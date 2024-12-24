using System.ComponentModel.DataAnnotations;

namespace CopilotWorkSpaceDemo.Models
{
    public class UserProfile
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
