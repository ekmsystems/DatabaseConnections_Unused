using System;
using System.Collections.Generic;
using System.Data;

namespace DatabaseConnections
{
    public interface IDatabase
    {
        IList<IDatabaseCommandInterceptor> Interceptors { get; }

        int ExecuteNonQuery(DatabaseCommand command);
        DataSet ExecuteQuery(DatabaseCommand command);
        DataSet ExecutePagedQuery(DatabaseCommand command, int startRecord, int maxRecords, string tableName);
        object ExecuteScalar(DatabaseCommand command);
        IDataReader ExecuteReader(DatabaseCommand command);

        event EventHandler<DatabaseCommandExecutingEventArgs> Executing;
        event EventHandler<DatabaseCommandExecutedEventArgs> Executed;
    }
}