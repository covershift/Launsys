using Launsys.Data.Connection;
using Launsys.Entity.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launsys.Framework;

namespace Launsys.Data.Operations
{
    public class ServicioDL : ConexionDL, IOperaciones<ServicioBE>
    {
        public async Task<List<ServicioBE>> ConsultarLista()
        {
            List<ServicioBE>? wServicioList = null;

            try
            {
                using SqlDataReader dtr = await ExecuteCommandAsync("Maestro.consulta_servicio").Result.ExecuteReaderAsync();

                if (dtr.HasRows)
                {
                    wServicioList = new();

                    while (await dtr.ReadAsync())
                    {
                        wServicioList.Add(new ServicioBE(dtr.ValidatorDataReaderInt("id_estado"))
                        {
                            nombre = dtr.ValidatorDataReaderString("nombre"),
                            estado = (int)dtr.ValidatorDataReaderInt("estado")
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return wServicioList;
        }
        public async Task<ServicioBE> Consultar(int pId)
        {
            ServicioBE? wServicio = null;

            try
            {
                List<SqlParameter> wSqlParametersList = new();
                wSqlParametersList.Add((SqlParameter)(new SqlParameter("@pCodloccodpas", SqlDbType.Char, 9).Value = pId));

                using SqlDataReader dtr = await ExecuteCommandAsync("Maestro.consulta_servicio", wSqlParametersList).Result.ExecuteReaderAsync();

                if (dtr.HasRows)
                {
                    while (await dtr.ReadAsync())
                    {
                        wServicio = new ServicioBE(dtr.ValidatorDataReaderInt("id_estado"))
                        {
                            nombre = dtr.ValidatorDataReaderString("nombre"),
                            estado = (int)dtr.ValidatorDataReaderInt("estado")
                        };
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return wServicio;
        }

        public Task<bool> Actualizar()
        {
            throw new NotImplementedException();
        }

        

        public Task<bool> Desactivar()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Grabar()
        {
            throw new NotImplementedException();
        }
    }
}
