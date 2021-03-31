namespace ADO.NET.Entity
{
    public class Kitap : Table
    {
        public override string PrimaryKey => "kitapno";
        public int kitapno { get; set; }
        public string ad { get; set; }
        public int sayfasayisi { get; set; }
        public int puan { get; set; }
        public int yazarno { get; set; }
        public int turno { get; set; }
        public int resimno { get; set; }
    }
}
