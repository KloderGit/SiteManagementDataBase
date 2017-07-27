using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;
using System.Linq;

namespace DataBase.EntityFramework
{
    public class EFUserRepository : EF_CRUD<User>, IUserRepository
    {
        public EFUserRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
