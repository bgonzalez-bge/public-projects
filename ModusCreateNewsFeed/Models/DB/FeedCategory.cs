using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModusCreateNewsFeed.Models.DB
{
    public class FeedCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, ErrorMessage = "Description can't be longer than 100 characteres")]
        public string Description { get; set; }
        public ICollection<Feed> Feeds { get; set; }
    }
}
