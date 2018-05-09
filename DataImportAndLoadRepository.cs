﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DataImportAndLoad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DataImportAndLoadRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("f1452eba-c83e-42c8-9d6c-0e9801d48e51")]
    public partial class DataImportAndLoadRepository : RepoGenBaseFolder
    {
        static DataImportAndLoadRepository instance = new DataImportAndLoadRepository();
        DataImportAndLoadRepositoryFolders.Form7DSurgicalSoftwareSpineModuleAppFolder _form7dsurgicalsoftwarespinemodule;

        /// <summary>
        /// Gets the singleton class instance representing the DataImportAndLoadRepository element repository.
        /// </summary>
        [RepositoryFolder("f1452eba-c83e-42c8-9d6c-0e9801d48e51")]
        public static DataImportAndLoadRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DataImportAndLoadRepository() 
            : base("DataImportAndLoadRepository", "/", null, 0, false, "f1452eba-c83e-42c8-9d6c-0e9801d48e51", ".\\RepositoryImages\\DataImportAndLoadRepositoryf1452eba.rximgres")
        {
            _form7dsurgicalsoftwarespinemodule = new DataImportAndLoadRepositoryFolders.Form7DSurgicalSoftwareSpineModuleAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f1452eba-c83e-42c8-9d6c-0e9801d48e51")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Form7DSurgicalSoftwareSpineModule folder.
        /// </summary>
        [RepositoryFolder("23d6a5e1-ab9c-4b39-8f02-f02fa6c12134")]
        public virtual DataImportAndLoadRepositoryFolders.Form7DSurgicalSoftwareSpineModuleAppFolder Form7DSurgicalSoftwareSpineModule
        {
            get { return _form7dsurgicalsoftwarespinemodule; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class DataImportAndLoadRepositoryFolders
    {
        /// <summary>
        /// The Form7DSurgicalSoftwareSpineModuleAppFolder folder.
        /// </summary>
        [RepositoryFolder("23d6a5e1-ab9c-4b39-8f02-f02fa6c12134")]
        public partial class Form7DSurgicalSoftwareSpineModuleAppFolder : RepoGenBaseFolder
        {
            DataImportAndLoadRepositoryFolders.SomeList1Folder _somelist1;
            RepoItemInfo _selectpatientdataforthisprocedureInfo;

            /// <summary>
            /// Creates a new Form7DSurgicalSoftwareSpineModule  folder.
            /// </summary>
            public Form7DSurgicalSoftwareSpineModuleAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Form7DSurgicalSoftwareSpineModule", "/form[@title~'^7D\\ Surgical\\ Software\\ -\\ Sp']", parentFolder, 30000, null, true, "23d6a5e1-ab9c-4b39-8f02-f02fa6c12134", "")
            {
                _somelist1 = new DataImportAndLoadRepositoryFolders.SomeList1Folder(this);
                _selectpatientdataforthisprocedureInfo = new RepoItemInfo(this, "SelectPatientDataForThisProcedure", "?/?/list[@automationid='MessageBar']/text[@caption~'^Select\\ patient\\ data\\ for\\ t']", 30000, null, "3b87049f-f924-4d13-aff2-7090a683dd02");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("23d6a5e1-ab9c-4b39-8f02-f02fa6c12134")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("23d6a5e1-ab9c-4b39-8f02-f02fa6c12134")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SelectPatientDataForThisProcedure item.
            /// </summary>
            [RepositoryItem("3b87049f-f924-4d13-aff2-7090a683dd02")]
            public virtual Ranorex.Text SelectPatientDataForThisProcedure
            {
                get
                {
                    return _selectpatientdataforthisprocedureInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SelectPatientDataForThisProcedure item info.
            /// </summary>
            [RepositoryItemInfo("3b87049f-f924-4d13-aff2-7090a683dd02")]
            public virtual RepoItemInfo SelectPatientDataForThisProcedureInfo
            {
                get
                {
                    return _selectpatientdataforthisprocedureInfo;
                }
            }

            /// <summary>
            /// The SomeList1 folder.
            /// </summary>
            [RepositoryFolder("e2b944f0-7bf0-46e7-8bdd-969c6ab92a34")]
            public virtual DataImportAndLoadRepositoryFolders.SomeList1Folder SomeList1
            {
                get { return _somelist1; }
            }
        }

        /// <summary>
        /// The SomeList1Folder folder.
        /// </summary>
        [RepositoryFolder("e2b944f0-7bf0-46e7-8bdd-969c6ab92a34")]
        public partial class SomeList1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _somelistInfo;
            RepoItemInfo _workflowbutton2Info;
            RepoItemInfo _workflowbuttonInfo;
            RepoItemInfo _workflowbutton4Info;
            RepoItemInfo _workflowbutton3Info;
            RepoItemInfo _workflowbutton1Info;

            /// <summary>
            /// Creates a new SomeList1  folder.
            /// </summary>
            public SomeList1Folder(RepoGenBaseFolder parentFolder) :
                    base("SomeList1", "container[1]/list", parentFolder, 30000, null, false, "e2b944f0-7bf0-46e7-8bdd-969c6ab92a34", "")
            {
                _somelistInfo = new RepoItemInfo(this, "SomeList", "", 30000, null, "9fc27105-13bd-4042-8921-4ccced35f16a");
                _workflowbutton2Info = new RepoItemInfo(this, "WorkflowButton2", "radiobutton[@name='WorkflowButton' and @text='Define Levels']", 30000, null, "96a3f5da-ec67-4fd9-b5ac-ee3801be5593");
                _workflowbuttonInfo = new RepoItemInfo(this, "WorkflowButton", "radiobutton[@name='WorkflowButton' and @text='Load Data']", 30000, null, "8d975658-3989-4c1c-9547-2ad3d7edde2c");
                _workflowbutton4Info = new RepoItemInfo(this, "WorkflowButton4", "radiobutton[@name='WorkflowButton' and @text='Navigate']", 30000, null, "7b683117-115e-4fb9-aa91-4151cdc61a39");
                _workflowbutton3Info = new RepoItemInfo(this, "WorkflowButton3", "radiobutton[@name='WorkflowButton' and @text='Register']", 30000, null, "a799fbcd-478b-4b23-ada9-6034dbd06f37");
                _workflowbutton1Info = new RepoItemInfo(this, "WorkflowButton1", "radiobutton[@name='WorkflowButton' and @text='Threshold']", 30000, null, "3b9e5452-9eb2-47b9-a401-578304b9e9bd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e2b944f0-7bf0-46e7-8bdd-969c6ab92a34")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e2b944f0-7bf0-46e7-8bdd-969c6ab92a34")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeList item.
            /// </summary>
            [RepositoryItem("9fc27105-13bd-4042-8921-4ccced35f16a")]
            public virtual Ranorex.List SomeList
            {
                get
                {
                    return _somelistInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The SomeList item info.
            /// </summary>
            [RepositoryItemInfo("9fc27105-13bd-4042-8921-4ccced35f16a")]
            public virtual RepoItemInfo SomeListInfo
            {
                get
                {
                    return _somelistInfo;
                }
            }

            /// <summary>
            /// The WorkflowButton2 item.
            /// </summary>
            [RepositoryItem("96a3f5da-ec67-4fd9-b5ac-ee3801be5593")]
            public virtual Ranorex.RadioButton WorkflowButton2
            {
                get
                {
                    return _workflowbutton2Info.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The WorkflowButton2 item info.
            /// </summary>
            [RepositoryItemInfo("96a3f5da-ec67-4fd9-b5ac-ee3801be5593")]
            public virtual RepoItemInfo WorkflowButton2Info
            {
                get
                {
                    return _workflowbutton2Info;
                }
            }

            /// <summary>
            /// The WorkflowButton item.
            /// </summary>
            [RepositoryItem("8d975658-3989-4c1c-9547-2ad3d7edde2c")]
            public virtual Ranorex.RadioButton WorkflowButton
            {
                get
                {
                    return _workflowbuttonInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The WorkflowButton item info.
            /// </summary>
            [RepositoryItemInfo("8d975658-3989-4c1c-9547-2ad3d7edde2c")]
            public virtual RepoItemInfo WorkflowButtonInfo
            {
                get
                {
                    return _workflowbuttonInfo;
                }
            }

            /// <summary>
            /// The WorkflowButton4 item.
            /// </summary>
            [RepositoryItem("7b683117-115e-4fb9-aa91-4151cdc61a39")]
            public virtual Ranorex.RadioButton WorkflowButton4
            {
                get
                {
                    return _workflowbutton4Info.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The WorkflowButton4 item info.
            /// </summary>
            [RepositoryItemInfo("7b683117-115e-4fb9-aa91-4151cdc61a39")]
            public virtual RepoItemInfo WorkflowButton4Info
            {
                get
                {
                    return _workflowbutton4Info;
                }
            }

            /// <summary>
            /// The WorkflowButton3 item.
            /// </summary>
            [RepositoryItem("a799fbcd-478b-4b23-ada9-6034dbd06f37")]
            public virtual Ranorex.RadioButton WorkflowButton3
            {
                get
                {
                    return _workflowbutton3Info.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The WorkflowButton3 item info.
            /// </summary>
            [RepositoryItemInfo("a799fbcd-478b-4b23-ada9-6034dbd06f37")]
            public virtual RepoItemInfo WorkflowButton3Info
            {
                get
                {
                    return _workflowbutton3Info;
                }
            }

            /// <summary>
            /// The WorkflowButton1 item.
            /// </summary>
            [RepositoryItem("3b9e5452-9eb2-47b9-a401-578304b9e9bd")]
            public virtual Ranorex.RadioButton WorkflowButton1
            {
                get
                {
                    return _workflowbutton1Info.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The WorkflowButton1 item info.
            /// </summary>
            [RepositoryItemInfo("3b9e5452-9eb2-47b9-a401-578304b9e9bd")]
            public virtual RepoItemInfo WorkflowButton1Info
            {
                get
                {
                    return _workflowbutton1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}