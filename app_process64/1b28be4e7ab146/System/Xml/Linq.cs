class <Module>
{
}

class SR
{
    static /*0x7647148*/ string Format(string resourceFormat, object p1);
    static /*0x76471b8*/ string Format(string resourceFormat, object p1, object p2);
}

namespace System
{
    namespace Xml
    {
        namespace Linq
        {
            class BaseUriAnnotation
            {
                /*0x10*/ string baseUri;

                /*0x7647230*/ BaseUriAnnotation(string baseUri);
            }

            class LineInfoAnnotation
            {
                /*0x10*/ int lineNumber;
                /*0x14*/ int linePosition;

                /*0x7647260*/ LineInfoAnnotation(int lineNumber, int linePosition);
            }

            class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
            {
                /*0x764728c*/ LineInfoEndElementAnnotation(int lineNumber, int linePosition);
            }

            class XAttribute : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XAttribute next;
                /*0x28*/ System.Xml.Linq.XName name;
                /*0x30*/ string value;

                static /*0x7647778*/ void ValidateAttribute(System.Xml.Linq.XName name, string value);
                /*0x76472b8*/ XAttribute(System.Xml.Linq.XName name, object value);
                /*0x76479a8*/ XAttribute(System.Xml.Linq.XAttribute other);
                /*0x7647a34*/ bool get_IsNamespaceDeclaration();
                /*0x7647aec*/ System.Xml.Linq.XName get_Name();
                /*0x7647af4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7647afc*/ string get_Value();
                /*0x7647b04*/ string ToString();
                /*0x7647ee0*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
            }

            class XCData : System.Xml.Linq.XText
            {
                /*0x7648220*/ XCData(string value);
                /*0x76482a0*/ XCData(System.Xml.Linq.XCData other);
                /*0x7648320*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7648328*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7648398*/ System.Xml.Linq.XNode CloneNode();
            }

            class XComment : System.Xml.Linq.XNode
            {
                /*0x28*/ string value;

                /*0x76483f0*/ XComment(string value);
                /*0x7648474*/ XComment(System.Xml.Linq.XComment other);
                /*0x76484f0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x76484f8*/ string get_Value();
                /*0x7648500*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7648570*/ System.Xml.Linq.XNode CloneNode();
            }

            class XContainer : System.Xml.Linq.XNode
            {
                /*0x28*/ object content;

                static /*0x7647398*/ string GetStringValue(object value);
                /*0x76485c8*/ XContainer();
                /*0x76485d0*/ XContainer(System.Xml.Linq.XContainer other);
                /*0x76487ec*/ System.Xml.Linq.XNode get_LastNode();
                /*0x7648934*/ void Add(object content);
                /*0x76496d0*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
                /*0x7649780*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x7649784*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x7648e88*/ void AddContentSkipNotify(object content);
                /*0x7649348*/ void AddNode(System.Xml.Linq.XNode n);
                /*0x7649788*/ void AddNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x76493c8*/ void AddString(string s);
                /*0x7649808*/ void AddStringSkipNotify(string s);
                /*0x7649a60*/ void AppendNode(System.Xml.Linq.XNode n);
                /*0x7648708*/ void AppendNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x7649dd0*/ void AppendText(System.Text.StringBuilder sb);
                /*0x7649984*/ void ConvertTextToNode();
                /*0x7649eac*/ void ReadContentFrom(System.Xml.XmlReader r);
                /*0x764a594*/ void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x764b428*/ void RemoveNode(System.Xml.Linq.XNode n);
                /*0x764b608*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x764b60c*/ void ValidateString(string s);
                /*0x764b610*/ void WriteContentTo(System.Xml.XmlWriter writer);

                class ContentReader
                {
                    /*0x10*/ System.Xml.Linq.NamespaceCache _eCache;
                    /*0x20*/ System.Xml.Linq.NamespaceCache _aCache;
                    /*0x30*/ System.Xml.IXmlLineInfo _lineInfo;
                    /*0x38*/ System.Xml.Linq.XContainer _currentContainer;
                    /*0x40*/ string _baseUri;

                    /*0x7649fac*/ ContentReader(System.Xml.Linq.XContainer rootContainer);
                    /*0x764a6bc*/ ContentReader(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                    /*0x7649fdc*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r);
                    /*0x764a784*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                }

                class <Nodes>d__18 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__2;

                    /*0x764974c*/ <Nodes>d__18(int <>1__state);
                    /*0x764bc6c*/ void System.IDisposable.Dispose();
                    /*0x764bc70*/ bool MoveNext();
                    /*0x764bd30*/ System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current();
                    /*0x764bd38*/ void System.Collections.IEnumerator.Reset();
                    /*0x764bd70*/ object System.Collections.IEnumerator.get_Current();
                    /*0x764bd78*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator();
                    /*0x764be1c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XDeclaration
            {
                /*0x10*/ string _version;
                /*0x18*/ string _encoding;
                /*0x20*/ string _standalone;

                /*0x764be20*/ XDeclaration(string version, string encoding, string standalone);
                /*0x764be80*/ XDeclaration(System.Xml.Linq.XDeclaration other);
                /*0x764bf1c*/ string get_Encoding();
                /*0x764bf24*/ string get_Standalone();
                /*0x764bf2c*/ string get_Version();
                /*0x764bf34*/ string ToString();
            }

