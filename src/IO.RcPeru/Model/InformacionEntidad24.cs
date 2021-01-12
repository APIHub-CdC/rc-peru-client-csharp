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
    public partial class InformacionEntidad24 :  IEquatable<InformacionEntidad24>, IValidatableObject
    {
        public InformacionEntidad24(string descripcionEntidad = default(string), string claveSituacion = default(string), string idCalificacion = default(string), decimal? diasAtraso = default(decimal?), decimal? maximoAtraso = default(decimal?), float? deudaMaximoAtraso = default(float?), string inicioPeriodo = default(string), string finPeriodo = default(string), string atrasos24 = default(string))
        {
            this.DescripcionEntidad = descripcionEntidad;
            this.ClaveSituacion = claveSituacion;
            this.IdCalificacion = idCalificacion;
            this.DiasAtraso = diasAtraso;
            this.MaximoAtraso = maximoAtraso;
            this.DeudaMaximoAtraso = deudaMaximoAtraso;
            this.InicioPeriodo = inicioPeriodo;
            this.FinPeriodo = finPeriodo;
            this.Atrasos24 = atrasos24;
        }
        [DataMember(Name="descripcionEntidad", EmitDefaultValue=false)]
        public string DescripcionEntidad { get; set; }
        [DataMember(Name="claveSituacion", EmitDefaultValue=false)]
        public string ClaveSituacion { get; set; }
        [DataMember(Name="idCalificacion", EmitDefaultValue=false)]
        public string IdCalificacion { get; set; }
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public decimal? DiasAtraso { get; set; }
        [DataMember(Name="maximoAtraso", EmitDefaultValue=false)]
        public decimal? MaximoAtraso { get; set; }
        [DataMember(Name="deudaMaximoAtraso", EmitDefaultValue=false)]
        public float? DeudaMaximoAtraso { get; set; }
        [DataMember(Name="inicioPeriodo", EmitDefaultValue=false)]
        public string InicioPeriodo { get; set; }
        [DataMember(Name="finPeriodo", EmitDefaultValue=false)]
        public string FinPeriodo { get; set; }
        [DataMember(Name="atrasos24", EmitDefaultValue=false)]
        public string Atrasos24 { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InformacionEntidad24 {\n");
            sb.Append("  DescripcionEntidad: ").Append(DescripcionEntidad).Append("\n");
            sb.Append("  ClaveSituacion: ").Append(ClaveSituacion).Append("\n");
            sb.Append("  IdCalificacion: ").Append(IdCalificacion).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            sb.Append("  MaximoAtraso: ").Append(MaximoAtraso).Append("\n");
            sb.Append("  DeudaMaximoAtraso: ").Append(DeudaMaximoAtraso).Append("\n");
            sb.Append("  InicioPeriodo: ").Append(InicioPeriodo).Append("\n");
            sb.Append("  FinPeriodo: ").Append(FinPeriodo).Append("\n");
            sb.Append("  Atrasos24: ").Append(Atrasos24).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as InformacionEntidad24);
        }
        public bool Equals(InformacionEntidad24 input)
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
                    this.ClaveSituacion == input.ClaveSituacion ||
                    (this.ClaveSituacion != null &&
                    this.ClaveSituacion.Equals(input.ClaveSituacion))
                ) && 
                (
                    this.IdCalificacion == input.IdCalificacion ||
                    (this.IdCalificacion != null &&
                    this.IdCalificacion.Equals(input.IdCalificacion))
                ) && 
                (
                    this.DiasAtraso == input.DiasAtraso ||
                    (this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(input.DiasAtraso))
                ) && 
                (
                    this.MaximoAtraso == input.MaximoAtraso ||
                    (this.MaximoAtraso != null &&
                    this.MaximoAtraso.Equals(input.MaximoAtraso))
                ) && 
                (
                    this.DeudaMaximoAtraso == input.DeudaMaximoAtraso ||
                    (this.DeudaMaximoAtraso != null &&
                    this.DeudaMaximoAtraso.Equals(input.DeudaMaximoAtraso))
                ) && 
                (
                    this.InicioPeriodo == input.InicioPeriodo ||
                    (this.InicioPeriodo != null &&
                    this.InicioPeriodo.Equals(input.InicioPeriodo))
                ) && 
                (
                    this.FinPeriodo == input.FinPeriodo ||
                    (this.FinPeriodo != null &&
                    this.FinPeriodo.Equals(input.FinPeriodo))
                ) && 
                (
                    this.Atrasos24 == input.Atrasos24 ||
                    (this.Atrasos24 != null &&
                    this.Atrasos24.Equals(input.Atrasos24))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DescripcionEntidad != null)
                    hashCode = hashCode * 59 + this.DescripcionEntidad.GetHashCode();
                if (this.ClaveSituacion != null)
                    hashCode = hashCode * 59 + this.ClaveSituacion.GetHashCode();
                if (this.IdCalificacion != null)
                    hashCode = hashCode * 59 + this.IdCalificacion.GetHashCode();
                if (this.DiasAtraso != null)
                    hashCode = hashCode * 59 + this.DiasAtraso.GetHashCode();
                if (this.MaximoAtraso != null)
                    hashCode = hashCode * 59 + this.MaximoAtraso.GetHashCode();
                if (this.DeudaMaximoAtraso != null)
                    hashCode = hashCode * 59 + this.DeudaMaximoAtraso.GetHashCode();
                if (this.InicioPeriodo != null)
                    hashCode = hashCode * 59 + this.InicioPeriodo.GetHashCode();
                if (this.FinPeriodo != null)
                    hashCode = hashCode * 59 + this.FinPeriodo.GetHashCode();
                if (this.Atrasos24 != null)
                    hashCode = hashCode * 59 + this.Atrasos24.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
