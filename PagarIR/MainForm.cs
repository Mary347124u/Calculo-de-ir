/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 28/02/2021
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PagarIR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	     float salario=float.Parse(textBox1.Text);
	     float ir=0;
	                     if (salario <= 2500)
                {
                    textBox2.Text = "isento";
                } else if (salario <= 5000)
                {
                    ir = salario * 0.10F;
                    textBox2.Text = ir.ToString();
                } 
	            else if (salario < 10000 )
                {
                    ir = salario * 0.15F;
                    textBox2.Text = ir.ToString();
                }else
                {
                    ir = salario * 0.25F;
                    textBox2.Text = ir.ToString();
                }

		}
	}
}
