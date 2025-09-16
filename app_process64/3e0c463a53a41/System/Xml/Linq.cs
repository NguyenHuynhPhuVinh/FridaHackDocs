class <Module>
{
}

class SR
{
    static /*0x762fd18*/ string Format(string resourceFormat, object p1);
    static /*0x762fd88*/ string Format(string resourceFormat, object p1, object p2);
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

                /*0x762fe00*/ BaseUriAnnotation(string baseUri);
            }

            class LineInfoAnnotation
            {
                /*0x10*/ int lineNumber;
                /*0x14*/ int linePosition;

                /*0x762fe30*/ LineInfoAnnotation(int lineNumber, int linePosition);
            }

            class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
            {
                /*0x762fe5c*/ LineInfoEndElementAnnotation(int lineNumber, int linePosition);
            }

            class XAttribute : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XAttribute next;
                /*0x28*/ System.Xml.Linq.XName name;
                /*0x30*/ string value;

                static /*0x7630348*/ void ValidateAttribute(System.Xml.Linq.XName name, string value);
                /*0x762fe88*/ XAttribute(System.Xml.Linq.XName name, object value);
                /*0x7630578*/ XAttribute(System.Xml.Linq.XAttribute other);
                /*0x7630604*/ bool get_IsNamespaceDeclaration();
                /*0x76306bc*/ System.Xml.Linq.XName get_Name();
                /*0x76306c4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x76306cc*/ string get_Value();
                /*0x76306d4*/ string ToString();
                /*0x7630ab0*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
            }

            class XCData : System.Xml.Linq.XText
            {
                /*0x7630df0*/ XCData(string value);
                /*0x7630e70*/ XCData(System.Xml.Linq.XCData other);
                /*0x7630ef0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7630ef8*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7630f68*/ System.Xml.Linq.XNode CloneNode();
            }

            class XComment : System.Xml.Linq.XNode
            {
                /*0x28*/ string value;

                /*0x7630fc0*/ XComment(string value);
                /*0x7631044*/ XComment(System.Xml.Linq.XComment other);
                /*0x76310c0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x76310c8*/ string get_Value();
                /*0x76310d0*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7631140*/ System.Xml.Linq.XNode CloneNode();
            }

            class XContainer : System.Xml.Linq.XNode
            {
                /*0x28*/ object content;

                static /*0x762ff68*/ string GetStringValue(object value);
                /*0x7631198*/ XContainer();
                /*0x76311a0*/ XContainer(System.Xml.Linq.XContainer other);
                /*0x76313bc*/ System.Xml.Linq.XNode get_LastNode();
                /*0x7631504*/ void Add(object content);
                /*0x76322a0*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
                /*0x7632350*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x7632354*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x7631a58*/ void AddContentSkipNotify(object content);
                /*0x7631f18*/ void AddNode(System.Xml.Linq.XNode n);
                /*0x7632358*/ void AddNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x7631f98*/ void AddString(string s);
                /*0x76323d8*/ void AddStringSkipNotify(string s);
                /*0x7632630*/ void AppendNode(System.Xml.Linq.XNode n);
                /*0x76312d8*/ void AppendNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x76329a0*/ void AppendText(System.Text.StringBuilder sb);
                /*0x7632554*/ void ConvertTextToNode();
                /*0x7632a7c*/ void ReadContentFrom(System.Xml.XmlReader r);
                /*0x7633164*/ void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x7633ff8*/ void RemoveNode(System.Xml.Linq.XNode n);
                /*0x76341d8*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x76341dc*/ void ValidateString(string s);
                /*0x76341e0*/ void WriteContentTo(System.Xml.XmlWriter writer);

                class ContentReader
                {
                    /*0x10*/ System.Xml.Linq.NamespaceCache _eCache;
                    /*0x20*/ System.Xml.Linq.NamespaceCache _aCache;
                    /*0x30*/ System.Xml.IXmlLineInfo _lineInfo;
                    /*0x38*/ System.Xml.Linq.XContainer _currentContainer;
                    /*0x40*/ string _baseUri;

                    /*0x7632b7c*/ ContentReader(System.Xml.Linq.XContainer rootContainer);
                    /*0x763328c*/ ContentReader(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                    /*0x7632bac*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r);
                    /*0x7633354*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                }

                class <Nodes>d__18 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__2;

                    /*0x763231c*/ <Nodes>d__18(int <>1__state);
                    /*0x763483c*/ void System.IDisposable.Dispose();
                    /*0x7634840*/ bool MoveNext();
                    /*0x7634900*/ System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current();
                    /*0x7634908*/ void System.Collections.IEnumerator.Reset();
                    /*0x7634940*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7634948*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator();
                    /*0x76349ec*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XDeclaration
            {
                /*0x10*/ string _version;
                /*0x18*/ string _encoding;
                /*0x20*/ string _standalone;

                /*0x76349f0*/ XDeclaration(string version, string encoding, string standalone);
                /*0x7634a50*/ XDeclaration(System.Xml.Linq.XDeclaration other);
                /*0x7634aec*/ string get_Encoding();
                /*0x7634af4*/ string get_Standalone();
                /*0x7634afc*/ string get_Version();
                /*0x7634b04*/ string ToString();
            }

            class XDocument : System.Xml.Linq.XContainer
            {
                /*0x30*/ System.Xml.Linq.XDeclaration _declaration;

                static /*0x7635084*/ bool IsWhitespace(string s);
                /*0x7634d74*/ XDocument();
                /*0x7634d7c*/ XDocument(System.Xml.Linq.XDocument other);
                /*0x7634e08*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x7634e10*/ void set_Declaration(System.Xml.Linq.XDeclaration value);
                /*0x7634e18*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7634e20*/ System.Xml.Linq.XElement get_Root();
                /*0x7634e68*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7634f94*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x7634fe0*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x763502c*/ System.Xml.Linq.XNode CloneNode();
                /*0x3907c14*/ T GetFirstNode<T>();
                /*0x7635118*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x76352bc*/ void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter);
                /*0x76353e0*/ void ValidateString(string s);
            }

            class XDocumentType : System.Xml.Linq.XNode
            {
                /*0x28*/ string _name;
                /*0x30*/ string _publicId;
                /*0x38*/ string _systemId;
                /*0x40*/ string _internalSubset;

                /*0x763454c*/ XDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x7635440*/ XDocumentType(System.Xml.Linq.XDocumentType other);
                /*0x76354ec*/ string get_InternalSubset();
                /*0x76354f4*/ string get_Name();
                /*0x76354fc*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7635504*/ string get_PublicId();
                /*0x763550c*/ string get_SystemId();
                /*0x7635514*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7635584*/ System.Xml.Linq.XNode CloneNode();
            }

            class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
            {
                /*0x30*/ System.Xml.Linq.XName name;
                /*0x38*/ System.Xml.Linq.XAttribute lastAttr;

                /*0x76343c8*/ XElement(System.Xml.Linq.XName name);
                /*0x76355dc*/ XElement(System.Xml.Linq.XElement other);
                /*0x7632218*/ XElement(System.Xml.Linq.XStreamingElement other);
                /*0x7635688*/ bool get_HasAttributes();
                /*0x7635698*/ bool get_IsEmpty();
                /*0x76356a8*/ System.Xml.Linq.XName get_Name();
                /*0x76356b0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x76356b8*/ string get_Value();
                /*0x763572c*/ System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name);
                /*0x7635768*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
                /*0x7630bdc*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
                /*0x7635908*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7635b54*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7635b5c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7635d60*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x7635d6c*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x7635f68*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x7635e54*/ void AppendAttribute(System.Xml.Linq.XAttribute a);
                /*0x7634444*/ void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x7636050*/ System.Xml.Linq.XNode CloneNode();
                /*0x7635770*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name);
                /*0x7635814*/ string GetNamespaceOfPrefixInScope(string prefix, System.Xml.Linq.XElement outOfScope);
                /*0x7635ce8*/ void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x76360dc*/ void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x76346f8*/ void SetEndElementLineInfo(int lineNumber, int linePosition);
                /*0x7636878*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);

                class <GetAttributes>d__116 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XAttribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XElement <>4__this;
                    /*0x30*/ System.Xml.Linq.XName name;
                    /*0x38*/ System.Xml.Linq.XName <>3__name;
                    /*0x40*/ System.Xml.Linq.XAttribute <a>5__2;

                    /*0x76360a8*/ <GetAttributes>d__116(int <>1__state);
                    /*0x76369ac*/ void System.IDisposable.Dispose();
                    /*0x76369b0*/ bool MoveNext();
                    /*0x7636a88*/ System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current();
                    /*0x7636a90*/ void System.Collections.IEnumerator.Reset();
                    /*0x7636ac8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7636ad0*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator();
                    /*0x7636b84*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XHashtable<TValue>
            {
                /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;

                /*0x380d8b8*/ XHashtable(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                bool TryGetValue(string key, int index, int count, ref TValue value);
                /*0x3907c14*/ TValue Add(TValue value);

                class ExtractKeyDelegate<TValue> : System.MulticastDelegate
                {
                    ExtractKeyDelegate(object object, nint method);
                    /*0x3907c14*/ string Invoke(TValue value);
                }

                class XHashtableState<TValue>
                {
                    /*0x0*/ int[] _buckets;
                    /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue> _entries;
                    /*0x0*/ int _numEntries;
                    /*0x0*/ System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;

                    static /*0x3826a54*/ int ComputeHashCode(string key, int index, int count);
                    /*0x380d8b8*/ XHashtableState(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                    /*0x380b9e8*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize();
                    bool TryGetValue(string key, int index, int count, ref TValue value);
                    /*0x3907c14*/ bool TryAdd(TValue value, ref TValue newValue);
                    /*0x3907c14*/ bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex);

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

                /*0x763431c*/ System.Xml.Linq.XNamespace Get(string namespaceName);
            }

            struct ElementWriter
            {
                /*0x10*/ System.Xml.XmlWriter _writer;
                /*0x18*/ System.Xml.Linq.NamespaceResolver _resolver;

                /*0x76359a0*/ ElementWriter(System.Xml.XmlWriter writer);
                /*0x76359c0*/ void WriteElement(System.Xml.Linq.XElement e);
                /*0x7636e5c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);
                /*0x7636b88*/ void PushAncestors(System.Xml.Linq.XElement e);
                /*0x7637130*/ void PushElement(System.Xml.Linq.XElement e);
                /*0x7636e04*/ void WriteEndElement();
                /*0x7636e30*/ void WriteFullEndElement();
                /*0x7636ca4*/ void WriteStartElement(System.Xml.Linq.XElement e);
            }

            struct NamespaceResolver
            {
                /*0x10*/ int _scope;
                /*0x18*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;
                /*0x20*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;

                /*0x76371e4*/ void PushScope();
                /*0x76372d8*/ void PopScope();
                /*0x76371f4*/ void Add(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x7637040*/ void AddFirst(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x7636f4c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);

                class NamespaceDeclaration
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ System.Xml.Linq.XNamespace ns;
                    /*0x20*/ int scope;
                    /*0x28*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;

                    /*0x763737c*/ NamespaceDeclaration();
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

                static /*0x76374f4*/ System.Xml.Linq.XName Get(string expandedName);
                static /*0x7637a78*/ System.Xml.Linq.XName Get(string localName, string namespaceName);
                static /*0x7637a9c*/ System.Xml.Linq.XName op_Implicit(string expandedName);
                static /*0x762ff5c*/ bool op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                /*0x7637384*/ XName(System.Xml.Linq.XNamespace ns, string localName);
                /*0x7637b00*/ XName();
                /*0x7637454*/ string get_LocalName();
                /*0x763745c*/ System.Xml.Linq.XNamespace get_Namespace();
                /*0x76306a0*/ string get_NamespaceName();
                /*0x7637464*/ string ToString();
                /*0x7637aa8*/ bool Equals(object obj);
                /*0x7637ab4*/ int GetHashCode();
                /*0x7637abc*/ bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other);
                /*0x7637ac8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x7637a1c*/ System.Xml.Linq.XNamespace get_None();
                static /*0x7637d34*/ System.Xml.Linq.XNamespace get_Xml();
                static /*0x7637d94*/ System.Xml.Linq.XNamespace get_Xmlns();
                static /*0x76365bc*/ System.Xml.Linq.XNamespace Get(string namespaceName);
                static /*0x7637df4*/ System.Xml.Linq.XNamespace op_Implicit(string namespaceName);
                static /*0x7635808*/ bool op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x7637e1c*/ bool op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x763763c*/ System.Xml.Linq.XNamespace Get(string namespaceName, int index, int count);
                static /*0x7637e28*/ string ExtractLocalName(System.Xml.Linq.XName n);
                static /*0x7637e40*/ string ExtractNamespace(System.WeakReference r);
                static /*0x7637c54*/ System.Xml.Linq.XNamespace EnsureNamespace(ref System.WeakReference refNmsp, string namespaceName);
                /*0x7637b38*/ XNamespace(string namespaceName);
                /*0x7637c44*/ string get_NamespaceName();
                /*0x7634368*/ System.Xml.Linq.XName GetName(string localName);
                /*0x7637c4c*/ string ToString();
                /*0x7637e08*/ bool Equals(object obj);
                /*0x7637e14*/ int GetHashCode();
                /*0x7637914*/ System.Xml.Linq.XName GetName(string localName, int index, int count);
            }

            class XNode : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XNode next;

                /*0x763103c*/ XNode();
                /*0x7637eb8*/ void Remove();
                /*0x7637f18*/ string ToString();
                /*0x380d83c*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7638480*/ void AppendText(System.Text.StringBuilder sb);
                /*0x380b9e8*/ System.Xml.Linq.XNode CloneNode();
                /*0x7638008*/ string GetXmlString(System.Xml.Linq.SaveOptions o);
            }

            class XObject : System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.Linq.XContainer parent;
                /*0x18*/ object annotations;

                /*0x762ff54*/ XObject();
                /*0x76347bc*/ string get_BaseUri();
                /*0x380b6a0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7638484*/ System.Xml.Linq.XElement get_Parent();
                /*0x763661c*/ void AddAnnotation(object annotation);
                /*0x7638500*/ object AnnotationForSealedType(System.Type type);
                /*0x3907c14*/ T Annotation<T>();
                /*0x7638640*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x7638694*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x76386e8*/ int System.Xml.IXmlLineInfo.get_LinePosition();
                /*0x7634768*/ bool get_HasBaseUri();
                /*0x76327ec*/ bool NotifyChanged(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x7632744*/ bool NotifyChanging(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x7634610*/ void SetBaseUri(string baseUri);
                /*0x7634688*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x76319e8*/ bool SkipNotify();
                /*0x7637f34*/ System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations();
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

                static /*0x76387a8*/ XObjectChangeEventArgs();
                /*0x763873c*/ XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange);
            }

            class XProcessingInstruction : System.Xml.Linq.XNode
            {
                /*0x28*/ string target;
                /*0x30*/ string data;

                static /*0x7638888*/ void ValidateName(string name);
                /*0x76344b4*/ XProcessingInstruction(string target, string data);
                /*0x7638960*/ XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other);
                /*0x76389ec*/ string get_Data();
                /*0x76389f4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x76389fc*/ string get_Target();
                /*0x7638a04*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7638a74*/ System.Xml.Linq.XNode CloneNode();
            }

            class XStreamingElement
            {
                /*0x10*/ System.Xml.Linq.XName name;
                /*0x18*/ object content;
            }

            class XText : System.Xml.Linq.XNode
            {
                /*0x28*/ string text;

                /*0x7630df4*/ XText(string value);
                /*0x7630e74*/ XText(System.Xml.Linq.XText other);
                /*0x7638acc*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7638ad4*/ string get_Value();
                /*0x7632894*/ void set_Value(string value);
                /*0x7638adc*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x7638bc8*/ void AppendText(System.Text.StringBuilder sb);
                /*0x7638bec*/ System.Xml.Linq.XNode CloneNode();
            }
        }
    }

    namespace Text
    {
        class StringBuilderCache
        {
            [ThreadStatic] static System.Text.StringBuilder t_cachedInstance;

            static /*0x7634c70*/ System.Text.StringBuilder Acquire(int capacity);
            static /*0x7638c44*/ void Release(System.Text.StringBuilder sb);
            static /*0x7634d38*/ string GetStringAndRelease(System.Text.StringBuilder sb);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x7638cc4*/ void ThrowNotSupportedException();
    }
}
