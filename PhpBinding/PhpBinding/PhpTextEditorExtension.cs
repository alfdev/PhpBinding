using System;
using System.IO;

using MonoDevelop.Core.Gui;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide.Gui.Content;
using MonoDevelop.Projects.Gui.Completion;

namespace PhpBinding
{
	public class PhpTextEditorExtension : CompletionTextEditorExtension
	{
		public override bool ExtendsEditor(Document doc, IEditableTextBuffer editor)
		{
			return (Path.GetExtension(doc.FileName).Equals(".php", StringComparison.OrdinalIgnoreCase));
		}
 		
		public override ICompletionDataList HandleCodeCompletion(CodeCompletionContext completionContext, char completionChar)
		{
			CompletionDataList cdl = new CompletionDataList();
			
			switch(completionChar)
			{
				case '.':
				
					break;
				case '>':
					Console.WriteLine("c_char: {0}", completionChar);
					Console.WriteLine("prev: {0}", Editor.GetCharAt(completionContext.TriggerOffset - 2));
					
					
					break;
			}
			
			return cdl;
		}
	}
}
