using System;

namespace Activity5
{
    class Program
    {
        static void Main(string[] args)
        {

            int length;

            while (true)
            {
                Console.WriteLine("Length Of Loop?");
                try
                {
                    length = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                break;
            }

            int[] nums = new int[length];

            for (int i = 0; i < length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Enter and integer:");
                    try
                    {
                        nums[i] = Int32.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }
                    break;
                }
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
                Console.WriteLine("7: Numerical order");
                Console.WriteLine("8: Reverse numerical order");
                Console.WriteLine("9: Quit");

                int input;

                while (true)
                {
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }
                    break;
                }

                switch (input)
                {
                    case 1:
                        String list = "";
                        for(int i = 0; i < nums.Length; i++)
                        {
                            list += nums[i] + " ";
                        }
                        Console.WriteLine(list);
                        break;
                    case 2:
                        String evens = "";
                        for (int i = 0; i < nums.Length; i++)
                        {
                            if(Math.Abs(nums[i]%2) == 0)
                            {
                                evens += nums[i] + " ";
                            }
                        }
                        Console.WriteLine(evens);
                        break;
                    case 3: 
                        { 
                        
                      for (int i = 0; i < length; i++) {
                         


                                if ( Math.Abs(nums[i]) % 2 == 1)
                                {
                                    Console.WriteLine(nums[i] + " is an odd number");
                                }
                            }

                            }
                        break;
                    case 4:
                        {
                            for (int i = 4; i < length; i = i + 5)
                            {
                                Console.WriteLine(nums[i]);
                            }
                        }
                        break;
                    case 5:
                    {
                        int sum = 0;
                        for (int i = 0; i < length; i++)
                        {
                            sum += nums[i];
                        }
                        Console.WriteLine("Sum: " + sum);
                    }
                        break;
                    case 6:
                    {
                        for (int i = 0; i < length; i++)
                        {
                            if ((nums[i] % 3) == 0)
                            {
                                Console.WriteLine(nums[i]);
                            }
                        }
                    }
                        break;
                    case 7:
                    {
                        Array.Sort(nums);
                        String numerical = "";
                        for(int i = 0; i < nums.Length; i++)
                         {
                                numerical += nums[i] + " ";
                         }
                        Console.WriteLine(numerical);

                        break;
                    }
                    case 8:
                        for (int j = 0; j < (nums.Length / 2); j++)
                        {
                            int temp = nums[j];
                            nums[j] = nums[nums.Length - (j + 1)];
                            nums[nums.Length - (j + 1)] = temp;
                        }
                        String reversed = "";
                        for (int k = 0; k < nums.Length; k++)
                        {
                            reversed += nums[k] + " ";
                        }
                        Console.WriteLine(reversed);

                        break;

                    case 9:
                        doLoop = false;

                        break;
                }

            }
            Console.WriteLine("Loop Closed");
        }
    }
}
