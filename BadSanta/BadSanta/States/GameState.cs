using System.Linq;
using BadSanta.Characters;
using BadSanta.Characters.PlayerControlled;
using BadSanta.Core;
using BadSanta.Core.Events;
using BadSanta.Entities.Factories;
using BadSanta.Managers;
using BadSanta.Objects.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class GameState : State
    {
        private Santa player;
        private readonly LevelManager levelManager;
        private SpriteFont font;

        private Texture2D SideMenu;

        private Viewport MapViewport;
        private Viewport MenuViewport;
        private Viewport InventoryViewport;

        private GiftFactory giftFactory;
        private EnemyFactory enemyFactory;

        public GameState(ContentManager content, GraphicsDeviceManager graphics)
        {
            base.Content = content;
            this.levelManager = new LevelManager();
            this.Graphics = graphics;
            Initialize();
        }

        private void Initialize()
        {
            this.player = new Santa(100, 100, "Pesho");
            
            this.giftFactory = new GiftFactory();
            this.enemyFactory = new EnemyFactory();

            this.enemyFactory.Produce(this.levelManager.CurrentLevel.Tiles);
            foreach (var generatedeEnemy in this.enemyFactory.GeneratedeEnemies)
            {
                generatedeEnemy.Killed += EnemyKilled;
            }

            this.player.Position = new Vector2(36, 36);

            this.font = this.Content.Load<SpriteFont>("Fonts/mainMenu");
            this.SideMenu = this.Content.Load<Texture2D>("Images/Backgrounds/SideMenu");

            this.MapViewport = new Viewport
            {
                X = 420,
                Y = 0,
                Width = this.Graphics.PreferredBackBufferHeight,
                Height = this.Graphics.PreferredBackBufferHeight,
                MinDepth = 0,
                MaxDepth = 1
            };

            this.MenuViewport = new Viewport
            {
                X = this.Graphics.PreferredBackBufferHeight + 420,
                Y = 0,
                Width = this.Graphics.PreferredBackBufferWidth - this.Graphics.PreferredBackBufferHeight,
                Height = this.Graphics.PreferredBackBufferHeight,
                MinDepth = 0,
                MaxDepth = 1
            };

            this.InventoryViewport = new Viewport
            {
                X = 0,
                Y = 0,
                Width = 420,
                Height = this.Graphics.PreferredBackBufferHeight,
                MinDepth = 0,
                MaxDepth = 1
            };
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
            this.giftFactory.Produce(this.levelManager.CurrentLevel.Tiles);

            inputHandler.PlayerMovement(this.player);
            this.player.Update(gameTime);
            this.player.Collect(this.giftFactory.GeneratedGifts);

            foreach (var tile in this.levelManager.CurrentLevel.Tiles.Where(tile => tile is CollisionTile))
            {
                this.player.Collision(tile.Rectangle);
            }

            for (int i = 0; i < this.enemyFactory.GeneratedeEnemies.Count(); i++)
            {
                this.enemyFactory.GeneratedeEnemies[i].Collision(this.player.CollisionBox);
                this.enemyFactory.GeneratedeEnemies[i].Update(gameTime);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Viewport original = this.Graphics.GraphicsDevice.Viewport;

            this.Graphics.GraphicsDevice.Viewport = this.InventoryViewport;

            spriteBatch.Begin();

            spriteBatch.Draw(this.SideMenu, new Vector2(0, 0), Color.White);
            spriteBatch.DrawString(this.font, $"Health: {this.player.Health}", new Vector2(150, 150) - this.font.MeasureString($"Health: {this.player.Health}") / 2, Color.Black);
            spriteBatch.DrawString(this.font, $"Damage: {this.player.Damage}", new Vector2(150, 200) - this.font.MeasureString($"Damage: {this.player.Damage}") / 2, Color.Black);
            spriteBatch.DrawString(this.font, $"Score: {this.player.Score}", new Vector2(150, 250) - this.font.MeasureString($"Score: {this.player.Score}") / 2, Color.Black);
            spriteBatch.DrawString(this.font, $"Money: {this.player.Money}", new Vector2(150, 300) - this.font.MeasureString($"Money: {this.player.Money}") / 2, Color.Black);

            spriteBatch.End();

            this.Graphics.GraphicsDevice.Viewport = this.MapViewport;

            spriteBatch.Begin();

            this.levelManager.CurrentLevel.Draw(spriteBatch);
            this.player.Draw(spriteBatch);//spriteBatch.Draw(this.player.Image, this.player.Position, Color.White);

            foreach (var enemy in this.enemyFactory.GeneratedeEnemies)
            {
                spriteBatch.Draw(enemy.Image, enemy.Position, Color.White);
            }

            foreach (var generatedGift in this.giftFactory.GeneratedGifts)
            {
                spriteBatch.Draw(generatedGift.Icon, generatedGift.Position, Color.White);
            }

            spriteBatch.End();

            this.Graphics.GraphicsDevice.Viewport = this.MenuViewport;

            spriteBatch.Begin();

            spriteBatch.Draw(this.SideMenu, new Vector2(0, 0), Color.White);
            spriteBatch.End();

            this.Graphics.GraphicsDevice.Viewport = original;
        }

        private void EnemyKilled(object sender, OnKilledEventArgs e)
        {
            this.player.Money += e.MoneyAward;
            this.player.Score += e.ScoreAward;
            this.enemyFactory.GeneratedeEnemies.Remove(sender as Enemy);
        }
    }
}
