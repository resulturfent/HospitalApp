namespace HospitalApp.Entity;

internal class DeleteBaseEntity:BaseEntity
{
    public DateTime DeleteDate { get; set; }
    public int DeleterId { get; set; }

    public override void DeleteInfo(int deleterId)
    {
        throw new NotImplementedException();
    }
}
