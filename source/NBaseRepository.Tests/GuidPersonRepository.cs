﻿namespace NBaseRepository.Tests
{
    using EF;
    using Microsoft.EntityFrameworkCore;

    internal class GuidPersonRepository : BaseGuidRepository<GuidPerson>
    {
        public GuidPersonRepository(DbContext context)
            : base(context)
        {
        }
    }
}
