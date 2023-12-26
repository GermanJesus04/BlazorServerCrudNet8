using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCrudNet8.Models
{
    [Table(name:"VIDEOGAME")]
    public class VideoGame
    {
        [Column(name:"ID")]
        public int Id { get; set; }

        [Column(name: "TITLE")]
        public string? Title { get; set; }

        [Column(name: "PUBLISHER")]
        public string? Publisher { get; set; }

        [Column(name: "RELEASE_YEAR")]
        public int ReleaseYear { get; set; }
    }
}
