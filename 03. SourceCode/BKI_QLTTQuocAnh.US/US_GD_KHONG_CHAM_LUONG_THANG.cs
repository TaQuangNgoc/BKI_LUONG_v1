///************************************************
/// Generated by: haihd
/// Date: 17/07/2016 02:29:56
/// Goal: Create User Service Class for GD_KHONG_CHAM_LUONG_THANG
///************************************************
/// <summary>
/// Create User Service Class for GD_KHONG_CHAM_LUONG_THANG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_GD_KHONG_CHAM_LUONG_THANG : US_Object
{
	private const string c_TableName = "GD_KHONG_CHAM_LUONG_THANG";
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

	public decimal dcTHANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THANG"] = value;
		}
	}

	public bool IsTHANGNull()	{
		return pm_objDR.IsNull("THANG");
	}

	public void SetTHANGNull() {
		pm_objDR["THANG"] = System.Convert.DBNull;
	}

	public decimal dcNAM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM"] = value;
		}
	}

	public bool IsNAMNull()	{
		return pm_objDR.IsNull("NAM");
	}

	public void SetNAMNull() {
		pm_objDR["NAM"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_GD_KHONG_CHAM_LUONG_THANG() 
	{
		pm_objDS = new DS_GD_KHONG_CHAM_LUONG_THANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_KHONG_CHAM_LUONG_THANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_KHONG_CHAM_LUONG_THANG(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_KHONG_CHAM_LUONG_THANG();
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