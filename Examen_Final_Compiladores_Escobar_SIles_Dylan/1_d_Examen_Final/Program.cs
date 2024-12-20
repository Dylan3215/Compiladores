using System;

class Program
{
    public class Estado
    {
        public const int q0 = 0;
        public const int q1 = 1;
        public const int q2 = 2;
        public const int q3 = 3;
    }

    public void Valido(string s)
    {
        if (Correcto(s))
        {
            Console.WriteLine("Es válido");
        }
        else
        {
            Console.WriteLine("No es válido");
        }
    }

    public bool Correcto(string s)
    {
        int actual = Estado.q0;
        foreach (char i in s)
        {
            switch (actual)
            {
                case Estado.q0:
                    if (i == 'm') actual = Estado.q1;
                    else if (i == 'h') actual = Estado.q2;
                    else return false;
                    break;

                case Estado.q1:
                    if (i == 'h') actual = Estado.q3;
                    else if (i == 'a') actual = Estado.q2;
                    else return false;
                    break;

                case Estado.q2:
                    if (i == 'm') actual = Estado.q1;
                    break;

                case Estado.q3:
                    if (i == 'a') actual = Estado.q3;
                    break;

                default:
                    return false;
            }
        }
        return actual == Estado.q2 || actual == Estado.q3;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena:");
        string s = Console.ReadLine();

            Program program = new Program();
            program.Valido(s);

    }
}