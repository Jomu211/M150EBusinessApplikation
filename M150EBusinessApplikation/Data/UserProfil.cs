using System.ComponentModel.DataAnnotations;

namespace M150EBusinessApplikation.Data
{
    public class UserProfil
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public int? Tries { get; set; }
        public int? Coins { get; set; }
    }
}
