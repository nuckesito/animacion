using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto_grafica;
using Proyecto_grafica.Extras;
using Proyecto1_01;
using Proyecto1_01.Extras;
using System;
using System.Drawing;

namespace Proyecto_grafica
{
    public class Game : GameWindow
    {
        Ejes t = new Ejes();
        Camara c;

        Escenario scenario = new Escenario();
        Guion G1 = new Guion();
        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            c.Update(e);
            base.OnUpdateFrame(e);

        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {

            GL.ClearColor(Color4.Yellow);
            c= new Camara(new Vector3(0, 0, 3), new Vector3(0, 0, -1), new Vector3(0, 1, 0), 0.08f);
            
            scenario = new Escenario(Utilidades.Cargar<Escenario>("EscenarioY.json"));
            //Utilidades.Guardar<Escenario>(scenario, "EscenarioY.json");
            CargarGuion.Cargar(scenario, G1);

            base.OnLoad(e);
            
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //-----------------------
            Matrix4 viewMatrix= c.GetViewMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMatrix);
            //-----------------------
            t.Dibujar();
            scenario.Dibujar();
            //scenario.Dibujar(matrix);


            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 40;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -22.5, 22.5, -d, d);//16:9
                                                //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }
        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Number1:
                    G1.Iniciar();
                    break;
                case Key.Number2:
                    G1.Pausar();
                    break;
            }
            base.OnKeyDown(e);
        }
    }
}


