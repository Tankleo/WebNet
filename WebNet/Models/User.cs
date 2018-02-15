using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class User
    {
        //is Required
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [Required]
        [MinLength(3), MaxLength(32)]
        public string FName { get; set; }

        [MinLength(3), MaxLength(32)]
        [Required]
        public string LName { get; set; }

        [MinLength(3), MaxLength(32)]
        [Required]
        public string Login { get; set; }

        [MinLength(6), MaxLength(20)]
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public bool isOnline { get; set; }

        //Describes if user deleted his account
        [Required]
        public bool isDeleted { get; set; }

        //to protect personal data
        [Required]
        public string Salt { get; set; }

        ////is Optional
        //public DateTime BirthDate { get; set; }
        //public string City { get; set; }
        //public string Language { get; set; }


        //Describes if session is valid. Connections: one to many
        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<Conversation> Conversations { get; set; }

        //The InverseProperty is used becouse we have multiple relationships between classes: Friend and User; Post and User.
        [InverseProperty("User")]
        public virtual ICollection<Friend> Users { get; set; }

        [InverseProperty("UserFriend")]
        public virtual ICollection<Friend> Friends { get; set; }

        [InverseProperty("WallOwnerUser")]
        public virtual ICollection<Post> WallOwnerUsers { get; set; }

        [InverseProperty("PostOwnerUser")]
        public virtual ICollection<Post> PostOwnerUsers { get; set; }
    }
}