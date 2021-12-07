using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace CRUD_CONSOLE
{
    public class MenuSistema
    {
        public void MontaMenu()
        {
            Console.WriteLine("CRUD CONSOLE");
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Deletar");
            Console.Write("Opção: ");
        }        
    }    
}
