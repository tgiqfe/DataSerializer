using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSerializer
{
    /// <summary>
    /// キーが無い場合にデフォルト値を返す為の拡張クラス
    /// </summary>
    public static class DictionaryExtensions
    {
        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key, TValue defaultValue)
        {
            if (source == null)
            {
                source = new Dictionary<TKey, TValue>();
            }

            return source.ContainsKey(key) ? source[key] : defaultValue;
        }
    }
}
