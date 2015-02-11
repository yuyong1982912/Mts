using System;
namespace MTS
{
	/// <summary>
	/// Mbzfb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mbzfb
	{
		public Mbzfb()
		{}
		#region Model
		private int _id;
		private DateTime _bzsj;
		private string _bzry;
		private string _cpsn;
		private string _glbzbom;
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
		public DateTime bzsj
		{
			set{ _bzsj=value;}
			get{return _bzsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bzry
		{
			set{ _bzry=value;}
			get{return _bzry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cpsn
		{
			set{ _cpsn=value;}
			get{return _cpsn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string glbzbom
		{
			set{ _glbzbom=value;}
			get{return _glbzbom;}
		}
		#endregion Model

	}
}

