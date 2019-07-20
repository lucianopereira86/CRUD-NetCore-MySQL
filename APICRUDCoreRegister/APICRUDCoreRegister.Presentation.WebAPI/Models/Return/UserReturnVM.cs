using APICRUDCoreRegister.Presentation.WebAPI.Models.Enum;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models.Return
{
    public class UserReturnVM
    {
        public int idUser { get; set; }
        public EnumProfileVM idProfile { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }
    }
}
