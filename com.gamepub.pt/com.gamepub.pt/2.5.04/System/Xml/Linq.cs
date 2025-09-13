class <Module>
{
}

namespace System
{
    namespace Xml
    {
        namespace Linq
        {
            class XName : System.IEquatable<System.Xml.Linq.XName>, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ System.Xml.Linq.XNamespace ns;
                /*0x18*/ string localName;
                /*0x20*/ int hashCode;

                static /*0x29fecd8*/ System.Xml.Linq.XName Get(string expandedName);
                static /*0x2a07ad8*/ System.Xml.Linq.XName Get(string localName, string namespaceName);
                static /*0x2a07b08*/ System.Xml.Linq.XName op_Implicit(string expandedName);
                static /*0x29ffb58*/ bool op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                static /*0x2a022b0*/ bool op_Inequality(System.Xml.Linq.XName left, System.Xml.Linq.XName right);
                /*0x2a07508*/ XName(System.Xml.Linq.XNamespace ns, string localName);
                /*0x2a07c50*/ XName();
                /*0x2a075cc*/ string get_LocalName();
                /*0x2a075d4*/ System.Xml.Linq.XNamespace get_Namespace();
                /*0x29fe878*/ string get_NamespaceName();
                /*0x2a075dc*/ string ToString();
                /*0x2a07b14*/ bool Equals(object obj);
                /*0x2a07b20*/ int GetHashCode();
                /*0x2a07b28*/ bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other);
                /*0x2a07b34*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NameSerializer : System.Runtime.Serialization.IObjectReference, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ string expandedName;

                /*0x29fec14*/ NameSerializer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x29fecd0*/ object System.Runtime.Serialization.IObjectReference.GetRealObject(System.Runtime.Serialization.StreamingContext context);
                /*0x29fee5c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XNamespace
            {
                static /*0x0*/ System.Xml.Linq.XHashtable<System.WeakReference> namespaces;
                static /*0x8*/ System.WeakReference refNone;
                static /*0x10*/ System.WeakReference refXml;
                static /*0x18*/ System.WeakReference refXmlns;
                /*0x10*/ string namespaceName;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.Linq.XHashtable<System.Xml.Linq.XName> names;

