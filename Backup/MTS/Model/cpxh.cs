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
        #endregion Model

    }
}

