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
    public partial class Direcciones :  IEquatable<Direcciones>, IValidatableObject
    {
        public Direcciones(string fuente = default(string), string ubigeo = default(string), string departamento = default(string), string provincia = default(string), string distrito = default(string), string nombreVia = default(string), string numeroExterior = default(string), string numeroInterior = default(string), string nombreZona = default(string), string referencia = default(string), string fecha = default(string), string fechaActualizaciontSunat = default(string))
        {
            this.Fuente = fuente;
            this.Ubigeo = ubigeo;
            this.Departamento = departamento;
            this.Provincia = provincia;
            this.Distrito = distrito;
            this.NombreVia = nombreVia;
            this.NumeroExterior = numeroExterior;
            this.NumeroInterior = numeroInterior;
            this.NombreZona = nombreZona;
            this.Referencia = referencia;
            this.Fecha = fecha;
            this.FechaActualizaciontSunat = fechaActualizaciontSunat;
        }
        [DataMember(Name="fuente", EmitDefaultValue=false)]
        public string Fuente { get; set; }
        [DataMember(Name="ubigeo", EmitDefaultValue=false)]
        public string Ubigeo { get; set; }
        [DataMember(Name="departamento", EmitDefaultValue=false)]
        public string Departamento { get; set; }
        [DataMember(Name="provincia", EmitDefaultValue=false)]
        public string Provincia { get; set; }
        [DataMember(Name="distrito", EmitDefaultValue=false)]
        public string Distrito { get; set; }
        [DataMember(Name="nombreVia", EmitDefaultValue=false)]
        public string NombreVia { get; set; }
        [DataMember(Name="numeroExterior", EmitDefaultValue=false)]
        public string NumeroExterior { get; set; }
        [DataMember(Name="numeroInterior", EmitDefaultValue=false)]
        public string NumeroInterior { get; set; }
        [DataMember(Name="nombreZona", EmitDefaultValue=false)]
        public string NombreZona { get; set; }
        [DataMember(Name="referencia", EmitDefaultValue=false)]
        public string Referencia { get; set; }
        [DataMember(Name="fecha", EmitDefaultValue=false)]
        public string Fecha { get; set; }
        [DataMember(Name="fechaActualizaciontSunat", EmitDefaultValue=false)]
        public string FechaActualizaciontSunat { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Direcciones {\n");
            sb.Append("  Fuente: ").Append(Fuente).Append("\n");
            sb.Append("  Ubigeo: ").Append(Ubigeo).Append("\n");
            sb.Append("  Departamento: ").Append(Departamento).Append("\n");
            sb.Append("  Provincia: ").Append(Provincia).Append("\n");
            sb.Append("  Distrito: ").Append(Distrito).Append("\n");
            sb.Append("  NombreVia: ").Append(NombreVia).Append("\n");
            sb.Append("  NumeroExterior: ").Append(NumeroExterior).Append("\n");
            sb.Append("  NumeroInterior: ").Append(NumeroInterior).Append("\n");
            sb.Append("  NombreZona: ").Append(NombreZona).Append("\n");
            sb.Append("  Referencia: ").Append(Referencia).Append("\n");
            sb.Append("  Fecha: ").Append(Fecha).Append("\n");
            sb.Append("  FechaActualizaciontSunat: ").Append(FechaActualizaciontSunat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Direcciones);
        }
        public bool Equals(Direcciones input)
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
                    this.Ubigeo == input.Ubigeo ||
                    (this.Ubigeo != null &&
                    this.Ubigeo.Equals(input.Ubigeo))
                ) && 
                (
                    this.Departamento == input.Departamento ||
                    (this.Departamento != null &&
                    this.Departamento.Equals(input.Departamento))
                ) && 
                (
                    this.Provincia == input.Provincia ||
                    (this.Provincia != null &&
                    this.Provincia.Equals(input.Provincia))
                ) && 
                (
                    this.Distrito == input.Distrito ||
                    (this.Distrito != null &&
                    this.Distrito.Equals(input.Distrito))
                ) && 
                (
                    this.NombreVia == input.NombreVia ||
                    (this.NombreVia != null &&
                    this.NombreVia.Equals(input.NombreVia))
                ) && 
                (
                    this.NumeroExterior == input.NumeroExterior ||
                    (this.NumeroExterior != null &&
                    this.NumeroExterior.Equals(input.NumeroExterior))
                ) && 
                (
                    this.NumeroInterior == input.NumeroInterior ||
                    (this.NumeroInterior != null &&
                    this.NumeroInterior.Equals(input.NumeroInterior))
                ) && 
                (
                    this.NombreZona == input.NombreZona ||
                    (this.NombreZona != null &&
                    this.NombreZona.Equals(input.NombreZona))
                ) && 
                (
                    this.Referencia == input.Referencia ||
                    (this.Referencia != null &&
                    this.Referencia.Equals(input.Referencia))
                ) && 
                (
                    this.Fecha == input.Fecha ||
                    (this.Fecha != null &&
                    this.Fecha.Equals(input.Fecha))
                ) && 
                (
                    this.FechaActualizaciontSunat == input.FechaActualizaciontSunat ||
                    (this.FechaActualizaciontSunat != null &&
                    this.FechaActualizaciontSunat.Equals(input.FechaActualizaciontSunat))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Fuente != null)
                    hashCode = hashCode * 59 + this.Fuente.GetHashCode();
                if (this.Ubigeo != null)
                    hashCode = hashCode * 59 + this.Ubigeo.GetHashCode();
                if (this.Departamento != null)
                    hashCode = hashCode * 59 + this.Departamento.GetHashCode();
                if (this.Provincia != null)
                    hashCode = hashCode * 59 + this.Provincia.GetHashCode();
                if (this.Distrito != null)
                    hashCode = hashCode * 59 + this.Distrito.GetHashCode();
                if (this.NombreVia != null)
                    hashCode = hashCode * 59 + this.NombreVia.GetHashCode();
                if (this.NumeroExterior != null)
                    hashCode = hashCode * 59 + this.NumeroExterior.GetHashCode();
                if (this.NumeroInterior != null)
                    hashCode = hashCode * 59 + this.NumeroInterior.GetHashCode();
                if (this.NombreZona != null)
                    hashCode = hashCode * 59 + this.NombreZona.GetHashCode();
                if (this.Referencia != null)
                    hashCode = hashCode * 59 + this.Referencia.GetHashCode();
                if (this.Fecha != null)
                    hashCode = hashCode * 59 + this.Fecha.GetHashCode();
                if (this.FechaActualizaciontSunat != null)
                    hashCode = hashCode * 59 + this.FechaActualizaciontSunat.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
