using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.api.Entities
{
    public class PointOfInterest
    {
        [Key]// not needed if name is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

       // [ForeignKey("CityId")]// not necessary in our case since we are using the convention
        //by convention if City has id this will become the foreign key for relations
        public int CityId { get; set; }
        public City City { get; set; }

    }
}