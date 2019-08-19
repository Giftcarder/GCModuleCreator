using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GiftCarder_Module_Creator
{
    public partial class Creation : Form
    {
        //VAR
        private string UpdateURL = "https://raw.githubusercontent.com/PurityWasHere/FeedTheBot/master/VersionNumber";

        private string LocalVersion = "1.0";

        //
        public Creation()
        {
            InitializeComponent();
            WebClient wc = new WebClient();
            string NewVersion = wc.DownloadString(UpdateURL).Trim();
            if (LocalVersion != NewVersion)
            {
                MessageBox.Show("Running Out of Date Version. Please Update", "Notice");
            }
        }

        //Clears Boxes on Click
        private void ScrapeBox_Click(object sender, EventArgs e)
        {
            ScrapeBox.Clear();
        }

        private void HeadersBox_TextChanged(object sender, EventArgs e)
        {
            HeadersBox.Clear();
        }

        private void SuccessBox_Click(object sender, EventArgs e)
        {
            SuccessBox.Clear();
        }

        private void ErrorBox_Click(object sender, EventArgs e)
        {
            ErrorBox.Clear();
        }

        private void SiteKeyBox_Click(object sender, EventArgs e)
        {
            SiteKeyBox.Clear();
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {
            URLBox.Clear();
        }

        private void NameBox_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
        }

        private void HeadersBox_Click(object sender, EventArgs e)
        {
            HeadersBox.Clear();
        }

        private void URLBox_Click(object sender, EventArgs e)
        {
            URLBox.Clear();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            ///VARS
            String CaptchaBOOL = "";
            String TokenBOOL = "";
            String PinBOOL = "";
            String CookiesBOOL = "";
            String ValidBOOL = "";
            String FILL = "";
            String METHOD = "";
            String CaptchaName = "";
            String PinName = "";
            String Headers = "";
            ///

            //Logic for VARS
            if (PinToggle.Checked == true)
            {
                PinBOOL = "Yes";
            }
            else
            {
                PinBOOL = "No";
            }

            if (PinToggle.Checked == true)
            {
                PinName = "True";
            }
            else
            {
                PinName = "False";
            }

            if (TokenToggle.Checked == true)
            {
                TokenBOOL = "True";
            }
            else
            {
                TokenBOOL = "False";
            }

            if (CookieToggle.Checked == true)
            {
                CookiesBOOL = "True";
            }
            else
            {
                CookiesBOOL = "False";
            }

            if (CaptchaToggle.Checked == true)
            {
                CaptchaBOOL = "True";
            }
            else
            {
                CaptchaBOOL = "False";
            }

            if (CaptchaToggle.Checked == true)
            {
                CaptchaName = "Yes";
            }
            else
            {
                CaptchaName = "No";
            }

            if (StaticToggle.Checked == true)
            {
                ValidBOOL = "Yes";
            }
            else
            {
                ValidBOOL = "No";
            }

            if (MethodToggle.Checked == true)
            {
                METHOD = "POST";
            }
            else
            {
                METHOD = "GET";
            }

            if (HeaderTOGGLE.Checked == true)
            {
                Headers = '"' + HeadersBox.Text + '"';
            }
            else
            {
                Headers = "None";
            }

            //Saves the name based off Selections
            string NameEXT = NameBox.Text + "[" + PinBOOL + "]" + "[" + CaptchaName + "]" + "[" + ValidBOOL + "]";
            File.WriteAllText(NameEXT + ".py", "");
            //

            //STRINGS FOR SETTINGS
            String NameFILL = NameBox.Text;
            String PatternFILL = CardFormatBox.Text;
            String PinFILL = PinBox.Text;
            String CookieFILL = CookiesBOOL;
            String TokenFILL = TokenBOOL;
            String CaptchaFILL = CaptchaBOOL;
            String SiteKeyFILL = SiteKeyBox.Text;
            String ErrorFILL = ErrorBox.Text;
            String RetriesFILL = RetriesBox.Text;
            String TimeoutFILL = TimeoutBox.Text;
            //

            FILL = ("#Module Generated Using Pure's Module Creator" + "\n" +
                    "#====== GENERAL SETTINGS ======" + "\n" +
                    "name = " + '"' + NameFILL + '"' + "\n" +
                    "method = " + "'" + METHOD + "'" + "\n" +
                    "pattern = " + '"' + PatternFILL + '"' + "\n" +
                    "pin = " + PinName + "\n" +
                    "cookie = " + CookieFILL + "\n" +
                    "token = " + TokenFILL + "\n" +
                    "captcha = " + CaptchaFILL + "\n" +
                    "site_key = " + '"' + SiteKeyFILL + '"' + "\n" +
                    "error = " + '[' + ErrorFILL + ']' + "\n" +
                    "retries = " + RetriesFILL + "\n" +
                    "timeout = " + TimeoutFILL + "\n" +
                    "headers = " + Headers + "\n" +
                    "#====== GENERATING AREA ======" + "\n" +
                    "async def cardcode(cardcode = pattern):" + "\n" +
                    "for x in range(" + (CardLength.Text) + "):" + "\n" +
                    "cardcode += str(randint(0,9))" + "\n" +
                    " return cardcode" + "\n" +
                    "async def pincode(pincode = " + (PinDigitBox.Text) + "):" + "\n" +
                    "for x in range(" + (PinBox.Text) + "):" + "\n" +
                    "pincode += str(randint(0,9))" + "\n" +
                    "return pincode" + "\n" +
                    "#====== SETTINGS AREA ======" + "\n" +
                    "def request():" + "\n" +
                    "url = " + (URLBox.Text) + "" + "\n" +
                    "return url" + "\n"
                    );

            //Writes the File
            File.WriteAllText(NameEXT + ".py", FILL);
        }
    }
}