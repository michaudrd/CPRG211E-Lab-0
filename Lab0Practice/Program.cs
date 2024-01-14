namespace Lab0Practice;

class Program
{
    static void Main(string[] args)
    {
        //Task One
        double lowNum = getPositiveNum();

        double highNum = getHighNum(lowNum);

        double difference = highNum - lowNum;
        Console.WriteLine($"The difference between {highNum} and {lowNum} is {difference}");

        //Task Two
        double[] numArray = new double[(int)(highNum - lowNum) + 1];
        for (double i = 0; i < numArray.Length; i++)
        {
            numArray[(int)i] = lowNum + i;
        }

        //List<double> ListOfNums = new List<double>();
        //for (int i = 0; i < 10; i++)
        //{
        //    ListOfNums.Add(i * 10);
        //}

        //Task Three
        using (StreamWriter sw = new StreamWriter("C:\\Users\\micha\\source\\repos\\Lab0Practice\\Lab0Practice\\numbers.txt"))
        {
            for (double i = numArray.Length - 1; i >= 0; i--)
            {
                double number = numArray[(int)i];
                Console.WriteLine(number);
                sw.WriteLine(number);
            }
        }

        double sum = 0;
        for (double i = lowNum; i <= highNum; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of these numbers is {sum}");

        Console.WriteLine($"Prime numbers between {lowNum} and {highNum} are:");
        for (double i = lowNum; i <= highNum; i++)
        {
            if (primeNum(i))
            {
                Console.WriteLine(i);
            }
        }
  
    }
    static double getHighNum(double lowNum)
    {
        double newHigh;
        while (true)
        {
            Console.WriteLine("Enter a high number: ");
            string high = Console.ReadLine();
            if (double.TryParse(high, out newHigh) && newHigh > lowNum)
            {
                //Console.WriteLine(newHigh);
                return newHigh;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    static double getPositiveNum()
    {
        double newLow;
        while (true)
        {
            Console.WriteLine("Enter a low number: ");
            string low = Console.ReadLine();
            if (double.TryParse(low, out newLow) && newLow > 0)
            {
                //Console.WriteLine(newLow);
                return newLow;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    static bool primeNum(double number)
    {
        if (number < 2)
        {
            return false;
        }
        for (double i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}