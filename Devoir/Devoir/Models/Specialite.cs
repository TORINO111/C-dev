namespace Dette.Models;

public class Specialite
{
    public int Id { get; set; }
    public string libelle { get; set; }

    public virtual ICollection<Professeur>? Professeurs { get; set; }

}