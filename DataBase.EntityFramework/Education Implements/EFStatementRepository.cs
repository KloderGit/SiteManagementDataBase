using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFStatementRepository : EF_CRUD<Statement>, IStatementRepository
    {
        public EFStatementRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
