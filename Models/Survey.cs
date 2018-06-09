using System;
using System.ComponentModel.DataAnnotations;
namespace dojoSurvey_Model.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 chars long!")]
        [MaxLength(35, ErrorMessage = "Must be at most 35 chars long!")]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 chars long!")]
        [MaxLength(15, ErrorMessage = "Must be at most 15 chars long!")]
        public string Language { get; set; }
        [MinLength(8, ErrorMessage = "Must be at least 8 chars long!")]
        [MaxLength(30, ErrorMessage = "Must be at most 30 chars long!")]
        public string Comment { get; set; }
    }
}