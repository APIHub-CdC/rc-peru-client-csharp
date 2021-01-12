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
    public partial class ConsultasInner :  IEquatable<ConsultasInner>, IValidatableObject
    {
        public ConsultasInner(string claveTipoEntidad = default(string), string entidad = default(string), decimal? totalUltimos12Meses = default(decimal?), List<ConsultaMes> consultaMes = default(List<ConsultaMes>))
        {
            this.ClaveTipoEntidad = claveTipoEntidad;
            this.Entidad = entidad;
            this.TotalUltimos12Meses = totalUltimos12Meses;
            this.ConsultaMes = consultaMes;
        }
        [DataMember(Name="claveTipoEntidad", EmitDefaultValue=false)]
        public string ClaveTipoEntidad { get; set; }
        [DataMember(Name="entidad", EmitDefaultValue=false)]
        public string Entidad { get; set; }
        [DataMember(Name="totalUltimos12Meses", EmitDefaultValue=false)]
        public decimal? TotalUltimos12Meses { get; set; }
        [DataMember(Name="consultaMes", EmitDefaultValue=false)]
        public List<ConsultaMes> ConsultaMes { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultasInner {\n");
            sb.Append("  ClaveTipoEntidad: ").Append(ClaveTipoEntidad).Append("\n");
            sb.Append("  Entidad: ").Append(Entidad).Append("\n");
            sb.Append("  TotalUltimos12Meses: ").Append(TotalUltimos12Meses).Append("\n");
            sb.Append("  ConsultaMes: ").Append(ConsultaMes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsultasInner);
        }
        public bool Equals(ConsultasInner input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveTipoEntidad == input.ClaveTipoEntidad ||
                    (this.ClaveTipoEntidad != null &&
                    this.ClaveTipoEntidad.Equals(input.ClaveTipoEntidad))
                ) && 
                (
                    this.Entidad == input.Entidad ||
                    (this.Entidad != null &&
                    this.Entidad.Equals(input.Entidad))
                ) && 
                (
                    this.TotalUltimos12Meses == input.TotalUltimos12Meses ||
                    (this.TotalUltimos12Meses != null &&
                    this.TotalUltimos12Meses.Equals(input.TotalUltimos12Meses))
                ) && 
                (
                    this.ConsultaMes == input.ConsultaMes ||
                    this.ConsultaMes != null &&
                    this.ConsultaMes.SequenceEqual(input.ConsultaMes)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveTipoEntidad != null)
                    hashCode = hashCode * 59 + this.ClaveTipoEntidad.GetHashCode();
                if (this.Entidad != null)
                    hashCode = hashCode * 59 + this.Entidad.GetHashCode();
                if (this.TotalUltimos12Meses != null)
                    hashCode = hashCode * 59 + this.TotalUltimos12Meses.GetHashCode();
                if (this.ConsultaMes != null)
                    hashCode = hashCode * 59 + this.ConsultaMes.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
