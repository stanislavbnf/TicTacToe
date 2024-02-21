// Осторожно!!! Наглоспиженный код :D
//Хотелось бы услышать разбор как он работает и как нужно было сделать 


string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool player1Turn = true;
int numTurns = 0;

while (!CheckVictory() && numTurns != 9)
{
    PrintGrid();

    if (player1Turn)
        Console.WriteLine("Player 1 Turn!");
    else
        Console.WriteLine("Player 2 Turn!");

    string choice = Console.ReadLine();

    if (grid.Contains(choice) && choice != "X" && choice != "O")
    {
        int gridIndex = Convert.ToInt32(choice) - 1;

        if (player1Turn)
            grid[gridIndex] = "X";
        else
            grid[gridIndex] = "O";

        numTurns++;
        Console.WriteLine(numTurns);
    }

    player1Turn = !player1Turn;
}

PrintGrid();

if (CheckVictory())
    Console.WriteLine("You win!");
else
    Console.WriteLine("Tie!");

void PrintGrid()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i * 3 + j] + "|");
        }

        Console.WriteLine("");
        Console.WriteLine("------");
    }
}

bool CheckVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
    bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

    return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
}



//namespace TicTacToe
//{
//    class Program
//    {
//        // The board is represented by a char array
//        // Доска представлена массивом символов
//        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

//        static int position;

//        // The current player is represented by a char
//        // Текущий игрок представлен символом
//        static char currentPlayer = 'X';

//        static void Main(string[] args)
//        {
//            // The game ends when the game is won
//            // Игра заканчивается, когда игра выиграна
//            bool gameWon = false;

//            // Loop until the game is won
//            // Цикл до выигрыша игры
//            while (!gameWon)
//            {
//                // Draw the board, get a position, and make a move 
//                // Нарисовать доску, получить позицию и сделать ход
//                DrawBoard();
//                position = GetPosition();
//                if (IsValidMove())
//                {
//                    MakeMove();

//                    // Check if the game is won and switch the player
//                    // Проверить, выиграл ли игрок и переключить игрока
//                    gameWon = CheckWin();
//                    if (!gameWon)
//                        SwitchPlayer();
//                }
//                else
//                {
//                    // The move was invalid, so ask again
//                    // Ход был недействителен, поэтому спросите еще раз

//                }
//            }

//            // Draw the board one last time and print the winner
//            // Нарисуйте доску еще раз и напечатайте победителя
//            DrawBoard();

//            // Print the winner
//            // Напечатать победителя
//        }

//        static void DrawBoard()
//        {
//            // Clear the console and draw the board
//            // Очистить консоль и нарисовать доску

//        }

//        static int GetPosition()
//        {
//            // Ask the current player for a position
//            // Спросить текущего игрока о позиции

//        }

//        static bool IsValidMove()
//        {
//            // Check if the position is valid
//            // Проверить, действительна ли позиция

//        }

//        static void MakeMove()
//        {
//            // Make the move
//            // Сделать ход

//        }

//        static bool CheckWin()
//        {
//            // Check if the current player has won
//            // Проверить, выиграл ли текущий игрок

//        }

//        static void SwitchPlayer()
//        {
//            // Switch the current player
//            // Переключить текущего игрока

//        }
//    }
//}
