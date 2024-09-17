using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_2
{
    public class GreenEnemy : Enemy
    {
        float direction = 1;
        public GreenEnemy(Texture2D texture, Vector2 position):base(texture, position)
        {
            color = Color.Lime;
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