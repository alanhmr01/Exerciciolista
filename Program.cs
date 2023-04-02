using Exerciciolista;

List<Vendas> vendas = new List<Vendas>();

for (int i = 1; i <= 5; i++)
{
    Vendas venda = new Vendas();
    venda.IdVenda = i;
    venda.DataVenda = DateTime.Now.AddDays(-i);
    venda.Produtos = new List<string>() { "Tulipa", "Gelo", "Cerveja", "Carvão", "Pinga", "Limão", "Picanha", "Linguiça", "Pão de Alho", "Queijo Coalho" };
    vendas.Add(venda);
}

foreach (Vendas venda in vendas)
{
    venda.ImprimirLista();
}