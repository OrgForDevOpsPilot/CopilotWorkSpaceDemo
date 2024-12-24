using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CopilotWorkSpaceDemo.Data;
using CopilotWorkSpaceDemo.Models;

namespace CopilotWorkSpaceDemo.Services
{
    public class UserProfileService
    {
        private readonly ApplicationDbContext _context;

        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<(bool Success, List<string> Errors)> AddUserProfileAsync(UserProfile userProfile)
        {
            var errors = new List<string>();

            if (await _context.UserProfiles.AnyAsync(u => u.Username == userProfile.Username))
            {
                errors.Add("ユーザー名は既に存在します。");
            }

            if (await _context.UserProfiles.AnyAsync(u => u.Email == userProfile.Email))
            {
                errors.Add("メールアドレスは既に存在します。");
            }

            if (errors.Any())
            {
                return (false, errors);
            }

            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();

            return (true, new List<string>());
        }

        public async Task<bool> UserProfileExistsAsync(string username, string email)
        {
            return await _context.UserProfiles.AnyAsync(u => u.Username == username || u.Email == email);
        }
    }
}
