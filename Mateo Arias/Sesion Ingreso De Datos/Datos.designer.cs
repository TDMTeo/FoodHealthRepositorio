﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistica
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Prueba4")]
	public partial class DatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAdministrador(Administrador instance);
    partial void UpdateAdministrador(Administrador instance);
    partial void DeleteAdministrador(Administrador instance);
    partial void InsertRol(Rol instance);
    partial void UpdateRol(Rol instance);
    partial void DeleteRol(Rol instance);
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertDomiciliario(Domiciliario instance);
    partial void UpdateDomiciliario(Domiciliario instance);
    partial void DeleteDomiciliario(Domiciliario instance);
    partial void Insertpersonas(personas instance);
    partial void Updatepersonas(personas instance);
    partial void Deletepersonas(personas instance);
    #endregion
		
		public DatosDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Prueba4ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Administrador> Administrador
		{
			get
			{
				return this.GetTable<Administrador>();
			}
		}
		
		public System.Data.Linq.Table<Rol> Rol
		{
			get
			{
				return this.GetTable<Rol>();
			}
		}
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Domiciliario> Domiciliario
		{
			get
			{
				return this.GetTable<Domiciliario>();
			}
		}
		
		public System.Data.Linq.Table<personas> personas
		{
			get
			{
				return this.GetTable<personas>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administrador")]
	public partial class Administrador : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdministradorID;
		
		private string _Usuario;
		
		private string _Contraseña;
		
		private int _RolID;
		
		private EntityRef<Rol> _Rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdministradorIDChanging(int value);
    partial void OnAdministradorIDChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnRolIDChanging(int value);
    partial void OnRolIDChanged();
    #endregion
		
		public Administrador()
		{
			this._Rol = default(EntityRef<Rol>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdministradorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdministradorID
		{
			get
			{
				return this._AdministradorID;
			}
			set
			{
				if ((this._AdministradorID != value))
				{
					this.OnAdministradorIDChanging(value);
					this.SendPropertyChanging();
					this._AdministradorID = value;
					this.SendPropertyChanged("AdministradorID");
					this.OnAdministradorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					if (this._Rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRolIDChanging(value);
					this.SendPropertyChanging();
					this._RolID = value;
					this.SendPropertyChanged("RolID");
					this.OnRolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Administrador", Storage="_Rol", ThisKey="RolID", OtherKey="RolID", IsForeignKey=true)]
		public Rol Rol
		{
			get
			{
				return this._Rol.Entity;
			}
			set
			{
				Rol previousValue = this._Rol.Entity;
				if (((previousValue != value) 
							|| (this._Rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rol.Entity = null;
						previousValue.Administrador.Remove(this);
					}
					this._Rol.Entity = value;
					if ((value != null))
					{
						value.Administrador.Add(this);
						this._RolID = value.RolID;
					}
					else
					{
						this._RolID = default(int);
					}
					this.SendPropertyChanged("Rol");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rol")]
	public partial class Rol : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RolID;
		
		private string _NombreRol;
		
		private EntitySet<Administrador> _Administrador;
		
		private EntitySet<Cliente> _Cliente;
		
		private EntitySet<Domiciliario> _Domiciliario;
		
		private EntitySet<personas> _personas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRolIDChanging(int value);
    partial void OnRolIDChanged();
    partial void OnNombreRolChanging(string value);
    partial void OnNombreRolChanged();
    #endregion
		
		public Rol()
		{
			this._Administrador = new EntitySet<Administrador>(new Action<Administrador>(this.attach_Administrador), new Action<Administrador>(this.detach_Administrador));
			this._Cliente = new EntitySet<Cliente>(new Action<Cliente>(this.attach_Cliente), new Action<Cliente>(this.detach_Cliente));
			this._Domiciliario = new EntitySet<Domiciliario>(new Action<Domiciliario>(this.attach_Domiciliario), new Action<Domiciliario>(this.detach_Domiciliario));
			this._personas = new EntitySet<personas>(new Action<personas>(this.attach_personas), new Action<personas>(this.detach_personas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					this.OnRolIDChanging(value);
					this.SendPropertyChanging();
					this._RolID = value;
					this.SendPropertyChanged("RolID");
					this.OnRolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreRol", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string NombreRol
		{
			get
			{
				return this._NombreRol;
			}
			set
			{
				if ((this._NombreRol != value))
				{
					this.OnNombreRolChanging(value);
					this.SendPropertyChanging();
					this._NombreRol = value;
					this.SendPropertyChanged("NombreRol");
					this.OnNombreRolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Administrador", Storage="_Administrador", ThisKey="RolID", OtherKey="RolID")]
		public EntitySet<Administrador> Administrador
		{
			get
			{
				return this._Administrador;
			}
			set
			{
				this._Administrador.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Cliente", Storage="_Cliente", ThisKey="RolID", OtherKey="RolID")]
		public EntitySet<Cliente> Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				this._Cliente.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Domiciliario", Storage="_Domiciliario", ThisKey="RolID", OtherKey="RolID")]
		public EntitySet<Domiciliario> Domiciliario
		{
			get
			{
				return this._Domiciliario;
			}
			set
			{
				this._Domiciliario.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_personas", Storage="_personas", ThisKey="RolID", OtherKey="RolID")]
		public EntitySet<personas> personas
		{
			get
			{
				return this._personas;
			}
			set
			{
				this._personas.Assign(value);
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
		
		private void attach_Administrador(Administrador entity)
		{
			this.SendPropertyChanging();
			entity.Rol = this;
		}
		
		private void detach_Administrador(Administrador entity)
		{
			this.SendPropertyChanging();
			entity.Rol = null;
		}
		
		private void attach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Rol = this;
		}
		
		private void detach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Rol = null;
		}
		
		private void attach_Domiciliario(Domiciliario entity)
		{
			this.SendPropertyChanging();
			entity.Rol = this;
		}
		
		private void detach_Domiciliario(Domiciliario entity)
		{
			this.SendPropertyChanging();
			entity.Rol = null;
		}
		
		private void attach_personas(personas entity)
		{
			this.SendPropertyChanging();
			entity.Rol = this;
		}
		
		private void detach_personas(personas entity)
		{
			this.SendPropertyChanging();
			entity.Rol = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClienteID;
		
		private string _Documento;
		
		private string _Correo;
		
		private string _Nombre;
		
		private string _Direccion;
		
		private int _RolID;
		
		private EntityRef<Rol> _Rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClienteIDChanging(int value);
    partial void OnClienteIDChanged();
    partial void OnDocumentoChanging(string value);
    partial void OnDocumentoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnRolIDChanging(int value);
    partial void OnRolIDChanged();
    #endregion
		
		public Cliente()
		{
			this._Rol = default(EntityRef<Rol>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClienteID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ClienteID
		{
			get
			{
				return this._ClienteID;
			}
			set
			{
				if ((this._ClienteID != value))
				{
					this.OnClienteIDChanging(value);
					this.SendPropertyChanging();
					this._ClienteID = value;
					this.SendPropertyChanged("ClienteID");
					this.OnClienteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Documento", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Documento
		{
			get
			{
				return this._Documento;
			}
			set
			{
				if ((this._Documento != value))
				{
					this.OnDocumentoChanging(value);
					this.SendPropertyChanging();
					this._Documento = value;
					this.SendPropertyChanged("Documento");
					this.OnDocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					if (this._Rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRolIDChanging(value);
					this.SendPropertyChanging();
					this._RolID = value;
					this.SendPropertyChanged("RolID");
					this.OnRolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Cliente", Storage="_Rol", ThisKey="RolID", OtherKey="RolID", IsForeignKey=true)]
		public Rol Rol
		{
			get
			{
				return this._Rol.Entity;
			}
			set
			{
				Rol previousValue = this._Rol.Entity;
				if (((previousValue != value) 
							|| (this._Rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rol.Entity = null;
						previousValue.Cliente.Remove(this);
					}
					this._Rol.Entity = value;
					if ((value != null))
					{
						value.Cliente.Add(this);
						this._RolID = value.RolID;
					}
					else
					{
						this._RolID = default(int);
					}
					this.SendPropertyChanged("Rol");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Domiciliario")]
	public partial class Domiciliario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DomiciliarioID;
		
		private string _Documento;
		
		private string _Correo;
		
		private string _Nombre;
		
		private int _Telefono;
		
		private int _RolID;
		
		private EntityRef<Rol> _Rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDomiciliarioIDChanging(int value);
    partial void OnDomiciliarioIDChanged();
    partial void OnDocumentoChanging(string value);
    partial void OnDocumentoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnTelefonoChanging(int value);
    partial void OnTelefonoChanged();
    partial void OnRolIDChanging(int value);
    partial void OnRolIDChanged();
    #endregion
		
		public Domiciliario()
		{
			this._Rol = default(EntityRef<Rol>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DomiciliarioID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DomiciliarioID
		{
			get
			{
				return this._DomiciliarioID;
			}
			set
			{
				if ((this._DomiciliarioID != value))
				{
					this.OnDomiciliarioIDChanging(value);
					this.SendPropertyChanging();
					this._DomiciliarioID = value;
					this.SendPropertyChanged("DomiciliarioID");
					this.OnDomiciliarioIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Documento", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Documento
		{
			get
			{
				return this._Documento;
			}
			set
			{
				if ((this._Documento != value))
				{
					this.OnDocumentoChanging(value);
					this.SendPropertyChanging();
					this._Documento = value;
					this.SendPropertyChanged("Documento");
					this.OnDocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int NOT NULL")]
		public int Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					if (this._Rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRolIDChanging(value);
					this.SendPropertyChanging();
					this._RolID = value;
					this.SendPropertyChanged("RolID");
					this.OnRolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Domiciliario", Storage="_Rol", ThisKey="RolID", OtherKey="RolID", IsForeignKey=true)]
		public Rol Rol
		{
			get
			{
				return this._Rol.Entity;
			}
			set
			{
				Rol previousValue = this._Rol.Entity;
				if (((previousValue != value) 
							|| (this._Rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rol.Entity = null;
						previousValue.Domiciliario.Remove(this);
					}
					this._Rol.Entity = value;
					if ((value != null))
					{
						value.Domiciliario.Add(this);
						this._RolID = value.RolID;
					}
					else
					{
						this._RolID = default(int);
					}
					this.SendPropertyChanged("Rol");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.personas")]
	public partial class personas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonaID;
		
		private string _Documento;
		
		private string _Correo;
		
		private string _Nombre;
		
		private string _Direccion;
		
		private int _RolID;
		
		private EntityRef<Rol> _Rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonaIDChanging(int value);
    partial void OnPersonaIDChanged();
    partial void OnDocumentoChanging(string value);
    partial void OnDocumentoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnRolIDChanging(int value);
    partial void OnRolIDChanged();
    #endregion
		
		public personas()
		{
			this._Rol = default(EntityRef<Rol>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PersonaID
		{
			get
			{
				return this._PersonaID;
			}
			set
			{
				if ((this._PersonaID != value))
				{
					this.OnPersonaIDChanging(value);
					this.SendPropertyChanging();
					this._PersonaID = value;
					this.SendPropertyChanged("PersonaID");
					this.OnPersonaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Documento", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Documento
		{
			get
			{
				return this._Documento;
			}
			set
			{
				if ((this._Documento != value))
				{
					this.OnDocumentoChanging(value);
					this.SendPropertyChanging();
					this._Documento = value;
					this.SendPropertyChanged("Documento");
					this.OnDocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					if (this._Rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRolIDChanging(value);
					this.SendPropertyChanging();
					this._RolID = value;
					this.SendPropertyChanged("RolID");
					this.OnRolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_personas", Storage="_Rol", ThisKey="RolID", OtherKey="RolID", IsForeignKey=true)]
		public Rol Rol
		{
			get
			{
				return this._Rol.Entity;
			}
			set
			{
				Rol previousValue = this._Rol.Entity;
				if (((previousValue != value) 
							|| (this._Rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rol.Entity = null;
						previousValue.personas.Remove(this);
					}
					this._Rol.Entity = value;
					if ((value != null))
					{
						value.personas.Add(this);
						this._RolID = value.RolID;
					}
					else
					{
						this._RolID = default(int);
					}
					this.SendPropertyChanged("Rol");
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
