using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    public class HtmlFormatHelper
    {
        public string GetBoldFormat(string content)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));
                
            return $"<b>{content}</b>";
        }

        public string GetItalicFormat(string content)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));
                
            return $"<i>{content}</i>";
        }

        // Plus difficile
        public string GetFormattedListElements(List<string> contents)
        {
            if (contents == null)
                throw new ArgumentNullException(nameof(contents));

            var htmlList = new StringBuilder();
            htmlList.Append("<ul>");

            foreach (var content in contents)
            {
                if (content == null)
                    throw new ArgumentNullException("List item cannot be null");
                    
                htmlList.Append($"<li>{content}</li>");
            }

            htmlList.Append("</ul>");
            return htmlList.ToString();
        }
    }
}
