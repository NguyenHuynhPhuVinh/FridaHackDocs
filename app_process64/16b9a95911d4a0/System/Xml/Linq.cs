class <Module>
{
}

class SR
{
    static /*0x37fcb98*/ string Format(string resourceFormat, object p1);
    static /*0x37fcc08*/ string Format(string resourceFormat, object p1, object p2);
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

                /*0x37fcc80*/ BaseUriAnnotation(string baseUri);
            }

            class LineInfoAnnotation
            {
                /*0x10*/ int lineNumber;
                /*0x14*/ int linePosition;

                /*0x37fccb0*/ LineInfoAnnotation(int lineNumber, int linePosition);
            }

            class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
            {
                /*0x37fccdc*/ LineInfoEndElementAnnotation(int lineNumber, int linePosition);
            }

            class XAttribute : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XAttribute next;
                /*0x28*/ System.Xml.Linq.XName name;
                /*0x30*/ string value;

                static /*0x37fd16c*/ void ValidateAttribute(System.Xml.Linq.XName name, string value);
                /*0x37fcd08*/ XAttribute(System.Xml.Linq.XName name, object value);
                /*0x37fd39c*/ XAttribute(System.Xml.Linq.XAttribute other);
                /*0x37fd428*/ bool get_IsNamespaceDeclaration();
                /*0x37fd4dc*/ System.Xml.Linq.XName get_Name();
                /*0x37fd4e4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x37fd4ec*/ string get_Value();
                /*0x37fd4f4*/ string ToString();
                /*0x37fd828*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
            }

            class XCData : System.Xml.Linq.XText
            {
                /*0x37fdb68*/ XCData(string value);
                /*0x37fdbe8*/ XCData(System.Xml.Linq.XCData other);
                /*0x37fdc68*/ System.Xml.XmlNodeType get_NodeType();
                /*0x37fdc70*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x37fdcdc*/ System.Xml.Linq.XNode CloneNode();
            }

            class XComment : System.Xml.Linq.XNode
            {
                /*0x28*/ string value;

                /*0x37fdd34*/ XComment(string value);
                /*0x37fddb8*/ XComment(System.Xml.Linq.XComment other);
                /*0x37fde34*/ System.Xml.XmlNodeType get_NodeType();
                /*0x37fde3c*/ string get_Value();
                /*0x37fde44*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x37fdeb0*/ System.Xml.Linq.XNode CloneNode();
            }

            class XContainer : System.Xml.Linq.XNode
            {
                /*0x28*/ object content;

                static /*0x37fcde8*/ string GetStringValue(object value);
                /*0x37fdf08*/ XContainer();
                /*0x37fdf10*/ XContainer(System.Xml.Linq.XContainer other);
                /*0x37fe128*/ System.Xml.Linq.XNode get_LastNode();
                /*0x37fe270*/ void Add(object content);
                /*0x37fee0c*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
                /*0x37feec0*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x37feec4*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x37fe6c0*/ void AddContentSkipNotify(object content);
                /*0x37fea78*/ void AddNode(System.Xml.Linq.XNode n);
                /*0x37feec8*/ void AddNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x37feaf8*/ void AddString(string s);
                /*0x37fef48*/ void AddStringSkipNotify(string s);
                /*0x37ff1a0*/ void AppendNode(System.Xml.Linq.XNode n);
                /*0x37fe048*/ void AppendNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x37ff518*/ void AppendText(System.Text.StringBuilder sb);
                /*0x37ff0c4*/ void ConvertTextToNode();
                /*0x37ff5f4*/ void ReadContentFrom(System.Xml.XmlReader r);
                /*0x37ffd20*/ void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x3800b54*/ void RemoveNode(System.Xml.Linq.XNode n);
                /*0x3800d34*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x3800d38*/ void ValidateString(string s);
                /*0x3800d3c*/ void WriteContentTo(System.Xml.XmlWriter writer);

                class ContentReader
                {
                    /*0x10*/ System.Xml.Linq.NamespaceCache _eCache;
                    /*0x20*/ System.Xml.Linq.NamespaceCache _aCache;
                    /*0x30*/ System.Xml.IXmlLineInfo _lineInfo;
                    /*0x38*/ System.Xml.Linq.XContainer _currentContainer;
                    /*0x40*/ string _baseUri;

                    /*0x37ff6f4*/ ContentReader(System.Xml.Linq.XContainer rootContainer);
                    /*0x37ffe48*/ ContentReader(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                    /*0x37ff724*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r);
                    /*0x37fff10*/ bool ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                }

                class <Nodes>d__18 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__2;

                    /*0x37fee8c*/ <Nodes>d__18(int <>1__state);
                    /*0x3801398*/ void System.IDisposable.Dispose();
                    /*0x380139c*/ bool MoveNext();
                    /*0x380145c*/ System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current();
                    /*0x3801464*/ void System.Collections.IEnumerator.Reset();
                    /*0x380149c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38014a4*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator();
                    /*0x3801548*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XDeclaration
            {
                /*0x10*/ string _version;
                /*0x18*/ string _encoding;
                /*0x20*/ string _standalone;

                /*0x380154c*/ XDeclaration(string version, string encoding, string standalone);
                /*0x38015ac*/ XDeclaration(System.Xml.Linq.XDeclaration other);
                /*0x3801648*/ string get_Encoding();
                /*0x3801650*/ string get_Standalone();
                /*0x3801658*/ string get_Version();
                /*0x3801660*/ string ToString();
            }

            class XDocument : System.Xml.Linq.XContainer
            {
                /*0x30*/ System.Xml.Linq.XDeclaration _declaration;

                static /*0x3801be0*/ bool IsWhitespace(string s);
                /*0x38018d0*/ XDocument();
                /*0x38018d8*/ XDocument(System.Xml.Linq.XDocument other);
                /*0x3801964*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x380196c*/ void set_Declaration(System.Xml.Linq.XDeclaration value);
                /*0x3801974*/ System.Xml.XmlNodeType get_NodeType();
                /*0x380197c*/ System.Xml.Linq.XElement get_Root();
                /*0x38019c4*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x3801af0*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x3801b3c*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x3801b88*/ System.Xml.Linq.XNode CloneNode();
                /*0x1ffc854*/ T GetFirstNode<T>();
                /*0x3801c6c*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x3801e1c*/ void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter);
                /*0x3801f3c*/ void ValidateString(string s);
            }

            class XDocumentType : System.Xml.Linq.XNode
            {
                /*0x28*/ string _name;
                /*0x30*/ string _publicId;
                /*0x38*/ string _systemId;
                /*0x40*/ string _internalSubset;

                /*0x38010a8*/ XDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x3801f9c*/ XDocumentType(System.Xml.Linq.XDocumentType other);
                /*0x3802048*/ string get_InternalSubset();
                /*0x3802050*/ string get_Name();
                /*0x3802058*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3802060*/ string get_PublicId();
                /*0x3802068*/ string get_SystemId();
                /*0x3802070*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x38020dc*/ System.Xml.Linq.XNode CloneNode();
            }

            class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
            {
                /*0x30*/ System.Xml.Linq.XName name;
                /*0x38*/ System.Xml.Linq.XAttribute lastAttr;

                /*0x3800f24*/ XElement(System.Xml.Linq.XName name);
                /*0x3802134*/ XElement(System.Xml.Linq.XElement other);
                /*0x37fed84*/ XElement(System.Xml.Linq.XStreamingElement other);
                /*0x38021e0*/ bool get_HasAttributes();
                /*0x38021f0*/ bool get_IsEmpty();
                /*0x3802200*/ System.Xml.Linq.XName get_Name();
                /*0x3802208*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3802210*/ string get_Value();
                /*0x3802280*/ System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name);
                /*0x38022bc*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
                /*0x37fd954*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
                /*0x3802460*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x38026a8*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x38026b0*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x38028bc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x38028c8*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x3802ac4*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x38029b0*/ void AppendAttribute(System.Xml.Linq.XAttribute a);
                /*0x3800fa0*/ void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x3802bac*/ System.Xml.Linq.XNode CloneNode();
                /*0x38022c4*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name);
                /*0x380236c*/ string GetNamespaceOfPrefixInScope(string prefix, System.Xml.Linq.XElement outOfScope);
                /*0x3802844*/ void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x3802c38*/ void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x3801254*/ void SetEndElementLineInfo(int lineNumber, int linePosition);
                /*0x38033cc*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);

                class <GetAttributes>d__116 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XAttribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XElement <>4__this;
                    /*0x30*/ System.Xml.Linq.XName name;
                    /*0x38*/ System.Xml.Linq.XName <>3__name;
                    /*0x40*/ System.Xml.Linq.XAttribute <a>5__2;

                    /*0x3802c04*/ <GetAttributes>d__116(int <>1__state);
                    /*0x3803500*/ void System.IDisposable.Dispose();
                    /*0x3803504*/ bool MoveNext();
                    /*0x38035dc*/ System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current();
                    /*0x38035e4*/ void System.Collections.IEnumerator.Reset();
                    /*0x380361c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3803624*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator();
                    /*0x38036d8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class XHashtable<TValue>
            {
                /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;

                /*0x1f30ee8*/ XHashtable(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                bool TryGetValue(string key, int index, int count, ref TValue value);
                /*0x1ffc854*/ TValue Add(TValue value);

                class ExtractKeyDelegate<TValue> : System.MulticastDelegate
                {
                    ExtractKeyDelegate(object object, nint method);
                    /*0x1ffc854*/ string Invoke(TValue value);
                }

                class XHashtableState<TValue>
                {
                    /*0x0*/ int[] _buckets;
                    /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue> _entries;
                    /*0x0*/ int _numEntries;
                    /*0x0*/ System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;

                    static /*0x1f32080*/ int ComputeHashCode(string key, int index, int count);
                    /*0x1f30ee8*/ XHashtableState(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                    /*0x1f30214*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize();
                    bool TryGetValue(string key, int index, int count, ref TValue value);
                    /*0x1ffc854*/ bool TryAdd(TValue value, ref TValue newValue);
                    /*0x1ffc854*/ bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex);

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

                /*0x3800e7c*/ System.Xml.Linq.XNamespace Get(string namespaceName);
            }

            struct ElementWriter
            {
                /*0x10*/ System.Xml.XmlWriter _writer;
                /*0x18*/ System.Xml.Linq.NamespaceResolver _resolver;

                /*0x38024f8*/ ElementWriter(System.Xml.XmlWriter writer);
                /*0x3802518*/ void WriteElement(System.Xml.Linq.XElement e);
                /*0x38039a4*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);
                /*0x38036dc*/ void PushAncestors(System.Xml.Linq.XElement e);
                /*0x3803c70*/ void PushElement(System.Xml.Linq.XElement e);
                /*0x380394c*/ void WriteEndElement();
                /*0x3803978*/ void WriteFullEndElement();
                /*0x38037ec*/ void WriteStartElement(System.Xml.Linq.XElement e);
            }

            struct NamespaceResolver
            {
                /*0x10*/ int _scope;
                /*0x18*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;
                /*0x20*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;

                /*0x3803d24*/ void PushScope();
                /*0x3803e18*/ void PopScope();
                /*0x3803d34*/ void Add(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x3803b88*/ void AddFirst(string prefix, System.Xml.Linq.XNamespace ns);
                /*0x3803a94*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);

                class NamespaceDeclaration
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ System.Xml.Linq.XNamespace ns;
                    /*0x20*/ int scope;
                    /*0x28*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;

                    /*0x3803eac*/ NamespaceDeclaration();
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

                static /*0x3804024*/ System.Xml.Linq.XName Get(string expandedName);
                static /*0x38045d8*/ System.Xml.Linq.XName Get(string localName, string namespaceName);
                static /*0x38045fc*/ System.Xml.Linq.XName op_Implicit(string expandedName);
                static /*0x37fcddc*/ bool op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                /*0x3803eb4*/ XName(System.Xml.Linq.XNamespace ns, string localName);
                /*0x3804660*/ XName();
                /*0x3803f84*/ string get_LocalName();
                /*0x3803f8c*/ System.Xml.Linq.XNamespace get_Namespace();
                /*0x37fd4c4*/ string get_NamespaceName();
                /*0x3803f94*/ string ToString();
                /*0x3804608*/ bool Equals(object obj);
                /*0x3804614*/ int GetHashCode();
                /*0x380461c*/ bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other);
                /*0x3804628*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x380457c*/ System.Xml.Linq.XNamespace get_None();
                static /*0x3804898*/ System.Xml.Linq.XNamespace get_Xml();
                static /*0x38048f8*/ System.Xml.Linq.XNamespace get_Xmlns();
                static /*0x3803118*/ System.Xml.Linq.XNamespace Get(string namespaceName);
                static /*0x3804958*/ System.Xml.Linq.XNamespace op_Implicit(string namespaceName);
                static /*0x3802360*/ bool op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x3804978*/ bool op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x380416c*/ System.Xml.Linq.XNamespace Get(string namespaceName, int index, int count);
                static /*0x3804984*/ string ExtractLocalName(System.Xml.Linq.XName n);
                static /*0x3804998*/ string ExtractNamespace(System.WeakReference r);
                static /*0x38047b8*/ System.Xml.Linq.XNamespace EnsureNamespace(ref System.WeakReference refNmsp, string namespaceName);
                /*0x3804698*/ XNamespace(string namespaceName);
                /*0x38047a8*/ string get_NamespaceName();
                /*0x3800ec8*/ System.Xml.Linq.XName GetName(string localName);
                /*0x38047b0*/ string ToString();
                /*0x3804964*/ bool Equals(object obj);
                /*0x3804970*/ int GetHashCode();
                /*0x380446c*/ System.Xml.Linq.XName GetName(string localName, int index, int count);
            }

            class XNode : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XNode next;

                /*0x37fddb0*/ XNode();
                /*0x3804a10*/ void Remove();
                /*0x3804a6c*/ string ToString();
                /*0x1f30ebc*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x3804f24*/ void AppendText(System.Text.StringBuilder sb);
                /*0x1f30214*/ System.Xml.Linq.XNode CloneNode();
                /*0x3804b5c*/ string GetXmlString(System.Xml.Linq.SaveOptions o);
            }

            class XObject : System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.Linq.XContainer parent;
                /*0x18*/ object annotations;

                /*0x37fcdd4*/ XObject();
                /*0x3801318*/ string get_BaseUri();
                /*0x1f2ffc8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3804f28*/ System.Xml.Linq.XElement get_Parent();
                /*0x3803174*/ void AddAnnotation(object annotation);
                /*0x3804fa4*/ object AnnotationForSealedType(System.Type type);
                /*0x1ffc854*/ T Annotation<T>();
                /*0x38050e4*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x3805138*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x380518c*/ int System.Xml.IXmlLineInfo.get_LinePosition();
                /*0x38012c4*/ bool get_HasBaseUri();
                /*0x37ff360*/ bool NotifyChanged(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x37ff2b4*/ bool NotifyChanging(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x380116c*/ void SetBaseUri(string baseUri);
                /*0x38011e4*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x37fe650*/ bool SkipNotify();
                /*0x3804a88*/ System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations();
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

                static /*0x380524c*/ XObjectChangeEventArgs();
                /*0x38051e0*/ XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange);
            }

            class XProcessingInstruction : System.Xml.Linq.XNode
            {
                /*0x28*/ string target;
                /*0x30*/ string data;

                static /*0x380532c*/ void ValidateName(string name);
                /*0x3801010*/ XProcessingInstruction(string target, string data);
                /*0x3805404*/ XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other);
                /*0x3805490*/ string get_Data();
                /*0x3805498*/ System.Xml.XmlNodeType get_NodeType();
                /*0x38054a0*/ string get_Target();
                /*0x38054a8*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x3805514*/ System.Xml.Linq.XNode CloneNode();
            }

            class XStreamingElement
            {
                /*0x10*/ System.Xml.Linq.XName name;
                /*0x18*/ object content;
            }

            class XText : System.Xml.Linq.XNode
            {
                /*0x28*/ string text;

                /*0x37fdb6c*/ XText(string value);
                /*0x37fdbec*/ XText(System.Xml.Linq.XText other);
                /*0x380556c*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3805574*/ string get_Value();
                /*0x37ff40c*/ void set_Value(string value);
                /*0x380557c*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x3805668*/ void AppendText(System.Text.StringBuilder sb);
                /*0x3805688*/ System.Xml.Linq.XNode CloneNode();
            }
        }
    }

    namespace Text
    {
        class StringBuilderCache
        {
            [ThreadStatic] static System.Text.StringBuilder t_cachedInstance;

            static /*0x38017cc*/ System.Text.StringBuilder Acquire(int capacity);
            static /*0x38056e0*/ void Release(System.Text.StringBuilder sb);
            static /*0x3801894*/ string GetStringAndRelease(System.Text.StringBuilder sb);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x3805760*/ void ThrowNotSupportedException();
    }
}
