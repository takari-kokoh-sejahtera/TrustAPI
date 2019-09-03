using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using TrustAPI.Models;
using TrustAPI.Models.Model;

namespace TrustAPI.Controllers
{
    public class BSTKAfterController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();

        // GET: api/BSTKAfter
        public IQueryable<Tr_BSTKAfters> GetTr_BSTKAfters()
        {
            return db.Tr_BSTKAfters;
        }

        // GET: api/BSTKAfter/5
        [ResponseType(typeof(Tr_BSTKAfters))]
        public IHttpActionResult GetTr_BSTKAfters(int id)
        {
            Tr_BSTKAfters tr_BSTKAfters = db.Tr_BSTKAfters.Find(id);
            if (tr_BSTKAfters == null)
            {
                return NotFound();
            }

            return Ok(tr_BSTKAfters);
        }

        private bool Validasi(Tr_BSTKAfter BSTKAfter,ref string result)
        {
            try
            {
                string[] Gabungan = BSTKAfter.Nomor_Plat_Kendaraan.Split(';');
                var BSTKBefore_ID = Int32.Parse(Gabungan[3]);
                if (!db.Tr_BSTKBefores.Any(x => x.BSTKBefore_ID == BSTKBefore_ID && x.IsCompleted == false && !x.IsDeleted))
                {
                    result = "BSTKBefore_ID does't exist!";
                    return false;
                }
                else if (!db.Cn_Users.Any(x => x.User_ID == BSTKAfter.CreatedBy))
                {
                    result = "User Name does't exist!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }
        public bool SaveImage(string ImgStr, string ImgName, string folder)
        {
            try
            {
                String path = HttpContext.Current.Server.MapPath("~/Image/" + folder); //Path

                //Check if directory exist
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
                }

                string imageName = ImgName + ".jpg";

                //set the image path
                string imgPath = Path.Combine(path, imageName);

                byte[] imageBytes = Convert.FromBase64String(ImgStr);

                File.WriteAllBytes(imgPath, imageBytes);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // POST: api/BSTKAfter
        [ResponseType(typeof(Tr_BSTKAfter))]
        public IHttpActionResult PostTr_BSTKAfters(Tr_BSTKAfter tr_BSTKAfters)
        {
            var results = new Result();
            results.Status = "Error";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string messages = "";
            if (!Validasi(tr_BSTKAfters, ref messages))
            {
                results.Message = messages;
                return Json(results);
            }

            using (var dbs = db.Database.BeginTransaction())
            {
                try
                {
                    string[] Gabungan = tr_BSTKAfters.Nomor_Plat_Kendaraan.Split(';');
                    var BSTKBefore_ID = Int32.Parse(Gabungan[3]);

                    var bstk = new Tr_BSTKAfters
                    {
                        BSTKBefore_ID = BSTKBefore_ID,
                        Automatic_Light_Switch = tr_BSTKAfters.Automatic_Light_Switch,
                        Automatic_Light_Switch_Ket = tr_BSTKAfters.Automatic_Light_Switch_Ket,
                        Lampu_Kecil = tr_BSTKAfters.Lampu_Kecil,
                        Lampu_Kecil_Ket = tr_BSTKAfters.Lampu_Kecil_Ket,
                        Lampu_Dekat = tr_BSTKAfters.Lampu_Dekat,
                        Lampu_Dekat_Ket = tr_BSTKAfters.Lampu_Dekat_Ket,
                        Lampu_Jauh = tr_BSTKAfters.Lampu_Jauh,
                        Lampu_Jauh_Ket = tr_BSTKAfters.Lampu_Jauh_Ket,
                        Lampu_Kabut_Fog_Lamp = tr_BSTKAfters.Lampu_Kabut_Fog_Lamp,
                        Lampu_Kabut_Fog_Lamp_Ket = tr_BSTKAfters.Lampu_Kabut_Fog_Lamp_Ket,
                        Lampu_Sign_Depan = tr_BSTKAfters.Lampu_Sign_Depan,
                        Lampu_Sign_Depan_Ket = tr_BSTKAfters.Lampu_Sign_Depan_Ket,
                        Lampu_Sign_Belakang = tr_BSTKAfters.Lampu_Sign_Belakang,
                        Lampu_Sign_Belakang_Ket = tr_BSTKAfters.Lampu_Sign_Belakang_Ket,
                        Lampu_Belakang = tr_BSTKAfters.Lampu_Belakang,
                        Lampu_Belakang_Ket = tr_BSTKAfters.Lampu_Belakang_Ket,
                        Lampu_Rem = tr_BSTKAfters.Lampu_Rem,
                        Lampu_Rem_Ket = tr_BSTKAfters.Lampu_Rem_Ket,
                        Lampu_Mundur = tr_BSTKAfters.Lampu_Mundur,
                        Lampu_Mundur_Ket = tr_BSTKAfters.Lampu_Mundur_Ket,
                        Lampu_Dashboard = tr_BSTKAfters.Lampu_Dashboard,
                        Lampu_Dashboard_Ket = tr_BSTKAfters.Lampu_Dashboard_Ket,
                        Lampu_Plafond_Depan_dan_Belakang = tr_BSTKAfters.Lampu_Plafond_Depan_dan_Belakang,
                        Lampu_Plafond_Depan_dan_Belakang_Ket = tr_BSTKAfters.Lampu_Plafond_Depan_dan_Belakang_Ket,
                        Klakson = tr_BSTKAfters.Klakson,
                        Klakson_Ket = tr_BSTKAfters.Klakson_Ket,
                        Antena = tr_BSTKAfters.Antena,
                        Antena_Ket = tr_BSTKAfters.Antena_Ket,
                        Tape_Radio_CD_DVD_TV_Player = tr_BSTKAfters.Tape_Radio_CD_DVD_TV_Player,
                        Tape_Radio_CD_DVD_TV_Player_Ket = tr_BSTKAfters.Tape_Radio_CD_DVD_TV_Player_Ket,
                        Remote_Tape_Radio_CD_DVD_TV_Player = tr_BSTKAfters.Remote_Tape_Radio_CD_DVD_TV_Player,
                        Remote_Tape_Radio_CD_DVD_TV_Player_Ket = tr_BSTKAfters.Remote_Tape_Radio_CD_DVD_TV_Player_Ket,
                        Alarm_Remote_Key = tr_BSTKAfters.Alarm_Remote_Key,
                        Alarm_Remote_Key_Ket = tr_BSTKAfters.Alarm_Remote_Key_Ket,
                        Central_Lock = tr_BSTKAfters.Central_Lock,
                        Central_Lock_Ket = tr_BSTKAfters.Central_Lock_Ket,
                        Power_Window = tr_BSTKAfters.Power_Window,
                        Power_Window_Ket = tr_BSTKAfters.Power_Window_Ket,
                        Switch_Mirror = tr_BSTKAfters.Switch_Mirror,
                        Switch_Mirror_Ket = tr_BSTKAfters.Switch_Mirror_Ket,
                        Air_Conditioner = tr_BSTKAfters.Air_Conditioner,
                        Air_Conditioner_Ket = tr_BSTKAfters.Air_Conditioner_Ket,
                        Safety_Belt = tr_BSTKAfters.Safety_Belt,
                        Safety_Belt_Ket = tr_BSTKAfters.Safety_Belt_Ket,
                        Karpet = tr_BSTKAfters.Karpet,
                        Karpet_Ket = tr_BSTKAfters.Karpet_Ket,
                        Lighter = tr_BSTKAfters.Lighter,
                        Lighter_Ket = tr_BSTKAfters.Lighter_Ket,
                        Asbak = tr_BSTKAfters.Asbak,
                        Asbak_Ket = tr_BSTKAfters.Asbak_Ket,
                        Sarung_Jok = tr_BSTKAfters.Sarung_Jok,
                        Sarung_Jok_Ket = tr_BSTKAfters.Sarung_Jok_Ket,
                        Sandaran_Kepala = tr_BSTKAfters.Sandaran_Kepala,
                        Sandaran_Kepala_Ket = tr_BSTKAfters.Sandaran_Kepala_Ket,
                        Spion_Dalam = tr_BSTKAfters.Spion_Dalam,
                        Spion_Dalam_Ket = tr_BSTKAfters.Spion_Dalam_Ket,
                        Wiper_Blade = tr_BSTKAfters.Wiper_Blade,
                        Wiper_Blade_Ket = tr_BSTKAfters.Wiper_Blade_Ket,
                        Windshield_Washer = tr_BSTKAfters.Windshield_Washer,
                        Windshield_Washer_Ket = tr_BSTKAfters.Windshield_Washer_Ket,
                        Talang_Air = tr_BSTKAfters.Talang_Air,
                        Talang_Air_Ket = tr_BSTKAfters.Talang_Air_Ket,
                        Fender_Lumpur_Depan_dan_Belakang = tr_BSTKAfters.Fender_Lumpur_Depan_dan_Belakang,
                        Fender_Lumpur_Depan_dan_Belakang_Ket = tr_BSTKAfters.Fender_Lumpur_Depan_dan_Belakang_Ket,
                        Spion_Kiri_Kanan = tr_BSTKAfters.Spion_Kiri_Kanan,
                        Spion_Kiri_Kanan_Ket = tr_BSTKAfters.Spion_Kiri_Kanan_Ket,
                        Tutup_Bensin = tr_BSTKAfters.Tutup_Bensin,
                        Tutup_Bensin_Ket = tr_BSTKAfters.Tutup_Bensin_Ket,
                        Emblem_Logo = tr_BSTKAfters.Emblem_Logo,
                        Emblem_Logo_Ket = tr_BSTKAfters.Emblem_Logo_Ket,
                        Kaca_Mobil_dan_Kaca_Film = tr_BSTKAfters.Kaca_Mobil_dan_Kaca_Film,
                        Kaca_Mobil_dan_Kaca_Film_Ket = tr_BSTKAfters.Kaca_Mobil_dan_Kaca_Film_Ket,
                        STNK = tr_BSTKAfters.STNK,
                        STNK_Ket = tr_BSTKAfters.STNK_Ket,
                        Buku_KIR_Stiker_Peneng = tr_BSTKAfters.Buku_KIR_Stiker_Peneng,
                        Buku_KIR_Stiker_Peneng_Ket = tr_BSTKAfters.Buku_KIR_Stiker_Peneng_Ket,
                        Owners_Manual_Book = tr_BSTKAfters.Owners_Manual_Book,
                        Owners_Manual_Book_Ket = tr_BSTKAfters.Owners_Manual_Book_Ket,
                        Buku_Service = tr_BSTKAfters.Buku_Service,
                        Buku_Service_Ket = tr_BSTKAfters.Buku_Service_Ket,
                        Ban_Serep = tr_BSTKAfters.Ban_Serep,
                        Ban_Serep_Ket = tr_BSTKAfters.Ban_Serep_Ket,
                        Kunci_Roda_Busi_Pas_Tang = tr_BSTKAfters.Kunci_Roda_Busi_Pas_Tang,
                        Kunci_Roda_Busi_Pas_Tang_Ket = tr_BSTKAfters.Kunci_Roda_Busi_Pas_Tang_Ket,
                        Kunci_Stir = tr_BSTKAfters.Kunci_Stir,
                        Kunci_Stir_Ket = tr_BSTKAfters.Kunci_Stir_Ket,
                        Dongkrak = tr_BSTKAfters.Dongkrak,
                        Dongkrak_Ket = tr_BSTKAfters.Dongkrak_Ket,
                        P3K = tr_BSTKAfters.P3K,
                        P3K_Ket = tr_BSTKAfters.P3K_Ket,
                        Segitiga_Pengaman = tr_BSTKAfters.Segitiga_Pengaman,
                        Segitiga_Pengaman_Ket = tr_BSTKAfters.Segitiga_Pengaman_Ket,
                        Lap_Kanebo = tr_BSTKAfters.Lap_Kanebo,
                        Lap_Kanebo_Ket = tr_BSTKAfters.Lap_Kanebo_Ket,
                        Foto_Kendaraan_Tampak_Depan = tr_BSTKAfters.Foto_Kendaraan_Tampak_Depan,
                        Foto_Kendaraan_Tampak_Belakang = tr_BSTKAfters.Foto_Kendaraan_Tampak_Belakang,
                        Foto_Kendaraan_Tampak_Samping_Kanan = tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kanan,
                        Foto_Kendaraan_Tampak_Samping_Kiri = tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kiri,
                        apar = tr_BSTKAfters.apar,
                        fuel = tr_BSTKAfters.fuel,
                        isi_tangki = tr_BSTKAfters.isi_tangki,
                        isi_tangki_ket = tr_BSTKAfters.isi_tangki_ket,
                        km = tr_BSTKAfters.km,
                        velg_ban = tr_BSTKAfters.velg_ban,
                        tutup_dop = tr_BSTKAfters.tutup_dop,
                        signature = tr_BSTKAfters.signature,
                        signature_image = tr_BSTKAfters.signature_image,
                        CreatedDate = DateTime.Now,
                        CreatedBy = tr_BSTKAfters.CreatedBy,
                        IsDeleted = false
                    };

                    db.Tr_BSTKAfters.Add(bstk);
                    db.SaveChanges();
                    if (tr_BSTKAfters.Foto_Kendaraan_Tampak_Depan != "" && !SaveImage(tr_BSTKAfters.Foto_Kendaraan_Tampak_Depan, bstk.BSTKBefore_ID.ToString(), "BSTKAfter\\Depan"))
                    {
                        throw new System.InvalidOperationException("Failed Save Image Tampak Depan");
                    }
                    if (tr_BSTKAfters.Foto_Kendaraan_Tampak_Belakang != "" && !SaveImage(tr_BSTKAfters.Foto_Kendaraan_Tampak_Belakang, bstk.BSTKBefore_ID.ToString(), "BSTKAfter\\Belakang"))
                    {
                        throw new System.InvalidOperationException("Failed Save Image Tampak Belakang");
                    }
                    if (tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kanan != "" && !SaveImage(tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kanan, bstk.BSTKBefore_ID.ToString(), "BSTKAfter\\Kanan"))
                    {
                        throw new System.InvalidOperationException("Failed Save Image Tampak Samping Kanan");
                    }
                    if (tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kiri != "" && !SaveImage(tr_BSTKAfters.Foto_Kendaraan_Tampak_Samping_Kiri, bstk.BSTKBefore_ID.ToString(), "BSTKAfter\\Kiri"))
                    {
                        throw new System.InvalidOperationException("Failed Save Image Tampak Samping Kiri");
                    }
                    if (tr_BSTKAfters.signature_image != "" && !SaveImage(tr_BSTKAfters.signature_image, bstk.BSTKBefore_ID.ToString(), "BSTKAfter\\Signature"))
                    {
                        throw new System.InvalidOperationException("Failed Save Image Tampak Signature");
                    }
                    var bsktBefore = db.Tr_BSTKBefores.Where(x => x.BSTKBefore_ID == BSTKBefore_ID).FirstOrDefault();
                    bsktBefore.IsCompleted = true;
                    db.SaveChanges();
                    dbs.Commit();
                    results.Status = "Success";
                    return Json(results);
                }
                catch (Exception e)
                {
                    results.Message = e.Message;
                    dbs.Rollback();
                    return Json(results);
                }

            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}