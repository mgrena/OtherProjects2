namespace Vetoquinol.Sales.Importer
{
    partial class AppForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            cFluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            cAccordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            cFluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            bsiVersionText = new DevExpress.XtraBars.BarStaticItem();
            bsiVersion = new DevExpress.XtraBars.BarStaticItem();
            bsiUserText = new DevExpress.XtraBars.BarStaticItem();
            bsiUser = new DevExpress.XtraBars.BarStaticItem();
            beiImage = new DevExpress.XtraBars.BarEditItem();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            cFluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            cStatusBar = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)cAccordionControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cFluentDesignFormControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cFluentFormDefaultManager).BeginInit();
            SuspendLayout();
            // 
            // cFluentDesignFormContainer
            // 
            cFluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            cFluentDesignFormContainer.Location = new System.Drawing.Point(260, 31);
            cFluentDesignFormContainer.Name = "cFluentDesignFormContainer";
            cFluentDesignFormContainer.Size = new System.Drawing.Size(471, 470);
            cFluentDesignFormContainer.TabIndex = 0;
            // 
            // cAccordionControl
            // 
            cAccordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            cAccordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            cAccordionControl.Location = new System.Drawing.Point(0, 31);
            cAccordionControl.Name = "cAccordionControl";
            cAccordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            cAccordionControl.Size = new System.Drawing.Size(260, 470);
            cAccordionControl.TabIndex = 1;
            cAccordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Element1";
            // 
            // cFluentDesignFormControl
            // 
            cFluentDesignFormControl.FluentDesignForm = this;
            cFluentDesignFormControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bsiVersionText, bsiVersion, bsiUserText, bsiUser, beiImage });
            cFluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            cFluentDesignFormControl.Manager = cFluentFormDefaultManager;
            cFluentDesignFormControl.Name = "cFluentDesignFormControl";
            cFluentDesignFormControl.Size = new System.Drawing.Size(731, 31);
            cFluentDesignFormControl.TabIndex = 2;
            cFluentDesignFormControl.TabStop = false;
            // 
            // bsiVersionText
            // 
            bsiVersionText.Caption = "Version";
            bsiVersionText.Id = 0;
            bsiVersionText.Name = "bsiVersionText";
            // 
            // bsiVersion
            // 
            bsiVersion.Caption = "1.x.x";
            bsiVersion.Id = 1;
            bsiVersion.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.HotTrack;
            bsiVersion.ItemAppearance.Normal.Options.UseForeColor = true;
            bsiVersion.Name = "bsiVersion";
            // 
            // bsiUserText
            // 
            bsiUserText.Caption = "User";
            bsiUserText.Id = 2;
            bsiUserText.Name = "bsiUserText";
            // 
            // bsiUser
            // 
            bsiUser.Caption = "user";
            bsiUser.Id = 3;
            bsiUser.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.HotTrack;
            bsiUser.ItemAppearance.Normal.Options.UseForeColor = true;
            bsiUser.Name = "bsiUser";
            // 
            // beiImage
            // 
            beiImage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            beiImage.Caption = "Background operation ...";
            beiImage.Edit = repositoryItemPictureEdit1;
            beiImage.Id = 6;
            beiImage.Name = "beiImage";
            beiImage.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // cFluentFormDefaultManager
            // 
            cFluentFormDefaultManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { cStatusBar });
            cFluentFormDefaultManager.DockControls.Add(barDockControlTop);
            cFluentFormDefaultManager.DockControls.Add(barDockControlBottom);
            cFluentFormDefaultManager.DockControls.Add(barDockControlLeft);
            cFluentFormDefaultManager.DockControls.Add(barDockControlRight);
            cFluentFormDefaultManager.DockingEnabled = true;
            cFluentFormDefaultManager.Form = this;
            cFluentFormDefaultManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bsiVersionText, bsiVersion, bsiUserText, bsiUser, beiImage });
            cFluentFormDefaultManager.MaxItemId = 7;
            cFluentFormDefaultManager.StatusBar = cStatusBar;
            // 
            // cStatusBar
            // 
            cStatusBar.BarItemHorzIndent = 10;
            cStatusBar.BarName = "Staus Bar";
            cStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            cStatusBar.DockCol = 0;
            cStatusBar.DockRow = 0;
            cStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            cStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bsiVersionText), new DevExpress.XtraBars.LinkPersistInfo(bsiVersion), new DevExpress.XtraBars.LinkPersistInfo(bsiUserText), new DevExpress.XtraBars.LinkPersistInfo(bsiUser), new DevExpress.XtraBars.LinkPersistInfo(beiImage) });
            cStatusBar.OptionsBar.AllowQuickCustomization = false;
            cStatusBar.OptionsBar.DrawDragBorder = false;
            cStatusBar.OptionsBar.UseWholeRow = true;
            cStatusBar.Text = "Status Bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 31);
            barDockControlTop.Manager = cFluentFormDefaultManager;
            barDockControlTop.Size = new System.Drawing.Size(731, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            barDockControlBottom.Manager = cFluentFormDefaultManager;
            barDockControlBottom.Size = new System.Drawing.Size(731, 24);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            barDockControlLeft.Manager = cFluentFormDefaultManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 470);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(731, 31);
            barDockControlRight.Manager = cFluentFormDefaultManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 470);
            // 
            // AppForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(731, 525);
            ControlContainer = cFluentDesignFormContainer;
            Controls.Add(cFluentDesignFormContainer);
            Controls.Add(cAccordionControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(cFluentDesignFormControl);
            FluentDesignFormControl = cFluentDesignFormControl;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("AppForm.IconOptions.SvgImage");
            Name = "AppForm";
            NavigationControl = cAccordionControl;
            Text = "Vetoquinol Sales Importer";
            Load += AppForm_Load;
            ((System.ComponentModel.ISupportInitialize)cAccordionControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)cFluentDesignFormControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cFluentFormDefaultManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer cFluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl cAccordionControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl cFluentDesignFormControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager cFluentFormDefaultManager;
        private DevExpress.XtraBars.Bar cStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiVersionText;
        private DevExpress.XtraBars.BarStaticItem bsiVersion;
        private DevExpress.XtraBars.BarStaticItem bsiUserText;
        private DevExpress.XtraBars.BarStaticItem bsiUser;
        private DevExpress.XtraBars.BarEditItem beiImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}

