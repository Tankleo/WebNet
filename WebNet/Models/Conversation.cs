using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class Conversation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ConversationId { get; set; }

        public long OwnerUserId { get; set; }

        [Required]
        public System.DateTime CreatedAt { get; set; }

        [ForeignKey("OwnerUserId")]
        public virtual User OwnerUserID { get; set; }
    }
}