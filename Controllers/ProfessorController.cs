using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class ProfessorController : SuperController<ProfessorViewModel>
    {
        protected override void ValidateModel(ProfessorViewModel model)
        {
            ModelState.Clear();

            if(string.IsNullOrEmpty(model.Nome))
            {
                ModelState.AddModelError(model.Nome, "Nome não pode ser vazio.");
            }
        }
    }
}