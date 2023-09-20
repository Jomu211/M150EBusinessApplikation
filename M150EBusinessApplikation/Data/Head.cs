using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M150EBusinessApplikation.Data
{
    public class Head
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 1)]
        public string? Haircolor { get; set; }
        [StringLength(25, MinimumLength = 1)]
        public string? Headgear { get; set; }
        [StringLength(25, MinimumLength = 1)]
        public string? Other { get; set; }
        [ForeignKey("Champion")]
        public int ChampionId { get; set; }
        public virtual Champion Champion { get; set; }
    }
}
