using System;

namespace NET12Final
{
    class ProgramFinal
    {
        static void Main(string[] args)
        {
            Adult[] ad = new Adult[10];
            Child[] cd = new Child[10];

            for(int i=0;i<ad.Length;i++)
            {
                Console.WriteLine("Enter the First Name and Last Name");
                ad[i].FirstName = Console.ReadLine();
                ad[i].LastName = Console.ReadLine();
            }
            Console.WriteLine("First Names and Last Names are");
            for (int i = 0; i < ad.Length; i++)
            {
                ad[i].PrintAName();
            }

            for (int i = 0; i < cd.Length; i++)
            {
                Console.WriteLine("Enter the First Name and Last Name");
                cd[i].FirstName = Console.ReadLine();
                 cd[i].LastName = Console.ReadLine();
            }
            Console.WriteLine("First Names and Last Names are");
            for (int i = 0; i < ad.Length; i++)
            {
                cd[i].PrintCName();
            }




        }
        public class Adult
    {
        public string FirstName;
        public string LastName;
        public void PrintAName()
        {
            Console.WriteLine("First Name is {0} Last Name is {1}", FirstName, LastName);
        }
    }

    public class Child 
    {
        public string FirstName;
        public string LastName;
        public void PrintCName()
        {
        Console.WriteLine("First Name is {0} Last Name is {1}", FirstName, LastName);
        }
    }
}
}
