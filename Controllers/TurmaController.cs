using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class TurmaController : SuperController<TurmaViewModel>
    {
        public TurmaController()
        {
            DAO = new TurmaDAO();
        }

        protected override void ValidateModel(TurmaViewModel model)
        {
            ModelState.Clear();

            if(model.Semestre < 1 || 10 < model.Semestre)
            {
                ModelState.AddModelError("Semestre", "Semestre deve estar entre 1 e 10");
            }

            if(((TurmaDAO)DAO).cursoDAO.SelectById(model.CursoId) == null)
            {
                ModelState.AddModelError("CursoId", "Curso não existe");
            }
        }

        protected override void PrepareView()
        {
            ViewBag.Cursos = ((TurmaDAO)DAO).cursoDAO.SelectAll();
        }
    }
}