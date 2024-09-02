using System;
using System.Collections.Generic;

namespace TARpv23_CSharp_Sild.OOP
{
    public static class ToiduaindeFunc
    {
        public static double CalculateBMR(double weight, double height, int age, string gender)
        {
            if (gender.ToLower() == "mees")
            {
                return 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            }
            else if (gender.ToLower() == "naine")
            {
                return 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            }
            else
            {
                throw new ArgumentException("Vale sugu sisestatud. Palun sisestage 'mees' või 'naine'.");
            }
        }

        public static double CalculateDailyCalories(double bmr, string activityLevel)
        {
            switch (activityLevel.ToLower())
            {
                case "istuv":
                    return bmr * 1.2;
                case "vähene":
                    return bmr * 1.375;
                case "mõõdukas":
                    return bmr * 1.55;
                case "kõrge":
                    return bmr * 1.725;
                case "väga kõrge":
                    return bmr * 1.9;
                default:
                    throw new ArgumentException("Vale aktiivsustase sisestatud.");
            }
        }

        public static Dictionary<string, double> GetFoodList()
        {
            return new Dictionary<string, double>()
            {
                {"Õun", 52},
                {"Banaan", 96},
                {"Kanafilee", 165},
                {"Riis", 130},
                {"Kartul", 77},
                {"Jogurt", 59},
                {"Munad", 155},
                {"Leib", 265},
                {"Juust", 402},
                {"Tomat", 18}
            };
        }

        public static double CalculateFoodPortion(double dailyCalories, double foodCalories)
        {
            return dailyCalories / foodCalories;
        }
    }
}
