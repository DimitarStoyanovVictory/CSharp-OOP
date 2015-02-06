namespace BankOfKurtovoKonare2
{
    public class Account2
    {
        private readonly LihvenCalculator _lihvenCalculator = null;
        public Account2(LihvenCalculator lihvenCalculator)
        {
            _lihvenCalculator = lihvenCalculator;
        }
        public decimal SmetniLihvata()
        {
            return _lihvenCalculator.SmetniLihvata();
        }
    }
}