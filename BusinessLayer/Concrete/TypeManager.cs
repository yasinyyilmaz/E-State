using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TypeManager : TypeService
    {
        ITypeRepository _typeRepository;

        public TypeManager(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public void Add(EntityLayer.Entities.Type p)
        {
            p.Status = true;
            _typeRepository.Add(p);
        }

        public void Delete(EntityLayer.Entities.Type p)
        {
            var type = _typeRepository.GetById(p.TypeId);
            type.Status = false;
            _typeRepository.Update(type);
        }

        public EntityLayer.Entities.Type GetById(int id)
        {
            return _typeRepository.GetById(id);
        }

        public List<EntityLayer.Entities.Type> List()
        {
            return _typeRepository.List();
        }

        public List<EntityLayer.Entities.Type> List(Expression<Func<EntityLayer.Entities.Type, bool>> filter)
        {
            return _typeRepository.List(filter);
        }

        public void Update(EntityLayer.Entities.Type p)
        {
            var type= _typeRepository.GetById(p.TypeId);
            type.TypeName= p.TypeName;
            type.SituationId=p.SituationId;
            _typeRepository.Update(type);
        }
    }
}
