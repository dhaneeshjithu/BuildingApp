﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildingAppService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CCPL")]
	public partial class CCPLDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CCPLDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CCPLConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CCPLDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CCPLDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CCPLDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CCPLDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Login_User")]
		public ISingleResult<Login_UserResult> Login_User([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string uname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), uname, pass);
			return ((ISingleResult<Login_UserResult>)(result.ReturnValue));
		}
	}
	
	public partial class Login_UserResult
	{
		
		private string _UserName;
		
		private string _Password;
		
		private string _Designation;
		
		public Login_UserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Designation
		{
			get
			{
				return this._Designation;
			}
			set
			{
				if ((this._Designation != value))
				{
					this._Designation = value;
				}
			}
		}
	}
}
#pragma warning restore 1591