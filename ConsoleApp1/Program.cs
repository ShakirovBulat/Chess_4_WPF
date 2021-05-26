/* 
 *  Shakirov_Bulat_221P
 *  Chess№3
 */
using System;

class Program
{
    static void Main()
    {
        figures[] chesfigure = new figures[5];

        //  Задал значения координат
        chesfigure[0] = new King(5, 4);
        chesfigure[2] = new Bishop(2, 4);
        chesfigure[4] = new Knight(1, 2);
        chesfigure[3] = new Rook(3, 5);
        chesfigure[1] = new Queen(3, 1);

        bool state = false;

        foreach (var figure in chesfigure)
        {
            // Задал значения 2-ой координаты (куда должны сдвинуться фигуры)
            state = figure.Move(3, 3);
            Console.WriteLine(state ? "YES" : "NO");
        }
    }
}

//              Класс Фигур
class figures
{
    public int x1;
    public int y1;
    public figures(int x, int y)
    {
        x1 = x;
        y1 = y;
    }
    public virtual bool Move(int x2, int y2)
    {
        bool state = false;
        return state;
    }
}

//  Класс Короля
class King : figures
{
    public King(int x1, int y1) : base(x1, y1)
    {
        Console.WriteLine("Constructor King");
    }
    public override bool Move(int x2, int y2)
    {
        if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Класс Королевы
class Queen : figures
{
    public Queen(int x1, int y1) : base(x1, y1)
    {
        Console.WriteLine("Constructor Queen");
    }
    public override bool Move(int x2, int y2)
    {
        if (((x1 + y1) == (x2 + y2)) || ((x1 - y1) == (x2 - y2)) || (x1 == x2 || y1 == y2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

//Класс Слона
class Bishop : figures
{
    public Bishop(int x1, int y1) : base(x1, y1)
    {
        Console.WriteLine("Constructor Bishop");
    }
    public override bool Move(int x2, int y2)
    {
        if (((x1 + y1) == (x2 + y2)) || ((x1 - y1) == (x2 - y2)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Класс Ладьи
class Rook : figures
{
    public Rook(int x1, int y1) : base(x1, y1)
    {
        Console.WriteLine("Constructor Rook");
    }
    public override bool Move(int x2, int y2)
    {
        if (x1 == x2 || y1 == y2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//Класс Коня
class Knight : figures
{
    public Knight(int x1, int y1) : base(x1, y1)
    {
        Console.WriteLine("Constructor Knight");
    }
    public override bool Move(int x2, int y2)
    {
        if (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) == Math.Sqrt(5))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
