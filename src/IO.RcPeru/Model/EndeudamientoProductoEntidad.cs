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
    public partial class EndeudamientoProductoEntidad :  IEquatable<EndeudamientoProductoEntidad>, IValidatableObject
    {
        public EndeudamientoProductoEntidad(string claveProducto = default(string), List<InformacionEntidad> informacionEntidad = default(List<InformacionEntidad>))
        {
            this.ClaveProducto = claveProducto;
            this.InformacionEntidad = informacionEntidad;
        }
        [DataMember(Name="claveProducto", EmitDefaultValue=false)]
        public string ClaveProducto { get; set; }
        [DataMember(Name="informacionEntidad", EmitDefaultValue=false)]
        public List<InformacionEntidad> InformacionEntidad { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndeudamientoProductoEntidad {\n");
            sb.Append("  ClaveProducto: ").Append(ClaveProducto).Append("\n");
            sb.Append("  InformacionEntidad: ").Append(InformacionEntidad).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as EndeudamientoProductoEntidad);
        }
        public bool Equals(EndeudamientoProductoEntidad input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveProducto == input.ClaveProducto ||
                    (this.ClaveProducto != null &&
                    this.ClaveProducto.Equals(input.ClaveProducto))
                ) && 
                (
                    this.InformacionEntidad == input.InformacionEntidad ||
                    this.InformacionEntidad != null &&
                    this.InformacionEntidad.SequenceEqual(input.InformacionEntidad)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveProducto != null)
                    hashCode = hashCode * 59 + this.ClaveProducto.GetHashCode();
                if (this.InformacionEntidad != null)
                    hashCode = hashCode * 59 + this.InformacionEntidad.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
