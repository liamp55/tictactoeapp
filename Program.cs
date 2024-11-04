// class QuizProgram
// {
//     static void Main()
//     {
//         string[] questions = 
//         {  
//             "what is the largest continent",
//             "who was the 44th president"
//         };

//         string[] answers =
//         {
//             "A. Asia\nB. Africa\nC. North America\n",
//             "A. Bush\nB. Obama\nC. Clinton\n"
//         };

//         int[] CorrectAnswers = { 0, 1 };
//         int PlayerScore = 0;

//         Console.Write("Welcome to my Quiz App\n");

//         for (int i = 0; i < questions.Length; i++) {
//             Console.WriteLine();
//             Console.Write("Question " + (i + 1) + ": ");
//             Console.WriteLine(questions[i]);
//             Console.WriteLine(answers[i]);
//             string playerAnswer = Console.ReadLine();


//         if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && CorrectAnswers[i] == 0) {
//             PlayerScore++;
//         }
//         else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && CorrectAnswers[i] == 1) {
//             PlayerScore++;
//         }
    
//         }
//         Console.WriteLine();
//         Console.WriteLine("You've completed the quiz!!");
//         Console.WriteLine("Your score is: " + PlayerScore);

        

//     }
// }





// class ShaqHeight
// {
//     static void Main()
//     {
//         int shaqCenti = 216;
//         int shaqFeet = 7;
//         int shaqInches = 1;

//         Console.Write("Please enter your feet (height) ");
//         string feet = Console.ReadLine();
//         int feetOne = int.Parse(feet);
//         Console.Write("Please enter your inches ");
//         string inches = Console.ReadLine();
//         int inchesOne = int.Parse(inches);


//         int convertFeet = (feetOne * 12);
//         double convertInches = (convertFeet + inchesOne) * 2.54;
//         int intConvertInches = Convert.ToInt32(convertInches);


//         CalculateShaqDifference(intConvertInches);


//     } 
//     static void CalculateShaqDifference(int convertIn)
//     {
        
//         int shaqCenti = 216;
//         int shaqFeet = 7;
//         int shaqInches = 1;

//         if (shaqCenti > convertIn) {
//             int shaqVsUser = shaqCenti - convertIn;
//             Console.WriteLine("You are " + shaqVsUser + " centimeters shorter than Shaq");

//         } else {
//             int shaqVsUser = convertIn - shaqCenti;
//             Console.WriteLine("You are " + shaqVsUser + " centimeters taller than Shaq");

//         }
        
//     }

// }








// class GuessingGame
// {
//     static void Main()
//     {
//         Random rnd = new Random();
//         int guessValue = rnd.Next(1, 100);
        
        
//         while (guessValue != guessValue-1) {
//             Console.WriteLine("Please choose a number from 1 - 100");
//             string userValue = Console.ReadLine();
//             int intUserValue = int.Parse(userValue);    

//             if (intUserValue > 100 | intUserValue < 0) {
//                 Console.WriteLine("Please choose a value within the correct bounds");
//             } else {

//             if (intUserValue > guessValue) {
//                 Console.WriteLine("Your input was too high");
//             } else if (intUserValue < guessValue) {
//                 Console.WriteLine("Your input was too low");
//             } else {
//                 Console.WriteLine("Correct!");
//                 guessValue = guessValue - 1;
//                 break;
//             }
//             }}

//     }
// }


using System;

namespace TicTac
{


static class TicTacToe 
{
    static void Main() 
    {
        int[,] grid = new int[3, 3]
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
        };

        

        PrintGrid(grid);
    }

