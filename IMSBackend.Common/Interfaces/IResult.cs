namespace IMSBackend.Common.Interfaces;

public interface IResult<T>
{
    List<string> Messages { get; set; }

    bool Succeeded { get; set; }

    T Data { get; set; }

    object Exception { get; set; }

    int Code { get; set; }
}
