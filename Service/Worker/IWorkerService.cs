using Pierwszy_projekt_na_serio.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Service.Worker
{
    public interface IWorkerService
    {
        Task<IEnumerable<WorkerInformation>> GetWorkers();
    }
}
