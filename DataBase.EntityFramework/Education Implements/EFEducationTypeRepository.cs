using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFEducationTypeRepository : EF_CRUD<EducationType>, IEducationTypeRepository
    {
        public EFEducationTypeRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
