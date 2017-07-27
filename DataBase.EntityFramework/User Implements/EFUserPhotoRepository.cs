using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFUserPhotoRepository : EF_CRUD<UserPhoto>, IUserPhotoRepository
    {
        public EFUserPhotoRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
