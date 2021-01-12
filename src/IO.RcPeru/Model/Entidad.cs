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
    public partial class Entidad :  IEquatable<Entidad>, IValidatableObject
    {
        public Entidad(string descripcionEntidad = default(string), List<DetalleEntidad> detalleEntidad = default(List<DetalleEntidad>))
        {
            this.DescripcionEntidad = descripcionEntidad;
            this.DetalleEntidad = detalleEntidad;
        }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="detalleEntidad", EmitDefaultValue=false)]
        public List<DetalleEntidad> DetalleEntidad { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entidad {\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  DetalleEntidad: ").Append(DetalleEntidad).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Entidad);
        }
        public bool Equals(Entidad input)
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
                    this.DetalleEntidad == input.DetalleEntidad ||
                    this.DetalleEntidad != null &&
                    this.DetalleEntidad.SequenceEqual(input.DetalleEntidad)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.DetalleEntidad != null)
                    hashCode = hashCode * 59 + this.DetalleEntidad.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
