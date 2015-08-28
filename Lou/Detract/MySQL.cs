using System.Collections.Generic;

namespace Lou.Detract
{
    abstract class MySQL
    {
        public abstract void OPEN(); 
        public abstract void CLOSE();
        public abstract void COMMIT();
        public abstract void READ();
        public abstract void PREPARE(string _host, string _database, string _username, string _password); 
        public abstract void MAKE_TABLE(string _tablename, Dictionary<string, string> _columns);
        public abstract string GET_ONE(string _tablename, string _statement, string _field);
        public abstract List<string> GET_MORE(string _tablename, string _statement, string[] _field);
        public abstract int COUNT(string _tablename);
        public abstract void PUT(string _tablename, Dictionary<string, string> _columns);
        public abstract void CHANGE(string _tablename, string _statement, Dictionary<string, string> _columns);
    }
}

