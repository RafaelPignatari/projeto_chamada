using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class TurmaDAO : SuperDAO<TurmaViewModel>
    {
        private CursoDAO cursoDAO;

        public TurmaDAO()
        {
            cursoDAO = new CursoDAO();
        }
        protected override TurmaViewModel SetModel(DataRow row)
        {
            TurmaViewModel turmaViewModel = new TurmaViewModel();
            turmaViewModel.Id = Convert.ToInt32(row["turma_id"]);
            turmaViewModel.Semestre = Convert.ToInt32(row["turma_semestre"]);
            turmaViewModel.Curso = cursoDAO.SelectById(Convert.ToInt32(row["turma_semestre"]));

            return turmaViewModel;
        }

        protected override SqlParameter[] SetParameters(TurmaViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("semestre", model.Semestre);
            parameters[2] = new SqlParameter("curso_id", model.Curso.Id);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "turma";
        }
    }
}