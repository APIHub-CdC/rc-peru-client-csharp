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
    public partial class DetalleProducto :  IEquatable<DetalleProducto>, IValidatableObject
    {
        public DetalleProducto(string claveProducto = default(string), string claveTipoProducto = default(string), string idCalificacion = default(string), string fechaReporteSBS = default(string), float? totalDeudaDirecta = default(float?), decimal? maximaMorosidad24meses = default(decimal?), decimal? maximaMorosidadActual = default(decimal?), decimal? antiguedad = default(decimal?), decimal? entidadesRegistradas = default(decimal?), decimal? entidadesAtrasos = default(decimal?), float? deudaVigente = default(float?), float? deudaReestructurada = default(float?), float? deudaRefinanciada = default(float?), float? deudaVencida = default(float?), float? deudaVencidaMenor30 = default(float?), float? deudaVencidaMayor30 = default(float?), float? deudaJudicial = default(float?), float? porcentajeDeudaMorosa = default(float?), float? porcentajeDeudaMonedaExtranjera = default(float?), float? deudaIndirecta = default(float?), float? lineaCredito = default(float?))
        {
            this.ClaveProducto = claveProducto;
            this.ClaveTipoProducto = claveTipoProducto;
            this.IdCalificacion = idCalificacion;
            this.FechaReporteSBS = fechaReporteSBS;
            this.TotalDeudaDirecta = totalDeudaDirecta;
            this.MaximaMorosidad24meses = maximaMorosidad24meses;
            this.MaximaMorosidadActual = maximaMorosidadActual;
            this.Antiguedad = antiguedad;
            this.EntidadesRegistradas = entidadesRegistradas;
            this.EntidadesAtrasos = entidadesAtrasos;
            this.DeudaVigente = deudaVigente;
            this.DeudaReestructurada = deudaReestructurada;
            this.DeudaRefinanciada = deudaRefinanciada;
            this.DeudaVencida = deudaVencida;
            this.DeudaVencidaMenor30 = deudaVencidaMenor30;
            this.DeudaVencidaMayor30 = deudaVencidaMayor30;
            this.DeudaJudicial = deudaJudicial;
            this.PorcentajeDeudaMorosa = porcentajeDeudaMorosa;
            this.PorcentajeDeudaMonedaExtranjera = porcentajeDeudaMonedaExtranjera;
            this.DeudaIndirecta = deudaIndirecta;
            this.LineaCredito = lineaCredito;
        }
        [DataMember(Name="claveProducto", EmitDefaultValue=false)]
        public string ClaveProducto { get; set; }
        [DataMember(Name="claveTipoProducto", EmitDefaultValue=false)]
        public string ClaveTipoProducto { get; set; }
        [DataMember(Name="idCalificacion", EmitDefaultValue=false)]
        public string IdCalificacion { get; set; }
        [DataMember(Name="fechaReporteSBS", EmitDefaultValue=false)]
        public string FechaReporteSBS { get; set; }
        [DataMember(Name="totalDeudaDirecta", EmitDefaultValue=false)]
        public float? TotalDeudaDirecta { get; set; }
        [DataMember(Name="maximaMorosidad24meses", EmitDefaultValue=false)]
        public decimal? MaximaMorosidad24meses { get; set; }
        [DataMember(Name="maximaMorosidadActual", EmitDefaultValue=false)]
        public decimal? MaximaMorosidadActual { get; set; }
        [DataMember(Name="antiguedad", EmitDefaultValue=false)]
        public decimal? Antiguedad { get; set; }
        [DataMember(Name="entidadesRegistradas", EmitDefaultValue=false)]
        public decimal? EntidadesRegistradas { get; set; }
        [DataMember(Name="entidadesAtrasos", EmitDefaultValue=false)]
        public decimal? EntidadesAtrasos { get; set; }
        [DataMember(Name="deudaVigente", EmitDefaultValue=false)]
        public float? DeudaVigente { get; set; }
        [DataMember(Name="deudaReestructurada", EmitDefaultValue=false)]
        public float? DeudaReestructurada { get; set; }
        [DataMember(Name="deudaRefinanciada", EmitDefaultValue=false)]
        public float? DeudaRefinanciada { get; set; }
        [DataMember(Name="deudaVencida", EmitDefaultValue=false)]
        public float? DeudaVencida { get; set; }
        [DataMember(Name="deudaVencidaMenor30", EmitDefaultValue=false)]
        public float? DeudaVencidaMenor30 { get; set; }
        [DataMember(Name="deudaVencidaMayor30", EmitDefaultValue=false)]
        public float? DeudaVencidaMayor30 { get; set; }
        [DataMember(Name="deudaJudicial", EmitDefaultValue=false)]
        public float? DeudaJudicial { get; set; }
        [DataMember(Name="porcentajeDeudaMorosa", EmitDefaultValue=false)]
        public float? PorcentajeDeudaMorosa { get; set; }
        [DataMember(Name="porcentajeDeudaMonedaExtranjera", EmitDefaultValue=false)]
        public float? PorcentajeDeudaMonedaExtranjera { get; set; }
        [DataMember(Name="deudaIndirecta", EmitDefaultValue=false)]
        public float? DeudaIndirecta { get; set; }
        [DataMember(Name="lineaCredito", EmitDefaultValue=false)]
        public float? LineaCredito { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleProducto {\n");
            sb.Append("  ClaveProducto: ").Append(ClaveProducto).Append("\n");
            sb.Append("  ClaveTipoProducto: ").Append(ClaveTipoProducto).Append("\n");
            sb.Append("  IdCalificacion: ").Append(IdCalificacion).Append("\n");
            sb.Append("  FechaReporteSBS: ").Append(FechaReporteSBS).Append("\n");
            sb.Append("  TotalDeudaDirecta: ").Append(TotalDeudaDirecta).Append("\n");
            sb.Append("  MaximaMorosidad24meses: ").Append(MaximaMorosidad24meses).Append("\n");
            sb.Append("  MaximaMorosidadActual: ").Append(MaximaMorosidadActual).Append("\n");
            sb.Append("  Antiguedad: ").Append(Antiguedad).Append("\n");
            sb.Append("  EntidadesRegistradas: ").Append(EntidadesRegistradas).Append("\n");
            sb.Append("  EntidadesAtrasos: ").Append(EntidadesAtrasos).Append("\n");
            sb.Append("  DeudaVigente: ").Append(DeudaVigente).Append("\n");
            sb.Append("  DeudaReestructurada: ").Append(DeudaReestructurada).Append("\n");
            sb.Append("  DeudaRefinanciada: ").Append(DeudaRefinanciada).Append("\n");
            sb.Append("  DeudaVencida: ").Append(DeudaVencida).Append("\n");
            sb.Append("  DeudaVencidaMenor30: ").Append(DeudaVencidaMenor30).Append("\n");
            sb.Append("  DeudaVencidaMayor30: ").Append(DeudaVencidaMayor30).Append("\n");
            sb.Append("  DeudaJudicial: ").Append(DeudaJudicial).Append("\n");
            sb.Append("  PorcentajeDeudaMorosa: ").Append(PorcentajeDeudaMorosa).Append("\n");
            sb.Append("  PorcentajeDeudaMonedaExtranjera: ").Append(PorcentajeDeudaMonedaExtranjera).Append("\n");
            sb.Append("  DeudaIndirecta: ").Append(DeudaIndirecta).Append("\n");
            sb.Append("  LineaCredito: ").Append(LineaCredito).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleProducto);
        }
        public bool Equals(DetalleProducto input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveProducto == input.ClaveProducto ||
                    (this.ClaveProducto != null &&
                    this.ClaveProducto.Equals(input.ClaveProducto))
                ) && 
                (
                    this.ClaveTipoProducto == input.ClaveTipoProducto ||
                    (this.ClaveTipoProducto != null &&
                    this.ClaveTipoProducto.Equals(input.ClaveTipoProducto))
                ) && 
                (
                    this.IdCalificacion == input.IdCalificacion ||
                    (this.IdCalificacion != null &&
                    this.IdCalificacion.Equals(input.IdCalificacion))
                ) && 
                (
                    this.FechaReporteSBS == input.FechaReporteSBS ||
                    (this.FechaReporteSBS != null &&
                    this.FechaReporteSBS.Equals(input.FechaReporteSBS))
                ) && 
                (
                    this.TotalDeudaDirecta == input.TotalDeudaDirecta ||
                    (this.TotalDeudaDirecta != null &&
                    this.TotalDeudaDirecta.Equals(input.TotalDeudaDirecta))
                ) && 
                (
                    this.MaximaMorosidad24meses == input.MaximaMorosidad24meses ||
                    (this.MaximaMorosidad24meses != null &&
                    this.MaximaMorosidad24meses.Equals(input.MaximaMorosidad24meses))
                ) && 
                (
                    this.MaximaMorosidadActual == input.MaximaMorosidadActual ||
                    (this.MaximaMorosidadActual != null &&
                    this.MaximaMorosidadActual.Equals(input.MaximaMorosidadActual))
                ) && 
                (
                    this.Antiguedad == input.Antiguedad ||
                    (this.Antiguedad != null &&
                    this.Antiguedad.Equals(input.Antiguedad))
                ) && 
                (
                    this.EntidadesRegistradas == input.EntidadesRegistradas ||
                    (this.EntidadesRegistradas != null &&
                    this.EntidadesRegistradas.Equals(input.EntidadesRegistradas))
                ) && 
                (
                    this.EntidadesAtrasos == input.EntidadesAtrasos ||
                    (this.EntidadesAtrasos != null &&
                    this.EntidadesAtrasos.Equals(input.EntidadesAtrasos))
                ) && 
                (
                    this.DeudaVigente == input.DeudaVigente ||
                    (this.DeudaVigente != null &&
                    this.DeudaVigente.Equals(input.DeudaVigente))
                ) && 
                (
                    this.DeudaReestructurada == input.DeudaReestructurada ||
                    (this.DeudaReestructurada != null &&
                    this.DeudaReestructurada.Equals(input.DeudaReestructurada))
                ) && 
                (
                    this.DeudaRefinanciada == input.DeudaRefinanciada ||
                    (this.DeudaRefinanciada != null &&
                    this.DeudaRefinanciada.Equals(input.DeudaRefinanciada))
                ) && 
                (
                    this.DeudaVencida == input.DeudaVencida ||
                    (this.DeudaVencida != null &&
                    this.DeudaVencida.Equals(input.DeudaVencida))
                ) && 
                (
                    this.DeudaVencidaMenor30 == input.DeudaVencidaMenor30 ||
                    (this.DeudaVencidaMenor30 != null &&
                    this.DeudaVencidaMenor30.Equals(input.DeudaVencidaMenor30))
                ) && 
                (
                    this.DeudaVencidaMayor30 == input.DeudaVencidaMayor30 ||
                    (this.DeudaVencidaMayor30 != null &&
                    this.DeudaVencidaMayor30.Equals(input.DeudaVencidaMayor30))
                ) && 
                (
                    this.DeudaJudicial == input.DeudaJudicial ||
                    (this.DeudaJudicial != null &&
                    this.DeudaJudicial.Equals(input.DeudaJudicial))
                ) && 
                (
                    this.PorcentajeDeudaMorosa == input.PorcentajeDeudaMorosa ||
                    (this.PorcentajeDeudaMorosa != null &&
                    this.PorcentajeDeudaMorosa.Equals(input.PorcentajeDeudaMorosa))
                ) && 
                (
                    this.PorcentajeDeudaMonedaExtranjera == input.PorcentajeDeudaMonedaExtranjera ||
                    (this.PorcentajeDeudaMonedaExtranjera != null &&
                    this.PorcentajeDeudaMonedaExtranjera.Equals(input.PorcentajeDeudaMonedaExtranjera))
                ) && 
                (
                    this.DeudaIndirecta == input.DeudaIndirecta ||
                    (this.DeudaIndirecta != null &&
                    this.DeudaIndirecta.Equals(input.DeudaIndirecta))
                ) && 
                (
                    this.LineaCredito == input.LineaCredito ||
                    (this.LineaCredito != null &&
                    this.LineaCredito.Equals(input.LineaCredito))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveProducto != null)
                    hashCode = hashCode * 59 + this.ClaveProducto.GetHashCode();
                if (this.ClaveTipoProducto != null)
                    hashCode = hashCode * 59 + this.ClaveTipoProducto.GetHashCode();
                if (this.IdCalificacion != null)
                    hashCode = hashCode * 59 + this.IdCalificacion.GetHashCode();
                if (this.FechaReporteSBS != null)
                    hashCode = hashCode * 59 + this.FechaReporteSBS.GetHashCode();
                if (this.TotalDeudaDirecta != null)
                    hashCode = hashCode * 59 + this.TotalDeudaDirecta.GetHashCode();
                if (this.MaximaMorosidad24meses != null)
                    hashCode = hashCode * 59 + this.MaximaMorosidad24meses.GetHashCode();
                if (this.MaximaMorosidadActual != null)
                    hashCode = hashCode * 59 + this.MaximaMorosidadActual.GetHashCode();
                if (this.Antiguedad != null)
                    hashCode = hashCode * 59 + this.Antiguedad.GetHashCode();
                if (this.EntidadesRegistradas != null)
                    hashCode = hashCode * 59 + this.EntidadesRegistradas.GetHashCode();
                if (this.EntidadesAtrasos != null)
                    hashCode = hashCode * 59 + this.EntidadesAtrasos.GetHashCode();
                if (this.DeudaVigente != null)
                    hashCode = hashCode * 59 + this.DeudaVigente.GetHashCode();
                if (this.DeudaReestructurada != null)
                    hashCode = hashCode * 59 + this.DeudaReestructurada.GetHashCode();
                if (this.DeudaRefinanciada != null)
                    hashCode = hashCode * 59 + this.DeudaRefinanciada.GetHashCode();
                if (this.DeudaVencida != null)
                    hashCode = hashCode * 59 + this.DeudaVencida.GetHashCode();
                if (this.DeudaVencidaMenor30 != null)
                    hashCode = hashCode * 59 + this.DeudaVencidaMenor30.GetHashCode();
                if (this.DeudaVencidaMayor30 != null)
                    hashCode = hashCode * 59 + this.DeudaVencidaMayor30.GetHashCode();
                if (this.DeudaJudicial != null)
                    hashCode = hashCode * 59 + this.DeudaJudicial.GetHashCode();
                if (this.PorcentajeDeudaMorosa != null)
                    hashCode = hashCode * 59 + this.PorcentajeDeudaMorosa.GetHashCode();
                if (this.PorcentajeDeudaMonedaExtranjera != null)
                    hashCode = hashCode * 59 + this.PorcentajeDeudaMonedaExtranjera.GetHashCode();
                if (this.DeudaIndirecta != null)
                    hashCode = hashCode * 59 + this.DeudaIndirecta.GetHashCode();
                if (this.LineaCredito != null)
                    hashCode = hashCode * 59 + this.LineaCredito.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
