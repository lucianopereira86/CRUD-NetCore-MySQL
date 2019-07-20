using System.ComponentModel.DataAnnotations;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models.VM
{
    public class UserPutVM: UserPostVM
    {
        /// <summary>
        /// User ID
        /// </summary>
        [Required]
        public int idUser { get; set; }
    }
}
