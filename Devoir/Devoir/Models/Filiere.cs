namespace Dette.Models;

public class Filiere
{

    public int Id { get; set; }
    public string libelle { get; set; }

    public virtual ICollection<Classe>? Classes { get; set; }

}