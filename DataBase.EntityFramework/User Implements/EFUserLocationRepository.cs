using System;
using System.Collections.Generic;
using Domain.Core.User;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    class EFUserLocationRepository : EF_CRUD<UserLocation>, IUserLocationRepository
    {
        public EFUserLocationRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
