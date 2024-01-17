namespace Promact.CustomerSuccessPlatform.App.Models
{
    public class Project : BaseModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public virtual ICollection<Document>? Documents { get; set; }
    }
}
