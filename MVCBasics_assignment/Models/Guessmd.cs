using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasics_assignment.Models
{
    public class Guessmd
    {
        public int Answer { get; set; }
        public List<int> guesses = new List<int>();
        public string msg { get; set; }

        public Guessmd()
        {
            Random random = new Random();
            Answer = random.Next(1, 100);
        }
        public void AddGuessNumber(int num)
        {
            if (num > Answer)
            {

                msg = "You guessed to high";
            }
            else if (num < Answer)
            {
                msg = " You guessed to low";
            }
            else if (num == Answer)
            {
                msg = "Wow you are correct !!!";
            }

            guesses.Add(num);
        }
    }
}