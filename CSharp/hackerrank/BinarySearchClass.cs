namespace hackerrank
{
    public class BinarySearchClass
    {
        public int BinarySearch(List<int> array, int numero)
        {
            int inicio = 0;
            int fim = array.Count - 1;

            while (inicio <= fim)
            {
                var meio = (inicio + fim) / 2;

                if (numero < array[meio])
                {
                    fim = meio - 1;
                }
                else if (numero > array[meio])
                {
                    inicio = meio + 1;
                }
                else
                {
                    return meio;
                }
            }
            return -1;
        }
    }
}
