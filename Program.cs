
//variáveis ou propridedaes, podem ser modificadas a todo momento do ciclo de vida do código.
int idade;
idade = 25;
System.Console.WriteLine(idade);

//Não se pode alterar os valores de constantes ao decorrer do projeto (digamos que você crie uma constante com um valor x, ele nunca poderá ser substituido ou alterado).
const string msgParabens = "parabéns pela sua idade";
System.Console.WriteLine(msgParabens);
//valor2 = valor;

string nome = "Professor Douglas";
System.Console.WriteLine(nome + " - idade " + idade + msgParabens);
Console.ReadKey();