using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isBulmaUygulamasi
{
    public class Models
    {
        public class IlanIdModel
        {
            public int IlanId { get; set; }
        }
        public class BasvuranIdModel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sehir { get; set; }
            public int BasvuranOzgecmisId { get; set; }
        }
        public class FirmaBilgileriModel
        {
            public int FirmaId { get; set; }
            public string FirmaAdi { get; set; }
            public string Sektor { get; set; }
            public int CalisanSayisi { get; set; }
            public string FirmaOzetBilgi { get; set; }
            public int kullaniciId { get; set; }
        }
        public class IlanlarModel
        {
            public int IlanId { get; set; }
            public string Tecrube { get; set; }
            public string Aciklama { get; set; }
            public string IsTanimi { get; set; }
            public string IlanVerilmeTarihi { get; set; }
            public string Sehir { get; set; }
            public int FirmaId { get; set; }
            public string FirmaAdi { get; set; }
        }
        public class OzgecmisModelBolum
        {
            public int OzgecmisId { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sehir { get; set; }
            public string Cinsiyet { get; set; }
            public string DogumTarihi { get; set; }
            public string UniversiteOkulAdi { get; set; }
            public int kullaniciId { get; set; }
        }
        public class OzgecmisModel
        {
            public int OzgecmisId { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Telefon { get; set; }
            public string Sehir { get; set; }
            public string Cinsiyet { get; set; }
            public string DogumTarihi { get; set; }
            public string LiseOkulAdi { get; set; }
            public string LiseBaslangicTarihi { get; set; }
            public string LiseBitisTarihi { get; set; }
            public string UniversiteOkulAdi { get; set; }
            public string UniversiteBaslangicTarihi { get; set; }
            public string UniversiteBitisTarihi { get; set; }
            public string UniversiteBolum { get; set; }
            public string FirmaAdi1 { get; set; }
            public string Firma1GirisTarihi { get; set; }
            public string Firma1CikisTarihi { get; set; }
            public string Firma1IsTipi { get; set; }
            public string FirmaAdi2 { get; set; }
            public string Firma2GirisTarihi { get; set; }
            public string Firma2CikisTarihi { get; set; }
            public string Firma2IsTipi { get; set; }
            public string Hobiler { get; set; }
            public string Ozet { get; set; }
            public string ResimUrl { get; set; }
            public int kullaniciId { get; set; }
            public int OzgecmisHerkeseAcik { get; set; }
            public string AskerlikDurumu { get; set; }
        }
        public class KayitVarMiModel
        {
            public string KullaniciMail { get; set; }
        }
        public class KullaniciModel
        {
            public int KullaniciId { get; set; }
            public string KullaniciMail { get; set; }
            public string KullaniciSifre { get; set; }
            public string KullaniciYetki { get; set; }
        }
        public class KullaniciOzgecmisVarMiModel
        {
            public int OzgecmisId { get; set; }
            public int kullaniciId { get; set; }
        }
        public class BasvurulariListeleModel
        {
            public int IlanId { get; set; }
            public string Aciklama { get; set; }
            public string IlanVerilmeTarihi { get; set; }
        }
        public class MesajlarModel
        {
            public int MesajId { get; set; }
            public string Mesaj { get; set; }
            public string MesajTarihi { get; set; }
            public int GondericiId { get; set; }
            public int AliciId { get; set; }
            public int MesajOkundu { get; set; }
            public string FirmaAdi { get; set; }
        }
        public class GonderilenMesajlarModel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Mesaj { get; set; }
            public string MesajTarihi { get; set; }
            public int MesajId { get; set; }
        }
    }
}
