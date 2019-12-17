using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MoveButton
{
    class Таблица : DataGridView

    {

        Point DownPoint;
        bool IsDragMode;

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            DownPoint = mevent.Location;
            IsDragMode = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            IsDragMode = false;
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (IsDragMode)
            {
                Point p = mevent.Location;
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(mevent);
        }
    }
}
