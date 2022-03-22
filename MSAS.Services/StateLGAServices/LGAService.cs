using MSAS.Core;
using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.StateLGAServices
{
    public class LGAService:ILGAService
    {
        private IRepository<LGA> lgaRepo;
       public LGAService(IRepository<LGA> lgaRepository)
        {
            this.lgaRepo = lgaRepository;
        }

       public List<LGA> GetAll()
        {
            return lgaRepo.GetAll().ToList();
        }

       public LGA GetById(int id)
        {
            if (id == 0)
                return null;
            return lgaRepo.GetById(id);
        }

       public void Insert(LGA model)
        {
            if (model == null)
                throw new ArgumentNullException("Class");
            lgaRepo.Insert(model);
        }

       public void Update(LGA model)
        {
           // if (model == null)
              //  throw new ArgumentNullException("product");
            lgaRepo.Update(model);
        }

       public void Delete(LGA model)
        {
            if (model == null)
                throw new ArgumentNullException("product");
            lgaRepo.Delete(model);
        }
    }

    
}
