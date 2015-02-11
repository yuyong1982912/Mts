using System;
namespace MTS{
    /// <summary>
    /// cpxh:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mcpxh
    {
        public Mcpxh()
        { }
        #region Model
        private int _id;
        private string _cpsnd;
        private string _cpxh;
        private string _cptype;
        private string _filePath;
        private string _imagePath;
        private string _Var3;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cpsnd
        {
            set { _cpsnd = value; }
            get { return _cpsnd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cpxh
        {
            set { _cpxh = value; }
            get { return _cpxh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cptype
        {
            set { _cptype = value; }
            get { return _cptype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string filePath
        {
            set { _filePath = value; }
            get { return _filePath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string imagePath
        {
            set { _imagePath = value; }
            get { return _imagePath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Var3
        {
            set { _Var3 = value; }
            get { return _Var3; }
        }
        #endregion Model

    }
}

