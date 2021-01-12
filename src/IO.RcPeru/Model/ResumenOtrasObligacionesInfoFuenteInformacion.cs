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
    public partial class ResumenOtrasObligacionesInfoFuenteInformacion :  IEquatable<ResumenOtrasObligacionesInfoFuenteInformacion>, IValidatableObject
    {
        public ResumenOtrasObligacionesInfoFuenteInformacion(string claveSituacion = default(string), decimal? obligaciones = default(decimal?), float? monto = default(float?), string primerVencimiento = default(string), string ultimoVencimiento = default(string), decimal? obligaciones24Meses = default(decimal?), float? monto24Meses = default(float?))
        {
            this.ClaveSituacion = claveSituacion;
            this.Obligaciones = obligaciones;
            this.Monto = monto;
            this.PrimerVencimiento = primerVencimiento;
            this.UltimoVencimiento = ultimoVencimiento;
            this.Obligaciones24Meses = obligaciones24Meses;
            this.Monto24Meses = monto24Meses;
        }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="obligaciones", EmitDefaultValue=false)]
        public decimal? Obligaciones { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        [DataMember(Name="primerVencimiento", EmitDefaultValue=false)]
        public string PrimerVencimiento { get; set; }
        [DataMember(Name="ultimoVencimiento", EmitDefaultValue=false)]
        public string UltimoVencimiento { get; set; }
        [DataMember(Name="obligaciones24Meses", EmitDefaultValue=false)]
        public decimal? Obligaciones24Meses { get; set; }
        [DataMember(Name="monto24Meses", EmitDefaultValue=false)]
        public float? Monto24Meses { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumenOtrasObligacionesInfoFuenteInformacion {\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  Obligaciones: ").Append(Obligaciones).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("  PrimerVencimiento: ").Append(PrimerVencimiento).Append("\n");
            sb.Append("  UltimoVencimiento: ").Append(UltimoVencimiento).Append("\n");
            sb.Append("  Obligaciones24Meses: ").Append(Obligaciones24Meses).Append("\n");
            sb.Append("  Monto24Meses: ").Append(Monto24Meses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumenOtrasObligacionesInfoFuenteInformacion);
        }
        public bool Equals(ResumenOtrasObligacionesInfoFuenteInformacion input)
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
                    this.Obligaciones == input.Obligaciones ||
                    (this.Obligaciones != null &&
                    this.Obligaciones.Equals(input.Obligaciones))
                ) && 
                (
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                ) && 
                (
                    this.PrimerVencimiento == input.PrimerVencimiento ||
                    (this.PrimerVencimiento != null &&
                    this.PrimerVencimiento.Equals(input.PrimerVencimiento))
                ) && 
                (
                    this.UltimoVencimiento == input.UltimoVencimiento ||
                    (this.UltimoVencimiento != null &&
                    this.UltimoVencimiento.Equals(input.UltimoVencimiento))
                ) && 
                (
                    this.Obligaciones24Meses == input.Obligaciones24Meses ||
                    (this.Obligaciones24Meses != null &&
                    this.Obligaciones24Meses.Equals(input.Obligaciones24Meses))
                ) && 
                (
                    this.Monto24Meses == input.Monto24Meses ||
                    (this.Monto24Meses != null &&
                    this.Monto24Meses.Equals(input.Monto24Meses))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.Obligaciones != null)
                    hashCode = hashCode * 59 + this.Obligaciones.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                if (this.PrimerVencimiento != null)
                    hashCode = hashCode * 59 + this.PrimerVencimiento.GetHashCode();
                if (this.UltimoVencimiento != null)
                    hashCode = hashCode * 59 + this.UltimoVencimiento.GetHashCode();
                if (this.Obligaciones24Meses != null)
                    hashCode = hashCode * 59 + this.Obligaciones24Meses.GetHashCode();
                if (this.Monto24Meses != null)
                    hashCode = hashCode * 59 + this.Monto24Meses.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
