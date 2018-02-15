using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PostId { get; set; }

        [Required]
        [ForeignKey("WallOwnerUser")]
        public long WallOwnerUserId { get; set; }

        [Required]
        [ForeignKey("PostOwnerUser")]
        public long PostOwnerUserId { get; set; }

        public string Description { get; set; }

        //for the creation of InverseProperty
        public virtual User WallOwnerUser { get; set; }

        //for the creation of InverseProperty
        public virtual User PostOwnerUser { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}