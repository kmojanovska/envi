using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public class Monsters
    {
        private List<IMonster> monstersList { get; set; }


        public List<IMonster> GetMonstersList
        {
            get { return monstersList; }
        }

        public Monsters(int level)
        {
            Random random = new Random();
            monstersList = new List<IMonster>();
            for (int i = 0; i < random.Next(1, Form1.ActiveForm.Width/20);i++) {
                monstersList.Add(new MonsterWeek(random.Next(20, Form1.ActiveForm.Width), random.Next(10, 80)));
                
            }
            if(level == 2 || level == 3)
            {
                for(int i = 0; i < random.Next(1, Form1.ActiveForm.Width / 50); i++)
                {
                    monstersList.Add(new MonsterMedium(random.Next(20, Form1.ActiveForm.Width), random.Next(10, 30)));
                }
                if (level == 3)
                {
                    for (int i = 0; i < random.Next(0, 2); i++)
                    {
                        monstersList.Add(new MonsterStrong(random.Next(20, Form1.ActiveForm.Width - 20), random.Next(2, 30)));
                    }
                }
            }
           
            
        }

        public void AddMonster(IMonster m)
        {
            monstersList.Add(m);
        }

        public void DrawMonsters(Graphics paper)
        {
            foreach(IMonster m in monstersList)
            {
                m.DrawMonster(paper);
            }
        }

        public void KillMonster(IMonster m)
        {
            if(m is MonsterWeek)
            {
                monstersList.Remove(m);
            } 
        }
        
    }
}
