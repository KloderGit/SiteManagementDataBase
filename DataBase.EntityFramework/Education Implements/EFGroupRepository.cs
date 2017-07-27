using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFGroupRepository : EF_CRUD<Group>, IGroupRepository
    {
        public EFGroupRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
