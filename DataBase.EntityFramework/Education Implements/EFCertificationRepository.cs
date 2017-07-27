using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFCertificationRepository : EF_CRUD<Certification>, ICertificationRepository
    {
        public EFCertificationRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
