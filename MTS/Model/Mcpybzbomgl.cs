using System;
namespace MTS
{
	/// <summary>
	/// cpybzbomgl:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mcpybzbomgl
	{
		public Mcpybzbomgl()
		{}
		#region Model
		private int _id;
		private string _cpbh;
		private string _bomid;
        private string _name;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cpbh
		{
			set{ _cpbh=value;}
			get{return _cpbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BOMid
		{
			set{ _bomid=value;}
			get{return _bomid;}
		}
        /// <summary>
        /// 数据库中不存在此字段
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
		#endregion Model

	}
}

