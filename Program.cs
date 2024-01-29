namespace EsercizioLezione1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente = new Dipendente();
            dipendente.Cognome = "Rossi";
            dipendente.Nome = "Giulio";
            dipendente.RuoloRicoperto = "Segretario";
            dipendente.Stipendio = 1400;
            Console.WriteLine(dipendente.ScriviDatiDipendente());

            Atleta atleta = new Atleta();
            atleta.Nome = "Marco";
            atleta.Cognome = "Bianchi";
            atleta.Nazionalità = "Italiano";
            atleta.NrCartelloGara = 29;
            Console.WriteLine(atleta.ScriviDatiAtleta());

            Animale animale = new Animale();
            animale.Razza = "PitBull";
            animale.Nome = "Chloe";
            animale.NrIdentificativo = "2a8649pla";
            Console.WriteLine(animale.ScriviDatiAnimale());

            Veicolo veicolo = new Veicolo();
            veicolo.Marca = "Ferrari";
            veicolo.Modello = "F8 Tributo";
            veicolo.Cavalli = 720;
            Console.WriteLine(veicolo.ScriviDatiVeicolo());
        }
    }

    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string RuoloRicoperto { get; set; }
        public double Stipendio { get; set; }
   
        public string ScriviDatiDipendente()
        {
            return $"Il dipendente {Cognome} {Nome}," + $" ricopre il ruolo di {RuoloRicoperto}" + $" percepisce uno stipendio di {Decimal.Parse(Stipendio.ToString())} euro";
        } 
    }
    public class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazionalità { get; set; }
        public int NrCartelloGara { get; set; }
        public string ScriviDatiAtleta()
        {
            return $"L'atleta {Cognome} {Nome}," + $" di nazionalità {Nazionalità}" + $" gareggia con il numero {NrCartelloGara}";
        }
    }

    

    public class Animale
    {
        public string Razza { get; set; }
        public string Nome { get; set; }
        public string NrIdentificativo { get; set; }

        public string ScriviDatiAnimale()
        {
            return $"L'animale con numero identificativo {NrIdentificativo}," + $" si chiama {Nome}" + $" ed è di razza {Razza}";
        }
    }

    

    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cavalli { get; set; }

        public string ScriviDatiVeicolo()
        {
            return $"Il veicolo {Marca} {Modello}" + $" ha {Cavalli} cavalli";
        }
    }
}
