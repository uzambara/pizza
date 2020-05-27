namespace Innoscripta.Pizza.Contracts
{
    public class BaseResponse
    {
        public ResponseCode Code { get; set; } = ResponseCode.Ok;
    }
}