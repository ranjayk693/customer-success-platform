using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.CustomerSuccessPlatform.App.Models
{
    public abstract class BaseAuditableModel
    {
        [Key]
        public int Id { get; set; }
        public required DateTime CreatedDateTime { get; set; }
        [ForeignKey(nameof(CreatedByUser))]
        public Guid CreatedBy { get; set; }
        public virtual ApplicationUser? CreatedByUser { get; set; }
        public required DateTime ModifiedDateTime { get; set; }
        [ForeignKey(nameof(ModifiedByUser))]
        public Guid ModifiedBy { get; set; }
        public virtual ApplicationUser? ModifiedByUser { get; set; }
    }
}
