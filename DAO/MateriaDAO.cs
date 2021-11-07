using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class MateriaDAO : SuperDAO<MateriaViewModel>
    {
        private ProfessorDAO professorDAO;
        private CursoDAO cursoDAO;

        public MateriaDAO()
        {
            professorDAO = new ProfessorDAO();
            cursoDAO = new CursoDAO();
        }
        protected override MateriaViewModel SetModel(DataRow row)
        {
            MateriaViewModel materiaViewModel = new MateriaViewModel();
            materiaViewModel.Id = Convert.ToInt32(row["materia_id"]);
            materiaViewModel.Nome = row["materia_nome"].ToString();
            materiaViewModel.Professor = professorDAO.SelectById(Convert.ToInt32(row["professor_id"]));
            materiaViewModel.Curso = cursoDAO.SelectById(Convert.ToInt32(row["curso_id"]));

            return materiaViewModel;
        }

        protected override SqlParameter[] SetParameters(MateriaViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("nome", model.Nome);
            parameters[2] = new SqlParameter("professor_id", model.Professor.Id);
            parameters[3] = new SqlParameter("curso_id", model.Curso.Id);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "materia";
        }
    }
}