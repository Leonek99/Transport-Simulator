using Pierwszy_projekt_na_serio.Models.Information;
using Pierwszy_projekt_na_serio.Repository.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Service.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task AddClient(ClientInformation clientInformation)
        {
            await _repository.AddClient(clientInformation);
        }

        public async Task EditClient(ClientInformation clientInformation)
        {
            await _repository.EditClient(clientInformation);
        }

        public async Task<ClientInformation> GetClient(int id)
        {
            return await _repository.GetClient(id);
        }

        public async Task<IEnumerable<ClientInformation>> GetClients()
        {
            return await _repository.GetClients();
        }
    }
}
