using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.StateLGAServices
{
    public interface ILGAService
    {
        List<LGA> GetAll();
        LGA GetById(int id);
        void Insert(LGA model);
        void Update(LGA model);
        void Delete(LGA model);
    }
}
