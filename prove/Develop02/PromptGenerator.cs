using System;
using System.Collections.Generic;

class PromptGenerator
{

    public string GetRandomPrompt()
    {
        string[] questions = {
            "What scripture did you study today? ",
            "What was something you saw happen that was funny today? ",
            "What was the most beautiful thing you saw today? ",
            "Name three good things about your day. ",
            "What was your favorite part of the day? ",
        };   




        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(questions.Length);
        string randomPrompt = questions[randomIndex];
        return randomPrompt;



        
    }
}