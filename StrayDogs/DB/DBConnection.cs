using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayDogs.DB
{
    internal class DBConnection
    {
        //
        public static Stray_DogsEntities stray_Dogs = new Stray_DogsEntities();

        public static Employee logginedEmployee;
    }
}
 