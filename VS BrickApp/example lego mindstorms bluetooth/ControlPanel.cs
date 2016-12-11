using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Lego_Mindstorms_Bluetooth
{
    public partial class ControlPanel : Form
    {
        private EV3Messenger messenger;
        #region FormInitialize
        public ControlPanel()
        {
            InitializeComponent();
            // Init application
            messenger = new EV3Messenger();
            statusBox.Text = "Status : Not connected";
            fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
           
        }
        #endregion
        #region ArrowsMovementSupport
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.NumPad8)
            {
                if (messenger.SendMessage("COMMAND", "PickUp"))
                {

                    //MessageBox.Show("Start function called!");
                    statusBox.Text = "Status : Picking Up Item";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            if (keyData == Keys.NumPad2)
            {
                if (messenger.SendMessage("COMMAND", "DropDown"))
                {

                    //MessageBox.Show("Start function called!");
                    statusBox.Text = "Status : Putting item on the ground.";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                if (messenger.SendMessage("COMMAND", "Start"))
                {

                    //MessageBox.Show("Start function called!");
                    statusBox.Text = "Status : Moving Forward";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                //Start Driving
                if (messenger.SendMessage("COMMAND", "Reverse"))
                {
                    //MessageBox.Show("Stop function called!");
                    statusBox.Text = "Status : Reversing";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                if (messenger.SendMessage("COMMAND", "Left"))
                {
                    //MessageBox.Show("Stop function called!");
                    statusBox.Text = "Status : Turning left";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return true;
            }
            if (keyData == Keys.Space)
            {
                if (messenger.SendMessage("COMMAND", "Stop"))
                {
                    //MessageBox.Show("Stop function called!");
                    statusBox.Text = "Status : Stopped, Idle";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                if (messenger.SendMessage("COMMAND", "Right"))
                {
                    //MessageBox.Show("Stop function called!");
                    statusBox.Text = "Status : Turning right";
                }
                else
                {
                    MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
        #region Connection form
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Check if a port has been selected
            if (portListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    statusBox.Text = "Status : Connected, Idle";
                    updateFormGUI();
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            // Disconnect from the Brick
            messenger.Disconnect();
            statusBox.Text = "Status : Disconnected";
            updateFormGUI();
        }

        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portListBox.Items.Clear();
            foreach (String port in ports)
            {
                portListBox.Items.Add(port);
            }
        }

        #endregion
        #region Input & output form

        private void inputButton_Click(object sender, EventArgs e)
        {
            string txtMsg = inputTextBox.Text;
            // Make sure a message has been typed
            if (!String.IsNullOrWhiteSpace(txtMsg))
            {
                // Send a message to the Brick with title: MESSAGE and the message
                if (messenger.SendMessage("COMMAND", txtMsg))
                {
                    inputTextBox.Text = "";
                    MessageBox.Show("The command has been send to the Brick");
                }
                else
                {
                    MessageBox.Show("Unable to send the command to the Brick. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please type a recognizable command in the above textbox for the Brick");
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputlistBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputlistBox.TopIndex = outputlistBox.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No message recieved from the Brick");
            }
        }

        #endregion
        #region GUI

        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshButton.Enabled = false;
                connectButton.Enabled = false;
                liftDown.Enabled = true;
                liftUp.Enabled = true;
                inputGroupBox.Enabled = true;
                outputGroupBox.Enabled = true;
                disconnectButton.Enabled = true;

                outputlistBox.Items.Clear();

                statusBox.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                liftDown.Enabled = false;
                liftUp.Enabled = false;
                refreshButton.Enabled = true;
                connectButton.Enabled = true;
                statusBox.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                inputGroupBox.Enabled = false;
                outputGroupBox.Enabled = false;
                disconnectButton.Enabled = false;
            }
        }

        #endregion
        #region ArrowsButtonsSupport
        private void button1_Click(object sender, EventArgs e)
        {
            //Start Driving
            if (messenger.SendMessage("COMMAND", "Start"))
            {
                
                //MessageBox.Show("Start function called!");
                statusBox.Text = "Status : Moving Forward";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                       //Start Driving
            if (messenger.SendMessage("COMMAND", "Stop"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Stopped, Idle";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Start Driving
            if (messenger.SendMessage("COMMAND", "Right"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Turning right";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Start Driving
            if (messenger.SendMessage("COMMAND", "Left"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Turning left";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Start Driving
            if (messenger.SendMessage("COMMAND", "Reverse"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Reversing";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Start Driving
            if (messenger.SendMessage("COMMAND", "AutoMove"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Tracing black line.";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion
        #region LiftUp/Down
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (messenger.SendMessage("COMMAND", "PickUp"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Lift stopped";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void liftDown_Click(object sender, EventArgs e)
        {
            if (messenger.SendMessage("COMMAND", "DropDown"))
            {
                //MessageBox.Show("Stop function called!");
                statusBox.Text = "Status : Dropping down.";
            }
            else
            {
                MessageBox.Show("Cannot execute command! Please check your connection!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
