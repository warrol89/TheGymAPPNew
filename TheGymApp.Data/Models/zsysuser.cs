using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheGymApp.Data
{
    public class ZSysUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(50)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }

    }
}
