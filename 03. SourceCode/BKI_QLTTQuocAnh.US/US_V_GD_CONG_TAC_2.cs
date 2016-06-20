///************************************************
/// Generated by: tuyennt
/// Date: 12-04-2016 02:48:09
/// Goal: Create User Service Class for V_GD_CONG_TAC_2
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CONG_TAC_2
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_V_GD_CONG_TAC_2 : US_Object
    {
        private const string c_TableName = "V_GD_CONG_TAC_2";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public decimal dcID_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_VIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHAN_VIEN"] = value;
            }
        }

        public bool IsID_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("ID_NHAN_VIEN");
        }

        public void SetID_NHAN_VIENNull()
        {
            pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
        }

        public decimal dcID_QUYET_DINH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUYET_DINH"] = value;
            }
        }

        public bool IsID_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("ID_QUYET_DINH");
        }

        public void SetID_QUYET_DINHNull()
        {
            pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI"] = value;
            }
        }

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU"] = value;
            }
        }

        public bool IsNGAY_BAT_DAUNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU");
        }

        public void SetNGAY_BAT_DAUNull()
        {
            pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC"] = value;
            }
        }

        public bool IsNGAY_KET_THUCNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC");
        }

        public void SetNGAY_KET_THUCNull()
        {
            pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_LAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_LAP"] = value;
            }
        }

        public bool IsNGAY_LAPNull()
        {
            return pm_objDR.IsNull("NGAY_LAP");
        }

        public void SetNGAY_LAPNull()
        {
            pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_SUA
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_SUA", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_SUA"] = value;
            }
        }

        public bool IsNGAY_SUANull()
        {
            return pm_objDR.IsNull("NGAY_SUA");
        }

        public void SetNGAY_SUANull()
        {
            pm_objDR["NGAY_SUA"] = System.Convert.DBNull;
        }

        public string strNGUOI_LAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_LAP"] = value;
            }
        }

        public bool IsNGUOI_LAPNull()
        {
            return pm_objDR.IsNull("NGUOI_LAP");
        }

        public void SetNGUOI_LAPNull()
        {
            pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
        }

        public string strNGUOI_SUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_SUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_SUA"] = value;
            }
        }

        public bool IsNGUOI_SUANull()
        {
            return pm_objDR.IsNull("NGUOI_SUA");
        }

        public void SetNGUOI_SUANull()
        {
            pm_objDR["NGUOI_SUA"] = System.Convert.DBNull;
        }

        public string strDA_XOA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DA_XOA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DA_XOA"] = value;
            }
        }

        public bool IsDA_XOANull()
        {
            return pm_objDR.IsNull("DA_XOA");
        }

        public void SetDA_XOANull()
        {
            pm_objDR["DA_XOA"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_CONG_TAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CONG_TAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_CONG_TAC"] = value;
            }
        }

        public bool IsID_LOAI_CONG_TACNull()
        {
            return pm_objDR.IsNull("ID_LOAI_CONG_TAC");
        }

        public void SetID_LOAI_CONG_TACNull()
        {
            pm_objDR["ID_LOAI_CONG_TAC"] = System.Convert.DBNull;
        }

        public decimal dcID_VI_TRI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_VI_TRI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_VI_TRI"] = value;
            }
        }

        public bool IsID_VI_TRINull()
        {
            return pm_objDR.IsNull("ID_VI_TRI");
        }

        public void SetID_VI_TRINull()
        {
            pm_objDR["ID_VI_TRI"] = System.Convert.DBNull;
        }

        public string strTEN_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DON_VI"] = value;
            }
        }

        public bool IsTEN_DON_VINull()
        {
            return pm_objDR.IsNull("TEN_DON_VI");
        }

        public void SetTEN_DON_VINull()
        {
            pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
        }

        public string strMA_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DON_VI"] = value;
            }
        }

        public bool IsMA_DON_VINull()
        {
            return pm_objDR.IsNull("MA_DON_VI");
        }

        public void SetMA_DON_VINull()
        {
            pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
        }

        public string strLOAI_CONG_TAC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_CONG_TAC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_CONG_TAC"] = value;
            }
        }

        public bool IsLOAI_CONG_TACNull()
        {
            return pm_objDR.IsNull("LOAI_CONG_TAC");
        }

        public void SetLOAI_CONG_TACNull()
        {
            pm_objDR["LOAI_CONG_TAC"] = System.Convert.DBNull;
        }

        public string strCHUC_DANH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHUC_DANH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHUC_DANH"] = value;
            }
        }

        public bool IsCHUC_DANHNull()
        {
            return pm_objDR.IsNull("CHUC_DANH");
        }

        public void SetCHUC_DANHNull()
        {
            pm_objDR["CHUC_DANH"] = System.Convert.DBNull;
        }

        public string strMA_NV
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_NV"] = value;
            }
        }

        public bool IsMA_NVNull()
        {
            return pm_objDR.IsNull("MA_NV");
        }

        public void SetMA_NVNull()
        {
            pm_objDR["MA_NV"] = System.Convert.DBNull;
        }

        public string strHO_DEM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_DEM"] = value;
            }
        }

        public bool IsHO_DEMNull()
        {
            return pm_objDR.IsNull("HO_DEM");
        }

        public void SetHO_DEMNull()
        {
            pm_objDR["HO_DEM"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public string strHO_TEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN"] = value;
            }
        }

        public bool IsHO_TENNull()
        {
            return pm_objDR.IsNull("HO_TEN");
        }

        public void SetHO_TENNull()
        {
            pm_objDR["HO_TEN"] = System.Convert.DBNull;
        }

        public string strGIOI_TINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GIOI_TINH"] = value;
            }
        }

        public bool IsGIOI_TINHNull()
        {
            return pm_objDR.IsNull("GIOI_TINH");
        }

        public void SetGIOI_TINHNull()
        {
            pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
        }

        public string strEMAIL
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL"] = value;
            }
        }

        public bool IsEMAILNull()
        {
            return pm_objDR.IsNull("EMAIL");
        }

        public void SetEMAILNull()
        {
            pm_objDR["EMAIL"] = System.Convert.DBNull;
        }

        public string strSDT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT"] = value;
            }
        }

        public bool IsSDTNull()
        {
            return pm_objDR.IsNull("SDT");
        }

        public void SetSDTNull()
        {
            pm_objDR["SDT"] = System.Convert.DBNull;
        }

        public string strSO_TAI_KHOAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_TAI_KHOAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_TAI_KHOAN"] = value;
            }
        }

        public bool IsSO_TAI_KHOANNull()
        {
            return pm_objDR.IsNull("SO_TAI_KHOAN");
        }

        public void SetSO_TAI_KHOANNull()
        {
            pm_objDR["SO_TAI_KHOAN"] = System.Convert.DBNull;
        }

        public string strNGAN_HANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGAN_HANG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGAN_HANG"] = value;
            }
        }

        public bool IsNGAN_HANGNull()
        {
            return pm_objDR.IsNull("NGAN_HANG");
        }

        public void SetNGAN_HANGNull()
        {
            pm_objDR["NGAN_HANG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_THE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_THE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP_THE"] = value;
            }
        }

        public bool IsNGAY_CAP_THENull()
        {
            return pm_objDR.IsNull("NGAY_CAP_THE");
        }

        public void SetNGAY_CAP_THENull()
        {
            pm_objDR["NGAY_CAP_THE"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_HET_HAN_THE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HAN_THE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_HET_HAN_THE"] = value;
            }
        }

        public bool IsNGAY_HET_HAN_THENull()
        {
            return pm_objDR.IsNull("NGAY_HET_HAN_THE");
        }

        public void SetNGAY_HET_HAN_THENull()
        {
            pm_objDR["NGAY_HET_HAN_THE"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_SINH
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_SINH"] = value;
            }
        }

        public bool IsNGAY_SINHNull()
        {
            return pm_objDR.IsNull("NGAY_SINH");
        }

        public void SetNGAY_SINHNull()
        {
            pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
        }

        public string strHON_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HON_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HON_NHAN"] = value;
            }
        }

        public bool IsHON_NHANNull()
        {
            return pm_objDR.IsNull("HON_NHAN");
        }

        public void SetHON_NHANNull()
        {
            pm_objDR["HON_NHAN"] = System.Convert.DBNull;
        }

        public string strSO_CMT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_CMT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_CMT"] = value;
            }
        }

        public bool IsSO_CMTNull()
        {
            return pm_objDR.IsNull("SO_CMT");
        }

        public void SetSO_CMTNull()
        {
            pm_objDR["SO_CMT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP"] = value;
            }
        }

        public bool IsNGAY_CAPNull()
        {
            return pm_objDR.IsNull("NGAY_CAP");
        }

        public void SetNGAY_CAPNull()
        {
            pm_objDR["NGAY_CAP"] = System.Convert.DBNull;
        }

        public string strNOI_CAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_CAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_CAP"] = value;
            }
        }

        public bool IsNOI_CAPNull()
        {
            return pm_objDR.IsNull("NOI_CAP");
        }

        public void SetNOI_CAPNull()
        {
            pm_objDR["NOI_CAP"] = System.Convert.DBNull;
        }

        public string strQUOC_TICH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "QUOC_TICH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["QUOC_TICH"] = value;
            }
        }

        public bool IsQUOC_TICHNull()
        {
            return pm_objDR.IsNull("QUOC_TICH");
        }

        public void SetQUOC_TICHNull()
        {
            pm_objDR["QUOC_TICH"] = System.Convert.DBNull;
        }

        public string strDAN_TOC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DAN_TOC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DAN_TOC"] = value;
            }
        }

        public bool IsDAN_TOCNull()
        {
            return pm_objDR.IsNull("DAN_TOC");
        }

        public void SetDAN_TOCNull()
        {
            pm_objDR["DAN_TOC"] = System.Convert.DBNull;
        }

        public string strTON_GIAO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TON_GIAO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TON_GIAO"] = value;
            }
        }

        public bool IsTON_GIAONull()
        {
            return pm_objDR.IsNull("TON_GIAO");
        }

        public void SetTON_GIAONull()
        {
            pm_objDR["TON_GIAO"] = System.Convert.DBNull;
        }

        public string strNOI_SINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_SINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_SINH"] = value;
            }
        }

        public bool IsNOI_SINHNull()
        {
            return pm_objDR.IsNull("NOI_SINH");
        }

        public void SetNOI_SINHNull()
        {
            pm_objDR["NOI_SINH"] = System.Convert.DBNull;
        }

        public string strQUE_QUAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "QUE_QUAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["QUE_QUAN"] = value;
            }
        }

        public bool IsQUE_QUANNull()
        {
            return pm_objDR.IsNull("QUE_QUAN");
        }

        public void SetQUE_QUANNull()
        {
            pm_objDR["QUE_QUAN"] = System.Convert.DBNull;
        }

        public string strDIA_CHI_THUONG_TRU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI_THUONG_TRU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI_THUONG_TRU"] = value;
            }
        }

        public bool IsDIA_CHI_THUONG_TRUNull()
        {
            return pm_objDR.IsNull("DIA_CHI_THUONG_TRU");
        }

        public void SetDIA_CHI_THUONG_TRUNull()
        {
            pm_objDR["DIA_CHI_THUONG_TRU"] = System.Convert.DBNull;
        }

        public string strDIA_CHI_TAM_TRU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI_TAM_TRU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI_TAM_TRU"] = value;
            }
        }

        public bool IsDIA_CHI_TAM_TRUNull()
        {
            return pm_objDR.IsNull("DIA_CHI_TAM_TRU");
        }

        public void SetDIA_CHI_TAM_TRUNull()
        {
            pm_objDR["DIA_CHI_TAM_TRU"] = System.Convert.DBNull;
        }

        public string strDIA_CHI_LIEN_LAC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI_LIEN_LAC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI_LIEN_LAC"] = value;
            }
        }

        public bool IsDIA_CHI_LIEN_LACNull()
        {
            return pm_objDR.IsNull("DIA_CHI_LIEN_LAC");
        }

        public void SetDIA_CHI_LIEN_LACNull()
        {
            pm_objDR["DIA_CHI_LIEN_LAC"] = System.Convert.DBNull;
        }

        public string strMA_SO_THUE_CA_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_SO_THUE_CA_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_SO_THUE_CA_NHAN"] = value;
            }
        }

        public bool IsMA_SO_THUE_CA_NHANNull()
        {
            return pm_objDR.IsNull("MA_SO_THUE_CA_NHAN");
        }

        public void SetMA_SO_THUE_CA_NHANNull()
        {
            pm_objDR["MA_SO_THUE_CA_NHAN"] = System.Convert.DBNull;
        }

        public string strCHUYEN_MON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHUYEN_MON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHUYEN_MON"] = value;
            }
        }

        public bool IsCHUYEN_MONNull()
        {
            return pm_objDR.IsNull("CHUYEN_MON");
        }

        public void SetCHUYEN_MONNull()
        {
            pm_objDR["CHUYEN_MON"] = System.Convert.DBNull;
        }

        public decimal dcTRINH_DO_VAN_HOA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TRINH_DO_VAN_HOA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TRINH_DO_VAN_HOA"] = value;
            }
        }

        public bool IsTRINH_DO_VAN_HOANull()
        {
            return pm_objDR.IsNull("TRINH_DO_VAN_HOA");
        }

        public void SetTRINH_DO_VAN_HOANull()
        {
            pm_objDR["TRINH_DO_VAN_HOA"] = System.Convert.DBNull;
        }

        public string strNAM_TOT_NGHIEP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NAM_TOT_NGHIEP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NAM_TOT_NGHIEP"] = value;
            }
        }

        public bool IsNAM_TOT_NGHIEPNull()
        {
            return pm_objDR.IsNull("NAM_TOT_NGHIEP");
        }

        public void SetNAM_TOT_NGHIEPNull()
        {
            pm_objDR["NAM_TOT_NGHIEP"] = System.Convert.DBNull;
        }

        public string strTOT_NGHIEP_TAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TOT_NGHIEP_TAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TOT_NGHIEP_TAI"] = value;
            }
        }

        public bool IsTOT_NGHIEP_TAINull()
        {
            return pm_objDR.IsNull("TOT_NGHIEP_TAI");
        }

        public void SetTOT_NGHIEP_TAINull()
        {
            pm_objDR["TOT_NGHIEP_TAI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_VAO_HANG_KHONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_VAO_HANG_KHONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_VAO_HANG_KHONG"] = value;
            }
        }

        public bool IsNGAY_VAO_HANG_KHONGNull()
        {
            return pm_objDR.IsNull("NGAY_VAO_HANG_KHONG");
        }

        public void SetNGAY_VAO_HANG_KHONGNull()
        {
            pm_objDR["NGAY_VAO_HANG_KHONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_TIEP_NHAN_VAO_TCT
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_TIEP_NHAN_VAO_TCT", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_TIEP_NHAN_VAO_TCT"] = value;
            }
        }

        public bool IsNGAY_TIEP_NHAN_VAO_TCTNull()
        {
            return pm_objDR.IsNull("NGAY_TIEP_NHAN_VAO_TCT");
        }

        public void SetNGAY_TIEP_NHAN_VAO_TCTNull()
        {
            pm_objDR["NGAY_TIEP_NHAN_VAO_TCT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CHINH_THUC_TIEP_NHAN
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CHINH_THUC_TIEP_NHAN", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CHINH_THUC_TIEP_NHAN"] = value;
            }
        }

        public bool IsNGAY_CHINH_THUC_TIEP_NHANNull()
        {
            return pm_objDR.IsNull("NGAY_CHINH_THUC_TIEP_NHAN");
        }

        public void SetNGAY_CHINH_THUC_TIEP_NHANNull()
        {
            pm_objDR["NGAY_CHINH_THUC_TIEP_NHAN"] = System.Convert.DBNull;
        }

        public string strNGUOI_BAO_LANH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_BAO_LANH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_BAO_LANH"] = value;
            }
        }

        public bool IsNGUOI_BAO_LANHNull()
        {
            return pm_objDR.IsNull("NGUOI_BAO_LANH");
        }

        public void SetNGUOI_BAO_LANHNull()
        {
            pm_objDR["NGUOI_BAO_LANH"] = System.Convert.DBNull;
        }

        public string strMA_TRA_CUU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_TRA_CUU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_TRA_CUU"] = value;
            }
        }

        public bool IsMA_TRA_CUUNull()
        {
            return pm_objDR.IsNull("MA_TRA_CUU");
        }

        public void SetMA_TRA_CUUNull()
        {
            pm_objDR["MA_TRA_CUU"] = System.Convert.DBNull;
        }

        public decimal dcTHU_TU_CHUC_VU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THU_TU_CHUC_VU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THU_TU_CHUC_VU"] = value;
            }
        }

        public bool IsTHU_TU_CHUC_VUNull()
        {
            return pm_objDR.IsNull("THU_TU_CHUC_VU");
        }

        public void SetTHU_TU_CHUC_VUNull()
        {
            pm_objDR["THU_TU_CHUC_VU"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_CONG_TAC_2()
        {
            pm_objDS = new DS_V_GD_CONG_TAC_2();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_CONG_TAC_2(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_CONG_TAC_2(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_CONG_TAC_2();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
    }
}
