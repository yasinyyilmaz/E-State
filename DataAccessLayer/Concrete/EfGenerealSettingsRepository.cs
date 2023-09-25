using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfGeneralSettingsRepository : GenericRepository<GeneralSettings, DataContext>, IGeneralSettingsRepository
    {
        private DataContext context;
        public EfGeneralSettingsRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
