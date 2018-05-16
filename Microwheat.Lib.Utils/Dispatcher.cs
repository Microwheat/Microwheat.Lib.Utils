using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microwheat.Lib.Utils {
	/// <summary>
	/// 一个用于派发事件的类。
	/// </summary>
	public static class Dispatcher {

		/// <summary>
		/// 派发一个 EventHandler 事件。
		/// </summary>
		/// <param name="sender">表示事件的发送实例。</param>
		/// <param name="handler">表示要派发的事件。</param>
		public static void Dispatch(object sender, EventHandler handler) {
			if (handler != null) {
				handler(sender, EventArgs.Empty);
			}
		}

		/// <summary>
		/// 派发一个 EventHandler&lt;T&gt; 事件。
		/// </summary>
		/// <typeparam name="T">表示事件数据的类型。</typeparam>
		/// <param name="sender">表示事件的发送实例。</param>
		/// <param name="handler">表示要派发的事件。</param>
		/// <param name="args">表示事件的数据。</param>
		public static void Dispatch<T>(object sender, EventHandler<T> handler, T args)
		where T : EventArgs {
			if (handler != null) {
				handler(sender, args);
			}
		}

		/// <summary>
		/// 派发一个 EventHandler&lt;T&gt; 事件。
		/// </summary>
		/// <typeparam name="T">表示事件数据的类型。</typeparam>
		/// <param name="sender">表示事件的发送实例。</param>
		/// <param name="handler">表示要派发的事件。</param>
		/// <param name="data">表示事件的数据。</param>
		public static void Dispatch<T>(object sender, EventHandler<Arg<T>> handler, T data) {
			if (handler != null) {
				handler(sender, new Arg<T>(data));
			}
		}

		public static void Dispatch(this EventHandler handler, object sender) {
			if (handler != null) {
				handler(sender, EventArgs.Empty);
			}
		}

		public static void Dispatch<T>(this EventHandler<T> handler, object sender,  T args)
		where T : EventArgs {
			if (handler != null) {
				handler(sender, args);
			}
		}

		public static void Dispatch<T>(this EventHandler<Arg<T>> handler, object sender,  T data) {
			if (handler != null) {
				handler(sender, new Arg<T>(data));
			}
		}

		//================================================================================
	}
}
