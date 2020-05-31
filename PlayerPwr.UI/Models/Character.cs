using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerPwr.UI.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Level { get; set; }
        public int ILvl { get; set; }

        [StringLength(30)]
        public string Spec { get; set; }

        public int RealmId { get; set; }
        public Realm Realm { get; set; }

        public ApplicationUser User { get; set; }
    }
}
