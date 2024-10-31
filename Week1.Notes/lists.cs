// this must be called to use lists at the top
using System.Collections.Generic;


// proper way to declare variables
List<int> numbers;
List<string> words;


// 
List<int> numbers = new List<int>();
List<string> words = new List<string>();



// this is how you call and "add" do a list
List<string> words = new List<string>();

words.Add("phone");
words.Add("keyboard");
words.Add("mouse");


// this is how you can see how big the list is with "count".
Console.WriteLine(words.Count);


// this is how you look through the loop
foreach (string word in words)
{
    Console.WriteLine(word);
}


// counts the index of each variable in the list
for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}

