using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

class program
{
    static void Main(string[] args)
    {
        //Data types
        int x = 10;
        double d = 23.45678;

        string s = "ivan";
        char c = 'a';

        bool status = true;

        //Displaying
        Console.WriteLine(s);
        Console.WriteLine(status);

        //Input
        Console.WriteLine("Kindly input: ");
        string userInput = Console.ReadLine();
        Console.WriteLine("Result: " + userInput);

        //Conditional
        if (x < 20)
        {
            Console.WriteLine("NUmber is Less than 20");
        }
        else
        {
            Console.WriteLine("Number is more than 20");
        }

        Console.WriteLine("Task One:");
        int newLow;
        while (true)
        {
            string low = Console.ReadLine();

            if (int.TryParse(low, out newLow))
            {
                Console.WriteLine("Low: " + newLow);
                break;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        int newHigh;
        while (true)
        {
            string high = Console.ReadLine();

            if (int.TryParse(high, out newHigh))
            {
                Console.WriteLine("High: " + newHigh);
                break;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        int difference = newHigh - newLow;
        Console.WriteLine($"Differenece between {newHigh} and {newLow} is {difference}");

        //Task Two
        Console.WriteLine("Please enter a low number");
        int lowNum = getPositiveNum();

        Console.WriteLine("Please enter a high number");
        int highNum = getHighNum(lowNum);

        static int getPositiveNum()
        {
            int newLow;
            while (true)
            {
                string low = Console.ReadLine();

                if (int.TryParse(low, out newLow) && newLow > 0)
                {
                    return newLow;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }
        static int getHighNum(int lowNum)
        {
            int newHigh;
            while (true)
            {
                string high = Console.ReadLine();

                if (int.TryParse(high, out newHigh) && newHigh > lowNum)
                {
                    return newHigh;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        //Task three Arrays
        int[] numArray = new int[highNum + 1];
        for (int i = lowNum + 1, k = 0; i < highNum; i++, k++)
        {
            numArray[i] = i;
            Console.WriteLine($"The value at index {k} is: {numArray[i]}");
        }

        //List version
        List<int>ListOfNum = new List<int>();
        for (int i = lowNum + 1,k = 0; i < highNum; i++,k++)
        {
            ListOfNum.Add(i);
            Console.WriteLine($"List Version value at index {k} is {ListOfNum[k]}");
        }
        List<int> newOfNum = new List<int>();

        for (int j = ListOfNum.Count - 1; j >=0; j--)
        {
            newOfNum.Add(ListOfNum[j]);
        }

        //Making file
        using (StreamWriter sw = new StreamWriter("/Users/ivanl/source/repos/Lab0/Lab0/Number.txt"))
        {
            foreach (double number in newOfNum)
            {

                sw.WriteLine(number);
            }
        }

        //printing number from file
        using (StreamReader reader = new StreamReader("/Users/ivanl/source/repos/Lab0/Lab0/Number.txt"))
            {
            int totalNum = 0;

            string numb;
            while ((numb = reader.ReadLine()) != null)
            {
                Console.WriteLine($"Reading through files number: {numb} ");
                int newNumber;
                int.TryParse(numb,out newNumber);
                totalNum += newNumber;


            }
            Console.WriteLine($"Total sum of numbers are: {totalNum}"); ;

            reader.Close();
        }
        //prime numbers

        using (StreamReader reader = new StreamReader("/Users/ivanl/source/repos/Lab0/Lab0/Number.txt"))
        {
   

            string numb;
            while ((numb = reader.ReadLine()) != null)
            {
                int convertNum;
                int.TryParse(numb,out convertNum);
                int primeNum = primeChecker(convertNum);
                if (primeNum == 1)
                {
                    Console.WriteLine($"This number is a prime number: {convertNum} ");

                }
            }

            reader.Close();

        static int primeChecker(int primeNum1)
        {
            int counter = 0;
                
            for (int i = 2; i< primeNum1; i++) 
                {
                    int remainder = primeNum1 % i;
                    if (remainder == 0)
                    {
                        counter ++;
                    }
                }
            if (counter == 0 ^ primeNum1 == 1)
                {
                    return 1;
                }
            else
                {
                    return 0;
                }

        }
        //if (counter > 0 )
        Console.ReadKey();

    }
}

    private static void primeChecker(int convertNum)
    {
        throw new NotImplementedException();
    }
}
