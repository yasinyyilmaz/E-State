using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public bool Status { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual List<Neighborhood> Neighborhoods {  get; set; }  
        public virtual List<Advert> Adverts { get; set; }
    
    }
}