            class XDocument : System.Xml.Linq.XContainer
            {
                /*0x30*/ System.Xml.Linq.XDeclaration _declaration;

                static /*0x764c4b4*/ bool IsWhitespace(string s);
                /*0x764c1a4*/ XDocument();
                /*0x764c1ac*/ XDocument(System.Xml.Linq.XDocument other);
                /*0x764c238*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x764c240*/ void set_Declaration(System.Xml.Linq.XDeclaration value);
                /*0x764c248*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764c250*/ System.Xml.Linq.XElement get_Root();
                /*0x764c298*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764c3c4*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x764c410*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x764c45c*/ System.Xml.Linq.XNode CloneNode();
                /*0x3910ae8*/ T GetFirstNode<T>();
                /*0x764c548*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x764c6ec*/ void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter);
                /*0x764c810*/ void ValidateString(string s);
            }

            class XDocumentType : System.Xml.Linq.XNode
            {
                /*0x28*/ string _name;
                /*0x30*/ string _publicId;
                /*0x38*/ string _systemId;
                /*0x40*/ string _internalSubset;

                /*0x764b97c*/ XDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x764c870*/ XDocumentType(System.Xml.Linq.XDocumentType other);
                /*0x764c91c*/ string get_InternalSubset();
                /*0x764c924*/ string get_Name();
                /*0x764c92c*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764c934*/ string get_PublicId();
                /*0x764c93c*/ string get_SystemId();
                /*0x764c944*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764c9b4*/ System.Xml.Linq.XNode CloneNode();
            }

            class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
            {
                /*0x30*/ System.Xml.Linq.XName name;
                /*0x38*/ System.Xml.Linq.XAttribute lastAttr;

                /*0x764b7f8*/ XElement(System.Xml.Linq.XName name);
                /*0x764ca0c*/ XElement(System.Xml.Linq.XElement other);
                /*0x7649648*/ XElement(System.Xml.Linq.XStreamingElement other);
                /*0x764cab8*/ bool get_HasAttributes();
                /*0x764cac8*/ bool get_IsEmpty();
                /*0x764cad8*/ System.Xml.Linq.XName get_Name();
                /*0x764cae0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764cae8*/ string get_Value();
                /*0x764cb5c*/ System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name);
                /*0x764cb98*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
                /*0x764800c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
                /*0x764cd38*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764cf84*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x764cf8c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x764d190*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x764d19c*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x764d398*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x764d284*/ void AppendAttribute(System.Xml.Linq.XAttribute a);
                /*0x764b874*/ void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x764d480*/ System.Xml.Linq.XNode CloneNode();
                /*0x764cba0*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name);
                /*0x764cc44*/ string GetNamespaceOfPrefixInScope(string prefix, System.Xml.Linq.XElement outOfScope);
                /*0x764d118*/ void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x764d50c*/ void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x764bb28*/ void SetEndElementLineInfo(int lineNumber, int linePosition);
                /*0x764dca8*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);

                class <GetAttributes>d__116 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XAttribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XElement <>4__this;
                    /*0x30*/ System.Xml.Linq.XName name;
                    /*0x38*/ System.Xml.Linq.XName <>3__name;
                    /*0x40*/ System.Xml.Linq.XAttribute <a>5__2;

                    /*0x764d4d8*/ <GetAttributes>d__116(int <>1__state);
                    /*0x764dddc*/ void System.IDisposable.Dispose();
                    /*0x764dde0*/ bool MoveNext();
                    /*0x764deb8*/ System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current();
                    /*0x764dec0*/ void System.Collections.IEnumerator.Reset();
                    /*0x764def8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x764df00*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator();
                    /*0x764dfb4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XHashtable<TValue>
            {
                /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;

                /*0x381678c*/ XHashtable(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                bool TryGetValue(string key, int index, int count, ref TValue value);
                /*0x3910ae8*/ TValue Add(TValue value);

                class ExtractKeyDelegate<TValue> : System.MulticastDelegate
                {
                    ExtractKeyDelegate(object object, nint method);
                    /*0x3910ae8*/ string Invoke(TValue value);
                }

                class XHashtableState<TValue>
                {
                    /*0x0*/ int[] _buckets;
                    /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue> _entries;
                    /*0x0*/ int _numEntries;
                    /*0x0*/ System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;

                    static /*0x382f928*/ int ComputeHashCode(string key, int index, int count);
                    /*0x381678c*/ XHashtableState(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                    /*0x38148bc*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize();
                    bool TryGetValue(string key, int index, int count, ref TValue value);
                    /*0x3910ae8*/ bool TryAdd(TValue value, ref TValue newValue);
                    /*0x3910ae8*/ bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex);

                    struct Entry<TValue>
                    {
                        /*0x0*/ TValue Value;
                        /*0x0*/ int HashCode;
                        /*0x0*/ int Next;
                    }
                }
            }

