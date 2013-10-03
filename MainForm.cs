using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IUSDatasources {
    public partial class MainForm : Form {
        public static string STR_FILENAME_XML;
        

        public MainForm() {
            InitializeComponent();
            txtFileName.Text = "C:\\_QA\\IUS\\win2012-worksite-web_datasources.xml.txt";
            lblOutput.Text = "(output)";
            //tvXML.Dock = DockStyle.Fill;
            tvXML.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        // Select file
        private void btnOpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog_XML = new OpenFileDialog();
            //string STR_FILENAME_XML;

            openFileDialog_XML.InitialDirectory = "c:\\";
            openFileDialog_XML.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            //openFileDialog_XML.FilterIndex = 2;
            openFileDialog_XML.RestoreDirectory = true;
            openFileDialog_XML.Multiselect = false;

            if (openFileDialog_XML.ShowDialog() == DialogResult.OK) {
                //STR_FILENAME_XML = openFileDialog_XML.FileName;
                txtFileName.Text = openFileDialog_XML.FileName;

                //txtFileName.Text = STR_FILENAME_XML;
            }
        }

        // Read in file
        private void btnParseFile_Click(object sender, EventArgs e) {
            STR_FILENAME_XML = txtFileName.Text;

            if (!string.IsNullOrWhiteSpace(STR_FILENAME_XML)) {
                //lblOutput.Text = "good to GO";
                parseXML(STR_FILENAME_XML);
            }
            else {
                lblOutput.Text = "empty";
            }
        }

        // Parse xml
        private void parseXML(string strFileName) {
            // load xml into doc
            //XmlReader reader = XmlReader.Create(strFileName);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(strFileName);

            // init treeview
            tvXML.Nodes.Clear();
            tvXML.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            TreeNode tNode = new TreeNode();
            tNode = tvXML.Nodes[0];

            // populate treeview
            AddNodes(xmldoc.DocumentElement, tNode);
            tvXML.ExpandAll();
        }

        // taken from http://support.microsoft.com/kb/317597
        // recurse the SHIT out of the XML tree
        private void AddNodes(XmlNode inXmlNode, TreeNode inTreeNode) {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;

            // loop down through XML to find leaf (adding to inTreeNode as we traverse)
            if (inXmlNode.HasChildNodes) {
                xNodeList = inXmlNode.ChildNodes;
                for (int i = 0; i <= xNodeList.Count - 1; i++) {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNodes(xNode, tNode);
                }
            }
            // "Here you need to pull the data from the XmlNode based on the type of node, whether attribute values are required, and so forth."
            // meh
            else {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }
    }
}
