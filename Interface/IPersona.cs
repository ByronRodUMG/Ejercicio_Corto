using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Corto.Interface
{
    internal interface IPersona
    {
        string Nombre { get; }
        int Edad { get; }

        void saludar();
        void CumplirAños();
    }
}
