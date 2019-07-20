using APICRUDCoreRegister.Presentation.WebAPI.Models.Enum;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models.VM
{
    public class UserGetVM
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? idUser { get; set; }
        /// <summary>
        /// Profile ID
        /// </summary>
        public EnumProfileVM? idProfile { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Is active?
        /// </summary>
        public bool? isActive { get; set; }
    }
}
