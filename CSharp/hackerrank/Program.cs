namespace hackerrank
{
    public class TrieNode
    {
        private readonly TrieNode[] TrieNoFilho;
        private readonly char? Letra;
        private bool FinalPalavra;
        private int QuantidadePalavras;
        const int PosicaoCharCode = 97;

        public TrieNode(char? letra)
        {
            Letra = letra;
            FinalPalavra = false;
            QuantidadePalavras = 1;
            TrieNoFilho = new TrieNode[26];
        }

        public void Insere(TrieNode noAtual, string palavra)
        {
            foreach (var p in palavra)
            {
                var indiceLetra = p - PosicaoCharCode;

                if (noAtual.TrieNoFilho[indiceLetra] == null)
                {
                    var novoNo = new TrieNode(p);
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

        public int BuscarTotalPalavras(TrieNode no, string palavra)
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
    }

    class Program
    {
        /*
         * Complete the 'contacts' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts 2D_STRING_ARRAY queries as parameter.
         */

        public static List<int> contacts(List<List<string>> queries)
        {
            var no = new TrieNode(null);
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

        static void Main()
        {
            List<List<string>> queries = new List<List<string>>()
            {
                new List<string>() { "add", "hack" },
                new List<string>() { "add", "hackerrank" },
                new List<string>() { "find", "hac" },
                new List<string>() { "find", "hak" }
            };

            var resultado = contacts(queries);

            resultado.ForEach(x => Console.WriteLine(x));
        }
    }
}