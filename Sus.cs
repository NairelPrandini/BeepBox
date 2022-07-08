namespace BeepBox
{
    class Music
    {
        
        static public int Bpms;
        static class Notes
        {
            public static int A1 = 55;
            public static int As1 = 58;
            public static int Bb1 = 58;
            public static int B1 = 62;
            public static int C2 = 65;
            public static int Cs2 = 69;
            public static int Db2 = 69;
            public static int D2 = 73;
            public static int Ds2 = 78;
            public static int Eb2 = 78;
            public static int E2 = 82;
            public static int F2 = 87;
            public static int Fs2 = 92;
            public static int Gb2 = 92;
            public static int G2 = 98;
            public static int Gs2 = 104;
            public static int Ab2 = 104;
            public static int A2 = 110;
            public static int As2 = 117;
            public static int Bb2 = 117;
            public static int B2 = 123;
            public static int C3 = 131;
            public static int Cs3 = 139;
            public static int Db3 = 139;
            public static int D3 = 147;
            public static int Ds3 = 156;
            public static int Eb3 = 156;
            public static int E3 = 165;
            public static int F3 = 175;
            public static int Fs3 = 185;
            public static int Gb3 = 185;
            public static int G3 = 196;
            public static int Gs3 = 208;
            public static int Ab3 = 208;
            public static int A3 = 220;
            public static int As3 = 233;
            public static int Bb3 = 233;
            public static int B3 = 247;
            public static int C4 = 262;
            public static int Cs4 = 277;
            public static int Db4 = 277;
            public static int D4 = 294;
            public static int Ds4 = 311;
            public static int Eb4 = 311;
            public static int E4 = 330;
            public static int F4 = 349;
            public static int Fs4 = 370;
            public static int Gb4 = 370;
            public static int G4 = 392;
            public static int Gs4 = 415;
            public static int Ab4 = 415;
            public static int A4 = 440;
            public static int As4 = 466;
            public static int Bb4 = 466;
            public static int B4 = 494;
            public static int C5 = 523;
            public static int Cs5 = 554;
            public static int Db5 = 554;
            public static int D5 = 587;
            public static int Ds5 = 622;
            public static int Eb5 = 622;
            public static int E5 = 659;
            public static int F5 = 698;
            public static int Fs5 = 740;
            public static int Gb5 = 740;
            public static int G5 = 784;
            public static int Gs5 = 831;
            public static int Ab5 = 831;
            public static int A5 = 880;
            public static int As5 = 932;
            public static int Bb5 = 932;
            public static int C6 = 1046;
            public static int Cs6 = 1109;
            public static int Db6 = 1109;
            public static int D6 = 1175;
            public static int Ds6 = 1245;
            public static int Eb6 = 1245;
            public static int E6 = 1319;
            public static int F6 = 1397;
            public static int Fs6 = 1480;
            public static int Gb6 = 1480;
            public static int G6 = 1568;
            public static int Gs6 = 1661;
            public static int Ab6 = 1661;
            public static int A6 = 1760;
            public static int As6 = 1865;
            public static int Bb6 = 1865;
            public static int B6 = 1976;
            public static int C7 = 2093;
            public static int Cs7 = 2217;
            public static int Db7 = 2217;
            public static int D7 = 2349;
            public static int Ds7 = 2489;
            public static int Eb7 = 2489;
            public static int E7 = 2637;
            public static int F7 = 2794;
            public static int Fs7 = 2960;
            public static int Gb7 = 2960;
            public static int G7 = 3136;
            public static int Gs7 = 3322;
            public static int Ab7 = 3322;
            public static int A7 = 3520;
        }
        static class Duration
        {
            static public float Whole = 1;
            static public float Half = 0.5f;
            static public float Quarter = 0.25f;
            static public float Eighth = 0.125f;
            static public float Sixteenth = 0.0625f;
        }
        public static void PlaySong(int Tempo)
        {
            Bpms = Convert.ToInt32((60000 / Tempo) * 4);
            Rest(Duration.Quarter);
            PlayNote(Notes.C4, Duration.Eighth);
            PlayNote(Notes.Eb4, Duration.Eighth);
            PlayNote(Notes.F4, Duration.Eighth);
            PlayNote(Notes.Fs4, Duration.Eighth);
            PlayNote(Notes.F4, Duration.Eighth);
            PlayNote(Notes.Eb4, Duration.Eighth);
            PlayNote(Notes.C4, Duration.Eighth);
            Rest(Duration.Quarter + Duration.Sixteenth);
            PlayNote(Notes.Bb3, Duration.Sixteenth);
            PlayNote(Notes.D4, Duration.Sixteenth);
            PlayNote(Notes.C4, Duration.Sixteenth);
            Rest(Duration.Quarter);
            PlayNote(Notes.G3, Duration.Quarter);
            PlayNote(Notes.C3, Duration.Quarter);
            PlayNote(Notes.C4, Duration.Eighth);
            PlayNote(Notes.Eb4, Duration.Eighth);
            PlayNote(Notes.F4, Duration.Eighth);
            PlayNote(Notes.Fs4, Duration.Eighth);
            PlayNote(Notes.F4, Duration.Eighth);
            PlayNote(Notes.Eb4, Duration.Eighth);
            PlayNote(Notes.Fs4, Duration.Half);
            PlayNote(Notes.Fs4, Duration.Sixteenth);
            PlayNote(Notes.F4, Duration.Sixteenth);
            PlayNote(Notes.Eb4, Duration.Sixteenth);
            PlayNote(Notes.Fs4, Duration.Sixteenth);
            PlayNote(Notes.F4, Duration.Sixteenth);
            PlayNote(Notes.Eb4, Duration.Sixteenth);
            PlayNote(Notes.C4, Duration.Sixteenth);
            Rest(Duration.Sixteenth);
        }
        static void PlayNote(int N, float D)
        {
            Console.Beep(N, (int)(D * Bpms));
        }
        static void Rest(float D)
        {
            Thread.Sleep((int)(D * Bpms));
        }
    }
}
