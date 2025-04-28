
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cgi_lab2
{
     internal class View
     {
          public void setupView()
          {

               GL.ShadeModel(ShadingModel.Smooth);
               GL.MatrixMode(MatrixMode.Projection);
               GL.LoadIdentity();
               GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
               GL.Viewport(0, 0, 0, 0);
          }

          public void drawQuads()
     }
}
