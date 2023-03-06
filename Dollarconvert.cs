class Program
{
    static void Main(string[] args)
    {
        double dollar_amount;
        int cents;
        // int compute_cents;

        Console.Write("Enter dollar amount :");
        dollar_amount = Convert.ToDouble(Console.ReadLine());

        cents = compute_cents(dollar_amount);

        Console.WriteLine("{0} $  = {1} ¢", dollar_amount, cents);

        Console.ReadLine();

    }

    static int compute_cents(double dollar_amount)
    {
        return (int)(dollar_amount * 100);
    }
}
