using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M150EBusinessApplikation.Data
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserProfil")]
        public int UserProfilId { get; set; }
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Feedback")]
        public string FeedbackText { get; set; }

        [Display(Name = "Last Feedback")]
        public DateTime FeedbackTime { get; set; } = DateTime.Now;

        //Star Rating 1-5
        [Range(1, 5)]
        [Required]
        [Display(Name = "Rating")]
        public int Rating { get; set; } = 5;
        public virtual UserProfil UserProfil { get; set; }

        public Feedback() { }
        public Feedback(string username, string feedbackText)
        {
            Username = username;
            FeedbackText = feedbackText;
        }
    }
}
