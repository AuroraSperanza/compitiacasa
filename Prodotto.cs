using System.Runtime.CompilerServices;

namespace Esercitazione_Magazzino;

internal class Prodotto


{
    
#region Variabili    
    private string Nome;
    private string Codice;
    private double Prezzo;
#endregion
#region Costruttori
// Costruttore Predefinito
    public Prodotto()
    {
        Nome="Sconosciuto";
        Codice="N/A";
        Prezzo=0.0;
    }
    
    // Costruttore Completo
    public Prodotto(String _Nome, string _Codice, double _Prezzo)
{
    this.Nome = _Nome;
    this.Codice = _Codice;
    this.Prezzo = _Prezzo;
}
    
    // Costruttore Parziale

    public Prodotto(String _Nome, double _Prezzo)
    {
        this.Nome = _Nome;
        this.Prezzo = _Prezzo;
        this.Codice = GeneraCodiceProdotto();
    }
    
#endregion
    
#region Metodi

        //Metodi Pubblici
        public void StampaDettagli()

        {
            Console.WriteLine($"{Nome} {Codice} {Prezzo}" );
        }

        public double ApplicaSconto(double percentualeSconto)

        {
            return (Prezzo * percentualeSconto / 100);
        }

        public double ApplicaSconto()

        {
            return ApplicaSconto(10);
        }
        
        //Metodi Statici

        public static String GeneraCodiceProdotto()
        {
            return "PROD_001";
        }
        
        
        
        
        

        #endregion
        
    






    


        
}

