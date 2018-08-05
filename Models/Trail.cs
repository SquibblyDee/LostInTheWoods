using System.ComponentModel.DataAnnotations;

namespace LostInTheWoods.Models
{
    public abstract class BaseEntity {}
    public class Trail : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        public int Length { get; set; }
        public int Elevation { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
    }
}