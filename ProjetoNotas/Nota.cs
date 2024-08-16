namespace ProjetoNotas
{
    public class Nota
    {
        public string Descricao { get; set; }

        public void Exibir()
        {
            Console.WriteLine(Descricao);
            Console.WriteLine("----------------------------------------");
        }

      
    }
}
