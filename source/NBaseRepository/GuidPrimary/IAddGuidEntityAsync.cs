﻿namespace NBaseRepository.GuidPrimary
{
    using System;
    using Common;

    /// <summary>
    /// An interface that allows a class to add a single entity of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IAddGuidEntityAsync<in TEntity> : IAddEntityAsync<TEntity, Guid>
        where TEntity : IEntity
    {
    }
}
