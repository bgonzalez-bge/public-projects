using ModusCreateNewsFeed.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Models.DB
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Password can't be longer than 50 characteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public  ICollection<Subcription> Subcriptions { get; set; }
    }
}
