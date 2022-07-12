﻿namespace NBaseRepository.EF.LongPrimary
{
    using System;
    using System.Linq;
    using Common;
    using Microsoft.EntityFrameworkCore;
    using NBaseRepository.LongPrimary;

    /// <summary>
    /// A repository that accepts and <see cref="TEntity"/> with a primary key of <see cref="long"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class NBaseRepository<TEntity> : NBaseRepository<TEntity, long>
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NNBaseLongRepository{TEntity}"/> class that has no default eager loading.
        /// </summary>
        /// <param name="context">A <see cref="DbContext"/>.</param>
        protected NBaseRepository(DbContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NNBaseLongRepository{TEntity}"/> class that has eager loading.
        /// </summary>
        /// <param name="context">A <see cref="DbContext"/>.</param>
        /// <param name="includeFunc">An include func used for eager loading.</param>
        protected NBaseRepository(DbContext context, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeFunc)
            : base(context, includeFunc)
        {
        }
    }
}