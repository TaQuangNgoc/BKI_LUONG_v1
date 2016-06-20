///************************************************
/// Generated by: sonpt
/// Date: 11/04/2016 04:02:05
/// Goal: Create User Service Class for V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG
///************************************************
/// <summary>
/// Create User Service Class for V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG : US_Object
    {
        private const string c_TableName = "V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG";
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

        public decimal dcID_LOAI_TRANG_THAI_LD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TRANG_THAI_LD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_TRANG_THAI_LD"] = value;
            }
        }

        public bool IsID_LOAI_TRANG_THAI_LDNull()
        {
            return pm_objDR.IsNull("ID_LOAI_TRANG_THAI_LD");
        }

        public void SetID_LOAI_TRANG_THAI_LDNull()
        {
            pm_objDR["ID_LOAI_TRANG_THAI_LD"] = System.Convert.DBNull;
        }

        public string strTEN_LOAI_TRANG_THAI_LD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOAI_TRANG_THAI_LD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOAI_TRANG_THAI_LD"] = value;
            }
        }

        public bool IsTEN_LOAI_TRANG_THAI_LDNull()
        {
            return pm_objDR.IsNull("TEN_LOAI_TRANG_THAI_LD");
        }

        public void SetTEN_LOAI_TRANG_THAI_LDNull()
        {
            pm_objDR["TEN_LOAI_TRANG_THAI_LD"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI_LAO_DONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_LAO_DONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI_LAO_DONG"] = value;
            }
        }

        public bool IsID_TRANG_THAI_LAO_DONGNull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI_LAO_DONG");
        }

        public void SetID_TRANG_THAI_LAO_DONGNull()
        {
            pm_objDR["ID_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
        }

        public string strTEN_TRANG_THAI_LD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TRANG_THAI_LD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TRANG_THAI_LD"] = value;
            }
        }

        public bool IsTEN_TRANG_THAI_LDNull()
        {
            return pm_objDR.IsNull("TEN_TRANG_THAI_LD");
        }

        public void SetTEN_TRANG_THAI_LDNull()
        {
            pm_objDR["TEN_TRANG_THAI_LD"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_AP_DUNG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_AP_DUNG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_AP_DUNG"] = value;
            }
        }

        public bool IsNGAY_AP_DUNGNull()
        {
            return pm_objDR.IsNull("NGAY_AP_DUNG");
        }

        public void SetNGAY_AP_DUNGNull()
        {
            pm_objDR["NGAY_AP_DUNG"] = System.Convert.DBNull;
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

        public string strGHI_CHU_TRANG_THAI_LAO_DONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_TRANG_THAI_LAO_DONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_TRANG_THAI_LAO_DONG"] = value;
            }
        }

        public bool IsGHI_CHU_TRANG_THAI_LAO_DONGNull()
        {
            return pm_objDR.IsNull("GHI_CHU_TRANG_THAI_LAO_DONG");
        }

        public void SetGHI_CHU_TRANG_THAI_LAO_DONGNull()
        {
            pm_objDR["GHI_CHU_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
        }

        public decimal dcID_GD_CT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_GD_CT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_GD_CT"] = value;
            }
        }



        public bool IsID_GD_CTNull()
        {
            return pm_objDR.IsNull("ID_GD_CT");
        }

        public void SetID_GD_CTNull()
        {
            pm_objDR["ID_GD_CT"] = System.Convert.DBNull;
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

        public string strTEN_VI_TRI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_VI_TRI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_VI_TRI"] = value;
            }
        }

        public bool IsTEN_VI_TRINull()
        {
            return pm_objDR.IsNull("TEN_VI_TRI");
        }

        public void SetTEN_VI_TRINull()
        {
            pm_objDR["TEN_VI_TRI"] = System.Convert.DBNull;
        }

        public string strTEN_LOAI_CONG_TAC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOAI_CONG_TAC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOAI_CONG_TAC"] = value;
            }
        }

        public bool IsTEN_LOAI_CONG_TACNull()
        {
            return pm_objDR.IsNull("TEN_LOAI_CONG_TAC");
        }

        public void SetTEN_LOAI_CONG_TACNull()
        {
            pm_objDR["TEN_LOAI_CONG_TAC"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG()
        {
            pm_objDS = new DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG(DataRow i_objDR) : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG(decimal i_dbID)
        {
            pm_objDS = new DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }

        public void FillDataset_by_thang_nam(DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG v_ds_468,
                                                DateTime dau_thang,
                                                DateTime cuoi_thang)
        {
            CStoredProc v_sp = new CStoredProc("Pr_f468_by_thang_nam");
            v_sp.addDatetimeInputParam("@ip_dat_ngay_dau_thang", dau_thang);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_cuoi_thang", cuoi_thang);
            v_sp.fillDataSetByCommand(this, v_ds_468);
        }
        public void FillDataset_by_thang_nam_and_id_trang_thai_ld(DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG v_ds_468,
            DateTime dau_thang,
            DateTime cuoi_thang,
            decimal id_trang_thai)
        {
            CStoredProc v_sp = new CStoredProc("Pr_f468_by_thang_nam_and_id_trang_thai_ld");
            v_sp.addDecimalInputParam("@ip_dc_id_ttld", id_trang_thai);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_dau_thang", dau_thang);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_cuoi_thang", cuoi_thang);
            v_sp.fillDataSetByCommand(this, v_ds_468);
        }
        public void FillDataset_by_thang_nam_and_id_loai_trang_thai_ld(DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG v_ds_468,
            DateTime dau_thang,
            DateTime cuoi_thang,
            decimal id_loai_trang_thai)
        {
            CStoredProc v_sp = new CStoredProc("Pr_f468_by_thang_nam_and_id_loai_trang_thai_ld");
            v_sp.addDecimalInputParam("@ip_dc_id_loai_ttld", id_loai_trang_thai);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_dau_thang", dau_thang);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_cuoi_thang", cuoi_thang);
            v_sp.fillDataSetByCommand(this, v_ds_468);
        }
        #endregion
    }
}
