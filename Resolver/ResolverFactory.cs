using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace Resolver
{
    public class ResolverFactory 
    {
        public static IDependencyResolver GetResolver(string type)
        {
            if (type == "MySql")
                return new MySqlDependencyResolver();
            if (type == "MsSql")
                return new MsSqlDependencyResolver();

            return null;
        }
    }
}
