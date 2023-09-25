using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class NeighborhoodManager : NeighborhoodService
    {
        INeighborhoodRepository _neighborhood;

        public NeighborhoodManager(INeighborhoodRepository neighborhoodRepository)
        {
            _neighborhood = neighborhoodRepository;
        }

        public void Add(Neighborhood p)
        {
            p.Status = true;
            _neighborhood.Add(p);
        }

        public void Delete(Neighborhood p)
        {
            var neighborhood = _neighborhood.GetById(p.NeighborhoodId);
            neighborhood.Status = false;
            _neighborhood.Update(neighborhood);
        }

        public Neighborhood GetById(int id)
        {
            return _neighborhood.GetById(id);
        }

        public List<Neighborhood> List()
        {
            return _neighborhood.List();
        }

        public List<Neighborhood> List(Expression<Func<Neighborhood, bool>> filter)
        {
            return _neighborhood.List(filter);
        }

        public void Update(Neighborhood p)
        {
            p.Status = true;
            _neighborhood.Update(p);
        }
    }
}
