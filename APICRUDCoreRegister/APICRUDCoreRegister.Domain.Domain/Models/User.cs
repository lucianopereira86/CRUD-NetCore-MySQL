namespace APICRUDCoreRegister.Domain.Domain.Models
{
    public class User
    {
        public int idUser { get; set; }
        public int idProfile { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
