using ML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result Add(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "LibroAdd";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = libro.Nombre;

                        collection[1] = new SqlParameter("@NumeroPaginas", System.Data.SqlDbType.Int);
                        collection[1].Value = libro.NumeroPaginas;

                        collection[2] = new SqlParameter("@FechaPublicacion", System.Data.SqlDbType.VarChar);
                        collection[2].Value = libro.FechaPublicacion;

                        collection[3] = new SqlParameter("@Edicion", System.Data.SqlDbType.VarChar);
                        collection[3].Value = libro.Edicion;

                        collection[3] = new SqlParameter("@IdAutor", System.Data.SqlDbType.Int);
                        collection[3].Value = libro.Autor.IdAutor;

                        collection[3] = new SqlParameter("@IdEditorial", System.Data.SqlDbType.Int);
                        collection[3].Value = libro.Editorial.IdEditorial;

                        collection[3] = new SqlParameter("@IdGenero", System.Data.SqlDbType.Int);
                        collection[3].Value = libro.Genero.IdGenero;


                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }


                    }
                }
            }
            catch
            {
                result.Correct = false;
            }
            return result;
        }

        public static ML.Result Update(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "LibroUpdate";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[8];

                        collection[0] = new SqlParameter("@IdLibro", System.Data.SqlDbType.Int);
                        collection[0].Value = libro.IdLibro;

                        collection[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[1].Value = libro.Nombre;

                        collection[2] = new SqlParameter("@NumeroPaginas", System.Data.SqlDbType.Int);
                        collection[2].Value = libro.NumeroPaginas;

                        collection[3] = new SqlParameter("@FechaPublicacion", System.Data.SqlDbType.VarChar);
                        collection[3].Value = libro.FechaPublicacion;

                        collection[4] = new SqlParameter("@Edicion", System.Data.SqlDbType.VarChar);
                        collection[4].Value = libro.Edicion;

                        collection[5] = new SqlParameter("@IdAutor", System.Data.SqlDbType.Int);
                        collection[5].Value = libro.Autor.IdAutor;

                        collection[6] = new SqlParameter("@Editorial", System.Data.SqlDbType.Int);
                        collection[6].Value = libro.Editorial.IdEditorial;

                        collection[7] = new SqlParameter("@Genero", System.Data.SqlDbType.Int);
                        collection[7].Value = libro.Genero.IdGenero;


                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }


                    }
                }
            }
            catch
            {
                result.Correct = false;
            }
            return result;
        }

        public static ML.Result Delete(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "LibroDelete";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdLibro", System.Data.SqlDbType.VarChar);
                        collection[0].Value = libro.IdLibro;


                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }


                    }
                }
            }
            catch
            {
                result.Correct = false;
            }
            return result;
        }
    }
}
