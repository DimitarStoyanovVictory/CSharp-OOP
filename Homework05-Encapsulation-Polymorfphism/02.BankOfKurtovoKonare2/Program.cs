namespace BankOfKurtovoKonare2
{
    public static class Program
    {
        public static void Main()
        {
            var depositLihvenCalc = new DepositenLihvenCalculator();
            var depositAccount = new Account2(new DepositenLihvenCalculator());
            depositAccount.SmetniLihvata();
        }
    }
}