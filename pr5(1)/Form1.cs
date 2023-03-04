using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace pr5(1)
{
public partial class pr5(1) : Form
{
public pr5(1)
{
    InitializeComponent();
}

private void txtX1_TextChanged(object sender, EventArgs e)
{

}

private void pr5(1)_Load(object sender, EventArgs e)
{

}

private void txtX1_Click(object sender, EventArgs e)
{

}

private void btnCalc_Click(object sender, EventArgs e)
{
    // çäåñü âàø êîä:
    int fromX = int.Parse(txtX1.Text);
    int toX = int.Parse(txtX2.Text);
    int fromY = int.Parse(txtY1.Text);
    int toY = int.Parse(txtY2.Text);
    //...
    if (fromX > toX)
    {
        MessageBox.Show("èíòåðâàë äîëæåí áûòü îò ìåíüøåãî ê áîëüøåìó");
        txtX1.Text = "";
        txtX2.Text = "";
    }
    if (fromY > toY)
    {
        MessageBox.Show("èíòåðâàë äîëæåí áûòü îò ìåíüøåãî ê áîëüøåìó");
        txtY1.Text = "";
        txtY2.Text = "";
    }

    for (int x = fromX; x <= toX; x++)
    {
        for (int y = fromY; y <= toY; y++)
        {
            // ...
        }
        for (int y = fromY; y <= toY; y++)
        {
            // çäåñü âàø êîä:
            lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
            // êîíåö âàøåãî êîäà
        }
    }

}

private void lstResult_Click(object sender, EventArgs e)
{

}

private void label1_Click(object sender, EventArgs e)
{

}
}
}}
