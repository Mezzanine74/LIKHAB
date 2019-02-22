namespace LIKHAB.DataLayer.Interface
{
    public interface IKoyMahalle
    {
        int Ilce { get; set; } // Ilce
        string KoyMahalle_ { get; set; } // Koy_Mahalle (length: 100)
        decimal YolKilometre { get; set; } // YolKilometre        
    }
}