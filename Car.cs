using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly
{
    internal class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запушен";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Двигатель уже запушен";
        private const string ATTEMPT_TO_STARTED_DRIVE_MESSAGE = "Тапку в пол";
        private const string DRIVE_MESSAGE = "Поезали";
        private const string DRIVE_ERROR_MESSAGE = "Сначало заводи двигатель";


        private readonly MyLogger _myLogger;

        private bool isIngineStarted;

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
            if (isIngineStarted)
            {
                _myLogger.Warn(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isIngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }

        public void Drive() 
        {
            _myLogger.Info(ATTEMPT_TO_STARTED_DRIVE_MESSAGE);
            if (isIngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
            }
        }
    }


}
