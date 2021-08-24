using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxForPartialUpdate.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Name required")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address required")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Telephone required")]
        [DisplayName("Telephone")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email required")]
        //[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Wrong email format")]  
        [EmailAddress]
        public string Email { get; set; }
    }
}
