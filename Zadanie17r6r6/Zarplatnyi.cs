namespace Zadanie17r6r6
{
    public class Zarplatnyi : Account
    {
        private double Procc { get; set; }
        protected override double RaschetProcPribyli(double balance)
        {
            Procc = 0.5;
            return balance * Procc;
        }
    }
}
