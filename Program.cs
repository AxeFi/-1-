using System;
class Time {
    private int hour, min, sec;
    public Time(int hours, int minutes, int seconds) { this.hour = hours; this.min = minutes; this.sec = seconds; }
    public bool isValid() {
        if (this.hour < 0 || this.hour > 23 || this.min < 0 || this.min > 59 || this.sec < 0 || this.sec > 59) return false;
        return true;
    }
    public void Print() 
    { 
        Console.WriteLine($"{this.hour:D2}:{this.min:D2}:{this.sec:D2}"); 
    }
    public void Plus1() {
        sec++;
        while (sec >= 60) { sec -= 60; min++; }
        while (min >= 60) { min -= 60; hour++;}
    }
}
class Program {
    static void Main() {
        bool validInput = false;
        int hours = 0, minutes = 0, seconds = 0;
        Time time = new Time(hours, minutes, seconds);
        do {
            try {
                Console.WriteLine("Enter hours, minutes and seconds:");
                validInput = true;
                hours = Convert.ToInt32(Console.Read());
                Console.Write(" ");
                minutes = Convert.ToInt32(Console.Read());
                Console.Write(" ");
                seconds = Convert.ToInt32(Console.ReadLine());
                time = new Time(hours, minutes, seconds);
                if (!time.isValid()) throw new Exception();
                time.Plus1(); time.Print();
            }
            catch { validInput = false; Console.WriteLine("Invalid input"); }
        } while (!validInput);
    }
}
