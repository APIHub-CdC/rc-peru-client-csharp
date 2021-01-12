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
    public partial class Calificacion24Meses :  IEquatable<Calificacion24Meses>, IValidatableObject
    {
        public Calificacion24Meses(string fechaPeriodo = default(string), float? deudaNormal = default(float?), float? deudaCPP = default(float?), float? deudaDeficiente = default(float?), float? deudaDudoso = default(float?), float? deudaPerdida = default(float?), decimal? numeroEntidades = default(decimal?))
        {
            this.FechaPeriodo = fechaPeriodo;
            this.DeudaNormal = deudaNormal;
            this.DeudaCPP = deudaCPP;
            this.DeudaDeficiente = deudaDeficiente;
            this.DeudaDudoso = deudaDudoso;
            this.DeudaPerdida = deudaPerdida;
            this.NumeroEntidades = numeroEntidades;
        }
        [DataMember(Name="fechaPeriodo", EmitDefaultValue=false)]
        public string FechaPeriodo { get; set; }
        [DataMember(Name="deudaNormal", EmitDefaultValue=false)]
        public float? DeudaNormal { get; set; }
        [DataMember(Name="deudaCPP", EmitDefaultValue=false)]
        public float? DeudaCPP { get; set; }
        [DataMember(Name="deudaDeficiente", EmitDefaultValue=false)]
        public float? DeudaDeficiente { get; set; }
        [DataMember(Name="deudaDudoso", EmitDefaultValue=false)]
        public float? DeudaDudoso { get; set; }
        [DataMember(Name="deudaPerdida", EmitDefaultValue=false)]
        public float? DeudaPerdida { get; set; }
        [DataMember(Name="numeroEntidades", EmitDefaultValue=false)]
        public decimal? NumeroEntidades { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Calificacion24Meses {\n");
            sb.Append("  FechaPeriodo: ").Append(FechaPeriodo).Append("\n");
            sb.Append("  DeudaNormal: ").Append(DeudaNormal).Append("\n");
            sb.Append("  DeudaCPP: ").Append(DeudaCPP).Append("\n");
            sb.Append("  DeudaDeficiente: ").Append(DeudaDeficiente).Append("\n");
            sb.Append("  DeudaDudoso: ").Append(DeudaDudoso).Append("\n");
            sb.Append("  DeudaPerdida: ").Append(DeudaPerdida).Append("\n");
            sb.Append("  NumeroEntidades: ").Append(NumeroEntidades).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Calificacion24Meses);
        }
        public bool Equals(Calificacion24Meses input)
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
                    this.DeudaNormal == input.DeudaNormal ||
                    (this.DeudaNormal != null &&
                    this.DeudaNormal.Equals(input.DeudaNormal))
                ) && 
                (
                    this.DeudaCPP == input.DeudaCPP ||
                    (this.DeudaCPP != null &&
                    this.DeudaCPP.Equals(input.DeudaCPP))
                ) && 
                (
                    this.DeudaDeficiente == input.DeudaDeficiente ||
                    (this.DeudaDeficiente != null &&
                    this.DeudaDeficiente.Equals(input.DeudaDeficiente))
                ) && 
                (
                    this.DeudaDudoso == input.DeudaDudoso ||
                    (this.DeudaDudoso != null &&
                    this.DeudaDudoso.Equals(input.DeudaDudoso))
                ) && 
                (
                    this.DeudaPerdida == input.DeudaPerdida ||
                    (this.DeudaPerdida != null &&
                    this.DeudaPerdida.Equals(input.DeudaPerdida))
                ) && 
                (
                    this.NumeroEntidades == input.NumeroEntidades ||
                    (this.NumeroEntidades != null &&
                    this.NumeroEntidades.Equals(input.NumeroEntidades))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaPeriodo != null)
                    hashCode = hashCode * 59 + this.FechaPeriodo.GetHashCode();
                if (this.DeudaNormal != null)
                    hashCode = hashCode * 59 + this.DeudaNormal.GetHashCode();
                if (this.DeudaCPP != null)
                    hashCode = hashCode * 59 + this.DeudaCPP.GetHashCode();
                if (this.DeudaDeficiente != null)
                    hashCode = hashCode * 59 + this.DeudaDeficiente.GetHashCode();
                if (this.DeudaDudoso != null)
                    hashCode = hashCode * 59 + this.DeudaDudoso.GetHashCode();
                if (this.DeudaPerdida != null)
                    hashCode = hashCode * 59 + this.DeudaPerdida.GetHashCode();
                if (this.NumeroEntidades != null)
                    hashCode = hashCode * 59 + this.NumeroEntidades.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
