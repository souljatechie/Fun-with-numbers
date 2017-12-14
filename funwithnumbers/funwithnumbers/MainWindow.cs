using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnExit (object sender, EventArgs e)
	{
		Application.Quit ();
	}

	protected void OnClick (object sender, EventArgs e)
	{
		resultsBox.Buffer.Text = "";

		//resultsBox.Buffer.Text = "It worked!!!";

		for (int i = 0; i < 10000; i++) 
		{
			//b = i;
			//a = i.ToString();

			resultsBox.Buffer.Text = resultsBox.Buffer.Text + " " + i.ToString();

			
		}


		//Console.WriteLine("Hello again - cool button was pressed");

		//Application.Quit();	

	}
}