                static /*0x2a07a6c*/ System.Xml.Linq.XNamespace get_None();
                static /*0x2a07e8c*/ System.Xml.Linq.XNamespace get_Xml();
                static /*0x2a07ef0*/ System.Xml.Linq.XNamespace get_Xmlns();
                static /*0x29fe894*/ System.Xml.Linq.XNamespace Get(string namespaceName);
                static /*0x2a07f54*/ System.Xml.Linq.XNamespace op_Implicit(string namespaceName);
                static /*0x29feee4*/ bool op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x2a07f74*/ bool op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right);
                static /*0x2a07670*/ System.Xml.Linq.XNamespace Get(string namespaceName, int index, int count);
                static /*0x2a07f80*/ string ExtractLocalName(System.Xml.Linq.XName n);
                static /*0x2a07f98*/ string ExtractNamespace(System.WeakReference r);
                static /*0x2a07da4*/ System.Xml.Linq.XNamespace EnsureNamespace(ref System.WeakReference refNmsp, string namespaceName);
                /*0x2a07c8c*/ XNamespace(string namespaceName);
                /*0x2a07d94*/ string get_NamespaceName();
                /*0x2a035a4*/ System.Xml.Linq.XName GetName(string localName);
                /*0x2a07d9c*/ string ToString();
                /*0x2a07f60*/ bool Equals(object obj);
                /*0x2a07f6c*/ int GetHashCode();
                /*0x2a07960*/ System.Xml.Linq.XName GetName(string localName, int index, int count);
            }

            class XHashtable<TValue>
            {
                /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState<TValue> state;

                XHashtable(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity);
                bool TryGetValue(string key, int index, int count, ref TValue value);
                TValue Add(TValue value);

                class ExtractKeyDelegate<TValue> : System.MulticastDelegate
                {
                    ExtractKeyDelegate(object object, nint method);
                    string Invoke(TValue value);
                    System.IAsyncResult BeginInvoke(TValue value, System.AsyncCallback callback, object object);
                    string EndInvoke(System.IAsyncResult result);
                }

                class XHashtableState<TValue>
                {
                    /*0x0*/ int[] buckets;
                    /*0x0*/ System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue> entries;
                    /*0x0*/ int numEntries;
                    /*0x0*/ System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey;

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

            class XObject : System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.Linq.XContainer parent;
                /*0x18*/ object annotations;

                /*0x29ffb50*/ XObject();
                /*0x2a04698*/ string get_BaseUri();
                System.Xml.XmlNodeType get_NodeType();
                /*0x2a08578*/ System.Xml.Linq.XElement get_Parent();
                /*0x2a065f8*/ void AddAnnotation(object annotation);
                /*0x2a085f8*/ object Annotation(System.Type type);
                T Annotation<T>();
                System.Collections.Generic.IEnumerable<T> Annotations<T>();
                /*0x2a08788*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x2a087e0*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x2a08838*/ int System.Xml.IXmlLineInfo.get_LinePosition();
                /*0x2a04640*/ bool get_HasBaseUri();
                /*0x2a0044c*/ bool NotifyChanged(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x2a0038c*/ bool NotifyChanging(object sender, System.Xml.Linq.XObjectChangeEventArgs e);
                /*0x2a044e8*/ void SetBaseUri(string baseUri);
                /*0x2a04558*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x2a0198c*/ bool SkipNotify();
                /*0x2a080a4*/ System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations();

                class <Annotations>d__16<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Xml.Linq.XObject <>4__this;
                    /*0x0*/ object[] <a>5__1;
                    /*0x0*/ int <i>5__2;

                    <Annotations>d__16(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class BaseUriAnnotation
            {
                /*0x10*/ string baseUri;

                /*0x29fe0fc*/ BaseUriAnnotation(string baseUri);
            }

            class LineInfoAnnotation
            {
                /*0x10*/ int lineNumber;
                /*0x14*/ int linePosition;

                /*0x29feba4*/ LineInfoAnnotation(int lineNumber, int linePosition);
            }

            class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
            {
                /*0x29febdc*/ LineInfoEndElementAnnotation(int lineNumber, int linePosition);
            }

            class XObjectChangeAnnotation
            {
                /*0x10*/ System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changing;
                /*0x18*/ System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changed;
            }

            enum XObjectChange
            {
                Add = 0,
                Remove = 1,
                Name = 2,
                Value = 3,
            }

            class XObjectChangeEventArgs : System.EventArgs
            {
                static /*0x0*/ System.Xml.Linq.XObjectChangeEventArgs Add;
                static /*0x8*/ System.Xml.Linq.XObjectChangeEventArgs Remove;
                static /*0x10*/ System.Xml.Linq.XObjectChangeEventArgs Name;
                static /*0x18*/ System.Xml.Linq.XObjectChangeEventArgs Value;
                /*0x10*/ System.Xml.Linq.XObjectChange objectChange;

                static /*0x2a08908*/ XObjectChangeEventArgs();
                /*0x2a08890*/ XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange);
            }

            class XNode : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XNode next;

                /*0x2a01028*/ XNode();
                /*0x2a08014*/ void Remove();
                /*0x2a0807c*/ string ToString();
                /*0x2a07504*/ string ToString(System.Xml.Linq.SaveOptions options);
                void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a08574*/ void AppendText(System.Text.StringBuilder sb);
                System.Xml.Linq.XNode CloneNode();
                /*0x2a08190*/ string GetXmlString(System.Xml.Linq.SaveOptions o);
            }

            class XText : System.Xml.Linq.XNode
            {
                /*0x28*/ string text;

                /*0x2a00de0*/ XText(string value);
                /*0x2a00e5c*/ XText(System.Xml.Linq.XText other);
                /*0x2a08c48*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a08c50*/ string get_Value();
                /*0x2a02cc0*/ void set_Value(string value);
                /*0x2a08c58*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a08d54*/ void AppendText(System.Text.StringBuilder sb);
                /*0x2a08d78*/ System.Xml.Linq.XNode CloneNode();
            }

            class XCData : System.Xml.Linq.XText
            {
                /*0x2a00ddc*/ XCData(string value);
                /*0x2a00e58*/ XCData(System.Xml.Linq.XCData other);
                /*0x2a00ed8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a00ee0*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a00f54*/ System.Xml.Linq.XNode CloneNode();
            }

            class XContainer : System.Xml.Linq.XNode
            {
                /*0x28*/ object content;

                static /*0x2a02ecc*/ string GetDateTimeString(System.DateTime value);
                static /*0x29ffb64*/ string GetStringValue(object value);
                /*0x2a0118c*/ XContainer();
                /*0x2a01194*/ XContainer(System.Xml.Linq.XContainer other);
                /*0x2a013a4*/ System.Xml.Linq.XNode get_LastNode();
                /*0x2a014ec*/ void Add(object content);
                /*0x2a021fc*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants();
                /*0x2a022a0*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(System.Xml.Linq.XName name);
                /*0x2a02344*/ System.Xml.Linq.XElement Element(System.Xml.Linq.XName name);
                /*0x2a02434*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements();
                /*0x2a024c8*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(System.Xml.Linq.XName name);
                /*0x2a024d4*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
                /*0x2a02588*/ void RemoveNodes();
                /*0x2a029a8*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x2a029ac*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x2a01a00*/ void AddContentSkipNotify(object content);
                /*0x2a01e84*/ void AddNode(System.Xml.Linq.XNode n);
                /*0x2a029b0*/ void AddNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x2a01f08*/ void AddString(string s);
                /*0x2a02a34*/ void AddStringSkipNotify(string s);
                /*0x2a02b94*/ void AppendNode(System.Xml.Linq.XNode n);
                /*0x2a012d8*/ void AppendNodeSkipNotify(System.Xml.Linq.XNode n);
                /*0x2a02dd0*/ void AppendText(System.Text.StringBuilder sb);
                /*0x2a028f4*/ void ConvertTextToNode();
                /*0x2a02208*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> GetDescendants(System.Xml.Linq.XName name, bool self);
                /*0x2a0243c*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> GetElements(System.Xml.Linq.XName name);
                /*0x2a02fa4*/ void ReadContentFrom(System.Xml.XmlReader r);
                /*0x2a03774*/ void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x2a04728*/ void RemoveNode(System.Xml.Linq.XNode n);
                /*0x2a02854*/ void RemoveNodesSkipNotify();
                /*0x2a048dc*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x2a048e0*/ void ValidateString(string s);
                /*0x2a048e4*/ void WriteContentTo(System.Xml.XmlWriter writer);

                class <Nodes>d__18 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__1;

                    /*0x2a02550*/ <Nodes>d__18(int <>1__state);
                    /*0x2a09360*/ void System.IDisposable.Dispose();
                    /*0x2a09364*/ bool MoveNext();
                    /*0x2a09408*/ System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current();
                    /*0x2a09410*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a09450*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2a09458*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator();
                    /*0x2a09500*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetDescendants>d__39 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XElement <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x24*/ bool self;
                    /*0x25*/ bool <>3__self;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XName name;
                    /*0x38*/ System.Xml.Linq.XName <>3__name;
                    /*0x40*/ System.Xml.Linq.XNode <n>5__1;
                    /*0x48*/ System.Xml.Linq.XElement <e>5__2;

                    /*0x2a02f34*/ <GetDescendants>d__39(int <>1__state);
                    /*0x2a08dd4*/ void System.IDisposable.Dispose();
                    /*0x2a08dd8*/ bool MoveNext();
                    /*0x2a08ff4*/ System.Xml.Linq.XElement System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>.get_Current();
                    /*0x2a08ffc*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a0903c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2a09044*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>.GetEnumerator();
                    /*0x2a090fc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetElements>d__40 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XElement <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XContainer <>4__this;
                    /*0x30*/ System.Xml.Linq.XNode <n>5__1;
                    /*0x38*/ System.Xml.Linq.XName name;
                    /*0x40*/ System.Xml.Linq.XName <>3__name;

                    /*0x2a02f6c*/ <GetElements>d__40(int <>1__state);
                    /*0x2a09100*/ void System.IDisposable.Dispose();
                    /*0x2a09104*/ bool MoveNext();
                    /*0x2a0925c*/ System.Xml.Linq.XElement System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>.get_Current();
                    /*0x2a09264*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a092a4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2a092ac*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>.GetEnumerator();
                    /*0x2a0935c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct NamespaceCache
            {
                /*0x10*/ System.Xml.Linq.XNamespace ns;
                /*0x18*/ string namespaceName;

                /*0xb1edfc*/ System.Xml.Linq.XNamespace Get(string namespaceName);
            }

            class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> emptySequence;
                /*0x30*/ System.Xml.Linq.XName name;
                /*0x38*/ System.Xml.Linq.XAttribute lastAttr;

                static /*0x2a022bc*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> get_EmptySequence();
                /*0x2a03608*/ XElement(System.Xml.Linq.XName name);
                /*0x2a0568c*/ XElement(System.Xml.Linq.XElement other);
                /*0x2a02178*/ XElement(System.Xml.Linq.XStreamingElement other);
                /*0x2a0573c*/ bool get_HasAttributes();
                /*0x2a0574c*/ bool get_IsEmpty();
                /*0x2a0575c*/ System.Xml.Linq.XName get_Name();
                /*0x2a05764*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a0576c*/ string get_Value();
                /*0x2a05830*/ void set_Value(string value);
                /*0x2a058a8*/ System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name);
                /*0x2a058e4*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
                /*0x2a009cc*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
                /*0x2a05a78*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a05b04*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x2a05b0c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x2a0623c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x2a06248*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x2a0646c*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x2a06340*/ void AppendAttribute(System.Xml.Linq.XAttribute a);
                /*0x2a03680*/ void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x2a06564*/ System.Xml.Linq.XNode CloneNode();
                /*0x2a058ec*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name);
                /*0x2a05978*/ string GetNamespaceOfPrefixInScope(string prefix, System.Xml.Linq.XElement outOfScope);
                /*0x2a05ce8*/ void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o);
                /*0x2a045cc*/ void SetEndElementLineInfo(int lineNumber, int linePosition);
                /*0x2a06824*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);

                class <GetAttributes>d__105 : System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Xml.Linq.XAttribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Xml.Linq.XElement <>4__this;
                    /*0x30*/ System.Xml.Linq.XAttribute <a>5__1;
                    /*0x38*/ System.Xml.Linq.XName name;
                    /*0x40*/ System.Xml.Linq.XName <>3__name;

                    /*0x2a065c0*/ <GetAttributes>d__105(int <>1__state);
                    /*0x2a09504*/ void System.IDisposable.Dispose();
                    /*0x2a09508*/ bool MoveNext();
                    /*0x2a095bc*/ System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current();
                    /*0x2a095c4*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a09604*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2a0960c*/ System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator();
                    /*0x2a096bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct ElementWriter
            {
                /*0x10*/ System.Xml.XmlWriter writer;
                /*0x18*/ System.Xml.Linq.NamespaceResolver resolver;

                /*0xb1ed78*/ ElementWriter(System.Xml.XmlWriter writer);
                /*0xb1ed84*/ void WriteElement(System.Xml.Linq.XElement e);
                /*0xb1ed8c*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);
                /*0xb1ed98*/ void PushAncestors(System.Xml.Linq.XElement e);
                /*0xb1eda0*/ void PushElement(System.Xml.Linq.XElement e);
                /*0xb1eda8*/ void WriteEndElement();
                /*0xb1edb0*/ void WriteFullEndElement();
                /*0xb1edb8*/ void WriteStartElement(System.Xml.Linq.XElement e);
            }

            struct NamespaceResolver
            {
                /*0x10*/ int scope;
                /*0x18*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration declaration;
                /*0x20*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration rover;

                /*0xb1ee78*/ void PushScope();
                /*0xb1ee88*/ void PopScope();
                /*0xb1ee90*/ void Add(string prefix, System.Xml.Linq.XNamespace ns);
                /*0xb1ee98*/ void AddFirst(string prefix, System.Xml.Linq.XNamespace ns);
                /*0xb1eea0*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, bool allowDefaultNamespace);

                class NamespaceDeclaration
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ System.Xml.Linq.XNamespace ns;
                    /*0x20*/ int scope;
                    /*0x28*/ System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;

                    /*0x29feedc*/ NamespaceDeclaration();
                }
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

            class XDocument : System.Xml.Linq.XContainer
            {
                /*0x30*/ System.Xml.Linq.XDeclaration declaration;

                static /*0x2a0501c*/ bool IsWhitespace(string s);
                /*0x2a04ce8*/ XDocument();
                /*0x2a04cf0*/ XDocument(System.Xml.Linq.XDocument other);
                /*0x2a04d74*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x2a04d7c*/ void set_Declaration(System.Xml.Linq.XDeclaration value);
                /*0x2a04d84*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a04d8c*/ System.Xml.Linq.XElement get_Root();
                /*0x2a04dd8*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a04f10*/ void AddAttribute(System.Xml.Linq.XAttribute a);
                /*0x2a04f68*/ void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a);
                /*0x2a04fc0*/ System.Xml.Linq.XNode CloneNode();
                T GetFirstNode<T>();
                /*0x2a050ac*/ void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous);
                /*0x2a052b4*/ void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter);
                /*0x2a053ec*/ void ValidateString(string s);
            }

            class XComment : System.Xml.Linq.XNode
            {
                /*0x28*/ string value;

                /*0x2a00fb0*/ XComment(string value);
                /*0x2a01030*/ XComment(System.Xml.Linq.XComment other);
                /*0x2a010ac*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a010b4*/ string get_Value();
                /*0x2a010bc*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a01130*/ System.Xml.Linq.XNode CloneNode();
            }

            class XProcessingInstruction : System.Xml.Linq.XNode
            {
                /*0x28*/ string target;
                /*0x30*/ string data;

                static /*0x2a089c0*/ void ValidateName(string name);
                /*0x2a036c0*/ XProcessingInstruction(string target, string data);
                /*0x2a08adc*/ XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other);
                /*0x2a08b60*/ string get_Data();
                /*0x2a08b68*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a08b70*/ string get_Target();
                /*0x2a08b78*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a08bec*/ System.Xml.Linq.XNode CloneNode();
            }

            class XDeclaration
            {
                /*0x10*/ string version;
                /*0x18*/ string encoding;
                /*0x20*/ string standalone;

                /*0x2a04a44*/ XDeclaration(string version, string encoding, string standalone);
                /*0x2a04a84*/ XDeclaration(System.Xml.Linq.XDeclaration other);
                /*0x2a04b10*/ string get_Encoding();
                /*0x2a04b18*/ string get_Standalone();
                /*0x2a04b20*/ string get_Version();
                /*0x2a04b28*/ string ToString();
            }

            class XDocumentType : System.Xml.Linq.XNode
            {
                /*0x28*/ string name;
                /*0x30*/ string publicId;
                /*0x38*/ string systemId;
                /*0x40*/ string internalSubset;
                /*0x48*/ System.Xml.IDtdInfo dtdInfo;

                /*0x2a0545c*/ XDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x2a054f8*/ XDocumentType(System.Xml.Linq.XDocumentType other);
                /*0x2a0374c*/ XDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.IDtdInfo dtdInfo);
                /*0x2a05594*/ string get_InternalSubset();
                /*0x2a0559c*/ string get_Name();
                /*0x2a055a4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a055ac*/ string get_PublicId();
                /*0x2a055b4*/ string get_SystemId();
                /*0x2a055bc*/ void WriteTo(System.Xml.XmlWriter writer);
                /*0x2a05630*/ System.Xml.Linq.XNode CloneNode();
            }

            class XAttribute : System.Xml.Linq.XObject
            {
                /*0x20*/ System.Xml.Linq.XAttribute next;
                /*0x28*/ System.Xml.Linq.XName name;
                /*0x30*/ string value;

                static /*0x29fffa4*/ void ValidateAttribute(System.Xml.Linq.XName name, string value);
                /*0x29ffa90*/ XAttribute(System.Xml.Linq.XName name, object value);
                /*0x2a001d4*/ XAttribute(System.Xml.Linq.XAttribute other);
                /*0x29fe7d8*/ bool get_IsNamespaceDeclaration();
                /*0x2a00258*/ System.Xml.Linq.XName get_Name();
                /*0x2a00260*/ System.Xml.XmlNodeType get_NodeType();
                /*0x2a00268*/ string get_Value();
                /*0x2a00270*/ void set_Value(string value);
                /*0x2a0050c*/ string ToString();
                /*0x2a00884*/ string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
            }

            class XStreamingElement
            {
                /*0x10*/ System.Xml.Linq.XName name;
                /*0x18*/ object content;
            }

            class Res
            {
                static /*0x29feef0*/ string GetString(string name);
                static /*0x29ff9a8*/ string GetString(string name, object[] args);
            }
        }
    }
}

