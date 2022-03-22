using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.StateLGAServices
{
    public interface IStateService
    {
        List<State> GetAll();
        State GetById(int id);
        void Insert(State model);
        void Update(State model);
        void Delete(State model);
    }
}
