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
    public partial class Consultas : List<ConsultasInner>,  IEquatable<Consultas>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public Consultas() : base()
        {
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Consultas {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Consultas);
        }
        public bool Equals(Consultas input)
        {
            if (input == null)
                return false;
            return base.Equals(input);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
