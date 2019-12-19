using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDay { get; set; }
    }
}
