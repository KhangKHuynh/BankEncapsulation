namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you want to deposit?");
            var AmountToDep = double.Parse(Console.ReadLine());
            
            account.Deposit(AmountToDep);
            
            Console.WriteLine($"Your new balance is {account.GetBalance()}");
        }
    }
}
