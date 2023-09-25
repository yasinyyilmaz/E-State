using DataAccessLayer.Abstract;
using DataAccessLayer.Data;

namespace DataAccessLayer.Concrete
{
    public class EfTypeRepository : GenericRepository<EntityLayer.Entities.Type, DataContext>, ITypeRepository
    {
        private DataContext context;
        public EfTypeRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
