using System;

namespace NET12Final
{
    class ProgramFinal
    {
        static void Main(string[] args)
        {
            Adult[] ad = new Child[5];

            for(int i=0;i<ad.Length;i++)
            {
                Console.WriteLine("Enter the First Name and Last Name");
                ad[i].FirstName = Console.ReadLine();
                ad[i].LastName = Console.ReadLine();
            }
            Console.WriteLine("First Names and Last Names are");
            for (int i = 0; i < ad.Length; i++)
            {
                ad[i].PrintName();
            }

           

        }
    public abstract class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void PrintName();
            
        
    }

    public class Child :Adult
    {
       public override void PrintName()
        {
        Console.WriteLine("First Name is {0} Last Name is {1}", FirstName, LastName);
        }
    }
}
}
