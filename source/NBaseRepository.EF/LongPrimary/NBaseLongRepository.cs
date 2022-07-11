﻿namespace NBaseRepository.EF.LongPrimary
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using LongPrimary;

    /* Unmerged change from project 'NBaseRepository.EF (netcoreapp3.1)'
    Before:
        using NBaseRepository.EF.Common;
    After:
        using NBaseRepository.EF.Common;
        using NBaseRepository;
        using NBaseRepository.EF;
        using NBaseRepository.EF.LongPrimary;
    */
    using NBaseRepository.EF.Common;

    /// <summary>
    /// A repository that accepts and <see cref="TEntity"/> with a primary key of <see cref="long"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class NBaseLongRepository<TEntity> : NBaseRepository<TEntity, long>
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NNBaseLongRepository{TEntity}"/> class that has no default eager loading.
        /// </summary>
        /// <param name="context">A <see cref="DbContext"/>.</param>
        protected NBaseLongRepository(DbContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NNBaseLongRepository{TEntity}"/> class that has eager loading.
        /// </summary>
        /// <param name="context">A <see cref="DbContext"/>.</param>
        /// <param name="includeFunc">An include func used for eager loading.</param>
        protected NBaseLongRepository(DbContext context, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeFunc)
            : base(context, includeFunc)
        {
        }
    }
}