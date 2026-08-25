namespace CCDemo.Data
{
    /// <summary>
    /// Een simpele calculator class voor demonstratie van unit testing.
    /// </summary>
    public class SimpleCalculator
    {
        public int AddTwo(int number)
        {
            return number + 2;
        }

        public int SubtractThree(int number)
        {
            return number - 3;
        }

        public int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        public int DivideByTwo(int number)
        {
            if (number == 0)
                throw new ArgumentException("Kan niet delen door nul");

            return number / 2;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsPositive(int number)
        {
            return number > 0;
        }

        public string GetStatus(int number)
        {
            if (number > 0)
                return "Positief";
            else if (number < 0)
                return "Negatief";
            else
                return "Nul";
        }
    }
}
