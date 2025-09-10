class <Module>
{
}

class SR
{
    static /*0xbee458*/ string Format(string resourceFormat, object p1);
    static /*0xbee4c8*/ string Format(string resourceFormat, object p1, object p2);
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

                /*0xbee540*/ BaseUriAnnotation(string baseUri);
            }

            class LineInfoAnnotation
            {
                /*0x10*/ int lineNumber;
                /*0x14*/ int linePosition;

                /*0xbee568*/ LineInfoAnnotation(int lineNumber, int linePosition);
            }

            class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
            {
                /*0xbee594*/ LineInfoEndElementAnnotation(int lineNumber, int linePosition);
            }

            class XAttribute : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XAttribute next;
                /*0x28*/ System.Xml.Linq.XName name;
                /*0x30*/ string value;

                static /*0xbeea90*/ void ValidateAttribute(System.Xml.Linq.XName name, string value);
                /*0xbee5c0*/ XAttribute(System.Xml.Linq.XName name, object value);
                /*0xbeecc0*/ XAttribute(System.Xml.Linq.XAttribute other);
                /*0xbeed3c*/ bool get_IsNamespaceDeclaration();
                /*0xbeedf4*/ System.Xml.Linq.XName get_Name();
                /*0xbeedfc*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbeee04*/ string get_Value();
                /*0xbeee0c*/ void set_Value(string value);
                /*0xbef05c*/ string ToString();
                /*0xbef430*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
            }

            class XCData : System.Xml.Linq.XText
            {
                /*0xbef78c*/ XCData(string value);
                /*0xbef808*/ XCData(System.Xml.Linq.XCData other);
                /*0xbef888*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbef890*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbef904*/ System.Xml.Linq.XNode CloneNode();
            }

            class XComment : System.Xml.Linq.XNode
            {
                /*0x28*/ string value;

                /*0xbef964*/ XComment(string value);
                /*0xbef9e4*/ XComment(System.Xml.Linq.XComment other);
                /*0xbefa60*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbefa68*/ string get_Value();
                /*0xbefa70*/ void set_Value(string value);
                /*0xbefb64*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbefbd8*/ System.Xml.Linq.XNode CloneNode();
            }

            class XContainer : System.Xml.Linq.XNode
            {
                /*0x28*/ object content;

                static /*0xbee690*/ string GetStringValue(object value);
                /*0xbefc38*/ XContainer();
                /*0xbefc40*/ XContainer(System.Xml.Linq.XContainer other);
                /*0xbefe3c*/ System.Xml.Linq.XNode get_LastNode();
                /*0xbeff78*/ void Add(object content);
                /*0xbf0d00*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
                /*0xbf0dac*/ void RemoveNodes();
                /*0xbf1190*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0xbf1194*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0xbf04d8*/ void AddContentSkipNotify(object content);
                /*0xbf09a4*/ void AddNode(System.Xml.Linq.XNode n);
                /*0xbf1198*/ void AddNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0xbf0a24*/ void AddString(string s);
                /*0xbf1218*/ void AddStringSkipNotify(string s);
                /*0xbf136c*/ void AppendNode(System.Xml.Linq.XNode n);
                /*0xbefd7c*/ void AppendNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0xbf1578*/ void AppendText(System.Text.StringBuilder sb);
                /*0xbf10e4*/ void ConvertTextToNode();
                /*0xbf1664*/ void ReadContentFrom(System.Xml.XmlReader r);
                /*0xbf1d84*/ void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0xbf2bc4*/ void RemoveNode(System.Xml.Linq.XNode n);
                /*0xbf1048*/ void RemoveNodesSkipNotify();
                /*0xbf2d64*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0xbf2d68*/ void ValidateString(string s);
                /*0xbf2d6c*/ void WriteContentTo(System.Xml.XmlWriter writer);

                class ContentReader
                {
                    /*0x10*/ System.Xml.Linq.NamespaceCache _eCache;
                    /*0x20*/ System.Xml.Linq.NamespaceCache _aCache;
                    /*0x30*/ System.Xml.IXmlLineInfo _lineInfo;
                    /*0x38*/ System.Xml.Linq.XContainer _currentContainer;
                    /*0x40*/ string _baseUri;

                    /*0xbf1760*/ ContentReader(System.Xml.Linq.XContainer rootContainer);
                    /*0xbf1eb0*/ ContentReader(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                    /*0xbf1788*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r);
                    /*0xbf1f58*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                }

                class <Nodes>d__18 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__2;

                    /*0xbf0d78*/ <Nodes>d__18(int <>1__state);
                    /*0xbf335c*/ void System.IDisposable.Dispose();
                    /*0xbf3360*/ bool MoveNext();
                    /*0xbf33f0*/ System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current();
                    /*0xbf33f8*/ void System.Collections.IEnumerator.Reset();
                    /*0xbf3438*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbf3440*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator();
                    /*0xbf34e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XDeclaration
            {
                /*0x10*/ string _version;
                /*0x18*/ string _encoding;
                /*0x20*/ string _standalone;

                /*0xbf34e8*/ XDeclaration(string version, string encoding, string standalone);
                /*0xbf3524*/ XDeclaration(System.Xml.Linq.XDeclaration other);
                /*0xbf35a8*/ string get_Encoding();
                /*0xbf35b0*/ void set_Encoding(string value);
                /*0xbf35b8*/ string get_Standalone();
                /*0xbf35c0*/ void set_Standalone(string value);
                /*0xbf35c8*/ string get_Version();
                /*0xbf35d0*/ string ToString();
            }

            class XDocument : System.Xml.Linq.XContainer
            {
                /*0x30*/ System.Xml.Linq.XDeclaration _declaration;

                static /*0xbf3b54*/ bool IsWhitespace(string s);
                /*0xbf3840*/ XDocument();
                /*0xbf3848*/ XDocument(System.Xml.Linq.XDocument other);
                /*0xbf38c4*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0xbf38cc*/ void set_Declaration(System.Xml.Linq.XDeclaration value);
                /*0xbf38d4*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbf38dc*/ System.Xml.Linq.XElement get_Root();
                /*0xbf3924*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf3a54*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0xbf3aa4*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0xbf3af4*/ System.Xml.Linq.XNode CloneNode();
                T GetFirstNode<T>();
                /*0xbf3be0*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0xbf3d8c*/ void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter);
                /*0xbf3eb8*/ void ValidateString(string s);
            }

            class XDocumentType : System.Xml.Linq.XNode
            {
                /*0x28*/ string _name;
                /*0x30*/ string _publicId;
                /*0x38*/ string _systemId;
                /*0x40*/ string _internalSubset;

                /*0xbf3088*/ XDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0xbf3f1c*/ XDocumentType(System.Xml.Linq.XDocumentType other);
                /*0xbf3fa0*/ string get_InternalSubset();
                /*0xbf3fa8*/ string get_Name();
                /*0xbf3fb0*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbf3fb8*/ string get_PublicId();
                /*0xbf3fc0*/ string get_SystemId();
                /*0xbf3fc8*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf403c*/ System.Xml.Linq.XNode CloneNode();
            }

            class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
            {
                /*0x30*/ System.Xml.Linq.XName name;
                /*0x38*/ System.Xml.Linq.XAttribute lastAttr;

                /*0xbf2f54*/ XElement(System.Xml.Linq.XName name);
                /*0xbf409c*/ XElement(System.Xml.Linq.XElement other);
                /*0xbf0c7c*/ XElement(System.Xml.Linq.XStreamingElement other);
                /*0xbf415c*/ bool get_HasAttributes();
                /*0xbf416c*/ bool get_IsEmpty();
                /*0xbf417c*/ System.Xml.Linq.XName get_Name();
                /*0xbf4184*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbf418c*/ string get_Value();
                /*0xbf4220*/ void set_Value(string value);
                /*0xbf4298*/ System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name);
                /*0xbf42d4*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
                /*0xbef568*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
                /*0xbf4464*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf469c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xbf46a4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xbf48c0*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0xbf48cc*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0xbf4af4*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0xbf49bc*/ void AppendAttribute(System.Xml.Linq.XAttribute a);
                /*0xbf2fcc*/ void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0xbf4c00*/ System.Xml.Linq.XNode CloneNode();
                /*0xbf42dc*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name);
                /*0xbf4370*/ string GetNamespaceOfPrefixInScope(string prefix, System.Xml.Linq.XElement outOfScope);
                /*0xbf4848*/ void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0xbf4c94*/ void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0xbf3204*/ void SetEndElementLineInfo(int lineNumber, int linePosition);
                /*0xbf5408*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);

                class <GetAttributes>d__116 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XAttribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XElement <>4__this;
                    /*0x30*/ System.Xml.Linq.XName name;
                    /*0x38*/ System.Xml.Linq.XName <>3__name;
                    /*0x40*/ System.Xml.Linq.XAttribute <a>5__2;

                    /*0xbf4c60*/ <GetAttributes>d__116(int <>1__state);
                    /*0xbf5544*/ void System.IDisposable.Dispose();
                    /*0xbf5548*/ bool MoveNext();
                    /*0xbf55f0*/ System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current();
                    /*0xbf55f8*/ void System.Collections.IEnumerator.Reset();
                    /*0xbf5638*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbf5640*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator();
                    /*0xbf56ec*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XHashtable<TValue>
            {
                /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;

                XHashtable(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                bool TryGetValue(string key, int index, int count, ref TValue value);
                TValue Add(TValue value);

                class ExtractKeyDelegate<TValue> : System.MulticastDelegate
                {
                    ExtractKeyDelegate(object object, nint method);
                    string Invoke(TValue value);
                }

                class XHashtableState<TValue>
                {
                    /*0x0*/ int[] _buckets;
                    /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue> _entries;
                    /*0x0*/ int _numEntries;
                    /*0x0*/ System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;

                    static int ComputeHashCode(string key, int index, int count);
                    XHashtableState(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                    System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize();
                    bool TryGetValue(string key, int index, int count, ref TValue value);
                    bool TryAdd(TValue value, ref TValue newValue);
                    bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex);

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

                /*0xbf2ebc*/ System.Xml.Linq.XNamespace Get(string namespaceName);
            }

            struct ElementWriter
            {
                /*0x10*/ System.Xml.XmlWriter _writer;
                /*0x18*/ System.Xml.Linq.NamespaceResolver _resolver;

                /*0xbf44e8*/ ElementWriter(System.Xml.XmlWriter writer);
                /*0xbf44f4*/ void WriteElement(System.Xml.Linq.XElement e);
                /*0xbf59d0*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);
                /*0xbf56f0*/ void PushAncestors(System.Xml.Linq.XElement e);
                /*0xbf5c40*/ void PushElement(System.Xml.Linq.XElement e);
                /*0xbf5978*/ void WriteEndElement();
                /*0xbf59a4*/ void WriteFullEndElement();
                /*0xbf5818*/ void WriteStartElement(System.Xml.Linq.XElement e);
            }

            struct NamespaceResolver
            {
                /*0x10*/ int _scope;
                /*0x18*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;
                /*0x20*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;

                /*0xbf5d14*/ void PushScope();
                /*0xbf5dc0*/ void PopScope();
                /*0xbf5d24*/ void Add(string prefix, System.Xml.Linq.XNamespace ns);
                /*0xbf5ba8*/ void AddFirst(string prefix, System.Xml.Linq.XNamespace ns);
                /*0xbf5acc*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);

                class NamespaceDeclaration
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ System.Xml.Linq.XNamespace ns;
                    /*0x20*/ int scope;
                    /*0x28*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;

                    /*0xbf5e38*/ NamespaceDeclaration();
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

                static /*0xbf5f98*/ System.Xml.Linq.XName Get(string expandedName);
                static /*0xbf6548*/ System.Xml.Linq.XName Get(string localName, string namespaceName);
                static /*0xbf656c*/ System.Xml.Linq.XName op_Implicit(string expandedName);
                static /*0xbee684*/ bool op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                /*0xbf5e40*/ XName(System.Xml.Linq.XNamespace ns, string localName);
                /*0xbf65d8*/ XName();
                /*0xbf5ef8*/ string get_LocalName();
                /*0xbf5f00*/ System.Xml.Linq.XNamespace get_Namespace();
                /*0xbeedd8*/ string get_NamespaceName();
                /*0xbf5f08*/ string ToString();
                /*0xbf6578*/ bool Equals(object obj);
                /*0xbf6584*/ int GetHashCode();
                /*0xbf658c*/ bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other);
                /*0xbf6598*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0xbf64e0*/ System.Xml.Linq.XNamespace get_None();
                static /*0xbf67fc*/ System.Xml.Linq.XNamespace get_Xml();
                static /*0xbf685c*/ System.Xml.Linq.XNamespace get_Xmlns();
                static /*0xbf5188*/ System.Xml.Linq.XNamespace Get(string namespaceName);
                static /*0xbf68bc*/ System.Xml.Linq.XNamespace op_Implicit(string namespaceName);
                static /*0xbf4364*/ bool op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0xbf68dc*/ bool op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0xbf60ec*/ System.Xml.Linq.XNamespace Get(string namespaceName, int index, int count);
                static /*0xbf68e8*/ string ExtractLocalName(System.Xml.Linq.XName n);
                static /*0xbf6900*/ string ExtractNamespace(System.WeakReference r);
                static /*0xbf6710*/ System.Xml.Linq.XNamespace EnsureNamespace(ref System.WeakReference refNmsp, string namespaceName);
                /*0xbf6610*/ XNamespace(string namespaceName);
                /*0xbf6700*/ string get_NamespaceName();
                /*0xbf2ef0*/ System.Xml.Linq.XName GetName(string localName);
                /*0xbf6708*/ string ToString();
                /*0xbf68c8*/ bool Equals(object obj);
                /*0xbf68d4*/ int GetHashCode();
                /*0xbf63d4*/ System.Xml.Linq.XName GetName(string localName, int index, int count);
            }

            class XNode : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XNode next;

                /*0xbef9dc*/ XNode();
                /*0xbf6978*/ void Remove();
                /*0xbf69dc*/ string ToString();
                void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf6f48*/ void AppendText(System.Text.StringBuilder sb);
                System.Xml.Linq.XNode CloneNode();
                /*0xbf6ad8*/ string GetXmlString(System.Xml.Linq.SaveOptions o);
            }

            class XObject : System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.Linq.XContainer parent;
                /*0x18*/ object annotations;

                /*0xbee67c*/ XObject();
                /*0xbf32d0*/ string get_BaseUri();
                System.Xml.XmlNodeType get_NodeType();
                /*0xbf6f4c*/ System.Xml.Linq.XElement get_Parent();
                /*0xbf51ec*/ void AddAnnotation(object annotation);
                /*0xbf6fc8*/ object AnnotationForSealedType(System.Type type);
                T Annotation<T>();
                /*0xbf710c*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0xbf7160*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0xbf71b4*/ int System.Xml.IXmlLineInfo.get_LinePosition();
                /*0xbf327c*/ bool get_HasBaseUri();
                /*0xbeefb4*/ bool NotifyChanged(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0xbeef0c*/ bool NotifyChanging(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0xbf3118*/ void SetBaseUri(string baseUri);
                /*0xbf318c*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0xbf0468*/ bool SkipNotify();
                /*0xbf69f8*/ System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations();
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

                static /*0xbf7274*/ XObjectChangeEventArgs();
                /*0xbf7208*/ XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange);
            }

            class XProcessingInstruction : System.Xml.Linq.XNode
            {
                /*0x28*/ string target;
                /*0x30*/ string data;

                static /*0xbf733c*/ void ValidateName(string name);
                /*0xbf3004*/ XProcessingInstruction(string target, string data);
                /*0xbf741c*/ XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other);
                /*0xbf7498*/ string get_Data();
                /*0xbf74a0*/ void set_Data(string value);
                /*0xbf7594*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbf759c*/ string get_Target();
                /*0xbf75a4*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf7618*/ System.Xml.Linq.XNode CloneNode();
            }

            class XStreamingElement
            {
                /*0x10*/ System.Xml.Linq.XName name;
                /*0x18*/ object content;
            }

            class XText : System.Xml.Linq.XNode
            {
                /*0x28*/ string text;

                /*0xbef790*/ XText(string value);
                /*0xbef80c*/ XText(System.Xml.Linq.XText other);
                /*0xbf7678*/ System.Xml.XmlNodeType get_NodeType();
                /*0xbf7680*/ string get_Value();
                /*0xbf1484*/ void set_Value(string value);
                /*0xbf7688*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0xbf777c*/ void AppendText(System.Text.StringBuilder sb);
                /*0xbf77a0*/ System.Xml.Linq.XNode CloneNode();
            }
        }
    }

    namespace Text
    {
        class StringBuilderCache
        {
            [ThreadStatic] static System.Text.StringBuilder t_cachedInstance;

            static /*0xbf373c*/ System.Text.StringBuilder Acquire(int capacity);
            static /*0xbf7800*/ void Release(System.Text.StringBuilder sb);
            static /*0xbf3804*/ string GetStringAndRelease(System.Text.StringBuilder sb);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0xbf7878*/ void ThrowNotSupportedException();
    }
}
