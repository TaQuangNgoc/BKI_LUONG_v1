///************************************************
/// Generated by: haihd
/// Date: 23/12/2015 12:22:51
/// Goal: Create User Service Class for V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG
///************************************************
/// <summary>
/// Create User Service Class for V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG : US_Object
    {
        private const string c_TableName = "V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG";
        #region "Public Properties"
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

        public decimal dcID_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_HOP_DONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_HOP_DONG"] = value;
            }
        }

        public bool IsID_HOP_DONGNull()
        {
            return pm_objDR.IsNull("ID_HOP_DONG");
        }

        public void SetID_HOP_DONGNull()
        {
            pm_objDR["ID_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_HOP_DONG");
        }

        public void SetNGAY_BAT_DAU_HOP_DONGNull()
        {
            pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_KET_THUC_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC_HOP_DONG");
        }

        public void SetNGAY_KET_THUC_HOP_DONGNull()
        {
            pm_objDR["NGAY_KET_THUC_HOP_DONG"] = System.Convert.DBNull;
        }

        public string strDA_XOA_HOP_DONG_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DA_XOA_HOP_DONG_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DA_XOA_HOP_DONG_YN"] = value;
            }
        }

        public bool IsDA_XOA_HOP_DONG_YNNull()
        {
            return pm_objDR.IsNull("DA_XOA_HOP_DONG_YN");
        }

        public void SetDA_XOA_HOP_DONG_YNNull()
        {
            pm_objDR["DA_XOA_HOP_DONG_YN"] = System.Convert.DBNull;
        }

        public decimal dcID_GD_HS_LNS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_GD_HS_LNS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_GD_HS_LNS"] = value;
            }
        }

        public bool IsID_GD_HS_LNSNull()
        {
            return pm_objDR.IsNull("ID_GD_HS_LNS");
        }

        public void SetID_GD_HS_LNSNull()
        {
            pm_objDR["ID_GD_HS_LNS"] = System.Convert.DBNull;
        }

        public decimal dcHE_SO_LNS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "HE_SO_LNS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["HE_SO_LNS"] = value;
            }
        }

        public bool IsHE_SO_LNSNull()
        {
            return pm_objDR.IsNull("HE_SO_LNS");
        }

        public void SetHE_SO_LNSNull()
        {
            pm_objDR["HE_SO_LNS"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_HS_LNS
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_HS_LNS", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_HS_LNS"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_HS_LNSNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_HS_LNS");
        }

        public void SetNGAY_BAT_DAU_HS_LNSNull()
        {
            pm_objDR["NGAY_BAT_DAU_HS_LNS"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC_HS_LNS
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC_HS_LNS", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC_HS_LNS"] = value;
            }
        }

        public bool IsNGAY_KET_THUC_HS_LNSNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC_HS_LNS");
        }

        public void SetNGAY_KET_THUC_HS_LNSNull()
        {
            pm_objDR["NGAY_KET_THUC_HS_LNS"] = System.Convert.DBNull;
        }

        public string strDA_XOA_HS_LNS_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DA_XOA_HS_LNS_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DA_XOA_HS_LNS_YN"] = value;
            }
        }

        public bool IsDA_XOA_HS_LNS_YNNull()
        {
            return pm_objDR.IsNull("DA_XOA_HS_LNS_YN");
        }

        public void SetDA_XOA_HS_LNS_YNNull()
        {
            pm_objDR["DA_XOA_HS_LNS_YN"] = System.Convert.DBNull;
        }

        public decimal dcID_LY_DO_CHINH_SUA_HS_LNS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LY_DO_CHINH_SUA_HS_LNS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LY_DO_CHINH_SUA_HS_LNS"] = value;
            }
        }

        public bool IsID_LY_DO_CHINH_SUA_HS_LNSNull()
        {
            return pm_objDR.IsNull("ID_LY_DO_CHINH_SUA_HS_LNS");
        }

        public void SetID_LY_DO_CHINH_SUA_HS_LNSNull()
        {
            pm_objDR["ID_LY_DO_CHINH_SUA_HS_LNS"] = System.Convert.DBNull;
        }

        public string strLY_DO_CHINH_SUA_HS_LNS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LY_DO_CHINH_SUA_HS_LNS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LY_DO_CHINH_SUA_HS_LNS"] = value;
            }
        }

        public bool IsLY_DO_CHINH_SUA_HS_LNSNull()
        {
            return pm_objDR.IsNull("LY_DO_CHINH_SUA_HS_LNS");
        }

        public void SetLY_DO_CHINH_SUA_HS_LNSNull()
        {
            pm_objDR["LY_DO_CHINH_SUA_HS_LNS"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_HS_LNS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_HS_LNS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_HS_LNS"] = value;
            }
        }

        public bool IsGHI_CHU_HS_LNSNull()
        {
            return pm_objDR.IsNull("GHI_CHU_HS_LNS");
        }

        public void SetGHI_CHU_HS_LNSNull()
        {
            pm_objDR["GHI_CHU_HS_LNS"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG()
        {
            pm_objDS = new DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG(decimal i_dbID)
        {
            pm_objDS = new DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDataset_by_thang_nam(
                            DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG op_ds_bc_hs_lns_nv_theo_thang,
                            decimal ip_dc_thang,
                            decimal ip_dc_nam,
                            decimal ip_co_xem_lich_su_giao_dich)
        {

            CStoredProc v_cstore = new CStoredProc("pr_f419_bao_cao_hs_lns_nhan_vien_theo_thang");

            v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_co_xem_lich_su_giao_dich", ip_co_xem_lich_su_giao_dich);

            v_cstore.fillDataSetByCommand(this, op_ds_bc_hs_lns_nv_theo_thang);
        }



        public void FillDataset_by_thang_nam_id_nhan_vien(
                            DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG op_ds_bc_hs_lns_nv_theo_thang,
                            decimal ip_dc_thang,
                            decimal ip_dc_nam,
                            decimal ip_dc_id_nhan_vien,
                            decimal ip_co_xem_lich_su_giao_dich)
        {
            CStoredProc v_cstore = new CStoredProc("pr_f419_bao_cao_hs_lns_1_nhan_vien_theo_thang_nam");

            v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_co_xem_lich_su_giao_dich", ip_co_xem_lich_su_giao_dich);

            v_cstore.fillDataSetByCommand(this, op_ds_bc_hs_lns_nv_theo_thang);
        }

        public DataSet LayDanhSachNhanVienHetHanHeSoLuongNangSuat(
            DateTime ip_dat_ngay_hien_tai)
        {
            CStoredProc v_sp = new CStoredProc("pr_lay_danh_sach_nv_het_han_hs_lns");
            v_sp.addDatetimeInputParam("@ip_dat_ngay_hien_tai", ip_dat_ngay_hien_tai);
            DataSet v_op_ds = new DataSet();
            v_op_ds.Tables.Add();

            //v_sp.fillDataSetByCommand(this, v_op_ds);
            return v_op_ds;
        }
    }
    
}
