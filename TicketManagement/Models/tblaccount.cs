//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;

   
    public partial class tblaccount
    {
        [Required]
        public string branch { get; set; }
        [Required]
        public string department { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]
        public int id { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string MiddleName { get; set; }

        [Required]
        [MinLength(8,ErrorMessage = "Password should be at least 8 characters.")]
        [RegularExpression("^[a-zA-Z0-9_]+$", ErrorMessage = "Password should be composed of letters and numbers.")]
        public string password { get; set; }
        [Required]

        public string status { get; set; }
        [Required]
        public string username { get; set; }
        [Required]

        public string usertype { get; set; }
    }
   
}
