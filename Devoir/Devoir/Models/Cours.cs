namespace Dette.Models;

public class Cours
{
    public int Id { get; set; }
    public string libelle { get; set; }

    public int semestre { get; set; }

    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public DateTime HeureDebut { get; set; } = DateTime.Now;
    public DateTime HeureFin { get; set; } = DateTime.Now;
    
    public virtual ICollection<Absence>? absence { get; set; }
    
    public Professeur professeur{ get; set; }
    public int ProfesseurId { get; set; }
    public Module module { get; set; }
    public int ModuleId { get; set; }

    public virtual ICollection<Classe>? Classes { get; set; }
    
}