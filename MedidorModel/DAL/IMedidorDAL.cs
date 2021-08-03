using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace MedidorModel.DAL
{
    public interface IMedidorDAL
    {
        List<medidor> ObtenerMedidor();
        medidor Obtener(int id);
        void agregarMedidor(medidor medidor);
        void eliminarMedidor(int id);

    }
}
