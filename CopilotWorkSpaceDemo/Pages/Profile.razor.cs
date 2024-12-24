using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using CopilotWorkSpaceDemo.Models;
using CopilotWorkSpaceDemo.Services;

namespace CopilotWorkSpaceDemo.Pages
{
    public partial class Profile : ComponentBase
    {
        private UserProfile userProfile = new UserProfile();
        private List<string> errors = new List<string>();

        [Inject]
        private UserProfileService UserProfileService { get; set; }

        private async Task HandleValidSubmit()
        {
            var result = await UserProfileService.AddUserProfileAsync(userProfile);
            if (!result.Success)
            {
                errors = result.Errors.ToList();
            }
        }
    }
}
