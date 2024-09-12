using System;
using StereoKit;
using StereoKit.Framework;

namespace avrcado;

class Program
{
	static void Main(string[] args)
	{
		// Initialize StereoKit
		SKSettings settings = new SKSettings
		{
			appName = "avrcado",
			assetsFolder = "Assets",
		};
		if (!SK.Initialize(settings))
			return;
















var sky = Tex.FromCubemapEquirectangular("snowy_forest_4k.hdr");
Renderer.SkyTex = sky;
Renderer.SkyLight = sky.CubemapLighting;

Vec3  pointA   = new Vec3(10,15,10);
Vec3  pointB   = new Vec3(0,3,-1);

Sound backsound = Sound.FromFile("4K HDR Bluebell Woods - English Forest - Birds Singing - No Loop - Relaxing Nature Video & Sounds.mp3");

backsound.Play(pointB);

Model clipboard = Model.FromFile("Avocado.gltf");
Pose   clipboardPose = new Pose(0.2f, 0, -0.6f, Quat.LookDir(0,0,1));

	bool   clipToggle;
	float  clipSlider;
	int    clipOption = 1;

	int    clipOption2 = 1;


		// Create assets used by the app
		Pose  cubePose = new Pose(0, 0, -0.5f);
		Model cube     = Model.FromMesh(
			Mesh.GenerateRoundedCube(Vec3.One*0.1f, 0.02f),
			Material.UI);

		Matrix   floorTransform = Matrix.TS(0, -1.5f, 0, new Vec3(30, 0.1f, 30));
		Material floorMaterial  = new Material("floor.hlsl");
		floorMaterial.Transparency = Transparency.Blend;


		// Core application loop
		SK.Run(() => {
			if (Device.DisplayBlend == DisplayBlend.Opaque)
				Mesh.Cube.Draw(floorMaterial, floorTransform);

			UI.Handle("Cube", ref cubePose, cube.Bounds);
			cube.Draw(cubePose.ToMatrix());

    UI.HandleBegin("Clip", ref clipboardPose, clipboard.Bounds);
    clipboard.Draw(Matrix.Identity);

UI.LayoutArea(new Vec3(13, 15, 0) * U.cm, new Vec2(26, 30) * U.cm);
		///
		/// Then after that? We can just add UI elements like normal!
		/// 
		//UI.Image(logoSprite, new Vec2(22,0) * U.cm);

		//UI.Toggle("Toggle", ref clipToggle);
		//UI.HSlider("Slide", ref clipSlider, 0, 1, 0);
		///
		/// And while we're at it, here's a quick example of doing a radio
		/// button group! Not much 'radio' actually happening, but it's still
		/// pretty simple. Pair it with an enum, or an integer, and have fun!
		///
		if (UI.Radio("Opt1", clipOption == 1)) clipOption = 1;
		UI.SameLine();
		if (UI.Radio("Opt2", clipOption == 2)) clipOption = 2;
		UI.SameLine();
		if (UI.Radio("Opt3", clipOption == 3)) clipOption = 3;

        if (UI.Radio("1", clipOption2 == 1)) clipOption2 = 1;
		UI.SameLine();
		if (UI.Radio("2", clipOption2 == 2)) clipOption2 = 2;
		UI.SameLine();
		if (UI.Radio("3", clipOption2 == 3)) clipOption2 = 3;




    UI.HandleEnd();


		});
	}
}