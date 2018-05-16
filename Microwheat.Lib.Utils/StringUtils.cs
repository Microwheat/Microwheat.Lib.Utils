using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microwheat.Lib.Utils {
	public static class StringUtils {
		public static string FormatWith(this string format, params object[] args) {
			return string.Format(format, args);
		}
	}
}
