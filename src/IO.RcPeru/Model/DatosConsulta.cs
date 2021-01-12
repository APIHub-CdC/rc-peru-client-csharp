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
    public partial class DatosConsulta :  IEquatable<DatosConsulta>, IValidatableObject
    {
        public DatosConsulta(string fechaConsulta = default(string), decimal? numeroConsulta = default(decimal?), string otorgante = default(string), string usuario = default(string), float? tipoCambio = default(float?))
        {
            this.FechaConsulta = fechaConsulta;
            this.NumeroConsulta = numeroConsulta;
            this.Otorgante = otorgante;
            this.Usuario = usuario;
            this.TipoCambio = tipoCambio;
        }
        [DataMember(Name="fechaConsulta", EmitDefaultValue=false)]
        public string FechaConsulta { get; set; }
        [DataMember(Name="numeroConsulta", EmitDefaultValue=false)]
        public decimal? NumeroConsulta { get; set; }
        [DataMember(Name="otorgante", EmitDefaultValue=false)]
        public string Otorgante { get; set; }
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
        [DataMember(Name="tipoCambio", EmitDefaultValue=false)]
        public float? TipoCambio { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatosConsulta {\n");
            sb.Append("  FechaConsulta: ").Append(FechaConsulta).Append("\n");
            sb.Append("  NumeroConsulta: ").Append(NumeroConsulta).Append("\n");
            sb.Append("  Otorgante: ").Append(Otorgante).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  TipoCambio: ").Append(TipoCambio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DatosConsulta);
        }
        public bool Equals(DatosConsulta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FechaConsulta == input.FechaConsulta ||
                    (this.FechaConsulta != null &&
                    this.FechaConsulta.Equals(input.FechaConsulta))
                ) && 
                (
                    this.NumeroConsulta == input.NumeroConsulta ||
                    (this.NumeroConsulta != null &&
                    this.NumeroConsulta.Equals(input.NumeroConsulta))
                ) && 
                (
                    this.Otorgante == input.Otorgante ||
                    (this.Otorgante != null &&
                    this.Otorgante.Equals(input.Otorgante))
                ) && 
                (
                    this.Usuario == input.Usuario ||
                    (this.Usuario != null &&
                    this.Usuario.Equals(input.Usuario))
                ) && 
                (
                    this.TipoCambio == input.TipoCambio ||
                    (this.TipoCambio != null &&
                    this.TipoCambio.Equals(input.TipoCambio))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaConsulta != null)
                    hashCode = hashCode * 59 + this.FechaConsulta.GetHashCode();
                if (this.NumeroConsulta != null)
                    hashCode = hashCode * 59 + this.NumeroConsulta.GetHashCode();
                if (this.Otorgante != null)
                    hashCode = hashCode * 59 + this.Otorgante.GetHashCode();
                if (this.Usuario != null)
                    hashCode = hashCode * 59 + this.Usuario.GetHashCode();
                if (this.TipoCambio != null)
                    hashCode = hashCode * 59 + this.TipoCambio.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
