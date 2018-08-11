using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CinemaClerk
    {
        const int TicketPrice = 25;
        private static int Income;
        private static List<Dictionary<int, int>> CalculationList;
        private static Dictionary<int, int> CurrentBills;

        public static string Tickets(int[] peopleInLine)
        {
            var output = "YES";
            Income = 0;
            CalculationList = new List<Dictionary<int, int>>();
            CurrentBills = new Dictionary<int, int>();
            var ticketCount = 0;

            foreach (var ticket in peopleInLine)
            {
                ticketCount++;
                var changeRequired = ticket - TicketPrice;
                var hasChange = CanProvideChange(ticket, changeRequired);
                var hasCorrectChange = CanCalculate(changeRequired);

                if (changeRequired == 0)
                    hasCorrectChange = true;

                if (!hasChange || !hasCorrectChange)
                {
                    output = "NO";
                    break;
                }

                GenerateNewCalculations(ticket, ticketCount);
                CurrentBills.Add(ticketCount, ticket);
                Income += TicketPrice;
            }

            return output;
        }

        private static bool CanProvideChange(int ticket, int changeRequired)
        {
            if (changeRequired > 0 && changeRequired > Income)
            {
                return false;
            }

            return true;
        }

        private static bool CanCalculate(int changeRequired)
        {
            var returnValue = false;
            var keysToRemove = new List<int>();

            CalculationList.Reverse();

            foreach (var calculation in CalculationList)
            {
                if (calculation.Values.Sum() == changeRequired)
                {
                    foreach (var bill in calculation)
                    {
                        keysToRemove.Add(bill.Key);                        
                    }

                    returnValue = true;
                    break;
                }
            }

            if(keysToRemove.Count > 0)
            {
                foreach(var key in keysToRemove)
                {
                    CurrentBills.Remove(key);
                    CalculationList.RemoveAll(x => x.ContainsKey(key));
                }
                
                CalculationList.RemoveAll(x => x.Count > CurrentBills.Count);                
            }

            return returnValue;
        }

        private static void GenerateNewCalculations(int ticket, int ticketCount)
        {
            var calculations = new List<Dictionary<int, int>>() {
                    new Dictionary<int, int>(){{ticketCount, ticket}}
                };

            foreach (var calculation in CalculationList)
            {
                var newCalculation = new Dictionary<int, int>(calculation);
                newCalculation.Add(ticketCount, ticket);

                calculations.Add(newCalculation);
            }

            CalculationList.AddRange(calculations);
        }
    }
}
