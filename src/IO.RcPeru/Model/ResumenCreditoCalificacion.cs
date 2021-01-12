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
    public partial class ResumenCreditoCalificacion :  IEquatable<ResumenCreditoCalificacion>, IValidatableObject
    {
        public ResumenCreditoCalificacion(string periodo = default(string), List<DetalleCalificacion> detalle = default(List<DetalleCalificacion>))
        {
            this.Periodo = periodo;
            this.Detalle = detalle;
        }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="detalle", EmitDefaultValue=false)]
        public List<DetalleCalificacion> Detalle { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumenCreditoCalificacion {\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  Detalle: ").Append(Detalle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumenCreditoCalificacion);
        }
        public bool Equals(ResumenCreditoCalificacion input)
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
                    this.Detalle == input.Detalle ||
                    this.Detalle != null &&
                    this.Detalle.SequenceEqual(input.Detalle)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.Detalle != null)
                    hashCode = hashCode * 59 + this.Detalle.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
