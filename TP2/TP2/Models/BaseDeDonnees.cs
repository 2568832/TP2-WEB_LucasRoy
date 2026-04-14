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

            Compagnies.Add(new Compagnie() {CompagnieID = 1, Nom = "Nvidia", imgURL = "/Images/[CITYPNG.COM]Nvidia Gaming White Logo Image PNG - 2400x2400.png", Description = "Nvidia, fondée en 1993, est un leader mondial des technologies graphiques et de l’intelligence artificielle, reconnu pour ses GPU innovants et son rôle clé dans l’essor du calcul haute performance." });
            Compagnies.Add(new Compagnie() { CompagnieID = 2, Nom = "AMD", imgURL = "/Images/amd-header-logo.svg", Description = "AMD est une entreprise américaine de semi‑conducteurs, fondée en 1969, spécialisée dans les processeurs Ryzen, les cartes graphiques Radeon et les solutions pour centres de données, IA et jeux." });
            Compagnies.Add(new Compagnie() { CompagnieID = 3, Nom = "INTEL", imgURL = "/Images/Intel_Arc_logo_(black).png", Description = "Intel est une entreprise américaine fondée en 1968, pionnière des microprocesseurs et acteur majeur des semi‑conducteurs. Elle développe des technologies pour PC, centres de données, IA et solutions réseau." });

            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 1, imgURL = "/Images/NVIDIA_CARTES/5090.png", Vedette = true, Nom = "RTX 5090", Model = "TUF-RTX5090-32G-GAMING", Prix = 4329.99 , PerformanceAI = "3352 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "470W-575W", Mémoire_vidéo = "32GB GDDR7", InfoIA = "L'un des principaux atouts des cartes graphiques haut de gamme NVIDIA GeForce RTX™ 5090 réside sans conteste dans leurs performances en intelligence artificielle . Avec 32 Go de GDDR7, 21 760 cœurs CUDA et les dernières innovations RTX, ces cartes offrent une puissance de calcul impressionnante de 3 352 TOPs en IA.", Description = "La NVIDIA GeForce RTX 5090 (architecture Blackwell, 2025) est la nouvelle référence absolue en ultra haut de gamme. Elle offre des performances en rastérisation 35 % supérieures à la 4090 et +40% en 3D/rendu, propulsée par 32 Go de mémoire GDDR7. Conçue pour le 4K/8K, elle consomme cependant énormément (jusqu'à 600W)" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 2, imgURL = "/Images/NVIDIA_CARTES/5080.webp", Vedette = false, Nom = "RTX 5080", Model = "GeForce-RTX5080-O16G", Prix = 2399.99 , PerformanceAI = "1802.9 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "360W-400W", Mémoire_vidéo = "16GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 3, imgURL = "/Images/NVIDIA_CARTES/5070.png", Vedette = false, Nom = "RTX 5070", Model = "MSI-GeForce-RTX5070-12G-GAMING", Prix = 1492.19, PerformanceAI = "987 TOPs", RésolutionPriorisé = "1440p", ConsomationMaxEn_Watt = "250W-300W", Mémoire_vidéo = "12GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 4, imgURL = "/Images/NVIDIA_CARTES/5060.webp", Vedette = false, Nom = "RTX 5060", Model = "GeForce-RTX5060-8G-VENTUS-2X-OC", Prix = 489.99 , PerformanceAI = "757.9 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "128W-161W", Mémoire_vidéo = "8GB GDDR7", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 5, imgURL = "/Images/NVIDIA_CARTES/4090.webp", Vedette = true, Nom = "RTX 4090", Model = "ROG_Strix-GeForce-RTX4090-24G-OC", Prix = 6951.76, PerformanceAI = "1321.2 TOPs", RésolutionPriorisé = "4K", ConsomationMaxEn_Watt = "450W-500W", Mémoire_vidéo = "24GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 6, imgURL = "/Images/NVIDIA_CARTES/4080.webp", Vedette = false, Nom = "RTX 4080", Model = "ROG_Strix-GeForce-RTX4080-16G-OC", Prix = 2509.99, PerformanceAI = "779.8 TOPs", RésolutionPriorisé = "1440p / 4K", ConsomationMaxEn_Watt = "320W-400W", Mémoire_vidéo = "16GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 7, imgURL = "/Images/NVIDIA_CARTES/4070.webp", Vedette = false, Nom = "RTX 4070", Model = "ROG_Strix-GeForce-RTX4070-12G-OC", Prix = 1791.99, PerformanceAI = "466.3 TOPs", RésolutionPriorisé = "1440p", ConsomationMaxEn_Watt = "180W-180W", Mémoire_vidéo = "12GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 1, ID = 8, imgURL = "/Images/NVIDIA_CARTES/4060.webp", Vedette = false, Nom = "RTX 4060", Model = "ROG_Strix-GeForce-RTX4060-8G-OC", Prix = 799.99, PerformanceAI = "241.8 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "115W-150W", Mémoire_vidéo = "8GB GDDR6X", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 2, ID = 9, imgURL = "/Images/NVIDIA_CARTES/Rx9070.webp", Vedette = false, Nom = "RX 9070", Model = "RX 9070 RADEON", Prix = 749.99, PerformanceAI = "300-350 TOPs", RésolutionPriorisé = "1440p / 4K", ConsomationMaxEn_Watt = "220W-240W", Mémoire_vidéo = "16GB GDDR6", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 2, ID = 10, imgURL = "/Images/NVIDIA_CARTES/Rx9060.png", Vedette = false, Nom = "RX 9060", Model = "RX 9060 RADEON", Prix = 379.99, PerformanceAI = "120-150 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "132W-150W", Mémoire_vidéo = "8GB GDDR6", InfoIA = "", Description = "" });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 3, ID = 11, imgURL = "/Images/NVIDIA_CARTES/B580.webp", Vedette = false, Nom = "B580", Model = "Intel Arc B580", Prix = 249.99, PerformanceAI = "90-110 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "150W-180W", Mémoire_vidéo = "8GB GDDR6", InfoIA = "Compatible avec XeSS pour améliorer les performances en 1080p.", Description = "Une carte graphique entrée/milieu de gamme idéale pour le 1080p avec un excellent rapport qualité‑prix." });
            Carte_Graphiques.Add(new Carte_Graphique() { CompagnieID = 3, ID = 12, imgURL = "/Images/NVIDIA_CARTES/A770.png", Vedette = false, Nom = "A770", Model = "Intel Arc A770", Prix = 449.99, PerformanceAI = "130 TOPs", RésolutionPriorisé = "1080p", ConsomationMaxEn_Watt = "225W", Mémoire_vidéo = "16GB GDDR6", InfoIA = "Compatible avec XeSS, l’upscaling IA d’Intel.", Description = "Une carte performante pour le 1440p, offrant un excellent rapport performance/prix et un support logiciel en constante amélioration." });
            
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
 