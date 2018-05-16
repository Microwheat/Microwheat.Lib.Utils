using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Microwheat.Lib.Utils {
	/// <summary>
	/// 包含了一个实例的事件数据类。
	/// </summary>
	/// <typeparam name="T">表示数据类型。</typeparam>
	public class Arg<T> : EventArgs {
		//________________________________________________________________________________
		//								  参数  

		private T data;

		//________________________________________________________________________________
		//								构造方法

		/// <summary>
		/// 通过数据初始化 Microwheat.Lib.General.Arg&lt;T&gt; 类的新实例。
		/// </summary>
		/// <param name="data">表示数据实例。</param>
		public Arg(T data) {
			this.data = data;
		}

		//________________________________________________________________________________
		//								  属性  

		/// <summary>
		/// 获取或设置事件的数据。
		/// </summary>
		public T Data {
			get { return data; }
			set { data = value; }
		}
		
		//================================================================================
	}
}
