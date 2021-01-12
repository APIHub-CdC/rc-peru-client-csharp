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
    public partial class DeudasAFP :  IEquatable<DeudasAFP>, IValidatableObject
    {
        public DeudasAFP(string descripcionEntidad = default(string), string fechaReporte = default(string), string claveTipoDeuda = default(string), string periodoDevengue = default(string), float? importeDeudaFondo = default(float?), float? importeDeudaAFP = default(float?), string claveCondicionDeuda = default(string), string claveSituacion = default(string))
        {
            this.DescripcionEntidad = descripcionEntidad;
            this.FechaReporte = fechaReporte;
            this.ClaveTipoDeuda = claveTipoDeuda;
            this.PeriodoDevengue = periodoDevengue;
            this.ImporteDeudaFondo = importeDeudaFondo;
            this.ImporteDeudaAFP = importeDeudaAFP;
            this.ClaveCondicionDeuda = claveCondicionDeuda;
            this.ClaveSituacion = claveSituacion;
        }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="fechaReporte", EmitDefaultValue=false)]
        public string FechaReporte { get; set; }
        [DataMember(Name="claveTipoDeuda", EmitDefaultValue=false)]
        public string ClaveTipoDeuda { get; set; }
        [DataMember(Name="periodoDevengue", EmitDefaultValue=false)]
        public string PeriodoDevengue { get; set; }
        [DataMember(Name="importeDeudaFondo", EmitDefaultValue=false)]
        public float? ImporteDeudaFondo { get; set; }
        [DataMember(Name="importeDeudaAFP", EmitDefaultValue=false)]
        public float? ImporteDeudaAFP { get; set; }
        [DataMember(Name="claveCondicionDeuda", EmitDefaultValue=false)]
        public string ClaveCondicionDeuda { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeudasAFP {\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  FechaReporte: ").Append(FechaReporte).Append("\n");
            sb.Append("  ClaveTipoDeuda: ").Append(ClaveTipoDeuda).Append("\n");
            sb.Append("  PeriodoDevengue: ").Append(PeriodoDevengue).Append("\n");
            sb.Append("  ImporteDeudaFondo: ").Append(ImporteDeudaFondo).Append("\n");
            sb.Append("  ImporteDeudaAFP: ").Append(ImporteDeudaAFP).Append("\n");
            sb.Append("  ClaveCondicionDeuda: ").Append(ClaveCondicionDeuda).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DeudasAFP);
        }
        public bool Equals(DeudasAFP input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DescripcionEntidad == input.DescripcionEntidad ||
                    (this.DescripcionEntidad != null &&
                    this.DescripcionEntidad.Equals(input.DescripcionEntidad))
                ) && 
                (
                    this.FechaReporte == input.FechaReporte ||
                    (this.FechaReporte != null &&
                    this.FechaReporte.Equals(input.FechaReporte))
                ) && 
                (
                    this.ClaveTipoDeuda == input.ClaveTipoDeuda ||
                    (this.ClaveTipoDeuda != null &&
                    this.ClaveTipoDeuda.Equals(input.ClaveTipoDeuda))
                ) && 
                (
                    this.PeriodoDevengue == input.PeriodoDevengue ||
                    (this.PeriodoDevengue != null &&
                    this.PeriodoDevengue.Equals(input.PeriodoDevengue))
                ) && 
                (
                    this.ImporteDeudaFondo == input.ImporteDeudaFondo ||
                    (this.ImporteDeudaFondo != null &&
                    this.ImporteDeudaFondo.Equals(input.ImporteDeudaFondo))
                ) && 
                (
                    this.ImporteDeudaAFP == input.ImporteDeudaAFP ||
                    (this.ImporteDeudaAFP != null &&
                    this.ImporteDeudaAFP.Equals(input.ImporteDeudaAFP))
                ) && 
                (
                    this.ClaveCondicionDeuda == input.ClaveCondicionDeuda ||
                    (this.ClaveCondicionDeuda != null &&
                    this.ClaveCondicionDeuda.Equals(input.ClaveCondicionDeuda))
                ) && 
                (
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.FechaReporte != null)
                    hashCode = hashCode * 59 + this.FechaReporte.GetHashCode();
                if (this.ClaveTipoDeuda != null)
                    hashCode = hashCode * 59 + this.ClaveTipoDeuda.GetHashCode();
                if (this.PeriodoDevengue != null)
                    hashCode = hashCode * 59 + this.PeriodoDevengue.GetHashCode();
                if (this.ImporteDeudaFondo != null)
                    hashCode = hashCode * 59 + this.ImporteDeudaFondo.GetHashCode();
                if (this.ImporteDeudaAFP != null)
                    hashCode = hashCode * 59 + this.ImporteDeudaAFP.GetHashCode();
                if (this.ClaveCondicionDeuda != null)
                    hashCode = hashCode * 59 + this.ClaveCondicionDeuda.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
