using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace build_a_fit
{
    public partial class Form1 : Form
    {
        private bool isImageSubmitted = false; // Define at class level
    }
    public class WardrobeItem //Components of system
    {
        public string ImagePath { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }
        public string Occasion { get; set; }
        public string Season { get; set; }
        public string Color { get; set; }

        //Constructor to match factory method
        public WardrobeItem(string imagePath, string type, string style,
                                                 string occasion, string season, string color)
        {
            this.ImagePath = imagePath;
            this.Type = type;
            this.Style = style;
            this.Occasion = occasion;
            this.Season = season;
            this.Color = color;
        }
        public static WardrobeItem CreateWardrobeItem(string imagePath, string type, string style,
                                                 string occasion, string season, string color)
        {
            return new WardrobeItem(imagePath, type, style, occasion, season, color);
        }


       
    }
    public class Wardrobe //utlkzing a list to store wardrobe items
    {
        public List<WardrobeItem> Items { get; set; } = new List<WardrobeItem>();
        public void AddItem(WardrobeItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(WardrobeItem item)
        {
            Items.Remove(item);
        }
        public List<WardrobeItem> GetRecommendations(string season, string occasion)
        {
            return Items.Where(i => i.Season == season && i.Occasion == occasion).ToList();
        }
    }
    public class UserProfile
    {
        public string UserId { get; set; }
        public List<string> FavoriteColors { get; set; } = new List<string>();
        public string PreferredStyle { get; set; }
        public string BodyType { get; set; }
        public int AgeGroup { get; set; }

        public void UpdatePreferences(List<string> colors, string style, string bodyType, int ageGroup)
        {
            FavoriteColors = colors;
            PreferredStyle = style;
            BodyType = bodyType;
            AgeGroup = ageGroup;
        }
    }
    public class AI_Engine
    {
            public UserProfile UserPreferences { get; set; }
            public Wardrobe UserWardrobe { get; set; }
            public AI_Engine(UserProfile user, Wardrobe wardrobe)
            {
                UserPreferences = user;
                UserWardrobe = wardrobe;
            }
            public List<WardrobeItem> GenerateOutfitSuggestions(string currentWeather, string eventType)
            {
                return UserWardrobe.GetRecommendations(currentWeather, eventType)
                    .Where(item => UserPreferences.FavoriteColors.Contains(item.Color))
                    .ToList();
            }
        }
    public class WeatherService
    {
        private static WeatherService instance;
        private static readonly object lockObj = new object(); // Lock object for thread safety

        public string Forecast { get; private set; }

        private WeatherService() { }

        public static WeatherService GetInstance()
        {
            lock (lockObj) // Prevent race conditions
            {
                if (instance == null)
                    instance = new WeatherService();
            }
            return instance;
        }

        public void UpdateWeather(string forecast)
        {
            Forecast = forecast;
        }
    }

    public class CalendarEvent
    {
            public string EventName { get; set; }
            public DateTime Date { get; set; }
            public string DressCode { get; set; }

            public CalendarEvent(string eventName, DateTime date, string dressCode)
            {
                EventName = eventName;
                Date = date;
                DressCode = dressCode;
            }

        }
}

   

