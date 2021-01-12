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
    public partial class DetalleCreditosAvalistasAvalados :  IEquatable<DetalleCreditosAvalistasAvalados>, IValidatableObject
    {
        public DetalleCreditosAvalistasAvalados(List<DetalleAvalistas> detallesAvalistas = default(List<DetalleAvalistas>), List<DetalleAvalados> detallesAvalados = default(List<DetalleAvalados>))
        {
            this.DetallesAvalistas = detallesAvalistas;
            this.DetallesAvalados = detallesAvalados;
        }
        [DataMember(Name="detallesAvalistas", EmitDefaultValue=false)]
        public List<DetalleAvalistas> DetallesAvalistas { get; set; }
        [DataMember(Name="detallesAvalados", EmitDefaultValue=false)]
        public List<DetalleAvalados> DetallesAvalados { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleCreditosAvalistasAvalados {\n");
            sb.Append("  DetallesAvalistas: ").Append(DetallesAvalistas).Append("\n");
            sb.Append("  DetallesAvalados: ").Append(DetallesAvalados).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleCreditosAvalistasAvalados);
        }
        public bool Equals(DetalleCreditosAvalistasAvalados input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DetallesAvalistas == input.DetallesAvalistas ||
                    this.DetallesAvalistas != null &&
                    this.DetallesAvalistas.SequenceEqual(input.DetallesAvalistas)
                ) && 
                (
                    this.DetallesAvalados == input.DetallesAvalados ||
                    this.DetallesAvalados != null &&
                    this.DetallesAvalados.SequenceEqual(input.DetallesAvalados)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DetallesAvalistas != null)
                    hashCode = hashCode * 59 + this.DetallesAvalistas.GetHashCode();
                if (this.DetallesAvalados != null)
                    hashCode = hashCode * 59 + this.DetallesAvalados.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
