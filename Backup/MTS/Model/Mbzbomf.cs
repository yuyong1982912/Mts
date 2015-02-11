using System;
namespace MTS
{
	/// <summary>
	/// Mbzbomf:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mbzbomf
	{
		public Mbzbomf()
		{}
		#region Model
		private string _bomid;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public string bomid
		{
			set{ _bomid=value;}
			get{return _bomid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

