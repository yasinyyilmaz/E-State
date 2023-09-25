using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfImageRepository : GenericRepository<Images, DataContext>, IImageRepository
    {
        private DataContext context;
        public EfImageRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
