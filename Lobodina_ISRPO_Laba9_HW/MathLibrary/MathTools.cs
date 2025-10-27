//namespace MathLibrary
//{
//    public class MathTools
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//        public int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//        public static double Divide(double a, double b)
//        {
//            if (b == 0)
//                throw new DivideByZeroException("Деление на ноль невозможно");
//            return a / b;
//        }
//        public static int Power(int baseNum, int exponent)
//        {
//            if (exponent < 0)
//                throw new ArgumentException("Показатель степени должен быть неотрицательным");

//            int result = 1;
//            for (int i = 0; i < exponent; i++)
//            {
//                result *= baseNum;
//            }
//            return result;
//        }
//    }
//}
