namespace HospitalApp.Entity;

internal class BaseEntity
{
    public bool IsActive { get; set; }
    public DateTime CreateDate { get; set; }
    public int CreatorId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdaterId { get; set; }
   
}
