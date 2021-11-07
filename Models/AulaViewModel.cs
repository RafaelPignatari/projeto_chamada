using System;

namespace ProjetoN2.Models
{
    public class AulaViewModel : SuperViewModel
    {
        public DateTime Data { get; set; }
        public MateriaViewModel Materia { get; set; }
        public TurmaViewModel Turma { get; set; }
        public SalaViewModel Sala { get; set; }
    }
}