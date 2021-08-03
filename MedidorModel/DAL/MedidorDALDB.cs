using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorDALDB : IMedidorDAL
    {
        private Medidor_inteligenteEntities medidorDB = new Medidor_inteligenteEntities();

        public void agregarMedidor(medidor medidor)
        {
            this.medidorDB.medidors.Add(medidor);
            this.medidorDB.SaveChanges();

        }

        public void eliminarMedidor(int id)
        {
            medidor medidor = this.medidorDB.medidors.Find(id);
            this.medidorDB.medidors.Remove(medidor);
            this.medidorDB.SaveChanges();

        }

        public medidor Obtener(int id)
        {
            return this.medidorDB.medidors.Find(id);

        }

        public List<medidor> ObtenerMedidor()
        {

            return this.medidorDB.medidors.ToList();

        }
        public void actualizar(medidor m)
        {
            medidor medidor = this.medidorDB.medidors.Find(m.id_medidor);
            medidor.fecha_medidor = m.fecha_medidor;
            medidor.ingreso = m.ingreso;
            medidor.valor_consumo = m.valor_consumo;
            this.medidorDB.SaveChanges();
        }

    }
}
