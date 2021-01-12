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
    public partial class Situacion24Meses :  IEquatable<Situacion24Meses>, IValidatableObject
    {
        public Situacion24Meses(string fechaPeriodo = default(string), float? deudaVencida = default(float?), float? deudaVigente = default(float?), float? deudaRR = default(float?), float? deudaJudicial = default(float?), float? deudaCastigo = default(float?))
        {
            this.FechaPeriodo = fechaPeriodo;
            this.DeudaVencida = deudaVencida;
            this.DeudaVigente = deudaVigente;
            this.DeudaRR = deudaRR;
            this.DeudaJudicial = deudaJudicial;
            this.DeudaCastigo = deudaCastigo;
        }
        [DataMember(Name="fechaPeriodo", EmitDefaultValue=false)]
        public string FechaPeriodo { get; set; }
        [DataMember(Name="deudaVencida", EmitDefaultValue=false)]
        public float? DeudaVencida { get; set; }
        [DataMember(Name="deudaVigente", EmitDefaultValue=false)]
        public float? DeudaVigente { get; set; }
        [DataMember(Name="deudaRR", EmitDefaultValue=false)]
        public float? DeudaRR { get; set; }
        [DataMember(Name="deudaJudicial", EmitDefaultValue=false)]
        public float? DeudaJudicial { get; set; }
        [DataMember(Name="deudaCastigo", EmitDefaultValue=false)]
        public float? DeudaCastigo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Situacion24Meses {\n");
            sb.Append("  FechaPeriodo: ").Append(FechaPeriodo).Append("\n");
            sb.Append("  DeudaVencida: ").Append(DeudaVencida).Append("\n");
            sb.Append("  DeudaVigente: ").Append(DeudaVigente).Append("\n");
            sb.Append("  DeudaRR: ").Append(DeudaRR).Append("\n");
            sb.Append("  DeudaJudicial: ").Append(DeudaJudicial).Append("\n");
            sb.Append("  DeudaCastigo: ").Append(DeudaCastigo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Situacion24Meses);
        }
        public bool Equals(Situacion24Meses input)
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
                    this.DeudaVencida == input.DeudaVencida ||
                    (this.DeudaVencida != null &&
                    this.DeudaVencida.Equals(input.DeudaVencida))
                ) && 
                (
                    this.DeudaVigente == input.DeudaVigente ||
                    (this.DeudaVigente != null &&
                    this.DeudaVigente.Equals(input.DeudaVigente))
                ) && 
                (
                    this.DeudaRR == input.DeudaRR ||
                    (this.DeudaRR != null &&
                    this.DeudaRR.Equals(input.DeudaRR))
                ) && 
                (
                    this.DeudaJudicial == input.DeudaJudicial ||
                    (this.DeudaJudicial != null &&
                    this.DeudaJudicial.Equals(input.DeudaJudicial))
                ) && 
                (
                    this.DeudaCastigo == input.DeudaCastigo ||
                    (this.DeudaCastigo != null &&
                    this.DeudaCastigo.Equals(input.DeudaCastigo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaPeriodo != null)
                    hashCode = hashCode * 59 + this.FechaPeriodo.GetHashCode();
                if (this.DeudaVencida != null)
                    hashCode = hashCode * 59 + this.DeudaVencida.GetHashCode();
                if (this.DeudaVigente != null)
                    hashCode = hashCode * 59 + this.DeudaVigente.GetHashCode();
                if (this.DeudaRR != null)
                    hashCode = hashCode * 59 + this.DeudaRR.GetHashCode();
                if (this.DeudaJudicial != null)
                    hashCode = hashCode * 59 + this.DeudaJudicial.GetHashCode();
                if (this.DeudaCastigo != null)
                    hashCode = hashCode * 59 + this.DeudaCastigo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
