using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using do0.Models;

namespace do0.Models
{
    public class do0DbInicializador1 : DropCreateDatabaseAlways<do0Context>
    {
        protected override void Seed(do0Context context)
        {
            IList<FrontPagePosts> defaultFrontPagePosts = new List<FrontPagePosts>();

            defaultFrontPagePosts.Add(new FrontPagePosts()
            {
                // do0FrontPagePostsId = 1,
                do0AvatarName = "do0CodeS",
                Descricao = "Página Principal"
            });

            context.FrontPagePosts.AddRange(defaultFrontPagePosts);

            base.Seed(context);

            IList<FrontPagePostLista> defaultFrontPagePostLista = new List<FrontPagePostLista>();

            defaultFrontPagePostLista.Add(new FrontPagePostLista()
            {
                //FrontPagePostListaId = 1,
                do0AvatarName = "do0CodeS",
                Descricao = "Lista Completa da Side Panel"
            });

            context.FrontPagePostLista.AddRange(defaultFrontPagePostLista);

            base.Seed(context);

        }
    }
}