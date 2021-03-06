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

namespace WP_SuAboneTakip
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class dataclassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAbone(Abone instance);
    partial void UpdateAbone(Abone instance);
    partial void DeleteAbone(Abone instance);
    partial void InsertFatura(Fatura instance);
    partial void UpdateFatura(Fatura instance);
    partial void DeleteFatura(Fatura instance);
    #endregion
		
		public dataclassDataContext() : 
				base(global::WP_SuAboneTakip.Properties.Settings.Default.DataSourceConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dataclassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataclassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataclassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataclassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Abone> Abones
		{
			get
			{
				return this.GetTable<Abone>();
			}
		}
		
		public System.Data.Linq.Table<Fatura> Faturas
		{
			get
			{
				return this.GetTable<Fatura>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Abone")]
	public partial class Abone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _Abone_ID;
		
		private string _İsim;
		
		private string _Soyisim;
		
		private string _Adres;
		
		private decimal _Telefon;
		
		private System.Nullable<decimal> _EskiBorc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAbone_IDChanging(decimal value);
    partial void OnAbone_IDChanged();
    partial void OnİsimChanging(string value);
    partial void OnİsimChanged();
    partial void OnSoyisimChanging(string value);
    partial void OnSoyisimChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnTelefonChanging(decimal value);
    partial void OnTelefonChanged();
    partial void OnEskiBorcChanging(System.Nullable<decimal> value);
    partial void OnEskiBorcChanged();
    #endregion
		
		public Abone()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abone_ID", DbType="Decimal(5,0) NOT NULL", IsPrimaryKey=true)]
		public decimal Abone_ID
		{
			get
			{
				return this._Abone_ID;
			}
			set
			{
				if ((this._Abone_ID != value))
				{
					this.OnAbone_IDChanging(value);
					this.SendPropertyChanging();
					this._Abone_ID = value;
					this.SendPropertyChanged("Abone_ID");
					this.OnAbone_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_İsim", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string İsim
		{
			get
			{
				return this._İsim;
			}
			set
			{
				if ((this._İsim != value))
				{
					this.OnİsimChanging(value);
					this.SendPropertyChanging();
					this._İsim = value;
					this.SendPropertyChanged("İsim");
					this.OnİsimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyisim", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Soyisim
		{
			get
			{
				return this._Soyisim;
			}
			set
			{
				if ((this._Soyisim != value))
				{
					this.OnSoyisimChanging(value);
					this.SendPropertyChanging();
					this._Soyisim = value;
					this.SendPropertyChanged("Soyisim");
					this.OnSoyisimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="Decimal(11,0) NOT NULL")]
		public decimal Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EskiBorc", DbType="Decimal(5,0)")]
		public System.Nullable<decimal> EskiBorc
		{
			get
			{
				return this._EskiBorc;
			}
			set
			{
				if ((this._EskiBorc != value))
				{
					this.OnEskiBorcChanging(value);
					this.SendPropertyChanging();
					this._EskiBorc = value;
					this.SendPropertyChanged("EskiBorc");
					this.OnEskiBorcChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fatura")]
	public partial class Fatura : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _Abone_ID;
		
		private int _Fatura_ID;
		
		private System.DateTime _Fatura_DATE;
		
		private int _Fatura_Borc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAbone_IDChanging(decimal value);
    partial void OnAbone_IDChanged();
    partial void OnFatura_IDChanging(int value);
    partial void OnFatura_IDChanged();
    partial void OnFatura_DATEChanging(System.DateTime value);
    partial void OnFatura_DATEChanged();
    partial void OnFatura_BorcChanging(int value);
    partial void OnFatura_BorcChanged();
    #endregion
		
		public Fatura()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abone_ID", DbType="Decimal(5,0) NOT NULL", IsPrimaryKey=true)]
		public decimal Abone_ID
		{
			get
			{
				return this._Abone_ID;
			}
			set
			{
				if ((this._Abone_ID != value))
				{
					this.OnAbone_IDChanging(value);
					this.SendPropertyChanging();
					this._Abone_ID = value;
					this.SendPropertyChanged("Abone_ID");
					this.OnAbone_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fatura_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Fatura_ID
		{
			get
			{
				return this._Fatura_ID;
			}
			set
			{
				if ((this._Fatura_ID != value))
				{
					this.OnFatura_IDChanging(value);
					this.SendPropertyChanging();
					this._Fatura_ID = value;
					this.SendPropertyChanged("Fatura_ID");
					this.OnFatura_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fatura_DATE", DbType="Date NOT NULL")]
		public System.DateTime Fatura_DATE
		{
			get
			{
				return this._Fatura_DATE;
			}
			set
			{
				if ((this._Fatura_DATE != value))
				{
					this.OnFatura_DATEChanging(value);
					this.SendPropertyChanging();
					this._Fatura_DATE = value;
					this.SendPropertyChanged("Fatura_DATE");
					this.OnFatura_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fatura_Borc", DbType="Int NOT NULL")]
		public int Fatura_Borc
		{
			get
			{
				return this._Fatura_Borc;
			}
			set
			{
				if ((this._Fatura_Borc != value))
				{
					this.OnFatura_BorcChanging(value);
					this.SendPropertyChanging();
					this._Fatura_Borc = value;
					this.SendPropertyChanged("Fatura_Borc");
					this.OnFatura_BorcChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
