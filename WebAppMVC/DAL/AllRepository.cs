using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMVC.Models;

namespace WebAppMVC.DAL
{
    public class AllRepository<T> : _I_AllRepository<T> where T : class
    {
        private DNDBWEBEntities _Context1;
        private IDbSet<T> dbEntity;

        public AllRepository()
        {
            _Context1 = new DNDBWEBEntities();
            dbEntity = _Context1.Set<T>();
        }
        void _I_AllRepository<T>.DeleteModel(int modelId)
        {
            T model = dbEntity.Find(modelId);
            dbEntity.Remove(model);
        }

        IEnumerable<T> _I_AllRepository<T>.GetModel()
        {
            return dbEntity.ToList();
        }

        T _I_AllRepository<T>.GetModelById(int modelId)
        {
            return dbEntity.Find(modelId);
        }

        void _I_AllRepository<T>.InsertModel(T Model)
        {
            dbEntity.Add(Model);
        }

        void _I_AllRepository<T>.save()
        {
            _Context1.SaveChanges();
        }

        void _I_AllRepository<T>.UpdateModel(T model)
        {
            _Context1.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }
    }
}