using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    class Bullets
    {
        private List<IBullet> bulletsList { get; set; }
        public List<IBullet> GetBulletsList
        {
            get { return bulletsList; }
        }

        public Bullets()
        {
            bulletsList = new List<IBullet>();
        }

        public void AddBullet(IBullet b)
        {
            bulletsList.Add(b);
        }

        public void DrawBullets(Graphics paper)
        {
            foreach (IBullet b in bulletsList)
            {
                b.DrawBullet(paper);
            }
        }

        public void KillBullet(IBullet b)
        {
            bulletsList.Remove(b);
        }


    }
}
