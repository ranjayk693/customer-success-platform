namespace Promact.CustomerSuccessPlatform.App.Models
{
    public class AuditHistory : BaseModel
    {
        public DateTime DateOfAudit { get; set; }
        public ApplicationUser? ReviewedBy { get; set; }
        public ProjectStatus Status { get; set; }
        public Section ReviewedSection { get; set; }
        public string? Comments { get; set; }
        public string? ActionItems { get; set; }

    }
}
