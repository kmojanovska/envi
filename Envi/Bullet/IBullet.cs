using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public interface IBullet
    {
        void MoveBullet(int charY, int charX);
        void DrawBullet(Graphics paper);
    }
}
