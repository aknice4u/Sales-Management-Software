using MSAS.Core;
using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.StateLGAServices
{
   public class StateService:IStateService
    {
       private IRepository<State> StateRepo;
       public StateService(IRepository<State> stateRepository)
        {
            this.StateRepo = stateRepository;
        }

       public List<State> GetAll()
        {
            return StateRepo.GetAll().ToList();
        }

       public State GetById(int id)
        {
            if (id == 0)
                return null;
            return StateRepo.GetById(id);
        }

       public void Insert(State model)
        {
            if (model == null)
                throw new ArgumentNullException("Class");
            StateRepo.Insert(model);
        }

       public void Update(State model)
        {
           // if (model == null)
              //  throw new ArgumentNullException("product");
            StateRepo.Update(model);
        }

       public void Delete(State model)
        {
            if (model == null)
                throw new ArgumentNullException("product");
            StateRepo.Delete(model);
        }
    }
}
