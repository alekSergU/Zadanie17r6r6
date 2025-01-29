namespace Zadanie17r6r6
{
    public class Obychnyi : Account
    {
        private double Procc { get; set; }
        protected override double RaschetProcPribyli(double balance)
        {
            if (balance < 1000) Procc = 0.2;
            else Procc = 0.4;
            return balance * Procc;
        }
    }
}
