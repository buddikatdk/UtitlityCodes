using System;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter the Date of Birth");
                DateTime date_of_birth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.WriteLine("Enter the age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Email id");
                string email_id = Console.ReadLine();
                Console.WriteLine("Enter the mobile number");
                long mobile_number = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the blood group");
                string blood_group = Console.ReadLine();
                BloodBank b = new BloodBank(username, date_of_birth, age, email_id, mobile_number, blood_group);
                if (!b.CheckAge(b))
                {
                    Console.WriteLine("Eligible for Blood Donation");
                    Console.WriteLine(b.ToString());
                }
                else
                {
                    throw new AgeException("Sorry !!! You are not eligible for Blood Donation");
                }
            }
            catch(AgeException e)
            {
                Console.WriteLine("Sorry !!! You are not eligible for Blood Donation");
            }
        }
    }
}
