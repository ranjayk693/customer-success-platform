using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccessPlatform.App.Models
{
    public class ProjectBudget : BaseModel
    {
        [Required]
        public ProjectType Type { get; set; }

        public int? DurationInMonths { get; set; }

        public int? ContractDuration { get; set; }
        public int? BudgetedHours { get; set; }
    }
}
