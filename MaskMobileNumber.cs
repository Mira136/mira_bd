using System;

namespace mira_bd
{
    class MaskMobileNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                mobile = mobile.Remove(mobile.Length - 5);
                mobile = mobile.Insert(mobile.Length, "XXXXX");

                Console.WriteLine("Masked Mobile: " + mobile);
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number.");
            }
            Console.ReadLine();
        }
    }
}

