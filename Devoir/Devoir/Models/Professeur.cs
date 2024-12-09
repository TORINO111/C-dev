namespace Dette.Models;

public class Professeur{

    public Grade grade { get; set; }
    public int GradeId { get; set; }

    public Specialite specialite { get; set; }
    public int SpecialiteId { get; set; }

    public virtual ICollection<Cours>? Cours { get; set; }

}