using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall : Obj {
        Random random = new Random();   //乱数インスタンス

        public static int Count { get; set; }

        public SoccerBall(double xp, double yp)
            : base(xp, yp, @"Picture\soccer_ball.png") {

            MoveX = random.Next(-25, 25); //移動量設定
            MoveY = random.Next(-25, 25);

            Count++;
        }

        public override int Move (PictureBox pbBar, PictureBox pbBall) {
            int ret = 0;

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                                    pbBar.Width, pbBar.Height);

        Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                               pbBall.Width, pbBall.Height);


            if (PosX > 750 || PosX< 0) {
                //移動量の符号を反転
                MoveX = -MoveX;
            }

            if (PosY > 500 || PosY< 0 || rBar.IntersectsWith(rBall)) {
                //移動量の符号を反転
                MoveY = -MoveY;
                ret = 2;
            }

PosX += MoveX;
PosY += MoveY;

if (PosY > 500)
    ret = 1;
if (rBar.IntersectsWith(rBall))
    return 2;

return 0;
        }

        public override int Move(Keys direction) {
    return true;
}
    }
}
