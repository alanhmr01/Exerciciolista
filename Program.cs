using Exerciciolista;

List<Vendas> vendas = new List<Vendas>();

for (int i = 1; i <= 5; i++)
{
    Vendas venda = new Vendas();
    venda.IdVenda = i;
    venda.DataVenda = DateTime.Now.AddDays(-i);
    venda.Produtos = new List<string>() { "Produto 1", "Produto 2", "Produto 3", "Produto 4", "Produto 5", "Produto 6", "Produto 7", "Produto 8", "Produto 9", "Produto 10" };
    vendas.Add(venda);
}

foreach (Vendas venda in vendas)
{
    venda.ImprimirLista();
}