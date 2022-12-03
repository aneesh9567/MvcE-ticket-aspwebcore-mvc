using System.ComponentModel.DataAnnotations;

namespace MvcE_ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationship
        public List<Movie> Movies { get; set; }

    }
}
