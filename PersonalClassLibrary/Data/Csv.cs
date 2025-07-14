using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace PersonalClassLibrary.Data
{
    class Csv
    {
        /// <summary>
        /// Write to a CSV file.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="separator"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool WriteToFile(List<string[]> data, string separator, string path)
        {
            bool flag = true;
            StreamWriter st = null;
            try
            {
                st = new StreamWriter(path, false, Encoding.UTF8);
                for (int i = 0; i < data.Count; i++)
                {
                    st.WriteLine(string.Join(separator, data[i]));
                }
            }
            catch
            {
                flag = false;
            }
            finally
            {
                st.Close();
                st.Dispose();
            }



            return flag;

        }

        /// <summary>
        /// Read from a CSV file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static List<string[]> ReadFromFile(string path, char separator)
        {
            List<string[]> lst = new List<string[]>();

            StreamReader st = null;

            try
            {
                st = new StreamReader(path, Encoding.UTF8);
                string line = "";
                while ((line = st.ReadLine())!=null)
                {
                    lst.Add(line.Split(separator));
                }
            }
            catch
            {
                return lst;
            }
            finally
            {
                st.Close();
                st.Dispose();
            }

            return lst;
        }

    }
}
