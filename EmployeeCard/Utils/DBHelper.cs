using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeCard.Utils
{
   public enum TableFieldTypes
    {
        integer,
        nvarchar
    }

    public class TableField
    {
        public string TableFieldValue { get; set; }
        public TableFieldTypes TableFieldType { get; set; }
    }
    public static class DBHelper
    {
        public static List<string> SelectValuesFromTable(string tableName, int id)
        {
            var result = new List<string>();
            try
            {
                var conn = new SqlConnection(Properties.Settings.Default.EmployeeBDConnectionString);
                var query = $"SELECT * FROM {tableName} WHERE Id = {id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Clear();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(reader[i].ToString());
                    }
                }
            }
            catch
            {

            }
            return result;
        }
        public static int InsertEntry(string tableName, Dictionary<string, TableField> fields)
        {
                var res = 0;
                var conn = new SqlConnection(Properties.Settings.Default.EmployeeBDConnectionString);
                var fieldsNames = string.Join(",", fields.Select(f => f.Key));
                var fieldsValues = string.Join(",", fields.Select(f =>
                {
                    if (f.Value.TableFieldType == TableFieldTypes.integer)
                    {
                        return f.Value.TableFieldValue;
                    }
                    return $"'{f.Value.TableFieldValue}'";
                }));
                var query = $"INSERT INTO {tableName} ({fieldsNames}) VALUES ({fieldsValues})";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                var selectedLastItemQuery = $"SELECT TOP 1 Id FROM {tableName} ORDER BY Id DESC";
                 var selectedLastItemCmd = new SqlCommand(selectedLastItemQuery, conn);
                 conn.Open();
             var reader = selectedLastItemCmd.ExecuteReader();
            while(reader.Read())
            {
                int.TryParse(reader[0].ToString(), out res);
            }
            conn.Close();

            return res;

        }
        public static void UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
        {
                var conn = new SqlConnection(Properties.Settings.Default.EmployeeBDConnectionString);
                var updatingFieldsValues = string.Join(",", fields.Select(f =>
                {
                    var fieldValue = string.Empty;
                    if (f.Value.TableFieldType == TableFieldTypes.integer)
                    {
                        fieldValue = f.Value.TableFieldValue;
                    }
                    else
                    {
                        fieldValue = $"'{f.Value.TableFieldValue}'";
                    }
                    return $"{f.Key}= {fieldValue}";
                }));
                var query = $"UPDATE {tableName} SET {updatingFieldsValues} WHERE Id = {id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();  
        }
        public static void DeleteEntry(string tableName, int id)
        {
            
            var conn = new SqlConnection(Properties.Settings.Default.EmployeeBDConnectionString);
                var query = $"DELETE FROM {tableName} WHERE Id={id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
        }

    } 
}
