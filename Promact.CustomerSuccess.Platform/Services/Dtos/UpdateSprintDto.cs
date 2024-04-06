﻿namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class UpdateSprintDto
    {
        public Guid PhaseMilestoneId { get; set; }
        public int SprintNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SprintStatus Status { get; set; }
        public required string Comments { get; set; }
    }
}
