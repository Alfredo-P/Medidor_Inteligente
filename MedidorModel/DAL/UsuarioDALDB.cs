using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class UsuarioDALDB : IUsuarioDAL
    {
        private Medidor_inteligenteEntities medidorDB = new Medidor_inteligenteEntities();
        public void agregarUsuario(usuario usuario)
        {
            this.medidorDB.usuarios.Add(usuario);
            this.medidorDB.SaveChanges();

        }

        public void eliminarUsuario(int id)
        {

            usuario usuario = this.medidorDB.usuarios.Find(id);
            this.medidorDB.usuarios.Remove(usuario);
            this.medidorDB.SaveChanges();

        }

        public usuario Obtener(int id)
        {
            return this.medidorDB.usuarios.Find(id);

        }
        public void actualizar(usuario us)
        {
            usuario usu = this.medidorDB.usuarios.Find(us.id_usuario);
            usu.nombre = us.nombre;
            usu.rut    = us.rut;
            usu.correo = us.correo;
            usu.contrasena = us.contrasena;
            this.medidorDB.SaveChanges();
        }
        public List<usuario> ObtenerUsuario()
        {
            return this.medidorDB.usuarios.ToList();
        }
    }
}
