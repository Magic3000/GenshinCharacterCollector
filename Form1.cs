using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinCharacterCollector
{
    public partial class Form1 : Form
    {
        private string texturesPath = "Resources/";
        public static Form1 _instance;
        public Form1()
        {
            InitializeComponent();
            _instance = this;
            LoadConfig();
            expBooxImage.Image = Image.FromFile($"{texturesPath}exp_book.png");
        }

        private string configPath = @"settings.json";
        public Dictionary<string, object> Config = new Dictionary<string, object>();
        internal void LoadConfig()
        {
            if (!File.Exists(configPath))
            {
                File.Create(configPath).Close();
                File.WriteAllText(configPath, "");
            }
            Config = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(configPath));

            if (Config == null)
                Config = new Dictionary<string, object>();

            try { useRus = int.Parse(Config[$"UseRus"].ToString()) == 1; }
            catch { useRus = false; }
            changeLang.Text = useRus ? "Rus" : "Eng";

            try { selectedCharacter = int.Parse(Config["SelectedCharacter"].ToString()); }
            catch { selectedCharacter = 0; }

            for (int i = 0; i < characterBanners.Count; i++)
            {
                try { expBooks[i] = int.Parse(Config[$"{i}_books"].ToString()); }
                catch { expBooks[i] = 0; }
                
                try { bossItems[i] = int.Parse(Config[$"{i}_boss_items"].ToString()); }
                catch { bossItems[i] = 0; }

                try { flowers[i] = int.Parse(Config[$"{i}_flowers"].ToString()); }
                catch { flowers[i] = 0; }

                try { goldGems[i] = int.Parse(Config[$"{i}_gold_gems"].ToString()); }
                catch { goldGems[i] = 0; }
                try { purpleGems[i] = int.Parse(Config[$"{i}_purple_gems"].ToString()); }
                catch { purpleGems[i] = 0; }
                try { blueGems[i] = int.Parse(Config[$"{i}_blue_gems"].ToString()); }
                catch { blueGems[i] = 0; }
                try { greenGems[i] = int.Parse(Config[$"{i}_green_gems"].ToString()); }
                catch { greenGems[i] = 0; }

                try { thirdMaterials[i] = int.Parse(Config[$"{i}_third_materials"].ToString()); }
                catch { thirdMaterials[i] = 0; }
                try { secondMaterials[i] = int.Parse(Config[$"{i}_second_materials"].ToString()); }
                catch { secondMaterials[i] = 0; }
                try { firstMaterials[i] = int.Parse(Config[$"{i}_first_materials"].ToString()); }
                catch { firstMaterials[i] = 0; }
            }
            currentBooks = expBooks[selectedCharacter];
            expBookLabel.Text = $"{currentBooks}/432";
            var booksLeft = 432 - currentBooks;
            var totalSeconds = booksLeft * minsPerBook * 60;
            TimeSpan timeLeft = new TimeSpan(0, 0, (int)totalSeconds);
            expBookTimeLeft.Text = $"{string.Format("{0:0}", timeLeft.TotalDays)}d or {string.Format("{0:0}", timeLeft.TotalHours)}hrs";

            currentBossItems = bossItems[selectedCharacter];
            bossItemsLabel.Text = $"{currentBossItems}/46";

            currentFlowers = flowers[selectedCharacter];
            flowersLabel.Text = $"{currentFlowers}/168";
            currentGoldGems = goldGems[selectedCharacter];
            goldGemLabel.Text = $"{currentGoldGems}/6";
            currentPurpleGems = purpleGems[selectedCharacter];
            purpleGemLabel.Text = $"{currentPurpleGems}/9";
            currentBlueGems = blueGems[selectedCharacter];
            blueGemLabel.Text = $"{currentBlueGems}/9";
            currentGreenGems = greenGems[selectedCharacter];
            greenGemLabel.Text = $"{currentGreenGems}/1";

            currentThirdMaterials = thirdMaterials[selectedCharacter];
            thirdMaterialLabel.Text = $"{currentThirdMaterials}/36";

            currentSecondMaterials = secondMaterials[selectedCharacter];
            secondMaterialLabel.Text = $"{currentSecondMaterials}/30";

            currentFirstMaterials = firstMaterials[selectedCharacter];
            firstMaterialLabel.Text = $"{currentFirstMaterials}/18";
        }

        public void SaveConfig()
        {
            Config["UseRus"] = useRus ? 1 : 0;
            Config["SelectedCharacter"] = selectedCharacter;
            for (int i = 0; i < characterBanners.Count; i++)
            {
                Config[$"{i}_books"] = expBooks[i];
                Config[$"{i}_boss_items"] = bossItems[i];
                Config[$"{i}_flowers"] = flowers[i];
                Config[$"{i}_gold_gems"] = goldGems[i];
                Config[$"{i}_purple_gems"] = purpleGems[i];
                Config[$"{i}_blue_gems"] = blueGems[i];
                Config[$"{i}_green_gems"] = greenGems[i];
                Config[$"{i}_third_materials"] = thirdMaterials[i];
                Config[$"{i}_second_materials"] = secondMaterials[i];
                Config[$"{i}_first_materials"] = firstMaterials[i];
            }
            File.WriteAllText(configPath, JsonConvert.SerializeObject(Config));
        }


        public List<string[]> characterBanners = new List<string[]>()
        {
            new string[] { "2021-03-02-MomentOfBloom", "juvenile_jade.png", "silk_flower.png",
                "pyro_gold_gem.png", "pyro_purple_gem.png", "pyro_blue_gem.png", "pyro_green_gem.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png" },
            new string[] { "2021-02-03_Invitation_to_Mundane_Life", "juvenile_jade.png", "qingxin.png",
                "anemo_gold_gem.png", "anemo_purple_gem.png", "anemo_blue_gem.png", "anemo_green_gem.png",
                "xiao_third_material.png", "xiao_second_material.png", "xiao_first_material.png" },
            new string[] { "2021-01-13_Adrift_in_the_Harbor", "hoarfrost_core.png", "qingxin.png",
                "cryo_gold_gem.png", "cryo_purple_gem.png", "cryo_blue_gem.png", "cryo_green_gem.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png" },
        };

        public Dictionary<int, int> expBooks = new Dictionary<int, int>();
        public Dictionary<int, int> bossItems = new Dictionary<int, int>();
        public Dictionary<int, int> flowers = new Dictionary<int, int>();
        public Dictionary<int, int> goldGems = new Dictionary<int, int>();
        public Dictionary<int, int> purpleGems = new Dictionary<int, int>();
        public Dictionary<int, int> blueGems = new Dictionary<int, int>();
        public Dictionary<int, int> greenGems = new Dictionary<int, int>();
        public Dictionary<int, int> thirdMaterials = new Dictionary<int, int>();
        public Dictionary<int, int> secondMaterials = new Dictionary<int, int>();
        public Dictionary<int, int> firstMaterials = new Dictionary<int, int>();

        private int _selectedCharacter = 0;
        private bool useRus = false;
        public int selectedCharacter
        {
            get
            {
                return _selectedCharacter;
            }
            set
            {
                _selectedCharacter = value;
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            characterImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][0]}{(useRus ? "_rus.jpg" : ".jpg")}");
            bossItemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][1]}");
            flowerImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][2]}");
            goldGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][3]}");
            purpleGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][4]}");
            blueGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][5]}");
            greenGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][6]}");
            thirdMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][7]}");
            secondMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][8]}");
            firstMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][9]}");
            //characterPreview.Size = new Size(1080, 533);
        }

        private void CharacterSwapped()
        {
            UpdateBooks();
            UpdateBossItems();
            UpdateFlowers();
            UpdateGoldGems();
            UpdatePurpleGems();
            UpdateBlueGems();
            UpdateGreenGems();
            UpdateThirdMaterials();
            UpdateSecondMaterials();
            UpdateFirstMaterials();
            SaveConfig();
        }
        private void hu_taoButton_Click(object sender, EventArgs e)
        {
            selectedCharacter = 0;
            CharacterSwapped();
        }
        private void xiao_button_Click(object sender, EventArgs e)
        {
            selectedCharacter = 1;
            CharacterSwapped();
        }

        private void ganyuButton_Click(object sender, EventArgs e)
        {
            selectedCharacter = 2;
            CharacterSwapped();
        }

        private static int oneResinTime = 8;
        private static float minsPerBook = 35.5555555556f;
        private void UpdateBooks()
        {
            currentBooks = expBooks[selectedCharacter];
            expBookLabel.Text = $"{currentBooks}/432";
            var booksLeft = 432 - currentBooks;
            var totalSeconds = booksLeft * minsPerBook * 60;
            TimeSpan timeLeft = new TimeSpan(0, 0, (int)totalSeconds);
            expBookTimeLeft.Text = $"{string.Format("{0:0}", timeLeft.TotalDays)}d or {string.Format("{0:0}", timeLeft.TotalHours)}hrs";
            //int price = 40;
            //int oneTake = oneResinTime * price;
            //var bestMinutes = books / 10 * oneTake;
            //var midMinutes = books / 9 * oneTake;
            //var worstMinutes = books / 8 * oneTake;
            //TimeSpan bestTS = new TimeSpan(0, bestMinutes, 0);
            //TimeSpan midTS = new TimeSpan(0, midMinutes, 0);
            //TimeSpan worstTS = new TimeSpan(0, worstMinutes, 0);
            /*var best = $"{bestMinutes} минут(-ы) / {string.Format("{0:0.#}", bestTS.TotalHours)} час(-ов) / {string.Format("{0:0}", bestTS.TotalDays)} дня(-ей) {string.Format("{0:0.#}", (double.Parse($"0.{(bestTS.TotalDays.ToString().Contains(".") ? bestTS.TotalDays.ToString().Split('.')[1] : bestTS.TotalDays.ToString())}")) * 24)} час(-ов)";
            var worst = $"{worstMinutes} минут(-ы) / {string.Format("{0:0.#}", worstTS.TotalHours)} час(-ов) / {string.Format("{0:0}", worstTS.TotalDays)} дня(-ей) {string.Format("{0:0.#}", (double.Parse($"0.{(worstTS.TotalDays.ToString().Contains(".") ? worstTS.TotalDays.ToString().Split('.')[1] : worstTS.TotalDays.ToString())}")) * 24)} час(-ов)";
            Console.WriteLine($"Интервал:\nЛучший (5 книжек за 20 смолы/10 за 1 густую): {best}\nХудший (4 книжки за 20 смолы/8 за 1 густую): {worst}");*/

            /*var leftHrs = double.Parse(string.Format("{0:0}", timeLeft.TotalHours)) - (double.Parse(string.Format("{0:0}", timeLeft.TotalDays)) * 24);
            var leftMins = double.Parse(string.Format("{0:0}", timeLeft.TotalMinutes)) - (double.Parse(string.Format("{0:0}", timeLeft.TotalHours)) * 60);
            expBookTimeLeft.Text = $"{string.Format("{0:0}", timeLeft.TotalDays)}d " +
                $"{string.Format("{0:0}", remap((float)leftHrs, 12, -12, 23, 0))}hrs" +
                $"{string.Format("{0:0}", remap((float)leftMins, 30, -30, 59, 0))}mins";*/
        }
        internal static float remap(float value, float start1, float stop1, float start2, float stop2) => start2 + (stop2 - start2) * ((value - start1) / (stop1 - start1));

        public int currentBooks = 0;
        private void expBookPlusButton_Click(object sender, EventArgs e)
        {
            if (expBooks[selectedCharacter] >= 432)
                expBooks[selectedCharacter] = 432;
            else
                expBooks[selectedCharacter]++;
            UpdateBooks();
            SaveConfig();
        }

        private void expBookMinusButton_Click(object sender, EventArgs e)
        {
            if (expBooks[selectedCharacter] <= 0)
                expBooks[selectedCharacter] = 0;
            else
                expBooks[selectedCharacter]--;
            UpdateBooks();
            SaveConfig();
        }

        private void UpdateBossItems()
        {
            currentBossItems = bossItems[selectedCharacter];
            bossItemsLabel.Text = $"{currentBossItems}/46";
        }
        public int currentBossItems = 0;
        private void bossItemPlusButton_Click(object sender, EventArgs e)
        {
            if (bossItems[selectedCharacter] >= 46)
                bossItems[selectedCharacter] = 46;
            else
                bossItems[selectedCharacter]++;
            UpdateBossItems();
            SaveConfig();
        }

        private void bossItemMinusButton_Click(object sender, EventArgs e)
        {
            if (bossItems[selectedCharacter] <= 0)
                bossItems[selectedCharacter] = 0;
            else
                bossItems[selectedCharacter]--;
            UpdateBossItems();
            SaveConfig();
        }
        private void UpdateFlowers()
        {
            currentFlowers = flowers[selectedCharacter];
            flowersLabel.Text = $"{currentFlowers}/168";
        }
        public int currentFlowers = 0;

        private void flowerPlusButton_Click(object sender, EventArgs e)
        {
            if (flowers[selectedCharacter] >= 168)
                flowers[selectedCharacter] = 168;
            else
                flowers[selectedCharacter]++;
            UpdateFlowers();
            SaveConfig();
        }

        private void flowerMinusButton_Click(object sender, EventArgs e)
        {
            if (flowers[selectedCharacter] <= 0)
                flowers[selectedCharacter] = 0;
            else
                flowers[selectedCharacter]--;
            UpdateFlowers();
            SaveConfig();
        }

        private void UpdateGoldGems()
        {
            currentGoldGems = goldGems[selectedCharacter];
            goldGemLabel.Text = $"{currentGoldGems}/6";
        }
        public int currentGoldGems = 0;

        private void goldGemPlusButton_Click(object sender, EventArgs e)
        {
            if (goldGems[selectedCharacter] >= 6)
                goldGems[selectedCharacter] = 6;
            else
                goldGems[selectedCharacter]++;
            UpdateGoldGems();
            SaveConfig();
        }

        private void goldGemMinusButton_Click(object sender, EventArgs e)
        {
            if (goldGems[selectedCharacter] <= 0)
                goldGems[selectedCharacter] = 0;
            else
                goldGems[selectedCharacter]--;
            UpdateGoldGems();
            SaveConfig();
        }

        private void UpdatePurpleGems()
        {
            currentPurpleGems = purpleGems[selectedCharacter];
            purpleGemLabel.Text = $"{currentPurpleGems}/9";
        }
        public int currentPurpleGems = 0;

        private void purpleGemPlusButton_Click(object sender, EventArgs e)
        {
            if (purpleGems[selectedCharacter] >= 9)
                purpleGems[selectedCharacter] = 9;
            else
                purpleGems[selectedCharacter]++;
            UpdatePurpleGems();
            SaveConfig();
        }

        private void purpleGemMinusButton_Click(object sender, EventArgs e)
        {
            if (purpleGems[selectedCharacter] <= 0)
                purpleGems[selectedCharacter] = 0;
            else
                purpleGems[selectedCharacter]--;
            UpdatePurpleGems();
            SaveConfig();
        }

        private void UpdateBlueGems()
        {
            currentBlueGems = blueGems[selectedCharacter];
            blueGemLabel.Text = $"{currentBlueGems}/9";
        }
        public int currentBlueGems = 0;

        private void blueGemPlusButton_Click(object sender, EventArgs e)
        {
            if (blueGems[selectedCharacter] >= 9)
                blueGems[selectedCharacter] = 9;
            else
                blueGems[selectedCharacter]++;
            UpdateBlueGems();
            SaveConfig();
        }

        private void blueGemMinusButton_Click(object sender, EventArgs e)
        {
            if (blueGems[selectedCharacter] <= 0)
                blueGems[selectedCharacter] = 0;
            else
                blueGems[selectedCharacter]--;
            UpdateBlueGems();
            SaveConfig();
        }
        private void UpdateGreenGems()
        {
            currentGreenGems = greenGems[selectedCharacter];
            greenGemLabel.Text = $"{currentGreenGems}/1";
        }
        public int currentGreenGems = 0;

        private void greenGemPlusButton_Click(object sender, EventArgs e)
        {
            if (greenGems[selectedCharacter] >= 1)
                greenGems[selectedCharacter] = 1;
            else
                greenGems[selectedCharacter]++;
            UpdateGreenGems();
            SaveConfig();
        }

        private void greenGemMinusButton_Click(object sender, EventArgs e)
        {
            if (greenGems[selectedCharacter] <= 0)
                greenGems[selectedCharacter] = 0;
            else
                greenGems[selectedCharacter]--;
            UpdateGreenGems();
            SaveConfig();
        }

        private void UpdateThirdMaterials()
        {
            currentThirdMaterials = thirdMaterials[selectedCharacter];
            thirdMaterialLabel.Text = $"{currentThirdMaterials}/36";
        }
        public int currentThirdMaterials = 0;
        private void thirdMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (thirdMaterials[selectedCharacter] >= 36)
                thirdMaterials[selectedCharacter] = 36;
            else
                thirdMaterials[selectedCharacter]++;
            UpdateThirdMaterials();
            SaveConfig();
        }

        private void thirdMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (thirdMaterials[selectedCharacter] <= 0)
                thirdMaterials[selectedCharacter] = 0;
            else
                thirdMaterials[selectedCharacter]--;
            UpdateThirdMaterials();
            SaveConfig();
        }

        private void UpdateSecondMaterials()
        {
            currentSecondMaterials = secondMaterials[selectedCharacter];
            secondMaterialLabel.Text = $"{currentSecondMaterials}/30";
        }
        public int currentSecondMaterials = 0;

        private void secondMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (secondMaterials[selectedCharacter] >= 30)
                secondMaterials[selectedCharacter] = 30;
            else
                secondMaterials[selectedCharacter]++;
            UpdateSecondMaterials();
            SaveConfig();
        }

        private void secondMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (secondMaterials[selectedCharacter] <= 0)
                secondMaterials[selectedCharacter] = 0;
            else
                secondMaterials[selectedCharacter]--;
            UpdateSecondMaterials();
            SaveConfig();
        }

        private void UpdateFirstMaterials()
        {
            currentFirstMaterials = firstMaterials[selectedCharacter];
            firstMaterialLabel.Text = $"{currentFirstMaterials}/18";
        }
        public int currentFirstMaterials = 0;

        private void firstMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (firstMaterials[selectedCharacter] >= 18)
                firstMaterials[selectedCharacter] = 18;
            else
                firstMaterials[selectedCharacter]++;
            UpdateFirstMaterials();
            SaveConfig();
        }

        private void firstMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (firstMaterials[selectedCharacter] <= 0)
                firstMaterials[selectedCharacter] = 0;
            else
                firstMaterials[selectedCharacter]--;
            UpdateFirstMaterials();
            SaveConfig();
        }

        private void changeLang_Click(object sender, EventArgs e)
        {
            useRus = !useRus;
            changeLang.Text = useRus ? "Rus" : "Eng";
            SaveConfig();
            UpdateImage();
        }
    }
}
