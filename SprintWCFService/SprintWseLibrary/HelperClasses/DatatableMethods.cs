using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using SprintWseLibrary.com.sprint.WholesaleQueryCsaService;
using Microsoft.Web.Services3;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3.Security;


////http://weblogs.asp.net/psperanza/archive/2005/05/24/408709.aspx


namespace SprintWseLibrary.HelperClasses
{
    class DatatableMethods
    {



      
    }

    /// <summary>
    ///             The Converter class provides methods to convert objects into data tables.
    /// </summary>
    public class Converter
    {
        /// <summary>
        ///             An array of the names of the System data types.
        /// </summary>
        private static String[] _systemTypes = new String[]{ "SYSTEM.BYTE", "SYSTEM.CHAR", "SYSTEM.DECIMAL", "SYSTEM.DOUBLE", "SYSTEM.INT16", "SYSTEM.INT32", "SYSTEM.INT64",
                                                                                                                "SYSTEM.SBYTE", "SYSTEM.SINGLE", "SYSTEM.UINT16", "SYSTEM.UINT32", "SYSTEM.UINT64", "SYSTEM.DATETIME",
                                                                                                                "SYSTEM.STRING", "SYSTEM.BOOLEAN" };

        private Converter() { }

        /// <summary>
        ///             Converts an object into a data table.
        /// </summary>
        /// <param name="source">Spcifies the object to convert into a data table.</param>
        /// <returns>Returns a data table created from an object.</returns>
        public static DataTable ConvertToDataTable(Object source)
        {
            PropertyInfo[] properties = source.GetType().GetProperties();
            DataTable dt = CreateDataTable(properties, source);
            dt.TableName = source.GetType().Name;
            FillData(properties, dt, null, String.Empty, source);
            return dt;
        }


        /// <summary>  
        ///             Converts an array of objects into a data table.
        /// </summary>
        /// <param name="array">Specifies the array of objects that wil be used to create the data table.</param>
        /// <returns>Returns a data table created from the array of objects.</returns>
        public static DataTable ConvertToDataTable(Object[] array)
        {


            PropertyInfo[] properties = array.GetType().GetElementType().GetProperties();

            //Added to remove errors prakash
            var x = properties.ToList();

            var x1 = (from p in properties
                     where
                         p.Name == "serviceDescriptionList"
                     select  p).FirstOrDefault();

            x.Remove(x1);

            properties = x.ToArray();
         
            

            DataTable dt = CreateDataTable(properties, null);
            dt.TableName = array.GetType().GetElementType().Name + DateTime.Now.Millisecond.ToString();

            if (array.Length != 0)
            {
                foreach (object source in array)
                    FillData(properties, dt, null, String.Empty, source);

            }

            return dt;
        }


        /// <summary>
        ///             Creates a new data table from the properties of an object.
        /// </summary>
        /// <param name="properties">Specifies the property information used to create the data table.</param>
        /// <returns>Returns a data table created from an object.</returns>
        private static DataTable CreateDataTable(PropertyInfo[] properties, object source)
        {
            DataTable dt = new DataTable();
            CreateColumns(properties, dt, String.Empty, source);
            return dt;
            
        }


