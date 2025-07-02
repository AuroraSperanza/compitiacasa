namespace Esercitazione_Magazzino;

internal class Magazzino
{
    #region Variabili
    
        Prodotto [] Prodotti;
        private int indiceProssimoProdotto;
        private const int DIMENSIONE_MASSIMA_MAGAZZINO = 20;

    #endregion
    
    #region Costruttori

    private Magazzino()
    {
        Prodotti = new Prodotto [DIMENSIONE_MASSIMA_MAGAZZINO];
        indiceProssimoProdotto = 0;
    }
    #endregion
    
    #region Metodi Pubblico

    public void AggiungiProdotto(Prodotto NuovoProdotto)
    {
        if (Prodotti.Length <= DIMENSIONE_MASSIMA_MAGAZZINO)
        {
            Prodotti[indiceProssimoProdotto] = NuovoProdotto;
            indiceProssimoProdotto++;
        }
    }

    public void AggiungiProdotto(string Nome, String Codice, double Prezzo)
        {
        Prodotto NuovoProdotto = new Prodotto(Nome, Codice, Prezzo);
            
        }




    #endregion


}