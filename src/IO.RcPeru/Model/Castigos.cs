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
    public partial class Castigos :  IEquatable<Castigos>, IValidatableObject
    {
        public Castigos(string descripcionEntidad = default(string), string claveEstatusPago = default(string), string fechaPrimerCastigo = default(string), string fechaUltimoCastigo = default(string), float? montoUltimoCastigo = default(float?))
        {
            this.DescripcionEntidad = descripcionEntidad;
            this.ClaveEstatusPago = claveEstatusPago;
            this.FechaPrimerCastigo = fechaPrimerCastigo;
            this.FechaUltimoCastigo = fechaUltimoCastigo;
            this.MontoUltimoCastigo = montoUltimoCastigo;
        }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="claveEstatusPago", EmitDefaultValue=false)]
        public string ClaveEstatusPago { get; set; }
        [DataMember(Name="fechaPrimerCastigo", EmitDefaultValue=false)]
        public string FechaPrimerCastigo { get; set; }
        [DataMember(Name="fechaUltimoCastigo", EmitDefaultValue=false)]
        public string FechaUltimoCastigo { get; set; }
        [DataMember(Name="montoUltimoCastigo", EmitDefaultValue=false)]
        public float? MontoUltimoCastigo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Castigos {\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  ClaveEstatusPago: ").Append(ClaveEstatusPago).Append("\n");
            sb.Append("  FechaPrimerCastigo: ").Append(FechaPrimerCastigo).Append("\n");
            sb.Append("  FechaUltimoCastigo: ").Append(FechaUltimoCastigo).Append("\n");
            sb.Append("  MontoUltimoCastigo: ").Append(MontoUltimoCastigo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Castigos);
        }
        public bool Equals(Castigos input)
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
                    this.ClaveEstatusPago == input.ClaveEstatusPago ||
                    (this.ClaveEstatusPago != null &&
                    this.ClaveEstatusPago.Equals(input.ClaveEstatusPago))
                ) && 
                (
                    this.FechaPrimerCastigo == input.FechaPrimerCastigo ||
                    (this.FechaPrimerCastigo != null &&
                    this.FechaPrimerCastigo.Equals(input.FechaPrimerCastigo))
                ) && 
                (
                    this.FechaUltimoCastigo == input.FechaUltimoCastigo ||
                    (this.FechaUltimoCastigo != null &&
                    this.FechaUltimoCastigo.Equals(input.FechaUltimoCastigo))
                ) && 
                (
                    this.MontoUltimoCastigo == input.MontoUltimoCastigo ||
                    (this.MontoUltimoCastigo != null &&
                    this.MontoUltimoCastigo.Equals(input.MontoUltimoCastigo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.ClaveEstatusPago != null)
                    hashCode = hashCode * 59 + this.ClaveEstatusPago.GetHashCode();
                if (this.FechaPrimerCastigo != null)
                    hashCode = hashCode * 59 + this.FechaPrimerCastigo.GetHashCode();
                if (this.FechaUltimoCastigo != null)
                    hashCode = hashCode * 59 + this.FechaUltimoCastigo.GetHashCode();
                if (this.MontoUltimoCastigo != null)
                    hashCode = hashCode * 59 + this.MontoUltimoCastigo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
