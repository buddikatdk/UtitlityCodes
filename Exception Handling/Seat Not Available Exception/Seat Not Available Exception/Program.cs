using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        Console.WriteLine("Enter the total number of seats");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of seats to be booked");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine("Enter the seat number {0}", i + 1);
                int num = Convert.ToInt32(Console.ReadLine());////seat 
                                                              
                if (size < num)
                {
                    Console.WriteLine("Array index is out of range.");
                }
                else
                {
                    if (arr[num - 1] == 0)
                    {
                        arr[num - 1] = num;
                        count++;
                        Console.WriteLine("Seat booked");
                    }
                    else
                    {
                        throw new SeatNotAvailableException("Already Booked");
                    }
                }
            }catch(SeatNotAvailableException e)
            {
                Console.WriteLine("SeatNotAvailableException:" +e.message);
            }

        }if (count > 0)
        {
            Console.WriteLine("The seats booked are");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 1)
                {

                    Console.WriteLine(i + 1);
                }
            }
        }
        else
        {
            Console.WriteLine("No seats booked");
        }
    }
}