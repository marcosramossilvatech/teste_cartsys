using Cartsys.Domain.Entities;
using Cartsys.Domain.Interfaces;
using Cartsys.Domain.Validators;

namespace Cartsys.Applications.Services
{
    public class DatabaseInitializerService
    {
        private readonly IDatabaseInitializerRepository _databaseInitializerRepository;

        public DatabaseInitializerService(IDatabaseInitializerRepository databaseInitializerRepository)
        {
            _databaseInitializerRepository = databaseInitializerRepository;
        }

        public bool  InitializeDatabase()
        {
            var retorno =  _databaseInitializerRepository.InitializeDatabase();
            return retorno;
        }
    }
}
