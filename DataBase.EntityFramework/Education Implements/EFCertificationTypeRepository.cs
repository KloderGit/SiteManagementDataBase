using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFCertificationTypeRepository : EF_CRUD<CertificationType>, ICertificationTypeRepository
    {
        public EFCertificationTypeRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
