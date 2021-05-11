using SEDC.HomeWork.TimeTracking.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract void GetInfo();
    }
}
