using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    delegate void PlayNotes();

    class Melody
    {
        Note[] notes;
        PlayNotes[] playNotes;

        public Melody()
        {
            notes = new Note[0];
            playNotes = new PlayNotes[0];
        }

        public event PlayNotes playMelody
        {
            add
            {
                // Реалізувати додавання обробника події в масив делегатів playNotes
                PlayNotes[] tempPlayNotes = playNotes;
                playNotes = new PlayNotes[tempPlayNotes.Length + 1];
                for (int i = 0; i < tempPlayNotes.Length; i++)
                {
                    playNotes[i] = tempPlayNotes[i];
                }
                playNotes[playNotes.Length - 1] = value;
            }
            remove
            {
                // Реалізувати видалення обробника події з масиву делегатів playNotes
                PlayNotes[] tempPlayNotes = playNotes;
                int removeIndex = 0;
                for (int i = 0; i < playNotes.Length; i++)
                {
                    if (playNotes[i] == value)
                    {
                        removeIndex = i;
                    }
                }
                playNotes = new PlayNotes[tempPlayNotes.Length - 1];
                for (int i = 0; i < removeIndex; i++)
                {
                    playNotes[i] = tempPlayNotes[i];
                }
                for (int i = removeIndex; i < playNotes.Length; i++)
                {
                    playNotes[i] = tempPlayNotes[i + 1];
                }
            }
        }

        public void OnPlayMelody()
        {
            // Реалізувати циклічне звернення до елементів масиву делегатів playNotes для
            // виклику по черзі кожного обробника події
            for (int i = 0; i < playNotes.Length; i++)
            {
                playNotes[i]();
            }
        }

        public void AddNote(string t, string d)
        {
            // Оголосити змінну note, типу даних Note, ініціалізувати параметрами t та d
            Note note = new Note(t, d);
            // Реалізувати додавання в подію playMelody методу Sound для note
            playMelody += note.Sound;
            // Реалізувати додавання note до масиву нот notes
            Note[] tempNotes = notes;
            notes = new Note[tempNotes.Length + 1];
            for (int i = 0; i < tempNotes.Length; i++)
            {
                notes[i] = tempNotes[i];
            }
            notes[notes.Length - 1] = note;
        }

        public void RemoveNote(int idx)
        {
            // Оголосити змінну note, типу даних Note, обрану з масиву нот за idx
            Note note = notes[idx];
            // Реалізувати видалення з події playMelody методу Sound для note
            playMelody -= note.Sound;
            // Реалізувати видалення note до масиву нот notes
            Note[] tempNotes = notes;
            notes = new Note[tempNotes.Length - 1];
            for (int i = 0; i < idx; i++)
            {
                notes[i] = tempNotes[i];
            }
            for (int i = idx; i < notes.Length; i++)
            {
                notes[i] = tempNotes[i + 1];
            }
        }
    }
}
