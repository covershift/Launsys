using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Launsys.Data.Connection
{
    public abstract class ConexionDL
    {
        public string LoadConnectionString() => ConfigurationManager.ConnectionStrings["ConexionDb"].ConnectionString;

        public async Task<SqlCommand> ExecuteCommandAsync(string pCommand, List<SqlParameter>? pSqlParameters = null)
        {
            SqlConnection cnx = new (LoadConnectionString());
            SqlCommand cmd = new (pCommand, cnx) { CommandType = CommandType.StoredProcedure };

            if (pSqlParameters is not null)
            {
                foreach (var fParameter in pSqlParameters)
                {
                    cmd.Parameters.Add(fParameter);
                }
            }

            await cnx.OpenAsync().ConfigureAwait(false);
            return cmd;
        }
    }
}
