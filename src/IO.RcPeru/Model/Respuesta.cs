using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ApihubDateConverter = IO.RcPeru.Client.ApihubDateConverter;

namespace IO.RcPeru.Model
{
    [DataContract]
    public partial class Respuesta :  IEquatable<Respuesta>, IValidatableObject
    {
        public Respuesta(DatosConsulta datosConsulta = default(DatosConsulta), ResumenCredito resumenCredito = default(ResumenCredito), ComportamientoRCCMFNZ comportamientoRCCMFNZ = default(ComportamientoRCCMFNZ), DetalleCreditos detallesCreditos = default(DetalleCreditos), OtrasObligaciones otrasObligaciones = default(OtrasObligaciones), ComercioExterior comercioExterior = default(ComercioExterior), Consultas consultas = default(Consultas), DatosGenerales datosGenerales = default(DatosGenerales))
        {
            this.DatosConsulta = datosConsulta;
            this.ResumenCredito = resumenCredito;
            this.ComportamientoRCCMFNZ = comportamientoRCCMFNZ;
            this.DetallesCreditos = detallesCreditos;
            this.OtrasObligaciones = otrasObligaciones;
            this.ComercioExterior = comercioExterior;
            this.Consultas = consultas;
            this.DatosGenerales = datosGenerales;
        }
        [DataMember(Name="datosConsulta", EmitDefaultValue=false)]
        public DatosConsulta DatosConsulta { get; set; }
        [DataMember(Name="resumenCredito", EmitDefaultValue=false)]
        public ResumenCredito ResumenCredito { get; set; }
        [DataMember(Name="comportamientoRCC_MFNZ", EmitDefaultValue=false)]
        public ComportamientoRCCMFNZ ComportamientoRCCMFNZ { get; set; }
        [DataMember(Name="detallesCreditos", EmitDefaultValue=false)]
        public DetalleCreditos DetallesCreditos { get; set; }
        [DataMember(Name="otrasObligaciones", EmitDefaultValue=false)]
        public OtrasObligaciones OtrasObligaciones { get; set; }
        [DataMember(Name="comercioExterior", EmitDefaultValue=false)]
        public ComercioExterior ComercioExterior { get; set; }
        [DataMember(Name="consultas", EmitDefaultValue=false)]
        public Consultas Consultas { get; set; }
        [DataMember(Name="datosGenerales", EmitDefaultValue=false)]
        public DatosGenerales DatosGenerales { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Respuesta {\n");
            sb.Append("  DatosConsulta: ").Append(DatosConsulta).Append("\n");
            sb.Append("  ResumenCredito: ").Append(ResumenCredito).Append("\n");
            sb.Append("  ComportamientoRCCMFNZ: ").Append(ComportamientoRCCMFNZ).Append("\n");
            sb.Append("  DetallesCreditos: ").Append(DetallesCreditos).Append("\n");
            sb.Append("  OtrasObligaciones: ").Append(OtrasObligaciones).Append("\n");
            sb.Append("  ComercioExterior: ").Append(ComercioExterior).Append("\n");
            sb.Append("  Consultas: ").Append(Consultas).Append("\n");
            sb.Append("  DatosGenerales: ").Append(DatosGenerales).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Respuesta);
        }
        public bool Equals(Respuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DatosConsulta == input.DatosConsulta ||
                    (this.DatosConsulta != null &&
                    this.DatosConsulta.Equals(input.DatosConsulta))
                ) && 
                (
                    this.ResumenCredito == input.ResumenCredito ||
                    (this.ResumenCredito != null &&
                    this.ResumenCredito.Equals(input.ResumenCredito))
                ) && 
                (
                    this.ComportamientoRCCMFNZ == input.ComportamientoRCCMFNZ ||
                    (this.ComportamientoRCCMFNZ != null &&
                    this.ComportamientoRCCMFNZ.Equals(input.ComportamientoRCCMFNZ))
                ) && 
                (
                    this.DetallesCreditos == input.DetallesCreditos ||
                    (this.DetallesCreditos != null &&
                    this.DetallesCreditos.Equals(input.DetallesCreditos))
                ) && 
                (
                    this.OtrasObligaciones == input.OtrasObligaciones ||
                    (this.OtrasObligaciones != null &&
                    this.OtrasObligaciones.Equals(input.OtrasObligaciones))
                ) && 
                (
                    this.ComercioExterior == input.ComercioExterior ||
                    (this.ComercioExterior != null &&
                    this.ComercioExterior.Equals(input.ComercioExterior))
                ) && 
                (
                    this.Consultas == input.Consultas ||
                    (this.Consultas != null &&
                    this.Consultas.Equals(input.Consultas))
                ) && 
                (
                    this.DatosGenerales == input.DatosGenerales ||
                    (this.DatosGenerales != null &&
                    this.DatosGenerales.Equals(input.DatosGenerales))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DatosConsulta != null)
                    hashCode = hashCode * 59 + this.DatosConsulta.GetHashCode();
                if (this.ResumenCredito != null)
                    hashCode = hashCode * 59 + this.ResumenCredito.GetHashCode();
                if (this.ComportamientoRCCMFNZ != null)
                    hashCode = hashCode * 59 + this.ComportamientoRCCMFNZ.GetHashCode();
                if (this.DetallesCreditos != null)
                    hashCode = hashCode * 59 + this.DetallesCreditos.GetHashCode();
                if (this.OtrasObligaciones != null)
                    hashCode = hashCode * 59 + this.OtrasObligaciones.GetHashCode();
                if (this.ComercioExterior != null)
                    hashCode = hashCode * 59 + this.ComercioExterior.GetHashCode();
                if (this.Consultas != null)
                    hashCode = hashCode * 59 + this.Consultas.GetHashCode();
                if (this.DatosGenerales != null)
                    hashCode = hashCode * 59 + this.DatosGenerales.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
