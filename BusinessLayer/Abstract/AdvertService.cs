using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface AdvertService : GenericService<Advert>
    {
        public void RestoreDelete(Advert p);
        public void FullDelete(Advert p);
    }
}
