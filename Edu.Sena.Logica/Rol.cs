using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Sena.Datos;
using System.Data;

namespace Edu.Sena.Logica
{
    class Rol
    {
        private int id;
        private string tipo;
        public string sentencia;

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public void Insertar_Rol()
        {
            sentencia = "insert into dbo.roles (idRol, tipo) values ("+ id + ",'"+tipo+"') ";
            Conexion.Ejecutar(sentencia);
        }

        public void Actualizar_Rol()
        {
            sentencia = "UPDATE dbo.roles SET tipo='" + tipo + "'";
            Conexion.Ejecutar(sentencia);
        }

        public  DataTable consultar_rol()
        {
            sentencia = "SELECT * FROM dbo.roles";
            return Conexion.consultar(sentencia);
        }

    }
}
