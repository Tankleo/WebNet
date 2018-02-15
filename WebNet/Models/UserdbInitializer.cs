using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    public class UserdbInitializer : DropCreateDatabaseAlways<WebNetContext>
    {
        protected override void Seed(WebNetContext context)
        {
            context.Users.Add(new User
            {
                FName = "Sam",
                LName = "Smith",
                Login = "sam80",
                Password = "123456",
                Email = "sam1980@gmail.com",
                Phone = "+190698712344",
                CreatedAt = DateTime.Now,
                Gender = false,
                isOnline = false,
                Salt = "tdrtrd5454ydry4r5y4d6dx45",
                isDeleted = false
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}