namespace Dette.Models;
public class Etudiant:Utilisateur{
    public virtual ICollection<Absence>? Absences { get; set; }

    public Classe classe { get; set; }
    public int ClasseId { get; set; }

}
