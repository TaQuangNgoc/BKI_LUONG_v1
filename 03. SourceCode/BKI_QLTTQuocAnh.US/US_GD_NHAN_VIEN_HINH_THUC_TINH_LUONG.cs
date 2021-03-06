///************************************************
/// Generated by: haihd
/// Date: 26/06/2016 04:42:02
/// Goal: Create User Service Class for GD_NHAN_VIEN_HINH_THUC_TINH_LUONG
///************************************************
/// <summary>
/// Create User Service Class for GD_NHAN_VIEN_HINH_THUC_TINH_LUONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG : US_Object
{
	private const string c_TableName = "GD_NHAN_VIEN_HINH_THUC_TINH_LUONG";
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

	public bool IsID_NHAN_VIENNull()	{
		return pm_objDR.IsNull("ID_NHAN_VIEN");
	}

	public void SetID_NHAN_VIENNull() {
		pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
	}

	public decimal dcID_HINH_THUC_TINH_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HINH_THUC_TINH_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HINH_THUC_TINH_LUONG"] = value;
		}
	}

	public bool IsID_HINH_THUC_TINH_LUONGNull()	{
		return pm_objDR.IsNull("ID_HINH_THUC_TINH_LUONG");
	}

	public void SetID_HINH_THUC_TINH_LUONGNull() {
		pm_objDR["ID_HINH_THUC_TINH_LUONG"] = System.Convert.DBNull;
	}

	public string strCO_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CO_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CO_YN"] = value;
		}
	}

	public bool IsCO_YNNull() 
	{
		return pm_objDR.IsNull("CO_YN");
	}

	public void SetCO_YNNull() {
		pm_objDR["CO_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG() 
	{
		pm_objDS = new DS_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG();
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
