﻿namespace NBaseRepository.IntPrimary
{
    using Common;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGetAllIntEntities<TEntity> : IGetAllEntities<TEntity, int>
        where TEntity : IIntEntity
    {
    }
}