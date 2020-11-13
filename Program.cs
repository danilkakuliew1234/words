using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            tasks tasks = new tasks();
            tasks.task2();
        }
    }
    interface ITasks
    {
        public void task1();
        public void task2();
        public void task3();
        public void task4();
    }
    class functions
    {
        private char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public int FindMaxCount(string word, bool ReturnNumber = false)
        {
            bool flag = false;
            int index = 0;
            int count = 0;
            int numCount = 1;
            int maxCount = 0;
            string returnNum = $"{numCount} число: ";
            for(int i = 0; i < word.Length; i++)
            {
                if (flag)
                {
                    count = 0;
                    returnNum += $";{numCount} число: ";
                }
                if (maxCount < count)
                    maxCount = count;
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(word[i] == numbers[j])
                    {
                        index = i;
                        count++;
                        flag = false;
                        if (ReturnNumber)
                        {
                            returnNum += word[i];
                            numCount++;
                        }
                        break;
                    } else if(word[index + 1] != numbers[j])
                        flag = true;
                }
            }
            if (maxCount < count)
                maxCount = count;
            if (ReturnNumber)
                return Convert.ToInt32(returnNum);
            return maxCount;
        }
        public string ReturnNumbers(string word)
        {
            bool flag = false;
            int index = 0;
            int numCount = 0;
            string returnNum = null;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (word[i] == numbers[j])
                    {
                        index = i;
                        returnNum += word[i];
                        flag = false;
                        break;
                    }
                    else if (word[index + 1] != numbers[j])
                        flag = true;
                }
                if(flag)
                    returnNum += $" ";
            }
            return returnNum;
        }
    }
    class tasks: functions, ITasks
    {
        public void task1()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            Console.Write($"Максимальное кол-во цифр подряд: {FindMaxCount(word)}");
        } 
        public void task2()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            Console.Write($"Числа идущие подряд - {ReturnNumbers(word)}");
        }
        public void task3()
        {

        }
        public void task4()
        {

        }
    }
}
