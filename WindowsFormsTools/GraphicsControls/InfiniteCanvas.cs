using System.Numerics;

namespace WindowsFormsTools.GraphicsControls
{
    /// <summary>
    /// Infinite zoomable and scrollable drawing area
    /// </summary>
    public partial class InfiniteCanvas : UserControl
    {
        public event PaintEventHandler? WorldSpacePaint;
        
        public float Zoom
        {
            get => zoom;
            set => setZoom(value, true);
        }

        public float ZoomBase { get; set; } = 2;
        public float ZoomPowStep { get; set; } = 0.1f;
        
        protected PointF ScreenMouseDownPosition;

        protected Vector2 Offset;

        protected Vector2 CanvasHalfSize { get; private set; }

        private Vector2 prevOffset;
        private bool isMousePressing;
        private float zoom = 1;
        private float zoomPow;

        public InfiniteCanvas()
        {
            InitializeComponent();

            MouseWheel += InfiniteCanvas_MouseWheel;
        }

        #region Event handlers

        private void InfiniteCanvas_Load(object sender, EventArgs e)
        {
            zoomPow = (float)Math.Log(Zoom, ZoomBase);
            CanvasHalfSize = new Vector2(0.5f * Width, 0.5f * Height);
            Offset = CanvasHalfSize;
        }

        private void InfiniteCanvas_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                zoomPow += ZoomPowStep * Math.Sign(e.Delta);
                float newZoom = (float)Math.Pow(ZoomBase, zoomPow);
                setZoom(newZoom, false);
            }
        }

        private void InfiniteCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressing = true;
            prevOffset = Offset;
            ScreenMouseDownPosition = e.Location;
            Invalidate();
        }

        private void InfiniteCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressing = false;
        }

        private void InfiniteCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePressing && e.Button == MouseButtons.Right)
            {
                Offset.X = (e.Location.X - ScreenMouseDownPosition.X) / Zoom + prevOffset.X;
                Offset.Y = (e.Location.Y - ScreenMouseDownPosition.Y) / Zoom + prevOffset.Y;
                
                Invalidate();
            }
        }

        private void InfiniteCanvas_Resize(object sender, EventArgs e)
        {
            CanvasHalfSize = new Vector2(0.5f * Width, 0.5f * Height);
            Invalidate();
        }

        private void InfiniteCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            e.Graphics.TranslateTransform(CanvasHalfSize.X, CanvasHalfSize.Y);
            e.Graphics.ScaleTransform(Zoom, Zoom);
            e.Graphics.TranslateTransform(Offset.X - CanvasHalfSize.X, Offset.Y - CanvasHalfSize.Y);

            WorldSpacePaint?.Invoke(sender, e);
        }

        #endregion

        #region Private methods
        
        private void setZoom(float newZoom, bool calcZoomPow)
        {
            zoom = newZoom;

            if(calcZoomPow)
                zoomPow = (float)Math.Log(zoom, ZoomBase);

            Invalidate();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Transforms the point coordinate from screen view to world view
        /// </summary>
        public (float, float) TransformToWorld(float screenX, float screenY)
        {
            float worldX = (screenX - CanvasHalfSize.X) / Zoom - Offset.X + CanvasHalfSize.X;
            float worldY = (screenY - CanvasHalfSize.Y) / Zoom - Offset.Y + CanvasHalfSize.Y;
            return (worldX, -worldY);
        }
        
        /// <summary>
        /// Transforms the point coordinate from screen view to world view
        /// </summary>
        public PointF TransformToWorld(PointF screenPoint)
        {
            var (x, y) = TransformToWorld(screenPoint.X, screenPoint.Y);
            return new PointF(x, y);
        }

        /// <summary>
        /// Transforms the point coordinate from screen view to world view
        /// </summary>
        public Vector2 TransformToWorld(Vector2 screenPoint)
        {
            var (x, y) = TransformToWorld(screenPoint.X, screenPoint.Y);
            return new Vector2(x, y);
        }

        #endregion
    }
}
