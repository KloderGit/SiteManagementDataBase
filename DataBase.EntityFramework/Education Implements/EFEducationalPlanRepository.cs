using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFEducationalPlanRepository : EF_CRUD<EducationalPlan>, IEducationalPlanRepository
    {
        public EFEducationalPlanRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
