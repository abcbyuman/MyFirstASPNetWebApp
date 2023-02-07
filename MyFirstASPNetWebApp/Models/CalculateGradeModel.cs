using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNetWebApp.Models
{
    public class CalculateGradeModel
    {
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0,100, ErrorMessage = "Value for Assignments must be between 0-100")]
        public string assignments { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0, 100, ErrorMessage = "Value for Group Project must be between 0-100")]
        public string groupProject { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0, 100, ErrorMessage = "Value for Quizzes must be between 0-100")]
        public string quizzes { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0, 100, ErrorMessage = "Value for Midterm Exam must be between 0-100")]
        public string midtermExam { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0, 100, ErrorMessage = "Value for Final Exam must be between 0-100")]
        public string finalExam { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Range(0, 100, ErrorMessage = "Value for INTEX must be between 0-100")]
        public string intex { get; set; }


    }
}
