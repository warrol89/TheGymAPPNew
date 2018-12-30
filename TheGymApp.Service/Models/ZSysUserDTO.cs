using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheGymApp.Service.Models
{
    public class ZSysUserDTO
    {
        private string _userName;
        
        public int Id { get; set; }        
        public string UserName
        {
            get { return _userName = $"{FirstName}.{LastName}"; }
            
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }        
        public string Notes { get; set; }

    }
}
