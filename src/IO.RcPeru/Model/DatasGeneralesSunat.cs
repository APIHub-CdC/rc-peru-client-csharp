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
    public partial class DatasGeneralesSunat :  IEquatable<DatasGeneralesSunat>, IValidatableObject
    {
        public DatasGeneralesSunat(string nombreComercial = default(string), string claveCiiu = default(string), string fechaInicioActividades = default(string), string claveTipoContribuyente = default(string), string dependencia = default(string), string clavePais = default(string), string claveEstadoContribuyente = default(string), string actividadComercioExterior = default(string), string fechaActividadComercioExterior = default(string))
        {
            this.NombreComercial = nombreComercial;
            this.ClaveCiiu = claveCiiu;
            this.FechaInicioActividades = fechaInicioActividades;
            this.ClaveTipoContribuyente = claveTipoContribuyente;
            this.Dependencia = dependencia;
            this.ClavePais = clavePais;
            this.ClaveEstadoContribuyente = claveEstadoContribuyente;
            this.ActividadComercioExterior = actividadComercioExterior;
            this.FechaActividadComercioExterior = fechaActividadComercioExterior;
        }
        [DataMember(Name="nombreComercial", EmitDefaultValue=false)]
        public string NombreComercial { get; set; }
        [DataMember(Name="claveCiiu", EmitDefaultValue=false)]
        public string ClaveCiiu { get; set; }
        [DataMember(Name="fechaInicioActividades", EmitDefaultValue=false)]
        public string FechaInicioActividades { get; set; }
        [DataMember(Name="claveTipoContribuyente", EmitDefaultValue=false)]
        public string ClaveTipoContribuyente { get; set; }
        [DataMember(Name="dependencia", EmitDefaultValue=false)]
        public string Dependencia { get; set; }
        [DataMember(Name="clavePais", EmitDefaultValue=false)]
        public string ClavePais { get; set; }
        [DataMember(Name="claveEstadoContribuyente", EmitDefaultValue=false)]
        public string ClaveEstadoContribuyente { get; set; }
        [DataMember(Name="actividadComercioExterior", EmitDefaultValue=false)]
        public string ActividadComercioExterior { get; set; }
        [DataMember(Name="fechaActividadComercioExterior", EmitDefaultValue=false)]
        public string FechaActividadComercioExterior { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasGeneralesSunat {\n");
            sb.Append("  NombreComercial: ").Append(NombreComercial).Append("\n");
            sb.Append("  ClaveCiiu: ").Append(ClaveCiiu).Append("\n");
            sb.Append("  FechaInicioActividades: ").Append(FechaInicioActividades).Append("\n");
            sb.Append("  ClaveTipoContribuyente: ").Append(ClaveTipoContribuyente).Append("\n");
            sb.Append("  Dependencia: ").Append(Dependencia).Append("\n");
            sb.Append("  ClavePais: ").Append(ClavePais).Append("\n");
            sb.Append("  ClaveEstadoContribuyente: ").Append(ClaveEstadoContribuyente).Append("\n");
            sb.Append("  ActividadComercioExterior: ").Append(ActividadComercioExterior).Append("\n");
            sb.Append("  FechaActividadComercioExterior: ").Append(FechaActividadComercioExterior).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DatasGeneralesSunat);
        }
        public bool Equals(DatasGeneralesSunat input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NombreComercial == input.NombreComercial ||
                    (this.NombreComercial != null &&
                    this.NombreComercial.Equals(input.NombreComercial))
                ) && 
                (
                    this.ClaveCiiu == input.ClaveCiiu ||
                    (this.ClaveCiiu != null &&
                    this.ClaveCiiu.Equals(input.ClaveCiiu))
                ) && 
                (
                    this.FechaInicioActividades == input.FechaInicioActividades ||
                    (this.FechaInicioActividades != null &&
                    this.FechaInicioActividades.Equals(input.FechaInicioActividades))
                ) && 
                (
                    this.ClaveTipoContribuyente == input.ClaveTipoContribuyente ||
                    (this.ClaveTipoContribuyente != null &&
                    this.ClaveTipoContribuyente.Equals(input.ClaveTipoContribuyente))
                ) && 
                (
                    this.Dependencia == input.Dependencia ||
                    (this.Dependencia != null &&
                    this.Dependencia.Equals(input.Dependencia))
                ) && 
                (
                    this.ClavePais == input.ClavePais ||
                    (this.ClavePais != null &&
                    this.ClavePais.Equals(input.ClavePais))
                ) && 
                (
                    this.ClaveEstadoContribuyente == input.ClaveEstadoContribuyente ||
                    (this.ClaveEstadoContribuyente != null &&
                    this.ClaveEstadoContribuyente.Equals(input.ClaveEstadoContribuyente))
                ) && 
                (
                    this.ActividadComercioExterior == input.ActividadComercioExterior ||
                    (this.ActividadComercioExterior != null &&
                    this.ActividadComercioExterior.Equals(input.ActividadComercioExterior))
                ) && 
                (
                    this.FechaActividadComercioExterior == input.FechaActividadComercioExterior ||
                    (this.FechaActividadComercioExterior != null &&
                    this.FechaActividadComercioExterior.Equals(input.FechaActividadComercioExterior))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreComercial != null)
                    hashCode = hashCode * 59 + this.NombreComercial.GetHashCode();
                if (this.ClaveCiiu != null)
                    hashCode = hashCode * 59 + this.ClaveCiiu.GetHashCode();
                if (this.FechaInicioActividades != null)
                    hashCode = hashCode * 59 + this.FechaInicioActividades.GetHashCode();
                if (this.ClaveTipoContribuyente != null)
                    hashCode = hashCode * 59 + this.ClaveTipoContribuyente.GetHashCode();
                if (this.Dependencia != null)
                    hashCode = hashCode * 59 + this.Dependencia.GetHashCode();
                if (this.ClavePais != null)
                    hashCode = hashCode * 59 + this.ClavePais.GetHashCode();
                if (this.ClaveEstadoContribuyente != null)
                    hashCode = hashCode * 59 + this.ClaveEstadoContribuyente.GetHashCode();
                if (this.ActividadComercioExterior != null)
                    hashCode = hashCode * 59 + this.ActividadComercioExterior.GetHashCode();
                if (this.FechaActividadComercioExterior != null)
                    hashCode = hashCode * 59 + this.FechaActividadComercioExterior.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
