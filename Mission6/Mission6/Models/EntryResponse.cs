using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class EntryResponse
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage="The Movie Title field is required.")]
        public string movieTitle { get; set; }
   
        [Required(ErrorMessage = "The Movie Category field is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "The Year field is required.")]
        public int Year { get; set; }
 
        [Required(ErrorMessage = "The Director's Name field is required.")]
        public string directorName { get; set; }
     
        [Required(ErrorMessage = "The Movie Rating field is required.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string lentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }

    }
}
