using System;

namespace Activity5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length Of Loop?");
            int length = Int32.Parse(Console.ReadLine());

            int[] nums = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter and integer:");
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            bool doLoop = true;
            while (doLoop)
            {
                Console.WriteLine("Select An Option:");
                Console.WriteLine("1: Display the whole list of input");
                Console.WriteLine("2: Display every even number");
                Console.WriteLine("3: Display every odd number");
                Console.WriteLine("4: Display every 5th number");
                Console.WriteLine("5: Display the sum of the integers");
                Console.WriteLine("6: Display every number divisible by 3");
                Console.WriteLine("7: Quit");

                int input = Int32.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3: 
                        { 
                        
                      for (int i = 0; i < length; i++) {
                             
                                if ( nums[i] % 2 == 1)
                                {
                                    Console.WriteLine(nums[i] + " is an odd number");
                                }
                            }

                            }
                        break;
                    case 4:
                        {
                            for (int i = 0; i < length; i = i + 5)
                            {
                                Console.WriteLine(nums[i]);
                            }
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:
                        doLoop = false;
                        break;
                }

            }
            Console.WriteLine("Loop Closed");
        }
    }
}
