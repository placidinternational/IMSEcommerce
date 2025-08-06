namespace IMSBackend.Application.Dtos.Auth.Requests;

public class TransactionPinDto
{
    public string Pin { get; set; }
}

public class UpdateTransactionPinDto
{
    public string OldPin { get; set; }
    public string NewPin { get; set; }
}