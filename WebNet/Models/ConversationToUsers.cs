using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class ConversationToUsers
    {
        [Key]
        [Column(Order = 1)]
        public long ConversationId { get; set; }

        [Key]
        [Column(Order = 2)]
        public long UserId { get; set; }

        [ForeignKey("ConversationId")]
        public virtual Conversation ConversationID { get; set; }

        [ForeignKey("UserId")]
        public virtual User UserID { get; set; }
    }
}