using System;

namespace DecisionUnderUncertaintyApp.Services.Validators
{
    public static class ValueValidator
    {
        public static void AssertMatrixIsNotNull<T>(T[,] matrix, string name)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException($"{name} is null!");
            }
            if (matrix.Length == 0)
            {
                throw new ArgumentNullException($"{name}'s legth is equal 0!");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }
    }
}