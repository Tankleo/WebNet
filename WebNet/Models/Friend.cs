using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class Friend
    {
        [Required]
        [Key, ForeignKey("User"), Column(Order = 1)]
        public long UserId { get; set; }

        [Required]
        [Key, ForeignKey("UserFriend"), Column(Order = 2)]
        public long UserFriendId { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public bool isFollow { get; set; }

        //for the creation of InverseProperty
        public virtual User User { get; set; }

        //for the creation of InverseProperty
        public virtual User UserFriend { get; set; }
    }
}