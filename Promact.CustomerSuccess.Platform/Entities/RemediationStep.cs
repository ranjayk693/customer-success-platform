using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class RemediationStep : AuditedAggregateRootWithUser<ApplicationUser>
    {
        public required string Description { get; set; }
        public override object?[] GetKeys()
        {
            throw new NotImplementedException();
        }
    }
}