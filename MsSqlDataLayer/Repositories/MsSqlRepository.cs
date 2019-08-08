﻿using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Data;
using MySqlDataLayer;

namespace MsSqlDataLayer.Repositories
{
    public class MsSqlRepository : IRepository
    {
        protected MsSqlContext context;
        public MsSqlRepository(MsSqlContext context)
        {
            this.context = context;
        }
    }
}