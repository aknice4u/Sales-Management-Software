using MSAS.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Services.ClientServices
{
  /* public class ClientService<t> : IClientService<t> where t : class
    {
        private MSASContext db = null;
        private DbSet<t> table = null;

        public ClientService()
        {
            this.db = new MSASContext();
            table = db.Set<t>();
        }
        public IEnumerable<t> SelectAll()
        {
            return table.ToList();
        }
        public t SelectByID(object Id)
        {
            return table.Find(Id);
        }
        public void Insert(t obj)
        {
            table.Add(obj);;
        }
        public void Update(t obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            t existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }*/
}
