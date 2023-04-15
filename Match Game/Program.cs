Console.ForegroundColor = ConsoleColor.DarkCyan;           
            
            ConsoleKeyInfo enter;
            int y, x, randomLetter, high_Score, high_Score_y, high_score_player_point = 0, array_variable;
            string high_score_player_name = "";
            int ctrlTurn = 0;
            Random r = new Random();
            int Player1_Point = 120;
            int Player2_Point = 120;

            char[] A1 = new char[15];     // We introduce 3 arrays from which we will print the letters.
            char[] A2 = new char[15];
            char[] A3 = new char[15];
            char[] letters = new char[] { 'D', 'E', 'U' };     
           
            Console.SetCursorPosition(1, 2);      
            Console.WriteLine("A1: ");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("A2: ");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine("A3: ");

            for (int i = 1; i <= 18; i++)       // We print horizontal lines of the game screen with for loops.
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine("-");
            }

            for (int i = 1; i <= 18; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.WriteLine("-");
            }

            Console.SetCursorPosition(19, 1);    // We print the vertical lines and corners of the game screen.
            Console.WriteLine("+");
            Console.SetCursorPosition(19, 5);
            Console.WriteLine("+");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("+");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("+");
            Console.SetCursorPosition(19, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(19, 3);
            Console.WriteLine("|");
            Console.SetCursorPosition(19, 4);
            Console.WriteLine("|");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("|");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("|");

            Console.SetCursorPosition(25, 1);     // Before the game starts, we show the player rank and player points to the players.
            Console.WriteLine("Turn: Player1");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Player1: " + Player1_Point);
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("Player2: " + Player2_Point);
            Console.SetCursorPosition(60, 1);
            Console.WriteLine("Welcome to DEU game.");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Please press enter to play game.");   // The game progresses by pressing enter.

            while (true)      // We open a "while" loop to check the operation of the game.
            {
                if (Console.KeyAvailable)
                {
                    enter = Console.ReadKey(true);
                    if (enter.Key == ConsoleKey.Enter)
                    {
                        y = r.Next(1, 4);     // We print a random letter on a random line.
                        x = 0;
                        if (y == 1 && x <= 14)     // We check the line where the letter is printed and accordingly we check the DEU writing states.
                        {
                            randomLetter = r.Next(0, 3);
                            
                            if (x <= 14)     // We start printing letters from the left.
                            {
                                while (A1[x] != 0)
                                {                                   
                                    x++;
                                    if (x > 14)
                                        break;
                                }
                                if (x <= 14)
                                {
                                    A1[x] = letters[randomLetter];
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.Write(A1[x]);
                                    ctrlTurn++;
                                }
                            }  
                            
                            if (A1[0] == 'D')     // We also check if the letter is in the first or second place.
                            {
                                if (A2[0] == 'E' && A3[0] == 'U')  // Vertical DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;    // If it provides the DEU, we print it in color.
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)      // Here we show the winning player.
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;     
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                } 
                                else if (A1[1] == 'E' && A1[2] == 'U')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[1] == 'E' && A3[2] == 'U')     // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else    // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[0] == 'E')   // We also check if the letter is in the first or second place.
                            {
                                if (ctrlTurn % 2 == 0)
                                {
                                    Player2_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player1");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }
                                else if (ctrlTurn % 2 == 1)
                                {
                                    Player1_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player2");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }

                            }
                              
                            else if (A1[0] == 'U')   // We also check if the letter is in the first or second place.
                            {
                                if (A2[0] == 'E' && A3[0] == 'D')   // Vertical, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[1] == 'E' && A1[2] == 'D')  // Horizontal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[1] == 'E' && A3[2] == 'D')    // Diagonal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else   // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[1] == 'D')   // We also check if the letter is in the first or second place.
                            {
                                if (A2[2] == 'E' && A3[3] == 'U')   // Vertical DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[2] == 'E' && A1[3] == 'U')    // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else   // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }
                            
                            else if (A1[1] == 'U')   // We also check if the letter is in the first or second place.
                            {
                                if (A2[2] == 'E' && A3[3] == 'D')   // Vertical, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[2] == 'E' && A1[3] == 'D')   // Horizontal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 13 && x > 1 && A1[x] == 'D')
                            {
                                if (A2[x] == 'E' && A3[x] == 'U')  // Vertical DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 4, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y + 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x + 1] == 'E' && A1[x + 2] == 'U')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x - 1] == 'E' && A1[x - 2] == 'U')  // Horizontal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                                
                                else if (A2[x + 1] == 'E' && A3[x + 2] == 'U')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A3[x - 2] == 'U')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 3, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else   // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 14 && x > 0 && A1[x] == 'E')
                            {                                
                                if (A1[x - 1] == 'D' && A1[x + 1] == 'U')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x - 1] == 'U' && A1[x + 1] == 'D')  // Horizontal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 13 && x > 1 && A1[x] == 'U')
                            {
                                if (A2[x] == 'E' && A3[x] == 'D')   // Vertical, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 4, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y + 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x + 1] == 'E' && A1[x + 2] == 'D')  // Vertical, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x - 1] == 'E' && A1[x - 2] == 'D')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                                
                                else if (A2[x + 1] == 'E' && A3[x + 2] == 'D')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A3[x - 2] == 'D')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 3, y + 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[13] == 'D')   // We also check if the letter is at the end or in the fourteenth.
                            {
                                if (A2[12] == 'E' && A3[11] == 'U')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[12] == 'E' && A1[11] == 'U')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else   // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[13] == 'U')   // We also check if the letter is at the end or in the fourteenth.
                            {
                                if (A2[12] == 'E' && A3[11] == 'D')   // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[12] == 'E' && A1[11] == 'D')  // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[14] == 'D')   // We also check if the letter is at the end or in the fourteenth.
                            {
                                if (A2[14] == 'E' && A3[14] == 'U')  // Vertical DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[13] == 'E' && A1[12] == 'U')  // Horizontal, reverse DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[13] == 'E' && A3[12] == 'U')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A1[14] == 'E')   // We also check if the letter is at the end or in the fourteenth.
                            {
                                if (ctrlTurn % 2 == 0)
                                {
                                    Player2_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player1");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }
                                else if (ctrlTurn % 2 == 1)
                                {
                                    Player1_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player2");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }

                            }
                            
                            else if (A1[14] == 'U')   // We also check if the letter is at the end or in the fourteenth.
                            {

                                if (A2[14] == 'E' && A3[14] == 'D')   // Vertical DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[13] == 'E' && A1[12] == 'D')   // Horizontal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(17, 2);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[13] == 'E' && A3[12] == 'D')  // Diagonal DEU probability.
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else  // If neither, the player's score is reduced by 5.
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                        }

                        if (y == 2 && x <= 14)   // We check the line where the letter is printed and accordingly we check the DEU writing states.
                        {                       // We apply the same procedures as above for this step as well.
                            randomLetter = r.Next(0, 3);
                            
                            if (x <= 14)
                            {
                                while (A2[x] != 0)
                                {
                                    x++;
                                    if (x > 14)
                                        break;
                                }
                                if (x <= 14)
                                {
                                    A2[x] = letters[randomLetter];
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.Write(A2[x]);
                                    ctrlTurn++;
                                }
                            }
                            if (A2[0] == 'D')
                            {                               
                                if (A2[1] == 'E' && A2[2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[0] == 'U')
                            {                               
                                if (A2[1] == 'E' && A2[2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[0] == 'E')
                            {
                                if (A1[0] == 'D' && A3[0] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[0] == 'U' && A3[0] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[1] == 'D')
                            {
                                if (A2[2] == 'E' && A2[3] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }
                           
                            else if (A2[1] == 'U')
                            {
                                if (A2[2] == 'E' && A2[3] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }

                            }

                            else if (x < 13 && x > 1 && A2[x] == 'D')
                            {                                
                                if (A2[x + 1] == 'E' && A2[x + 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A2[x - 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                               
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 14 && x > 0 && A2[x] == 'E')
                            {
                                if (A2[x - 1] == 'D' && A2[x + 1] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'U' && A2[x + 1] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x] == 'D' && A3[x] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 4, y + 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x] == 'U' && A3[x] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 4, y + 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x - 1] == 'D' && A3[x + 1] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x - 1] == 'U' && A3[x + 1] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x + 1] == 'D' && A3[x - 1] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 2);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[x + 1] == 'U' && A3[x - 1] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 2);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 13 && x > 1 && A1[x] == 'U')
                            {
                                if (A2[x + 1] == 'E' && A2[x + 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A2[x - 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                                
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[13] == 'D')
                            {
                                if (A2[12] == 'E' && A2[11] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[13] == 'U')
                            {
                                if (A2[12] == 'E' && A2[11] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[14] == 'D')
                            {                                
                                if (A2[13] == 'E' && A2[12] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[14] == 'U')
                            {                               
                                if (A2[13] == 'E' && A2[12] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A2[14] == 'E')
                            {
                                if (A1[14] == 'D' && A3[14] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A1[14] == 'U' && A3[14] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }



                            }
                        }
                        if (y == 3 && x <= 14)   // We check the line where the letter is printed and accordingly we check the DEU writing states.
                        {                       // We apply the same procedures as above for this step as well.
                            randomLetter = r.Next(0, 3);
                            
                            if (x <= 14)
                            {
                                while (A3[x] != 0)
                                {
                                    x++;
                                    if (x > 14)
                                        break;
                                }
                                if (x <= 14)
                                {
                                    A3[x] = letters[randomLetter];
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.Write(A3[x]);
                                    ctrlTurn++;
                                }
                            }
                            if (A3[0] == 'D')
                            {
                                if (A2[0] == 'E' && A1[0] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[1] == 'E' && A3[2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[1] == 'E' && A1[2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[0] == 'E')
                            {
                                if (ctrlTurn % 2 == 0)
                                {
                                    Player2_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player1");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }
                                else if (ctrlTurn % 2 == 1)
                                {
                                    Player1_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player2");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }

                            }

                            else if (A3[0] == 'U')
                            {
                                if (A2[0] == 'E' && A1[0] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(4, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(4, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[1] == 'E' && A3[2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[1] == 'E' && A1[2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(4, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(5, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(6, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[1] == 'D')
                            {
                                 if (A2[2] == 'E' && A1[3] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[2] == 'E' && A3[3] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[1] == 'U')
                            {
                                if (A2[2] == 'E' && A1[3] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(6, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[2] == 'E' && A3[3] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(5, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(6, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(7, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 13 && x > 1 && A3[x] == 'D')
                            {
                                if (A2[x] == 'E' && A1[x] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 4, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y - 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[x + 1] == 'E' && A3[x + 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[x - 1] == 'E' && A3[x - 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                               
                                else if (A2[x + 1] == 'E' && A1[x + 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y - 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A1[x - 2] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 3, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y - 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 14 && x > 0 && A3[x] == 'E')
                            {
                                if (A3[x - 1] == 'D' && A3[x + 1] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[x - 1] == 'U' && A3[x + 1] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (x < 13 && x > 1 && A3[x] == 'U')
                            {
                                if (A2[x] == 'E' && A1[x] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 4, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 4, y - 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[x + 1] == 'E' && A3[x + 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[x - 1] == 'E' && A3[x - 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 3, y + 1);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y + 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }                                                                
                                else if (A2[x + 1] == 'E' && A1[x + 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 5, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 6, y - 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[x - 1] == 'E' && A1[x - 2] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(x + 4, y + 1);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(x + 3, y);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(x + 2, y - 1);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[13] == 'D')
                            {
                                if (A2[12] == 'E' && A1[11] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[12] == 'E' && A3[11] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[13] == 'U')
                            {
                                if (A2[12] == 'E' && A1[11] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(16, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[12] == 'E' && A3[11] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(15, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[14] == 'D')
                            {
                                if (A2[14] == 'E' && A1[14] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[13] == 'E' && A3[12] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[13] == 'E' && A1[12] == 'U')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("D");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("U");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }

                            else if (A3[14] == 'E')
                            {
                                if (ctrlTurn % 2 == 0)
                                {
                                    Player2_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player1");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }
                                else if (ctrlTurn % 2 == 1)
                                {
                                    Player1_Point -= 5;
                                    Console.SetCursorPosition(25, 1);
                                    Console.WriteLine("Turn: Player2");
                                    Console.SetCursorPosition(25, 4);
                                    Console.WriteLine("Player1: " + Player1_Point + " ");
                                    Console.SetCursorPosition(40, 4);
                                    Console.WriteLine("Player2: " + Player2_Point + " ");
                                }

                            }

                            else if (A3[14] == 'U')
                            {
                                if (A2[14] == 'E' && A1[14] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(18, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(18, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A3[13] == 'E' && A3[12] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(17, 4);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 4);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else if (A2[13] == 'E' && A1[12] == 'D')
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(18, 4);
                                    Console.WriteLine("U");
                                    Console.SetCursorPosition(17, 3);
                                    Console.WriteLine("E");
                                    Console.SetCursorPosition(16, 2);
                                    Console.WriteLine("D");
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player2 won. Point: " + Player2_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(1, 7);
                                        Console.WriteLine("Player1 won. Point: " + Player1_Point);
                                        Console.SetCursorPosition(60, 3);
                                        Console.WriteLine("Please press space to see high score table.");

                                    }
                                }
                                else
                                {
                                    if (ctrlTurn % 2 == 0)
                                    {
                                        Player2_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player1");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                    else if (ctrlTurn % 2 == 1)
                                    {
                                        Player1_Point -= 5;
                                        Console.SetCursorPosition(25, 1);
                                        Console.WriteLine("Turn: Player2");
                                        Console.SetCursorPosition(25, 4);
                                        Console.WriteLine("Player1: " + Player1_Point + " ");
                                        Console.SetCursorPosition(40, 4);
                                        Console.WriteLine("Player2: " + Player2_Point + " ");
                                    }
                                }
                            }
                        }                       
                    }
                    if (enter.Key == ConsoleKey.Spacebar)   // Pressing the "spacebar" key shows the High Score-Table.
                    {
                        Console.Clear();    // We create two arrays for the names and scores of the people on the High-Score Table.
                        string[] names = new string[] { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = new int[] { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };

                        for (high_Score = 0; high_Score <= 11; high_Score++)
                            Console.WriteLine(names[high_Score]);
                        for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                        {
                            Console.SetCursorPosition(10, high_Score_y);
                            Console.WriteLine(scores[high_Score]);
                        }

                        if (ctrlTurn % 2 == 1)    // Whoever wins, her score is compared with the other scores on the table.
                        {
                            high_score_player_point = Player1_Point;
                            high_score_player_name = "Player1";
                        }
                        else if (ctrlTurn % 2 == 0)
                        {
                            high_score_player_point = Player2_Point;
                            high_score_player_name = "Player2";
                        }
                        // According to the score earned by the player, her name and score are written in the appropriate place on the table.
                        if (high_score_player_point > 100)  
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 1; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[0] = high_score_player_name;
                            scores[0] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 100)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 3; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[2] = high_score_player_name;
                            scores[2] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 95)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 4; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[3] = high_score_player_name;
                            scores[3] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 90)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 5; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[4] = high_score_player_name;
                            scores[4] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 85)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 6; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[5] = high_score_player_name;
                            scores[5] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 80 || high_score_player_point == 75)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 8; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[7] = high_score_player_name;
                            scores[7] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point <= 70 && high_score_player_point > 55)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 9; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[8] = high_score_player_name;
                            scores[8] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point == 55)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 10; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[9] = high_score_player_name;
                            scores[9] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }

                        }

                        else if (high_score_player_point <= 50 && high_score_player_point > 30)
                        {
                            Console.Clear();
                            for (array_variable = 11; array_variable >= 11; array_variable--)
                            {
                                names[array_variable] = names[array_variable - 1];
                                scores[array_variable] = scores[array_variable - 1];
                            }
                            names[10] = high_score_player_name;
                            scores[10] = high_score_player_point;

                            for (high_Score = 0; high_Score <= 11; high_Score++)
                                Console.WriteLine(names[high_Score]);
                            for (high_Score = 0, high_Score_y = 0; high_Score <= 11; high_Score++, high_Score_y++)
                            {
                                Console.SetCursorPosition(10, high_Score_y);
                                Console.WriteLine(scores[high_Score]);
                            }
                        }
                    }
                }
            }
