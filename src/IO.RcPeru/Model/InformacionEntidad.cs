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
    public partial class InformacionEntidad :  IEquatable<InformacionEntidad>, IValidatableObject
    {
        public InformacionEntidad(string descripcionEntidad = default(string), string claveSituacion = default(string), decimal? antiguedad = default(decimal?), string fechaUltimoReporte = default(string), float? vigente = default(float?), float? refinanciada = default(float?), float? vencida = default(float?), float? judicial = default(float?), float? deudaTotal = default(float?))
        {
            this.DescripcionEntidad = descripcionEntidad;
            this.ClaveSituacion = claveSituacion;
            this.Antiguedad = antiguedad;
            this.FechaUltimoReporte = fechaUltimoReporte;
            this.Vigente = vigente;
            this.Refinanciada = refinanciada;
            this.Vencida = vencida;
            this.Judicial = judicial;
            this.DeudaTotal = deudaTotal;
        }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="antiguedad", EmitDefaultValue=false)]
        public decimal? Antiguedad { get; set; }
        [DataMember(Name="fechaUltimoReporte", EmitDefaultValue=false)]
        public string FechaUltimoReporte { get; set; }
        [DataMember(Name="vigente", EmitDefaultValue=false)]
        public float? Vigente { get; set; }
        [DataMember(Name="refinanciada", EmitDefaultValue=false)]
        public float? Refinanciada { get; set; }
        [DataMember(Name="vencida", EmitDefaultValue=false)]
        public float? Vencida { get; set; }
        [DataMember(Name="judicial", EmitDefaultValue=false)]
        public float? Judicial { get; set; }
        [DataMember(Name="deudaTotal", EmitDefaultValue=false)]
        public float? DeudaTotal { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InformacionEntidad {\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  Antiguedad: ").Append(Antiguedad).Append("\n");
            sb.Append("  FechaUltimoReporte: ").Append(FechaUltimoReporte).Append("\n");
            sb.Append("  Vigente: ").Append(Vigente).Append("\n");
            sb.Append("  Refinanciada: ").Append(Refinanciada).Append("\n");
            sb.Append("  Vencida: ").Append(Vencida).Append("\n");
            sb.Append("  Judicial: ").Append(Judicial).Append("\n");
            sb.Append("  DeudaTotal: ").Append(DeudaTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as InformacionEntidad);
        }
        public bool Equals(InformacionEntidad input)
        {
            if (input == null)
                return false;
            return 
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
                    this.Antiguedad == input.Antiguedad ||
                    (this.Antiguedad != null &&
                    this.Antiguedad.Equals(input.Antiguedad))
                ) && 
                (
                    this.FechaUltimoReporte == input.FechaUltimoReporte ||
                    (this.FechaUltimoReporte != null &&
                    this.FechaUltimoReporte.Equals(input.FechaUltimoReporte))
                ) && 
                (
                    this.Vigente == input.Vigente ||
                    (this.Vigente != null &&
                    this.Vigente.Equals(input.Vigente))
                ) && 
                (
                    this.Refinanciada == input.Refinanciada ||
                    (this.Refinanciada != null &&
                    this.Refinanciada.Equals(input.Refinanciada))
                ) && 
                (
                    this.Vencida == input.Vencida ||
                    (this.Vencida != null &&
                    this.Vencida.Equals(input.Vencida))
                ) && 
                (
                    this.Judicial == input.Judicial ||
                    (this.Judicial != null &&
                    this.Judicial.Equals(input.Judicial))
                ) && 
                (
                    this.DeudaTotal == input.DeudaTotal ||
                    (this.DeudaTotal != null &&
                    this.DeudaTotal.Equals(input.DeudaTotal))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.Antiguedad != null)
                    hashCode = hashCode * 59 + this.Antiguedad.GetHashCode();
                if (this.FechaUltimoReporte != null)
                    hashCode = hashCode * 59 + this.FechaUltimoReporte.GetHashCode();
                if (this.Vigente != null)
                    hashCode = hashCode * 59 + this.Vigente.GetHashCode();
                if (this.Refinanciada != null)
                    hashCode = hashCode * 59 + this.Refinanciada.GetHashCode();
                if (this.Vencida != null)
                    hashCode = hashCode * 59 + this.Vencida.GetHashCode();
                if (this.Judicial != null)
                    hashCode = hashCode * 59 + this.Judicial.GetHashCode();
                if (this.DeudaTotal != null)
                    hashCode = hashCode * 59 + this.DeudaTotal.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
