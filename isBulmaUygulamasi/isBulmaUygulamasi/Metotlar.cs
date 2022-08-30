using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using static isBulmaUygulamasi.Models;

namespace isBulmaUygulamasi
{
    public class Metotlar
    {
        public List<KullaniciModel> kullaniciBilgileriDogruMu;
        public List<KullaniciModel> kullaniciBilgileri;
        public List<KayitVarMiModel> kayitVarMi;
        public List<KullaniciOzgecmisVarMiModel> ozGecmisDoluMu;
        public List<OzgecmisModel> ozGecmis;
        public List<OzgecmisModelBolum> ozgecmisModelBolum;
        public List<OzgecmisModelBolum> ozgecmisModelAnahtarKelime;
        public List<IlanlarModel> ilanlarModel;
        public List<OzgecmisModelBolum> basvurulariListeleme = new List<OzgecmisModelBolum>();
        public List<IlanlarModel> tumIlanlar;
        public List<BasvurulariListeleModel> basvurular = new List<BasvurulariListeleModel>();
        public List<IlanIdModel> basvurulanIlanIdleri;
        public List<BasvuranIdModel> basvuranOzgecmisListesi;
        public Form activeForm;
        public List<MesajlarModel> mesajlar;
        public List<FirmaBilgileriModel> firmaBilgileri;
        public int ToplamKullaniciSayisi;
        public int ToplamIlanSayisi;
        public int ToplamBasvuruSayisi;
        public List<GonderilenMesajlarModel> gonderilenMesajlar;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public string Sorgu;

