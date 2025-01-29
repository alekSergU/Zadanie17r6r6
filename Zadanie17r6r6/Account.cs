namespace Zadanie17r6r6
{
    public abstract class Account
    {
        private double Balance { get; set; }
        private double Interest { get; set; }
        protected abstract double RaschetProcPribyli(double balance);
    }
}
