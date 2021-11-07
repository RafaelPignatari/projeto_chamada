namespace ProjetoN2.Models
{
    public class TurmaViewModel : SuperViewModel
    {
        public int Semestre { get; set; }
        public CursoViewModel Curso { get; set; }
    }
}