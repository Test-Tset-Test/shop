﻿using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Data;

namespace MsSqlDataLayer.Repositories
{
    public class MsSqlRepository : IRepository
    {
        protected MsSqlContext context;
        protected MsSqlRepository(MsSqlContext context)
        {
            this.context = context;
        }
    }
}
