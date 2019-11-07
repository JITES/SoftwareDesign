using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    class Observer
    {
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        void Display();
    }

    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float Tempearture;
        private float Humidity;
        private float Pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

       
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(Tempearture, Humidity, Pressure);
            }
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.Tempearture = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }
    }

    public class CurrentConditionsDisplay : IObserver, DisplayElement
    {
        private float Tempearture;
        private float Humidity;
        private float Pressure;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.Tempearture = temp;
            this.Humidity = humidity;
            Display();
        }

        public void Display()
        {
        }

        
    }
}
