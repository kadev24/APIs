namespace Ventas.WebAPI.Models
{
    public class ResponseModel
    {
        public ResponseModel(string message)
        {
            this.Message = message;
        }

        public ResponseModel(int statusCode, string message)
        {
            this.Message = message;
            this.StatusCode = statusCode;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
