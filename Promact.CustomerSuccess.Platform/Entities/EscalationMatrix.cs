using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class EscalationMatrix : AuditedAggregateRootWithUser<ApplicationUser>
    {        
        public EscalationMatrixLevels Level { get; set; }
        public EscalationType EscalationType { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project? Project { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public override object?[] GetKeys()
        {
            throw new NotImplementedException();
        }
    }
}