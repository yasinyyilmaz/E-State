using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfDistrictRepository : GenericRepository<District, DataContext>, IDistrictRepository
    {
        private DataContext context;
        public EfDistrictRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
