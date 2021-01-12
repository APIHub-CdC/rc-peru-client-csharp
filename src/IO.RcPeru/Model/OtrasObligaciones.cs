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
    public partial class OtrasObligaciones :  IEquatable<OtrasObligaciones>, IValidatableObject
    {
        public OtrasObligaciones(List<ResumenOtrasObligaciones> resumenOtrasObligaciones = default(List<ResumenOtrasObligaciones>), List<DeudoresOmisos> deudoresOmisos = default(List<DeudoresOmisos>), List<DeudasAFP> deudasAFP = default(List<DeudasAFP>), List<Morosidad> morosidad = default(List<Morosidad>), List<ProtestosAceptante> protestosAceptante = default(List<ProtestosAceptante>), List<ProtestosGirador> protestosGirador = default(List<ProtestosGirador>))
        {
            this.ResumenOtrasObligaciones = resumenOtrasObligaciones;
            this.DeudoresOmisos = deudoresOmisos;
            this.DeudasAFP = deudasAFP;
            this.Morosidad = morosidad;
            this.ProtestosAceptante = protestosAceptante;
            this.ProtestosGirador = protestosGirador;
        }
        [DataMember(Name="resumenOtrasObligaciones", EmitDefaultValue=false)]
        public List<ResumenOtrasObligaciones> ResumenOtrasObligaciones { get; set; }
        [DataMember(Name="deudoresOmisos", EmitDefaultValue=false)]
        public List<DeudoresOmisos> DeudoresOmisos { get; set; }
        [DataMember(Name="deudasAFP", EmitDefaultValue=false)]
        public List<DeudasAFP> DeudasAFP { get; set; }
        [DataMember(Name="morosidad", EmitDefaultValue=false)]
        public List<Morosidad> Morosidad { get; set; }
        [DataMember(Name="protestosAceptante", EmitDefaultValue=false)]
        public List<ProtestosAceptante> ProtestosAceptante { get; set; }
        [DataMember(Name="protestosGirador", EmitDefaultValue=false)]
        public List<ProtestosGirador> ProtestosGirador { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtrasObligaciones {\n");
            sb.Append("  ResumenOtrasObligaciones: ").Append(ResumenOtrasObligaciones).Append("\n");
            sb.Append("  DeudoresOmisos: ").Append(DeudoresOmisos).Append("\n");
            sb.Append("  DeudasAFP: ").Append(DeudasAFP).Append("\n");
            sb.Append("  Morosidad: ").Append(Morosidad).Append("\n");
            sb.Append("  ProtestosAceptante: ").Append(ProtestosAceptante).Append("\n");
            sb.Append("  ProtestosGirador: ").Append(ProtestosGirador).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as OtrasObligaciones);
        }
        public bool Equals(OtrasObligaciones input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ResumenOtrasObligaciones == input.ResumenOtrasObligaciones ||
                    this.ResumenOtrasObligaciones != null &&
                    this.ResumenOtrasObligaciones.SequenceEqual(input.ResumenOtrasObligaciones)
                ) && 
                (
                    this.DeudoresOmisos == input.DeudoresOmisos ||
                    this.DeudoresOmisos != null &&
                    this.DeudoresOmisos.SequenceEqual(input.DeudoresOmisos)
                ) && 
                (
                    this.DeudasAFP == input.DeudasAFP ||
                    this.DeudasAFP != null &&
                    this.DeudasAFP.SequenceEqual(input.DeudasAFP)
                ) && 
                (
                    this.Morosidad == input.Morosidad ||
                    this.Morosidad != null &&
                    this.Morosidad.SequenceEqual(input.Morosidad)
                ) && 
                (
                    this.ProtestosAceptante == input.ProtestosAceptante ||
                    this.ProtestosAceptante != null &&
                    this.ProtestosAceptante.SequenceEqual(input.ProtestosAceptante)
                ) && 
                (
                    this.ProtestosGirador == input.ProtestosGirador ||
                    this.ProtestosGirador != null &&
                    this.ProtestosGirador.SequenceEqual(input.ProtestosGirador)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ResumenOtrasObligaciones != null)
                    hashCode = hashCode * 59 + this.ResumenOtrasObligaciones.GetHashCode();
                if (this.DeudoresOmisos != null)
                    hashCode = hashCode * 59 + this.DeudoresOmisos.GetHashCode();
                if (this.DeudasAFP != null)
                    hashCode = hashCode * 59 + this.DeudasAFP.GetHashCode();
                if (this.Morosidad != null)
                    hashCode = hashCode * 59 + this.Morosidad.GetHashCode();
                if (this.ProtestosAceptante != null)
                    hashCode = hashCode * 59 + this.ProtestosAceptante.GetHashCode();
                if (this.ProtestosGirador != null)
                    hashCode = hashCode * 59 + this.ProtestosGirador.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