        /// <summary>
        ///             Creates the columns in a data table from the properties of an object.
        /// </summary>
        /// <param name="properties">Specifies the property information used to create the columns.</param>
        /// <param name="dt">Specifies the data table being created.</param>
        /// <param name="expandedName">Specifies the property name plus the nested object's property name when the column name is from a nested object.</param>
        private static void CreateColumns(PropertyInfo[] properties, DataTable dt, String expandedName, object source)
        {
            DataColumn dc = null;
            PropertyInfo[] nestedProperties = null;
            Object nested = null;

            foreach (PropertyInfo pi in properties)
            {
                if (IsSystemType(pi.PropertyType.ToString()) || pi.PropertyType.IsEnum)
                {
                    dc = new DataColumn();
                    dc.ColumnName = expandedName + pi.Name;

                    if (pi.PropertyType.IsEnum)    // Enums always get the string type because we stuff the enum item name as the value.
                        dc.DataType = Type.GetType("System.String");
                    else
                        dc.DataType = pi.PropertyType;

                    dt.Columns.Add(dc);
                }
                else
                {
                    try
                    {

                        nested = pi.GetValue(source, null);

                        if (pi.GetType().IsArray)
                            nestedProperties = nested.GetType().GetElementType().GetProperties();
                        else
                            nestedProperties = nested.GetType().GetProperties();

                        CreateColumns(nestedProperties, dt, pi.Name, nested);
                    }
                    catch (System.Exception ex)
                    {
                        
                        throw;
                    }
                }
            }
        }

        /// <summary>
        ///             Fills a data row with values from an object.
        /// </summary>
        /// <param name="properties">Specifies the property that we are fill the data from.</param>
        /// <param name="dt">Specifies the data table being fllled.</param>
        /// <param name="row">Specifies the data row that will be filled with the property value.</param>
        /// <param name="expandedName">Specifies the property name plus the nested object's property name when the column name is from a nested object.</param>
        /// <param name="source">Specifies the object that contains the property being read..</param>
        private static void FillData(PropertyInfo[] properties, DataTable dt, DataRow row, String expandedName, object source)
        {
            DataRow newRow = null;
            PropertyInfo[] nestedProperties = null;
            Object nested = null;

            if (row == null)
                newRow = dt.NewRow();
            else
                newRow = row;

            object itemVal =null;
            DateTime dtValue= DateTime.MinValue;
            foreach (PropertyInfo pi in properties)
            {
                if (IsSystemType(pi.PropertyType.ToString()))
                {
                    itemVal = pi.GetValue(source, null);
                    if (itemVal != null && DateTime.TryParse(itemVal.ToString(),out dtValue))
                    {

                        if (dtValue != DateTime.MinValue)
                        {
                            newRow[expandedName + pi.Name] = pi.GetValue(source, null);
                        }
                    }
                    else
                    {
                        newRow[expandedName + pi.Name] = pi.GetValue(source, null);
                    }
                    
                }
                else if (pi.PropertyType.IsEnum)
                {
                    int i = 0;
                    itemVal = pi.GetValue(source, null);
                    string[] names = Enum.GetNames(itemVal.GetType());

                    // Pull the enum text into the column value.
                    foreach (object o in Enum.GetValues(itemVal.GetType()))
                    {
                        if (o.ToString() == itemVal.ToString())
                            newRow[expandedName + pi.Name] = names[i];
                        i++;
                    }


                }
                else
                {
                    nested = pi.GetValue(source, null);

                    if (pi.GetType().IsArray)
                        nestedProperties = nested.GetType().GetElementType().GetProperties();
                    else
                        nestedProperties = nested.GetType().GetProperties();

                    FillData(nestedProperties, dt, newRow, pi.Name, nested);
                }

            }

            if (row == null)
                dt.Rows.Add(newRow);
        }


        /// <summary>
        ///             IsSystemType determines if the name of a proerty type is one of the system data types.
        /// </summary>
        /// <param name="type">Specifies the name of the property type.</param>
        /// <returns>True if the type is a system type, otherwise false.</returns>
        private static bool IsSystemType(String type)
        {
            String utype = type.ToUpper();

            foreach (String st in _systemTypes)
            {
                if (utype == st)
                    return true;
            }

            return false;
        }



        public static DataTable GetDataTableForType(Type type)
        {


            try
            {
                Type myObject = type;
                System.Reflection.FieldInfo[] fieldInfo = myObject.GetFields();
                DataTable dt = new DataTable();
                foreach (System.Reflection.FieldInfo info in fieldInfo)
                {
                    dt.Columns.Add(info.Name, info.FieldType);
                }


                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }

   


}
