using DataLayer.Database;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBMetot : IDBMetotlar
    {
        public Guid DepoKaydet(Depo depo)
        {
            using (var context = new DBContext())
            {
               depo.Id = Guid.NewGuid();

               context.depos.Add(depo);

               context.SaveChanges();

               var deger = depo.Id; 

               return deger;

            }
        }

        public Depo KayitGetir(Guid id)
        {
            using (var context = new DBContext())
            {

                var a = context.depos.FirstOrDefault(x => x.Id == id);

                return a;
            }
        }
        public void DepoDuzenle(Depo depo) 
        {
            using (var context = new DBContext())
            {
                context.depos.Update(depo);

                context.SaveChanges();
                
            }
        }
    }
}
