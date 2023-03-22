using net.sf.saxon.s9api;
using net.liberty_development.SaxonHE12s9apiExtensions;

Console.WriteLine($"{Environment.Version} {Environment.OSVersion}");

var processor = new Processor(false);

Console.WriteLine($"{processor.getSaxonEdition()} {processor.getSaxonProductVersion()}");

var xslt30Transformer = processor.newXsltCompiler().Compile(new Uri("https://github.com/martin-honnen/martin-honnen.github.io/raw/master/xslt/processorTestHTML5Xslt3InitialTempl.xsl")).load30();

xslt30Transformer.callTemplate(null, processor.NewSerializer(Console.Out));
