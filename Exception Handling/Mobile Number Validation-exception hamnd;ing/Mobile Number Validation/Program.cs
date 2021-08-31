using System;
public class Program{
    public static void Main(){
        try
        {
            Console.WriteLine("Enter the mobile number:");
            long mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the alternate mobile number:");
            long alternateMobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the landline number:");
            long landLine = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the email id:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            string address = Console.ReadLine();
            ContactDetailBO cb = new ContactDetailBO();
            ContactDetail cd = new ContactDetail(mobile, alternateMobile, landLine, email, address);
            cb.Validate(cd);
        }catch(DuplicateNumberException e)
        {
            Console.WriteLine(e.message);
        }
        //fill your code
    }
}
