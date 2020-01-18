using Arq.Commom;
using ServiceContract.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContract.DataAccess
{
    public interface IServiceContractRepository : IRepositoryManager<Model.ServiceContract>
    {
    }
}
