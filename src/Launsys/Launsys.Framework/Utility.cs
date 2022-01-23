using System.Data.SqlClient;

namespace Launsys.Framework
{
    public static class Utility
    {
        public static string ValidatorDataReaderString(this SqlDataReader pSqlDataReader, string pCampo)
        {
            var wValorReader = pSqlDataReader[pCampo];
            if (wValorReader != null)
            {
                string? wValorRetorno = Convert.ToString(pSqlDataReader[pCampo]);
                return _ = wValorRetorno == string.Empty ? null : wValorRetorno;
            }
            else
            {
                return null;
            }
        }

        public static string ValidatorDataReaderDate(this SqlDataReader pSqlDataReader, string pCampo)
        {
            string? wValorRetorno = Convert.ToString(pSqlDataReader[pCampo]);
            return _ = wValorRetorno == string.Empty ? null : wValorRetorno;
        }

        public static decimal? ValidatorDataReaderDecimal(this SqlDataReader pSqlDataReader, string pCampo)
        {
            bool wValorParse = decimal.TryParse(Convert.ToString(pSqlDataReader[pCampo]), out decimal oValorRetorno);
            return wValorParse ? oValorRetorno : null;
        }

        public static int? ValidatorDataReaderInt(this SqlDataReader pSqlDataReader, string pCampo)
        {
            var wValorReader = pSqlDataReader[pCampo];
            if (wValorReader != null)
            {
                bool wValorParse = int.TryParse(Convert.ToString(pSqlDataReader[pCampo]), out int oValorRetorno);
                return wValorParse ? oValorRetorno : 0;
            }
            else
            {
                return null;
            }
        }

        public static bool? ValidatorDataReaderBool(this SqlDataReader pSqlDataReader, string pCampo)
        {
            if (pSqlDataReader[pCampo] != null)
            {
                var wValor = Convert.ToString(pSqlDataReader[pCampo]);

                if (wValor == "1" || wValor == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return null;
            }
        }
    }
}