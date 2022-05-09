using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPSLS 
{ 


public class Human : Player 
{

    public Human(string name, string choice, int score) 
            : base(name, choice, score)
    {
        this.name = name;
        this.choice = choice;
        this.score = score;



    }


    



}
}