            struct NamespaceCache
            {
                /*0x10*/ System.Xml.Linq.XNamespace _ns;
                /*0x18*/ string _namespaceName;

                /*0x764b74c*/ System.Xml.Linq.XNamespace Get(string namespaceName);
            }

            struct ElementWriter
            {
                /*0x10*/ System.Xml.XmlWriter _writer;
                /*0x18*/ System.Xml.Linq.NamespaceResolver _resolver;

                /*0x764cdd0*/ ElementWriter(System.Xml.XmlWriter writer);
                /*0x764cdf0*/ void WriteElement(System.Xml.Linq.XElement e);
                /*0x764e28c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);
                /*0x764dfb8*/ void PushAncestors(System.Xml.Linq.XElement e);
                /*0x764e560*/ void PushElement(System.Xml.Linq.XElement e);
                /*0x764e234*/ void WriteEndElement();
                /*0x764e260*/ void WriteFullEndElement();
                /*0x764e0d4*/ void WriteStartElement(System.Xml.Linq.XElement e);
            }

            struct NamespaceResolver
            {
                /*0x10*/ int _scope;
                /*0x18*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;
                /*0x20*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;

                /*0x764e614*/ void PushScope();
                /*0x764e708*/ void PopScope();
                /*0x764e624*/ void Add(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x764e470*/ void AddFirst(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x764e37c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);

                class NamespaceDeclaration
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ System.Xml.Linq.XNamespace ns;
                    /*0x20*/ int scope;
                    /*0x28*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;

                    /*0x764e7ac*/ NamespaceDeclaration();
                }
            }

            enum XObjectChange
            {
                Add = 0,
                Remove = 1,
                Name = 2,
                Value = 3,
            }

            enum LoadOptions
            {
                None = 0,
                PreserveWhitespace = 1,
                SetBaseUri = 2,
                SetLineInfo = 4,
            }

            enum SaveOptions
            {
                None = 0,
                DisableFormatting = 1,
                OmitDuplicateNamespaces = 2,
            }

            class XName : System.IEquatable<System.Xml.Linq.XName>, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ System.Xml.Linq.XNamespace _ns;
                /*0x18*/ string _localName;
                /*0x20*/ int _hashCode;

                static /*0x764e924*/ System.Xml.Linq.XName Get(string expandedName);
                static /*0x764eea8*/ System.Xml.Linq.XName Get(string localName, string namespaceName);
                static /*0x764eecc*/ System.Xml.Linq.XName op_Implicit(string expandedName);
                static /*0x764738c*/ bool op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                /*0x764e7b4*/ XName(System.Xml.Linq.XNamespace ns, string localName);
                /*0x764ef30*/ XName();
                /*0x764e884*/ string get_LocalName();
                /*0x764e88c*/ System.Xml.Linq.XNamespace get_Namespace();
                /*0x7647ad0*/ string get_NamespaceName();
                /*0x764e894*/ string ToString();
                /*0x764eed8*/ bool Equals(object obj);
                /*0x764eee4*/ int GetHashCode();
                /*0x764eeec*/ bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other);
                /*0x764eef8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XNamespace
            {
                static /*0x0*/ System.Xml.Linq.XHashtable<System.WeakReference> s_namespaces;
                static /*0x8*/ System.WeakReference s_refNone;
                static /*0x10*/ System.WeakReference s_refXml;
                static /*0x18*/ System.WeakReference s_refXmlns;
                /*0x10*/ string _namespaceName;
                /*0x18*/ int _hashCode;
                /*0x20*/ System.Xml.Linq.XHashtable<System.Xml.Linq.XName> _names;

