using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Enums;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class CursoDAO : SuperDAO<CursoViewModel>
    {
        protected override CursoViewModel SetModel(DataRow row)
        {
            CursoViewModel cursoViewModel = new CursoViewModel();
            cursoViewModel.Id = Convert.ToInt32(row["curso_id"]);
            cursoViewModel.Nome = row["curso_nome"].ToString();
            cursoViewModel.Periodo = (EPeriodo)Convert.ToInt32(row["curso_id"]);
            
            return cursoViewModel;
        }

        protected override SqlParameter[] SetParameters(CursoViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("nome", model.Nome);
            parameters[2] = new SqlParameter("periodo", (int)model.Periodo);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "curso";
        }
    }
}