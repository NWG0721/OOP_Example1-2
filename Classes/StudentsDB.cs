public class StudentsDB
{
    public int ID
    {
        get;
        set;
    }
    public string FName
    {
        get;
        set;
    }
    public string LName
    {
        get;
        set;
    }
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            if (value < 21 && value > -1)
            { score = value; }
            else
            { Console.WriteLine("Enter right number"); }
        }
    }
}