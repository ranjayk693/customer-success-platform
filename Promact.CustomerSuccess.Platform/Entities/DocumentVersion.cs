using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class DocumentVersion : AuditedEntityWithUser<ApplicationUser>
    {
        public required ChangeType ChangeType { get; set; }
        public string? Changes { get; set; }
        public string? ChangeReason { get; set; }
        public override object?[] GetKeys()
        {
            throw new NotImplementedException();
        }
    }
}
