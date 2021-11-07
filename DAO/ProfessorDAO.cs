using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class ProfessorDAO : SuperDAO<ProfessorViewModel>
    {
        protected override ProfessorViewModel SetModel(DataRow row)
        {
            ProfessorViewModel professorViewModel = new ProfessorViewModel();
            professorViewModel.Id = Convert.ToInt32(row["professor_id"]);
            professorViewModel.Nome = row["professor_nome"].ToString();

            return professorViewModel;
        }

        protected override SqlParameter[] SetParameters(ProfessorViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("nome", model.Nome);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "professor";
        }
    }
}