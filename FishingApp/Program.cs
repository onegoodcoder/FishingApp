using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for username 
            
            //printing welcome mesage
            Console.WriteLine("**********************************************Welcome to the fishing game***************************");

           //asking user what their name is
           Console.WriteLine("what is your username");

            //making a varible called userName and capturing the data from the user
            string userInput = Console.ReadLine();
            
            //printing the varible
            Console.WriteLine("hello " + userInput);

            #endregion

            #region create player object and set score to 0
            //created a new instance and set the username 
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;

            Console.WriteLine("player1 username " + player1.Username);
            Console.WriteLine("player1 Score " + player1.Score);
            #endregion



            GameEngine game = new GameEngine();
            Fish fish1 = game.CatchFish();

            Console.WriteLine("fish 1 fishType " + fish1.FishType);
            Console.WriteLine("fish1 points " + fish1.Points);

            player1.Score = player1.Score + fish1.Points;
            Console.WriteLine("player1 Score " + player1.Score);


            Fish fish2 = game.CatchFish();

            Console.WriteLine("fish 2 fishType " + fish2.FishType);
            Console.WriteLine("fish 2 points " + fish2.Points);

            player1.Score = player1.Score + fish2.Points;
            Console.WriteLine("player1 Score " + player1.Score);

        }
    }

}
