using System;
namespace MTS
{
	/// <summary>
	/// cpybzbomgl:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
        /// ���ݿ��в����ڴ��ֶ�
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
		#endregion Model

	}
}

