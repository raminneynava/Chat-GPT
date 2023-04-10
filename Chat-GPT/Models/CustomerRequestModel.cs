namespace Chat_GPT.Models
{
    public class CustomerRequestModel
    {
        public string Message { get; set; }
    }
    public class ADProductResponseModel

    {
        public List<string> ADContent { get; set; }
        public bool Success { get; set; }

    }
}
