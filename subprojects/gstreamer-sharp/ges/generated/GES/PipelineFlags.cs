// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GES.PipelineFlagsGType))]
	public enum PipelineFlags : uint {

		AudioPreview = 1,
		VideoPreview = 2,
		FullPreview = 3,
		Render = 4,
		SmartRender = 8,
	}

	internal class PipelineFlagsGType {
		[DllImport ("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (ges_pipeline_flags_get_type ());
			}
		}
	}
#endregion
}
