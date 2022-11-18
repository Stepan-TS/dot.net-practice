﻿using System.Text;

int scoreOfUser = 0;
int scoreOfComputer = 0;
int quite = 5;

//Console.WriteLine("Hello!" + "\n"
//    + "Let's play a game!" + "\n"
//    + "You have 3 options available('rock','paper','scissors')" 
//    + "\n" + "You can choose one of them!"
//    + "\n" + "If you want to over this game, enter 'end' please!");

StringBuilder builder = new StringBuilder();
builder.AppendLine("Hello!")
    .AppendLine("Let's play a game!")
    .AppendLine("You have 3 options available('rock','paper','scissors')")
    .AppendLine("You can choose one of them!")
    .AppendLine("If you want to over this game, enter 'end' please!");
string message = builder.ToString();
Console.WriteLine(message);

while (true)
{
    string value = Console.ReadLine();

        if (value == "rock")
        {
            Console.WriteLine("Draw!!!Let's try again");
        }
        else if(value == "paper")
        {
            scoreOfUser++;
            Console.WriteLine("Congratulations, you won!Let's try again");
        }
        else if(value == "scissors")
        {
            scoreOfComputer++;
            Console.WriteLine("You lost! Let's try again!");
        }
        else if(value == "end")
        {
            break;
        }
        else
        {
            Console.WriteLine("Something wrong! Please, choose one of options available!");
        }
    Console.WriteLine("scoreOfUser: " + scoreOfUser + "\n" + "scoreOfComputer: " + scoreOfComputer);
}

Console.WriteLine("Finaly score: " + "\n" + "scoreOfUser: " + scoreOfUser + "\n" + "scoreOfComputer: " + scoreOfComputer);
