﻿using Pierwszy_projekt_na_serio.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Repository.Clients
{
    public interface IClientRepository
    {
        Task<IEnumerable<ClientInformation>> GetClients();
        Task<ClientInformation> GetClient(int id);
        Task EditClient(ClientInformation clientInformation);
        Task AddClient(ClientInformation clientInformation);
    }
}
