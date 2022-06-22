﻿using AgeOfEmpires;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;
using MonoGame.Extended.ViewportAdapters;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using System;
using System.Diagnostics;
using AgeOfEmpires.States;


using MonoGame.Extended.Content;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.Serialization;
using AgeOfEmpires.Systems;
using MonoGame.Extended.Entities.Systems;
using AgeOfEmpires.Components;

namespace AgeOfEmpires.IngameUI_s
{
    public class NoClickState : Component
    {
        private GraphicsDevice graphicsDevice;
        private Texture2D _buttonContainer;
       

        private MouseState _previousMouse;

        private MouseState _currentMouse;

        private bool _isHovering;

        public event EventHandler Click;

        

        

        public NoClickState(GraphicsDevice graphicsDevice, Texture2D buttonConatiner)
        {
            this._buttonContainer = buttonConatiner;
           
            this.graphicsDevice = graphicsDevice;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var buttonColour = Color.White;
            if (_isHovering)
            {
                buttonColour = Color.Gray;
            }
           
            spriteBatch.Draw(_buttonContainer, new Rectangle(0, graphicsDevice.Adapter.CurrentDisplayMode.Height - _buttonContainer.Height, _buttonContainer.Width, _buttonContainer.Height), Color.White);
           
            
        }

        public override void Update(GameTime gameTime)
        {
           
        }
    }
}
