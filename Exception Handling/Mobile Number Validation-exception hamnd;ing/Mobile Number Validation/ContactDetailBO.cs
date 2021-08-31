using System;
public class ContactDetailBO
{
    public void Validate(ContactDetail cd)
    {
         //Fill your code
         if(cd.Mobile == cd.AlternateMobile)
        {
            throw new DuplicateNumberException("Exception: Same Mobile number and Alternate Mobile number.");
        }
        else
        {
            Console.WriteLine(cd.ToString());
        }

    }
}
