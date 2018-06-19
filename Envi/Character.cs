using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public class Character
    {
        public Boolean flag = false;
        private int x { get; set; }
        private int y { get; set; }
        private int width, height;
        public Image characterImage;
        private Rectangle characterRectangle;

        public Rectangle CharacterRec
        {
            get { return characterRectangle; }
        }

        public Character()
        {
            //300 y-
            x = 50;
            y = Form1.ActiveForm.Height-120;
            width = 50;
            height = 69;

            characterImage = Envi.Properties.Resources.thor;
            characterRectangle = new Rectangle(x, y, width, height);
        }

        public void drawCharacter(Graphics paper)
        {
            paper.DrawImage(characterImage, characterRectangle);
        }

        public void moveCharacter(int mouseX)
        {
            characterRectangle.X = mouseX -(characterRectangle.Width /2);
        }

        public Boolean characterKilledMethod(Rectangle monsterRectangle)
        {
            if (monsterRectangle.IntersectsWith(characterRectangle))
            {
                characterRectangle.Width = 0;
                flag = true;
                return true;
            }
            return false;
        }


        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetX
        {
            get { return x; }
        }

        public int GetY
        {
            get { return y; }
        }

    }
}
