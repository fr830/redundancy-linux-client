
// This file has been generated by the GUI designer. Do not modify.

public partial class Settings
{
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget Settings
		this.Name = "Settings";
		this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 285;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}