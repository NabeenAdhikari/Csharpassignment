namespace MyApp
{
    public static class Arithmetic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
                return 0; // or you can return double.NaN;
            return (double)a / b;
        }

        public static int Modulus(int a, int b)
        {
            if (b == 0)
                return 0; // or return -1 as a custom error code
            return a % b;
        }
    }
}


