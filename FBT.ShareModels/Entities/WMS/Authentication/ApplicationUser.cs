using Microsoft.AspNetCore.Identity;

namespace FBT.ShareModels.WMS
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? Localtion { get; set; }
        public EnumStatus? Status { get; set; }
    }
}
