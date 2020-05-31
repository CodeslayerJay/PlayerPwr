using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlayerPwr.Engine.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public int Points { get; set; }

        public string Comment { get; set; }

        public string ReportingUserExternalId { get; set; }

        public Character Character { get; set; }

        public IUser User { get; set; }
    }
}
