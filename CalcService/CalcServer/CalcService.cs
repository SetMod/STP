using CalcInterfaces;

namespace CalcServer
{
    class CalcService : ICalcService
    {

        public float Sum(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public float Diff(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public float Div(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public float Mult(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public float Mod(float firstNumber, float secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}