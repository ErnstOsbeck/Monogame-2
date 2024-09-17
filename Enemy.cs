using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_2
{
    public class Enemy : BaseClass
    {

        public Enemy(Texture2D texture, Vector2 position):base(texture, position)
        {
            color = Color.Red;
        }

        

    }
}