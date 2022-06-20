

namespace Heranca.Entities
{
     class BusinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinesAccount()
        {

        }

        public BusinesAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;

        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
