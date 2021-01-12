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
    public partial class Morosidad :  IEquatable<Morosidad>, IValidatableObject
    {
        public Morosidad(string claveTipoEntidad = default(string), List<Entidad> entidad = default(List<Entidad>))
        {
            this.ClaveTipoEntidad = claveTipoEntidad;
            this.Entidad = entidad;
        }
        [DataMember(Name="claveTipoEntidad", EmitDefaultValue=false)]
        public string ClaveTipoEntidad { get; set; }
        [DataMember(Name="entidad", EmitDefaultValue=false)]
        public List<Entidad> Entidad { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Morosidad {\n");
            sb.Append("  ClaveTipoEntidad: ").Append(ClaveTipoEntidad).Append("\n");
            sb.Append("  Entidad: ").Append(Entidad).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Morosidad);
        }
        public bool Equals(Morosidad input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveTipoEntidad == input.ClaveTipoEntidad ||
                    (this.ClaveTipoEntidad != null &&
                    this.ClaveTipoEntidad.Equals(input.ClaveTipoEntidad))
                ) && 
                (
                    this.Entidad == input.Entidad ||
                    this.Entidad != null &&
                    this.Entidad.SequenceEqual(input.Entidad)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveTipoEntidad != null)
                    hashCode = hashCode * 59 + this.ClaveTipoEntidad.GetHashCode();
                if (this.Entidad != null)
                    hashCode = hashCode * 59 + this.Entidad.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
