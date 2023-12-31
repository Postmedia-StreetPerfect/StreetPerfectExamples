using StreetPerfect.Http;
using StreetPerfect.Models;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string _searchText { get; set; } = "";
        private caTypeaheadResponse _lastTypeaheadResp { get; set; }
        private readonly IStreetPerfectHttpClient _client;

        public Form1(IStreetPerfectHttpClient client)
        {
            _client = client;
            InitializeComponent();
            ResizeTabCtrl();

            clientId.Text = ConfigurationManager.AppSettings["sp_ClientId"];
            clientSecret.Text = ConfigurationManager.AppSettings["sp_ClientSecret"];
            baseAddr.Text = ConfigurationManager.AppSettings["sp_BaseAddress"];
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            await GetInfo();
        }


        private async Task GetInfo()
        {
            try
            {
                var info = await _client.GetInfo();
                spInfo.Text = "";
                foreach (var line in info.info)
                {
                    spInfo.Text += $"{line}\r\n";
                }
                spInfo.Text += $"status_flag: {info.status_flag}\r\n";
                spInfo.Text += $"status_messages: {info.status_messages}\r\n";
            }
            catch (Exception ex)
            {
                spInfo.Text = $"Error:\r\n{ex.Message}\r\n\r\nStack:\r\n{ex.StackTrace.ToString()}";
            }
        }


        private void ResizeTabCtrl()
        {
            tabControl1.Width = Width;
            tabControl1.Height = Height - 60;

            var box_width = Width - 220;

            baseAddr.Width = box_width;
            clientId.Width = box_width;
            clientSecret.Width = box_width;

            spInfo.Width = box_width;
            spInfo.Height = Height - 410;
            test_button.Top = Height - 220;

            box_width = Width - 200;

            SearchCtrl.Width = box_width;
            StreetAddr.Width = box_width;
            City.Width = box_width;
            Prov.Width = box_width;
            PostalCode.Width = box_width;
            msgBox.Width = box_width;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeTabCtrl();
        }

        private async void SearchCtrl_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                // these helps us use the combo box as a typeahead ctrl
                _searchText = SearchCtrl.Text;
                SearchCtrl.SelectedIndex = -1;

                var qreq = new caTypeaheadRequest()
                {
                    address_line = _searchText,
                    city = City.Text,
                    max_returned = 50,
                    province = Prov.Text,
                    postal_code = "",
                };

                int max_returned = 30;

                qreq.tokenize_qry = true;
                qreq.max_returned = max_returned;

                var qresp = await _client.caTypeahead(qreq);

                int recs = Math.Min((int)max_returned, qresp.count);
                _lastTypeaheadResp = qresp;
                var addx = qresp.addr_num;

                SearchCtrl.SelectedIndex = -1;
                SearchCtrl.Items.Clear();
                SearchCtrl.DroppedDown = true;
                foreach (var a in qresp.address_lines.GetRange(0, recs))
                {
                    SearchCtrl.Items.Add(a);
                }

                SearchCtrl.SelectedIndex = -1;
                SearchCtrl.DisplayMember = "addr";
                SearchCtrl.ValueMember = "id";

                SearchCtrl.Text = _searchText;
                SearchCtrl.SelectionStart = _searchText.Length;
                Cursor.Current = Cursors.Default;

                msgBox.Text = 
$"""
Response:
status_flag={qresp.status_flag}
status_messages={qresp.status_messages}
addr_num={qresp.addr_num}
unit_num={qresp.unit_num}
suffix={qresp.suffix}
start_rec={qresp.start_rec}
count={qresp.count}
total_hits={qresp.total_hits}
t_exec_ms={qresp.t_exec_ms}
""";
            }
            catch (Exception ex)
            {
                //_logger.LogCritical(ex, "{Path} error, {Message}, req= {@req}", Request.Path.Value.ToString(), ex.Message, req);
                msgBox.Text = $"Error:\r\n{ex.Message}";
            }

        }

        private async void SearchCtrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (SearchCtrl?.SelectedIndex >= 0 && SearchCtrl.SelectedItem != null)
            {
                var sel_addr = (caTypeaheadAddr)SearchCtrl.SelectedItem;
                SearchCtrl.DroppedDown = false;

                var addr = await _client.caTypeaheadFetch(new caTypeaheadFetchRequest()
                {
                    id = sel_addr.id,
                    autocorrect = true,
                    street_num = _lastTypeaheadResp.addr_num,
                    unit_num = _lastTypeaheadResp.unit_num,
                    street_suffix = _lastTypeaheadResp.suffix,
                    return_components = true,
                    options = new Options()
                    {
                        OutputFormatGuide = "7"
                    }
                });

                StreetAddr.Text = addr.address_line;
                City.Text = addr.city;
                Prov.Text = addr.province;
                PostalCode.Text = addr.postal_code;

            }
        }

        private void clear_button_MouseClick(object sender, MouseEventArgs e)
        {
            SearchCtrl.DroppedDown = false;
            SearchCtrl.Items.Clear();
            SearchCtrl.Text = "";

            StreetAddr.Text = "";
            City.Text = "";
            Prov.Text = "";
            PostalCode.Text = "";
            msgBox.Text = "";
            SearchCtrl.Focus();
            SearchCtrl.SelectedIndex = -1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                SearchCtrl.Focus();
        }
    }
}