                static /*0x764ee4c*/ System.Xml.Linq.XNamespace get_None();
                static /*0x764f164*/ System.Xml.Linq.XNamespace get_Xml();
                static /*0x764f1c4*/ System.Xml.Linq.XNamespace get_Xmlns();
                static /*0x764d9ec*/ System.Xml.Linq.XNamespace Get(string namespaceName);
                static /*0x764f224*/ System.Xml.Linq.XNamespace op_Implicit(string namespaceName);
                static /*0x764cc38*/ bool op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x764f24c*/ bool op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x764ea6c*/ System.Xml.Linq.XNamespace Get(string namespaceName, int index, int count);
                static /*0x764f258*/ string ExtractLocalName(System.Xml.Linq.XName n);
                static /*0x764f270*/ string ExtractNamespace(System.WeakReference r);
                static /*0x764f084*/ System.Xml.Linq.XNamespace EnsureNamespace(ref System.WeakReference refNmsp, string namespaceName);
                /*0x764ef68*/ XNamespace(string namespaceName);
                /*0x764f074*/ string get_NamespaceName();
                /*0x764b798*/ System.Xml.Linq.XName GetName(string localName);
                /*0x764f07c*/ string ToString();
                /*0x764f238*/ bool Equals(object obj);
                /*0x764f244*/ int GetHashCode();
                /*0x764ed44*/ System.Xml.Linq.XName GetName(string localName, int index, int count);
            }

            class XNode : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XNode next;

                /*0x764846c*/ XNode();
                /*0x764f2e8*/ void Remove();
                /*0x764f348*/ string ToString();
                /*0x3816710*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764f8b0*/ void AppendText(System.Text.StringBuilder sb);
                /*0x38148bc*/ System.Xml.Linq.XNode CloneNode();
                /*0x764f438*/ string GetXmlString(System.Xml.Linq.SaveOptions o);
            }

            class XObject : System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.Linq.XContainer parent;
                /*0x18*/ object annotations;

                /*0x7647384*/ XObject();
                /*0x764bbec*/ string get_BaseUri();
                /*0x3814574*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764f8b4*/ System.Xml.Linq.XElement get_Parent();
                /*0x764da4c*/ void AddAnnotation(object annotation);
                /*0x764f930*/ object AnnotationForSealedType(System.Type type);
                /*0x3910ae8*/ T Annotation<T>();
                /*0x764fa70*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x764fac4*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x764fb18*/ int System.Xml.IXmlLineInfo.get_LinePosition();
                /*0x764bb98*/ bool get_HasBaseUri();
                /*0x7649c1c*/ bool NotifyChanged(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x7649b74*/ bool NotifyChanging(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x764ba40*/ void SetBaseUri(string baseUri);
                /*0x764bab8*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x7648e18*/ bool SkipNotify();
                /*0x764f364*/ System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations();
            }

            class XObjectChangeAnnotation
            {
                /*0x10*/ System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changing;
                /*0x18*/ System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changed;
            }

            class XObjectChangeEventArgs : System.EventArgs
            {
                static /*0x0*/ System.Xml.Linq.XObjectChangeEventArgs Add;
                static /*0x8*/ System.Xml.Linq.XObjectChangeEventArgs Remove;
                static /*0x10*/ System.Xml.Linq.XObjectChangeEventArgs Name;
                static /*0x18*/ System.Xml.Linq.XObjectChangeEventArgs Value;
                /*0x10*/ System.Xml.Linq.XObjectChange _objectChange;

                static /*0x764fbd8*/ XObjectChangeEventArgs();
                /*0x764fb6c*/ XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange);
            }

            class XProcessingInstruction : System.Xml.Linq.XNode
            {
                /*0x28*/ string target;
                /*0x30*/ string data;

                static /*0x764fcb8*/ void ValidateName(string name);
                /*0x764b8e4*/ XProcessingInstruction(string target, string data);
                /*0x764fd90*/ XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other);
                /*0x764fe1c*/ string get_Data();
                /*0x764fe24*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764fe2c*/ string get_Target();
                /*0x764fe34*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764fea4*/ System.Xml.Linq.XNode CloneNode();
            }

            class XStreamingElement
            {
                /*0x10*/ System.Xml.Linq.XName name;
                /*0x18*/ object content;
            }

            class XText : System.Xml.Linq.XNode
            {
                /*0x28*/ string text;

                /*0x7648224*/ XText(string value);
                /*0x76482a4*/ XText(System.Xml.Linq.XText other);
                /*0x764fefc*/ System.Xml.XmlNodeType get_NodeType();
                /*0x764ff04*/ string get_Value();
                /*0x7649cc4*/ void set_Value(string value);
                /*0x764ff0c*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x764fff8*/ void AppendText(System.Text.StringBuilder sb);
                /*0x765001c*/ System.Xml.Linq.XNode CloneNode();
            }
        }
    }

    namespace Text
    {
        class StringBuilderCache
        {
            [ThreadStatic] static System.Text.StringBuilder t_cachedInstance;

            static /*0x764c0a0*/ System.Text.StringBuilder Acquire(int capacity);
            static /*0x7650074*/ void Release(System.Text.StringBuilder sb);
            static /*0x764c168*/ string GetStringAndRelease(System.Text.StringBuilder sb);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x76500f4*/ void ThrowNotSupportedException();
    }
}
