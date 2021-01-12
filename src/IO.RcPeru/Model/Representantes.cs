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
    public partial class Representantes :  IEquatable<Representantes>, IValidatableObject
    {
        public Representantes(string claveRespuesta = default(string), string fechaReporte = default(string), string documentoIdentidad = default(string), string nombre = default(string), string cargo = default(string), string fechaInicioCargo = default(string), string fechaActaRepresentante = default(string))
        {
            this.ClaveRespuesta = claveRespuesta;
            this.FechaReporte = fechaReporte;
            this.DocumentoIdentidad = documentoIdentidad;
            this.Nombre = nombre;
            this.Cargo = cargo;
            this.FechaInicioCargo = fechaInicioCargo;
            this.FechaActaRepresentante = fechaActaRepresentante;
        }
        [DataMember(Name="claveRespuesta", EmitDefaultValue=false)]
        public string ClaveRespuesta { get; set; }
        [DataMember(Name="fechaReporte", EmitDefaultValue=false)]
        public string FechaReporte { get; set; }
        [DataMember(Name="documentoIdentidad", EmitDefaultValue=false)]
        public string DocumentoIdentidad { get; set; }
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }
        [DataMember(Name="cargo", EmitDefaultValue=false)]
        public string Cargo { get; set; }
        [DataMember(Name="fechaInicioCargo", EmitDefaultValue=false)]
        public string FechaInicioCargo { get; set; }
        [DataMember(Name="fechaActaRepresentante", EmitDefaultValue=false)]
        public string FechaActaRepresentante { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Representantes {\n");
            sb.Append("  ClaveRespuesta: ").Append(ClaveRespuesta).Append("\n");
            sb.Append("  FechaReporte: ").Append(FechaReporte).Append("\n");
            sb.Append("  DocumentoIdentidad: ").Append(DocumentoIdentidad).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Cargo: ").Append(Cargo).Append("\n");
            sb.Append("  FechaInicioCargo: ").Append(FechaInicioCargo).Append("\n");
            sb.Append("  FechaActaRepresentante: ").Append(FechaActaRepresentante).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Representantes);
        }
        public bool Equals(Representantes input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClaveRespuesta == input.ClaveRespuesta ||
                    (this.ClaveRespuesta != null &&
                    this.ClaveRespuesta.Equals(input.ClaveRespuesta))
                ) && 
                (
                    this.FechaReporte == input.FechaReporte ||
                    (this.FechaReporte != null &&
                    this.FechaReporte.Equals(input.FechaReporte))
                ) && 
                (
                    this.DocumentoIdentidad == input.DocumentoIdentidad ||
                    (this.DocumentoIdentidad != null &&
                    this.DocumentoIdentidad.Equals(input.DocumentoIdentidad))
                ) && 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
                ) && 
                (
                    this.Cargo == input.Cargo ||
                    (this.Cargo != null &&
                    this.Cargo.Equals(input.Cargo))
                ) && 
                (
                    this.FechaInicioCargo == input.FechaInicioCargo ||
                    (this.FechaInicioCargo != null &&
                    this.FechaInicioCargo.Equals(input.FechaInicioCargo))
                ) && 
                (
                    this.FechaActaRepresentante == input.FechaActaRepresentante ||
                    (this.FechaActaRepresentante != null &&
                    this.FechaActaRepresentante.Equals(input.FechaActaRepresentante))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ClaveRespuesta != null)
                    hashCode = hashCode * 59 + this.ClaveRespuesta.GetHashCode();
                if (this.FechaReporte != null)
                    hashCode = hashCode * 59 + this.FechaReporte.GetHashCode();
                if (this.DocumentoIdentidad != null)
                    hashCode = hashCode * 59 + this.DocumentoIdentidad.GetHashCode();
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
                if (this.Cargo != null)
                    hashCode = hashCode * 59 + this.Cargo.GetHashCode();
                if (this.FechaInicioCargo != null)
                    hashCode = hashCode * 59 + this.FechaInicioCargo.GetHashCode();
                if (this.FechaActaRepresentante != null)
                    hashCode = hashCode * 59 + this.FechaActaRepresentante.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
