using System;
using System.IO;

using MonoDevelop.Core;
using MonoDevelop.Projects;
using MonoDevelop.Projects.Dom.Parser;
using MonoDevelop.Projects.CodeGeneration;

namespace PhpBinding
{
	public class PhpLanguageBinding : ILanguageBinding
	{
		static readonly string language = "Php";
		static readonly string php_ext = ".php";

		public string Language
		{
			get { return language; }
		}
		
		public string SingleLineCommentTag
		{
			get { return "#"; }
		}
		
		public string BlockCommentStartTag
		{
			get { return "/*"; }
		}
		
		public string BlockCommentEndTag
		{
			get { return "*/"; }
		}
		
		public IParser Parser
		{
			get { return null; }
		}
		
		public IRefactorer Refactorer
		{
			get { return null; }
		}
		
		public PhpLanguageBinding ()
		{
		}
		
		public bool IsSourceCodeFile (string fileName)
		{
			return Path.GetExtension(fileName) == php_ext;
		}
		
		public string GetFileName(string baseName)
		{
			return String.Concat(baseName, php_ext);
		}
	}
}
