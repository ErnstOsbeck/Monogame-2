using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_2
{
    public class BlackEnemy : Enemy
    {
        float direction = 1;
        public BlackEnemy(Texture2D texture, Vector2 position):base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            position.Y+=direction;
            position.X+=direction;
            if(position.Y >= 380){
                direction *= -1;
            }
            if(position.Y <= 0){
                direction *= -1;
            }

        }
    }
}