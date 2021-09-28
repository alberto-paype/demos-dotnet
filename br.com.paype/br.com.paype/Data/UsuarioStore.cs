using br.com.paype.Models.TI;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Data
{
    public class UsuarioStore
    {

        private SqlConnection _connection;
        private Usuario _usuario;

        public UsuarioStore(Usuario usuario)
        {
            string conString = Startup.StaticConfig.GetConnectionString("value");
            _connection = new SqlConnection(conString);
            _usuario = usuario;
        }

        public dynamic GetPermissoes()
        {
            try
            {

                string Sql = string.Format(@"SELECT 

	                                            TU.Username,
	                                            TPM.Role,
	                                            TP.Policy

                                            FROM   ti_usuario TU
                                                   LEFT JOIN ti_papel_usuario TPU
                                                          ON TPU.usuariohandle = TU.handle
                                                   LEFT JOIN ti_papel TP
                                                          ON TP.handle = TPU.papelhandle
                                                   LEFT JOIN ti_permissao TPM
                                                          ON TP.permissaohandle = TPM.handle
                                            WHERE  TU.username = '{0}' ", _usuario.Username);

                return _connection.Query<dynamic>(Sql).ToList();

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
