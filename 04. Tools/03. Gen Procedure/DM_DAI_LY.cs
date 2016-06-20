///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'DM_DAI_LY'
// Generated by LLBLGen v1.21.2003.712 Final on: Thursday, October 04, 2007, 11:19:01 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace AuctionthudoLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'DM_DAI_LY'.
	/// </summary>
	public class DM_DAI_LY : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDecimal		_iD;
			private SqlString		_dIA_CHI, _dESCRIPTION, _tRU_SO_CHINH_YN, _dAI_LY_NAME, _dIEN_THOAI, _fAX;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DM_DAI_LY()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>DAI_LY_NAME. May be SqlString.Null</LI>
		///		 <LI>DIEN_THOAI. May be SqlString.Null</LI>
		///		 <LI>FAX. May be SqlString.Null</LI>
		///		 <LI>DIA_CHI. May be SqlString.Null</LI>
		///		 <LI>DESCRIPTION. May be SqlString.Null</LI>
		///		 <LI>TRU_SO_CHINH_YN. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_DAI_LY_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@DAI_LY_NAME", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dAI_LY_NAME));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIEN_THOAI", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIEN_THOAI));
				cmdToExecute.Parameters.Add(new SqlParameter("@FAX", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fAX));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIA_CHI", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIA_CHI));
				cmdToExecute.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dESCRIPTION));
				cmdToExecute.Parameters.Add(new SqlParameter("@TRU_SO_CHINH_YN", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tRU_SO_CHINH_YN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Output, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_iD = (Decimal)cmdToExecute.Parameters["@ID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("DM_DAI_LY::Insert::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		///		 <LI>DAI_LY_NAME. May be SqlString.Null</LI>
		///		 <LI>DIEN_THOAI. May be SqlString.Null</LI>
		///		 <LI>FAX. May be SqlString.Null</LI>
		///		 <LI>DIA_CHI. May be SqlString.Null</LI>
		///		 <LI>DESCRIPTION. May be SqlString.Null</LI>
		///		 <LI>TRU_SO_CHINH_YN. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_DAI_LY_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@DAI_LY_NAME", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dAI_LY_NAME));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIEN_THOAI", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIEN_THOAI));
				cmdToExecute.Parameters.Add(new SqlParameter("@FAX", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fAX));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIA_CHI", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIA_CHI));
				cmdToExecute.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dESCRIPTION));
				cmdToExecute.Parameters.Add(new SqlParameter("@TRU_SO_CHINH_YN", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tRU_SO_CHINH_YN));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("DM_DAI_LY::Update::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_DAI_LY_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("DM_DAI_LY::Delete::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlDecimal ID
		{
			get
			{
				return _iD;
			}
			set
			{
				SqlDecimal iDTmp = (SqlDecimal)value;
				if(iDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID", "ID can't be NULL");
				}
				_iD = value;
			}
		}


		public SqlString DAI_LY_NAME
		{
			get
			{
				return _dAI_LY_NAME;
			}
			set
			{
				SqlString dAI_LY_NAMETmp = (SqlString)value;
				if(dAI_LY_NAMETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DAI_LY_NAME", "DAI_LY_NAME can't be NULL");
				}
				_dAI_LY_NAME = value;
			}
		}


		public SqlString DIEN_THOAI
		{
			get
			{
				return _dIEN_THOAI;
			}
			set
			{
				SqlString dIEN_THOAITmp = (SqlString)value;
				if(dIEN_THOAITmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DIEN_THOAI", "DIEN_THOAI can't be NULL");
				}
				_dIEN_THOAI = value;
			}
		}


		public SqlString FAX
		{
			get
			{
				return _fAX;
			}
			set
			{
				SqlString fAXTmp = (SqlString)value;
				if(fAXTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FAX", "FAX can't be NULL");
				}
				_fAX = value;
			}
		}


		public SqlString DIA_CHI
		{
			get
			{
				return _dIA_CHI;
			}
			set
			{
				SqlString dIA_CHITmp = (SqlString)value;
				if(dIA_CHITmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DIA_CHI", "DIA_CHI can't be NULL");
				}
				_dIA_CHI = value;
			}
		}


		public SqlString DESCRIPTION
		{
			get
			{
				return _dESCRIPTION;
			}
			set
			{
				SqlString dESCRIPTIONTmp = (SqlString)value;
				if(dESCRIPTIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DESCRIPTION", "DESCRIPTION can't be NULL");
				}
				_dESCRIPTION = value;
			}
		}


		public SqlString TRU_SO_CHINH_YN
		{
			get
			{
				return _tRU_SO_CHINH_YN;
			}
			set
			{
				SqlString tRU_SO_CHINH_YNTmp = (SqlString)value;
				if(tRU_SO_CHINH_YNTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TRU_SO_CHINH_YN", "TRU_SO_CHINH_YN can't be NULL");
				}
				_tRU_SO_CHINH_YN = value;
			}
		}
		#endregion
	}
}
