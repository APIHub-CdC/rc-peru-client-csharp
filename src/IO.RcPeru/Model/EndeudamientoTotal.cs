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
    public partial class EndeudamientoTotal :  IEquatable<EndeudamientoTotal>, IValidatableObject
    {
        public EndeudamientoTotal(string claveConcepto = default(string), float? monto = default(float?), float? porcentaje = default(float?))
        {
            this.ClaveConcepto = claveConcepto;
            this.Monto = monto;
            this.Porcentaje = porcentaje;
        }
        [DataMember(Name="claveConcepto", EmitDefaultValue=false)]
        public string ClaveConcepto { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        [DataMember(Name="porcentaje", EmitDefaultValue=false)]
        public float? Porcentaje { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndeudamientoTotal {\n");
            sb.Append("  ClaveConcepto: ").Append(ClaveConcepto).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("  Porcentaje: ").Append(Porcentaje).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as EndeudamientoTotal);
        }
        public bool Equals(EndeudamientoTotal input)
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
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                ) && 
                (
                    this.Porcentaje == input.Porcentaje ||
                    (this.Porcentaje != null &&
                    this.Porcentaje.Equals(input.Porcentaje))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveConcepto != null)
                    hashCode = hashCode * 59 + this.ClaveConcepto.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                if (this.Porcentaje != null)
                    hashCode = hashCode * 59 + this.Porcentaje.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
