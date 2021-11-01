namespace Dope
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewsList = new System.Windows.Forms.Panel();
            this.side1 = new Dope.Theme.Side();
            this.SuspendLayout();
            // 
            // ViewsList
            // 
            this.ViewsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ViewsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsList.Location = new System.Drawing.Point(200, 0);
            this.ViewsList.Name = "ViewsList";
            this.ViewsList.Size = new System.Drawing.Size(464, 411);
            this.ViewsList.TabIndex = 7;
            // 
            // side1
            // 
            this.side1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.side1.Dock = System.Windows.Forms.DockStyle.Left;
            this.side1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1.ForeColor = System.Drawing.Color.Gainsboro;
            this.side1.Index = 0;
            this.side1.Location = new System.Drawing.Point(0, 0);
            this.side1.MaxCol = 200;
            this.side1.MinCol = 60;
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(200, 411);
            this.side1.TabIndex = 6;
            this.side1.IndexChange += new System.EventHandler(this.side1_IndexChange);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.ViewsList);
            this.Controls.Add(this.side1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 450);
            this.MinimumSize = new System.Drawing.Size(680, 450);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private Theme.Side side1;
        private System.Windows.Forms.Panel ViewsList;
    }
}

