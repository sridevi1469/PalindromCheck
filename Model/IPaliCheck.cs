using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaliAPI.Model
{
    interface IPaliCheck
    {
        Task<PaliCheck> GetPaliCheck();
    }
}
