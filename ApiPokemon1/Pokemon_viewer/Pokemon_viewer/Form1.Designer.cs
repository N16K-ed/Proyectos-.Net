namespace Pokemon_viewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.ListBox lstHabilidades;
        private System.Windows.Forms.ListBox lstEstadisticas;
        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label lblHabilidades;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.Label lblMovimientos;

        // Nuevo Label para mostrar "Cargando..."
        private System.Windows.Forms.Label lblCargando;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lstHabilidades = new System.Windows.Forms.ListBox();
            this.lstEstadisticas = new System.Windows.Forms.ListBox();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.picSprite = new System.Windows.Forms.PictureBox();

            this.lblTipos = new System.Windows.Forms.Label();
            this.lblHabilidades = new System.Windows.Forms.Label();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();

            this.lblCargando = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            this.SuspendLayout();

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(20, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(230, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // lblDatos
            this.lblDatos.Location = new System.Drawing.Point(20, 60);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(350, 60);

            // lblTipos
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(20, 130);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(32, 15);
            this.lblTipos.Text = "Tipos";

            // lstTipos
            this.lstTipos.Location = new System.Drawing.Point(20, 150);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(120, 80);

            // lblHabilidades
            this.lblHabilidades.AutoSize = true;
            this.lblHabilidades.Location = new System.Drawing.Point(150, 130);
            this.lblHabilidades.Name = "lblHabilidades";
            this.lblHabilidades.Size = new System.Drawing.Size(67, 15);
            this.lblHabilidades.Text = "Habilidades";

            // lstHabilidades
            this.lstHabilidades.Location = new System.Drawing.Point(150, 150);
            this.lstHabilidades.Name = "lstHabilidades";
            this.lstHabilidades.Size = new System.Drawing.Size(120, 80);

            // lblEstadisticas
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Location = new System.Drawing.Point(280, 130);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(71, 15);
            this.lblEstadisticas.Text = "Estadísticas";

            // lstEstadisticas
            this.lstEstadisticas.Location = new System.Drawing.Point(280, 150);
            this.lstEstadisticas.Name = "lstEstadisticas";
            this.lstEstadisticas.Size = new System.Drawing.Size(220, 100);

            // lblMovimientos
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Location = new System.Drawing.Point(20, 240);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(75, 15);
            this.lblMovimientos.Text = "Movimientos";

            // lstMovimientos
            this.lstMovimientos.Location = new System.Drawing.Point(20, 260);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(480, 150);

            // picSprite
            this.picSprite.Location = new System.Drawing.Point(550, 60);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(120, 120);
            this.picSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblCargando
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargando.Location = new System.Drawing.Point(300, 200);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(110, 25);
            this.lblCargando.Text = "Cargando...";
            this.lblCargando.Visible = false; // Inicialmente oculto

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.lblHabilidades);
            this.Controls.Add(this.lstHabilidades);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.lstEstadisticas);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.picSprite);
            this.Controls.Add(this.lblCargando);

            this.Name = "Form1";
            this.Text = "Pokémon Viewer";

            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
