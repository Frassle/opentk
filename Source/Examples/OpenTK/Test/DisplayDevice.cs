// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

#pragma warning disable 612,618 // disable obsolete warnings - we need to access these functions

namespace Examples.Tests
{
	[Example("Display Devices", ExampleCategory.OpenTK, "GameWindow")]
	public class DisplayDevices : GameWindow
	{
		static readonly Font TextFont = new Font(FontFamily.GenericSansSerif, 11);
		Bitmap TextBitmap = new Bitmap(1024, 1024);
		int texture;

		public DisplayDevices()
			: base(800, 600, GraphicsMode.Default)
		{
		}

		#region Private Members

		static float DrawString(Graphics gfx, string str, int line)
		{
			return DrawString(gfx, str, line, 0);
		}

		static float DrawString(Graphics gfx, string str, int line, float offset)
		{
			gfx.DrawString(str, TextFont, Brushes.White, new PointF(offset, line * TextFont.Height));
			return offset + gfx.MeasureString(str, TextFont).Width;
		}

		#endregion

		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			using (Graphics gfx = Graphics.FromImage(TextBitmap))
			{
				int line = 0;

				gfx.Clear(Color.Black);
				gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

				// OpenGL information
				DrawString(gfx, GL.GetString(StringName.Renderer), line++);
				DrawString(gfx, GL.GetString(StringName.Version), line++);
				DrawString(gfx, Context.GraphicsMode.ToString(), line++);

				// GameWindow information
				line++;
				DrawString(gfx, "GameWindow:", line++);
				DrawString(gfx, String.Format("[1 - 4]:[5 - 7]: WindowState.{0}:WindowBorder.{1}",
					this.WindowState, this.WindowBorder), line++);
				DrawString(gfx, String.Format("[V]: VSync.{0}.", VSync), line++);
				DrawString(gfx, String.Format("Bounds: {0}", Bounds), line++);
				DrawString(gfx, String.Format("ClientRectangle: {0}", ClientRectangle), line++);

				for (DisplayIndex index = DisplayIndex.First; index < DisplayIndex.Sixth; ++index)
				{
					DisplayDevice device = DisplayDevice.GetDisplay (index);

					if (device == null)
					{
						break;
					}

					line++;
					DrawString(gfx, String.Format("DisplayIndex.{0} {1}", index, device.IsPrimary ? "is primary" : ""), line++);
					DrawString(gfx, String.Format("Bounds: {0}", device.Bounds), line++);
				}
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.MidnightBlue);

			GL.Enable(EnableCap.Texture2D);
			GL.Enable(EnableCap.Blend);
			GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcColor);

			texture = GL.GenTexture();
			GL.BindTexture(TextureTarget.Texture2D, texture);
			GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, TextBitmap.Width, TextBitmap.Height,
				0, PixelFormat.Bgra, PixelType.UnsignedByte, IntPtr.Zero);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Nearest);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Nearest);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			GL.Viewport(0, 0, Width, Height);
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);

			DrawText();

			SwapBuffers();
		}

		// Uploads our text Bitmap to an OpenGL texture
		// and displays is to screen.
		private void DrawText()
		{
			System.Drawing.Imaging.BitmapData data = TextBitmap.LockBits(
				new System.Drawing.Rectangle(0, 0, TextBitmap.Width, TextBitmap.Height),
				System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			GL.TexSubImage2D(TextureTarget.Texture2D, 0, 0, 0, TextBitmap.Width, TextBitmap.Height, PixelFormat.Bgra,
				PixelType.UnsignedByte, data.Scan0);
			TextBitmap.UnlockBits(data);

			Matrix4 text_projection = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, -1, 1);
			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadMatrix(ref text_projection);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();

			GL.Color4(Color4.White);
			GL.Enable(EnableCap.Texture2D);
			GL.Begin(PrimitiveType.Quads);
			GL.TexCoord2(0, 0); GL.Vertex2(0, 0);
			GL.TexCoord2(1, 0); GL.Vertex2(TextBitmap.Width, 0);
			GL.TexCoord2(1, 1); GL.Vertex2(TextBitmap.Width, TextBitmap.Height);
			GL.TexCoord2(0, 1); GL.Vertex2(0, TextBitmap.Height);
			GL.End();
			GL.Disable(EnableCap.Texture2D);
		}

		public static void Main()
		{
			using (DisplayDevices ex = new DisplayDevices())
			{
				Utilities.SetWindowTitle(ex);
				ex.Run(30.0);
			}
		}
	}
}
