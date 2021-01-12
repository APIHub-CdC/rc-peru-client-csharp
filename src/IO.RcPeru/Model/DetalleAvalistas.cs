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
    public partial class DetalleAvalistas :  IEquatable<DetalleAvalistas>, IValidatableObject
    {
        public DetalleAvalistas(string periodo = default(string), string idCalificacion = default(string), string idTipoDocumento = default(string), string documento = default(string), string nombre = default(string), string entidad = default(string), float? saldo = default(float?))
        {
            this.Periodo = periodo;
            this.IdCalificacion = idCalificacion;
            this.IdTipoDocumento = idTipoDocumento;
            this.Documento = documento;
            this.Nombre = nombre;
            this.Entidad = entidad;
            this.Saldo = saldo;
        }
        [DataMember(Name="periodo", EmitDefaultValue=false)]
        public string Periodo { get; set; }
        [DataMember(Name="idCalificacion", EmitDefaultValue=false)]
        public string IdCalificacion { get; set; }
        [DataMember(Name="idTipoDocumento", EmitDefaultValue=false)]
        public string IdTipoDocumento { get; set; }
        [DataMember(Name="documento", EmitDefaultValue=false)]
        public string Documento { get; set; }
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }
        [DataMember(Name="entidad", EmitDefaultValue=false)]
        public string Entidad { get; set; }
        [DataMember(Name="saldo", EmitDefaultValue=false)]
        public float? Saldo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalleAvalistas {\n");
            sb.Append("  Periodo: ").Append(Periodo).Append("\n");
            sb.Append("  IdCalificacion: ").Append(IdCalificacion).Append("\n");
            sb.Append("  IdTipoDocumento: ").Append(IdTipoDocumento).Append("\n");
            sb.Append("  Documento: ").Append(Documento).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Entidad: ").Append(Entidad).Append("\n");
            sb.Append("  Saldo: ").Append(Saldo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DetalleAvalistas);
        }
        public bool Equals(DetalleAvalistas input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Periodo == input.Periodo ||
                    (this.Periodo != null &&
                    this.Periodo.Equals(input.Periodo))
                ) && 
                (
                    this.IdCalificacion == input.IdCalificacion ||
                    (this.IdCalificacion != null &&
                    this.IdCalificacion.Equals(input.IdCalificacion))
                ) && 
                (
                    this.IdTipoDocumento == input.IdTipoDocumento ||
                    (this.IdTipoDocumento != null &&
                    this.IdTipoDocumento.Equals(input.IdTipoDocumento))
                ) && 
                (
                    this.Documento == input.Documento ||
                    (this.Documento != null &&
                    this.Documento.Equals(input.Documento))
                ) && 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
                ) && 
                (
                    this.Entidad == input.Entidad ||
                    (this.Entidad != null &&
                    this.Entidad.Equals(input.Entidad))
                ) && 
                (
                    this.Saldo == input.Saldo ||
                    (this.Saldo != null &&
                    this.Saldo.Equals(input.Saldo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Periodo != null)
                    hashCode = hashCode * 59 + this.Periodo.GetHashCode();
                if (this.IdCalificacion != null)
                    hashCode = hashCode * 59 + this.IdCalificacion.GetHashCode();
                if (this.IdTipoDocumento != null)
                    hashCode = hashCode * 59 + this.IdTipoDocumento.GetHashCode();
                if (this.Documento != null)
                    hashCode = hashCode * 59 + this.Documento.GetHashCode();
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
                if (this.Entidad != null)
                    hashCode = hashCode * 59 + this.Entidad.GetHashCode();
                if (this.Saldo != null)
                    hashCode = hashCode * 59 + this.Saldo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
