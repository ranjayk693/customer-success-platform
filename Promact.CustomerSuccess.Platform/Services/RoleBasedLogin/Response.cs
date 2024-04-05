using Promact.CustomerSuccess.Platform.Entities;

namespace Promact.CustomerSuccess.Platform.Services.RoleBasedLogin
{
    public class Response
    {   
        public string message { get; set; }
        public string email { get; set; }
        public RoleType role { get; set; }
        public bool isAuthentic { get; set; } = false;
    }
}
