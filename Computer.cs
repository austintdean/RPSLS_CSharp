using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  

        public class Computer : Player
        {

            public Computer(string name, string choice, int score)
                    : base(name, choice, score)
            {
                this.name = name;
                this.choice = choice;
                this.score = score;



            }

        public void ComputerChoice()
        {
            List<string> choices = new List<string>();





        }
    
}
