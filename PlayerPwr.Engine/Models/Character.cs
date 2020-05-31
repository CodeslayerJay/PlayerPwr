using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerPwr.Engine.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string UserExternalId { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }
        public int ILvl { get; set; }

        public string Spec { get; set; }

        public int RealmId { get; set; }
        public Realm Realm { get; set; }

        public IUser User { get; set; }

    }
}