namespace MS
{
    namespace Internal
    {
        namespace Xml
        {
            namespace Linq
            {
                namespace ComponentModel
                {
                    class XTypeDescriptionProvider<T> : System.ComponentModel.TypeDescriptionProvider
                    {
                        XTypeDescriptionProvider();
                        System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type, object instance);
                    }

                    class XTypeDescriptor<T> : System.ComponentModel.CustomTypeDescriptor
                    {
                        XTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor parent);
                        System.ComponentModel.PropertyDescriptorCollection GetProperties();
                        System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
                    }

                    class XPropertyDescriptor<T, TProperty> : System.ComponentModel.PropertyDescriptor
                    {
                        XPropertyDescriptor(string name);
                        System.Type get_ComponentType();
                        bool get_IsReadOnly();
                        System.Type get_PropertyType();
                        bool CanResetValue(object component);
                        void ResetValue(object component);
                        void SetValue(object component, object value);
                        bool ShouldSerializeValue(object component);
                    }

                    class XElementAttributePropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, object>
                    {
                        /*0x88*/ MS.Internal.Xml.Linq.ComponentModel.XDeferredSingleton<System.Xml.Linq.XAttribute> value;

                        /*0x2a069b8*/ XElementAttributePropertyDescriptor();
                        /*0x2a06a1c*/ object GetValue(object component);

