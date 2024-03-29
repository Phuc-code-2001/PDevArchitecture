﻿using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.EntityFrameworkCore.DataAccess;

namespace PDevArchitecture.Core.Repositories.Abstracts
{
    public abstract class RepositoryCore
    {
        protected readonly IConfiguration _configuration;
        protected readonly AppDbContext _dbContext;

        public RepositoryCore(AppDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }


    }
}
