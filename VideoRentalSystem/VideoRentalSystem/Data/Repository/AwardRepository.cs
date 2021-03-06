﻿using System.Data.Entity;
using VideoRentalSystem.Data.SqLite.Contracts;
using VideoRentalSystem.Models;

namespace VideoRentalSystem.Data.Repository
{
    public class AwardRepository : Repository<Award>, IAwardRepository
    {
        public AwardRepository(DbContext context) 
            : base(context)
        {
        }
    }
}
