using System;
using System.Collections.Generic;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataBase.EntityFramework
{
    public abstract class EF_CRUD<T> : ICommonRepository<T>
        where T : class
    {
        ApplicationContext db;
        DbSet<T> table;
        IEnumerable<T> tableInMemory;

        public EF_CRUD(ApplicationContext db)
        {
            this.db = db;
            table = db.Set<T>();
            tableInMemory = table.Local;
        }

        public virtual void Add(T item)
        {
            table.Add(item);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return table;
        }

        public virtual T GetById(int id)
        {
            return table.Find(id);
        }

        public virtual void Save()
        {
            db.SaveChanges();
        }

        public virtual void Update(T item)
        {
            table.Update(item);
        }

        public virtual void Delete(int id)
        {
            Delete(GetById(id));
        }

        public virtual void Delete(T item)
        {
            table.Remove(item);
        }

        public virtual IEnumerable<T> GetLocal()
        {
            return tableInMemory;
        }
    }
}
