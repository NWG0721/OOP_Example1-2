using System.Diagnostics.Metrics;
using System.Collections;

public static class Doer
{
    public static StudentsDB[] SDB = new StudentsDB[1];
    private static int Count = SDB.Length -1;
    public static ArrayList sdbBackupList = new ArrayList();

    public static void AddStudent()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter First Name: ");
        string fName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lName = Console.ReadLine();
        Console.Write("Enter Score: ");
        int score = Convert.ToInt32(Console.ReadLine());
        //------------------------------| Submiter |------------------------------//
        SDB[0].ID = id;
        SDB[Count].FName = fName;
        SDB[Count].LName = lName;
        SDB[Count].Score = score;
        Console.WriteLine("Added Success");
        //------------------------------| Submiter |------------------------------//
        //------------------------------| Count Checker |------------------------------//
        sdbBackupList.Add(SDB);
        foreach (StudentsDB item in sdbBackupList)
        {
            Console.WriteLine("id: " + item.ID + " | fullname: " + item.FName + " " + item.LName + " | score: " + item.Score);
        }
        Array.Resize(ref SDB, SDB.Length + 1);
        //------------------------------| Count Checker |------------------------------//
    }
    public static void RemoveStudent()
    {
        // foreach(var item in sDb_Store){
        //     Console.WriteLine("ID: "+item.ID+" | FullName: "+item.FName+" "+item.LName+" | Score: "+item.Score);
        // }
            //foreach (var item in sDb_Store)
            //{
            //    Console.WriteLine("id: " + item.ID + " | fullname: " + item.FName + " " + item.LName + " | score: " + item.Score);
            //}
            //Console.WriteLine("ID: " + sDb_Store[0].ID + " | FullName: " + sDb_Store[0].FName + " " + sDb_Store[0].LName + " | Score: " + sDb_Store[0].Score);
            System.Console.Write("Please selecet name ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            // var index = sDb_Store.

    }
}

//Console.WriteLine("ID: " + sDb_Store[0].ID + " | FullName: " + sDb_Store[0].FName + " " + sDb_Store[0].LName + " | Score: " + sDb_Store[0].Score);