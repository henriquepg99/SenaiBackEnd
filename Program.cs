using System;
namespace  Atividade
{
    class Program   
    { 
        static void Main(string[] agrs)
        {
            float val_pag;
            Console.WriteLine("informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (F) ou Jurídica (J)");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "F")
            {
            // --- Pessoa Física ---
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.nome = var_nome;
            pf.endereco = var_endereco;
            Console.WriteLine("Informar CPF:");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Informar RG:");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Física --------");
            Console.WriteLine("Nome ..........: " + pf.nome);
            Console.WriteLine("Endereço ......: " + pf.endereco);
            Console.WriteLine("CPF ...........: " + pf.cpf);
            Console.WriteLine("RG ............: " + pf.rg);
            Console.WriteLine("Valor de Compra: " + pf.valor.ToString("c"));
            Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("c"));
            Console.WriteLine("Total a Pagar..: " + pf.total.ToString("c"));
            }
            if(var_tipo == "J")
            {
            // Pessoa Jurídica
            Pessoa_Juridica pj = new Pessoa_Juridica();
            pj.nome = var_nome;
            pj.endereco = var_endereco;
            Console.WriteLine("Informar CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("informar IE:");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Jurídica --------");
            Console.WriteLine("Endereço ......: " + pj.endereco);
            Console.WriteLine("CJPJ ..........: " + pj.cnpj);
            Console.WriteLine("IE ............: " + pj.ie);
            Console.WriteLine("Valor de Compra: " + pj.valor.ToString("c"));
            Console.WriteLine("Imposoto ......: " + pj.valor_imposto.ToString("c"));
            Console.WriteLine("Total a Pagar..: " + pj.total.ToString("c"));
            }

        }
    }
}