    static void PrintGrid(int[,] grid)
    {
        
        bool gameIsOver = false;
        bool alreadySelected = false;

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);


        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }

         while (!gameIsOver)
        {
        
        FirstPlayer(grid, rows, cols);
        bool gameOverOne = checkIfGameIsOver(grid, 1);
        if (gameOverOne) 
        {
            gameIsOver = true;
            break;
        }
        SecondPlayer(grid, rows, cols);
        bool gameOverTwo = checkIfGameIsOver(grid, 2);
        if (gameOverTwo) 
        {
            gameIsOver = true;
            break;
        }
        }
        //  if (checkAlreadySelected(grid, rows, cols) == 1)
        // {
        //     Console.WriteLine("Please choose another coordinate 2");
        //     SecondPlayer(grid, rows, cols);
        // } 
        // if (checkAlreadySelected(grid, rows, cols) == 2)
        // {
        //     Console.WriteLine("Please choose anther coordinate for 1");
        //     FirstPlayer(grid, rows, cols);
        // }
        
        }
        
        

        //     if (checkIfGameIsOver(grid, 1) != false || checkIfGameIsOver(grid, 2) != false) 
        //     {
        //         HandleMoves(grid, rows, cols);
        //         gameIsOver = true;
        //     }
        // }
    


    // static void HandleMoves(int[,] grid, int row, int col) 
    // {
        
        
    //     bool gameIsOver = false;
    //     bool alreadySelected = false;

    //     PrintGrid(grid);

        
        // FirstPlayer(grid, row, col);
        // SecondPlayer(grid, row, col);
        
        // var firstValRow = FirstPlayer(grid, row, col);
        // var firstValCol = FirstPlayer(grid, row, col);

        // var secondValRow = SecondPlayer(grid, row, col);
        // var secondValCol = SecondPlayer(grid, row, col);

        // if (checkAlreadySelected(grid, FirstPlayer(grid, row, col).Item1, FirstPlayer(grid, row, col).Item2) == 0 || checkAlreadySelected(grid, SecondPlayer(grid, row, col).Item1, SecondPlayer(grid, row, col).Item2) == 0) 
        // {
        
       
        
    static (int, int) FirstPlayer(int[,] grid, int row, int col)
    {
       
        Console.WriteLine("Player1's Turn");
        Console.Write("Please choose a row");
        string rowChoice = Console.ReadLine();
        Console.Write("Please choose a column");
        string columnChoice = Console.ReadLine();

        int newColumn = int.Parse(columnChoice);
        int newRow = int.Parse(rowChoice);


        for (int i = 0; i < row; i++) 
        {
            for (int j = 0; j < col; j++)
            {
                grid[newRow, newColumn] = 1;
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }

       

        return (newRow, newColumn);
    }   

     static (int, int) SecondPlayer(int[,] grid, int row, int col)
    {
       
        Console.WriteLine("Player2's Turn");
        Console.Write("Please choose a row");
        string rowChoice = Console.ReadLine();
        Console.Write("Please choose a column");
        string columnChoice = Console.ReadLine();

        int newColumn = int.Parse(columnChoice);
        int newRow = int.Parse(rowChoice);


        for (int i = 0; i < row; i++) 
        {
            for (int j = 0; j < col; j++)
            {
                grid[newRow, newColumn] = 2;
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
        return (newRow, newColumn);


    }   
    static bool checkIfGameIsOver(int[,] grid, int playerSymbol)
    {
        for ( int row = 0; row < 3; row++) 
        {
        if (grid[row, 0] == playerSymbol && grid[row, 1] == playerSymbol && grid[row, 2] == playerSymbol ) 
        {
            return true;
        }
        }
        for (int col = 0; col < 3; col++)
        {
        if (grid[0, col] == playerSymbol && grid[1, col] == playerSymbol && grid[2, col] == playerSymbol ) 
        {
            return true;
        }
        }

        if (grid[0, 0] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 2] == playerSymbol ) 
        {
            return true;
        }
        if (grid[0, 2] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 0] == playerSymbol ) 
        {
            return true;
        }

        return false;
    }
    static int checkAlreadySelected(int[,] grid, int rows, int cols)
    {

            // if (rows < 0 || rows >= grid.GetLength(0) || cols < 0 || cols >= grid.GetLength(1) )
            // {
            //     throw new ArgumentOutOfRangeException("try again");
            // }

            if (grid[rows, cols] == 1) 
            {
                return 1;
            } 
            if (grid[rows, cols] == 2)
            {
                return 2;
            } else 
            {
                return 0;
            }

    
        
    }
} 
}







// using System;

// class BlackJackGame 
// {
//     static void Main()
//     {

        
//         bool gameIsOver = true;

//         while (gameIsOver)
//         {
//             PlayerAndDealer("Dealer");
//             Dealer();
//         }
        
        
//     }

//     static int PlayerAndDealer(string player)
//     {

    
//         Random random = new Random();
//         int randomNumber = random.Next(1, 12);
//         string faceCardName = "";

//         if (randomNumber == 10) 
//         {
//             int faceCard = random.Next(1, 5);

//             if (faceCard == 1)
//             {
//                 faceCardName = "Jack";
//             }
//             else if (faceCard == 2)
//             {
//                 faceCardName = "Queen";
//             }
//             else if (faceCard == 3)
//             {
//                 faceCardName = "King";
//             }
//             else if (faceCard == 4)
//             {
//                 faceCardName = "Ace";
//             }

//             Console.WriteLine($"{player} drew a card of the value:" + faceCardName);

//             if (faceCardName != "Ace")
//             {
//                 return randomNumber;
//             }
//             else 
//             {
//                 return 11;
//             }
        
            
//         } 
//             if (randomNumber < 10)
//             {
//                 Console.WriteLine($"{player} drew a card of the value:" + randomNumber);
//                 return randomNumber;
//             }
            
//         return 0;
        
//         }
        
//     static int PlayerChoice() 
//     {

//         int playerCard = PlayerAndDealer("Player");

//         Console.WriteLine("Would you like to draw again? yes/no");
//         string playerChoice = Console.ReadLine();

//         if (playerChoice == "yes")
//         {
//             playerCard = playerCard + PlayerAndDealer("Player");

//             int total = playerCard;
//             Console.WriteLine("Player's total is: " + total);

//             return total;
//         }

//         return 0;


//     }

//     static void Dealer()
//     {

//         bool hit = true;
//         PlayerAndDealer("Player");

//         while (hit)
//         {

//         int playerCard = PlayerAndDealer("Player");

//         Console.WriteLine("Would you like to draw again? yes/no");
//         string playerChoice = Console.ReadLine();

//         int playerTotal = playerCard;

//         if (playerChoice == "yes")
//         {
//             int newPlayerCard = PlayerAndDealer("Player");
//             playerTotal += newPlayerCard;
//             Console.WriteLine("Player's total is: " + playerTotal);
//         }
//         else 
//         {
//             hit = false;
//         }
//         }
        
//         int dealerTotal = PlayerAndDealer("Dealer");


//         while (dealerTotal < 17)
//         {
//         int dealerChoice = PlayerAndDealer("Dealer");
//         dealerTotal = dealerChoice + dealerTotal;
//         }

//         Console.WriteLine("Dealer's total is " + dealerTotal);        

//     }
    
// }


