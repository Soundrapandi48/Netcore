using System.ComponentModel.DataAnnotations.Schema;

namespace APIProject.Entities.Models
{
    [Table("UserInfo")]
    public class UserData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string Upduser { get; set; }
        public string UpdTime { get; set; }
    }
}
