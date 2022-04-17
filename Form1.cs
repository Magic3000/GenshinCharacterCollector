using Newtonsoft.Json;
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

            var c = 0;
            try { c = int.Parse(Config["SelectedCharacter"].ToString()); }
            catch { }

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

                try { greenTalents[i] = int.Parse(Config[$"{i}_green_talents"].ToString()); }
                catch { greenTalents[i] = 0; }
                try { blueTalents[i] = int.Parse(Config[$"{i}_blue_talents"].ToString()); }
                catch { blueTalents[i] = 0; }
                try { purpleTalents[i] = int.Parse(Config[$"{i}_purple_talents"].ToString()); }
                catch { purpleTalents[i] = 0; }
                try { crowns[i] = int.Parse(Config[$"{i}_crowns"].ToString()); }
                catch { crowns[i] = 0; }

                try { thirdTalentMaterials[i] = int.Parse(Config[$"{i}_third_talent_materials"].ToString()); }
                catch { thirdTalentMaterials[i] = 0; }
                try { secondTalentMaterials[i] = int.Parse(Config[$"{i}_second_talent_materials"].ToString()); }
                catch { secondTalentMaterials[i] = 0; }
                try { firstTalentMaterials[i] = int.Parse(Config[$"{i}_first_talent_materials"].ToString()); }
                catch { firstTalentMaterials[i] = 0; }
                try { talentBossItems[i] = int.Parse(Config[$"{i}_talent_boss_items"].ToString()); }
                catch { talentBossItems[i] = 0; }
                try { totalMora[i] = Config[$"{i}_total_mora"].ToString(); }
                catch { totalMora[i] = "0"; }
            }
            try { useRus = int.Parse(Config[$"UseRus"].ToString()) == 1; }
            catch { useRus = false; }
            try { moraType = int.Parse(Config[$"MoraType"].ToString()); }
            catch { moraType = 0; }
            moraTypeDropMenu.Text = moraTypeDropMenu.Items[moraType].ToString();
            UpdateMora();
            /*currentBooks = expBooks[selectedCharacter];
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

            currentGreenTalents = greenTalents[selectedCharacter];
            greenTalentLabel.Text = $"{currentGreenTalents}/9";
            currentBlueTalents = blueTalents[selectedCharacter];
            blueTalentLabel.Text = $"{currentBlueTalents}/63";
            currentPurpleTalents = purpleTalents[selectedCharacter];
            purpleTalentLabel.Text = $"{currentPurpleTalents}/114";
            currentCrowns = crowns[selectedCharacter];
            crownLabel.Text = $"{currentCrowns}/3";

            currentFirstTalentMaterials = firstTalentMaterials[selectedCharacter];
            firstTalentMaterialLabel.Text = $"{currentFirstTalentMaterials}/18";

            currentSecondTalentMaterials = secondTalentMaterials[selectedCharacter];
            secondTalentMaterialLabel.Text = $"{currentSecondTalentMaterials}/66";

            currentThirdTalentMaterials = thirdTalentMaterials[selectedCharacter];
            thirdTalentMaterialLabel.Text = $"{currentThirdTalentMaterials}/93";

            currentTalentBossItems = talentBossItems[selectedCharacter];
            talentBossItemLabel.Text = $"{currentTalentBossItems}/18";*/

            changeLang.Text = useRus ? "Rus" : "Eng";
            charactersDropMenu.Items.Clear();
            charactersDropMenu.Items.AddRange(characterNames[useRus ? 1 : 0].ToArray());

            CharacterSwapped(c);
        }

        public void SaveConfig()
        {
            Config["UseRus"] = useRus ? 1 : 0;
            Config["SelectedCharacter"] = selectedCharacter;
            Config["MoraType"] = moraType;
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

                Config[$"{i}_green_talents"] = greenTalents[i];
                Config[$"{i}_blue_talents"] = blueTalents[i];
                Config[$"{i}_purple_talents"] = purpleTalents[i];
                Config[$"{i}_crowns"] = crowns[i];
                Config[$"{i}_third_talent_materials"] = thirdTalentMaterials[i];
                Config[$"{i}_second_talent_materials"] = secondTalentMaterials[i];
                Config[$"{i}_first_talent_materials"] = firstTalentMaterials[i];
                Config[$"{i}_talent_boss_items"] = talentBossItems[i];
                Config[$"{i}_total_mora"] = totalMora[i];
            }
            File.WriteAllText(configPath, JsonConvert.SerializeObject(Config));
        }

        public List<List<string>> characterNames = new List<List<string>>()
        {
            new List<string>() { "Hu Tao", "Xiao", "Ganyu", "Yelan" },
            new List<string>() { "Ху Тао", "Сяо", "Гань Юй", "Е Лань" }
        };
        public List<string[]> characterBanners = new List<string[]>()
        {
            new string[] { "2021-03-02-MomentOfBloom", "juvenile_jade.png", "silk_flower.png",
                "pyro_gold_gem.png", "pyro_purple_gem.png", "pyro_blue_gem.png", "pyro_green_gem.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png",
                "teachings_of_diligence.png", "guide_to_diligence.png", "philosophies_of_diligence.png", "crown_of_insight.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png", "shard_of_a_foul_legacy.png", "#E5451E" },
            new string[] { "2021-02-03_Invitation_to_Mundane_Life", "juvenile_jade.png", "qingxin.png",
                "anemo_gold_gem.png", "anemo_purple_gem.png", "anemo_blue_gem.png", "anemo_green_gem.png",
                "slime_concentrate.png", "slime_secretions.png", "slime_condensate.png",
                "teachings_of_prosperity.png", "guide_to_prosperity.png", "philosophies_of_prosperity.png", "crown_of_insight.png",
                "slime_concentrate.png", "slime_secretions.png", "slime_condensate.png", "shadow_of_the_warrior.png", "#137075" },
            new string[] { "2021-01-13_Adrift_in_the_Harbor", "hoarfrost_core.png", "qingxin.png",
                "cryo_gold_gem.png", "cryo_purple_gem.png", "cryo_blue_gem.png", "cryo_green_gem.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png",
                "teachings_of_diligence.png", "guide_to_diligence.png", "philosophies_of_diligence.png", "crown_of_insight.png",
                "energy_nectar.png", "shimmering_nectar.png", "whopperflower_nectar.png", "shadow_of_the_warrior.png", "#34AACE" },
            new string[] { "yelan", "runic_fang.png", "starconch.png",
                "hydro_gold_gem.png", "hydro_purple_gem.png", "hydro_blue_gem.png", "hydro_green_gem.png",
                "lieutenants_insignia.png", "sergeants_insignia.png", "recruits_insignia.png",
                "teachings_of_prosperity.png", "guide_to_prosperity.png", "philosophies_of_prosperity.png", "crown_of_insight.png",
                "lieutenants_insignia.png", "sergeants_insignia.png", "recruits_insignia.png", "gilded_scale.png", "#3479ce" },
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
        public Dictionary<int, int> greenTalents = new Dictionary<int, int>();
        public Dictionary<int, int> blueTalents = new Dictionary<int, int>();
        public Dictionary<int, int> purpleTalents = new Dictionary<int, int>();
        public Dictionary<int, int> crowns = new Dictionary<int, int>();
        public Dictionary<int, int> thirdTalentMaterials = new Dictionary<int, int>();
        public Dictionary<int, int> secondTalentMaterials = new Dictionary<int, int>();
        public Dictionary<int, int> firstTalentMaterials = new Dictionary<int, int>();
        public Dictionary<int, int> talentBossItems = new Dictionary<int, int>();
        public Dictionary<int, string> totalMora = new Dictionary<int, string>();

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
                charactersDropMenu.Text = charactersDropMenu.Items[value].ToString();
            }
        }

        private void UpdateImage()
        {
            this.BackgroundImage = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][0]}{(useRus ? "_rus.jpg" : ".jpg")}");
            //characterImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][0]}{(useRus ? "_rus.jpg" : ".jpg")}");
            bossItemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][1]}");
            flowerImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][2]}");
            goldGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][3]}");
            purpleGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][4]}");
            blueGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][5]}");
            greenGemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][6]}");
            thirdMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][7]}");
            secondMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][8]}");
            firstMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][9]}");

            greenTalentImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][10]}");
            blueTalentImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][11]}");
            purpleTalentImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][12]}");
            crownImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][13]}");
            thirdTalentMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][14]}");
            secondTalentMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][15]}");
            firstTalentMaterialImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][16]}");
            talentBossItemImage.Image = Image.FromFile($"{texturesPath}{characterBanners[selectedCharacter][17]}");
            typeof(Form1).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.FieldType == typeof(Button)).ToList().ForEach(y =>
            {
                var characterColor = ColorTranslator.FromHtml(characterBanners[selectedCharacter][18]);
                var btn = ((Button)y.GetValue(this));
                btn.ForeColor = characterColor;
                btn.BackColor = Lerp(characterColor, Color.Black, 0.6f);
                btn.FlatAppearance.BorderColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.White;
                btn.FlatAppearance.MouseOverBackColor = Lerp(characterColor, Color.White, 0.6f);
            });
            typeof(Form1).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.FieldType == typeof(Label)).ToList().ForEach(y =>
            {
                var characterColor = ColorTranslator.FromHtml(characterBanners[selectedCharacter][18]);
                var lbl = ((Label)y.GetValue(this));
                lbl.ForeColor = Color.Black;
                lbl.BackColor = Lerp(characterColor, Color.White, 0.6f);
            });
            typeof(Form1).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.FieldType == typeof(ComboBox)).ToList().ForEach(y =>
            {
                var characterColor = ColorTranslator.FromHtml(characterBanners[selectedCharacter][18]);
                var cb = ((ComboBox)y.GetValue(this));
                cb.ForeColor = Color.Black;
                cb.BackColor = Lerp(characterColor, Color.White, 0.6f);
            });
            typeof(Form1).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.FieldType == typeof(TextBox)).ToList().ForEach(y =>
            {
                var characterColor = ColorTranslator.FromHtml(characterBanners[selectedCharacter][18]);
                var tb = ((TextBox)y.GetValue(this));
                tb.ForeColor = Color.Black;
                tb.BackColor = Lerp(characterColor, Color.White, 0.6f);
            });
            //characterPreview.Size = new Size(1080, 533);
        }

        public Color Lerp(Color s, Color t, float k)
        {
            var bk = (1 - k);
            var a = s.A * bk + t.A * k;
            var r = s.R * bk + t.R * k;
            var g = s.G * bk + t.G * k;
            var b = s.B * bk + t.B * k;
            return Color.FromArgb((int)a, (int)r, (int)g, (int)b);
        }

        public float Lerp(float s, float t, float k)
        {
            var bk = (1 - k);
            return s * bk + t * k;
        }

        private void CharacterSwapped(int newCharacter)
        {
            selectedCharacter = newCharacter;
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
            UpdateGreenTalents();
            UpdateBlueTalents();
            UpdatePurpleTalents();
            UpdateCrowns();
            UpdateFirstTalentMaterial();
            UpdateSecondTalentMaterial();
            UpdateThirdTalentMaterial();
            UpdateTalentBossItems();
            UpdateMora();
            SaveConfig();
        }
        /*private void hu_taoButton_Click(object sender, EventArgs e)
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
        }*/

        //private static int oneResinTime = 8;
        private static float minsPerBook = 35.5555555556f;
        private void UpdateBooks()
        {
            currentBooks = expBooks[selectedCharacter];
            expBookLabel.Text = $"{currentBooks}/432";
            var booksLeft = 432 - currentBooks;
            var totalSeconds = booksLeft * minsPerBook * 60;
            TimeSpan timeLeft = new TimeSpan(0, 0, (int)totalSeconds);
            expBookTimeLeft.Text = $"{string.Format("{0:0}", timeLeft.TotalDays)}{(useRus ? "д" : "d")} or {string.Format("{0:0}", timeLeft.TotalHours)}{(useRus ? "ч" : "h")}";
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
            charactersDropMenu.Items.Clear();
            charactersDropMenu.Items.AddRange(characterNames[useRus ? 1 : 0].ToArray());
            charactersDropMenu.Text = charactersDropMenu.Items[selectedCharacter].ToString();
            SaveConfig();
            UpdateImage();
        }

        private void charactersDropMenu_SelectedIndexChanged(object sender, EventArgs e) => CharacterSwapped(charactersDropMenu.Items.IndexOf(charactersDropMenu.SelectedItem.ToString()));

        private List<string> charactersHoneyLinks = new List<string>()
        {
            "https://genshin.honeyhunterworld.com/db/char/hutao/?lang=",
            "https://genshin.honeyhunterworld.com/db/char/xiao/?lang=",
            "https://genshin.honeyhunterworld.com/db/char/ganyu/?lang="
        };

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e) => Process.Start($"{charactersHoneyLinks[selectedCharacter]}{(useRus ? "RU" : "EN")}");

        private void UpdateGreenTalents()
        {
            currentGreenTalents = greenTalents[selectedCharacter];
            greenTalentLabel.Text = $"{currentGreenTalents}/9";
        }
        public int currentGreenTalents = 0;
        private void greenTalentPlusButton_Click(object sender, EventArgs e)
        {
            if (greenTalents[selectedCharacter] >= 9)
                greenTalents[selectedCharacter] = 9;
            else
                greenTalents[selectedCharacter]++;
            UpdateGreenTalents();
            SaveConfig();
        }

        private void greenTalentMinusButton_Click(object sender, EventArgs e)
        {
            if (greenTalents[selectedCharacter] <= 0)
                greenTalents[selectedCharacter] = 0;
            else
                greenTalents[selectedCharacter]--;
            UpdateGreenTalents();
            SaveConfig();
        }

        private void UpdateBlueTalents()
        {
            currentBlueTalents = blueTalents[selectedCharacter];
            blueTalentLabel.Text = $"{currentBlueTalents}/63";
        }
        public int currentBlueTalents = 0;
        private void blueTalentPlusButton_Click(object sender, EventArgs e)
        {
            if (blueTalents[selectedCharacter] >= 63)
                blueTalents[selectedCharacter] = 63;
            else
                blueTalents[selectedCharacter]++;
            UpdateBlueTalents();
            SaveConfig();
        }

        private void blueTalentMinusButton_Click(object sender, EventArgs e)
        {
            if (blueTalents[selectedCharacter] <= 0)
                blueTalents[selectedCharacter] = 0;
            else
                blueTalents[selectedCharacter]--;
            UpdateBlueTalents();
            SaveConfig();
        }
        private void UpdatePurpleTalents()
        {
            currentPurpleTalents = purpleTalents[selectedCharacter];
            purpleTalentLabel.Text = $"{currentPurpleTalents}/114";
        }
        public int currentPurpleTalents = 0;

        private void purpleTalentPlusButton_Click(object sender, EventArgs e)
        {
            if (purpleTalents[selectedCharacter] >= 114)
                purpleTalents[selectedCharacter] = 114;
            else
                purpleTalents[selectedCharacter]++;
            UpdatePurpleTalents();
            SaveConfig();
        }

        private void purpleTalentMinusButton_Click(object sender, EventArgs e)
        {
            if (purpleTalents[selectedCharacter] <= 0)
                purpleTalents[selectedCharacter] = 0;
            else
                purpleTalents[selectedCharacter]--;
            UpdatePurpleTalents();
            SaveConfig();
        }
        private void UpdateCrowns()
        {
            currentCrowns = crowns[selectedCharacter];
            crownLabel.Text = $"{currentCrowns}/3";
        }
        public int currentCrowns = 0;

        private void crownPlusButton_Click(object sender, EventArgs e)
        {
            if (crowns[selectedCharacter] >= 3)
                crowns[selectedCharacter] = 3;
            else
                crowns[selectedCharacter]++;
            UpdateCrowns();
            SaveConfig();
        }

        private void crownMinusButton_Click(object sender, EventArgs e)
        {
            if (crowns[selectedCharacter] <= 0)
                crowns[selectedCharacter] = 0;
            else
                crowns[selectedCharacter]--;
            UpdateCrowns();
            SaveConfig();
        }

        private void UpdateFirstTalentMaterial()
        {
            currentFirstTalentMaterials = firstTalentMaterials[selectedCharacter];
            firstTalentMaterialLabel.Text = $"{currentFirstTalentMaterials}/18";
        }
        public int currentFirstTalentMaterials = 0;
        private void firstTalentMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (firstTalentMaterials[selectedCharacter] >= 18)
                firstTalentMaterials[selectedCharacter] = 18;
            else
                firstTalentMaterials[selectedCharacter]++;
            UpdateFirstTalentMaterial();
            SaveConfig();
        }

        private void firstTalentMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (firstTalentMaterials[selectedCharacter] <= 0)
                firstTalentMaterials[selectedCharacter] = 0;
            else
                firstTalentMaterials[selectedCharacter]--;
            UpdateFirstTalentMaterial();
            SaveConfig();
        }

        private void UpdateSecondTalentMaterial()
        {
            currentSecondTalentMaterials = secondTalentMaterials[selectedCharacter];
            secondTalentMaterialLabel.Text = $"{currentSecondTalentMaterials}/66";
        }
        public int currentSecondTalentMaterials = 0;
        private void secondTalentMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (secondTalentMaterials[selectedCharacter] >= 66)
                secondTalentMaterials[selectedCharacter] = 66;
            else
                secondTalentMaterials[selectedCharacter]++;
            UpdateSecondTalentMaterial();
            SaveConfig();
        }

        private void secondTalentMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (secondTalentMaterials[selectedCharacter] <= 0)
                secondTalentMaterials[selectedCharacter] = 0;
            else
                secondTalentMaterials[selectedCharacter]--;
            UpdateSecondTalentMaterial();
            SaveConfig();
        }

        private void UpdateThirdTalentMaterial()
        {
            currentThirdTalentMaterials = thirdTalentMaterials[selectedCharacter];
            thirdTalentMaterialLabel.Text = $"{currentThirdTalentMaterials}/93";
        }
        public int currentThirdTalentMaterials = 0;
        private void thirdTalentMaterialPlusButton_Click(object sender, EventArgs e)
        {
            if (thirdTalentMaterials[selectedCharacter] >= 93)
                thirdTalentMaterials[selectedCharacter] = 93;
            else
                thirdTalentMaterials[selectedCharacter]++;
            UpdateThirdTalentMaterial();
            SaveConfig();
        }

        private void thirdTalentMaterialMinusButton_Click(object sender, EventArgs e)
        {
            if (thirdTalentMaterials[selectedCharacter] <= 0)
                thirdTalentMaterials[selectedCharacter] = 0;
            else
                thirdTalentMaterials[selectedCharacter]--;
            UpdateThirdTalentMaterial();
            SaveConfig();
        }

        private void UpdateTalentBossItems()
        {
            currentTalentBossItems = talentBossItems[selectedCharacter];
            talentBossItemLabel.Text = $"{currentTalentBossItems}/18";
        }
        public int currentTalentBossItems = 0;
        private void talentBossItemPlusButton_Click(object sender, EventArgs e)
        {
            if (talentBossItems[selectedCharacter] >= 18)
                talentBossItems[selectedCharacter] = 18;
            else
                talentBossItems[selectedCharacter]++;
            UpdateTalentBossItems();
            SaveConfig();
        }

        private void talentBossItemMinusButton_Click(object sender, EventArgs e)
        {
            if (talentBossItems[selectedCharacter] <= 0)
                talentBossItems[selectedCharacter] = 0;
            else
                talentBossItems[selectedCharacter]--;
            UpdateTalentBossItems();
            SaveConfig();
        }

        private void calculateChanceButton_Click(object sender, EventArgs e)
        {
            var primos = calculateChanceText.Text;
            if (!int.TryParse(primos, out int num))
            {
                calculateChanceLabel.Text = "Error";
                return;
            }
            var wishes = num / 160;
            float chance = 0;
            int pity = 0;
            for (int i = 0; i < wishes; i++)
            {
                if (pity < 75)
                {
                    pity++;
                    chance += 0.6f;
                }
                else
                {
                    if (chance < 100)
                        chance += Lerp(0.6f, 100f, remap(pity, 75, 90, 0, 1));
                    pity++;
                }
            }
            if (chance >= 100)
                chance = 100;
            calculateChanceLabel.Text = string.Format("{0:0.00}{1} ({2})", chance, (wishes >= 75 ? $"~ {(string.Format("{0:0.00}%", Lerp(0.6f, 100f, remap(wishes, 75, 90, 0, 1))))}" : "%"), wishes);
        }

        private void UpdateMoraTimeLeft()
        {
            if (int.TryParse(totalMora[selectedCharacter], out int currentMora) && int.TryParse(moraLabel.Text.Replace(".", "").Replace("from", "").Trim(), out int totallMora))
            {
                var moraLeft = totallMora - currentMora;
                var totalSeconds = moraLeft * minsPerMora * 60;
                TimeSpan timeLeft = new TimeSpan(0, 0, (int)totalSeconds);
                moraTimeLeft.Text = $"{string.Format("{0:0}", timeLeft.TotalDays)}{(useRus ? "д" : "d")} or {string.Format("{0:0}", timeLeft.TotalHours)}{(useRus ? "ч" : "h")}";
            }
            else
                moraTimeLeft.Text = $"Error 1st-arg: {totalMora[selectedCharacter]} 2nd-arg: {moraLabel.Text.Replace(".", "").Replace("from", "").Trim()}";
        }
        private void moraText_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inStr = moraText.Text;
            var asd = e.KeyChar == (char)Keys.Back ? inStr.Remove(inStr.Length - 1) : $"{inStr}{e.KeyChar}";
            totalMora[selectedCharacter] = asd;
            SaveConfig();
            UpdateMoraTimeLeft();
        }

        private static float minsPerMora = 0.00266666666f;
        public void UpdateMora()
        {
            moraText.Text = totalMora[selectedCharacter];
            moraLabel.Text = moraType == 0 ? "from 2.092.000" : moraType == 1 ? "from 4.950.000" : "from 7.042.000";
            UpdateMoraTimeLeft();
        }
        public int moraType;
        private void moraTypeDropMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            moraType = moraTypeDropMenu.Items.IndexOf(moraTypeDropMenu.SelectedItem.ToString());
            SaveConfig();
            UpdateMora();
        }
    }
}
