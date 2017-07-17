using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FBKA_v2.Models
{
    public class ModUser
    {
        [Display(Name= "Código do Usuário")]
        [Range(minimum:1, maximum:50, ErrorMessage ="Código do usuário deve ser entre 1 e 50")]
        public int IdUser { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Campo nome obrigatório")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Campo Nome deve ter entre 4 e 50 caracteres")]
        public String Name { get; set; }
        [Display(Name = "Email para cadastro")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido")]
        [Required(ErrorMessage = "Campo email obrigatório")]
        public String Email { get; set; }


    }
}