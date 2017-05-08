using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Behavioral
{
    //Inform observers of changes
    //News publishing to SMS subscribers and Email subscribers
    abstract class NewsPublisher    
    {
        List<Subscriber> subLst = null;
        private string latestNews = "";
        public NewsPublisher(string news)
        {
            subLst = new List<Subscriber>();
            Console.WriteLine(news);
            latestNews = news;
        }
        public void NotifySubscribers()
        {
            foreach(var i in subLst)
            {
                i.Update(this);
            }
        }
        public void attach(Subscriber attachSubsc)
        {
            subLst.Add(attachSubsc);
        }
        public void detach(Subscriber removeSubsc)
        {
            subLst.Remove(removeSubsc);
        }
        public string getLatestNews()
        {
            return latestNews;
        }
        public void updateLatestNews(string updNews)
        {
            latestNews = updNews;
            NotifySubscribers();
        }
    }

    class SportsPublisher : NewsPublisher
    {
        public SportsPublisher(string news) : base(news)
        {

        }
    }
    class BusinessPublisher : NewsPublisher
    {
        public BusinessPublisher(string news) : base(news)
        {

        }
    }
    abstract class Subscriber
    {
        NewsPublisher subject = null;
        public Subscriber(NewsPublisher subj)
        {
            subject = subj;            
        }
        public abstract void Update(NewsPublisher updatedSubject);
    }
    class SMSSubscriber : Subscriber
    {
        public SMSSubscriber(NewsPublisher news) : base(news)
        {
            Console.WriteLine("SMS news initial received: " + news.getLatestNews());
        }
        public override void Update(NewsPublisher updatedSubject)
        {
            Console.WriteLine("SMS received latest news:" + updatedSubject.getLatestNews());
        }
    }
    class EmailSubscriber : Subscriber
    {
        public EmailSubscriber(NewsPublisher news) : base(news)
        {
            Console.WriteLine("Email news initial received: " + news.getLatestNews());
        }
        public override void Update(NewsPublisher updatedSubject)
        {
            Console.WriteLine("Email received latest news:" + updatedSubject.getLatestNews());
        }
    }
    class ObserverDP
    {
        //public static void Main()
        //{
        //    BusinessPublisher business = new BusinessPublisher("Business news started");
        //    SMSSubscriber sms = new SMSSubscriber(business);
        //    EmailSubscriber email = new EmailSubscriber(business);
        //    business.attach(sms);
        //    business.attach(email);

        //    business.updateLatestNews("Business news latest");
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    SportsPublisher sports = new SportsPublisher("Sports news started");
        //    SMSSubscriber sportssms = new SMSSubscriber(sports);
        //    EmailSubscriber sportsemail = new EmailSubscriber(sports);
        //    sports.attach(sportssms);
        //    sports.attach(sportsemail);
        //    sports.updateLatestNews("Sports news latest");

        //}        
    }
}
