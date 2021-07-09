using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builders
{
    public interface IKeyValueCollectionBuilder
    {
        IKeyValueCollectionBuilder Add(string key, string value);
    }

    public class QueryBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();
        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            _queryStringBuilder.Append(_queryStringBuilder.Length == 0 ? "?" : "&");
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append("=");
            _queryStringBuilder.Append(Uri.EscapeDataString(value));
            return this;
        }

        public string Build()
        {
            return _queryStringBuilder.ToString();
        }
    }

    public class FormBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();

        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append("=");
            _queryStringBuilder.Append(value);
            _queryStringBuilder.AppendLine();
            return this;
        }

        public string Build()
        {
            return _queryStringBuilder.ToString();
        }
    }

    public class HttpHeaderBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();

        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append(": ");
            _queryStringBuilder.Append(value);
            _queryStringBuilder.AppendLine();
            return this;
        }

        public string Build()
        {
            return _queryStringBuilder.ToString();
        }
    }

    public class DictBuilder : IKeyValueCollectionBuilder
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            _dictionary[key] = value;
            return this;
        }

        public string Build()
        {
            var str = string.Empty;
            foreach (var item in _dictionary)
            {
                str += $"Key = {item.Key}, Value = {item.Value}";
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
