namespace terscapasSi.UI
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudId = new NumericUpDown();
            txtNombre = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            checkActivo = new CheckBox();
            lblId = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            btnCrear = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            SuspendLayout();
            // 
            // nudId
            // 
            nudId.Location = new Point(172, 78);
            nudId.Name = "nudId";
            nudId.Size = new Size(150, 27);
            nudId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 1;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(172, 179);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(260, 27);
            textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(172, 228);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(260, 27);
            textPassword.TabIndex = 3;
            // 
            // checkActivo
            // 
            checkActivo.AutoSize = true;
            checkActivo.Location = new Point(173, 277);
            checkActivo.Name = "checkActivo";
            checkActivo.Size = new Size(73, 24);
            checkActivo.TabIndex = 4;
            checkActivo.Text = "Activo";
            checkActivo.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(59, 85);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Numero ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 137);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(59, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(59, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(33, 340);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(134, 53);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(188, 340);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 53);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(343, 340);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 53);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(188, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 53);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 653);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(checkActivo);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(txtNombre);
            Controls.Add(nudId);
            Name = "UserForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudId;
        private TextBox txtNombre;
        private TextBox textEmail;
        private TextBox textPassword;
        private CheckBox checkActivo;
        private Label lblId;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblPassword;
        private Button btnCrear;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}