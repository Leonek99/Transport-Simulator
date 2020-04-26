using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pierwszy_projekt_na_serio.Data;
using Pierwszy_projekt_na_serio.Models.Entity;
using Pierwszy_projekt_na_serio.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Repository.Clients
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ClientRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddClient(ClientInformation clientInformation)
        {
            var client = _mapper.Map<Client>(clientInformation);
            await _context.AddAsync(client);

            await _context.SaveChangesAsync();

        }

        public async Task EditClient(ClientInformation clientInformation)
        {
            var client = _mapper.Map<Client>(clientInformation);
            _context.Update(client);

            await _context.SaveChangesAsync();
        }

        public async Task<ClientInformation> GetClient(int id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(x => x.ClientId == id);
            return _mapper.Map<ClientInformation>(client);
        }

        public async Task<IEnumerable<ClientInformation>> GetClients()
        {
            var client = await _context.Clients.ToListAsync();
            return _mapper.Map<IEnumerable<ClientInformation>>(client);
        }
    }
}
