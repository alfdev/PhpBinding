using System;
using System.Xml;
using System.IO;

using MonoDevelop.Projects;

namespace PhpBinding
{
	public class PhpProjectBinding : IProjectBinding
	{
		public string Name
		{
			get { return "Php"; }	
		}
		
		public Project CreateProject(ProjectCreateInformation info, XmlElement projectOptions)
		{
			return new PhpProject(info, projectOptions);
		}
		
		public Project CreateSingleFileProject (string sourceFile)
		{
			ProjectCreateInformation info = new ProjectCreateInformation();
			info.ProjectName = Path.GetFileNameWithoutExtension(sourceFile);
			info.SolutionPath = Path.GetDirectoryName(sourceFile);
			info.ProjectBasePath = Path.GetDirectoryName(sourceFile);
			
			PhpProject project = new PhpProject(info, null);
			project.Files.Add(new ProjectFile(sourceFile));
			return project;
		}
		
		public bool CanCreateSingleFileProject(string sourceFile)
		{
			return Path.GetExtension(sourceFile) == ".php";
		}
	}
}
