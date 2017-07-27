using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFUserCardRepository : EF_CRUD<UserCard>, IUserCardRepository
    {
        public EFUserCardRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
