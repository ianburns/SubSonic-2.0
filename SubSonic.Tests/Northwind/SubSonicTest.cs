using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Northwind
{
	/// <summary>
	/// Strongly-typed collection for the SubSonicTest class.
	/// </summary>
    [Serializable]
	public partial class SubSonicTestCollection : ActiveList<SubSonicTest, SubSonicTestCollection>
	{	   
		public SubSonicTestCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SubSonicTestCollection</returns>
		public SubSonicTestCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SubSonicTest o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the SubSonicTests table.
	/// </summary>
	[Serializable]
	public partial class SubSonicTest : ActiveRecord<SubSonicTest>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SubSonicTest()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SubSonicTest(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SubSonicTest(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SubSonicTest(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("SubSonicTests", TableType.Table, DataService.GetInstance("Northwind"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSubSonicTestID = new TableSchema.TableColumn(schema);
				colvarSubSonicTestID.ColumnName = "SubSonicTestID";
				colvarSubSonicTestID.DataType = DbType.Int32;
				colvarSubSonicTestID.MaxLength = 0;
				colvarSubSonicTestID.AutoIncrement = true;
				colvarSubSonicTestID.IsNullable = false;
				colvarSubSonicTestID.IsPrimaryKey = true;
				colvarSubSonicTestID.IsForeignKey = false;
				colvarSubSonicTestID.IsReadOnly = false;
				colvarSubSonicTestID.DefaultSetting = @"";
				colvarSubSonicTestID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSubSonicTestID);
				
				TableSchema.TableColumn colvarThinger = new TableSchema.TableColumn(schema);
				colvarThinger.ColumnName = "Thinger";
				colvarThinger.DataType = DbType.Int32;
				colvarThinger.MaxLength = 0;
				colvarThinger.AutoIncrement = false;
				colvarThinger.IsNullable = false;
				colvarThinger.IsPrimaryKey = false;
				colvarThinger.IsForeignKey = false;
				colvarThinger.IsReadOnly = false;
				colvarThinger.DefaultSetting = @"";
				colvarThinger.ForeignKeyTableName = "";
				schema.Columns.Add(colvarThinger);
				
				TableSchema.TableColumn colvarName = new TableSchema.TableColumn(schema);
				colvarName.ColumnName = "Name";
				colvarName.DataType = DbType.String;
				colvarName.MaxLength = 255;
				colvarName.AutoIncrement = false;
				colvarName.IsNullable = false;
				colvarName.IsPrimaryKey = false;
				colvarName.IsForeignKey = false;
				colvarName.IsReadOnly = false;
				colvarName.DefaultSetting = @"";
				colvarName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarName);
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "UserName";
				colvarUserName.DataType = DbType.String;
				colvarUserName.MaxLength = 500;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = false;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = false;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				colvarCreatedOn.DefaultSetting = @"";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarPrice = new TableSchema.TableColumn(schema);
				colvarPrice.ColumnName = "Price";
				colvarPrice.DataType = DbType.Decimal;
				colvarPrice.MaxLength = 0;
				colvarPrice.AutoIncrement = false;
				colvarPrice.IsNullable = false;
				colvarPrice.IsPrimaryKey = false;
				colvarPrice.IsForeignKey = false;
				colvarPrice.IsReadOnly = false;
				colvarPrice.DefaultSetting = @"";
				colvarPrice.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrice);
				
				TableSchema.TableColumn colvarDiscount = new TableSchema.TableColumn(schema);
				colvarDiscount.ColumnName = "Discount";
				colvarDiscount.DataType = DbType.Double;
				colvarDiscount.MaxLength = 0;
				colvarDiscount.AutoIncrement = false;
				colvarDiscount.IsNullable = false;
				colvarDiscount.IsPrimaryKey = false;
				colvarDiscount.IsForeignKey = false;
				colvarDiscount.IsReadOnly = false;
				colvarDiscount.DefaultSetting = @"";
				colvarDiscount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiscount);
				
				TableSchema.TableColumn colvarLat = new TableSchema.TableColumn(schema);
				colvarLat.ColumnName = "Lat";
				colvarLat.DataType = DbType.Decimal;
				colvarLat.MaxLength = 0;
				colvarLat.AutoIncrement = false;
				colvarLat.IsNullable = true;
				colvarLat.IsPrimaryKey = false;
				colvarLat.IsForeignKey = false;
				colvarLat.IsReadOnly = false;
				colvarLat.DefaultSetting = @"";
				colvarLat.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLat);
				
				TableSchema.TableColumn colvarLongX = new TableSchema.TableColumn(schema);
				colvarLongX.ColumnName = "Long";
				colvarLongX.DataType = DbType.Decimal;
				colvarLongX.MaxLength = 0;
				colvarLongX.AutoIncrement = false;
				colvarLongX.IsNullable = true;
				colvarLongX.IsPrimaryKey = false;
				colvarLongX.IsForeignKey = false;
				colvarLongX.IsReadOnly = false;
				colvarLongX.DefaultSetting = @"";
				colvarLongX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLongX);
				
				TableSchema.TableColumn colvarSomeFlag = new TableSchema.TableColumn(schema);
				colvarSomeFlag.ColumnName = "SomeFlag";
				colvarSomeFlag.DataType = DbType.Boolean;
				colvarSomeFlag.MaxLength = 0;
				colvarSomeFlag.AutoIncrement = false;
				colvarSomeFlag.IsNullable = false;
				colvarSomeFlag.IsPrimaryKey = false;
				colvarSomeFlag.IsForeignKey = false;
				colvarSomeFlag.IsReadOnly = false;
				colvarSomeFlag.DefaultSetting = @"";
				colvarSomeFlag.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSomeFlag);
				
				TableSchema.TableColumn colvarSomeNullableFlag = new TableSchema.TableColumn(schema);
				colvarSomeNullableFlag.ColumnName = "SomeNullableFlag";
				colvarSomeNullableFlag.DataType = DbType.Boolean;
				colvarSomeNullableFlag.MaxLength = 0;
				colvarSomeNullableFlag.AutoIncrement = false;
				colvarSomeNullableFlag.IsNullable = true;
				colvarSomeNullableFlag.IsPrimaryKey = false;
				colvarSomeNullableFlag.IsForeignKey = false;
				colvarSomeNullableFlag.IsReadOnly = false;
				colvarSomeNullableFlag.DefaultSetting = @"";
				colvarSomeNullableFlag.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSomeNullableFlag);
				
				TableSchema.TableColumn colvarLongText = new TableSchema.TableColumn(schema);
				colvarLongText.ColumnName = "LongText";
				colvarLongText.DataType = DbType.String;
				colvarLongText.MaxLength = -1;
				colvarLongText.AutoIncrement = false;
				colvarLongText.IsNullable = false;
				colvarLongText.IsPrimaryKey = false;
				colvarLongText.IsForeignKey = false;
				colvarLongText.IsReadOnly = false;
				colvarLongText.DefaultSetting = @"";
				colvarLongText.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLongText);
				
				TableSchema.TableColumn colvarMediumText = new TableSchema.TableColumn(schema);
				colvarMediumText.ColumnName = "MediumText";
				colvarMediumText.DataType = DbType.String;
				colvarMediumText.MaxLength = 800;
				colvarMediumText.AutoIncrement = false;
				colvarMediumText.IsNullable = false;
				colvarMediumText.IsPrimaryKey = false;
				colvarMediumText.IsForeignKey = false;
				colvarMediumText.IsReadOnly = false;
				colvarMediumText.DefaultSetting = @"";
				colvarMediumText.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMediumText);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Northwind"].AddSchema("SubSonicTests",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("SubSonicTestID")]
		[Bindable(true)]
		public int SubSonicTestID 
		{
			get { return GetColumnValue<int>(Columns.SubSonicTestID); }
			set { SetColumnValue(Columns.SubSonicTestID, value); }
		}
		  
		[XmlAttribute("Thinger")]
		[Bindable(true)]
		public int Thinger 
		{
			get { return GetColumnValue<int>(Columns.Thinger); }
			set { SetColumnValue(Columns.Thinger, value); }
		}
		  
		[XmlAttribute("Name")]
		[Bindable(true)]
		public string Name 
		{
			get { return GetColumnValue<string>(Columns.Name); }
			set { SetColumnValue(Columns.Name, value); }
		}
		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }
			set { SetColumnValue(Columns.UserName, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime CreatedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("Price")]
		[Bindable(true)]
		public decimal Price 
		{
			get { return GetColumnValue<decimal>(Columns.Price); }
			set { SetColumnValue(Columns.Price, value); }
		}
		  
		[XmlAttribute("Discount")]
		[Bindable(true)]
		public double Discount 
		{
			get { return GetColumnValue<double>(Columns.Discount); }
			set { SetColumnValue(Columns.Discount, value); }
		}
		  
		[XmlAttribute("Lat")]
		[Bindable(true)]
		public decimal? Lat 
		{
			get { return GetColumnValue<decimal?>(Columns.Lat); }
			set { SetColumnValue(Columns.Lat, value); }
		}
		  
		[XmlAttribute("LongX")]
		[Bindable(true)]
		public decimal? LongX 
		{
			get { return GetColumnValue<decimal?>(Columns.LongX); }
			set { SetColumnValue(Columns.LongX, value); }
		}
		  
		[XmlAttribute("SomeFlag")]
		[Bindable(true)]
		public bool SomeFlag 
		{
			get { return GetColumnValue<bool>(Columns.SomeFlag); }
			set { SetColumnValue(Columns.SomeFlag, value); }
		}
		  
		[XmlAttribute("SomeNullableFlag")]
		[Bindable(true)]
		public bool? SomeNullableFlag 
		{
			get { return GetColumnValue<bool?>(Columns.SomeNullableFlag); }
			set { SetColumnValue(Columns.SomeNullableFlag, value); }
		}
		  
		[XmlAttribute("LongText")]
		[Bindable(true)]
		public string LongText 
		{
			get { return GetColumnValue<string>(Columns.LongText); }
			set { SetColumnValue(Columns.LongText, value); }
		}
		  
		[XmlAttribute("MediumText")]
		[Bindable(true)]
		public string MediumText 
		{
			get { return GetColumnValue<string>(Columns.MediumText); }
			set { SetColumnValue(Columns.MediumText, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varThinger,string varName,string varUserName,DateTime varCreatedOn,decimal varPrice,double varDiscount,decimal? varLat,decimal? varLongX,bool varSomeFlag,bool? varSomeNullableFlag,string varLongText,string varMediumText)
		{
			SubSonicTest item = new SubSonicTest();
			
			item.Thinger = varThinger;
			
			item.Name = varName;
			
			item.UserName = varUserName;
			
			item.CreatedOn = varCreatedOn;
			
			item.Price = varPrice;
			
			item.Discount = varDiscount;
			
			item.Lat = varLat;
			
			item.LongX = varLongX;
			
			item.SomeFlag = varSomeFlag;
			
			item.SomeNullableFlag = varSomeNullableFlag;
			
			item.LongText = varLongText;
			
			item.MediumText = varMediumText;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varSubSonicTestID,int varThinger,string varName,string varUserName,DateTime varCreatedOn,decimal varPrice,double varDiscount,decimal? varLat,decimal? varLongX,bool varSomeFlag,bool? varSomeNullableFlag,string varLongText,string varMediumText)
		{
			SubSonicTest item = new SubSonicTest();
			
				item.SubSonicTestID = varSubSonicTestID;
			
				item.Thinger = varThinger;
			
				item.Name = varName;
			
				item.UserName = varUserName;
			
				item.CreatedOn = varCreatedOn;
			
				item.Price = varPrice;
			
				item.Discount = varDiscount;
			
				item.Lat = varLat;
			
				item.LongX = varLongX;
			
				item.SomeFlag = varSomeFlag;
			
				item.SomeNullableFlag = varSomeNullableFlag;
			
				item.LongText = varLongText;
			
				item.MediumText = varMediumText;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SubSonicTestIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ThingerColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PriceColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DiscountColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn LatColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn LongXColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn SomeFlagColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SomeNullableFlagColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn LongTextColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MediumTextColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string SubSonicTestID = @"SubSonicTestID";
			 public static string Thinger = @"Thinger";
			 public static string Name = @"Name";
			 public static string UserName = @"UserName";
			 public static string CreatedOn = @"CreatedOn";
			 public static string Price = @"Price";
			 public static string Discount = @"Discount";
			 public static string Lat = @"Lat";
			 public static string LongX = @"Long";
			 public static string SomeFlag = @"SomeFlag";
			 public static string SomeNullableFlag = @"SomeNullableFlag";
			 public static string LongText = @"LongText";
			 public static string MediumText = @"MediumText";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}