while (true)
{
    FrontEnd.Selectors();
    FrontEnd.Board();
    Console.WriteLine("Continue? Y/N");
    string yesNo = Console.ReadLine().ToLower();
    if (yesNo == "n")
    {
        break;
    }
}