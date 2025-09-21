namespace HospitalApp.Entity;

internal abstract  class DeleteBaseEntity:BaseEntity
{
    public DateTime DeleteDate { get; set; }
    public int DeleterId { get; set; }

 
}
