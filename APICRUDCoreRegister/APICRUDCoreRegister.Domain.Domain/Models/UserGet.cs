namespace APICRUDCoreRegister.Domain.Domain.Models
{
    public class UserGet
    {
        public int? idUser { get; set; }
        public int? idProfile { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public bool? isActive { get; set; }
    }
}
