using ServiceContract.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContract.Business.Abstraction
{
    public interface IServiceContract
    {
        void Confirm(Model.ServiceContract service);
    }
}
