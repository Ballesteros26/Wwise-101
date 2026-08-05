#if UNITY_EDITOR_OSX
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.iOS.Xcode;

public class iOSBuildHandler : IPostprocessBuildWithReport
{
	public int callbackOrder
	{
		get { return 0; }
	}

	public void OnPostprocessBuild(UnityEditor.Build.Reporting.BuildReport Report)
	{
		if (Report.summary.platform == BuildTarget.iOS)
		{
			var BuiltProjectPath = PBXProject.GetPBXProjectPath(Report.summary.outputPath);
			var BuiltProject = new PBXProject();
			BuiltProject.ReadFromFile(BuiltProjectPath);
			if (BuiltProject != null)
			{
				var targetGuid = BuiltProject.GetUnityFrameworkTargetGuid();
				BuiltProject.AddFrameworkToProject(targetGuid, "CoreHaptics.framework", false);
				BuiltProject.WriteToFile(BuiltProjectPath);
			}
			else
			{
				UnityEngine.Debug.Log(
					"Cannot read PBXProject from file. Please manually add a depencency on CoreHaptics in Xcode.");
			}
		}
	}
}
#endif