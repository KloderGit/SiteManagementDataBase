using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFUserProfileRepository : EF_CRUD<UserProfile>, IUserProfileRepository
    {
        public EFUserProfileRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
