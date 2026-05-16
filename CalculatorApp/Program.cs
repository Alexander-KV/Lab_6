namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.add(2, 3));
        }
    }
}
