using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfSituationRepository : GenericRepository<Situation, DataContext>, ISituationRepository
    {
        private DataContext context;
        public EfSituationRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
