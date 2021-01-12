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
    public partial class DetalleCreditos :  IEquatable<DetalleCreditos>, IValidatableObject
    {
        public DetalleCreditos(List<DetalleCreditosRCC> detalleCreditosRCC = default(List<DetalleCreditosRCC>), List<DetalleCreditosMFNZ> detalleCreditosMFNZ = default(List<DetalleCreditosMFNZ>), DetalleCreditosAvalistasAvalados avalistasAvalados = default(DetalleCreditosAvalistasAvalados))
        {
            this.DetalleCreditosRCC = detalleCreditosRCC;
            this.DetalleCreditosMFNZ = detalleCreditosMFNZ;
            this.AvalistasAvalados = avalistasAvalados;
        }
        [DataMember(Name="detalleCreditosRCC", EmitDefaultValue=false)]
        public List<DetalleCreditosRCC> DetalleCreditosRCC { get; set; }
        [DataMember(Name="detalleCreditosMFNZ", EmitDefaultValue=false)]
        public List<DetalleCreditosMFNZ> DetalleCreditosMFNZ { get; set; }
        [DataMember(Name="avalistasAvalados", EmitDefaultValue=false)]
        public DetalleCreditosAvalistasAvalados AvalistasAvalados { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleCreditos {\n");
            sb.Append("  DetalleCreditosRCC: ").Append(DetalleCreditosRCC).Append("\n");
            sb.Append("  DetalleCreditosMFNZ: ").Append(DetalleCreditosMFNZ).Append("\n");
            sb.Append("  AvalistasAvalados: ").Append(AvalistasAvalados).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleCreditos);
        }
        public bool Equals(DetalleCreditos input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DetalleCreditosRCC == input.DetalleCreditosRCC ||
                    this.DetalleCreditosRCC != null &&
                    this.DetalleCreditosRCC.SequenceEqual(input.DetalleCreditosRCC)
                ) && 
                (
                    this.DetalleCreditosMFNZ == input.DetalleCreditosMFNZ ||
                    this.DetalleCreditosMFNZ != null &&
                    this.DetalleCreditosMFNZ.SequenceEqual(input.DetalleCreditosMFNZ)
                ) && 
                (
                    this.AvalistasAvalados == input.AvalistasAvalados ||
                    (this.AvalistasAvalados != null &&
                    this.AvalistasAvalados.Equals(input.AvalistasAvalados))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DetalleCreditosRCC != null)
                    hashCode = hashCode * 59 + this.DetalleCreditosRCC.GetHashCode();
                if (this.DetalleCreditosMFNZ != null)
                    hashCode = hashCode * 59 + this.DetalleCreditosMFNZ.GetHashCode();
                if (this.AvalistasAvalados != null)
                    hashCode = hashCode * 59 + this.AvalistasAvalados.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
