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
    public partial class DetalleCreditosRCC :  IEquatable<DetalleCreditosRCC>, IValidatableObject
    {
        public DetalleCreditosRCC(string claveMes = default(string), decimal? numeroEntidades = default(decimal?), string idPeorCalificacion = default(string), float? porcentajeCalificacion = default(float?), float? deudaVigente = default(float?), float? deudaVencida = default(float?), float? deudaJudicial = default(float?), float? deudaRR = default(float?), float? deudaIndirecta = default(float?), float? castigos = default(float?), float? provisiones = default(float?), List<Entidades> entidades = default(List<Entidades>))
        {
            this.ClaveMes = claveMes;
            this.NumeroEntidades = numeroEntidades;
            this.IdPeorCalificacion = idPeorCalificacion;
            this.PorcentajeCalificacion = porcentajeCalificacion;
            this.DeudaVigente = deudaVigente;
            this.DeudaVencida = deudaVencida;
            this.DeudaJudicial = deudaJudicial;
            this.DeudaRR = deudaRR;
            this.DeudaIndirecta = deudaIndirecta;
            this.Castigos = castigos;
            this.Provisiones = provisiones;
            this.Entidades = entidades;
        }
        [DataMember(Name="claveMes", EmitDefaultValue=false)]
        public string ClaveMes { get; set; }
        [DataMember(Name="numeroEntidades", EmitDefaultValue=false)]
        public decimal? NumeroEntidades { get; set; }
        [DataMember(Name="idPeorCalificacion", EmitDefaultValue=false)]
        public string IdPeorCalificacion { get; set; }
        [DataMember(Name="porcentajeCalificacion", EmitDefaultValue=false)]
        public float? PorcentajeCalificacion { get; set; }
        [DataMember(Name="deudaVigente", EmitDefaultValue=false)]
        public float? DeudaVigente { get; set; }
        [DataMember(Name="deudaVencida", EmitDefaultValue=false)]
        public float? DeudaVencida { get; set; }
        [DataMember(Name="deudaJudicial", EmitDefaultValue=false)]
        public float? DeudaJudicial { get; set; }
        [DataMember(Name="deudaRR", EmitDefaultValue=false)]
        public float? DeudaRR { get; set; }
        [DataMember(Name="deudaIndirecta", EmitDefaultValue=false)]
        public float? DeudaIndirecta { get; set; }
        [DataMember(Name="castigos", EmitDefaultValue=false)]
        public float? Castigos { get; set; }
        [DataMember(Name="provisiones", EmitDefaultValue=false)]
        public float? Provisiones { get; set; }
        [DataMember(Name="entidades", EmitDefaultValue=false)]
        public List<Entidades> Entidades { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleCreditosRCC {\n");
            sb.Append("  ClaveMes: ").Append(ClaveMes).Append("\n");
            sb.Append("  NumeroEntidades: ").Append(NumeroEntidades).Append("\n");
            sb.Append("  IdPeorCalificacion: ").Append(IdPeorCalificacion).Append("\n");
            sb.Append("  PorcentajeCalificacion: ").Append(PorcentajeCalificacion).Append("\n");
            sb.Append("  DeudaVigente: ").Append(DeudaVigente).Append("\n");
            sb.Append("  DeudaVencida: ").Append(DeudaVencida).Append("\n");
            sb.Append("  DeudaJudicial: ").Append(DeudaJudicial).Append("\n");
            sb.Append("  DeudaRR: ").Append(DeudaRR).Append("\n");
            sb.Append("  DeudaIndirecta: ").Append(DeudaIndirecta).Append("\n");
            sb.Append("  Castigos: ").Append(Castigos).Append("\n");
            sb.Append("  Provisiones: ").Append(Provisiones).Append("\n");
            sb.Append("  Entidades: ").Append(Entidades).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleCreditosRCC);
        }
        public bool Equals(DetalleCreditosRCC input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveMes == input.ClaveMes ||
                    (this.ClaveMes != null &&
                    this.ClaveMes.Equals(input.ClaveMes))
                ) && 
                (
                    this.NumeroEntidades == input.NumeroEntidades ||
                    (this.NumeroEntidades != null &&
                    this.NumeroEntidades.Equals(input.NumeroEntidades))
                ) && 
                (
                    this.IdPeorCalificacion == input.IdPeorCalificacion ||
                    (this.IdPeorCalificacion != null &&
                    this.IdPeorCalificacion.Equals(input.IdPeorCalificacion))
                ) && 
                (
                    this.PorcentajeCalificacion == input.PorcentajeCalificacion ||
                    (this.PorcentajeCalificacion != null &&
                    this.PorcentajeCalificacion.Equals(input.PorcentajeCalificacion))
                ) && 
                (
                    this.DeudaVigente == input.DeudaVigente ||
                    (this.DeudaVigente != null &&
                    this.DeudaVigente.Equals(input.DeudaVigente))
                ) && 
                (
                    this.DeudaVencida == input.DeudaVencida ||
                    (this.DeudaVencida != null &&
                    this.DeudaVencida.Equals(input.DeudaVencida))
                ) && 
                (
                    this.DeudaJudicial == input.DeudaJudicial ||
                    (this.DeudaJudicial != null &&
                    this.DeudaJudicial.Equals(input.DeudaJudicial))
                ) && 
                (
                    this.DeudaRR == input.DeudaRR ||
                    (this.DeudaRR != null &&
                    this.DeudaRR.Equals(input.DeudaRR))
                ) && 
                (
                    this.DeudaIndirecta == input.DeudaIndirecta ||
                    (this.DeudaIndirecta != null &&
                    this.DeudaIndirecta.Equals(input.DeudaIndirecta))
                ) && 
                (
                    this.Castigos == input.Castigos ||
                    (this.Castigos != null &&
                    this.Castigos.Equals(input.Castigos))
                ) && 
                (
                    this.Provisiones == input.Provisiones ||
                    (this.Provisiones != null &&
                    this.Provisiones.Equals(input.Provisiones))
                ) && 
                (
                    this.Entidades == input.Entidades ||
                    this.Entidades != null &&
                    this.Entidades.SequenceEqual(input.Entidades)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveMes != null)
                    hashCode = hashCode * 59 + this.ClaveMes.GetHashCode();
                if (this.NumeroEntidades != null)
                    hashCode = hashCode * 59 + this.NumeroEntidades.GetHashCode();
                if (this.IdPeorCalificacion != null)
                    hashCode = hashCode * 59 + this.IdPeorCalificacion.GetHashCode();
                if (this.PorcentajeCalificacion != null)
                    hashCode = hashCode * 59 + this.PorcentajeCalificacion.GetHashCode();
                if (this.DeudaVigente != null)
                    hashCode = hashCode * 59 + this.DeudaVigente.GetHashCode();
                if (this.DeudaVencida != null)
                    hashCode = hashCode * 59 + this.DeudaVencida.GetHashCode();
                if (this.DeudaJudicial != null)
                    hashCode = hashCode * 59 + this.DeudaJudicial.GetHashCode();
                if (this.DeudaRR != null)
                    hashCode = hashCode * 59 + this.DeudaRR.GetHashCode();
                if (this.DeudaIndirecta != null)
                    hashCode = hashCode * 59 + this.DeudaIndirecta.GetHashCode();
                if (this.Castigos != null)
                    hashCode = hashCode * 59 + this.Castigos.GetHashCode();
                if (this.Provisiones != null)
                    hashCode = hashCode * 59 + this.Provisiones.GetHashCode();
                if (this.Entidades != null)
                    hashCode = hashCode * 59 + this.Entidades.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
