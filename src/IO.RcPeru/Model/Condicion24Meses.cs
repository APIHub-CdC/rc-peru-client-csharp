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
    public partial class Condicion24Meses :  IEquatable<Condicion24Meses>, IValidatableObject
    {
        public Condicion24Meses(string fechaPeriodo = default(string), float? deudaMorosa = default(float?), float? deudaAlDia = default(float?), decimal? peorCalificacion = default(decimal?))
        {
            this.FechaPeriodo = fechaPeriodo;
            this.DeudaMorosa = deudaMorosa;
            this.DeudaAlDia = deudaAlDia;
            this.PeorCalificacion = peorCalificacion;
        }
        [DataMember(Name="fechaPeriodo", EmitDefaultValue=false)]
        public string FechaPeriodo { get; set; }
        [DataMember(Name="deudaMorosa", EmitDefaultValue=false)]
        public float? DeudaMorosa { get; set; }
        [DataMember(Name="deudaAlDia", EmitDefaultValue=false)]
        public float? DeudaAlDia { get; set; }
        [DataMember(Name="peorCalificacion", EmitDefaultValue=false)]
        public decimal? PeorCalificacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condicion24Meses {\n");
            sb.Append("  FechaPeriodo: ").Append(FechaPeriodo).Append("\n");
            sb.Append("  DeudaMorosa: ").Append(DeudaMorosa).Append("\n");
            sb.Append("  DeudaAlDia: ").Append(DeudaAlDia).Append("\n");
            sb.Append("  PeorCalificacion: ").Append(PeorCalificacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Condicion24Meses);
        }
        public bool Equals(Condicion24Meses input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FechaPeriodo == input.FechaPeriodo ||
                    (this.FechaPeriodo != null &&
                    this.FechaPeriodo.Equals(input.FechaPeriodo))
                ) && 
                (
                    this.DeudaMorosa == input.DeudaMorosa ||
                    (this.DeudaMorosa != null &&
                    this.DeudaMorosa.Equals(input.DeudaMorosa))
                ) && 
                (
                    this.DeudaAlDia == input.DeudaAlDia ||
                    (this.DeudaAlDia != null &&
                    this.DeudaAlDia.Equals(input.DeudaAlDia))
                ) && 
                (
                    this.PeorCalificacion == input.PeorCalificacion ||
                    (this.PeorCalificacion != null &&
                    this.PeorCalificacion.Equals(input.PeorCalificacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaPeriodo != null)
                    hashCode = hashCode * 59 + this.FechaPeriodo.GetHashCode();
                if (this.DeudaMorosa != null)
                    hashCode = hashCode * 59 + this.DeudaMorosa.GetHashCode();
                if (this.DeudaAlDia != null)
                    hashCode = hashCode * 59 + this.DeudaAlDia.GetHashCode();
                if (this.PeorCalificacion != null)
                    hashCode = hashCode * 59 + this.PeorCalificacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
