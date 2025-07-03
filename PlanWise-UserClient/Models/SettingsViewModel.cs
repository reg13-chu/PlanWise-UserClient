using Microsoft.AspNetCore.Http;

namespace PlanWise_UserClient.Models
{
    public class SettingsViewModel
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; } 
        public string Username { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ProfileImagePath { get; set; } = string.Empty;
        public IFormFile ProfileImage { get; set; } = null!; // Use null-forgiving operator to indicate this will be set by the user

    }
}
