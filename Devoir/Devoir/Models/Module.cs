namespace Dette.Models;

public class Module
{
    public int Id { get; set; }
    public string libelle { get; set; }


    public virtual ICollection<Cours>? Cours { get; set; }

}