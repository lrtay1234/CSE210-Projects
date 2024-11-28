using System;

class Program
{
    static void Main(string[] args)
    {
        
        Videos video1 = new Videos("Paul", "Dancing with the stars", 2.36);
        video1.AddComments("Alice", "Amazing work!!");
        video1.AddComments("Joe", "WOWWW!!");
        video1.AddComments("Bob", "spectacular!!");




        Videos video2 = new Videos("Billy ", "Cars and cars", 12.43);
        video2.AddComments("Billy", "I love the Bugatti!!");
        video2.AddComments("Mamie", "Vroom Vroom!!");
        video2.AddComments("Emma", "Wow, just wow!!");


        Videos video3 = new Videos("Donavan", "Jumping hoops", 5.20);
        video3.AddComments("Melissa", "They are so fast!!");
        video3.AddComments("Leslie", "I could never do that!");
        video3.AddComments("Jeff", "Now that is talent!");


        // this will store all the videos
        List<Videos> videos = new List<Videos>{video1, video2, video3};

        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }

        
        
    }
}

