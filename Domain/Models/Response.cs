namespace Domain.Models;

public class Response<T>
{
    public string messeng { get; set; }
    public T _data { get; set; }
    public Response(string m,T data)
    {
    messeng=m;
    _data = data;
    }
    public Response(string mes)
    {
        messeng=mes;
    }
}
