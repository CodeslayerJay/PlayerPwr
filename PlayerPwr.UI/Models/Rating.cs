using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlayerPwr.UI.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public int Points { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        [Required]
        [ForeignKey("User")]
        public string ReportingUserId { get; set; }

        public Character Character { get; set; }

        public ApplicationUser User { get; set; }
    }
}
