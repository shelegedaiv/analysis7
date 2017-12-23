﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using Analysis7.Model.Entities;
using Analysis7.Model.Observer;
using Analysis7.ViewModel.AbstractViewModel;

namespace Analysis7.ViewModel.ConcreteViewModel
{
    public class PriceGroupViewModel: RiskEntityViewModel,IListener
    {
        private readonly Group _modelGroup;
        private ObservableCollection<int> _expertCoefficients;
        public Color GroupColor { get; }
        private int _expertCoefficientsSum;

        public ObservableCollection<int> ExpertCoefficients
        {
            get => _expertCoefficients;
            set
            {
                _expertCoefficients = value;
                OnPropertyChanged(nameof(ExpertCoefficients));
                _expertCoefficients.CollectionChanged += (source, e) =>
                {
                    _modelGroup.PriceExperts[e.NewStartingIndex].Coefficient = _expertCoefficients[e.NewStartingIndex];
                    Update();
                };
            }
        }
        public int ExpertCoefficientsSum
        {
            get => _expertCoefficientsSum;
            set
            {
                _expertCoefficientsSum = value;
                OnPropertyChanged(nameof(ExpertCoefficientsSum));
            }
        }

        private ObservableCollection<double> _expertAverageProbabilities;

        public ObservableCollection<double> ExpertAverageProbabilities
        {
            get => _expertAverageProbabilities;
            set
            {
                _expertAverageProbabilities = value;
                OnPropertyChanged(nameof(ExpertAverageProbabilities));
            }
        }

        private double _averageCoefProbability;

        public double AverageCoefProbability
        {
            get => _averageCoefProbability;
            set
            {
                _averageCoefProbability = value;
                OnPropertyChanged(nameof(AverageCoefProbability));
            }
        }
        public PriceGroupViewModel(Group modelGroup, Color color):base(modelGroup.Name,modelGroup.Description, modelGroup.AverageProbability.Value)
        {
            GroupColor = color;
            _modelGroup = modelGroup;
            _modelGroup.AttachListener(this);
            Update();
        }

        private double _startPrice;
        public double StartPrice
        {
            get => _startPrice;
            set
            {
                _startPrice = value;
                _modelGroup.StartPrice = value;
                OnPropertyChanged(nameof(StartPrice));
            }
        }

        private double _additionalPrice;
        public double AdditionalPrice
        {
            get => _additionalPrice;
            private set
            {
                _additionalPrice = value;
                OnPropertyChanged(nameof(AdditionalPrice));
            }
        }

        private double _finalPrice;
        public double FinalPrice
        {
            get => _finalPrice;
            private set
            {
                _startPrice = value;
                OnPropertyChanged(nameof(FinalPrice));
            }
        }

        public void Update()
        {
            AverageProbability = _modelGroup.AverageProbability.Value;
            ExpertCoefficients =
                new ObservableCollection<int>(_modelGroup.PriceExperts.Select(exp => exp.Coefficient).ToList());
            ExpertCoefficientsSum = ExpertCoefficients.Sum(exp => exp);
            _modelGroup.PriceExperts.ForEach(ex => ex.Update());
            ExpertAverageProbabilities = new ObservableCollection<double>(_modelGroup.PriceExperts.Select(ex => ex.AverageCoefProbability).ToList());
            AverageCoefProbability = ExpertAverageProbabilities.Sum() / ExpertCoefficientsSum;
        }

    }
}
