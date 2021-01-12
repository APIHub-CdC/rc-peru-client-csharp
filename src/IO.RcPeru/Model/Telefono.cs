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
    public partial class Telefono :  IEquatable<Telefono>, IValidatableObject
    {
        public Telefono(string fuente = default(string), string telefono = default(string), string codigo = default(string), string fechaActualizacion = default(string))
        {
            this.Fuente = fuente;
            this._Telefono = telefono;
            this.Codigo = codigo;
            this.FechaActualizacion = fechaActualizacion;
        }
        [DataMember(Name="fuente", EmitDefaultValue=false)]
        public string Fuente { get; set; }
        [DataMember(Name="telefono", EmitDefaultValue=false)]
        public string _Telefono { get; set; }
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
        [DataMember(Name="fechaActualizacion", EmitDefaultValue=false)]
        public string FechaActualizacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Telefono {\n");
            sb.Append("  Fuente: ").Append(Fuente).Append("\n");
            sb.Append("  _Telefono: ").Append(_Telefono).Append("\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  FechaActualizacion: ").Append(FechaActualizacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Telefono);
        }
        public bool Equals(Telefono input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Fuente == input.Fuente ||
                    (this.Fuente != null &&
                    this.Fuente.Equals(input.Fuente))
                ) && 
                (
                    this._Telefono == input._Telefono ||
                    (this._Telefono != null &&
                    this._Telefono.Equals(input._Telefono))
                ) && 
                (
                    this.Codigo == input.Codigo ||
                    (this.Codigo != null &&
                    this.Codigo.Equals(input.Codigo))
                ) && 
                (
                    this.FechaActualizacion == input.FechaActualizacion ||
                    (this.FechaActualizacion != null &&
                    this.FechaActualizacion.Equals(input.FechaActualizacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Fuente != null)
                    hashCode = hashCode * 59 + this.Fuente.GetHashCode();
                if (this._Telefono != null)
                    hashCode = hashCode * 59 + this._Telefono.GetHashCode();
                if (this.Codigo != null)
                    hashCode = hashCode * 59 + this.Codigo.GetHashCode();
                if (this.FechaActualizacion != null)
                    hashCode = hashCode * 59 + this.FechaActualizacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
