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
    public partial class ResumenOtrasObligaciones :  IEquatable<ResumenOtrasObligaciones>, IValidatableObject
    {
        public ResumenOtrasObligaciones(string claveFuente = default(string), ResumenOtrasObligacionesInfoFuenteInformacion infoFuenteInformacion = default(ResumenOtrasObligacionesInfoFuenteInformacion))
        {
            this.ClaveFuente = claveFuente;
            this.InfoFuenteInformacion = infoFuenteInformacion;
        }
        [DataMember(Name="claveFuente", EmitDefaultValue=false)]
        public string ClaveFuente { get; set; }
        [DataMember(Name="infoFuenteInformacion", EmitDefaultValue=false)]
        public ResumenOtrasObligacionesInfoFuenteInformacion InfoFuenteInformacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumenOtrasObligaciones {\n");
            sb.Append("  ClaveFuente: ").Append(ClaveFuente).Append("\n");
            sb.Append("  InfoFuenteInformacion: ").Append(InfoFuenteInformacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumenOtrasObligaciones);
        }
        public bool Equals(ResumenOtrasObligaciones input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveFuente == input.ClaveFuente ||
                    (this.ClaveFuente != null &&
                    this.ClaveFuente.Equals(input.ClaveFuente))
                ) && 
                (
                    this.InfoFuenteInformacion == input.InfoFuenteInformacion ||
                    (this.InfoFuenteInformacion != null &&
                    this.InfoFuenteInformacion.Equals(input.InfoFuenteInformacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveFuente != null)
                    hashCode = hashCode * 59 + this.ClaveFuente.GetHashCode();
                if (this.InfoFuenteInformacion != null)
                    hashCode = hashCode * 59 + this.InfoFuenteInformacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
