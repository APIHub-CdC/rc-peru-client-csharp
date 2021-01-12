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
    public partial class DetalleCreditosMFNZ :  IEquatable<DetalleCreditosMFNZ>, IValidatableObject
    {
        public DetalleCreditosMFNZ(string periodo = default(string), decimal? entidades = default(decimal?), string idPeorCalificacion = default(string), float? porcentaje = default(float?), float? vigente = default(float?), float? vencidaMenor30 = default(float?), float? vencidaMayor30 = default(float?), float? judicial = default(float?), float? refinanciada = default(float?), float? indirecta = default(float?), float? castigos = default(float?), List<DetalleEntidades> detalleEntidades = default(List<DetalleEntidades>))
        {
            this.Periodo = periodo;
            this.Entidades = entidades;
            this.IdPeorCalificacion = idPeorCalificacion;
            this.Porcentaje = porcentaje;
            this.Vigente = vigente;
            this.VencidaMenor30 = vencidaMenor30;
            this.VencidaMayor30 = vencidaMayor30;
            this.Judicial = judicial;
            this.Refinanciada = refinanciada;
            this.Indirecta = indirecta;
            this.Castigos = castigos;
            this.DetalleEntidades = detalleEntidades;
        }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="entidades", EmitDefaultValue=false)]
        public decimal? Entidades { get; set; }
        [DataMember(Name="idPeorCalificacion", EmitDefaultValue=false)]
        public string IdPeorCalificacion { get; set; }
        [DataMember(Name="porcentaje", EmitDefaultValue=false)]
        public float? Porcentaje { get; set; }
        [DataMember(Name="vigente", EmitDefaultValue=false)]
        public float? Vigente { get; set; }
        [DataMember(Name="vencidaMenor30", EmitDefaultValue=false)]
        public float? VencidaMenor30 { get; set; }
        [DataMember(Name="vencidaMayor30", EmitDefaultValue=false)]
        public float? VencidaMayor30 { get; set; }
        [DataMember(Name="judicial", EmitDefaultValue=false)]
        public float? Judicial { get; set; }
        [DataMember(Name="refinanciada", EmitDefaultValue=false)]
        public float? Refinanciada { get; set; }
        [DataMember(Name="indirecta", EmitDefaultValue=false)]
        public float? Indirecta { get; set; }
        [DataMember(Name="castigos", EmitDefaultValue=false)]
        public float? Castigos { get; set; }
        [DataMember(Name="detalleEntidades", EmitDefaultValue=false)]
        public List<DetalleEntidades> DetalleEntidades { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleCreditosMFNZ {\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  Entidades: ").Append(Entidades).Append("\n");
            sb.Append("  IdPeorCalificacion: ").Append(IdPeorCalificacion).Append("\n");
            sb.Append("  Porcentaje: ").Append(Porcentaje).Append("\n");
            sb.Append("  Vigente: ").Append(Vigente).Append("\n");
            sb.Append("  VencidaMenor30: ").Append(VencidaMenor30).Append("\n");
            sb.Append("  VencidaMayor30: ").Append(VencidaMayor30).Append("\n");
            sb.Append("  Judicial: ").Append(Judicial).Append("\n");
            sb.Append("  Refinanciada: ").Append(Refinanciada).Append("\n");
            sb.Append("  Indirecta: ").Append(Indirecta).Append("\n");
            sb.Append("  Castigos: ").Append(Castigos).Append("\n");
            sb.Append("  DetalleEntidades: ").Append(DetalleEntidades).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleCreditosMFNZ);
        }
        public bool Equals(DetalleCreditosMFNZ input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Periodo == input.Periodo ||
                    (this.Periodo != null &&
                    this.Periodo.Equals(input.Periodo))
                ) && 
                (
                    this.Entidades == input.Entidades ||
                    (this.Entidades != null &&
                    this.Entidades.Equals(input.Entidades))
                ) && 
                (
                    this.IdPeorCalificacion == input.IdPeorCalificacion ||
                    (this.IdPeorCalificacion != null &&
                    this.IdPeorCalificacion.Equals(input.IdPeorCalificacion))
                ) && 
                (
                    this.Porcentaje == input.Porcentaje ||
                    (this.Porcentaje != null &&
                    this.Porcentaje.Equals(input.Porcentaje))
                ) && 
                (
                    this.Vigente == input.Vigente ||
                    (this.Vigente != null &&
                    this.Vigente.Equals(input.Vigente))
                ) && 
                (
                    this.VencidaMenor30 == input.VencidaMenor30 ||
                    (this.VencidaMenor30 != null &&
                    this.VencidaMenor30.Equals(input.VencidaMenor30))
                ) && 
                (
                    this.VencidaMayor30 == input.VencidaMayor30 ||
                    (this.VencidaMayor30 != null &&
                    this.VencidaMayor30.Equals(input.VencidaMayor30))
                ) && 
                (
                    this.Judicial == input.Judicial ||
                    (this.Judicial != null &&
                    this.Judicial.Equals(input.Judicial))
                ) && 
                (
                    this.Refinanciada == input.Refinanciada ||
                    (this.Refinanciada != null &&
                    this.Refinanciada.Equals(input.Refinanciada))
                ) && 
                (
                    this.Indirecta == input.Indirecta ||
                    (this.Indirecta != null &&
                    this.Indirecta.Equals(input.Indirecta))
                ) && 
                (
                    this.Castigos == input.Castigos ||
                    (this.Castigos != null &&
                    this.Castigos.Equals(input.Castigos))
                ) && 
                (
                    this.DetalleEntidades == input.DetalleEntidades ||
                    this.DetalleEntidades != null &&
                    this.DetalleEntidades.SequenceEqual(input.DetalleEntidades)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.Entidades != null)
                    hashCode = hashCode * 59 + this.Entidades.GetHashCode();
                if (this.IdPeorCalificacion != null)
                    hashCode = hashCode * 59 + this.IdPeorCalificacion.GetHashCode();
                if (this.Porcentaje != null)
                    hashCode = hashCode * 59 + this.Porcentaje.GetHashCode();
                if (this.Vigente != null)
                    hashCode = hashCode * 59 + this.Vigente.GetHashCode();
                if (this.VencidaMenor30 != null)
                    hashCode = hashCode * 59 + this.VencidaMenor30.GetHashCode();
                if (this.VencidaMayor30 != null)
                    hashCode = hashCode * 59 + this.VencidaMayor30.GetHashCode();
                if (this.Judicial != null)
                    hashCode = hashCode * 59 + this.Judicial.GetHashCode();
                if (this.Refinanciada != null)
                    hashCode = hashCode * 59 + this.Refinanciada.GetHashCode();
                if (this.Indirecta != null)
                    hashCode = hashCode * 59 + this.Indirecta.GetHashCode();
                if (this.Castigos != null)
                    hashCode = hashCode * 59 + this.Castigos.GetHashCode();
                if (this.DetalleEntidades != null)
                    hashCode = hashCode * 59 + this.DetalleEntidades.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
