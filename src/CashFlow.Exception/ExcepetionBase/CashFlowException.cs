namespace CashFlow.Exception.ExcepetionBase;

public abstract class CashFlowException : SystemException
{
    protected CashFlowException(string message) : base(message)
    {
        
    }
}
