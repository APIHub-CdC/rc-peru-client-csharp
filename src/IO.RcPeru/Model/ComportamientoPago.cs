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
    public partial class ComportamientoPago :  IEquatable<ComportamientoPago>, IValidatableObject
    {
        public ComportamientoPago(string claveProducto = default(string), List<InformacionEntidad24> informacionEntidad24 = default(List<InformacionEntidad24>))
        {
            this.ClaveProducto = claveProducto;
            this.InformacionEntidad24 = informacionEntidad24;
        }
        [DataMember(Name="claveProducto", EmitDefaultValue=false)]
        public string ClaveProducto { get; set; }
        [DataMember(Name="informacionEntidad24", EmitDefaultValue=false)]
        public List<InformacionEntidad24> InformacionEntidad24 { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComportamientoPago {\n");
            sb.Append("  ClaveProducto: ").Append(ClaveProducto).Append("\n");
            sb.Append("  InformacionEntidad24: ").Append(InformacionEntidad24).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ComportamientoPago);
        }
        public bool Equals(ComportamientoPago input)
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
                    this.InformacionEntidad24 == input.InformacionEntidad24 ||
                    this.InformacionEntidad24 != null &&
                    this.InformacionEntidad24.SequenceEqual(input.InformacionEntidad24)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveProducto != null)
                    hashCode = hashCode * 59 + this.ClaveProducto.GetHashCode();
                if (this.InformacionEntidad24 != null)
                    hashCode = hashCode * 59 + this.InformacionEntidad24.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
