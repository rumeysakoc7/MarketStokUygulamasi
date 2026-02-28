using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class LogRepository
    {
        private readonly DatabaseHelper _dbHelper;

        public LogRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public DataTable GetAllLogs()
        {
            string query = "SELECT * FROM Loglar";
            return _dbHelper.ExecuteQuery(query);
        }

        public DataTable GetLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT * FROM Loglar WHERE TimeStamp BETWEEN @StartDate AND @EndDate";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StartDate", startDate),
            new SqlParameter("@EndDate", endDate)
            };
            return _dbHelper.ExecuteQuery(query, parameters);
        }
    }

}
