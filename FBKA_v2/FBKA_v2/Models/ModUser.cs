using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace FBKA_v2.Models
{
    public class ModUser
    {
        [Display(Name = "Código do Usuário")]
        [Range(minimum: 1, maximum: 999999999, ErrorMessage = "Código do usuário deve ser entre 1 e 999999999")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [NumeroBrasil(PontoMilharPermitido = true, DecimalRequerido = false)]
        public int IdUser { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Campo nome obrigatório")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Campo Nome deve ter entre 3 e 50 caracteres")]
        [Remote("ValidNames", "RegisterUser", ErrorMessage = "Nome Já cadastrado!", AdditionalFields = "IdUser")]
        public String Name { get; set; }

        [Display(Name = "Email para cadastro")]
        //[RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido")]
        [EmailBrasil(ErrorMessage = "Email inválido", EmailRequerido = true)]
        [Required(ErrorMessage = "Campo email obrigatório")]
        public String Email { get; set; }

        [Display(Name = "Data de cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataBrasil(ErrorMessage = "Data inválida", DataRequerida = false)]
        public DateTime? DtCadastro { get; set; }

        [Display(Name = "Valor da Etapa")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "Valor deve ser maior que 1,00 e menor que 10.000,00")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [NumeroBrasil(ErrorMessage = "Valor está inválido!", PontoMilharPermitido = true, DecimalRequerido = true)]
        public double? ValorEtapa { get; set; }

        [Display(Name = "Senha")]
        [SenhaBrasil(SenhaTamanhoMinimo = 6, SenhaTamanhoMaximo = 8, SenhaForteRequerida =true, CaracterEspecialRequerido = false)]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Senhas digitadas não conferem.")]
        public string ConfirmPassword { get; set; }

    }
}