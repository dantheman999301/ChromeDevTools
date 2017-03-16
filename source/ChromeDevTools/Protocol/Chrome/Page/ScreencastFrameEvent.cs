using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Compressed image data requested by the <code>startScreencast</code>.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastFrame)]
	[SupportedBy("Chrome")]
	public class ScreencastFrameEvent
	{
		/// <summary>
		/// Gets or sets Base64-encoded compressed image.
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets Screencast frame metadata.
		/// </summary>
		public ScreencastFrameMetadata Metadata { get; set; }
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? FrameNumber { get; set; }
	}
}