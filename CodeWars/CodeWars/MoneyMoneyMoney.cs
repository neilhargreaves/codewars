namespace CodeWars
{
    public class MoneyMoneyMoney
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal == desiredPrincipal)
                return 0;

            var years = 0;

            do
            {
                years++;
                var yearlyInterest = CalculateInterest(principal, interest);
                var yearlyTax = CalculateTax(yearlyInterest, tax);
                principal += yearlyInterest - yearlyTax;
            } while (principal < desiredPrincipal);

            return years;
        }

        private static double CalculateInterest(double principal, double interest)
        {
            return principal * interest;
        }

        private static double CalculateTax(double interest, double tax)
        {
            return interest * tax;
        }
    }
}
