using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        public int MovieId {get;set;}
        public Movie? ActorMovie { get; set; }

    }
}