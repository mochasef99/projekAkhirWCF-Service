﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service_Projek
{
    [ServiceContract]
    public interface IService1
    {
        //BARANG
        [OperationContract]
        [WebInvoke(
           Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getallbarang"
           )]
        List<dataBarang> GetSemuaBarang();

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangid/id={Id}"
          )]
        dataBarang GetBarangID(string id);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangnama/nama={Nama}"
          )]
        List<dataBarang> GetBarangNama(string nama);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangjenis/jenis={Jenis}"
          )]
        List<dataBarang> GetBarangJenis(string jenis);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangmerek/merek={Merek}"
          )]
        List<dataBarang> GetBarangMerek(string merek);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangnamajenismerek/nama={Nama}/jenis={Jenis}/merek={Merek}"
          )]
        List<dataBarang> GetBarangNamaJenisMerek(string nama, string jenis, string merek);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "addbarang"
          )]
        void AddBarang(dataBarang db);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updatebarang"
          )]
        void UpdateBarang(dataBarang db);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "deletebarang/id={Id}"
          )]
        void HapusBarang(string id);

        //----------------------------------------------------
        //ADMIN
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getadmin/nama={Nama}"
          )]
        dataAdmin GetAdmin(string nama);

        //----------------------------------------------------
        //USER
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getuser/nama={Nama}"
          )]
<<<<<<< HEAD
        dataPengguna GetUser(string nama);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
=======
        dataUser GetUser(string Nama);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
>>>>>>> 8bfc965dbc678919c4bd13e4c41a22b15a28be0b
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "cariid/hp={Hp}"
          )]
        int updatehp (string hp);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "adduser"
          )]
        string AddUser(dataPengguna du);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updateuser"
          )]
        string UpdateUser(dataPengguna du);

        //----------------------------------------------------
        //TRANSAKSI
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "gettransaksi/idUser={IdUser}"
          )]
        List<dataTransaksi> GetTransaksi(string idUser);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "addtransaksi"
          )]
        string AddTransaksi(dataTransaksi dt);

        [OperationContract]
        [WebInvoke(
           Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalltransaksiview"
           )]
        List<dataView> GetSemuaTransaksiView();

        [OperationContract]
        [WebInvoke(
           Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalltransaksiviewnama/nama={Nama}"
           )]
        List<dataView> GetSemuaTransaksiViewUser(string nama);

        [OperationContract]
        [WebInvoke(
           Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalltransaksiviewid/id={Id}"
           )]
        List<dataView> GetSemuaTransaksiViewId(string id);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalltransaksiviewstatus/status={status}"
           )]
        List<dataView> GetSemuaTransaksiViewStatus(string status);

        [OperationContract]
        [WebInvoke(
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updatetransaksi"
          )]
        void UpdateTransaksi(dataTransaksi dt);
    }
        
    [DataContract]
    public class dataAdmin
    {
        [DataMember]
        public int ID_Admin { get; set; }
        [DataMember]
        public string Nama_Admin { get; set; }
        [DataMember]
        public string Password { get; set; }
    }

    [DataContract]
    public class dataPengguna
    {
        [DataMember]
        public int ID_User { get; set; }
        [DataMember]
        public string Nama_User { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Alamat { get; set; }
        [DataMember]
        public string No_Telpon { get; set; }
    }

    [DataContract]
    public class dataBarang
    {
        [DataMember]
        public int ID_Barang { get; set; }
        [DataMember]
        public string Nama_Barang { get; set; }
        [DataMember]
        public string Jenis_Barang { get; set; }
        [DataMember]
        public string Merek { get; set; }
        [DataMember]
        public int Harga { get; set; }
        [DataMember]
        public int Stok { get; set; }
        [DataMember]
        public string Foto { get; set; }
    }

    [DataContract]
    public class dataTransaksi
    {
        [DataMember]
        public int ID_Transaksi { get; set; }
        [DataMember]
        public int ID_User { get; set; }
        [DataMember]
        public int ID_Barang { get; set; }
        [DataMember]
        public int ID_Admin { get; set; }
        [DataMember]
        public int Total_Harga { get; set; }
        [DataMember]
        public DateTime Tanggal_Transaksi { get; set; }
        [DataMember]
        public string Status { get; set; }
    }

    [DataContract]
    public class dataView
    {
        [DataMember]
        public int ID_Transaksi { get; set; }
        [DataMember]
        public string Nama_User { get; set; }
        [DataMember]
        public string Nama_Barang { get; set; }
        [DataMember]
        public string Nama_Admin { get; set; }
        [DataMember]
        public int Total_Harga { get; set; }
        [DataMember]
        public DateTime Tanggal_Transaksi { get; set; }
        [DataMember]
        public string No_Telpon { get; set; }
        [DataMember]
        public string Alamat { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
