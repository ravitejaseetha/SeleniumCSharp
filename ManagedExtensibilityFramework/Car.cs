using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedExtensibilityFramework
{
    
    public class Car
    {
        [Import(AllowDefault=true)]// 0 or 1 exports
        private Engine Engine;
        [Import]//Exactly 1
        private Brakes Brake;
        [ImportMany]//0 or many
        private Steering Steering;
        [Import]
        private Transmission Transmission;



        //public Car()
        //{
        //    Engine = new Engine();
        //    Brake = new Brakes();
        //    Steering = new Steering();
        //    Transmission = new Transmission();
        //}

        public void Drive()
        {
            this.Engine.Start();
            this.Brake.Stop();
            this.Steering.Left();
            this.Transmission.ShiftUp();
        }
    }
}
