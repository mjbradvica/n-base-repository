namespace NBaseRepository.Common
{
    /// <summary>
    /// An interface that allows a class to add a single entity of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TId">The type of the Id.</typeparam>
    public interface IAddEntity<in TEntity, TId>
        where TEntity : IEntity<TId>
    {
        /// <summary>
        /// Adds a single <see cref="TEntity"/> to a collection.
        /// </summary>
        /// <param name="entity">The <see cref="TEntity"/> to be added.</param>
        /// <returns>The result contains the number of state entries written to the database.</returns>
        int AddEntity(TEntity entity);
    }
}