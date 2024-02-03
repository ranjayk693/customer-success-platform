using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class Sprint : AuditedAggregateRootWithUser<ApplicationUser>
    {
        public int PhaseMilestoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SprintStatus Status { get; set; }
        public virtual PhaseMilestone? PhaseMilestone { get; set; }
        public override object?[] GetKeys()
        {
            throw new NotImplementedException();
        }
    }
}