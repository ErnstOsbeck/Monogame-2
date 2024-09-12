using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_2
{
    public class BlueEnemy : Enemy
    {
        float direction = 1;
        public BlueEnemy(Texture2D texture, Vector2 position):base(texture, position)
        {
            color = Color.Blue;
        }

        public override void Update()
        {
            position.X+=direction;
            if(position.X +100 >= 800){
                direction *= -1;
            }
            if(position.X <= 0){
                direction *= -1;
            }

        }
    }
}