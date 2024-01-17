using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.CustomerSuccessPlatform.App.Models
{
    public class Document : BaseModel
    {
        public required string Url { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        [ForeignKey(nameof(Project))]
        public required int ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
