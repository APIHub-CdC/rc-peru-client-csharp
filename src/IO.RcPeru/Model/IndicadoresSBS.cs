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
    public partial class IndicadoresSBS :  IEquatable<IndicadoresSBS>, IValidatableObject
    {
        public IndicadoresSBS(float? deudaDirecta = default(float?), float? deudaDirectaMorosa = default(float?), float? deudaIndirecta = default(float?), float? deudaCastigada = default(float?), decimal? numeroEntidades = default(decimal?), decimal? entidadesDeudaDirecta = default(decimal?), decimal? maximoAtraso = default(decimal?), decimal? antiguedadMaxima = default(decimal?), string entidadMayorDeuda = default(string))
        {
            this.DeudaDirecta = deudaDirecta;
            this.DeudaDirectaMorosa = deudaDirectaMorosa;
            this.DeudaIndirecta = deudaIndirecta;
            this.DeudaCastigada = deudaCastigada;
            this.NumeroEntidades = numeroEntidades;
            this.EntidadesDeudaDirecta = entidadesDeudaDirecta;
            this.MaximoAtraso = maximoAtraso;
            this.AntiguedadMaxima = antiguedadMaxima;
            this.EntidadMayorDeuda = entidadMayorDeuda;
        }
        [DataMember(Name="deudaDirecta", EmitDefaultValue=false)]
        public float? DeudaDirecta { get; set; }
        [DataMember(Name="deudaDirectaMorosa", EmitDefaultValue=false)]
        public float? DeudaDirectaMorosa { get; set; }
        [DataMember(Name="deudaIndirecta", EmitDefaultValue=false)]
        public float? DeudaIndirecta { get; set; }
        [DataMember(Name="deudaCastigada", EmitDefaultValue=false)]
        public float? DeudaCastigada { get; set; }
        [DataMember(Name="numeroEntidades", EmitDefaultValue=false)]
        public decimal? NumeroEntidades { get; set; }
        [DataMember(Name="entidadesDeudaDirecta", EmitDefaultValue=false)]
        public decimal? EntidadesDeudaDirecta { get; set; }
        [DataMember(Name="maximoAtraso", EmitDefaultValue=false)]
        public decimal? MaximoAtraso { get; set; }
        [DataMember(Name="antiguedadMaxima", EmitDefaultValue=false)]
        public decimal? AntiguedadMaxima { get; set; }
        [DataMember(Name="entidadMayorDeuda", EmitDefaultValue=false)]
        public string EntidadMayorDeuda { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndicadoresSBS {\n");
            sb.Append("  DeudaDirecta: ").Append(DeudaDirecta).Append("\n");
            sb.Append("  DeudaDirectaMorosa: ").Append(DeudaDirectaMorosa).Append("\n");
            sb.Append("  DeudaIndirecta: ").Append(DeudaIndirecta).Append("\n");
            sb.Append("  DeudaCastigada: ").Append(DeudaCastigada).Append("\n");
            sb.Append("  NumeroEntidades: ").Append(NumeroEntidades).Append("\n");
            sb.Append("  EntidadesDeudaDirecta: ").Append(EntidadesDeudaDirecta).Append("\n");
            sb.Append("  MaximoAtraso: ").Append(MaximoAtraso).Append("\n");
            sb.Append("  AntiguedadMaxima: ").Append(AntiguedadMaxima).Append("\n");
            sb.Append("  EntidadMayorDeuda: ").Append(EntidadMayorDeuda).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as IndicadoresSBS);
        }
        public bool Equals(IndicadoresSBS input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DeudaDirecta == input.DeudaDirecta ||
                    (this.DeudaDirecta != null &&
                    this.DeudaDirecta.Equals(input.DeudaDirecta))
                ) && 
                (
                    this.DeudaDirectaMorosa == input.DeudaDirectaMorosa ||
                    (this.DeudaDirectaMorosa != null &&
                    this.DeudaDirectaMorosa.Equals(input.DeudaDirectaMorosa))
                ) && 
                (
                    this.DeudaIndirecta == input.DeudaIndirecta ||
                    (this.DeudaIndirecta != null &&
                    this.DeudaIndirecta.Equals(input.DeudaIndirecta))
                ) && 
                (
                    this.DeudaCastigada == input.DeudaCastigada ||
                    (this.DeudaCastigada != null &&
                    this.DeudaCastigada.Equals(input.DeudaCastigada))
                ) && 
                (
                    this.NumeroEntidades == input.NumeroEntidades ||
                    (this.NumeroEntidades != null &&
                    this.NumeroEntidades.Equals(input.NumeroEntidades))
                ) && 
                (
                    this.EntidadesDeudaDirecta == input.EntidadesDeudaDirecta ||
                    (this.EntidadesDeudaDirecta != null &&
                    this.EntidadesDeudaDirecta.Equals(input.EntidadesDeudaDirecta))
                ) && 
                (
                    this.MaximoAtraso == input.MaximoAtraso ||
                    (this.MaximoAtraso != null &&
                    this.MaximoAtraso.Equals(input.MaximoAtraso))
                ) && 
                (
                    this.AntiguedadMaxima == input.AntiguedadMaxima ||
                    (this.AntiguedadMaxima != null &&
                    this.AntiguedadMaxima.Equals(input.AntiguedadMaxima))
                ) && 
                (
                    this.EntidadMayorDeuda == input.EntidadMayorDeuda ||
                    (this.EntidadMayorDeuda != null &&
                    this.EntidadMayorDeuda.Equals(input.EntidadMayorDeuda))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DeudaDirecta != null)
                    hashCode = hashCode * 59 + this.DeudaDirecta.GetHashCode();
                if (this.DeudaDirectaMorosa != null)
                    hashCode = hashCode * 59 + this.DeudaDirectaMorosa.GetHashCode();
                if (this.DeudaIndirecta != null)
                    hashCode = hashCode * 59 + this.DeudaIndirecta.GetHashCode();
                if (this.DeudaCastigada != null)
                    hashCode = hashCode * 59 + this.DeudaCastigada.GetHashCode();
                if (this.NumeroEntidades != null)
                    hashCode = hashCode * 59 + this.NumeroEntidades.GetHashCode();
                if (this.EntidadesDeudaDirecta != null)
                    hashCode = hashCode * 59 + this.EntidadesDeudaDirecta.GetHashCode();
                if (this.MaximoAtraso != null)
                    hashCode = hashCode * 59 + this.MaximoAtraso.GetHashCode();
                if (this.AntiguedadMaxima != null)
                    hashCode = hashCode * 59 + this.AntiguedadMaxima.GetHashCode();
                if (this.EntidadMayorDeuda != null)
                    hashCode = hashCode * 59 + this.EntidadMayorDeuda.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
