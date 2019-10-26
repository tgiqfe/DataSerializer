using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataSerializer
{
    class DataSerializer
    {
        #region Deserialize

        /// <summary>
        /// ファイルからオブジェクトにデシリアライズ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string fileName) where T : class, new()
        {
            using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
            {
                return Deserialize<T>(sr, Enum.TryParse(
                    Path.GetExtension(fileName).TrimStart('.'), true, out DataType extension) ?
                    extension : DataType.None);
            }
        }

        /// <summary>
        /// 文字列からオブジェクトにデシリアライズ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceText"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string sourceText, DataType extension) where T : class, new()
        {
            using (StringReader sr = new StringReader(sourceText))
            {
                return Deserialize<T>(sr, extension);
            }
        }

        /// <summary>
        /// TextStreamからオブジェクトにデシリアライズ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tr"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static T Deserialize<T>(TextReader tr, DataType extension) where T : class, new()
        {
            switch (extension)
            {
                case DataType.Json:
                    return JSON.Deserialize<T>(tr);
                case DataType.Xml:
                    return XML.Deserialize<T>(tr);
                case DataType.Yml:
                    return YML.Deserialize<T>(tr);
            }
            return null;
            //return new T();
        }

        #endregion

        #region Serialize

        /// <summary>
        /// オブジェクトをシリアライズしてファイルに出力
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void Serialize<T>(object obj, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                Serialize<T>(obj, sw, Enum.TryParse(
                    Path.GetExtension(fileName).TrimStart('.'), true, out DataType extension) ?
                    extension : DataType.None);
            }
        }

        /// <summary>
        /// オブジェクトをシリアライズして文字列として返す
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string Serialize<T>(object obj, DataType extension)
        {
            using (StringWriter sw = new StringWriter())
            {
                Serialize<T>(obj, sw, extension);
                return sw.ToString();
            }
        }

        /// <summary>
        /// オブジェクトをシリアライズしてTextStreamに出力
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tw"></param>
        /// <param name="extension"></param>
        public static void Serialize<T>(object obj, TextWriter tw, DataType extension)
        {
            switch (extension)
            {
                case DataType.Json:
                    break;
                case DataType.Xml:
                    break;
                case DataType.Yml:
                    break;
            }
        }

        #endregion
    }
}
