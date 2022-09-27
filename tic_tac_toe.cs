using System;
namespace CSE210_kasonmills;

class Tic_Tac_Toe
{
    void display()
    {
        Console.WriteLine("This is a game of Tic Tac Toe!");
    }
    void display_the_board()
    {
        List<int> Board = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
        foreach (int num in Board)
        {
            Console.WriteLine(" " + num + " |");
            if (num % 3 == 1 | num % 3 == 2)
            {
                Console.WriteLine("--+--+--");
            }
        }
    }
    static void Main(string[] args)
    {
    Tic_Tac_Toe program = new Tic_Tac_Toe ();
    program.display();
    //program.Main();
    }
}
