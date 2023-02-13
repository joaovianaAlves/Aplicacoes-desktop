static void Verificacao() {
    string escreve;
    escreve = "";
    do
    {
        Console.WriteLine("Escreve QUE");
        escreve = Console.ReadLine();
    } while (escreve != "QUE");


    if (escreve == "QUE")
    {
        Console.WriteLine("Aceito");
    }
}

Verificacao();