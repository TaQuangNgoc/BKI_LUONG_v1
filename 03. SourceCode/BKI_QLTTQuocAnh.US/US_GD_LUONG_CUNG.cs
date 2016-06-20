///************************************************
/// Generated by: haihd
/// Date: 09/09/2015 06:19:49
/// Goal: Create User Service Class for GD_LUONG_CUNG
///************************************************
/// <summary>
/// Create User Service Class for GD_LUONG_CUNG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_LUONG_CUNG : US_Object
    {
        private const string c_TableName = "GD_LUONG_CUNG";
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

        public decimal dcSO_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN"] = value;
            }
        }

        public bool IsSO_TIENNull()
        {
            return pm_objDR.IsNull("SO_TIEN");
        }

        public void SetSO_TIENNull()
        {
            pm_objDR["SO_TIEN"] = System.Convert.DBNull;
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

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
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

        #endregion
        #region "Init Functions"
        public US_GD_LUONG_CUNG()
        {
            pm_objDS = new DS_GD_LUONG_CUNG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_LUONG_CUNG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_LUONG_CUNG(decimal i_dbID)
        {
            pm_objDS = new DS_GD_LUONG_CUNG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        public void LayDanhSach(DataSet ip_ds)
        {
            CStoredProc v_sp = new CStoredProc("PR_SELECT_ALL_LUONG_CUNG");
            v_sp.fillDataSetByCommand(this, ip_ds);
        }
        public void LayDanhSach(DataSet ip_ds, decimal ip_dc_id_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("PR_SELECT_ONE_LUONG_CUNG");
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_sp.fillDataSetByCommand(this, ip_ds);
        }

        public bool KiemTraThoiGianVoiHeSoLNSForInsert(decimal ip_dc_id_nhan_vien, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LC_kiem_tra_thoi_gian_hop_le_voi_lns_ForInsert");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

            SqlParameter v_yn = v_cstore.addNVarcharOutputParam("@op_str_hop_le_yn", "");
            v_cstore.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? true : false;
        }
        public bool KiemTraThoiGianVoiHeSoLNSForUpdate(decimal ip_dc_id_gd_luong_cung, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LC_kiem_tra_thoi_gian_hop_le_voi_lns_ForUpdate");
            v_cstore.addDecimalInputParam("@ip_dc_id_gd_luong_cung", ip_dc_id_gd_luong_cung);
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

            SqlParameter v_yn = v_cstore.addNVarcharOutputParam("@op_str_hop_le_yn", "");
            v_cstore.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? true : false;
        }
    }
}
