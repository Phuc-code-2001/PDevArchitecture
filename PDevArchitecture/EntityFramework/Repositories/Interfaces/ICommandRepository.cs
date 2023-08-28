﻿using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;

namespace PDevArchitecture.EntityFramework.Repositories.Interfaces
{
    public interface ICommandRepository<TEntity, TPrimary> :
        IHasCreateRepository<TEntity>,
        IHasUpdateRepository<TEntity>,
        IHasDeleteRepository<TEntity>
        where TEntity : BaseEntity<TPrimary>
    {

    }
}
