using NFDao.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class BaseCrud<x> : BaseConnection where x : new()
    {
        internal KeyQuery[] querys { get; set; }

        private PropertyInfo[] GetProperties()
        {
            return typeof(x).GetProperties();
        }
        protected List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow row in dataTable.AsEnumerable())
            {
                T obj = new T();

                foreach (DataColumn col in dataTable.Columns)
                {
                    // Obtén el nombre de la propiedad correspondiente en el objeto genérico
                    string propertyName = col.ColumnName;

                    // Obtén el valor de la celda en el DataTable
                    object value = row[col];

                    // Asigna el valor a la propiedad correspondiente en el objeto genérico
                    PropertyInfo propertyInfo = typeof(T).GetProperty(propertyName);

                    if (propertyInfo != null && propertyInfo.PropertyType == typeof(int))
                    {
                        // Verifica si el valor es DBNull y, en ese caso, asigna 0 a la propiedad de tipo int
                        if (value != DBNull.Value)
                        {
                            propertyInfo.SetValue(obj, value);
                        }
                        else
                        {
                            propertyInfo.SetValue(obj, 0);
                        }
                    }
                    else
                    {
                        // Asigna el valor a la propiedad correspondiente en el objeto genérico sin realizar
                        // ninguna modificación si no es de tipo int
                        propertyInfo?.SetValue(obj, value);
                    }
                }

                list.Add(obj);
            }

            return list;
        }
        public List<x> Select() 
        {
            SqlCommand command = CreateComand(querys.FirstOrDefault(q => q.key == "Select").query);
            try
            {
                return ConvertDataTableToList<x>(DataTableCommand(command));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Insert(x obj) 
        {

            SqlCommand command = CreateComand(querys.FirstOrDefault(q => q.key == "Insert").query);
            foreach (PropertyInfo property in GetProperties())
            {
                // Obtén el nombre de la propiedad y su valor en el objeto obj
                string propertyName = property.Name;
                object propertyValue = property.GetValue(obj);

                // Agrega un parámetro a la consulta con el nombre de la propiedad
                // y el valor obtenido del objeto
                if(propertyName == "password")
                {
                    command.Parameters.AddWithValue("@" + propertyName, propertyValue).SqlDbType = SqlDbType.VarChar; ;
                }
                else if (propertyName == "systemUserId" && propertyValue.ToString() == "0")
                {
                    command.Parameters.AddWithValue("@" + propertyName,DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + propertyName, propertyValue ?? DBNull.Value);
                }
                
            }
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Update(x obj)
        {

            SqlCommand command = CreateComand(querys.FirstOrDefault(q => q.key == "Update").query);
            foreach (PropertyInfo property in GetProperties())
            {
                // Obtén el nombre de la propiedad y su valor en el objeto obj
                string propertyName = property.Name;
                object propertyValue = property.GetValue(obj);

                // Agrega un parámetro a la consulta con el nombre de la propiedad
                // y el valor obtenido del objeto
                if (propertyName == "password")
                {
                    command.Parameters.AddWithValue("@" + propertyName, propertyValue).SqlDbType = SqlDbType.VarChar; ;
                }
                else if (propertyName == "systemUserId" && propertyValue.ToString() == "0")
                {
                    command.Parameters.AddWithValue("@" + propertyName, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + propertyName, propertyValue ?? DBNull.Value);
                }
            }
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public x Get(int id)
        {
            x obj = new x();
            SqlCommand command = CreateComand(querys.FirstOrDefault(q => q.key == "Get").query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable dt = DataTableCommand(command);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        PropertyInfo property = typeof(x).GetProperty(column.ColumnName);
                        if (property != null && dt.Rows[0][column] != DBNull.Value)
                        {
                            property.SetValue(obj, dt.Rows[0][column]);
                        }
                    }


                }
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public int Delete(int id) 
        {

            SqlCommand command = CreateComand(querys.FirstOrDefault(q => q.key == "Delete").query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
