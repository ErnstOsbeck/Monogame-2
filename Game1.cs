﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_2;

namespace Monogame_2;


public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    BlueEnemy blue;
    RedEnemy red;
    GreenEnemy green;
    YellowEnemy yellow;
    Texture2D pixel;


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        pixel = new Texture2D(GraphicsDevice,1,1);
        pixel.SetData(new Color[]{Color.White});

        blue = new BlueEnemy(pixel, new Vector2(350,190));
        red = new RedEnemy(pixel, new Vector2(350,190));
        green = new GreenEnemy(pixel, new Vector2(350,190));
        yellow = new YellowEnemy(pixel, new Vector2(350,190));

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        blue.Update();
        red.Update();
        green.Update();
        yellow.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Navy);

        // TODO: Add your drawing code here
            
            _spriteBatch.Begin();
            blue.Draw(_spriteBatch);
            red.Draw(_spriteBatch);
            green.Draw(_spriteBatch);
            yellow.Draw(_spriteBatch);
            _spriteBatch.End();

        base.Draw(gameTime);
    }
}