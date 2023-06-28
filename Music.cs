using System;
///Test WTF amannnnnnnnnnnnnn

namespace BeepBox
{
    class Music
    {

        public int Bpms;
        public struct Notes
        {
            public int A1 = 55;
            public int As1 = 58;
            public int Bb1 = 58;
            public int B1 = 62;
            public int C2 = 65;
            public int Cs2 = 69;
            public int Db2 = 69;
            public int D2 = 73;
            public int Ds2 = 78;
            public int Eb2 = 78;
            public int E2 = 82;
            public int F2 = 87;
            public int Fs2 = 92;
            public int Gb2 = 92;
            public int G2 = 98;
            public int Gs2 = 104;
            public int Ab2 = 104;
            public int A2 = 110;
            public int As2 = 117;
            public int Bb2 = 117;
            public int B2 = 123;
            public int C3 = 131;
            public int Cs3 = 139;
            public int Db3 = 139;
            public int D3 = 147;
            public int Ds3 = 156;
            public int Eb3 = 156;
            public int E3 = 165;
            public int F3 = 175;
            public int Fs3 = 185;
            public int Gb3 = 185;
            public int G3 = 196;
            public int Gs3 = 208;
            public int Ab3 = 208;
            public int A3 = 220;
            public int As3 = 233;
            public int Bb3 = 233;
            public int B3 = 247;
            public int C4 = 262;
            public int Cs4 = 277;
            public int Db4 = 277;
            public int D4 = 294;
            public int Ds4 = 311;
            public int Eb4 = 311;
            public int E4 = 330;
            public int F4 = 349;
            public int Fs4 = 370;
            public int Gb4 = 370;
            public int G4 = 392;
            public int Gs4 = 415;
            public int Ab4 = 415;
            public int A4 = 440;
            public int As4 = 466;
            public int Bb4 = 466;
            public int B4 = 494;
            public int C5 = 523;
            public int Cs5 = 554;
            public int Db5 = 554;
            public int D5 = 587;
            public int Ds5 = 622;
            public int Eb5 = 622;
            public int E5 = 659;
            public int F5 = 698;
            public int Fs5 = 740;
            public int Gb5 = 740;
            public int G5 = 784;
            public int Gs5 = 831;
            public int Ab5 = 831;
            public int A5 = 880;
            public int As5 = 932;
            public int Bb5 = 932;
            public int C6 = 1046;
            public int Cs6 = 1109;
            public int Db6 = 1109;
            public int D6 = 1175;
            public int Ds6 = 1245;
            public int Eb6 = 1245;
            public int E6 = 1319;
            public int F6 = 1397;
            public int Fs6 = 1480;
            public int Gb6 = 1480;
            public int G6 = 1568;
            public int Gs6 = 1661;
            public int Ab6 = 1661;
            public int A6 = 1760;
            public int As6 = 1865;
            public int Bb6 = 1865;
            public int B6 = 1976;
            public int C7 = 2093;
            public int Cs7 = 2217;
            public int Db7 = 2217;
            public int D7 = 2349;
            public int Ds7 = 2489;
            public int Eb7 = 2489;
            public int E7 = 2637;
            public int F7 = 2794;
            public int Fs7 = 2960;
            public int Gb7 = 2960;
            public int G7 = 3136;
            public int Gs7 = 3322;
            public int Ab7 = 3322;
            public int A7 = 3520;
        }
        class Duration
        {
            public float Whole = 1;
            public float Half = 0.5f;
            public float Quarter = 0.25f;
            public float Eighth = 0.125f;
            public float Sixteenth = 0.0625f;
        }
        public void PlaySong(int Tempo)
        {
            Bpms = Convert.ToInt64((60000 / Tempo) * 4);
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
        void PlayNote(int N, float D)
        {
            Console.Beep(N, (int)(D * Bpms));
        }
        void Rest(float D)
        {
            Thread.Sleep((int)(D * Bpms));
        }
    }
}
