using System;
using System.Collections.Generic;

namespace ModelingEventFlows
{
    /// <summary>
    /// Пуасоновский поток событий
    /// </summary>
    internal class PoissonEventsFlow
    {
        public PoissonEventsFlow(double flowIntensity, double simulationTime)
        {
            FlowIntensity = flowIntensity;
            SimulationTime = simulationTime;
        }

        /// <summary>
        /// Интенсивность потока событий
        /// </summary>
        private double _flowIntensity;

        public double FlowIntensity
        {
            get { return _flowIntensity; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Интенсивность потока событий не может быть отрицательной", "flowIntensity");
                _flowIntensity = value;
            }
        }

        /// <summary>
        /// Время моделирования
        /// </summary>
        private double _simulationTime;

        public double SimulationTime
        {
            get { return _simulationTime; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Время моделирования не может быть отрицательным", "simulationTime");
                _simulationTime = value; 
            }
        }

        /// <summary>
        /// Число N - Количество событий
        /// </summary>
        private int _eventsCount;

        public int EventsCount
        {
            get { return _eventsCount; }
        }


        /// <summary>
        /// Запуск процесса моделирования
        /// </summary>
        /// <returns></returns>
        public double[] RunModelingProcess()
        {
            var random = new Random();
            double t = 0;
            int N = 0;
            var timePoints = new List<double>();

            do
            {
                double r = random.NextDouble();
                double tau = (-1 / _flowIntensity) * Math.Log(r);
                t += tau;
                N++;
                // фиксируем время
                timePoints.Add(t);
            } 
            while (t < _simulationTime);
            _eventsCount = N;

            return timePoints.ToArray();
        }
    }
}
