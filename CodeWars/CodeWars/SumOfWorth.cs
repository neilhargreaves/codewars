using System.Collections.Generic;

namespace CodeWars
{
    public class SumOfWorth
    {
        private static readonly Dictionary<string, int> Heroes = new Dictionary<string, int>()
            {
                {"Hobbits", 1},
                {"Men", 2},
                {"Elves", 3},
                {"Dwarves", 3 },
                {"Eagles", 4},
                {"Wizards", 10}
            };

        private static readonly Dictionary<string, int> Villains = new Dictionary<string, int>()
            {
                {"Orcs", 1},
                {"Men", 2},
                {"Wargs", 2},
                {"Goblins", 2 },
                {"Uruk Hai", 3},
                {"Trolls", 5},
                {"Wizards", 10}
            };

        public static string GoodVsEvil(string good, string evil)
        {
            var worthOfGood = 0;
            var worthOfEvil = 0;

            var goodWarriors = good.Split(" ");
            var evilWarriors = evil.Split(" ");
            var index = 0;

            foreach(var warrior in Heroes)
            {
                var warriorValue = warrior.Value * int.Parse(goodWarriors[index]);
                worthOfGood += warriorValue;
                index++;
            }

            index = 0;

            foreach (var warrior in Villains)
            {
                var warriorValue = warrior.Value * int.Parse(evilWarriors[index]);
                worthOfEvil += warriorValue;
                index++;
            }

            if (worthOfGood < worthOfEvil)
                return "Battle Result: Evil eradicates all trace of Good";

            if (worthOfEvil < worthOfGood)
                return "Battle Result: Good triumphs over Evil";

            return "Battle Result: No victor on this battle field";
        }
    }
}
