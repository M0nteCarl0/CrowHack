using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace VirusTotalChecker.Models.Output
{
    public class Uploaded : IObservable
    {
        #region IObservable
        public void Subscribe(IObserver o)
        {
            observers.Add(o);
        }

        public void UnSubscribe(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify(string result)
        {
            foreach (IObserver o in observers)
            {
                o.Update(result);
            }
        }
        #endregion
        public Uploaded()
        {
            observers = new List<IObserver>();
        }
        List<IObserver> observers;
        [JsonPropertyName("data")]
        public Data Data { get; set; }
        /// <summary>
        /// notMapped, jsonIgnore
        /// </summary>
        public event AnalyzeDone AnalyzeDone;
    }
    /// <summary>
    /// Uploaded file information
    /// </summary>
    public class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