                        class <>c
                        {
                            static /*0x0*/ MS.Internal.Xml.Linq.ComponentModel.XElementAttributePropertyDescriptor.<> <>9;
                            static /*0x8*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Xml.Linq.XAttribute> <>9__3_0;

                            static /*0x2a096c0*/ <>c();
                            /*0x2a09720*/ <>c();
                            /*0x2a09728*/ System.Xml.Linq.XAttribute <GetValue>b__3_0(System.Xml.Linq.XElement e, System.Xml.Linq.XName n);
                        }
                    }

                    class XElementDescendantsPropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>>
                    {
                        /*0x88*/ MS.Internal.Xml.Linq.ComponentModel.XDeferredAxis<System.Xml.Linq.XElement> value;

                        /*0x2a06bc4*/ XElementDescendantsPropertyDescriptor();
                        /*0x2a06c28*/ object GetValue(object component);

                        class <>c
                        {
                            static /*0x0*/ MS.Internal.Xml.Linq.ComponentModel.XElementDescendantsPropertyDescriptor.<> <>9;
                            static /*0x8*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>> <>9__3_0;

                            static /*0x2a0976c*/ <>c();
                            /*0x2a097cc*/ <>c();
                            /*0x2a097d4*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> <GetValue>b__3_0(System.Xml.Linq.XElement e, System.Xml.Linq.XName n);
                        }
                    }

                    class XElementElementPropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, object>
                    {
                        /*0x88*/ MS.Internal.Xml.Linq.ComponentModel.XDeferredSingleton<System.Xml.Linq.XElement> value;

