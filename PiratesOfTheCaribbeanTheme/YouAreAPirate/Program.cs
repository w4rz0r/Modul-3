class Sample
{
    public static void Main()
    {
        Note[] Mary =
        {
        //number one
        new Note(Tone.NOTE_E4, Duration.SHORT),
        new Note(Tone.NOTE_G4, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.NOTE_C5, Duration.MEDIUM),
        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.NOTE_D5, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.MEDIUM),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_G4, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.LONG),
        new Note(Tone.REST, Duration.SHORT),

        //number two
        new Note(Tone.NOTE_E4, Duration.SHORT),
        new Note(Tone.NOTE_G4, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.NOTE_C5, Duration.MEDIUM),
        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.NOTE_D5, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.MEDIUM),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_G4, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.LONG),
        new Note(Tone.REST, Duration.SHORT),

        //number three
        new Note(Tone.NOTE_E4, Duration.SHORT),
        new Note(Tone.NOTE_G4, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.NOTE_D5, Duration.MEDIUM),
        new Note(Tone.NOTE_D5, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_D5, Duration.SHORT),
        new Note(Tone.NOTE_E5, Duration.SHORT),
        new Note(Tone.NOTE_F5, Duration.MEDIUM),
        new Note(Tone.NOTE_F5, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_E5, Duration.SHORT),
        new Note(Tone.NOTE_D5, Duration.SHORT),
        new Note(Tone.NOTE_E5, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.REST, Duration.SHORT),

        //number four
        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.NOTE_C5, Duration.MEDIUM),
        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_D5, Duration.MEDIUM),
        new Note(Tone.NOTE_E5, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.REST, Duration.SHORT),

        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.MEDIUM),
        new Note(Tone.NOTE_B4, Duration.SHORT),
        new Note(Tone.REST, Duration.MEDIUM),

        new Note(Tone.NOTE_C5, Duration.SHORT),
        new Note(Tone.NOTE_A4, Duration.SHORT),
        new Note(Tone.NOTE_B4, Duration.LONG),
        new Note(Tone.REST, Duration.LONG),

        //number five
        new Note(Tone.NOTE_A4, Duration.MEDIUM),
        new Note(Tone.NOTE_A4, Duration.SHORT),

        };
        // Play the song
        Play(Mary);
    }

    // Play the notes in a song.
    protected static void Play(Note[] tune)
    {
        foreach (Note n in tune)
        {
            if (n.NoteTone == Tone.REST)
                Thread.Sleep((int)n.NoteDuration);
            else
                Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
        }
    }

    // Define the frequencies of notes in an octave, as well as
    // silence (rest).
    protected enum Tone
    {
        REST = 0,
        NOTE_C4 = 262,
        NOTE_D4 = 294,
        NOTE_E4 = 330,
        NOTE_F4 = 349,
        NOTE_G4 = 392,
        NOTE_A4 = 440,
        NOTE_B4 = 494,
        NOTE_C5 = 523,
        NOTE_D5 = 587,
        NOTE_E5 = 659,
        NOTE_F5 = 698,
        NOTE_G5 = 784,
        NOTE_A5 = 880,
        NOTE_B5 = 988,
    }

    // Define the duration of a note in units of milliseconds.
    protected enum Duration
    {
        SUPERLONG = 500,
        LONG = 375,
        MEDIUM = 250,
        SHORT = 125,
    }

    // Define a note as a frequency (tone) and the amount of
    // time (duration) the note plays.
    protected struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note.
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        // Define properties to return the note's tone and duration.
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }
}