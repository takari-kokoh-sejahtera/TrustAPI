﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Imaging;
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
    public class BSTKBeforeController : ApiController
    {
        public IQueryable<Tr_BSTKBefore> GetMs_Vehicles()
        {
            return db.Tr_BSTKBefores.Where(x => x.IsDeleted == false).Select(x => new Tr_BSTKBefore
            {
                Nama_Customer = x.Ms_Customers.Company_Name,
                Nomor_Plat_Kendaraan = x.Ms_Vehicles.license_no,
                Automatic_Light_Switch = x.Automatic_Light_Switch,
                Automatic_Light_Switch_Ket = x.Automatic_Light_Switch_Ket,
                Lampu_Kecil = x.Lampu_Kecil,
                Lampu_Kecil_Ket = x.Lampu_Kecil_Ket,
                Lampu_Dekat = x.Lampu_Dekat,
                Lampu_Dekat_Ket = x.Lampu_Dekat_Ket,
                Lampu_Jauh = x.Lampu_Jauh,
                Lampu_Jauh_Ket = x.Lampu_Jauh_Ket,
                Lampu_Kabut_Fog_Lamp = x.Lampu_Kabut_Fog_Lamp,
                Lampu_Kabut_Fog_Lamp_Ket = x.Lampu_Kabut_Fog_Lamp_Ket,
                Lampu_Sign_Depan = x.Lampu_Sign_Depan,
                Lampu_Sign_Depan_Ket = x.Lampu_Sign_Depan_Ket,
                Lampu_Sign_Belakang = x.Lampu_Sign_Belakang,
                Lampu_Sign_Belakang_Ket = x.Lampu_Sign_Belakang_Ket,
                Lampu_Belakang = x.Lampu_Belakang,
                Lampu_Belakang_Ket = x.Lampu_Belakang_Ket,
                Lampu_Rem = x.Lampu_Rem,
                Lampu_Rem_Ket = x.Lampu_Rem_Ket,
                Lampu_Mundur = x.Lampu_Mundur,
                Lampu_Mundur_Ket = x.Lampu_Mundur_Ket,
                Lampu_Dashboard = x.Lampu_Dashboard,
                Lampu_Dashboard_Ket = x.Lampu_Dashboard_Ket,
                Lampu_Plafond_Depan_dan_Belakang = x.Lampu_Plafond_Depan_dan_Belakang,
                Lampu_Plafond_Depan_dan_Belakang_Ket = x.Lampu_Plafond_Depan_dan_Belakang_Ket,
                Klakson = x.Klakson,
                Klakson_Ket = x.Klakson_Ket,
                Antena = x.Antena,
                Antena_Ket = x.Antena_Ket,
                Tape_Radio_CD_DVD_TV_Player = x.Tape_Radio_CD_DVD_TV_Player,
                Tape_Radio_CD_DVD_TV_Player_Ket = x.Tape_Radio_CD_DVD_TV_Player_Ket,
                Remote_Tape_Radio_CD_DVD_TV_Player = x.Remote_Tape_Radio_CD_DVD_TV_Player,
                Remote_Tape_Radio_CD_DVD_TV_Player_Ket = x.Remote_Tape_Radio_CD_DVD_TV_Player_Ket,
                Alarm_Remote_Key = x.Alarm_Remote_Key,
                Alarm_Remote_Key_Ket = x.Alarm_Remote_Key_Ket,
                Central_Lock = x.Central_Lock,
                Central_Lock_Ket = x.Central_Lock_Ket,
                Power_Window = x.Power_Window,
                Power_Window_Ket = x.Power_Window_Ket,
                Switch_Mirror = x.Switch_Mirror,
                Switch_Mirror_Ket = x.Switch_Mirror_Ket,
                Air_Conditioner = x.Air_Conditioner,
                Air_Conditioner_Ket = x.Air_Conditioner_Ket,
                Safety_Belt = x.Safety_Belt,
                Safety_Belt_Ket = x.Safety_Belt_Ket,
                Karpet = x.Karpet,
                Karpet_Ket = x.Karpet_Ket,
                Lighter = x.Lighter,
                Lighter_Ket = x.Lighter_Ket,
                Asbak = x.Asbak,
                Asbak_Ket = x.Asbak_Ket,
                Sarung_Jok = x.Sarung_Jok,
                Sarung_Jok_Ket = x.Sarung_Jok_Ket,
                Sandaran_Kepala = x.Sandaran_Kepala,
                Sandaran_Kepala_Ket = x.Sandaran_Kepala_Ket,
                Spion_Dalam = x.Spion_Dalam,
                Spion_Dalam_Ket = x.Spion_Dalam_Ket,
                Wiper_Blade = x.Wiper_Blade,
                Wiper_Blade_Ket = x.Wiper_Blade_Ket,
                Windshield_Washer = x.Windshield_Washer,
                Windshield_Washer_Ket = x.Windshield_Washer_Ket,
                Talang_Air = x.Talang_Air,
                Talang_Air_Ket = x.Talang_Air_Ket,
                Fender_Lumpur_Depan_dan_Belakang = x.Fender_Lumpur_Depan_dan_Belakang,
                Fender_Lumpur_Depan_dan_Belakang_Ket = x.Fender_Lumpur_Depan_dan_Belakang_Ket,
                Spion_Kiri_Kanan = x.Spion_Kiri_Kanan,
                Spion_Kiri_Kanan_Ket = x.Spion_Kiri_Kanan_Ket,
                Tutup_Bensin = x.Tutup_Bensin,
                Tutup_Bensin_Ket = x.Tutup_Bensin_Ket,
                Emblem_Logo = x.Emblem_Logo,
                Emblem_Logo_Ket = x.Emblem_Logo_Ket,
                Kaca_Mobil_dan_Kaca_Film = x.Kaca_Mobil_dan_Kaca_Film,
                Kaca_Mobil_dan_Kaca_Film_Ket = x.Kaca_Mobil_dan_Kaca_Film_Ket,
                STNK = x.STNK,
                STNK_Ket = x.STNK_Ket,
                Buku_KIR_Stiker_Peneng = x.Buku_KIR_Stiker_Peneng,
                Buku_KIR_Stiker_Peneng_Ket = x.Buku_KIR_Stiker_Peneng_Ket,
                Owners_Manual_Book = x.Owners_Manual_Book,
                Owners_Manual_Book_Ket = x.Owners_Manual_Book_Ket,
                Buku_Service = x.Buku_Service,
                Buku_Service_Ket = x.Buku_Service_Ket,
                Ban_Serep = x.Ban_Serep,
                Ban_Serep_Ket = x.Ban_Serep_Ket,
                Kunci_Roda_Busi_Pas_Tang = x.Kunci_Roda_Busi_Pas_Tang,
                Kunci_Roda_Busi_Pas_Tang_Ket = x.Kunci_Roda_Busi_Pas_Tang_Ket,
                Kunci_Stir = x.Kunci_Stir,
                Kunci_Stir_Ket = x.Kunci_Stir_Ket,
                Dongkrak = x.Dongkrak,
                Dongkrak_Ket = x.Dongkrak_Ket,
                P3K = x.P3K,
                P3K_Ket = x.P3K_Ket,
                Segitiga_Pengaman = x.Segitiga_Pengaman,
                Segitiga_Pengaman_Ket = x.Segitiga_Pengaman_Ket,
                Lap_Kanebo = x.Lap_Kanebo,
                Lap_Kanebo_Ket = x.Lap_Kanebo_Ket,
                Foto_Kendaraan_Tampak_Depan = x.Foto_Kendaraan_Tampak_Depan,
                Foto_Kendaraan_Tampak_Belakang = x.Foto_Kendaraan_Tampak_Belakang,
                Foto_Kendaraan_Tampak_Samping_Kanan = x.Foto_Kendaraan_Tampak_Samping_Kanan,
                Foto_Kendaraan_Tampak_Samping_Kiri = x.Foto_Kendaraan_Tampak_Samping_Kiri,
                apar = x.apar,
                fuel = x.fuel,
                isi_tangki = x.isi_tangki,
                isi_tangki_ket = x.isi_tangki_ket,
                km = x.km,
                velg_ban = x.velg_ban,
                tutup_dop = x.tutup_dop,
                signature = x.signature,
                signature_image = x.signature_image,
                CreatedBy = x.CreatedBy
            });
        }

        public Tr_BSTKBefore GetMs_Vehicles(int id)
        {
            Tr_BSTKBefore bstk = db.Tr_BSTKBefores.Where(x => x.IsDeleted == false && x.BSTKBefore_ID == id).Select(x => new Tr_BSTKBefore
            {
                Nama_Customer = x.Ms_Customers.Company_Name,
                Nomor_Plat_Kendaraan = x.Ms_Vehicles.license_no,
                Automatic_Light_Switch = x.Automatic_Light_Switch,
                Automatic_Light_Switch_Ket = x.Automatic_Light_Switch_Ket,
                Lampu_Kecil = x.Lampu_Kecil,
                Lampu_Kecil_Ket = x.Lampu_Kecil_Ket,
                Lampu_Dekat = x.Lampu_Dekat,
                Lampu_Dekat_Ket = x.Lampu_Dekat_Ket,
                Lampu_Jauh = x.Lampu_Jauh,
                Lampu_Jauh_Ket = x.Lampu_Jauh_Ket,
                Lampu_Kabut_Fog_Lamp = x.Lampu_Kabut_Fog_Lamp,
                Lampu_Kabut_Fog_Lamp_Ket = x.Lampu_Kabut_Fog_Lamp_Ket,
                Lampu_Sign_Depan = x.Lampu_Sign_Depan,
                Lampu_Sign_Depan_Ket = x.Lampu_Sign_Depan_Ket,
                Lampu_Sign_Belakang = x.Lampu_Sign_Belakang,
                Lampu_Sign_Belakang_Ket = x.Lampu_Sign_Belakang_Ket,
                Lampu_Belakang = x.Lampu_Belakang,
                Lampu_Belakang_Ket = x.Lampu_Belakang_Ket,
                Lampu_Rem = x.Lampu_Rem,
                Lampu_Rem_Ket = x.Lampu_Rem_Ket,
                Lampu_Mundur = x.Lampu_Mundur,
                Lampu_Mundur_Ket = x.Lampu_Mundur_Ket,
                Lampu_Dashboard = x.Lampu_Dashboard,
                Lampu_Dashboard_Ket = x.Lampu_Dashboard_Ket,
                Lampu_Plafond_Depan_dan_Belakang = x.Lampu_Plafond_Depan_dan_Belakang,
                Lampu_Plafond_Depan_dan_Belakang_Ket = x.Lampu_Plafond_Depan_dan_Belakang_Ket,
                Klakson = x.Klakson,
                Klakson_Ket = x.Klakson_Ket,
                Antena = x.Antena,
                Antena_Ket = x.Antena_Ket,
                Tape_Radio_CD_DVD_TV_Player = x.Tape_Radio_CD_DVD_TV_Player,
                Tape_Radio_CD_DVD_TV_Player_Ket = x.Tape_Radio_CD_DVD_TV_Player_Ket,
                Remote_Tape_Radio_CD_DVD_TV_Player = x.Remote_Tape_Radio_CD_DVD_TV_Player,
                Remote_Tape_Radio_CD_DVD_TV_Player_Ket = x.Remote_Tape_Radio_CD_DVD_TV_Player_Ket,
                Alarm_Remote_Key = x.Alarm_Remote_Key,
                Alarm_Remote_Key_Ket = x.Alarm_Remote_Key_Ket,
                Central_Lock = x.Central_Lock,
                Central_Lock_Ket = x.Central_Lock_Ket,
                Power_Window = x.Power_Window,
                Power_Window_Ket = x.Power_Window_Ket,
                Switch_Mirror = x.Switch_Mirror,
                Switch_Mirror_Ket = x.Switch_Mirror_Ket,
                Air_Conditioner = x.Air_Conditioner,
                Air_Conditioner_Ket = x.Air_Conditioner_Ket,
                Safety_Belt = x.Safety_Belt,
                Safety_Belt_Ket = x.Safety_Belt_Ket,
                Karpet = x.Karpet,
                Karpet_Ket = x.Karpet_Ket,
                Lighter = x.Lighter,
                Lighter_Ket = x.Lighter_Ket,
                Asbak = x.Asbak,
                Asbak_Ket = x.Asbak_Ket,
                Sarung_Jok = x.Sarung_Jok,
                Sarung_Jok_Ket = x.Sarung_Jok_Ket,
                Sandaran_Kepala = x.Sandaran_Kepala,
                Sandaran_Kepala_Ket = x.Sandaran_Kepala_Ket,
                Spion_Dalam = x.Spion_Dalam,
                Spion_Dalam_Ket = x.Spion_Dalam_Ket,
                Wiper_Blade = x.Wiper_Blade,
                Wiper_Blade_Ket = x.Wiper_Blade_Ket,
                Windshield_Washer = x.Windshield_Washer,
                Windshield_Washer_Ket = x.Windshield_Washer_Ket,
                Talang_Air = x.Talang_Air,
                Talang_Air_Ket = x.Talang_Air_Ket,
                Fender_Lumpur_Depan_dan_Belakang = x.Fender_Lumpur_Depan_dan_Belakang,
                Fender_Lumpur_Depan_dan_Belakang_Ket = x.Fender_Lumpur_Depan_dan_Belakang_Ket,
                Spion_Kiri_Kanan = x.Spion_Kiri_Kanan,
                Spion_Kiri_Kanan_Ket = x.Spion_Kiri_Kanan_Ket,
                Tutup_Bensin = x.Tutup_Bensin,
                Tutup_Bensin_Ket = x.Tutup_Bensin_Ket,
                Emblem_Logo = x.Emblem_Logo,
                Emblem_Logo_Ket = x.Emblem_Logo_Ket,
                Kaca_Mobil_dan_Kaca_Film = x.Kaca_Mobil_dan_Kaca_Film,
                Kaca_Mobil_dan_Kaca_Film_Ket = x.Kaca_Mobil_dan_Kaca_Film_Ket,
                STNK = x.STNK,
                STNK_Ket = x.STNK_Ket,
                Buku_KIR_Stiker_Peneng = x.Buku_KIR_Stiker_Peneng,
                Buku_KIR_Stiker_Peneng_Ket = x.Buku_KIR_Stiker_Peneng_Ket,
                Owners_Manual_Book = x.Owners_Manual_Book,
                Owners_Manual_Book_Ket = x.Owners_Manual_Book_Ket,
                Buku_Service = x.Buku_Service,
                Buku_Service_Ket = x.Buku_Service_Ket,
                Ban_Serep = x.Ban_Serep,
                Ban_Serep_Ket = x.Ban_Serep_Ket,
                Kunci_Roda_Busi_Pas_Tang = x.Kunci_Roda_Busi_Pas_Tang,
                Kunci_Roda_Busi_Pas_Tang_Ket = x.Kunci_Roda_Busi_Pas_Tang_Ket,
                Kunci_Stir = x.Kunci_Stir,
                Kunci_Stir_Ket = x.Kunci_Stir_Ket,
                Dongkrak = x.Dongkrak,
                Dongkrak_Ket = x.Dongkrak_Ket,
                P3K = x.P3K,
                P3K_Ket = x.P3K_Ket,
                Segitiga_Pengaman = x.Segitiga_Pengaman,
                Segitiga_Pengaman_Ket = x.Segitiga_Pengaman_Ket,
                Lap_Kanebo = x.Lap_Kanebo,
                Lap_Kanebo_Ket = x.Lap_Kanebo_Ket,
                Foto_Kendaraan_Tampak_Depan = x.Foto_Kendaraan_Tampak_Depan,
                Foto_Kendaraan_Tampak_Belakang = x.Foto_Kendaraan_Tampak_Belakang,
                Foto_Kendaraan_Tampak_Samping_Kanan = x.Foto_Kendaraan_Tampak_Samping_Kanan,
                Foto_Kendaraan_Tampak_Samping_Kiri = x.Foto_Kendaraan_Tampak_Samping_Kiri,
                apar = x.apar,
                fuel = x.fuel,
                isi_tangki = x.isi_tangki,
                isi_tangki_ket = x.isi_tangki_ket,
                km = x.km,
                velg_ban = x.velg_ban,
                tutup_dop = x.tutup_dop,
                signature = x.signature,
                signature_image = x.signature_image,
                CreatedBy = x.CreatedBy
            }).FirstOrDefault();
            if (bstk == null)
            {
                return null;
            }

            return bstk;
        }

        public Result Delete(int id)
        {
            Result result = new Result();
            result.Status = "Error";
            if (!db.Tr_BSTKBefores.Any(x => x.BSTKBefore_ID == id && x.IsDeleted == false))
            {
                result.Message = "BSTK Before ID not exists";
            }
            else
            {
                var bstkBefore = db.Tr_BSTKBefores.Where(x => x.BSTKBefore_ID == id).FirstOrDefault();
                bstkBefore.IsDeleted = true;
                db.SaveChanges();
                result.Status = "Success";
            }
            return result;
        }

        private EntityTRUST db = new EntityTRUST();

        private bool Validasi(Tr_BSTKBefore BSTKBefore, ref string result)
        {
            if (!db.Ms_Customers.Any(x => x.Company_Name == BSTKBefore.Nama_Customer))
            {
                result = "Company Name does't exist!";
                return false;
            }
            else if (!db.Ms_Vehicles.Any(x => x.license_no == BSTKBefore.Nomor_Plat_Kendaraan))
            {
                result = "license no does't exist!";
                return false;
            }
            else if (!db.Cn_Users.Any(x => x.User_ID == BSTKBefore.CreatedBy))
            {
                result = "User Name does't exist!";
                return false;
            }
            else if (BSTKBefore.IsEdited && (int)BSTKBefore.BSTKBefore_ID == 0 )
            {
                result = "Must fill BSTKBefore_ID";
                return false;
            }
            else if (BSTKBefore.IsEdited && !db.Tr_BSTKBefores.Any(x => x.BSTKBefore_ID == BSTKBefore.BSTKBefore_ID))
            {
                result = "BSTKBefore_ID not found";
                return false;
            }
            return true;
        }
        public bool SaveImage(string ImgStr, string ImgName, string folder)
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
        // POST: api/BSTKBefore
        [ResponseType(typeof(Tr_BSTKBefore))]
        public IHttpActionResult PostTr_BSTKBefores(Tr_BSTKBefore BSTKBeforeRequest)
        {
            var results = new Result();
            results.Status = "Error";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string messages = "";
            if (!Validasi(BSTKBeforeRequest, ref messages))
            {
                results.Message = messages;
                return Json(results);
            }

            using (var dbs = db.Database.BeginTransaction())
            {
                try
                {
                    if (BSTKBeforeRequest.IsEdited == false)
                    {
                        //save data
                        var bstk = new Tr_BSTKBefores();
                        bstk.Customer_ID = db.Ms_Customers.Where(x => x.Company_Name == BSTKBeforeRequest.Nama_Customer).Select(x => x.Customer_ID).FirstOrDefault();
                        bstk.Vehicle_ID = db.Ms_Vehicles.Where(x => x.license_no == BSTKBeforeRequest.Nomor_Plat_Kendaraan).Select(x => x.Vehicle_id).FirstOrDefault();
                        bstk.Automatic_Light_Switch = BSTKBeforeRequest.Automatic_Light_Switch;
                        bstk.Automatic_Light_Switch_Ket = BSTKBeforeRequest.Automatic_Light_Switch_Ket;
                        bstk.Lampu_Kecil = BSTKBeforeRequest.Lampu_Kecil;
                        bstk.Lampu_Kecil_Ket = BSTKBeforeRequest.Lampu_Kecil_Ket;
                        bstk.Lampu_Dekat = BSTKBeforeRequest.Lampu_Dekat;
                        bstk.Lampu_Dekat_Ket = BSTKBeforeRequest.Lampu_Dekat_Ket;
                        bstk.Lampu_Jauh = BSTKBeforeRequest.Lampu_Jauh;
                        bstk.Lampu_Jauh_Ket = BSTKBeforeRequest.Lampu_Jauh_Ket;
                        bstk.Lampu_Kabut_Fog_Lamp = BSTKBeforeRequest.Lampu_Kabut_Fog_Lamp;
                        bstk.Lampu_Kabut_Fog_Lamp_Ket = BSTKBeforeRequest.Lampu_Kabut_Fog_Lamp_Ket;
                        bstk.Lampu_Sign_Depan = BSTKBeforeRequest.Lampu_Sign_Depan;
                        bstk.Lampu_Sign_Depan_Ket = BSTKBeforeRequest.Lampu_Sign_Depan_Ket;
                        bstk.Lampu_Sign_Belakang = BSTKBeforeRequest.Lampu_Sign_Belakang;
                        bstk.Lampu_Sign_Belakang_Ket = BSTKBeforeRequest.Lampu_Sign_Belakang_Ket;
                        bstk.Lampu_Belakang = BSTKBeforeRequest.Lampu_Belakang;
                        bstk.Lampu_Belakang_Ket = BSTKBeforeRequest.Lampu_Belakang_Ket;
                        bstk.Lampu_Rem = BSTKBeforeRequest.Lampu_Rem;
                        bstk.Lampu_Rem_Ket = BSTKBeforeRequest.Lampu_Rem_Ket;
                        bstk.Lampu_Mundur = BSTKBeforeRequest.Lampu_Mundur;
                        bstk.Lampu_Mundur_Ket = BSTKBeforeRequest.Lampu_Mundur_Ket;
                        bstk.Lampu_Dashboard = BSTKBeforeRequest.Lampu_Dashboard;
                        bstk.Lampu_Dashboard_Ket = BSTKBeforeRequest.Lampu_Dashboard_Ket;
                        bstk.Lampu_Plafond_Depan_dan_Belakang = BSTKBeforeRequest.Lampu_Plafond_Depan_dan_Belakang;
                        bstk.Lampu_Plafond_Depan_dan_Belakang_Ket = BSTKBeforeRequest.Lampu_Plafond_Depan_dan_Belakang_Ket;
                        bstk.Klakson = BSTKBeforeRequest.Klakson;
                        bstk.Klakson_Ket = BSTKBeforeRequest.Klakson_Ket;
                        bstk.Antena = BSTKBeforeRequest.Antena;
                        bstk.Antena_Ket = BSTKBeforeRequest.Antena_Ket;
                        bstk.Tape_Radio_CD_DVD_TV_Player = BSTKBeforeRequest.Tape_Radio_CD_DVD_TV_Player;
                        bstk.Tape_Radio_CD_DVD_TV_Player_Ket = BSTKBeforeRequest.Tape_Radio_CD_DVD_TV_Player_Ket;
                        bstk.Remote_Tape_Radio_CD_DVD_TV_Player = BSTKBeforeRequest.Remote_Tape_Radio_CD_DVD_TV_Player;
                        bstk.Remote_Tape_Radio_CD_DVD_TV_Player_Ket = BSTKBeforeRequest.Remote_Tape_Radio_CD_DVD_TV_Player_Ket;
                        bstk.Alarm_Remote_Key = BSTKBeforeRequest.Alarm_Remote_Key;
                        bstk.Alarm_Remote_Key_Ket = BSTKBeforeRequest.Alarm_Remote_Key_Ket;
                        bstk.Central_Lock = BSTKBeforeRequest.Central_Lock;
                        bstk.Central_Lock_Ket = BSTKBeforeRequest.Central_Lock_Ket;
                        bstk.Power_Window = BSTKBeforeRequest.Power_Window;
                        bstk.Power_Window_Ket = BSTKBeforeRequest.Power_Window_Ket;
                        bstk.Switch_Mirror = BSTKBeforeRequest.Switch_Mirror;
                        bstk.Switch_Mirror_Ket = BSTKBeforeRequest.Switch_Mirror_Ket;
                        bstk.Air_Conditioner = BSTKBeforeRequest.Air_Conditioner;
                        bstk.Air_Conditioner_Ket = BSTKBeforeRequest.Air_Conditioner_Ket;
                        bstk.Safety_Belt = BSTKBeforeRequest.Safety_Belt;
                        bstk.Safety_Belt_Ket = BSTKBeforeRequest.Safety_Belt_Ket;
                        bstk.Karpet = BSTKBeforeRequest.Karpet;
                        bstk.Karpet_Ket = BSTKBeforeRequest.Karpet_Ket;
                        bstk.Lighter = BSTKBeforeRequest.Lighter;
                        bstk.Lighter_Ket = BSTKBeforeRequest.Lighter_Ket;
                        bstk.Asbak = BSTKBeforeRequest.Asbak;
                        bstk.Asbak_Ket = BSTKBeforeRequest.Asbak_Ket;
                        bstk.Sarung_Jok = BSTKBeforeRequest.Sarung_Jok;
                        bstk.Sarung_Jok_Ket = BSTKBeforeRequest.Sarung_Jok_Ket;
                        bstk.Sandaran_Kepala = BSTKBeforeRequest.Sandaran_Kepala;
                        bstk.Sandaran_Kepala_Ket = BSTKBeforeRequest.Sandaran_Kepala_Ket;
                        bstk.Spion_Dalam = BSTKBeforeRequest.Spion_Dalam;
                        bstk.Spion_Dalam_Ket = BSTKBeforeRequest.Spion_Dalam_Ket;
                        bstk.Wiper_Blade = BSTKBeforeRequest.Wiper_Blade;
                        bstk.Wiper_Blade_Ket = BSTKBeforeRequest.Wiper_Blade_Ket;
                        bstk.Windshield_Washer = BSTKBeforeRequest.Windshield_Washer;
                        bstk.Windshield_Washer_Ket = BSTKBeforeRequest.Windshield_Washer_Ket;
                        bstk.Talang_Air = BSTKBeforeRequest.Talang_Air;
                        bstk.Talang_Air_Ket = BSTKBeforeRequest.Talang_Air_Ket;
                        bstk.Fender_Lumpur_Depan_dan_Belakang = BSTKBeforeRequest.Fender_Lumpur_Depan_dan_Belakang;
                        bstk.Fender_Lumpur_Depan_dan_Belakang_Ket = BSTKBeforeRequest.Fender_Lumpur_Depan_dan_Belakang_Ket;
                        bstk.Spion_Kiri_Kanan = BSTKBeforeRequest.Spion_Kiri_Kanan;
                        bstk.Spion_Kiri_Kanan_Ket = BSTKBeforeRequest.Spion_Kiri_Kanan_Ket;
                        bstk.Tutup_Bensin = BSTKBeforeRequest.Tutup_Bensin;
                        bstk.Tutup_Bensin_Ket = BSTKBeforeRequest.Tutup_Bensin_Ket;
                        bstk.Emblem_Logo = BSTKBeforeRequest.Emblem_Logo;
                        bstk.Emblem_Logo_Ket = BSTKBeforeRequest.Emblem_Logo_Ket;
                        bstk.Kaca_Mobil_dan_Kaca_Film = BSTKBeforeRequest.Kaca_Mobil_dan_Kaca_Film;
                        bstk.Kaca_Mobil_dan_Kaca_Film_Ket = BSTKBeforeRequest.Kaca_Mobil_dan_Kaca_Film_Ket;
                        bstk.STNK = BSTKBeforeRequest.STNK;
                        bstk.STNK_Ket = BSTKBeforeRequest.STNK_Ket;
                        bstk.Buku_KIR_Stiker_Peneng = BSTKBeforeRequest.Buku_KIR_Stiker_Peneng;
                        bstk.Buku_KIR_Stiker_Peneng_Ket = BSTKBeforeRequest.Buku_KIR_Stiker_Peneng_Ket;
                        bstk.Owners_Manual_Book = BSTKBeforeRequest.Owners_Manual_Book;
                        bstk.Owners_Manual_Book_Ket = BSTKBeforeRequest.Owners_Manual_Book_Ket;
                        bstk.Buku_Service = BSTKBeforeRequest.Buku_Service;
                        bstk.Buku_Service_Ket = BSTKBeforeRequest.Buku_Service_Ket;
                        bstk.Ban_Serep = BSTKBeforeRequest.Ban_Serep;
                        bstk.Ban_Serep_Ket = BSTKBeforeRequest.Ban_Serep_Ket;
                        bstk.Kunci_Roda_Busi_Pas_Tang = BSTKBeforeRequest.Kunci_Roda_Busi_Pas_Tang;
                        bstk.Kunci_Roda_Busi_Pas_Tang_Ket = BSTKBeforeRequest.Kunci_Roda_Busi_Pas_Tang_Ket;
                        bstk.Kunci_Stir = BSTKBeforeRequest.Kunci_Stir;
                        bstk.Kunci_Stir_Ket = BSTKBeforeRequest.Kunci_Stir_Ket;
                        bstk.Dongkrak = BSTKBeforeRequest.Dongkrak;
                        bstk.Dongkrak_Ket = BSTKBeforeRequest.Dongkrak_Ket;
                        bstk.P3K = BSTKBeforeRequest.P3K;
                        bstk.P3K_Ket = BSTKBeforeRequest.P3K_Ket;
                        bstk.Segitiga_Pengaman = BSTKBeforeRequest.Segitiga_Pengaman;
                        bstk.Segitiga_Pengaman_Ket = BSTKBeforeRequest.Segitiga_Pengaman_Ket;
                        bstk.Lap_Kanebo = BSTKBeforeRequest.Lap_Kanebo;
                        bstk.Lap_Kanebo_Ket = BSTKBeforeRequest.Lap_Kanebo_Ket;
                        bstk.Foto_Kendaraan_Tampak_Depan = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan;
                        bstk.Foto_Kendaraan_Tampak_Belakang = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang;
                        bstk.Foto_Kendaraan_Tampak_Samping_Kanan = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan;
                        bstk.Foto_Kendaraan_Tampak_Samping_Kiri = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri;
                        bstk.apar = BSTKBeforeRequest.apar;
                        bstk.fuel = BSTKBeforeRequest.fuel;
                        bstk.isi_tangki = BSTKBeforeRequest.isi_tangki;
                        bstk.isi_tangki_ket = BSTKBeforeRequest.isi_tangki_ket;
                        bstk.km = BSTKBeforeRequest.km;
                        bstk.velg_ban = BSTKBeforeRequest.velg_ban;
                        bstk.tutup_dop = BSTKBeforeRequest.tutup_dop;
                        bstk.signature = BSTKBeforeRequest.signature;
                        bstk.signature_image = BSTKBeforeRequest.signature_image;
                        bstk.CreatedDate = DateTime.Now;
                        bstk.CreatedBy = BSTKBeforeRequest.CreatedBy;
                        bstk.IsCompleted = false;
                        bstk.IsDeleted = false;
                        db.Tr_BSTKBefores.Add(bstk);
                        db.SaveChanges();
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Depan"))
                        {
                            results.Message = "Failed Save Image Tampak Depan";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Belakang"))
                        {
                            results.Message = "Failed Save Image Tampak Belakang";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Kanan"))
                        {
                            results.Message = "Failed Save Image Tampak Samping Kanan";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Kiri"))
                        {
                            results.Message = "Failed Save Image Tampak Samping Kiri";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.signature_image != "" && !SaveImage(BSTKBeforeRequest.signature_image, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Signature"))
                        {
                            results.Message = "Failed Save Image Tampak Signature";
                            return Json(results);
                        }
                        results.Status = "Success";
                        dbs.Commit();
                        return Json(results);
                    }
                    else {
                        //edit data
                        var bstk = db.Tr_BSTKBefores.Where(x => x.BSTKBefore_ID == BSTKBeforeRequest.BSTKBefore_ID).FirstOrDefault();
                        bstk.Automatic_Light_Switch = BSTKBeforeRequest.Automatic_Light_Switch;
                        bstk.Automatic_Light_Switch_Ket = BSTKBeforeRequest.Automatic_Light_Switch_Ket;
                        bstk.Lampu_Kecil = BSTKBeforeRequest.Lampu_Kecil;
                        bstk.Lampu_Kecil_Ket = BSTKBeforeRequest.Lampu_Kecil_Ket;
                        bstk.Lampu_Dekat = BSTKBeforeRequest.Lampu_Dekat;
                        bstk.Lampu_Dekat_Ket = BSTKBeforeRequest.Lampu_Dekat_Ket;
                        bstk.Lampu_Jauh = BSTKBeforeRequest.Lampu_Jauh;
                        bstk.Lampu_Jauh_Ket = BSTKBeforeRequest.Lampu_Jauh_Ket;
                        bstk.Lampu_Kabut_Fog_Lamp = BSTKBeforeRequest.Lampu_Kabut_Fog_Lamp;
                        bstk.Lampu_Kabut_Fog_Lamp_Ket = BSTKBeforeRequest.Lampu_Kabut_Fog_Lamp_Ket;
                        bstk.Lampu_Sign_Depan = BSTKBeforeRequest.Lampu_Sign_Depan;
                        bstk.Lampu_Sign_Depan_Ket = BSTKBeforeRequest.Lampu_Sign_Depan_Ket;
                        bstk.Lampu_Sign_Belakang = BSTKBeforeRequest.Lampu_Sign_Belakang;
                        bstk.Lampu_Sign_Belakang_Ket = BSTKBeforeRequest.Lampu_Sign_Belakang_Ket;
                        bstk.Lampu_Belakang = BSTKBeforeRequest.Lampu_Belakang;
                        bstk.Lampu_Belakang_Ket = BSTKBeforeRequest.Lampu_Belakang_Ket;
                        bstk.Lampu_Rem = BSTKBeforeRequest.Lampu_Rem;
                        bstk.Lampu_Rem_Ket = BSTKBeforeRequest.Lampu_Rem_Ket;
                        bstk.Lampu_Mundur = BSTKBeforeRequest.Lampu_Mundur;
                        bstk.Lampu_Mundur_Ket = BSTKBeforeRequest.Lampu_Mundur_Ket;
                        bstk.Lampu_Dashboard = BSTKBeforeRequest.Lampu_Dashboard;
                        bstk.Lampu_Dashboard_Ket = BSTKBeforeRequest.Lampu_Dashboard_Ket;
                        bstk.Lampu_Plafond_Depan_dan_Belakang = BSTKBeforeRequest.Lampu_Plafond_Depan_dan_Belakang;
                        bstk.Lampu_Plafond_Depan_dan_Belakang_Ket = BSTKBeforeRequest.Lampu_Plafond_Depan_dan_Belakang_Ket;
                        bstk.Klakson = BSTKBeforeRequest.Klakson;
                        bstk.Klakson_Ket = BSTKBeforeRequest.Klakson_Ket;
                        bstk.Antena = BSTKBeforeRequest.Antena;
                        bstk.Antena_Ket = BSTKBeforeRequest.Antena_Ket;
                        bstk.Tape_Radio_CD_DVD_TV_Player = BSTKBeforeRequest.Tape_Radio_CD_DVD_TV_Player;
                        bstk.Tape_Radio_CD_DVD_TV_Player_Ket = BSTKBeforeRequest.Tape_Radio_CD_DVD_TV_Player_Ket;
                        bstk.Remote_Tape_Radio_CD_DVD_TV_Player = BSTKBeforeRequest.Remote_Tape_Radio_CD_DVD_TV_Player;
                        bstk.Remote_Tape_Radio_CD_DVD_TV_Player_Ket = BSTKBeforeRequest.Remote_Tape_Radio_CD_DVD_TV_Player_Ket;
                        bstk.Alarm_Remote_Key = BSTKBeforeRequest.Alarm_Remote_Key;
                        bstk.Alarm_Remote_Key_Ket = BSTKBeforeRequest.Alarm_Remote_Key_Ket;
                        bstk.Central_Lock = BSTKBeforeRequest.Central_Lock;
                        bstk.Central_Lock_Ket = BSTKBeforeRequest.Central_Lock_Ket;
                        bstk.Power_Window = BSTKBeforeRequest.Power_Window;
                        bstk.Power_Window_Ket = BSTKBeforeRequest.Power_Window_Ket;
                        bstk.Switch_Mirror = BSTKBeforeRequest.Switch_Mirror;
                        bstk.Switch_Mirror_Ket = BSTKBeforeRequest.Switch_Mirror_Ket;
                        bstk.Air_Conditioner = BSTKBeforeRequest.Air_Conditioner;
                        bstk.Air_Conditioner_Ket = BSTKBeforeRequest.Air_Conditioner_Ket;
                        bstk.Safety_Belt = BSTKBeforeRequest.Safety_Belt;
                        bstk.Safety_Belt_Ket = BSTKBeforeRequest.Safety_Belt_Ket;
                        bstk.Karpet = BSTKBeforeRequest.Karpet;
                        bstk.Karpet_Ket = BSTKBeforeRequest.Karpet_Ket;
                        bstk.Lighter = BSTKBeforeRequest.Lighter;
                        bstk.Lighter_Ket = BSTKBeforeRequest.Lighter_Ket;
                        bstk.Asbak = BSTKBeforeRequest.Asbak;
                        bstk.Asbak_Ket = BSTKBeforeRequest.Asbak_Ket;
                        bstk.Sarung_Jok = BSTKBeforeRequest.Sarung_Jok;
                        bstk.Sarung_Jok_Ket = BSTKBeforeRequest.Sarung_Jok_Ket;
                        bstk.Sandaran_Kepala = BSTKBeforeRequest.Sandaran_Kepala;
                        bstk.Sandaran_Kepala_Ket = BSTKBeforeRequest.Sandaran_Kepala_Ket;
                        bstk.Spion_Dalam = BSTKBeforeRequest.Spion_Dalam;
                        bstk.Spion_Dalam_Ket = BSTKBeforeRequest.Spion_Dalam_Ket;
                        bstk.Wiper_Blade = BSTKBeforeRequest.Wiper_Blade;
                        bstk.Wiper_Blade_Ket = BSTKBeforeRequest.Wiper_Blade_Ket;
                        bstk.Windshield_Washer = BSTKBeforeRequest.Windshield_Washer;
                        bstk.Windshield_Washer_Ket = BSTKBeforeRequest.Windshield_Washer_Ket;
                        bstk.Talang_Air = BSTKBeforeRequest.Talang_Air;
                        bstk.Talang_Air_Ket = BSTKBeforeRequest.Talang_Air_Ket;
                        bstk.Fender_Lumpur_Depan_dan_Belakang = BSTKBeforeRequest.Fender_Lumpur_Depan_dan_Belakang;
                        bstk.Fender_Lumpur_Depan_dan_Belakang_Ket = BSTKBeforeRequest.Fender_Lumpur_Depan_dan_Belakang_Ket;
                        bstk.Spion_Kiri_Kanan = BSTKBeforeRequest.Spion_Kiri_Kanan;
                        bstk.Spion_Kiri_Kanan_Ket = BSTKBeforeRequest.Spion_Kiri_Kanan_Ket;
                        bstk.Tutup_Bensin = BSTKBeforeRequest.Tutup_Bensin;
                        bstk.Tutup_Bensin_Ket = BSTKBeforeRequest.Tutup_Bensin_Ket;
                        bstk.Emblem_Logo = BSTKBeforeRequest.Emblem_Logo;
                        bstk.Emblem_Logo_Ket = BSTKBeforeRequest.Emblem_Logo_Ket;
                        bstk.Kaca_Mobil_dan_Kaca_Film = BSTKBeforeRequest.Kaca_Mobil_dan_Kaca_Film;
                        bstk.Kaca_Mobil_dan_Kaca_Film_Ket = BSTKBeforeRequest.Kaca_Mobil_dan_Kaca_Film_Ket;
                        bstk.STNK = BSTKBeforeRequest.STNK;
                        bstk.STNK_Ket = BSTKBeforeRequest.STNK_Ket;
                        bstk.Buku_KIR_Stiker_Peneng = BSTKBeforeRequest.Buku_KIR_Stiker_Peneng;
                        bstk.Buku_KIR_Stiker_Peneng_Ket = BSTKBeforeRequest.Buku_KIR_Stiker_Peneng_Ket;
                        bstk.Owners_Manual_Book = BSTKBeforeRequest.Owners_Manual_Book;
                        bstk.Owners_Manual_Book_Ket = BSTKBeforeRequest.Owners_Manual_Book_Ket;
                        bstk.Buku_Service = BSTKBeforeRequest.Buku_Service;
                        bstk.Buku_Service_Ket = BSTKBeforeRequest.Buku_Service_Ket;
                        bstk.Ban_Serep = BSTKBeforeRequest.Ban_Serep;
                        bstk.Ban_Serep_Ket = BSTKBeforeRequest.Ban_Serep_Ket;
                        bstk.Kunci_Roda_Busi_Pas_Tang = BSTKBeforeRequest.Kunci_Roda_Busi_Pas_Tang;
                        bstk.Kunci_Roda_Busi_Pas_Tang_Ket = BSTKBeforeRequest.Kunci_Roda_Busi_Pas_Tang_Ket;
                        bstk.Kunci_Stir = BSTKBeforeRequest.Kunci_Stir;
                        bstk.Kunci_Stir_Ket = BSTKBeforeRequest.Kunci_Stir_Ket;
                        bstk.Dongkrak = BSTKBeforeRequest.Dongkrak;
                        bstk.Dongkrak_Ket = BSTKBeforeRequest.Dongkrak_Ket;
                        bstk.P3K = BSTKBeforeRequest.P3K;
                        bstk.P3K_Ket = BSTKBeforeRequest.P3K_Ket;
                        bstk.Segitiga_Pengaman = BSTKBeforeRequest.Segitiga_Pengaman;
                        bstk.Segitiga_Pengaman_Ket = BSTKBeforeRequest.Segitiga_Pengaman_Ket;
                        bstk.Lap_Kanebo = BSTKBeforeRequest.Lap_Kanebo;
                        bstk.Lap_Kanebo_Ket = BSTKBeforeRequest.Lap_Kanebo_Ket;
                        bstk.Foto_Kendaraan_Tampak_Depan = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan;
                        bstk.Foto_Kendaraan_Tampak_Belakang = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang;
                        bstk.Foto_Kendaraan_Tampak_Samping_Kanan = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan;
                        bstk.Foto_Kendaraan_Tampak_Samping_Kiri = BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri;
                        bstk.apar = BSTKBeforeRequest.apar;
                        bstk.fuel = BSTKBeforeRequest.fuel;
                        bstk.isi_tangki = BSTKBeforeRequest.isi_tangki;
                        bstk.isi_tangki_ket = BSTKBeforeRequest.isi_tangki_ket;
                        bstk.km = BSTKBeforeRequest.km;
                        bstk.velg_ban = BSTKBeforeRequest.velg_ban;
                        bstk.tutup_dop = BSTKBeforeRequest.tutup_dop;
                        bstk.signature = BSTKBeforeRequest.signature;
                        //bstk.signature_image = BSTKBeforeRequest.signature_image;
                        bstk.ModifiedDate = DateTime.Now;
                        bstk.ModifiedBy = BSTKBeforeRequest.CreatedBy;
                        db.SaveChanges();
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Depan, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Depan"))
                        {
                            results.Message = "Failed Save Image Tampak Depan";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Belakang, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Belakang"))
                        {
                            results.Message = "Failed Save Image Tampak Belakang";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kanan, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Kanan"))
                        {
                            results.Message = "Failed Save Image Tampak Samping Kanan";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri != "" && !SaveImage(BSTKBeforeRequest.Foto_Kendaraan_Tampak_Samping_Kiri, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Kiri"))
                        {
                            results.Message = "Failed Save Image Tampak Samping Kiri";
                            return Json(results);
                        }
                        if (BSTKBeforeRequest.signature_image != "" && !SaveImage(BSTKBeforeRequest.signature_image, bstk.BSTKBefore_ID.ToString(), "BSTKBefore\\Signature"))
                        {
                            results.Message = "Failed Save Image Tampak Signature";
                            return Json(results);
                        }
                        results.Status = "Success";
                        dbs.Commit();
                        return Json(results);
                    }
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