                        /*0x2a06dd0*/ XElementElementPropertyDescriptor();
                        /*0x2a06e34*/ object GetValue(object component);

                        class <>c
                        {
                            static /*0x0*/ MS.Internal.Xml.Linq.ComponentModel.XElementElementPropertyDescriptor.<> <>9;
                            static /*0x8*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Xml.Linq.XElement> <>9__3_0;

                            static /*0x2a097fc*/ <>c();
                            /*0x2a0985c*/ <>c();
                            /*0x2a09864*/ System.Xml.Linq.XElement <GetValue>b__3_0(System.Xml.Linq.XElement e, System.Xml.Linq.XName n);
                        }
                    }

                    class XElementElementsPropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>>
                    {
                        /*0x88*/ MS.Internal.Xml.Linq.ComponentModel.XDeferredAxis<System.Xml.Linq.XElement> value;

                        /*0x2a06fdc*/ XElementElementsPropertyDescriptor();
                        /*0x2a07040*/ object GetValue(object component);

                        class <>c
                        {
                            static /*0x0*/ MS.Internal.Xml.Linq.ComponentModel.XElementElementsPropertyDescriptor.<> <>9;
                            static /*0x8*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>> <>9__3_0;

                            static /*0x2a09880*/ <>c();
                            /*0x2a098e0*/ <>c();
                            /*0x2a098e8*/ System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> <GetValue>b__3_0(System.Xml.Linq.XElement e, System.Xml.Linq.XName n);
                        }
                    }

