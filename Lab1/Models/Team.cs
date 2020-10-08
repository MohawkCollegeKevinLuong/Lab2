using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public string EstablishedDate { get; set; }


    }
}
