using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UTS.WebGuessGame
{
    public class Game 
    {
        private Random random = new Random();
        private int number; 
        public int Attempts { get; private set; }
        public int Number { get => number; set => number = value; }

        public void Start()
        {
            Attempts = 0;
            Number = random.Next(1, 101);
        } 

        public Result Guess(int guess)
        { 
            Attempts++; 
            if (guess < Number)    
                return Result.TooLow; 
            else if (guess > Number)    
                return Result.TooHigh; 
            else    
                return Result.Correct; 
        } 
    }
}