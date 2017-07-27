using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFUserCommentsRepository : EF_CRUD<UserComment>, IUserCommentRepository
    {
        public EFUserCommentsRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
