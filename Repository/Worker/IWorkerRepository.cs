using Pierwszy_projekt_na_serio.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Repository.Workers
{
    public interface IWorkerRepository
    {
        Task AddWorker(WorkerInformation workerInformation);
        Task EditWorker(WorkerInformation workerInformation);
        Task<WorkerInformation> GetWorker(int id);
        Task<IEnumerable<WorkerInformation>> GetWorkers();
    }
}
