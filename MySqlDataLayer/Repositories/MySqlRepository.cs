using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Data;

namespace MySqlDataLayer.Repositories
{
    public class MySqlRepository: IRepository
    {
        protected MySqlContext context;
        public MySqlRepository(MySqlContext context) {
            this.context = context;
        }
    }
}
