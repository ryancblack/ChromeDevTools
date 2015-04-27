using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetResourceContent)]
	public class GetResourceContentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resource content.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Gets or sets True, if content was served as base64.
		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}