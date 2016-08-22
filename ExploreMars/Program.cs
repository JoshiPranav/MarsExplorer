using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExploreMars.BaseClasses;

namespace ExploreMars
{
    class Program
    {
        /// <summary>
        /// Execute starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Welcome to Mars explore program");
            Console.WriteLine("----------------------------------------------------------");
            bool isPlateauInError = true;
            IPlateau plateau = new Plateau();
            while (isPlateauInError)
            {
                try
                {
                    Console.WriteLine("Please enter plateau dimensions(eg: 5 5)");
                    string sPlDimensions = Console.ReadLine();
                    if (!String.IsNullOrEmpty(sPlDimensions))
                    {
                        string[] plateauDimensions = sPlDimensions.Split(' ');
                        if (plateauDimensions.Length == 2)
                        {
                            //Define the plateau with specific height and width based on user input.
                            plateau.Height = Convert.ToInt32(plateauDimensions[0]);
                            plateau.Width = Convert.ToInt32(plateauDimensions[1]);
                            isPlateauInError = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.Please enter valid plateau co-ordinates(eg: 5 5)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.Please enter valid plateau co-ordinates(eg: 5 5)");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid plateau dimensions");
                }
            }
            string continueFlag = "Y";
            do
            {
                try
                {
                    Console.WriteLine("Enter position of rover(eg: 1 2 E)");
                    string roverPosition = Console.ReadLine();
                    if (!String.IsNullOrEmpty(roverPosition))
                    {
                        string[] roverPos = roverPosition.Split(' ');
                        if (roverPos.Length == 3)
                        {
                            //Define the rover associated plateau, position, and initial direction
                            Rover rover = new Rover(plateau, new Position(Convert.ToInt32(roverPos[0]), Convert.ToInt32(roverPos[1])), Common.DirectionHelper(roverPos[2].ToUpper()));
                            Console.WriteLine("Enter the movements(eg: LMRLMR...)");
                            string movements = Console.ReadLine();
                            char[] movementArray = movements.ToCharArray();
                            List<char> commands = new List<char>(movementArray.Length);
                            for (int i = 0; i < movementArray.Length; i++)
                            {
                                commands.Add(movementArray[i]);
                            }
                            //EXECUTE ...
                            rover = rover.Execute(commands);
                            Console.WriteLine("Current position of the rover is : " + rover.RoverPosition.XPoisition + "," + rover.RoverPosition.YPosition + "," + rover.RoverDirection.getRoverDirection().ToString());
                            Console.WriteLine("Go to next rover? (Y/N) : ");
                            continueFlag = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.Please enter valid rover position(eg: 1 2 E)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.Please enter valid rover position(eg: 1 2 E)");
                    }
                }
                catch (Exception excp)
                {
                    Console.WriteLine("An error occurred: " + excp.Message);
                }
            } while (continueFlag.ToUpper() == "Y");
        }
    }
}
