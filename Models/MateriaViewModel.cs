namespace ProjetoN2.Models
{
    public class MateriaViewModel : SuperViewModel
    {
        public string Nome { get; set; }
        public CursoViewModel Curso { get; set; }
        public ProfessorViewModel Professor { get; set; }
    }
}