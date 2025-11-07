namespace Task2
{
    public class Calculator(double A, double B, string operation)
    {
        private readonly double A = A;
        private readonly double B = B;
        private readonly string operation = operation;

        public double Calculate()
        {
            double result;
            if (operation == "+")
            {
                result = A + B;
            }
            else if (operation == "-")
            {
                result = A - B;
            }
            else if (operation == "*")
            {
                result = A * B;
            }
            else if (operation == "/")
            {
                if (B == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                else
                {
                    result = A / B;
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid operation");
            }

            return result;
        }
    }
}