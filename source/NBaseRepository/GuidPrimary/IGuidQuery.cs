﻿namespace NBaseRepository.GuidPrimary
{
    using System;
    using Common;

    public interface IGuidQuery<TEntity> : IQuery<TEntity, Guid>
        where TEntity : IGuidEntity
    {
    }
}
