namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public  List<string> ErrorMassages { get; set; }
    public ResponseErrorJson(string errorMessage) 
    {
        ErrorMassages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMassages = errorMessage;
    }
}
