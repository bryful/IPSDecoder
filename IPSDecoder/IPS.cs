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
        private readonly string wk = "\"";
        private int m_Adr = 0;
        public int Adr
        {
            get { return m_Adr; }
            set
            {
                m_Adr = value;
            }
        }
        private int m_PatchSize = 0;
        public int PatchSize
        {
            get { return m_PatchSize; }
            set
            {
                m_PatchSize = value;
                if (m_PatchSize < 0) m_PatchSize = 0;
                PatchValues = new byte[m_PatchSize];
            }
        }
        private int m_FilllSize =0;
        public int FilllSize
        {
            get { return m_FilllSize; }
            set
            {
                m_FilllSize = value;
                if (m_FilllSize < 0) m_FilllSize = 0;
            }
        }
        public int Size
        {
            get { if (m_PatchSize > 0) return PatchSize; else return FilllSize; }
        }
        public int AdrEnd
        {
            get { return m_Adr + Size - 1; }
        }


        public bool IsPatch
        {
            get { return (PatchSize != 0); }
        }
        public byte[] PatchValues = new byte[0];
        private byte m_FillValue = 0;
        public byte FillValue
        {
            get { return m_FillValue; }
            set { m_FillValue = value; }
        }
        public Clusters()
        {

        }
        // *
        private string ToS(int v)
        {
            return String.Format("0x{0:X6}", v);
        }
        private string ToB(byte v)
        {
            return String.Format("0x{0:X2}", v);
        }
        public string ToJson()
        {
            string ret = "{";

            ret += wk + "Adr" + wk + ":" + wk + ToS(m_Adr) + wk + ",";
            if (IsPatch == true)
            {
                ret += wk + "Patch" + wk + ":true"  + ",";
                ret += wk + "Size" + wk + ":" + wk + ToS(m_PatchSize) + wk + ",";
                ret += wk+"Value:"+wk+ "[";

                string s2 = "";
                for (int i=0; i< PatchSize; i++)
                {
                    if (s2 != "") s2 += ",";
                    s2 += wk + ToB(PatchValues[i]) + wk;
                }
                ret +=s2 + "]}";

            }else
            {
                ret += wk + "Patch" + wk + ":false" + ",";
                ret += wk + "Size" + wk + ":" + wk + ToS(m_FilllSize) + wk + ",";
                ret += wk + "Value" + wk + ":" + wk + ToS(m_FillValue) + wk;
                ret += "}";
            }
            return ret;
        }

        public bool Enabled
        {
            get
            {
                return (((m_PatchSize > 0)&&(PatchValues.Length>0)) || (m_FilllSize > 0));
            }
        }
        public bool InAdr(int a)
        {
            if(m_PatchSize>0)
            {
                return ((a >= m_Adr) && (a < m_Adr + m_PatchSize));
            }
            else
            {
                return ((a >= m_Adr) && (a < m_Adr + m_FilllSize));
            }
        }
        public bool InAdr(Clusters clst)
        {
            return ((InAdr(clst.Adr)) || (InAdr(clst.AdrEnd)));
        }
    }

    public class IPS
    {
        private readonly string wk = "\"";
        private readonly string CRLF = "\r\n";
        // *******************************************************************************************
        private string m_filepath = "";
        public string FilePath
        {
            get { return m_filepath; }
            set
            {
                LoadFile(value);
            }
        }

        private List<Clusters> m_clusters = new List<Clusters>();

        public Clusters this[int idx]
        {
            get
            {
                return m_clusters[idx];
            }
        }
        public bool IsEnabled
        {
            get { return (m_clusters.Count > 0); }
        }
        // *******************************************************************************************
        public IPS()
        {

        }
        // *******************************************************************************************
        public void Claer()
        {
            m_clusters.Clear();
            m_filepath = "";
        }
        // *******************************************************************************************
        public void Sort()
        {
            m_clusters.Sort((a, b) => a.Adr - b.Adr);
        }
        // *******************************************************************************************
        public bool CanAdd(Clusters clst)
        {
            bool ret = false;
            if (clst.Enabled == false) return ret;
            if (m_clusters.Count<=0)
            {
                ret = true;
            }
            else
            {
                if (clst.AdrEnd < m_clusters[0].Adr)
                {
                    ret = true;
                } else if ((clst.Adr > m_clusters[m_clusters.Count - 1].AdrEnd))
                {
                    ret = true;
                }
                else
                {
                    ret = true;
                    for (int i=0;i<m_clusters.Count;i++)
                    {
                        if (m_clusters[i].InAdr(clst) == true)
                        {
                            ret = false;
                            break;
                        }
                    }
                }

            }
            return ret;
        }
        // *******************************************************************************************
        public bool Add(Clusters clst)
        {
            bool ret = false;
            if(CanAdd(clst)==true)
            {
                m_clusters.Add(clst);
                Sort();
                ret = true;
            }
            return ret;
        }
        // *******************************************************************************************
        public string ToJson()
        {
            string ret = "";
            if (m_clusters.Count <= 0) return "{}";
            ret += "{" + CRLF;
            ret += wk + "Name" + wk + ":" + wk + Path.GetFileName(m_filepath) + wk + "," + CRLF;
            ret += wk + "Clusters" + wk + ":" + "[" + CRLF;
            string s = "";
            for (int i = 0;i< m_clusters.Count; i++)
            {
                s += m_clusters[i].ToJson();
                if(i< m_clusters.Count-1)
                {
                    s += ",";
                }
                s += CRLF;
            }
            ret +=  s + "]"+CRLF;
            ret += "}";

            return ret;
        }
        public bool LoadFile(string p)
        {
            bool ret = false;
            int st = 0;
            int ed = 0;
            m_filepath = "";
            byte [] d = new byte[0];
            if (File.Exists(p) == false) return ret;
            FileStream fs = new FileStream(p, System.IO.FileMode.Open, FileAccess.Read);
            try
            {
                int fsize = (int)fs.Length;
                d = new byte[fsize];
                int sz = fs.Read(d, 0, fsize);
                if (sz == fsize)
                {
                    //50 41 54 43 48
                    //45 4F 46
                    if (( d[0]==0x50)
                        && (d[1] == 0x41)
                        && (d[2] == 0x54)
                        && (d[3] == 0x43)
                        && (d[4] == 0x48)
                        && (d[sz - 3] == 0x45)
                        && (d[sz - 2] == 0x4F)
                        && (d[sz - 1] == 0x46))
                    {
                        st = 5;
                        ed= sz - 4;
                        ret = true;
                    }
                }
            }
            finally
            {
                fs.Close();
            }
            if (ret == true)
            {
                m_filepath = p;
                ret = Decode(d,st,ed);
            }
            //イベント
            return ret;
        }
        private bool Decode(byte [] d,int st, int ed)
        {
            bool ret = false;
            if (d.Length <= 8) return ret;
            if ((st < 5) || (ed <= 0)) return ret;
 
            int idx = st;

            m_clusters.Clear();

            do
            {
                dynamic data = new DynamicJson();

                Clusters clst = new Clusters();
                try
                {
                    if (idx >= ed - 2) break;
                    clst.Adr = (d[idx] << 16) | (d[idx + 1] << 8) | (d[idx + 2]);
                    idx += 3;
                    if (idx >= ed - 1) break;
                    clst.PatchSize = (d[idx] << 8) | (d[idx + 1]);
                    idx += 2;

                    if (clst.PatchSize > 0)
                    {
                        for (int i = 0; i < clst.PatchSize; i++)
                        {
                            clst.PatchValues[i] = d[idx];
                            idx++;
                            if (idx > ed) break;
                        }
                    }
                    else
                    {
                        clst.FilllSize = (d[idx] << 8) | (d[idx + 1]);
                        idx += 2;
                        clst.FillValue = d[idx];
                        idx++;
                    }
                    m_clusters.Add(clst);
                    ret = true;
                }
                catch
                {
                    ret = false;
                    m_clusters.Clear();
                    break;
                }
                
                
            } while (idx <= ed);
            return ret;
        }
    }
}
