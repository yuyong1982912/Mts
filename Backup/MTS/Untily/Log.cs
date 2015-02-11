using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MTS
{
    public abstract class Log
    {
        private  static string wlog = "";//新建一个字段        

        public static string wLog//新建一个属性
        { 
            set
                {
                    wlog = value;
                    WriteLogFile(wlog);//调用方法
                } 
        }

        private static void WriteLogFile(String input)
        {
            //取当前目录
            //string fCurDic = Directory.GetCurrentDirectory(); 
            //指定存放日志文件的文件
            string fname = "c:\\logfile.txt ";
            
            //定义文件信息对象
            FileInfo finfo = new FileInfo(fname);

            //判断文件是否存在以及是否大于2K
            if (finfo.Exists && finfo.Length > 2048)
            {
                //删除该文件
                finfo.Delete();
            }
            //创建只写文件流
            using (FileStream fs = finfo.OpenWrite())
            {
                //根据上面创建的文件流创建写数据流
                StreamWriter w = new StreamWriter(fs);
                //设置写数据流的起始位置为文件流的末尾
                w.BaseStream.Seek(0, SeekOrigin.End);
                //写入“Log   Entry   :   ”
                //w.Write("Log   Entry   :   ");
                //写入当前系统时间并换行
                w.Write("{0}   {1}    ", DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
                //写入日志内容并换行
                w.Write("{0} \r\n ",input);
                //写入------------------------------------“并换行
                //w.Write("------------------------------------\n ");
                //清空缓冲区内容，并把缓冲区内容写入基础流
                w.Flush();
                //关闭写数据流
                w.Close();
            }
        }
    }
}
