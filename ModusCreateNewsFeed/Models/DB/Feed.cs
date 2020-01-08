using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModusCreateNewsFeed.Models.DB
{
    public class Feed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title can't be longer than 100 characteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "URL is required")]
        [StringLength(500, ErrorMessage = "URL can't be longer than 500 characteres")]
        public string URL { get; set; }

        [StringLength(1000, ErrorMessage = "Description can't be longer than 1000 characteres")]
        public string Description { get; set; }

        public int FeedCategoryId { get; set; }
        public FeedCategory FeedCategory { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Subcription> Subcriptions { get; set; }
    }
}
