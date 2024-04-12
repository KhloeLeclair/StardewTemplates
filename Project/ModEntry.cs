using StardewModdingAPI;

namespace SafeProjectName;

public class ModEntry : Mod {

	public override void Entry(IModHelper helper) {
		// Initialize the Translation Helper
		I18n.Init(Helper.Translation);

		// Say Hello.
		Monitor.Log(I18n.Hello("World"), LogLevel.Info);
	}

}
