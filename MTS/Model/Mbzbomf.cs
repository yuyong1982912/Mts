using System;
namespace MTS
{
	/// <summary>
	/// Mbzbomf:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

