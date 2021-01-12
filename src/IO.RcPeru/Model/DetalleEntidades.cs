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
    public partial class DetalleEntidades :  IEquatable<DetalleEntidades>, IValidatableObject
    {
        public DetalleEntidades(string nombreEntidad = default(string), string idCalificacionEntidad = default(string), float? porcentajeCalificacion = default(float?), float? detalleVigente = default(float?), float? detalleVencidaMenor30 = default(float?), float? detalleVencidaMayor30 = default(float?), float? detalleJudicial = default(float?), float? detalleRefinanciada = default(float?), float? detalleIndirecta = default(float?), float? detalleCastigo = default(float?))
        {
            this.NombreEntidad = nombreEntidad;
            this.IdCalificacionEntidad = idCalificacionEntidad;
            this.PorcentajeCalificacion = porcentajeCalificacion;
            this.DetalleVigente = detalleVigente;
            this.DetalleVencidaMenor30 = detalleVencidaMenor30;
            this.DetalleVencidaMayor30 = detalleVencidaMayor30;
            this.DetalleJudicial = detalleJudicial;
            this.DetalleRefinanciada = detalleRefinanciada;
            this.DetalleIndirecta = detalleIndirecta;
            this.DetalleCastigo = detalleCastigo;
        }
        [DataMember(Name="nombreEntidad", EmitDefaultValue=false)]
        public string NombreEntidad { get; set; }
        [DataMember(Name="idCalificacionEntidad", EmitDefaultValue=false)]
        public string IdCalificacionEntidad { get; set; }
        [DataMember(Name="porcentajeCalificacion", EmitDefaultValue=false)]
        public float? PorcentajeCalificacion { get; set; }
        [DataMember(Name="detalleVigente", EmitDefaultValue=false)]
        public float? DetalleVigente { get; set; }
        [DataMember(Name="detalleVencidaMenor30", EmitDefaultValue=false)]
        public float? DetalleVencidaMenor30 { get; set; }
        [DataMember(Name="detalleVencidaMayor30", EmitDefaultValue=false)]
        public float? DetalleVencidaMayor30 { get; set; }
        [DataMember(Name="detalleJudicial", EmitDefaultValue=false)]
        public float? DetalleJudicial { get; set; }
        [DataMember(Name="detalleRefinanciada", EmitDefaultValue=false)]
        public float? DetalleRefinanciada { get; set; }
        [DataMember(Name="detalleIndirecta", EmitDefaultValue=false)]
        public float? DetalleIndirecta { get; set; }
        [DataMember(Name="detalleCastigo", EmitDefaultValue=false)]
        public float? DetalleCastigo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleEntidades {\n");
            sb.Append("  NombreEntidad: ").Append(NombreEntidad).Append("\n");
            sb.Append("  IdCalificacionEntidad: ").Append(IdCalificacionEntidad).Append("\n");
            sb.Append("  PorcentajeCalificacion: ").Append(PorcentajeCalificacion).Append("\n");
            sb.Append("  DetalleVigente: ").Append(DetalleVigente).Append("\n");
            sb.Append("  DetalleVencidaMenor30: ").Append(DetalleVencidaMenor30).Append("\n");
            sb.Append("  DetalleVencidaMayor30: ").Append(DetalleVencidaMayor30).Append("\n");
            sb.Append("  DetalleJudicial: ").Append(DetalleJudicial).Append("\n");
            sb.Append("  DetalleRefinanciada: ").Append(DetalleRefinanciada).Append("\n");
            sb.Append("  DetalleIndirecta: ").Append(DetalleIndirecta).Append("\n");
            sb.Append("  DetalleCastigo: ").Append(DetalleCastigo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleEntidades);
        }
        public bool Equals(DetalleEntidades input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NombreEntidad == input.NombreEntidad ||
                    (this.NombreEntidad != null &&
                    this.NombreEntidad.Equals(input.NombreEntidad))
                ) && 
                (
                    this.IdCalificacionEntidad == input.IdCalificacionEntidad ||
                    (this.IdCalificacionEntidad != null &&
                    this.IdCalificacionEntidad.Equals(input.IdCalificacionEntidad))
                ) && 
                (
                    this.PorcentajeCalificacion == input.PorcentajeCalificacion ||
                    (this.PorcentajeCalificacion != null &&
                    this.PorcentajeCalificacion.Equals(input.PorcentajeCalificacion))
                ) && 
                (
                    this.DetalleVigente == input.DetalleVigente ||
                    (this.DetalleVigente != null &&
                    this.DetalleVigente.Equals(input.DetalleVigente))
                ) && 
                (
                    this.DetalleVencidaMenor30 == input.DetalleVencidaMenor30 ||
                    (this.DetalleVencidaMenor30 != null &&
                    this.DetalleVencidaMenor30.Equals(input.DetalleVencidaMenor30))
                ) && 
                (
                    this.DetalleVencidaMayor30 == input.DetalleVencidaMayor30 ||
                    (this.DetalleVencidaMayor30 != null &&
                    this.DetalleVencidaMayor30.Equals(input.DetalleVencidaMayor30))
                ) && 
                (
                    this.DetalleJudicial == input.DetalleJudicial ||
                    (this.DetalleJudicial != null &&
                    this.DetalleJudicial.Equals(input.DetalleJudicial))
                ) && 
                (
                    this.DetalleRefinanciada == input.DetalleRefinanciada ||
                    (this.DetalleRefinanciada != null &&
                    this.DetalleRefinanciada.Equals(input.DetalleRefinanciada))
                ) && 
                (
                    this.DetalleIndirecta == input.DetalleIndirecta ||
                    (this.DetalleIndirecta != null &&
                    this.DetalleIndirecta.Equals(input.DetalleIndirecta))
                ) && 
                (
                    this.DetalleCastigo == input.DetalleCastigo ||
                    (this.DetalleCastigo != null &&
                    this.DetalleCastigo.Equals(input.DetalleCastigo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreEntidad != null)
                    hashCode = hashCode * 59 + this.NombreEntidad.GetHashCode();
                if (this.IdCalificacionEntidad != null)
                    hashCode = hashCode * 59 + this.IdCalificacionEntidad.GetHashCode();
                if (this.PorcentajeCalificacion != null)
                    hashCode = hashCode * 59 + this.PorcentajeCalificacion.GetHashCode();
                if (this.DetalleVigente != null)
                    hashCode = hashCode * 59 + this.DetalleVigente.GetHashCode();
                if (this.DetalleVencidaMenor30 != null)
                    hashCode = hashCode * 59 + this.DetalleVencidaMenor30.GetHashCode();
                if (this.DetalleVencidaMayor30 != null)
                    hashCode = hashCode * 59 + this.DetalleVencidaMayor30.GetHashCode();
                if (this.DetalleJudicial != null)
                    hashCode = hashCode * 59 + this.DetalleJudicial.GetHashCode();
                if (this.DetalleRefinanciada != null)
                    hashCode = hashCode * 59 + this.DetalleRefinanciada.GetHashCode();
                if (this.DetalleIndirecta != null)
                    hashCode = hashCode * 59 + this.DetalleIndirecta.GetHashCode();
                if (this.DetalleCastigo != null)
                    hashCode = hashCode * 59 + this.DetalleCastigo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
