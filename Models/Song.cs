using System.ComponentModel.DataAnnotations;

namespace Music_Library_Frontend.Models
{
    public class Song
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
