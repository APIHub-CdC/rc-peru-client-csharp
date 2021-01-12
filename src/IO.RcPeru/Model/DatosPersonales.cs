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
    public partial class DatosPersonales :  IEquatable<DatosPersonales>, IValidatableObject
    {
        public DatosPersonales(string primerNombre = default(string), string segundoNombre = default(string), string apellidoPaterno = default(string), string apellidoMaterno = default(string), string apellidoCasada = default(string), string fechaNacimiento = default(string), decimal? edad = default(decimal?), string genero = default(string), string tipoDocumento = default(string), string numeroDocumento = default(string), string rUC = default(string), float? codigoSBS = default(float?), string ubigeo = default(string), string departamento = default(string), string provincia = default(string), string distrito = default(string), string via = default(string), string numeroExterior = default(string), string numeroInterior = default(string), string zona = default(string), decimal? claveTipoPersona = default(decimal?), string claveTipoEmpresa = default(string))
        {
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.ApellidoCasada = apellidoCasada;
            this.FechaNacimiento = fechaNacimiento;
            this.Edad = edad;
            this.Genero = genero;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.RUC = rUC;
            this.CodigoSBS = codigoSBS;
            this.Ubigeo = ubigeo;
            this.Departamento = departamento;
            this.Provincia = provincia;
            this.Distrito = distrito;
            this.Via = via;
            this.NumeroExterior = numeroExterior;
            this.NumeroInterior = numeroInterior;
            this.Zona = zona;
            this.ClaveTipoPersona = claveTipoPersona;
            this.ClaveTipoEmpresa = claveTipoEmpresa;
        }
        [DataMember(Name="primerNombre", EmitDefaultValue=false)]
        public string PrimerNombre { get; set; }
        [DataMember(Name="segundoNombre", EmitDefaultValue=false)]
        public string SegundoNombre { get; set; }
        [DataMember(Name="apellidoPaterno", EmitDefaultValue=false)]
        public string ApellidoPaterno { get; set; }
        [DataMember(Name="apellidoMaterno", EmitDefaultValue=false)]
        public string ApellidoMaterno { get; set; }
        [DataMember(Name="apellidoCasada", EmitDefaultValue=false)]
        public string ApellidoCasada { get; set; }
        [DataMember(Name="fechaNacimiento", EmitDefaultValue=false)]
        public string FechaNacimiento { get; set; }
        [DataMember(Name="edad", EmitDefaultValue=false)]
        public decimal? Edad { get; set; }
        [DataMember(Name="genero", EmitDefaultValue=false)]
        public string Genero { get; set; }
        [DataMember(Name="tipoDocumento", EmitDefaultValue=false)]
        public string TipoDocumento { get; set; }
        [DataMember(Name="numeroDocumento", EmitDefaultValue=false)]
        public string NumeroDocumento { get; set; }
        [DataMember(Name="RUC", EmitDefaultValue=false)]
        public string RUC { get; set; }
        [DataMember(Name="codigoSBS", EmitDefaultValue=false)]
        public float? CodigoSBS { get; set; }
        [DataMember(Name="ubigeo", EmitDefaultValue=false)]
        public string Ubigeo { get; set; }
        [DataMember(Name="departamento", EmitDefaultValue=false)]
        public string Departamento { get; set; }
        [DataMember(Name="provincia", EmitDefaultValue=false)]
        public string Provincia { get; set; }
        [DataMember(Name="distrito", EmitDefaultValue=false)]
        public string Distrito { get; set; }
        [DataMember(Name="via", EmitDefaultValue=false)]
        public string Via { get; set; }
        [DataMember(Name="numeroExterior", EmitDefaultValue=false)]
        public string NumeroExterior { get; set; }
        [DataMember(Name="numeroInterior", EmitDefaultValue=false)]
        public string NumeroInterior { get; set; }
        [DataMember(Name="zona", EmitDefaultValue=false)]
        public string Zona { get; set; }
        [DataMember(Name="claveTipoPersona", EmitDefaultValue=false)]
        public decimal? ClaveTipoPersona { get; set; }
        [DataMember(Name="claveTipoEmpresa", EmitDefaultValue=false)]
        public string ClaveTipoEmpresa { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatosPersonales {\n");
            sb.Append("  PrimerNombre: ").Append(PrimerNombre).Append("\n");
            sb.Append("  SegundoNombre: ").Append(SegundoNombre).Append("\n");
            sb.Append("  ApellidoPaterno: ").Append(ApellidoPaterno).Append("\n");
            sb.Append("  ApellidoMaterno: ").Append(ApellidoMaterno).Append("\n");
            sb.Append("  ApellidoCasada: ").Append(ApellidoCasada).Append("\n");
            sb.Append("  FechaNacimiento: ").Append(FechaNacimiento).Append("\n");
            sb.Append("  Edad: ").Append(Edad).Append("\n");
            sb.Append("  Genero: ").Append(Genero).Append("\n");
            sb.Append("  TipoDocumento: ").Append(TipoDocumento).Append("\n");
            sb.Append("  NumeroDocumento: ").Append(NumeroDocumento).Append("\n");
            sb.Append("  RUC: ").Append(RUC).Append("\n");
            sb.Append("  CodigoSBS: ").Append(CodigoSBS).Append("\n");
            sb.Append("  Ubigeo: ").Append(Ubigeo).Append("\n");
            sb.Append("  Departamento: ").Append(Departamento).Append("\n");
            sb.Append("  Provincia: ").Append(Provincia).Append("\n");
            sb.Append("  Distrito: ").Append(Distrito).Append("\n");
            sb.Append("  Via: ").Append(Via).Append("\n");
            sb.Append("  NumeroExterior: ").Append(NumeroExterior).Append("\n");
            sb.Append("  NumeroInterior: ").Append(NumeroInterior).Append("\n");
            sb.Append("  Zona: ").Append(Zona).Append("\n");
            sb.Append("  ClaveTipoPersona: ").Append(ClaveTipoPersona).Append("\n");
            sb.Append("  ClaveTipoEmpresa: ").Append(ClaveTipoEmpresa).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DatosPersonales);
        }
        public bool Equals(DatosPersonales input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.PrimerNombre == input.PrimerNombre ||
                    (this.PrimerNombre != null &&
                    this.PrimerNombre.Equals(input.PrimerNombre))
                ) && 
                (
                    this.SegundoNombre == input.SegundoNombre ||
                    (this.SegundoNombre != null &&
                    this.SegundoNombre.Equals(input.SegundoNombre))
                ) && 
                (
                    this.ApellidoPaterno == input.ApellidoPaterno ||
                    (this.ApellidoPaterno != null &&
                    this.ApellidoPaterno.Equals(input.ApellidoPaterno))
                ) && 
                (
                    this.ApellidoMaterno == input.ApellidoMaterno ||
                    (this.ApellidoMaterno != null &&
                    this.ApellidoMaterno.Equals(input.ApellidoMaterno))
                ) && 
                (
                    this.ApellidoCasada == input.ApellidoCasada ||
                    (this.ApellidoCasada != null &&
                    this.ApellidoCasada.Equals(input.ApellidoCasada))
                ) && 
                (
                    this.FechaNacimiento == input.FechaNacimiento ||
                    (this.FechaNacimiento != null &&
                    this.FechaNacimiento.Equals(input.FechaNacimiento))
                ) && 
                (
                    this.Edad == input.Edad ||
                    (this.Edad != null &&
                    this.Edad.Equals(input.Edad))
                ) && 
                (
                    this.Genero == input.Genero ||
                    (this.Genero != null &&
                    this.Genero.Equals(input.Genero))
                ) && 
                (
                    this.TipoDocumento == input.TipoDocumento ||
                    (this.TipoDocumento != null &&
                    this.TipoDocumento.Equals(input.TipoDocumento))
                ) && 
                (
                    this.NumeroDocumento == input.NumeroDocumento ||
                    (this.NumeroDocumento != null &&
                    this.NumeroDocumento.Equals(input.NumeroDocumento))
                ) && 
                (
                    this.RUC == input.RUC ||
                    (this.RUC != null &&
                    this.RUC.Equals(input.RUC))
                ) && 
                (
                    this.CodigoSBS == input.CodigoSBS ||
                    (this.CodigoSBS != null &&
                    this.CodigoSBS.Equals(input.CodigoSBS))
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
                    this.Via == input.Via ||
                    (this.Via != null &&
                    this.Via.Equals(input.Via))
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
                    this.Zona == input.Zona ||
                    (this.Zona != null &&
                    this.Zona.Equals(input.Zona))
                ) && 
                (
                    this.ClaveTipoPersona == input.ClaveTipoPersona ||
                    (this.ClaveTipoPersona != null &&
                    this.ClaveTipoPersona.Equals(input.ClaveTipoPersona))
                ) && 
                (
                    this.ClaveTipoEmpresa == input.ClaveTipoEmpresa ||
                    (this.ClaveTipoEmpresa != null &&
                    this.ClaveTipoEmpresa.Equals(input.ClaveTipoEmpresa))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.PrimerNombre != null)
                    hashCode = hashCode * 59 + this.PrimerNombre.GetHashCode();
                if (this.SegundoNombre != null)
                    hashCode = hashCode * 59 + this.SegundoNombre.GetHashCode();
                if (this.ApellidoPaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoPaterno.GetHashCode();
                if (this.ApellidoMaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoMaterno.GetHashCode();
                if (this.ApellidoCasada != null)
                    hashCode = hashCode * 59 + this.ApellidoCasada.GetHashCode();
                if (this.FechaNacimiento != null)
                    hashCode = hashCode * 59 + this.FechaNacimiento.GetHashCode();
                if (this.Edad != null)
                    hashCode = hashCode * 59 + this.Edad.GetHashCode();
                if (this.Genero != null)
                    hashCode = hashCode * 59 + this.Genero.GetHashCode();
                if (this.TipoDocumento != null)
                    hashCode = hashCode * 59 + this.TipoDocumento.GetHashCode();
                if (this.NumeroDocumento != null)
                    hashCode = hashCode * 59 + this.NumeroDocumento.GetHashCode();
                if (this.RUC != null)
                    hashCode = hashCode * 59 + this.RUC.GetHashCode();
                if (this.CodigoSBS != null)
                    hashCode = hashCode * 59 + this.CodigoSBS.GetHashCode();
                if (this.Ubigeo != null)
                    hashCode = hashCode * 59 + this.Ubigeo.GetHashCode();
                if (this.Departamento != null)
                    hashCode = hashCode * 59 + this.Departamento.GetHashCode();
                if (this.Provincia != null)
                    hashCode = hashCode * 59 + this.Provincia.GetHashCode();
                if (this.Distrito != null)
                    hashCode = hashCode * 59 + this.Distrito.GetHashCode();
                if (this.Via != null)
                    hashCode = hashCode * 59 + this.Via.GetHashCode();
                if (this.NumeroExterior != null)
                    hashCode = hashCode * 59 + this.NumeroExterior.GetHashCode();
                if (this.NumeroInterior != null)
                    hashCode = hashCode * 59 + this.NumeroInterior.GetHashCode();
                if (this.Zona != null)
                    hashCode = hashCode * 59 + this.Zona.GetHashCode();
                if (this.ClaveTipoPersona != null)
                    hashCode = hashCode * 59 + this.ClaveTipoPersona.GetHashCode();
                if (this.ClaveTipoEmpresa != null)
                    hashCode = hashCode * 59 + this.ClaveTipoEmpresa.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
