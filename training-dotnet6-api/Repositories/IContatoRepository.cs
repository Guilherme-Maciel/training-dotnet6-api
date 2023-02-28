using training_dotnet6_api.Models;

namespace training_dotnet6_api.Repositories
{
    public interface IContatoRepository
    {
        public IEnumerable<Contato> GetAll();
        public Contato GetById(int id);
    }
}
