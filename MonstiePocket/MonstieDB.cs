using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstiePocket
{
    static class MonstieDB
    {
        public static void Add(Monstie monster)
        {
            EdoMonstieContext myContext = new EdoMonstieContext();
            myContext.Monsties.Add(monster);
            myContext.SaveChanges();
        }
    }
}
