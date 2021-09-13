
namespace Perdomo_Javier_Laboratoire2
{
    partial class Form1
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
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.labelUtlisateur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelProg = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(171, 12);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(307, 22);
            this.textPrenom.TabIndex = 0;
            this.textPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrenom_KeyPress);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(171, 42);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(307, 22);
            this.textNom.TabIndex = 1;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrenom.Location = new System.Drawing.Point(12, 15);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(63, 17);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(12, 45);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 17);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // textBoxUtilisateur
            // 
            this.textBoxUtilisateur.Location = new System.Drawing.Point(171, 73);
            this.textBoxUtilisateur.Name = "textBoxUtilisateur";
            this.textBoxUtilisateur.Size = new System.Drawing.Size(307, 22);
            this.textBoxUtilisateur.TabIndex = 4;
            // 
            // labelUtlisateur
            // 
            this.labelUtlisateur.AutoSize = true;
            this.labelUtlisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtlisateur.Location = new System.Drawing.Point(12, 73);
            this.labelUtlisateur.Name = "labelUtlisateur";
            this.labelUtlisateur.Size = new System.Drawing.Size(130, 17);
            this.labelUtlisateur.TabIndex = 5;
            this.labelUtlisateur.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date de naissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // labelProg
            // 
            this.labelProg.AutoSize = true;
            this.labelProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProg.Location = new System.Drawing.Point(12, 147);
            this.labelProg.Name = "labelProg";
            this.labelProg.Size = new System.Drawing.Size(98, 17);
            this.labelProg.TabIndex = 8;
            this.labelProg.Text = "Programmes";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 177);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(728, 89);
            this.checkedListBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 292);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(314, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Afficher les informations de l\'utilisateur";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 319);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 88);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelProg);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUtlisateur);
            this.Controls.Add(this.textBoxUtilisateur);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPrenom);
            this.Name = "Form1";
            this.Text = "Laboratoire 2 - Javier Perdomo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxUtilisateur;
        private System.Windows.Forms.Label labelUtlisateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelProg;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

