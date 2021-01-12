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
    public partial class ProtestosGirador :  IEquatable<ProtestosGirador>, IValidatableObject
    {
        public ProtestosGirador(string nombreAceptante = default(string), string segundoNombreAceptante = default(string), string apellidoPaternoAceptante = default(string), string apellidoMaternoAceptante = default(string), string claveSituacion = default(string), string fechaProtesto = default(string), string fechaAclaracion = default(string), float? monto = default(float?), string claveTipoValor = default(string))
        {
            this.NombreAceptante = nombreAceptante;
            this.SegundoNombreAceptante = segundoNombreAceptante;
            this.ApellidoPaternoAceptante = apellidoPaternoAceptante;
            this.ApellidoMaternoAceptante = apellidoMaternoAceptante;
            this.ClaveSituacion = claveSituacion;
            this.FechaProtesto = fechaProtesto;
            this.FechaAclaracion = fechaAclaracion;
            this.Monto = monto;
            this.ClaveTipoValor = claveTipoValor;
        }
        [DataMember(Name="nombreAceptante", EmitDefaultValue=false)]
        public string NombreAceptante { get; set; }
        [DataMember(Name="segundoNombreAceptante", EmitDefaultValue=false)]
        public string SegundoNombreAceptante { get; set; }
        [DataMember(Name="apellidoPaternoAceptante", EmitDefaultValue=false)]
        public string ApellidoPaternoAceptante { get; set; }
        [DataMember(Name="apellidoMaternoAceptante", EmitDefaultValue=false)]
        public string ApellidoMaternoAceptante { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="fechaProtesto", EmitDefaultValue=false)]
        public string FechaProtesto { get; set; }
        [DataMember(Name="fechaAclaracion", EmitDefaultValue=false)]
        public string FechaAclaracion { get; set; }
        [DataMember(Name="monto", EmitDefaultValue=false)]
        public float? Monto { get; set; }
        [DataMember(Name="claveTipoValor", EmitDefaultValue=false)]
        public string ClaveTipoValor { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtestosGirador {\n");
            sb.Append("  NombreAceptante: ").Append(NombreAceptante).Append("\n");
            sb.Append("  SegundoNombreAceptante: ").Append(SegundoNombreAceptante).Append("\n");
            sb.Append("  ApellidoPaternoAceptante: ").Append(ApellidoPaternoAceptante).Append("\n");
            sb.Append("  ApellidoMaternoAceptante: ").Append(ApellidoMaternoAceptante).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  FechaProtesto: ").Append(FechaProtesto).Append("\n");
            sb.Append("  FechaAclaracion: ").Append(FechaAclaracion).Append("\n");
            sb.Append("  Monto: ").Append(Monto).Append("\n");
            sb.Append("  ClaveTipoValor: ").Append(ClaveTipoValor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtestosGirador);
        }
        public bool Equals(ProtestosGirador input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NombreAceptante == input.NombreAceptante ||
                    (this.NombreAceptante != null &&
                    this.NombreAceptante.Equals(input.NombreAceptante))
                ) && 
                (
                    this.SegundoNombreAceptante == input.SegundoNombreAceptante ||
                    (this.SegundoNombreAceptante != null &&
                    this.SegundoNombreAceptante.Equals(input.SegundoNombreAceptante))
                ) && 
                (
                    this.ApellidoPaternoAceptante == input.ApellidoPaternoAceptante ||
                    (this.ApellidoPaternoAceptante != null &&
                    this.ApellidoPaternoAceptante.Equals(input.ApellidoPaternoAceptante))
                ) && 
                (
                    this.ApellidoMaternoAceptante == input.ApellidoMaternoAceptante ||
                    (this.ApellidoMaternoAceptante != null &&
                    this.ApellidoMaternoAceptante.Equals(input.ApellidoMaternoAceptante))
                ) && 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.FechaProtesto == input.FechaProtesto ||
                    (this.FechaProtesto != null &&
                    this.FechaProtesto.Equals(input.FechaProtesto))
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
                    this.ClaveTipoValor == input.ClaveTipoValor ||
                    (this.ClaveTipoValor != null &&
                    this.ClaveTipoValor.Equals(input.ClaveTipoValor))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreAceptante != null)
                    hashCode = hashCode * 59 + this.NombreAceptante.GetHashCode();
                if (this.SegundoNombreAceptante != null)
                    hashCode = hashCode * 59 + this.SegundoNombreAceptante.GetHashCode();
                if (this.ApellidoPaternoAceptante != null)
                    hashCode = hashCode * 59 + this.ApellidoPaternoAceptante.GetHashCode();
                if (this.ApellidoMaternoAceptante != null)
                    hashCode = hashCode * 59 + this.ApellidoMaternoAceptante.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.FechaProtesto != null)
                    hashCode = hashCode * 59 + this.FechaProtesto.GetHashCode();
                if (this.FechaAclaracion != null)
                    hashCode = hashCode * 59 + this.FechaAclaracion.GetHashCode();
                if (this.Monto != null)
                    hashCode = hashCode * 59 + this.Monto.GetHashCode();
                if (this.ClaveTipoValor != null)
                    hashCode = hashCode * 59 + this.ClaveTipoValor.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
