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
    public partial class ComportamientoUsoTarjeta :  IEquatable<ComportamientoUsoTarjeta>, IValidatableObject
    {
        public ComportamientoUsoTarjeta(string claveProducto = default(string), string descripcionEntidad = default(string), string claveSituacion = default(string), float? ultimaLineaCredito = default(float?), string utilizacion24 = default(string), string inicioPeriodoUtil = default(string), string finPeriodoUtil = default(string), float? maximaDeuda = default(float?), float? porcentajeMaximaDeuda = default(float?), string disposicion24 = default(string), string inicioPeriodoDisposicion = default(string), string finPeriodoDisposicion = default(string), float? maximaDeudaEfectivo = default(float?), float? porcentajeMaximaDeudaEfectivo = default(float?), float? maximoLineaCredito = default(float?), string maximoFechaLineaCredito = default(string))
        {
            this.ClaveProducto = claveProducto;
            this.DescripcionEntidad = descripcionEntidad;
            this.ClaveSituacion = claveSituacion;
            this.UltimaLineaCredito = ultimaLineaCredito;
            this.Utilizacion24 = utilizacion24;
            this.InicioPeriodoUtil = inicioPeriodoUtil;
            this.FinPeriodoUtil = finPeriodoUtil;
            this.MaximaDeuda = maximaDeuda;
            this.PorcentajeMaximaDeuda = porcentajeMaximaDeuda;
            this.Disposicion24 = disposicion24;
            this.InicioPeriodoDisposicion = inicioPeriodoDisposicion;
            this.FinPeriodoDisposicion = finPeriodoDisposicion;
            this.MaximaDeudaEfectivo = maximaDeudaEfectivo;
            this.PorcentajeMaximaDeudaEfectivo = porcentajeMaximaDeudaEfectivo;
            this.MaximoLineaCredito = maximoLineaCredito;
            this.MaximoFechaLineaCredito = maximoFechaLineaCredito;
        }
        [DataMember(Name="claveProducto", EmitDefaultValue=false)]
        public string ClaveProducto { get; set; }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="ultimaLineaCredito", EmitDefaultValue=false)]
        public float? UltimaLineaCredito { get; set; }
        [DataMember(Name="utilizacion24", EmitDefaultValue=false)]
        public string Utilizacion24 { get; set; }
        [DataMember(Name="inicioPeriodoUtil", EmitDefaultValue=false)]
        public string InicioPeriodoUtil { get; set; }
        [DataMember(Name="finPeriodoUtil", EmitDefaultValue=false)]
        public string FinPeriodoUtil { get; set; }
        [DataMember(Name="maximaDeuda", EmitDefaultValue=false)]
        public float? MaximaDeuda { get; set; }
        [DataMember(Name="porcentajeMaximaDeuda", EmitDefaultValue=false)]
        public float? PorcentajeMaximaDeuda { get; set; }
        [DataMember(Name="disposicion24", EmitDefaultValue=false)]
        public string Disposicion24 { get; set; }
        [DataMember(Name="inicioPeriodoDisposicion", EmitDefaultValue=false)]
        public string InicioPeriodoDisposicion { get; set; }
        [DataMember(Name="finPeriodoDisposicion", EmitDefaultValue=false)]
        public string FinPeriodoDisposicion { get; set; }
        [DataMember(Name="maximaDeudaEfectivo", EmitDefaultValue=false)]
        public float? MaximaDeudaEfectivo { get; set; }
        [DataMember(Name="porcentajeMaximaDeudaEfectivo", EmitDefaultValue=false)]
        public float? PorcentajeMaximaDeudaEfectivo { get; set; }
        [DataMember(Name="maximoLineaCredito", EmitDefaultValue=false)]
        public float? MaximoLineaCredito { get; set; }
        [DataMember(Name="maximoFechaLineaCredito", EmitDefaultValue=false)]
        public string MaximoFechaLineaCredito { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComportamientoUsoTarjeta {\n");
            sb.Append("  ClaveProducto: ").Append(ClaveProducto).Append("\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  UltimaLineaCredito: ").Append(UltimaLineaCredito).Append("\n");
            sb.Append("  Utilizacion24: ").Append(Utilizacion24).Append("\n");
            sb.Append("  InicioPeriodoUtil: ").Append(InicioPeriodoUtil).Append("\n");
            sb.Append("  FinPeriodoUtil: ").Append(FinPeriodoUtil).Append("\n");
            sb.Append("  MaximaDeuda: ").Append(MaximaDeuda).Append("\n");
            sb.Append("  PorcentajeMaximaDeuda: ").Append(PorcentajeMaximaDeuda).Append("\n");
            sb.Append("  Disposicion24: ").Append(Disposicion24).Append("\n");
            sb.Append("  InicioPeriodoDisposicion: ").Append(InicioPeriodoDisposicion).Append("\n");
            sb.Append("  FinPeriodoDisposicion: ").Append(FinPeriodoDisposicion).Append("\n");
            sb.Append("  MaximaDeudaEfectivo: ").Append(MaximaDeudaEfectivo).Append("\n");
            sb.Append("  PorcentajeMaximaDeudaEfectivo: ").Append(PorcentajeMaximaDeudaEfectivo).Append("\n");
            sb.Append("  MaximoLineaCredito: ").Append(MaximoLineaCredito).Append("\n");
            sb.Append("  MaximoFechaLineaCredito: ").Append(MaximoFechaLineaCredito).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ComportamientoUsoTarjeta);
        }
        public bool Equals(ComportamientoUsoTarjeta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveProducto == input.ClaveProducto ||
                    (this.ClaveProducto != null &&
                    this.ClaveProducto.Equals(input.ClaveProducto))
                ) && 
                (
                    this.DescripcionEntidad == input.DescripcionEntidad ||
                    (this.DescripcionEntidad != null &&
                    this.DescripcionEntidad.Equals(input.DescripcionEntidad))
                ) && 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.UltimaLineaCredito == input.UltimaLineaCredito ||
                    (this.UltimaLineaCredito != null &&
                    this.UltimaLineaCredito.Equals(input.UltimaLineaCredito))
                ) && 
                (
                    this.Utilizacion24 == input.Utilizacion24 ||
                    (this.Utilizacion24 != null &&
                    this.Utilizacion24.Equals(input.Utilizacion24))
                ) && 
                (
                    this.InicioPeriodoUtil == input.InicioPeriodoUtil ||
                    (this.InicioPeriodoUtil != null &&
                    this.InicioPeriodoUtil.Equals(input.InicioPeriodoUtil))
                ) && 
                (
                    this.FinPeriodoUtil == input.FinPeriodoUtil ||
                    (this.FinPeriodoUtil != null &&
                    this.FinPeriodoUtil.Equals(input.FinPeriodoUtil))
                ) && 
                (
                    this.MaximaDeuda == input.MaximaDeuda ||
                    (this.MaximaDeuda != null &&
                    this.MaximaDeuda.Equals(input.MaximaDeuda))
                ) && 
                (
                    this.PorcentajeMaximaDeuda == input.PorcentajeMaximaDeuda ||
                    (this.PorcentajeMaximaDeuda != null &&
                    this.PorcentajeMaximaDeuda.Equals(input.PorcentajeMaximaDeuda))
                ) && 
                (
                    this.Disposicion24 == input.Disposicion24 ||
                    (this.Disposicion24 != null &&
                    this.Disposicion24.Equals(input.Disposicion24))
                ) && 
                (
                    this.InicioPeriodoDisposicion == input.InicioPeriodoDisposicion ||
                    (this.InicioPeriodoDisposicion != null &&
                    this.InicioPeriodoDisposicion.Equals(input.InicioPeriodoDisposicion))
                ) && 
                (
                    this.FinPeriodoDisposicion == input.FinPeriodoDisposicion ||
                    (this.FinPeriodoDisposicion != null &&
                    this.FinPeriodoDisposicion.Equals(input.FinPeriodoDisposicion))
                ) && 
                (
                    this.MaximaDeudaEfectivo == input.MaximaDeudaEfectivo ||
                    (this.MaximaDeudaEfectivo != null &&
                    this.MaximaDeudaEfectivo.Equals(input.MaximaDeudaEfectivo))
                ) && 
                (
                    this.PorcentajeMaximaDeudaEfectivo == input.PorcentajeMaximaDeudaEfectivo ||
                    (this.PorcentajeMaximaDeudaEfectivo != null &&
                    this.PorcentajeMaximaDeudaEfectivo.Equals(input.PorcentajeMaximaDeudaEfectivo))
                ) && 
                (
                    this.MaximoLineaCredito == input.MaximoLineaCredito ||
                    (this.MaximoLineaCredito != null &&
                    this.MaximoLineaCredito.Equals(input.MaximoLineaCredito))
                ) && 
                (
                    this.MaximoFechaLineaCredito == input.MaximoFechaLineaCredito ||
                    (this.MaximoFechaLineaCredito != null &&
                    this.MaximoFechaLineaCredito.Equals(input.MaximoFechaLineaCredito))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveProducto != null)
                    hashCode = hashCode * 59 + this.ClaveProducto.GetHashCode();
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.UltimaLineaCredito != null)
                    hashCode = hashCode * 59 + this.UltimaLineaCredito.GetHashCode();
                if (this.Utilizacion24 != null)
                    hashCode = hashCode * 59 + this.Utilizacion24.GetHashCode();
                if (this.InicioPeriodoUtil != null)
                    hashCode = hashCode * 59 + this.InicioPeriodoUtil.GetHashCode();
                if (this.FinPeriodoUtil != null)
                    hashCode = hashCode * 59 + this.FinPeriodoUtil.GetHashCode();
                if (this.MaximaDeuda != null)
                    hashCode = hashCode * 59 + this.MaximaDeuda.GetHashCode();
                if (this.PorcentajeMaximaDeuda != null)
                    hashCode = hashCode * 59 + this.PorcentajeMaximaDeuda.GetHashCode();
                if (this.Disposicion24 != null)
                    hashCode = hashCode * 59 + this.Disposicion24.GetHashCode();
                if (this.InicioPeriodoDisposicion != null)
                    hashCode = hashCode * 59 + this.InicioPeriodoDisposicion.GetHashCode();
                if (this.FinPeriodoDisposicion != null)
                    hashCode = hashCode * 59 + this.FinPeriodoDisposicion.GetHashCode();
                if (this.MaximaDeudaEfectivo != null)
                    hashCode = hashCode * 59 + this.MaximaDeudaEfectivo.GetHashCode();
                if (this.PorcentajeMaximaDeudaEfectivo != null)
                    hashCode = hashCode * 59 + this.PorcentajeMaximaDeudaEfectivo.GetHashCode();
                if (this.MaximoLineaCredito != null)
                    hashCode = hashCode * 59 + this.MaximoLineaCredito.GetHashCode();
                if (this.MaximoFechaLineaCredito != null)
                    hashCode = hashCode * 59 + this.MaximoFechaLineaCredito.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
