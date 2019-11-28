using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Codeplex.Data;

namespace IPSDecoder
{

    public class Clusters
    {
        public int Adr = 0;
        public int Size = 0;
        public bool IsPatch = true;
        public byte[] PatchValues = new byte[0];
        public byte FillValue = 0;
        public Clusters()
        {

        }
    }

    public class IPS
    {
        private string m_filepath = "";
        private byte[] m_data = new byte[0];
        private int m_start = 0;
        private int m_last = 0;
        private string m_ResultStr = "";
        public string ResultStr { get { return m_ResultStr; } }
        public IPS()
        {

        }
        public bool LoadFile(string p)
        {
            bool ret = false;
            m_start = m_last = 0;
            m_filepath = "";
            m_data = new byte[0];
            m_ResultStr = "";
            if (File.Exists(p) == false) return ret;
            FileStream fs = new FileStream(p, System.IO.FileMode.Open, FileAccess.Read);
            try
            {
                int fsize = (int)fs.Length;
                m_data = new byte[fsize];
                int sz = fs.Read(m_data, 0, fsize);
                if (sz == fsize)
                {
                    //50 41 54 43 48
                    //45 4F 46
                    if (( m_data[0]==0x50)
                        && (m_data[1] == 0x41)
                        && (m_data[2] == 0x54)
                        && (m_data[3] == 0x43)
                        && (m_data[4] == 0x48)
                        && (m_data[sz - 3] == 0x45)
                        && (m_data[sz - 2] == 0x4F)
                        && (m_data[sz - 1] == 0x46))
                    {
                        m_start = 5;
                        m_last = sz - 4;
                        ret = true;
                    }
                }
            }
            finally
            {
                fs.Close();
            }
            if (ret == false)
            {
                m_data = new byte[0];
            }
            else
            {
                m_filepath = p;
                ret = Decode();
            }
            //イベント
            return ret;
        }
        private bool Decode()
        {
            bool ret = false;
            if ((m_start < 5) || (m_last <= 0)) return ret;

            int idx = m_start;


            string cr = "";
            do
            {
                dynamic data = new DynamicJson();

                try
                {
                    if (idx >= m_last - 2) break;
                    int adr = (m_data[idx] << 16) | (m_data[idx + 1] << 8) | (m_data[idx + 2]);
                    idx += 3;
                    if (idx >= m_last - 1) break;
                    int ps = (m_data[idx] << 8) | (m_data[idx + 1]);
                    idx += 2;

                    int fillSize = 0;
                    int fillValue = 0;
                    string[] vs = new string[ps];
                    if (ps > 0)
                    {
                        //if (idx >= m_last - ps) break;
                        for (int i = 0; i < ps; i++)
                        {
                            vs[i] = String.Format("0x{0:X2}", m_data[idx]);
                            idx++;
                            if (idx > m_last) break;
                        }

                        data["Adr"] = String.Format("0x{0:X6}", adr);
                        data["PatchSize"] = String.Format("0x{0:X6}", ps);
                        data["PatchValues"] = vs;
                    }
                    else
                    {
                        fillSize = (m_data[idx] << 8) | (m_data[idx + 1]);
                        idx += 2;
                        fillValue = m_data[idx];
                        idx++;

                        data["Adr"] = String.Format("0x{0:X6}", adr);
                        data["FillSize"] = String.Format("0x{0:X6}", fillSize);
                        data["FillValue"] = String.Format("0x{0:X6}", fillValue);
                    }
                    if (cr != "") cr += ",\r\n";
                    cr += "\t" + data.ToString();
                    ret = true;
                }
                catch
                {
                    ret = false;
                    break;
                }
                
                
            } while (idx <= m_last);

            string js = "";
            js += "{\r\n";
            js += "\"FileName\":\"" + Path.GetFileName(m_filepath) + "\",\r\n";
            js += "\"Clusters\":" + "[\r\n";
            js += cr;
            js += "\r\n]\r\n";
            js += "}";
            if (ret == false)
            {
                js = "ERROR !\r\n" + js; 
            }
            m_ResultStr = js;
            return ret;
        }
    }
}
