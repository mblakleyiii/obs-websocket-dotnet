﻿/*
    TestClient for obs-websocket-dotnet
    Copyright (C) 2021	Stéphane Lepin, BarRaider

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program. If not, see <https://www.gnu.org/licenses/>
*/

namespace TestClient
{
    partial class MainWindow
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.tvScenes = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentScene = new System.Windows.Forms.Button();
            this.btnGetCurrentScene = new System.Windows.Forms.Button();
            this.btnListScenes = new System.Windows.Forms.Button();
            this.tbCurrentScene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSetTransitionDuration = new System.Windows.Forms.Button();
            this.btnGetTransitionDuration = new System.Windows.Forms.Button();
            this.tbTransitionDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentTransition = new System.Windows.Forms.Button();
            this.btnGetCurrentTransition = new System.Windows.Forms.Button();
            this.tbTransition = new System.Windows.Forms.TextBox();
            this.btnListTransitions = new System.Windows.Forms.Button();
            this.tvTransitions = new System.Windows.Forms.TreeView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalFrames = new System.Windows.Forms.Label();
            this.txtDroppedFrames = new System.Windows.Forms.Label();
            this.txtStrain = new System.Windows.Forms.Label();
            this.txtFramerate = new System.Windows.Forms.Label();
            this.txtBytesSec = new System.Windows.Forms.Label();
            this.txtKbitsSec = new System.Windows.Forms.Label();
            this.txtStreamTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnToggleRecording = new System.Windows.Forms.Button();
            this.btnToggleStreaming = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentProfile = new System.Windows.Forms.Button();
            this.btnGetCurrentProfile = new System.Windows.Forms.Button();
            this.tbProfile = new System.Windows.Forms.TextBox();
            this.btnListProfiles = new System.Windows.Forms.Button();
            this.tvProfiles = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentSceneCol = new System.Windows.Forms.Button();
            this.btnGetCurrentSceneCol = new System.Windows.Forms.Button();
            this.tbSceneCol = new System.Windows.Forms.TextBox();
            this.btnListSceneCol = new System.Windows.Forms.Button();
            this.tvSceneCols = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbOBSVersion = new System.Windows.Forms.Label();
            this.tbPluginVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnVirtualCamStop = new System.Windows.Forms.Button();
            this.btnVirtualCamStart = new System.Windows.Forms.Button();
            this.btnVirtualCamToggle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVirtualCamStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransitionDuration)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(596, 6);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIP.Location = new System.Drawing.Point(237, 8);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(132, 23);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.Text = "ws://127.0.0.1:4444";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerPassword.Location = new System.Drawing.Point(456, 8);
            this.txtServerPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(132, 23);
            this.txtServerPassword.TabIndex = 3;
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // tvScenes
            // 
            this.tvScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvScenes.Location = new System.Drawing.Point(7, 57);
            this.tvScenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvScenes.Name = "tvScenes";
            this.tvScenes.Size = new System.Drawing.Size(160, 136);
            this.tvScenes.TabIndex = 4;
            this.tvScenes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvScenes_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetCurrentScene);
            this.groupBox1.Controls.Add(this.btnGetCurrentScene);
            this.groupBox1.Controls.Add(this.btnListScenes);
            this.groupBox1.Controls.Add(this.tvScenes);
            this.groupBox1.Controls.Add(this.tbCurrentScene);
            this.groupBox1.Location = new System.Drawing.Point(7, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(175, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scene List with Items";
            // 
            // btnSetCurrentScene
            // 
            this.btnSetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentScene.Location = new System.Drawing.Point(91, 230);
            this.btnSetCurrentScene.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetCurrentScene.Name = "btnSetCurrentScene";
            this.btnSetCurrentScene.Size = new System.Drawing.Size(77, 44);
            this.btnSetCurrentScene.TabIndex = 1;
            this.btnSetCurrentScene.Text = "Set\r\nCurScene";
            this.btnSetCurrentScene.UseVisualStyleBackColor = true;
            this.btnSetCurrentScene.Click += new System.EventHandler(this.btnSetCurrentScene_Click);
            // 
            // btnGetCurrentScene
            // 
            this.btnGetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentScene.Location = new System.Drawing.Point(7, 230);
            this.btnGetCurrentScene.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrentScene.Name = "btnGetCurrentScene";
            this.btnGetCurrentScene.Size = new System.Drawing.Size(72, 44);
            this.btnGetCurrentScene.TabIndex = 2;
            this.btnGetCurrentScene.Text = "Get\r\nCurScene";
            this.btnGetCurrentScene.UseVisualStyleBackColor = true;
            this.btnGetCurrentScene.Click += new System.EventHandler(this.btnGetCurrentScene_Click);
            // 
            // btnListScenes
            // 
            this.btnListScenes.Location = new System.Drawing.Point(8, 23);
            this.btnListScenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListScenes.Name = "btnListScenes";
            this.btnListScenes.Size = new System.Drawing.Size(88, 27);
            this.btnListScenes.TabIndex = 5;
            this.btnListScenes.Text = "ListScenes";
            this.btnListScenes.UseVisualStyleBackColor = true;
            this.btnListScenes.Click += new System.EventHandler(this.btnListScenes_Click);
            // 
            // tbCurrentScene
            // 
            this.tbCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentScene.Location = new System.Drawing.Point(7, 200);
            this.tbCurrentScene.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCurrentScene.Name = "tbCurrentScene";
            this.tbCurrentScene.Size = new System.Drawing.Size(160, 23);
            this.tbCurrentScene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:PORT :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.groupBox9);
            this.gbControls.Controls.Add(this.groupBox8);
            this.gbControls.Controls.Add(this.btnAdvanced);
            this.gbControls.Controls.Add(this.groupBox7);
            this.gbControls.Controls.Add(this.groupBox6);
            this.gbControls.Controls.Add(this.gbStatus);
            this.gbControls.Controls.Add(this.groupBox5);
            this.gbControls.Controls.Add(this.groupBox4);
            this.gbControls.Controls.Add(this.groupBox2);
            this.gbControls.Controls.Add(this.groupBox3);
            this.gbControls.Controls.Add(this.groupBox1);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(13, 39);
            this.gbControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbControls.Size = new System.Drawing.Size(670, 642);
            this.gbControls.TabIndex = 9;
            this.gbControls.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnBrowse);
            this.groupBox8.Controls.Add(this.tbFolderPath);
            this.groupBox8.Controls.Add(this.btnSetPath);
            this.groupBox8.Location = new System.Drawing.Point(7, 582);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(422, 51);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Recordings Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(242, 22);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.Location = new System.Drawing.Point(8, 22);
            this.tbFolderPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(232, 23);
            this.tbFolderPath.TabIndex = 15;
            // 
            // btnSetPath
            // 
            this.btnSetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPath.Location = new System.Drawing.Point(319, 21);
            this.btnSetPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(94, 23);
            this.btnSetPath.TabIndex = 16;
            this.btnSetPath.Text = "Set Path";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(575, 599);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(88, 27);
            this.btnAdvanced.TabIndex = 13;
            this.btnAdvanced.Text = "Advanced >>";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSetTransitionDuration);
            this.groupBox7.Controls.Add(this.btnGetTransitionDuration);
            this.groupBox7.Controls.Add(this.tbTransitionDuration);
            this.groupBox7.Location = new System.Drawing.Point(493, 501);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(170, 61);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Transition Duration";
            // 
            // btnSetTransitionDuration
            // 
            this.btnSetTransitionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetTransitionDuration.Location = new System.Drawing.Point(113, 25);
            this.btnSetTransitionDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetTransitionDuration.Name = "btnSetTransitionDuration";
            this.btnSetTransitionDuration.Size = new System.Drawing.Size(47, 27);
            this.btnSetTransitionDuration.TabIndex = 2;
            this.btnSetTransitionDuration.Text = "Set";
            this.btnSetTransitionDuration.UseVisualStyleBackColor = true;
            this.btnSetTransitionDuration.Click += new System.EventHandler(this.btnSetTransitionDuration_Click);
            // 
            // btnGetTransitionDuration
            // 
            this.btnGetTransitionDuration.Location = new System.Drawing.Point(8, 25);
            this.btnGetTransitionDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetTransitionDuration.Name = "btnGetTransitionDuration";
            this.btnGetTransitionDuration.Size = new System.Drawing.Size(48, 27);
            this.btnGetTransitionDuration.TabIndex = 1;
            this.btnGetTransitionDuration.Text = "Get";
            this.btnGetTransitionDuration.UseVisualStyleBackColor = true;
            this.btnGetTransitionDuration.Click += new System.EventHandler(this.btnGetTransitionDuration_Click);
            // 
            // tbTransitionDuration
            // 
            this.tbTransitionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransitionDuration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbTransitionDuration.Location = new System.Drawing.Point(59, 27);
            this.tbTransitionDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTransitionDuration.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.tbTransitionDuration.Name = "tbTransitionDuration";
            this.tbTransitionDuration.Size = new System.Drawing.Size(46, 23);
            this.tbTransitionDuration.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetCurrentTransition);
            this.groupBox6.Controls.Add(this.btnGetCurrentTransition);
            this.groupBox6.Controls.Add(this.tbTransition);
            this.groupBox6.Controls.Add(this.btnListTransitions);
            this.groupBox6.Controls.Add(this.tvTransitions);
            this.groupBox6.Location = new System.Drawing.Point(205, 301);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(224, 280);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transitions";
            // 
            // btnSetCurrentTransition
            // 
            this.btnSetCurrentTransition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentTransition.Location = new System.Drawing.Point(121, 230);
            this.btnSetCurrentTransition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetCurrentTransition.Name = "btnSetCurrentTransition";
            this.btnSetCurrentTransition.Size = new System.Drawing.Size(94, 44);
            this.btnSetCurrentTransition.TabIndex = 5;
            this.btnSetCurrentTransition.Text = "Set\r\nCurTransition";
            this.btnSetCurrentTransition.UseVisualStyleBackColor = true;
            this.btnSetCurrentTransition.Click += new System.EventHandler(this.btnSetCurrentTransition_Click);
            // 
            // btnGetCurrentTransition
            // 
            this.btnGetCurrentTransition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentTransition.Location = new System.Drawing.Point(7, 230);
            this.btnGetCurrentTransition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrentTransition.Name = "btnGetCurrentTransition";
            this.btnGetCurrentTransition.Size = new System.Drawing.Size(100, 44);
            this.btnGetCurrentTransition.TabIndex = 4;
            this.btnGetCurrentTransition.Text = "Get\r\nCurTransition";
            this.btnGetCurrentTransition.UseVisualStyleBackColor = true;
            this.btnGetCurrentTransition.Click += new System.EventHandler(this.btnGetCurrentTransition_Click);
            // 
            // tbTransition
            // 
            this.tbTransition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransition.Location = new System.Drawing.Point(7, 200);
            this.tbTransition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTransition.Name = "tbTransition";
            this.tbTransition.Size = new System.Drawing.Size(208, 23);
            this.tbTransition.TabIndex = 3;
            // 
            // btnListTransitions
            // 
            this.btnListTransitions.Location = new System.Drawing.Point(7, 22);
            this.btnListTransitions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListTransitions.Name = "btnListTransitions";
            this.btnListTransitions.Size = new System.Drawing.Size(100, 27);
            this.btnListTransitions.TabIndex = 2;
            this.btnListTransitions.Text = "ListTransitions";
            this.btnListTransitions.UseVisualStyleBackColor = true;
            this.btnListTransitions.Click += new System.EventHandler(this.btnListTransitions_Click);
            // 
            // tvTransitions
            // 
            this.tvTransitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTransitions.Location = new System.Drawing.Point(7, 57);
            this.tvTransitions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvTransitions.Name = "tvTransitions";
            this.tvTransitions.Size = new System.Drawing.Size(209, 136);
            this.tvTransitions.TabIndex = 1;
            this.tvTransitions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTransitions_NodeMouseClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatus.Controls.Add(this.tableLayoutPanel2);
            this.gbStatus.Enabled = false;
            this.gbStatus.Location = new System.Drawing.Point(396, 14);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Size = new System.Drawing.Size(267, 202);
            this.gbStatus.TabIndex = 11;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Stream Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtTotalFrames, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtDroppedFrames, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtStrain, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtFramerate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBytesSec, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtKbitsSec, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStreamTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 172);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtTotalFrames
            // 
            this.txtTotalFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFrames.AutoSize = true;
            this.txtTotalFrames.Location = new System.Drawing.Point(121, 142);
            this.txtTotalFrames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalFrames.Name = "txtTotalFrames";
            this.txtTotalFrames.Size = new System.Drawing.Size(123, 15);
            this.txtTotalFrames.TabIndex = 14;
            this.txtTotalFrames.Text = "0";
            this.txtTotalFrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDroppedFrames
            // 
            this.txtDroppedFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDroppedFrames.AutoSize = true;
            this.txtDroppedFrames.Location = new System.Drawing.Point(121, 119);
            this.txtDroppedFrames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDroppedFrames.Name = "txtDroppedFrames";
            this.txtDroppedFrames.Size = new System.Drawing.Size(123, 15);
            this.txtDroppedFrames.TabIndex = 13;
            this.txtDroppedFrames.Text = "0";
            this.txtDroppedFrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStrain
            // 
            this.txtStrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStrain.AutoSize = true;
            this.txtStrain.Location = new System.Drawing.Point(121, 96);
            this.txtStrain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStrain.Name = "txtStrain";
            this.txtStrain.Size = new System.Drawing.Size(123, 15);
            this.txtStrain.TabIndex = 12;
            this.txtStrain.Text = "0 %";
            this.txtStrain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFramerate
            // 
            this.txtFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFramerate.AutoSize = true;
            this.txtFramerate.Location = new System.Drawing.Point(121, 73);
            this.txtFramerate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFramerate.Name = "txtFramerate";
            this.txtFramerate.Size = new System.Drawing.Size(123, 15);
            this.txtFramerate.TabIndex = 11;
            this.txtFramerate.Text = "0 fps";
            this.txtFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBytesSec
            // 
            this.txtBytesSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBytesSec.AutoSize = true;
            this.txtBytesSec.Location = new System.Drawing.Point(121, 50);
            this.txtBytesSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBytesSec.Name = "txtBytesSec";
            this.txtBytesSec.Size = new System.Drawing.Size(123, 15);
            this.txtBytesSec.TabIndex = 10;
            this.txtBytesSec.Text = "0 bytes/s";
            this.txtBytesSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKbitsSec
            // 
            this.txtKbitsSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKbitsSec.AutoSize = true;
            this.txtKbitsSec.Location = new System.Drawing.Point(121, 27);
            this.txtKbitsSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKbitsSec.Name = "txtKbitsSec";
            this.txtKbitsSec.Size = new System.Drawing.Size(123, 15);
            this.txtKbitsSec.TabIndex = 9;
            this.txtKbitsSec.Text = "0 kbits/s";
            this.txtKbitsSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStreamTime
            // 
            this.txtStreamTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreamTime.AutoSize = true;
            this.txtStreamTime.Location = new System.Drawing.Point(121, 4);
            this.txtStreamTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStreamTime.Name = "txtStreamTime";
            this.txtStreamTime.Size = new System.Drawing.Size(123, 15);
            this.txtStreamTime.TabIndex = 8;
            this.txtStreamTime.Text = "0 sec";
            this.txtStreamTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total stream time :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kbits/sec :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bytes/sec :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Framerate :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Strain :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dropped frames :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total frames :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnToggleRecording);
            this.groupBox5.Controls.Add(this.btnToggleStreaming);
            this.groupBox5.Location = new System.Drawing.Point(493, 331);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(169, 91);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Streaming / Recording";
            // 
            // btnToggleRecording
            // 
            this.btnToggleRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleRecording.Location = new System.Drawing.Point(8, 58);
            this.btnToggleRecording.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToggleRecording.Name = "btnToggleRecording";
            this.btnToggleRecording.Size = new System.Drawing.Size(154, 27);
            this.btnToggleRecording.TabIndex = 1;
            this.btnToggleRecording.Text = "State unknown";
            this.btnToggleRecording.UseVisualStyleBackColor = true;
            this.btnToggleRecording.Click += new System.EventHandler(this.btnToggleRecording_Click);
            // 
            // btnToggleStreaming
            // 
            this.btnToggleStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStreaming.Location = new System.Drawing.Point(8, 23);
            this.btnToggleStreaming.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToggleStreaming.Name = "btnToggleStreaming";
            this.btnToggleStreaming.Size = new System.Drawing.Size(154, 27);
            this.btnToggleStreaming.TabIndex = 0;
            this.btnToggleStreaming.Text = "State unknown";
            this.btnToggleStreaming.UseVisualStyleBackColor = true;
            this.btnToggleStreaming.Click += new System.EventHandler(this.btnToggleStreaming_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetCurrentProfile);
            this.groupBox4.Controls.Add(this.btnGetCurrentProfile);
            this.groupBox4.Controls.Add(this.tbProfile);
            this.groupBox4.Controls.Add(this.btnListProfiles);
            this.groupBox4.Controls.Add(this.tvProfiles);
            this.groupBox4.Location = new System.Drawing.Point(7, 301);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(191, 280);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profiles";
            // 
            // btnSetCurrentProfile
            // 
            this.btnSetCurrentProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentProfile.Location = new System.Drawing.Point(103, 230);
            this.btnSetCurrentProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetCurrentProfile.Name = "btnSetCurrentProfile";
            this.btnSetCurrentProfile.Size = new System.Drawing.Size(80, 44);
            this.btnSetCurrentProfile.TabIndex = 5;
            this.btnSetCurrentProfile.Text = "Set\r\nCurProfile";
            this.btnSetCurrentProfile.UseVisualStyleBackColor = true;
            this.btnSetCurrentProfile.Click += new System.EventHandler(this.btnSetCurrentProfile_Click);
            // 
            // btnGetCurrentProfile
            // 
            this.btnGetCurrentProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentProfile.Location = new System.Drawing.Point(7, 230);
            this.btnGetCurrentProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrentProfile.Name = "btnGetCurrentProfile";
            this.btnGetCurrentProfile.Size = new System.Drawing.Size(80, 44);
            this.btnGetCurrentProfile.TabIndex = 4;
            this.btnGetCurrentProfile.Text = "Get\r\nCurProfile";
            this.btnGetCurrentProfile.UseVisualStyleBackColor = true;
            this.btnGetCurrentProfile.Click += new System.EventHandler(this.btnGetCurrentProfile_Click);
            // 
            // tbProfile
            // 
            this.tbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfile.Location = new System.Drawing.Point(7, 200);
            this.tbProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(176, 23);
            this.tbProfile.TabIndex = 3;
            // 
            // btnListProfiles
            // 
            this.btnListProfiles.Location = new System.Drawing.Point(7, 22);
            this.btnListProfiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListProfiles.Name = "btnListProfiles";
            this.btnListProfiles.Size = new System.Drawing.Size(93, 27);
            this.btnListProfiles.TabIndex = 2;
            this.btnListProfiles.Text = "ListProfiles";
            this.btnListProfiles.UseVisualStyleBackColor = true;
            this.btnListProfiles.Click += new System.EventHandler(this.btnListProfiles_Click);
            // 
            // tvProfiles
            // 
            this.tvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvProfiles.Location = new System.Drawing.Point(7, 57);
            this.tvProfiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvProfiles.Name = "tvProfiles";
            this.tvProfiles.Size = new System.Drawing.Size(177, 136);
            this.tvProfiles.TabIndex = 1;
            this.tvProfiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProfiles_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetCurrentSceneCol);
            this.groupBox2.Controls.Add(this.btnGetCurrentSceneCol);
            this.groupBox2.Controls.Add(this.tbSceneCol);
            this.groupBox2.Controls.Add(this.btnListSceneCol);
            this.groupBox2.Controls.Add(this.tvSceneCols);
            this.groupBox2.Location = new System.Drawing.Point(189, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(186, 280);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scene Collections";
            // 
            // btnSetCurrentSceneCol
            // 
            this.btnSetCurrentSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentSceneCol.Location = new System.Drawing.Point(97, 230);
            this.btnSetCurrentSceneCol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetCurrentSceneCol.Name = "btnSetCurrentSceneCol";
            this.btnSetCurrentSceneCol.Size = new System.Drawing.Size(80, 44);
            this.btnSetCurrentSceneCol.TabIndex = 5;
            this.btnSetCurrentSceneCol.Text = "Set\r\nCurSC";
            this.btnSetCurrentSceneCol.UseVisualStyleBackColor = true;
            this.btnSetCurrentSceneCol.Click += new System.EventHandler(this.btnSetCurrentSceneCol_Click);
            // 
            // btnGetCurrentSceneCol
            // 
            this.btnGetCurrentSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentSceneCol.Location = new System.Drawing.Point(7, 230);
            this.btnGetCurrentSceneCol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrentSceneCol.Name = "btnGetCurrentSceneCol";
            this.btnGetCurrentSceneCol.Size = new System.Drawing.Size(80, 44);
            this.btnGetCurrentSceneCol.TabIndex = 4;
            this.btnGetCurrentSceneCol.Text = "Get\r\nCurSC";
            this.btnGetCurrentSceneCol.UseVisualStyleBackColor = true;
            this.btnGetCurrentSceneCol.Click += new System.EventHandler(this.btnGetCurrentSceneCol_Click);
            // 
            // tbSceneCol
            // 
            this.tbSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSceneCol.Location = new System.Drawing.Point(7, 200);
            this.tbSceneCol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSceneCol.Name = "tbSceneCol";
            this.tbSceneCol.Size = new System.Drawing.Size(170, 23);
            this.tbSceneCol.TabIndex = 3;
            // 
            // btnListSceneCol
            // 
            this.btnListSceneCol.Location = new System.Drawing.Point(7, 22);
            this.btnListSceneCol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListSceneCol.Name = "btnListSceneCol";
            this.btnListSceneCol.Size = new System.Drawing.Size(146, 27);
            this.btnListSceneCol.TabIndex = 2;
            this.btnListSceneCol.Text = "ListSceneCollections";
            this.btnListSceneCol.UseVisualStyleBackColor = true;
            this.btnListSceneCol.Click += new System.EventHandler(this.btnListSceneCol_Click);
            // 
            // tvSceneCols
            // 
            this.tvSceneCols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvSceneCols.Location = new System.Drawing.Point(7, 57);
            this.tvSceneCols.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvSceneCols.Name = "tvSceneCols";
            this.tvSceneCols.Size = new System.Drawing.Size(171, 136);
            this.tvSceneCols.TabIndex = 1;
            this.tvSceneCols.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSceneCols_NodeMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(469, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(194, 102);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Version Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbOBSVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPluginVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 73);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbOBSVersion
            // 
            this.tbOBSVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOBSVersion.AutoSize = true;
            this.tbOBSVersion.Location = new System.Drawing.Point(108, 27);
            this.tbOBSVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbOBSVersion.Name = "tbOBSVersion";
            this.tbOBSVersion.Size = new System.Drawing.Size(66, 15);
            this.tbOBSVersion.TabIndex = 5;
            this.tbOBSVersion.Text = "???";
            this.tbOBSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPluginVersion
            // 
            this.tbPluginVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPluginVersion.AutoSize = true;
            this.tbPluginVersion.Location = new System.Drawing.Point(108, 4);
            this.tbPluginVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbPluginVersion.Name = "tbPluginVersion";
            this.tbPluginVersion.Size = new System.Drawing.Size(66, 15);
            this.tbPluginVersion.TabIndex = 3;
            this.tbPluginVersion.Text = "???";
            this.tbPluginVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plugin Version :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "OBS Version :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(299, 326);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Set Path";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblVirtualCamStatus);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.btnVirtualCamToggle);
            this.groupBox9.Controls.Add(this.btnVirtualCamStop);
            this.groupBox9.Controls.Add(this.btnVirtualCamStart);
            this.groupBox9.Location = new System.Drawing.Point(492, 428);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox9.Size = new System.Drawing.Size(170, 67);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Virtual Cam";
            // 
            // btnVirtualCamStop
            // 
            this.btnVirtualCamStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVirtualCamStop.Location = new System.Drawing.Point(59, 33);
            this.btnVirtualCamStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVirtualCamStop.Name = "btnVirtualCamStop";
            this.btnVirtualCamStop.Size = new System.Drawing.Size(47, 27);
            this.btnVirtualCamStop.TabIndex = 2;
            this.btnVirtualCamStop.Text = "Stop";
            this.btnVirtualCamStop.UseVisualStyleBackColor = true;
            this.btnVirtualCamStop.Click += new System.EventHandler(this.btnVirtualCamStop_Click);
            // 
            // btnVirtualCamStart
            // 
            this.btnVirtualCamStart.Location = new System.Drawing.Point(6, 33);
            this.btnVirtualCamStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVirtualCamStart.Name = "btnVirtualCamStart";
            this.btnVirtualCamStart.Size = new System.Drawing.Size(48, 27);
            this.btnVirtualCamStart.TabIndex = 1;
            this.btnVirtualCamStart.Text = "Start";
            this.btnVirtualCamStart.UseVisualStyleBackColor = true;
            this.btnVirtualCamStart.Click += new System.EventHandler(this.btnVirtualCamStart_Click);
            // 
            // btnVirtualCamToggle
            // 
            this.btnVirtualCamToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVirtualCamToggle.Location = new System.Drawing.Point(109, 33);
            this.btnVirtualCamToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVirtualCamToggle.Name = "btnVirtualCamToggle";
            this.btnVirtualCamToggle.Size = new System.Drawing.Size(56, 27);
            this.btnVirtualCamToggle.TabIndex = 3;
            this.btnVirtualCamToggle.Text = "Toggle";
            this.btnVirtualCamToggle.UseVisualStyleBackColor = true;
            this.btnVirtualCamToggle.Click += new System.EventHandler(this.btnVirtualCamToggle_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVirtualCamStatus
            // 
            this.lblVirtualCamStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVirtualCamStatus.Location = new System.Drawing.Point(57, 17);
            this.lblVirtualCamStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVirtualCamStatus.Name = "lblVirtualCamStatus";
            this.lblVirtualCamStatus.Size = new System.Drawing.Size(107, 15);
            this.lblVirtualCamStatus.TabIndex = 8;
            this.lblVirtualCamStatus.Text = "Unknown";
            this.lblVirtualCamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 693);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "obs-websocket client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTransitionDuration)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TreeView tvScenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListScenes;
        private System.Windows.Forms.Button btnGetCurrentScene;
        private System.Windows.Forms.Button btnSetCurrentScene;
        private System.Windows.Forms.TextBox tbCurrentScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tbOBSVersion;
        private System.Windows.Forms.Label tbPluginVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetCurrentProfile;
        private System.Windows.Forms.Button btnGetCurrentProfile;
        private System.Windows.Forms.TextBox tbProfile;
        private System.Windows.Forms.Button btnListProfiles;
        private System.Windows.Forms.TreeView tvProfiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetCurrentSceneCol;
        private System.Windows.Forms.Button btnGetCurrentSceneCol;
        private System.Windows.Forms.TextBox tbSceneCol;
        private System.Windows.Forms.Button btnListSceneCol;
        private System.Windows.Forms.TreeView tvSceneCols;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnToggleRecording;
        private System.Windows.Forms.Button btnToggleStreaming;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTotalFrames;
        private System.Windows.Forms.Label txtDroppedFrames;
        private System.Windows.Forms.Label txtStrain;
        private System.Windows.Forms.Label txtFramerate;
        private System.Windows.Forms.Label txtBytesSec;
        private System.Windows.Forms.Label txtKbitsSec;
        private System.Windows.Forms.Label txtStreamTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetCurrentTransition;
        private System.Windows.Forms.Button btnGetCurrentTransition;
        private System.Windows.Forms.TextBox tbTransition;
        private System.Windows.Forms.Button btnListTransitions;
        private System.Windows.Forms.TreeView tvTransitions;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSetTransitionDuration;
        private System.Windows.Forms.Button btnGetTransitionDuration;
        private System.Windows.Forms.NumericUpDown tbTransitionDuration;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblVirtualCamStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVirtualCamToggle;
        private System.Windows.Forms.Button btnVirtualCamStop;
        private System.Windows.Forms.Button btnVirtualCamStart;
    }
}

