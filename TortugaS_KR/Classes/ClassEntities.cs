using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaS_KR.BD;

namespace TortugaS_KR.Classes
{
    class ClassEntities
    {
        public static TortugaS_FinishEntities context { get; set; } = new TortugaS_FinishEntities();
    }
}
