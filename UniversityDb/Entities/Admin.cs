using System.ComponentModel.DataAnnotations;


namespace UniversityDb.Entities
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Key]
        public string AdminName { get; set; }
    }
}
