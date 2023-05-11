using System.Runtime.InteropServices;

namespace ProtoKeyboardInput;

class VirtualKeyListener
{
        static int VK_DELETE = 0x2E;
        static int VK_ESC = 0x1B;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Int32 vKey);


        static void Main(string[] args)
        {
                short keyStatus;
                short escStatus;

                // https://stackoverflow.com/a/62629269/3875151
                // Get KeyState forever, does not get keystate in terminal
                // List of Virtual Keys (VK) https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
                do
                {

                        keyStatus = GetAsyncKeyState(VK_DELETE);
                        escStatus = GetAsyncKeyState(VK_ESC);

                        if ((keyStatus & 1) == 1)
                        {
                                Console.WriteLine("DELETE!");
                        }

                } while ((escStatus & 1) != 1);
        }
}