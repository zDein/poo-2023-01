using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Calendario
    {
        private IList<DateTime> datas;

        public IList<DateTime> GetDatas()
        {
            return datas;
        }

        public void SetDatas(IList<DateTime> value)
        {
            datas = value;
        }

        public Calendario()
        {
            this.SetDatas(new List<DateTime>());
        }

        public void MostrarDatas()
        {
            int i = 0;
            foreach (var data in GetDatas())
            {
                Console.WriteLine($"#{++i}- {data}");
            }
        }
    }
}
