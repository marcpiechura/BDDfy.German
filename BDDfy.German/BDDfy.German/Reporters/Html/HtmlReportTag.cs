using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestStack.BDDfy.Reporters.Html;

namespace BDDfy.German.Reporters.Html
{
    class HtmlReportTag : IDisposable
    {
        private readonly HtmlTag _tagName;
        private readonly Action<HtmlTag> _closeTagAction;

        public HtmlReportTag(HtmlTag tag, Action<HtmlTag> closeTagAction)
        {
            _tagName = tag;
            _closeTagAction = closeTagAction;
        }

        public void Dispose()
        {
            _closeTagAction(_tagName);
        }
    }
}
