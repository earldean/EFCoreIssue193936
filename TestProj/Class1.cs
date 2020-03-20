using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProj
{
    public class Class1
    {
        private SqliteConnection connection;
        public Class1()
        {
            connection = new SqliteConnection(new SqliteConnectionStringBuilder
            {
                DataSource = ":memory:"
            }.ToString());
        }

        [Fact]
        public void RunTest()
        {
            Assert.True(true);
        }
    }
}
