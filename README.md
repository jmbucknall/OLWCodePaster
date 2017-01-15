Open Live Writer code paster
===

_Pasting code copied from &lt;your editor of choice&gt; into Open Live Writer_

Introduction
---

A common need for developers writing blog posts is to show nicely syntax-highlighted 
code in those posts. These days people use a JavaScript library to render code on the 
client-side -- and by 'code' I mean languages like HTML, CSS, JSON, XML, as well as the
actual languages we write our apps in. After a bit of research I decided on 
[Prism JS](http://prismjs.com/) to do this.

The scenario I had was to copy some block of code to the clipboard, and then 'paste' it into
the blog post I was writing with Open Live Writer. The pasting operation would wrap the
copied code in a `<div>` element to allow for some overall styling, and within that the
normal `<pre>` and `<code>` elements required by Prism (and others). A nice little gotcha
is that the `<code>` tag needs a `language` attribute that defines what syntax highlighting
is required to render the code. 


Using with Open Live Writer
===

Compiling the code with Visual Studio will produce a DLL called `OLWCodePaster.dll`. Make sure you are not running
Open Live Writer, then copy this DLL to the `Plugins` folder off from the installation folder for Open Live Writer
(you might need to create it if this is the first plugin you're using). Restart Open Live Writer.

To paste some code, highlight and copy it from your editor. Switch to OpenLive Writer, go to the Insert tab, and look in the Plug-ins folder. Select Paste Code. A dialog is shown allowing you to select the type of code you're inserting. Make the choice, press OK, and the code will be inserted into the document, properly surrounded with the required tags.


Code block format
===

The code will be wrapped in a special code block like this:

    <div class="jmbcodeblock">
		<pre><code class="language-foo">
	_your formatted code_ 
		</code></pre>
	</div>

where "foo" is the language of the code being inserted (JavaScript, HTML, CSS, whatever). That language value is provided by the plug-in based on your selection.

You can then style the `.jmbcodeblock` selector as you wish. Prism will style the `pre` and `<code>` elements, using whatever theme you previously selected. As an example, in my main blog's CSS I add a larger bottom margin than that provided by Prism:

    div.jmbcodeblock {
        margin-bottom: 30px;
    }

