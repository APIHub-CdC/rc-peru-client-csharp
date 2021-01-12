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
    public partial class DetalleCalificacion :  IEquatable<DetalleCalificacion>, IValidatableObject
    {
        public DetalleCalificacion(string idCalificacion = default(string), float? porcentaje = default(float?), float? monto = default(float?))
        {
            this.IdCalificacion = idCalificacion;
            this.Porcentaje = porcentaje;
            this.Monto = monto;
        }
        [DataMember(Name="idCalificacion", EmitDefaultValue=false)]
        public string IdCalificacion { get; set; }
        [DataMember(Name="porcentaje", EmitDefaultValue=false)]
        public float? Porcentaje { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleCalificacion {\n");
            sb.Append("  IdCalificacion: ").Append(IdCalificacion).Append("\n");
            sb.Append("  Porcentaje: ").Append(Porcentaje).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleCalificacion);
        }
        public bool Equals(DetalleCalificacion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.IdCalificacion == input.IdCalificacion ||
                    (this.IdCalificacion != null &&
                    this.IdCalificacion.Equals(input.IdCalificacion))
                ) && 
                (
                    this.Porcentaje == input.Porcentaje ||
                    (this.Porcentaje != null &&
                    this.Porcentaje.Equals(input.Porcentaje))
                ) && 
                (
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.IdCalificacion != null)
                    hashCode = hashCode * 59 + this.IdCalificacion.GetHashCode();
                if (this.Porcentaje != null)
                    hashCode = hashCode * 59 + this.Porcentaje.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
