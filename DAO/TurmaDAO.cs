using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class TurmaDAO : SuperDAO<TurmaViewModel>
    {
        public CursoDAO cursoDAO;

        public TurmaDAO()
        {
            cursoDAO = new CursoDAO();
        }
        protected override TurmaViewModel SetModel(DataRow row)
        {
            TurmaViewModel turmaViewModel = new TurmaViewModel();
            turmaViewModel.Id = Convert.ToInt32(row["turma_id"]);
            turmaViewModel.Semestre = Convert.ToInt32(row["turma_semestre"]);
            if(row.Table.Columns.Contains("curso_nome"))
            {
                turmaViewModel.CursoNome = row["curso_nome"].ToString();
            }
            else
            {
                turmaViewModel.CursoId = Convert.ToInt32(row["curso_id"]);
            }

            return turmaViewModel;
        }

        protected override SqlParameter[] SetParameters(TurmaViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("semestre", model.Semestre);
            parameters[1] = new SqlParameter("curso_id", model.CursoId);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "turma";
            SpSelectName = SpSelectName + "_" + Table;
        }
    }
}