using System.Runtime.InteropServices;

namespace MacroApp
{
    internal class MouseClass
    {
        public static int _ScreenWidth { get; } = Screen.PrimaryScreen.Bounds.Width;
        public static int _ScreenHeight { get; } = Screen.PrimaryScreen.Bounds.Height;
        public static int _ScreenCenterX { get; } = _ScreenWidth / 2;
        public static int _ScreenCenterY { get; } = _ScreenHeight / 2;
        private const int MOUSE_EVENT_MOVE = 0x0001;
        private const int INPUT_MOUSE = 0;
        private const int MOUSE_EVENT_LEFT_DOWN = 0x0002;
        private const int MOUSE_EVENT_LEFT_UP = 0x0004;

        [DllImport("user32.dll")]
        private static extern void SendInput(uint nInputs, Input[] pInputs, int cbSize);
        
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [StructLayout(LayoutKind.Sequential)]
        private struct Input
        {
            public uint Type;
            public MouseInput Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseInput
        {
            public int DX;
            public int DY;
            public uint MouseData;
            public uint DWFlags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        // Valida tecla pressionada
        public static bool bGetAsyncKeyState(Keys vKey)
        {
            int x = GetAsyncKeyState(vKey);
            if ((x == 1) || (x == Int16.MinValue))
                return true;
            else
                return false;
        }

        public static void RapidFire(int vThread)
        {
            ClickMouse();
            Thread.Sleep(vThread);
            ClickMouse();

        }

        private static void ClickMouse()
        {
            Input[] inputs =
            {
            new Input
            {
                Type = INPUT_MOUSE,
                Data = new MouseInput
                {
                    DWFlags = MOUSE_EVENT_LEFT_DOWN
                }
            },
            new Input
            {
                Type = INPUT_MOUSE,
                Data = new MouseInput
                {
                    DWFlags = MOUSE_EVENT_LEFT_UP
                }
            }
        };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSE_EVENT_MOVE, xDelta, yDelta, 0, 0);
        }

    }
}

