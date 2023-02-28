using Dapper;
using MySql.Data.MySqlClient;
using training_dotnet6_api.Models;

namespace training_dotnet6_api.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly IConfiguration _configuration;
        public ContatoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public IEnumerable<Contato> GetAll() 
        {
            using MySqlConnection con = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection"));
            con.Open();
            var sqlStatetament = @"
                SELECT
                    contato.id,
                    contato.name,
                    contato.email,
                    contato.number
                FROM Contato AS contato;
            ";
            return con.Query<Contato>(sqlStatetament);

        }

        public Contato GetById(int id)
        {
            using MySqlConnection con = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection"));
            con.Open();
            var sqlStatetament = @"
                SELECT
                    contato.id,
                    contato.name,
                    contato.email,
                    contato.number
                FROM Contato AS contato
                WHERE contato.id = @Id;
            ";
            return con.QueryFirstOrDefault<Contato>(sqlStatetament, new { Id = id });
        }
    }
}
