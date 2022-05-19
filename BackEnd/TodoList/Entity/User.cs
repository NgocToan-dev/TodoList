using System.ComponentModel.DataAnnotations;

namespace TodoList.Entity
{
    public class User : BaseEntity
    {
        [Key]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public User()
        {
        }
    }
}
