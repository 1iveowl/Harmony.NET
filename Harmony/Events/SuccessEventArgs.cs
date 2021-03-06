﻿using System;
using System.Collections.Generic;
using System.Text;
using Harmony.Responses;

namespace Harmony.Events {
	/// <summary>
	///		Event arguments that indicates whether a command was successful or not
	/// </summary>
	public class SuccessEventArgs {
		/// <summary>
		///		Initializes a new instance of the <see cref="SuccessEventArgs"/> class.
		/// </summary>
		/// <param name="response">The response data from the command</param>
		public SuccessEventArgs(StringResponse response) {
			// there can be 200.1,.2s sometimes
			this.Success = Math.Abs(response.Code - 200) < 1;
		}

		/// <summary>
		///		Gets a value indicating whether or not the command was successful
		/// </summary>
		public bool Success { get; }
	}
}
