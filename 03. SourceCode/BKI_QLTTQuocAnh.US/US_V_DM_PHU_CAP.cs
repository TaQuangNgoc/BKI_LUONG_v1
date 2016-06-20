///************************************************
/// Generated by: hoangnl
/// Date: 03-03-2016 06:21:34
/// Goal: Create User Service Class for V_DM_PHU_CAP
///************************************************
/// <summary>
/// Create User Service Class for V_DM_PHU_CAP
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_DM_PHU_CAP : US_Object
{
	private const string c_TableName = "V_DM_PHU_CAP";
#region "Public Properties"
	public string strDOI_TUONG_HUONG_PHU_CAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DOI_TUONG_HUONG_PHU_CAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DOI_TUONG_HUONG_PHU_CAP"] = value;
		}
	}

	public bool IsDOI_TUONG_HUONG_PHU_CAPNull() 
	{
		return pm_objDR.IsNull("DOI_TUONG_HUONG_PHU_CAP");
	}

	public void SetDOI_TUONG_HUONG_PHU_CAPNull() {
		pm_objDR["DOI_TUONG_HUONG_PHU_CAP"] = System.Convert.DBNull;
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

	public decimal dcTI_LE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE"] = value;
		}
	}

	public bool IsTI_LENull()	{
		return pm_objDR.IsNull("TI_LE");
	}

	public void SetTI_LENull() {
		pm_objDR["TI_LE"] = System.Convert.DBNull;
	}

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

	public decimal dcID_LOAI_PHU_CAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_PHU_CAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_PHU_CAP"] = value;
		}
	}

	public bool IsID_LOAI_PHU_CAPNull()	{
		return pm_objDR.IsNull("ID_LOAI_PHU_CAP");
	}

	public void SetID_LOAI_PHU_CAPNull() {
		pm_objDR["ID_LOAI_PHU_CAP"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_PHU_CAP() 
	{
		pm_objDS = new DS_V_DM_PHU_CAP();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_PHU_CAP(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_PHU_CAP(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_PHU_CAP();
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
