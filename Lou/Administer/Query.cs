using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace Lou.Administer
{ class Query : Detract.MySQL
    {
        public MySqlConnection _connect;
        public MySqlCommand _command;
        public MySqlDataReader _reader;
        public string _query;
 
        public override void OPEN()
        {
            _connect.Open();
        }
        public override void CLOSE()
        { _connect.Close();
        }
        public override void PREPARE(string _host, string _database, string _username, string _password)
        {
            _connect = new MySqlConnection("SERVER=" + _host + ";" + "DATABASE=" + _database + ";" + "UID=" + _username + ";" + "PASSWORD=" + _password + ";");
            OPEN();
        }
        public override void MAKE_TABLE(string _tablename, Dictionary<string, string> _columns)
        {
            _query = "";
            foreach (var a in _columns) {
                _query += a.Key + " " + a.Value + ",";
            }
            _query = "create table if not exists " + _tablename + "(" + _query.Remove(_query.Length - 1) + ")";
            COMMIT();
        }
        public override void COMMIT()
        {
           
            CLOSE();
            OPEN();
            _command = new MySqlCommand(_query, _connect);
             
            _command.ExecuteNonQuery();
        }
        public override void READ()
        {
            CLOSE();
            OPEN();
            COMMIT();
            _reader = _command.ExecuteReader();
        }
        public override string GET_ONE(string _tablename, string _statement, string _field)
        {
            string ret = null; _query = "select " + _field + " from " + _tablename + " where " + _statement;
            READ();
            while (_reader.Read()) {
                ret = _reader.GetString(_field);
            }
            return ret;
        }
        public override List<string> GET_MORE(string _tablename, string _statement, string[] _field)
        {
            List<string> ret = new List<string>(); _query = "";
            foreach (string a in _field) {
                _query += a + ",";
            }
            _query = "select " + _query.Remove(_query.Length - 1) + " from " + _tablename + " where " + _statement;
            READ();
            while (_reader.Read()) {
                foreach (string a in _field) {
                    ret.Add(_reader.GetString(a));
                }
            }
            return ret;
        }
        public override int COUNT(string _tablename)
        {
            int count = 0; _query = "select count(*) from " + _tablename; READ();
            while (_reader.Read()) {
                count = Int16.Parse(_reader.GetString(0));
            } return count;
        }
        public override void PUT(string _tablename, Dictionary<string, string> _columns)
        {
            string columns = "";
            string values = "";
            foreach (var a in _columns) {
                columns += a.Key + ",";
                values += "'" + a.Value + "'" + ",";
            }
            _query = "insert into " + _tablename + " (" + columns.Remove(columns.Length - 1) + ") values (" + values.Remove(values.Length - 1) + ")";
            COMMIT();
        }
        public override void CHANGE(string _tablename, string _statement, Dictionary<string, string> _columns)
        {
            _query = "";
            foreach (var a in _columns) {
                _query += a.Key + "='" + a.Value + "'" + ",";
            }
            _query = "update " + _tablename + " set " + _query.Remove(_query.Length - 1) + " where " + _statement;
            COMMIT();
        }
        public override void ERASE(string _tablename, string _statement, string _field)
        {
            _query = "";
            _query = "delete " + _field + " from " + _tablename + " where " + _statement;
            READ();
        }

    }
}