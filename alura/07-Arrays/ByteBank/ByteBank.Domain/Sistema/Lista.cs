namespace ByteBank.Domain.Sistema;

public class Lista<T>
{
    private T[] _itens;
    private int _proximaPosicao;

    public T this[int indice]
    {
        get
        {
            return GetItemNoIndice(indice);
        }
    }

    public Lista(int capacidadeInicial = 5)
    {
        _itens = new T[capacidadeInicial];
        _proximaPosicao = 0;
    }

    public T GetItemNoIndice(int indice)
    {
        if (indice < 0 || indice >= _proximaPosicao)
        {
            throw new ArgumentOutOfRangeException(nameof(indice));
        }

        return _itens[indice];
    }

    public void Adicionar(T item)
    {
        VerificarCapacidade(_proximaPosicao + 1);

        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

    public void AdicionarVarios(params T[] itens)
    {
        foreach (T item in itens)
        {
            Adicionar(item);
        }
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length >= tamanhoNecessario)
        {
            return;
        }

        int novoTamanho = _itens.Length * 2;

        if (novoTamanho < tamanhoNecessario)
        {
            novoTamanho = tamanhoNecessario;
        }

        var novoArray = new T[novoTamanho];

        for (int indice = 0; indice < _itens.Length; indice++)
        {
            novoArray[indice] = _itens[indice];
        }

        _itens = novoArray;
    }

    public void Remover(T item)
    {
        int indiceItem = -1;

        for (int i = 0; i < _proximaPosicao; i++)
        {
            var itemAtual = _itens[i];

            if (itemAtual.Equals(item))
            {
                indiceItem = i;
                break;
            }
        }

        for (int i = indiceItem; i < _proximaPosicao - 1; i++)
        {
            _itens[i] = _itens[i + 1];
        }

        _proximaPosicao--;
    }

    public void EscreverListaInteira()
    {
        for (int i = 0; i < _proximaPosicao; i++)
        {
            var item = _itens[i];
        }
    }
}