using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WKSADB
{
    [MetadataType(typeof(StudentMetaData))]
    partial class Student
    {
    }

    public class StudentMetaData
    {
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int RankId { get; set; }

        [Required]
        public int SchoolId { get; set; }
    }
}