using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFSubGroupRepository : EF_CRUD<SubGroup>, ISubGroupRepository
    {
        public EFSubGroupRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
