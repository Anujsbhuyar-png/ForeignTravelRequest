namespace FTR.UI.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool? Success { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
