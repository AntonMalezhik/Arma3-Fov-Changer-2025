using System;
using System.Diagnostics;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Arma3_Fov_Changer_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Публичная глобальная переменная с путем профиля
        public string global_arma3profile_file_path = "";

        // Нажатие на кнопку выбора файла
        private void GUI_btn_filechoose_Click(object sender, EventArgs e)
        {

            // Блокировака параметров (Защита от дурака)
            GUI_groupbox.Enabled = false;

            // Сбрасываем переменную пути
            global_arma3profile_file_path = "";

            // Сбрасываем текст
            GUI_profile_label.Text = "Выберите ваш профиль.arma3profile";

            // Открытие диалога выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                // Настройки диалогового окна
                openFileDialog.Title = "Выберите файл профиля Arma 3";
                openFileDialog.Filter = "Arma 3 Profile Files (*.Arma3Profile)|*.Arma3Profile";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Если файл выбран
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем выбранный файл
                    global_arma3profile_file_path = openFileDialog.FileName;

                    // Меняем текст выбора файла
                    GUI_profile_label.Text = Uri.UnescapeDataString(Path.GetFileName(global_arma3profile_file_path));

                    // ======================================

                    // Строчки необходимые для поиска в файле
                    string[] searchLines = { "fovTop=", "fovLeft=" };

                    // Читаем весь файл
                    string content = File.ReadAllText(global_arma3profile_file_path);

                    // Определяет, были ли найдены сразу две строки или нет
                    bool allLinesFound = true;

                    // Потерянные строки
                    string missingLines = "";

                    // Перебираем все строчки
                    foreach (var line in searchLines)
                    {

                        // Если строчка не содержанала нужное слово
                        if (!content.Contains(line))
                        {

                            // Обновляем статусы
                            allLinesFound = false;
                            missingLines += line + "\n";
                        }
                    }

                    // Файл не верен и не содержит строчки для изменения FOV
                    if (!allLinesFound)
                    {

                        // Уведомление пользователя
                        MessageBox.Show("К сожалению вы выбрали не тот файл профиля, убедитесь что выбераете файл профиля без .eden и .vars в названии", "Неверный файл профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    // Все хорошо, строчки найдены, fov возможно изменить
                    else
                    {

                        // Запись в хранилище
                        Properties.Settings.Default.savedPath = global_arma3profile_file_path; Properties.Settings.Default.Save();

                        // Разблокировка параметров
                        GUI_groupbox.Enabled = Enabled;

                    }
                }
            }
        }

        // Процедура кулькулирования результата и сохранение его в файл профиля
        private async Task calculateAndSave(string global_arma3profile_file_path)
        {

            // Переменные для записи в файл
            string fovTop, fovLeft;

            // Создаем словарь для хранения значений FOV для каждого разрешения
            Dictionary<string, Dictionary<string, (string fovTop, string fovLeft)>> fovValues = new()
            {
                ["7680×4320"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["3840×2160"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["3100×1440"] = new() {
                    ["120"] = ("1.07", "2.31"),
                    ["110"] = ("0.88", "1.90"),
                    ["100"] = ("0.74", "1.59"),
                    ["90"] = ("0.62", "1.33"),
                    ["80"] = ("0.52", "1.12"),
                    ["70"] = ("0.43", "0.93")
                },

                ["2560×1440"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["1920×1080"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["1366×768"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["1280×720"] = new() {
                    ["120"] = ("1.30", "2.31"),
                    ["110"] = ("1.07", "1.90"),
                    ["100"] = ("0.89", "1.59"),
                    ["90"] = ("0.75", "1.33"),
                    ["80"] = ("0.63", "1.12"),
                    ["70"] = ("0.53", "0.93")
                },

                ["640×480"] = new() {
                    ["120"] = ("1.73", "2.31"),
                    ["110"] = ("1.43", "1.90"),
                    ["100"] = ("1.19", "1.59"),
                    ["90"] = ("1.00", "1.33"),
                    ["80"] = ("0.84", "1.12"),
                    ["70"] = ("0.70", "0.93")
                },

            };

            // Получаем значения
            string selectedResolution = GUI_combo_screen.Text;
            string selectedFov = GUI_combo_fov.Text;

            // Проверяем, находим и ищем два значения в словаре
            if (fovValues.TryGetValue(selectedResolution, out var resolutionFovs) &&
                resolutionFovs.TryGetValue(selectedFov, out var fov))
            {
                
                // Устанавливаем значения из словаря
                fovTop = fov.fovTop; fovLeft = fov.fovLeft;

                try
                {
                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(global_arma3profile_file_path);

                    // Найденные строчки
                    bool fovLeftFound = false; bool fovTopFound = false;

                    // Проходим по всем строкам и ищем нужные параметры
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("fovLeft="))
                        {
                            lines[i] = $"fovLeft={fovLeft}";
                            fovLeftFound = true;
                        }
                        else if (lines[i].StartsWith("fovTop="))
                        {
                            lines[i] = $"fovTop={fovTop}";
                            fovTopFound = true;
                        }

                        // Если оба параметра найдены, можно выйти из цикла
                        if (fovLeftFound && fovTopFound)

                            // Выход из цикла
                            break;
                    }

                    // Если не все параметры найдены
                    if (!fovLeftFound || !fovTopFound)
                    {
                        List<string> linesList = new List<string>(lines);
                        if (!fovLeftFound)

                            // Добавляем новые значения
                            linesList.Add($"fovLeft={fovLeft}");

                        if (!fovTopFound)

                            // Добавляем новые значения
                            linesList.Add($"fovTop={fovTop}");

                        // Все строки файла
                        lines = linesList.ToArray();
                    }

                    // Записываем изменения обратно в файл
                    File.WriteAllLines(global_arma3profile_file_path, lines);

                    // Выходим из функции
                    return;

                } catch (Exception ex) {

                    // Уведомление пользователя
                    MessageBox.Show($"При записи новых значений для FOV в выбранный вами профиль произошла ошибка (Вероятнее всего вы не закрыли игру или файл профиля занят другой программой): {ex.Message}", "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            } else {

                // Обработка случая, когда разрешение или FOV не найдены
                MessageBox.Show("К сожалению программа не нашла скалькулированных данных по вашим параметрам, приношу извинения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Выходим из функции
                return;
            }

        }

        // Сохранение результата в файл профиля
        private async void GUI_btn_save_Click(object sender, EventArgs e)
        {

            // Делаем проверку на то, что пользователь выбрал нужные параметры
            if (GUI_combo_fov.SelectedIndex != -1 && GUI_combo_screen.SelectedIndex != -1)
            {

                // Если включено резервное копирование на рабочий стол
                if (GUI_checkbox_bakup.Checked)
                {

                    // Получаем путь к рабочему столу текущего пользователя
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // Формируем путь для копии файла на рабочем столе
                    string destinationFilePath = Path.Combine(desktopPath, Path.GetFileName(global_arma3profile_file_path));

                    // Копируем файл
                    File.Copy(global_arma3profile_file_path, destinationFilePath, overwrite: true);

                }

                // Калькулируем и сохраняем файл
                await calculateAndSave(global_arma3profile_file_path);

                // Запоминаем текст
                string savebtn_text = GUI_btn_save.Text;

                // Делаем ее неактивной
                GUI_btn_save.Enabled = false;

                // Устанавливаем текст
                GUI_btn_save.Text = "✔️ Успешно!";

                // Ждем полторы секунды
                await Task.Delay(1500);

                // Возвращаем активность
                GUI_btn_save.Enabled = Enabled;

                // Возвращаем текст
                GUI_btn_save.Text = savebtn_text;

            } else {

                // Уведомление пользователю
                MessageBox.Show("К сожалению вы не выбрали все параметры, пожалуйста выберите", "Недостаточно параметров", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        // Когда форма появилась
        private void Form1_Shown(object sender, EventArgs e)
        {

            // Проверка, пустое ли значение или нет
            if (!string.IsNullOrEmpty(Properties.Settings.Default.savedPath))
            {

                // Получаем прошлый путь
                string pathWithSettings = Properties.Settings.Default.savedPath;

                // Проверяем все еще существование файла профиля
                if (File.Exists(Properties.Settings.Default.savedPath))
                {

                    // Указываем новый путь из хранилища для профиля
                    global_arma3profile_file_path = Properties.Settings.Default.savedPath;

                    // Меняем текст выбора файла
                    GUI_profile_label.Text = Uri.UnescapeDataString(Path.GetFileName(global_arma3profile_file_path));

                    // Разблокировка параметров
                    GUI_groupbox.Enabled = Enabled;

                }

                try
                {

                    // Установка FOV
                    GUI_combo_fov.SelectedIndex = Properties.Settings.Default.savedFov;

                    // Установка разрешения
                    GUI_combo_screen.SelectedIndex = Properties.Settings.Default.savedScreen;

                }
                catch
                {

                    // Установка FOV
                    GUI_combo_fov.SelectedIndex = 0;

                    // Установка разрешения
                    GUI_combo_screen.SelectedIndex = 0;

                }


            }


        }

        // Выбор элемента в Combobox (в двух), событие
        private void ComboboxSelectIndex(object sender, EventArgs e)
        {

            // Запись в хранилище
            Properties.Settings.Default.savedScreen = GUI_combo_screen.SelectedIndex;
            Properties.Settings.Default.savedFov = GUI_combo_fov.SelectedIndex;

            // Сохраняем
            Properties.Settings.Default.Save();

        }

        // Нажатие на посетить GitHub
        private void GUI_label_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Переходим на сайт
            Process.Start("explorer", "https://github.com/AntonMalezhik");

        }

        // Нажатие на посетить Itch.io
        private void GUI_label_link_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Переходим на веб сайт
            Process.Start("explorer", "https://joblab-studio.itch.io");

        }
    }
}
