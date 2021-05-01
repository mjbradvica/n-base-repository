﻿namespace NBaseRepository.LongPrimary
{
    using Common;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IGetAllLongEntities<TEntity> : IGetAllEntities<TEntity, long>
        where TEntity : ILongEntity
    {
    }
}
