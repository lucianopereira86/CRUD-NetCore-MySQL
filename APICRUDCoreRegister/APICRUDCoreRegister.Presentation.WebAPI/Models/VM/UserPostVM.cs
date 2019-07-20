using APICRUDCoreRegister.Presentation.WebAPI.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models.VM
{
    public class UserPostVM
    {
        /// <summary>
        /// Profile ID
        /// </summary>
        [Required]
        public EnumProfileVM idProfile { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string email { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string password { get; set; }
        /// <summary>
        /// Is active?
        /// </summary>
        public bool isActive { get; set; }
    }
}
