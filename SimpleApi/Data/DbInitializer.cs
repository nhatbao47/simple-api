using SimpleApi.Models;

namespace SimpleApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SimpleApiContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User { Name = "Admin", Title = "Administrator", Username = "admin", Password = "123456"},
                new User { Name = "Peter Pham", Title = "PM"}
            };

            foreach (var u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
