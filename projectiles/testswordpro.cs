using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hyperionandmaybeotherstuff.projectiles
{
    public class testswordpro : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Sword Projectile");
        }

        public override void SetDefaults()
        {
            Projectile.width = 30;
            Projectile.height = 30;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.timeLeft = 600;
            Projectile.penetrate = 900;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
        }
        /*public override void AI()
        {
            if (Projectile.ai[0] == 0f) // If AI flag is 0, set initial position and velocity
            {
                Projectile.position.Y = Main.screenPosition.Y - Projectile.height; // Spawn projectile at top of screen
                Projectile.position.X = Main.MouseWorld.X; // Set X position to player's cursor position
                Vector2 direction = Main.MouseWorld - Projectile.Center; // Calculate direction towards player's cursor
                direction.Normalize();
                Projectile.velocity = direction * 50f; // Set initial velocity towards player's cursor
                Projectile.ai[0] = 1f; // Set AI flag to 1 to prevent this code from running again
            }

            // Rotate projectile based on its velocity
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

            // Spawn dust effect
            int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 16, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].velocity = Projectile.velocity * 0.1f;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Create explosion effect on hit
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
            for (int i = 0; i < 30; i++)
              {
                Dust dust2 = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, 16, 0f, 0f, 0, default(Color), 1.5f);
                dust2.velocity *= 1.4f;
               }
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                if (Main.npc[i].active && !Main.npc[i].friendly && Vector2.Distance(Main.npc[i].Center, Projectile.Center) < 100f)
                {
                    Main.npc[i].HitEffect(0, 10.0);
                    int dmg = Projectile.damage;
                    int kb = 10;
                    Main.npc[i].StrikeNPC(dmg, kb, Projectile.direction, false, false, false);
                }
            }
            Projectile.Kill();
        }
       /* public override void AI()
        {
            if (Projectile.ai[0] == 0) // Spawn projectile at the top of the screen when it is first created
            {
                Projectile.position.X = Main.MouseWorld.X - Projectile.width / 2;
                Projectile.position.Y = Main.screenPosition.Y - Projectile.height / 2;
                Projectile.ai[0] = 1;
            }
            else
            {
                // Increase projectile velocity over time to simulate falling from the sky
                Projectile.velocity.Y += 0.2f;
                Projectile.velocity.X *= 0.99f;

                // Rotate projectile based on its velocity
                Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

                // Spawn dust effect to simulate falling from the sky
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 16, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust].velocity = Projectile.velocity * 0.1f;

                // If projectile collides with the ground, create an explosion effect
                if (Projectile.velocity.Y > 0 && Projectile.Hitbox.Intersects(new Rectangle((int)Projectile.position.X, (int)Projectile.position.Y + Projectile.height, Projectile.width, 1)))
                {

                    for (int i = 0; i < Main.maxNPCs; i++)
                    {
                        if (Main.npc[i].active && !Main.npc[i].friendly && Vector2.Distance(Main.npc[i].Center, Projectile.Center) < 100f)
                        {
                            Main.npc[i].HitEffect(0, 10.0);
                            int damage = Projectile.damage;
                            int knockback = 10;
                            Main.npc[i].StrikeNPC(damage, knockback, Projectile.direction, false, false, false);
                        }
                    }
                    Projectile.Kill();
                }
            }
        }*/

        
    }
}
