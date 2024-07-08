using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface ITrainingSessionRepository
    {
        List<TrainingSession> GetAllTrainings();
        TrainingSession GetTrainingSessionById(int trainingSessionId);
        void AddTrainingSession(TrainingSession trainingSession);
        void DeleteTrainingSession(int trainingSessionId);

        void EditTrainingSession(TrainingSession trainingSession);

    }
}
