using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class ConversationToMessages
    {
        [Key]
        [Column(Order = 1)]
        public long ConversationId { get; set; }

        [Key]
        [Column(Order = 2)]
        public long MessageId { get; set; }

        [ForeignKey("ConversationId")]
        public virtual Conversation ConversationID { get; set; }

        [ForeignKey("MessageId")]
        public virtual Message MessageID { get; set; }
    }
}