﻿namespace NBaseRepository
{
    public interface IEntity<out T>
    {
        T Id { get; }
    }
}
