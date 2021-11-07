using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class AulaDAO : SuperDAO<AulaViewModel>
    {
        private MateriaDAO materiaDAO;
        private TurmaDAO turmaDAO;
        private SalaDAO salaDAO;

        public AulaDAO()
        {
            materiaDAO = new MateriaDAO();
            turmaDAO = new TurmaDAO();
            salaDAO = new SalaDAO();
        }
        protected override AulaViewModel SetModel(DataRow row)
        {
            AulaViewModel aulaViewModel = new AulaViewModel();
            aulaViewModel.Id = Convert.ToInt32(row["aula_id"]);
            aulaViewModel.Data = Convert.ToDateTime(row["aula_data"]);
            aulaViewModel.Materia = materiaDAO.SelectById(Convert.ToInt32(row["materia_id"]));
            aulaViewModel.Turma = turmaDAO.SelectById(Convert.ToInt32(row["turma_id"]));
            aulaViewModel.Sala = salaDAO.SelectById(Convert.ToInt32(row["sala_id"]));

            return aulaViewModel;
        }
        protected override SqlParameter[] SetParameters(AulaViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("data", model.Data);
            parameters[2] = new SqlParameter("turma_id", model.Turma.Id);
            parameters[3] = new SqlParameter("materia_id", model.Materia.Id);
            parameters[4] = new SqlParameter("sala_id", model.Sala.Id);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "aula";
        }
    }
}