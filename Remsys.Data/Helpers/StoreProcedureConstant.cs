using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Data.Helpers
{
    public static class StoreProcedureConstant
    {
        #region Inserts
        public static string InsertInTblTipoDocumento => nameof(InsertInTblTipoDocumento);
        public static string InsertInTblPersona => nameof(InsertInTblPersona);
        public static string InsertInTblCliente => nameof(InsertInTblCliente);

        public static string InsertInTblAgenteInmobilario => nameof(InsertInTblAgenteInmobilario);
        public static string InsertInTblEncargadoDeVenta => nameof(InsertInTblEncargadoDeVenta);

        public static string InsertInTblAbogado => nameof(InsertInTblAbogado);
        public static string InsertInTblContrato => nameof(InsertInTblContrato);

        public static string InsertInTblTipoContrato => nameof(InsertInTblTipoContrato);
        public static string InsertInTblEstadoCita => nameof(InsertInTblEstadoCita);
       
        public static string InsertInTblHorario => nameof(InsertInTblHorario);

        public static string InsertInTblCita => nameof(InsertInTblCita);

        public static string InsertInTblRegistroCita => nameof(InsertInTblRegistroCita);

        public static string InsertInTblTipoReporte => nameof(InsertInTblTipoReporte);
        public static string InsertInTblReporte => nameof(InsertInTblReporte);

        public static string InsertInTblTipoOperacionInmueble => nameof(InsertInTblTipoOperacionInmueble);

        public static string InsertInTblTipoPropiedad => nameof(InsertInTblTipoPropiedad);

        public static string InsertInTblTipoHabitacion => nameof(InsertInTblTipoHabitacion);
        public static string InsertInTblHabitacion => nameof(InsertInTblHabitacion);
        public static string InsertInTblInmueble => nameof(InsertInTblInmueble);
        public static string InsertInTblVenta => nameof(InsertInTblVenta);
        public static string InsertInTblProvincia => nameof(InsertInTblProvincia);
        #endregion

        #region Delete
        public static string DeleteInTblContrato => nameof(DeleteInTblContrato);
        public static string DeleteInTblTipoOperacionInmueble => nameof(DeleteInTblTipoOperacionInmueble);
        public static string DeleteInTblEncargadoDeVenta => nameof(DeleteInTblEncargadoDeVenta);
        public static string DeleteInTblEstadoCita => nameof(DeleteInTblEstadoCita);
        public static string DeleteInTblHorario => nameof(DeleteInTblHorario);
        public static string DeleteInTblCita => nameof(DeleteInTblCita);
        public static string DeleteInTblRegistroCita => nameof(DeleteInTblRegistroCita);
        public static string DeleteInTblTipoReporte => nameof(DeleteInTblTipoReporte);
        public static string DeleteInTblReporte => nameof(DeleteInTblReporte);

        public static string DeleteInTblAgenteInmobilario => nameof(DeleteInTblAgenteInmobilario);

        public static string DeleteInTblAbogado => nameof(DeleteInTblAbogado);
        public static string DeleteInTblTipoPropiedad => nameof(DeleteInTblTipoPropiedad);
        public static string DeleteInTblTipoHabitacion => nameof(DeleteInTblTipoHabitacion);
        public static string DeleteInTblCliente => nameof(DeleteInTblCliente);
        public static string DeleteInTblTblHabitacion => nameof(DeleteInTblTblHabitacion);
  
        public static string DeleteInTblInmueble => nameof(DeleteInTblInmueble);
     
        public static string DeleteInTblVenta => nameof(DeleteInTblVenta);
        public static string DeleteInTblTipoContrato => nameof(DeleteInTblTipoContrato);

        #endregion

        #region Update
        public static string UpdateTblPersona => nameof(UpdateTblPersona);
        public static string UpdateInTblContrato => nameof(UpdateInTblContrato);
        public static string UpdateInTblTipoContrato => nameof(UpdateInTblTipoContrato);
        public static string UpdateInTblEstadoCita => nameof(UpdateInTblEstadoCita);
        public static string UpdateInTblCita => nameof(UpdateInTblCita);

        public static string UpdateInTblTipoReporte => nameof(UpdateInTblTipoReporte);
        public static string UpdateInTblTReporte => nameof(UpdateInTblTReporte);
        public static string UpdateInTblPais => nameof(UpdateInTblPais);
        public static string UpdateInTblDireccion => nameof(UpdateInTblDireccion);
        public static string UpdateInTblTipoOperacionInmueble => nameof(UpdateInTblTipoOperacionInmueble);
        public static string UpdateInTblTipoPropiedad => nameof(UpdateInTblTipoPropiedad);

        public static string UpdateInTblHabitacion => nameof(UpdateInTblHabitacion);
        public static string UpdateInTblInmueble => nameof(UpdateInTblInmueble);
        public static string UpdateInTblProvincia => nameof(UpdateInTblProvincia);
        #endregion

        #region Join
        public static string JoinClientePersona => nameof(JoinClientePersona);

        public static string JoinAbogadoPersona => nameof(JoinAbogadoPersona);
        public static string JoinTblInmueble => nameof(JoinTblInmueble);
        public static string JoinDireccion => nameof(JoinDireccion);
        public static string JoinProvincia => nameof(JoinProvincia);

        public static string JoinAgenteInmboliarioPersona => nameof(JoinAgenteInmboliarioPersona);
        public static string JoinReporte => nameof(JoinReporte);
        public static string JoinTipoContrato => nameof(JoinTipoContrato); 
        public static string JoinEncargadoVentaPersona => nameof(JoinEncargadoVentaPersona);
        public static string JoinHorario_Cita_Estado_Cita => nameof(JoinHorario_Cita_Estado_Cita);
        #endregion

        #region Show table
        public static string MostrarPersonas => nameof(MostrarPersonas);
        public static string MostrarEstadoCita => nameof(MostrarEstadoCita);
        public static string MostrarTiposReporte => nameof(MostrarTiposReporte);

        public static string MostrarTipoHabitacion => nameof(MostrarTipoHabitacion);
        public static string MostrarHabitacionPorInmueble => nameof(MostrarHabitacionPorInmueble);
        public static string MostrarTipoPropiedad => nameof(MostrarTipoPropiedad);
        public static string MostrarTipoOperacion => nameof(MostrarTipoOperacion);
        public static string MostrarTiposContratos => nameof(MostrarTiposContratos);
        public static string MostrarVentas => nameof(MostrarVentas);
        public static string MostrarTblPais => nameof(MostrarTblPais);
        public static string LoginProc => nameof(LoginProc); 
        #endregion


    }
}
