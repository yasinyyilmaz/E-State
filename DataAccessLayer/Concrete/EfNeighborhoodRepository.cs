using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfNeighborhoodRepository : GenericRepository<Neighborhood, DataContext>, INeighborhoodRepository
    {
        private DataContext context;
        public EfNeighborhoodRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
