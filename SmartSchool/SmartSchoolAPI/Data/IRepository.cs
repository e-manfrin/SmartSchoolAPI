using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        public Aluno[] GetAllAlunos(bool includeProfessor = false);
        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false);

        public Professor[] GetAllProfessores(bool includeAlunos = false);
        public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, 
                                                           bool includeAlunos = false);
        public Professor GetProfessorById(int professorId, bool includeProfessor = false);

    }
}
