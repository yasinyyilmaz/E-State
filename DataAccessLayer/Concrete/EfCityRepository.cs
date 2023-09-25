using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfCityRepository : GenericRepository<City, DataContext>, ICityRepository
    {
        private DataContext context;
        public EfCityRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}