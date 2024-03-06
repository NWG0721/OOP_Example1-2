using System.Drawing;

public static class FrontEnd
{
    public static void Selectors()
    {
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t    Select one of these\n");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("(A)dd new student\t");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("(R)emove student\t");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("(E)dit student");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\t(F)ind student by id\t");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("(S)ort students");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t***************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("(P)rint Datas\t");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("(Avg) Average score\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("(Min) Minimum scores");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\t(Max) Maximum scores\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("(C)ount students");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t***************************");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Board()
    {
        string Receiver = Console.ReadLine().ToUpper();
        switch (Receiver)
        {
            case "A":
                Doer.AddStudent();
                //------------------------------| !Succrss! |------------------------------//
                break;
            case "R":
                Doer.RemoveStudent();
                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "E":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "F":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "S":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "P":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "Avg":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "Min":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "Max":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            case "C":

                //------------------------------| !NOTSuccrss! |------------------------------//
                break;
            default:
                Console.WriteLine("Are you relieved, filthy bitch?");
                break;
        }
    }
}