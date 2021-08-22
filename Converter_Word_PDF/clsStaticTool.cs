using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace Converter_Word_PDF
{
    public static class clsStaticTool
    {
        /// <summary>
        /// 儲存 XML
        /// </summary>
        /// <param name="SrcProduct"></param>
        /// <param name="PathFile"></param>
        /// <returns></returns>
        public static bool SaveXML(Object SrcProduct, string PathFile) // (20190822) Jeff Revised!
        {
            bool b_status_ = false;
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(PathFile));

            try
            {
                XmlSerializer XmlS = new XmlSerializer(SrcProduct.GetType());
                Stream S = File.Open(PathFile, FileMode.Create);
                XmlS.Serialize(S, SrcProduct);
                S.Close();
                b_status_ = true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }

            return b_status_;
        }

        /// <summary>
        /// 載入 XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PathFile"></param>
        /// <param name="Recipe"></param>
        /// <returns></returns>
        public static bool LoadXML<T>(string PathFile, out T Recipe) // (20200429) Jeff Revised!
        {
            bool b_status_ = false;
            //Recipe = new T();
            Recipe = default(T); // i.e. Recipe = null

            if (File.Exists(PathFile) == false)
                return false;

            try
            {
                //XmlSerializer XmlS = new XmlSerializer(Recipe.GetType());
                XmlSerializer XmlS = new XmlSerializer(typeof(T));
                Stream S = File.Open(PathFile, FileMode.Open);
                Recipe = (T)XmlS.Deserialize(S);
                S.Close();
                b_status_ = true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            return b_status_;
        }
    }
}