        #region Select Sorguları
        public Boolean KullaniciBilgileriDogruMu(string Mail, string Sifre)   // GİRİŞ FORMUNDA KULLANICI BİLGİLERİNİ KONTROL EDEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    kullaniciBilgileriDogruMu = conn.Query<KullaniciModel>("select * from Tbl_Kullanicilar where KullaniciMail=@kullaniciMail and KullaniciSifre=@kullaniciSifre",
                        new { @kullaniciMail = Mail, @kullaniciSifre = Sifre }).ToList();
                    if (kullaniciBilgileriDogruMu.Count > 0)
                    {
                        if (Mail == kullaniciBilgileriDogruMu[0].KullaniciMail && Sifre == kullaniciBilgileriDogruMu[0].KullaniciSifre)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                return false;
            }
        }
        public Boolean FirmaBilgileriDoluMu(int KullaniciId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var doluMu = conn.ExecuteScalar<int>("select FirmaId from Tbl_FirmaBilgileri where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId
                        });
                    if (doluMu > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void FirmaBilgileriDoldur(int kullaniciId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    firmaBilgileri = conn.Query<FirmaBilgileriModel>("select * from Tbl_FirmaBilgileri where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = kullaniciId
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void KullaniciBilgileriNe(int KullaniciId)   // ID PARAMETRESİ ALAN VE ID'YE AİT BİLGİLERİ LİSTELEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    kullaniciBilgileri = conn.Query<KullaniciModel>("select * from Tbl_Kullanicilar where KullaniciId=@kullaniciId",
                        new { @kullaniciId = KullaniciId }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                MessageBox.Show("Hata : ", ex.Message);
            }
        }
        public string KullaniciMailDondur(int OzgecmisId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var Mail = conn.ExecuteScalar<string>("select KullaniciMail from Tbl_Kullanicilar K inner join Tbl_Ozgecmisler O on K.KullaniciId=O.kullaniciId where O.OzgecmisId=@ozgecmisId",
                        new
                        {
                            @ozgecmisId = OzgecmisId
                        });
                    return Mail;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public int KullaniciIdDondur(int OzgecmisId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var Id = conn.ExecuteScalar<int>("select kullaniciId from Tbl_Ozgecmisler where OzgecmisId=@ozgecmisId",
                        new
                        {
                            @ozgecmisId = OzgecmisId
                        });
                    return Id;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public int OzgecmisIdDondur(int KullaniciId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var ozGecmisId = conn.ExecuteScalar<int>("select OzgecmisId from Tbl_Ozgecmisler where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId
                        });
                    return ozGecmisId;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }

        public Boolean KayitVarMi(string Mail)  // GİRİLEN MAİL İLE VERİTABANINDA KAYIT VAR MI SONUCUNU DÖNDÜREN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    kayitVarMi = conn.Query<KayitVarMiModel>("select * from Tbl_Kullanicilar where KullaniciMail=@p1", new { p1 = Mail }).ToList();
                    if (kayitVarMi.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                return false;
            }
        }
        public Boolean OzgecmisDoluMu(int KullaniciId) // ID'YE AİT DAHA ÖNCE OLUŞTURULMUŞ ÖZGEÇMİŞ BİLGİLERİ VAR MI SONUCUNU DÖNDÜREN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ozGecmisDoluMu = conn.Query<KullaniciOzgecmisVarMiModel>("select * from Tbl_Ozgecmisler where kullaniciId=@kullaniciId", new { @kullaniciId = KullaniciId }).ToList();
                }
                if (ozGecmisDoluMu.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void OzgecmisBilgileri(int KullaniciId_) // KULLANICI ID'SİNE AİT ÖZGEÇMİŞ BİLGİLERİNİ LİSTELEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ozGecmis = conn.Query<OzgecmisModel>("select * from Tbl_Ozgecmisler where kullaniciId=@KullaniciId", new { @KullaniciId = KullaniciId_ }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void GridDoldurBolum(string Bolum)  // GİRİLEN BÖLÜM'E AİT LİSTELENEBİLİR ÖZGEÇMİŞLERİ LİSTELEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ozgecmisModelBolum = conn.Query<OzgecmisModelBolum>("select OzgecmisId,Ad,Soyad,Sehir,Cinsiyet,DogumTarihi,UniversiteOkulAdi,kullaniciId from Tbl_Ozgecmisler where UniversiteBolum=@universiteBolum and OzgecmisHerkeseAcik='1'",
                        new { @universiteBolum = Bolum }).ToList();
                    if (ozgecmisModelBolum.Count == 0)
                    {
                        MessageBox.Show("Sonuç bulunamadı.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void BasvurulariListele(List<BasvuranIdModel> basvuranIdler_)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ozgecmisModelBolum = conn.Query<OzgecmisModelBolum>("select OzgecmisId,Ad,Soyad,Sehir,Cinsiyet,DogumTarihi,UniversiteOkulAdi,kullaniciId from Tbl_Ozgecmisler ").ToList();
                }
                foreach (var item in ozgecmisModelBolum)
                {
                    foreach (var item2 in basvuranIdler_)
                    {
                        if ((item.kullaniciId) == item2.BasvuranOzgecmisId)
                        {
                            basvurulariListeleme.Add(item);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void GridDoldurAnahtarKelime(string AnahtarKelime) // GİRİLEN ANAHTAR KELİME İLE ARAMA YAPIP ÖZGEÇMİŞLERİ LİSTELEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ozgecmisModelAnahtarKelime = conn.Query<OzgecmisModelBolum>("select * from Tbl_Ozgecmisler Where Ozet Like '%'+@anahtarKelime+'%' and OzgecmisHerkeseAcik = 1 ", new { @anahtarKelime = AnahtarKelime }).ToList();
                    if (ozgecmisModelAnahtarKelime.Count == 0)
                    {
                        MessageBox.Show("Sonuç bulunamadı.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void IlanlariListele(string IsTanimi, string Sehir, string Tecrube)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    if (Sehir == "Tüm Şehirler")
                    {
                        tumIlanlar = conn.Query<IlanlarModel>("select F.FirmaAdi,I.IlanId,I.Tecrube,I.Aciklama,I.IlanVerilmeTarihi,I.FirmaId, I.IsTanimi,I.Sehir" +
                            " from Tbl_FirmaBilgileri F inner join Tbl_Ilanlar I On F.FirmaId=I.FirmaId where Tecrube=@tecrube and IsTanimi=@isTanimi and IlanDurumuGuncel=1",
                       new { @tecrube = Tecrube, @isTanimi = IsTanimi }).ToList();
                    }
                    else
                    {
                        tumIlanlar = conn.Query<IlanlarModel>("select F.FirmaAdi,I.IlanId,I.Tecrube,I.Aciklama,I.IlanVerilmeTarihi,I.FirmaId, I.IsTanimi,I.Sehir" +
                            " from Tbl_FirmaBilgileri F inner join Tbl_Ilanlar I On F.FirmaId=I.FirmaId where Tecrube=@tecrube and Sehir=@sehir and IsTanimi=@isTanimi and IlanDurumuGuncel=1",
                       new { @tecrube = Tecrube, @isTanimi = IsTanimi, @sehir = Sehir }).ToList();
                    }
                    if (tumIlanlar.Count == 0)
                    {
                        MessageBox.Show("Sonuç bulunamadı.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void IlanDetaylarıDoldur(int IlanId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    tumIlanlar = conn.Query<IlanlarModel>("select F.FirmaAdi,I.IlanId,I.Tecrube,I.Aciklama,I.IlanVerilmeTarihi,I.FirmaId, I.IsTanimi,I.Sehir" +
                            " from Tbl_FirmaBilgileri F inner join Tbl_Ilanlar I On F.FirmaId=I.FirmaId where IlanId=@ilanId and IlanDurumuGuncel=1",
                       new { @ilanId = IlanId }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void GridDoldurIlanlar(int FirmaId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ilanlarModel = conn.Query<IlanlarModel>("select IlanId,Tecrube,Aciklama,IlanVerilmeTarihi,IsTanimi from Tbl_Ilanlar Where FirmaId=@firmaId and IlanDurumuGuncel=1", new { @firmaId = FirmaId }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void BasvurulariListele(int KullaniciId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var ozGecmisId = conn.ExecuteScalar<int>("select OzgecmisId from Tbl_Ozgecmisler where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId
                        });
                    basvurulanIlanIdleri = conn.Query<IlanIdModel>("select IlanId from Tbl_Basvurular Where BasvuranOzgecmisId=@basvuranId and BasvuruGuncel=1",
                        new
                        {
                            @basvuranId = ozGecmisId
                        }).ToList();
                    if (basvurulanIlanIdleri.Count != 0)
                    {
                        for (int i = 0; i < basvurulanIlanIdleri.Count; i++)
                        {
                            var item = conn.Query<BasvurulariListeleModel>("select IlanId,Aciklama,IlanVerilmeTarihi from Tbl_Ilanlar where IlanId=@ilanId and IlanDurumuGuncel=1",
                                new
                                {
                                    @ilanId = basvurulanIlanIdleri[i].IlanId
                                }).First();
                            basvurular.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void BasvuranlariListele(int IlanId) // PARAMETRE OLARAK İLAN ID'Sİ ALAN VE İLANA GELEN BAŞVURULARI LİSTELEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    basvuranOzgecmisListesi = conn.Query<BasvuranIdModel>("select Tbl_Ozgecmisler.Ad,Tbl_Ozgecmisler.Soyad,Tbl_Ozgecmisler.Sehir," +
                        "Tbl_Basvurular.BasvuranOzgecmisId from Tbl_Ozgecmisler " +
                        "INNER JOIN Tbl_Basvurular  ON Tbl_Ozgecmisler.OzgecmisId = Tbl_Basvurular.BasvuranOzgecmisId where Tbl_Basvurular.IlanId=@ilanId and " +
                        "Tbl_Basvurular.BasvuruGuncel=1",
                        new
                        {
                            @ilanId = IlanId
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public string KullaniciFotografiVarsaUrlDondur(int KullaniciId_)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var resimUrl = conn.ExecuteScalar<string>("select ResimUrl from Tbl_Ozgecmisler where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId_
                        });
                    if (resimUrl != "")
                    {
                        return resimUrl;
                    }
                    else
                        return "";
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void TumMesajlar(int kullaniciId, int MesajOkundu)
        {
            try
            {
                if (MesajOkundu == 0)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        var ozGecmisId = conn.ExecuteScalar<int>("select OzgecmisId from Tbl_Ozgecmisler where kullaniciId=@KullaniciId",
                            new
                            {
                                @KullaniciId = kullaniciId
                            });
                        mesajlar = conn.Query<MesajlarModel>("select F.FirmaAdi,M.MesajId,M.Mesaj," +
                            "M.MesajTarihi,M.GondericiId,M.AliciId,M.MesajOkundu from Tbl_FirmaBilgileri F inner join Tbl_Mesajlar M " +
                            "On F.FirmaId=M.GondericiId where AliciId=@aliciId and MesajOkundu=0",
                            new
                            {
                                @aliciId = ozGecmisId
                            }).ToList();
                    }
                }
                else if (MesajOkundu == 1)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        var ozGecmisId = conn.ExecuteScalar<int>("select OzgecmisId from Tbl_Ozgecmisler where kullaniciId=@KullaniciId",
                            new
                            {
                                @KullaniciId = kullaniciId
                            });
                        mesajlar = conn.Query<MesajlarModel>("select F.FirmaAdi,M.MesajId,M.Mesaj," +
                           "M.MesajTarihi,M.GondericiId,M.AliciId,M.MesajOkundu from Tbl_FirmaBilgileri F inner join Tbl_Mesajlar M " +
                           "On F.FirmaId=M.GondericiId where AliciId=@aliciId and MesajOkundu=1",
                           new
                           {
                               @aliciId = ozGecmisId
                           }).ToList();
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        var firmaId = conn.ExecuteScalar<int>("select FirmaId from Tbl_FirmaBilgileri where kullaniciId=@KullaniciId",
                            new
                            {
                                @KullaniciId = kullaniciId
                            });
                        mesajlar = conn.Query<MesajlarModel>("select * from Tbl_Mesajlar where GondericiId=@gondericiId",
                            new
                            {
                                @gondericiId = firmaId
                            }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void SeciliMesajıGoster(int MesajId, int MesajOkundu) // SEÇİLEN MESAJI DETAYLARINI LİSTELEYEN VE YENİ MESAJ İSE MesajOkundu ALANINI 1 OLARAK GÜNCELLEYEN METOT
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    mesajlar = conn.Query<MesajlarModel>("select * from Tbl_Mesajlar where MesajId=@mesajId",
                        new
                        {
                            @mesajId = MesajId
                        }).ToList();
                    if (MesajOkundu == 0)
                    {
                        conn.Execute("update Tbl_Mesajlar set MesajOkundu=1 where MesajId=@mesajId",
                            new
                            {
                                @mesajId = MesajId
                            });
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public string GonderilenMesajDetayı(int MesajId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    mesajlar = conn.Query<MesajlarModel>("select * from Tbl_Mesajlar where MesajId=@mesajId",
                        new
                        {
                            @mesajId = MesajId
                        }).ToList();
                    var ad = conn.ExecuteScalar<string>("select Ad from Tbl_Ozgecmisler where kullaniciId=@KullaniciId", new { @KullaniciId = mesajlar[0].AliciId });
                    var soyad = conn.ExecuteScalar<string>("select Soyad from Tbl_Ozgecmisler where kullaniciId=@KullaniciId", new { @KullaniciId = mesajlar[0].AliciId });
                    return (ad + " " + soyad);
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void GonderilenMesajlariListele(int MesajId, int KullaniciId) // ALDIĞI FİRMA KULLANICI ID'SİNE AİT GÖNDERİLMİŞ MESAJLARI LİSTELEYEN METOT
        {
            try
            {
                if (MesajId != 0)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        gonderilenMesajlar = conn.Query<GonderilenMesajlarModel>("select O.Ad, O.Soyad, M.Mesaj,M.MesajTarihi,M.MesajId from Tbl_Mesajlar as M inner join Tbl_Ozgecmisler as O on M.AliciId = O.OzgecmisId where M.MesajId=@mesajId", new { @mesajId = MesajId }).ToList();
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        var FirmaId = FirmaIdDondur(KullaniciId);
                        gonderilenMesajlar = conn.Query<GonderilenMesajlarModel>("select O.Ad, O.Soyad, M.Mesaj,M.MesajTarihi,M.MesajId from Tbl_Mesajlar as M inner join Tbl_Ozgecmisler as O on M.AliciId = O.OzgecmisId where M.GondericiId=@gondericiId", new { @gondericiId = FirmaId }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public int FirmaIdDondur(int KullaniciId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var FirmaId = conn.ExecuteScalar<int>("select FirmaId from Tbl_FirmaBilgileri where kullaniciId=@KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId
                        });
                    return FirmaId;
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void AnaMenuToplamSayilar()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    ToplamKullaniciSayisi = conn.ExecuteScalar<int>("select COUNT(*) from Tbl_Kullanicilar");
                    ToplamIlanSayisi = conn.ExecuteScalar<int>("select COUNT(*) from Tbl_Ilanlar");
                    ToplamBasvuruSayisi = conn.ExecuteScalar<int>("select COUNT(*) from Tbl_Basvurular");
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        #endregion


        #region Insert-Update-Delete Sorguları
        // ADO.NET
        public void Kayit(string Mail, string Sifre, string Yetki)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "insert into Tbl_Kullanicilar(KullaniciMail,KullaniciSifre,KullaniciYetki) values (@KullaniciMail,@KullaniciSifre,@KullaniciYetki)";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@KullaniciMail", Mail);
                    cmd.Parameters.AddWithValue("@KullaniciSifre", Sifre);
                    cmd.Parameters.AddWithValue("@KullaniciYetki", Yetki);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Kayıt Başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                MessageBox.Show("Hata : ", ex.Message);
            }
        }
        // ADO.NET
        public void OzgecmisYeniKayit(string Ad, string Soyad, string Telefon, string Sehir, string Cinsiyet, string DogumTarihi, string LiseOkulAdi, string LiseBaslangicTarihi, string LiseBitisTarihi,
            string UniversiteOkulAdi, string UniversiteBaslangicTarihi, string UniversiteBitisTarihi, string UniversiteBolum, string FirmaAdi1, string Firma1GirisTarihi,
            string Firma1CikisTarihi, string Firma1IsTipi, string FirmaAdi2, string Firma2GirisTarihi, string Firma2CikisTarihi, string Firma2IsTipi, string Hobiler,
            string Ozet, string ResimUrl, int KullaniciId, int OzgecmisHerkeseAcik, string AskerlikDurumu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "insert into Tbl_Ozgecmisler(Ad,Soyad,Telefon,Sehir,Cinsiyet,DogumTarihi,LiseOkulAdi,LiseBaslangicTarihi,LiseBitisTarihi," +
                        "UniversiteOkulAdi,UniversiteBaslangicTarihi,UniversiteBitisTarihi,UniversiteBolum,FirmaAdi1,Firma1GirisTarihi,Firma1CikisTarihi," +
                        "Firma1IsTipi,FirmaAdi2,Firma2GirisTarihi,Firma2CikisTarihi,Firma2IsTipi,Hobiler,Ozet,ResimUrl,kullaniciId,OzgecmisHerkeseAcik,AskerlikDurumu) values(@ad,@soyad,@telefon," +
                        "@sehir,@cinsiyet,@dogumTarihi,@liseOkulAdi,@liseBaslangicTarihi,@liseBitisTarihi,@universiteOkulAdi,@universiteBaslangicTarihi," +
                        "@universiteBitisTarihi,@universiteBolum,@firmaAdi1,@firma1GirisTarihi,@firma1CikisTarihi,@firma1IsTipi,@firmaAdi2,@firma2GirisTarihi," +
                        "@firma2CikisTarihi,@firma2IsTipi,@hobiler,@ozet,@resimUrl,@KullaniciId,@ozgecmisHerkeseAcik,@askerlikDurumu)";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@ad", Ad);
                    cmd.Parameters.AddWithValue("@soyad", Soyad);
                    cmd.Parameters.AddWithValue("@telefon", Telefon);
                    cmd.Parameters.AddWithValue("@sehir", Sehir);
                    cmd.Parameters.AddWithValue("@cinsiyet", Cinsiyet);
                    cmd.Parameters.AddWithValue("@dogumTarihi", DogumTarihi);
                    cmd.Parameters.AddWithValue("@liseOkulAdi", LiseOkulAdi);
                    cmd.Parameters.AddWithValue("@liseBaslangicTarihi", LiseBaslangicTarihi);
                    cmd.Parameters.AddWithValue("@liseBitisTarihi", LiseBitisTarihi);
                    cmd.Parameters.AddWithValue("@universiteOkulAdi", UniversiteOkulAdi);
                    cmd.Parameters.AddWithValue("@universiteBaslangicTarihi", UniversiteBaslangicTarihi);
                    cmd.Parameters.AddWithValue("@universiteBitisTarihi", UniversiteBitisTarihi);
                    cmd.Parameters.AddWithValue("@universiteBolum", UniversiteBolum);
                    cmd.Parameters.AddWithValue("@firmaAdi1", FirmaAdi1);
                    cmd.Parameters.AddWithValue("@firma1GirisTarihi", Firma1GirisTarihi);
                    cmd.Parameters.AddWithValue("@firma1CikisTarihi", Firma1CikisTarihi);
                    cmd.Parameters.AddWithValue("@firma1IsTipi", Firma1IsTipi);
                    cmd.Parameters.AddWithValue("@firmaAdi2", FirmaAdi2);
                    cmd.Parameters.AddWithValue("@firma2GirisTarihi", Firma2GirisTarihi);
                    cmd.Parameters.AddWithValue("@firma2CikisTarihi", Firma2CikisTarihi);
                    cmd.Parameters.AddWithValue("@firma2IsTipi", Firma2IsTipi);
                    cmd.Parameters.AddWithValue("@hobiler", Hobiler);
                    cmd.Parameters.AddWithValue("@ozet", Ozet);
                    cmd.Parameters.AddWithValue("@resimUrl", ResimUrl);
                    cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                    cmd.Parameters.AddWithValue("@ozgecmisHerkeseAcik", OzgecmisHerkeseAcik);
                    cmd.Parameters.AddWithValue("@askerlikDurumu", AskerlikDurumu);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Özgeçmişiniz başarıyla kaydedildi.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        // ADO.NET
        public void OzgecmisGuncelleme(string Ad, string Soyad, string Telefon, string Sehir, string Cinsiyet, string DogumTarihi, string LiseOkulAdi, string LiseBaslangicTarihi, string LiseBitisTarihi,
            string UniversiteOkulAdi, string UniversiteBaslangicTarihi, string UniversiteBitisTarihi, string UniversiteBolum, string FirmaAdi1, string Firma1GirisTarihi,
            string Firma1CikisTarihi, string Firma1IsTipi, string FirmaAdi2, string Firma2GirisTarihi, string Firma2CikisTarihi, string Firma2IsTipi, string Hobiler,
            string Ozet, string ResimUrl, int KullaniciId, int OzgecmisHerkeseAcik, string AskerlikDurumu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "update  Tbl_Ozgecmisler Set Ad=@ad,Soyad=@soyad,Telefon=@telefon,Sehir=@sehir,Cinsiyet=@cinsiyet,DogumTarihi=@dogumTarihi,LiseOkulAdi=@liseOkulAdi," +
                        "LiseBaslangicTarihi=@liseBaslangicTarihi,LiseBitisTarihi=@liseBitisTarihi," +
                        "UniversiteOkulAdi=@universiteOkulAdi,UniversiteBaslangicTarihi=@universiteBaslangicTarihi,UniversiteBitisTarihi=@universiteBitisTarihi,UniversiteBolum=@universiteBolum,FirmaAdi1=@firmaAdi1," +
                        "Firma1GirisTarihi=@firma1GirisTarihi,Firma1CikisTarihi=@firma1CikisTarihi," +
                        "Firma1IsTipi=@firma1IsTipi,FirmaAdi2=@firmaAdi2,Firma2GirisTarihi=@firma2GirisTarihi,Firma2CikisTarihi=@firma2CikisTarihi,Firma2IsTipi=@firma2IsTipi,Hobiler=@hobiler,Ozet=@ozet,ResimUrl=@resimUrl,OzgecmisHerkeseAcik=@ozgecmisHerkeseAcik,AskerlikDurumu=@askerlikDurumu where kullaniciId=@KullaniciId";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@ad", Ad);
                    cmd.Parameters.AddWithValue("@soyad", Soyad);
                    cmd.Parameters.AddWithValue("@telefon", Telefon);
                    cmd.Parameters.AddWithValue("@sehir", Sehir);
                    cmd.Parameters.AddWithValue("@cinsiyet", Cinsiyet);
                    cmd.Parameters.AddWithValue("@dogumTarihi", DogumTarihi);
                    cmd.Parameters.AddWithValue("@liseOkulAdi", LiseOkulAdi);
                    cmd.Parameters.AddWithValue("@liseBaslangicTarihi", LiseBaslangicTarihi);
                    cmd.Parameters.AddWithValue("@liseBitisTarihi", LiseBitisTarihi);
                    cmd.Parameters.AddWithValue("@universiteOkulAdi", UniversiteOkulAdi);
                    cmd.Parameters.AddWithValue("@universiteBaslangicTarihi", UniversiteBaslangicTarihi);
                    cmd.Parameters.AddWithValue("@universiteBitisTarihi", UniversiteBitisTarihi);
                    cmd.Parameters.AddWithValue("@universiteBolum", UniversiteBolum);
                    cmd.Parameters.AddWithValue("@firmaAdi1", FirmaAdi1);
                    cmd.Parameters.AddWithValue("@firma1GirisTarihi", Firma1GirisTarihi);
                    cmd.Parameters.AddWithValue("@firma1CikisTarihi", Firma1CikisTarihi);
                    cmd.Parameters.AddWithValue("@firma1IsTipi", Firma1IsTipi);
                    cmd.Parameters.AddWithValue("@firmaAdi2", FirmaAdi2);
                    cmd.Parameters.AddWithValue("@firma2GirisTarihi", Firma2GirisTarihi);
                    cmd.Parameters.AddWithValue("@firma2CikisTarihi", Firma2CikisTarihi);
                    cmd.Parameters.AddWithValue("@firma2IsTipi", Firma2IsTipi);
                    cmd.Parameters.AddWithValue("@hobiler", Hobiler);
                    cmd.Parameters.AddWithValue("@ozet", Ozet);
                    cmd.Parameters.AddWithValue("@resimUrl", ResimUrl);
                    cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                    cmd.Parameters.AddWithValue("@ozgecmisHerkeseAcik", OzgecmisHerkeseAcik);
                    cmd.Parameters.AddWithValue("@askerlikDurumu", AskerlikDurumu);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Özgeçmişiniz başarıyla güncellendi.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void FirmaBilgileriInsert(int kullaniciId, string FirmaAdi, string Sektor, string CalisanSayisi, string FirmaBilgisi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "insert into Tbl_FirmaBilgileri(FirmaAdi,Sektor,CalisanSayisi,FirmaOzetBilgi,kullaniciId) values(@firmaAdi,@sektor,@calisanSayisi,@firmaOzetBilgi,@KullaniciId)";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@firmaAdi", FirmaAdi);
                    cmd.Parameters.AddWithValue("@sektor", Sektor);
                    cmd.Parameters.AddWithValue("@calisanSayisi", Convert.ToInt32(CalisanSayisi));
                    cmd.Parameters.AddWithValue("@firmaOzetBilgi", FirmaBilgisi);
                    cmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void FirmaBilgileriniGuncelle(int kullaniciId, string FirmaAdi, string Sektor, string CalisanSayisi, string FirmaBilgisi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "update Tbl_FirmaBilgileri set FirmaAdi=@firmaAdi,Sektor=@sektor,CalisanSayisi=@calisanSayisi,FirmaOzetBilgi=@firmaOzetBilgi where kullaniciId = @KullaniciId";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@firmaAdi", FirmaAdi);
                    cmd.Parameters.AddWithValue("@sektor", Sektor);
                    cmd.Parameters.AddWithValue("@calisanSayisi", Convert.ToInt32(CalisanSayisi));
                    cmd.Parameters.AddWithValue("@firmaOzetBilgi", FirmaBilgisi);
                    cmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void IlanSil(int silinecekIlanId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "update Tbl_Ilanlar set IlanDurumuGuncel = 0 where IlanId=@ilanId";
                    var basvuruSorgu = "update Tbl_Basvurular set BasvuruGuncel = 0 where IlanId=@ilanId";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@ilanId", silinecekIlanId);
                    SqlCommand cmd2 = new SqlCommand(basvuruSorgu, conn);
                    cmd2.Parameters.AddWithValue("@ilanId", silinecekIlanId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void IlanVer(int FirmaId, string Tecrube, string Aciklama, int FirmakullaniciId, string IsTanimi, string Sehir, string OtomatikMesaj)
        {
            try
            {
                var tarih = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    if (OtomatikMesaj != "")
                    {
                        Sorgu = "insert into Tbl_Ilanlar (Tecrube,Aciklama,IlanVerilmeTarihi,FirmaId,IsTanimi,Sehir,OtomatikMesajGonder,OtomatikMesaj) values(@tecrube,@aciklama,@ilanVerilmeTarihi,@firmaId,@isTanimi,@sehir,@otomatikMesajGonder,@otomatikMesaj)";
                        SqlCommand cmd = new SqlCommand(Sorgu, conn);
                        cmd.Parameters.AddWithValue("@sehir", Sehir);
                        cmd.Parameters.AddWithValue("@firmaId", FirmaId);
                        cmd.Parameters.AddWithValue("@tecrube", Tecrube);
                        cmd.Parameters.AddWithValue("@aciklama", Aciklama);
                        cmd.Parameters.AddWithValue("@ilanVerilmeTarihi", tarih);
                        cmd.Parameters.AddWithValue("@isTanimi", IsTanimi);
                        cmd.Parameters.AddWithValue("@otomatikMesajGonder", 1);
                        cmd.Parameters.AddWithValue("@otomatikMesaj", OtomatikMesaj);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        Sorgu = "insert into Tbl_Ilanlar (Tecrube,Aciklama,IlanVerilmeTarihi,FirmaId,IsTanimi,Sehir,OtomatikMesajGonder,OtomatikMesaj) values(@tecrube,@aciklama,@ilanVerilmeTarihi,@firmaId,@isTanimi,@sehir,@otomatikMesajGonder,@otomatikMesaj)";
                        SqlCommand cmd = new SqlCommand(Sorgu, conn);
                        cmd.Parameters.AddWithValue("@sehir", Sehir);
                        cmd.Parameters.AddWithValue("@firmaId", FirmaId);
                        cmd.Parameters.AddWithValue("@tecrube", Tecrube);
                        cmd.Parameters.AddWithValue("@aciklama", Aciklama);
                        cmd.Parameters.AddWithValue("@ilanVerilmeTarihi", tarih);
                        cmd.Parameters.AddWithValue("@isTanimi", IsTanimi);
                        cmd.Parameters.AddWithValue("@otomatikMesajGonder", 0);
                        cmd.Parameters.AddWithValue("@otomatikMesaj", OtomatikMesaj);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void BasvuruEkle(int IlanId, int FirmaId, int BasvuranOzgecmisId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var tarih = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
                    var kayitVarMi = conn.ExecuteScalar<int>("select BasvuranOzgecmisId from Tbl_Basvurular where IlanId=@ilanId and BasvuruGuncel = 1",
                        new
                        {
                            @ilanId = IlanId
                        });
                    if (kayitVarMi == 0)
                    {
                        var otomatikMesajVar = conn.ExecuteScalar<int>("select OtomatikMesajGonder from Tbl_Ilanlar where IlanId=@ilanId",
                       new
                       {
                           @ilanId = IlanId
                       });
                        if (otomatikMesajVar == 1)
                        {
                            var otomatikMesaj = conn.ExecuteScalar<string>("select OtomatikMesaj from Tbl_Ilanlar where IlanId=@ilanId",
                                new
                                {
                                    @ilanId = IlanId
                                });
                            conn.Execute("insert into Tbl_Mesajlar (Mesaj,MesajTarihi,GondericiId,AliciId) values (@mesaj,@mesajTarihi,@gondericiId,@aliciId)",
                                new
                                {
                                    @mesaj = otomatikMesaj,
                                    @mesajTarihi = tarih,
                                    @gondericiId = FirmaId,
                                    @aliciId = BasvuranOzgecmisId
                                });
                        }
                        conn.Execute("insert into Tbl_Basvurular (FirmaId,BasvuranOzgecmisId,IlanId) values (@firmaId,@basvuranOzgecmisId,@ilanId)",
                        new
                        {
                            @firmaId = FirmaId,
                            @basvuranOzgecmisId = BasvuranOzgecmisId,
                            @ilanId = IlanId
                        });
                        MessageBox.Show("İşlem başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Bu ilana zaten başvurdunuz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void MailSifreGuncelleme(string OncekiMail, string Sifre, string Mail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "update Tbl_Kullanicilar Set KullaniciMail=@kullaniciMail,KullaniciSifre=@kullaniciSifre where KullaniciMail=@tutulanKullaniciMail";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@kullaniciMail", Mail);
                    cmd.Parameters.AddWithValue("@kullaniciSifre", Sifre);
                    cmd.Parameters.AddWithValue("@tutulanKullaniciMail", OncekiMail);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        //ADO.NET
        public void BasvuruSil(int KullaniciId, int IlanId)
        {
            try
            {
                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var ozGecmisId = conn.ExecuteScalar<int>("select OzgecmisId from Tbl_Ozgecmisler where kullaniciId = @KullaniciId",
                        new
                        {
                            @KullaniciId = KullaniciId
                        });
                    Sorgu = "update Tbl_Basvurular set BasvuruGuncel = 0 where IlanId=@ilanId and BasvuranOzgecmisId=@basvuranId";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@ilanId", IlanId);
                    cmd.Parameters.AddWithValue("@basvuranId", ozGecmisId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Başvuru başarıyla silindi.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void Log(string LogMesaji, string LogTuru, int KullaniciId) // ADO.NET
        {
            try
            {
                if (KullaniciId != 0)
                {
                    var aciklama = +KullaniciId + " id'li " + LogMesaji;
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        Sorgu = "insert into Tbl_Loglar (LogMesaj,LogTarih,LogTuru) values (@logMesaj,@logTarih,@logTuru)";
                        SqlCommand cmd = new SqlCommand(Sorgu, conn);
                        cmd.Parameters.AddWithValue("@logMesaj", aciklama);
                        cmd.Parameters.AddWithValue("@logTarih", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@logTuru", LogTuru);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        Sorgu = "insert into Tbl_Loglar (LogMesaj,LogTarih,LogTuru) values (@logMesaj,@logTarih,@logTuru)";
                        SqlCommand cmd = new SqlCommand(Sorgu, conn);
                        cmd.Parameters.AddWithValue("@logMesaj", LogMesaji);
                        cmd.Parameters.AddWithValue("@logTarih", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@logTuru", LogTuru);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void MesajGonder(string Mesaj, int AliciId, int FirmaId)
        {
            try
            {
                var tarih = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    Sorgu = "insert into Tbl_Mesajlar (Mesaj,MesajTarihi,GondericiId,AliciId) values (@mesaj,@mesajTarihi,@gondericiId,@aliciId)";
                    SqlCommand cmd = new SqlCommand(Sorgu, conn);
                    cmd.Parameters.AddWithValue("@mesaj", Mesaj);
                    cmd.Parameters.AddWithValue("@mesajTarihi", tarih);
                    cmd.Parameters.AddWithValue("@gondericiId", FirmaId);
                    cmd.Parameters.AddWithValue("@aliciId", AliciId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Mesaj gönderildi.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        #endregion


        #region Sorgu kullanılmayan metotlar
        public Boolean SifreUygunMu(string Sifre)  // GİRİLEN ŞİFRENİN UYGUNLUĞUNU KONTROL EDEN METOT
        {
            string BuyukHarfler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ";
            string KucukHarfler = "abcçdefgğhiıjklmnoöprsştuüvyz";
            string Sayilar = "0123456789";
            foreach (var item in Sifre)
            {
                if (BuyukHarfler.Contains(item))
                {
                    foreach (var item2 in Sifre)
                    {
                        if (KucukHarfler.Contains(item2))
                        {
                            foreach (var item3 in Sifre)
                            {
                                if (Sayilar.Contains(item3))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public void OpenChildForm(Form childForm, object sender, Panel pnl)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnl.Controls.Add(childForm);
                pnl.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public string KullaniciYetkisiNe(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                return "İşveren";
            }
            else
                return "Çalışan";
        }
        public void GridTemizle(int RowsCount, DataGridView grid)
        {
            try
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    grid.Rows[i].Cells["Ad"].Value = "";
                    grid.Rows[i].Cells["Soyad"].Value = "";
                    grid.Rows[i].Cells["Sehir"].Value = "";
                    grid.Rows[i].Cells["Cinsiyet"].Value = "";
                    grid.Rows[i].Cells["DogumTarihi"].Value = "";
                    grid.Rows[i].Cells["UniversiteOkulAdi"].Value = "";
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        public void GridTemizleTest(DataGridView grid) // PARAMETRE OLARAK DATAGRIDVIEW ALAN VE ALDIĞI GRID SATIRLARINI TEMİZLEYEN METOT
        {
            try
            {
                var colCount = grid.ColumnCount;
                var rowCount = grid.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        Type tp = grid.Rows[i].Cells[j].Value.GetType();
                        if (tp.Equals(typeof(string)))
                        {
                            grid.Rows[i].Cells[j].Value = "";
                        }
                        else
                        {
                            grid.Rows[i].Cells[j].Value = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        #endregion

    }
}
