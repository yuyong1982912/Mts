using System;
namespace MTS
{
	/// <summary>
	/// Mbzbomz:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mbzbomz
	{
		public Mbzbomz()
		{}
		#region Model
        private int _id;
        private string _bomid;
        private int _sx;
        private int _bzxm;
		private string _bzsn;
        private string _name;
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
        public string BOMid
        {
            set { _bomid = value; }
            get { return _bomid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sx
        {
            set { _sx = value; }
            get { return _sx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int bzxm
        {
            set { _bzxm = value; }
            get { return _bzxm; }
        }

        /// <summary>
        /// 数据库中无此数据
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
		/// 
		/// </summary>
		public string bzsn
		{
			set{ _bzsn=value;}
			get{return _bzsn;}
		}

        
		#endregion Model

	}
}

