namespace Dette.Models;

public class Classe
{
    public int Id { get; set; }
    public string libelle { get; set; }

    public Filiere filiere { get; set; }
    public int FiliereId { get; set; }


    public virtual ICollection<Cours>? Cours { get; set; }

}