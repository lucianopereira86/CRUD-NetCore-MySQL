using System.ComponentModel.DataAnnotations;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models.VM
{
    public class UserDeleteVM
    {
        /// <summary>
        /// User ID
        /// </summary>
        [Required]
        public int idUser { get; set; }
    }
}
