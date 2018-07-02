using System;
using OpenTK;

namespace Graphics
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using(Viewer viewer = new Viewer())
            {

                for (int x = 0; x < 16; x++)
                {
                    for (int y = 0; y < 16; y++)
                    {
                        
                        var obj = new WorldObject("Bob");
                        
                        obj.Animate("Looking");
                        obj.Position = new Vector3(x, 0, y) * 32;
                        viewer.Objects.Add(obj);
                        viewer.FocusObject = obj;
                    }
                }
                
                

                viewer.Run(60.0);
            }
        }
    }
}