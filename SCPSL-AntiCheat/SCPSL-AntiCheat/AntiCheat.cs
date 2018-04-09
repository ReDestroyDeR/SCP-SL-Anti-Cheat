using Smod2;
using Smod2.Attributes;
using Smod2.Events;

namespace SCPSL_AntiCheat
{
    [PluginDetails(
        author = "RED & Tianshee",
        name = "SCP: SL Anti-Cheat",
        description = "Anti-Cheat System for SCP: Secret Laboratory",
        id = "scp.anti.cheat",
        version = "001",
        SmodMajor = 2,
        SmodMinor = 5,
        SmodRevision = 0
        )]
    class AntiCheat : Plugin
    {
        
        public override void OnDisable()
        {
        }

        public override void OnEnable()
        {
        }

        public override void Register()
        {
        }

        /*
         
        public override void OnDisable()
		{
		}

		public override void OnEnable()
		{
			this.Info("Example Plugin has loaded :)");
			this.Info("Config value: " + this.GetConfigString("test"));
		}

		public override void Register()
		{
			// Register Events
			this.AddEventHandler(typeof(IEventRoundStart), new RoundStartHandler(this), Priority.Highest);
			// Register Commands
			this.AddCommand("hello", new HelloWorldCommand(this));
			// Register config settings
			this.AddConfig(new Smod2.Config.ConfigSetting("test", "yes", Smod2.Config.SettingType.STRING, true, "test"));
		}

        */

    }
}
