using System;
using System.Collections.Generic;
using System.Text;

namespace IOOPMVC.Business.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }
    }
}
