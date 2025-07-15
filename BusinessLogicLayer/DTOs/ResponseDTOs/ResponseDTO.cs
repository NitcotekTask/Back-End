namespace BusinessLogicLayer.DTOs.ResponseDTOs
{
    public class ResponseDTO<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}
