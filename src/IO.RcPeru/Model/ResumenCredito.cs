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
    public partial class ResumenCredito :  IEquatable<ResumenCredito>, IValidatableObject
    {
        public ResumenCredito(List<EndeudamientoTotal> endeudamientoTotal = default(List<EndeudamientoTotal>), List<DeudaTipoProductoRC> deudaTipoProductoRC = default(List<DeudaTipoProductoRC>), List<DetalleProducto> detalleProducto = default(List<DetalleProducto>), List<IndicadoresSBS> indicadoresSBS = default(List<IndicadoresSBS>), ResumenCreditoCalificacion calificacion = default(ResumenCreditoCalificacion), ResumenCreditoSBSUltimos24Meses sBSUltimos24Meses = default(ResumenCreditoSBSUltimos24Meses))
        {
            this.EndeudamientoTotal = endeudamientoTotal;
            this.DeudaTipoProductoRC = deudaTipoProductoRC;
            this.DetalleProducto = detalleProducto;
            this.IndicadoresSBS = indicadoresSBS;
            this.Calificacion = calificacion;
            this.SBSUltimos24Meses = sBSUltimos24Meses;
        }
        [DataMember(Name="endeudamientoTotal", EmitDefaultValue=false)]
        public List<EndeudamientoTotal> EndeudamientoTotal { get; set; }
        [DataMember(Name="deudaTipoProductoRC", EmitDefaultValue=false)]
        public List<DeudaTipoProductoRC> DeudaTipoProductoRC { get; set; }
        [DataMember(Name="detalleProducto", EmitDefaultValue=false)]
        public List<DetalleProducto> DetalleProducto { get; set; }
        [DataMember(Name="indicadoresSBS", EmitDefaultValue=false)]
        public List<IndicadoresSBS> IndicadoresSBS { get; set; }
        [DataMember(Name="calificacion", EmitDefaultValue=false)]
        public ResumenCreditoCalificacion Calificacion { get; set; }
        [DataMember(Name="SBSUltimos24Meses", EmitDefaultValue=false)]
        public ResumenCreditoSBSUltimos24Meses SBSUltimos24Meses { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumenCredito {\n");
            sb.Append("  EndeudamientoTotal: ").Append(EndeudamientoTotal).Append("\n");
            sb.Append("  DeudaTipoProductoRC: ").Append(DeudaTipoProductoRC).Append("\n");
            sb.Append("  DetalleProducto: ").Append(DetalleProducto).Append("\n");
            sb.Append("  IndicadoresSBS: ").Append(IndicadoresSBS).Append("\n");
            sb.Append("  Calificacion: ").Append(Calificacion).Append("\n");
            sb.Append("  SBSUltimos24Meses: ").Append(SBSUltimos24Meses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumenCredito);
        }
        public bool Equals(ResumenCredito input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.EndeudamientoTotal == input.EndeudamientoTotal ||
                    this.EndeudamientoTotal != null &&
                    this.EndeudamientoTotal.SequenceEqual(input.EndeudamientoTotal)
                ) && 
                (
                    this.DeudaTipoProductoRC == input.DeudaTipoProductoRC ||
                    this.DeudaTipoProductoRC != null &&
                    this.DeudaTipoProductoRC.SequenceEqual(input.DeudaTipoProductoRC)
                ) && 
                (
                    this.DetalleProducto == input.DetalleProducto ||
                    this.DetalleProducto != null &&
                    this.DetalleProducto.SequenceEqual(input.DetalleProducto)
                ) && 
                (
                    this.IndicadoresSBS == input.IndicadoresSBS ||
                    this.IndicadoresSBS != null &&
                    this.IndicadoresSBS.SequenceEqual(input.IndicadoresSBS)
                ) && 
                (
                    this.Calificacion == input.Calificacion ||
                    (this.Calificacion != null &&
                    this.Calificacion.Equals(input.Calificacion))
                ) && 
                (
                    this.SBSUltimos24Meses == input.SBSUltimos24Meses ||
                    (this.SBSUltimos24Meses != null &&
                    this.SBSUltimos24Meses.Equals(input.SBSUltimos24Meses))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.EndeudamientoTotal != null)
                    hashCode = hashCode * 59 + this.EndeudamientoTotal.GetHashCode();
                if (this.DeudaTipoProductoRC != null)
                    hashCode = hashCode * 59 + this.DeudaTipoProductoRC.GetHashCode();
                if (this.DetalleProducto != null)
                    hashCode = hashCode * 59 + this.DetalleProducto.GetHashCode();
                if (this.IndicadoresSBS != null)
                    hashCode = hashCode * 59 + this.IndicadoresSBS.GetHashCode();
                if (this.Calificacion != null)
                    hashCode = hashCode * 59 + this.Calificacion.GetHashCode();
                if (this.SBSUltimos24Meses != null)
                    hashCode = hashCode * 59 + this.SBSUltimos24Meses.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
