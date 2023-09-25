using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IAdvertRepository : IRepository<Advert>
    {
        public void FullDelete(Advert p);
    }
}
