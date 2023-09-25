using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ImageManager : ImageService
    {
        IImageRepository _imageRepository;

        public ImageManager(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public void Add(Images p)
        {
            _imageRepository.Add(p);
        }

        public void Delete(Images p)
        {
            _imageRepository.Delete(p);
        }

        public Images GetById(int id)
        {
            return _imageRepository.GetById(id);
        }

        public List<Images> List()
        {
            return _imageRepository.List();
        }

        public List<Images> List(Expression<Func<Images, bool>> filter)
        {
            return _imageRepository.List(filter);
        }

        public void Update(Images p)
        {
            var update = _imageRepository.GetById(p.ImageId);
            update.ImageName= p.Image.FileName;
            _imageRepository.Update(update);
        }
    }
}
