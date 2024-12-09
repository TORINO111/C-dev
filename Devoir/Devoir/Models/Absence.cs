namespace Dette.Models;

public class Absence
{
    public int Id { get; set; }
    public Etudiant etudiant { get; set; }
    public int EtudiantId { get; set; }

    public Cours cours { get; set; }
    public int CoursId { get; set; }
}