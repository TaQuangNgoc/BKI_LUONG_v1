///************************************************
/// Generated by: haihd
/// Date: 25/06/2016 09:46:21
/// Goal: Create User Service Class for GD_LUONG_MOT_NGAY
///************************************************
/// <summary>
/// Create User Service Class for GD_LUONG_MOT_NGAY
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_GD_LUONG_MOT_NGAY : US_Object
{
	private const string c_TableName = "GD_LUONG_MOT_NGAY";
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

	public bool IsSO_TIENNull()	{
		return pm_objDR.IsNull("SO_TIEN");
	}

	public void SetSO_TIENNull() {
		pm_objDR["SO_TIEN"] = System.Convert.DBNull;
	}

	public DateTime datTU_NGAY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "TU_NGAY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["TU_NGAY"] = value;
		}
	}

	public bool IsTU_NGAYNull()
	{
		return pm_objDR.IsNull("TU_NGAY");
	}

	public void SetTU_NGAYNull()
	{
		pm_objDR["TU_NGAY"] = System.Convert.DBNull;
	}

	public DateTime datDEN_NGAY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "DEN_NGAY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["DEN_NGAY"] = value;
		}
	}

	public bool IsDEN_NGAYNull()
	{
		return pm_objDR.IsNull("DEN_NGAY");
	}

	public void SetDEN_NGAYNull()
	{
		pm_objDR["DEN_NGAY"] = System.Convert.DBNull;
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

	public void SetDA_XOANull() {
		pm_objDR["DA_XOA"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_LUONG_MOT_NGAY() 
	{
		pm_objDS = new DS_GD_LUONG_MOT_NGAY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_LUONG_MOT_NGAY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_LUONG_MOT_NGAY(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_LUONG_MOT_NGAY();
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
