using System;
using System.Xml;

using MonoDevelop.Projects;

namespace PhpBinding
{
	public class PhpProject : Project
	{

		public override string ProjectType
		{
			get
			{
				return "Php";
			}
		}

		protected override BuildResult DoBuild (MonoDevelop.Core.IProgressMonitor monitor, string itemConfiguration)
		{
			return base.DoBuild(monitor, itemConfiguration);
		}
		
		public PhpProject ()
		{
		}
		
		public PhpProject (ProjectCreateInformation info, XmlElement projectOptions)
		{
			if (info != null)
				this.Name = info.ProjectName;
		}

		protected override void DoExecute (MonoDevelop.Core.IProgressMonitor monitor, ExecutionContext context, string itemConfiguration)
		{
			base.DoExecute(monitor, context, itemConfiguration);
		}
	}
}
