using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFUserContractRepository : EF_CRUD<UserContract>, IUserContractRepository
    {
        public EFUserContractRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
