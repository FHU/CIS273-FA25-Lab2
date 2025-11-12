namespace PrayerScheduler;

public class PrayerScheduler
{

    public int NumDailyPrayers;
    public int NumNonDailyPrayers;

    public List<Prayer> DailyPrayers { get; } = new();

    private Queue<Prayer> nonDailyPrayers = new(); 
    public List<Prayer> NonDailyPrayers
    {
        get
        {
            return nonDailyPrayers.ToList();
        }
    }

    public List<Prayer> AnsweredPrayers { get; } = new();

    public PrayerScheduler()
    {
    }

    public void AddPrayer(Prayer prayer)
    {
        // if answered
        // add it to answered

        //if unanswered
        // if daily, add to dailys


    }

    public void AnswerPrayer(int id)
    {
        //is the prayer in the dailys?
        var prayerToRemove = DailyPrayers.Find((prayer) => prayer.ID == id);
        if (prayerToRemove != null)
        {
            prayerToRemove.IsAnswered = true;
            DailyPrayers.Remove(prayerToRemove);
            AnsweredPrayers.Add(prayerToRemove);
            return;
        }
        
        //is the prayer in the non-dailys?
        for(int i=0; i< nonDailyPrayers.Count; i++)
        {
            var prayer = nonDailyPrayers.Dequeue();
            if (prayer.ID == id)
            {
                prayer.IsAnswered = true;
                AnsweredPrayers.Add(prayer);
            }
            else
            {
                nonDailyPrayers.Enqueue(prayer);
            }
        }
    
    }

    public List<Prayer> GetPrayers(int numPrayers)
    {
        List<Prayer> prayers = new List<Prayer>();


        return prayers;
    }

}


