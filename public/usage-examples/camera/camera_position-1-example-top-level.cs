using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Camera Position Example", 400, 300);

double cameraX = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    // Move the camera position each frame
    SetCameraPosition(PointAt(cameraX, 0));
    cameraX += 1;

    // Read back and display the current camera position
    WriteLine("Camera position: " + PointToString(CameraPosition()));

    // A stationary object in the world - it does not move itself
    FillRectangle(Color.Red, 200, 100, 50, 50);

    RefreshScreen(60);
}

CloseAllWindows();