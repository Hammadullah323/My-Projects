using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static char[] myarr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] myarr2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        static char[] myarr3 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q' };
        static int player = 1;
        static int Markchoice;
        static int flag = 0; // 1 = win, -1 = draw , 0 = still playing
        static void Main(string[] args)
        {
            while (true)
            {
                ResetBoard();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t----------Welcome to Tic-Tac-Toe Game----------");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\tEnter the level that you want to play...");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t-----------------------------------------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t     1.EASY       2.MEDIUM        3.HARD");
                Console.WriteLine();
                Console.SetCursorPosition(29, Console.CursorTop);
                Console.ResetColor();
                int levchoice = int.Parse(Console.ReadLine());
                switch (levchoice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t----------------------LEVEL 1:-------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t-----------------------EASY----------------------");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.WriteLine("\t\t\t\tPlayer 1 : 'X' and Player 2 : 'Z'");
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            if (player % 2 == 0)
                            {
                                // Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 2 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                //Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 1 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            Console.WriteLine("\n");
                            Board();
                            Markchoice = int.Parse(Console.ReadLine());
                            if (myarr[Markchoice] != 'X' && myarr[Markchoice] != 'Z')
                            {
                                if (player % 2 == 0)
                                {
                                    myarr[Markchoice] = 'Z';
                                    player++;
                                }
                                else
                                {
                                    myarr[Markchoice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t----->  The row {0} is already marked with {1}", Markchoice, myarr[Markchoice]);
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\t----->   Please wait 2 second board is loading again.....");
                                Console.ResetColor();
                                Thread.Sleep(2000);
                            }
                            flag = CheckWin();
                        } while (flag != 1 && flag != -1);
                        Console.Clear();
                        Board();
                        if (flag == 1)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tCongragulations");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tPlayer {0} has won", (player % 2) + 1);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tOOPS!!");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tDRAW");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                        }



                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t----------------------LEVEL 2:-------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t-----------------------MEDIUM--------------------");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.WriteLine("\t\t\t\tPlayer 1 : 'X' and Player 2 : 'Z'");
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            if (player % 2 == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 2 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 1 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            Console.WriteLine("\n");
                            drawBoard();
                            Markchoice = int.Parse(Console.ReadLine());
                            if (myarr2[Markchoice] != 'X' && myarr2[Markchoice] != 'Z')
                            {
                                if (player % 2 == 0)
                                {
                                    myarr2[Markchoice] = 'Z';
                                    player++;
                                }
                                else
                                {
                                    myarr2[Markchoice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t----->  The row {0} is already marked with {1}", Markchoice, myarr2[Markchoice]);
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\t----->   Please wait 2 second board is loading again.....");
                                Console.ResetColor();
                                Thread.Sleep(2000);
                            }
                            flag = CheckWinmed();
                        } while (flag != 1 && flag != -1);
                        Console.Clear();
                        drawBoard();
                        if (flag == 1)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tCongragulations");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tPlayer {0} has won", (player % 2) + 1);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tOOPS!!");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tDRAW");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                        }


                        break;


                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t----------------------LEVEL 3:-------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t-----------------------HARD----------------------");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.WriteLine("\t\t\t\tPlayer 1 : 'X' and Player 2 : 'Z'");
                            Console.WriteLine("\t\t\t-------------------------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            if (player % 2 == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 2 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t\t\t\tPlayer 1 Chance");
                                Console.WriteLine("\t\t\t-------------------------------------------------");
                                Console.ResetColor();
                            }
                            Console.WriteLine("\n");
                            initializeBoard();
                            Markchoice = int.Parse(Console.ReadLine());
                            if (myarr3[Markchoice] != 'X' && myarr3[Markchoice] != 'Z')
                            {
                                if (player % 2 == 0)
                                {
                                    myarr3[Markchoice] = 'Z';
                                    player++;
                                }
                                else
                                {
                                    myarr3[Markchoice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t----->  The row {0} is already marked with {1}", Markchoice, myarr3[Markchoice]);
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\t----->   Please wait 2 second board is loading again.....");
                                Console.ResetColor();
                                Thread.Sleep(2000);
                            }
                            flag = CheckWinadv();
                        } while (flag != 1 && flag != -1);
                        Console.Clear();
                        initializeBoard();
                        if (flag == 1)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tCongragulations");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\tPlayer {0} has won", (player % 2) + 1);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t-----------------------------");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tOOPS!!");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\tDRAW");
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t----------------------------------");
                            Console.ResetColor();
                        }





                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("\t\t\t---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\tDo you want to continue or not? Y/S");
                Console.ResetColor();
                Console.SetCursorPosition(30, Console.CursorTop);
                char stchoice = char.Parse(Console.ReadLine());
                if (stchoice == 'S')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t\t\t\tGame stopped");
                    Console.ResetColor();
                }
                Console.ReadKey();
            }
        }
        private static void ResetBoard()
        {
            myarr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            myarr2 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            myarr3 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q' };
            int player = 1;
            flag = 0;
        }
        private static void Board()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t     |     |      ");
            Console.WriteLine("\t\t\t\t\t  {0}  |  {1}  |  {2}", myarr[1], myarr[2], myarr[3]);
            Console.WriteLine("\t\t\t\t\t_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t\t     |     |      ");
            Console.WriteLine("\t\t\t\t\t  {0}  |  {1}  |  {2}", myarr[4], myarr[5], myarr[6]);
            Console.WriteLine("\t\t\t\t\t_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t\t     |     |      ");
            Console.WriteLine("\t\t\t\t\t  {0}  |  {1}  |  {2}", myarr[7], myarr[8], myarr[9]);
            Console.WriteLine("\t\t\t\t\t     |     |      ");
            Console.SetCursorPosition(29, Console.CursorTop);
            Console.ResetColor();
        }
        private static void drawBoard()
        {
            Console.WriteLine("\t\t\t------------------------------------------------");
            Console.WriteLine("\t\t\tA = 10, B = 11, C = 12, D = 13, E = 14 and so on");
            Console.WriteLine("\t\t\t------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  ", myarr2[1], myarr2[2], myarr2[3], myarr2[4]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____      ");
            Console.WriteLine("\t\t\t\t     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  ", myarr2[5], myarr2[6], myarr2[7], myarr2[8]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  ", myarr2[9], myarr2[10], myarr2[11], myarr2[12]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  ", myarr2[13], myarr2[14], myarr2[15], myarr2[16]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |      ");
            Console.SetCursorPosition(29, Console.CursorTop);
            Console.ResetColor();
        }
        private static void initializeBoard()
        {
            Console.WriteLine("\t\t\t------------------------------------------------");
            Console.WriteLine("\t\t\tA = 10, B = 11, C = 12, D = 13, E = 14 and so on");
            Console.WriteLine("\t\t\t------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  |  {4}  ", myarr3[1], myarr3[2], myarr3[3], myarr3[4], myarr3[5]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____|_____      ");
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  |  {4}  ", myarr3[6], myarr3[7], myarr3[8], myarr3[9], myarr3[10]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____|_____      ");
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  |  {4}  ", myarr3[11], myarr3[12], myarr3[13], myarr3[14], myarr3[15]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  |  {4}  ", myarr3[16], myarr3[17], myarr3[18], myarr3[19], myarr3[20]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.WriteLine("\t\t\t\t  {0}  |  {1}  |  {2}  |  {3}  |  {4}  ", myarr3[21], myarr3[22], myarr3[23], myarr3[24], myarr3[25]);
            Console.WriteLine("\t\t\t\t_____|_____|_____|_____|_____ ");
            Console.WriteLine("\t\t\t\t     |     |     |     |      ");
            Console.SetCursorPosition(29, Console.CursorTop);
            Console.ResetColor();
        }

        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (myarr[1] == myarr[2] && myarr[2] == myarr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (myarr[4] == myarr[5] && myarr[5] == myarr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (myarr[7] == myarr[8] && myarr[8] == myarr[9])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (myarr[1] == myarr[4] && myarr[4] == myarr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (myarr[2] == myarr[5] && myarr[5] == myarr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (myarr[3] == myarr[6] && myarr[6] == myarr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (myarr[1] == myarr[5] && myarr[5] == myarr[9])
            {
                return 1;
            }
            else if (myarr[3] == myarr[5] && myarr[5] == myarr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (myarr[1] != '1' && myarr[2] != '2' && myarr[3] != '3' && myarr[4] != '4' && myarr[5] != '5' && myarr[6] != '6' && myarr[7] != '7' && myarr[8] != '8' && myarr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        private static int CheckWinmed()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (myarr2[1] == myarr2[2] && myarr2[2] == myarr2[3] && myarr2[3] == myarr2[4])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (myarr2[5] == myarr2[6] && myarr2[6] == myarr2[7] && myarr2[7] == myarr2[8])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (myarr2[9] == myarr2[10] && myarr2[10] == myarr2[11] && myarr2[11] == myarr2[12])
            {
                return 1;
            }
            //Winning Condition For Fourth Row
            else if (myarr2[13] == myarr2[14] && myarr2[14] == myarr2[15] && myarr2[15] == myarr2[16])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (myarr2[1] == myarr2[5] && myarr2[5] == myarr2[9] && myarr2[9] == myarr2[13])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (myarr2[2] == myarr2[6] && myarr2[6] == myarr2[10] && myarr2[10] == myarr2[14])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (myarr2[3] == myarr2[7] && myarr2[7] == myarr2[11] && myarr2[11] == myarr2[15])
            {
                return 1;
            }
            //Winning Condition For Fourth Column
            else if (myarr2[4] == myarr2[8] && myarr2[8] == myarr2[12] && myarr2[12] == myarr2[16])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (myarr2[1] == myarr2[6] && myarr2[6] == myarr2[11] && myarr2[11] == myarr2[16])
            {
                return 1;
            }
            else if (myarr2[4] == myarr2[7] && myarr2[7] == myarr2[10] && myarr2[10] == myarr2[13])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (myarr2[1] != '1' && myarr2[2] != '2' && myarr2[3] != '3' && myarr2[4] != '4' && myarr2[5] != '5' && myarr2[6] != '6' && myarr2[7] != '7' && myarr2[8] != '8' && myarr2[9] != '9' && myarr2[10] != 'A' && myarr2[11] != 'B' && myarr2[12] != 'C' && myarr2[13] != 'D' && myarr2[14] != 'E' && myarr2[15] != 'F' && myarr2[16] != 'G')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
        private static int CheckWinadv()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (myarr3[1] == myarr3[2] && myarr3[2] == myarr3[3] && myarr3[3] == myarr3[4] && myarr3[4] == myarr3[5])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (myarr3[6] == myarr3[7] && myarr3[7] == myarr3[8] && myarr3[8] == myarr3[9] && myarr3[9] == myarr3[10])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (myarr3[11] == myarr3[12] && myarr3[12] == myarr3[13] && myarr3[13] == myarr3[14] && myarr3[14] == myarr3[15])
            {
                return 1;
            }
            //Winning Condition For Fourth Row
            else if (myarr3[16] == myarr3[17] && myarr3[17] == myarr3[18] && myarr3[18] == myarr3[19] && myarr3[19] == myarr3[20])
            {
                return 1;
            }
            //Winning Condition For Fifth Row
            else if (myarr3[21] == myarr3[22] && myarr3[22] == myarr3[23] && myarr3[23] == myarr3[24] && myarr3[24] == myarr3[25])
            {
                return 1;
            }

            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (myarr3[1] == myarr3[6] && myarr3[6] == myarr3[11] && myarr3[11] == myarr3[16] && myarr3[16] == myarr3[21])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (myarr3[2] == myarr3[7] && myarr3[7] == myarr3[12] && myarr3[12] == myarr3[17] && myarr3[17] == myarr3[22])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (myarr3[3] == myarr3[8] && myarr3[8] == myarr3[13] && myarr3[13] == myarr3[18] && myarr3[18] == myarr3[23])
            {
                return 1;
            }
            //Winning Condition For Fourth Column
            else if (myarr3[4] == myarr3[9] && myarr3[9] == myarr3[14] && myarr3[14] == myarr3[19] && myarr3[19] == myarr3[24])
            {
                return 1;
            }
            //Winning Condition For Fifth Column
            else if (myarr3[5] == myarr3[10] && myarr3[10] == myarr3[15] && myarr3[15] == myarr3[20] && myarr3[20] == myarr3[25])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (myarr3[1] == myarr3[7] && myarr3[7] == myarr3[13] && myarr3[13] == myarr3[19] && myarr3[19] == myarr3[25])
            {
                return 1;
            }
            else if (myarr3[5] == myarr3[9] && myarr3[9] == myarr3[13] && myarr3[13] == myarr3[17] && myarr3[17] == myarr3[21])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (myarr3[1] != '1' && myarr3[2] != '2' && myarr3[3] != '3' && myarr3[4] != '4' && myarr3[5] != '5' && myarr3[6] != '6' && myarr3[7] != '7' && myarr3[8] != '8' && myarr3[9] != '9' && myarr3[10] != 'A' && myarr3[11] != 'B' && myarr3[12] != 'C' && myarr3[13] != 'D' && myarr3[14] != 'E' && myarr3[15] != 'F' && myarr3[16] != 'G'
                && myarr3[17] != 'H' && myarr3[18] != 'I' && myarr3[19] != 'J' && myarr3[20] != 'K' && myarr3[21] != 'L' && myarr3[22] != 'M' && myarr3[23] != 'N' && myarr3[24] != 'O' && myarr3[25] != 'P' && myarr3[26] != 'Q')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }

        }
    }
}
