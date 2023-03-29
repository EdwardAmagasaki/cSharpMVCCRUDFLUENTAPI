using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace do0.Models.FrontPageEntityADO
{
    public class FrontPagePostsADORepository : AbstractRepository<FrontPagePosts, int>
    {
        ///<summary>Exclui uma FrontPagePosts pela entidade
        ///<param name="entity">Referência de FrontPagePosts que será excluída.</param>
        ///</summary>
        public override void Delete(FrontPagePosts entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE do0FrontPagePosts Where do0FrontPagePostsId=@do0FrontPagePostsId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@do0FrontPagePostsId", entity.do0FrontPagePostsId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        ///<summary>Exclui uma do0FrontPagePosts pelo ID
        ///<param name="id">Id do registro que será excluído.</param>
        ///</summary>
        public override void DeleteById(int do0FrontPagePostsId)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE do0FrontPagePosts Where do0FrontPagePostsId=@do0FrontPagePostsId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@do0FrontPagePostsId", do0FrontPagePostsId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        ///<summary>Obtém todas as FrontPagePosts
        ///<returns>Retorna as FrontPagePosts cadastradas.</returns>
        ///</summary>
        public override List<FrontPagePosts> GetAll()
        {
            string sql = "Select do0FrontPagePostsId, Data, Autor, do0UserName, do0AvatarName, Rascunho, Reserva1, Titulo, Introducao, Descricao, LinkExterno, LinkUrl, Pasta FROM do0FrontPagePosts ORDER BY Data";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<FrontPagePosts> list = new List<FrontPagePosts>();
                FrontPagePosts p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new FrontPagePosts();
                            p.do0FrontPagePostsId = (int)reader["do0FrontPagePostsId"];
                            p.Data = (DateTime)reader["Data"];
                            p.Autor = reader["Autor"].ToString();
                            p.do0UserName = reader["do0UserName"].ToString();
                            p.do0AvatarName = reader["do0AvatarName"].ToString();
                            p.Rascunho = (bool)reader["Rascunho"];
                            p.Reserva1 = (bool)reader["Reserva1"];
                            p.Titulo = reader["Titulo"].ToString();
                            p.Introducao = reader["Introducao"].ToString();
                            p.Descricao = reader["Descricao"].ToString();
                            p.LinkExterno = (bool)reader["LinkExterno"];
                            p.LinkUrl = reader["LinkUrl"].ToString();
                            p.Pasta = reader["Pasta"].ToString();
                            list.Add(p);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return list;
            }
        }

        ///<summary>Obtém uma FrontPagePosts pelo ID
        ///<param name="id">Id do registro que obtido.</param>
        ///<returns>Retorna uma referência de FrontPagePosts do registro encontrado ou null se ele não for encontrado.</returns>
        ///</summary>
        public override FrontPagePosts GetById(int FrontPagePostsId)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select do0FrontPagePostsId, Data, Autor, do0UserName, do0AvatarName, Rascunho, Reserva1,Titulo, Introducao, Descricao, LinkExterno,LinkUrl,Pasta  FROM do0FrontPagePosts WHERE do0FrontPagePostsId=@do0FrontPagePostsId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FrontPagePostsId", FrontPagePostsId.ToString());
                FrontPagePosts p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                p = new FrontPagePosts();
                                p.do0FrontPagePostsId = (int)reader["do0FrontPagePostsId"];
                                p.Data = (DateTime)reader["Data"];
                                p.Autor = reader["Autor"].ToString();
                                p.do0UserName = reader["do0UserName"].ToString();
                                p.do0AvatarName = reader["do0AvatarName"].ToString();
                                p.Rascunho = (bool)reader["Rascunho"];
                                p.Reserva1 = (bool)reader["Reserva1"];
                                p.Titulo = reader["Titulo"].ToString();
                                p.Introducao = reader["Introducao"].ToString();
                                p.Descricao = reader["Descricao"].ToString();
                                p.LinkExterno = (bool)reader["LinkExterno"];
                                p.LinkUrl = reader["LinkUrl"].ToString();
                                p.Pasta = reader["Pasta"].ToString();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return p;
            }
        }

        ///<summary>Salva a FrontPagePosts no banco
        ///<param name="entity">Referência de FrontPagePosts que será salva.</param>
        ///</summary>
        public override void Save(FrontPagePosts entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO do0FrontPagePosts ( Data, Autor, do0UserName, do0AvatarName, Rascunho, Reserva1, Titulo, Introducao, Descricao, LinkExterno, LinkUrl, Pasta ) VALUES (@Data, @Autor, @do0UserName, @do0AvatarName, @Rascunho, @Reserva1, @Titulo, @Introducao, @Descricao, @LinkExterno, @LinkUrl, @Pasta )";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@do0FrontPagePostsId", entity.do0FrontPagePostsId);
                cmd.Parameters.AddWithValue("@Data", entity.Data);
                cmd.Parameters.AddWithValue("@Autor", entity.Autor);
                cmd.Parameters.AddWithValue("@do0UserName", entity.do0UserName);
                cmd.Parameters.AddWithValue("@do0AvatarName", entity.do0AvatarName);
                cmd.Parameters.AddWithValue("@Rascunho", entity.Rascunho);
                cmd.Parameters.AddWithValue("@Reserva1", entity.Reserva1);
                cmd.Parameters.AddWithValue("@Titulo", entity.Titulo);
                cmd.Parameters.AddWithValue("@Introducao", entity.Introducao);
                cmd.Parameters.AddWithValue("@Descricao", entity.Descricao);
                cmd.Parameters.AddWithValue("@LinkExterno", entity.LinkExterno);
                cmd.Parameters.AddWithValue("@LinkUrl", entity.LinkUrl);
                cmd.Parameters.AddWithValue("@Pasta", entity.Pasta);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e) 
                {
                    throw e;
                }
            }
        }

        ///<summary>Atualiza a FrontPagePosts no banco
        ///<param name="entity">Referência de FrontPagePosts que será atualizada.</param>
        ///</summary>
        public override void Update(FrontPagePosts entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE do0FrontPagePosts SET Data=@Data, Autor=@Autor, do0UserName=@do0UserName, do0AvatarName=@do0AvatarName, Rascunho=@Rascunho, Reserva1=@Reserva1, Titulo=@Titulo, Introducao=@Introducao, Descricao=@Descricao, LinkExterno=@LinkExterno, LinkUrl=@LinkUrl, Pasta=@Pasta Where do0FrontPagePostsId=@do0FrontPagePostsId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@do0FrontPagePostsId", entity.do0FrontPagePostsId);
                cmd.Parameters.AddWithValue("@Data", entity.Data);
                cmd.Parameters.AddWithValue("@Autor", entity.Autor);
                cmd.Parameters.AddWithValue("@do0UserName", entity.do0UserName);
                cmd.Parameters.AddWithValue("@do0AvatarName", entity.do0AvatarName);
                cmd.Parameters.AddWithValue("@Rascunho", entity.Rascunho);
                cmd.Parameters.AddWithValue("@Reserva1", entity.Reserva1);
                cmd.Parameters.AddWithValue("@Titulo", entity.Titulo);
                cmd.Parameters.AddWithValue("@Introducao", entity.Introducao);
                cmd.Parameters.AddWithValue("@Descricao", entity.Descricao);
                cmd.Parameters.AddWithValue("@LinkExterno", entity.LinkExterno);
                cmd.Parameters.AddWithValue("@LinkUrl", entity.LinkUrl);
                cmd.Parameters.AddWithValue("@Pasta", entity.Pasta);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

