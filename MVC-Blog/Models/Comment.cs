using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Blog.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Text { get; set; }

        [StringLength(500)]
        public string VisitorName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Post Post { get; set; }
        public int Post_Id { get; set; }
    }
}