using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Developer_forum.Models
{
    public class Answer
    {
        public ApplicationUser applicationUser { get; set; } //foreign key for userid
        [ForeignKey("applicationUser")]
        [MaxLength(128)]
        public string Id { get; set; }

        public Question question { get; set; }
        [ForeignKey("question")]
        public int quesId { get; set; }

        [Key]
        public int ansId { get; set; }

        [Required]
        [MinLength(10)]
        public string answer { get; set; }
    }
}