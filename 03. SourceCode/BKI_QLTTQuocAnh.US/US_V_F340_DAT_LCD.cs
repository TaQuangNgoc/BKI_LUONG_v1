///************************************************
/// Generated by: haihd
/// Date: 24/08/2015 07:02:40
/// Goal: Create User Service Class for V_F340_DAT_LCD
///************************************************
/// <summary>
/// Create User Service Class for V_F340_DAT_LCD
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_F340_DAT_LCD : US_Object
{
	private const string c_TableName = "V_F340_DAT_LCD";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
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

	public void SetMA_NVNull() {
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

	public void SetHO_DEMNull() {
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

	public void SetTENNull() {
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

	public void SetHO_TENNull() {
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

	public bool IsID_HOP_DONGNull()	{
		return pm_objDR.IsNull("ID_HOP_DONG");
	}

	public void SetID_HOP_DONGNull() {
		pm_objDR["ID_HOP_DONG"] = System.Convert.DBNull;
	}

	public string strMA_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HOP_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HOP_DONG"] = value;
		}
	}

	public bool IsMA_HOP_DONGNull() 
	{
		return pm_objDR.IsNull("MA_HOP_DONG");
	}

	public void SetMA_HOP_DONGNull() {
		pm_objDR["MA_HOP_DONG"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_HOP_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsID_LOAI_HOP_DONGNull()	{
		return pm_objDR.IsNull("ID_LOAI_HOP_DONG");
	}

	public void SetID_LOAI_HOP_DONGNull() {
		pm_objDR["ID_LOAI_HOP_DONG"] = System.Convert.DBNull;
	}

	public string strMA_LOAI_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOAI_HOP_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsMA_LOAI_HOP_DONGNull() 
	{
		return pm_objDR.IsNull("MA_LOAI_HOP_DONG");
	}

	public void SetMA_LOAI_HOP_DONGNull() {
		pm_objDR["MA_LOAI_HOP_DONG"] = System.Convert.DBNull;
	}

	public string strLOAI_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_HOP_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsLOAI_HOP_DONGNull() 
	{
		return pm_objDR.IsNull("LOAI_HOP_DONG");
	}

	public void SetLOAI_HOP_DONGNull() {
		pm_objDR["LOAI_HOP_DONG"] = System.Convert.DBNull;
	}

	public decimal dcID_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LCD"] = value;
		}
	}

	public bool IsID_LCDNull()	{
		return pm_objDR.IsNull("ID_LCD");
	}

	public void SetID_LCDNull() {
		pm_objDR["ID_LCD"] = System.Convert.DBNull;
	}

	public decimal dcSO_TIEN_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_TIEN_LCD"] = value;
		}
	}

	public bool IsSO_TIEN_LCDNull()	{
		return pm_objDR.IsNull("SO_TIEN_LCD");
	}

	public void SetSO_TIEN_LCDNull() {
		pm_objDR["SO_TIEN_LCD"] = System.Convert.DBNull;
	}

	public decimal dcID_LY_DO_CHINH_SUA_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LY_DO_CHINH_SUA_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LY_DO_CHINH_SUA_LCD"] = value;
		}
	}

	public bool IsID_LY_DO_CHINH_SUA_LCDNull()	{
		return pm_objDR.IsNull("ID_LY_DO_CHINH_SUA_LCD");
	}

	public void SetID_LY_DO_CHINH_SUA_LCDNull() {
		pm_objDR["ID_LY_DO_CHINH_SUA_LCD"] = System.Convert.DBNull;
	}

	public string strMA_LY_DO_CHINH_SUA_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LY_DO_CHINH_SUA_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LY_DO_CHINH_SUA_LCD"] = value;
		}
	}

	public bool IsMA_LY_DO_CHINH_SUA_LCDNull() 
	{
		return pm_objDR.IsNull("MA_LY_DO_CHINH_SUA_LCD");
	}

	public void SetMA_LY_DO_CHINH_SUA_LCDNull() {
		pm_objDR["MA_LY_DO_CHINH_SUA_LCD"] = System.Convert.DBNull;
	}

	public string strTEN_LY_DO_CHINH_SUA_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LY_DO_CHINH_SUA_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LY_DO_CHINH_SUA_LCD"] = value;
		}
	}

	public bool IsTEN_LY_DO_CHINH_SUA_LCDNull() 
	{
		return pm_objDR.IsNull("TEN_LY_DO_CHINH_SUA_LCD");
	}

	public void SetTEN_LY_DO_CHINH_SUA_LCDNull() {
		pm_objDR["TEN_LY_DO_CHINH_SUA_LCD"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_LCD"] = value;
		}
	}

	public bool IsGHI_CHU_LCDNull() 
	{
		return pm_objDR.IsNull("GHI_CHU_LCD");
	}

	public void SetGHI_CHU_LCDNull() {
		pm_objDR["GHI_CHU_LCD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BAT_DAU_LCD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_LCD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU_LCD"] = value;
		}
	}

	public bool IsNGAY_BAT_DAU_LCDNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU_LCD");
	}

	public void SetNGAY_BAT_DAU_LCDNull()
	{
		pm_objDR["NGAY_BAT_DAU_LCD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC_LCD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC_LCD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC_LCD"] = value;
		}
	}

	public bool IsNGAY_KET_THUC_LCDNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC_LCD");
	}

	public void SetNGAY_KET_THUC_LCDNull()
	{
		pm_objDR["NGAY_KET_THUC_LCD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_LAP_LCD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_LAP_LCD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_LAP_LCD"] = value;
		}
	}

	public bool IsNGAY_LAP_LCDNull()
	{
		return pm_objDR.IsNull("NGAY_LAP_LCD");
	}

	public void SetNGAY_LAP_LCDNull()
	{
		pm_objDR["NGAY_LAP_LCD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SUA_LCD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SUA_LCD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SUA_LCD"] = value;
		}
	}

	public bool IsNGAY_SUA_LCDNull()
	{
		return pm_objDR.IsNull("NGAY_SUA_LCD");
	}

	public void SetNGAY_SUA_LCDNull()
	{
		pm_objDR["NGAY_SUA_LCD"] = System.Convert.DBNull;
	}

	public string strNGUOI_LAP_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_LAP_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_LAP_LCD"] = value;
		}
	}

	public bool IsNGUOI_LAP_LCDNull() 
	{
		return pm_objDR.IsNull("NGUOI_LAP_LCD");
	}

	public void SetNGUOI_LAP_LCDNull() {
		pm_objDR["NGUOI_LAP_LCD"] = System.Convert.DBNull;
	}

	public string strNGUOI_SUA_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_SUA_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_SUA_LCD"] = value;
		}
	}

	public bool IsNGUOI_SUA_LCDNull() 
	{
		return pm_objDR.IsNull("NGUOI_SUA_LCD");
	}

	public void SetNGUOI_SUA_LCDNull() {
		pm_objDR["NGUOI_SUA_LCD"] = System.Convert.DBNull;
	}

	public string strDA_XOA_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_XOA_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_XOA_LCD"] = value;
		}
	}

	public bool IsDA_XOA_LCDNull() 
	{
		return pm_objDR.IsNull("DA_XOA_LCD");
	}

	public void SetDA_XOA_LCDNull() {
		pm_objDR["DA_XOA_LCD"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_F340_DAT_LCD() 
	{
		pm_objDS = new DS_V_F340_DAT_LCD();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_F340_DAT_LCD(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_F340_DAT_LCD(decimal i_dbID) 
	{
		pm_objDS = new DS_V_F340_DAT_LCD();
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
