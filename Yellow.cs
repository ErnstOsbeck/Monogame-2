using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_2
{
    public class YellowEnemy : Enemy
    {
        float direction = -1;
        public YellowEnemy(Texture2D texture, Vector2 position):base(texture, position)
        {
            color = Color.Yellow;
        }

        public override void Update()
        {
            position.Y+=direction;
            if(position.Y >= 380){
                direction *= -1;
            }
            if(position.Y <= 0){
                direction *= -1;
            }

        }
    }
}