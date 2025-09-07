namespace HospitalApp.Entity;

internal class BaseEntity
{
    public bool IsActive { get; set; }
    public DateTime CreateDate { get; set; }
    public int CreatorId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdaterId { get; set; }

    public virtual string CreaterInfo(params string[] param)
    {
        IsActive = true;
        CreateDate = DateTime.Now;
        CreatorId = Convert.ToInt32(param[0]);
        return CreatorId+"-" +IsActive+"-"+CreateDate;
    }


    public virtual void UpdaterInfo(int updaterId)
    {
        UpdateDate = DateTime.Now;
        UpdaterId = updaterId;
    }

}
