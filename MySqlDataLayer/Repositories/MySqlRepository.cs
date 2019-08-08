using Contracts.Data;

namespace MySqlDataLayer.Repositories
{
    public class MySqlRepository: IRepository
    {
        protected MySqlContext context;
        protected MySqlRepository(MySqlContext context) {
            this.context = context;
        }
    }
}
