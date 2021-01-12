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
    public partial class DetalleEntidad :  IEquatable<DetalleEntidad>, IValidatableObject
    {
        public DetalleEntidad(string claveSituacion = default(string), float? monto = default(float?), string fechaVencimiento = default(string), string fechaReporte = default(string))
        {
            this.ClaveSituacion = claveSituacion;
            this.Monto = monto;
            this.FechaVencimiento = fechaVencimiento;
            this.FechaReporte = fechaReporte;
        }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        [DataMember(Name="fechaVencimiento", EmitDefaultValue=false)]
        public string FechaVencimiento { get; set; }
        [DataMember(Name="fechaReporte", EmitDefaultValue=false)]
        public string FechaReporte { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleEntidad {\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("  FechaVencimiento: ").Append(FechaVencimiento).Append("\n");
            sb.Append("  FechaReporte: ").Append(FechaReporte).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleEntidad);
        }
        public bool Equals(DetalleEntidad input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                ) && 
                (
                    this.FechaVencimiento == input.FechaVencimiento ||
                    (this.FechaVencimiento != null &&
                    this.FechaVencimiento.Equals(input.FechaVencimiento))
                ) && 
                (
                    this.FechaReporte == input.FechaReporte ||
                    (this.FechaReporte != null &&
                    this.FechaReporte.Equals(input.FechaReporte))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                if (this.FechaVencimiento != null)
                    hashCode = hashCode * 59 + this.FechaVencimiento.GetHashCode();
                if (this.FechaReporte != null)
                    hashCode = hashCode * 59 + this.FechaReporte.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
