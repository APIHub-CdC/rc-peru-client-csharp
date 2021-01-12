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
    public partial class Exportaciones :  IEquatable<Exportaciones>, IValidatableObject
    {
        public Exportaciones(string periodo = default(string), float? monto = default(float?))
        {
            this.Periodo = periodo;
            this.Monto = monto;
        }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exportaciones {\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Exportaciones);
        }
        public bool Equals(Exportaciones input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Periodo == input.Periodo ||
                    (this.Periodo != null &&
                    this.Periodo.Equals(input.Periodo))
                ) && 
                (
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
