using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataBase.EntityFramework
{
    class EFCategoryRepository : EF_CRUD<Category>, ICategoryRepository
    {
        public EFCategoryRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
