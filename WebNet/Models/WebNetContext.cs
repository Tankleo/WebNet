namespace WebNet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using WebNet.Models;

    public class WebNetContext : DbContext
    {

        static WebNetContext()
        {
            //Database.SetInitializer(new UserdbInitializer());
        }

        public WebNetContext()
     : base("name=WebNetContext")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<PostToMessages> PostToMessages { get; set; }
        public virtual DbSet<ConversationToUsers> ConversationToUsers { get; set; }
        public virtual DbSet<ConversationToMessages> ConversationToMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }

    
}