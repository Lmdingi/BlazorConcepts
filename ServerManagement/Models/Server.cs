using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {     
        // props
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        public bool IsOnline { get; set; }

        // fields

        // ctors
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0? false : true;
        }

        // methods
    }
}
