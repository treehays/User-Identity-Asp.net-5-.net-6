using Microsoft.AspNetCore.Identity;

namespace MVCWithIdentity.Models
{
    
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// 002 Adding my personal identities
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }
    }
}
