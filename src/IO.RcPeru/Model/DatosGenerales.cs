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
    public partial class DatosGenerales :  IEquatable<DatosGenerales>, IValidatableObject
    {
        public DatosGenerales(DatosPersonales datosPersonales = default(DatosPersonales), DatasGeneralesSunat datosGeneralesSunat = default(DatasGeneralesSunat), List<Representantes> representantes = default(List<Representantes>), List<Direcciones> direcciones = default(List<Direcciones>), List<Telefono> telefonos = default(List<Telefono>))
        {
            this.DatosPersonales = datosPersonales;
            this.DatosGeneralesSunat = datosGeneralesSunat;
            this.Representantes = representantes;
            this.Direcciones = direcciones;
            this.Telefonos = telefonos;
        }
        [DataMember(Name="datosPersonales", EmitDefaultValue=false)]
        public DatosPersonales DatosPersonales { get; set; }
        [DataMember(Name="datosGeneralesSunat", EmitDefaultValue=false)]
        public DatasGeneralesSunat DatosGeneralesSunat { get; set; }
        [DataMember(Name="representantes", EmitDefaultValue=false)]
        public List<Representantes> Representantes { get; set; }
        [DataMember(Name="direcciones", EmitDefaultValue=false)]
        public List<Direcciones> Direcciones { get; set; }
        [DataMember(Name="telefonos", EmitDefaultValue=false)]
        public List<Telefono> Telefonos { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatosGenerales {\n");
            sb.Append("  DatosPersonales: ").Append(DatosPersonales).Append("\n");
            sb.Append("  DatosGeneralesSunat: ").Append(DatosGeneralesSunat).Append("\n");
            sb.Append("  Representantes: ").Append(Representantes).Append("\n");
            sb.Append("  Direcciones: ").Append(Direcciones).Append("\n");
            sb.Append("  Telefonos: ").Append(Telefonos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DatosGenerales);
        }
        public bool Equals(DatosGenerales input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DatosPersonales == input.DatosPersonales ||
                    (this.DatosPersonales != null &&
                    this.DatosPersonales.Equals(input.DatosPersonales))
                ) && 
                (
                    this.DatosGeneralesSunat == input.DatosGeneralesSunat ||
                    (this.DatosGeneralesSunat != null &&
                    this.DatosGeneralesSunat.Equals(input.DatosGeneralesSunat))
                ) && 
                (
                    this.Representantes == input.Representantes ||
                    this.Representantes != null &&
                    this.Representantes.SequenceEqual(input.Representantes)
                ) && 
                (
                    this.Direcciones == input.Direcciones ||
                    this.Direcciones != null &&
                    this.Direcciones.SequenceEqual(input.Direcciones)
                ) && 
                (
                    this.Telefonos == input.Telefonos ||
                    this.Telefonos != null &&
                    this.Telefonos.SequenceEqual(input.Telefonos)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DatosPersonales != null)
                    hashCode = hashCode * 59 + this.DatosPersonales.GetHashCode();
                if (this.DatosGeneralesSunat != null)
                    hashCode = hashCode * 59 + this.DatosGeneralesSunat.GetHashCode();
                if (this.Representantes != null)
                    hashCode = hashCode * 59 + this.Representantes.GetHashCode();
                if (this.Direcciones != null)
                    hashCode = hashCode * 59 + this.Direcciones.GetHashCode();
                if (this.Telefonos != null)
                    hashCode = hashCode * 59 + this.Telefonos.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
