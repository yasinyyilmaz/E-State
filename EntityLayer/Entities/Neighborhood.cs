using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Neighborhood
    {
        [Key]
        public int NeighborhoodId { get; set; }
        public string NeighborhoodName { get; set; }
        public bool Status { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}
