using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfAdvertRepository : GenericRepository<Advert, DataContext>, IAdvertRepository
    {
        private DataContext context;
        public EfAdvertRepository(DataContext context) : base(context)
        {
            this.context=context;
        }

        public void FullDelete(Advert p)
        {
            var advert = context.Adverts.Find(p.AdvertId);
            context.Adverts.Remove(advert);
            context.SaveChanges();
        }
    }
}
