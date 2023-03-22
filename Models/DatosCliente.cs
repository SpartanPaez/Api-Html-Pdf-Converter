using Api.Clientes.ReporteActualizacionDatos.Models;

namespace WebApp.Models
{
    public class DatosCliente
    {
        /// <summary>
        /// Nombres del cliente
        /// </summary>
        /// <value></value>
        public string Nombres { get; set; }
        /// <summary>
        /// Apellidos del cliente
        /// </summary>
        /// <value></value>
        public string Apellidos { get; set; }
        /// <summary>
        /// Cedula del cliente
        /// </summary>
        /// <value></value>
        public string Cedula { get; set; }
        /// <summary>
        /// Ruc del cliente
        /// </summary>
        /// <value></value>
        public string Ruc { get; set; }
        public string CodigoCliente { get; set; }
        public string Direccion { get; set; }
        public string NumeroDireccion { get; set; }
        public string ReferenciaDireccion { get; set; }
        public string Edificio { get; set; }
        public string Piso { get; set; }
        public string DepartamentoNumero { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public string RedSocial { get; set; }
        public List<DatosCuentas> Cuentas { get; set; }
        public string LugarDeTrabajo { get; set; }
        public string Profesion { get; set; }
        public string Ocupacion { get; set; }
        public string DireccionLaboral { get; set; }
        public string NumeroDireccionLaboral { get; set; }
        public string ReferencialDireccionLaboral { get; set; }
        public string EdificioLaboral { get; set; }
        public string PisoLaboral { get; set; }
        public string NumeroDeptoLaboral { get; set; }
        public string BarrioLaboral { get; set; }
        public string CiudadLaboral { get; set; }
        public string DepartamentoLaboral { get; set; }
        public string TelefonoLaboral { get; set; }
        public string CelularLaboral { get; set; }
        public string CorreoLaboral { get; set; }
        public string CanalExtracto { get; set; }
        public string CanalExtractoMail { get; set; }
        public string DireccionTarjeta { get; set; }
    }
}
