namespace ProjetoNotas
{
    public class Gerenciador
    {
       private List<Nota> notas = new List<Nota>();

       public void Adicionar(string descricao)
        {
            var nota = new Nota {Descricao = descricao};
            notas.Add(nota);
        } 

        public void ExibirTodas()
        {
            foreach (var nota in notas)
            {
                nota.Exibir();
            }

        }

    }
}
