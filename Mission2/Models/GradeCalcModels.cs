using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2.Models
{
    public class GradeCalcModels
    {
        [Required]
        public byte Assign { get; set; }

        [Required]
        public byte Group { get; set; }

        [Required]
        public byte Quiz { get; set; }
        
        [Required]
        public byte Exam { get; set; }

        [Required]
        public byte Intex { get; set; }
    }
}
