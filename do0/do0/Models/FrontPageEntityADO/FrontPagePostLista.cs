using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using do0.Models;
using System.Web.Mvc;

namespace do0.Models
{
    public class FrontPagePostLista
    {
        [Key]
        public int FrontPagePostListaId { get; set; }
        public int do0FrontPagePostsId { get; set; }
        public FrontPagePosts FrontPagePosts { get; set; }

        [Display(Name = "do0Avatar")]
        public string do0AvatarName { get; set; }
        [Display(Name = "do0User")]
        public string do0UserName { get; set; }

        public bool Rascunho { get; set; }
        [Display(Name = "AUTOR")]
        public string Autor { get; set; }
        [Display(Name = "DATA")]
        public DateTime? Data { get; set; }
        [Display(Name = "TÍTULO")]
        public string Titulo { get; set; }
        [AllowHtml]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "Número máximo de 200 caracteres !")]
        [Display(Name = "INTRODUÇÃO")]
        public string Introducao { get; set; }
        [AllowHtml]
        [StringLength(4000, MinimumLength = 0, ErrorMessage = "Número máximo de 4000 caracteres !")]
        [Display(Name = "DESCRIÇÃO")]
        public string Descricao { get; set; }
        [Display(Name = "PASTA")]
        public string Pasta { get; set; }

        [Display(Name = "LINK EXTERNO?")]
        public bool LinkExterno { get; set; }

        [Display(Name = "ENDEREÇO URL LINK")]
        public string LinkUrl { get; set; }
        public bool Reserva1 { get; set; }
    }
}