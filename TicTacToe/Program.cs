namespace TicTacToe
{
    class Program
    {
        // The board is represented by a char array
        // Доска представлена массивом символов
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        
        static int position;
        
        // The current player is represented by a char
        // Текущий игрок представлен символом
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            // The game ends when the game is won
            // Игра заканчивается, когда игра выиграна
            bool gameWon = false;

            // Loop until the game is won
            // Цикл до выигрыша игры
            while (!gameWon)
            {
                // Draw the board, get a position, and make a move 
                // Нарисовать доску, получить позицию и сделать ход
                DrawBoard();
                position = GetPosition();
                if (IsValidMove())
                {
                    MakeMove();
                    
                    // Check if the game is won and switch the player
                    // Проверить, выиграл ли игрок и переключить игрока
                    gameWon = CheckWin();
                    if (!gameWon)
                        SwitchPlayer();
                }
                else
                {
                    // The move was invalid, so ask again
                    // Ход был недействителен, поэтому спросите еще раз
                    
                }
            }

            // Draw the board one last time and print the winner
            // Нарисуйте доску еще раз и напечатайте победителя
            DrawBoard();

            // Print the winner
            // Напечатать победителя
        }

        static void DrawBoard()
        {
            // Clear the console and draw the board
            // Очистить консоль и нарисовать доску
            
        }

        static int GetPosition()
        {
            // Ask the current player for a position
            // Спросить текущего игрока о позиции

        }

        static bool IsValidMove()
        {
            // Check if the position is valid
            // Проверить, действительна ли позиция
            
        }

        static void MakeMove()
        {
            // Make the move
            // Сделать ход
            
        }

        static bool CheckWin()
        {
            // Check if the current player has won
            // Проверить, выиграл ли текущий игрок

        }

        static void SwitchPlayer()
        {
            // Switch the current player
            // Переключить текущего игрока
            
        }
    }
}
