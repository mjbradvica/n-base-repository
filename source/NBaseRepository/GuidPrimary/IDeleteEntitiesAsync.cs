﻿namespace NBaseRepository.GuidPrimary
{
    using System;
    using Common;

    /// <summary>
    /// An interface used to describe a class that can delete multiple entities of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IDeleteEntitiesAsync<in TEntity> : IDeleteEntitiesAsync<TEntity, Guid>
        where TEntity : IEntity
    {
    }
}
