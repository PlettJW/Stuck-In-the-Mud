using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StuckInTheMud
{
    class Program
    {
        static void Main(string[] args)
        {
           
           bool playing = true;
            string info, p1, p2; ;
            Random r = new Random();
            Console.WriteLine("Welcome to stuck in the Mud");//intro
                                                                //nickname entering outside of loop so it dosnt ask your name every time
            Console.WriteLine("P1 please enter your name or nickname.");//player 1 enteres there nickname hear
            p1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to stuck in the Mud");//clears but then keep's the title
            Console.WriteLine("P2 please enter your name or nickname.");//player 2 enter's there nackname hear
            p2 = Console.ReadLine();

            do
            {
                //resets variables so you can play again
                int d1 = 0, d2 = 0, d3 = 0, d4 = 0, d5 = 0, p1Score = 0, p2Score = 0;
                bool Rd1 = true, Rd2 = true, Rd3 = true, Rd4 = true, Rd5 = true, winner = false, noPoints = false, P1Turn = true;
               
                Console.Clear();
                Console.WriteLine("Welcome to stuck in the Mud");//clears again but still keep's the top title

                Console.WriteLine("press I for directions,Q to quite, and press any other key to play");

                info = Console.ReadLine().ToUpper();//for getting to the instructions or playing or quitting

                Console.Clear();

                if (info == "I")//if the wanted instrunctions
                {
                    Thread.Sleep(250);//adds cenematic effect
                    Console.WriteLine("The first player rolls all five dice. If any 2s or 5s are rolled, no points are scored for this throw.");//game instructions
                    Thread.Sleep(250);
                    Console.WriteLine("If no 2s or 5s are rolled, you will the total amount as points.");
                    Thread.Sleep(250);
                    Console.WriteLine("The 2s and 5s go away and the remaining dice are rolled, ");
                    Thread.Sleep(250);
                    Console.WriteLine("Again, if any 2s or 5s rolled, no points are scored. If there are no 2’s or 5s, the total will be added previous score.");
                    Thread.Sleep(250);
                    Console.WriteLine("Continue in this way until all the dice are “Stuck in the Mud.” then it will switch turns. the game goes to the first 100 points");
                    Thread.Sleep(250);
                    Console.WriteLine("");
                    Console.WriteLine("got it figured out, press enter when your ready to play.");

                    Console.ReadKey();
                    Console.Clear();
                }

                if (info == "Q")//if they want to quite
                {
                    playing = false;
                }

                if (playing )
                {
                    do
                    {
                        noPoints = false;//refreshes vairable for looping perposes

                        if (Rd1)// rolls all dice that arnt stuck in the mud
                        {
                            d1 = r.Next(1, 7);
                            Thread.Sleep(250);//adds cenamatic effect
                            Console.WriteLine("dice 1 = " + d1);
                            noPoints = false;
                        }

                        if (Rd2)
                        {
                            d2 = r.Next(1, 7);
                            Thread.Sleep(250);
                            Console.WriteLine("dice 2 = " + d2);
                            noPoints = false;
                        }

                        if (Rd3)
                        {
                            d3 = r.Next(1, 7);
                            Thread.Sleep(250);
                            Console.WriteLine("dice 3 = " + d3);
                            noPoints = false;
                        }

                        if (Rd4)
                        {
                            d4 = r.Next(1, 7);
                            Thread.Sleep(250);
                            Console.WriteLine("dice 4 = " + d4);
                            noPoints = false;
                        }

                        if (Rd5)
                        {
                            d5 = r.Next(1, 7);
                            Thread.Sleep(250);
                            Console.WriteLine("dice 5 = " + d5);
                            noPoints = false;
                        }//11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111

                        if (Rd1 && (d1 == 2 || d1 == 5))//if the dice is not already stuck in the mud and it rolls a 2 or 5, it gets stuck in the mud and you get no points that round
                        {
                            Rd1 = false;
                            noPoints = true;
                        }

                        if (Rd2 && (d2 == 2 || d2 == 5))
                        {
                            Rd2 = false;
                            noPoints = true;
                        }

                        if (Rd3 && (d3 == 2 || d3 == 5))

                        {
                            Rd3 = false;
                            noPoints = true;
                        }

                        if (Rd4 && (d4 == 2 || d4 == 5))
                        {
                            Rd4 = false;
                            noPoints = true;
                        }

                        if (Rd5 && (d5 == 2 || d5 == 5))
                        {
                            Rd5 = false;
                            noPoints = true;
                        }


                        if (!noPoints)//if no dice got stuck in the mud this round
                        {
                            if (P1Turn)//for p1 turn they get the points
                            {
                                if (Rd1)
                                    p1Score = p1Score + d1; //adds up dice that arnt stuck in the mud

                                if (Rd2)
                                    p1Score = p1Score + d2;

                                if (Rd3)
                                    p1Score = p1Score + d3;

                                if (Rd4)
                                    p1Score = p1Score + d4;

                                if (Rd5)
                                    p1Score = p1Score + d5;
                            }

                            if (!P1Turn)//on p2 turn they get the points
                            {
                                if (Rd1)
                                    p2Score = p2Score + d1;//adds up dice that arnt stuck ing the mud

                                if (Rd2)
                                    p2Score = p2Score + d2;

                                if (Rd3)
                                    p2Score = p2Score + d3;

                                if (Rd4)
                                    p2Score = p2Score + d4;

                                if (Rd5)
                                    p2Score = p2Score + d5;
                            }

                        }
                        Console.WriteLine("");
                        if (P1Turn == true)// says whos turn it is
                            Console.WriteLine(p1 + "'s Turn. ");
                        else
                            Console.WriteLine(p2 + "'s Turn. ");
                        Console.WriteLine("");

                        Console.WriteLine(p1 + "'s Total = " + p1Score);
                        Console.WriteLine(p2 + "'s Total = " + p2Score);//displays scores

                        if (P1Turn)// when player 1 gets stuck in the mud it unsticks dice and makes it p2 turn
                        {
                            if (!Rd1 && !Rd2 && !Rd3 && !Rd4 && !Rd5)
                            {
                                P1Turn = false;
                                Rd1 = true;
                                Rd2 = true;
                                Rd3 = true;
                                Rd4 = true;
                                Rd5 = true;
                            }



                        }

                        if (!P1Turn)//when player 2 gets stuck in the mud it unsticks all dice and makes i player 1's turn
                        {
                            if (!Rd1 && !Rd2 && !Rd3 && !Rd4 && !Rd5)
                            {
                                P1Turn = true;
                                Rd1 = true;
                                Rd2 = true;
                                Rd3 = true;
                                Rd4 = true;
                                Rd5 = true;
                            }

                        }

                        if (p1Score >= 100)//if player 1 getss over 100 they win
                        {
                            Console.Clear();
                            winner = true;
                            Console.WriteLine(p1 + " wins.");
                        }

                        if (p2Score >= 100)//if player 2 gets over 100 they win
                        {
                            Console.Clear();
                            winner = true;
                            Console.WriteLine(p2 + " wins.");
                        }

                        Console.ReadLine();
                        Console.Clear();
                    } while (!winner);//loops game until someone wins














                }


            } while (playing) ;//bring's you back to menu

            Console.WriteLine("Good Bye");
            Console.ReadKey();

        }
    }
}
