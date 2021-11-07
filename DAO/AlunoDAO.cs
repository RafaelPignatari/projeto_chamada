using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class AlunoDAO : SuperDAO<AlunoViewModel>
    {
        private TurmaDAO turmaDAO;
        public AlunoDAO()
        {
            turmaDAO = new TurmaDAO();
        }
        protected override AlunoViewModel SetModel(DataRow row)
        {
            AlunoViewModel alunoViewModel = new AlunoViewModel();
            alunoViewModel.Id = Convert.ToInt32(row["aluno_id"]);
            alunoViewModel.Nome = row["aluno_nome"].ToString();
            alunoViewModel.Turma = turmaDAO.SelectById(Convert.ToInt32(row["turma_id"]));

            return alunoViewModel;
        }

        protected override SqlParameter[] SetParameters(AlunoViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("nome", model.Nome);
            parameters[2] = new SqlParameter("turma_id", model.Turma.Id);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "aluno";
        }
    }
}