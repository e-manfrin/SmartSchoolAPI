namespace SmartSchoolAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() {}
        public AlunoDisciplina(int alunoId, int DisciplicaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = DisciplicaId;
        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
