using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", @"This activity will help you relax 
    by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void PeformActivity()
    {
 
            for (int i = 0; i < _duration / 6; i++)
            {
                Console.Write("Breathe in... ");
                ShowCountDown(3);
                
                Console.Write("Breathe out... ");
                ShowCountDown(6);
            }

        
    }

    public override void Run()
    {
        DisplayStartingMessage();
        PeformActivity();
        DisplayEndingMessage();
        
    }


}