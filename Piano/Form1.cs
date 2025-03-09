using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {

        Melody melody;

        public Form1()
        {
            InitializeComponent();
            melody = new Melody();
        }

        private RadioButton get_duration()
        {
            // Реалізувати повернення з методу елементу керування RadioButton, для 
            // встановлена властивість Checked в true, обираючи серед елементів керування
            // RadioButton, які належать panel_duration
            for (int i = 0; i < panel_duration.Controls.Count; i++)
            {
                RadioButton toCheck = (RadioButton)panel_duration.Controls[i];
                if (toCheck.Checked) return toCheck;
            }
            return null;
        }

        private void btn_key_Click(object sender, EventArgs e)
        {
            // Оголосити змінну btn_key, типу даних Button, ініціалізувати значенням sender
            Button btn_key = (Button)sender;
            // Оголосити змінну note, типу даних Note, ініціалізувати конструктором з параметрами
            Note note = new Note(btn_key.Name, get_duration().Name);
            // Визвати метод Sound для змінної note
            note.Sound();
            // Реалізувати додавання в melody за допомогою метода AddNote ноту
            melody.AddNote(btn_key.Name, get_duration().Name);
            // Оголосити змінну btn_note, типу даних Button
            Button btn_note = new Button();
            // Встановити властивість Size для змінної btn_note
            btn_note.Size = new Size(72, 23);
            // Встановити властивість Name для змінної btn_note, як номер ноти в мелодії
            btn_note.Name = Convert.ToString(panel_melody.Controls.Count);
            // Встановити властивість Text для змінної btn_note, у форматі нота та тривалість
            btn_note.Text = $"{btn_key.Text} {get_duration().Text}";
            // Встановити подію Click для змінної btn_note, як btn_note_Click
            btn_note.Click += btn_note_Click;
            // Реалізувати додавання змінної btn_note на panel_melody
            panel_melody.Controls.Add(btn_note);
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            // Оголосити змінну btn_key, типу даних Button, ініціалізувати значенням sender
            Button btn_key = (Button)sender;
            // Оголосити змінну idx, типу даних int, ініціалізувати властивістю Name від btn_key
            int idx = Convert.ToInt32(btn_key.Name);
            // Реалізувати видалення з melody ноту за допомогою метода RemoveNote
            melody.RemoveNote(idx);
            // Реалізувати видалення змінної btn_key з panel_melody
            panel_melody.Controls.Remove(btn_key);
            // Реалізувати циклічне звернення до кожного елементу на panel_melody, що розташовані
            // після елементу під номером idx, та для властивості Name, що зберігає номер
            // ноти в мелодії, зменшити значення на одиницю
            for (int i = idx; i < panel_melody.Controls.Count; i++)
            {
                panel_melody.Controls[i].Name = Convert.ToString(i);
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            // Реалізувати видалення всіх елементів керування з panel_melody
            panel_melody.Controls.Clear();
            // Реалізувати початкову ініціалізацію змінної melody
            melody = new Melody();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            // Реалізувати запуск події playMelody для змінної melody
            melody.OnPlayMelody();
        }
    }
}