                    class XElementValuePropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, string>
                    {
                        /*0x88*/ System.Xml.Linq.XElement element;

                        /*0x2a071e8*/ XElementValuePropertyDescriptor();
                        /*0x2a0724c*/ bool get_IsReadOnly();
                        /*0x2a07254*/ object GetValue(object component);
                        /*0x2a07310*/ void SetValue(object component, object value);
                    }

                    class XElementXmlPropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XElement, string>
                    {
                        /*0x88*/ System.Xml.Linq.XElement element;

                        /*0x2a073e0*/ XElementXmlPropertyDescriptor();
                        /*0x2a07444*/ object GetValue(object component);
                    }

                    class XAttributeValuePropertyDescriptor : MS.Internal.Xml.Linq.ComponentModel.XPropertyDescriptor<System.Xml.Linq.XAttribute, string>
                    {
                        /*0x88*/ System.Xml.Linq.XAttribute attribute;

                        /*0x2a00bf0*/ XAttributeValuePropertyDescriptor();
                        /*0x2a00c54*/ bool get_IsReadOnly();
                        /*0x2a00c5c*/ object GetValue(object component);
                        /*0x2a00d0c*/ void SetValue(object component, object value);
                    }

                    class XDeferredAxis<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                    {
                        /*0x0*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Collections.Generic.IEnumerable<T>> func;
                        /*0x0*/ System.Xml.Linq.XElement element;
                        /*0x0*/ System.Xml.Linq.XName name;

                        XDeferredAxis(System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Collections.Generic.IEnumerable<T>> func, System.Xml.Linq.XElement element, System.Xml.Linq.XName name);
                        System.Collections.Generic.IEnumerator<T> GetEnumerator();
                        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }

                    class XDeferredSingleton<T>
                    {
                        /*0x0*/ System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, T> func;
                        /*0x0*/ System.Xml.Linq.XElement element;
                        /*0x0*/ System.Xml.Linq.XName name;

                        XDeferredSingleton(System.Func<System.Xml.Linq.XElement, System.Xml.Linq.XName, T> func, System.Xml.Linq.XElement element, System.Xml.Linq.XName name);
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x29fe07c*/ uint ComputeStringHash(string s);
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x29ffa50*/ void ThrowNotSupportedException();
    }
}
