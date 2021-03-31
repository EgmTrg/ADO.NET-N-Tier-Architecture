namespace ADO.NET.Entity
{
    public class KitapResim : Table
    {
        public override string PrimaryKey => "resimID";
        public int kitapno { get; set; }
        public byte[] resim { get; set; }
    }
}
