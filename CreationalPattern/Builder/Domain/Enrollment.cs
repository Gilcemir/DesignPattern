namespace Builder.Domain;

public class Enrollment
{
    public Guid Id { get; init; }
    
    public Person Responsable { get; set; }
    
    public Person person { get; init; }

    public HashSet<Modality> Modalities { get; set; }

    public int Year { get; set; }

    public string AccessCode { get; set; }
}