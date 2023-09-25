﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class SituationManager : SituationService
    {
        ISituationRepository _status;

        public SituationManager(ISituationRepository situationRepository)
        {
            _status = situationRepository;
        }

        public void Add(Situation p)
        {
            p.Status = true;
            _status.Add(p);
        }

        public void Delete(Situation p)
        {
            var status=_status.GetById(p.SituationId);
            status.Status = false;
            _status.Update(status);
        }

        public Situation GetById(int id)
        {
            return _status.GetById(id);
        }

        public List<Situation> List()
        {
            return _status.List();
        }

        public List<Situation> List(Expression<Func<Situation, bool>> filter)
        {
            return _status.List(filter);
        }

        public void Update(Situation p)
        {
            var status = _status.GetById(p.SituationId);
            status.SituationName = p.SituationName;
            _status.Update(status);
        }
    }
}
