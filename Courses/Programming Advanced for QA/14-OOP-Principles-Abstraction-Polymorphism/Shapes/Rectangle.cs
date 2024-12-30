using System;
using Shapes;

internal class Rectangle : IDrawable
{
    private int width;                                      //Fields (полета)

    private int height;

    public Rectangle(int width, int height)                             //Конструктор
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()                                      //Метод Interface
    {
        DrawLine(this.width, '*', '*');
        for(int i = 1; i < this.height - 1; ++i)
        {
            DrawLine(this.width, '*', ' ');
        }
        DrawLine(this.width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for(int i = 1; i < width - 1; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}