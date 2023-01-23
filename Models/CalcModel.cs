using System.Runtime.CompilerServices;
namespace task12.Models
{
    public class CalcModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Operation { get; set; }

        public string Calc()
        {
            return Operation switch
            {
                "+" => $"{X} + {Y} = {X + Y}",
                "-" => $"{X} - {Y} = {X - Y}",
                "*" => $"{X} * {Y} = {X * Y}",
                "/" when Y != 0 => $"{X} / {Y} = {X / Y}",
                "/" when Y == 0 => "Zero divisiion is forbidden.",
                _ => "Invalid operation."
            };
        }
    }
}