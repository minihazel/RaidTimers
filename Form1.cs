using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidTimers
{
    public partial class raidForm : Form
    {
        public string modDir = Environment.CurrentDirectory;
        public string modConfig;
        public string success;

        public raidForm()
        {
            InitializeComponent();
        }

        private void raidForm_Load(object sender, EventArgs e)
        {
            modConfig = Path.Combine(modDir, "config\\config.json");
            if (!File.Exists(modConfig))
            {
                mapsBox.Enabled = false;
                bApply.Enabled = false;
                MessageBox.Show($"It appears that you have not placed this app in the right folder.\nPlease place RaidTimers.exe and Newtonsoft.Json.dll into the \"RaidTimers\" mod folder.");
                Application.Exit();
            } else
            {
                this.Text = modConfig;
            }
        }

        private void showMessage(string content)
        {
            MessageBox.Show(content, this.Text, MessageBoxButtons.OK);
        }

        private void fetchTime(string item)
        {
            string[] mapArray = { };
            string readConfig = File.ReadAllText(modConfig);
            JObject obj = JObject.Parse(readConfig);
            JObject maps = (JObject)obj["maps"];

            try
            {
                foreach (var map in maps)
                {
                    if (map.Key.ToString() == item.ToLower())
                    {
                        string mName = map.Key.ToString();
                        JObject child = (JObject)map.Value;

                        escapeBox.Text = child["time"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine($"ERROR: {err.ToString()}");
            }
        }

        private void mapsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapsBox.SelectedIndex > -1)
            {
                bCheck.Enabled = true;
                bApply.Enabled = true;
                escapeBox.Enabled = true;

                switch (mapsBox.SelectedItem.ToString())
                {
                    case "Customs":
                        lblMapPlaceholder.Text = "bigmap";
                        break;
                    case "Factory Day":
                        lblMapPlaceholder.Text = "factory4_day";
                        break;
                    case "Factory Night":
                        lblMapPlaceholder.Text = "factory4_night";
                        break;
                    case "Interchange":
                        lblMapPlaceholder.Text = "interchange";
                        break;
                    case "Labs":
                        lblMapPlaceholder.Text = "laboratory";
                        break;
                    case "Lighthouse":
                        lblMapPlaceholder.Text = "lighthouse";
                        break;
                    case "Reserve":
                        lblMapPlaceholder.Text = "rezervbase";
                        break;
                    case "Shoreline":
                        lblMapPlaceholder.Text = "shoreline";
                        break;
                    case "Streets":
                        lblMapPlaceholder.Text = "tarkovstreets";
                        break;
                    case "Woods":
                        lblMapPlaceholder.Text = "woods";
                        break;
                }
                fetchTime(lblMapPlaceholder.Text);
            }
        }

        private void escapebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (chkAllMaps.Checked == true)
            {
                if (escapeBox.Text.Contains("."))
                {
                    showMessage("Please do not use \".\" periods in the time.");
                }
                else
                {
                    if (bApply.Text.ToLower().Contains("reset"))
                    {
                        if (MessageBox.Show($"Reset time for all maps?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string readConfig = File.ReadAllText(modConfig);
                            JObject obj = JObject.Parse(readConfig);
                            JObject maps = (JObject)obj["maps"];

                            try
                            {
                                maps["bigmap"]["time"] = 40;
                                maps["factory4_day"]["time"] = 20;
                                maps["factory4_night"]["time"] = 25;
                                maps["interchange"]["time"] = 40;
                                maps["laboratory"]["time"] = 35;
                                maps["lighthouse"]["time"] = 40;
                                maps["rezervbase"]["time"] = 40;
                                maps["shoreline"]["time"] = 45;
                                maps["tarkovstreets"]["time"] = 50;
                                maps["woods"]["time"] = 40;

                                string output = JsonConvert.SerializeObject(obj, Formatting.Indented);

                                File.WriteAllText(modConfig, output);
                            }
                            catch (Exception err)
                            {
                                Debug.WriteLine($"ERROR: {err.ToString()}");
                            }
                        }

                    } else
                    {
                        if (escapeBox.Text.Length > 0 && escapeBox.Text != null)
                        {
                            if (MessageBox.Show($"Apply {escapeBox.Text} minutes to all maps?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string readConfig = File.ReadAllText(modConfig);
                                JObject obj = JObject.Parse(readConfig);
                                JObject maps = (JObject)obj["maps"];

                                try
                                {
                                    foreach (var map in maps)
                                    {
                                        JObject child = (JObject)map.Value;
                                        child["time"] = Int32.Parse(escapeBox.Text);
                                    }

                                    string output = JsonConvert.SerializeObject(obj, Formatting.Indented);

                                    File.WriteAllText(modConfig, output);
                                }
                                catch (Exception err)
                                {
                                    Debug.WriteLine($"ERROR: {err.ToString()}");
                                }
                            }

                        }
                        else
                        {
                            showMessage("Please provide a time in minutes to apply to all maps.");
                        }

                    }
                }


            } else
            {
                if (mapsBox.SelectedIndex > -1 && escapeBox.Text != null)
                {
                    if (escapeBox.Text.Contains("."))
                    {
                        showMessage("Please do not use \".\" periods in the time.");
                    }
                    else
                    {
                        if (bApply.Text.ToLower().Contains("reset"))
                        {
                            if (MessageBox.Show($"Reset time for {mapsBox.SelectedItem.ToString()}?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string readConfig = File.ReadAllText(modConfig);
                                JObject obj = JObject.Parse(readConfig);
                                JObject maps = (JObject)obj["maps"];

                                switch (mapsBox.SelectedItem.ToString().ToLower())
                                {
                                    case "customs":
                                        maps[lblMapPlaceholder.Text]["time"] = 40;
                                        break;

                                    case "factory day":
                                        maps[lblMapPlaceholder.Text]["time"] = 20;
                                        break;

                                    case "factory night":
                                        maps[lblMapPlaceholder.Text]["time"] = 25;
                                        break;

                                    case "interchange":
                                        maps[lblMapPlaceholder.Text]["time"] = 40;
                                        break;

                                    case "labs":
                                        maps[lblMapPlaceholder.Text]["time"] = 35;
                                        break;

                                    case "lighthouse":
                                        maps[lblMapPlaceholder.Text]["time"] = 40;
                                        break;

                                    case "reserve":
                                        maps[lblMapPlaceholder.Text]["time"] = 40;
                                        break;

                                    case "shoreline":
                                        maps[lblMapPlaceholder.Text]["time"] = 45;
                                        break;

                                    case "streets":
                                        maps[lblMapPlaceholder.Text]["time"] = 50;
                                        break;

                                    case "woods":
                                        maps[lblMapPlaceholder.Text]["time"] = 40;
                                        break;
                                }

                                string output = JsonConvert.SerializeObject(obj, Formatting.Indented);
                                File.WriteAllText(modConfig, output);

                            }

                        } else
                        {
                            string readConfig = File.ReadAllText(modConfig);
                            JObject obj = JObject.Parse(readConfig);
                            JObject maps = (JObject)obj["maps"];

                            try
                            {
                                foreach (var map in maps)
                                {
                                    if (map.Key.ToString() == lblMapPlaceholder.Text.ToLower())
                                    {
                                        if (MessageBox.Show($"Set {escapeBox.Text} minutes of raid time to {mapsBox.SelectedItem.ToString()}?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        {
                                            string mName = map.Key.ToString();
                                            JObject child = (JObject)map.Value;
                                            int time = (int)child["time"];

                                            maps[lblMapPlaceholder.Text]["time"] = Int32.Parse(escapeBox.Text);

                                            string output = JsonConvert.SerializeObject(obj, Formatting.Indented);
                                            File.WriteAllText(modConfig, output);
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            catch (Exception err)
                            {
                                Debug.WriteLine($"ERROR: {err.ToString()}");
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Please fill out the information necessary.", this.Text, MessageBoxButtons.OK);

                }
            }

            

        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (chkAllMaps.Checked == true)
            {
                // all maps
                string[] mapArray = { };
                string readConfig = File.ReadAllText(modConfig);
                JObject obj = JObject.Parse(readConfig);
                JObject maps = (JObject)obj["maps"];

                try
                {
                    foreach (var map in maps)
                    {
                        string mName = map.Key.ToString();
                        JObject child = (JObject)map.Value;
                        int time = (int)child["time"];

                        string content = $"Map {mName} has time: {time.ToString()} minutes\n";
                        Array.Resize(ref mapArray, mapArray.Length + 1);
                        mapArray[mapArray.Length - 1] = content;
                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine($"ERROR: {err.ToString()}");
                }

                try
                {
                    MessageBox.Show(string.Join("\n", mapArray), this.Text, MessageBoxButtons.OK);

                }
                catch (Exception err)
                {
                    Debug.WriteLine($"ERROR: {err.ToString()}");
                }

            }
            else
            {
                // single map
                if (mapsBox.SelectedIndex > -1 && escapeBox.Text != null && escapeBox.Text.Length > 0)
                {
                    string readConfig = File.ReadAllText(modConfig);
                    JObject obj = JObject.Parse(readConfig);
                    JObject maps = (JObject)obj["maps"];

                    try
                    {
                        foreach (var map in maps)
                        {
                            if (map.Key.ToString() == lblMapPlaceholder.Text.ToLower())
                            {
                                string mName = map.Key.ToString();
                                JObject child = (JObject)map.Value;
                                int time = (int)child["time"];

                                string content = $"Map {mName} has time: {time.ToString()} minutes";
                                showMessage(content);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.ToString()}");
                    }
                } else
                {
                    showMessage("Please select a map to view first, alternatively enable \"All maps\"");
                }
            }
        }

        private void chkReset_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReset.Checked == true)
            {
                bApply.Text = "Apply reset";
            } else
            {
                bApply.Text = "Apply";
            }
        }

        private void chkAllMaps_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllMaps.Checked == true)
            {
                bApply.Enabled = true;
                escapeBox.Enabled = true;
            } else
            {
                if (mapsBox.SelectedIndex < 0)
                {
                    bApply.Enabled = false;
                    escapeBox.Enabled = false;
                }
            }
        }
    }
}
