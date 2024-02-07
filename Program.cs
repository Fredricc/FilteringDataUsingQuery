namespace FilteringDataUsingQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //1. Data source
            var numbers= new List<int>() {0, 1, 2, 3, 4, 5, 6};


            

            //Query execution
            var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();

            numbers.Add(7);
            numbers.Add(8);

            foreach (int num in evenNumbers)
            {
                Console.Write("{0, 1} ", num);
            }

            //static bool FilterEvenNumber(int num)
            //{

            //    return num % 2 == 0;
            //}
        }
    }
}