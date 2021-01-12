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
    public partial class ComercioExterior :  IEquatable<ComercioExterior>, IValidatableObject
    {
        public ComercioExterior(List<Exportaciones> exportaciones = default(List<Exportaciones>), List<Importaciones> importaciones = default(List<Importaciones>))
        {
            this.Exportaciones = exportaciones;
            this.Importaciones = importaciones;
        }
        [DataMember(Name="exportaciones", EmitDefaultValue=false)]
        public List<Exportaciones> Exportaciones { get; set; }
        [DataMember(Name="importaciones", EmitDefaultValue=false)]
        public List<Importaciones> Importaciones { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComercioExterior {\n");
            sb.Append("  Exportaciones: ").Append(Exportaciones).Append("\n");
            sb.Append("  Importaciones: ").Append(Importaciones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ComercioExterior);
        }
        public bool Equals(ComercioExterior input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Exportaciones == input.Exportaciones ||
                    this.Exportaciones != null &&
                    this.Exportaciones.SequenceEqual(input.Exportaciones)
                ) && 
                (
                    this.Importaciones == input.Importaciones ||
                    this.Importaciones != null &&
                    this.Importaciones.SequenceEqual(input.Importaciones)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Exportaciones != null)
                    hashCode = hashCode * 59 + this.Exportaciones.GetHashCode();
                if (this.Importaciones != null)
                    hashCode = hashCode * 59 + this.Importaciones.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
