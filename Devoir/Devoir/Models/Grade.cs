namespace Dette.Models;

public class Grade{

    public int Id { get; set; }
    public string libelle { get; set; }

    public virtual ICollection<Professeur>? Professeurs { get; set; }

}