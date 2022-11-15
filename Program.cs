using CSharp.Models;

Pessoa p1 = new Pessoa("Gui","oliveira");

Pessoa p2 = new Pessoa("juliana","Maraccini");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();






/*
Pessoa p1 = new Pessoa();
p1.Nome = "Guilherme";// o nome vai ser o value
p1.Sobrenome = "Oliveira";
p1.Idade = 20;
p1.Apresentar();
*/

// Pessoa p2 = new Pessoa();
// p2.Nome = "Guilherme";
// p2.Idade = 20;
// p2.Apresentar();