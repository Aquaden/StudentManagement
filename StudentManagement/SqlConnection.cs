using Microsoft.Data.SqlClient;

namespace StudentManagement
{
    internal class SqlConnection1:IDisposable
    {
        public SqlConnection1(string connectionstring)
        {
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal SqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}