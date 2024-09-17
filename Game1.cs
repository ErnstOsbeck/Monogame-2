﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_2;

namespace Monogame_2;


public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    Texture2D pixel;
    List<BaseClass> enemies = new List<BaseClass>();


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

        enemies.Add(new BlueEnemy(pixel, new Vector2(350,190)));
        enemies.Add(new RedEnemy(pixel, new Vector2(350,190)));
        enemies.Add(new GreenEnemy(pixel, new Vector2(350,190)));
        enemies.Add(new YellowEnemy(pixel, new Vector2(350,190)));
        enemies.Add(new BlackEnemy(pixel, new Vector2(350,190)));
        enemies.Add(new WhiteEnemy(pixel, new Vector2(350,190)));
        
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        foreach(BaseClass enemy in enemies){
            enemy.Update();
        }
        base.Update(gameTime);
    }
    public void RemoveEnemy(){
        MouseState ms = Mouse.GetState();
        
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.SkyBlue);

        // TODO: Add your drawing code here
            
            _spriteBatch.Begin();
            foreach(BaseClass enemy in enemies){
                enemy.Draw(_spriteBatch);
            }
            _spriteBatch.End();

        base.Draw(gameTime);
    }
}