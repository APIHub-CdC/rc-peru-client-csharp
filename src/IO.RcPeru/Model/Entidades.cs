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
    public partial class Entidades :  IEquatable<Entidades>, IValidatableObject
    {
        public Entidades(string nombreEntidad = default(string), string idCalificacion = default(string), float? porcentajeCalificacion = default(float?), float? detalleVigente = default(float?), float? detalleVencida = default(float?), float? detalleJudicial = default(float?), float? detalleRR = default(float?), float? detalleIndirecta = default(float?), float? detalleCastigos = default(float?), float? detalleProvisiones = default(float?))
        {
            this.NombreEntidad = nombreEntidad;
            this.IdCalificacion = idCalificacion;
            this.PorcentajeCalificacion = porcentajeCalificacion;
            this.DetalleVigente = detalleVigente;
            this.DetalleVencida = detalleVencida;
            this.DetalleJudicial = detalleJudicial;
            this.DetalleRR = detalleRR;
            this.DetalleIndirecta = detalleIndirecta;
            this.DetalleCastigos = detalleCastigos;
            this.DetalleProvisiones = detalleProvisiones;
        }
        [DataMember(Name="nombreEntidad", EmitDefaultValue=false)]
        public string NombreEntidad { get; set; }
        [DataMember(Name="idCalificacion", EmitDefaultValue=false)]
        public string IdCalificacion { get; set; }
        [DataMember(Name="porcentajeCalificacion", EmitDefaultValue=false)]
        public float? PorcentajeCalificacion { get; set; }
        [DataMember(Name="detalleVigente", EmitDefaultValue=false)]
        public float? DetalleVigente { get; set; }
        [DataMember(Name="detalleVencida", EmitDefaultValue=false)]
        public float? DetalleVencida { get; set; }
        [DataMember(Name="detalleJudicial", EmitDefaultValue=false)]
        public float? DetalleJudicial { get; set; }
        [DataMember(Name="detalleRR", EmitDefaultValue=false)]
        public float? DetalleRR { get; set; }
        [DataMember(Name="detalleIndirecta", EmitDefaultValue=false)]
        public float? DetalleIndirecta { get; set; }
        [DataMember(Name="detalleCastigos", EmitDefaultValue=false)]
        public float? DetalleCastigos { get; set; }
        [DataMember(Name="detalleProvisiones", EmitDefaultValue=false)]
        public float? DetalleProvisiones { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entidades {\n");
            sb.Append("  NombreEntidad: ").Append(NombreEntidad).Append("\n");
            sb.Append("  IdCalificacion: ").Append(IdCalificacion).Append("\n");
            sb.Append("  PorcentajeCalificacion: ").Append(PorcentajeCalificacion).Append("\n");
            sb.Append("  DetalleVigente: ").Append(DetalleVigente).Append("\n");
            sb.Append("  DetalleVencida: ").Append(DetalleVencida).Append("\n");
            sb.Append("  DetalleJudicial: ").Append(DetalleJudicial).Append("\n");
            sb.Append("  DetalleRR: ").Append(DetalleRR).Append("\n");
            sb.Append("  DetalleIndirecta: ").Append(DetalleIndirecta).Append("\n");
            sb.Append("  DetalleCastigos: ").Append(DetalleCastigos).Append("\n");
            sb.Append("  DetalleProvisiones: ").Append(DetalleProvisiones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Entidades);
        }
        public bool Equals(Entidades input)
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
                    this.IdCalificacion == input.IdCalificacion ||
                    (this.IdCalificacion != null &&
                    this.IdCalificacion.Equals(input.IdCalificacion))
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
                    this.DetalleVencida == input.DetalleVencida ||
                    (this.DetalleVencida != null &&
                    this.DetalleVencida.Equals(input.DetalleVencida))
                ) && 
                (
                    this.DetalleJudicial == input.DetalleJudicial ||
                    (this.DetalleJudicial != null &&
                    this.DetalleJudicial.Equals(input.DetalleJudicial))
                ) && 
                (
                    this.DetalleRR == input.DetalleRR ||
                    (this.DetalleRR != null &&
                    this.DetalleRR.Equals(input.DetalleRR))
                ) && 
                (
                    this.DetalleIndirecta == input.DetalleIndirecta ||
                    (this.DetalleIndirecta != null &&
                    this.DetalleIndirecta.Equals(input.DetalleIndirecta))
                ) && 
                (
                    this.DetalleCastigos == input.DetalleCastigos ||
                    (this.DetalleCastigos != null &&
                    this.DetalleCastigos.Equals(input.DetalleCastigos))
                ) && 
                (
                    this.DetalleProvisiones == input.DetalleProvisiones ||
                    (this.DetalleProvisiones != null &&
                    this.DetalleProvisiones.Equals(input.DetalleProvisiones))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreEntidad != null)
                    hashCode = hashCode * 59 + this.NombreEntidad.GetHashCode();
                if (this.IdCalificacion != null)
                    hashCode = hashCode * 59 + this.IdCalificacion.GetHashCode();
                if (this.PorcentajeCalificacion != null)
                    hashCode = hashCode * 59 + this.PorcentajeCalificacion.GetHashCode();
                if (this.DetalleVigente != null)
                    hashCode = hashCode * 59 + this.DetalleVigente.GetHashCode();
                if (this.DetalleVencida != null)
                    hashCode = hashCode * 59 + this.DetalleVencida.GetHashCode();
                if (this.DetalleJudicial != null)
                    hashCode = hashCode * 59 + this.DetalleJudicial.GetHashCode();
                if (this.DetalleRR != null)
                    hashCode = hashCode * 59 + this.DetalleRR.GetHashCode();
                if (this.DetalleIndirecta != null)
                    hashCode = hashCode * 59 + this.DetalleIndirecta.GetHashCode();
                if (this.DetalleCastigos != null)
                    hashCode = hashCode * 59 + this.DetalleCastigos.GetHashCode();
                if (this.DetalleProvisiones != null)
                    hashCode = hashCode * 59 + this.DetalleProvisiones.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
