using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerPwr.Engine.Models
{
    public class Realm
    {
        public Realm()
        {
            Characters = new List<Character>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
