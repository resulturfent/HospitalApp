namespace HospitalApp.Entity;

internal class Role:BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public override string GetInfo()
    {
        throw new NotImplementedException();
    }
}
