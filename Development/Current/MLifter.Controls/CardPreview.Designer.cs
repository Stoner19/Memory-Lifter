/***************************************************************************************************************************************
 * Copyright (C) 2001-2012 LearnLift USA																	*
 * Contact: Learnlift USA, 12 Greenway Plaza, Suite 1510, Houston, Texas 77046, support@memorylifter.com					*
 *																								*
 * This library is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License	*
 * as published by the Free Software Foundation; either version 2.1 of the License, or (at your option) any later version.			*
 *																								*
 * This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty	*
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.	*
 *																								*
 * You should have received a copy of the GNU Lesser General Public License along with this library; if not,					*
 * write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA					*
 ***************************************************************************************************************************************/
namespace MLifter.Controls
{
    partial class CardPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPreview));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowserQuestion = new MLifter.Components.MLifterWebBrowser();
            this.webBrowserAnswer = new MLifter.Components.MLifterWebBrowser();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.webBrowserQuestion, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.webBrowserAnswer, 1, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // webBrowserQuestion
            // 
            this.webBrowserQuestion.AllowWebBrowserDrop = false;
            resources.ApplyResources(this.webBrowserQuestion, "webBrowserQuestion");
            this.webBrowserQuestion.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserQuestion.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserQuestion.Name = "webBrowserQuestion";
            this.webBrowserQuestion.ScriptErrorsSuppressed = true;
            this.webBrowserQuestion.WebBrowserShortcutsEnabled = false;
            // 
            // webBrowserAnswer
            // 
            this.webBrowserAnswer.AllowWebBrowserDrop = false;
            resources.ApplyResources(this.webBrowserAnswer, "webBrowserAnswer");
            this.webBrowserAnswer.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserAnswer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAnswer.Name = "webBrowserAnswer";
            this.webBrowserAnswer.ScriptErrorsSuppressed = true;
            this.webBrowserAnswer.WebBrowserShortcutsEnabled = false;
            // 
            // CardPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.CardPreview_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardPreview_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MLifter.Components.MLifterWebBrowser webBrowserQuestion;
        private MLifter.Components.MLifterWebBrowser webBrowserAnswer;
    }
}
