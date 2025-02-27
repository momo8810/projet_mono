﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BasicMonoGame;

public class MyGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Sprite _ship; // instance de Sprite

    public MyGame()
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
        Texture2D shipTexture = Content.Load<Texture2D>("ship2");
        _ship = new Sprite(shipTexture, new Vector2(150, 150),20);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.
                Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        _ship.Update(gameTime);
        base.Update(gameTime);

        // TODO: Add your update logic here
        
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        _ship.Draw(_spriteBatch);
        _spriteBatch.End();
        base.Draw(gameTime);

        // TODO: Add your drawing code here
        
    }
}