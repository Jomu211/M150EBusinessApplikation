using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M150EBusinessApplikation.Data
{
    public class UserGameChampion
    {
        [Key]
        public int Id { get; set; }
        public bool Hidden { get; set; }
        public bool Chosen { get; set; }
        [ForeignKey("Champion")]
        public int ChampionId { get; set; }
        public string Username { get; set; }
        public bool Bought { get; set; }
        public virtual Champion Champion { get; set; }
    }
}
