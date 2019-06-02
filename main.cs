using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Solve this puzzle by writing the shortest code.
 * Whitespaces (spaces, new lines, tabs...) are counted in the total amount of chars.
 * These comments should be burnt after reading!
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        var LightLocation = new Location
        {
            X = int.Parse(inputs[0]),
            Y = int.Parse(inputs[1])
        };
        var thorLocation = new Location
        {
            X = int.Parse(inputs[2]),
            Y = int.Parse(inputs[3])
        };
        
        // game loop
        while (true)
        {
            var rep = "";
            int remainingTurns = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.
            if(thorLocation.Y > LightLocation.Y)
            {
                rep += "N";
                thorLocation.Y--;
            }
            else if(thorLocation.Y < LightLocation.Y)
            {
                rep += "S";
                thorLocation.Y++;
            }
            if(thorLocation.X > LightLocation.X)
            {
                rep += "W";
                thorLocation.X--;
            }
            else if(thorLocation.X < LightLocation.X)
            {
                rep += "E";
                thorLocation.X++;
            }
            Console.WriteLine(rep);
        }
    }
}
class Location
{
    public int X { get; set; }
    public int Y { get; set; }
}