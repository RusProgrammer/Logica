namespace Logica
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Parameters_Browser = new System.Windows.Forms.TreeView();
            this.Tree_Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьПараметрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСигналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tree_Context.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parameters_Browser
            // 
            this.Parameters_Browser.ContextMenuStrip = this.Tree_Context;
            this.Parameters_Browser.Location = new System.Drawing.Point(12, 12);
            this.Parameters_Browser.Name = "Parameters_Browser";
            this.Parameters_Browser.Size = new System.Drawing.Size(390, 509);
            this.Parameters_Browser.TabIndex = 0;
            this.Parameters_Browser.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Parameters_Browser_NodeMouseClick);
            // 
            // Tree_Context
            // 
            this.Tree_Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПараметрToolStripMenuItem,
            this.добавитьСигналToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.Tree_Context.Name = "Tree_Context";
            this.Tree_Context.Size = new System.Drawing.Size(183, 70);
            // 
            // добавитьПараметрToolStripMenuItem
            // 
            this.добавитьПараметрToolStripMenuItem.Name = "добавитьПараметрToolStripMenuItem";
            this.добавитьПараметрToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.добавитьПараметрToolStripMenuItem.Text = "Добавить параметр";
            this.добавитьПараметрToolStripMenuItem.Click += new System.EventHandler(this.добавитьПараметрToolStripMenuItem_Click);
            // 
            // добавитьСигналToolStripMenuItem
            // 
            this.добавитьСигналToolStripMenuItem.Name = "добавитьСигналToolStripMenuItem";
            this.добавитьСигналToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.добавитьСигналToolStripMenuItem.Text = "Добавить сигнал";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 533);
            this.Controls.Add(this.Parameters_Browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tree_Context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Parameters_Browser;
        private System.Windows.Forms.ContextMenuStrip Tree_Context;
        private System.Windows.Forms.ToolStripMenuItem добавитьПараметрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСигналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
    }
}

