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
    public partial class ConsultaMes :  IEquatable<ConsultaMes>, IValidatableObject
    {
        public ConsultaMes(string periodo = default(string), decimal? consultas = default(decimal?))
        {
            this.Periodo = periodo;
            this.Consultas = consultas;
        }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="consultas", EmitDefaultValue=false)]
        public decimal? Consultas { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultaMes {\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  Consultas: ").Append(Consultas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsultaMes);
        }
        public bool Equals(ConsultaMes input)
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
                    this.Consultas == input.Consultas ||
                    (this.Consultas != null &&
                    this.Consultas.Equals(input.Consultas))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.Consultas != null)
                    hashCode = hashCode * 59 + this.Consultas.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
