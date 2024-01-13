using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccessPlatform.App.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
