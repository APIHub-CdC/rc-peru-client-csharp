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
    public partial class ResumenCreditoSBSUltimos24Meses :  IEquatable<ResumenCreditoSBSUltimos24Meses>, IValidatableObject
    {
        public ResumenCreditoSBSUltimos24Meses(List<Condicion24Meses> condicion24Meses = default(List<Condicion24Meses>), List<Calificacion24Meses> calificacion24Meses = default(List<Calificacion24Meses>), List<Situacion24Meses> situacion24Meses = default(List<Situacion24Meses>))
        {
            this.Condicion24Meses = condicion24Meses;
            this.Calificacion24Meses = calificacion24Meses;
            this.Situacion24Meses = situacion24Meses;
        }
        [DataMember(Name="condicion24Meses", EmitDefaultValue=false)]
        public List<Condicion24Meses> Condicion24Meses { get; set; }
        [DataMember(Name="calificacion24Meses", EmitDefaultValue=false)]
        public List<Calificacion24Meses> Calificacion24Meses { get; set; }
        [DataMember(Name="situacion24Meses", EmitDefaultValue=false)]
        public List<Situacion24Meses> Situacion24Meses { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumenCreditoSBSUltimos24Meses {\n");
            sb.Append("  Condicion24Meses: ").Append(Condicion24Meses).Append("\n");
            sb.Append("  Calificacion24Meses: ").Append(Calificacion24Meses).Append("\n");
            sb.Append("  Situacion24Meses: ").Append(Situacion24Meses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumenCreditoSBSUltimos24Meses);
        }
        public bool Equals(ResumenCreditoSBSUltimos24Meses input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Condicion24Meses == input.Condicion24Meses ||
                    this.Condicion24Meses != null &&
                    this.Condicion24Meses.SequenceEqual(input.Condicion24Meses)
                ) && 
                (
                    this.Calificacion24Meses == input.Calificacion24Meses ||
                    this.Calificacion24Meses != null &&
                    this.Calificacion24Meses.SequenceEqual(input.Calificacion24Meses)
                ) && 
                (
                    this.Situacion24Meses == input.Situacion24Meses ||
                    this.Situacion24Meses != null &&
                    this.Situacion24Meses.SequenceEqual(input.Situacion24Meses)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Condicion24Meses != null)
                    hashCode = hashCode * 59 + this.Condicion24Meses.GetHashCode();
                if (this.Calificacion24Meses != null)
                    hashCode = hashCode * 59 + this.Calificacion24Meses.GetHashCode();
                if (this.Situacion24Meses != null)
                    hashCode = hashCode * 59 + this.Situacion24Meses.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
