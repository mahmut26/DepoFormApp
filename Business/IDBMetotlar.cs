using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public interface IDBMetotlar
    {
        Guid DepoKaydet(Depo depo);
        Depo KayitGetir(Guid id);
        void DepoDuzenle(Depo depo);

    }
}
