using MSAS.Core;
using MSAS.Core.UsersMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace MSAS.Services.ClientServices
{
    public class UserService : IUserService
    {
       private IRepository<Users> UserRepo;
       public UserService(IRepository<Users> menuGroupRepository)
        {
            this.UserRepo = menuGroupRepository;
        }

       public List<Users> GetAll()
        {
            return UserRepo.GetAll().ToList();
        }

       public Users GetById(int id)
        {
            if (id == 0)
                return null;
            return UserRepo.GetById(id);
        }

       public void Insert(Users model)
        {
            if (model == null)
                throw new ArgumentNullException("Class");
            UserRepo.Insert(model);
        }

       public void Update(Users model)
        {
           // if (model == null)
              //  throw new ArgumentNullException("product");
            UserRepo.Update(model);
        }

       public void Delete(Users model)
        {
            if (model == null)
                throw new ArgumentNullException("product");
            UserRepo.Delete(model);
        }


       public List<loginModel> LoginUser(string em, string ps)
       {
        var s = (from b in UserRepo.Table
                where b.Email == em && b.Password == ps
                select new loginModel
                {
                    Password = b.Password,
                    UserId = b.UserId,
                    Email = b.Email
                });
        return s.ToList();

       }
   
    }
}
