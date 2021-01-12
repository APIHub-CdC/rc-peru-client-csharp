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
    public partial class ProtestosAceptante :  IEquatable<ProtestosAceptante>, IValidatableObject
    {
        public ProtestosAceptante(string claveTipoValor = default(string), string fechaProtesto = default(string), string claveSituacion = default(string), string fechaAclaracion = default(string), float? monto = default(float?), string nombreGirador = default(string))
        {
            this.ClaveTipoValor = claveTipoValor;
            this.FechaProtesto = fechaProtesto;
            this.ClaveSituacion = claveSituacion;
            this.FechaAclaracion = fechaAclaracion;
            this.Monto = monto;
            this.NombreGirador = nombreGirador;
        }
        [DataMember(Name="claveTipoValor", EmitDefaultValue=false)]
        public string ClaveTipoValor { get; set; }
        [DataMember(Name="fechaProtesto", EmitDefaultValue=false)]
        public string FechaProtesto { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="fechaAclaracion", EmitDefaultValue=false)]
        public string FechaAclaracion { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        [DataMember(Name="nombreGirador", EmitDefaultValue=false)]
        public string NombreGirador { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtestosAceptante {\n");
            sb.Append("  ClaveTipoValor: ").Append(ClaveTipoValor).Append("\n");
            sb.Append("  FechaProtesto: ").Append(FechaProtesto).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  FechaAclaracion: ").Append(FechaAclaracion).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("  NombreGirador: ").Append(NombreGirador).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtestosAceptante);
        }
        public bool Equals(ProtestosAceptante input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveTipoValor == input.ClaveTipoValor ||
                    (this.ClaveTipoValor != null &&
                    this.ClaveTipoValor.Equals(input.ClaveTipoValor))
                ) && 
                (
                    this.FechaProtesto == input.FechaProtesto ||
                    (this.FechaProtesto != null &&
                    this.FechaProtesto.Equals(input.FechaProtesto))
                ) && 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.FechaAclaracion == input.FechaAclaracion ||
                    (this.FechaAclaracion != null &&
                    this.FechaAclaracion.Equals(input.FechaAclaracion))
                ) && 
                (
                    this.Monto == input.Monto ||
                    (this.Monto != null &&
                    this.Monto.Equals(input.Monto))
                ) && 
                (
                    this.NombreGirador == input.NombreGirador ||
                    (this.NombreGirador != null &&
                    this.NombreGirador.Equals(input.NombreGirador))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveTipoValor != null)
                    hashCode = hashCode * 59 + this.ClaveTipoValor.GetHashCode();
                if (this.FechaProtesto != null)
                    hashCode = hashCode * 59 + this.FechaProtesto.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.FechaAclaracion != null)
                    hashCode = hashCode * 59 + this.FechaAclaracion.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                if (this.NombreGirador != null)
                    hashCode = hashCode * 59 + this.NombreGirador.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
