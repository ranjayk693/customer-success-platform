namespace Promact.CustomerSuccessPlatform.App.Models
{
    public class DocumentVersion : BaseModel
    {
        public required ChangeType ChangeType { get; set; }
        public string? Changes { get; set; }
        public string? ChangeReason { get; set; }
        public required ApplicationUser CreatedBy { get; set; }
        public required DateTime CreatedDateTime { get; set; }
        public ApplicationUser? ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public required ApplicationUser ModifiedBy { get; set; }
        public required DateTime ModifiedDateTime { get; set; }
    }
}
