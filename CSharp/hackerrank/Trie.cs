namespace hackerrank
{
    public class Trie
    {
        private readonly Trie[] TrieNoFilho;
        private readonly char? Letra;
        private bool FinalPalavra;
        private int QuantidadePalavras;
        const int PosicaoCharCode = 97;

        public Trie(char? letra)
        {
            Letra = letra;
            FinalPalavra = false;
            QuantidadePalavras = 1;
            TrieNoFilho = new Trie[26];
        }

        public void Insere(Trie noAtual, string palavra)
        {
            foreach (var p in palavra)
            {
                var indiceLetra = p - PosicaoCharCode;

                if (noAtual.TrieNoFilho[indiceLetra] == null)
                {
                    var novoNo = new Trie(p);
                    noAtual.TrieNoFilho[indiceLetra] = novoNo;
                    noAtual = novoNo;
                }
                else
                {
                    noAtual = noAtual.TrieNoFilho[indiceLetra];
                    noAtual.QuantidadePalavras++;
                }
            }
            noAtual.FinalPalavra = true;
        }

        public int BuscarTotalPalavras(Trie no, string palavra)
        {
            var noAtual = no;


            foreach (var p in palavra)
            {
                var indiceLetra = p - PosicaoCharCode;

                if (noAtual.TrieNoFilho[indiceLetra] != null)
                {
                    noAtual = noAtual.TrieNoFilho[indiceLetra];
                }
                else
                {
                    return 0;
                }
            }
            return noAtual.QuantidadePalavras;
        }

        /*
        We're going to make our own Contacts application! The application must perform two types of operations:
        add name, where  is a string denoting a contact name.This must store  as a new contact in the application.
        find partial, where  is a string denoting a partial name to search the application for. It must count the number 
        of contacts starting with and print the count on a new line.
        Given sequential add and find operations, perform each operation in order.
        */
        public List<int> contacts()
        {
            List<List<string>> queries = new List<List<string>>()
            {
                new List<string>() { "add", "hack" },
                new List<string>() { "add", "hackerrank" },
                new List<string>() { "find", "hac" },
                new List<string>() { "find", "hak" }
            };

            var no = new Trie(null);
            var resultado = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {

                bool adicionar = queries[i][0] == "add";
                bool buscar = queries[i][0] == "find";
                string palavra = queries[i][1];

                if (adicionar)
                {
                    no.Insere(no, palavra);
                }
                else if (buscar)
                {
                    resultado.Add(no.BuscarTotalPalavras(no, palavra));
                }

            }
            return resultado;
        }
    }
}
