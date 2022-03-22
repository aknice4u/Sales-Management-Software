using MSAS.Core.UsersMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.ClientServices
{
    public interface IUserService
    {
        List<Users> GetAll();
        Users GetById(int id);
        void Insert(Users model);
        void Update(Users model);
        void Delete(Users model);
        List<loginModel> LoginUser(string em, string ps);
      
    }
}
