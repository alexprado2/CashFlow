namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public  string ErrorMassage { get; set; } = string.Empty;

    public ResponseErrorJson(string errorMessage) 
    {
        ErrorMassage = errorMessage;
    }
}
