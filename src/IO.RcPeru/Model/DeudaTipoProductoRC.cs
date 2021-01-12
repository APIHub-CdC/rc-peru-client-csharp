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
    public partial class DeudaTipoProductoRC :  IEquatable<DeudaTipoProductoRC>, IValidatableObject
    {
        public DeudaTipoProductoRC(string claveConcepto = default(string), float? montoDia = default(float?), float? montoMorosa = default(float?), float? montoTotal = default(float?), float? porcentajeDia = default(float?), float? porcentajeMorosa = default(float?), float? porcentajeTotal = default(float?))
        {
            this.ClaveConcepto = claveConcepto;
            this.MontoDia = montoDia;
            this.MontoMorosa = montoMorosa;
            this.MontoTotal = montoTotal;
            this.PorcentajeDia = porcentajeDia;
            this.PorcentajeMorosa = porcentajeMorosa;
            this.PorcentajeTotal = porcentajeTotal;
        }
        [DataMember(Name="claveConcepto", EmitDefaultValue=false)]
        public string ClaveConcepto { get; set; }
        [DataMember(Name="montoDia", EmitDefaultValue=false)]
        public float? MontoDia { get; set; }
        [DataMember(Name="montoMorosa", EmitDefaultValue=false)]
        public float? MontoMorosa { get; set; }
        [DataMember(Name="montoTotal", EmitDefaultValue=false)]
        public float? MontoTotal { get; set; }
        [DataMember(Name="porcentajeDia", EmitDefaultValue=false)]
        public float? PorcentajeDia { get; set; }
        [DataMember(Name="porcentajeMorosa", EmitDefaultValue=false)]
        public float? PorcentajeMorosa { get; set; }
        [DataMember(Name="porcentajeTotal", EmitDefaultValue=false)]
        public float? PorcentajeTotal { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeudaTipoProductoRC {\n");
            sb.Append("  ClaveConcepto: ").Append(ClaveConcepto).Append("\n");
            sb.Append("  MontoDia: ").Append(MontoDia).Append("\n");
            sb.Append("  MontoMorosa: ").Append(MontoMorosa).Append("\n");
            sb.Append("  MontoTotal: ").Append(MontoTotal).Append("\n");
            sb.Append("  PorcentajeDia: ").Append(PorcentajeDia).Append("\n");
            sb.Append("  PorcentajeMorosa: ").Append(PorcentajeMorosa).Append("\n");
            sb.Append("  PorcentajeTotal: ").Append(PorcentajeTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DeudaTipoProductoRC);
        }
        public bool Equals(DeudaTipoProductoRC input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveConcepto == input.ClaveConcepto ||
                    (this.ClaveConcepto != null &&
                    this.ClaveConcepto.Equals(input.ClaveConcepto))
                ) && 
                (
                    this.MontoDia == input.MontoDia ||
                    (this.MontoDia != null &&
                    this.MontoDia.Equals(input.MontoDia))
                ) && 
                (
                    this.MontoMorosa == input.MontoMorosa ||
                    (this.MontoMorosa != null &&
                    this.MontoMorosa.Equals(input.MontoMorosa))
                ) && 
                (
                    this.MontoTotal == input.MontoTotal ||
                    (this.MontoTotal != null &&
                    this.MontoTotal.Equals(input.MontoTotal))
                ) && 
                (
                    this.PorcentajeDia == input.PorcentajeDia ||
                    (this.PorcentajeDia != null &&
                    this.PorcentajeDia.Equals(input.PorcentajeDia))
                ) && 
                (
                    this.PorcentajeMorosa == input.PorcentajeMorosa ||
                    (this.PorcentajeMorosa != null &&
                    this.PorcentajeMorosa.Equals(input.PorcentajeMorosa))
                ) && 
                (
                    this.PorcentajeTotal == input.PorcentajeTotal ||
                    (this.PorcentajeTotal != null &&
                    this.PorcentajeTotal.Equals(input.PorcentajeTotal))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveConcepto != null)
                    hashCode = hashCode * 59 + this.ClaveConcepto.GetHashCode();
                if (this.MontoDia != null)
                    hashCode = hashCode * 59 + this.MontoDia.GetHashCode();
                if (this.MontoMorosa != null)
                    hashCode = hashCode * 59 + this.MontoMorosa.GetHashCode();
                if (this.MontoTotal != null)
                    hashCode = hashCode * 59 + this.MontoTotal.GetHashCode();
                if (this.PorcentajeDia != null)
                    hashCode = hashCode * 59 + this.PorcentajeDia.GetHashCode();
                if (this.PorcentajeMorosa != null)
                    hashCode = hashCode * 59 + this.PorcentajeMorosa.GetHashCode();
                if (this.PorcentajeTotal != null)
                    hashCode = hashCode * 59 + this.PorcentajeTotal.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
