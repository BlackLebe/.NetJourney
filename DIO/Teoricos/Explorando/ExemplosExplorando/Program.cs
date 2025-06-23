using ExemplosExplorando.models;

Console.Clear();


Pessoa p1 = new Pessoa();
// p1.Nome = "Calebe";
// p1.Sobrenome = "Honorato";

Pessoa p2 = new Pessoa();
// p2.Nome = "Pedro";
// p2.Sobrenome = "Machado";

Curso cursoDeIngles = new Curso();
cursoDeIngles.InformacaoCurso();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




















// Pessoa p1 = new Pessoa();

// p1.Apresentar();

