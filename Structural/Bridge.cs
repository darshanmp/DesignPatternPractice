using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
     //   1
    //  2   3
    //    4
    //Bridge pattern creates 2 levels of abstaction between abstractions and concretions
    //Example device - tv & dvd , remote -  tvmuteremote , tvpauseremote, dvdremote
    //Creating 2 levels of abstraction
    abstract class Device
    {
        public int deviceState;
        public int channelSetting;
        public int volumeControl = 0;

        public Device(int stat, int initialChannel)
        {
            this.deviceState = stat;
            this.channelSetting = initialChannel;
        }

        public void Button2Pressed()
        {
            volumeControl--;
            Console.WriteLine("Volume level decreased");
        }
        public void Button3Pressed()
        {
            volumeControl++;
            Console.WriteLine("Volume level increased");
        }
        abstract public void Button1Pressed();
        abstract public void Button4Pressed();
    }

    class TV : Device
    {
        public TV(int stat,int initialChannel) : base(stat,initialChannel)
        {

        }
        public override void Button1Pressed()
        {
            deviceState++;
            Console.WriteLine("going to next channel");
        }

        public override void Button4Pressed()
        {
            deviceState--;
            Console.WriteLine("going to previous channel");
        }
    }

    class DVD : Device
    {
        public DVD(int stat, int initialChannel) : base(stat,initialChannel)
        {

        }
        public override void Button1Pressed()
        {
            deviceState++;
            Console.WriteLine("dvd going to next chapter");
        }

        public override void Button4Pressed()
        {
            deviceState--;
            Console.WriteLine("dvd going to previous chapter");
        }
    }

    abstract class AbstractRemote
    {
        private Device device;
        public AbstractRemote(Device dev)
        {
            device = dev;
        }
        public void Button1Pressed()
        {
            device.Button1Pressed();
        }
        public void Button4Pressed()
        {
            device.Button4Pressed();
        }
        abstract public void Button9Pressed();
    }

    class TVRemoteMute : AbstractRemote
    {
        public TVRemoteMute(Device dev) : base(dev)
        {

        }
        public override void Button9Pressed()
        {
            Console.WriteLine("Muted tv ");
        }
    }

    class TVRemotePause : AbstractRemote
    {
        public TVRemotePause(Device dev) : base(dev)
        {

        }
        public override void Button9Pressed()
        {
            Console.WriteLine("Paused tv");
        }
    }

    class TVRemoteTest
    {
        //public static void Main()
        //{
        //    TVRemoteMute muteremote = new TVRemoteMute(new TV(1, 300));
        //    muteremote.Button1Pressed();
        //    muteremote.Button4Pressed();
        //    muteremote.Button9Pressed();

        //    TVRemotePause mutepause = new TVRemotePause(new TV(1, 350));
        //    mutepause.Button1Pressed();
        //    mutepause.Button4Pressed();
        //    mutepause.Button9Pressed();


        //}
    }
}
