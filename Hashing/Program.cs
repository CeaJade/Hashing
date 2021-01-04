using System;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Hash \n2. HMAC");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 1:
                    Hash();
                    break;
                case 2:
                    Hmac();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            
        }

        static void Hash()
        {
            Console.WriteLine("Message: ");
            string message = Console.ReadLine();
        }

        static void Hmac()
        {
            Console.WriteLine("1. Encrypt \n2. Decrypt");

            Console.WriteLine("1. SHA1 \n2. MD5 \n3. RIPEMD \n4. SHA256 \n5. SHA384 \n6. SHA512");


            Console.WriteLine("Message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Key: ");
            string key = Console.ReadLine();
        }
    }
}
