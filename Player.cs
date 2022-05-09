using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPSLS 
{ 

public class Player
{
    //member variables
    public string name;
    public string choice;
    public int score;
    //constructor
    public Player(string name, string choice, int score)
    {


        this.name = name;
        this.choice = choice;
        this.score = score;
    }
    // member methods
    public void IsRock() 
    {
        choice = "rock";
    }
    public void IsPaper()
    {
        choice = "paper";
    }
    public void IsScissors()
    {
        choice = "scissors";
    }
    public void IsLizard()
    {
        choice = "lizard";
    }
    public void IsSpock()
    {
        choice = "rock";
    }


}
}