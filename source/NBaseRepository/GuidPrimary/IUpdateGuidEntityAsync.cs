namespace NBaseRepository.GuidPrimary
{
    using System;
    using Common;

    /// <summary>
    /// An interface used to describe a class that can update an entity of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IUpdateGuidEntityAsync<in TEntity> : IUpdateEntityAsync<TEntity, Guid>
        where TEntity : IGuidEntity
    {
    }
}
