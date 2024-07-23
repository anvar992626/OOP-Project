using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitetsLager
{
    public class BokBokning
    {
        [Column("BokBokningId")]
        [Key]
        public int BokBokningId { get; set; }

        [Required]
        public int BokId { get; set; }
        public Bok Bok { get; set; }

        [Required]
        public int BokningId { get; set; }
        public Bokning Bokning { get; set; }
       
        //[Required]
        ////public int Id { get; set; } 
        //public int BokId { get; set; }
        //public Bok Bok { get; set; } = null!;

        //[Required]
        //public int BokningId { get; set; }
        //public Bokning Bokning { get; set; } = null!;
    }
}
