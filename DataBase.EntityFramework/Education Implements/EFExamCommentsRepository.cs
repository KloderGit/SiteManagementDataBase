using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFExamCommentsRepository : EF_CRUD<ExamComment>, IExamCommentRepository
    {
        public EFExamCommentsRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
