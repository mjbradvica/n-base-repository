namespace NBaseRepository.Common
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// An interface used to describe a class that can retrieve a single entity of type <see cref="TEntity"/> by an Id of type <see cref="TId"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TId">The type of the Id.</typeparam>
    public interface IGetByIdAsync<TEntity, in TId>
        where TEntity : IEntity<TId>
    {
        /// <summary>
        /// Retrieves an <see cref="TEntity"/> from a collection by Id.
        /// </summary>
        /// <param name="id">The Id of type <see cref="TId"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>An object of type <see cref="TEntity"/>.</returns>
        Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves an entity from a collection by Id that accepts a custom include func for eager loading.
        /// </summary>
        /// <param name="id">The Id of type <see cref="TId"/>.</param>
        /// <param name="includeFunc">An include func used for eager loading.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>An object of type <see cref="TEntity"/>.</returns>
        Task<TEntity> GetByIdAsync(TId id, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeFunc, CancellationToken cancellationToken);
    }
}
