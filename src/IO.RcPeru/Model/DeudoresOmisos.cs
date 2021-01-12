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
    public partial class DeudoresOmisos :  IEquatable<DeudoresOmisos>, IValidatableObject
    {
        public DeudoresOmisos(string tipo = default(string), string periodo = default(string), string claveSituacion = default(string), string acreedorConcepto = default(string), string fechaReporte = default(string), float? montoDeuda = default(float?))
        {
            this.Tipo = tipo;
            this.Periodo = periodo;
            this.ClaveSituacion = claveSituacion;
            this.AcreedorConcepto = acreedorConcepto;
            this.FechaReporte = fechaReporte;
            this.MontoDeuda = montoDeuda;
        }
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="acreedorConcepto", EmitDefaultValue=false)]
        public string AcreedorConcepto { get; set; }
        [DataMember(Name="fechaReporte", EmitDefaultValue=false)]
        public string FechaReporte { get; set; }
        [DataMember(Name="montoDeuda", EmitDefaultValue=false)]
        public float? MontoDeuda { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeudoresOmisos {\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  AcreedorConcepto: ").Append(AcreedorConcepto).Append("\n");
            sb.Append("  FechaReporte: ").Append(FechaReporte).Append("\n");
            sb.Append("  MontoDeuda: ").Append(MontoDeuda).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DeudoresOmisos);
        }
        public bool Equals(DeudoresOmisos input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
                ) && 
                (
                    this.Periodo == input.Periodo ||
                    (this.Periodo != null &&
                    this.Periodo.Equals(input.Periodo))
                ) && 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.AcreedorConcepto == input.AcreedorConcepto ||
                    (this.AcreedorConcepto != null &&
                    this.AcreedorConcepto.Equals(input.AcreedorConcepto))
                ) && 
                (
                    this.FechaReporte == input.FechaReporte ||
                    (this.FechaReporte != null &&
                    this.FechaReporte.Equals(input.FechaReporte))
                ) && 
                (
                    this.MontoDeuda == input.MontoDeuda ||
                    (this.MontoDeuda != null &&
                    this.MontoDeuda.Equals(input.MontoDeuda))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.AcreedorConcepto != null)
                    hashCode = hashCode * 59 + this.AcreedorConcepto.GetHashCode();
                if (this.FechaReporte != null)
                    hashCode = hashCode * 59 + this.FechaReporte.GetHashCode();
                if (this.MontoDeuda != null)
                    hashCode = hashCode * 59 + this.MontoDeuda.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
