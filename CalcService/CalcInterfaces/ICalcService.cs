using CoreWCF;

namespace CalcInterfaces;
[ServiceContract]
public interface ICalcService
{
    [OperationContract]
    float Sum(float firstNumber, float secondNumber);
    [OperationContract]
    float Diff(float firstNumber, float secondNumber);
    [OperationContract]
    float Div(float firstNumber, float secondNumber);
    [OperationContract]
    float Mult(float firstNumber, float secondNumber);
    [OperationContract]
    float Mod(float firstNumber, float secondNumber);

}