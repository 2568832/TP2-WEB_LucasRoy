namespace TP2.Models
{
    public class BaseDeDonnees
    {
        public List<Compagnie> Compagnies { get; set; }
        public List<Carte_Graphique> Carte_Graphiques { get; set; }

        public BaseDeDonnees() 
        { 
            Compagnies = new List<Compagnie>();
            Carte_Graphiques = new List<Carte_Graphique>();

            Compagnies.Add(new Compagnie() {CompagnieID = 1, Nom = "Nvidia" });
            Compagnies.Add(new Compagnie() { CompagnieID = 2, Nom = "AMD" });
            Compagnies.Add(new Compagnie() { CompagnieID = 3, Nom = "Intel" });

            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 1, Vedette = false, Nom = "RTX 5090", Model = "TUF-RTX5090-32G-GAMING", Prix = "4,329.99 $", PerformanceAI = "3352 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "470W-575W", Mémoire_vidéo = "32GB GDDR7", InfoIA = "L'un des principaux atouts des cartes graphiques haut de gamme NVIDIA GeForce RTX™ 5090 réside sans conteste dans leurs performances en intelligence artificielle . Avec 32 Go de GDDR7, 21 760 cœurs CUDA et les dernières innovations RTX, ces cartes offrent une puissance de calcul impressionnante de 3 352 TOPs en IA.", Description = "La NVIDIA GeForce RTX 5090 (architecture Blackwell, 2025) est la nouvelle référence absolue en ultra haut de gamme. Elle offre des performances en rastérisation 35 % supérieures à la 4090 et +40% en 3D/rendu, propulsée par 32 Go de mémoire GDDR7. Conçue pour le 4K/8K, elle consomme cependant énormément (jusqu'à 600W)" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 2, Vedette = false, Nom = "RTX 5080", Model = "GeForce-RTX5080-O16G", Prix = "2,399.99 $", PerformanceAI = "1802.9 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "360W-400W", Mémoire_vidéo = "16GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 3, Vedette = false, Nom = "RTX 5070", Model = "MSI-GeForce-RTX5070-12G-GAMING", Prix = "1,492.19 $", PerformanceAI = "987 TOPs", RésolutionPriorisé = "1440p", ConsomationMaxEn_Watt = "250W-300W", Mémoire_vidéo = "12GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 4, Vedette = false, Nom = "RTX 5060", Model = "GeForce-RTX5060-8G-VENTUS-2X-OC", Prix = "489.99 $", PerformanceAI = "757.9 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "128W-161W", Mémoire_vidéo = "8GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 5, Vedette = false, Nom = "RTX 4090", Model = "ROG_Strix-GeForce-RTX4090-24G-OC", Prix = "6,951.76 $", PerformanceAI = "1321.2 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "450W-500W", Mémoire_vidéo = "24GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 6, Vedette = false, Nom = "RTX 4080", Model = "ROG_Strix-GeForce-RTX4080-16G-OC", Prix = "2, 509.99 $", PerformanceAI = "779.8 TOPs", RésolutionPriorisé = "1440p / 4K", ConsomationMaxEn_Watt = "320W-400W", Mémoire_vidéo = "16GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 7, Vedette = false, Nom = "RTX 4070", Model = "ROG_Strix-GeForce-RTX4070-12G-OC", Prix = "1,791.99 $", PerformanceAI = "466.3 TOPs", RésolutionPriorisé = "1440p", ConsomationMaxEn_Watt = "180W-180W", Mémoire_vidéo = "12GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 8, Vedette = false, Nom = "RTX 4060", Model = "ROG_Strix-GeForce-RTX4060-8G-OC", Prix = "799.99 $", PerformanceAI = "241.8 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "115W-150W", Mémoire_vidéo = "8GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 2, ID = 9, Vedette = false, Nom = "RX 9070", Model = "RX 9070 RADEON", Prix = "749.99 $", PerformanceAI = "300-350 TOPs", RésolutionPriorisé = "1440p / 4K", ConsomationMaxEn_Watt = "220W-240W", Mémoire_vidéo = "16GB GDDR6", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 2, ID = 10, Vedette = false, Nom = "RX 9060", Model = "RX 9060 RADEON", Prix = "379.99 $", PerformanceAI = "120-150 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "132W-150W", Mémoire_vidéo = "8GB GDDR6", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 3, ID = 11, Vedette = false, Nom = "Intel Arc B580", Model = "", Prix = "", PerformanceAI = "", RésolutionPriorisé = "", ConsomationMaxEn_Watt = "", Mémoire_vidéo = "", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 3, ID = 12, Vedette = false, Nom = "Intel Arc A770", Model = "", Prix = "", PerformanceAI = "", RésolutionPriorisé = "", ConsomationMaxEn_Watt = "", Mémoire_vidéo = "", InfoIA = "", Description = "" });
            
            // Lier les ojet enfants aux parents

            foreach (var C in Compagnies)
            {
                C.Cartes_Graphiques = new List<Carte_Graphique>();
                C.Cartes_Graphiques.AddRange(Carte_Graphiques.Where(c => c.CompagnieID == C.CompagnieID));
            }

            //  Lier le objet parents (Compagnie) aux enfant (Cartes graphique)

            foreach (var c in Carte_Graphiques)
            {
                c.compagnie = Compagnies.Where(C => C.CompagnieID == c.CompagnieID).Single();
            }




        }

    }
}
