namespace UneCalculette;

using System;

class Program {
  public static void Main (string[] args) {





      while (true)
        {
            Console.WriteLine("First operand : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Second operand : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Wich operation you choose (+, -, *, /, %) : ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine("Addition : " + Add(a, b));
                    break;
                case "-":
                    Console.WriteLine("Soustraction : " + Subtract(a, b));
                    break;
                case "*":
                    Console.WriteLine("Multiplication : " + Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine("Division : " + Divide(a, b));
                    break;
                case "%":
                    Console.WriteLine("Modulo : " + Modulo((int)a, (int)b));
                    break;
                default:
                    Console.WriteLine("Erreur : opération non reconnue.");
                    break;
            } 
        }
    }

    static float Add(float a, float b)
    {
        return a + b;
    }

    static float Subtract(float a, float b)
    {
        return a - b;
    }

    static float Multiply(float a, float b)
    {
        return a * b;
    }

    static float Divide(float a, float b)
    {
        return a / b;
    }

    static int Modulo(int a, int b)
    {
        return a % b;

  }
}
