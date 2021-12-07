// See https://aka.ms/new-console-template for more information
using CRUD_CONSOLE;
MenuSistema menuSistema = new MenuSistema();

Categorias categorias = new Categorias();

int opcao;
int id;
string? nome = "";
do
{
    
    menuSistema.MontaMenu();   
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1: categorias.ListarCategorias();
            break;
        case 2: 
            Console.WriteLine("Digite o ID ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome ");
            nome = Console.ReadLine();
            
            categorias.IncluirCategoria(id,nome);
            categorias.ListarCategorias();
            break; 
        
        case 3: Console.WriteLine("Digite o id para excluir");
            id = Convert.ToInt32(Console.ReadLine());
            categorias.ExcluirCategoria(id);
            categorias.ListarCategorias();
            break;
    }

    if (!(opcao >= 1 && opcao <= 3))
        {
            Console.WriteLine("Digite uma opção válida");            
        }       

} while (opcao != 4);

