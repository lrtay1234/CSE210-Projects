using System;
using System.Collections.Generic;
using System.IO;

// I did  get a lot of help from AI, explaination will be where I got help

public class ManageGoals
{
    public List<Goals> _goals;
    public int _score;

    public ManageGoals()
    {
        _goals = new List<Goals>();
        _score = 0;
    }

    public void Start()
    {
        // I actually found this on AI, make loops lots easier
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals ");
            Console.WriteLine("4. Show Score ");
            Console.WriteLine("5. Save goals ");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Quit");
            Console.Write("8 Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    RecordEvent();
                    break;

                case "3":
                    ListGoalDetails();
                    break;

                case "4":
                    DisplayPlayerInfo();
                    break;

                case "5":
                    SaveGoals();
                    break;

                case "6":
                    LoadGoals();
                    break;

                case "7":
                    running = false;       
                    break;
                default:
                    Console.WriteLine("Try again. ");
                    break;
                
            }
        }


    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalName()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Check List Goal ");
        Console.Write("Which one will you choose? (1-3) ");
        string choice2 = Console.ReadLine();

        // i stuck and got some help with AI here
        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Goal Desription: ");
        string description = Console.ReadLine();   
        Console.Write("Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice2)
        {
            // so not to toot my own horn I did do this one alone, but.. I did double check AI to see 
            // if i was right. I mostly, execpt the checklist, i did get help
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoals(name, description, points, target, bonus));
                break;   
            default:
                Console.WriteLine("Please try again. ");
                break;             
        } 
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            // I got help with AI here
            // its goign to get every goal listed, each one from every class.
            // it will then print 1. whatevr goal
            // the i + 1 just make it more neat, the program starts at 0, so you add one to make it better
            // _goal[this is the goal, in the array or list]
            // it will then get teh detail and share it
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        // this will no make the program be able to read the correct spot the user inputs
        // so the computer read 0 and the user sees 1 and puts 1
        // this will then -1 and thenthe computer will be able to read 0 :)
        int choice = int.Parse(Console.ReadLine()) - 1;
        // this make sure the user inputs the correct number, must be above 0 and below the number of goals.
        if (choice >= 0 && choice < _goals.Count)
        {
            //
            _goals[choice].RecordEvent();
            _score += _goals[choice]._points;
        }
        else
        {
        Console.WriteLine("Try Again. ");
        }

    }

    public void SaveGoals ()
    {
        // i did use AI to firgure our streamwriter
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_goals.Count);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals Saved. ");

    }

    public void LoadGoals()
    {
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            // I got a lot of help with AI right here
            // this jsut read the first two variables, score and goals count
            _score = int.Parse(reader.ReadLine());
            int goalCount = int.Parse(reader.ReadLine());
            _goals.Clear();
            for (int i = 0; i < goalCount; i++)
            {
                // I did need help udnerstanding to split the varibles
                string[] goalData = reader.ReadLine().Split('|');
                string goalType = goalData[0];
                // set the goal varible, but must be null
                Goals goal = null;
                switch (goalType)
                {
                    case "SimpleGoal": // i did use AI to get the int.parse on goalData
                        goal = new SimpleGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                        // used AI to know how to put in this alst variable
                        ((SimpleGoal)goal)._isComplete = bool.Parse(goalData[4]);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                        // we dont need to put iscomplete because it wont ever be complete
                        break;
                    case "CheckListGoals":
                        goal = new CheckListGoals(goalData[1], goalData[2], int.Parse(goalData[3]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                        
                        ((CheckListGoals)goal)._amountCompleted = int.Parse(goalData[6]);
                        break;
                    default:
                        Console.WriteLine("Please Try Again. ");
                        break;
                }
                // I did use AI, because it was acting weird until I foudn out i needed this
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Loaded Successfully. ");

    }
}