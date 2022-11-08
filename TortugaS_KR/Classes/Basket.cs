using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaS_KR.BD;

namespace TortugaS_KR.Classes
{
    class Basket
    {
        public static List<Dish> dishes = new List<Dish>();
    }

    public interface MenuInterface 
    {
        void ChangeDishCount(int count);
    }

}
