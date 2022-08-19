using System;

namespace ConsoleApp2
{
    public static class Question
    {
        public static void Question1()
        {
            int[] arr = {0,2,1,3};
            int move = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i + 1] + 1 || arr[i] != arr[i + 1] - 1)
                {
                    move++;
                }
                
            }

            Console.WriteLine(move/2);
        }

        public static void Question2(int maxChooseableInteger,  int desiredTotal)
        {
            
            int sum = 0;
            int player =0;
            if (desiredTotal == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                for (int i = 0; i <= maxChooseableInteger; i++)
                {
                    if (sum>=desiredTotal)
                    {
                        break;
                        
                    }
                    sum += i;
                    player = 1+i;
                }
                
                Console.WriteLine(player %2 ==0 ? "false" : "true");
            }
            
        }
    }
}