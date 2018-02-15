using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CommentId { get; set; }

        public long CommentOwnerUserId { get; set; }
        public long PostId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public System.DateTime CreatedAt { get; set; }

        [ForeignKey("CommentOwnerUserId")]
        public virtual User CommentOwnerUser { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

    }
}