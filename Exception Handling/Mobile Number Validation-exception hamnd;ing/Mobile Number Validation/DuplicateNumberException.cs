using System;
public class DuplicateNumberException:Exception
{
    public string message;
    public DuplicateNumberException(string message) : base(message)
    {
        this.message = message;
    }
}
