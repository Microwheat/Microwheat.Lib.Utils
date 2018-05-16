using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microwheat.Lib.Utils {
	public static class ValidationUtils {
		public static void ArgumentIsNotNull(object argument, string argumentName) {
			if(argument == null) {
				throw new ArgumentNullException(argumentName);
			}
		}
	}
}
