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
    public partial class ComportamientoRCCMFNZ :  IEquatable<ComportamientoRCCMFNZ>, IValidatableObject
    {
        public ComportamientoRCCMFNZ(List<Castigos> castigos = default(List<Castigos>), List<EndeudamientoProductoEntidad> endeudamientoProductoEntidad = default(List<EndeudamientoProductoEntidad>), List<ComportamientoPago> comportamientoPago = default(List<ComportamientoPago>), List<ComportamientoUsoTarjeta> comportamientoUsoTarjeta = default(List<ComportamientoUsoTarjeta>))
        {
            this.Castigos = castigos;
            this.EndeudamientoProductoEntidad = endeudamientoProductoEntidad;
            this.ComportamientoPago = comportamientoPago;
            this.ComportamientoUsoTarjeta = comportamientoUsoTarjeta;
        }
        [DataMember(Name="castigos", EmitDefaultValue=false)]
        public List<Castigos> Castigos { get; set; }
        [DataMember(Name="endeudamientoProductoEntidad", EmitDefaultValue=false)]
        public List<EndeudamientoProductoEntidad> EndeudamientoProductoEntidad { get; set; }
        [DataMember(Name="comportamientoPago", EmitDefaultValue=false)]
        public List<ComportamientoPago> ComportamientoPago { get; set; }
        [DataMember(Name="comportamientoUsoTarjeta", EmitDefaultValue=false)]
        public List<ComportamientoUsoTarjeta> ComportamientoUsoTarjeta { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComportamientoRCCMFNZ {\n");
            sb.Append("  Castigos: ").Append(Castigos).Append("\n");
            sb.Append("  EndeudamientoProductoEntidad: ").Append(EndeudamientoProductoEntidad).Append("\n");
            sb.Append("  ComportamientoPago: ").Append(ComportamientoPago).Append("\n");
            sb.Append("  ComportamientoUsoTarjeta: ").Append(ComportamientoUsoTarjeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ComportamientoRCCMFNZ);
        }
        public bool Equals(ComportamientoRCCMFNZ input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Castigos == input.Castigos ||
                    this.Castigos != null &&
                    this.Castigos.SequenceEqual(input.Castigos)
                ) && 
                (
                    this.EndeudamientoProductoEntidad == input.EndeudamientoProductoEntidad ||
                    this.EndeudamientoProductoEntidad != null &&
                    this.EndeudamientoProductoEntidad.SequenceEqual(input.EndeudamientoProductoEntidad)
                ) && 
                (
                    this.ComportamientoPago == input.ComportamientoPago ||
                    this.ComportamientoPago != null &&
                    this.ComportamientoPago.SequenceEqual(input.ComportamientoPago)
                ) && 
                (
                    this.ComportamientoUsoTarjeta == input.ComportamientoUsoTarjeta ||
                    this.ComportamientoUsoTarjeta != null &&
                    this.ComportamientoUsoTarjeta.SequenceEqual(input.ComportamientoUsoTarjeta)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Castigos != null)
                    hashCode = hashCode * 59 + this.Castigos.GetHashCode();
                if (this.EndeudamientoProductoEntidad != null)
                    hashCode = hashCode * 59 + this.EndeudamientoProductoEntidad.GetHashCode();
                if (this.ComportamientoPago != null)
                    hashCode = hashCode * 59 + this.ComportamientoPago.GetHashCode();
                if (this.ComportamientoUsoTarjeta != null)
                    hashCode = hashCode * 59 + this.ComportamientoUsoTarjeta.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
