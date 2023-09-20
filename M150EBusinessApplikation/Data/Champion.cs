using System.ComponentModel.DataAnnotations;

namespace M150EBusinessApplikation.Data
{
    public class Champion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public string Name { get; set; }
        [Required]
        [StringLength(35, MinimumLength = 1)]
        public string? ImageUrl { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public string? Region { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string? Gender { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string? CombatStyle { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public string? Resource { get; set; }
        public int? Price { get; set; }
        public virtual List<UserGameChampion> UserGameChampions { get; set; }
        public virtual Head Head { get; set; }
    }
}
