using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    class Controller
    {
        public bool campoIngresadosTractor(string text, DateTime value1, DateTime value2)
        {
            int result = DateTime.Compare(value1, value2);

            if (text.Equals(""))
            {
                return false;
            }else if (result > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
}
