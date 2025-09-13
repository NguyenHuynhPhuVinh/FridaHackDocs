class <Module>
{
}

class SR
{
    static /*0x1825be0*/ string GetString(string name, object[] args);
    static /*0x1825c7c*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
}

namespace Microsoft
{
    namespace CSharp
    {
        class CodeDomProvider
        {
            /*0x1590c4c*/ CodeDomProvider();
        }

        class CSharpCodeProvider : Microsoft.CSharp.CodeDomProvider
        {
            /*0x1590c44*/ CSharpCodeProvider();
        }
    }
}

namespace MS
{
    namespace Internal
    {
        namespace Xml
        {
            namespace XPath
            {
                class AstNode
                {
                    /*0x1588134*/ AstNode();
                    MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    System.Xml.XPath.XPathResultType get_ReturnType();

                    enum AstType
                    {
                        Axis = 0,
                        Operator = 1,
                        Filter = 2,
                        ConstantOperand = 3,
                        Function = 4,
                        Group = 5,
                        Root = 6,
                        Variable = 7,
                        Error = 8,
                    }
                }

                class Axis : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.Axis.AxisType axisType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode input;
                    /*0x20*/ string prefix;
                    /*0x28*/ string name;
                    /*0x30*/ System.Xml.XPath.XPathNodeType nodeType;
                    /*0x34*/ bool abbrAxis;
                    /*0x38*/ string urn;

                    /*0x15893d0*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, string prefix, string name, System.Xml.XPath.XPathNodeType nodetype);
                    /*0x158946c*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input);
                    /*0x15894ec*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x15894f4*/ System.Xml.XPath.XPathResultType get_ReturnType();
                    /*0x15894fc*/ MS.Internal.Xml.XPath.AstNode get_Input();
                    /*0x1589504*/ void set_Input(MS.Internal.Xml.XPath.AstNode value);
                    /*0x158950c*/ string get_Prefix();
                    /*0x1589514*/ string get_Name();
                    /*0x158951c*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x1589524*/ MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis();
                    /*0x158952c*/ bool get_AbbrAxis();
                    /*0x1589534*/ string get_Urn();
                    /*0x158953c*/ void set_Urn(string value);

                    enum AxisType
                    {
                        Ancestor = 0,
                        AncestorOrSelf = 1,
                        Attribute = 2,
                        Child = 3,
                        Descendant = 4,
                        DescendantOrSelf = 5,
                        Following = 6,
                        FollowingSibling = 7,
                        Namespace = 8,
                        Parent = 9,
                        Preceding = 10,
                        PrecedingSibling = 11,
                        Self = 12,
                        None = 13,
                    }
                }

                class Filter : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.AstNode input;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode condition;

                    /*0x14ca158*/ Filter(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition);
                    /*0x14ca190*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x14ca198*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Function : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] ReturnTypes;
                    /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType functionType;
                    /*0x18*/ System.Collections.ArrayList argumentList;
                    /*0x20*/ string name;
                    /*0x28*/ string prefix;

                    static /*0x14ca4f0*/ Function();
                    /*0x14ca2a8*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.ArrayList argumentList);
                    /*0x14ca328*/ Function(string prefix, string name, System.Collections.ArrayList argumentList);
                    /*0x14ca3bc*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg);
                    /*0x14ca454*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x14ca45c*/ System.Xml.XPath.XPathResultType get_ReturnType();

                    enum FunctionType
                    {
                        FuncLast = 0,
                        FuncPosition = 1,
                        FuncCount = 2,
                        FuncID = 3,
                        FuncLocalName = 4,
                        FuncNameSpaceUri = 5,
                        FuncName = 6,
                        FuncString = 7,
                        FuncBoolean = 8,
                        FuncNumber = 9,
                        FuncTrue = 10,
                        FuncFalse = 11,
                        FuncNot = 12,
                        FuncConcat = 13,
                        FuncStartsWith = 14,
                        FuncContains = 15,
                        FuncSubstringBefore = 16,
                        FuncSubstringAfter = 17,
                        FuncSubstring = 18,
                        FuncStringLength = 19,
                        FuncNormalize = 20,
                        FuncTranslate = 21,
                        FuncLang = 22,
                        FuncSum = 23,
                        FuncFloor = 24,
                        FuncCeiling = 25,
                        FuncRound = 26,
                        FuncUserDefined = 27,
                    }
                }

                class Group : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.AstNode groupNode;

                    /*0x14ca580*/ Group(MS.Internal.Xml.XPath.AstNode groupNode);
                    /*0x14ca5ac*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x14ca5b4*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operand : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ System.Xml.XPath.XPathResultType type;
                    /*0x18*/ object val;

                    /*0x14d47b4*/ Operand(string val);
                    /*0x14d47e8*/ Operand(double val);
                    /*0x14d485c*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x14d4864*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operator : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ MS.Internal.Xml.XPath.Operator.Op[] invertOp;
                    /*0x10*/ MS.Internal.Xml.XPath.Operator.Op opType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode opnd1;
                    /*0x20*/ MS.Internal.Xml.XPath.AstNode opnd2;

                    static /*0x14d48d8*/ Operator();
                    /*0x14d486c*/ Operator(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2);
                    /*0x14d48ac*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x14d48b4*/ System.Xml.XPath.XPathResultType get_ReturnType();

                    enum Op
                    {
                        INVALID = 0,
                        OR = 1,
                        AND = 2,
                        EQ = 3,
                        NE = 4,
                        LT = 5,
                        LE = 6,
                        GT = 7,
                        GE = 8,
                        PLUS = 9,
                        MINUS = 10,
                        MUL = 11,
                        DIV = 12,
                        MOD = 13,
                        UNION = 14,
                    }
                }

                class Root : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x1825c64*/ Root();
                    /*0x1825c6c*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x1825c74*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Variable : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ string localname;
                    /*0x18*/ string prefix;

                    /*0x1b1b8c4*/ Variable(string name, string prefix);
                    /*0x1b1b8fc*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x1b1b904*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class XPathParser
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] temparray1;
                    static /*0x8*/ System.Xml.XPath.XPathResultType[] temparray2;
                    static /*0x10*/ System.Xml.XPath.XPathResultType[] temparray3;
                    static /*0x18*/ System.Xml.XPath.XPathResultType[] temparray4;
                    static /*0x20*/ System.Xml.XPath.XPathResultType[] temparray5;
                    static /*0x28*/ System.Xml.XPath.XPathResultType[] temparray6;
                    static /*0x30*/ System.Xml.XPath.XPathResultType[] temparray7;
                    static /*0x38*/ System.Xml.XPath.XPathResultType[] temparray8;
                    static /*0x40*/ System.Xml.XPath.XPathResultType[] temparray9;
                    static /*0x48*/ System.Collections.Hashtable functionTable;
                    static /*0x50*/ System.Collections.Hashtable AxesTable;
                    /*0x10*/ MS.Internal.Xml.XPath.XPathScanner scanner;
                    /*0x18*/ int parseDepth;

                    static /*0x1d18e90*/ XPathParser();
                    static /*0x1d15c8c*/ MS.Internal.Xml.XPath.AstNode ParseXPathExpresion(string xpathExpresion);
                    static /*0x1d16864*/ bool IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner);
                    static /*0x1d16fb4*/ bool IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind);
                    static /*0x1d1695c*/ bool IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner);
                    static /*0x1d17fcc*/ System.Collections.Hashtable CreateFunctionTable();
                    static /*0x1d18aa0*/ System.Collections.Hashtable CreateAxesTable();
                    /*0x1d15c60*/ XPathParser(MS.Internal.Xml.XPath.XPathScanner scanner);
                    /*0x1d15e10*/ MS.Internal.Xml.XPath.AstNode ParseExpresion(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d15e80*/ MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d15f74*/ MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d160d0*/ MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d161b8*/ MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d162c8*/ MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d163b0*/ MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d164ec*/ MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d165d0*/ MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d166d8*/ MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d16a18*/ MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d16f18*/ MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d16ba8*/ MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d16ad8*/ MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d16ffc*/ MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d172b0*/ MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType);
                    /*0x1d16d04*/ MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d17630*/ MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x1d175c0*/ void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x1d16f88*/ void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x1d160b8*/ void NextLex();
                    /*0x1d16068*/ bool TestOp(string op);
                    /*0x1d16800*/ void CheckNodeSet(System.Xml.XPath.XPathResultType t);
                    /*0x1d1719c*/ MS.Internal.Xml.XPath.Axis.AxisType GetAxis(MS.Internal.Xml.XPath.XPathScanner scaner);

                    class ParamInfo
                    {
                        /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType ftype;
                        /*0x14*/ int minargs;
                        /*0x18*/ int maxargs;
                        /*0x20*/ System.Xml.XPath.XPathResultType[] argTypes;

                        /*0x16c4af0*/ ParamInfo(MS.Internal.Xml.XPath.Function.FunctionType ftype, int minargs, int maxargs, System.Xml.XPath.XPathResultType[] argTypes);
                        /*0x16c4ad0*/ MS.Internal.Xml.XPath.Function.FunctionType get_FType();
                        /*0x16c4ad8*/ int get_Minargs();
                        /*0x16c4ae0*/ int get_Maxargs();
                        /*0x16c4ae8*/ System.Xml.XPath.XPathResultType[] get_ArgTypes();
                    }
                }

                class XPathScanner
                {
                    /*0x10*/ string xpathExpr;
                    /*0x18*/ int xpathExprIndex;
                    /*0x1c*/ MS.Internal.Xml.XPath.XPathScanner.LexKind kind;
                    /*0x20*/ char currentChar;
                    /*0x28*/ string name;
                    /*0x30*/ string prefix;
                    /*0x38*/ string stringValue;
                    /*0x40*/ double numberValue;
                    /*0x48*/ bool canBeFunction;
                    /*0x50*/ System.Xml.XmlCharType xmlCharType;

                    /*0x1d15d74*/ XPathScanner(string xpathExpr);
                    /*0x1d190fc*/ string get_SourceText();
                    /*0x1d19104*/ char get_CurerntChar();
                    /*0x1d1909c*/ bool NextChar();
                    /*0x1d1910c*/ MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind();
                    /*0x1d19114*/ string get_Name();
                    /*0x1d1911c*/ string get_Prefix();
                    /*0x1d19124*/ string get_StringValue();
                    /*0x1d1912c*/ double get_NumberValue();
                    /*0x1d19134*/ bool get_CanBeFunction();
                    /*0x1d1913c*/ void SkipSpace();
                    /*0x1d17c00*/ bool NextLex();
                    /*0x1d192fc*/ double ScanNumber();
                    /*0x1d1917c*/ double ScanFraction();
                    /*0x1d19240*/ string ScanString();
                    /*0x1d193e8*/ string ScanName();

                    enum LexKind
                    {
                        Comma = 44,
                        Slash = 47,
                        At = 64,
                        Dot = 46,
                        LParens = 40,
                        RParens = 41,
                        LBracket = 91,
                        RBracket = 93,
                        Star = 42,
                        Plus = 43,
                        Minus = 45,
                        Eq = 61,
                        Lt = 60,
                        Gt = 62,
                        Bang = 33,
                        Dollar = 36,
                        Apos = 39,
                        Quote = 34,
                        Union = 124,
                        Ne = 78,
                        Le = 76,
                        Ge = 71,
                        And = 65,
                        Or = 79,
                        DotDot = 68,
                        SlashSlash = 83,
                        Name = 110,
                        String = 115,
                        Number = 100,
                        Axe = 97,
                        Eof = 69,
                    }
                }
            }

            namespace Cache
            {
                class XPathDocumentNavigator : System.Xml.XPath.XPathNavigator, System.Xml.IXmlLineInfo
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] pageCurrent;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] pageParent;
                    /*0x20*/ int idxCurrent;
                    /*0x24*/ int idxParent;

                    /*0x1b1ba0c*/ XPathDocumentNavigator(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, int idxParent);
                    /*0x1b1baa4*/ string get_Value();
                    /*0x1b1bec0*/ System.Xml.XPath.XPathNavigator Clone();
                    /*0x1b1bf40*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x1b1bf90*/ string get_LocalName();
                    /*0x1b1bff4*/ string get_NamespaceURI();
                    /*0x1b1c058*/ string get_Prefix();
                    /*0x1b1c0bc*/ System.Xml.XmlNameTable get_NameTable();
                    /*0x1b1c128*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                    /*0x1b1c408*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
                    /*0x1b1c540*/ bool MoveToParent();
                    /*0x1b1c5d0*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                    /*0x1b1c688*/ object get_UnderlyingObject();
                    /*0x1b1c698*/ bool HasLineInfo();
                    /*0x1b1c6e8*/ int get_LineNumber();
                    /*0x1b1c7a8*/ int get_LinePosition();
                    /*0x1b1c8b0*/ int GetPositionHashCode();
                }

                struct XPathNode
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNodeInfoAtom info;
                    /*0x18*/ ushort idxSibling;
                    /*0x1a*/ ushort idxParent;
                    /*0x1c*/ ushort idxSimilar;
                    /*0x1e*/ ushort posOffset;
                    /*0x20*/ uint props;
                    /*0x28*/ string value;

                    /*0xad1484*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0xad1490*/ string get_Prefix();
                    /*0xad14ac*/ string get_LocalName();
                    /*0xad14c8*/ string get_NamespaceUri();
                    /*0xad14e4*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0xad1500*/ int get_LineNumber();
                    /*0xad1528*/ int get_LinePosition();
                    /*0xad154c*/ int get_CollapsedLinePosition();
                    /*0xad1578*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0xad1594*/ int GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0xad15b8*/ int GetSibling(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0xad15dc*/ bool get_IsXmlNamespaceNode();
                    /*0xad15e4*/ bool get_HasSibling();
                    /*0xad15f4*/ bool get_HasCollapsedText();
                    /*0xad1600*/ bool get_IsText();
                    /*0xad1608*/ bool get_HasNamespaceDecls();
                    /*0xad1614*/ string get_Value();
                }

                struct XPathNodeRef
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] page;
                    /*0x18*/ int idx;

                    /*0xadb090*/ XPathNodeRef(MS.Internal.Xml.Cache.XPathNode[] page, int idx);
                    /*0xadb09c*/ MS.Internal.Xml.Cache.XPathNode[] get_Page();
                    /*0xadb0a4*/ int get_Index();
                    /*0xadb0ac*/ int GetHashCode();
                }

                class XPathNodeHelper
                {
                    static /*0x1b1c22c*/ int GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x1b1c298*/ int GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x1b1c56c*/ bool GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                    static /*0x1b1f68c*/ int GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, int idxNode);
                    static /*0x1b1bd54*/ bool GetTextFollowing(ref MS.Internal.Xml.Cache.XPathNode[] pageCurrent, ref int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, int idxEnd);
                    static /*0x1b1bcb8*/ bool GetNonDescendant(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                }

                class XPathNodePageInfo
                {
                    /*0x10*/ int pageNum;
                    /*0x14*/ int nodeCount;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] pageNext;

                    /*0x1d15c18*/ int get_PageNumber();
                    /*0x1d15c20*/ int get_NodeCount();
                    /*0x1d15c28*/ MS.Internal.Xml.Cache.XPathNode[] get_NextPage();
                }

                class XPathNodeInfoAtom
                {
                    /*0x10*/ string localName;
                    /*0x18*/ string namespaceUri;
                    /*0x20*/ string prefix;
                    /*0x28*/ MS.Internal.Xml.Cache.XPathNode[] pageParent;
                    /*0x30*/ MS.Internal.Xml.Cache.XPathNode[] pageSibling;
                    /*0x38*/ System.Xml.XPath.XPathDocument doc;
                    /*0x40*/ int lineNumBase;
                    /*0x44*/ int linePosBase;
                    /*0x48*/ MS.Internal.Xml.Cache.XPathNodePageInfo pageInfo;

                    /*0x1d15bd0*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x1d15bd8*/ string get_LocalName();
                    /*0x1d15be0*/ string get_NamespaceUri();
                    /*0x1d15be8*/ string get_Prefix();
                    /*0x1d15bf0*/ MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage();
                    /*0x1d15bf8*/ MS.Internal.Xml.Cache.XPathNode[] get_ParentPage();
                    /*0x1d15c00*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x1d15c08*/ int get_LineNumberBase();
                    /*0x1d15c10*/ int get_LinePositionBase();
                }
            }
        }
    }
}

namespace System
{
    class MonoTODOAttribute : System.Attribute
    {
        /*0x14d0328*/ MonoTODOAttribute();
    }

    class LocalAppContextSwitches
    {
        static /*0x0*/ bool IgnoreEmptyKeySequences;
        static /*0x1*/ bool DontThrowOnInvalidSurrogatePairs;
    }

    namespace Xml
    {
        class AsyncHelper
        {
            static /*0x0*/ System.Threading.Tasks.Task DoneTask;
            static /*0x8*/ System.Threading.Tasks.Task<bool> DoneTaskTrue;
            static /*0x10*/ System.Threading.Tasks.Task<bool> DoneTaskFalse;
            static /*0x18*/ System.Threading.Tasks.Task<int> DoneTaskZero;

            static /*0x1588bd0*/ AsyncHelper();
        }

        class Base64Encoder
        {
            /*0x10*/ byte[] leftOverBytes;
            /*0x18*/ int leftOverBytesCount;
            /*0x20*/ char[] charsLine;

            /*0x158997c*/ Base64Encoder();
            void WriteChars(char[] chars, int index, int count);
            /*0x15899dc*/ void Encode(byte[] buffer, int index, int count);
            /*0x1589d30*/ void Flush();
        }

        class XmlRawWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlRawWriter rawWriter;

            /*0x1b5ce40*/ XmlRawWriterBase64Encoder(System.Xml.XmlRawWriter rawWriter);
            /*0x1b5d2c4*/ void WriteChars(char[] chars, int index, int count);
        }

        class XmlTextWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlTextEncoder xmlTextEncoder;

            /*0x1bc8a00*/ XmlTextWriterBase64Encoder(System.Xml.XmlTextEncoder xmlTextEncoder);
            /*0x1bc9f34*/ void WriteChars(char[] chars, int index, int count);
        }

        class BinHexDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x10*/ byte[] buffer;
            /*0x18*/ int curIndex;
            /*0x1c*/ int endIndex;
            /*0x20*/ bool hasHalfByteCached;
            /*0x21*/ byte cachedHalfByte;

            static /*0x158c344*/ byte[] Decode(char[] chars, bool allowOddChars);
            static /*0x158c170*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, ref int charsDecoded, ref int bytesDecoded);
            /*0x158c000*/ bool get_IsFull();
            /*0x158c010*/ int Decode(char[] chars, int startPos, int len);
        }

        class BinHexEncoder
        {
            static /*0x158c538*/ void Encode(byte[] buffer, int index, int count, System.Xml.XmlWriter writer);
            static /*0x158c818*/ string Encode(byte[] inArray, int offsetIn, int count);
            static /*0x158c6d8*/ int Encode(byte[] inArray, int offsetIn, int count, char[] outArray);
        }

        enum BinXmlToken
        {
            Error = 0,
            NotImpl = -2,
            EOF = -1,
            XmlDecl = 254,
            Encoding = 253,
            DocType = 252,
            System = 251,
            Public = 250,
            Subset = 249,
            Element = 248,
            EndElem = 247,
            Attr = 246,
            EndAttrs = 245,
            PI = 244,
            Comment = 243,
            CData = 242,
            EndCData = 241,
            Name = 240,
            QName = 239,
            XmlText = 237,
            Nest = 236,
            EndNest = 235,
            Extn = 234,
            NmFlush = 233,
            SQL_BIT = 6,
            SQL_TINYINT = 7,
            SQL_SMALLINT = 1,
            SQL_INT = 2,
            SQL_BIGINT = 8,
            SQL_REAL = 3,
            SQL_FLOAT = 4,
            SQL_MONEY = 5,
            SQL_SMALLMONEY = 20,
            SQL_DATETIME = 18,
            SQL_SMALLDATETIME = 19,
            SQL_DECIMAL = 10,
            SQL_NUMERIC = 11,
            SQL_UUID = 9,
            SQL_VARBINARY = 15,
            SQL_BINARY = 12,
            SQL_IMAGE = 23,
            SQL_CHAR = 13,
            SQL_VARCHAR = 16,
            SQL_TEXT = 22,
            SQL_NVARCHAR = 17,
            SQL_NCHAR = 14,
            SQL_NTEXT = 24,
            SQL_UDT = 27,
            XSD_KATMAI_DATE = 127,
            XSD_KATMAI_DATETIME = 126,
            XSD_KATMAI_TIME = 125,
            XSD_KATMAI_DATEOFFSET = 124,
            XSD_KATMAI_DATETIMEOFFSET = 123,
            XSD_KATMAI_TIMEOFFSET = 122,
            XSD_BOOLEAN = 134,
            XSD_TIME = 129,
            XSD_DATETIME = 130,
            XSD_DATE = 131,
            XSD_BINHEX = 132,
            XSD_BASE64 = 133,
            XSD_DECIMAL = 135,
            XSD_BYTE = 136,
            XSD_UNSIGNEDSHORT = 137,
            XSD_UNSIGNEDINT = 138,
            XSD_UNSIGNEDLONG = 139,
            XSD_QNAME = 140,
        }

        struct BinXmlSqlDecimal
        {
            static /*0x0*/ byte NUMERIC_MAX_PRECISION;
            static /*0x1*/ byte MaxPrecision;
            static /*0x2*/ byte MaxScale;
            static /*0x4*/ int x_cNumeMax;
            static /*0x8*/ long x_lInt32Base;
            static /*0x10*/ ulong x_ulInt32Base;
            static /*0x18*/ ulong x_ulInt32BaseForMod;
            static /*0x20*/ ulong x_llMax;
            static /*0x28*/ double DUINT_BASE;
            static /*0x30*/ double DUINT_BASE2;
            static /*0x38*/ double DUINT_BASE3;
            static /*0x40*/ uint[] x_rgulShiftBase;
            static /*0x48*/ byte[] rgCLenFromPrec;
            /*0x10*/ byte m_bLen;
            /*0x11*/ byte m_bPrec;
            /*0x12*/ byte m_bScale;
            /*0x13*/ byte m_bSign;
            /*0x14*/ uint m_data1;
            /*0x18*/ uint m_data2;
            /*0x1c*/ uint m_data3;
            /*0x20*/ uint m_data4;

            static /*0x158f5d0*/ BinXmlSqlDecimal();
            static /*0x158ee8c*/ uint UIntFromByteArray(byte[] data, int offset);
            static /*0x158f0f8*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
            static /*0x158f1f4*/ void MpNormalize(uint[] rgulU, ref int ciulU);
            static /*0x158f24c*/ char ChFromDigit(uint uiDigit);
            /*0xaa54f4*/ BinXmlSqlDecimal(byte[] data, int offset, bool trim);
            /*0xaa54e4*/ bool get_IsPositive();
            /*0xaa5500*/ decimal ToDecimal();
            /*0xaa5508*/ void TrimTrailingZeros();
            /*0xaa5510*/ string ToString();
        }

        struct BinXmlSqlMoney
        {
            /*0x10*/ long data;

            /*0xaa5518*/ BinXmlSqlMoney(int v);
            /*0xaa5524*/ BinXmlSqlMoney(long v);
            /*0xaa552c*/ decimal ToDecimal();
            /*0xaa5534*/ string ToString();
        }

        class BinXmlDateTime
        {
            static /*0x0*/ int[] KatmaiTimeScaleMultiplicator;
            static /*0x8*/ double SQLTicksPerMillisecond;
            static /*0x10*/ int SQLTicksPerSecond;
            static /*0x14*/ int SQLTicksPerMinute;
            static /*0x18*/ int SQLTicksPerHour;
            static /*0x1c*/ int SQLTicksPerDay;

            static /*0x158eac4*/ BinXmlDateTime();
            static /*0x158c95c*/ void Write2Dig(System.Text.StringBuilder sb, int val);
            static /*0x158c9c4*/ void Write4DigNeg(System.Text.StringBuilder sb, int val);
            static /*0x158ca7c*/ void Write3Dec(System.Text.StringBuilder sb, int val);
            static /*0x158cb2c*/ void WriteDate(System.Text.StringBuilder sb, int yr, int mnth, int day);
            static /*0x158cbec*/ void WriteTime(System.Text.StringBuilder sb, int hr, int min, int sec, int ms);
            static /*0x158ccec*/ void WriteTimeFullPrecision(System.Text.StringBuilder sb, int hr, int min, int sec, int fraction);
            static /*0x158cef4*/ void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone);
            static /*0x158cfc0*/ void WriteTimeZone(System.Text.StringBuilder sb, bool negTimeZone, int hr, int min);
            static /*0x158d0ac*/ void BreakDownXsdDateTime(long val, ref int yr, ref int mnth, ref int day, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x158d280*/ void BreakDownXsdDate(long val, ref int yr, ref int mnth, ref int day, ref bool negTimeZone, ref int hr, ref int min);
            static /*0x158d3e8*/ void BreakDownXsdTime(long val, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x158d4f4*/ string XsdDateTimeToString(long val);
            static /*0x158d614*/ string XsdDateToString(long val);
            static /*0x158d70c*/ string XsdTimeToString(long val);
            static /*0x158d7f8*/ string SqlDateTimeToString(int dateticks, uint timeticks);
            static /*0x158d900*/ System.DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks);
            static /*0x158d9e0*/ string SqlSmallDateTimeToString(short dateticks, ushort timeticks);
            static /*0x158dabc*/ System.DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks);
            static /*0x158db3c*/ System.DateTime XsdKatmaiDateToDateTime(byte[] data, int offset);
            static /*0x158dc48*/ System.DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset);
            static /*0x158df20*/ System.DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset);
            static /*0x158df90*/ System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x158e000*/ System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x158e11c*/ System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x158e18c*/ string XsdKatmaiDateToString(byte[] data, int offset);
            static /*0x158e290*/ string XsdKatmaiDateTimeToString(byte[] data, int offset);
            static /*0x158e4e0*/ string XsdKatmaiTimeToString(byte[] data, int offset);
            static /*0x158e600*/ string XsdKatmaiDateOffsetToString(byte[] data, int offset);
            static /*0x158e724*/ string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset);
            static /*0x158e98c*/ string XsdKatmaiTimeOffsetToString(byte[] data, int offset);
            static /*0x158dbc8*/ long GetKatmaiDateTicks(byte[] data, ref int pos);
            static /*0x158dce4*/ long GetKatmaiTimeTicks(byte[] data, ref int pos);
            static /*0x158e0bc*/ long GetKatmaiTimeZoneTicks(byte[] data, int pos);
            static /*0x158e400*/ int GetFractions(System.DateTime dt);
            static /*0x158e8ac*/ int GetFractions(System.DateTimeOffset dt);
        }

        class XmlSqlBinaryReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Type TypeOfObject;
            static /*0x8*/ System.Type TypeOfString;
            static /*0x10*/ System.Type[] TokenTypeMap;
            static /*0x18*/ byte[] XsdKatmaiTimeScaleToValueLengthMap;
            static /*0x20*/ System.Xml.ReadState[] ScanState2ReadState;
            /*0x10*/ System.IO.Stream inStrm;
            /*0x18*/ byte[] data;
            /*0x20*/ int pos;
            /*0x24*/ int mark;
            /*0x28*/ int end;
            /*0x30*/ long offset;
            /*0x38*/ bool eof;
            /*0x39*/ bool sniffed;
            /*0x3a*/ bool isEmpty;
            /*0x3c*/ int docState;
            /*0x40*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
            /*0x60*/ System.Xml.XmlNameTable xnt;
            /*0x68*/ bool xntFromSettings;
            /*0x70*/ string xml;
            /*0x78*/ string xmlns;
            /*0x80*/ string nsxmlns;
            /*0x88*/ string baseUri;
            /*0x90*/ System.Xml.XmlSqlBinaryReader.ScanState state;
            /*0x94*/ System.Xml.XmlNodeType nodetype;
            /*0x98*/ System.Xml.BinXmlToken token;
            /*0x9c*/ int attrIndex;
            /*0xa0*/ System.Xml.XmlSqlBinaryReader.QName qnameOther;
            /*0xb8*/ System.Xml.XmlSqlBinaryReader.QName qnameElement;
            /*0xd0*/ System.Xml.XmlNodeType parentNodeType;
            /*0xd8*/ System.Xml.XmlSqlBinaryReader.ElemInfo[] elementStack;
            /*0xe0*/ int elemDepth;
            /*0xe8*/ System.Xml.XmlSqlBinaryReader.AttrInfo[] attributes;
            /*0xf0*/ int[] attrHashTbl;
            /*0xf8*/ int attrCount;
            /*0xfc*/ int posAfterAttrs;
            /*0x100*/ bool xmlspacePreserve;
            /*0x104*/ int tokLen;
            /*0x108*/ int tokDataPos;
            /*0x10c*/ bool hasTypedValue;
            /*0x110*/ System.Type valueType;
            /*0x118*/ string stringValue;
            /*0x120*/ System.Collections.Generic.Dictionary<string, System.Xml.XmlSqlBinaryReader.NamespaceDecl> namespaces;
            /*0x128*/ System.Xml.XmlSqlBinaryReader.NestedBinXml prevNameInfo;
            /*0x130*/ System.Xml.XmlReader textXmlReader;
            /*0x138*/ bool closeInput;
            /*0x139*/ bool checkCharacters;
            /*0x13a*/ bool ignoreWhitespace;
            /*0x13b*/ bool ignorePIs;
            /*0x13c*/ bool ignoreComments;
            /*0x140*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x148*/ System.Xml.SecureStringHasher hasher;
            /*0x150*/ System.Xml.XmlCharType xmlCharType;
            /*0x158*/ System.Text.Encoding unicode;
            /*0x160*/ byte version;

            static /*0x20defec*/ XmlSqlBinaryReader();
            /*0x20d6a9c*/ XmlSqlBinaryReader(System.IO.Stream stream, byte[] data, int len, string baseUri, bool closeInput, System.Xml.XmlReaderSettings settings);
            /*0x20d7a4c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x20d7b70*/ System.Xml.XmlNodeType get_NodeType();
            /*0x20d7b78*/ string get_LocalName();
            /*0x20d7b80*/ string get_NamespaceURI();
            /*0x20d7b88*/ string get_Prefix();
            /*0x20d7b90*/ string get_Value();
            /*0x20d88ec*/ int get_Depth();
            /*0x20d8998*/ string get_BaseURI();
            /*0x20d89a0*/ bool get_IsEmptyElement();
            /*0x20d89c4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x20d8a50*/ string get_XmlLang();
            /*0x20d8b1c*/ System.Type get_ValueType();
            /*0x20d8b24*/ int get_AttributeCount();
            /*0x20d8b74*/ string GetAttribute(string name, string ns);
            /*0x20d8d40*/ string GetAttribute(string name);
            /*0x20d8eb8*/ string GetAttribute(int i);
            /*0x20d8f58*/ bool MoveToAttribute(string name);
            /*0x20d90e4*/ void MoveToAttribute(int i);
            /*0x20d9198*/ bool MoveToFirstAttribute();
            /*0x20d9214*/ bool MoveToNextAttribute();
            /*0x20d92a4*/ bool MoveToElement();
            /*0x20d9368*/ bool get_EOF();
            /*0x20d9378*/ bool ReadAttributeValue();
            /*0x20d96e8*/ void Close();
            /*0x20d9760*/ System.Xml.XmlNameTable get_NameTable();
            /*0x20d9768*/ string LookupNamespace(string prefix);
            /*0x20d9820*/ void ResolveEntity();
            /*0x20d9860*/ System.Xml.ReadState get_ReadState();
            /*0x20d98f4*/ bool Read();
            /*0x20da310*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x20da6a4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x20da854*/ void VerifyVersion(int requiredVersion, System.Xml.BinXmlToken token);
            /*0x20d6f18*/ void AddInitNamespace(string prefix, string uri);
            /*0x20da8dc*/ void AddName();
            /*0x20dab00*/ void AddQName();
            /*0x20dae38*/ void NameFlush();
            /*0x20dae94*/ void SkipExtn();
            /*0x20daf80*/ int ReadQNameRef();
            /*0x20dada8*/ int ReadNameRef();
            /*0x20db010*/ bool FillAllowEOF();
            /*0x20db250*/ void Fill_(int require);
            /*0x20daf64*/ void Fill(int require);
            /*0x20db344*/ byte ReadByte();
            /*0x20db3b4*/ ushort ReadUShort();
            /*0x20daf24*/ int ParseMB32();
            /*0x20db43c*/ int ParseMB32_(byte b);
            /*0x20db4e4*/ int ParseMB32(int pos);
            /*0x20db5e8*/ int ParseMB64();
            /*0x20db628*/ System.Xml.BinXmlToken PeekToken();
            /*0x20db6a4*/ System.Xml.BinXmlToken ReadToken();
            /*0x20db728*/ System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token);
            /*0x20db7ac*/ System.Xml.BinXmlToken NextToken1();
            /*0x20db83c*/ System.Xml.BinXmlToken NextToken();
            /*0x20db8ac*/ System.Xml.BinXmlToken PeekNextToken();
            /*0x20d94e8*/ System.Xml.BinXmlToken RescanNextToken();
            /*0x20daa24*/ string ParseText();
            /*0x20db8e0*/ int ScanText(ref int start);
            /*0x20d7ca0*/ string GetString(int pos, int cch);
            /*0x20db9b8*/ string GetStringAligned(byte[] data, int offset, int cch);
            /*0x20d87cc*/ string GetAttributeText(int i);
            /*0x20d8ca0*/ int LocateAttribute(string name, string ns);
            /*0x20d8dc0*/ int LocateAttribute(string name);
            /*0x20d9008*/ void PositionOnAttribute(int i);
            /*0x20db9e4*/ void GrowElements();
            /*0x20dba70*/ void GrowAttributes();
            /*0x20dbaf8*/ void ClearAttributes();
            /*0x20dbb08*/ void PushNamespace(string prefix, string ns, bool implied);
            /*0x20dbd44*/ void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain);
            /*0x20dbdec*/ void GenerateImpliedXmlnsAttrs();
            /*0x20d9ad4*/ bool ReadInit(bool skipXmlDecl);
            /*0x20dbf74*/ void ScanAttributes();
            /*0x20dc728*/ void SimpleCheckForDuplicateAttributes();
            /*0x20dc894*/ void HashCheckForDuplicateAttributes();
            /*0x20d7f20*/ string XmlDeclValue();
            /*0x20d7e10*/ string CDATAValue();
            /*0x20dcb00*/ void FinishCDATA();
            /*0x20dcba8*/ void FinishEndElement();
            /*0x20d9fb4*/ bool ReadDoc();
            /*0x20dd74c*/ void ImplReadData(System.Xml.BinXmlToken tokenType);
            /*0x20dcc18*/ void ImplReadElement();
            /*0x20dce94*/ void ImplReadEndElement();
            /*0x20dcf70*/ void ImplReadDoctype();
            /*0x20dd248*/ void ImplReadPI();
            /*0x20dd2b8*/ void ImplReadComment();
            /*0x20dd2f0*/ void ImplReadCDATA();
            /*0x20dd330*/ void ImplReadNest();
            /*0x20dd3dc*/ void ImplReadEndNest();
            /*0x20dd40c*/ void ImplReadXmlText();
            /*0x20dd93c*/ void UpdateFromTextReader();
            /*0x20d8fe0*/ bool UpdateFromTextReader(bool needUpdate);
            /*0x20dd8d0*/ void CheckAllowContent();
            /*0x20d7000*/ void GenerateTokenTypeMap();
            /*0x20d95e0*/ System.Type GetValueType(System.Xml.BinXmlToken token);
            /*0x20d95d4*/ void ReScanOverValue(System.Xml.BinXmlToken token);
            /*0x20dc560*/ System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x20ddcb8*/ System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x20dd9e8*/ System.Xml.XmlNodeType CheckText(bool attr);
            /*0x20ddc10*/ System.Xml.XmlNodeType CheckTextIsWS();
            /*0x20de0d8*/ void CheckValueTokenBounds();
            /*0x20ddfdc*/ int GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token);
            /*0x20de13c*/ int XsdKatmaiTimeScaleToValueLength(byte scale);
            /*0x20de228*/ long ValueAsLong();
            /*0x20dea54*/ ulong ValueAsULong();
            /*0x20de8bc*/ decimal ValueAsDecimal();
            /*0x20de780*/ double ValueAsDouble();
            /*0x20dec14*/ string ValueAsDateTimeString();
            /*0x20d8074*/ string ValueAsString(System.Xml.BinXmlToken token);
            /*0x20de428*/ short GetInt16(int pos);
            /*0x20de5d4*/ ushort GetUInt16(int pos);
            /*0x20de478*/ int GetInt32(int pos);
            /*0x20de624*/ uint GetUInt32(int pos);
            /*0x20de4f8*/ long GetInt64(int pos);
            /*0x20de6a4*/ ulong GetUInt64(int pos);
            /*0x20deab0*/ float GetSingle(int offset);
            /*0x20deb34*/ double GetDouble(int offset);
            /*0x20da890*/ System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token);
            /*0x20db2cc*/ System.Exception ThrowXmlException(string res);
            /*0x20dc448*/ System.Exception ThrowXmlException(string res, string arg1, string arg2);
            /*0x20dc6a0*/ System.Exception ThrowNotSupported(string res);

            enum ScanState
            {
                Doc = 0,
                XmlText = 1,
                Attr = 2,
                AttrVal = 3,
                AttrValPseudoValue = 4,
                Init = 5,
                Error = 6,
                EOF = 7,
                Closed = 8,
            }

            struct QName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string localname;
                /*0x20*/ string namespaceUri;

                static /*0x16c8930*/ bool op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b);
                /*0xac161c*/ QName(string prefix, string lname, string nsUri);
                /*0xac1628*/ void Set(string prefix, string lname, string nsUri);
                /*0xac1634*/ void Clear();
                /*0xac168c*/ bool MatchNs(string lname, string nsUri);
                /*0xac1694*/ bool MatchPrefix(string prefix, string lname);
                /*0xac169c*/ void CheckPrefixNS(string prefix, string namespaceUri);
                /*0xac16a4*/ int GetHashCode();
                /*0xac16ac*/ int GetNSHashCode(System.Xml.SecureStringHasher hasher);
                /*0xac16b4*/ bool Equals(object other);
                /*0xac16bc*/ string ToString();
            }

            struct ElemInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string xmlLang;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x34*/ bool xmlspacePreserve;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;

                /*0xac15ec*/ void Set(System.Xml.XmlSqlBinaryReader.QName name, bool xmlspacePreserve);
                /*0xac160c*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear();
            }

            struct AttrInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string val;
                /*0x30*/ int contentPos;
                /*0x34*/ int hashCode;
                /*0x38*/ int prevHash;

                /*0xac14ec*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, string v);
                /*0xac1508*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, int pos);
                /*0xac1524*/ void GetLocalnameAndNamespaceUri(ref string localname, ref string namespaceUri);
                /*0xac1538*/ int GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, ref string localname, ref string namespaceUri);
                /*0xac1570*/ bool MatchNS(string localname, string namespaceUri);
                /*0xac1578*/ bool MatchHashNS(int hash, string localname, string namespaceUri);
                /*0xac159c*/ void AdjustPosition(int adj);
            }

            class NamespaceDecl
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;
                /*0x28*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;
                /*0x30*/ int scope;
                /*0x34*/ bool implied;

                /*0x16c8580*/ NamespaceDecl(string prefix, string nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied);
            }

            struct SymbolTables
            {
                /*0x10*/ string[] symtable;
                /*0x18*/ int symCount;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.QName[] qnametable;
                /*0x28*/ int qnameCount;

                /*0xac1700*/ void Init();
            }

            class NestedBinXml
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
                /*0x30*/ int docState;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NestedBinXml next;

                /*0x16c85e8*/ NestedBinXml(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, int docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next);
            }
        }

        class BitStack
        {
            /*0x10*/ uint[] bitStack;
            /*0x18*/ int stackPos;
            /*0x1c*/ uint curr;

            /*0x1590704*/ BitStack();
            /*0x1590730*/ void PushBit(bool bit);
            /*0x159085c*/ bool PopBit();
            /*0x15908e0*/ bool PeekBit();
            /*0x159076c*/ void PushCurr();
            /*0x1590890*/ void PopCurr();
        }

        class Bits
        {
            static /*0x0*/ uint MASK_0101010101010101;
            static /*0x4*/ uint MASK_0011001100110011;
            static /*0x8*/ uint MASK_0000111100001111;
            static /*0xc*/ uint MASK_0000000011111111;
            static /*0x10*/ uint MASK_1111111111111111;

            static /*0x1590a10*/ Bits();
            static /*0x15908ec*/ int Count(uint num);
            static /*0x1590998*/ int LeastPosition(uint num);
        }

        class ByteStack
        {
            /*0x10*/ byte[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int top;
            /*0x20*/ int size;

            /*0x1590a98*/ ByteStack(int growthRate);
            /*0x1590b0c*/ void Push(byte data);
            /*0x1590bf0*/ byte Pop();
        }

        class BinaryCompatibility
        {
            static /*0x0*/ bool _targetsAtLeast_Desktop_V4_5_2;

            static /*0x158fad4*/ BinaryCompatibility();
            static /*0x158f854*/ bool get_TargetsAtLeast_Desktop_V4_5_2();
            static /*0x158f8b8*/ bool RunningOnCheck(string propertyName);
        }

        class CharEntityEncoderFallback : System.Text.EncoderFallback
        {
            /*0x18*/ System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;
            /*0x20*/ int[] textContentMarks;
            /*0x28*/ int endMarkPos;
            /*0x2c*/ int curMarkPos;
            /*0x30*/ int startOffset;

            /*0x159122c*/ CharEntityEncoderFallback();
            /*0x1591234*/ System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
            /*0x1591314*/ int get_MaxCharCount();
            /*0x159131c*/ void set_StartOffset(int value);
            /*0x1591324*/ void Reset(int[] textContentMarks, int endMarkPos);
            /*0x1591330*/ bool CanReplaceAt(int index);
        }

        class CharEntityEncoderFallbackBuffer : System.Text.EncoderFallbackBuffer
        {
            /*0x30*/ System.Xml.CharEntityEncoderFallback parent;
            /*0x38*/ string charEntity;
            /*0x40*/ int charEntityIndex;

            /*0x159129c*/ CharEntityEncoderFallbackBuffer(System.Xml.CharEntityEncoderFallback parent);
            /*0x159139c*/ bool Fallback(char charUnknown, int index);
            /*0x15915a8*/ bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
            /*0x1591884*/ char GetNextChar();
            /*0x15918d8*/ bool MovePrevious();
            /*0x15918f8*/ int get_Remaining();
            /*0x159192c*/ void Reset();
            /*0x1591874*/ int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate);
        }

        enum ConformanceLevel
        {
            Auto = 0,
            Fragment = 1,
            Document = 2,
        }

        enum DtdProcessing
        {
            Prohibit = 0,
            Ignore = 1,
            Parse = 2,
        }

        enum EntityHandling
        {
            ExpandEntities = 1,
            ExpandCharEntities = 2,
        }

        class HtmlEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            static /*0x0*/ System.Xml.TernaryTreeReadOnly elementPropertySearch;
            static /*0x8*/ System.Xml.TernaryTreeReadOnly attributePropertySearch;
            /*0xc0*/ System.Xml.ByteStack elementScope;
            /*0xc8*/ System.Xml.ElementProperties currentElementProperties;
            /*0xcc*/ System.Xml.AttributeProperties currentAttributeProperties;
            /*0xd0*/ bool endsWithAmpersand;
            /*0xd8*/ byte[] uriEscapingBuffer;
            /*0xe0*/ string mediaType;
            /*0xe8*/ bool doNotEscapeUriAttributes;

            /*0x14ca8ac*/ HtmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x14caa5c*/ HtmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x14caa8c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x14caa90*/ void WriteXmlDeclaration(string xmldecl);
            /*0x14caa94*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x14cad04*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x14cae4c*/ void StartElementContent();
            /*0x14cafc8*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x14cb0ec*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x14cb210*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x14cb3b8*/ void WriteEndAttribute();
            /*0x14cb534*/ void WriteProcessingInstruction(string target, string text);
            /*0x14cb694*/ void WriteString(string text);
            /*0x14cb764*/ void WriteEntityRef(string name);
            /*0x14cb7c0*/ void WriteCharEntity(char ch);
            /*0x14cb81c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x14cb878*/ void WriteChars(char[] buffer, int index, int count);
            /*0x14ca8dc*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x14caeb0*/ void WriteMetaElement();
            /*0x14cb74c*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x14cb708*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x14cbc74*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x14cb914*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x14cb464*/ void OutputRestAmps();
        }

        class HtmlEncodedRawTextWriterIndent : System.Xml.HtmlEncodedRawTextWriter
        {
            /*0xec*/ int indentLevel;
            /*0xf0*/ int endBlockPos;
            /*0xf8*/ string indentChars;
            /*0x100*/ bool newLineOnAttributes;

            /*0x14cbf08*/ HtmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x14cbf80*/ HtmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x14cbfd0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x14cbff8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x14cc228*/ void StartElementContent();
            /*0x14cc2b0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x14cc350*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x14cc3c8*/ void FlushBuffer();
            /*0x14cbf58*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x14cc1d4*/ void WriteIndent();
        }

        class HtmlTernaryTree
        {
            static /*0x0*/ byte[] htmlElements;
            static /*0x8*/ byte[] htmlAttributes;

            static /*0x14cc3f4*/ HtmlTernaryTree();
        }

        class HtmlUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            static /*0x0*/ System.Xml.TernaryTreeReadOnly elementPropertySearch;
            static /*0x8*/ System.Xml.TernaryTreeReadOnly attributePropertySearch;
            /*0x90*/ System.Xml.ByteStack elementScope;
            /*0x98*/ System.Xml.ElementProperties currentElementProperties;
            /*0x9c*/ System.Xml.AttributeProperties currentAttributeProperties;
            /*0xa0*/ bool endsWithAmpersand;
            /*0xa8*/ byte[] uriEscapingBuffer;
            /*0xb0*/ string mediaType;
            /*0xb8*/ bool doNotEscapeUriAttributes;

            /*0x14cc4c8*/ HtmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x14cc678*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x14cc67c*/ void WriteXmlDeclaration(string xmldecl);
            /*0x14cc680*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x14cc8d0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x14cc9f8*/ void StartElementContent();
            /*0x14ccb74*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x14ccc70*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x14ccd6c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x14ccef4*/ void WriteEndAttribute();
            /*0x14cd050*/ void WriteProcessingInstruction(string target, string text);
            /*0x14cd17c*/ void WriteString(string text);
            /*0x14cd22c*/ void WriteEntityRef(string name);
            /*0x14cd288*/ void WriteCharEntity(char ch);
            /*0x14cd2e4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x14cd340*/ void WriteChars(char[] buffer, int index, int count);
            /*0x14cc4f8*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x14cca5c*/ void WriteMetaElement();
            /*0x14cd214*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x14cd1d0*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x14cd6d4*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x14cd390*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x14ccf80*/ void OutputRestAmps();
        }

        class HtmlUtf8RawTextWriterIndent : System.Xml.HtmlUtf8RawTextWriter
        {
            /*0xbc*/ int indentLevel;
            /*0xc0*/ int endBlockPos;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool newLineOnAttributes;

            /*0x14cd950*/ HtmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x14cd9c8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x14cd9f0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x14cdc04*/ void StartElementContent();
            /*0x14cdc8c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x14cdd2c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x14cdda4*/ void FlushBuffer();
            /*0x14cd9a0*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x14cdbb0*/ void WriteIndent();
        }

        interface IDtdInfo
        {
            System.Xml.XmlQualifiedName get_Name();
            string get_InternalDtdSubset();
            bool get_HasDefaultAttributes();
            bool get_HasNonCDataAttributes();
            System.Xml.IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);
            System.Xml.IDtdEntityInfo LookupEntity(string name);
        }

        interface IDtdAttributeListInfo
        {
            bool get_HasNonCDataAttributes();
            System.Xml.IDtdAttributeInfo LookupAttribute(string prefix, string localName);
            System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes();
        }

        interface IDtdAttributeInfo
        {
            string get_Prefix();
            string get_LocalName();
            int get_LineNumber();
            int get_LinePosition();
            bool get_IsNonCDataType();
            bool get_IsDeclaredInExternal();
            bool get_IsXmlAttribute();
        }

        interface IDtdDefaultAttributeInfo : System.Xml.IDtdAttributeInfo
        {
            string get_DefaultValueExpanded();
            object get_DefaultValueTyped();
            int get_ValueLineNumber();
            int get_ValueLinePosition();
        }

        interface IDtdEntityInfo
        {
            string get_Name();
            bool get_IsExternal();
            bool get_IsDeclaredInExternal();
            bool get_IsUnparsedEntity();
            bool get_IsParameterEntity();
            string get_BaseUriString();
            string get_DeclaredUriString();
            string get_SystemId();
            string get_PublicId();
            string get_Text();
            int get_LineNumber();
            int get_LinePosition();
        }

        interface IDtdParser
        {
            System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            System.Xml.IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
        }

        interface IDtdParserAdapter
        {
            System.Xml.XmlNameTable get_NameTable();
            System.Xml.IXmlNamespaceResolver get_NamespaceResolver();
            System.Uri get_BaseUri();
            char[] get_ParsingBuffer();
            int get_ParsingBufferLength();
            int get_CurrentPosition();
            void set_CurrentPosition(int value);
            int get_LineNo();
            int get_LineStartPosition();
            bool get_IsEof();
            int get_EntityStackLength();
            bool get_IsEntityEolNormalized();
            int ReadData();
            void OnNewLine(int pos);
            int ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            void ParsePI(System.Text.StringBuilder sb);
            void ParseComment(System.Text.StringBuilder sb);
            bool PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            bool PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            bool PushExternalSubset(string systemId, string publicId);
            void PushInternalDtd(string baseUri, string internalDtd);
            void OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            void OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            void Throw(System.Exception e);
        }

        interface IDtdParserAdapterWithValidation : System.Xml.IDtdParserAdapter
        {
            bool get_DtdValidation();
            System.Xml.IValidationEventHandling get_ValidationEventHandling();
        }

        interface IDtdParserAdapterV1 : System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
        {
            bool get_V1CompatibilityMode();
            bool get_Normalization();
            bool get_Namespaces();
        }

        class OnRemoveWriter : System.MulticastDelegate
        {
            /*0x14d43a4*/ OnRemoveWriter(object object, nint method);
            /*0x14d4404*/ void Invoke(System.Xml.XmlRawWriter writer);
            /*0x14d477c*/ System.IAsyncResult BeginInvoke(System.Xml.XmlRawWriter writer, System.AsyncCallback callback, object object);
            /*0x14d47a0*/ void EndInvoke(System.IAsyncResult result);
        }

        interface IValidationEventHandling
        {
            object get_EventHandler();
            void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
        }

        class IncrementalReadDecoder
        {
            /*0x14cddd0*/ IncrementalReadDecoder();
            bool get_IsFull();
            int Decode(char[] chars, int startPos, int len);
        }

        class IncrementalReadDummyDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x14cdde8*/ IncrementalReadDummyDecoder();
            /*0x14cddd8*/ bool get_IsFull();
            /*0x14cdde0*/ int Decode(char[] chars, int startPos, int len);
        }

        enum NamespaceHandling
        {
            Default = 0,
            OmitDuplicates = 1,
        }

        enum NewLineHandling
        {
            Replace = 0,
            Entitize = 1,
            None = 2,
        }

        class QueryOutputWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ bool inCDataSection;
            /*0x38*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, int> lookupCDataElems;
            /*0x40*/ System.Xml.BitStack bitsCData;
            /*0x48*/ System.Xml.XmlQualifiedName qnameCData;
            /*0x50*/ bool outputDocType;
            /*0x51*/ bool checkWellFormedDoc;
            /*0x52*/ bool hasDocElem;
            /*0x53*/ bool inAttr;
            /*0x58*/ string systemId;
            /*0x60*/ string publicId;
            /*0x68*/ int depth;

            /*0x182336c*/ QueryOutputWriter(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x18235e8*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x1823614*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1823638*/ void WriteXmlDeclaration(string xmldecl);
            /*0x182365c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1823690*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1823868*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x18238d8*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1823948*/ void StartElementContent();
            /*0x182396c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1823998*/ void WriteEndAttribute();
            /*0x18239c4*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x18239e8*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1823a0c*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x1823a30*/ void WriteEndNamespaceDeclaration();
            /*0x1823a54*/ void WriteCData(string text);
            /*0x1823a78*/ void WriteComment(string text);
            /*0x1823aa4*/ void WriteProcessingInstruction(string name, string text);
            /*0x1823ad0*/ void WriteWhitespace(string ws);
            /*0x1823b8c*/ void WriteString(string text);
            /*0x1823bfc*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1823cb0*/ void WriteEntityRef(string name);
            /*0x1823cdc*/ void WriteCharEntity(char ch);
            /*0x1823d08*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1823d34*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1823de8*/ void WriteRaw(string data);
            /*0x1823e58*/ void Close();
            /*0x1823f00*/ void Flush();
            /*0x1823b40*/ bool StartCDataSection();
            /*0x1823860*/ void EndCDataSection();
        }

        class ReadContentAsBinaryHelper
        {
            /*0x10*/ System.Xml.XmlReader reader;
            /*0x18*/ System.Xml.ReadContentAsBinaryHelper.State state;
            /*0x1c*/ int valueOffset;
            /*0x20*/ bool isEnd;

            /*0x1824e84*/ void Finish();
            /*0x18250c4*/ void Reset();
            /*0x1824fe0*/ bool MoveToNextContentNode(bool moveIfOnContentNode);

            enum State
            {
                None = 0,
                InReadContent = 1,
                InReadElementContent = 2,
            }
        }

        enum ElementProperties
        {
            DEFAULT = 0,
            URI_PARENT = 1,
            BOOL_PARENT = 2,
            NAME_PARENT = 4,
            EMPTY = 8,
            NO_ENTITIES = 16,
            HEAD = 32,
            BLOCK_WS = 64,
            HAS_NS = 128,
        }

        enum AttributeProperties
        {
            DEFAULT = 0,
            URI = 1,
            BOOLEAN = 2,
            NAME = 4,
        }

        class TernaryTreeReadOnly
        {
            /*0x10*/ byte[] nodeBuffer;

            /*0x1b11878*/ TernaryTreeReadOnly(byte[] nodeBuffer);
            /*0x1b118a4*/ byte FindCaseInsensitiveString(string stringToFind);
        }

        enum ReadState
        {
            Initial = 0,
            Interactive = 1,
            Error = 2,
            EndOfFile = 3,
            Closed = 4,
        }

        class SecureStringHasher : System.Collections.Generic.IEqualityComparer<string>
        {
            static /*0x0*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;
            /*0x10*/ int hashCodeRandomizer;

            static /*0x1b0eac8*/ int GetHashCodeOfString(string key, int sLen, long additionalEntropy);
            static /*0x1b0e954*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate();
            /*0x1b0e874*/ SecureStringHasher();
            /*0x1b0e8a4*/ bool Equals(string x, string y);
            /*0x1b0e8bc*/ int GetHashCode(string key);

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x16c44cc*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x16c452c*/ int Invoke(string s, int sLen, long additionalEntropy);
                /*0x16c48ec*/ System.IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, System.AsyncCallback callback, object object);
                /*0x16c49ac*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class TextEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            /*0x1b119dc*/ TextEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x1b119e4*/ TextEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1b119ec*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1b119f0*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1b119f4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1b119f8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1b119fc*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1b11a00*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1b11a04*/ void StartElementContent();
            /*0x1b11a08*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1b11a14*/ void WriteEndAttribute();
            /*0x1b11a1c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x1b11a20*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1b11a28*/ void WriteCData(string text);
            /*0x1b11a30*/ void WriteComment(string text);
            /*0x1b11a34*/ void WriteProcessingInstruction(string name, string text);
            /*0x1b11a38*/ void WriteEntityRef(string name);
            /*0x1b11a3c*/ void WriteCharEntity(char ch);
            /*0x1b11a40*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1b11a44*/ void WriteWhitespace(string ws);
            /*0x1b11a58*/ void WriteString(string textBlock);
            /*0x1b11a6c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1b11a80*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1b11a94*/ void WriteRaw(string data);
        }

        class TextUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x1b11aa8*/ TextUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1b11ab0*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1b11ab4*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1b11ab8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1b11abc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1b11ac0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1b11ac4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1b11ac8*/ void StartElementContent();
            /*0x1b11acc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1b11ad8*/ void WriteEndAttribute();
            /*0x1b11ae0*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x1b11ae4*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1b11aec*/ void WriteCData(string text);
            /*0x1b11af4*/ void WriteComment(string text);
            /*0x1b11af8*/ void WriteProcessingInstruction(string name, string text);
            /*0x1b11afc*/ void WriteEntityRef(string name);
            /*0x1b11b00*/ void WriteCharEntity(char ch);
            /*0x1b11b04*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1b11b08*/ void WriteWhitespace(string ws);
            /*0x1b11b1c*/ void WriteString(string textBlock);
            /*0x1b11b30*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1b11b44*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1b11b58*/ void WriteRaw(string data);
        }

        class ValidatingReaderNodeData
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ string prefix;
            /*0x28*/ string nameWPrefix;
            /*0x30*/ string rawValue;
            /*0x38*/ string originalStringValue;
            /*0x40*/ int depth;
            /*0x48*/ System.Xml.AttributePSVIInfo attributePSVIInfo;
            /*0x50*/ System.Xml.XmlNodeType nodeType;
            /*0x54*/ int lineNo;
            /*0x58*/ int linePos;

            /*0x1b1b35c*/ ValidatingReaderNodeData();
            /*0x1b1b428*/ ValidatingReaderNodeData(System.Xml.XmlNodeType nodeType);
            /*0x1b1b458*/ string get_LocalName();
            /*0x1b1b460*/ void set_LocalName(string value);
            /*0x1b1b468*/ string get_Namespace();
            /*0x1b1b470*/ void set_Namespace(string value);
            /*0x1b1b478*/ string get_Prefix();
            /*0x1b1b480*/ void set_Prefix(string value);
            /*0x1b1b488*/ string GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable);
            /*0x1b1b528*/ int get_Depth();
            /*0x1b1b530*/ void set_Depth(int value);
            /*0x1b1b538*/ string get_RawValue();
            /*0x1b1b540*/ void set_RawValue(string value);
            /*0x1b1b548*/ string get_OriginalStringValue();
            /*0x1b1b550*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1b1b558*/ void set_NodeType(System.Xml.XmlNodeType value);
            /*0x1b1b560*/ System.Xml.AttributePSVIInfo get_AttInfo();
            /*0x1b1b568*/ void set_AttInfo(System.Xml.AttributePSVIInfo value);
            /*0x1b1b570*/ int get_LineNumber();
            /*0x1b1b578*/ int get_LinePosition();
            /*0x1b1b388*/ void Clear(System.Xml.XmlNodeType nodeType);
            /*0x1b1b580*/ void SetLineInfo(int lineNo, int linePos);
            /*0x1b1b588*/ void SetLineInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x1b1b6ac*/ void SetItemData(string localName, string prefix, string ns, int depth);
            /*0x1b1b72c*/ void SetItemData(string value);
            /*0x1b1b734*/ void SetItemData(string value, string originalStringValue);
        }

        enum ValidationType
        {
            None = 0,
            Auto = 1,
            DTD = 2,
            XDR = 3,
            Schema = 4,
        }

        enum WhitespaceHandling
        {
            All = 0,
            Significant = 1,
            None = 2,
        }

        class XmlAsyncCheckReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Threading.Tasks.Task lastTask;

            static /*0x1d28428*/ System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader);
            /*0x1d287c8*/ XmlAsyncCheckReader(System.Xml.XmlReader reader);
            /*0x1d28420*/ System.Xml.XmlReader get_CoreReader();
            /*0x1d2887c*/ void CheckAsync();
            /*0x1d288fc*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x1d289a0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d289d4*/ string get_Name();
            /*0x1d28a08*/ string get_LocalName();
            /*0x1d28a3c*/ string get_NamespaceURI();
            /*0x1d28a70*/ string get_Prefix();
            /*0x1d28aa4*/ string get_Value();
            /*0x1d28ad8*/ int get_Depth();
            /*0x1d28b0c*/ string get_BaseURI();
            /*0x1d28b44*/ bool get_IsEmptyElement();
            /*0x1d28b7c*/ bool get_IsDefault();
            /*0x1d28bb4*/ char get_QuoteChar();
            /*0x1d28bec*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1d28c24*/ string get_XmlLang();
            /*0x1d28c5c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1d28c94*/ System.Type get_ValueType();
            /*0x1d28ccc*/ int get_AttributeCount();
            /*0x1d28d04*/ string GetAttribute(string name);
            /*0x1d28d44*/ string GetAttribute(string name, string namespaceURI);
            /*0x1d28d94*/ string GetAttribute(int i);
            /*0x1d28dd4*/ bool MoveToAttribute(string name);
            /*0x1d28e14*/ void MoveToAttribute(int i);
            /*0x1d28e54*/ bool MoveToFirstAttribute();
            /*0x1d28e8c*/ bool MoveToNextAttribute();
            /*0x1d28ec4*/ bool MoveToElement();
            /*0x1d28efc*/ bool ReadAttributeValue();
            /*0x1d28f34*/ bool Read();
            /*0x1d28f6c*/ bool get_EOF();
            /*0x1d28fa4*/ void Close();
            /*0x1d28fdc*/ System.Xml.ReadState get_ReadState();
            /*0x1d29014*/ void Skip();
            /*0x1d2904c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1d29084*/ string LookupNamespace(string prefix);
            /*0x1d290c4*/ bool get_CanResolveEntity();
            /*0x1d290fc*/ void ResolveEntity();
            /*0x1d29134*/ bool get_CanReadValueChunk();
            /*0x1d2916c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x1d291c4*/ string ReadString();
            /*0x1d291fc*/ System.Xml.XmlNodeType MoveToContent();
            /*0x1d29234*/ void ReadStartElement();
            /*0x1d2926c*/ string ReadElementString();
            /*0x1d292a4*/ void ReadEndElement();
            /*0x1d292dc*/ bool IsStartElement(string localname, string ns);
            /*0x1d2932c*/ string ReadInnerXml();
            /*0x1d29364*/ bool get_HasAttributes();
            /*0x1d2939c*/ void Dispose(bool disposing);
            /*0x1d293cc*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x1d29404*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlAsyncCheckReaderWithNS : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x20*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x1d28740*/ XmlAsyncCheckReaderWithNS(System.Xml.XmlReader reader);
            /*0x1d29d50*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1d29e0c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x1d29ecc*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfo : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlLineInfo
        {
            /*0x20*/ System.Xml.IXmlLineInfo readerAsIXmlLineInfo;

            /*0x1d286b8*/ XmlAsyncCheckReaderWithLineInfo(System.Xml.XmlReader reader);
            /*0x1d2943c*/ bool HasLineInfo();
            /*0x1d294e8*/ int get_LineNumber();
            /*0x1d29598*/ int get_LinePosition();
        }

        class XmlAsyncCheckReaderWithLineInfoNS : System.Xml.XmlAsyncCheckReaderWithLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x28*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x1d28630*/ XmlAsyncCheckReaderWithLineInfoNS(System.Xml.XmlReader reader);
            /*0x1d29648*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1d29704*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x1d297c4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfoNSSchema : System.Xml.XmlAsyncCheckReaderWithLineInfoNS, System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x30*/ System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;

            /*0x1d285a8*/ XmlAsyncCheckReaderWithLineInfoNSSchema(System.Xml.XmlReader reader);
            /*0x1d29884*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x1d29930*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x1d299e0*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x1d29a90*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x1d29b40*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x1d29bf0*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x1d29ca0*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
        }

        class XmlAsyncCheckWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter coreWriter;
            /*0x20*/ System.Threading.Tasks.Task lastTask;

            /*0x1d29f8c*/ XmlAsyncCheckWriter(System.Xml.XmlWriter writer);
            /*0x1d2a014*/ void CheckAsync();
            /*0x1d2a094*/ void WriteStartDocument();
            /*0x1d2a0c8*/ void WriteStartDocument(bool standalone);
            /*0x1d2a104*/ void WriteEndDocument();
            /*0x1d2a138*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1d2a19c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1d2a1f0*/ void WriteEndElement();
            /*0x1d2a224*/ void WriteFullEndElement();
            /*0x1d2a258*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1d2a2ac*/ void WriteEndAttribute();
            /*0x1d2a2e4*/ void WriteCData(string text);
            /*0x1d2a324*/ void WriteComment(string text);
            /*0x1d2a364*/ void WriteProcessingInstruction(string name, string text);
            /*0x1d2a3b4*/ void WriteEntityRef(string name);
            /*0x1d2a3f4*/ void WriteCharEntity(char ch);
            /*0x1d2a434*/ void WriteWhitespace(string ws);
            /*0x1d2a474*/ void WriteString(string text);
            /*0x1d2a4b4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1d2a504*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1d2a55c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1d2a5b4*/ void WriteRaw(string data);
            /*0x1d2a5f4*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1d2a64c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1d2a6a4*/ System.Xml.WriteState get_WriteState();
            /*0x1d2a6dc*/ void Close();
            /*0x1d2a714*/ void Flush();
            /*0x1d2a74c*/ string LookupPrefix(string ns);
            /*0x1d2a78c*/ void WriteValue(string value);
            /*0x1d2a7cc*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x1d2a81c*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x1d2a86c*/ void Dispose(bool disposing);
        }

        class XmlAutoDetectWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ System.Xml.OnRemoveWriter onRemove;
            /*0x38*/ System.Xml.XmlWriterSettings writerSettings;
            /*0x40*/ System.Xml.XmlEventCache eventCache;
            /*0x48*/ System.IO.TextWriter textWriter;
            /*0x50*/ System.IO.Stream strm;

            static /*0x1d570a0*/ bool IsHtmlTag(string tagName);
            /*0x1d56e7c*/ XmlAutoDetectWriter(System.Xml.XmlWriterSettings writerSettings);
            /*0x1d56f3c*/ XmlAutoDetectWriter(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings);
            /*0x1d56f68*/ XmlAutoDetectWriter(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings);
            /*0x1d56f94*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1d57018*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1d57310*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1d57374*/ void WriteEndAttribute();
            /*0x1d57398*/ void WriteCData(string text);
            /*0x1d5744c*/ void WriteComment(string text);
            /*0x1d5747c*/ void WriteProcessingInstruction(string name, string text);
            /*0x1d574ac*/ void WriteWhitespace(string ws);
            /*0x1d574dc*/ void WriteString(string text);
            /*0x1d57528*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1d57564*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1d575a0*/ void WriteRaw(string data);
            /*0x1d575ec*/ void WriteEntityRef(string name);
            /*0x1d5763c*/ void WriteCharEntity(char ch);
            /*0x1d5768c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1d576ec*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1d57754*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1d577bc*/ void Close();
            /*0x1d57804*/ void Flush();
            /*0x1d5784c*/ void WriteValue(string value);
            /*0x1d5789c*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x1d578d0*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1d57920*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1d57970*/ void StartElementContent();
            /*0x1d57994*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1d579b8*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1d579dc*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x1d57a3c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1d57a60*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x1d57ab0*/ void WriteEndNamespaceDeclaration();
            /*0x1d57008*/ void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod);
            /*0x1d573e4*/ bool TextBlockCreatesWriter(string textBlock);
            /*0x1d571c0*/ void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod);
        }

        class XmlEncodedRawTextWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ bool useAsync;
            /*0x30*/ byte[] bufBytes;
            /*0x38*/ System.IO.Stream stream;
            /*0x40*/ System.Text.Encoding encoding;
            /*0x48*/ System.Xml.XmlCharType xmlCharType;
            /*0x50*/ int bufPos;
            /*0x54*/ int textPos;
            /*0x58*/ int contentPos;
            /*0x5c*/ int cdataPos;
            /*0x60*/ int attrEndPos;
            /*0x64*/ int bufLen;
            /*0x68*/ bool writeToNull;
            /*0x69*/ bool hadDoubleBracket;
            /*0x6a*/ bool inAttributeValue;
            /*0x6c*/ int bufBytesUsed;
            /*0x70*/ char[] bufChars;
            /*0x78*/ System.Text.Encoder encoder;
            /*0x80*/ System.IO.TextWriter writer;
            /*0x88*/ bool trackTextContent;
            /*0x89*/ bool inTextContent;
            /*0x8c*/ int lastMarkPos;
            /*0x90*/ int[] textContentMarks;
            /*0x98*/ System.Xml.CharEntityEncoderFallback charEntityFallback;
            /*0xa0*/ System.Xml.NewLineHandling newLineHandling;
            /*0xa4*/ bool closeOutput;
            /*0xa5*/ bool omitXmlDeclaration;
            /*0xa8*/ string newLineChars;
            /*0xb0*/ bool checkCharacters;
            /*0xb4*/ System.Xml.XmlStandalone standalone;
            /*0xb8*/ System.Xml.XmlOutputMethod outputMethod;
            /*0xbc*/ bool autoXmlDeclaration;
            /*0xbd*/ bool mergeCDataSections;

            static /*0x1fd6880*/ char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst);
            static /*0x1fd67ac*/ char* LtEntity(char* pDst);
            static /*0x1fd67c4*/ char* GtEntity(char* pDst);
            static /*0x1fd6784*/ char* AmpEntity(char* pDst);
            static /*0x1fd67dc*/ char* QuoteEntity(char* pDst);
            static /*0x1fd6808*/ char* TabEntity(char* pDst);
            static /*0x1fd6858*/ char* LineFeedEntity(char* pDst);
            static /*0x1fd6830*/ char* CarriageReturnEntity(char* pDst);
            static /*0x1fd6cf8*/ char* CharEntity(char* pDst, char ch);
            static /*0x1fd6cc0*/ char* RawStartCData(char* pDst);
            static /*0x1fd6ca0*/ char* RawEndCData(char* pDst);
            /*0x1fd3124*/ XmlEncodedRawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x1fd3598*/ XmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x1fd3674*/ XmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1fd38ec*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1fd3b34*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1fd3bbc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1fd3dd4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1fd3eb0*/ void StartElementContent();
            /*0x1fd3f04*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1fd4094*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1fd41c0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1fd4304*/ void WriteEndAttribute();
            /*0x1fd4384*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x1fd43dc*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1fd43e4*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x1fd4530*/ void WriteEndNamespaceDeclaration();
            /*0x1fd45b0*/ void WriteCData(string text);
            /*0x1fd4b74*/ void WriteComment(string text);
            /*0x1fd5024*/ void WriteProcessingInstruction(string name, string text);
            /*0x1fd5184*/ void WriteEntityRef(string name);
            /*0x1fd5260*/ void WriteCharEntity(char ch);
            /*0x1fd547c*/ void WriteWhitespace(string ws);
            /*0x1fd5aa8*/ void WriteString(string text);
            /*0x1fd5b18*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1fd5c98*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1fd5d2c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1fd5fe4*/ void WriteRaw(string data);
            /*0x1fd604c*/ void Close();
            /*0x1fd6388*/ void Flush();
            /*0x1fd63f0*/ void FlushBuffer();
            /*0x1fd6648*/ void EncodeChars(int startOffset, int endOffset, bool writeAllToStream);
            /*0x1fd62e0*/ void FlushEncoder();
            /*0x1fd54ec*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1fd57ec*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1fd3af4*/ void RawText(string s);
            /*0x1fd6b28*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x1fd5db4*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x1fd4d04*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x1fd4858*/ void WriteCDataSection(string text);
            /*0x1fd6a34*/ char* InvalidXmlChar(int ch, char* pDst, bool entitize);
            /*0x1fd6dac*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst);
            /*0x1fd3a6c*/ void ChangeTextContentMark(bool value);
            /*0x1fd6e68*/ void GrowTextContentMarks();
            /*0x1fd6ac8*/ char* WriteNewLine(char* pDst);
            /*0x1fd3210*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlEncodedRawTextWriterIndent : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xc0*/ int indentLevel;
            /*0xc4*/ bool newLineOnAttributes;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool mixedContent;
            /*0xd8*/ System.Xml.BitStack mixedContentStack;
            /*0xe0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x1fd6f4c*/ XmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x1fd7094*/ XmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1fd70c0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1fd7178*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1fd71f0*/ void StartElementContent();
            /*0x1fd724c*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x1fd7254*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1fd72e0*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1fd736c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1fd73b4*/ void WriteCData(string text);
            /*0x1fd73c0*/ void WriteComment(string text);
            /*0x1fd7404*/ void WriteProcessingInstruction(string target, string text);
            /*0x1fd7458*/ void WriteEntityRef(string name);
            /*0x1fd7464*/ void WriteCharEntity(char ch);
            /*0x1fd7470*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1fd747c*/ void WriteWhitespace(string ws);
            /*0x1fd7488*/ void WriteString(string text);
            /*0x1fd7494*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1fd74a0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1fd74ac*/ void WriteRaw(string data);
            /*0x1fd74b8*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1fd6f78*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x1fd712c*/ void WriteIndent();
        }

        class XmlEventCache : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;
            /*0x30*/ System.Xml.XmlEventCache.XmlEvent[] pageCurr;
            /*0x38*/ int pageSize;
            /*0x3c*/ bool hasRootNode;
            /*0x40*/ System.Xml.Xsl.Runtime.StringConcat singleText;
            /*0x78*/ string baseUri;

            static /*0x1fd92bc*/ byte[] ToBytes(byte[] buffer, int index, int count);
            /*0x1fd8640*/ XmlEventCache(string baseUri, bool hasRootNode);
            /*0x1fd8680*/ void EndEvents();
            /*0x1fd86e8*/ void EventsToWriter(System.Xml.XmlWriter writer);
            /*0x1fd8df0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1fd8e94*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1fd8f2c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1fd8f40*/ void WriteEndAttribute();
            /*0x1fd8f48*/ void WriteCData(string text);
            /*0x1fd8fc0*/ void WriteComment(string text);
            /*0x1fd8fcc*/ void WriteProcessingInstruction(string name, string text);
            /*0x1fd9050*/ void WriteWhitespace(string ws);
            /*0x1fd905c*/ void WriteString(string text);
            /*0x1fd9080*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1fd90bc*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1fd90f8*/ void WriteRaw(string data);
            /*0x1fd9104*/ void WriteEntityRef(string name);
            /*0x1fd9110*/ void WriteCharEntity(char ch);
            /*0x1fd91ec*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1fd9284*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1fd9374*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1fd93ac*/ void Close();
            /*0x1fd93b4*/ void Flush();
            /*0x1fd93bc*/ void WriteValue(string value);
            /*0x1fd93cc*/ void Dispose(bool disposing);
            /*0x1fd944c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1fd94bc*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1fd94c8*/ void StartElementContent();
            /*0x1fd94d0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1fd94e4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1fd94f8*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x1fd9508*/ void WriteEndBase64();
            /*0x1fd8694*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType);
            /*0x1fd8f54*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
            /*0x1fd8fdc*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
            /*0x1fd8ea8*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
            /*0x1fd8e08*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
            /*0x1fd9180*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
            /*0x1fd9510*/ int NewEvent();

            enum XmlEventType
            {
                Unknown = 0,
                DocType = 1,
                StartElem = 2,
                StartAttr = 3,
                EndAttr = 4,
                CData = 5,
                Comment = 6,
                PI = 7,
                Whitespace = 8,
                String = 9,
                Raw = 10,
                EntRef = 11,
                CharEnt = 12,
                SurrCharEnt = 13,
                Base64 = 14,
                BinHex = 15,
                XmlDecl1 = 16,
                XmlDecl2 = 17,
                StartContent = 18,
                EndElem = 19,
                FullEndElem = 20,
                Nmsp = 21,
                EndBase64 = 22,
                Close = 23,
                Flush = 24,
                Dispose = 25,
            }

            struct XmlEvent
            {
                /*0x10*/ System.Xml.XmlEventCache.XmlEventType eventType;
                /*0x18*/ string s1;
                /*0x20*/ string s2;
                /*0x28*/ string s3;
                /*0x30*/ object o;

                /*0xac0f3c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType);
                /*0xac0f44*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
                /*0xac0f50*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
                /*0xac0f5c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
                /*0xac0f6c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
                /*0xac0f7c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
                /*0xac0f88*/ System.Xml.XmlEventCache.XmlEventType get_EventType();
                /*0xac0f90*/ string get_String1();
                /*0xac0f98*/ string get_String2();
                /*0xac0fa0*/ string get_String3();
                /*0xac0fa8*/ object get_Object();
            }
        }

        class XmlParserContext
        {
            /*0x10*/ System.Xml.XmlNameTable _nt;
            /*0x18*/ System.Xml.XmlNamespaceManager _nsMgr;
            /*0x20*/ string _docTypeName;
            /*0x28*/ string _pubId;
            /*0x30*/ string _sysId;
            /*0x38*/ string _internalSubset;
            /*0x40*/ string _xmlLang;
            /*0x48*/ System.Xml.XmlSpace _xmlSpace;
            /*0x50*/ string _baseURI;
            /*0x58*/ System.Text.Encoding _encoding;

            /*0x1b5bb18*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x1b5bbbc*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x1b5bbec*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc);
            /*0x1b5bdd8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1b5bde0*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x1b5bde8*/ string get_DocTypeName();
            /*0x1b5bdf0*/ string get_PublicId();
            /*0x1b5bdf8*/ string get_SystemId();
            /*0x1b5be00*/ string get_BaseURI();
            /*0x1b5be08*/ string get_InternalSubset();
            /*0x1b5be10*/ string get_XmlLang();
            /*0x1b5be18*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1b5be20*/ System.Text.Encoding get_Encoding();
            /*0x1b5be28*/ bool get_HasDtdInfo();
        }

        class XmlRawWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlRawWriterBase64Encoder base64Encoder;
            /*0x20*/ System.Xml.IXmlNamespaceResolver resolver;

            /*0x1b5d2bc*/ XmlRawWriter();
            /*0x1b5cbd0*/ void WriteStartDocument();
            /*0x1b5cc2c*/ void WriteStartDocument(bool standalone);
            /*0x1b5cc88*/ void WriteEndDocument();
            /*0x1b5cce4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1b5cce8*/ void WriteEndElement();
            /*0x1b5cd44*/ void WriteFullEndElement();
            /*0x1b5cda0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1b5ce6c*/ string LookupPrefix(string ns);
            /*0x1b5cec8*/ System.Xml.WriteState get_WriteState();
            /*0x1b5cf24*/ void WriteCData(string text);
            /*0x1b5cf34*/ void WriteCharEntity(char ch);
            /*0x1b5cfd4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1b5d084*/ void WriteWhitespace(string ws);
            /*0x1b5d094*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1b5d0d0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1b5d10c*/ void WriteRaw(string data);
            /*0x1b5d11c*/ void WriteValue(string value);
            /*0x1b5d12c*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x1b5d188*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x1b5d1e4*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x1b5d1ec*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1b5d1f0*/ void WriteXmlDeclaration(string xmldecl);
            void StartElementContent();
            /*0x1b5d1f4*/ void OnRootElement(System.Xml.ConformanceLevel conformanceLevel);
            void WriteEndElement(string prefix, string localName, string ns);
            /*0x1b5d1f8*/ void WriteFullEndElement(string prefix, string localName, string ns);
            void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x1b5d208*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1b5d210*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x1b5d250*/ void WriteEndNamespaceDeclaration();
            /*0x1b5d290*/ void WriteEndBase64();
            /*0x1b5d2ac*/ void Close(System.Xml.WriteState currentState);
        }

        class XmlReader : System.IDisposable
        {
            static /*0x0*/ uint IsTextualNodeBitmap;
            static /*0x4*/ uint CanReadContentAsBitmap;
            static /*0x8*/ uint HasValueBitmap;

            static /*0x1b5f220*/ XmlReader();
            static /*0x1b5d75c*/ bool IsTextualNode(System.Xml.XmlNodeType nodeType);
            static /*0x1b5e7f4*/ bool HasValueInternal(System.Xml.XmlNodeType nodeType);
            static /*0x1b5e964*/ System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x1b5ebd4*/ System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x1b5ed8c*/ System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext);
            static /*0x1b5f0b0*/ int CalcBufferSize(System.IO.Stream input);
            /*0x1b5108c*/ XmlReader();
            /*0x1b5d2e8*/ System.Xml.XmlReaderSettings get_Settings();
            System.Xml.XmlNodeType get_NodeType();
            /*0x1b5d2f0*/ string get_Name();
            string get_LocalName();
            string get_NamespaceURI();
            string get_Prefix();
            string get_Value();
            int get_Depth();
            string get_BaseURI();
            bool get_IsEmptyElement();
            /*0x1b5d3d8*/ bool get_IsDefault();
            /*0x1b5d3e0*/ char get_QuoteChar();
            /*0x1b5d3e8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1b5d3f0*/ string get_XmlLang();
            /*0x1b5d43c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1b5d488*/ System.Type get_ValueType();
            int get_AttributeCount();
            string GetAttribute(string name);
            string GetAttribute(string name, string namespaceURI);
            string GetAttribute(int i);
            bool MoveToAttribute(string name);
            /*0x1b5d500*/ void MoveToAttribute(int i);
            bool MoveToFirstAttribute();
            bool MoveToNextAttribute();
            bool MoveToElement();
            bool ReadAttributeValue();
            bool Read();
            bool get_EOF();
            /*0x1b5d5d0*/ void Close();
            System.Xml.ReadState get_ReadState();
            /*0x1b5d5d4*/ void Skip();
            System.Xml.XmlNameTable get_NameTable();
            string LookupNamespace(string prefix);
            /*0x1b5d6f0*/ bool get_CanResolveEntity();
            void ResolveEntity();
            /*0x1b5d6f8*/ bool get_CanReadValueChunk();
            /*0x1b5d700*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x1b539a0*/ string ReadString();
            /*0x1b5d7d8*/ System.Xml.XmlNodeType MoveToContent();
            /*0x1b5d868*/ void ReadStartElement();
            /*0x1b5d980*/ string ReadElementString();
            /*0x1b5dc6c*/ void ReadEndElement();
            /*0x1b5dd84*/ bool IsStartElement(string localname, string ns);
            /*0x1b5de18*/ string ReadInnerXml();
            /*0x1b5e214*/ void WriteNode(System.Xml.XmlWriter xtw, bool defattr);
            /*0x1b5e134*/ void WriteAttributeValue(System.Xml.XmlWriter xtw);
            /*0x1b5e0bc*/ System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw);
            /*0x1b5e65c*/ void SetNamespacesFlag(System.Xml.XmlTextWriter xtw);
            /*0x1b5e75c*/ bool get_HasAttributes();
            /*0x1b5e784*/ void Dispose();
            /*0x1b5e798*/ void Dispose(bool disposing);
            /*0x1b5e7ec*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x1b5d618*/ bool SkipSubtree();
            /*0x1b5e870*/ bool get_IsDefaultInternal();
            /*0x1b5e95c*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlReaderSettings
        {
            static /*0x0*/ System.Nullable<bool> s_enableLegacyXmlSettings;
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Xml.XmlNameTable nameTable;
            /*0x20*/ System.Xml.XmlResolver xmlResolver;
            /*0x28*/ int lineNumberOffset;
            /*0x2c*/ int linePositionOffset;
            /*0x30*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0x34*/ bool checkCharacters;
            /*0x38*/ long maxCharactersInDocument;
            /*0x40*/ long maxCharactersFromEntities;
            /*0x48*/ bool ignoreWhitespace;
            /*0x49*/ bool ignorePIs;
            /*0x4a*/ bool ignoreComments;
            /*0x4c*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x50*/ System.Xml.ValidationType validationType;
            /*0x54*/ System.Xml.Schema.XmlSchemaValidationFlags validationFlags;
            /*0x58*/ System.Xml.Schema.XmlSchemaSet schemas;
            /*0x60*/ System.Xml.Schema.ValidationEventHandler valEventHandler;
            /*0x68*/ bool closeInput;
            /*0x69*/ bool isReadOnly;
            /*0x6a*/ bool <IsXmlResolverSet>k__BackingField;

            static /*0x1b5fe04*/ System.Xml.XmlResolver CreateDefaultResolver();
            static /*0x1b5fe5c*/ bool EnableLegacyXmlSettings();
            /*0x1b5e9f8*/ XmlReaderSettings();
            /*0x1b5f308*/ bool get_Async();
            /*0x1b5f310*/ void set_Async(bool value);
            /*0x1b5f424*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1b5f42c*/ void set_NameTable(System.Xml.XmlNameTable value);
            /*0x1b5f48c*/ bool get_IsXmlResolverSet();
            /*0x1b5f494*/ void set_IsXmlResolverSet(bool value);
            /*0x1b5f4a0*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x1b5f508*/ System.Xml.XmlResolver GetXmlResolver();
            /*0x1b5f510*/ System.Xml.XmlResolver GetXmlResolver_CheckConfig();
            /*0x1b5f518*/ int get_LineNumberOffset();
            /*0x1b5f520*/ void set_LineNumberOffset(int value);
            /*0x1b5f580*/ int get_LinePositionOffset();
            /*0x1b5f588*/ void set_LinePositionOffset(int value);
            /*0x1b5f5e8*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x1b5f5f0*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x1b5f6a0*/ bool get_CheckCharacters();
            /*0x1b5f6a8*/ void set_CheckCharacters(bool value);
            /*0x1b5f70c*/ long get_MaxCharactersInDocument();
            /*0x1b5f714*/ void set_MaxCharactersInDocument(long value);
            /*0x1b5f7c0*/ long get_MaxCharactersFromEntities();
            /*0x1b5f7c8*/ void set_MaxCharactersFromEntities(long value);
            /*0x1b5f874*/ bool get_IgnoreWhitespace();
            /*0x1b5f87c*/ void set_IgnoreWhitespace(bool value);
            /*0x1b5f8e0*/ bool get_IgnoreProcessingInstructions();
            /*0x1b5f8e8*/ void set_IgnoreProcessingInstructions(bool value);
            /*0x1b5f94c*/ bool get_IgnoreComments();
            /*0x1b5f954*/ void set_IgnoreComments(bool value);
            /*0x1b5f9b8*/ System.Xml.DtdProcessing get_DtdProcessing();
            /*0x1b5f9c0*/ void set_DtdProcessing(System.Xml.DtdProcessing value);
            /*0x1b5fa70*/ bool get_CloseInput();
            /*0x1b5fa78*/ void set_CloseInput(bool value);
            /*0x1b5fadc*/ System.Xml.ValidationType get_ValidationType();
            /*0x1b5fae4*/ void set_ValidationType(System.Xml.ValidationType value);
            /*0x1b5fb94*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
            /*0x1b5fb9c*/ void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value);
            /*0x1b5fc4c*/ System.Xml.Schema.XmlSchemaSet get_Schemas();
            /*0x1b5fcb4*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x1b5fd14*/ System.Xml.XmlReaderSettings Clone();
            /*0x1b5fd80*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
            /*0x1b5ea24*/ System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x1b5ec64*/ System.Xml.XmlReader CreateReader(System.IO.TextReader input, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x1b5fd88*/ void set_ReadOnly(bool value);
            /*0x1b5f374*/ void CheckReadOnly(string propertyName);
            /*0x1b5f300*/ void Initialize();
            /*0x1b5fd94*/ void Initialize(System.Xml.XmlResolver resolver);
            /*0x1b5f138*/ System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader);
            /*0x1b5ffd8*/ System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader);
        }

        enum XmlSpace
        {
            None = 0,
            Default = 1,
            Preserve = 2,
        }

        class XmlTextEncoder
        {
            /*0x10*/ System.IO.TextWriter textWriter;
            /*0x18*/ bool inAttribute;
            /*0x1a*/ char quoteChar;
            /*0x20*/ System.Text.StringBuilder attrValue;
            /*0x28*/ bool cacheAttrValue;
            /*0x30*/ System.Xml.XmlCharType xmlCharType;

            /*0x2399804*/ XmlTextEncoder(System.IO.TextWriter textWriter);
            /*0x2399844*/ void set_QuoteChar(char value);
            /*0x239984c*/ void StartAttribute(bool cacheAttrValue);
            /*0x23998e8*/ void EndAttribute();
            /*0x239992c*/ string get_AttributeValue();
            /*0x23999a4*/ void WriteSurrogateChar(char lowChar, char highChar);
            /*0x2399a8c*/ void Write(char[] array, int offset, int count);
            /*0x2399fc8*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x239a184*/ void Write(string text);
            /*0x239a6d8*/ void WriteRawWithSurrogateChecking(string text);
            /*0x239a924*/ void WriteRaw(char[] array, int offset, int count);
            /*0x239aa54*/ void WriteCharEntity(char ch);
            /*0x239ac3c*/ void WriteEntityRef(string name);
            /*0x239a624*/ void WriteStringFragment(string str, int offset, int count, char[] helperBuffer);
            /*0x2399ed4*/ void WriteCharEntityImpl(char ch);
            /*0x239ab98*/ void WriteCharEntityImpl(string strVal);
            /*0x2399f54*/ void WriteEntityRefImpl(string name);
        }

        class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlTextReaderImpl impl;

            /*0x239acac*/ XmlTextReader(System.IO.Stream input);
            /*0x239adec*/ XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x239af84*/ XmlTextReader(System.IO.TextReader input);
            /*0x239b0c4*/ XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x239b1e4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x239b204*/ string get_Name();
            /*0x239b224*/ string get_LocalName();
            /*0x239b244*/ string get_NamespaceURI();
            /*0x239b264*/ string get_Prefix();
            /*0x239b284*/ string get_Value();
            /*0x239b2a4*/ int get_Depth();
            /*0x239b2c4*/ string get_BaseURI();
            /*0x239b2e8*/ bool get_IsEmptyElement();
            /*0x239b30c*/ bool get_IsDefault();
            /*0x239b330*/ char get_QuoteChar();
            /*0x239b354*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x239b378*/ string get_XmlLang();
            /*0x239b39c*/ int get_AttributeCount();
            /*0x239b3c0*/ string GetAttribute(string name);
            /*0x239b3e4*/ string GetAttribute(string localName, string namespaceURI);
            /*0x239b408*/ string GetAttribute(int i);
            /*0x239b42c*/ bool MoveToAttribute(string name);
            /*0x239b450*/ void MoveToAttribute(int i);
            /*0x239b474*/ bool MoveToFirstAttribute();
            /*0x239b498*/ bool MoveToNextAttribute();
            /*0x239b4bc*/ bool MoveToElement();
            /*0x239b4e0*/ bool ReadAttributeValue();
            /*0x239b504*/ bool Read();
            /*0x239b528*/ bool get_EOF();
            /*0x239b54c*/ void Close();
            /*0x239b570*/ System.Xml.ReadState get_ReadState();
            /*0x239b594*/ void Skip();
            /*0x239b5b8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x239b5dc*/ string LookupNamespace(string prefix);
            /*0x239b618*/ bool get_CanResolveEntity();
            /*0x239b620*/ void ResolveEntity();
            /*0x239b644*/ bool get_CanReadValueChunk();
            /*0x239b64c*/ string ReadString();
            /*0x239b734*/ bool HasLineInfo();
            /*0x239b73c*/ int get_LineNumber();
            /*0x239b780*/ int get_LinePosition();
            /*0x239b7c4*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x239b818*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x239b83c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x239b890*/ bool get_Namespaces();
            /*0x239b8ac*/ bool get_Normalization();
            /*0x239b8c8*/ void set_Normalization(bool value);
            /*0x239ba14*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x239baf8*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x239bb90*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x239bc14*/ System.Xml.XmlTextReaderImpl get_Impl();
            /*0x239bc1c*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x239bc40*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x239bd38*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlTextReaderImpl : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Xml.XmlTextReaderImpl.LaterInitParam laterInitParam;
            /*0x20*/ System.Xml.XmlCharType xmlCharType;
            /*0x28*/ System.Xml.XmlTextReaderImpl.ParsingState ps;
            /*0xa0*/ System.Xml.XmlTextReaderImpl.ParsingFunction parsingFunction;
            /*0xa4*/ System.Xml.XmlTextReaderImpl.ParsingFunction nextParsingFunction;
            /*0xa8*/ System.Xml.XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;
            /*0xb0*/ System.Xml.XmlTextReaderImpl.NodeData[] nodes;
            /*0xb8*/ System.Xml.XmlTextReaderImpl.NodeData curNode;
            /*0xc0*/ int index;
            /*0xc4*/ int curAttrIndex;
            /*0xc8*/ int attrCount;
            /*0xcc*/ int attrHashtable;
            /*0xd0*/ int attrDuplWalkCount;
            /*0xd4*/ bool attrNeedNamespaceLookup;
            /*0xd5*/ bool fullAttrCleanup;
            /*0xd8*/ System.Xml.XmlTextReaderImpl.NodeData[] attrDuplSortingArray;
            /*0xe0*/ System.Xml.XmlNameTable nameTable;
            /*0xe8*/ bool nameTableFromSettings;
            /*0xf0*/ System.Xml.XmlResolver xmlResolver;
            /*0xf8*/ string url;
            /*0x100*/ bool normalize;
            /*0x101*/ bool supportNamespaces;
            /*0x104*/ System.Xml.WhitespaceHandling whitespaceHandling;
            /*0x108*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x10c*/ System.Xml.EntityHandling entityHandling;
            /*0x110*/ bool ignorePIs;
            /*0x111*/ bool ignoreComments;
            /*0x112*/ bool checkCharacters;
            /*0x114*/ int lineNumberOffset;
            /*0x118*/ int linePositionOffset;
            /*0x11c*/ bool closeInput;
            /*0x120*/ long maxCharactersInDocument;
            /*0x128*/ long maxCharactersFromEntities;
            /*0x130*/ bool v1Compat;
            /*0x138*/ System.Xml.XmlNamespaceManager namespaceManager;
            /*0x140*/ string lastPrefix;
            /*0x148*/ System.Xml.XmlTextReaderImpl.XmlContext xmlContext;
            /*0x150*/ System.Xml.XmlTextReaderImpl.ParsingState[] parsingStatesStack;
            /*0x158*/ int parsingStatesStackTop;
            /*0x160*/ string reportedBaseUri;
            /*0x168*/ System.Text.Encoding reportedEncoding;
            /*0x170*/ System.Xml.IDtdInfo dtdInfo;
            /*0x178*/ System.Xml.XmlNodeType fragmentType;
            /*0x180*/ System.Xml.XmlParserContext fragmentParserContext;
            /*0x188*/ bool fragment;
            /*0x190*/ System.Xml.IncrementalReadDecoder incReadDecoder;
            /*0x198*/ System.Xml.XmlTextReaderImpl.IncrementalReadState incReadState;
            /*0x19c*/ System.Xml.LineInfo incReadLineInfo;
            /*0x1a4*/ int incReadDepth;
            /*0x1a8*/ int incReadLeftStartPos;
            /*0x1ac*/ int incReadLeftEndPos;
            /*0x1b0*/ int attributeValueBaseEntityId;
            /*0x1b4*/ bool emptyEntityInAttributeResolved;
            /*0x1b8*/ System.Xml.IValidationEventHandling validationEventHandling;
            /*0x1c0*/ System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;
            /*0x1c8*/ bool validatingReaderCompatFlag;
            /*0x1c9*/ bool addDefaultAttributesAndNormalize;
            /*0x1d0*/ System.Text.StringBuilder stringBuilder;
            /*0x1d8*/ bool rootElementParsed;
            /*0x1d9*/ bool standalone;
            /*0x1dc*/ int nextEntityId;
            /*0x1e0*/ System.Xml.XmlTextReaderImpl.ParsingMode parsingMode;
            /*0x1e4*/ System.Xml.ReadState readState;
            /*0x1e8*/ System.Xml.IDtdEntityInfo lastEntity;
            /*0x1f0*/ bool afterResetState;
            /*0x1f4*/ int documentStartBytePos;
            /*0x1f8*/ int readValueOffset;
            /*0x200*/ long charactersInDocument;
            /*0x208*/ long charactersFromEntities;
            /*0x210*/ System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo, System.Xml.IDtdEntityInfo> currentEntities;
            /*0x218*/ bool disableUndeclaredEntityCheck;
            /*0x220*/ System.Xml.XmlReader outerReader;
            /*0x228*/ bool xmlResolverIsSet;
            /*0x230*/ string Xml;
            /*0x238*/ string XmlNs;
            /*0x240*/ System.Threading.Tasks.Task<System.Tuple<int, int, int, bool>> parseText_dummyTask;

            static /*0x23aed08*/ string StripSpaces(string value);
            static /*0x23aef2c*/ void StripSpaces(char[] value, int index, ref int len);
            static /*0x23a273c*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x23a63d8*/ void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            /*0x239bd5c*/ XmlTextReaderImpl(System.Xml.XmlNameTable nt);
            /*0x239c0dc*/ XmlTextReaderImpl(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context);
            /*0x239ad58*/ XmlTextReaderImpl(System.IO.Stream input);
            /*0x239aeb0*/ XmlTextReaderImpl(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x239b030*/ XmlTextReaderImpl(System.IO.TextReader input);
            /*0x239b178*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x239c830*/ XmlTextReaderImpl(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x239c908*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context);
            /*0x239cd30*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context);
            /*0x239d488*/ XmlTextReaderImpl(System.IO.Stream stream, byte[] bytes, int byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, string baseUriStr, System.Xml.XmlParserContext context, bool closeInput);
            /*0x239d80c*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUriStr, System.Xml.XmlParserContext context);
            /*0x239d984*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x239ce5c*/ void FinishInitUriString();
            /*0x239d780*/ void FinishInitStream();
            /*0x239d914*/ void FinishInitTextReader();
            /*0x239da2c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x239dba8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x239dbc4*/ string get_Name();
            /*0x239dbe8*/ string get_LocalName();
            /*0x239dc04*/ string get_NamespaceURI();
            /*0x239dc20*/ string get_Prefix();
            /*0x239dc3c*/ string get_Value();
            /*0x239de6c*/ int get_Depth();
            /*0x239de88*/ string get_BaseURI();
            /*0x239de90*/ bool get_IsEmptyElement();
            /*0x239deac*/ bool get_IsDefault();
            /*0x239dec8*/ char get_QuoteChar();
            /*0x239def8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x239df14*/ string get_XmlLang();
            /*0x239df30*/ System.Xml.ReadState get_ReadState();
            /*0x239df38*/ bool get_EOF();
            /*0x239df48*/ System.Xml.XmlNameTable get_NameTable();
            /*0x239df50*/ bool get_CanResolveEntity();
            /*0x239df58*/ int get_AttributeCount();
            /*0x239df60*/ string GetAttribute(string name);
            /*0x239e1bc*/ string GetAttribute(string localName, string namespaceURI);
            /*0x239e358*/ string GetAttribute(int i);
            /*0x239e408*/ bool MoveToAttribute(string name);
            /*0x239e5a8*/ void MoveToAttribute(int i);
            /*0x239e67c*/ bool MoveToFirstAttribute();
            /*0x239e704*/ bool MoveToNextAttribute();
            /*0x239e7a0*/ bool MoveToElement();
            /*0x239e83c*/ void FinishInit();
            /*0x239e878*/ bool Read();
            /*0x23a0ae0*/ void Close();
            /*0x23a0bac*/ void Skip();
            /*0x23a0d34*/ string LookupNamespace(string prefix);
            /*0x23a0d68*/ bool ReadAttributeValue();
            /*0x23a146c*/ void ResolveEntity();
            /*0x23a1b9c*/ void set_OuterReader(System.Xml.XmlReader value);
            /*0x239b680*/ void MoveOffEntityReference();
            /*0x23a1ba4*/ string ReadString();
            /*0x23a1bcc*/ bool get_CanReadValueChunk();
            /*0x23a1bd4*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x23a2750*/ bool HasLineInfo();
            /*0x239b764*/ int get_LineNumber();
            /*0x239b7a8*/ int get_LinePosition();
            /*0x23a2758*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x23a277c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x23a278c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x239b7f4*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x239b86c*/ string LookupPrefix(string namespaceName);
            /*0x23a27b0*/ bool get_Namespaces();
            /*0x23a27b8*/ void set_Namespaces(bool value);
            /*0x23a2984*/ bool get_Normalization();
            /*0x239b8e4*/ void set_Normalization(bool value);
            /*0x239ba2c*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x239bb10*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x23a298c*/ bool get_IsResolverSet();
            /*0x239bba8*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x23a2994*/ System.Xml.XmlNameTable get_DtdParserProxy_NameTable();
            /*0x23a299c*/ System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver();
            /*0x23a29a4*/ bool get_DtdParserProxy_DtdValidation();
            /*0x23a29c4*/ bool get_DtdParserProxy_Normalization();
            /*0x23a29cc*/ bool get_DtdParserProxy_Namespaces();
            /*0x23a29d4*/ bool get_DtdParserProxy_V1CompatibilityMode();
            /*0x23a29dc*/ System.Uri get_DtdParserProxy_BaseUri();
            /*0x23a2a8c*/ bool get_DtdParserProxy_IsEof();
            /*0x23a2a94*/ char[] get_DtdParserProxy_ParsingBuffer();
            /*0x23a2a9c*/ int get_DtdParserProxy_ParsingBufferLength();
            /*0x23a2aa4*/ int get_DtdParserProxy_CurrentPosition();
            /*0x23a2aac*/ void set_DtdParserProxy_CurrentPosition(int value);
            /*0x23a2ab4*/ int get_DtdParserProxy_EntityStackLength();
            /*0x23a2ac0*/ bool get_DtdParserProxy_IsEntityEolNormalized();
            /*0x23a2ac8*/ System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling();
            /*0x23a2ad0*/ void DtdParserProxy_OnNewLine(int pos);
            /*0x23a2af8*/ int get_DtdParserProxy_LineNo();
            /*0x23a2b00*/ int get_DtdParserProxy_LineStartPosition();
            /*0x23a2b08*/ int DtdParserProxy_ReadData();
            /*0x23a2f50*/ int DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            /*0x23a302c*/ int DtdParserProxy_ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x23a30a4*/ void DtdParserProxy_ParsePI(System.Text.StringBuilder sb);
            /*0x23a3484*/ void DtdParserProxy_ParseComment(System.Text.StringBuilder sb);
            /*0x23a382c*/ bool get_IsResolverNull();
            /*0x23a3878*/ System.Xml.XmlResolver GetTempResolver();
            /*0x23a38dc*/ bool DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x23a4124*/ bool DtdParserProxy_PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x23a41cc*/ bool DtdParserProxy_PushExternalSubset(string systemId, string publicId);
            /*0x23a492c*/ void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd);
            /*0x23a4bcc*/ void DtdParserProxy_Throw(System.Exception e);
            /*0x23a4c6c*/ void DtdParserProxy_OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            /*0x23a4d84*/ void DtdParserProxy_OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x23a4e14*/ void Throw(int pos, string res, string arg);
            /*0x23a4ec8*/ void Throw(int pos, string res, string[] args);
            /*0x23a4f7c*/ void Throw(int pos, string res);
            /*0x239d728*/ void Throw(string res);
            /*0x23a4fdc*/ void Throw(string res, int lineNo, int linePos);
            /*0x23a4e2c*/ void Throw(string res, string arg);
            /*0x23a5084*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x23a4ee0*/ void Throw(string res, string[] args);
            /*0x23a5110*/ void Throw(string res, string arg, System.Exception innerException);
            /*0x23a51a0*/ void Throw(string res, string[] args, System.Exception innerException);
            /*0x23a4bd8*/ void Throw(System.Exception e);
            /*0x23a5258*/ void ReThrow(System.Exception e, int lineNo, int linePos);
            /*0x23a089c*/ void ThrowWithoutLineInfo(string res);
            /*0x23a52fc*/ void ThrowWithoutLineInfo(string res, string arg);
            /*0x23a5374*/ void ThrowWithoutLineInfo(string res, string[] args, System.Exception innerException);
            /*0x23a53fc*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x23a5244*/ void SetErrorState();
            /*0x23a3784*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg, int lineNo, int linePos);
            /*0x23a5470*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception);
            /*0x239e4d4*/ bool get_InAttributeValueIterator();
            /*0x239e4f8*/ void FinishAttributeValueIterator();
            /*0x23a29b4*/ bool get_DtdValidation();
            /*0x239c79c*/ void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x239c814*/ void InitStreamInput(string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x23a5684*/ void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x23a56e8*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x239d188*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, byte[] bytes, int byteCount, System.Text.Encoding encoding);
            /*0x239c8fc*/ void InitTextReaderInput(string baseUriStr, System.IO.TextReader input);
            /*0x23a5a70*/ void InitTextReaderInput(string baseUriStr, System.Uri baseUri, System.IO.TextReader input);
            /*0x239ca24*/ void InitStringInput(string baseUriStr, System.Text.Encoding originalEncoding, string str);
            /*0x239cb04*/ void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, bool allowXmlDeclFragment);
            /*0x239d418*/ void ProcessDtdFromParserContext(System.Xml.XmlParserContext context);
            /*0x239f488*/ void OpenUrl();
            /*0x23a5d6c*/ void OpenUrlDelegate(object xmlResolver);
            /*0x23a56f8*/ System.Text.Encoding DetectEncoding();
            /*0x23a592c*/ void SetupEncoding(System.Text.Encoding encoding);
            /*0x23a5e78*/ void SwitchEncoding(System.Text.Encoding newEncoding);
            /*0x23a6028*/ System.Text.Encoding CheckEncoding(string newEncodingName);
            /*0x23a5f78*/ void UnDecodeChars();
            /*0x23a6370*/ void SwitchEncodingToUTF8();
            /*0x23a2b0c*/ int ReadData();
            /*0x23a63e0*/ int GetChars(int maxCharsCount);
            /*0x23a64fc*/ void InvalidCharRecovery(ref int bytesCount, ref int charsCount);
            /*0x23a0ae8*/ void Close(bool closeInput);
            /*0x23a6700*/ void ShiftBuffer(int sourcePos, int destPos, int count);
            /*0x239f638*/ bool ParseXmlDeclaration(bool isTextDecl);
            /*0x239ef78*/ bool ParseDocumentContent();
            /*0x239ec2c*/ bool ParseElementContent();
            /*0x23a7cf0*/ void ThrowUnclosedElements();
            /*0x23a6c08*/ void ParseElement();
            /*0x23a84e0*/ void AddDefaultAttributesAndNormalize();
            /*0x23a78f0*/ void ParseEndElement();
            /*0x23a9718*/ void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag);
            /*0x23a7ea0*/ void ParseAttributes();
            /*0x23a8f2c*/ void ElementNamespaceLookup();
            /*0x23a9660*/ void AttributeNamespaceLookup();
            /*0x23aa8b4*/ void AttributeDuplCheck();
            /*0x23aa4d0*/ void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x23aa5dc*/ void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x23aa6bc*/ void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x23a9b74*/ void ParseAttributeValueSlow(int curPos, char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x23aafe8*/ void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, ref System.Xml.XmlTextReaderImpl.NodeData lastChunk);
            /*0x23a736c*/ bool ParseText();
            /*0x23a2038*/ bool ParseText(ref int startPos, ref int endPos, ref int outOrChars);
            /*0x239dc90*/ void FinishPartialValue();
            /*0x239dd58*/ void FinishOtherValueIterator();
            /*0x23a0930*/ void SkipPartialTextValue();
            /*0x23a097c*/ void FinishReadValueChunk();
            /*0x23a099c*/ void FinishReadContentAsBinary();
            /*0x23a09f8*/ void FinishReadElementContentAsBinary();
            /*0x23a76e8*/ bool ParseRootLevelWhitespace();
            /*0x23a046c*/ void ParseEntityReference();
            /*0x23a70ac*/ System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, ref int charRefEndPos);
            /*0x23a16c0*/ System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos);
            /*0x23a6360*/ bool get_InEntity();
            /*0x23a5544*/ bool HandleEntityEnd(bool checkEntityNesting);
            /*0x23a04ec*/ void SetupEndEntityNodeInContent();
            /*0x23ab3b8*/ void SetupEndEntityNodeInAttribute();
            /*0x23a68e0*/ bool ParsePI();
            /*0x23a30ec*/ bool ParsePI(System.Text.StringBuilder piInDtdStringBuilder);
            /*0x23ab434*/ bool ParsePIValue(ref int outStartPos, ref int outEndPos);
            /*0x23a68e8*/ bool ParseComment();
            /*0x23a6950*/ void ParseCData();
            /*0x23a3628*/ void ParseCDataOrComment(System.Xml.XmlNodeType type);
            /*0x23ab7d0*/ bool ParseCDataOrComment(System.Xml.XmlNodeType type, ref int outStartPos, ref int outEndPos);
            /*0x23a6958*/ bool ParseDoctypeDecl();
            /*0x23abc14*/ void ParseDtd();
            /*0x23abf60*/ void SkipDtd();
            /*0x23ac2dc*/ void SkipPublicOrSystemIdLiteral();
            /*0x23ac3a0*/ void SkipUntil(char stopChar, bool recognizeLiterals);
            /*0x23a46d8*/ int EatWhitespaces(System.Text.StringBuilder sb);
            /*0x23ab1c0*/ int ParseCharRefInline(int startPos, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x23a2f7c*/ int ParseNumericCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x23ac80c*/ int ParseNumericCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x23a3034*/ int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x23ace78*/ int ParseNamedCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x23a6728*/ int ParseName();
            /*0x23a7e90*/ int ParseQName(ref int colonPos);
            /*0x23ad168*/ int ParseQName(bool isQName, int startOffset, ref int colonPos);
            /*0x23ad3e8*/ bool ReadDataInName(ref int pos);
            /*0x23ab018*/ string ParseEntityName();
            /*0x23a03c8*/ System.Xml.XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth);
            /*0x23ad434*/ System.Xml.XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth);
            /*0x23a4cfc*/ System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth);
            /*0x23a99bc*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos);
            /*0x23ad584*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix);
            /*0x23a0418*/ void PopElementContext();
            /*0x23a2ae4*/ void OnNewLine(int pos);
            /*0x23a0800*/ void OnEof();
            /*0x23aac38*/ string LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node);
            /*0x23aad80*/ void AddNamespace(string prefix, string uri, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x23a0390*/ void ResetAttributes();
            /*0x23ad6fc*/ void FullAttributeCleanup();
            /*0x23aad00*/ void PushXmlContext();
            /*0x23ad6cc*/ void PopXmlContext();
            /*0x23ab370*/ System.Xml.XmlNodeType GetWhitespaceType();
            /*0x23ab168*/ System.Xml.XmlNodeType GetTextNodeType(int orChars);
            /*0x23a4300*/ void PushExternalEntityOrSubset(string publicId, string systemId, System.Uri baseUri, string entityName);
            /*0x23ad778*/ bool OpenAndPush(System.Uri uri);
            /*0x23a39f4*/ bool PushExternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x23a3dc8*/ void PushInternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x23a4174*/ void PopEntity();
            /*0x23ad9c8*/ void RegisterEntity(System.Xml.IDtdEntityInfo entity);
            /*0x23adbbc*/ void UnregisterEntity();
            /*0x23a499c*/ void PushParsingState();
            /*0x23a6688*/ void PopParsingState();
            /*0x23adc24*/ int IncrementalRead();
            /*0x23a0640*/ void FinishIncrementalRead();
            /*0x23a06a8*/ bool ParseFragmentAttribute();
            /*0x23a0fc8*/ bool ParseAttributeValueChunk();
            /*0x23a0738*/ void ParseXmlDeclarationFragment();
            /*0x23a6940*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x23a6720*/ void ThrowUnexpectedToken(string expectedToken1);
            /*0x23a6bf8*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x23a6754*/ void ThrowUnexpectedToken(string expectedToken1, string expectedToken2);
            /*0x23a6bf0*/ string ParseUnexpectedToken(int pos);
            /*0x23ae574*/ string ParseUnexpectedToken();
            /*0x23a9934*/ void ThrowExpectingWhitespace(int pos);
            /*0x239e000*/ int GetIndexOfAttributeWithoutPrefix(string name);
            /*0x239e0f4*/ int GetIndexOfAttributeWithPrefix(string name);
            /*0x23ab238*/ bool ZeroEndingStream(int pos);
            /*0x23a5b2c*/ void ParseDtdFromParserContext();
            /*0x23ab2c8*/ bool MoveToNextContentNode(bool moveIfOnContentNode);
            /*0x239c564*/ void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x23ae654*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x23ae65c*/ void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo);
            /*0x23ae7ac*/ void set_ValidationEventHandling(System.Xml.IValidationEventHandling value);
            /*0x23ae7b4*/ void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value);
            /*0x239bc5c*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x23ae7bc*/ System.Xml.XmlNodeType get_FragmentType();
            /*0x23ae7c4*/ void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType);
            /*0x23ae7e0*/ System.Xml.XmlResolver GetResolver();
            /*0x23ae824*/ void set_InternalSchemaType(object value);
            /*0x23ae840*/ object get_InternalTypedValue();
            /*0x23ae85c*/ void set_InternalTypedValue(object value);
            /*0x23ae878*/ bool get_StandAlone();
            /*0x23ae880*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x23ae888*/ bool get_V1Compat();
            /*0x23a8f80*/ bool AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData);
            /*0x23aeae8*/ bool AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef);
            /*0x23ae890*/ System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute);
            /*0x23aecfc*/ void set_DisableUndeclaredEntityCheck(bool value);
            /*0x239d62c*/ bool UriEqual(System.Uri uri1, string uri1Str, string uri2Str, System.Xml.XmlResolver resolver);
            /*0x23a4ae0*/ void RegisterConsumedCharacters(long characters, bool inEntityReference);

            enum ParsingFunction
            {
                ElementContent = 0,
                NoData = 1,
                OpenUrl = 2,
                SwitchToInteractive = 3,
                SwitchToInteractiveXmlDecl = 4,
                DocumentContent = 5,
                MoveToElementContent = 6,
                PopElementContext = 7,
                PopEmptyElementContext = 8,
                ResetAttributesRootLevel = 9,
                Error = 10,
                Eof = 11,
                ReaderClosed = 12,
                EntityReference = 13,
                InIncrementalRead = 14,
                FragmentAttribute = 15,
                ReportEndEntity = 16,
                AfterResolveEntityInContent = 17,
                AfterResolveEmptyEntityInContent = 18,
                XmlDeclarationFragment = 19,
                GoToEof = 20,
                PartialTextValue = 21,
                InReadAttributeValue = 22,
                InReadValueChunk = 23,
                InReadContentAsBinary = 24,
                InReadElementContentAsBinary = 25,
            }

            enum ParsingMode
            {
                Full = 0,
                SkipNode = 1,
                SkipContent = 2,
            }

            enum EntityType
            {
                CharacterDec = 0,
                CharacterHex = 1,
                CharacterNamed = 2,
                Expanded = 3,
                Skipped = 4,
                FakeExpanded = 5,
                Unexpanded = 6,
                ExpandedInAttribute = 7,
            }

            enum EntityExpandType
            {
                All = 0,
                OnlyGeneral = 1,
                OnlyCharacter = 2,
            }

            enum IncrementalReadState
            {
                Text = 0,
                StartTag = 1,
                PI = 2,
                CDATA = 3,
                Comment = 4,
                Attributes = 5,
                AttributeValue = 6,
                ReadData = 7,
                EndElement = 8,
                End = 9,
                ReadValueChunk_OnCachedValue = 10,
                ReadValueChunk_OnPartialValue = 11,
                ReadContentAsBinary_OnCachedValue = 12,
                ReadContentAsBinary_OnPartialValue = 13,
                ReadContentAsBinary_End = 14,
            }

            class LaterInitParam
            {
                /*0x10*/ bool useAsync;
                /*0x18*/ System.IO.Stream inputStream;
                /*0x20*/ byte[] inputBytes;
                /*0x28*/ int inputByteCount;
                /*0x30*/ System.Uri inputbaseUri;
                /*0x38*/ string inputUriStr;
                /*0x40*/ System.Xml.XmlResolver inputUriResolver;
                /*0x48*/ System.Xml.XmlParserContext inputContext;
                /*0x50*/ System.IO.TextReader inputTextReader;
                /*0x58*/ System.Xml.XmlTextReaderImpl.InitInputType initType;

                /*0x16c92a4*/ LaterInitParam();
            }

            enum InitInputType
            {
                UriString = 0,
                Stream = 1,
                TextReader = 2,
                Invalid = 3,
            }

            struct ParsingState
            {
                /*0x10*/ char[] chars;
                /*0x18*/ int charPos;
                /*0x1c*/ int charsUsed;
                /*0x20*/ System.Text.Encoding encoding;
                /*0x28*/ bool appendMode;
                /*0x30*/ System.IO.Stream stream;
                /*0x38*/ System.Text.Decoder decoder;
                /*0x40*/ byte[] bytes;
                /*0x48*/ int bytePos;
                /*0x4c*/ int bytesUsed;
                /*0x50*/ System.IO.TextReader textReader;
                /*0x58*/ int lineNo;
                /*0x5c*/ int lineStartPos;
                /*0x60*/ string baseUriStr;
                /*0x68*/ System.Uri baseUri;
                /*0x70*/ bool isEof;
                /*0x71*/ bool isStreamEof;
                /*0x78*/ System.Xml.IDtdEntityInfo entity;
                /*0x80*/ int entityId;
                /*0x84*/ bool eolNormalized;
                /*0x85*/ bool entityResolvedManually;

                /*0xac1744*/ void Clear();
                /*0xac174c*/ void Close(bool closeInput);
                /*0xac1758*/ int get_LineNo();
                /*0xac1760*/ int get_LinePos();
            }

            class XmlContext
            {
                /*0x10*/ System.Xml.XmlSpace xmlSpace;
                /*0x18*/ string xmlLang;
                /*0x20*/ string defaultNamespace;
                /*0x28*/ System.Xml.XmlTextReaderImpl.XmlContext previousContext;

                /*0x16c9fd0*/ XmlContext();
                /*0x16ca040*/ XmlContext(System.Xml.XmlTextReaderImpl.XmlContext previousContext);
            }

            class NoNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x16c92b4*/ NoNamespaceManager();
                /*0x16c92bc*/ string get_DefaultNamespace();
                /*0x16c9308*/ void PushScope();
                /*0x16c930c*/ bool PopScope();
                /*0x16c9314*/ void AddNamespace(string prefix, string uri);
                /*0x16c9318*/ void RemoveNamespace(string prefix, string uri);
                /*0x16c931c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x16c9324*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x16c932c*/ string LookupNamespace(string prefix);
                /*0x16c9378*/ string LookupPrefix(string uri);
            }

            class DtdParserProxy : System.Xml.IDtdParserAdapterV1, System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
            {
                /*0x10*/ System.Xml.XmlTextReaderImpl reader;

                /*0x16c8f2c*/ DtdParserProxy(System.Xml.XmlTextReaderImpl reader);
                /*0x16c8f58*/ System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable();
                /*0x16c8f74*/ System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver();
                /*0x16c8f90*/ System.Uri System.Xml.IDtdParserAdapter.get_BaseUri();
                /*0x16c8fac*/ bool System.Xml.IDtdParserAdapter.get_IsEof();
                /*0x16c8fc8*/ char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer();
                /*0x16c8fe4*/ int System.Xml.IDtdParserAdapter.get_ParsingBufferLength();
                /*0x16c9000*/ int System.Xml.IDtdParserAdapter.get_CurrentPosition();
                /*0x16c901c*/ void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value);
                /*0x16c9038*/ int System.Xml.IDtdParserAdapter.get_EntityStackLength();
                /*0x16c9054*/ bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized();
                /*0x16c9070*/ void System.Xml.IDtdParserAdapter.OnNewLine(int pos);
                /*0x16c908c*/ int System.Xml.IDtdParserAdapter.get_LineNo();
                /*0x16c90a8*/ int System.Xml.IDtdParserAdapter.get_LineStartPosition();
                /*0x16c90c4*/ int System.Xml.IDtdParserAdapter.ReadData();
                /*0x16c90e0*/ int System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
                /*0x16c90fc*/ int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
                /*0x16c911c*/ void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb);
                /*0x16c9138*/ void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb);
                /*0x16c9154*/ bool System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
                /*0x16c9170*/ bool System.Xml.IDtdParserAdapter.PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
                /*0x16c918c*/ bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId);
                /*0x16c91a8*/ void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd);
                /*0x16c91c4*/ void System.Xml.IDtdParserAdapter.Throw(System.Exception e);
                /*0x16c91e0*/ void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
                /*0x16c91fc*/ void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
                /*0x16c9218*/ bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation();
                /*0x16c9234*/ System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling();
                /*0x16c9250*/ bool System.Xml.IDtdParserAdapterV1.get_Normalization();
                /*0x16c926c*/ bool System.Xml.IDtdParserAdapterV1.get_Namespaces();
                /*0x16c9288*/ bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode();
            }

            class NodeData : System.IComparable
            {
                static /*0x0*/ System.Xml.XmlTextReaderImpl.NodeData s_None;
                /*0x10*/ System.Xml.XmlNodeType type;
                /*0x18*/ string localName;
                /*0x20*/ string prefix;
                /*0x28*/ string ns;
                /*0x30*/ string nameWPrefix;
                /*0x38*/ string value;
                /*0x40*/ char[] chars;
                /*0x48*/ int valueStartPos;
                /*0x4c*/ int valueLength;
                /*0x50*/ System.Xml.LineInfo lineInfo;
                /*0x58*/ System.Xml.LineInfo lineInfo2;
                /*0x60*/ char quoteChar;
                /*0x64*/ int depth;
                /*0x68*/ bool isEmptyOrDefault;
                /*0x6c*/ int entityId;
                /*0x70*/ bool xmlContextPushed;
                /*0x78*/ System.Xml.XmlTextReaderImpl.NodeData nextAttrValueChunk;
                /*0x80*/ object schemaType;
                /*0x88*/ object typedValue;

                static /*0x16c9380*/ System.Xml.XmlTextReaderImpl.NodeData get_None();
                /*0x16c941c*/ NodeData();
                /*0x16c94d4*/ int get_LineNo();
                /*0x16c94dc*/ int get_LinePos();
                /*0x16c94e4*/ bool get_IsEmptyElement();
                /*0x16c9508*/ void set_IsEmptyElement(bool value);
                /*0x16c9514*/ bool get_IsDefaultAttribute();
                /*0x16c9538*/ void set_IsDefaultAttribute(bool value);
                /*0x16c9544*/ bool get_ValueBuffered();
                /*0x16c9554*/ string get_StringValue();
                /*0x16c958c*/ void TrimSpacesInValue();
                /*0x16c9450*/ void Clear(System.Xml.XmlNodeType type);
                /*0x16c95d8*/ void ClearName();
                /*0x16c9650*/ void SetLineInfo(int lineNo, int linePos);
                /*0x16c965c*/ void SetLineInfo2(int lineNo, int linePos);
                /*0x16c9668*/ void SetValueNode(System.Xml.XmlNodeType type, string value);
                /*0x16c969c*/ void SetValueNode(System.Xml.XmlNodeType type, char[] chars, int startPos, int len);
                /*0x16c96dc*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName);
                /*0x16c974c*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName, string prefix, string nameWPrefix);
                /*0x16c97e0*/ void SetValue(string value);
                /*0x16c97f0*/ void SetValue(char[] chars, int startPos, int len);
                /*0x16c97fc*/ void OnBufferInvalidated();
                /*0x16c984c*/ void CopyTo(int valueOffset, System.Text.StringBuilder sb);
                /*0x16c98d0*/ int CopyTo(int valueOffset, char[] buffer, int offset, int length);
                /*0x16c993c*/ string GetNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x16c9950*/ string CreateNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x16c99e8*/ int System.IComparable.CompareTo(object obj);
            }

            class DtdDefaultAttributeInfoToNodeDataComparer : System.Collections.Generic.IComparer<object>
            {
                static /*0x0*/ System.Collections.Generic.IComparer<object> s_instance;

                static /*0x16c8ecc*/ DtdDefaultAttributeInfoToNodeDataComparer();
                static /*0x16c8afc*/ System.Collections.Generic.IComparer<object> get_Instance();
                /*0x16c8ec4*/ DtdDefaultAttributeInfoToNodeDataComparer();
                /*0x16c8b60*/ int Compare(object x, object y);
            }

            class OnDefaultAttributeUseDelegate : System.MulticastDelegate
            {
                /*0x16c9ad0*/ OnDefaultAttributeUseDelegate(object object, nint method);
                /*0x16c9b30*/ void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);
                /*0x16c9ec4*/ System.IAsyncResult BeginInvoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader, System.AsyncCallback callback, object object);
                /*0x16c9ef4*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        enum Formatting
        {
            None = 0,
            Indented = 1,
        }

        class XmlTextWriter : System.Xml.XmlWriter
        {
            static /*0x0*/ string[] stateName;
            static /*0x8*/ string[] tokenName;
            static /*0x10*/ System.Xml.XmlTextWriter.State[] stateTableDefault;
            static /*0x18*/ System.Xml.XmlTextWriter.State[] stateTableDocument;
            /*0x18*/ System.IO.TextWriter textWriter;
            /*0x20*/ System.Xml.XmlTextEncoder xmlEncoder;
            /*0x28*/ System.Text.Encoding encoding;
            /*0x30*/ System.Xml.Formatting formatting;
            /*0x34*/ bool indented;
            /*0x38*/ int indentation;
            /*0x3c*/ char indentChar;
            /*0x40*/ System.Xml.XmlTextWriter.TagInfo[] stack;
            /*0x48*/ int top;
            /*0x50*/ System.Xml.XmlTextWriter.State[] stateTable;
            /*0x58*/ System.Xml.XmlTextWriter.State currentState;
            /*0x5c*/ System.Xml.XmlTextWriter.Token lastToken;
            /*0x60*/ System.Xml.XmlTextWriterBase64Encoder base64Encoder;
            /*0x68*/ char quoteChar;
            /*0x6a*/ char curQuoteChar;
            /*0x6c*/ bool namespaces;
            /*0x70*/ System.Xml.XmlTextWriter.SpecialAttr specialAttr;
            /*0x78*/ string prefixForXmlNs;
            /*0x80*/ bool flush;
            /*0x88*/ System.Xml.XmlTextWriter.Namespace[] nsStack;
            /*0x90*/ int nsTop;
            /*0x98*/ System.Collections.Generic.Dictionary<string, int> nsHashtable;
            /*0xa0*/ bool useNsHashtable;
            /*0xa8*/ System.Xml.XmlCharType xmlCharType;

            static /*0x1bc980c*/ XmlTextWriter();
            /*0x1bc4b50*/ XmlTextWriter();
            /*0x1bc4c84*/ XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding);
            /*0x1bc4d54*/ XmlTextWriter(string filename, System.Text.Encoding encoding);
            /*0x1bc4dd8*/ XmlTextWriter(System.IO.TextWriter w);
            /*0x1bc4e78*/ System.IO.Stream get_BaseStream();
            /*0x1bc4f18*/ void set_Namespaces(bool value);
            /*0x1bc4f88*/ void set_Formatting(System.Xml.Formatting value);
            /*0x1bc4f9c*/ void set_QuoteChar(char value);
            /*0x1bc502c*/ void WriteStartDocument();
            /*0x1bc53c0*/ void WriteStartDocument(bool standalone);
            /*0x1bc53d8*/ void WriteEndDocument();
            /*0x1bc5614*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1bc616c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1bc6cbc*/ void WriteEndElement();
            /*0x1bc6fd4*/ void WriteFullEndElement();
            /*0x1bc6fdc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1bc78ec*/ void WriteEndAttribute();
            /*0x1bc79a0*/ void WriteCData(string text);
            /*0x1bc7b88*/ void WriteComment(string text);
            /*0x1bc7da4*/ void WriteProcessingInstruction(string name, string text);
            /*0x1bc80f8*/ void WriteEntityRef(string name);
            /*0x1bc81d8*/ void WriteCharEntity(char ch);
            /*0x1bc82ac*/ void WriteWhitespace(string ws);
            /*0x1bc8434*/ void WriteString(string text);
            /*0x1bc8514*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1bc85f8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1bc86e4*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1bc87d0*/ void WriteRaw(string data);
            /*0x1bc88a4*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1bc8a2c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1bc8b10*/ System.Xml.WriteState get_WriteState();
            /*0x1bc8b34*/ void Close();
            /*0x1bc8c6c*/ void Flush();
            /*0x1bc8c8c*/ string LookupPrefix(string ns);
            /*0x1bc5034*/ void StartDocument(int standalone);
            /*0x1bc5c00*/ void AutoComplete(System.Xml.XmlTextWriter.Token token);
            /*0x1bc55b4*/ void AutoCompleteAll();
            /*0x1bc6cc4*/ void InternalWriteEndElement(bool longFormat);
            /*0x1bc8ed4*/ void WriteEndStartTag(bool empty);
            /*0x1bc8e7c*/ void WriteEndAttributeQuote();
            /*0x1bc8da0*/ void Indent(bool beforeEndElement);
            /*0x1bc68f4*/ void PushNamespace(string prefix, string ns, bool declared);
            /*0x1bc9568*/ void AddNamespace(string prefix, string ns, bool declared);
            /*0x1bc9710*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x1bc9264*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x1bc77c4*/ string GeneratePrefix();
            /*0x1bc7ff8*/ void InternalWriteProcessingInstruction(string name, string text);
            /*0x1bc6724*/ int LookupNamespace(string prefix);
            /*0x1bc768c*/ int LookupNamespaceInCurrentScope(string prefix);
            /*0x1bc6820*/ string FindPrefix(string ns);
            /*0x1bc5a1c*/ void ValidateName(string name, bool isNCName);
            /*0x1bc9344*/ void HandleSpecialAttribute();
            /*0x1bc6b50*/ void VerifyPrefixXml(string prefix, string ns);
            /*0x1bc6648*/ void PushStack();
            /*0x1bc9234*/ void FlushEncoders();

            enum NamespaceState
            {
                Uninitialized = 0,
                NotDeclaredButInScope = 1,
                DeclaredButNotWrittenOut = 2,
                DeclaredAndWrittenOut = 3,
            }

            struct TagInfo
            {
                /*0x10*/ string name;
                /*0x18*/ string prefix;
                /*0x20*/ string defaultNs;
                /*0x28*/ System.Xml.XmlTextWriter.NamespaceState defaultNsState;
                /*0x2c*/ System.Xml.XmlSpace xmlSpace;
                /*0x30*/ string xmlLang;
                /*0x38*/ int prevNsTop;
                /*0x3c*/ int prefixCount;
                /*0x40*/ bool mixed;

                /*0xac1998*/ void Init(int nsTop);
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ bool declared;
                /*0x24*/ int prevNsIndex;

                /*0xac183c*/ void Set(string prefix, string ns, bool declared);
            }

            enum SpecialAttr
            {
                None = 0,
                XmlSpace = 1,
                XmlLang = 2,
                XmlNs = 3,
            }

            enum State
            {
                Start = 0,
                Prolog = 1,
                PostDTD = 2,
                Element = 3,
                Attribute = 4,
                Content = 5,
                AttrOnly = 6,
                Epilog = 7,
                Error = 8,
                Closed = 9,
            }

            enum Token
            {
                PI = 0,
                Doctype = 1,
                Comment = 2,
                CData = 3,
                StartElement = 4,
                EndElement = 5,
                LongEndElement = 6,
                StartAttribute = 7,
                EndAttribute = 8,
                Content = 9,
                Base64 = 10,
                RawData = 11,
                Whitespace = 12,
                Empty = 13,
            }
        }

        class XmlUtf8RawTextWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ bool useAsync;
            /*0x30*/ byte[] bufBytes;
            /*0x38*/ System.IO.Stream stream;
            /*0x40*/ System.Text.Encoding encoding;
            /*0x48*/ System.Xml.XmlCharType xmlCharType;
            /*0x50*/ int bufPos;
            /*0x54*/ int textPos;
            /*0x58*/ int contentPos;
            /*0x5c*/ int cdataPos;
            /*0x60*/ int attrEndPos;
            /*0x64*/ int bufLen;
            /*0x68*/ bool writeToNull;
            /*0x69*/ bool hadDoubleBracket;
            /*0x6a*/ bool inAttributeValue;
            /*0x6c*/ System.Xml.NewLineHandling newLineHandling;
            /*0x70*/ bool closeOutput;
            /*0x71*/ bool omitXmlDeclaration;
            /*0x78*/ string newLineChars;
            /*0x80*/ bool checkCharacters;
            /*0x84*/ System.Xml.XmlStandalone standalone;
            /*0x88*/ System.Xml.XmlOutputMethod outputMethod;
            /*0x8c*/ bool autoXmlDeclaration;
            /*0x8d*/ bool mergeCDataSections;

            static /*0x1bd749c*/ bool IsSurrogateByte(byte b);
            static /*0x1bd756c*/ byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst);
            static /*0x1bd7830*/ byte* EncodeMultibyteUTF8(int ch, byte* pDst);
            static /*0x1bd7c38*/ void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            static /*0x1bd74cc*/ byte* LtEntity(byte* pDst);
            static /*0x1bd74dc*/ byte* GtEntity(byte* pDst);
            static /*0x1bd74ac*/ byte* AmpEntity(byte* pDst);
            static /*0x1bd74ec*/ byte* QuoteEntity(byte* pDst);
            static /*0x1bd750c*/ byte* TabEntity(byte* pDst);
            static /*0x1bd754c*/ byte* LineFeedEntity(byte* pDst);
            static /*0x1bd752c*/ byte* CarriageReturnEntity(byte* pDst);
            static /*0x1bd7a9c*/ byte* CharEntity(byte* pDst, char ch);
            static /*0x1bd7a74*/ byte* RawStartCData(byte* pDst);
            static /*0x1bd7a58*/ byte* RawEndCData(byte* pDst);
            /*0x1bd4678*/ XmlUtf8RawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x1bd4af0*/ XmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1bd4c40*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1bd4de4*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1bd4e6c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1bd5068*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1bd5118*/ void StartElementContent();
            /*0x1bd516c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1bd52d0*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1bd53d0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1bd54e8*/ void WriteEndAttribute();
            /*0x1bd5540*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x1bd5598*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x1bd55a0*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x1bd56a8*/ void WriteEndNamespaceDeclaration();
            /*0x1bd5700*/ void WriteCData(string text);
            /*0x1bd5cac*/ void WriteComment(string text);
            /*0x1bd6158*/ void WriteProcessingInstruction(string name, string text);
            /*0x1bd628c*/ void WriteEntityRef(string name);
            /*0x1bd6340*/ void WriteCharEntity(char ch);
            /*0x1bd6540*/ void WriteWhitespace(string ws);
            /*0x1bd6b60*/ void WriteString(string text);
            /*0x1bd6bb4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1bd6d14*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1bd6d60*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1bd700c*/ void WriteRaw(string data);
            /*0x1bd7058*/ void Close();
            /*0x1bd71f0*/ void Flush();
            /*0x1bd723c*/ void FlushBuffer();
            /*0x1bd71ec*/ void FlushEncoder();
            /*0x1bd6594*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1bd6894*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1bd4da4*/ void RawText(string s);
            /*0x1bd78c8*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x1bd6db4*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x1bd5e18*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x1bd5984*/ void WriteCDataSection(string text);
            /*0x1bd7754*/ byte* InvalidXmlChar(int ch, byte* pDst, bool entitize);
            /*0x1bd7b4c*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            /*0x1bd7870*/ byte* WriteNewLine(byte* pDst);
            /*0x1bd4764*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlUtf8RawTextWriterIndent : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x90*/ int indentLevel;
            /*0x94*/ bool newLineOnAttributes;
            /*0x98*/ string indentChars;
            /*0xa0*/ bool mixedContent;
            /*0xa8*/ System.Xml.BitStack mixedContentStack;
            /*0xb0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x1bd7d0c*/ XmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1bd7e54*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1bd7f0c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1bd7f84*/ void StartElementContent();
            /*0x1bd7fe0*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x1bd7fe8*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1bd8074*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1bd8100*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1bd8148*/ void WriteCData(string text);
            /*0x1bd8154*/ void WriteComment(string text);
            /*0x1bd8198*/ void WriteProcessingInstruction(string target, string text);
            /*0x1bd81ec*/ void WriteEntityRef(string name);
            /*0x1bd81f8*/ void WriteCharEntity(char ch);
            /*0x1bd8204*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1bd8210*/ void WriteWhitespace(string ws);
            /*0x1bd821c*/ void WriteString(string text);
            /*0x1bd8228*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1bd8234*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1bd8240*/ void WriteRaw(string data);
            /*0x1bd824c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1bd7d38*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x1bd7ec0*/ void WriteIndent();
        }

        class XmlValidatingReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlValidatingReaderImpl impl;

            /*0x1bd825c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1bd827c*/ string get_LocalName();
            /*0x1bd829c*/ string get_NamespaceURI();
            /*0x1bd82bc*/ string get_Prefix();
            /*0x1bd82dc*/ string get_Value();
            /*0x1bd82fc*/ int get_Depth();
            /*0x1bd831c*/ string get_BaseURI();
            /*0x1bd8340*/ bool get_IsEmptyElement();
            /*0x1bd8364*/ int get_AttributeCount();
            /*0x1bd8388*/ string GetAttribute(string name);
            /*0x1bd83ac*/ string GetAttribute(string localName, string namespaceURI);
            /*0x1bd83d0*/ string GetAttribute(int i);
            /*0x1bd83f4*/ bool MoveToAttribute(string name);
            /*0x1bd8418*/ bool MoveToFirstAttribute();
            /*0x1bd843c*/ bool MoveToNextAttribute();
            /*0x1bd8460*/ bool MoveToElement();
            /*0x1bd8484*/ bool ReadAttributeValue();
            /*0x1bd84a8*/ bool Read();
            /*0x1bd84cc*/ bool get_EOF();
            /*0x1bd84f0*/ System.Xml.ReadState get_ReadState();
            /*0x1bd8514*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1bd8538*/ string LookupNamespace(string prefix);
            /*0x1bd8574*/ void ResolveEntity();
            /*0x1bd8598*/ bool get_Namespaces();
        }

        class XmlValidatingReaderImpl : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Xml.XmlResolver s_tempResolver;
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.XmlTextReaderImpl coreReaderImpl;
            /*0x20*/ System.Xml.IXmlNamespaceResolver coreReaderNSResolver;
            /*0x28*/ System.Xml.ValidationType validationType;
            /*0x30*/ System.Xml.Schema.BaseValidator validator;
            /*0x38*/ System.Xml.Schema.XmlSchemaCollection schemaCollection;
            /*0x40*/ bool processIdentityConstraints;
            /*0x44*/ System.Xml.XmlValidatingReaderImpl.ParsingFunction parsingFunction;
            /*0x48*/ System.Xml.XmlValidatingReaderImpl.ValidationEventHandling eventHandling;
            /*0x50*/ System.Xml.XmlParserContext parserContext;
            /*0x58*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;
            /*0x60*/ System.Xml.XmlReader outerReader;

            /*0x1bd85dc*/ XmlValidatingReaderImpl(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, bool processIdentityConstraints);
            /*0x1bd8b50*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x1bd8c24*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1bd8c44*/ string get_Name();
            /*0x1bd8c64*/ string get_LocalName();
            /*0x1bd8c84*/ string get_NamespaceURI();
            /*0x1bd8ca4*/ string get_Prefix();
            /*0x1bd8cc4*/ string get_Value();
            /*0x1bd8ce4*/ int get_Depth();
            /*0x1bd8d04*/ string get_BaseURI();
            /*0x1bd8d28*/ bool get_IsEmptyElement();
            /*0x1bd8d4c*/ bool get_IsDefault();
            /*0x1bd8d70*/ char get_QuoteChar();
            /*0x1bd8d94*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1bd8db8*/ string get_XmlLang();
            /*0x1bd8ddc*/ System.Xml.ReadState get_ReadState();
            /*0x1bd8e14*/ bool get_EOF();
            /*0x1bd8e38*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1bd8e5c*/ int get_AttributeCount();
            /*0x1bd8e80*/ string GetAttribute(string name);
            /*0x1bd8ea4*/ string GetAttribute(string localName, string namespaceURI);
            /*0x1bd8ec8*/ string GetAttribute(int i);
            /*0x1bd8eec*/ bool MoveToAttribute(string name);
            /*0x1bd8f38*/ void MoveToAttribute(int i);
            /*0x1bd8f74*/ bool MoveToFirstAttribute();
            /*0x1bd8fc0*/ bool MoveToNextAttribute();
            /*0x1bd900c*/ bool MoveToElement();
            /*0x1bd9058*/ bool Read();
            /*0x1bd9440*/ void Close();
            /*0x1bd9480*/ string LookupNamespace(string prefix);
            /*0x1bd94a4*/ bool ReadAttributeValue();
            /*0x1bd9510*/ bool get_CanResolveEntity();
            /*0x1bd9518*/ void ResolveEntity();
            /*0x1bd954c*/ void MoveOffEntityReference();
            /*0x1bd9600*/ string ReadString();
            /*0x1bd9628*/ bool HasLineInfo();
            /*0x1bd9630*/ int get_LineNumber();
            /*0x1bd972c*/ int get_LinePosition();
            /*0x1bd9828*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1bd98e8*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x1bd98f8*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x1bd982c*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1bd98fc*/ string LookupPrefix(string namespaceName);
            /*0x1bd99bc*/ System.Xml.ValidationType get_ValidationType();
            /*0x1bd99c4*/ System.Xml.Schema.XmlSchemaCollection get_Schemas();
            /*0x1bd85c0*/ bool get_Namespaces();
            /*0x1bd9234*/ void ParseDtdFromParserContext();
            /*0x1bd99cc*/ void ValidateDtd();
            /*0x1bd93b4*/ void ResolveEntityInternally();
            /*0x1bd8a10*/ void SetupValidation(System.Xml.ValidationType valType);
            /*0x1bd8938*/ System.Xml.XmlResolver GetResolver();
            /*0x1bd9138*/ void ProcessCoreReaderEvent();
            /*0x1bd9a4c*/ System.Xml.Schema.BaseValidator get_Validator();
            /*0x1bd9a54*/ void set_Validator(System.Xml.Schema.BaseValidator value);
            /*0x1bd9a5c*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x1bd9a80*/ bool get_StandAlone();
            /*0x1bd9a9c*/ void set_SchemaTypeObject(object value);
            /*0x1bd9ab8*/ object get_TypedValueObject();
            /*0x1bd9ad4*/ void set_TypedValueObject(object value);
            /*0x1bd9af0*/ bool AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef);
            /*0x1bd9b0c*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x1bd9b30*/ void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);

            enum ParsingFunction
            {
                Read = 0,
                Init = 1,
                ParseDtdFromContext = 2,
                ResolveEntityInternally = 3,
                InReadBinaryContent = 4,
                ReaderClosed = 5,
                Error = 6,
                None = 7,
            }

            class ValidationEventHandling : System.Xml.IValidationEventHandling
            {
                /*0x10*/ System.Xml.XmlValidatingReaderImpl reader;
                /*0x18*/ System.Xml.Schema.ValidationEventHandler eventHandler;

                /*0x16ca510*/ ValidationEventHandling(System.Xml.XmlValidatingReaderImpl reader);
                /*0x16ca53c*/ object System.Xml.IValidationEventHandling.get_EventHandler();
                /*0x16ca544*/ void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
                /*0x16ca664*/ void AddHandler(System.Xml.Schema.ValidationEventHandler handler);
            }
        }

        class XmlWellFormedWriter : System.Xml.XmlWriter
        {
            static /*0x0*/ string[] stateName;
            static /*0x8*/ string[] tokenName;
            static /*0x10*/ System.Xml.WriteState[] state2WriteState;
            static /*0x18*/ System.Xml.XmlWellFormedWriter.State[] StateTableDocument;
            static /*0x20*/ System.Xml.XmlWellFormedWriter.State[] StateTableAuto;
            /*0x18*/ System.Xml.XmlWriter writer;
            /*0x20*/ System.Xml.XmlRawWriter rawWriter;
            /*0x28*/ System.Xml.IXmlNamespaceResolver predefinedNamespaces;
            /*0x30*/ System.Xml.XmlWellFormedWriter.Namespace[] nsStack;
            /*0x38*/ int nsTop;
            /*0x40*/ System.Collections.Generic.Dictionary<string, int> nsHashtable;
            /*0x48*/ bool useNsHashtable;
            /*0x50*/ System.Xml.XmlWellFormedWriter.ElementScope[] elemScopeStack;
            /*0x58*/ int elemTop;
            /*0x60*/ System.Xml.XmlWellFormedWriter.AttrName[] attrStack;
            /*0x68*/ int attrCount;
            /*0x70*/ System.Collections.Generic.Dictionary<string, int> attrHashTable;
            /*0x78*/ System.Xml.XmlWellFormedWriter.SpecialAttribute specAttr;
            /*0x80*/ System.Xml.XmlWellFormedWriter.AttributeValueCache attrValueCache;
            /*0x88*/ string curDeclPrefix;
            /*0x90*/ System.Xml.XmlWellFormedWriter.State[] stateTable;
            /*0x98*/ System.Xml.XmlWellFormedWriter.State currentState;
            /*0x9c*/ bool checkCharacters;
            /*0x9d*/ bool omitDuplNamespaces;
            /*0x9e*/ bool writeEndDocumentOnClose;
            /*0xa0*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0xa4*/ bool dtdWritten;
            /*0xa5*/ bool xmlDeclFollows;
            /*0xa8*/ System.Xml.XmlCharType xmlCharType;
            /*0xb0*/ System.Xml.SecureStringHasher hasher;

            static /*0x1be02b8*/ XmlWellFormedWriter();
            static /*0x1bdfa54*/ System.Xml.XmlException DupAttrException(string prefix, string localName);
            static /*0x1bdfc64*/ string GetStateName(System.Xml.XmlWellFormedWriter.State state);
            static /*0x1bdffe0*/ System.Exception InvalidCharsException(string name, int badCharIndex);
            /*0x1bd9f30*/ XmlWellFormedWriter(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x1bda3a0*/ System.Xml.WriteState get_WriteState();
            /*0x1bda448*/ void WriteStartDocument();
            /*0x1bda61c*/ void WriteStartDocument(bool standalone);
            /*0x1bda63c*/ void WriteEndDocument();
            /*0x1bdaadc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1bdafb0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1bdba84*/ void WriteEndElement();
            /*0x1bdbd80*/ void WriteFullEndElement();
            /*0x1bdbf9c*/ void WriteStartAttribute(string prefix, string localName, string namespaceName);
            /*0x1bdcc14*/ void WriteEndAttribute();
            /*0x1bdd9c4*/ void WriteCData(string text);
            /*0x1bddae4*/ void WriteComment(string text);
            /*0x1bddc04*/ void WriteProcessingInstruction(string name, string text);
            /*0x1bddebc*/ void WriteEntityRef(string name);
            /*0x1bde04c*/ void WriteCharEntity(char ch);
            /*0x1bde20c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1bde3f0*/ void WriteWhitespace(string ws);
            /*0x1bde5bc*/ void WriteString(string text);
            /*0x1bde6c4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1bde938*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x1bdebac*/ void WriteRaw(string data);
            /*0x1bdecb4*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x1bdeef8*/ void Close();
            /*0x1bdf1d8*/ void Flush();
            /*0x1bdf2a0*/ string LookupPrefix(string ns);
            /*0x1bdf560*/ void WriteValue(string value);
            /*0x1bdf678*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1bdf7b4*/ System.Xml.XmlRawWriter get_RawWriter();
            /*0x1bde03c*/ bool get_SaveAttrValue();
            /*0x1bdf1ac*/ bool get_InBase64();
            /*0x1bdc69c*/ void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special);
            /*0x1bda450*/ void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone);
            /*0x1bdf7bc*/ void StartFragment();
            /*0x1bdb644*/ void PushNamespaceImplicit(string prefix, string ns);
            /*0x1bdd4a4*/ bool PushNamespaceExplicit(string prefix, string ns);
            /*0x1bdf8c4*/ void AddNamespace(string prefix, string ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
            /*0x1bdfb68*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x1bdf7c8*/ int LookupNamespaceIndex(string prefix);
            /*0x1bdbca0*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x1bda7a8*/ void AdvanceState(System.Xml.XmlWellFormedWriter.Token token);
            /*0x1bdff08*/ void StartElementContent();
            /*0x1bdb4e0*/ string LookupNamespace(string prefix);
            /*0x1bdc888*/ string LookupLocalNamespace(string prefix);
            /*0x1bdc734*/ string GeneratePrefix();
            /*0x1bdb374*/ void CheckNCName(string ncname);
            /*0x1bdfd18*/ void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState);
            /*0x1bdf7a4*/ bool get_IsClosedOrErrorState();
            /*0x1bdc964*/ void AddAttribute(string prefix, string localName, string namespaceName);
            /*0x1be0168*/ void AddToAttrHashTable(int attributeIndex);

            enum State
            {
                Start = 0,
                TopLevel = 1,
                Document = 2,
                Element = 3,
                Content = 4,
                B64Content = 5,
                B64Attribute = 6,
                AfterRootEle = 7,
                Attribute = 8,
                SpecialAttr = 9,
                EndDocument = 10,
                RootLevelAttr = 11,
                RootLevelSpecAttr = 12,
                RootLevelB64Attr = 13,
                AfterRootLevelAttr = 14,
                Closed = 15,
                Error = 16,
                StartContent = 101,
                StartContentEle = 102,
                StartContentB64 = 103,
                StartDoc = 104,
                StartDocEle = 106,
                EndAttrSEle = 107,
                EndAttrEEle = 108,
                EndAttrSCont = 109,
                EndAttrSAttr = 111,
                PostB64Cont = 112,
                PostB64Attr = 113,
                PostB64RootAttr = 114,
                StartFragEle = 115,
                StartFragCont = 116,
                StartFragB64 = 117,
                StartRootLevelAttr = 118,
            }

            enum Token
            {
                StartDocument = 0,
                EndDocument = 1,
                PI = 2,
                Comment = 3,
                Dtd = 4,
                StartElement = 5,
                EndElement = 6,
                StartAttribute = 7,
                EndAttribute = 8,
                Text = 9,
                CData = 10,
                AtomicValue = 11,
                Base64 = 12,
                RawData = 13,
                Whitespace = 14,
            }

            class NamespaceResolverProxy : System.Xml.IXmlNamespaceResolver
            {
                /*0x10*/ System.Xml.XmlWellFormedWriter wfWriter;

                /*0x16cb9d0*/ NamespaceResolverProxy(System.Xml.XmlWellFormedWriter wfWriter);
                /*0x16cb9fc*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x16cba3c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
                /*0x16cba58*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            }

            struct ElementScope
            {
                /*0x10*/ int prevNSTop;
                /*0x18*/ string prefix;
                /*0x20*/ string localName;
                /*0x28*/ string namespaceUri;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x38*/ string xmlLang;

                /*0xac1bac*/ void Set(string prefix, string localName, string namespaceUri, int prevNSTop);
                /*0xac1bc8*/ void WriteEndElement(System.Xml.XmlRawWriter rawWriter);
                /*0xac1bd0*/ void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter);
            }

            enum NamespaceKind
            {
                Written = 0,
                NeedToWrite = 1,
                Implied = 2,
                Special = 3,
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ System.Xml.XmlWellFormedWriter.NamespaceKind kind;
                /*0x24*/ int prevNsIndex;

                /*0xac1c9c*/ void Set(string prefix, string namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
                /*0xac1cac*/ void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter);
            }

            struct AttrName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ string localName;
                /*0x28*/ int prev;

                /*0xac1a88*/ void Set(string prefix, string localName, string namespaceUri);
                /*0xac1a98*/ bool IsDuplicate(string prefix, string localName, string namespaceUri);
            }

            enum SpecialAttribute
            {
                No = 0,
                DefaultXmlns = 1,
                PrefixedXmlns = 2,
                XmlSpace = 3,
                XmlLang = 4,
            }

            class AttributeValueCache
            {
                /*0x10*/ System.Text.StringBuilder stringValue;
                /*0x18*/ string singleStringValue;
                /*0x20*/ System.Xml.XmlWellFormedWriter.AttributeValueCache.Item[] items;
                /*0x28*/ int firstItem;
                /*0x2c*/ int lastItem;

                /*0x16cb798*/ AttributeValueCache();
                /*0x16ca76c*/ string get_StringValue();
                /*0x16ca79c*/ void WriteEntityRef(string name);
                /*0x16cab0c*/ void WriteCharEntity(char ch);
                /*0x16caba4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x16cac74*/ void WriteWhitespace(string ws);
                /*0x16cacc8*/ void WriteString(string text);
                /*0x16cad3c*/ void WriteChars(char[] buffer, int index, int count);
                /*0x16cae34*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x16caeec*/ void WriteRaw(string data);
                /*0x16caf40*/ void WriteValue(string value);
                /*0x16caf94*/ void Replay(System.Xml.XmlWriter writer);
                /*0x16cb2c0*/ void Trim();
                /*0x16cb754*/ void Clear();
                /*0x16ca944*/ void StartComplexValue();
                /*0x16ca98c*/ void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);

                enum ItemType
                {
                    EntityRef = 0,
                    CharEntity = 1,
                    SurrogateCharEntity = 2,
                    Whitespace = 3,
                    String = 4,
                    StringChars = 5,
                    Raw = 6,
                    RawChars = 7,
                    ValueString = 8,
                }

                class Item
                {
                    /*0x10*/ System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type;
                    /*0x18*/ object data;

                    /*0x16cb784*/ Item();
                    /*0x16cb78c*/ void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);
                }

                class BufferChunk
                {
                    /*0x10*/ char[] buffer;
                    /*0x18*/ int index;
                    /*0x1c*/ int count;

                    /*0x16cadf4*/ BufferChunk(char[] buffer, int index, int count);
                }
            }
        }

        enum WriteState
        {
            Start = 0,
            Prolog = 1,
            Element = 2,
            Attribute = 3,
            Content = 4,
            Closed = 5,
            Error = 6,
        }

        class XmlWriter : System.IDisposable
        {
            /*0x10*/ char[] writeNodeBuffer;

            static /*0x1a4e9f4*/ System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings);
            static /*0x1a4ef64*/ System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings);
            /*0x1a4f2dc*/ XmlWriter();
            void WriteStartDocument();
            void WriteStartDocument(bool standalone);
            void WriteEndDocument();
            void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1a4e0d0*/ void WriteStartElement(string localName, string ns);
            void WriteStartElement(string prefix, string localName, string ns);
            void WriteEndElement();
            void WriteFullEndElement();
            /*0x1a4e0e8*/ void WriteAttributeString(string localName, string ns, string value);
            /*0x1a4e148*/ void WriteAttributeString(string localName, string value);
            /*0x1a4e1a8*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
            void WriteStartAttribute(string prefix, string localName, string ns);
            void WriteEndAttribute();
            void WriteCData(string text);
            void WriteComment(string text);
            void WriteProcessingInstruction(string name, string text);
            void WriteEntityRef(string name);
            void WriteCharEntity(char ch);
            void WriteWhitespace(string ws);
            void WriteString(string text);
            void WriteSurrogateCharEntity(char lowChar, char highChar);
            void WriteChars(char[] buffer, int index, int count);
            void WriteRaw(char[] buffer, int index, int count);
            void WriteRaw(string data);
            void WriteBase64(byte[] buffer, int index, int count);
            /*0x1a4e1fc*/ void WriteBinHex(byte[] buffer, int index, int count);
            System.Xml.WriteState get_WriteState();
            /*0x1a4e218*/ void Close();
            void Flush();
            string LookupPrefix(string ns);
            /*0x1a4e21c*/ void WriteValue(string value);
            /*0x1a4e234*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x1a4e4c0*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x1a4e924*/ void WriteElementString(string localName, string ns, string value);
            /*0x1a4e98c*/ void Dispose();
            /*0x1a4e9a0*/ void Dispose(bool disposing);
        }

        enum XmlOutputMethod
        {
            Xml = 0,
            Html = 1,
            Text = 2,
            AutoDetect = 3,
        }

        enum TriState
        {
            Unknown = -1,
            False = 0,
            True = 1,
        }

        enum XmlStandalone
        {
            Omit = 0,
            Yes = 1,
            No = 2,
        }

        class XmlWriterSettings
        {
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Text.Encoding encoding;
            /*0x20*/ bool omitXmlDecl;
            /*0x24*/ System.Xml.NewLineHandling newLineHandling;
            /*0x28*/ string newLineChars;
            /*0x30*/ System.Xml.TriState indent;
            /*0x38*/ string indentChars;
            /*0x40*/ bool newLineOnAttributes;
            /*0x41*/ bool closeOutput;
            /*0x44*/ System.Xml.NamespaceHandling namespaceHandling;
            /*0x48*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0x4c*/ bool checkCharacters;
            /*0x4d*/ bool writeEndDocumentOnClose;
            /*0x50*/ System.Xml.XmlOutputMethod outputMethod;
            /*0x58*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> cdataSections;
            /*0x60*/ bool doNotEscapeUriAttributes;
            /*0x61*/ bool mergeCDataSections;
            /*0x68*/ string mediaType;
            /*0x70*/ string docTypeSystem;
            /*0x78*/ string docTypePublic;
            /*0x80*/ System.Xml.XmlStandalone standalone;
            /*0x84*/ bool autoXmlDecl;
            /*0x85*/ bool isReadOnly;

            /*0x1a4ea68*/ XmlWriterSettings();
            /*0x1a4f3b4*/ bool get_Async();
            /*0x1a4f3bc*/ System.Text.Encoding get_Encoding();
            /*0x1a4f3c4*/ bool get_OmitXmlDeclaration();
            /*0x1a4f3cc*/ void set_OmitXmlDeclaration(bool value);
            /*0x1a4f4e0*/ System.Xml.NewLineHandling get_NewLineHandling();
            /*0x1a4f4e8*/ string get_NewLineChars();
            /*0x1a4f4f0*/ bool get_Indent();
            /*0x1a4f500*/ void set_Indent(bool value);
            /*0x1a4f56c*/ string get_IndentChars();
            /*0x1a4f574*/ bool get_NewLineOnAttributes();
            /*0x1a4f57c*/ bool get_CloseOutput();
            /*0x1a4f584*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x1a4f58c*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x1a4f63c*/ bool get_CheckCharacters();
            /*0x1a4f644*/ System.Xml.NamespaceHandling get_NamespaceHandling();
            /*0x1a4f64c*/ void set_NamespaceHandling(System.Xml.NamespaceHandling value);
            /*0x1a4f6fc*/ bool get_WriteEndDocumentOnClose();
            /*0x1a4f704*/ System.Xml.XmlOutputMethod get_OutputMethod();
            /*0x1a4f70c*/ void set_OutputMethod(System.Xml.XmlOutputMethod value);
            /*0x1a4f714*/ System.Xml.XmlWriterSettings Clone();
            /*0x1a4f7e0*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements();
            /*0x1a4f7e8*/ bool get_DoNotEscapeUriAttributes();
            /*0x1a4f7f0*/ bool get_MergeCDataSections();
            /*0x1a4f7f8*/ string get_MediaType();
            /*0x1a4f800*/ string get_DocTypeSystem();
            /*0x1a4f808*/ string get_DocTypePublic();
            /*0x1a4f810*/ System.Xml.XmlStandalone get_Standalone();
            /*0x1a4f818*/ bool get_AutoXmlDeclaration();
            /*0x1a4f820*/ System.Xml.TriState get_IndentInternal();
            /*0x1a4f828*/ bool get_IsQuerySpecific();
            /*0x1a4eae8*/ System.Xml.XmlWriter CreateWriter(System.IO.Stream output);
            /*0x1a4efd8*/ System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output);
            /*0x1a4f89c*/ void set_ReadOnly(bool value);
            /*0x1a4f430*/ void CheckReadOnly(string propertyName);
            /*0x1a4f2e4*/ void Initialize();
        }

        class XsdCachingReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo
        {
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.XmlNameTable coreReaderNameTable;
            /*0x20*/ System.Xml.ValidatingReaderNodeData[] contentEvents;
            /*0x28*/ System.Xml.ValidatingReaderNodeData[] attributeEvents;
            /*0x30*/ System.Xml.ValidatingReaderNodeData cachedNode;
            /*0x38*/ System.Xml.XsdCachingReader.CachingReaderState cacheState;
            /*0x3c*/ int contentIndex;
            /*0x40*/ int attributeCount;
            /*0x44*/ bool returnOriginalStringValues;
            /*0x48*/ System.Xml.CachingEventHandler cacheHandler;
            /*0x50*/ int currentAttrIndex;
            /*0x54*/ int currentContentIndex;
            /*0x58*/ bool readAhead;
            /*0x60*/ System.Xml.IXmlLineInfo lineInfo;
            /*0x68*/ System.Xml.ValidatingReaderNodeData textNode;

            /*0x1a5b278*/ XsdCachingReader(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod);
            /*0x1a5b340*/ void Init();
            /*0x1a5b79c*/ void Reset(System.Xml.XmlReader reader);
            /*0x1a5b7a4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x1a5b7c4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1a5b7e0*/ string get_Name();
            /*0x1a5b804*/ string get_LocalName();
            /*0x1a5b820*/ string get_NamespaceURI();
            /*0x1a5b83c*/ string get_Prefix();
            /*0x1a5b858*/ string get_Value();
            /*0x1a5b888*/ int get_Depth();
            /*0x1a5b8a4*/ string get_BaseURI();
            /*0x1a5b8c8*/ bool get_IsEmptyElement();
            /*0x1a5b8d0*/ bool get_IsDefault();
            /*0x1a5b8d8*/ char get_QuoteChar();
            /*0x1a5b8fc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1a5b920*/ string get_XmlLang();
            /*0x1a5b944*/ int get_AttributeCount();
            /*0x1a5b94c*/ string GetAttribute(string name);
            /*0x1a5bb54*/ string GetAttribute(string name, string namespaceURI);
            /*0x1a5bc88*/ string GetAttribute(int i);
            /*0x1a5bd2c*/ bool MoveToAttribute(string name);
            /*0x1a5bdc8*/ void MoveToAttribute(int i);
            /*0x1a5be6c*/ bool MoveToFirstAttribute();
            /*0x1a5bebc*/ bool MoveToNextAttribute();
            /*0x1a5bf20*/ bool MoveToElement();
            /*0x1a5bf78*/ bool Read();
            /*0x1a5c25c*/ System.Xml.ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos);
            /*0x1a5c2d8*/ void SwitchTextNodeAndEndElement(string textValue, string originalStringValue);
            /*0x1a5c3e4*/ void RecordEndElementNode();
            /*0x1a5c518*/ bool get_EOF();
            /*0x1a5c550*/ void Close();
            /*0x1a5c590*/ System.Xml.ReadState get_ReadState();
            /*0x1a5c5b4*/ void Skip();
            /*0x1a5c6c4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1a5c6cc*/ string LookupNamespace(string prefix);
            /*0x1a5c6f0*/ void ResolveEntity();
            /*0x1a5c730*/ bool ReadAttributeValue();
            /*0x1a5c818*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
            /*0x1a5c820*/ int System.Xml.IXmlLineInfo.get_LineNumber();
            /*0x1a5c83c*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            /*0x1a5c858*/ void SetToReplayMode();
            /*0x1a5c878*/ System.Xml.XmlReader GetCoreReader();
            /*0x1a5c880*/ System.Xml.IXmlLineInfo GetLineInfo();
            /*0x1a5c24c*/ void ClearAttributesInfo();
            /*0x1a5c888*/ System.Xml.ValidatingReaderNodeData AddAttribute(int attIndex);
            /*0x1a5b4a0*/ System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType);
            /*0x1a5b620*/ void RecordAttributes();
            /*0x1a5b9e4*/ int GetAttributeIndexWithoutPrefix(string name);
            /*0x1a5baa0*/ int GetAttributeIndexWithPrefix(string name);
            /*0x1a5c784*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);

            enum CachingReaderState
            {
                None = 0,
                Init = 1,
                Record = 2,
                Replay = 3,
                ReaderClosed = 4,
                Error = 5,
            }
        }

        class CachingEventHandler : System.MulticastDelegate
        {
            /*0x1590c54*/ CachingEventHandler(object object, nint method);
            /*0x1590cb4*/ void Invoke(System.Xml.XsdCachingReader cachingReader);
            /*0x159102c*/ System.IAsyncResult BeginInvoke(System.Xml.XsdCachingReader cachingReader, System.AsyncCallback callback, object object);
            /*0x1591050*/ void EndInvoke(System.IAsyncResult result);
        }

        class AttributePSVIInfo
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ object typedAttributeValue;
            /*0x28*/ System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;

            /*0x1588cc4*/ AttributePSVIInfo();
            /*0x1588d2c*/ void Reset();
        }

        class XsdValidatingReader : System.Xml.XmlReader, System.Xml.Schema.IXmlSchemaInfo, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Type TypeOfString;
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.IXmlNamespaceResolver coreReaderNSResolver;
            /*0x20*/ System.Xml.IXmlNamespaceResolver thisNSResolver;
            /*0x28*/ System.Xml.Schema.XmlSchemaValidator validator;
            /*0x30*/ System.Xml.XmlResolver xmlResolver;
            /*0x38*/ System.Xml.Schema.ValidationEventHandler validationEvent;
            /*0x40*/ System.Xml.XsdValidatingReader.ValidatingReaderState validationState;
            /*0x48*/ System.Xml.Schema.XmlValueGetter valueGetter;
            /*0x50*/ System.Xml.XmlNamespaceManager nsManager;
            /*0x58*/ bool manageNamespaces;
            /*0x59*/ bool processInlineSchema;
            /*0x5a*/ bool replayCache;
            /*0x60*/ System.Xml.ValidatingReaderNodeData cachedNode;
            /*0x68*/ System.Xml.AttributePSVIInfo attributePSVI;
            /*0x70*/ int attributeCount;
            /*0x74*/ int coreReaderAttributeCount;
            /*0x78*/ int currentAttrIndex;
            /*0x80*/ System.Xml.AttributePSVIInfo[] attributePSVINodes;
            /*0x88*/ System.Collections.ArrayList defaultAttributes;
            /*0x90*/ System.Xml.Schema.Parser inlineSchemaParser;
            /*0x98*/ object atomicValue;
            /*0xa0*/ System.Xml.Schema.XmlSchemaInfo xmlSchemaInfo;
            /*0xa8*/ string originalAtomicValueString;
            /*0xb0*/ System.Xml.XmlNameTable coreReaderNameTable;
            /*0xb8*/ System.Xml.XsdCachingReader cachingReader;
            /*0xc0*/ System.Xml.ValidatingReaderNodeData textNode;
            /*0xc8*/ string NsXmlNs;
            /*0xd0*/ string NsXs;
            /*0xd8*/ string NsXsi;
            /*0xe0*/ string XsiType;
            /*0xe8*/ string XsiNil;
            /*0xf0*/ string XsdSchema;
            /*0xf8*/ string XsiSchemaLocation;
            /*0x100*/ string XsiNoNamespaceSchemaLocation;
            /*0x108*/ System.Xml.XmlCharType xmlCharType;
            /*0x110*/ System.Xml.IXmlLineInfo lineInfo;
            /*0x118*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;
            /*0x120*/ System.Xml.XsdValidatingReader.ValidatingReaderState savedState;

            /*0x1a5fdc4*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x1a60474*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings);
            /*0x1a5ff50*/ void Init();
            /*0x1a6026c*/ void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x1a6047c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x1a60550*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1a605dc*/ string get_Name();
            /*0x1a6071c*/ string get_LocalName();
            /*0x1a6075c*/ string get_NamespaceURI();
            /*0x1a6079c*/ string get_Prefix();
            /*0x1a607dc*/ string get_Value();
            /*0x1a6081c*/ int get_Depth();
            /*0x1a6085c*/ string get_BaseURI();
            /*0x1a60880*/ bool get_IsEmptyElement();
            /*0x1a608a4*/ bool get_IsDefault();
            /*0x1a608dc*/ char get_QuoteChar();
            /*0x1a60900*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1a60924*/ string get_XmlLang();
            /*0x1a60948*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1a6094c*/ System.Type get_ValueType();
            /*0x1a60a34*/ int get_AttributeCount();
            /*0x1a60a3c*/ string GetAttribute(string name);
            /*0x1a60c44*/ string GetAttribute(string name, string namespaceURI);
            /*0x1a60ea0*/ string GetAttribute(int i);
            /*0x1a60f8c*/ bool MoveToAttribute(string name);
            /*0x1a611e8*/ void MoveToAttribute(int i);
            /*0x1a61370*/ bool MoveToFirstAttribute();
            /*0x1a614b0*/ bool MoveToNextAttribute();
            /*0x1a615f4*/ bool MoveToElement();
            /*0x1a61654*/ bool Read();
            /*0x1a61a7c*/ bool get_EOF();
            /*0x1a61aa0*/ void Close();
            /*0x1a61ae0*/ System.Xml.ReadState get_ReadState();
            /*0x1a61b18*/ void Skip();
            /*0x1a61c88*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1a61c90*/ string LookupNamespace(string prefix);
            /*0x1a61d50*/ void ResolveEntity();
            /*0x1a61d90*/ bool ReadAttributeValue();
            /*0x1a61ee0*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x1a621f0*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x1a62248*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x1a622e8*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x1a62470*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x1a624d8*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x1a62538*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
            /*0x1a62588*/ bool HasLineInfo();
            /*0x1a62590*/ int get_LineNumber();
            /*0x1a6264c*/ int get_LinePosition();
            /*0x1a62708*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1a627dc*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x1a628b4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x1a6298c*/ object GetStringValue();
            /*0x1a60a18*/ System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo();
            /*0x1a617b0*/ void ProcessReaderEvent();
            /*0x1a629ac*/ void ProcessElementEvent();
            /*0x1a62e48*/ void ProcessEndElementEvent();
            /*0x1a62fdc*/ void ValidateAttributes();
            /*0x1a61a34*/ void ClearAttributesInfo();
            /*0x1a61048*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string name);
            /*0x1a6346c*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string localName, string ns);
            /*0x1a60aac*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition);
            /*0x1a60d50*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition);
            /*0x1a63304*/ System.Xml.AttributePSVIInfo AddAttributePSVI(int attIndex);
            /*0x1a62f88*/ bool IsXSDRoot(string localName, string ns);
            /*0x1a61978*/ void ProcessInlineSchema();
            /*0x1a63528*/ void ReadAheadForMemberType();
            /*0x1a61f74*/ void GetIsDefault();
            /*0x1a62374*/ void GetMemberType();
            /*0x1a6321c*/ System.Xml.XsdCachingReader GetCachingReader();
            /*0x1a61e4c*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);
            /*0x1a636f4*/ void CachingCallBack(System.Xml.XsdCachingReader cachingReader);
            /*0x1a63188*/ string GetOriginalAtomicValueStringOfElement();

            enum ValidatingReaderState
            {
                None = 0,
                Init = 1,
                Read = 2,
                OnDefaultAttribute = -1,
                OnReadAttributeValue = -2,
                OnAttribute = 3,
                ClearAttributes = 4,
                ParseInlineSchema = 5,
                ReadAhead = 6,
                OnReadBinaryContent = 7,
                ReaderClosed = 8,
                EOF = 9,
                Error = 10,
            }
        }

        class DomNameTable
        {
            /*0x10*/ System.Xml.XmlName[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ System.Xml.XmlDocument ownerDocument;
            /*0x28*/ System.Xml.XmlNameTable nameTable;

            /*0x1c017ec*/ DomNameTable(System.Xml.XmlDocument document);
            /*0x1c0187c*/ System.Xml.XmlName GetName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1c019f0*/ System.Xml.XmlName AddName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1c01c6c*/ void Grow();
        }

        class XmlAttribute : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlName name;
            /*0x20*/ System.Xml.XmlLinkedNode lastChild;

            /*0x1d2b578*/ XmlAttribute(System.Xml.XmlName name, System.Xml.XmlDocument doc);
            /*0x1d2b6b0*/ XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x1d2b694*/ int get_LocalNameHash();
            /*0x1d2b6f4*/ System.Xml.XmlName get_XmlName();
            /*0x1d2b6fc*/ void set_XmlName(System.Xml.XmlName value);
            /*0x1d2b704*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d2b7d0*/ System.Xml.XmlNode get_ParentNode();
            /*0x1d2b7d8*/ string get_Name();
            /*0x1d2b7f4*/ string get_LocalName();
            /*0x1d2b810*/ string get_NamespaceURI();
            /*0x1d2b82c*/ string get_Prefix();
            /*0x1d2b848*/ void set_Prefix(string value);
            /*0x1d2b8ec*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d2b8f4*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1d2b910*/ string get_Value();
            /*0x1d2b920*/ void set_Value(string value);
            /*0x1d2b930*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1d2b938*/ void set_InnerText(string value);
            /*0x1d2b9ac*/ bool PrepareOwnerElementInElementIdAttrMap();
            /*0x1d2ba70*/ void ResetOwnerElementInElementIdAttrMap(string oldInnerText);
            /*0x1d2bb00*/ bool get_IsContainer();
            /*0x1d2bb08*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x1d2bc80*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1d2bc88*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1d2bc90*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1d2bca8*/ bool get_Specified();
            /*0x1d2bcb0*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d2bd44*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d2bdd8*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x1d2be60*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x1d2bee8*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x1d2bf70*/ System.Xml.XmlElement get_OwnerElement();
            /*0x1d2bff0*/ void set_InnerXml(string value);
            /*0x1d2c080*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d2c138*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1d2c1a4*/ string get_BaseURI();
            /*0x1d2c240*/ void SetParent(System.Xml.XmlNode node);
            /*0x1d2c248*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1d2c2ac*/ string get_XmlLang();
        }

        class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x1d52dd8*/ XmlAttributeCollection(System.Xml.XmlNode parent);
            /*0x1d52de0*/ System.Xml.XmlAttribute get_ItemOf(int i);
            /*0x1d52f30*/ System.Xml.XmlAttribute get_ItemOf(string name);
            /*0x1d5305c*/ System.Xml.XmlAttribute get_ItemOf(string localName, string namespaceURI);
            /*0x1d531c0*/ int FindNodeOffsetNS(System.Xml.XmlAttribute node);
            /*0x1d5334c*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x1d53590*/ System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node);
            /*0x1d53860*/ System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node);
            /*0x1d538f4*/ System.Xml.XmlAttribute RemoveAt(int i);
            /*0x1d539ac*/ void RemoveAll();
            /*0x1d539f8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x1d53a88*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1d53a90*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1d53a94*/ int System.Collections.ICollection.get_Count();
            /*0x1d53a9c*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x1d53c94*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);
            /*0x1d53d48*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x1d536b0*/ void Detach(System.Xml.XmlAttribute attr);
            /*0x1d53704*/ void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x1d53ef4*/ void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x1d53b84*/ int RemoveDuplicateAttribute(System.Xml.XmlAttribute attr);
            /*0x1d54644*/ bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName);
            /*0x1d5473c*/ void ResetParentInElementIdAttrMap(string oldVal, string newVal);
            /*0x1d534e4*/ System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node);
        }

        class XmlCDataSection : System.Xml.XmlCharacterData
        {
            /*0x1d5f7d0*/ XmlCDataSection(string data, System.Xml.XmlDocument doc);
            /*0x1d5f830*/ string get_Name();
            /*0x1d5f85c*/ string get_LocalName();
            /*0x1d5f888*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d5f890*/ System.Xml.XmlNode get_ParentNode();
            /*0x1d5f920*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d5f980*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d5f9cc*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1d5f9d0*/ bool get_IsText();
        }

        class XmlCharacterData : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string data;

            /*0x1d5f800*/ XmlCharacterData(string data, System.Xml.XmlDocument doc);
            /*0x1d60500*/ string get_Value();
            /*0x1d60510*/ void set_Value(string value);
            /*0x1d60520*/ string get_InnerText();
            /*0x1d6052c*/ void set_InnerText(string value);
            /*0x1d60538*/ string get_Data();
            /*0x1d60590*/ void set_Data(string value);
            /*0x1d60640*/ bool CheckOnData(string data);
        }

        class XmlChildEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Xml.XmlNode container;
            /*0x18*/ System.Xml.XmlNode child;
            /*0x20*/ bool isFirst;

            /*0x1d60678*/ XmlChildEnumerator(System.Xml.XmlNode container);
            /*0x1d606cc*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x1d606d0*/ bool MoveNext();
            /*0x1d60740*/ void System.Collections.IEnumerator.Reset();
            /*0x1d60784*/ object System.Collections.IEnumerator.get_Current();
            /*0x1d60788*/ System.Xml.XmlNode get_Current();
        }

        class XmlChildNodes : System.Xml.XmlNodeList
        {
            /*0x10*/ System.Xml.XmlNode container;

            /*0x1d607f8*/ XmlChildNodes(System.Xml.XmlNode container);
            /*0x1d60824*/ System.Xml.XmlNode Item(int i);
            /*0x1d6088c*/ int get_Count();
            /*0x1d608e4*/ System.Collections.IEnumerator GetEnumerator();
        }

        class XmlComment : System.Xml.XmlCharacterData
        {
            /*0x1d609f8*/ XmlComment(string comment, System.Xml.XmlDocument doc);
            /*0x1d60a28*/ string get_Name();
            /*0x1d60a54*/ string get_LocalName();
            /*0x1d60a80*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d60a88*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d60ae8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d60b34*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlDeclaration : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string version;
            /*0x28*/ string encoding;
            /*0x30*/ string standalone;

            /*0x1d6bab4*/ XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc);
            /*0x1d6be8c*/ string get_Version();
            /*0x1d6be94*/ void set_Version(string value);
            /*0x1d6be9c*/ string get_Encoding();
            /*0x1d6bcc8*/ void set_Encoding(string value);
            /*0x1d6bea4*/ string get_Standalone();
            /*0x1d6bd3c*/ void set_Standalone(string value);
            /*0x1d6beac*/ string get_Value();
            /*0x1d6bebc*/ void set_Value(string value);
            /*0x1d6becc*/ string get_InnerText();
            /*0x1d6c044*/ void set_InnerText(string value);
            /*0x1d6c1dc*/ string get_Name();
            /*0x1d6c220*/ string get_LocalName();
            /*0x1d6c22c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d6c234*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d6c27c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d6c2ec*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1d6bc40*/ bool IsValidXmlVersion(string ver);
        }

        class XmlDocument : System.Xml.XmlNode
        {
            static /*0x0*/ System.Xml.EmptyEnumerator EmptyEnumerator;
            static /*0x8*/ System.Xml.Schema.IXmlSchemaInfo NotKnownSchemaInfo;
            static /*0x10*/ System.Xml.Schema.IXmlSchemaInfo ValidSchemaInfo;
            static /*0x18*/ System.Xml.Schema.IXmlSchemaInfo InvalidSchemaInfo;
            /*0x18*/ System.Xml.XmlImplementation implementation;
            /*0x20*/ System.Xml.DomNameTable domNameTable;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;
            /*0x30*/ System.Xml.XmlNamedNodeMap entities;
            /*0x38*/ System.Collections.Hashtable htElementIdMap;
            /*0x40*/ System.Collections.Hashtable htElementIDAttrDecl;
            /*0x48*/ System.Xml.Schema.SchemaInfo schemaInfo;
            /*0x50*/ System.Xml.Schema.XmlSchemaSet schemas;
            /*0x58*/ bool reportValidity;
            /*0x59*/ bool actualLoadingStatus;
            /*0x60*/ System.Xml.XmlNodeChangedEventHandler onNodeInsertingDelegate;
            /*0x68*/ System.Xml.XmlNodeChangedEventHandler onNodeInsertedDelegate;
            /*0x70*/ System.Xml.XmlNodeChangedEventHandler onNodeRemovingDelegate;
            /*0x78*/ System.Xml.XmlNodeChangedEventHandler onNodeRemovedDelegate;
            /*0x80*/ System.Xml.XmlNodeChangedEventHandler onNodeChangingDelegate;
            /*0x88*/ System.Xml.XmlNodeChangedEventHandler onNodeChangedDelegate;
            /*0x90*/ bool fEntRefNodesPresent;
            /*0x91*/ bool fCDataNodesPresent;
            /*0x92*/ bool preserveWhitespace;
            /*0x93*/ bool isLoading;
            /*0x98*/ string strDocumentName;
            /*0xa0*/ string strDocumentFragmentName;
            /*0xa8*/ string strCommentName;
            /*0xb0*/ string strTextName;
            /*0xb8*/ string strCDataSectionName;
            /*0xc0*/ string strEntityName;
            /*0xc8*/ string strID;
            /*0xd0*/ string strXmlns;
            /*0xd8*/ string strXml;
            /*0xe0*/ string strSpace;
            /*0xe8*/ string strLang;
            /*0xf0*/ string strEmpty;
            /*0xf8*/ string strNonSignificantWhitespaceName;
            /*0x100*/ string strSignificantWhitespaceName;
            /*0x108*/ string strReservedXmlns;
            /*0x110*/ string strReservedXml;
            /*0x118*/ string baseURI;
            /*0x120*/ System.Xml.XmlResolver resolver;
            /*0x128*/ bool bSetResolver;
            /*0x130*/ object objLock;

            static /*0x1d6ffb8*/ XmlDocument();
            static /*0x1d6c79c*/ void CheckName(string name);
            /*0x1d6c2f0*/ XmlDocument();
            /*0x1d6c700*/ XmlDocument(System.Xml.XmlNameTable nt);
            /*0x1d6c350*/ XmlDocument(System.Xml.XmlImplementation imp);
            /*0x1d6c78c*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x1d6c794*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
            /*0x1d6c87c*/ System.Xml.XmlName AddXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1d6c898*/ System.Xml.XmlName GetXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1d6c8b4*/ System.Xml.XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1d6c9d0*/ bool AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName);
            /*0x1d6ca94*/ System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName);
            /*0x1d542f8*/ System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName);
            /*0x1d6cb78*/ System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem);
            /*0x1d5430c*/ void AddElementWithId(string id, System.Xml.XmlElement elem);
            /*0x1d54508*/ void RemoveElementWithId(string id, System.Xml.XmlElement elem);
            /*0x1d6d168*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d6d274*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d6d27c*/ System.Xml.XmlNode get_ParentNode();
            /*0x1d6d284*/ System.Xml.XmlDocumentType get_DocumentType();
            /*0x1d6d314*/ System.Xml.XmlDeclaration get_Declaration();
            /*0x1d6d3bc*/ System.Xml.XmlImplementation get_Implementation();
            /*0x1d6d3c4*/ string get_Name();
            /*0x1d6d3cc*/ string get_LocalName();
            /*0x1d6d3d4*/ System.Xml.XmlElement get_DocumentElement();
            /*0x1d6d464*/ bool get_IsContainer();
            /*0x1d6d46c*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1d6d474*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1d6d47c*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1d6d484*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x1d6d48c*/ bool get_CanReportValidity();
            /*0x1d6d494*/ bool get_HasSetResolver();
            /*0x1d6d49c*/ System.Xml.XmlResolver GetResolver();
            /*0x1d6d4a4*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x1d6d62c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1d6d714*/ bool HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x1d6d7d0*/ bool HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x1d6d838*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d6d99c*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d6da98*/ System.Xml.XmlAttribute CreateAttribute(string name);
            /*0x1d6db5c*/ void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI);
            /*0x1d6dbf0*/ System.Xml.XmlCDataSection CreateCDataSection(string data);
            /*0x1d6dc68*/ System.Xml.XmlComment CreateComment(string data);
            /*0x1d6dcd8*/ System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset);
            /*0x1d6dd68*/ System.Xml.XmlDocumentFragment CreateDocumentFragment();
            /*0x1d6de44*/ System.Xml.XmlElement CreateElement(string name);
            /*0x1d6def8*/ void AddDefaultAttributes(System.Xml.XmlElement elem);
            /*0x1d6e194*/ System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem);
            /*0x1d6e2a4*/ System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x1d6e3a4*/ System.Xml.XmlEntityReference CreateEntityReference(string name);
            /*0x1d6e414*/ System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
            /*0x1d6e48c*/ System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
            /*0x1d6e510*/ System.Xml.XmlText CreateTextNode(string text);
            /*0x1d6e580*/ System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text);
            /*0x1d6e5f0*/ System.Xml.XmlWhitespace CreateWhitespace(string text);
            /*0x1d6e660*/ System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
            /*0x1d6e708*/ System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI);
            /*0x1d6e7b0*/ System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, bool deep);
            /*0x1d6ec60*/ void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem);
            /*0x1d6d1d4*/ void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, bool deep);
            /*0x1d6c770*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1d6ed78*/ System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
            /*0x1d6ee18*/ System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI);
            /*0x1d6eea0*/ System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI);
            /*0x1d6ef64*/ bool get_IsReadOnly();
            /*0x1d6ef6c*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x1d6efd8*/ void set_Entities(System.Xml.XmlNamedNodeMap value);
            /*0x1d6efe0*/ bool get_IsLoading();
            /*0x1d6efe8*/ void set_IsLoading(bool value);
            /*0x1d6eff4*/ bool get_ActualLoadingStatus();
            /*0x1d6effc*/ System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader);
            /*0x1d6f0c4*/ System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr);
            /*0x1d6f128*/ void Load(System.Xml.XmlReader reader);
            /*0x1d6f21c*/ void LoadXml(string xml);
            /*0x1d6f370*/ void set_InnerText(string value);
            /*0x1d6f3cc*/ void set_InnerXml(string value);
            /*0x1d6f3dc*/ void Save(System.Xml.XmlWriter w);
            /*0x1d6f608*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d6f618*/ void WriteContentTo(System.Xml.XmlWriter xw);
            /*0x1d6f8d8*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x1d6f9d4*/ System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent);
            /*0x1d6fa90*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x1d6fadc*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x1d54050*/ System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x1d6fb28*/ string get_Version();
            /*0x1d6fb50*/ string get_Encoding();
            /*0x1d6f5e0*/ string get_Standalone();
            /*0x1d6fb78*/ System.Xml.XmlEntity GetEntityNode(string name);
            /*0x1d6fc4c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1d6fdcc*/ string get_BaseURI();
            /*0x1d6fdd4*/ void SetBaseURI(string inBaseURI);
            /*0x1d6fddc*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
        }

        class XmlDocumentFragment : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode lastChild;

            /*0x1d6ddc4*/ XmlDocumentFragment(System.Xml.XmlDocument ownerDocument);
            /*0x1d700b4*/ string get_Name();
            /*0x1d700e0*/ string get_LocalName();
            /*0x1d7010c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1d70114*/ System.Xml.XmlNode get_ParentNode();
            /*0x1d7011c*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1d70198*/ void set_InnerXml(string value);
            /*0x1d7022c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1d702b4*/ bool get_IsContainer();
            /*0x1d702bc*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1d702c4*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1d702cc*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1d7033c*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d703b0*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1d7041c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1d7042c*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlDocumentType : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ string publicId;
            /*0x30*/ string systemId;
            /*0x38*/ string internalSubset;
            /*0x40*/ bool namespaces;
            /*0x48*/ System.Xml.XmlNamedNodeMap entities;
            /*0x50*/ System.Xml.XmlNamedNodeMap notations;
            /*0x58*/ System.Xml.Schema.SchemaInfo schemaInfo;

            /*0x1fcfc94*/ XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc);
            /*0x1fcfe04*/ string get_Name();
            /*0x1fcfe0c*/ string get_LocalName();
            /*0x1fcfe14*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1fcfe1c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1fcfe64*/ bool get_IsReadOnly();
            /*0x1fcfe6c*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x1fcfed8*/ System.Xml.XmlNamedNodeMap get_Notations();
            /*0x1fcff44*/ string get_PublicId();
            /*0x1fcff4c*/ string get_SystemId();
            /*0x1fcff54*/ string get_InternalSubset();
            /*0x1fcff5c*/ bool get_ParseWithNamespaces();
            /*0x1fcff64*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1fcff90*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1fcff94*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x1fcff9c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
        }

        class XmlElement : System.Xml.XmlLinkedNode
        {
            /*0x20*/ System.Xml.XmlName name;
            /*0x28*/ System.Xml.XmlAttributeCollection attributes;
            /*0x30*/ System.Xml.XmlLinkedNode lastChild;

            static /*0x1fd1dc8*/ void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e);
            /*0x1fd0970*/ XmlElement(System.Xml.XmlName name, bool empty, System.Xml.XmlDocument doc);
            /*0x1fd0aa0*/ XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x1fd0ae8*/ System.Xml.XmlName get_XmlName();
            /*0x1fd0af0*/ void set_XmlName(System.Xml.XmlName value);
            /*0x1fd0af8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1fd1094*/ string get_Name();
            /*0x1fd1244*/ string get_LocalName();
            /*0x1fd1260*/ string get_NamespaceURI();
            /*0x1fd127c*/ string get_Prefix();
            /*0x1fd1298*/ void set_Prefix(string value);
            /*0x1fd133c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1fd1344*/ System.Xml.XmlNode get_ParentNode();
            /*0x1fd134c*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1fd1368*/ bool get_IsContainer();
            /*0x1fd1370*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x1fd103c*/ bool get_IsEmpty();
            /*0x1fd104c*/ void set_IsEmpty(bool value);
            /*0x1fd14f8*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1fd1508*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1fd1510*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1fd1534*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x1fd1670*/ bool get_HasAttributes();
            /*0x1fd169c*/ string GetAttribute(string name);
            /*0x1fd172c*/ void SetAttribute(string name, string value);
            /*0x1fd17e8*/ System.Xml.XmlAttribute GetAttributeNode(string name);
            /*0x1fd1854*/ System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr);
            /*0x1fd1970*/ string GetAttribute(string localName, string namespaceURI);
            /*0x1fd1a08*/ string SetAttribute(string localName, string namespaceURI, string value);
            /*0x1fd1b1c*/ System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI);
            /*0x1fd1b9c*/ System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI);
            /*0x1fd1c80*/ bool HasAttribute(string name);
            /*0x1fd1ca8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1fd1fc0*/ void WriteStartElement(System.Xml.XmlWriter w);
            /*0x1fd20e0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1fd214c*/ void RemoveAllAttributes();
            /*0x1fd2198*/ void RemoveAll();
            /*0x1fd14f0*/ void RemoveAllChildren();
            /*0x1fd21cc*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1fd21d4*/ void set_InnerXml(string value);
            /*0x1fd22dc*/ string get_InnerText();
            /*0x1fd22e4*/ void set_InnerText(string value);
            /*0x1fd23ac*/ System.Xml.XmlNode get_NextSibling();
            /*0x1fd23f4*/ void SetParent(System.Xml.XmlNode node);
        }

        class XmlEntity : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string notationName;
            /*0x30*/ string name;
            /*0x38*/ string unparsedReplacementStr;
            /*0x40*/ string baseURI;
            /*0x48*/ System.Xml.XmlLinkedNode lastChild;
            /*0x50*/ bool childrenFoliating;

            /*0x1fd74c8*/ XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, System.Xml.XmlDocument doc);
            /*0x1fd7558*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1fd75b4*/ bool get_IsReadOnly();
            /*0x1fd75bc*/ string get_Name();
            /*0x1fd75c4*/ string get_LocalName();
            /*0x1fd75cc*/ string get_InnerText();
            /*0x1fd75d4*/ void set_InnerText(string value);
            /*0x1fd7630*/ bool get_IsContainer();
            /*0x1fd7638*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1fd7718*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1fd7720*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1fd775c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1fd7764*/ string get_SystemId();
            /*0x1fd776c*/ void set_InnerXml(string value);
            /*0x1fd77c8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1fd77cc*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1fd77d0*/ string get_BaseURI();
            /*0x1fd77d8*/ void SetBaseURI(string inBaseURI);
        }

        class XmlEntityReference : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;

            /*0x1fd77e0*/ XmlEntityReference(string name, System.Xml.XmlDocument doc);
            /*0x1fd78d4*/ string get_Name();
            /*0x1fd78dc*/ string get_LocalName();
            /*0x1fd78e4*/ string get_Value();
            /*0x1fd78ec*/ void set_Value(string value);
            /*0x1fd7948*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1fd7950*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1fd7994*/ bool get_IsReadOnly();
            /*0x1fd799c*/ bool get_IsContainer();
            /*0x1fd79a4*/ void SetParent(System.Xml.XmlNode node);
            /*0x1fd8064*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x1fd8074*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1fd807c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1fd8084*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1fd80a8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1fd80d4*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1fd8394*/ string get_BaseURI();
            /*0x1fd83c8*/ string ConstructBaseURI(string baseURI, string systemId);
            /*0x1fd84ac*/ string get_ChildBaseURI();
        }

        enum XmlNodeChangedAction
        {
            Insert = 0,
            Remove = 1,
            Change = 2,
        }

        class XmlImplementation
        {
            /*0x10*/ System.Xml.XmlNameTable nameTable;

            /*0x1fdad14*/ XmlImplementation();
            /*0x1fdad7c*/ XmlImplementation(System.Xml.XmlNameTable nt);
            /*0x1fdada8*/ System.Xml.XmlDocument CreateDocument();
            /*0x1fdae08*/ System.Xml.XmlNameTable get_NameTable();
        }

        class XmlLinkedNode : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode next;

            /*0x1fcfd68*/ XmlLinkedNode(System.Xml.XmlDocument doc);
            /*0x1fdae18*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x1fdae84*/ System.Xml.XmlNode get_NextSibling();
        }

        class XmlLoader
        {
            /*0x10*/ System.Xml.XmlDocument doc;
            /*0x18*/ System.Xml.XmlReader reader;
            /*0x20*/ bool preserveWhitespace;

            static /*0x1fdece4*/ void ParseXmlDeclarationValue(string strValue, ref string version, ref string encoding, ref string standalone);
            static /*0x1fde28c*/ System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype);
            /*0x1fcfd90*/ XmlLoader();
            /*0x1fdd05c*/ void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, bool preserveWhitespace);
            /*0x1fdd2a0*/ void LoadDocSequence(System.Xml.XmlDocument parentDoc);
            /*0x1fdd8c0*/ System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader);
            /*0x1fdd310*/ System.Xml.XmlNode LoadNode(bool skipOverWhitespace);
            /*0x1fdd9e4*/ System.Xml.XmlAttribute LoadAttributeNode();
            /*0x1fde3c8*/ System.Xml.XmlAttribute LoadDefaultAttribute();
            /*0x1fde568*/ void LoadAttributeValue(System.Xml.XmlNode parent, bool direct);
            /*0x1fddd24*/ System.Xml.XmlEntityReference LoadEntityReferenceNode(bool direct);
            /*0x1fddf1c*/ System.Xml.XmlDeclaration LoadDeclarationNode();
            /*0x1fde0dc*/ System.Xml.XmlDocumentType LoadDocumentTypeNode();
            /*0x1fde878*/ System.Xml.XmlNode LoadNodeDirect();
            /*0x1fdfa84*/ System.Xml.XmlAttribute LoadAttributeNodeDirect();
            /*0x1fcfd98*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode);
            /*0x1fdfbd4*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode, bool bUseResolver, System.Xml.XmlResolver resolver);
            /*0x1fdeef0*/ void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode);
            /*0x1fdfea8*/ System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node);
            /*0x1fe0784*/ System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, string innerxmltext, System.Xml.XmlNodeType nt);
            /*0x1fd2258*/ void LoadInnerXmlElement(System.Xml.XmlElement node, string innerxmltext);
            /*0x1fe0ea0*/ void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, string innerxmltext);
            /*0x1fe0c04*/ void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, bool fCheckElemAttrs);
            /*0x1fe0ea8*/ string EntitizeName(string name);
            /*0x1fd76c8*/ void ExpandEntity(System.Xml.XmlEntity ent);
            /*0x1fd7a70*/ void ExpandEntityReference(System.Xml.XmlEntityReference eref);
            /*0x1fe097c*/ System.Xml.XmlReader CreateInnerXmlReader(string xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc);
        }

        class XmlName : System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x10*/ string prefix;
            /*0x18*/ string localName;
            /*0x20*/ string ns;
            /*0x28*/ string name;
            /*0x30*/ int hashCode;
            /*0x38*/ System.Xml.XmlDocument ownerDoc;
            /*0x40*/ System.Xml.XmlName next;

            static /*0x1fe2d68*/ System.Xml.XmlName Create(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            static /*0x1fe333c*/ int GetHashCode(string name);
            /*0x1fe2e54*/ XmlName(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next);
            /*0x1fe32d0*/ string get_LocalName();
            /*0x1fe32d8*/ string get_NamespaceURI();
            /*0x1fe32e0*/ string get_Prefix();
            /*0x1fe32e8*/ int get_HashCode();
            /*0x1fe32f0*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1fd10ac*/ string get_Name();
            /*0x1fe32f8*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x1fe3300*/ bool get_IsDefault();
            /*0x1fe3308*/ bool get_IsNil();
            /*0x1fe3310*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x1fe3318*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x1fe3320*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x1fe3328*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x1fe3330*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNameEx : System.Xml.XmlName
        {
            /*0x48*/ byte flags;
            /*0x50*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
            /*0x58*/ System.Xml.Schema.XmlSchemaType schemaType;
            /*0x60*/ object decl;

            /*0x1fe2eb8*/ XmlNameEx(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x1fe33f8*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x1fe3428*/ bool get_IsDefault();
            /*0x1fe3434*/ bool get_IsNil();
            /*0x1fe3440*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x1fe3448*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x1fe3450*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x1fe34d0*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x1fe33ac*/ void SetValidity(System.Xml.Schema.XmlSchemaValidity value);
            /*0x1fe33c0*/ void SetIsDefault(bool value);
            /*0x1fe33dc*/ void SetIsNil(bool value);
            /*0x1fe3550*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNamedNodeMap : System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parent;
            /*0x18*/ System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;

            /*0x1b4c0d0*/ XmlNamedNodeMap(System.Xml.XmlNode parent);
            /*0x1b4c0fc*/ System.Xml.XmlNode GetNamedItem(string name);
            /*0x1b4c298*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x1b4c4e4*/ int get_Count();
            /*0x1b4c4f0*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1b4c1a4*/ int FindNodeOffset(string name);
            /*0x1b4c358*/ int FindNodeOffset(string localName, string namespaceURI);
            /*0x1b4c4fc*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x1b4c67c*/ System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc);
            /*0x1b4c72c*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x1b4c48c*/ System.Xml.XmlNode ReplaceNodeAt(int i, System.Xml.XmlNode node);
            /*0x1b4c8ac*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);

            struct SmallXmlNodeList
            {
                /*0x10*/ object field;

                /*0xac10e0*/ int get_Count();
                /*0xac10e8*/ object get_Item(int index);
                /*0xac10f0*/ void Add(object value);
                /*0xac10f8*/ void RemoveAt(int index);
                /*0xac1100*/ void Insert(int index, object value);
                /*0xac1108*/ System.Collections.IEnumerator GetEnumerator();

                class SingleObjectEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ object loneValue;
                    /*0x18*/ int position;

                    /*0x16c6efc*/ SingleObjectEnumerator(object value);
                    /*0x16cdd04*/ object get_Current();
                    /*0x16cdd54*/ bool MoveNext();
                    /*0x16cdd70*/ void Reset();
                }
            }
        }

        class XmlNode : System.ICloneable, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parentNode;

            static /*0x1b4f460*/ bool HasReadOnlyParent(System.Xml.XmlNode n);
            static /*0x1b50028*/ void SplitName(string name, ref string prefix, ref string localName);
            static /*0x1b4e2fc*/ void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            static /*0x1b4e314*/ void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            /*0x1b4d910*/ XmlNode();
            /*0x1b4d918*/ XmlNode(System.Xml.XmlDocument doc);
            string get_Name();
            /*0x1b4d998*/ string get_Value();
            /*0x1b4d9a0*/ void set_Value(string value);
            System.Xml.XmlNodeType get_NodeType();
            /*0x1b4dabc*/ System.Xml.XmlNode get_ParentNode();
            /*0x1b4dbac*/ System.Xml.XmlNodeList get_ChildNodes();
            /*0x1b4dc0c*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x1b4dc14*/ System.Xml.XmlNode get_NextSibling();
            /*0x1b4dc1c*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x1b4dc24*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x1b4dce8*/ System.Xml.XmlNode get_FirstChild();
            /*0x1b4dd10*/ System.Xml.XmlNode get_LastChild();
            /*0x1b4dd20*/ bool get_IsContainer();
            /*0x1b4dd28*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x1b4dd30*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x1b4dd34*/ bool AncestorNode(System.Xml.XmlNode node);
            /*0x1b4dd94*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1b4e34c*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1b4e89c*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x1b4ec08*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x1b4ec54*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x1b4f108*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x1b4f2b0*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x1b4f2b8*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1b4f2c0*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1b4f2c8*/ bool get_HasChildNodes();
            System.Xml.XmlNode CloneNode(bool deep);
            /*0x1b4f2f0*/ void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, bool deep);
            /*0x1b4f394*/ string get_NamespaceURI();
            /*0x1b4f3e0*/ string get_Prefix();
            /*0x1b4f42c*/ void set_Prefix(string value);
            string get_LocalName();
            /*0x1b4f430*/ bool get_IsReadOnly();
            /*0x1b4f530*/ object System.ICloneable.Clone();
            /*0x1b4f544*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1b4f5a4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1b4f604*/ void AppendChildText(System.Text.StringBuilder builder);
            /*0x1b4f70c*/ string get_InnerText();
            /*0x1b4f818*/ void set_InnerText(string value);
            /*0x1b4f8f4*/ void set_InnerXml(string value);
            /*0x1b4f950*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1b4f9b4*/ string get_BaseURI();
            void WriteTo(System.Xml.XmlWriter w);
            void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1b4fadc*/ void RemoveAll();
            /*0x1b4fb50*/ System.Xml.XmlDocument get_Document();
            /*0x1b4fc00*/ string GetPrefixOfNamespace(string namespaceURI);
            /*0x1b4fc6c*/ string GetPrefixOfNamespaceStrict(string namespaceURI);
            /*0x1b4ffe4*/ void SetParent(System.Xml.XmlNode node);
            /*0x1b50020*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x1b500f8*/ System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type);
            /*0x1b50160*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x1b50294*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x1b502e8*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x1b5033c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1b504c8*/ string get_XmlLang();
            /*0x1b505d0*/ bool get_IsText();
        }

        class XmlNodeChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Xml.XmlNodeChangedAction action;
            /*0x18*/ System.Xml.XmlNode node;
            /*0x20*/ System.Xml.XmlNode oldParent;
            /*0x28*/ System.Xml.XmlNode newParent;
            /*0x30*/ string oldValue;
            /*0x38*/ string newValue;

            /*0x1b505d8*/ XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x1b50680*/ System.Xml.XmlNodeChangedAction get_Action();
        }

        class XmlNodeChangedEventHandler : System.MulticastDelegate
        {
            /*0x1b50688*/ XmlNodeChangedEventHandler(object object, nint method);
            /*0x1b506e8*/ void Invoke(object sender, System.Xml.XmlNodeChangedEventArgs e);
            /*0x1b50a7c*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.XmlNodeChangedEventArgs e, System.AsyncCallback callback, object object);
            /*0x1b50aac*/ void EndInvoke(System.IAsyncResult result);
        }

        class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
        {
            /*0x1b50f94*/ XmlNodeList();
            System.Xml.XmlNode Item(int index);
            int get_Count();
            System.Collections.IEnumerator GetEnumerator();
            /*0x1b50f78*/ System.Xml.XmlNode get_ItemOf(int i);
            /*0x1b50f84*/ void System.IDisposable.Dispose();
            /*0x1b50f90*/ void PrivateDisposeNodeList();
        }

        class XmlNodeReaderNavigator
        {
            /*0x10*/ System.Xml.XmlNode curNode;
            /*0x18*/ System.Xml.XmlNode elemNode;
            /*0x20*/ System.Xml.XmlNode logNode;
            /*0x28*/ int attrIndex;
            /*0x2c*/ int logAttrIndex;
            /*0x30*/ System.Xml.XmlNameTable nameTable;
            /*0x38*/ System.Xml.XmlDocument doc;
            /*0x40*/ int nAttrInd;
            /*0x44*/ int nDeclarationAttrCount;
            /*0x48*/ int nDocTypeAttrCount;
            /*0x4c*/ int nLogLevel;
            /*0x50*/ int nLogAttrInd;
            /*0x54*/ bool bLogOnAttrVal;
            /*0x55*/ bool bCreatedOnAttribute;
            /*0x58*/ System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes;
            /*0x60*/ System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes;
            /*0x68*/ bool bOnAttrVal;

            /*0x1b51094*/ XmlNodeReaderNavigator(System.Xml.XmlNode node);
            /*0x1b5292c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1b51634*/ string get_NamespaceURI();
            /*0x1b5138c*/ string get_Name();
            /*0x1b514fc*/ string get_LocalName();
            /*0x1b54c2c*/ bool get_CreatedOnAttribute();
            /*0x1b54c08*/ bool IsLocalNameEmpty(System.Xml.XmlNodeType nt);
            /*0x1b516e0*/ string get_Prefix();
            /*0x1b51778*/ string get_Value();
            /*0x1b51a44*/ string get_BaseURI();
            /*0x1b51ca0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1b51d4c*/ string get_XmlLang();
            /*0x1b51a9c*/ bool get_IsEmptyElement();
            /*0x1b51b78*/ bool get_IsDefault();
            /*0x1b51db8*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1b54dc0*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1b51e14*/ int get_AttributeCount();
            /*0x1b54ed8*/ void CheckIndexCondition(int attributeIndex);
            /*0x1b54c34*/ void InitDecAttr();
            /*0x1b54f4c*/ string GetDeclarationAttr(System.Xml.XmlDeclaration decl, string name);
            /*0x1b55030*/ string GetDeclarationAttr(int i);
            /*0x1b55090*/ int GetDecAttrInd(string name);
            /*0x1b54dc8*/ void InitDocTypeAttr();
            /*0x1b55134*/ string GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, string name);
            /*0x1b551e4*/ string GetDocumentTypeAttr(int i);
            /*0x1b55244*/ int GetDocTypeAttrInd(string name);
            /*0x1b552e8*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name);
            /*0x1b51fa8*/ string GetAttribute(string name);
            /*0x1b55330*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x1b521f4*/ string GetAttribute(string name, string ns);
            /*0x1b52440*/ string GetAttribute(int attributeIndex);
            /*0x1b52f68*/ void LogMove(int level);
            /*0x1b529a0*/ void RollBackMove(ref int level);
            /*0x1b5537c*/ bool get_IsOnDeclOrDocType();
            /*0x1b52f8c*/ void ResetToAttribute(ref int level);
            /*0x1b526fc*/ void ResetMove(ref int level, ref System.Xml.XmlNodeType nt);
            /*0x1b528c8*/ bool MoveToAttribute(string name);
            /*0x1b55514*/ bool MoveToAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x1b553b8*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x1b52bb8*/ void MoveToAttribute(int attributeIndex);
            /*0x1b53024*/ bool MoveToNextAttribute(ref int level);
            /*0x1b53870*/ bool MoveToParent();
            /*0x1b53654*/ bool MoveToFirstChild();
            /*0x1b555d8*/ bool MoveToNextSibling(System.Xml.XmlNode node);
            /*0x1b53824*/ bool MoveToNext();
            /*0x1b532d8*/ bool MoveToElement();
            /*0x1b53c00*/ string LookupNamespace(string prefix);
            /*0x1b54a98*/ string DefaultLookupNamespace(string prefix);
            /*0x1b5465c*/ string LookupPrefix(string namespaceName);
            /*0x1b5416c*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1b53f90*/ bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref System.Xml.XmlNodeType nt);
            /*0x1b55630*/ System.Xml.XmlDocument get_Document();

            struct VirtualAttribute
            {
                /*0x10*/ string name;
                /*0x18*/ string value;

                /*0xac1284*/ VirtualAttribute(string name, string value);
            }
        }

        class XmlNodeReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlNodeReaderNavigator readerNav;
            /*0x18*/ System.Xml.XmlNodeType nodeType;
            /*0x1c*/ int curDepth;
            /*0x20*/ System.Xml.ReadState readState;
            /*0x24*/ bool fEOF;
            /*0x25*/ bool bResolveEntity;
            /*0x26*/ bool bStartFromDocument;
            /*0x27*/ bool bInReadBinary;
            /*0x28*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;

            /*0x1b50f9c*/ XmlNodeReader(System.Xml.XmlNode node);
            /*0x1b512ec*/ bool IsInReadingStates();
            /*0x1b512fc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1b51318*/ string get_Name();
            /*0x1b51488*/ string get_LocalName();
            /*0x1b515ac*/ string get_NamespaceURI();
            /*0x1b51658*/ string get_Prefix();
            /*0x1b51704*/ string get_Value();
            /*0x1b51a0c*/ int get_Depth();
            /*0x1b51a14*/ string get_BaseURI();
            /*0x1b51a68*/ bool get_CanResolveEntity();
            /*0x1b51a70*/ bool get_IsEmptyElement();
            /*0x1b51b4c*/ bool get_IsDefault();
            /*0x1b51c58*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x1b51cc4*/ string get_XmlLang();
            /*0x1b51d70*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x1b51ddc*/ int get_AttributeCount();
            /*0x1b51f7c*/ string GetAttribute(string name);
            /*0x1b5215c*/ string GetAttribute(string name, string namespaceURI);
            /*0x1b523c8*/ string GetAttribute(int attributeIndex);
            /*0x1b52628*/ bool MoveToAttribute(string name);
            /*0x1b529cc*/ void MoveToAttribute(int attributeIndex);
            /*0x1b52d98*/ bool MoveToFirstAttribute();
            /*0x1b52e78*/ bool MoveToNextAttribute();
            /*0x1b531ec*/ bool MoveToElement();
            /*0x1b53364*/ bool Read();
            /*0x1b5336c*/ bool Read(bool fSkipChildren);
            /*0x1b53474*/ bool ReadNextNode(bool fSkipChildren);
            /*0x1b53790*/ void SetEndOfFile();
            /*0x1b537a8*/ bool ReadAtZeroLevel(bool fSkipChildren);
            /*0x1b536a8*/ bool ReadForward(bool fSkipChildren);
            /*0x1b53630*/ void ReSetReadingMarks();
            /*0x1b538bc*/ bool get_EOF();
            /*0x1b538e0*/ void Close();
            /*0x1b538ec*/ System.Xml.ReadState get_ReadState();
            /*0x1b538f4*/ void Skip();
            /*0x1b538fc*/ string ReadString();
            /*0x1b53b80*/ bool get_HasAttributes();
            /*0x1b53ba8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1b53bc4*/ string LookupNamespace(string prefix);
            /*0x1b53eb8*/ void ResolveEntity();
            /*0x1b53f38*/ bool ReadAttributeValue();
            /*0x1b5297c*/ void FinishReadBinary();
            /*0x1b54154*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1b54644*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x1b54a28*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x1b54be0*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlNotation : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string name;

            /*0x1b55638*/ XmlNotation(string name, string publicId, string systemId, System.Xml.XmlDocument doc);
            /*0x1b556ac*/ string get_Name();
            /*0x1b556b4*/ string get_LocalName();
            /*0x1b556bc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1b556c4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1b55720*/ bool get_IsReadOnly();
            /*0x1b55728*/ void set_InnerXml(string value);
            /*0x1b55784*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1b55788*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlProcessingInstruction : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string target;
            /*0x28*/ string data;

            /*0x1b5bec8*/ XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc);
            /*0x1b5bf04*/ string get_Name();
            /*0x1b5bf5c*/ string get_LocalName();
            /*0x1b5bf68*/ string get_Value();
            /*0x1b5bf70*/ void set_Value(string value);
            /*0x1b5bf74*/ void set_Data(string value);
            /*0x1b5c024*/ string get_InnerText();
            /*0x1b5c02c*/ void set_InnerText(string value);
            /*0x1b5c030*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1b5c038*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1b5c07c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1b5c0a8*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlSignificantWhitespace : System.Xml.XmlCharacterData
        {
            /*0x20d67a0*/ XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x20d6848*/ string get_Name();
            /*0x20d6874*/ string get_LocalName();
            /*0x20d68a0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x20d68a8*/ System.Xml.XmlNode get_ParentNode();
            /*0x20d6944*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x20d69a4*/ string get_Value();
            /*0x20d69b4*/ void set_Value(string value);
            /*0x20d6a44*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x20d6a90*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x20d6a94*/ bool get_IsText();
        }

        class XmlText : System.Xml.XmlCharacterData
        {
            /*0x2399454*/ XmlText(string strData);
            /*0x2399460*/ XmlText(string strData, System.Xml.XmlDocument doc);
            /*0x2399468*/ string get_Name();
            /*0x2399494*/ string get_LocalName();
            /*0x23994c0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x23994c8*/ System.Xml.XmlNode get_ParentNode();
            /*0x2399558*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x23995b8*/ string get_Value();
            /*0x23995c8*/ void set_Value(string value);
            /*0x23996a8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x23996f4*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x23996f8*/ bool get_IsText();
        }

        class XmlUnspecifiedAttribute : System.Xml.XmlAttribute
        {
            /*0x28*/ bool fSpecified;

            /*0x1bcd4d0*/ XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x1bcd4d8*/ bool get_Specified();
            /*0x1bcd4e0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1bcd614*/ void set_InnerText(string value);
            /*0x1bcd640*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1bcd66c*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x1bcd698*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x1bcd6c4*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x1bcd6f0*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1bcd704*/ void SetSpecified(bool f);
        }

        class XmlWhitespace : System.Xml.XmlCharacterData
        {
            /*0x1a4ddd4*/ XmlWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x1a4de7c*/ string get_Name();
            /*0x1a4dea8*/ string get_LocalName();
            /*0x1a4ded4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x1a4dedc*/ System.Xml.XmlNode get_ParentNode();
            /*0x1a4df78*/ string get_Value();
            /*0x1a4df88*/ void set_Value(string value);
            /*0x1a4e018*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x1a4e078*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1a4e0c4*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x1a4e0c8*/ bool get_IsText();
        }

        class EmptyEnumerator : System.Collections.IEnumerator
        {
            /*0x14c9124*/ EmptyEnumerator();
            /*0x14c90bc*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x14c90c4*/ void System.Collections.IEnumerator.Reset();
            /*0x14c90c8*/ object System.Collections.IEnumerator.get_Current();
        }

        class HWStack : System.ICloneable
        {
            /*0x10*/ object[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int used;
            /*0x20*/ int size;
            /*0x24*/ int limit;

            /*0x14c6258*/ HWStack(int GrowthRate);
            /*0x14ca5bc*/ HWStack(int GrowthRate, int limit);
            /*0x14ca780*/ HWStack(object[] stack, int growthRate, int used, int size);
            /*0x14c7f64*/ object Push();
            /*0x14c8128*/ object Pop();
            /*0x14c817c*/ object Peek();
            /*0x14c80a8*/ void AddToTop(object o);
            /*0x14ca634*/ object get_Item(int index);
            /*0x14ca6bc*/ void set_Item(int index, object value);
            /*0x14ca778*/ int get_Length();
            /*0x14ca7d0*/ object Clone();
        }

        interface IXmlLineInfo
        {
            bool HasLineInfo();
            int get_LineNumber();
            int get_LinePosition();
        }

        class PositionInfo : System.Xml.IXmlLineInfo
        {
            static /*0x14d54b4*/ System.Xml.PositionInfo GetPositionInfo(object o);
            /*0x14d8260*/ PositionInfo();
            /*0x14d8248*/ bool HasLineInfo();
            /*0x14d8250*/ int get_LineNumber();
            /*0x14d8258*/ int get_LinePosition();
        }

        class ReaderPositionInfo : System.Xml.PositionInfo
        {
            /*0x10*/ System.Xml.IXmlLineInfo lineInfo;

            /*0x18250d0*/ ReaderPositionInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x18250fc*/ bool HasLineInfo();
            /*0x18251a8*/ int get_LineNumber();
            /*0x1825258*/ int get_LinePosition();
        }

        interface IXmlNamespaceResolver
        {
            System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            string LookupNamespace(string prefix);
            string LookupPrefix(string namespaceName);
        }

        struct LineInfo
        {
            /*0x10*/ int lineNo;
            /*0x14*/ int linePos;

            /*0xaa2cc8*/ LineInfo(int lineNo, int linePos);
            /*0xaa2cd0*/ void Set(int lineNo, int linePos);
        }

        class NameTable : System.Xml.XmlNameTable
        {
            /*0x10*/ System.Xml.NameTable.Entry[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ int hashCodeRandomizer;

            static /*0x14d07c8*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x14d0330*/ NameTable();
            /*0x14d03a4*/ string Add(string key);
            /*0x14d0648*/ string Add(char[] key, int start, int len);
            /*0x14d0888*/ string Get(string value);
            /*0x14d0528*/ string AddEntry(string str, int hashCode);
            /*0x14d09f8*/ void Grow();

            class Entry
            {
                /*0x10*/ string str;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.NameTable.Entry next;

                /*0x16c4488*/ Entry(string str, int hashCode, System.Xml.NameTable.Entry next);
            }
        }

        class Ref
        {
            static /*0x1825340*/ bool Equal(string strA, string strB);
        }

        class DtdParser : System.Xml.IDtdParser
        {
            /*0x10*/ System.Xml.IDtdParserAdapter readerAdapter;
            /*0x18*/ System.Xml.IDtdParserAdapterWithValidation readerAdapterWithValidation;
            /*0x20*/ System.Xml.XmlNameTable nameTable;
            /*0x28*/ System.Xml.Schema.SchemaInfo schemaInfo;
            /*0x30*/ System.Xml.XmlCharType xmlCharType;
            /*0x38*/ string systemId;
            /*0x40*/ string publicId;
            /*0x48*/ bool normalize;
            /*0x49*/ bool validate;
            /*0x4a*/ bool supportNamespaces;
            /*0x4b*/ bool v1Compat;
            /*0x50*/ char[] chars;
            /*0x58*/ int charsUsed;
            /*0x5c*/ int curPos;
            /*0x60*/ System.Xml.DtdParser.ScanningFunction scanningFunction;
            /*0x64*/ System.Xml.DtdParser.ScanningFunction nextScaningFunction;
            /*0x68*/ System.Xml.DtdParser.ScanningFunction savedScanningFunction;
            /*0x6c*/ bool whitespaceSeen;
            /*0x70*/ int tokenStartPos;
            /*0x74*/ int colonPos;
            /*0x78*/ System.Text.StringBuilder internalSubsetValueSb;
            /*0x80*/ int externalEntitiesDepth;
            /*0x84*/ int currentEntityId;
            /*0x88*/ bool freeFloatingDtd;
            /*0x89*/ bool hasFreeFloatingInternalSubset;
            /*0x90*/ System.Text.StringBuilder stringBuilder;
            /*0x98*/ int condSectionDepth;
            /*0x9c*/ System.Xml.LineInfo literalLineInfo;
            /*0xa4*/ char literalQuoteChar;
            /*0xa8*/ string documentBaseUri;
            /*0xb0*/ string externalDtdBaseUri;
            /*0xb8*/ System.Collections.Generic.Dictionary<string, System.Xml.DtdParser.UndeclaredNotation> undeclaredNotations;
            /*0xc0*/ int[] condSectionEntityIds;

            static /*0x1c01fb4*/ System.Xml.IDtdParser Create();
            static /*0x1c0bfd0*/ string StripSpaces(string value);
            /*0x1c01ee4*/ DtdParser();
            /*0x1c02008*/ void Initialize(System.Xml.IDtdParserAdapter readerAdapter);
            /*0x1c02404*/ void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x1c028a8*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x1c02ae4*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x1c02b14*/ bool get_ParsingInternalSubset();
            /*0x1c02b24*/ bool get_IgnoreEntityReferences();
            /*0x1c02b34*/ bool get_SaveInternalSubsetValue();
            /*0x1c02c00*/ bool get_ParsingTopLevelMarkup();
            /*0x1c02c30*/ bool get_SupportNamespaces();
            /*0x1c02c38*/ bool get_Normalize();
            /*0x1c028dc*/ void Parse(bool saveInternalSubset);
            /*0x1c02ca4*/ void ParseInDocumentDtd(bool saveInternalSubset);
            /*0x1c02c40*/ void ParseFreeFloatingDtd();
            /*0x1c04214*/ void ParseInternalSubset();
            /*0x1c04218*/ void ParseExternalSubset();
            /*0x1c043e4*/ void ParseSubset();
            /*0x1c0473c*/ void ParseAttlistDecl();
            /*0x1c06294*/ void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, bool ignoreErrors);
            /*0x1c06804*/ void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, bool ignoreErrors);
            /*0x1c04d14*/ void ParseElementDecl();
            /*0x1c06fb0*/ void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x1c07304*/ void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv);
            /*0x1c06d0c*/ void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x1c050d0*/ void ParseEntityDecl();
            /*0x1c05428*/ void ParseNotationDecl();
            /*0x1c06ab0*/ void AddUndeclaredNotation(string notationName);
            /*0x1c0562c*/ void ParseComment();
            /*0x1c058a4*/ void ParsePI();
            /*0x1c05a90*/ void ParseCondSection();
            /*0x1c03ce8*/ void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, ref string publicId, ref string systemId);
            /*0x1c03230*/ System.Xml.DtdParser.Token GetToken(bool needWhiteSpace);
            /*0x1c07b8c*/ System.Xml.DtdParser.Token ScanSubsetContent();
            /*0x1c07b00*/ System.Xml.DtdParser.Token ScanNameExpected();
            /*0x1c07b30*/ System.Xml.DtdParser.Token ScanQNameExpected();
            /*0x1c07b60*/ System.Xml.DtdParser.Token ScanNmtokenExpected();
            /*0x1c082b4*/ System.Xml.DtdParser.Token ScanDoctype1();
            /*0x1c083ec*/ System.Xml.DtdParser.Token ScanDoctype2();
            /*0x1c0a7c4*/ System.Xml.DtdParser.Token ScanClosingTag();
            /*0x1c084a0*/ System.Xml.DtdParser.Token ScanElement1();
            /*0x1c08684*/ System.Xml.DtdParser.Token ScanElement2();
            /*0x1c08834*/ System.Xml.DtdParser.Token ScanElement3();
            /*0x1c088c8*/ System.Xml.DtdParser.Token ScanElement4();
            /*0x1c089a0*/ System.Xml.DtdParser.Token ScanElement5();
            /*0x1c08a98*/ System.Xml.DtdParser.Token ScanElement6();
            /*0x1c08b74*/ System.Xml.DtdParser.Token ScanElement7();
            /*0x1c08be0*/ System.Xml.DtdParser.Token ScanAttlist1();
            /*0x1c08cb0*/ System.Xml.DtdParser.Token ScanAttlist2();
            /*0x1c0934c*/ System.Xml.DtdParser.Token ScanAttlist3();
            /*0x1c093f8*/ System.Xml.DtdParser.Token ScanAttlist4();
            /*0x1c094d4*/ System.Xml.DtdParser.Token ScanAttlist5();
            /*0x1c095b0*/ System.Xml.DtdParser.Token ScanAttlist6();
            /*0x1c09938*/ System.Xml.DtdParser.Token ScanAttlist7();
            /*0x1c0ae70*/ System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType);
            /*0x1c0b968*/ System.Xml.XmlQualifiedName ScanEntityName();
            /*0x1c09a00*/ System.Xml.DtdParser.Token ScanNotation1();
            /*0x1c09b0c*/ System.Xml.DtdParser.Token ScanSystemId();
            /*0x1c09d08*/ System.Xml.DtdParser.Token ScanEntity1();
            /*0x1c09d90*/ System.Xml.DtdParser.Token ScanEntity2();
            /*0x1c09ed0*/ System.Xml.DtdParser.Token ScanEntity3();
            /*0x1c09bcc*/ System.Xml.DtdParser.Token ScanPublicId1();
            /*0x1c09c8c*/ System.Xml.DtdParser.Token ScanPublicId2();
            /*0x1c09ff8*/ System.Xml.DtdParser.Token ScanCondSection1();
            /*0x1c0a2a8*/ System.Xml.DtdParser.Token ScanCondSection2();
            /*0x1c0a34c*/ System.Xml.DtdParser.Token ScanCondSection3();
            /*0x1c0aaf8*/ void ScanName();
            /*0x1c0ab00*/ void ScanQName();
            /*0x1c0bcf4*/ void ScanQName(bool isQName);
            /*0x1c0bf88*/ bool ReadDataInName();
            /*0x1c0ab08*/ void ScanNmtoken();
            /*0x1c0ac80*/ bool EatPublicKeyword();
            /*0x1c0ad78*/ bool EatSystemKeyword();
            /*0x1c03b6c*/ System.Xml.XmlQualifiedName GetNameQualified(bool canHavePrefix);
            /*0x1c06a94*/ string GetNameString();
            /*0x1c06c18*/ string GetNmtokenString();
            /*0x1c06ca0*/ string GetValue();
            /*0x1c06c34*/ string GetValueWithStrippedSpaces();
            /*0x1c0a864*/ int ReadData();
            /*0x1c03090*/ void LoadParsingBuffer();
            /*0x1c0420c*/ void SaveParsingBuffer();
            /*0x1c05dd0*/ void SaveParsingBuffer(int internalSubsetValueEndPos);
            /*0x1c079e4*/ bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x1c0c1f4*/ bool HandleEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x1c0a934*/ bool HandleEntityEnd(bool inLiteral);
            /*0x1c0bad8*/ System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute);
            /*0x1c05cf8*/ void SendValidationEvent(int pos, System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x1c069d0*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x1c02f38*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e);
            /*0x1c069c4*/ bool IsAttributeValueType(System.Xml.DtdParser.Token token);
            /*0x1c05f40*/ int get_LineNo();
            /*0x1c05ff0*/ int get_LinePos();
            /*0x1c02e00*/ string get_BaseUriStr();
            /*0x1c03b1c*/ void OnUnexpectedError();
            /*0x1c05a24*/ void Throw(int curPos, string res);
            /*0x1c0738c*/ void Throw(int curPos, string res, string arg);
            /*0x1c07758*/ void Throw(int curPos, string res, string[] args);
            /*0x1c060ac*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x1c02828*/ void ThrowInvalidChar(int pos, string data, int invCharPos);
            /*0x1c07960*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x1c05f38*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x1c07594*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x1c07a38*/ string ParseUnexpectedToken(int startPos);

            enum Token
            {
                CDATA = 0,
                ID = 1,
                IDREF = 2,
                IDREFS = 3,
                ENTITY = 4,
                ENTITIES = 5,
                NMTOKEN = 6,
                NMTOKENS = 7,
                NOTATION = 8,
                None = 9,
                PERef = 10,
                AttlistDecl = 11,
                ElementDecl = 12,
                EntityDecl = 13,
                NotationDecl = 14,
                Comment = 15,
                PI = 16,
                CondSectionStart = 17,
                CondSectionEnd = 18,
                Eof = 19,
                REQUIRED = 20,
                IMPLIED = 21,
                FIXED = 22,
                QName = 23,
                Name = 24,
                Nmtoken = 25,
                Quote = 26,
                LeftParen = 27,
                RightParen = 28,
                GreaterThan = 29,
                Or = 30,
                LeftBracket = 31,
                RightBracket = 32,
                PUBLIC = 33,
                SYSTEM = 34,
                Literal = 35,
                DOCTYPE = 36,
                NData = 37,
                Percent = 38,
                Star = 39,
                QMark = 40,
                Plus = 41,
                PCDATA = 42,
                Comma = 43,
                ANY = 44,
                EMPTY = 45,
                IGNORE = 46,
                INCLUDE = 47,
            }

            enum ScanningFunction
            {
                SubsetContent = 0,
                Name = 1,
                QName = 2,
                Nmtoken = 3,
                Doctype1 = 4,
                Doctype2 = 5,
                Element1 = 6,
                Element2 = 7,
                Element3 = 8,
                Element4 = 9,
                Element5 = 10,
                Element6 = 11,
                Element7 = 12,
                Attlist1 = 13,
                Attlist2 = 14,
                Attlist3 = 15,
                Attlist4 = 16,
                Attlist5 = 17,
                Attlist6 = 18,
                Attlist7 = 19,
                Entity1 = 20,
                Entity2 = 21,
                Entity3 = 22,
                Notation1 = 23,
                CondSection1 = 24,
                CondSection2 = 25,
                CondSection3 = 26,
                Literal = 27,
                SystemId = 28,
                PublicId1 = 29,
                PublicId2 = 30,
                ClosingTag = 31,
                ParamEntitySpace = 32,
                None = 33,
            }

            enum LiteralType
            {
                AttributeValue = 0,
                EntityReplText = 1,
                SystemOrPublicID = 2,
            }

            class UndeclaredNotation
            {
                /*0x10*/ string name;
                /*0x18*/ int lineNo;
                /*0x1c*/ int linePos;
                /*0x20*/ System.Xml.DtdParser.UndeclaredNotation next;

                /*0x16c11c0*/ UndeclaredNotation(string name, int lineNo, int linePos);
            }

            class ParseElementOnlyContent_LocalFrame
            {
                /*0x10*/ int startParenEntityId;
                /*0x14*/ System.Xml.DtdParser.Token parsingSchema;

                /*0x16c1190*/ ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam);
            }
        }

        enum XmlTokenizedType
        {
            CDATA = 0,
            ID = 1,
            IDREF = 2,
            IDREFS = 3,
            ENTITY = 4,
            ENTITIES = 5,
            NMTOKEN = 6,
            NMTOKENS = 7,
            NOTATION = 8,
            ENUMERATION = 9,
            QName = 10,
            NCName = 11,
            None = 12,
        }

        class ValidateNames
        {
            static /*0x0*/ System.Xml.XmlCharType xmlCharType;

            static /*0x1b1b308*/ ValidateNames();
            static /*0x1b1a658*/ int ParseNmtoken(string s, int offset);
            static /*0x1b1a740*/ int ParseNmtokenNoNamespaces(string s, int offset);
            static /*0x1b1a844*/ int ParseNameNoNamespaces(string s, int offset);
            static /*0x1b1a9c8*/ bool IsNameNoNamespaces(string s);
            static /*0x1b1aa54*/ int ParseNCName(string s, int offset);
            static /*0x1b1ab9c*/ int ParseNCName(string s);
            static /*0x1b1ac00*/ int ParseQName(string s, int offset, ref int colonOffset);
            static /*0x1b1acf8*/ void ParseQNameThrow(string s, ref string prefix, ref string localName);
            static /*0x1b1ae1c*/ void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar);
            static /*0x1b1afc8*/ System.Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar);
            static /*0x1b1b1b4*/ void SplitQName(string name, ref string prefix, ref string lname);
        }

        struct XmlCharType
        {
            static /*0x0*/ object s_Lock;
            static /*0x8*/ byte[] s_CharProperties;
            /*0x10*/ byte[] charProperties;

            static /*0x1d5fb48*/ object get_StaticLock();
            static /*0x1d5fbe0*/ void InitInstance();
            static /*0x1d5fdfc*/ void SetProperties(string ranges, byte value);
            static /*0x1d57ad4*/ System.Xml.XmlCharType get_Instance();
            static /*0x1d60200*/ bool IsDigit(char ch);
            static /*0x1d60228*/ bool IsHighSurrogate(int ch);
            static /*0x1d60238*/ bool IsLowSurrogate(int ch);
            static /*0x1d60248*/ bool IsSurrogate(int ch);
            static /*0x1d60258*/ int CombineSurrogateChar(int lowChar, int highChar);
            static /*0x1d60270*/ void SplitSurrogateChar(int combinedChar, ref char lowChar, ref char highChar);
            static /*0x1d60428*/ bool IsOnlyDigits(string str, int startPos, int len);
            static /*0x1d60214*/ bool InRange(int value, int start, int end);
            /*0xadc7d0*/ XmlCharType(byte[] charProperties);
            /*0xadc7d8*/ bool IsWhiteSpace(char ch);
            /*0xadc7e0*/ bool IsNCNameSingleChar(char ch);
            /*0xadc7e8*/ bool IsStartNCNameSingleChar(char ch);
            /*0xadc7f0*/ bool IsNameSingleChar(char ch);
            /*0xadc824*/ bool IsCharData(char ch);
            /*0xadc82c*/ bool IsPubidChar(char ch);
            /*0xadc830*/ bool IsTextChar(char ch);
            /*0xadc838*/ bool IsLetter(char ch);
            /*0xadc840*/ bool IsNCNameCharXml4e(char ch);
            /*0xadc848*/ bool IsStartNCNameCharXml4e(char ch);
            /*0xadc87c*/ bool IsNameCharXml4e(char ch);
            /*0xadc8b0*/ bool IsOnlyWhitespace(string str);
            /*0xadc8d0*/ int IsOnlyWhitespaceWithPos(string str);
            /*0xadc8d8*/ int IsOnlyCharData(string str);
            /*0xadc8e0*/ int IsPublicId(string str);
        }

        class XmlComplianceUtil
        {
            static /*0x1d60b38*/ string NonCDataNormalize(string value);
            static /*0x1d60dc4*/ string CDataNormalize(string value);
        }

        enum ExceptionType
        {
            ArgumentException = 0,
            XmlException = 1,
        }

        enum XmlDateTimeSerializationMode
        {
            Local = 0,
            Utc = 1,
            Unspecified = 2,
            RoundtripKind = 3,
        }

        class XmlConvert
        {
            static /*0x0*/ System.Xml.XmlCharType xmlCharType;
            static /*0x8*/ char[] crt;
            static /*0x10*/ int c_EncodedCharLength;
            static /*0x18*/ System.Text.RegularExpressions.Regex c_EncodeCharPattern;
            static /*0x20*/ System.Text.RegularExpressions.Regex c_DecodeCharPattern;
            static /*0x28*/ string[] s_allDateTimeFormats;
            static /*0x30*/ char[] WhitespaceChars;

            static /*0x1d67e64*/ XmlConvert();
            static /*0x1d60fb4*/ string EncodeName(string name);
            static /*0x1d61a84*/ string EncodeLocalName(string name);
            static /*0x1d61aec*/ string DecodeName(string name);
            static /*0x1d6101c*/ string EncodeName(string name, bool first, bool local);
            static /*0x1d624a4*/ int FromHex(char digit);
            static /*0x1d624d4*/ byte[] FromBinHexString(string s);
            static /*0x1d5be58*/ byte[] FromBinHexString(string s, bool allowOddCount);
            static /*0x1d62538*/ string ToBinHexString(byte[] inArray);
            static /*0x1d625a0*/ string VerifyName(string name);
            static /*0x1d627fc*/ System.Exception TryVerifyName(string name);
            static /*0x1d62968*/ string VerifyQName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x1d62bac*/ string VerifyNCName(string name);
            static /*0x1d62c10*/ string VerifyNCName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x1d62da4*/ System.Exception TryVerifyNCName(string name);
            static /*0x1d62e6c*/ string VerifyTOKEN(string token);
            static /*0x1d62fb0*/ System.Exception TryVerifyTOKEN(string token);
            static /*0x1d630f4*/ System.Exception TryVerifyNMTOKEN(string name);
            static /*0x1d63238*/ System.Exception TryVerifyNormalizedString(string str);
            static /*0x1d5e71c*/ string ToString(bool value);
            static /*0x1d6330c*/ string ToString(char value);
            static /*0x1d5cdd0*/ string ToString(decimal value);
            static /*0x1d63338*/ string ToString(sbyte value);
            static /*0x1d63370*/ string ToString(short value);
            static /*0x1d5d364*/ string ToString(int value);
            static /*0x1d5d868*/ string ToString(long value);
            static /*0x1d633a8*/ string ToString(byte value);
            static /*0x1d633e0*/ string ToString(ushort value);
            static /*0x1d63418*/ string ToString(uint value);
            static /*0x1d63450*/ string ToString(ulong value);
            static /*0x1d63488*/ string ToString(float value);
            static /*0x1d63628*/ string ToString(double value);
            static /*0x1d63780*/ string ToString(System.TimeSpan value);
            static /*0x1d637dc*/ string ToString(System.DateTime value, string format);
            static /*0x1d63860*/ string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x1d63b5c*/ string ToString(System.DateTimeOffset value);
            static /*0x1d63b98*/ string ToString(System.Guid value);
            static /*0x1d5e1c4*/ bool ToBoolean(string s);
            static /*0x1d63bc0*/ System.Exception TryToBoolean(string s, ref bool result);
            static /*0x1d63df4*/ char ToChar(string s);
            static /*0x1d63ebc*/ System.Exception TryToChar(string s, ref char result);
            static /*0x1d64040*/ decimal ToDecimal(string s);
            static /*0x1d640bc*/ System.Exception TryToDecimal(string s, ref decimal result);
            static /*0x1d64258*/ decimal ToInteger(string s);
            static /*0x1d642d4*/ System.Exception TryToInteger(string s, ref decimal result);
            static /*0x1d64470*/ sbyte ToSByte(string s);
            static /*0x1d644a4*/ System.Exception TryToSByte(string s, ref sbyte result);
            static /*0x1d6460c*/ short ToInt16(string s);
            static /*0x1d64640*/ System.Exception TryToInt16(string s, ref short result);
            static /*0x1d647a8*/ int ToInt32(string s);
            static /*0x1d647dc*/ System.Exception TryToInt32(string s, ref int result);
            static /*0x1d64944*/ long ToInt64(string s);
            static /*0x1d64978*/ System.Exception TryToInt64(string s, ref long result);
            static /*0x1d64ae0*/ byte ToByte(string s);
            static /*0x1d64b14*/ System.Exception TryToByte(string s, ref byte result);
            static /*0x1d64c7c*/ ushort ToUInt16(string s);
            static /*0x1d64cb0*/ System.Exception TryToUInt16(string s, ref ushort result);
            static /*0x1d64e18*/ uint ToUInt32(string s);
            static /*0x1d64e4c*/ System.Exception TryToUInt32(string s, ref uint result);
            static /*0x1d64fb4*/ ulong ToUInt64(string s);
            static /*0x1d64fe8*/ System.Exception TryToUInt64(string s, ref ulong result);
            static /*0x1d65150*/ float ToSingle(string s);
            static /*0x1d6527c*/ System.Exception TryToSingle(string s, ref float result);
            static /*0x1d654c4*/ double ToDouble(string s);
            static /*0x1d65624*/ System.Exception TryToDouble(string s, ref double result);
            static /*0x1d658a0*/ double ToXPathDouble(object o);
            static /*0x1d65b50*/ System.TimeSpan ToTimeSpan(string s);
            static /*0x1d65cec*/ System.Exception TryToTimeSpan(string s, ref System.TimeSpan result);
            static /*0x1d65dac*/ string[] get_AllDateTimeFormats();
            static /*0x1d65e60*/ void CreateAllDateTimeFormats();
            static /*0x1d66540*/ System.DateTime ToDateTime(string s);
            static /*0x1d665a8*/ System.DateTime ToDateTime(string s, string[] formats);
            static /*0x1d66660*/ System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x1d6689c*/ System.DateTimeOffset ToDateTimeOffset(string s);
            static /*0x1d66970*/ System.Guid ToGuid(string s);
            static /*0x1d669a0*/ System.Exception TryToGuid(string s, ref System.Guid result);
            static /*0x1d63a64*/ System.DateTime SwitchToLocalTime(System.DateTime value);
            static /*0x1d63ae0*/ System.DateTime SwitchToUtcTime(System.DateTime value);
            static /*0x1d66ba4*/ System.Uri ToUri(string s);
            static /*0x1d66d78*/ System.Exception TryToUri(string s, ref System.Uri result);
            static /*0x1d66fa8*/ bool StrEqual(char[] chars, int strPos1, int strLen1, string str2);
            static /*0x1d5b470*/ string TrimString(string value);
            static /*0x1d67084*/ string TrimStringStart(string value);
            static /*0x1d670fc*/ string TrimStringEnd(string value);
            static /*0x1d67174*/ string[] SplitString(string value);
            static /*0x1d635a0*/ bool IsNegativeZero(double value);
            static /*0x1d671f0*/ long DoubleToInt64Bits(double value);
            static /*0x1d671f8*/ void VerifyCharData(string data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType);
            static /*0x1d67470*/ System.Exception CreateException(string res, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x1d677e0*/ System.Exception CreateException(string res, string arg, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x1d67920*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType);
            static /*0x1d62ad4*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x1d679a0*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi);
            static /*0x1d67a14*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType);
            static /*0x1d67560*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x1d67a94*/ System.Exception CreateInvalidHighSurrogateCharException(char hi);
            static /*0x1d67af8*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType);
            static /*0x1d67b70*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x1d67734*/ System.Exception CreateInvalidCharException(string data, int invCharPos, System.Xml.ExceptionType exceptionType);
            static /*0x1d67c80*/ System.Exception CreateInvalidCharException(char invChar, char nextChar);
            static /*0x1d67cf4*/ System.Exception CreateInvalidCharException(char invChar, char nextChar, System.Xml.ExceptionType exceptionType);
            static /*0x1d62730*/ System.Exception CreateInvalidNameCharException(string name, int index, System.Xml.ExceptionType exceptionType);
            static /*0x1d67d98*/ System.ArgumentException CreateInvalidNameArgumentException(string name, string argumentName);
        }

        class XmlDownloadManager
        {
            /*0x10*/ System.Collections.Hashtable connections;

            /*0x1fd0968*/ XmlDownloadManager();
            /*0x1fcffa4*/ System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x1fd00a8*/ System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x1fd051c*/ void Remove(string host);
            /*0x1fd0690*/ System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x1fd0810*/ System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Uri uri;

                /*0x16c5fac*/ <>c__DisplayClass4_0();
                /*0x16c5fb4*/ System.IO.Stream <GetStreamAsync>b__0();
            }

            struct <GetNonFileStreamAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Uri uri;
                /*0x38*/ System.Net.ICredentials credentials;
                /*0x40*/ System.Net.IWebProxy proxy;
                /*0x48*/ System.Net.Cache.RequestCachePolicy cachePolicy;
                /*0x50*/ System.Net.WebRequest <req>5__1;
                /*0x58*/ System.Xml.XmlDownloadManager <>4__this;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__1;

                /*0xac0d7c*/ void MoveNext();
                /*0xac0d84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class OpenedHost
        {
            /*0x10*/ int nonCachedConnectionsCount;

            /*0x14d47ac*/ OpenedHost();
        }

        class XmlRegisteredNonCachedStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream stream;
            /*0x30*/ System.Xml.XmlDownloadManager downloadManager;
            /*0x38*/ string host;

            /*0x1ce519c*/ XmlRegisteredNonCachedStream(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, string host);
            /*0x1ce5228*/ void Finalize();
            /*0x1ce52a4*/ void Dispose(bool disposing);
            /*0x1ce53b8*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x1ce53dc*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x1ce5400*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x1ce5424*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x1ce5448*/ void Flush();
            /*0x1ce546c*/ int Read(byte[] buffer, int offset, int count);
            /*0x1ce5490*/ int ReadByte();
            /*0x1ce54b4*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x1ce54d8*/ void Write(byte[] buffer, int offset, int count);
            /*0x1ce54fc*/ void WriteByte(byte value);
            /*0x1ce5520*/ bool get_CanRead();
            /*0x1ce5540*/ bool get_CanSeek();
            /*0x1ce5560*/ bool get_CanWrite();
            /*0x1ce5580*/ long get_Length();
            /*0x1ce55a0*/ long get_Position();
            /*0x1ce55c0*/ void set_Position(long value);
        }

        class XmlCachedStream : System.IO.MemoryStream
        {
            /*0x50*/ System.Uri uri;

            /*0x1d5f9d8*/ XmlCachedStream(System.Uri uri, System.IO.Stream stream);
        }

        class UTF16Decoder : System.Text.Decoder
        {
            /*0x20*/ bool bigEndian;
            /*0x24*/ int lastByte;

            /*0x1b18440*/ UTF16Decoder(bool bigEndian);
            /*0x1b18478*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x1b18488*/ int GetCharCount(byte[] bytes, int index, int count, bool flush);
            /*0x1b18574*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x1b187d8*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class SafeAsciiDecoder : System.Text.Decoder
        {
            /*0x1825c84*/ SafeAsciiDecoder();
            /*0x1825c8c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x1825c94*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x1825d14*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class Ucs4Encoding : System.Text.Encoding
        {
            /*0x38*/ System.Xml.Ucs4Decoder ucs4Decoder;

            static /*0x1b19960*/ System.Text.Encoding get_UCS4_Littleendian();
            static /*0x1b19a18*/ System.Text.Encoding get_UCS4_Bigendian();
            static /*0x1b19ad0*/ System.Text.Encoding get_UCS4_2143();
            static /*0x1b19b88*/ System.Text.Encoding get_UCS4_3412();
            /*0x1b19c40*/ Ucs4Encoding();
            /*0x1b1984c*/ string get_WebName();
            /*0x1b19858*/ System.Text.Decoder GetDecoder();
            /*0x1b19860*/ int GetByteCount(char[] chars, int index, int count);
            /*0x1b198c4*/ int GetByteCount(char[] chars);
            /*0x1b198e0*/ byte[] GetBytes(string s);
            /*0x1b198e8*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x1b198f0*/ int GetMaxByteCount(int charCount);
            /*0x1b198f8*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x1b19918*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x1b19938*/ int GetMaxCharCount(int byteCount);
            /*0x1b19950*/ int get_CodePage();
            /*0x1b19958*/ System.Text.Encoder GetEncoder();
        }

        class Ucs4Encoding1234 : System.Xml.Ucs4Encoding
        {
            /*0x1b19a6c*/ Ucs4Encoding1234();
            /*0x1b19c48*/ string get_EncodingName();
            /*0x1b19c8c*/ byte[] GetPreamble();
        }

        class Ucs4Encoding4321 : System.Xml.Ucs4Encoding
        {
            /*0x1b199b4*/ Ucs4Encoding4321();
            /*0x1b19e9c*/ string get_EncodingName();
            /*0x1b19ee0*/ byte[] GetPreamble();
        }

        class Ucs4Encoding2143 : System.Xml.Ucs4Encoding
        {
            /*0x1b19b24*/ Ucs4Encoding2143();
            /*0x1b19d10*/ string get_EncodingName();
            /*0x1b19d54*/ byte[] GetPreamble();
        }

        class Ucs4Encoding3412 : System.Xml.Ucs4Encoding
        {
            /*0x1b19bdc*/ Ucs4Encoding3412();
            /*0x1b19dd8*/ string get_EncodingName();
            /*0x1b19e1c*/ byte[] GetPreamble();
        }

        class Ucs4Decoder : System.Text.Decoder
        {
            /*0x20*/ byte[] lastBytes;
            /*0x28*/ int lastBytesCount;

            /*0x1b18f30*/ Ucs4Decoder();
            /*0x1b18afc*/ int GetCharCount(byte[] bytes, int index, int count);
            int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x1b18b18*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x1b18ca4*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
            /*0x1b18ec8*/ void Ucs4ToUTF16(uint code, char[] chars, int charIndex);
        }

        class Ucs4Decoder4321 : System.Xml.Ucs4Decoder
        {
            /*0x1b19848*/ Ucs4Decoder4321();
            /*0x1b1961c*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder1234 : System.Xml.Ucs4Decoder
        {
            /*0x1b191b8*/ Ucs4Decoder1234();
            /*0x1b18f8c*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder2143 : System.Xml.Ucs4Decoder
        {
            /*0x1b193e8*/ Ucs4Decoder2143();
            /*0x1b191bc*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder3412 : System.Xml.Ucs4Decoder
        {
            /*0x1b19618*/ Ucs4Decoder3412();
            /*0x1b193ec*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class XmlException : System.SystemException
        {
            /*0x88*/ string res;
            /*0x90*/ string[] args;
            /*0x98*/ int lineNumber;
            /*0x9c*/ int linePosition;
            /*0xa0*/ string sourceUri;
            /*0xa8*/ string message;

            static /*0x1fd9ffc*/ string FormatUserMessage(string message, int lineNumber, int linePosition);
            static /*0x1fd9a5c*/ string CreateMessage(string res, string[] args, int lineNumber, int linePosition);
            static /*0x1fd6eec*/ string[] BuildCharExceptionArgs(string data, int invCharIndex);
            static /*0x1fdac7c*/ string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex);
            static /*0x1fda99c*/ string[] BuildCharExceptionArgs(char invChar, char nextChar);
            /*0x1fd96b8*/ XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1fd9e7c*/ XmlException();
            /*0x1fd9e94*/ XmlException(string message);
            /*0x1fd9eb0*/ XmlException(string message, System.Exception innerException);
            /*0x1fd9ea8*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition);
            /*0x1fd9ec0*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x1fda100*/ XmlException(string res, string[] args);
            /*0x1fda1f4*/ XmlException(string res, string arg);
            /*0x1fda2d8*/ XmlException(string res, string arg, string sourceUri);
            /*0x1fda3c8*/ XmlException(string res, string arg, System.Xml.IXmlLineInfo lineInfo);
            /*0x1fda61c*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo);
            /*0x1fda490*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo, string sourceUri);
            /*0x1fda624*/ XmlException(string res, string arg, int lineNumber, int linePosition);
            /*0x1fda71c*/ XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri);
            /*0x1fda820*/ XmlException(string res, string[] args, int lineNumber, int linePosition);
            /*0x1fda89c*/ XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri);
            /*0x1fda91c*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition);
            /*0x1fda168*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x1fd9d10*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1fdacdc*/ int get_LineNumber();
            /*0x1fdace4*/ int get_LinePosition();
            /*0x1fdacec*/ string get_Message();
            /*0x1fdad04*/ string get_ResString();
        }

        class XmlNameTable
        {
            /*0x1b4c0c8*/ XmlNameTable();
            string Get(string array);
            string Add(char[] array, int offset, int length);
            string Add(string array);
        }

        enum XmlNamespaceScope
        {
            All = 0,
            ExcludeXml = 1,
            Local = 2,
        }

        class XmlNamespaceManager : System.Xml.IXmlNamespaceResolver, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNamespaceManager.NamespaceDeclaration[] nsdecls;
            /*0x18*/ int lastDecl;
            /*0x20*/ System.Xml.XmlNameTable nameTable;
            /*0x28*/ int scopeId;
            /*0x30*/ System.Collections.Generic.Dictionary<string, int> hashTable;
            /*0x38*/ bool useHashtable;
            /*0x40*/ string xml;
            /*0x48*/ string xmlNs;

            /*0x1b4ca44*/ XmlNamespaceManager();
            /*0x1b4ca4c*/ XmlNamespaceManager(System.Xml.XmlNameTable nameTable);
            /*0x1b4cc4c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1b4cc54*/ string get_DefaultNamespace();
            /*0x1b4ccc8*/ void PushScope();
            /*0x1b4ccd8*/ bool PopScope();
            /*0x1b4cdbc*/ void AddNamespace(string prefix, string uri);
            /*0x1b4d330*/ void RemoveNamespace(string prefix, string uri);
            /*0x1b4d478*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1b4d600*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1b4d7d4*/ string LookupNamespace(string prefix);
            /*0x1b4d17c*/ int LookupNamespaceDecl(string prefix);
            /*0x1b4d834*/ string LookupPrefix(string uri);

            struct NamespaceDeclaration
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ int scopeId;
                /*0x24*/ int previousNsIndex;

                /*0xac11d4*/ void Set(string prefix, string uri, int scopeId, int previousNsIndex);
            }
        }

        enum XmlNodeType
        {
            None = 0,
            Element = 1,
            Attribute = 2,
            Text = 3,
            CDATA = 4,
            EntityReference = 5,
            Entity = 6,
            ProcessingInstruction = 7,
            Comment = 8,
            Document = 9,
            DocumentType = 10,
            DocumentFragment = 11,
            Notation = 12,
            Whitespace = 13,
            SignificantWhitespace = 14,
            EndElement = 15,
            EndEntity = 16,
            XmlDeclaration = 17,
        }

        class XmlQualifiedName
        {
            static /*0x0*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;
            static /*0x8*/ System.Xml.XmlQualifiedName Empty;
            /*0x10*/ string name;
            /*0x18*/ string ns;
            /*0x20*/ int hash;

            static /*0x1b5cb3c*/ XmlQualifiedName();
            static /*0x1b5c6b8*/ bool op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x1b5c63c*/ bool op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x1b5c724*/ string ToString(string name, string ns);
            static /*0x1b5c2f0*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate();
            static /*0x1b5c7a4*/ bool IsRandomizedHashingDisabled();
            static /*0x1b5c7ac*/ int GetHashCodeOfString(string s, int length, long additionalEntropy);
            static /*0x1b5c8ec*/ System.Xml.XmlQualifiedName Parse(string s, System.Xml.IXmlNamespaceResolver nsmgr, ref string prefix);
            /*0x1b5c0ac*/ XmlQualifiedName();
            /*0x1b5c19c*/ XmlQualifiedName(string name);
            /*0x1b5c104*/ XmlQualifiedName(string name, string ns);
            /*0x1b5c200*/ string get_Namespace();
            /*0x1b5c208*/ string get_Name();
            /*0x1b5c210*/ int GetHashCode();
            /*0x1b5c490*/ bool get_IsEmpty();
            /*0x1b5c4d0*/ string ToString();
            /*0x1b5c544*/ bool Equals(object other);
            /*0x1b5c7c8*/ void Init(string name, string ns);
            /*0x1b5c7d4*/ void SetNamespace(string ns);
            /*0x1b5c7dc*/ void Verify();
            /*0x1b5c894*/ void Atomize(System.Xml.XmlNameTable nameTable);
            /*0x1b5cab8*/ System.Xml.XmlQualifiedName Clone();

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x16c6f44*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x16c6fa4*/ int Invoke(string s, int sLen, long additionalEntropy);
                /*0x16c7364*/ System.IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, System.AsyncCallback callback, object object);
                /*0x16c7424*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class XmlResolver
        {
            /*0x1ce5964*/ XmlResolver();
            object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x1ce55e0*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x1ce57c4*/ bool SupportsType(System.Uri absoluteUri, System.Type type);
            /*0x1ce5924*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        }

        class XmlUrlResolver : System.Xml.XmlResolver
        {
            static /*0x0*/ object s_DownloadManager;
            /*0x10*/ System.Net.ICredentials _credentials;
            /*0x18*/ System.Net.IWebProxy _proxy;
            /*0x20*/ System.Net.Cache.RequestCachePolicy _cachePolicy;

            static /*0x1bd42a0*/ System.Xml.XmlDownloadManager get_DownloadManager();
            /*0x1bd4378*/ XmlUrlResolver();
            /*0x1bd4380*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x1bd4524*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x1bd452c*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);

            struct <GetEntityAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ System.Type ofObjectToReturn;
                /*0x38*/ System.Uri absoluteUri;
                /*0x40*/ System.Xml.XmlUrlResolver <>4__this;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1;

                /*0xac19a0*/ void MoveNext();
                /*0xac19a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class Res
        {
            static /*0x1825bd0*/ string GetString(string name);
            static /*0x1825bd4*/ string GetString(string name, object[] args);
        }

        namespace XPath
        {
            class XPathDocument
            {
                /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp;
                /*0x18*/ int idxXmlNmsp;
                /*0x20*/ System.Xml.XmlNameTable nameTable;
                /*0x28*/ bool hasLineInfo;
                /*0x30*/ System.Collections.Generic.Dictionary<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef> mapNmsp;

                /*0x1b1b90c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1b1b914*/ bool get_HasLineInfo();
                /*0x1b1b91c*/ int GetXmlNamespaceNode(ref MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp);
                /*0x1b1b92c*/ int LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
            }

            class XPathException : System.SystemException
            {
                /*0x88*/ string res;
                /*0x90*/ string[] args;
                /*0x98*/ string message;

                static /*0x1b1cecc*/ System.Xml.XPath.XPathException Create(string res);
                static /*0x1b1cfac*/ System.Xml.XPath.XPathException Create(string res, string arg);
                static /*0x1b1d0a4*/ System.Xml.XPath.XPathException Create(string res, string arg, string arg2);
                static /*0x1b1caf8*/ string CreateMessage(string res, string[] args);
                /*0x1b1c8bc*/ XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1b1cd24*/ XPathException();
                /*0x1b1cd7c*/ XPathException(string message, System.Exception innerException);
                /*0x1b1cf50*/ XPathException(string res, string[] args);
                /*0x1b1ce6c*/ XPathException(string res, string[] args, System.Exception inner);
                /*0x1b1cc30*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1b1d1c8*/ string get_Message();
            }

            enum XPathResultType
            {
                Number = 0,
                String = 1,
                Boolean = 2,
                NodeSet = 3,
                Navigator = 1,
                Any = 5,
                Error = 6,
            }

            class XPathItem
            {
                /*0x1b1d1f4*/ XPathItem();
                System.Xml.Schema.XmlSchemaType get_XmlType();
                string get_Value();
                object get_TypedValue();
                System.Type get_ValueType();
                bool get_ValueAsBoolean();
                System.DateTime get_ValueAsDateTime();
                double get_ValueAsDouble();
                int get_ValueAsInt();
                long get_ValueAsLong();
                /*0x1b1d1e0*/ object ValueAs(System.Type returnType);
                object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            enum XPathNamespaceScope
            {
                All = 0,
                ExcludeXml = 1,
                Local = 2,
            }

            class XPathNavigator : System.Xml.XPath.XPathItem, System.ICloneable, System.Xml.IXmlNamespaceResolver
            {
                static /*0x0*/ System.Xml.XPath.XPathNavigatorKeyComparer comparer;
                static /*0x8*/ char[] NodeTypeLetter;
                static /*0x10*/ char[] UniqueIdTbl;
                static /*0x18*/ int[] ContentKindMasks;

                static /*0x1b1f1cc*/ XPathNavigator();
                static /*0x1b1f1bc*/ bool IsText(System.Xml.XPath.XPathNodeType type);
                /*0x1b1ba9c*/ XPathNavigator();
                /*0x1b1d1fc*/ string ToString();
                /*0x1b1d208*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x1b1d3ac*/ object get_TypedValue();
                /*0x1b1d6ac*/ System.Type get_ValueType();
                /*0x1b1d8e4*/ bool get_ValueAsBoolean();
                /*0x1b1dbd4*/ System.DateTime get_ValueAsDateTime();
                /*0x1b1decc*/ double get_ValueAsDouble();
                /*0x1b1e1c4*/ int get_ValueAsInt();
                /*0x1b1e4bc*/ long get_ValueAsLong();
                /*0x1b1e7b4*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b1eacc*/ object System.ICloneable.Clone();
                System.Xml.XmlNameTable get_NameTable();
                /*0x1b1eadc*/ string LookupNamespace(string prefix);
                /*0x1b1ec90*/ string LookupPrefix(string namespaceURI);
                /*0x1b1ee98*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                System.Xml.XPath.XPathNavigator Clone();
                System.Xml.XPath.XPathNodeType get_NodeType();
                string get_LocalName();
                string get_NamespaceURI();
                string get_Prefix();
                /*0x1b1f0c4*/ object get_UnderlyingObject();
                /*0x1b1f0cc*/ bool MoveToNamespace(string name);
                bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                bool MoveToParent();
                bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                /*0x1b1f170*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            }

            class XPathNavigatorKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x1b1f324*/ XPathNavigatorKeyComparer();
                /*0x1b1f32c*/ bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2);
                /*0x1b1f40c*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }

            enum XPathNodeType
            {
                Root = 0,
                Element = 1,
                Attribute = 2,
                Namespace = 3,
                Text = 4,
                SignificantWhitespace = 5,
                Whitespace = 6,
                ProcessingInstruction = 7,
                Comment = 8,
                All = 9,
            }
        }

        namespace Serialization
        {
            class CodeIdentifier
            {
                static /*0x0*/ Microsoft.CSharp.CodeDomProvider csharp;

                static /*0x1594084*/ CodeIdentifier();
                static /*0x1593c10*/ string MakePascal(string identifier);
                static /*0x1593dec*/ string MakeValid(string identifier);
                static /*0x1594014*/ bool IsValidStart(char c);
                static /*0x1593f8c*/ bool IsValid(char c);
            }

            class XmlSerializerNamespaces
            {
                /*0x10*/ System.Collections.Hashtable namespaces;

                /*0x20cb994*/ XmlSerializerNamespaces();
                /*0x20cb99c*/ void Add(string prefix, string ns);
                /*0x20d6354*/ void AddInternal(string prefix, string ns);
                /*0x20cd970*/ System.Xml.XmlQualifiedName[] ToArray();
                /*0x20d5fb8*/ int get_Count();
                /*0x20d6394*/ System.Collections.ArrayList get_NamespaceList();
                /*0x20cedac*/ System.Collections.Hashtable get_Namespaces();
                /*0x20d6798*/ void set_Namespaces(System.Collections.Hashtable value);
            }

            class XmlAttributeEventHandler : System.MulticastDelegate
            {
                /*0x1d548a0*/ XmlAttributeEventHandler(object object, nint method);
                /*0x1d54900*/ void Invoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x1d54c94*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e, System.AsyncCallback callback, object object);
                /*0x1d54cc4*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlAttributeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlAttribute attr;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x1d54800*/ XmlAttributeEventArgs(System.Xml.XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlElementEventHandler : System.MulticastDelegate
            {
                /*0x1fd2cf4*/ XmlElementEventHandler(object object, nint method);
                /*0x1fd2d54*/ void Invoke(object sender, System.Xml.Serialization.XmlElementEventArgs e);
                /*0x1fd30e8*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.Serialization.XmlElementEventArgs e, System.AsyncCallback callback, object object);
                /*0x1fd3118*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlElementEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlElement elem;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x1fd2c54*/ XmlElementEventArgs(System.Xml.XmlElement elem, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlNodeEventHandler : System.MulticastDelegate
            {
                /*0x1b50b48*/ XmlNodeEventHandler(object object, nint method);
                /*0x1b50ba8*/ void Invoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x1b50f3c*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e, System.AsyncCallback callback, object object);
                /*0x1b50f6c*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlNodeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlNode xmlNode;
                /*0x20*/ int lineNumber;
                /*0x24*/ int linePosition;

                /*0x1b50ab8*/ XmlNodeEventArgs(System.Xml.XmlNode xmlNode, int lineNumber, int linePosition, object o);
            }

            class UnreferencedObjectEventHandler : System.MulticastDelegate
            {
                /*0x1b1a19c*/ UnreferencedObjectEventHandler(object object, nint method);
                /*0x1b1a1fc*/ void Invoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x1b1a590*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e, System.AsyncCallback callback, object object);
                /*0x1b1a5c0*/ void EndInvoke(System.IAsyncResult result);
            }

            class UnreferencedObjectEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ string id;

                /*0x1b1a120*/ UnreferencedObjectEventArgs(object o, string id);
            }

            interface IXmlSerializable
            {
                System.Xml.Schema.XmlSchema GetSchema();
                void ReadXml(System.Xml.XmlReader reader);
                void WriteXml(System.Xml.XmlWriter writer);
            }

            interface IXmlTextParser
            {
                bool get_Normalized();
                void set_Normalized(bool value);
            }

            class KeyHelper
            {
                static /*0x14ce0ec*/ void AddField(System.Text.StringBuilder sb, int n, string val);
                static /*0x14ce0f4*/ void AddField(System.Text.StringBuilder sb, int n, string val, string def);
                static /*0x14ce1ec*/ void AddField(System.Text.StringBuilder sb, int n, bool val);
                static /*0x14ce1f8*/ void AddField(System.Text.StringBuilder sb, int n, bool val, bool def);
                static /*0x14ce244*/ void AddField(System.Text.StringBuilder sb, int n, int val, int def);
                static /*0x14ce310*/ void AddField(System.Text.StringBuilder sb, int n, System.Type val);
            }

            class ReflectionHelper
            {
                static /*0x0*/ System.Reflection.ParameterModifier[] empty_modifiers;
                /*0x10*/ System.Collections.Hashtable _clrTypes;
                /*0x18*/ System.Collections.Hashtable _schemaTypes;

                static /*0x1825b64*/ ReflectionHelper();
                static /*0x18257c4*/ void CheckSerializableType(System.Type type, bool allowPrivateConstructors);
                /*0x1825ae0*/ ReflectionHelper();
                /*0x182534c*/ void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, string xmlType, string ns);
                /*0x182541c*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns);
                /*0x18254f4*/ void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, string ns);
                /*0x1825658*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, string ns);
            }

            enum SchemaTypes
            {
                NotSet = 0,
                Primitive = 1,
                Enum = 2,
                Array = 3,
                Class = 4,
                XmlSerializable = 5,
                XmlNode = 6,
                Void = 7,
            }

            class SerializationSource
            {
                /*0x10*/ System.Type[] includedTypes;
                /*0x18*/ string namspace;
                /*0x20*/ bool canBeGenerated;

                /*0x1b0f5bc*/ SerializationSource(string namspace, System.Type[] includedTypes);
                /*0x1b0f5fc*/ bool BaseEquals(System.Xml.Serialization.SerializationSource other);
            }

            class XmlTypeSerializationSource : System.Xml.Serialization.SerializationSource
            {
                /*0x28*/ string attributeOverridesHash;
                /*0x30*/ System.Type type;
                /*0x38*/ string rootHash;

                /*0x1bccb7c*/ XmlTypeSerializationSource(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string namspace, System.Type[] includedTypes);
                /*0x1bccc90*/ bool Equals(object o);
                /*0x1bccd84*/ int GetHashCode();
            }

            class XmlTypeConvertorAttribute : System.Attribute
            {
                /*0x10*/ string <Method>k__BackingField;

                /*0x1bca078*/ XmlTypeConvertorAttribute(string method);
                /*0x1bca068*/ string get_Method();
                /*0x1bca070*/ void set_Method(string value);
            }

            class TypeData
            {
                static /*0x0*/ string[] keywords;
                /*0x10*/ System.Type type;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Serialization.SchemaTypes sType;
                /*0x28*/ System.Type listItemType;
                /*0x30*/ string typeName;
                /*0x38*/ string fullTypeName;
                /*0x40*/ System.Xml.Serialization.TypeData listItemTypeData;
                /*0x48*/ System.Xml.Serialization.TypeData mappedType;
                /*0x50*/ System.Xml.Schema.XmlSchemaPatternFacet facet;
                /*0x58*/ System.Reflection.MethodInfo typeConvertor;
                /*0x60*/ bool hasPublicConstructor;
                /*0x61*/ bool nullableOverride;

                static /*0x1b131c8*/ TypeData();
                static /*0x1b12f4c*/ System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType);
                static /*0x1b130a8*/ System.InvalidOperationException CreateMissingAddMethodException(System.Type type, string inheritFrom, System.Type argumentType);
                static /*0x1b12d2c*/ System.Type GetGenericListItemType(System.Type type);
                /*0x1b11b6c*/ TypeData(System.Type type, string elementName, bool isPrimitive);
                /*0x1b11b7c*/ TypeData(System.Type type, string elementName, bool isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet);
                /*0x1b12154*/ void LookupTypeConvertor();
                /*0x1b121f8*/ void ConvertForAssignment(ref object value);
                /*0x1b122d4*/ string get_TypeName();
                /*0x1b122dc*/ string get_XmlType();
                /*0x1b122e4*/ System.Type get_Type();
                /*0x1b122ec*/ string get_FullTypeName();
                /*0x1b122f4*/ System.Xml.Serialization.SchemaTypes get_SchemaType();
                /*0x1b11f54*/ bool get_IsListType();
                /*0x1b122fc*/ bool get_IsComplexType();
                /*0x1b12334*/ bool get_IsValueType();
                /*0x1b123d4*/ bool get_IsNullable();
                /*0x1b12508*/ void set_IsNullable(bool value);
                /*0x1b11f64*/ System.Xml.Serialization.TypeData get_ListItemTypeData();
                /*0x1b12514*/ System.Type get_ListItemType();
                /*0x1b12324*/ bool get_IsXsdType();
                /*0x1b131c0*/ bool get_HasPublicConstructor();
            }

            class TypeMember
            {
                /*0x10*/ System.Type type;
                /*0x18*/ string member;

                static /*0x1b14784*/ bool Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2);
                /*0x1b14678*/ TypeMember(System.Type type, string member);
                /*0x1b146b0*/ int GetHashCode();
                /*0x1b14704*/ bool Equals(object obj);
                /*0x1b1483c*/ string ToString();
            }

            class TypeTranslator
            {
                static /*0x0*/ System.Collections.Hashtable nameCache;
                static /*0x8*/ System.Collections.Hashtable primitiveTypes;
                static /*0x10*/ System.Collections.Hashtable primitiveArrayTypes;
                static /*0x18*/ System.Collections.Hashtable nullableTypes;

                static /*0x1b148a4*/ TypeTranslator();
                static /*0x1b12cc4*/ System.Xml.Serialization.TypeData GetTypeData(System.Type type);
                static /*0x1b16cc0*/ System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, string xmlDataType, bool underlyingEnumType);
                static /*0x1b17758*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName);
                static /*0x1b177bc*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName, bool nullable);
                static /*0x1b179e8*/ System.Xml.Serialization.TypeData FindPrimitiveTypeData(string typeName);
                static /*0x1b12030*/ string GetArrayName(string elemName);
                static /*0x1b17ab4*/ void ParseArrayType(string arrayType, ref string type, ref string ns, ref string dimensions);
            }

            class XmlAnyAttributeAttribute : System.Attribute
            {
                /*0x1d23210*/ XmlAnyAttributeAttribute();
            }

            class XmlAnyElementAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ string ns;
                /*0x20*/ int order;

                /*0x1d2727c*/ XmlAnyElementAttribute();
                /*0x1d2728c*/ string get_Name();
                /*0x1d272e4*/ string get_Namespace();
                /*0x1d272ec*/ int get_Order();
                /*0x1d272f4*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAnyElementAttributes : System.Collections.CollectionBase
            {
                /*0x1d27904*/ XmlAnyElementAttributes();
                /*0x1d27390*/ System.Xml.Serialization.XmlAnyElementAttribute get_Item(int index);
                /*0x1d274a4*/ int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute);
                /*0x1d27570*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x1d2764c*/ int get_Order();
            }

            class XmlArrayAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x1c*/ bool isNullable;
                /*0x20*/ string ns;
                /*0x28*/ int order;

                /*0x1d27cf8*/ string get_ElementName();
                /*0x1d27d50*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1d27d58*/ bool get_IsNullable();
                /*0x1d27d60*/ string get_Namespace();
                /*0x1d27d68*/ int get_Order();
                /*0x1d27d70*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x28*/ string ns;
                /*0x30*/ bool isNullable;
                /*0x31*/ bool isNullableSpecified;
                /*0x34*/ int nestingLevel;
                /*0x38*/ System.Type type;

                /*0x1d27ed4*/ string get_DataType();
                /*0x1d27f2c*/ string get_ElementName();
                /*0x1d27f84*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1d27f8c*/ string get_Namespace();
                /*0x1d27f94*/ bool get_IsNullable();
                /*0x1d27f9c*/ bool get_IsNullableSpecified();
                /*0x1d27fa4*/ System.Type get_Type();
                /*0x1d27fac*/ int get_NestingLevel();
                /*0x1d27fb4*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttributes : System.Collections.CollectionBase
            {
                /*0x1d28418*/ XmlArrayItemAttributes();
                /*0x1d2815c*/ System.Xml.Serialization.XmlArrayItemAttribute get_Item(int index);
                /*0x1d28270*/ int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute);
                /*0x1d2833c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeAttribute : System.Attribute
            {
                /*0x10*/ string attributeName;
                /*0x18*/ string dataType;
                /*0x20*/ System.Type type;
                /*0x28*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x30*/ string ns;

                /*0x1d52b6c*/ XmlAttributeAttribute(string attributeName);
                /*0x1d52b98*/ string get_AttributeName();
                /*0x1d52bf0*/ string get_DataType();
                /*0x1d52c48*/ void set_DataType(string value);
                /*0x1d52c50*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1d52c58*/ string get_Namespace();
                /*0x1d52c60*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeOverrides
            {
                /*0x10*/ System.Collections.Hashtable overrides;

                /*0x1d54cd0*/ XmlAttributeOverrides();
                /*0x1d54d38*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type);
                /*0x1d54d9c*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type, string member);
                /*0x1d54e54*/ System.Xml.Serialization.TypeMember GetKey(System.Type type, string member);
                /*0x1d54ec4*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributes
            {
                /*0x10*/ System.Xml.Serialization.XmlAnyAttributeAttribute xmlAnyAttribute;
                /*0x18*/ System.Xml.Serialization.XmlAnyElementAttributes xmlAnyElements;
                /*0x20*/ System.Xml.Serialization.XmlArrayAttribute xmlArray;
                /*0x28*/ System.Xml.Serialization.XmlArrayItemAttributes xmlArrayItems;
                /*0x30*/ System.Xml.Serialization.XmlAttributeAttribute xmlAttribute;
                /*0x38*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute xmlChoiceIdentifier;
                /*0x40*/ object xmlDefaultValue;
                /*0x48*/ System.Xml.Serialization.XmlElementAttributes xmlElements;
                /*0x50*/ System.Xml.Serialization.XmlEnumAttribute xmlEnum;
                /*0x58*/ bool xmlIgnore;
                /*0x59*/ bool xmlns;
                /*0x60*/ System.Xml.Serialization.XmlRootAttribute xmlRoot;
                /*0x68*/ System.Xml.Serialization.XmlTextAttribute xmlText;
                /*0x70*/ System.Xml.Serialization.XmlTypeAttribute xmlType;

                /*0x1d55614*/ XmlAttributes();
                /*0x1d5570c*/ XmlAttributes(System.Reflection.ICustomAttributeProvider provider);
                /*0x1d55d30*/ System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute();
                /*0x1d55d38*/ System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements();
                /*0x1d55d40*/ System.Xml.Serialization.XmlArrayAttribute get_XmlArray();
                /*0x1d55d48*/ System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems();
                /*0x1d55d50*/ System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute();
                /*0x1d55d58*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier();
                /*0x1d55d60*/ object get_XmlDefaultValue();
                /*0x1d55d68*/ System.Xml.Serialization.XmlElementAttributes get_XmlElements();
                /*0x1d55d70*/ bool get_XmlIgnore();
                /*0x1d55d78*/ bool get_Xmlns();
                /*0x1d55d80*/ System.Xml.Serialization.XmlRootAttribute get_XmlRoot();
                /*0x1d55d88*/ System.Xml.Serialization.XmlTextAttribute get_XmlText();
                /*0x1d55d90*/ System.Xml.Serialization.XmlTypeAttribute get_XmlType();
                /*0x1d5537c*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x1d56d1c*/ System.Nullable<int> get_Order();
                /*0x1d56df0*/ int get_SortableOrder();
            }

            class XmlChoiceIdentifierAttribute : System.Attribute
            {
                /*0x10*/ string memberName;

                /*0x1d609a0*/ string get_MemberName();
                /*0x1d56c94*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlCustomFormatter
            {
                static /*0x0*/ string[] allTimeFormats;

                static /*0x1d68f1c*/ XmlCustomFormatter();
                static /*0x1d67f54*/ string FromEnum(long value, string[] values, long[] ids, string typeName);
                static /*0x1d68240*/ string FromXmlName(string name);
                static /*0x1d682a0*/ string FromXmlNCName(string ncName);
                static /*0x1d55d98*/ string ToXmlString(System.Xml.Serialization.TypeData type, object value);
                static /*0x1d68300*/ object FromXmlString(System.Xml.Serialization.TypeData type, string value);
            }

            class XmlElementAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x28*/ string ns;
                /*0x30*/ bool isNullable;
                /*0x38*/ System.Type type;
                /*0x40*/ int order;

                /*0x1fd23fc*/ XmlElementAttribute(string elementName);
                /*0x1fd2430*/ XmlElementAttribute(string elementName, System.Type type);
                /*0x1fd2474*/ string get_DataType();
                /*0x1fd24cc*/ string get_ElementName();
                /*0x1fd2524*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1fd252c*/ string get_Namespace();
                /*0x1fd2534*/ bool get_IsNullable();
                /*0x1fd253c*/ int get_Order();
                /*0x1fd2544*/ System.Type get_Type();
                /*0x1fd254c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlElementAttributes : System.Collections.CollectionBase
            {
                /*0x1fd2c4c*/ XmlElementAttributes();
                /*0x1fd26d8*/ System.Xml.Serialization.XmlElementAttribute get_Item(int index);
                /*0x1fd27ec*/ int Add(System.Xml.Serialization.XmlElementAttribute attribute);
                /*0x1fd28b8*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x1fd2994*/ int get_Order();
            }

            class XmlEnumAttribute : System.Attribute
            {
                /*0x10*/ string name;

                /*0x1fd8584*/ XmlEnumAttribute(string name);
                /*0x1fd85b0*/ string get_Name();
                /*0x1fd85b8*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlIgnoreAttribute : System.Attribute
            {
                /*0x1fdad0c*/ XmlIgnoreAttribute();
            }

            class XmlIncludeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x1fdae10*/ System.Type get_Type();
            }

            class XmlMapping
            {
                /*0x10*/ System.Xml.Serialization.ObjectMap map;
                /*0x18*/ System.Collections.ArrayList relatedMaps;
                /*0x20*/ System.Xml.Serialization.SerializationFormat format;
                /*0x28*/ System.Xml.Serialization.SerializationSource source;
                /*0x30*/ string _elementName;
                /*0x38*/ string _namespace;
                /*0x40*/ string key;

                /*0x1fe0f10*/ XmlMapping(string elementName, string ns);
                /*0x1fe0f48*/ string get_ElementName();
                /*0x1fe0f50*/ string get_Namespace();
                /*0x1fe0f58*/ void SetKey(string key);
                /*0x1fe0f60*/ System.Xml.Serialization.ObjectMap get_ObjectMap();
                /*0x1fe0f68*/ void set_ObjectMap(System.Xml.Serialization.ObjectMap value);
                /*0x1fe0f70*/ System.Collections.ArrayList get_RelatedMaps();
                /*0x1fe0f78*/ void set_RelatedMaps(System.Collections.ArrayList value);
                /*0x1fe0f80*/ System.Xml.Serialization.SerializationFormat get_Format();
                /*0x1fe0f88*/ void set_Format(System.Xml.Serialization.SerializationFormat value);
                /*0x1fe0f90*/ System.Xml.Serialization.SerializationSource get_Source();
            }

            class ObjectMap
            {
                /*0x14c92d0*/ ObjectMap();
            }

            enum SerializationFormat
            {
                Encoded = 0,
                Literal = 1,
            }

            class XmlMemberMapping
            {
            }

            class XmlMembersMapping : System.Xml.Serialization.XmlMapping
            {
                /*0x48*/ bool _hasWrapperElement;
                /*0x50*/ System.Xml.Serialization.XmlMemberMapping[] _mapping;

                /*0x1fe0f98*/ int get_Count();
                /*0x1fe0fb4*/ bool get_HasWrapperElement();
            }

            class XmlNamespaceDeclarationsAttribute : System.Attribute
            {
                /*0x1b4ca3c*/ XmlNamespaceDeclarationsAttribute();
            }

            class XmlReflectionImporter
            {
                static /*0x0*/ string errSimple;
                static /*0x8*/ string errSimple2;
                /*0x10*/ string initialDefaultNamespace;
                /*0x18*/ System.Xml.Serialization.XmlAttributeOverrides attributeOverrides;
                /*0x20*/ System.Collections.ArrayList includedTypes;
                /*0x28*/ System.Xml.Serialization.ReflectionHelper helper;
                /*0x30*/ int arrayChoiceCount;
                /*0x38*/ System.Collections.ArrayList relatedMaps;
                /*0x40*/ bool allowPrivateTypes;

                static /*0x1b6723c*/ XmlReflectionImporter();
                /*0x1b60054*/ XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace);
                /*0x1b60164*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type);
                /*0x1b60368*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace);
                /*0x1b60170*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b60374*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b62f80*/ System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultXmlType, string defaultNamespace);
                /*0x1b63410*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x1b60814*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x1b64c3c*/ void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap);
                /*0x1b634ac*/ string GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b64eb8*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x1b6188c*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x1b62568*/ System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b62758*/ System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b62810*/ System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b62e60*/ System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1b64d70*/ void ImportIncludedTypes(System.Type type, string defaultNamespace);
                /*0x1b635cc*/ System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type);
                /*0x1b642d4*/ System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, string defaultNamespace);
                /*0x1b65660*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, string defaultName, string defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x1b64f64*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x1b669c8*/ void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, string defaultNamespace);
                /*0x1b633c0*/ bool CanBeNull(System.Xml.Serialization.TypeData type);
                /*0x1b66d4c*/ void IncludeType(System.Type type);
                /*0x1b667c0*/ object GetDefaultValue(System.Xml.Serialization.TypeData typeData, object defaultValue);

                class <>c
                {
                    static /*0x0*/ System.Xml.Serialization.XmlReflectionImporter.<> <>9;
                    static /*0x8*/ System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0;

                    static /*0x16c7450*/ <>c();
                    /*0x16c74b0*/ <>c();
                    /*0x16c74b8*/ int <ImportClassMapping>b__28_0(System.Xml.Serialization.XmlReflectionMember m1, System.Xml.Serialization.XmlReflectionMember m2);
                }
            }

            class XmlReflectionMember
            {
                /*0x10*/ bool isReturnValue;
                /*0x18*/ string memberName;
                /*0x20*/ System.Type memberType;
                /*0x28*/ System.Xml.Serialization.XmlAttributes xmlAttributes;
                /*0x30*/ System.Type declaringType;

                /*0x1ce50cc*/ XmlReflectionMember(string name, System.Type type, System.Xml.Serialization.XmlAttributes attributes);
                /*0x1ce510c*/ bool get_IsReturnValue();
                /*0x1ce5114*/ string get_MemberName();
                /*0x1ce511c*/ System.Type get_MemberType();
                /*0x1ce5124*/ System.Xml.Serialization.XmlAttributes get_XmlAttributes();
                /*0x1ce518c*/ System.Type get_DeclaringType();
                /*0x1ce5194*/ void set_DeclaringType(System.Type value);
            }

            class XmlRootAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ bool isNullable;
                /*0x28*/ string ns;

                /*0x1ce596c*/ XmlRootAttribute();
                /*0x1ce597c*/ XmlRootAttribute(string elementName);
                /*0x1ce59b0*/ string get_DataType();
                /*0x1ce5a08*/ void set_DataType(string value);
                /*0x1ce5a10*/ string get_ElementName();
                /*0x1ce5a68*/ void set_ElementName(string value);
                /*0x1ce5a70*/ bool get_IsNullable();
                /*0x1ce5a78*/ void set_IsNullable(bool value);
                /*0x1ce5a84*/ string get_Namespace();
                /*0x1ce5a8c*/ void set_Namespace(string value);
                /*0x1ce5a94*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlSchemaProviderAttribute : System.Attribute
            {
                /*0x10*/ string _methodName;
                /*0x18*/ bool _isAny;

                /*0x1abac9c*/ XmlSchemaProviderAttribute(string methodName);
                /*0x1abacc8*/ string get_MethodName();
                /*0x1abacd0*/ bool get_IsAny();
                /*0x1abacd8*/ void set_IsAny(bool value);
            }

            class XmlSerializationCollectionFixupCallback : System.MulticastDelegate
            {
                /*0x1acff20*/ XmlSerializationCollectionFixupCallback(object object, nint method);
                /*0x1acff80*/ void Invoke(object collection, object collectionItems);
                /*0x1ad0314*/ System.IAsyncResult BeginInvoke(object collection, object collectionItems, System.AsyncCallback callback, object object);
                /*0x1ad0344*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlSerializationFixupCallback : System.MulticastDelegate
            {
                /*0x1ad0350*/ XmlSerializationFixupCallback(object object, nint method);
                /*0x1ad03b0*/ void Invoke(object fixup);
                /*0x1ad0728*/ System.IAsyncResult BeginInvoke(object fixup, System.AsyncCallback callback, object object);
                /*0x1ad074c*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlSerializationGeneratedCode
            {
                /*0x1ad0758*/ XmlSerializationGeneratedCode();
            }

            class XmlSerializationReadCallback : System.MulticastDelegate
            {
                /*0x1ad0760*/ XmlSerializationReadCallback(object object, nint method);
                /*0x1ad07c0*/ object Invoke();
                /*0x1ad09d4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1ad0a00*/ object EndInvoke(System.IAsyncResult result);
            }

            class XmlSerializationReader : System.Xml.Serialization.XmlSerializationGeneratedCode
            {
                /*0x10*/ System.Xml.XmlDocument document;
                /*0x18*/ System.Xml.XmlReader reader;
                /*0x20*/ System.Collections.ArrayList fixups;
                /*0x28*/ System.Collections.Hashtable collFixups;
                /*0x30*/ System.Collections.ArrayList collItemFixups;
                /*0x38*/ System.Collections.Hashtable typesCallbacks;
                /*0x40*/ System.Collections.ArrayList noIDTargets;
                /*0x48*/ System.Collections.Hashtable targets;
                /*0x50*/ System.Collections.Hashtable delayedListFixups;
                /*0x58*/ System.Xml.Serialization.XmlSerializer eventSource;
                /*0x60*/ int delayedFixupId;
                /*0x68*/ System.Collections.Hashtable referencedObjects;
                /*0x70*/ int readCount;
                /*0x74*/ int whileIterationCount;
                /*0x78*/ string w3SchemaNS;
                /*0x80*/ string w3InstanceNS;
                /*0x88*/ string w3InstanceNS2000;
                /*0x90*/ string w3InstanceNS1999;
                /*0x98*/ string soapNS;
                /*0xa0*/ string wsdlNS;
                /*0xa8*/ string nullX;
                /*0xb0*/ string nil;
                /*0xb8*/ string typeX;
                /*0xc0*/ string arrayType;
                /*0xc8*/ System.Xml.XmlQualifiedName arrayQName;

                /*0x1ad0df4*/ XmlSerializationReader();
                /*0x1ad0a0c*/ void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource);
                /*0x1ad0d34*/ System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list);
                /*0x1ad0d94*/ System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash);
                /*0x1ad0dfc*/ System.Xml.XmlDocument get_Document();
                /*0x1ad0e94*/ System.Xml.XmlReader get_Reader();
                /*0x1ad0e9c*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup);
                /*0x1ad0f54*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup);
                /*0x1ad0f9c*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup);
                /*0x1ad0fe4*/ void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read);
                /*0x1ad10c8*/ void AddTarget(string id, object o);
                /*0x1ad1184*/ string CurrentTag();
                /*0x1ad12e4*/ System.Exception CreateReadOnlyCollectionException(string name);
                /*0x1ad1370*/ System.Exception CreateUnknownConstantException(string value, System.Type enumType);
                /*0x1ad140c*/ System.Exception CreateUnknownNodeException();
                /*0x1ad149c*/ System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type);
                /*0x1ad16ac*/ System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType);
                /*0x1ad1748*/ bool GetNullAttr();
                /*0x1ad17fc*/ object GetTarget(string id);
                /*0x1ad18c0*/ bool TargetReady(string id);
                /*0x1ad18dc*/ System.Xml.XmlQualifiedName GetXsiType();
                void InitCallbacks();
                void InitIDs();
                /*0x1ad1af8*/ bool IsXmlnsAttribute(string name);
                /*0x1ad1b9c*/ void ParseWsdlArrayType(System.Xml.XmlAttribute attr);
                /*0x1ad1d2c*/ System.Xml.XmlQualifiedName ReadElementQualifiedName();
                /*0x1ad206c*/ void ReadEndElement();
                /*0x1ad2110*/ bool ReadNull();
                /*0x1ad221c*/ System.Xml.XmlQualifiedName ReadNullableQualifiedName();
                /*0x1ad2254*/ string ReadNullableString();
                /*0x1ad22ac*/ object ReadReferencedElement();
                /*0x1ad25c4*/ System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname);
                /*0x1ad2308*/ object ReadReferencedElement(string name, string ns);
                /*0x1ad26ac*/ bool ReadList(ref object resultList);
                /*0x1ad34a8*/ void ReadReferencedElements();
                /*0x1ad42b8*/ object ReadReferencingElement(ref string fixupReference);
                /*0x1ad349c*/ object ReadReferencingElement(string name, string ns, ref string fixupReference);
                /*0x1ad4328*/ object ReadReferencingElement(string name, string ns, bool elementCanBeType, ref string fixupReference);
                /*0x1ad4650*/ System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable);
                /*0x1ad47ec*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName type);
                /*0x1ad2b98*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, bool reportUnknown);
                /*0x1ad4a80*/ System.Xml.XmlNode ReadXmlNode(bool wrapped);
                /*0x1ad4aec*/ System.Xml.XmlDocument ReadXmlDocument(bool wrapped);
                /*0x1ad4c0c*/ System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable);
                /*0x1ad1e2c*/ System.Xml.XmlQualifiedName ToXmlQualifiedName(string value);
                /*0x1ad4cac*/ void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames);
                /*0x1ad4e18*/ void UnknownElement(object o, System.Xml.XmlElement elem, string qnames);
                /*0x1ad21e4*/ void UnknownNode(object o);
                /*0x1ad4f84*/ void UnknownNode(object o, string qnames);
                /*0x1ad47f4*/ void OnUnknownNode(System.Xml.XmlNode node, object o, string qnames);
                /*0x1ad4220*/ void UnreferencedObject(string id, object o);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationReadCallback Callback;

                    /*0x16c8148*/ WriteCallbackInfo();
                }

                class CollectionFixup
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;
                    /*0x18*/ object collection;
                    /*0x20*/ object collectionItems;
                    /*0x28*/ string id;

                    /*0x16c7fe8*/ CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, string id);
                    /*0x16c8028*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback();
                    /*0x16c8030*/ object get_Collection();
                    /*0x16c8038*/ object get_Id();
                    /*0x16c8040*/ object get_CollectionItems();
                    /*0x16c8048*/ void set_CollectionItems(object value);
                }

                class Fixup
                {
                    /*0x10*/ object source;
                    /*0x18*/ string[] ids;
                    /*0x20*/ System.Xml.Serialization.XmlSerializationFixupCallback callback;

                    /*0x16c80ac*/ Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count);
                    /*0x16c8130*/ System.Xml.Serialization.XmlSerializationFixupCallback get_Callback();
                    /*0x16c8138*/ string[] get_Ids();
                    /*0x16c8140*/ object get_Source();
                }

                class CollectionItemFixup
                {
                    /*0x10*/ System.Array list;
                    /*0x18*/ int index;
                    /*0x20*/ string id;

                    /*0x16c8050*/ CollectionItemFixup(System.Array list, int index, string id);
                    /*0x16c8094*/ System.Array get_Collection();
                    /*0x16c809c*/ int get_Index();
                    /*0x16c80a4*/ string get_Id();
                }
            }

            class XmlSerializationReaderInterpreter : System.Xml.Serialization.XmlSerializationReader
            {
                static /*0x0*/ System.Xml.XmlQualifiedName AnyType;
                static /*0x8*/ object[] empty_array;
                /*0xd0*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0xd8*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x20cd304*/ XmlSerializationReaderInterpreter();
                static /*0x20cb508*/ object CreateInstance(System.Type type, bool nonPublic);
                /*0x20c78b8*/ XmlSerializationReaderInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x20c78f4*/ void InitCallbacks();
                /*0x20c7c84*/ void InitIDs();
                /*0x20c7c88*/ object ReadRoot();
                /*0x20c7e74*/ object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x20c7f78*/ object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap);
                /*0x20c7d94*/ object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap);
                /*0x20caa20*/ object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x20cb1dc*/ object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x20cb514*/ void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x20c8570*/ void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x20c8990*/ void ReadMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList, bool readBySoapOrder);
                /*0x20cbd74*/ void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x20cc318*/ void FixupMembers(System.Xml.Serialization.ClassMap map, object obfixup, bool isValueList);
                /*0x20cc6f0*/ void ProcessUnknownAttribute(object target);
                /*0x20cc6f8*/ void ProcessUnknownElement(object target);
                /*0x20cbec8*/ bool IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, object ob, bool isValueList);
                /*0x20cb728*/ void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x20c849c*/ void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x20cb8bc*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x20cc08c*/ object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x20cca00*/ object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x20cb5c0*/ object GetValueFromXmlString(string value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x20cab20*/ object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance);
                /*0x20ccb18*/ object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, string values);
                /*0x20cba6c*/ void AddListValue(System.Xml.Serialization.TypeData listType, ref object list, int index, object value, bool canCreateInstance);
                /*0x20c842c*/ object CreateInstance(System.Type type);
                /*0x20cbfc8*/ object CreateList(System.Type listType);
                /*0x20cbf30*/ object InitializeList(System.Xml.Serialization.TypeData listType);
                /*0x20cced8*/ void FillList(object list, object items);
                /*0x20ccee8*/ void CopyEnumerableList(object source, object dest);
                /*0x20caa04*/ object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x20cc248*/ object ReadXmlNode(System.Xml.Serialization.TypeData type, bool wrapped);
                /*0x20caef0*/ object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x20cafc0*/ object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x20ccd84*/ object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, string val);
                /*0x20cb038*/ object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);

                class FixupCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.ClassMap _map;
                    /*0x20*/ bool _isValueList;

                    /*0x16c8150*/ FixupCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, bool isValueList);
                    /*0x16c8194*/ void FixupMembers(object fixup);
                }

                class ReaderCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x16c81c0*/ ReaderCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x16c81f8*/ object ReadObject();
                }
            }

            class XmlSerializationWriteCallback : System.MulticastDelegate
            {
                /*0x20cd3d4*/ XmlSerializationWriteCallback(object object, nint method);
                /*0x20cd434*/ void Invoke(object o);
                /*0x20cd7ac*/ System.IAsyncResult BeginInvoke(object o, System.AsyncCallback callback, object object);
                /*0x20cd7d0*/ void EndInvoke(System.IAsyncResult result);
            }

            class XmlSerializationWriter : System.Xml.Serialization.XmlSerializationGeneratedCode
            {
                /*0x10*/ System.Runtime.Serialization.ObjectIDGenerator idGenerator;
                /*0x18*/ int qnameCount;
                /*0x1c*/ bool topLevelElement;
                /*0x20*/ System.Collections.ArrayList namespaces;
                /*0x28*/ System.Xml.XmlWriter writer;
                /*0x30*/ System.Collections.Queue referencedElements;
                /*0x38*/ System.Collections.Hashtable callbacks;
                /*0x40*/ System.Collections.Hashtable serializedObjects;

                /*0x20cd7dc*/ XmlSerializationWriter();
                /*0x20cd848*/ void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss);
                /*0x20cda78*/ System.Xml.XmlWriter get_Writer();
                /*0x20cda80*/ void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback);
                /*0x20cdb58*/ System.Exception CreateUnknownAnyElementException(string name, string ns);
                /*0x20cdbf4*/ System.Exception CreateUnknownTypeException(object o);
                /*0x20cdc1c*/ System.Exception CreateUnknownTypeException(System.Type type);
                /*0x20cdca8*/ string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName);
                /*0x20cde4c*/ string GetId(object o, bool addToReferencesList);
                /*0x20cdf74*/ bool AlreadyQueued(object ob);
                /*0x20cdfb4*/ string GetNamespacePrefix(string ns);
                /*0x20cdd7c*/ string GetQualifiedName(string name, string ns);
                void InitCallbacks();
                /*0x20ce100*/ void TopLevelElement();
                /*0x20ce10c*/ void WriteAttribute(string localName, string ns, string value);
                /*0x20ce0dc*/ void WriteAttribute(string prefix, string localName, string ns, string value);
                /*0x20ce120*/ void WriteXmlNode(System.Xml.XmlNode node);
                /*0x20ce1cc*/ void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x20ce3bc*/ void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x20ce5b0*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value);
                /*0x20ce5b8*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x20ce804*/ void WriteElementString(string localName, string ns, string value);
                /*0x20ce80c*/ void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x20ce7e4*/ void WriteEndElement();
                /*0x20ce974*/ void WriteEndElement(object o);
                /*0x20ce9c0*/ void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns);
                /*0x20cee14*/ void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x20ceed8*/ void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value);
                /*0x20cef98*/ void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x20cefa4*/ void WriteNullableStringLiteral(string name, string ns, string value);
                /*0x20ce2f8*/ void WriteNullTagEncoded(string name, string ns);
                /*0x20ce4e8*/ void WriteNullTagLiteral(string name, string ns);
                /*0x20cefb4*/ void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable);
                /*0x20cf624*/ void WriteReferencedElements();
                /*0x20cf51c*/ bool IsPrimitiveArray(System.Xml.Serialization.TypeData td);
                /*0x20cf840*/ void WriteArray(object o, System.Xml.Serialization.TypeData td);
                /*0x20cfb38*/ void WriteReferencingElement(string n, string ns, object o, bool isNullable);
                /*0x20cf4a0*/ void CheckReferenceQueue();
                /*0x20cfca4*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable);
                /*0x20cfcb0*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
                /*0x20cfe08*/ void WriteStartDocument();
                /*0x20ce6ec*/ void WriteStartElement(string name, string ns);
                /*0x20cf490*/ void WriteStartElement(string name, string ns, bool writePrefixed);
                /*0x20cfe6c*/ void WriteStartElement(string name, string ns, object o);
                /*0x20cfe60*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed);
                /*0x20cfe78*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Collections.ICollection namespaces);
                /*0x20d0714*/ void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
                /*0x20d0a0c*/ void WriteValue(string value);
                /*0x20d0a38*/ void WriteXmlAttribute(System.Xml.XmlNode node, object container);
                /*0x20ce6fc*/ void WriteXsiType(string name, string ns);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationWriteCallback Callback;

                    /*0x16c8228*/ WriteCallbackInfo();
                }
            }

            class XmlSerializationWriterInterpreter : System.Xml.Serialization.XmlSerializationWriter
            {
                /*0x48*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0x50*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x20cc700*/ object ImplicitConvert(object obj, System.Type type);
                /*0x20d0ccc*/ XmlSerializationWriterInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x20d0d04*/ void InitCallbacks();
                /*0x20d10c0*/ void WriteRoot(object ob);
                /*0x20d12c0*/ void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem);
                /*0x20d19e8*/ void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, object[] parameters);
                /*0x20d1c24*/ void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x20d1d50*/ void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x20d24f4*/ void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x20d1bdc*/ void WriteMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x20d1df8*/ void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x20d259c*/ void WriteElementMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x20d2f3c*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x20d2ce0*/ bool MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x20d3284*/ void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, object memberValue);
                /*0x20d45d4*/ void WritePrimitiveValueLiteral(object memberValue, string name, string ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x20d4898*/ void WritePrimitiveValueEncoded(object memberValue, string name, string ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x20d4b68*/ void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x20d37ec*/ void WriteListContent(object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, object ob, System.Text.StringBuilder targetString);
                /*0x20d4d60*/ int GetListCount(System.Xml.Serialization.TypeData listType, object ob);
                /*0x20d3fcc*/ void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, object memberValue);
                /*0x20d4e9c*/ void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x20d4ee4*/ void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x20d3014*/ string GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, object value);
                /*0x20d4f20*/ string GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);

                class CallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x16c8230*/ CallbackInfo(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x16c8268*/ void WriteObject(object ob);
                    /*0x16c82bc*/ void WriteEnum(object ob);
                }
            }

            class XmlSerializer
            {
                static /*0x0*/ int generationThreshold;
                static /*0x4*/ bool backgroundGeneration;
                static /*0x5*/ bool deleteTempFiles;
                static /*0x6*/ bool generatorFallback;
                static /*0x8*/ System.Collections.Hashtable serializerTypes;
                static /*0x10*/ System.Text.Encoding DefaultEncoding;
                /*0x10*/ bool customSerializer;
                /*0x18*/ System.Xml.Serialization.XmlMapping typeMapping;
                /*0x20*/ System.Xml.Serialization.XmlSerializer.SerializerData serializerData;
                /*0x28*/ System.Xml.Serialization.UnreferencedObjectEventHandler onUnreferencedObject;
                /*0x30*/ System.Xml.Serialization.XmlAttributeEventHandler onUnknownAttribute;
                /*0x38*/ System.Xml.Serialization.XmlElementEventHandler onUnknownElement;
                /*0x40*/ System.Xml.Serialization.XmlNodeEventHandler onUnknownNode;

                static /*0x20d4fec*/ XmlSerializer();
                /*0x20d50d4*/ XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x20d5270*/ System.Xml.Serialization.XmlMapping get_Mapping();
                /*0x20d5278*/ void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x20d5298*/ void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e);
                /*0x20d52b8*/ void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x20d52d8*/ void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x20d52f8*/ System.Xml.Serialization.XmlSerializationReader CreateReader();
                /*0x20d5338*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                /*0x20d5378*/ object Deserialize(System.IO.TextReader textReader);
                /*0x20d5410*/ object Deserialize(System.Xml.XmlReader xmlReader);
                /*0x20d54e8*/ object Deserialize(System.Xml.Serialization.XmlSerializationReader reader);
                /*0x20d5804*/ void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer);
                /*0x20d59fc*/ void Serialize(System.IO.TextWriter textWriter, object o);
                /*0x20d5d90*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o);
                /*0x20d5a90*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces);
                /*0x20d5d98*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping);
                /*0x20d548c*/ System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping);

                class SerializerData
                {
                    /*0x10*/ System.Reflection.MethodInfo ReaderMethod;
                    /*0x18*/ System.Type WriterType;
                    /*0x20*/ System.Reflection.MethodInfo WriterMethod;
                    /*0x28*/ System.Xml.Serialization.XmlSerializerImplementation Implementation;

                    /*0x16c8310*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                }
            }

            class XmlSerializerFactory
            {
                static /*0x0*/ System.Collections.Hashtable serializersBySource;

                static /*0x20d62a0*/ XmlSerializerFactory();
                /*0x20d5fe0*/ XmlSerializerFactory();
                /*0x20d5fe8*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type);
                /*0x20d628c*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root);
                /*0x20d5ffc*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
            }

            class XmlSerializerImplementation
            {
                /*0x20d6314*/ System.Xml.Serialization.XmlSerializationWriter get_Writer();
            }

            class XmlTextAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ System.Type type;

                /*0x2399700*/ XmlTextAttribute();
                /*0x2399708*/ string get_DataType();
                /*0x2399760*/ System.Type get_Type();
                /*0x2399768*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeAttribute : System.Attribute
            {
                /*0x10*/ bool includeInSchema;
                /*0x18*/ string ns;
                /*0x20*/ string typeName;

                /*0x1bc9f50*/ bool get_IncludeInSchema();
                /*0x1bc9f58*/ string get_Namespace();
                /*0x1bc9f60*/ string get_TypeName();
                /*0x1bc9fb8*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeMapElementInfo
            {
                /*0x10*/ string _elementName;
                /*0x18*/ string _namespace;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x28*/ System.Xml.Serialization.XmlTypeMapMember _member;
                /*0x30*/ object _choiceValue;
                /*0x38*/ bool _isNullable;
                /*0x3c*/ int _nestingLevel;
                /*0x40*/ System.Xml.Serialization.XmlTypeMapping _mappedType;
                /*0x48*/ System.Xml.Serialization.TypeData _type;
                /*0x50*/ bool _wrappedElement;
                /*0x54*/ int _explicitOrder;

                /*0x1bca0a4*/ XmlTypeMapElementInfo(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type);
                /*0x1bca154*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1bca15c*/ object get_ChoiceValue();
                /*0x1bca164*/ void set_ChoiceValue(object value);
                /*0x1bca16c*/ string get_ElementName();
                /*0x1bca174*/ void set_ElementName(string value);
                /*0x1bca17c*/ string get_Namespace();
                /*0x1bca184*/ void set_Namespace(string value);
                /*0x1bca18c*/ string get_DataTypeNamespace();
                /*0x1bca270*/ string get_DataTypeName();
                /*0x1bca2a0*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1bca2a8*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1bca2b0*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x1bca2b8*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
                /*0x1bca2c0*/ bool get_IsNullable();
                /*0x1bca2c8*/ void set_IsNullable(bool value);
                /*0x1bca2d4*/ System.Xml.Serialization.XmlTypeMapMember get_Member();
                /*0x1bca2dc*/ void set_NestingLevel(int value);
                /*0x1bca2e4*/ bool get_MultiReferenceType();
                /*0x1bca304*/ bool get_WrappedElement();
                /*0x1bca30c*/ void set_WrappedElement(bool value);
                /*0x1bca318*/ bool get_IsTextElement();
                /*0x1bca368*/ void set_IsTextElement(bool value);
                /*0x1bca430*/ bool get_IsUnnamedAnyElement();
                /*0x1bca488*/ void set_IsUnnamedAnyElement(bool value);
                /*0x1bca540*/ int get_ExplicitOrder();
                /*0x1bca548*/ void set_ExplicitOrder(int value);
                /*0x1bca550*/ bool Equals(object other);
                /*0x1bca6a8*/ int GetHashCode();
            }

            class XmlTypeMapElementInfoList : System.Collections.ArrayList
            {
                /*0x1bca6b0*/ XmlTypeMapElementInfoList();
            }

            class XmlTypeMapMember
            {
                /*0x10*/ string _name;
                /*0x18*/ int _index;
                /*0x1c*/ int _globalIndex;
                /*0x20*/ int _specifiedGlobalIndex;
                /*0x28*/ System.Xml.Serialization.TypeData _typeData;
                /*0x30*/ System.Reflection.MemberInfo _member;
                /*0x38*/ System.Reflection.MemberInfo _specifiedMember;
                /*0x40*/ System.Reflection.MethodInfo _shouldSerialize;
                /*0x48*/ object _defaultValue;
                /*0x50*/ int _flags;

                static /*0x1bcaad4*/ object GetValue(object ob, string name);
                static /*0x1bcaedc*/ void SetValue(object ob, string name, object value);
                /*0x1bca714*/ XmlTypeMapMember();
                /*0x1bca790*/ string get_Name();
                /*0x1bca798*/ void set_Name(string value);
                /*0x1bca7a0*/ object get_DefaultValue();
                /*0x1bca7a8*/ void set_DefaultValue(object value);
                /*0x1bca7b0*/ bool IsReadOnly(System.Type type);
                /*0x1bcac30*/ object GetValue(object ob);
                /*0x1bcad78*/ void SetValue(object ob, object value);
                /*0x1bca870*/ void InitMember(System.Type type);
                /*0x1bcb040*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1bcb048*/ void set_TypeData(System.Xml.Serialization.TypeData value);
                /*0x1bcb050*/ int get_Index();
                /*0x1bcb058*/ void set_Index(int value);
                /*0x1bcb060*/ int get_GlobalIndex();
                /*0x1bcb068*/ void set_GlobalIndex(int value);
                /*0x1bcb070*/ bool get_IsOptionalValueType();
                /*0x1bcb07c*/ void set_IsOptionalValueType(bool value);
                /*0x1bcb0a8*/ bool get_IsReturnValue();
                /*0x1bcb0b4*/ void set_IsReturnValue(bool value);
                /*0x1bcb0e0*/ void CheckOptionalValueType(System.Type type);
                /*0x1bcb164*/ bool GetValueSpecified(object ob);
                /*0x1bcb3d8*/ void SetValueSpecified(object ob, bool value);
            }

            class XmlTypeMapMemberAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ string _attributeName;
                /*0x60*/ string _namespace;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapping _mappedType;

                /*0x1bcbd00*/ XmlTypeMapMemberAttribute();
                /*0x1bcbd50*/ string get_AttributeName();
                /*0x1bcbd58*/ void set_AttributeName(string value);
                /*0x1bcbd60*/ string get_Namespace();
                /*0x1bcbd68*/ void set_Namespace(string value);
                /*0x1bcbd70*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1bcbd78*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x1bcbd80*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
            }

            class XmlTypeMapMemberElement : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;
                /*0x60*/ string _choiceMember;
                /*0x68*/ bool _isTextCollector;
                /*0x70*/ System.Xml.Serialization.TypeData _choiceTypeData;

                /*0x1bcbd88*/ XmlTypeMapMemberElement();
                /*0x1bcb9b8*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo();
                /*0x1bcbd8c*/ void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x1bcbd94*/ string get_ChoiceMember();
                /*0x1bcbd9c*/ void set_ChoiceMember(string value);
                /*0x1bcbda4*/ System.Xml.Serialization.TypeData get_ChoiceTypeData();
                /*0x1bcbdac*/ void set_ChoiceTypeData(System.Xml.Serialization.TypeData value);
                /*0x1bcbdb4*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, object memberValue);
                /*0x1bcc418*/ void SetChoice(object ob, object choice);
                /*0x1bcc428*/ bool get_IsXmlTextCollector();
                /*0x1bcc430*/ void set_IsXmlTextCollector(bool value);
            }

            class XmlTypeMapMemberList : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x1bcc460*/ XmlTypeMapMemberList();
            }

            class XmlTypeMapMemberExpandable : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x78*/ int _flatArrayIndex;

                /*0x1bcbcfc*/ XmlTypeMapMemberExpandable();
                /*0x1bcc43c*/ int get_FlatArrayIndex();
                /*0x1bcc444*/ void set_FlatArrayIndex(int value);
            }

            class XmlTypeMapMemberFlatList : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x80*/ System.Xml.Serialization.ListMap _listMap;

                /*0x1bcc45c*/ XmlTypeMapMemberFlatList();
                /*0x1bcc44c*/ System.Xml.Serialization.ListMap get_ListMap();
                /*0x1bcc454*/ void set_ListMap(System.Xml.Serialization.ListMap value);
            }

            class XmlTypeMapMemberAnyElement : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x1bcbcf8*/ XmlTypeMapMemberAnyElement();
                /*0x1bcb694*/ bool IsElementDefined(string name, string ns);
                /*0x1bcba1c*/ bool get_IsDefaultAny();
            }

            class XmlTypeMapMemberAnyAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x1bcb690*/ XmlTypeMapMemberAnyAttribute();
            }

            class XmlTypeMapMemberNamespaces : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x1bcc464*/ XmlTypeMapMemberNamespaces();
            }

            class XmlTypeMapping : System.Xml.Serialization.XmlMapping
            {
                /*0x48*/ string xmlType;
                /*0x50*/ string xmlTypeNamespace;
                /*0x58*/ System.Xml.Serialization.TypeData type;
                /*0x60*/ System.Xml.Serialization.XmlTypeMapping baseMap;
                /*0x68*/ bool multiReferenceType;
                /*0x69*/ bool includeInSchema;
                /*0x6a*/ bool isNullable;
                /*0x6b*/ bool isAny;
                /*0x70*/ System.Collections.ArrayList _derivedTypes;

                /*0x1bcc468*/ XmlTypeMapping(string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
                /*0x1bcc514*/ string get_TypeFullName();
                /*0x1bcc530*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1bcc538*/ string get_XmlType();
                /*0x1bcc540*/ void set_XmlType(string value);
                /*0x1bca218*/ string get_XmlTypeNamespace();
                /*0x1bcc548*/ void set_XmlTypeNamespace(string value);
                /*0x1bcc550*/ bool get_HasXmlTypeNamespace();
                /*0x1bcc560*/ System.Collections.ArrayList get_DerivedTypes();
                /*0x1bcc568*/ bool get_MultiReferenceType();
                /*0x1bcc570*/ System.Xml.Serialization.XmlTypeMapping get_BaseMap();
                /*0x1bcc578*/ void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value);
                /*0x1bcc580*/ void set_IncludeInSchema(bool value);
                /*0x1bcc58c*/ bool get_IsNullable();
                /*0x1bcc594*/ void set_IsNullable(bool value);
                /*0x1bcc5a0*/ bool get_IsAny();
                /*0x1bcc5a8*/ void set_IsAny(bool value);
                /*0x1bcc5b4*/ System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType);
                /*0x1bcc740*/ System.Xml.Serialization.XmlTypeMapping GetRealElementMap(string name, string ens);
                /*0x1bccae8*/ void UpdateRoot(System.Xml.XmlQualifiedName qname);
            }

            class XmlSerializableMapping : System.Xml.Serialization.XmlTypeMapping
            {
                /*0x78*/ System.Xml.Schema.XmlSchema _schema;
                /*0x80*/ System.Xml.Schema.XmlSchemaComplexType _schemaType;
                /*0x88*/ System.Xml.XmlQualifiedName _schemaTypeName;

                /*0x1acf7c4*/ XmlSerializableMapping(System.Xml.Serialization.XmlRootAttribute root, string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
            }

            class ClassMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Collections.Hashtable _elements;
                /*0x18*/ System.Collections.ArrayList _elementMembers;
                /*0x20*/ System.Collections.Hashtable _attributeMembers;
                /*0x28*/ System.Xml.Serialization.XmlTypeMapMemberAttribute[] _attributeMembersArray;
                /*0x30*/ System.Collections.ArrayList _flatLists;
                /*0x38*/ System.Collections.ArrayList _allMembers;
                /*0x40*/ System.Collections.ArrayList _membersWithDefault;
                /*0x48*/ System.Collections.ArrayList _listMembers;
                /*0x50*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement _defaultAnyElement;
                /*0x58*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;
                /*0x60*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces _namespaceDeclarations;
                /*0x68*/ System.Xml.Serialization.XmlTypeMapMember _xmlTextCollector;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapMember _returnMember;
                /*0x78*/ bool _ignoreMemberNamespace;
                /*0x79*/ bool _canBeSimpleType;
                /*0x7a*/ System.Nullable<bool> _isOrderDependentMap;

                /*0x1593b78*/ ClassMap();
                /*0x1591bc8*/ void AddMember(System.Xml.Serialization.XmlTypeMapMember member);
                /*0x15928b4*/ void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member);
                /*0x1592960*/ System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(string name, string ns);
                /*0x1592a20*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder);
                /*0x1592db4*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns);
                /*0x15927bc*/ string BuildKey(string name, string ns, int explicitOrder);
                /*0x1593130*/ bool get_IsOrderDependentMap();
                /*0x15934e8*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember();
                /*0x15934f0*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember();
                /*0x15934f8*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations();
                /*0x1593500*/ System.Collections.ICollection get_AttributeMembers();
                /*0x15938d0*/ System.Collections.ICollection get_ElementMembers();
                /*0x15938d8*/ System.Collections.ArrayList get_AllMembers();
                /*0x15938e0*/ System.Collections.ArrayList get_FlatLists();
                /*0x15938e8*/ System.Collections.ArrayList get_ListMembers();
                /*0x15938f0*/ System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector();
                /*0x15938f8*/ System.Xml.Serialization.XmlTypeMapMember get_ReturnMember();
                /*0x1593900*/ System.Xml.XmlQualifiedName get_SimpleContentBaseType();
                /*0x1593af4*/ void SetCanBeSimpleType(bool can);
                /*0x1593b00*/ bool get_HasSimpleContent();
            }

            class ListMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;
                /*0x18*/ string _choiceMember;

                /*0x14d02a4*/ ListMap();
                /*0x14cf10c*/ void set_ChoiceMember(string value);
                /*0x14cf114*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo();
                /*0x14cf11c*/ void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x14cf124*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue);
                /*0x14cf934*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(string elementName, string ns);
                /*0x14cfc34*/ System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement();
                /*0x14cff10*/ void GetArrayType(int itemCount, ref string localName, ref string ns);
                /*0x14d013c*/ bool Equals(object other);
                /*0x14d029c*/ int GetHashCode();
            }

            class EnumMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.EnumMap.EnumMapMember[] _members;
                /*0x18*/ bool _isFlags;
                /*0x20*/ string[] _enumNames;
                /*0x28*/ string[] _xmlNames;
                /*0x30*/ long[] _values;

                /*0x14c912c*/ EnumMap(System.Xml.Serialization.EnumMap.EnumMapMember[] members, bool isFlags);
                /*0x14c92d8*/ bool get_IsFlags();
                /*0x14c92e0*/ string[] get_EnumNames();
                /*0x14c92e8*/ string[] get_XmlNames();
                /*0x14c92f0*/ long[] get_Values();
                /*0x14c92f8*/ string GetXmlName(string typeName, object enumValue);
                /*0x14c96c0*/ string GetEnumName(string typeName, string xmlName);

                class EnumMapMember
                {
                    /*0x10*/ string _xmlName;
                    /*0x18*/ string _enumName;
                    /*0x20*/ long _value;

                    /*0x16c1214*/ EnumMapMember(string xmlName, string enumName, long value);
                    /*0x16c1254*/ string get_XmlName();
                    /*0x16c125c*/ string get_EnumName();
                    /*0x16c1264*/ long get_Value();
                }
            }
        }

        namespace Schema
        {
            class AxisElement
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis curNode;
                /*0x18*/ int rootDepth;
                /*0x1c*/ int curDepth;
                /*0x20*/ bool isMatch;

                /*0x158954c*/ AxisElement(System.Xml.Schema.DoubleLinkAxis node, int depth);
                /*0x1589544*/ System.Xml.Schema.DoubleLinkAxis get_CurNode();
                /*0x158958c*/ void SetDepth(int depth);
                /*0x1589594*/ void MoveToParent(int depth, System.Xml.Schema.ForwardAxis parent);
                /*0x1589684*/ bool MoveToChild(string name, string URN, int depth, System.Xml.Schema.ForwardAxis parent);
            }

            class AxisStack
            {
                /*0x10*/ System.Collections.ArrayList stack;
                /*0x18*/ System.Xml.Schema.ForwardAxis subtree;
                /*0x20*/ System.Xml.Schema.ActiveAxis parent;

                static /*0x15897ec*/ bool Equal(string thisname, string thisURN, string name, string URN);
                /*0x1586ae4*/ AxisStack(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent);
                /*0x158986c*/ System.Xml.Schema.ForwardAxis get_Subtree();
                /*0x1589874*/ int get_Length();
                /*0x1589898*/ void Push(int depth);
                /*0x1589930*/ void Pop();
                /*0x1586f38*/ void MoveToParent(string name, string URN, int depth);
                /*0x1586cd0*/ bool MoveToChild(string name, string URN, int depth);
                /*0x1587194*/ bool MoveToAttribute(string name, string URN, int depth);
            }

            class ActiveAxis
            {
                /*0x10*/ int currentDepth;
                /*0x14*/ bool isActive;
                /*0x18*/ System.Xml.Schema.Asttree axisTree;
                /*0x20*/ System.Collections.ArrayList axisStack;

                /*0x1586934*/ ActiveAxis(System.Xml.Schema.Asttree axisTree);
                /*0x1586918*/ int get_CurrentDepth();
                /*0x1586920*/ void Reactivate();
                /*0x1586b8c*/ bool MoveToStartElement(string localname, string URN);
                /*0x1586e1c*/ bool EndElement(string localname, string URN);
                /*0x1587084*/ bool MoveToAttribute(string localname, string URN);
            }

            class DoubleLinkAxis : MS.Internal.Xml.XPath.Axis
            {
                /*0x40*/ MS.Internal.Xml.XPath.Axis next;

                static /*0x1c01e18*/ System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis);
                /*0x1c01db4*/ DoubleLinkAxis(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis);
                /*0x1c01da4*/ MS.Internal.Xml.XPath.Axis get_Next();
                /*0x1c01dac*/ void set_Next(MS.Internal.Xml.XPath.Axis value);
            }

            class ForwardAxis
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis topNode;
                /*0x18*/ System.Xml.Schema.DoubleLinkAxis rootNode;
                /*0x20*/ bool isAttribute;
                /*0x21*/ bool isDss;
                /*0x22*/ bool isSelfAxis;

                /*0x14ca1c8*/ ForwardAxis(System.Xml.Schema.DoubleLinkAxis axis, bool isdesorself);
                /*0x14ca1a0*/ System.Xml.Schema.DoubleLinkAxis get_RootNode();
                /*0x14ca1a8*/ System.Xml.Schema.DoubleLinkAxis get_TopNode();
                /*0x14ca1b0*/ bool get_IsAttribute();
                /*0x14ca1b8*/ bool get_IsDss();
                /*0x14ca1c0*/ bool get_IsSelfAxis();
            }

            class Asttree
            {
                /*0x10*/ System.Collections.ArrayList fAxisArray;
                /*0x18*/ string xpathexpr;
                /*0x20*/ bool isField;
                /*0x28*/ System.Xml.XmlNamespaceManager nsmgr;

                static /*0x15889e8*/ bool IsNameTest(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1588a1c*/ bool IsAttribute(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1588a50*/ bool IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1588a90*/ bool IsSelf(MS.Internal.Xml.XPath.Axis ast);
                /*0x1588144*/ Asttree(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x158813c*/ System.Collections.ArrayList get_SubtreeArray();
                /*0x1588198*/ void CompileXPath(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x1588ad0*/ void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr);
            }

            class AutoValidator : System.Xml.Schema.BaseValidator
            {
                /*0x1588da0*/ AutoValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x1588ee8*/ bool get_PreserveWhitespace();
                /*0x1588ef0*/ void Validate();
                /*0x158932c*/ void CompleteValidation();
                /*0x1589330*/ object FindId(string name);
                /*0x1588fdc*/ System.Xml.ValidationType DetectValidationType();
            }

            class BaseProcessor
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x28*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x30*/ int errorCount;
                /*0x38*/ string NsXml;

                /*0x1589de4*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x1589e6c*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x1589f04*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1589f0c*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x1589f84*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x1589f8c*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x1589f94*/ bool get_HasErrors();
                /*0x1589fa4*/ void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x158a408*/ bool IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x158a660*/ bool IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x158a534*/ bool IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x158a804*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source);
                /*0x158a778*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source);
                /*0x158a944*/ void SendValidationEvent(string code, string msg1, string msg2, System.Xml.Schema.XmlSchemaObject source);
                /*0x158aa64*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source);
                /*0x158ab2c*/ void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition);
                /*0x158ac64*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x158acec*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x158acf4*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x158a880*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x158ad84*/ void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BaseValidator
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaCollection schemaCollection;
                /*0x18*/ System.Xml.IValidationEventHandling eventHandling;
                /*0x20*/ System.Xml.XmlNameTable nameTable;
                /*0x28*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x30*/ System.Xml.PositionInfo positionInfo;
                /*0x38*/ System.Xml.XmlResolver xmlResolver;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x50*/ System.Xml.XmlValidatingReaderImpl reader;
                /*0x58*/ System.Xml.XmlQualifiedName elementName;
                /*0x60*/ System.Xml.Schema.ValidationState context;
                /*0x68*/ System.Text.StringBuilder textValue;
                /*0x70*/ string textString;
                /*0x78*/ bool hasSibling;
                /*0x79*/ bool checkDatatype;

                static /*0x158baa0*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition);
                static /*0x158bc78*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, System.Xml.IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition);
                static /*0x158be78*/ System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x158ae2c*/ BaseValidator(System.Xml.Schema.BaseValidator other);
                /*0x1588e2c*/ BaseValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x158aea4*/ System.Xml.XmlValidatingReaderImpl get_Reader();
                /*0x158aeac*/ System.Xml.Schema.XmlSchemaCollection get_SchemaCollection();
                /*0x158aeb4*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1589338*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x158aebc*/ System.Xml.PositionInfo get_PositionInfo();
                /*0x158aec4*/ System.Xml.XmlResolver get_XmlResolver();
                /*0x158aecc*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x158aed4*/ System.Uri get_BaseUri();
                /*0x158aedc*/ void set_BaseUri(System.Uri value);
                /*0x158aee4*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x158afc0*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x158afc8*/ void set_DtdInfo(System.Xml.IDtdInfo value);
                /*0x158b0ac*/ bool get_PreserveWhitespace();
                /*0x158b0b4*/ void Validate();
                /*0x158b0b8*/ void CompleteValidation();
                /*0x158b0bc*/ object FindId(string name);
                /*0x158b0c4*/ void ValidateText();
                /*0x158b60c*/ void ValidateWhitespace();
                /*0x158b594*/ void SaveTextValue(string value);
                /*0x158b754*/ void SendValidationEvent(string code);
                /*0x158b4a0*/ void SendValidationEvent(string code, string[] args);
                /*0x158b3ac*/ void SendValidationEvent(string code, string arg);
                /*0x158b7b8*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x158b8b0*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x158b9a8*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x158b7c0*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BitSet
            {
                /*0x10*/ int count;
                /*0x18*/ uint[] bits;

                /*0x158ff60*/ BitSet();
                /*0x1587424*/ BitSet(int count);
                /*0x158ff70*/ int get_Count();
                /*0x1587868*/ bool get_Item(int index);
                /*0x158ffe0*/ void Clear();
                /*0x15875f0*/ void Set(int index);
                /*0x158ff78*/ bool Get(int index);
                /*0x15900e4*/ int NextSet(int startFrom);
                /*0x1590190*/ void And(System.Xml.Schema.BitSet other);
                /*0x1590284*/ void Or(System.Xml.Schema.BitSet other);
                /*0x159033c*/ int GetHashCode();
                /*0x1590380*/ bool Equals(object obj);
                /*0x15904dc*/ System.Xml.Schema.BitSet Clone();
                /*0x159059c*/ bool get_IsEmpty();
                /*0x1590610*/ bool Intersects(System.Xml.Schema.BitSet other);
                /*0x158ff68*/ int Subscript(int bitIndex);
                /*0x1590044*/ void EnsureLength(int nRequiredLength);
            }

            class ChameleonKey
            {
                /*0x10*/ string targetNS;
                /*0x18*/ System.Uri chameleonLocation;
                /*0x20*/ System.Xml.Schema.XmlSchema originalSchema;
                /*0x28*/ int hashCode;

                /*0x159105c*/ ChameleonKey(string ns, System.Xml.Schema.XmlSchema originalSchema);
                /*0x15910c0*/ int GetHashCode();
                /*0x1591144*/ bool Equals(object obj);
            }

            class CompiledIdentityConstraint
            {
                static /*0x0*/ System.Xml.Schema.CompiledIdentityConstraint Empty;
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;
                /*0x20*/ System.Xml.Schema.Asttree selector;
                /*0x28*/ System.Xml.Schema.Asttree[] fields;
                /*0x30*/ System.Xml.XmlQualifiedName refer;

                static /*0x1594658*/ CompiledIdentityConstraint();
                /*0x1594110*/ CompiledIdentityConstraint();
                /*0x1594190*/ CompiledIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr);
                /*0x15940f8*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role();
                /*0x1594100*/ System.Xml.Schema.Asttree get_Selector();
                /*0x1594108*/ System.Xml.Schema.Asttree[] get_Fields();

                enum ConstraintRole
                {
                    Unique = 0,
                    Key = 1,
                    Keyref = 2,
                }
            }

            class ConstraintStruct
            {
                /*0x10*/ System.Xml.Schema.CompiledIdentityConstraint constraint;
                /*0x18*/ System.Xml.Schema.SelectorActiveAxis axisSelector;
                /*0x20*/ System.Collections.ArrayList axisFields;
                /*0x28*/ System.Collections.Hashtable qualifiedTable;
                /*0x30*/ System.Collections.Hashtable keyrefTable;
                /*0x38*/ int tableDim;

                /*0x1befb58*/ ConstraintStruct(System.Xml.Schema.CompiledIdentityConstraint constraint);
                /*0x1befb50*/ int get_TableDim();
            }

            class LocatedActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ int column;
                /*0x2c*/ bool isMatched;
                /*0x30*/ System.Xml.Schema.KeySequence Ks;

                /*0x14d02b4*/ LocatedActiveAxis(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, int column);
                /*0x14d02ac*/ int get_Column();
                /*0x14d02f4*/ void Reactivate(System.Xml.Schema.KeySequence ks);
            }

            class SelectorActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ System.Xml.Schema.ConstraintStruct cs;
                /*0x30*/ System.Collections.ArrayList KSs;
                /*0x38*/ int KSpointer;

                /*0x1b0ebec*/ SelectorActiveAxis(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs);
                /*0x1b0eb40*/ int get_lastDepth();
                /*0x1b0ec68*/ bool EndElement(string localname, string URN);
                /*0x1b0ecb8*/ int PushKS(int errline, int errcol);
                /*0x1b0efa4*/ System.Xml.Schema.KeySequence PopKS();
            }

            class KSStruct
            {
                /*0x10*/ int depth;
                /*0x18*/ System.Xml.Schema.KeySequence ks;
                /*0x20*/ System.Xml.Schema.LocatedActiveAxis[] fields;

                /*0x14ce078*/ KSStruct(System.Xml.Schema.KeySequence ks, int dim);
            }

            class TypedObject
            {
                /*0x10*/ System.Xml.Schema.TypedObject.DecimalStruct dstruct;
                /*0x18*/ object ovalue;
                /*0x20*/ string svalue;
                /*0x28*/ System.Xml.Schema.XmlSchemaDatatype xsdtype;
                /*0x30*/ int dim;
                /*0x34*/ bool isList;

                /*0x1b17c84*/ TypedObject(object obj, string svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype);
                /*0x1b17c2c*/ int get_Dim();
                /*0x1b17c34*/ bool get_IsList();
                /*0x1b17c3c*/ bool get_IsDecimal();
                /*0x1b17c58*/ decimal[] get_Dvalue();
                /*0x1b17c74*/ object get_Value();
                /*0x1b17c7c*/ System.Xml.Schema.XmlSchemaDatatype get_Type();
                /*0x1b17dec*/ string ToString();
                /*0x1b17df4*/ void SetDecimal();
                /*0x1b18090*/ bool ListDValueEquals(System.Xml.Schema.TypedObject other);
                /*0x1b181bc*/ bool Equals(System.Xml.Schema.TypedObject other);

                class DecimalStruct
                {
                    /*0x10*/ bool isDecimal;
                    /*0x18*/ decimal[] dvalue;

                    /*0x16c4a04*/ DecimalStruct();
                    /*0x16c4a64*/ DecimalStruct(int dim);
                    /*0x16c49e8*/ bool get_IsDecimal();
                    /*0x16c49f0*/ void set_IsDecimal(bool value);
                    /*0x16c49fc*/ decimal[] get_Dvalue();
                }
            }

            class KeySequence
            {
                /*0x10*/ System.Xml.Schema.TypedObject[] ks;
                /*0x18*/ int dim;
                /*0x1c*/ int hashcode;
                /*0x20*/ int posline;
                /*0x24*/ int poscol;

                /*0x14ce410*/ KeySequence(int dim, int line, int col);
                /*0x14ce49c*/ int get_PosLine();
                /*0x14ce4a4*/ int get_PosCol();
                /*0x14ce4ac*/ object get_Item(int index);
                /*0x14ce4e8*/ void set_Item(int index, object value);
                /*0x14ce5ec*/ bool IsQualified();
                /*0x14ce658*/ int GetHashCode();
                /*0x14ce9d8*/ bool Equals(object other);
                /*0x14ceadc*/ string ToString();
            }

            class UpaException : System.Exception
            {
                /*0x88*/ object particle1;
                /*0x90*/ object particle2;

                /*0x1b1a5cc*/ UpaException(object particle1, object particle2);
                /*0x1b1a648*/ object get_Particle1();
                /*0x1b1a650*/ object get_Particle2();
            }

            class SymbolsDictionary
            {
                /*0x10*/ int last;
                /*0x18*/ System.Collections.Hashtable names;
                /*0x20*/ System.Collections.Hashtable wildcards;
                /*0x28*/ System.Collections.ArrayList particles;
                /*0x30*/ object particleLast;
                /*0x38*/ bool isUpaEnforced;

                /*0x1b10284*/ SymbolsDictionary();
                /*0x1b10320*/ int get_Count();
                /*0x1b1032c*/ bool get_IsUpaEnforced();
                /*0x1b10334*/ void set_IsUpaEnforced(bool value);
                /*0x1b10340*/ int AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x1b10480*/ void AddNamespaceList(System.Xml.Schema.NamespaceList list, object particle, bool allowLocal);
                /*0x1b107e0*/ void AddWildcard(string wildcard, object particle);
                /*0x1b10954*/ System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list);
                /*0x1b11094*/ int get_Item(System.Xml.XmlQualifiedName name);
                /*0x1b11158*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x1b1118c*/ object GetParticle(int symbol);
                /*0x1b111c4*/ string NameOf(int symbol);
            }

            struct Position
            {
                /*0x10*/ int symbol;
                /*0x18*/ object particle;

                /*0xaa2e18*/ Position(int symbol, object particle);
            }

            class Positions
            {
                /*0x10*/ System.Collections.ArrayList positions;

                /*0x14d6368*/ Positions();
                /*0x14d28c0*/ int Add(int symbol, object particle);
                /*0x14d2d78*/ System.Xml.Schema.Position get_Item(int pos);
                /*0x14d72c0*/ int get_Count();
            }

            class SyntaxTreeNode
            {
                /*0x1b11870*/ SyntaxTreeNode();
                void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                bool get_IsNullable();
                /*0x1b11868*/ bool get_IsRangeNode();
            }

            class LeafNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ int pos;

                /*0x14cec1c*/ LeafNode(int pos);
                /*0x14cec48*/ int get_Pos();
                /*0x14cec50*/ void set_Pos(int value);
                /*0x14cec58*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x14cec5c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x14ceca8*/ bool get_IsNullable();
            }

            class NamespaceListNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.NamespaceList namespaceList;
                /*0x18*/ object particle;

                /*0x14d2454*/ NamespaceListNode(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x14d248c*/ System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols);
                /*0x14d24b0*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x14d2954*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x14d2994*/ bool get_IsNullable();
            }

            class InteriorNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.SyntaxTreeNode leftChild;
                /*0x18*/ System.Xml.Schema.SyntaxTreeNode rightChild;

                /*0x14ce070*/ InteriorNode();
                /*0x14cddf0*/ System.Xml.Schema.SyntaxTreeNode get_LeftChild();
                /*0x14cddf8*/ void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x14cde00*/ System.Xml.Schema.SyntaxTreeNode get_RightChild();
                /*0x14cde08*/ void set_RightChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x14cde10*/ void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x14cdffc*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class SequenceNode : System.Xml.Schema.InteriorNode
            {
                /*0x1b0f5b4*/ SequenceNode();
                /*0x1b0f048*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1b0f440*/ bool get_IsNullable();
                /*0x1b0f5ac*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);

                struct SequenceConstructPosContext
                {
                    /*0x10*/ System.Xml.Schema.SequenceNode this_;
                    /*0x18*/ System.Xml.Schema.BitSet firstpos;
                    /*0x20*/ System.Xml.Schema.BitSet lastpos;
                    /*0x28*/ System.Xml.Schema.BitSet lastposLeft;
                    /*0x30*/ System.Xml.Schema.BitSet firstposRight;

                    /*0xac0c44*/ SequenceConstructPosContext(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos);
                }
            }

            class ChoiceNode : System.Xml.Schema.InteriorNode
            {
                static /*0x1591938*/ void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1591bc0*/ ChoiceNode();
                /*0x1591a10*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1591b24*/ bool get_IsNullable();
                /*0x1591bb8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class PlusNode : System.Xml.Schema.InteriorNode
            {
                /*0x14d6b88*/ PlusNode();
                /*0x14d8168*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x14d821c*/ bool get_IsNullable();
            }

            class QmarkNode : System.Xml.Schema.InteriorNode
            {
                /*0x1823364*/ QmarkNode();
                /*0x182333c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x182335c*/ bool get_IsNullable();
            }

            class StarNode : System.Xml.Schema.InteriorNode
            {
                /*0x1b0f7d4*/ StarNode();
                /*0x1b0f718*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1b0f7cc*/ bool get_IsNullable();
            }

            class LeafRangeNode : System.Xml.Schema.LeafNode
            {
                /*0x14*/ decimal min;
                /*0x24*/ decimal max;
                /*0x38*/ System.Xml.Schema.BitSet nextIteration;

                /*0x14cecb0*/ LeafRangeNode(decimal min, decimal max);
                /*0x14ced0c*/ LeafRangeNode(int pos, decimal min, decimal max);
                /*0x14ced68*/ decimal get_Max();
                /*0x14ced78*/ decimal get_Min();
                /*0x14ced88*/ System.Xml.Schema.BitSet get_NextIteration();
                /*0x14ced90*/ void set_NextIteration(System.Xml.Schema.BitSet value);
                /*0x14ced98*/ bool get_IsRangeNode();
                /*0x14ceda0*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class ContentValidator
            {
                static /*0x0*/ System.Xml.Schema.ContentValidator Empty;
                static /*0x8*/ System.Xml.Schema.ContentValidator TextOnly;
                static /*0x10*/ System.Xml.Schema.ContentValidator Mixed;
                static /*0x18*/ System.Xml.Schema.ContentValidator Any;
                /*0x10*/ System.Xml.Schema.XmlSchemaContentType contentType;
                /*0x14*/ bool isOpen;
                /*0x15*/ bool isEmptiable;

                static /*0x1bf003c*/ ContentValidator();
                static /*0x1befd88*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles);
                static /*0x1befe04*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, bool global);
                /*0x1befc60*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x1befc94*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x1befce0*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x1befce8*/ bool get_PreserveWhitespace();
                /*0x1befd04*/ bool get_IsEmptiable();
                /*0x1befd0c*/ bool get_IsOpen();
                /*0x1befd30*/ void set_IsOpen(bool value);
                /*0x1befd3c*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1befd40*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1befd70*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1befd78*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1befd80*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class ParticleContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x20*/ System.Xml.Schema.Positions positions;
                /*0x28*/ System.Collections.Stack stack;
                /*0x30*/ System.Xml.Schema.SyntaxTreeNode contentNode;
                /*0x38*/ bool isPartial;
                /*0x3c*/ int minMaxNodesCount;
                /*0x40*/ bool enableUpaCheck;

                /*0x14d616c*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x14d6174*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool enableUpaCheck);
                /*0x14d61f8*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x14d6238*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x14d6278*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x14d62b8*/ void Start();
                /*0x14d63cc*/ void OpenGroup();
                /*0x14d63f4*/ void CloseGroup();
                /*0x14d6548*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x14d6564*/ void AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x14d66fc*/ void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x14d6614*/ void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node);
                /*0x14d6790*/ void AddChoice();
                /*0x14d687c*/ void AddSequence();
                /*0x14d6968*/ void AddStar();
                /*0x14d6b28*/ void AddPlus();
                /*0x14d6b90*/ void AddQMark();
                /*0x14d6bf0*/ void AddLeafRange(decimal min, decimal max);
                /*0x14d69c8*/ void Closure(System.Xml.Schema.InteriorNode node);
                /*0x14d6ce8*/ System.Xml.Schema.ContentValidator Finish(bool useDFA);
                /*0x14d72e4*/ System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, ref System.Xml.Schema.BitSet posWithRangeTerminals);
                /*0x14d7794*/ void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos);
                /*0x14d75f8*/ System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos);
                /*0x14d792c*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos);
                /*0x14d7f94*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos);
                /*0x14d79c0*/ int[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, int endMarkerPos);
            }

            class DfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ int[][] transitionTable;
                /*0x20*/ System.Xml.Schema.SymbolsDictionary symbols;

                /*0x1c011e4*/ DfaContentValidator(int[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x1c01290*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1c0130c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1c01448*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1c01460*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1c01648*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class NfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x30*/ System.Xml.Schema.Positions positions;
                /*0x38*/ int endMarkerPos;

                /*0x14d29fc*/ NfaContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x14d2abc*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x14d2bc4*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x14d2e14*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x14d2e68*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x14d3058*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            struct RangePositionInfo
            {
                /*0x10*/ System.Xml.Schema.BitSet curpos;
                /*0x18*/ decimal[] rangeCounters;
            }

            class RangeContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.BitSet positionsWithRangeTerminals;
                /*0x30*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x38*/ System.Xml.Schema.Positions positions;
                /*0x40*/ int minMaxNodesCount;
                /*0x44*/ int endMarkerPos;

                /*0x1823f24*/ RangeContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, int minmaxNodesCount);
                /*0x1823fec*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1824134*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x18249c4*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x18249dc*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1824c64*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class AllElementsContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Collections.Hashtable elements;
                /*0x20*/ object[] particles;
                /*0x28*/ System.Xml.Schema.BitSet isRequired;
                /*0x30*/ int countRequired;

                /*0x1587314*/ AllElementsContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, int size, bool isEmptiable);
                /*0x1587498*/ bool AddElement(System.Xml.XmlQualifiedName name, object particle, bool isEmptiable);
                /*0x1587660*/ bool get_IsEmptiable();
                /*0x1587680*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1587718*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x158786c*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x15878c8*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1587ca4*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            enum XmlSchemaDatatypeVariety
            {
                Atomic = 0,
                List = 1,
                Union = 2,
            }

            class XsdSimpleValue
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaSimpleType xmlType;
                /*0x18*/ object typedValue;

                /*0x1a5fd7c*/ XsdSimpleValue(System.Xml.Schema.XmlSchemaSimpleType st, object value);
                /*0x1a5fdb4*/ System.Xml.Schema.XmlSchemaSimpleType get_XmlType();
                /*0x1a5fdbc*/ object get_TypedValue();
            }

            enum RestrictionFlags
            {
                Length = 1,
                MinLength = 2,
                MaxLength = 4,
                Pattern = 8,
                Enumeration = 16,
                WhiteSpace = 32,
                MaxInclusive = 64,
                MaxExclusive = 128,
                MinInclusive = 256,
                MinExclusive = 512,
                TotalDigits = 1024,
                FractionDigits = 2048,
            }

            enum XmlSchemaWhiteSpace
            {
                Preserve = 0,
                Replace = 1,
                Collapse = 2,
            }

            class RestrictionFacets
            {
                /*0x10*/ int Length;
                /*0x14*/ int MinLength;
                /*0x18*/ int MaxLength;
                /*0x20*/ System.Collections.ArrayList Patterns;
                /*0x28*/ System.Collections.ArrayList Enumeration;
                /*0x30*/ System.Xml.Schema.XmlSchemaWhiteSpace WhiteSpace;
                /*0x38*/ object MaxInclusive;
                /*0x40*/ object MaxExclusive;
                /*0x48*/ object MinInclusive;
                /*0x50*/ object MinExclusive;
                /*0x58*/ int TotalDigits;
                /*0x5c*/ int FractionDigits;
                /*0x60*/ System.Xml.Schema.RestrictionFlags Flags;
                /*0x64*/ System.Xml.Schema.RestrictionFlags FixedFlags;

                /*0x1825c5c*/ RestrictionFacets();
            }

            class DatatypeImplementation : System.Xml.Schema.XmlSchemaDatatype
            {
                static /*0x0*/ System.Collections.Hashtable builtinTypes;
                static /*0x8*/ System.Xml.Schema.XmlSchemaSimpleType[] enumToTypeCode;
                static /*0x10*/ System.Xml.Schema.XmlSchemaSimpleType anySimpleType;
                static /*0x18*/ System.Xml.Schema.XmlSchemaSimpleType anyAtomicType;
                static /*0x20*/ System.Xml.Schema.XmlSchemaSimpleType untypedAtomicType;
                static /*0x28*/ System.Xml.Schema.XmlSchemaSimpleType yearMonthDurationType;
                static /*0x30*/ System.Xml.Schema.XmlSchemaSimpleType dayTimeDurationType;
                static /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType normalizedStringTypeV1Compat;
                static /*0x40*/ System.Xml.Schema.XmlSchemaSimpleType tokenTypeV1Compat;
                static /*0x48*/ System.Xml.XmlQualifiedName QnAnySimpleType;
                static /*0x50*/ System.Xml.XmlQualifiedName QnAnyType;
                static /*0x58*/ System.Xml.Schema.FacetsChecker stringFacetsChecker;
                static /*0x60*/ System.Xml.Schema.FacetsChecker miscFacetsChecker;
                static /*0x68*/ System.Xml.Schema.FacetsChecker numeric2FacetsChecker;
                static /*0x70*/ System.Xml.Schema.FacetsChecker binaryFacetsChecker;
                static /*0x78*/ System.Xml.Schema.FacetsChecker dateTimeFacetsChecker;
                static /*0x80*/ System.Xml.Schema.FacetsChecker durationFacetsChecker;
                static /*0x88*/ System.Xml.Schema.FacetsChecker listFacetsChecker;
                static /*0x90*/ System.Xml.Schema.FacetsChecker qnameFacetsChecker;
                static /*0x98*/ System.Xml.Schema.FacetsChecker unionFacetsChecker;
                static /*0xa0*/ System.Xml.Schema.DatatypeImplementation c_anySimpleType;
                static /*0xa8*/ System.Xml.Schema.DatatypeImplementation c_anyURI;
                static /*0xb0*/ System.Xml.Schema.DatatypeImplementation c_base64Binary;
                static /*0xb8*/ System.Xml.Schema.DatatypeImplementation c_boolean;
                static /*0xc0*/ System.Xml.Schema.DatatypeImplementation c_byte;
                static /*0xc8*/ System.Xml.Schema.DatatypeImplementation c_char;
                static /*0xd0*/ System.Xml.Schema.DatatypeImplementation c_date;
                static /*0xd8*/ System.Xml.Schema.DatatypeImplementation c_dateTime;
                static /*0xe0*/ System.Xml.Schema.DatatypeImplementation c_dateTimeNoTz;
                static /*0xe8*/ System.Xml.Schema.DatatypeImplementation c_dateTimeTz;
                static /*0xf0*/ System.Xml.Schema.DatatypeImplementation c_day;
                static /*0xf8*/ System.Xml.Schema.DatatypeImplementation c_decimal;
                static /*0x100*/ System.Xml.Schema.DatatypeImplementation c_double;
                static /*0x108*/ System.Xml.Schema.DatatypeImplementation c_doubleXdr;
                static /*0x110*/ System.Xml.Schema.DatatypeImplementation c_duration;
                static /*0x118*/ System.Xml.Schema.DatatypeImplementation c_ENTITY;
                static /*0x120*/ System.Xml.Schema.DatatypeImplementation c_ENTITIES;
                static /*0x128*/ System.Xml.Schema.DatatypeImplementation c_ENUMERATION;
                static /*0x130*/ System.Xml.Schema.DatatypeImplementation c_fixed;
                static /*0x138*/ System.Xml.Schema.DatatypeImplementation c_float;
                static /*0x140*/ System.Xml.Schema.DatatypeImplementation c_floatXdr;
                static /*0x148*/ System.Xml.Schema.DatatypeImplementation c_hexBinary;
                static /*0x150*/ System.Xml.Schema.DatatypeImplementation c_ID;
                static /*0x158*/ System.Xml.Schema.DatatypeImplementation c_IDREF;
                static /*0x160*/ System.Xml.Schema.DatatypeImplementation c_IDREFS;
                static /*0x168*/ System.Xml.Schema.DatatypeImplementation c_int;
                static /*0x170*/ System.Xml.Schema.DatatypeImplementation c_integer;
                static /*0x178*/ System.Xml.Schema.DatatypeImplementation c_language;
                static /*0x180*/ System.Xml.Schema.DatatypeImplementation c_long;
                static /*0x188*/ System.Xml.Schema.DatatypeImplementation c_month;
                static /*0x190*/ System.Xml.Schema.DatatypeImplementation c_monthDay;
                static /*0x198*/ System.Xml.Schema.DatatypeImplementation c_Name;
                static /*0x1a0*/ System.Xml.Schema.DatatypeImplementation c_NCName;
                static /*0x1a8*/ System.Xml.Schema.DatatypeImplementation c_negativeInteger;
                static /*0x1b0*/ System.Xml.Schema.DatatypeImplementation c_NMTOKEN;
                static /*0x1b8*/ System.Xml.Schema.DatatypeImplementation c_NMTOKENS;
                static /*0x1c0*/ System.Xml.Schema.DatatypeImplementation c_nonNegativeInteger;
                static /*0x1c8*/ System.Xml.Schema.DatatypeImplementation c_nonPositiveInteger;
                static /*0x1d0*/ System.Xml.Schema.DatatypeImplementation c_normalizedString;
                static /*0x1d8*/ System.Xml.Schema.DatatypeImplementation c_NOTATION;
                static /*0x1e0*/ System.Xml.Schema.DatatypeImplementation c_positiveInteger;
                static /*0x1e8*/ System.Xml.Schema.DatatypeImplementation c_QName;
                static /*0x1f0*/ System.Xml.Schema.DatatypeImplementation c_QNameXdr;
                static /*0x1f8*/ System.Xml.Schema.DatatypeImplementation c_short;
                static /*0x200*/ System.Xml.Schema.DatatypeImplementation c_string;
                static /*0x208*/ System.Xml.Schema.DatatypeImplementation c_time;
                static /*0x210*/ System.Xml.Schema.DatatypeImplementation c_timeNoTz;
                static /*0x218*/ System.Xml.Schema.DatatypeImplementation c_timeTz;
                static /*0x220*/ System.Xml.Schema.DatatypeImplementation c_token;
                static /*0x228*/ System.Xml.Schema.DatatypeImplementation c_unsignedByte;
                static /*0x230*/ System.Xml.Schema.DatatypeImplementation c_unsignedInt;
                static /*0x238*/ System.Xml.Schema.DatatypeImplementation c_unsignedLong;
                static /*0x240*/ System.Xml.Schema.DatatypeImplementation c_unsignedShort;
                static /*0x248*/ System.Xml.Schema.DatatypeImplementation c_uuid;
                static /*0x250*/ System.Xml.Schema.DatatypeImplementation c_year;
                static /*0x258*/ System.Xml.Schema.DatatypeImplementation c_yearMonth;
                static /*0x260*/ System.Xml.Schema.DatatypeImplementation c_normalizedStringV1Compat;
                static /*0x268*/ System.Xml.Schema.DatatypeImplementation c_tokenV1Compat;
                static /*0x270*/ System.Xml.Schema.DatatypeImplementation c_anyAtomicType;
                static /*0x278*/ System.Xml.Schema.DatatypeImplementation c_dayTimeDuration;
                static /*0x280*/ System.Xml.Schema.DatatypeImplementation c_untypedAtomicType;
                static /*0x288*/ System.Xml.Schema.DatatypeImplementation c_yearMonthDuration;
                static /*0x290*/ System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypes;
                static /*0x298*/ System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypesXsd;
                static /*0x2a0*/ System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;
                static /*0x2a8*/ System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;
                /*0x10*/ System.Xml.Schema.XmlSchemaDatatypeVariety variety;
                /*0x18*/ System.Xml.Schema.RestrictionFacets restriction;
                /*0x20*/ System.Xml.Schema.DatatypeImplementation baseType;
                /*0x28*/ System.Xml.Schema.XmlValueConverter valueConverter;
                /*0x30*/ System.Xml.Schema.XmlSchemaType parentSchemaType;

                static /*0x1bf0128*/ DatatypeImplementation();
                static /*0x1bf5170*/ System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType();
                static /*0x1bf51d4*/ System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType();
                static /*0x1bf5238*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x1bf52c8*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x1bf5358*/ System.Xml.Schema.DatatypeImplementation FromXdrName(string name);
                static /*0x1bf5434*/ System.Xml.Schema.DatatypeImplementation FromTypeName(string name);
                static /*0x1bf5510*/ System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType);
                static /*0x1bf55e4*/ void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType);
                static /*0x1bf48f4*/ void CreateBuiltinTypes();
                static /*0x1bf580c*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x1bf589c*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname);
                static /*0x1bf5968*/ System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat();
                static /*0x1bf5afc*/ System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat();
                static /*0x1bf5c90*/ System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes();
                static /*0x1bf5cf4*/ System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x1bf604c*/ System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf6fa8*/ DatatypeImplementation();
                /*0x1bf5e48*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf5f38*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf3c90*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(int minSize, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf6178*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x1bf617c*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf6448*/ bool IsEqual(object o1, object o2);
                /*0x1bf6470*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x1bf6568*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf6570*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf65d4*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x1bf6614*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf661c*/ System.Type get_ValueType();
                /*0x1bf6694*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x1bf669c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf66a4*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                /*0x1bf66ac*/ bool get_HasLexicalFacets();
                /*0x1bf66d4*/ bool get_HasValueFacets();
                /*0x1bf66fc*/ System.Xml.Schema.DatatypeImplementation get_Base();
                System.Type get_ListValueType();
                System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf6704*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf670c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf6980*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x1bf6b00*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x1bf6910*/ string GetTypeName();
                /*0x1bf6f2c*/ int Compare(byte[] value1, byte[] value2);

                class SchemaDatatypeMap : System.IComparable
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Xml.Schema.DatatypeImplementation type;
                    /*0x20*/ int parentIndex;

                    static /*0x16c10ec*/ System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm);
                    /*0x16c1074*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type);
                    /*0x16c10ac*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type, int parentIndex);
                    /*0x16c1104*/ string get_Name();
                    /*0x16c110c*/ int get_ParentIndex();
                    /*0x16c1114*/ int CompareTo(object obj);
                }
            }

            class Datatype_List : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x38*/ System.Xml.Schema.DatatypeImplementation itemType;
                /*0x40*/ int minListSize;

                /*0x1bf5fd0*/ Datatype_List(System.Xml.Schema.DatatypeImplementation type, int minListSize);
                /*0x1bf6fe8*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf72d8*/ int Compare(object value1, object value2);
                /*0x1bf758c*/ System.Type get_ValueType();
                /*0x1bf759c*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf75bc*/ System.Type get_ListValueType();
                /*0x1bf75e0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf7644*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf7664*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf766c*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x1bf7ca4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_union : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType[] types;

                static /*0x1bff130*/ Datatype_union();
                /*0x1bf6104*/ Datatype_union(System.Xml.Schema.XmlSchemaSimpleType[] types);
                /*0x1bfe7e0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfe7ec*/ int Compare(object value1, object value2);
                /*0x1bfe8f4*/ System.Type get_ValueType();
                /*0x1bfe958*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe960*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfe9c4*/ System.Type get_ListValueType();
                /*0x1bfea28*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfea30*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x1bf5f44*/ bool HasAtomicMembers();
                /*0x1bf63b0*/ bool IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType);
                /*0x1bfea38*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bfec44*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anySimpleType : System.Xml.Schema.DatatypeImplementation
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf9418*/ Datatype_anySimpleType();
                /*0x1bf36d4*/ Datatype_anySimpleType();
                /*0x1bf91dc*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf9240*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf92a4*/ System.Type get_ValueType();
                /*0x1bf9308*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf9310*/ System.Type get_ListValueType();
                /*0x1bf9374*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf937c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf9384*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf938c*/ int Compare(object value1, object value2);
                /*0x1bf93e8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyAtomicType : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x1bf47d0*/ Datatype_anyAtomicType();
                /*0x1bf9168*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf91cc*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf91d4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_untypedAtomicType : System.Xml.Schema.Datatype_anyAtomicType
            {
                /*0x1bf4890*/ Datatype_untypedAtomicType();
                /*0x1c00484*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1c004e8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1c004f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_string : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x1bf4390*/ Datatype_string();
                /*0x1bfe648*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfe654*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfe65c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfe6c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe6c8*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bfe6d0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfe6d8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_boolean : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfa120*/ Datatype_boolean();
                /*0x1bf37f8*/ Datatype_boolean();
                /*0x1bf9e1c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf9e28*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf9e8c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf9e94*/ System.Type get_ValueType();
                /*0x1bf9ef8*/ System.Type get_ListValueType();
                /*0x1bf9f5c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf9f64*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf9f6c*/ int Compare(object value1, object value2);
                /*0x1bfa004*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_float : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfcac8*/ Datatype_float();
                /*0x1bf3e80*/ Datatype_float();
                /*0x1bfc780*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfc78c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfc7f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfc7f8*/ System.Type get_ValueType();
                /*0x1bfc85c*/ System.Type get_ListValueType();
                /*0x1bfc8c0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfc8c8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfc8d0*/ int Compare(object value1, object value2);
                /*0x1bfc968*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_double : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfbc00*/ Datatype_double();
                /*0x1bf3b6c*/ Datatype_double();
                /*0x1bfb8b8*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfb8c4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfb928*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfb930*/ System.Type get_ValueType();
                /*0x1bfb994*/ System.Type get_ListValueType();
                /*0x1bfb9f8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfba00*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfba08*/ int Compare(object value1, object value2);
                /*0x1bfbaa0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_decimal : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfb764*/ Datatype_decimal();
                /*0x1bf3b0c*/ Datatype_decimal();
                /*0x1bfb414*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfb420*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfb484*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfb48c*/ System.Type get_ValueType();
                /*0x1bfb4f0*/ System.Type get_ListValueType();
                /*0x1bfb554*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfb55c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfb564*/ int Compare(object value1, object value2);
                /*0x1bfb604*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_duration : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfc2dc*/ Datatype_duration();
                /*0x1bf3c2c*/ Datatype_duration();
                /*0x1bfbf10*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfbf1c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfbf80*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfbf88*/ System.Type get_ValueType();
                /*0x1bfbfec*/ System.Type get_ListValueType();
                /*0x1bfc050*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfc058*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfc060*/ int Compare(object value1, object value2);
                /*0x1bfc0f8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_yearMonthDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x1bf4894*/ Datatype_yearMonthDuration();
                /*0x1c009ec*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1c00bcc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dayTimeDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x1bf4830*/ Datatype_dayTimeDuration();
                /*0x1bfb22c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bfb40c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dateTimeBase : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;

                static /*0x1bfb15c*/ Datatype_dateTimeBase();
                /*0x1bfab14*/ Datatype_dateTimeBase(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags);
                /*0x1bfab88*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfab94*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfabf8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfac00*/ System.Type get_ValueType();
                /*0x1bfac64*/ System.Type get_ListValueType();
                /*0x1bfacc8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfacd0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfacd8*/ int Compare(object value1, object value2);
                /*0x1bfadf0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_dateTimeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf39e0*/ Datatype_dateTimeNoTimeZone();
            }

            class Datatype_dateTimeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf3a44*/ Datatype_dateTimeTimeZone();
            }

            class Datatype_dateTime : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf397c*/ Datatype_dateTime();
            }

            class Datatype_timeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf4454*/ Datatype_timeNoTimeZone();
            }

            class Datatype_timeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf44b8*/ Datatype_timeTimeZone();
            }

            class Datatype_time : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf43f0*/ Datatype_time();
                /*0x1bfe7c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_date : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf3918*/ Datatype_date();
                /*0x1bfab0c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_yearMonth : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf4764*/ Datatype_yearMonth();
                /*0x1c009e4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_year : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf4700*/ Datatype_year();
                /*0x1c009dc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_monthDay : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf40d4*/ Datatype_monthDay();
                /*0x1bfdc48*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_day : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf3aa8*/ Datatype_day();
                /*0x1bfb224*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_month : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1bf4070*/ Datatype_month();
                /*0x1bfdc40*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_hexBinary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfd174*/ Datatype_hexBinary();
                /*0x1bf3f40*/ Datatype_hexBinary();
                /*0x1bfcda4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bfcdb0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfce14*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfce1c*/ System.Type get_ValueType();
                /*0x1bfce80*/ System.Type get_ListValueType();
                /*0x1bfcee4*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfceec*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfcef4*/ int Compare(object value1, object value2);
                /*0x1bfcfac*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_base64Binary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf9d54*/ Datatype_base64Binary();
                /*0x1bf3798*/ Datatype_base64Binary();
                /*0x1bf9988*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf9994*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf99f8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf9a00*/ System.Type get_ValueType();
                /*0x1bf9a64*/ System.Type get_ListValueType();
                /*0x1bf9ac8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf9ad0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf9ad8*/ int Compare(object value1, object value2);
                /*0x1bf9b90*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyURI : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf98c0*/ Datatype_anyURI();
                /*0x1bf3738*/ Datatype_anyURI();
                /*0x1bf94e0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf94ec*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf9550*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf9558*/ System.Type get_ValueType();
                /*0x1bf95bc*/ bool get_HasValueFacets();
                /*0x1bf95c4*/ System.Type get_ListValueType();
                /*0x1bf9628*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf9630*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf9638*/ int Compare(object value1, object value2);
                /*0x1bf9730*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_QName : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf8c90*/ Datatype_QName();
                /*0x1bf4270*/ Datatype_QName();
                /*0x1bf88e0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf88ec*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf8950*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf8958*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf8960*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf8968*/ System.Type get_ValueType();
                /*0x1bf89cc*/ System.Type get_ListValueType();
                /*0x1bf8a30*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf8a38*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_normalizedString : System.Xml.Schema.Datatype_string
            {
                /*0x1bf41ac*/ Datatype_normalizedString();
                /*0x1bfe068*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe070*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bfe078*/ bool get_HasValueFacets();
            }

            class Datatype_normalizedStringV1Compat : System.Xml.Schema.Datatype_string
            {
                /*0x1bf47c8*/ Datatype_normalizedStringV1Compat();
                /*0x1bfe080*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe088*/ bool get_HasValueFacets();
            }

            class Datatype_token : System.Xml.Schema.Datatype_normalizedString
            {
                /*0x1bf451c*/ Datatype_token();
                /*0x1bfe7c8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe7d0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
            }

            class Datatype_tokenV1Compat : System.Xml.Schema.Datatype_normalizedStringV1Compat
            {
                /*0x1bf47cc*/ Datatype_tokenV1Compat();
                /*0x1bfe7d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_language : System.Xml.Schema.Datatype_token
            {
                /*0x1bf4068*/ Datatype_language();
                /*0x1bfd7d0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NMTOKEN : System.Xml.Schema.Datatype_token
            {
                /*0x1bf41a0*/ Datatype_NMTOKEN();
                /*0x1bf8238*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf8240*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_Name : System.Xml.Schema.Datatype_token
            {
                /*0x1bf4138*/ Datatype_Name();
                /*0x1bf88d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NCName : System.Xml.Schema.Datatype_Name
            {
                /*0x1bf413c*/ Datatype_NCName();
                /*0x1bf8120*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf8128*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_ID : System.Xml.Schema.Datatype_NCName
            {
                /*0x1bf3fa0*/ Datatype_ID();
                /*0x1bf6fc8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf6fd0*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_IDREF : System.Xml.Schema.Datatype_NCName
            {
                /*0x1bf3fa4*/ Datatype_IDREF();
                /*0x1bf6fd8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf6fe0*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_ENTITY : System.Xml.Schema.Datatype_NCName
            {
                /*0x1bf3c8c*/ Datatype_ENTITY();
                /*0x1bf6fb0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf6fb8*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_NOTATION : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf8810*/ Datatype_NOTATION();
                /*0x1bf41b0*/ Datatype_NOTATION();
                /*0x1bf8248*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bf8254*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf82b8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf82c0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf82c8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf82d0*/ System.Type get_ValueType();
                /*0x1bf8334*/ System.Type get_ListValueType();
                /*0x1bf8398*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bf83a0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bf85f8*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
            }

            class Datatype_integer : System.Xml.Schema.Datatype_decimal
            {
                /*0x1bf4008*/ Datatype_integer();
                /*0x1bfd69c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfd6a4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonPositiveInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfdf7c*/ Datatype_nonPositiveInteger();
                /*0x1bf41a8*/ Datatype_nonPositiveInteger();
                /*0x1bfdf08*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfdf6c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfdf74*/ bool get_HasValueFacets();
            }

            class Datatype_negativeInteger : System.Xml.Schema.Datatype_nonPositiveInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfdcbc*/ Datatype_negativeInteger();
                /*0x1bf4140*/ Datatype_negativeInteger();
                /*0x1bfdc50*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfdcb4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_long : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfdb0c*/ Datatype_long();
                /*0x1bf406c*/ Datatype_long();
                /*0x1bfd7d8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfd83c*/ bool get_HasValueFacets();
                /*0x1bfd844*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfd84c*/ int Compare(object value1, object value2);
                /*0x1bfd8e4*/ System.Type get_ValueType();
                /*0x1bfd948*/ System.Type get_ListValueType();
                /*0x1bfd9ac*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_int : System.Xml.Schema.Datatype_long
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfd568*/ Datatype_int();
                /*0x1bf3fa8*/ Datatype_int();
                /*0x1bfd23c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfd2a0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfd2a8*/ int Compare(object value1, object value2);
                /*0x1bfd340*/ System.Type get_ValueType();
                /*0x1bfd3a4*/ System.Type get_ListValueType();
                /*0x1bfd408*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_short : System.Xml.Schema.Datatype_int
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfe514*/ Datatype_short();
                /*0x1bf4330*/ Datatype_short();
                /*0x1bfe1e8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfe24c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfe254*/ int Compare(object value1, object value2);
                /*0x1bfe2ec*/ System.Type get_ValueType();
                /*0x1bfe350*/ System.Type get_ListValueType();
                /*0x1bfe3b4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_byte : System.Xml.Schema.Datatype_short
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfa514*/ Datatype_byte();
                /*0x1bf3858*/ Datatype_byte();
                /*0x1bfa1e8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfa24c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfa254*/ int Compare(object value1, object value2);
                /*0x1bfa2ec*/ System.Type get_ValueType();
                /*0x1bfa350*/ System.Type get_ListValueType();
                /*0x1bfa3b4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonNegativeInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfde1c*/ Datatype_nonNegativeInteger();
                /*0x1bf41a4*/ Datatype_nonNegativeInteger();
                /*0x1bfdda8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfde0c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bfde14*/ bool get_HasValueFacets();
            }

            class Datatype_unsignedLong : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bffe90*/ Datatype_unsignedLong();
                /*0x1bf45e0*/ Datatype_unsignedLong();
                /*0x1bffb18*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bffb7c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bffb84*/ int Compare(object value1, object value2);
                /*0x1bffc1c*/ System.Type get_ValueType();
                /*0x1bffc80*/ System.Type get_ListValueType();
                /*0x1bffce4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedInt : System.Xml.Schema.Datatype_unsignedLong
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bff9b4*/ Datatype_unsignedInt();
                /*0x1bf4580*/ Datatype_unsignedInt();
                /*0x1bff688*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bff6ec*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bff6f4*/ int Compare(object value1, object value2);
                /*0x1bff78c*/ System.Type get_ValueType();
                /*0x1bff7f0*/ System.Type get_ListValueType();
                /*0x1bff854*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedShort : System.Xml.Schema.Datatype_unsignedInt
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1c00320*/ Datatype_unsignedShort();
                /*0x1bf4640*/ Datatype_unsignedShort();
                /*0x1bffff4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1c00058*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1c00060*/ int Compare(object value1, object value2);
                /*0x1c000f8*/ System.Type get_ValueType();
                /*0x1c0015c*/ System.Type get_ListValueType();
                /*0x1c001c0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedByte : System.Xml.Schema.Datatype_unsignedShort
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bff524*/ Datatype_unsignedByte();
                /*0x1bf4520*/ Datatype_unsignedByte();
                /*0x1bff1f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bff25c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bff264*/ int Compare(object value1, object value2);
                /*0x1bff2fc*/ System.Type get_ValueType();
                /*0x1bff360*/ System.Type get_ListValueType();
                /*0x1bff3c4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_positiveInteger : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bfe0fc*/ Datatype_positiveInteger();
                /*0x1bf4210*/ Datatype_positiveInteger();
                /*0x1bfe090*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bfe0f4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_doubleXdr : System.Xml.Schema.Datatype_double
            {
                /*0x1bf3bcc*/ Datatype_doubleXdr();
                /*0x1bfbcc8*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_floatXdr : System.Xml.Schema.Datatype_float
            {
                /*0x1bf3ee0*/ Datatype_floatXdr();
                /*0x1bfcb90*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_QNameXdr : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf90a0*/ Datatype_QNameXdr();
                /*0x1bf42d0*/ Datatype_QNameXdr();
                /*0x1bf8d58*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf8d60*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf8fd8*/ System.Type get_ValueType();
                /*0x1bf903c*/ System.Type get_ListValueType();
            }

            class Datatype_ENUMERATION : System.Xml.Schema.Datatype_NMTOKEN
            {
                /*0x1bf3e1c*/ Datatype_ENUMERATION();
                /*0x1bf6fc0*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_char : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bfaa44*/ Datatype_char();
                /*0x1bf38b8*/ Datatype_char();
                /*0x1bfa648*/ System.Type get_ValueType();
                /*0x1bfa6ac*/ System.Type get_ListValueType();
                /*0x1bfa710*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bfa718*/ int Compare(object value1, object value2);
                /*0x1bfa7b0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bfa98c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_fixed : System.Xml.Schema.Datatype_decimal
            {
                /*0x1bf3e20*/ Datatype_fixed();
                /*0x1bfc3a4*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bfc640*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_uuid : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1c00914*/ Datatype_uuid();
                /*0x1bf46a0*/ Datatype_uuid();
                /*0x1c004f8*/ System.Type get_ValueType();
                /*0x1c0055c*/ System.Type get_ListValueType();
                /*0x1c005c0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1c005c8*/ int Compare(object value1, object value2);
                /*0x1c00670*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1c00854*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class DtdValidator : System.Xml.Schema.BaseValidator
            {
                static /*0x0*/ System.Xml.Schema.DtdValidator.NamespaceManager namespaceManager;
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlQualifiedName name;
                /*0x98*/ System.Collections.Hashtable IDs;
                /*0xa0*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xa8*/ bool processIdentityConstraints;

                static /*0x14c89e0*/ DtdValidator();
                static /*0x14c81cc*/ void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter);
                static /*0x14c85a4*/ void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, string baseUriStr);
                /*0x14c6080*/ DtdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x14c612c*/ void Init();
                /*0x14c6354*/ void Validate();
                /*0x14c6660*/ bool MeetsStandAloneConstraint();
                /*0x14c6704*/ void ValidatePIComment();
                /*0x14c654c*/ void ValidateElement();
                /*0x14c6ae4*/ void ValidateChildElement();
                /*0x14c6d68*/ void ValidateStartElement();
                /*0x14c77a0*/ void ValidateEndStartElement();
                /*0x14c6c40*/ void ProcessElement();
                /*0x14c7978*/ void CompleteValidation();
                /*0x14c692c*/ void ValidateEndElement();
                /*0x14c7b74*/ bool get_PreserveWhitespace();
                /*0x14c7bb0*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x14c71e8*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x14c7dc4*/ void AddID(string name, object node);
                /*0x14c7ea8*/ object FindId(string name);
                /*0x14c67cc*/ bool GenEntity(System.Xml.XmlQualifiedName qname);
                /*0x14c7ec4*/ System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, bool fParameterEntity);
                /*0x14c7a64*/ void CheckForwardRefs();
                /*0x14c6260*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x14c79d0*/ bool Pop();

                class NamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x16c120c*/ NamespaceManager();
                    /*0x16c1204*/ string LookupNamespace(string prefix);
                }
            }

            class FacetsChecker
            {
                static /*0x14ca038*/ decimal Power(int x, int y);
                /*0x14c90b4*/ FacetsChecker();
                /*0x14c99d0*/ System.Exception CheckLexicalFacets(ref string parseString, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c6c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c74*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c7c*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c84*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c8c*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c94*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9c9c*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9ca4*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9cac*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9cb4*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9cbc*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9cc4*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9a18*/ void CheckWhitespaceFacets(ref string s, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9b0c*/ System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, string value);
                /*0x14c9ccc*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9cd4*/ System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable);

                struct FacetsCompiler
                {
                    static /*0x0*/ System.Xml.Schema.FacetsChecker.FacetsCompiler.Map[] c_map;
                    /*0x10*/ System.Xml.Schema.DatatypeImplementation datatype;
                    /*0x18*/ System.Xml.Schema.RestrictionFacets derivedRestriction;
                    /*0x20*/ System.Xml.Schema.RestrictionFlags baseFlags;
                    /*0x24*/ System.Xml.Schema.RestrictionFlags baseFixedFlags;
                    /*0x28*/ System.Xml.Schema.RestrictionFlags validRestrictionFlags;
                    /*0x30*/ System.Xml.Schema.XmlSchemaDatatype nonNegativeInt;
                    /*0x38*/ System.Xml.Schema.XmlSchemaDatatype builtInType;
                    /*0x40*/ System.Xml.Schema.XmlTypeCode builtInEnum;
                    /*0x44*/ bool firstPattern;
                    /*0x48*/ System.Text.StringBuilder regStr;
                    /*0x50*/ System.Xml.Schema.XmlSchemaPatternFacet pattern_facet;

                    static /*0x16c42bc*/ FacetsCompiler();
                    static /*0x16c39a0*/ string Preprocess(string pattern);
                    /*0xac0b04*/ FacetsCompiler(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction);
                    /*0xac0b0c*/ void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b14*/ void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b1c*/ void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b24*/ void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet);
                    /*0xac0b2c*/ void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0xac0b34*/ void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b3c*/ void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b44*/ void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b4c*/ void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b54*/ void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b5c*/ void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b64*/ void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b6c*/ void FinishFacetCompile();
                    /*0xac0b74*/ void CheckValue(object value, System.Xml.Schema.XmlSchemaFacet facet);
                    /*0xac0b7c*/ void CompileFacetCombinations();
                    /*0xac0b84*/ void CopyFacetsFromBaseType();
                    /*0xac0b8c*/ object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, string code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0xac0b90*/ void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0xac0b98*/ void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0xac0ba0*/ void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag);
                    /*0xac0ba8*/ void SetFlag(System.Xml.Schema.RestrictionFlags flag);

                    struct Map
                    {
                        /*0x10*/ char match;
                        /*0x18*/ string replacement;

                        /*0xac1ec4*/ Map(char m, string r);
                    }
                }
            }

            class Numeric10FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ char[] signs;
                /*0x10*/ decimal maxValue;
                /*0x20*/ decimal minValue;

                static /*0x14d3e84*/ Numeric10FacetsChecker();
                /*0x14d31e4*/ Numeric10FacetsChecker(decimal minVal, decimal maxVal);
                /*0x14d3230*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d32ac*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3c34*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3ccc*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3d64*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3dfc*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3864*/ bool MatchEnumeration(decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
                /*0x14d3990*/ System.Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction);
            }

            class Numeric2FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x14d439c*/ Numeric2FacetsChecker();
                /*0x14d3f24*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d3f90*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d4308*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d4318*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14d4244*/ bool MatchEnumeration(double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
            }

            class DurationFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x14c90ac*/ DurationFacetsChecker();
                /*0x14c8a54*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c8b7c*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c9028*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14c8f08*/ bool MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration);
            }

            class DateTimeFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1bf36cc*/ DateTimeFacetsChecker();
                /*0x1c00bd4*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1c00c44*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1c0117c*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1c0103c*/ bool MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class StringFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex languagePattern;

                static /*0x1b0fa6c*/ System.Text.RegularExpressions.Regex get_LanguagePattern();
                /*0x1b1027c*/ StringFacetsChecker();
                /*0x1b0fb20*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1b0fdb4*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1b0fb8c*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype, bool verifyUri);
                /*0x1b10214*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1b1003c*/ bool MatchEnumeration(string value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1b0fdbc*/ System.Exception CheckBuiltInFacets(string s, System.Xml.Schema.XmlTypeCode typeCode, bool verifyUri);
            }

            class QNameFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1823334*/ QNameFacetsChecker();
                /*0x1822dd4*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1822f14*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1823214*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1823100*/ bool MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration);
            }

            class MiscFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x14d0320*/ MiscFacetsChecker();
            }

            class BinaryFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x158ff58*/ BinaryFacetsChecker();
                /*0x158fb40*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x158fbd4*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x158fed0*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x158fdac*/ bool MatchEnumeration(byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class ListFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x14cf104*/ ListFacetsChecker();
                /*0x14cedf4*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x14cf048*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class UnionFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1b1a118*/ UnionFacetsChecker();
                /*0x1b19f60*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1b1a05c*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            interface IXmlSchemaInfo
            {
                System.Xml.Schema.XmlSchemaValidity get_Validity();
                bool get_IsDefault();
                bool get_IsNil();
                System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                System.Xml.Schema.XmlSchemaType get_SchemaType();
                System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            }

            class XmlSchemaInference
            {
                static /*0x0*/ System.Xml.XmlQualifiedName ST_boolean;
                static /*0x8*/ System.Xml.XmlQualifiedName ST_byte;
                static /*0x10*/ System.Xml.XmlQualifiedName ST_unsignedByte;
                static /*0x18*/ System.Xml.XmlQualifiedName ST_short;
                static /*0x20*/ System.Xml.XmlQualifiedName ST_unsignedShort;
                static /*0x28*/ System.Xml.XmlQualifiedName ST_int;
                static /*0x30*/ System.Xml.XmlQualifiedName ST_unsignedInt;
                static /*0x38*/ System.Xml.XmlQualifiedName ST_long;
                static /*0x40*/ System.Xml.XmlQualifiedName ST_unsignedLong;
                static /*0x48*/ System.Xml.XmlQualifiedName ST_integer;
                static /*0x50*/ System.Xml.XmlQualifiedName ST_decimal;
                static /*0x58*/ System.Xml.XmlQualifiedName ST_float;
                static /*0x60*/ System.Xml.XmlQualifiedName ST_double;
                static /*0x68*/ System.Xml.XmlQualifiedName ST_duration;
                static /*0x70*/ System.Xml.XmlQualifiedName ST_dateTime;
                static /*0x78*/ System.Xml.XmlQualifiedName ST_time;
                static /*0x80*/ System.Xml.XmlQualifiedName ST_date;
                static /*0x88*/ System.Xml.XmlQualifiedName ST_gYearMonth;
                static /*0x90*/ System.Xml.XmlQualifiedName ST_string;
                static /*0x98*/ System.Xml.XmlQualifiedName ST_anySimpleType;
                static /*0xa0*/ System.Xml.XmlQualifiedName[] SimpleTypes;
                /*0x10*/ System.Xml.Schema.XmlSchema rootSchema;
                /*0x18*/ System.Xml.Schema.XmlSchemaSet schemaSet;
                /*0x20*/ System.Xml.XmlReader xtr;
                /*0x28*/ System.Xml.NameTable nametable;
                /*0x30*/ string TargetNamespace;
                /*0x38*/ System.Xml.XmlNamespaceManager NamespaceManager;
                /*0x40*/ System.Collections.ArrayList schemaList;
                /*0x48*/ System.Xml.Schema.XmlSchemaInference.InferenceOption occurrence;
                /*0x4c*/ System.Xml.Schema.XmlSchemaInference.InferenceOption typeInference;

                static /*0x1cf7594*/ XmlSchemaInference();
                static /*0x1cf5eb4*/ int InferSimpleType(string s, ref bool bNeedsRangeCheck);
                static /*0x1cf7474*/ int DateTime(string s, bool bDate, bool bTime);
                static /*0x1cf2a68*/ int GetSchemaType(System.Xml.XmlQualifiedName qname);
                /*0x1cee13c*/ XmlSchemaInference();
                /*0x1cee124*/ void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x1cee12c*/ System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence();
                /*0x1cee134*/ void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x1cee250*/ System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument);
                /*0x1cee2c8*/ System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas);
                /*0x1cf0740*/ System.Xml.Schema.XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes);
                /*0x1cf337c*/ System.Xml.Schema.XmlSchema CreateXmlSchema(string targetNS);
                /*0x1ceec7c*/ System.Xml.Schema.XmlSchemaElement AddElement(string localName, string prefix, string childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, int positionWithinCollection);
                /*0x1cef248*/ void InferElement(System.Xml.Schema.XmlSchemaElement xse, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x1cf4118*/ System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x1cf3854*/ System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, bool bCreatingNewType);
                /*0x1cf466c*/ System.Xml.Schema.XmlSchemaElement FindMatchingElement(bool bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, bool setMaxoccurs);
                /*0x1cf3988*/ void ProcessAttributes(ref System.Xml.Schema.XmlSchemaElement xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x1cf45d4*/ void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x1cf4254*/ void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType);
                /*0x1cf130c*/ System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, string attrName);
                /*0x1cf340c*/ System.Xml.Schema.XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, ref System.Xml.Schema.XmlSchema parentSchema);
                /*0x1cf582c*/ System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName);
                /*0x1cf0f58*/ System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, string attributeName, string nsURI);
                /*0x1cf5970*/ System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName, string nsURI);
                /*0x1cf4080*/ void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x1cf5d8c*/ void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x1cf167c*/ System.Xml.XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags);
                /*0x1cf5adc*/ System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement);
                /*0x1cf568c*/ void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, bool setMaxOccurs);

                enum InferenceOption
                {
                    Restricted = 0,
                    Relaxed = 1,
                }
            }

            class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
            {
                /*0x1cf7edc*/ XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1cf7ee4*/ XmlSchemaInferenceException();
                /*0x1cf5cac*/ XmlSchemaInferenceException(string res, string arg);
                /*0x1ceec10*/ XmlSchemaInferenceException(string res, int lineNumber, int linePosition);
                /*0x1cf7ee0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NamespaceList
            {
                /*0x10*/ System.Xml.Schema.NamespaceList.ListType type;
                /*0x18*/ System.Collections.Hashtable set;
                /*0x20*/ string targetNamespace;

                static /*0x14d14d0*/ bool IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super);
                static /*0x14d1884*/ System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                static /*0x14d1f00*/ System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                /*0x14d0b30*/ NamespaceList();
                /*0x14d0b38*/ NamespaceList(string namespaces, string targetNamespace);
                /*0x14d0df0*/ System.Xml.Schema.NamespaceList Clone();
                /*0x14d0ef8*/ System.Xml.Schema.NamespaceList.ListType get_Type();
                /*0x14d0f00*/ string get_Excluded();
                /*0x14d0f08*/ System.Collections.ICollection get_Enumerate();
                /*0x14d0f78*/ bool Allows(string ns);
                /*0x14d1008*/ bool Allows(System.Xml.XmlQualifiedName qname);
                /*0x14d1028*/ string ToString();
                /*0x14d1dc8*/ System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other);
                /*0x14d23f0*/ void RemoveNamespace(string tns);

                enum ListType
                {
                    Any = 0,
                    Other = 1,
                    Set = 2,
                }
            }

            class NamespaceListV1Compat : System.Xml.Schema.NamespaceList
            {
                /*0x14d29d4*/ NamespaceListV1Compat(string namespaces, string targetNamespace);
                /*0x14d29d8*/ bool Allows(string ns);
            }

            class Parser
            {
                /*0x10*/ System.Xml.Schema.SchemaType schemaType;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x28*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x30*/ System.Xml.XmlNamespaceManager namespaceManager;
                /*0x38*/ System.Xml.XmlReader reader;
                /*0x40*/ System.Xml.PositionInfo positionInfo;
                /*0x48*/ bool isProcessNamespaces;
                /*0x4c*/ int schemaXmlDepth;
                /*0x50*/ int markupDepth;
                /*0x58*/ System.Xml.Schema.SchemaBuilder builder;
                /*0x60*/ System.Xml.Schema.XmlSchema schema;
                /*0x68*/ System.Xml.Schema.SchemaInfo xdrSchema;
                /*0x70*/ System.Xml.XmlResolver xmlResolver;
                /*0x78*/ System.Xml.XmlDocument dummyDocument;
                /*0x80*/ bool processMarkup;
                /*0x88*/ System.Xml.XmlNode parentNode;
                /*0x90*/ System.Xml.XmlNamespaceManager annotationNSManager;
                /*0x98*/ string xmlns;
                /*0xa0*/ System.Xml.XmlCharType xmlCharType;

                /*0x14d4968*/ Parser(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x14d4a1c*/ System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, string targetNamespace);
                /*0x14d4a70*/ void StartParsing(System.Xml.XmlReader reader, string targetNamespace);
                /*0x14d5568*/ bool CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, ref string code);
                /*0x14d5674*/ System.Xml.Schema.SchemaType FinishParsing();
                /*0x14d567c*/ System.Xml.Schema.XmlSchema get_XmlSchema();
                /*0x14d5684*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x14d568c*/ System.Xml.Schema.SchemaInfo get_XdrSchema();
                /*0x14d4e24*/ bool ParseReaderNode();
                /*0x14d5694*/ void ProcessAppInfoDocMarkup(bool root);
                /*0x14d58c4*/ System.Xml.XmlElement LoadElementNode(bool root);
                /*0x14d5e2c*/ System.Xml.XmlAttribute CreateXmlNsAttribute(string prefix, string value);
                /*0x14d5cac*/ System.Xml.XmlAttribute LoadAttributeNode();
                /*0x14d5f58*/ System.Xml.XmlEntityReference LoadEntityReferenceInAttribute();
            }

            enum Compositor
            {
                Root = 0,
                Include = 1,
                Import = 2,
                Redefine = 3,
            }

            class RedefineEntry
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaRedefine redefine;
                /*0x18*/ System.Xml.Schema.XmlSchema schemaToUpdate;

                /*0x1825308*/ RedefineEntry(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema);
            }

            class Preprocessor : System.Xml.Schema.BaseProcessor
            {
                static /*0x0*/ System.Xml.Schema.XmlSchema builtInSchemaForXmlNS;
                /*0x40*/ string Xmlns;
                /*0x48*/ string NsXsi;
                /*0x50*/ string targetNamespace;
                /*0x58*/ System.Xml.Schema.XmlSchema rootSchema;
                /*0x60*/ System.Xml.Schema.XmlSchema currentSchema;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x6c*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x70*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x74*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x78*/ System.Collections.Hashtable schemaLocations;
                /*0x80*/ System.Collections.Hashtable chameleonSchemas;
                /*0x88*/ System.Collections.Hashtable referenceNamespaces;
                /*0x90*/ System.Collections.Hashtable processedExternals;
                /*0x98*/ System.Collections.SortedList lockList;
                /*0xa0*/ System.Xml.XmlReaderSettings readerSettings;
                /*0xa8*/ System.Xml.Schema.XmlSchema rootSchemaForRedefine;
                /*0xb0*/ System.Collections.ArrayList redefinedList;
                /*0xb8*/ System.Xml.XmlResolver xmlResolver;

                static /*0x14db65c*/ System.Xml.Schema.XmlSchema GetBuildInSchema();
                static /*0x14df064*/ System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject);
                /*0x14d8268*/ Preprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x14d8344*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals);
                /*0x14dbc0c*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x14dbcec*/ void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include);
                /*0x14dbd90*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x14dbd98*/ void set_ReaderSettings(System.Xml.XmlReaderSettings value);
                /*0x14dbda0*/ void set_SchemaLocations(System.Collections.Hashtable value);
                /*0x14dbda8*/ void set_ChameleonSchemas(System.Collections.Hashtable value);
                /*0x14dbdb0*/ System.Xml.Schema.XmlSchema get_RootSchema();
                /*0x14d978c*/ void BuildSchemaList(System.Xml.Schema.XmlSchema schema);
                /*0x14d8a18*/ void LoadExternals(System.Xml.Schema.XmlSchema schema);
                /*0x14dbe24*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x14dc054*/ void ParseUri(string uri, string code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject);
                /*0x14d9910*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Collections.ArrayList imports);
                /*0x14dc6ec*/ void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema);
                /*0x14dab40*/ void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry);
                /*0x14df0fc*/ void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList);
                /*0x14dc5d4*/ void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema);
                /*0x14df888*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined);
                /*0x14df234*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x14df2e0*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x14df770*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x14df444*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x14dd864*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x14e00d4*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x14dfe90*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x14dd9dc*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x14de924*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x14e0bc4*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x14e0890*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x14e0f58*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x14de390*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x14ddae0*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x14deb88*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x14ded5c*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x14e12a0*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x14e04f8*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x14dc284*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x14dfbcc*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x14e028c*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x14dbdb8*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x14dbdfc*/ object GetSchemaEntity(System.Uri ruri);
                /*0x14d88dc*/ System.Xml.Schema.XmlSchema GetChameleonSchema(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x14dc1d4*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x14dc1ec*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x14deff0*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class SchemaAttDef : System.Xml.Schema.SchemaDeclBase, System.Xml.IDtdDefaultAttributeInfo, System.Xml.IDtdAttributeInfo
            {
                static /*0x0*/ System.Xml.Schema.SchemaAttDef Empty;
                /*0x60*/ string defExpanded;
                /*0x68*/ int lineNum;
                /*0x6c*/ int linePos;
                /*0x70*/ int valueLineNum;
                /*0x74*/ int valueLinePos;
                /*0x78*/ System.Xml.Schema.SchemaAttDef.Reserve reserved;
                /*0x7c*/ bool defaultValueChecked;
                /*0x80*/ System.Xml.Schema.XmlSchemaAttribute schemaAttribute;

                static /*0x18262b0*/ SchemaAttDef();
                /*0x1825db0*/ SchemaAttDef(System.Xml.XmlQualifiedName name, string prefix);
                /*0x1825db8*/ SchemaAttDef(System.Xml.XmlQualifiedName name);
                /*0x1825dc4*/ SchemaAttDef();
                /*0x1825dcc*/ string System.Xml.IDtdAttributeInfo.get_Prefix();
                /*0x1825dd4*/ string System.Xml.IDtdAttributeInfo.get_LocalName();
                /*0x1825df0*/ int System.Xml.IDtdAttributeInfo.get_LineNumber();
                /*0x1825df8*/ int System.Xml.IDtdAttributeInfo.get_LinePosition();
                /*0x1825e00*/ bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType();
                /*0x1825e50*/ bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal();
                /*0x1825e58*/ bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute();
                /*0x1825e68*/ string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded();
                /*0x1825f18*/ object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped();
                /*0x1825f20*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber();
                /*0x1825f28*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition();
                /*0x1825f30*/ int get_LinePosition();
                /*0x1825f38*/ void set_LinePosition(int value);
                /*0x1825f40*/ int get_LineNumber();
                /*0x1825f48*/ void set_LineNumber(int value);
                /*0x1825f50*/ int get_ValueLinePosition();
                /*0x1825f58*/ void set_ValueLinePosition(int value);
                /*0x1825f60*/ int get_ValueLineNumber();
                /*0x1825f68*/ void set_ValueLineNumber(int value);
                /*0x1825ec0*/ string get_DefaultValueExpanded();
                /*0x1825f70*/ void set_DefaultValueExpanded(string value);
                /*0x1825e30*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1825f78*/ void set_TokenizedType(System.Xml.XmlTokenizedType value);
                /*0x1825fa4*/ System.Xml.Schema.SchemaAttDef.Reserve get_Reserved();
                /*0x1825fac*/ void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value);
                /*0x1825fb4*/ bool get_DefaultValueChecked();
                /*0x1825fbc*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x1825fc4*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x1825fcc*/ void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling);
                /*0x1826248*/ System.Xml.Schema.SchemaAttDef Clone();

                enum Reserve
                {
                    None = 0,
                    XmlSpace = 1,
                    XmlLang = 2,
                }
            }

            class SchemaBuilder
            {
                /*0x1826310*/ SchemaBuilder();
                bool ProcessElement(string prefix, string name, string ns);
                void ProcessAttribute(string prefix, string name, string ns, string value);
                bool IsContentParsed();
                void ProcessMarkup(System.Xml.XmlNode[] markup);
                void ProcessCData(string value);
                void StartChildren();
                void EndChildren();
            }

            class SchemaCollectionCompiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ bool compileContentModel;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x50*/ System.Collections.Stack complexTypeStack;
                /*0x58*/ System.Xml.Schema.XmlSchema schema;

                static /*0x182a8f4*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                static /*0x182a8b8*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                static /*0x182a3a0*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                static /*0x182a3e8*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                static /*0x182a71c*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                static /*0x182a738*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                static /*0x182f1e0*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x182a370*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                static /*0x182f2b0*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1826318*/ SchemaCollectionCompiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x18263c4*/ bool Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, bool compileContentModel);
                /*0x1826434*/ void Prepare();
                /*0x1826880*/ void Cleanup();
                /*0x182766c*/ void Compile();
                /*0x1829454*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x182af0c*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup);
                /*0x182f010*/ void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x182b3a4*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x182c818*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x182f810*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x182fbcc*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x182bbb4*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x182fcf4*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x182ff48*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x18303ac*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x18307a0*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x182eebc*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1831e40*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool substitution);
                /*0x182f424*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root, bool substitution);
                /*0x18332f8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, bool substitution);
                /*0x183344c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root, bool substitution);
                /*0x1833a24*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root, bool substitution);
                /*0x1833f04*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root, bool substitution);
                /*0x183446c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root, bool substitution);
                /*0x1832d1c*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x1834a10*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x1834b3c*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1834ba8*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1834bf8*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1834de8*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x1835138*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x18353b0*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x18356c0*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x18362d0*/ void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x1835894*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x18360d4*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x18361d0*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x1834960*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x18358dc*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x1836698*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1831fcc*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x182b484*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x1830a84*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x1836754*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x18366bc*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x182ddd0*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x182e740*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x182d10c*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x1832048*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x18367ec*/ void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1836d20*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x182eddc*/ void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x182f698*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x1832c5c*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x1832ae4*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
            }

            class SchemaCollectionPreprocessor : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ System.Xml.Schema.XmlSchema schema;
                /*0x48*/ string targetNamespace;
                /*0x50*/ bool buildinIncluded;
                /*0x54*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x58*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x5c*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x60*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x68*/ System.Collections.Hashtable schemaLocations;
                /*0x70*/ System.Collections.Hashtable referenceNamespaces;
                /*0x78*/ string Xmlns;
                /*0x80*/ System.Xml.XmlResolver xmlResolver;

                /*0x1836f88*/ SchemaCollectionPreprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x1836f90*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x18371bc*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x183a46c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x18373dc*/ void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x183a64c*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x18380fc*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor);
                /*0x183a964*/ void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine);
                /*0x183d7c4*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name);
                /*0x183d164*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x183d20c*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x183d6ac*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x183d380*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x183b9a0*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x183dff4*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x183dda0*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x183bb18*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x183ca6c*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x183e9ac*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x183e654*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x183ed3c*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x183c4bc*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x183bc18*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x183ccd0*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x183cea0*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x183f080*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x183e340*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x1837e94*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x183daec*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x183e1a8*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x183a860*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x183a878*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x183a474*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x183a52c*/ System.IO.Stream GetSchemaEntity(System.Uri ruri);

                enum Compositor
                {
                    Root = 0,
                    Include = 1,
                    Import = 2,
                }
            }

            class SchemaDeclBase
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string prefix;
                /*0x20*/ bool isDeclaredInExternal;
                /*0x24*/ System.Xml.Schema.SchemaDeclBase.Use presence;
                /*0x28*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x30*/ System.Xml.Schema.XmlSchemaDatatype datatype;
                /*0x38*/ string defaultValueRaw;
                /*0x40*/ object defaultValueTyped;
                /*0x48*/ long maxLength;
                /*0x50*/ long minLength;
                /*0x58*/ System.Collections.Generic.List<string> values;

                /*0x1b07290*/ SchemaDeclBase(System.Xml.XmlQualifiedName name, string prefix);
                /*0x1b07324*/ SchemaDeclBase();
                /*0x1b07398*/ System.Xml.XmlQualifiedName get_Name();
                /*0x1b073a0*/ void set_Name(System.Xml.XmlQualifiedName value);
                /*0x1b073a8*/ string get_Prefix();
                /*0x1b07400*/ void set_Prefix(string value);
                /*0x1b07408*/ bool get_IsDeclaredInExternal();
                /*0x1b07410*/ void set_IsDeclaredInExternal(bool value);
                /*0x1b0741c*/ System.Xml.Schema.SchemaDeclBase.Use get_Presence();
                /*0x1b07424*/ void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value);
                /*0x1b0742c*/ long get_MaxLength();
                /*0x1b07434*/ void set_MaxLength(long value);
                /*0x1b0743c*/ long get_MinLength();
                /*0x1b07444*/ void set_MinLength(long value);
                /*0x1b0744c*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x1b07454*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x1b0745c*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x1b07464*/ void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x1b0746c*/ void AddValue(string value);
                /*0x1b07518*/ System.Collections.Generic.List<string> get_Values();
                /*0x1b07520*/ void set_Values(System.Collections.Generic.List<string> value);
                /*0x1b07528*/ string get_DefaultValueRaw();
                /*0x1b07580*/ void set_DefaultValueRaw(string value);
                /*0x1b07588*/ object get_DefaultValueTyped();
                /*0x1b07590*/ void set_DefaultValueTyped(object value);
                /*0x1b07598*/ bool CheckEnumeration(object pVal);
                /*0x1b07660*/ bool CheckValue(object pVal);

                enum Use
                {
                    Default = 0,
                    Required = 1,
                    Implied = 2,
                    Fixed = 3,
                    RequiredFixed = 4,
                }
            }

            class SchemaElementDecl : System.Xml.Schema.SchemaDeclBase, System.Xml.IDtdAttributeListInfo
            {
                static /*0x0*/ System.Xml.Schema.SchemaElementDecl Empty;
                /*0x60*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> attdefs;
                /*0x68*/ System.Collections.Generic.List<System.Xml.IDtdDefaultAttributeInfo> defaultAttdefs;
                /*0x70*/ bool isIdDeclared;
                /*0x71*/ bool hasNonCDataAttribute;
                /*0x72*/ bool isAbstract;
                /*0x73*/ bool isNillable;
                /*0x74*/ bool hasRequiredAttribute;
                /*0x75*/ bool isNotationDeclared;
                /*0x78*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> prohibitedAttributes;
                /*0x80*/ System.Xml.Schema.ContentValidator contentValidator;
                /*0x88*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x90*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x98*/ System.Xml.Schema.CompiledIdentityConstraint[] constraints;
                /*0xa0*/ System.Xml.Schema.XmlSchemaElement schemaElement;

                static /*0x1b0802c*/ SchemaElementDecl();
                static /*0x1b07930*/ System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl();
                /*0x1b076ac*/ SchemaElementDecl();
                /*0x1b07760*/ SchemaElementDecl(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x1b07864*/ SchemaElementDecl(System.Xml.XmlQualifiedName name, string prefix);
                /*0x1b07a10*/ bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes();
                /*0x1b07a18*/ System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName);
                /*0x1b07ad0*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes();
                /*0x1b07ad8*/ bool get_IsIdDeclared();
                /*0x1b07ae0*/ void set_IsIdDeclared(bool value);
                /*0x1b07aec*/ bool get_HasNonCDataAttribute();
                /*0x1b07af4*/ void set_HasNonCDataAttribute(bool value);
                /*0x1b07b00*/ System.Xml.Schema.SchemaElementDecl Clone();
                /*0x1b07b68*/ bool get_IsAbstract();
                /*0x1b07b70*/ void set_IsAbstract(bool value);
                /*0x1b07b7c*/ bool get_IsNillable();
                /*0x1b07b84*/ void set_IsNillable(bool value);
                /*0x1b07b90*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x1b07b98*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1b07ba0*/ bool get_IsNotationDeclared();
                /*0x1b07ba8*/ void set_IsNotationDeclared(bool value);
                /*0x1b07bb4*/ bool get_HasDefaultAttribute();
                /*0x1b07bc4*/ bool get_HasRequiredAttribute();
                /*0x1b07bcc*/ System.Xml.Schema.ContentValidator get_ContentValidator();
                /*0x1b07bd4*/ void set_ContentValidator(System.Xml.Schema.ContentValidator value);
                /*0x1b07bdc*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1b07be4*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1b07bec*/ System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints();
                /*0x1b07bf4*/ void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value);
                /*0x1b07bfc*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x1b07c04*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x1b07c0c*/ void AddAttDef(System.Xml.Schema.SchemaAttDef attdef);
                /*0x1b07d24*/ System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname);
                /*0x1b07da0*/ System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs();
                /*0x1b07da8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttDefs();
                /*0x1b07db0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> get_ProhibitedAttributes();
                /*0x1b07db8*/ void CheckAttributes(System.Collections.Hashtable presence, bool standalone);
            }

            class SchemaEntity : System.Xml.IDtdEntityInfo
            {
                /*0x10*/ System.Xml.XmlQualifiedName qname;
                /*0x18*/ string url;
                /*0x20*/ string pubid;
                /*0x28*/ string text;
                /*0x30*/ System.Xml.XmlQualifiedName ndata;
                /*0x38*/ int lineNumber;
                /*0x3c*/ int linePosition;
                /*0x40*/ bool isParameter;
                /*0x41*/ bool isExternal;
                /*0x42*/ bool parsingInProgress;
                /*0x43*/ bool isDeclaredInExternal;
                /*0x48*/ string baseURI;
                /*0x50*/ string declaredURI;

                static /*0x1b08304*/ bool IsPredefinedEntity(string n);
                /*0x1b08088*/ SchemaEntity(System.Xml.XmlQualifiedName qname, bool isParameter);
                /*0x1b0811c*/ string System.Xml.IDtdEntityInfo.get_Name();
                /*0x1b08138*/ bool System.Xml.IDtdEntityInfo.get_IsExternal();
                /*0x1b08140*/ bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal();
                /*0x1b08148*/ bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity();
                /*0x1b08174*/ bool System.Xml.IDtdEntityInfo.get_IsParameterEntity();
                /*0x1b0817c*/ string System.Xml.IDtdEntityInfo.get_BaseUriString();
                /*0x1b0822c*/ string System.Xml.IDtdEntityInfo.get_DeclaredUriString();
                /*0x1b082dc*/ string System.Xml.IDtdEntityInfo.get_SystemId();
                /*0x1b082e4*/ string System.Xml.IDtdEntityInfo.get_PublicId();
                /*0x1b082ec*/ string System.Xml.IDtdEntityInfo.get_Text();
                /*0x1b082f4*/ int System.Xml.IDtdEntityInfo.get_LineNumber();
                /*0x1b082fc*/ int System.Xml.IDtdEntityInfo.get_LinePosition();
                /*0x1b08404*/ System.Xml.XmlQualifiedName get_Name();
                /*0x1b0840c*/ string get_Url();
                /*0x1b08414*/ void set_Url(string value);
                /*0x1b08424*/ string get_Pubid();
                /*0x1b0842c*/ void set_Pubid(string value);
                /*0x1b08434*/ bool get_IsExternal();
                /*0x1b0843c*/ void set_IsExternal(bool value);
                /*0x1b08448*/ bool get_DeclaredInExternal();
                /*0x1b08450*/ void set_DeclaredInExternal(bool value);
                /*0x1b0845c*/ System.Xml.XmlQualifiedName get_NData();
                /*0x1b08464*/ void set_NData(System.Xml.XmlQualifiedName value);
                /*0x1b0846c*/ string get_Text();
                /*0x1b08474*/ void set_Text(string value);
                /*0x1b08480*/ int get_Line();
                /*0x1b08488*/ void set_Line(int value);
                /*0x1b08490*/ int get_Pos();
                /*0x1b08498*/ void set_Pos(int value);
                /*0x1b081d4*/ string get_BaseURI();
                /*0x1b084a0*/ void set_BaseURI(string value);
                /*0x1b084a8*/ bool get_ParsingInProgress();
                /*0x1b084b0*/ void set_ParsingInProgress(bool value);
                /*0x1b08284*/ string get_DeclaredURI();
                /*0x1b084bc*/ void set_DeclaredURI(string value);
            }

            enum AttributeMatchState
            {
                AttributeFound = 0,
                AnyIdAttributeFound = 1,
                UndeclaredElementAndAttribute = 2,
                UndeclaredAttribute = 3,
                AnyAttributeLax = 4,
                AnyAttributeSkip = 5,
                ProhibitedAnyAttribute = 6,
                ProhibitedAttribute = 7,
                AttributeNameMismatch = 8,
                ValidateAttributeInvalidCall = 9,
            }

            class SchemaInfo : System.Xml.IDtdInfo
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> elementDecls;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> undeclaredElementDecls;
                /*0x20*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> generalEntities;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> parameterEntities;
                /*0x30*/ System.Xml.XmlQualifiedName docTypeName;
                /*0x38*/ string internalDtdSubset;
                /*0x40*/ bool hasNonCDataAttributes;
                /*0x41*/ bool hasDefaultAttributes;
                /*0x48*/ System.Collections.Generic.Dictionary<string, bool> targetNamespaces;
                /*0x50*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> attributeDecls;
                /*0x58*/ int errorCount;
                /*0x5c*/ System.Xml.Schema.SchemaType schemaType;
                /*0x60*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> elementDeclsByType;
                /*0x68*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> notations;

                /*0x1b084c4*/ SchemaInfo();
                /*0x1b0865c*/ System.Xml.XmlQualifiedName get_DocTypeName();
                /*0x1b08664*/ void set_DocTypeName(System.Xml.XmlQualifiedName value);
                /*0x1b0866c*/ void set_InternalDtdSubset(string value);
                /*0x1b08674*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDecls();
                /*0x1b0867c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls();
                /*0x1b08684*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_GeneralEntities();
                /*0x1b08700*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_ParameterEntities();
                /*0x1b0877c*/ System.Xml.Schema.SchemaType get_SchemaType();
                /*0x1b08784*/ void set_SchemaType(System.Xml.Schema.SchemaType value);
                /*0x1b0878c*/ System.Collections.Generic.Dictionary<string, bool> get_TargetNamespaces();
                /*0x1b08794*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType();
                /*0x1b0879c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttributeDecls();
                /*0x1b087a4*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> get_Notations();
                /*0x1b08820*/ int get_ErrorCount();
                /*0x1b08828*/ void set_ErrorCount(int value);
                /*0x1b08830*/ System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname);
                /*0x1b088ac*/ System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname);
                /*0x1b08928*/ System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname);
                /*0x1b08944*/ bool HasSchema(string ns);
                /*0x1b089a8*/ bool Contains(string ns);
                /*0x1b08a0c*/ System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname);
                /*0x1b08b64*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, ref System.Xml.Schema.AttributeMatchState attributeMatchState);
                /*0x1b08d90*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, ref bool skip);
                /*0x1b08e94*/ void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x1b09b84*/ void Finish();
                /*0x1b09d58*/ bool System.Xml.IDtdInfo.get_HasDefaultAttributes();
                /*0x1b09d60*/ bool System.Xml.IDtdInfo.get_HasNonCDataAttributes();
                /*0x1b09d68*/ System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName);
                /*0x1b09e34*/ System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name);
                /*0x1b09eec*/ System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name();
                /*0x1b09ef4*/ string System.Xml.IDtdInfo.get_InternalDtdSubset();
            }

            class SchemaNames
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ string NsDataType;
                /*0x20*/ string NsDataTypeAlias;
                /*0x28*/ string NsDataTypeOld;
                /*0x30*/ string NsXml;
                /*0x38*/ string NsXmlNs;
                /*0x40*/ string NsXdr;
                /*0x48*/ string NsXdrAlias;
                /*0x50*/ string NsXs;
                /*0x58*/ string NsXsi;
                /*0x60*/ string XsiType;
                /*0x68*/ string XsiNil;
                /*0x70*/ string XsiSchemaLocation;
                /*0x78*/ string XsiNoNamespaceSchemaLocation;
                /*0x80*/ string XsdSchema;
                /*0x88*/ string XdrSchema;
                /*0x90*/ System.Xml.XmlQualifiedName QnPCData;
                /*0x98*/ System.Xml.XmlQualifiedName QnXml;
                /*0xa0*/ System.Xml.XmlQualifiedName QnXmlNs;
                /*0xa8*/ System.Xml.XmlQualifiedName QnDtDt;
                /*0xb0*/ System.Xml.XmlQualifiedName QnXmlLang;
                /*0xb8*/ System.Xml.XmlQualifiedName QnName;
                /*0xc0*/ System.Xml.XmlQualifiedName QnType;
                /*0xc8*/ System.Xml.XmlQualifiedName QnMaxOccurs;
                /*0xd0*/ System.Xml.XmlQualifiedName QnMinOccurs;
                /*0xd8*/ System.Xml.XmlQualifiedName QnInfinite;
                /*0xe0*/ System.Xml.XmlQualifiedName QnModel;
                /*0xe8*/ System.Xml.XmlQualifiedName QnOpen;
                /*0xf0*/ System.Xml.XmlQualifiedName QnClosed;
                /*0xf8*/ System.Xml.XmlQualifiedName QnContent;
                /*0x100*/ System.Xml.XmlQualifiedName QnMixed;
                /*0x108*/ System.Xml.XmlQualifiedName QnEmpty;
                /*0x110*/ System.Xml.XmlQualifiedName QnEltOnly;
                /*0x118*/ System.Xml.XmlQualifiedName QnTextOnly;
                /*0x120*/ System.Xml.XmlQualifiedName QnOrder;
                /*0x128*/ System.Xml.XmlQualifiedName QnSeq;
                /*0x130*/ System.Xml.XmlQualifiedName QnOne;
                /*0x138*/ System.Xml.XmlQualifiedName QnMany;
                /*0x140*/ System.Xml.XmlQualifiedName QnRequired;
                /*0x148*/ System.Xml.XmlQualifiedName QnYes;
                /*0x150*/ System.Xml.XmlQualifiedName QnNo;
                /*0x158*/ System.Xml.XmlQualifiedName QnString;
                /*0x160*/ System.Xml.XmlQualifiedName QnID;
                /*0x168*/ System.Xml.XmlQualifiedName QnIDRef;
                /*0x170*/ System.Xml.XmlQualifiedName QnIDRefs;
                /*0x178*/ System.Xml.XmlQualifiedName QnEntity;
                /*0x180*/ System.Xml.XmlQualifiedName QnEntities;
                /*0x188*/ System.Xml.XmlQualifiedName QnNmToken;
                /*0x190*/ System.Xml.XmlQualifiedName QnNmTokens;
                /*0x198*/ System.Xml.XmlQualifiedName QnEnumeration;
                /*0x1a0*/ System.Xml.XmlQualifiedName QnDefault;
                /*0x1a8*/ System.Xml.XmlQualifiedName QnXdrSchema;
                /*0x1b0*/ System.Xml.XmlQualifiedName QnXdrElementType;
                /*0x1b8*/ System.Xml.XmlQualifiedName QnXdrElement;
                /*0x1c0*/ System.Xml.XmlQualifiedName QnXdrGroup;
                /*0x1c8*/ System.Xml.XmlQualifiedName QnXdrAttributeType;
                /*0x1d0*/ System.Xml.XmlQualifiedName QnXdrAttribute;
                /*0x1d8*/ System.Xml.XmlQualifiedName QnXdrDataType;
                /*0x1e0*/ System.Xml.XmlQualifiedName QnXdrDescription;
                /*0x1e8*/ System.Xml.XmlQualifiedName QnXdrExtends;
                /*0x1f0*/ System.Xml.XmlQualifiedName QnXdrAliasSchema;
                /*0x1f8*/ System.Xml.XmlQualifiedName QnDtType;
                /*0x200*/ System.Xml.XmlQualifiedName QnDtValues;
                /*0x208*/ System.Xml.XmlQualifiedName QnDtMaxLength;
                /*0x210*/ System.Xml.XmlQualifiedName QnDtMinLength;
                /*0x218*/ System.Xml.XmlQualifiedName QnDtMax;
                /*0x220*/ System.Xml.XmlQualifiedName QnDtMin;
                /*0x228*/ System.Xml.XmlQualifiedName QnDtMinExclusive;
                /*0x230*/ System.Xml.XmlQualifiedName QnDtMaxExclusive;
                /*0x238*/ System.Xml.XmlQualifiedName QnTargetNamespace;
                /*0x240*/ System.Xml.XmlQualifiedName QnVersion;
                /*0x248*/ System.Xml.XmlQualifiedName QnFinalDefault;
                /*0x250*/ System.Xml.XmlQualifiedName QnBlockDefault;
                /*0x258*/ System.Xml.XmlQualifiedName QnFixed;
                /*0x260*/ System.Xml.XmlQualifiedName QnAbstract;
                /*0x268*/ System.Xml.XmlQualifiedName QnBlock;
                /*0x270*/ System.Xml.XmlQualifiedName QnSubstitutionGroup;
                /*0x278*/ System.Xml.XmlQualifiedName QnFinal;
                /*0x280*/ System.Xml.XmlQualifiedName QnNillable;
                /*0x288*/ System.Xml.XmlQualifiedName QnRef;
                /*0x290*/ System.Xml.XmlQualifiedName QnBase;
                /*0x298*/ System.Xml.XmlQualifiedName QnDerivedBy;
                /*0x2a0*/ System.Xml.XmlQualifiedName QnNamespace;
                /*0x2a8*/ System.Xml.XmlQualifiedName QnProcessContents;
                /*0x2b0*/ System.Xml.XmlQualifiedName QnRefer;
                /*0x2b8*/ System.Xml.XmlQualifiedName QnPublic;
                /*0x2c0*/ System.Xml.XmlQualifiedName QnSystem;
                /*0x2c8*/ System.Xml.XmlQualifiedName QnSchemaLocation;
                /*0x2d0*/ System.Xml.XmlQualifiedName QnValue;
                /*0x2d8*/ System.Xml.XmlQualifiedName QnUse;
                /*0x2e0*/ System.Xml.XmlQualifiedName QnForm;
                /*0x2e8*/ System.Xml.XmlQualifiedName QnElementFormDefault;
                /*0x2f0*/ System.Xml.XmlQualifiedName QnAttributeFormDefault;
                /*0x2f8*/ System.Xml.XmlQualifiedName QnItemType;
                /*0x300*/ System.Xml.XmlQualifiedName QnMemberTypes;
                /*0x308*/ System.Xml.XmlQualifiedName QnXPath;
                /*0x310*/ System.Xml.XmlQualifiedName QnXsdSchema;
                /*0x318*/ System.Xml.XmlQualifiedName QnXsdAnnotation;
                /*0x320*/ System.Xml.XmlQualifiedName QnXsdInclude;
                /*0x328*/ System.Xml.XmlQualifiedName QnXsdImport;
                /*0x330*/ System.Xml.XmlQualifiedName QnXsdElement;
                /*0x338*/ System.Xml.XmlQualifiedName QnXsdAttribute;
                /*0x340*/ System.Xml.XmlQualifiedName QnXsdAttributeGroup;
                /*0x348*/ System.Xml.XmlQualifiedName QnXsdAnyAttribute;
                /*0x350*/ System.Xml.XmlQualifiedName QnXsdGroup;
                /*0x358*/ System.Xml.XmlQualifiedName QnXsdAll;
                /*0x360*/ System.Xml.XmlQualifiedName QnXsdChoice;
                /*0x368*/ System.Xml.XmlQualifiedName QnXsdSequence;
                /*0x370*/ System.Xml.XmlQualifiedName QnXsdAny;
                /*0x378*/ System.Xml.XmlQualifiedName QnXsdNotation;
                /*0x380*/ System.Xml.XmlQualifiedName QnXsdSimpleType;
                /*0x388*/ System.Xml.XmlQualifiedName QnXsdComplexType;
                /*0x390*/ System.Xml.XmlQualifiedName QnXsdUnique;
                /*0x398*/ System.Xml.XmlQualifiedName QnXsdKey;
                /*0x3a0*/ System.Xml.XmlQualifiedName QnXsdKeyRef;
                /*0x3a8*/ System.Xml.XmlQualifiedName QnXsdSelector;
                /*0x3b0*/ System.Xml.XmlQualifiedName QnXsdField;
                /*0x3b8*/ System.Xml.XmlQualifiedName QnXsdMinExclusive;
                /*0x3c0*/ System.Xml.XmlQualifiedName QnXsdMinInclusive;
                /*0x3c8*/ System.Xml.XmlQualifiedName QnXsdMaxInclusive;
                /*0x3d0*/ System.Xml.XmlQualifiedName QnXsdMaxExclusive;
                /*0x3d8*/ System.Xml.XmlQualifiedName QnXsdTotalDigits;
                /*0x3e0*/ System.Xml.XmlQualifiedName QnXsdFractionDigits;
                /*0x3e8*/ System.Xml.XmlQualifiedName QnXsdLength;
                /*0x3f0*/ System.Xml.XmlQualifiedName QnXsdMinLength;
                /*0x3f8*/ System.Xml.XmlQualifiedName QnXsdMaxLength;
                /*0x400*/ System.Xml.XmlQualifiedName QnXsdEnumeration;
                /*0x408*/ System.Xml.XmlQualifiedName QnXsdPattern;
                /*0x410*/ System.Xml.XmlQualifiedName QnXsdDocumentation;
                /*0x418*/ System.Xml.XmlQualifiedName QnXsdAppinfo;
                /*0x420*/ System.Xml.XmlQualifiedName QnSource;
                /*0x428*/ System.Xml.XmlQualifiedName QnXsdComplexContent;
                /*0x430*/ System.Xml.XmlQualifiedName QnXsdSimpleContent;
                /*0x438*/ System.Xml.XmlQualifiedName QnXsdRestriction;
                /*0x440*/ System.Xml.XmlQualifiedName QnXsdExtension;
                /*0x448*/ System.Xml.XmlQualifiedName QnXsdUnion;
                /*0x450*/ System.Xml.XmlQualifiedName QnXsdList;
                /*0x458*/ System.Xml.XmlQualifiedName QnXsdWhiteSpace;
                /*0x460*/ System.Xml.XmlQualifiedName QnXsdRedefine;
                /*0x468*/ System.Xml.XmlQualifiedName QnXsdAnyType;
                /*0x470*/ System.Xml.XmlQualifiedName[] TokenToQName;

                /*0x1b09efc*/ SchemaNames(System.Xml.XmlNameTable nameTable);
                /*0x1b0c7e8*/ void CreateTokenToQNameTable();
                /*0x1b0e1a0*/ System.Xml.Schema.SchemaType SchemaTypeFromRoot(string localName, string ns);
                /*0x1b0e20c*/ bool IsXSDRoot(string localName, string ns);
                /*0x1b0e260*/ bool IsXDRRoot(string localName, string ns);

                enum Token
                {
                    Empty = 0,
                    SchemaName = 1,
                    SchemaType = 2,
                    SchemaMaxOccurs = 3,
                    SchemaMinOccurs = 4,
                    SchemaInfinite = 5,
                    SchemaModel = 6,
                    SchemaOpen = 7,
                    SchemaClosed = 8,
                    SchemaContent = 9,
                    SchemaMixed = 10,
                    SchemaEmpty = 11,
                    SchemaElementOnly = 12,
                    SchemaTextOnly = 13,
                    SchemaOrder = 14,
                    SchemaSeq = 15,
                    SchemaOne = 16,
                    SchemaMany = 17,
                    SchemaRequired = 18,
                    SchemaYes = 19,
                    SchemaNo = 20,
                    SchemaString = 21,
                    SchemaId = 22,
                    SchemaIdref = 23,
                    SchemaIdrefs = 24,
                    SchemaEntity = 25,
                    SchemaEntities = 26,
                    SchemaNmtoken = 27,
                    SchemaNmtokens = 28,
                    SchemaEnumeration = 29,
                    SchemaDefault = 30,
                    XdrRoot = 31,
                    XdrElementType = 32,
                    XdrElement = 33,
                    XdrGroup = 34,
                    XdrAttributeType = 35,
                    XdrAttribute = 36,
                    XdrDatatype = 37,
                    XdrDescription = 38,
                    XdrExtends = 39,
                    SchemaXdrRootAlias = 40,
                    SchemaDtType = 41,
                    SchemaDtValues = 42,
                    SchemaDtMaxLength = 43,
                    SchemaDtMinLength = 44,
                    SchemaDtMax = 45,
                    SchemaDtMin = 46,
                    SchemaDtMinExclusive = 47,
                    SchemaDtMaxExclusive = 48,
                    SchemaTargetNamespace = 49,
                    SchemaVersion = 50,
                    SchemaFinalDefault = 51,
                    SchemaBlockDefault = 52,
                    SchemaFixed = 53,
                    SchemaAbstract = 54,
                    SchemaBlock = 55,
                    SchemaSubstitutionGroup = 56,
                    SchemaFinal = 57,
                    SchemaNillable = 58,
                    SchemaRef = 59,
                    SchemaBase = 60,
                    SchemaDerivedBy = 61,
                    SchemaNamespace = 62,
                    SchemaProcessContents = 63,
                    SchemaRefer = 64,
                    SchemaPublic = 65,
                    SchemaSystem = 66,
                    SchemaSchemaLocation = 67,
                    SchemaValue = 68,
                    SchemaSource = 69,
                    SchemaAttributeFormDefault = 70,
                    SchemaElementFormDefault = 71,
                    SchemaUse = 72,
                    SchemaForm = 73,
                    XsdSchema = 74,
                    XsdAnnotation = 75,
                    XsdInclude = 76,
                    XsdImport = 77,
                    XsdElement = 78,
                    XsdAttribute = 79,
                    xsdAttributeGroup = 80,
                    XsdAnyAttribute = 81,
                    XsdGroup = 82,
                    XsdAll = 83,
                    XsdChoice = 84,
                    XsdSequence = 85,
                    XsdAny = 86,
                    XsdNotation = 87,
                    XsdSimpleType = 88,
                    XsdComplexType = 89,
                    XsdUnique = 90,
                    XsdKey = 91,
                    XsdKeyref = 92,
                    XsdSelector = 93,
                    XsdField = 94,
                    XsdMinExclusive = 95,
                    XsdMinInclusive = 96,
                    XsdMaxExclusive = 97,
                    XsdMaxInclusive = 98,
                    XsdTotalDigits = 99,
                    XsdFractionDigits = 100,
                    XsdLength = 101,
                    XsdMinLength = 102,
                    XsdMaxLength = 103,
                    XsdEnumeration = 104,
                    XsdPattern = 105,
                    XsdDocumentation = 106,
                    XsdAppInfo = 107,
                    XsdComplexContent = 108,
                    XsdComplexContentExtension = 109,
                    XsdComplexContentRestriction = 110,
                    XsdSimpleContent = 111,
                    XsdSimpleContentExtension = 112,
                    XsdSimpleContentRestriction = 113,
                    XsdSimpleTypeList = 114,
                    XsdSimpleTypeRestriction = 115,
                    XsdSimpleTypeUnion = 116,
                    XsdWhitespace = 117,
                    XsdRedefine = 118,
                    SchemaItemType = 119,
                    SchemaMemberTypes = 120,
                    SchemaXPath = 121,
                    XmlLang = 122,
                }
            }

            class SchemaNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObject node;

                /*0x1b0e2b4*/ SchemaNamespaceManager(System.Xml.Schema.XmlSchemaObject node);
                /*0x1b0e2e0*/ string LookupNamespace(string prefix);
                /*0x1b0e414*/ string LookupPrefix(string ns);
            }

            class SchemaNotation
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string systemLiteral;
                /*0x20*/ string pubid;

                /*0x1b0e820*/ SchemaNotation(System.Xml.XmlQualifiedName name);
                /*0x1b0e84c*/ System.Xml.XmlQualifiedName get_Name();
                /*0x1b0e854*/ string get_SystemLiteral();
                /*0x1b0e85c*/ void set_SystemLiteral(string value);
                /*0x1b0e864*/ string get_Pubid();
                /*0x1b0e86c*/ void set_Pubid(string value);
            }

            class Compiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ string restrictionErrorMsg;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectTable schemaTypes;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectTable groups;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable notations;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable identityConstraints;
                /*0x88*/ System.Collections.Stack complexTypeStack;
                /*0x90*/ System.Collections.Hashtable schemasToCompile;
                /*0x98*/ System.Collections.Hashtable importedSchemas;
                /*0xa0*/ System.Xml.Schema.XmlSchema schemaForSchema;

                /*0x15946b4*/ Compiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x159486c*/ bool Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo);
                /*0x1597688*/ void Prepare(System.Xml.Schema.XmlSchema schema, bool cleanup);
                /*0x15992f0*/ void UpdateSForSSimpleTypes();
                /*0x1596698*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x1599454*/ void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x15948e4*/ bool Compile();
                /*0x1598d24*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x1598d98*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x1598df0*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1599238*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x1598b94*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x159dec0*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x1598d58*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x159df9c*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x159cfc0*/ void ProcessSubstitutionGroups();
                /*0x159e148*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x159dd78*/ void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup);
                /*0x159de38*/ void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup);
                /*0x1599560*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x159a940*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x159f4a4*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x159f85c*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x1599eb0*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x159f980*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x159fbc8*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x15a001c*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x15a03b0*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x159d7b8*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x159e9f0*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x15a1a88*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x159e63c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root);
                /*0x15a493c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x15a36a4*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root);
                /*0x15a3c38*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root);
                /*0x15a3ed4*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root);
                /*0x15a4434*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root);
                /*0x15a2948*/ System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x15a2c50*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x15a4c64*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x15a4e80*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x15a501c*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x15a5118*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x15a54d4*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase);
                /*0x15a62d8*/ bool IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x15a5d04*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x15a5fd8*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x15a6468*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x15a678c*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x15a7044*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x15a7140*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x15a4bb4*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x15a6934*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x15a7240*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x15a1c08*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1599638*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x15a0660*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x159eac4*/ void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup);
                /*0x15a738c*/ bool IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard);
                /*0x15a72f8*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x15a7264*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x159c02c*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x15a7484*/ void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl);
                /*0x159c830*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x159b26c*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x15a1c84*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x15a760c*/ bool BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x15a7b34*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x159e864*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x159ceb4*/ void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x159f3b4*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x15a2894*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x15a2728*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
                /*0x15a4b44*/ void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, bool copyParent);
                /*0x15a67d4*/ bool IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl);
            }

            enum SchemaType
            {
                None = 0,
                DTD = 1,
                XDR = 2,
                XSD = 3,
            }

            class ValidationEventArgs : System.EventArgs
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaException ex;
                /*0x18*/ System.Xml.Schema.XmlSeverityType severity;

                /*0x1b09774*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex);
                /*0x1b1b73c*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity);
                /*0x1b1b7bc*/ System.Xml.Schema.XmlSeverityType get_Severity();
                /*0x1b1b7c4*/ System.Xml.Schema.XmlSchemaException get_Exception();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0x1b1b7cc*/ ValidationEventHandler(object object, nint method);
                /*0x1b097f0*/ void Invoke(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0x1b1b82c*/ System.IAsyncResult BeginInvoke(object sender, System.Xml.Schema.ValidationEventArgs e, System.AsyncCallback callback, object object);
                /*0x1b1b85c*/ void EndInvoke(System.IAsyncResult result);
            }

            struct StateUnion
            {
                /*0x10*/ int State;
                /*0x10*/ int AllElementsRequired;
                /*0x10*/ int CurPosIndex;
                /*0x10*/ int NumberOfRunningPos;
            }

            class ValidationState
            {
                /*0x10*/ bool IsNill;
                /*0x11*/ bool IsDefault;
                /*0x12*/ bool NeedValidateChildren;
                /*0x13*/ bool CheckRequiredAttribute;
                /*0x14*/ bool ValidationSkipped;
                /*0x18*/ System.Xml.Schema.XmlSchemaContentProcessing ProcessContents;
                /*0x1c*/ System.Xml.Schema.XmlSchemaValidity Validity;
                /*0x20*/ System.Xml.Schema.SchemaElementDecl ElementDecl;
                /*0x28*/ System.Xml.Schema.SchemaElementDecl ElementDeclBeforeXsi;
                /*0x30*/ string LocalName;
                /*0x38*/ string Namespace;
                /*0x40*/ System.Xml.Schema.ConstraintStruct[] Constr;
                /*0x48*/ System.Xml.Schema.StateUnion CurrentState;
                /*0x4c*/ bool HasMatched;
                /*0x50*/ System.Xml.Schema.BitSet[] CurPos;
                /*0x58*/ System.Xml.Schema.BitSet AllElementsSet;
                /*0x60*/ System.Collections.Generic.List<System.Xml.Schema.RangePositionInfo> RunningPositions;
                /*0x68*/ bool TooComplex;

                /*0x1b1b868*/ ValidationState();
            }

            class XdrBuilder : System.Xml.Schema.SchemaBuilder
            {
                static /*0x0*/ int[] S_XDR_Root_Element;
                static /*0x8*/ int[] S_XDR_Root_SubElements;
                static /*0x10*/ int[] S_XDR_ElementType_SubElements;
                static /*0x18*/ int[] S_XDR_AttributeType_SubElements;
                static /*0x20*/ int[] S_XDR_Group_SubElements;
                static /*0x28*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes;
                static /*0x30*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes;
                static /*0x38*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes;
                static /*0x40*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes;
                static /*0x48*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes;
                static /*0x50*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes;
                static /*0x58*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes;
                static /*0x60*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes;
                static /*0x68*/ System.Xml.Schema.XdrBuilder.XdrEntry[] S_SchemaEntries;
                /*0x10*/ System.Xml.Schema.SchemaInfo _SchemaInfo;
                /*0x18*/ string _TargetNamespace;
                /*0x20*/ System.Xml.XmlReader _reader;
                /*0x28*/ System.Xml.PositionInfo positionInfo;
                /*0x30*/ System.Xml.Schema.ParticleContentValidator _contentValidator;
                /*0x38*/ System.Xml.Schema.XdrBuilder.XdrEntry _CurState;
                /*0x40*/ System.Xml.Schema.XdrBuilder.XdrEntry _NextState;
                /*0x48*/ System.Xml.HWStack _StateHistory;
                /*0x50*/ System.Xml.HWStack _GroupStack;
                /*0x58*/ string _XdrName;
                /*0x60*/ string _XdrPrefix;
                /*0x68*/ System.Xml.Schema.XdrBuilder.ElementContent _ElementDef;
                /*0x70*/ System.Xml.Schema.XdrBuilder.GroupContent _GroupDef;
                /*0x78*/ System.Xml.Schema.XdrBuilder.AttributeContent _AttributeDef;
                /*0x80*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes;
                /*0x88*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _BaseDecl;
                /*0x90*/ System.Xml.XmlNameTable _NameTable;
                /*0x98*/ System.Xml.Schema.SchemaNames _SchemaNames;
                /*0xa0*/ System.Xml.XmlNamespaceManager _CurNsMgr;
                /*0xa8*/ string _Text;
                /*0xb0*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0xb8*/ System.Collections.Hashtable _UndeclaredElements;
                /*0xc0*/ System.Xml.XmlResolver xmlResolver;

                static /*0x1d1ebf8*/ XdrBuilder();
                static /*0x1d19f18*/ bool IsXdrSchema(string uri);
                static /*0x1d1a9d0*/ void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1aa1c*/ void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1aa98*/ void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1aa9c*/ void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1ab7c*/ void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1b0bc*/ void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1b214*/ void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1b3dc*/ void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1b620*/ void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1b7bc*/ void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1b9a4*/ void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1bb1c*/ void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1bc04*/ void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1bdd0*/ void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1bf9c*/ void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1c28c*/ void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1c684*/ void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1c774*/ void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1c9b8*/ void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1cb50*/ void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1cb74*/ void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1cd8c*/ void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1ce74*/ void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1cefc*/ void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1cf84*/ void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1d000*/ void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1d358*/ void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1d404*/ void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1d658*/ void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1d7e4*/ void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1d9a0*/ void XDR_EndElement(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1da8c*/ void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1db00*/ void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1dbac*/ void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1dc3c*/ void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1dc60*/ void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1df30*/ void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1df54*/ void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1e030*/ void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1e12c*/ void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1e1c4*/ void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x1d1e25c*/ void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1e398*/ void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1e438*/ void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1e514*/ void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x1d1e584*/ void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1ca44*/ bool IsYes(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1d6e0*/ uint ParseMinOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1d86c*/ uint ParseMaxOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1da5c*/ void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, uint cMin, uint cMax);
                static /*0x1d1bc8c*/ void ParseDtMaxLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1be58*/ void ParseDtMinLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1c5f8*/ void CompareMinMaxLength(uint cMin, uint cMax, System.Xml.Schema.XdrBuilder builder);
                static /*0x1d1e668*/ bool ParseInteger(string str, ref uint n);
                /*0x1d19464*/ XdrBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, string targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x1d19664*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x1d19b68*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x1d1a634*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x1d19fd4*/ bool LoadSchema(string uri);
                /*0x1d1a734*/ bool IsContentParsed();
                /*0x1d1a73c*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x1d1a798*/ void ProcessCData(string value);
                /*0x1d1a81c*/ void StartChildren();
                /*0x1d1a848*/ void EndChildren();
                /*0x1d19954*/ void Push();
                /*0x1d1a888*/ void Pop();
                /*0x1d1a8fc*/ void PushGroupInfo();
                /*0x1d1a95c*/ void PopGroupInfo();
                /*0x1d1979c*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x1d199a8*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x1d1a4f0*/ bool IsSkipableAttribute(System.Xml.XmlQualifiedName qname);
                /*0x1d1b86c*/ int GetOrder(System.Xml.XmlQualifiedName qname);
                /*0x1d1d598*/ void AddOrder();
                /*0x1d1b014*/ void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef);
                /*0x1d1d308*/ void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, bool fRequired);
                /*0x1d1b484*/ int GetContent(System.Xml.XmlQualifiedName qname);
                /*0x1d1b6cc*/ bool GetModel(System.Xml.XmlQualifiedName qname);
                /*0x1d1cc38*/ System.Xml.Schema.XmlSchemaDatatype CheckDatatype(string str);
                /*0x1d1d214*/ void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef);
                /*0x1d19f0c*/ bool IsGlobal(int flags);
                /*0x1d1a63c*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x1d1bab8*/ void SendValidationEvent(string code);
                /*0x1d19a74*/ void SendValidationEvent(string code, string msg);
                /*0x1d1eb20*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);

                class DeclBaseInfo
                {
                    /*0x10*/ System.Xml.XmlQualifiedName _Name;
                    /*0x18*/ string _Prefix;
                    /*0x20*/ System.Xml.XmlQualifiedName _TypeName;
                    /*0x28*/ string _TypePrefix;
                    /*0x30*/ object _Default;
                    /*0x38*/ object _Revises;
                    /*0x40*/ uint _MaxOccurs;
                    /*0x44*/ uint _MinOccurs;
                    /*0x48*/ bool _Checking;
                    /*0x50*/ System.Xml.Schema.SchemaElementDecl _ElementDecl;
                    /*0x58*/ System.Xml.Schema.SchemaAttDef _Attdef;
                    /*0x60*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _Next;

                    /*0x16c4b48*/ DeclBaseInfo();
                    /*0x16c4b70*/ void Reset();
                }

                class GroupContent
                {
                    /*0x10*/ uint _MinVal;
                    /*0x14*/ uint _MaxVal;
                    /*0x18*/ bool _HasMaxAttr;
                    /*0x19*/ bool _HasMinAttr;
                    /*0x1c*/ int _Order;

                    static /*0x16c4c08*/ void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to);
                    static /*0x16c4c3c*/ System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other);
                    /*0x16c4ca4*/ GroupContent();
                }

                class ElementContent
                {
                    /*0x10*/ System.Xml.Schema.SchemaElementDecl _ElementDecl;
                    /*0x18*/ int _ContentAttr;
                    /*0x1c*/ int _OrderAttr;
                    /*0x20*/ bool _MasterGroupRequired;
                    /*0x21*/ bool _ExistTerminal;
                    /*0x22*/ bool _AllowDataType;
                    /*0x23*/ bool _HasDataType;
                    /*0x24*/ bool _HasType;
                    /*0x25*/ bool _EnumerationRequired;
                    /*0x28*/ uint _MinVal;
                    /*0x2c*/ uint _MaxVal;
                    /*0x30*/ uint _MaxLength;
                    /*0x34*/ uint _MinLength;
                    /*0x38*/ System.Collections.Hashtable _AttDefList;

                    /*0x16c4c00*/ ElementContent();
                }

                class AttributeContent
                {
                    /*0x10*/ System.Xml.Schema.SchemaAttDef _AttDef;
                    /*0x18*/ System.Xml.XmlQualifiedName _Name;
                    /*0x20*/ string _Prefix;
                    /*0x28*/ bool _Required;
                    /*0x2c*/ uint _MinVal;
                    /*0x30*/ uint _MaxVal;
                    /*0x34*/ uint _MaxLength;
                    /*0x38*/ uint _MinLength;
                    /*0x3c*/ bool _EnumerationRequired;
                    /*0x3d*/ bool _HasDataType;
                    /*0x3e*/ bool _Global;
                    /*0x40*/ object _Default;

                    /*0x16c4b40*/ AttributeContent();
                }

                class XdrBuildFunction : System.MulticastDelegate
                {
                    /*0x16c5160*/ XdrBuildFunction(object object, nint method);
                    /*0x16c51c0*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                    /*0x16c5578*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix, System.AsyncCallback callback, object object);
                    /*0x16c55a8*/ void EndInvoke(System.IAsyncResult result);
                }

                class XdrInitFunction : System.MulticastDelegate
                {
                    /*0x16c5a2c*/ XdrInitFunction(object object, nint method);
                    /*0x16c5a8c*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj);
                    /*0x16c5e20*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XdrBuilder builder, object obj, System.AsyncCallback callback, object object);
                    /*0x16c5e50*/ void EndInvoke(System.IAsyncResult result);
                }

                class XdrBeginChildFunction : System.MulticastDelegate
                {
                    /*0x16c4d58*/ XdrBeginChildFunction(object object, nint method);
                    /*0x16c4db8*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                    /*0x16c5130*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XdrBuilder builder, System.AsyncCallback callback, object object);
                    /*0x16c5154*/ void EndInvoke(System.IAsyncResult result);
                }

                class XdrEndChildFunction : System.MulticastDelegate
                {
                    /*0x16c55b4*/ XdrEndChildFunction(object object, nint method);
                    /*0x16c5614*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                    /*0x16c598c*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XdrBuilder builder, System.AsyncCallback callback, object object);
                    /*0x16c59b0*/ void EndInvoke(System.IAsyncResult result);
                }

                class XdrAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Attribute;
                    /*0x14*/ int _SchemaFlags;
                    /*0x18*/ System.Xml.Schema.XmlSchemaDatatype _Datatype;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;

                    /*0x16c4cac*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                    /*0x16c4cfc*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, int schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                }

                class XdrEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Name;
                    /*0x18*/ int[] _NextStates;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] _Attributes;
                    /*0x28*/ System.Xml.Schema.XdrBuilder.XdrInitFunction _InitFunc;
                    /*0x30*/ System.Xml.Schema.XdrBuilder.XdrBeginChildFunction _BeginChildFunc;
                    /*0x38*/ System.Xml.Schema.XdrBuilder.XdrEndChildFunction _EndChildFunc;
                    /*0x40*/ bool _AllowText;

                    /*0x16c59bc*/ XdrEntry(System.Xml.Schema.SchemaNames.Token n, int[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, bool fText);
                }
            }

            class XdrValidator : System.Xml.Schema.BaseValidator
            {
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlQualifiedName name;
                /*0x98*/ System.Xml.XmlNamespaceManager nsManager;
                /*0xa0*/ bool isProcessContents;
                /*0xa8*/ System.Collections.Hashtable IDs;
                /*0xb0*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xb8*/ System.Xml.Schema.Parser inlineSchemaParser;

                static /*0x1d1e6a4*/ void CheckDefaultValue(string value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos);
                /*0x1d20688*/ XdrValidator(System.Xml.Schema.BaseValidator validator);
                /*0x1d208b4*/ XdrValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x1d20714*/ void Init();
                /*0x1d20a54*/ void Validate();
                /*0x1d20d1c*/ void ValidateElement();
                /*0x1d21094*/ void ValidateChildElement();
                /*0x1d20b28*/ bool get_IsInlineSchemaStarted();
                /*0x1d20b38*/ void ProcessInlineSchema();
                /*0x1d211f0*/ void ProcessElement();
                /*0x1d20ec0*/ void ValidateEndElement();
                /*0x1d212a4*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl();
                /*0x1d215d0*/ void ValidateStartElement();
                /*0x1d219fc*/ void ValidateEndStartElement();
                /*0x1d22670*/ void LoadSchemaFromLocation(string uri);
                /*0x1d22438*/ void LoadSchema(string uri);
                /*0x1d22d14*/ bool get_HasSchema();
                /*0x1d22d38*/ bool get_PreserveWhitespace();
                /*0x1d22d74*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x1d23010*/ void CompleteValidation();
                /*0x1d21d88*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x1d22f7c*/ void AddID(string name, object node);
                /*0x1d231f4*/ object FindId(string name);
                /*0x1d20958*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x1d223a8*/ void Pop();
                /*0x1d230e4*/ void CheckForwardRefs();
                /*0x1d225d0*/ System.Xml.XmlQualifiedName QualifiedName(string name, string ns);
            }

            class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaType xmlType;
                /*0x18*/ object objVal;
                /*0x20*/ System.TypeCode clrType;
                /*0x24*/ System.Xml.Schema.XmlAtomicValue.Union unionVal;
                /*0x30*/ System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;

                /*0x1d24524*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, bool value);
                /*0x1d24954*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value);
                /*0x1d24ef4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, double value);
                /*0x1d251a0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, int value);
                /*0x1d25448*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, long value);
                /*0x1d25704*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value);
                /*0x1d2a89c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d24c28*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value);
                /*0x1d26f44*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d2ab38*/ object System.ICloneable.Clone();
                /*0x1d2ab3c*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x1d2ab44*/ System.Type get_ValueType();
                /*0x1d2ab70*/ object get_TypedValue();
                /*0x1d2ad50*/ bool get_ValueAsBoolean();
                /*0x1d2ae38*/ System.DateTime get_ValueAsDateTime();
                /*0x1d2af34*/ double get_ValueAsDouble();
                /*0x1d2b028*/ int get_ValueAsInt();
                /*0x1d2b118*/ long get_ValueAsLong();
                /*0x1d2b214*/ object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d2b45c*/ string get_Value();
                /*0x1d2b56c*/ string ToString();
                /*0x1d2aa60*/ string GetPrefixFromQName(string value);

                struct Union
                {
                    /*0x10*/ bool boolVal;
                    /*0x10*/ double dblVal;
                    /*0x10*/ long i64Val;
                    /*0x10*/ int i32Val;
                    /*0x10*/ System.DateTime dtVal;
                }

                class NamespacePrefixForQName : System.Xml.IXmlNamespaceResolver
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ string ns;

                    /*0x16c5e5c*/ NamespacePrefixForQName(string prefix, string ns);
                    /*0x16c5e94*/ string LookupNamespace(string prefix);
                    /*0x16c5ed4*/ string LookupPrefix(string namespaceName);
                    /*0x16c5f0c*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                }
            }

            class XmlSchema : System.Xml.Schema.XmlSchemaObject
            {
                static /*0x0*/ int globalIdCounter;
                /*0x34*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x38*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x3c*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x40*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x48*/ string targetNs;
                /*0x50*/ string version;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection includes;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x68*/ string id;
                /*0x70*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x78*/ bool isCompiled;
                /*0x79*/ bool isCompiledBySet;
                /*0x7a*/ bool isPreprocessed;
                /*0x7b*/ bool isRedefined;
                /*0x7c*/ int errorCount;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x88*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x90*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x98*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObjectTable groups;
                /*0xa8*/ System.Xml.Schema.XmlSchemaObjectTable notations;
                /*0xb0*/ System.Xml.Schema.XmlSchemaObjectTable identityConstraints;
                /*0xb8*/ System.Collections.ArrayList importedSchemas;
                /*0xc0*/ System.Collections.ArrayList importedNamespaces;
                /*0xc8*/ int schemaId;
                /*0xd0*/ System.Uri baseUri;
                /*0xd8*/ bool isChameleon;
                /*0xe0*/ System.Collections.Hashtable ids;
                /*0xe8*/ System.Xml.XmlDocument document;

                static /*0x1ce7760*/ XmlSchema();
                static /*0x1ce5d6c*/ System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler);
                /*0x1ce5b58*/ XmlSchema();
                /*0x1ce5f24*/ bool CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, string ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, bool CompileContentModel);
                /*0x1ce6118*/ void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x1ce61cc*/ System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault();
                /*0x1ce61d4*/ void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x1ce61dc*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault();
                /*0x1ce61e4*/ void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ce61ec*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault();
                /*0x1ce61f4*/ void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ce61fc*/ System.Xml.Schema.XmlSchemaForm get_ElementFormDefault();
                /*0x1ce6204*/ void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x1ce620c*/ string get_TargetNamespace();
                /*0x1ce6214*/ void set_TargetNamespace(string value);
                /*0x1ce621c*/ string get_Version();
                /*0x1ce6224*/ void set_Version(string value);
                /*0x1ce622c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Includes();
                /*0x1ce6234*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1ce623c*/ bool get_IsCompiledBySet();
                /*0x1ce6244*/ void set_IsCompiledBySet(bool value);
                /*0x1ce6250*/ bool get_IsPreprocessed();
                /*0x1ce6258*/ void set_IsPreprocessed(bool value);
                /*0x1ce6264*/ bool get_IsRedefined();
                /*0x1ce626c*/ void set_IsRedefined(bool value);
                /*0x1ce6278*/ System.Xml.Schema.XmlSchemaObjectTable get_Attributes();
                /*0x1ce62dc*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x1ce6340*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x1ce63a4*/ System.Xml.Schema.XmlSchemaObjectTable get_Elements();
                /*0x1ce6408*/ string get_Id();
                /*0x1ce6410*/ void set_Id(string value);
                /*0x1ce6418*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x1ce6420*/ System.Xml.Schema.XmlSchemaObjectTable get_Notations();
                /*0x1ce6428*/ System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints();
                /*0x1ce6430*/ System.Uri get_BaseUri();
                /*0x1ce6438*/ void set_BaseUri(System.Uri value);
                /*0x1ce6440*/ int get_SchemaId();
                /*0x1ce64bc*/ bool get_IsChameleon();
                /*0x1ce64c4*/ void set_IsChameleon(bool value);
                /*0x1ce64d0*/ System.Collections.Hashtable get_Ids();
                /*0x1ce64d8*/ System.Xml.XmlDocument get_Document();
                /*0x1ce6540*/ int get_ErrorCount();
                /*0x1ce6548*/ void set_ErrorCount(int value);
                /*0x1ce6550*/ System.Xml.Schema.XmlSchema Clone();
                /*0x1ce6678*/ System.Xml.Schema.XmlSchema DeepClone();
                /*0x1ce7478*/ string get_IdAttribute();
                /*0x1ce7480*/ void set_IdAttribute(string value);
                /*0x1ce7488*/ void SetIsCompiled(bool isCompiled);
                /*0x1ce7494*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x1ce749c*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x1ce74b4*/ System.Collections.ArrayList get_ImportedSchemas();
                /*0x1ce751c*/ System.Collections.ArrayList get_ImportedNamespaces();
                /*0x1ce7584*/ void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema);
            }

            class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x1ce7888*/ XmlSchemaAll();
                /*0x1ce77b0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1ce77b8*/ bool get_IsEmpty();
                /*0x1ce7880*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x1ce7998*/ XmlSchemaAnnotated();
                /*0x1ce7948*/ string get_Id();
                /*0x1ce7950*/ void set_Id(string value);
                /*0x1ce7958*/ System.Xml.Schema.XmlSchemaAnnotation get_Annotation();
                /*0x1ce7960*/ void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value);
                /*0x1ce7968*/ System.Xml.XmlAttribute[] get_UnhandledAttributes();
                /*0x1ce7970*/ void set_UnhandledAttributes(System.Xml.XmlAttribute[] value);
                /*0x1ce7978*/ string get_IdAttribute();
                /*0x1ce7980*/ void set_IdAttribute(string value);
                /*0x1ce7988*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x1ce7990*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x1ce79d0*/ XmlSchemaAnnotation();
                /*0x1ce79a0*/ string get_Id();
                /*0x1ce79a8*/ void set_Id(string value);
                /*0x1ce79b0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1ce79b8*/ string get_IdAttribute();
                /*0x1ce79c0*/ void set_IdAttribute(string value);
                /*0x1ce79c8*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
            }

            class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ string ns;
                /*0x80*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x88*/ System.Xml.Schema.NamespaceList namespaceList;

                /*0x1ce80d4*/ XmlSchemaAny();
                /*0x1ce7a34*/ string get_Namespace();
                /*0x1ce7a3c*/ void set_Namespace(string value);
                /*0x1ce7a44*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x1ce7a4c*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x1ce7a54*/ string get_ResolvedNamespace();
                /*0x1ce7aac*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x1ce7ac0*/ string get_NameString();
                /*0x1ce7f80*/ void BuildNamespaceList(string targetNamespace);
                /*0x1ce8004*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x1ce80a8*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string ns;
                /*0x58*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x60*/ System.Xml.Schema.NamespaceList namespaceList;

                static /*0x1ce833c*/ bool IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super);
                static /*0x1ce8364*/ System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                static /*0x1ce8420*/ System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                /*0x1ce8418*/ XmlSchemaAnyAttribute();
                /*0x1ce81b4*/ void set_Namespace(string value);
                /*0x1ce81bc*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents();
                /*0x1ce81c4*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x1ce81cc*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x1ce81d4*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x1ce81e8*/ void BuildNamespaceList(string targetNamespace);
                /*0x1ce826c*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x1ce8310*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string source;
                /*0x40*/ System.Xml.XmlNode[] markup;

                /*0x1ce84ec*/ XmlSchemaAppInfo();
                /*0x1ce84d4*/ void set_Source(string value);
                /*0x1ce84dc*/ System.Xml.XmlNode[] get_Markup();
                /*0x1ce84e4*/ void set_Markup(System.Xml.XmlNode[] value);
            }

            class XmlSchemaAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string defaultValue;
                /*0x58*/ string fixedValue;
                /*0x60*/ string name;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x6c*/ System.Xml.Schema.XmlSchemaUse use;
                /*0x70*/ System.Xml.XmlQualifiedName refName;
                /*0x78*/ System.Xml.XmlQualifiedName typeName;
                /*0x80*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x88*/ System.Xml.Schema.XmlSchemaSimpleType type;
                /*0x90*/ System.Xml.Schema.XmlSchemaSimpleType attributeType;
                /*0x98*/ System.Xml.Schema.SchemaAttDef attDef;

                /*0x1ce87e8*/ XmlSchemaAttribute();
                /*0x1ce84f4*/ string get_DefaultValue();
                /*0x1ce84fc*/ void set_DefaultValue(string value);
                /*0x1ce8504*/ string get_FixedValue();
                /*0x1ce850c*/ void set_FixedValue(string value);
                /*0x1ce8514*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1ce851c*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1ce8524*/ string get_Name();
                /*0x1ce852c*/ void set_Name(string value);
                /*0x1ce8534*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x1ce853c*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x1ce85e8*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x1ce85f0*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ce869c*/ System.Xml.Schema.XmlSchemaSimpleType get_SchemaType();
                /*0x1ce86a4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ce86ac*/ System.Xml.Schema.XmlSchemaUse get_Use();
                /*0x1ce86b4*/ void set_Use(System.Xml.Schema.XmlSchemaUse value);
                /*0x1ce86bc*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1ce86c4*/ System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType();
                /*0x1ce86cc*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x1ce86e4*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1ce86ec*/ void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ce86f4*/ System.Xml.Schema.SchemaAttDef get_AttDef();
                /*0x1ce86fc*/ void set_AttDef(System.Xml.Schema.SchemaAttDef value);
                /*0x1ce8704*/ string get_NameAttribute();
                /*0x1ce870c*/ void set_NameAttribute(string value);
                /*0x1ce8714*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroup : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName qname;
                /*0x70*/ System.Xml.Schema.XmlSchemaAttributeGroup redefined;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable attributeUses;
                /*0x80*/ System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;
                /*0x88*/ int selfReferenceCount;

                /*0x1ce8e0c*/ XmlSchemaAttributeGroup();
                /*0x1ce8874*/ string get_Name();
                /*0x1ce887c*/ void set_Name(string value);
                /*0x1ce8884*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ce888c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ce8894*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ce889c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1ce88a4*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x1ce8908*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x1ce8910*/ void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ce8918*/ System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup();
                /*0x1ce8920*/ System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined();
                /*0x1ce8928*/ void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value);
                /*0x1ce8930*/ int get_SelfReferenceCount();
                /*0x1ce8938*/ void set_SelfReferenceCount(int value);
                /*0x1ce8940*/ string get_NameAttribute();
                /*0x1ce8948*/ void set_NameAttribute(string value);
                /*0x1ce8950*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1ce8958*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ System.Xml.XmlQualifiedName refName;

                /*0x1ce8f60*/ XmlSchemaAttributeGroupRef();
                /*0x1ce8eac*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x1ce8eb4*/ void set_RefName(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x1ce8fe8*/ XmlSchemaChoice();
                /*0x1ce8fd4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1ce8fdc*/ bool get_IsEmpty();
                /*0x1ce8fe0*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable collection;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x28*/ System.Threading.ReaderWriterLock wLock;
                /*0x30*/ int timeout;
                /*0x34*/ bool isThreadSafe;
                /*0x38*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0x40*/ System.Xml.XmlResolver xmlResolver;

                /*0x1ce9048*/ XmlSchemaCollection(System.Xml.XmlNameTable nametable);
                /*0x1ce9164*/ int get_Count();
                /*0x1ce9188*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1ce9190*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x1ce9198*/ System.Xml.Schema.XmlSchema get_Item(string ns);
                /*0x1ce9248*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1ce92f0*/ System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator();
                /*0x1ce9350*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1ce95f8*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1ce9600*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1ce9604*/ int System.Collections.ICollection.get_Count();
                /*0x1ce9628*/ System.Xml.Schema.SchemaInfo GetSchemaInfo(string ns);
                /*0x1ce96d8*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x1ce9780*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile);
                /*0x1ce978c*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile, System.Xml.XmlResolver resolver);
                /*0x1ce98e8*/ void Add(string ns, System.Xml.Schema.XmlSchemaCollectionNode node);
                /*0x1ce9a24*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x1ce9a2c*/ void set_EventHandler(System.Xml.Schema.ValidationEventHandler value);
            }

            class XmlSchemaCollectionNode
            {
                /*0x10*/ string namespaceUri;
                /*0x18*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x20*/ System.Xml.Schema.XmlSchema schema;

                /*0x1ce98e0*/ XmlSchemaCollectionNode();
                /*0x1ce9c74*/ void set_NamespaceURI(string value);
                /*0x1ce9c7c*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x1ce9c84*/ void set_SchemaInfo(System.Xml.Schema.SchemaInfo value);
                /*0x1ce9c8c*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x1ce9c94*/ void set_Schema(System.Xml.Schema.XmlSchema value);
            }

            class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                /*0x1ce92a8*/ XmlSchemaCollectionEnumerator(System.Collections.Hashtable collection);
                /*0x1ce9a34*/ void System.Collections.IEnumerator.Reset();
                /*0x1ce9ae4*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x1ce954c*/ bool MoveNext();
                /*0x1ce9b90*/ object System.Collections.IEnumerator.get_Current();
                /*0x1ce9468*/ System.Xml.Schema.XmlSchema get_Current();
                /*0x1ce9b94*/ System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode();
            }

            class XmlSchemaCompilationSettings
            {
                /*0x10*/ bool enableUpaCheck;

                /*0x1ce9c9c*/ XmlSchemaCompilationSettings();
                /*0x1ce9cc8*/ bool get_EnableUpaCheck();
            }

            class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;
                /*0x58*/ bool isMixed;
                /*0x59*/ bool hasMixedAttribute;

                /*0x1ce9d04*/ XmlSchemaComplexContent();
                /*0x1ce9cd0*/ bool get_IsMixed();
                /*0x1ce9cd8*/ void set_IsMixed(bool value);
                /*0x1ce9cec*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x1ce9cf4*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
                /*0x1ce9cfc*/ bool get_HasMixedAttribute();
            }

            class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x1ce9df8*/ XmlSchemaComplexContentExtension();
                /*0x1ce9d14*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x1ce9d1c*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ce9dc8*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x1ce9dd0*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x1ce9dd8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ce9de0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ce9de8*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ce9df0*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x1ce9f84*/ XmlSchemaComplexContentRestriction();
                /*0x1ce9ea0*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x1ce9ea8*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ce9f54*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x1ce9f5c*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x1ce9f64*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ce9f6c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ce9f74*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ce9f7c*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexType : System.Xml.Schema.XmlSchemaType
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaComplexType anyTypeLax;
                static /*0x8*/ System.Xml.Schema.XmlSchemaComplexType anyTypeSkip;
                static /*0x10*/ System.Xml.Schema.XmlSchemaComplexType untypedAnyType;
                /*0x94*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x98*/ System.Xml.Schema.XmlSchemaContentModel contentModel;
                /*0xa0*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0xa8*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0xb0*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0xb8*/ System.Xml.Schema.XmlSchemaParticle contentTypeParticle;
                /*0xc0*/ System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;
                /*0xc8*/ System.Xml.Schema.XmlSchemaObjectTable localElements;
                /*0xd0*/ System.Xml.Schema.XmlSchemaObjectTable attributeUses;
                /*0xd8*/ System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;
                /*0xe0*/ byte pvFlags;

                static /*0x1cea024*/ XmlSchemaComplexType();
                static /*0x1cea220*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents);
                static /*0x1cea8cc*/ System.Xml.Schema.XmlSchemaComplexType get_AnyType();
                static /*0x1cea930*/ System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType();
                static /*0x1cea598*/ System.Xml.Schema.ContentValidator get_AnyTypeContentValidator();
                static /*0x1ce8bc8*/ System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x1ceb608*/ System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x1ceb25c*/ System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x1ceb808*/ System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element);
                static /*0x1ceafc4*/ bool HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x1ce8a60*/ bool HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x1cea51c*/ XmlSchemaComplexType();
                /*0x1cea994*/ bool get_IsAbstract();
                /*0x1cea9a0*/ void set_IsAbstract(bool value);
                /*0x1cea9bc*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x1cea9c4*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1cea9cc*/ bool get_IsMixed();
                /*0x1cea9d8*/ void set_IsMixed(bool value);
                /*0x1cea9f4*/ System.Xml.Schema.XmlSchemaContentModel get_ContentModel();
                /*0x1cea9fc*/ void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value);
                /*0x1ceaa04*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x1ceaa0c*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x1ceaa14*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ceaa7c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ceaa84*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ceaa8c*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x1ceaa94*/ System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle();
                /*0x1ceaa9c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x1ceaaa4*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x1ceab08*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x1ceab10*/ System.Xml.Schema.XmlSchemaObjectTable get_LocalElements();
                /*0x1ceab74*/ void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x1ceab7c*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ceab84*/ void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ceab8c*/ void set_HasWildCard(bool value);
                /*0x1ceaba8*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
                /*0x1ceabb0*/ bool ContainsIdAttribute(bool findAll);
                /*0x1ceafbc*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x1ce699c*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
                /*0x1ceb51c*/ void ClearCompiledState();
            }

            class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x1ce9e98*/ XmlSchemaContent();
            }

            class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x1ce9d0c*/ XmlSchemaContentModel();
                System.Xml.Schema.XmlSchemaContent get_Content();
                void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            enum XmlSchemaContentProcessing
            {
                None = 0,
                Skip = 1,
                Lax = 2,
                Strict = 3,
            }

            enum XmlSchemaContentType
            {
                TextOnly = 0,
                Empty = 1,
                ElementOnly = 2,
                Mixed = 3,
            }

            class XmlSchemaDatatype
            {
                static /*0x1cebe54*/ string ConcatenatedToString(object value);
                static /*0x1cec5ac*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x1cec610*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x1cec674*/ System.Xml.Schema.XmlSchemaDatatype FromXdrName(string name);
                static /*0x1cec6d8*/ System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                static /*0x1cec74c*/ string XdrCanonizeUri(string uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames);
                /*0x1cec918*/ XmlSchemaDatatype();
                System.Type get_ValueType();
                System.Xml.XmlTokenizedType get_TokenizedType();
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1ceb830*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x1ceb838*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1ceb840*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                bool get_HasLexicalFacets();
                bool get_HasValueFacets();
                System.Xml.Schema.XmlValueConverter get_ValueConverter();
                System.Xml.Schema.RestrictionFacets get_Restriction();
                int Compare(object value1, object value2);
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                System.Xml.Schema.FacetsChecker get_FacetsChecker();
                System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                bool IsEqual(object o1, object o2);
                bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x1ceb848*/ string get_TypeCodeString();
                /*0x1ceb984*/ string TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode);
            }

            enum XmlSchemaDerivationMethod
            {
                Empty = 0,
                Substitution = 1,
                Extension = 2,
                Restriction = 4,
                List = 8,
                Union = 16,
                All = 255,
                None = 256,
            }

            class XmlSchemaDocumentation : System.Xml.Schema.XmlSchemaObject
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaSimpleType languageType;
                /*0x38*/ string source;
                /*0x40*/ string language;
                /*0x48*/ System.Xml.XmlNode[] markup;

                static /*0x1ceca04*/ XmlSchemaDocumentation();
                /*0x1cec9fc*/ XmlSchemaDocumentation();
                /*0x1cec920*/ void set_Source(string value);
                /*0x1cec928*/ void set_Language(string value);
                /*0x1cec9f4*/ void set_Markup(System.Xml.XmlNode[] value);
            }

            class XmlSchemaElement : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x74*/ bool isAbstract;
                /*0x75*/ bool hasAbstractAttribute;
                /*0x76*/ bool isNillable;
                /*0x77*/ bool hasNillableAttribute;
                /*0x78*/ bool isLocalTypeDerivationChecked;
                /*0x7c*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x80*/ System.Xml.Schema.XmlSchemaDerivationMethod final;
                /*0x84*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x88*/ string defaultValue;
                /*0x90*/ string fixedValue;
                /*0x98*/ string name;
                /*0xa0*/ System.Xml.XmlQualifiedName refName;
                /*0xa8*/ System.Xml.XmlQualifiedName substitutionGroup;
                /*0xb0*/ System.Xml.XmlQualifiedName typeName;
                /*0xb8*/ System.Xml.Schema.XmlSchemaType type;
                /*0xc0*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0xc8*/ System.Xml.Schema.XmlSchemaType elementType;
                /*0xd0*/ System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;
                /*0xd4*/ System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;
                /*0xd8*/ System.Xml.Schema.XmlSchemaObjectCollection constraints;
                /*0xe0*/ System.Xml.Schema.SchemaElementDecl elementDecl;

                /*0x1cecee0*/ XmlSchemaElement();
                /*0x1cecae0*/ bool get_IsAbstract();
                /*0x1cecae8*/ void set_IsAbstract(bool value);
                /*0x1cecafc*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x1cecb04*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1cecb0c*/ string get_DefaultValue();
                /*0x1cecb14*/ void set_DefaultValue(string value);
                /*0x1cecb1c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x1cecb24*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1cecb2c*/ string get_FixedValue();
                /*0x1cecb34*/ void set_FixedValue(string value);
                /*0x1cecb3c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1cecb44*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1cecb4c*/ string get_Name();
                /*0x1cecb54*/ void set_Name(string value);
                /*0x1cecb5c*/ bool get_IsNillable();
                /*0x1cecb64*/ void set_IsNillable(bool value);
                /*0x1cecb78*/ bool get_HasNillableAttribute();
                /*0x1cecb80*/ bool get_HasAbstractAttribute();
                /*0x1cecb88*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x1cecb90*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x1cecc3c*/ System.Xml.XmlQualifiedName get_SubstitutionGroup();
                /*0x1cecc44*/ void set_SubstitutionGroup(System.Xml.XmlQualifiedName value);
                /*0x1ceccf0*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x1ceccf8*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x1cecda4*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x1cecdac*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x1cecdb4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Constraints();
                /*0x1cece1c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1cece24*/ System.Xml.Schema.XmlSchemaType get_ElementSchemaType();
                /*0x1cece2c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x1cece34*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x1cece3c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1cece44*/ void SetElementType(System.Xml.Schema.XmlSchemaType value);
                /*0x1cece4c*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1cece54*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1cece5c*/ bool get_HasConstraints();
                /*0x1cece84*/ bool get_IsLocalTypeDerivationChecked();
                /*0x1cece8c*/ void set_IsLocalTypeDerivationChecked(bool value);
                /*0x1cece98*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x1cecea0*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x1cecea8*/ string get_NameAttribute();
                /*0x1ceceb0*/ void set_NameAttribute(string value);
                /*0x1ceceb8*/ string get_NameString();
                /*0x1ceced8*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x1ce7054*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaException : System.SystemException
            {
                /*0x88*/ string res;
                /*0x90*/ string[] args;
                /*0x98*/ string sourceUri;
                /*0xa0*/ int lineNumber;
                /*0xa4*/ int linePosition;
                /*0xa8*/ System.Xml.Schema.XmlSchemaObject sourceSchemaObject;
                /*0xb0*/ string message;

                static /*0x1ced344*/ string CreateMessage(string res, string[] args);
                /*0x1cecfdc*/ XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1ced578*/ XmlSchemaException();
                /*0x1ced58c*/ XmlSchemaException(string message);
                /*0x1ced6d0*/ XmlSchemaException(string message, System.Exception innerException);
                /*0x1ced59c*/ XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition);
                /*0x1ced768*/ XmlSchemaException(string res, string[] args);
                /*0x1ced7cc*/ XmlSchemaException(string res, string arg);
                /*0x1ced8ac*/ XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x1ced9ac*/ XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition);
                /*0x1ceda24*/ XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x1cedaa0*/ XmlSchemaException(string res, System.Xml.Schema.XmlSchemaObject source);
                /*0x1cedb28*/ XmlSchemaException(string res, string arg, System.Xml.Schema.XmlSchemaObject source);
                /*0x1cedaac*/ XmlSchemaException(string res, string[] args, System.Xml.Schema.XmlSchemaObject source);
                /*0x1ced6dc*/ XmlSchemaException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition, System.Xml.Schema.XmlSchemaObject source);
                /*0x1ced40c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1cedbec*/ string get_GetRes();
                /*0x1cedbf4*/ string[] get_Args();
                /*0x1cedbfc*/ string get_SourceUri();
                /*0x1cedc04*/ int get_LineNumber();
                /*0x1cedc0c*/ int get_LinePosition();
                /*0x1cedc14*/ System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject();
                /*0x1cedc1c*/ void SetSource(string sourceUri, int lineNumber, int linePosition);
                /*0x1cedc28*/ void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source);
                /*0x1cedc30*/ void SetSource(System.Xml.Schema.XmlSchemaObject source);
                /*0x1cedc60*/ string get_Message();
            }

            class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string location;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.XmlSchema schema;
                /*0x50*/ string id;
                /*0x58*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x60*/ System.Xml.Schema.Compositor compositor;

                /*0x1cedce0*/ XmlSchemaExternal();
                /*0x1cedc78*/ string get_SchemaLocation();
                /*0x1cedc80*/ void set_SchemaLocation(string value);
                /*0x1cedc88*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x1cedc90*/ void set_Schema(System.Xml.Schema.XmlSchema value);
                /*0x1cedc98*/ string get_Id();
                /*0x1cedca0*/ void set_Id(string value);
                /*0x1cedca8*/ System.Uri get_BaseUri();
                /*0x1cedcb0*/ void set_BaseUri(System.Uri value);
                /*0x1cedcb8*/ string get_IdAttribute();
                /*0x1cedcc0*/ void set_IdAttribute(string value);
                /*0x1cedcc8*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x1cedcd0*/ System.Xml.Schema.Compositor get_Compositor();
                /*0x1cedcd8*/ void set_Compositor(System.Xml.Schema.Compositor value);
            }

            enum FacetType
            {
                None = 0,
                Length = 1,
                MinLength = 2,
                MaxLength = 3,
                Pattern = 4,
                Whitespace = 5,
                Enumeration = 6,
                MinExclusive = 7,
                MinInclusive = 8,
                MaxExclusive = 9,
                MaxInclusive = 10,
                TotalDigits = 11,
                FractionDigits = 12,
            }

            class XmlSchemaFacet : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string value;
                /*0x58*/ bool isFixed;
                /*0x5c*/ System.Xml.Schema.FacetType facetType;

                /*0x1cecfd4*/ XmlSchemaFacet();
                /*0x1cedce8*/ string get_Value();
                /*0x1cedcf0*/ void set_Value(string value);
                /*0x1cedcf8*/ bool get_IsFixed();
                /*0x1cedd00*/ void set_IsFixed(bool value);
                /*0x1ceddc0*/ System.Xml.Schema.FacetType get_FacetType();
                /*0x1ceddc8*/ void set_FacetType(System.Xml.Schema.FacetType value);
            }

            class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1ceddfc*/ XmlSchemaNumericFacet();
            }

            class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x1cf81d8*/ XmlSchemaLengthFacet();
            }

            class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x1cf82e0*/ XmlSchemaMinLengthFacet();
            }

            class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x1cf825c*/ XmlSchemaMaxLengthFacet();
            }

            class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1abac70*/ XmlSchemaPatternFacet();
            }

            class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1cecfa8*/ XmlSchemaEnumerationFacet();
            }

            class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1cf8288*/ XmlSchemaMinExclusiveFacet();
            }

            class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1cf82b4*/ XmlSchemaMinInclusiveFacet();
            }

            class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1cf8204*/ XmlSchemaMaxExclusiveFacet();
            }

            class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1cf8230*/ XmlSchemaMaxInclusiveFacet();
            }

            class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x1ac34dc*/ XmlSchemaTotalDigitsFacet();
            }

            class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x1ceddd0*/ XmlSchemaFractionDigitsFacet();
            }

            class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x1acf780*/ XmlSchemaWhiteSpaceFacet();
            }

            enum XmlSchemaForm
            {
                None = 0,
                Qualified = 1,
                Unqualified = 2,
            }

            class XmlSchemaGroup : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x60*/ System.Xml.Schema.XmlSchemaParticle canonicalParticle;
                /*0x68*/ System.Xml.XmlQualifiedName qname;
                /*0x70*/ System.Xml.Schema.XmlSchemaGroup redefined;
                /*0x78*/ int selfReferenceCount;

                /*0x1cede7c*/ XmlSchemaGroup();
                /*0x1cede04*/ string get_Name();
                /*0x1cede0c*/ void set_Name(string value);
                /*0x1cede14*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x1cede1c*/ void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x1cede24*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1cede2c*/ System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle();
                /*0x1cede34*/ void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x1cede3c*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x1cede44*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
                /*0x1cede4c*/ int get_SelfReferenceCount();
                /*0x1cede54*/ void set_SelfReferenceCount(int value);
                /*0x1cede5c*/ string get_NameAttribute();
                /*0x1cede64*/ void set_NameAttribute(string value);
                /*0x1cede6c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1cede74*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x1ce7208*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x1ce78e8*/ XmlSchemaGroupBase();
                System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ System.Xml.XmlQualifiedName refName;
                /*0x80*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x88*/ System.Xml.Schema.XmlSchemaGroup refined;

                /*0x1cedf18*/ XmlSchemaGroupRef();
                /*0x1cedef0*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x1ceb75c*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x1cedef8*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x1cedf00*/ void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x1cedf08*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x1cedf10*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
            }

            class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaXPath selector;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection fields;
                /*0x68*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x70*/ System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;

                /*0x1cee00c*/ XmlSchemaIdentityConstraint();
                /*0x1cedfb4*/ string get_Name();
                /*0x1cedfbc*/ void set_Name(string value);
                /*0x1cedfc4*/ System.Xml.Schema.XmlSchemaXPath get_Selector();
                /*0x1cedfcc*/ void set_Selector(System.Xml.Schema.XmlSchemaXPath value);
                /*0x1cedfd4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Fields();
                /*0x1cedfdc*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1cedfe4*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1cedfec*/ System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint();
                /*0x1cedff4*/ void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value);
                /*0x1cedffc*/ string get_NameAttribute();
                /*0x1cee004*/ void set_NameAttribute(string value);
            }

            class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string xpath;

                /*0x1acf7bc*/ XmlSchemaXPath();
                /*0x1acf7ac*/ string get_XPath();
                /*0x1acf7b4*/ void set_XPath(string value);
            }

            class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x1ac3e5c*/ XmlSchemaUnique();
            }

            class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x1cf80b0*/ XmlSchemaKey();
            }

            class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x78*/ System.Xml.XmlQualifiedName refer;

                /*0x1cf8168*/ XmlSchemaKeyref();
                /*0x1cf80b4*/ System.Xml.XmlQualifiedName get_Refer();
                /*0x1cf80bc*/ void set_Refer(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ string ns;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x1cee0ac*/ XmlSchemaImport();
                /*0x1cee0d8*/ string get_Namespace();
                /*0x1cee0e0*/ void set_Namespace(string value);
                /*0x1cee0e8*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x1cee0f0*/ XmlSchemaInclude();
                /*0x1cee11c*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInfo : System.Xml.Schema.IXmlSchemaInfo
            {
                /*0x10*/ bool isDefault;
                /*0x11*/ bool isNil;
                /*0x18*/ System.Xml.Schema.XmlSchemaElement schemaElement;
                /*0x20*/ System.Xml.Schema.XmlSchemaAttribute schemaAttribute;
                /*0x28*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x30*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
                /*0x38*/ System.Xml.Schema.XmlSchemaValidity validity;
                /*0x3c*/ System.Xml.Schema.XmlSchemaContentType contentType;

                /*0x1cf7ef8*/ XmlSchemaInfo();
                /*0x1cf7f48*/ XmlSchemaInfo(System.Xml.Schema.XmlSchemaValidity validity);
                /*0x1cf7f84*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x1cf7f8c*/ void set_Validity(System.Xml.Schema.XmlSchemaValidity value);
                /*0x1cf7f94*/ bool get_IsDefault();
                /*0x1cf7f9c*/ void set_IsDefault(bool value);
                /*0x1cf7fa8*/ bool get_IsNil();
                /*0x1cf7fb0*/ void set_IsNil(bool value);
                /*0x1cf7fbc*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x1cf7fc4*/ void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1cf7fcc*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x1cf7fd4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x1cf7ff0*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x1cf7ff8*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x1cf8008*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x1cf8010*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x1cf8020*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x1cf8028*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x1cf8040*/ bool get_HasDefaultValue();
                /*0x1cf8074*/ bool get_IsUnionType();
                /*0x1cf7f30*/ void Clear();
            }

            class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ string publicId;
                /*0x60*/ string systemId;
                /*0x68*/ System.Xml.XmlQualifiedName qname;

                /*0x1cf835c*/ XmlSchemaNotation();
                /*0x1cf830c*/ string get_Name();
                /*0x1cf8314*/ void set_Name(string value);
                /*0x1cf831c*/ string get_Public();
                /*0x1cf8324*/ void set_Public(string value);
                /*0x1cf832c*/ string get_System();
                /*0x1cf8334*/ void set_System(string value);
                /*0x1cf833c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1cf8344*/ void set_QualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1cf834c*/ string get_NameAttribute();
                /*0x1cf8354*/ void set_NameAttribute(string value);
            }

            class XmlSchemaObject
            {
                /*0x10*/ int lineNum;
                /*0x14*/ int linePos;
                /*0x18*/ string sourceUri;
                /*0x20*/ System.Xml.Serialization.XmlSerializerNamespaces namespaces;
                /*0x28*/ System.Xml.Schema.XmlSchemaObject parent;
                /*0x30*/ bool isProcessing;

                /*0x1ce5d64*/ XmlSchemaObject();
                /*0x1cf83d0*/ int get_LineNumber();
                /*0x1cf83d8*/ void set_LineNumber(int value);
                /*0x1cf83e0*/ int get_LinePosition();
                /*0x1cf83e8*/ void set_LinePosition(int value);
                /*0x1cf83f0*/ string get_SourceUri();
                /*0x1cf83f8*/ void set_SourceUri(string value);
                /*0x1cf8400*/ System.Xml.Schema.XmlSchemaObject get_Parent();
                /*0x1cf8408*/ void set_Parent(System.Xml.Schema.XmlSchemaObject value);
                /*0x1ce6610*/ System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces();
                /*0x1cf8410*/ void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value);
                /*0x1cf8418*/ void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x1cf841c*/ void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x1cf8420*/ void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container);
                /*0x1cf8424*/ string get_IdAttribute();
                /*0x1cf842c*/ void set_IdAttribute(string value);
                /*0x1cf8430*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x1cf8434*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x1cf8438*/ string get_NameAttribute();
                /*0x1cf8440*/ void set_NameAttribute(string value);
                /*0x1cf8444*/ bool get_IsProcessing();
                /*0x1cf844c*/ void set_IsProcessing(bool value);
                /*0x1cf8458*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaObjectCollection : System.Collections.CollectionBase
            {
                /*0x18*/ System.Xml.Schema.XmlSchemaObject parent;

                /*0x1ce5ca4*/ XmlSchemaObjectCollection();
                /*0x1cf84dc*/ System.Xml.Schema.XmlSchemaObject get_Item(int index);
                /*0x1cf85f0*/ void set_Item(int index, System.Xml.Schema.XmlSchemaObject value);
                /*0x1cf86c4*/ System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator();
                /*0x1ce73ac*/ int Add(System.Xml.Schema.XmlSchemaObject item);
                /*0x1cf3780*/ void Insert(int index, System.Xml.Schema.XmlSchemaObject item);
                /*0x1cf877c*/ void Remove(System.Xml.Schema.XmlSchemaObject item);
                /*0x1cf8848*/ void OnInsert(int index, object item);
                /*0x1cf8864*/ void OnSet(int index, object oldValue, object newValue);
                /*0x1cf88c4*/ void OnClear();
                /*0x1cf88e0*/ void OnRemove(int index, object item);
                /*0x1ceb598*/ System.Xml.Schema.XmlSchemaObjectCollection Clone();
                /*0x1cf88fc*/ void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd);
            }

            class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IEnumerator enumerator;

                /*0x1cf8750*/ XmlSchemaObjectEnumerator(System.Collections.IEnumerator enumerator);
                /*0x1cf893c*/ bool MoveNext();
                /*0x1cf89e8*/ System.Xml.Schema.XmlSchemaObject get_Current();
                /*0x1cf8ae4*/ void System.Collections.IEnumerator.Reset();
                /*0x1cf8b94*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x1cf8c40*/ object System.Collections.IEnumerator.get_Current();
            }

            class XmlSchemaObjectTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject> table;
                /*0x18*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

                /*0x1ce5cac*/ XmlSchemaObjectTable();
                /*0x1cf8cf0*/ void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x1cf8dac*/ void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x1cf8f78*/ void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x1cf907c*/ void Clear();
                /*0x1cf90f4*/ void Remove(System.Xml.XmlQualifiedName name);
                /*0x1cf8ec4*/ int FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso);
                /*0x1cf0f04*/ int get_Count();
                /*0x1cf91c8*/ bool Contains(System.Xml.XmlQualifiedName name);
                /*0x1cf5610*/ System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name);
                /*0x1ceaf1c*/ System.Collections.ICollection get_Values();
                /*0x1cf922c*/ System.Collections.IDictionaryEnumerator GetEnumerator();

                enum EnumeratorType
                {
                    Keys = 0,
                    Values = 1,
                    DictionaryEntry = 2,
                }

                struct XmlSchemaObjectEntry
                {
                    /*0x10*/ System.Xml.XmlQualifiedName qname;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObject xso;

                    /*0xac1320*/ XmlSchemaObjectEntry(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                }

                class ValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ int size;

                    /*0x16c7518*/ ValuesCollection(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size);
                    /*0x16c7554*/ int get_Count();
                    /*0x16c755c*/ object get_SyncRoot();
                    /*0x16c760c*/ bool get_IsSynchronized();
                    /*0x16c76bc*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x16c7804*/ System.Collections.IEnumerator GetEnumerator();
                }

                class XSOEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;
                    /*0x1c*/ int currentIndex;
                    /*0x20*/ int size;
                    /*0x28*/ System.Xml.XmlQualifiedName currentKey;
                    /*0x30*/ System.Xml.Schema.XmlSchemaObject currentValue;

                    /*0x16c7884*/ XSOEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x16c7ccc*/ object get_Current();
                    /*0x16c7e88*/ bool MoveNext();
                    /*0x16c7f64*/ void Reset();
                }

                class XSODictionaryEnumerator : System.Xml.Schema.XmlSchemaObjectTable.XSOEnumerator, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x16c78cc*/ XSODictionaryEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x16c7914*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x16c7a64*/ object get_Key();
                    /*0x16c7b98*/ object get_Value();
                }
            }

            class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaParticle Empty;
                /*0x50*/ decimal minOccurs;
                /*0x60*/ decimal maxOccurs;
                /*0x70*/ System.Xml.Schema.XmlSchemaParticle.Occurs flags;

                static /*0x1cf99fc*/ XmlSchemaParticle();
                /*0x1ce8134*/ XmlSchemaParticle();
                /*0x1cf92d0*/ string get_MinOccursString();
                /*0x1cf9354*/ void set_MinOccursString(string value);
                /*0x1cf94c8*/ string get_MaxOccursString();
                /*0x1cf95e0*/ void set_MaxOccursString(string value);
                /*0x1cf97fc*/ decimal get_MinOccurs();
                /*0x1cea614*/ void set_MinOccurs(decimal value);
                /*0x1cf9808*/ decimal get_MaxOccurs();
                /*0x1cea750*/ void set_MaxOccurs(decimal value);
                /*0x1ce7800*/ bool get_IsEmpty();
                /*0x1cf9814*/ string get_NameString();
                /*0x1cf9860*/ System.Xml.XmlQualifiedName GetQualifiedName();

                enum Occurs
                {
                    None = 0,
                    Min = 1,
                    Max = 2,
                }

                class EmptyParticle : System.Xml.Schema.XmlSchemaParticle
                {
                    /*0x16c7f84*/ EmptyParticle();
                    /*0x16c7f7c*/ bool get_IsEmpty();
                }
            }

            class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable groups;

                /*0x1abace4*/ XmlSchemaRedefine();
                /*0x1abadb8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1abadc0*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x1abadc8*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x1abadd0*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x1abadd8*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x1abae50*/ XmlSchemaSequence();
                /*0x1abadf4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1abadfc*/ bool get_IsEmpty();
                /*0x1abae48*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaSet
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Collections.SortedList schemas;
                /*0x28*/ System.Xml.Schema.ValidationEventHandler internalEventHandler;
                /*0x30*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x38*/ bool isCompiled;
                /*0x40*/ System.Collections.Hashtable schemaLocations;
                /*0x48*/ System.Collections.Hashtable chameleonSchemas;
                /*0x50*/ System.Collections.Hashtable targetNamespaces;
                /*0x58*/ bool compileAll;
                /*0x60*/ System.Xml.Schema.SchemaInfo cachedCompiledInfo;
                /*0x68*/ System.Xml.XmlReaderSettings readerSettings;
                /*0x70*/ System.Xml.Schema.XmlSchema schemaForSchema;
                /*0x78*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x88*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x90*/ System.Xml.Schema.XmlSchemaObjectTable schemaTypes;
                /*0x98*/ System.Xml.Schema.XmlSchemaObjectTable substitutionGroups;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObjectTable typeExtensions;
                /*0xa8*/ object internalSyncObject;

                /*0x1abaf28*/ XmlSchemaSet();
                /*0x1abaf88*/ XmlSchemaSet(System.Xml.XmlNameTable nameTable);
                /*0x1abaeb4*/ object get_InternalSyncObject();
                /*0x1abb1fc*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x1abb2a4*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x1abb32c*/ bool get_IsCompiled();
                /*0x1abb334*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x1abb350*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x1abb358*/ void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value);
                /*0x1abb360*/ int get_Count();
                /*0x1abb384*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements();
                /*0x1abb3ec*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes();
                /*0x1abb454*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes();
                /*0x1abb4bc*/ System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups();
                /*0x1abb524*/ System.Collections.Hashtable get_SchemaLocations();
                /*0x1abb52c*/ System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions();
                /*0x1abb594*/ void Add(System.Xml.Schema.XmlSchemaSet schemas);
                /*0x1abdb18*/ System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema);
                /*0x1abdcc8*/ bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove);
                /*0x1abebdc*/ bool Contains(string targetNamespace);
                /*0x1abec64*/ void Compile();
                /*0x1abf2d4*/ System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema);
                /*0x1ac0ce0*/ void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index);
                /*0x1ac0e50*/ System.Collections.ICollection Schemas();
                /*0x1ac0a78*/ System.Collections.ICollection Schemas(string targetNamespace);
                /*0x1abdab0*/ System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x1ac121c*/ void Add(string targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces);
                /*0x1abd81c*/ System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, string ns, System.Collections.DictionaryEntry[] locationsTable);
                /*0x1ac0e74*/ void AddSchemaToSet(System.Xml.Schema.XmlSchema schema);
                /*0x1ac1a04*/ void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, bool resolve);
                /*0x1ac1eb4*/ void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable);
                /*0x1abe854*/ System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, bool forceCompile);
                /*0x1abf258*/ void ClearTables();
                /*0x1ac0be0*/ bool PreprocessSchema(ref System.Xml.Schema.XmlSchema schema, string targetNamespace);
                /*0x1ac188c*/ System.Xml.Schema.XmlSchema ParseSchema(string targetNamespace, System.Xml.XmlReader reader);
                /*0x1abbed8*/ void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet);
                /*0x1ac26f8*/ System.Xml.Schema.SchemaInfo get_CompiledInfo();
                /*0x1ac2700*/ System.Xml.XmlReaderSettings get_ReaderSettings();
                /*0x1ac2708*/ System.Xml.XmlResolver GetResolver();
                /*0x1ac2724*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
                /*0x1ac2550*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x1ac15c0*/ bool IsSchemaLoaded(System.Uri schemaUri, string targetNamespace, ref System.Xml.Schema.XmlSchema schema);
                /*0x1ac272c*/ bool GetSchemaByUri(System.Uri schemaUri, ref System.Xml.Schema.XmlSchema schema);
                /*0x1abe74c*/ string GetTargetNamespace(System.Xml.Schema.XmlSchema schema);
                /*0x1ac2878*/ System.Collections.SortedList get_SortedSchemas();
                /*0x1ac0430*/ void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema);
                /*0x1abfa10*/ void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema);
                /*0x1ac225c*/ bool AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x1ac25f8*/ void VerifyTables();
                /*0x1ac2880*/ void InternalValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0x1abe7ac*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;

                /*0x1ac28e0*/ XmlSchemaSimpleContent();
                /*0x1ac28d0*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x1ac28d8*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x58*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x60*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x1ac29bc*/ XmlSchemaSimpleContentExtension();
                /*0x1ac28e8*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x1ac28f0*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ac299c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ac29a4*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ac29ac*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ac29b4*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;

                /*0x1ac2b48*/ XmlSchemaSimpleContentRestriction();
                /*0x1ac2a5c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x1ac2a64*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ac2b10*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x1ac2b18*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ac2b20*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x1ac2b28*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x1ac2b30*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1ac2b38*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1ac2b40*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
            {
                /*0x98*/ System.Xml.Schema.XmlSchemaSimpleTypeContent content;

                /*0x1ac2c08*/ XmlSchemaSimpleType();
                /*0x1ac2c8c*/ System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content();
                /*0x1ac2c94*/ void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value);
                /*0x1ac2c9c*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x1ac2d98*/ XmlSchemaSimpleTypeContent();
            }

            class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName itemTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType itemType;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType baseItemType;

                /*0x1ac2f28*/ XmlSchemaSimpleTypeList();
                /*0x1ac2da0*/ System.Xml.XmlQualifiedName get_ItemTypeName();
                /*0x1ac2da8*/ void set_ItemTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ac2e54*/ System.Xml.Schema.XmlSchemaSimpleType get_ItemType();
                /*0x1ac2e5c*/ void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ac2e64*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType();
                /*0x1ac2e6c*/ void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ac2e74*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;

                /*0x1ac311c*/ XmlSchemaSimpleTypeRestriction();
                /*0x1ac2f9c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x1ac2fa4*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x1ac3050*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x1ac3058*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x1ac3060*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x1ac3068*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection baseTypes;
                /*0x58*/ System.Xml.XmlQualifiedName[] memberTypes;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;

                /*0x1ac3358*/ XmlSchemaSimpleTypeUnion();
                /*0x1ac31bc*/ System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes();
                /*0x1ac31c4*/ System.Xml.XmlQualifiedName[] get_MemberTypes();
                /*0x1ac31cc*/ void set_MemberTypes(System.Xml.XmlQualifiedName[] value);
                /*0x1ac31d4*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x1ac31dc*/ void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes);
                /*0x1ac31e4*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSubstitutionGroup : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ System.Collections.ArrayList membersList;
                /*0x40*/ System.Xml.XmlQualifiedName examplar;

                /*0x1ac33d4*/ XmlSchemaSubstitutionGroup();
                /*0x1ac33bc*/ System.Collections.ArrayList get_Members();
                /*0x1ac33c4*/ System.Xml.XmlQualifiedName get_Examplar();
                /*0x1ac33cc*/ void set_Examplar(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaSubstitutionGroupV1Compat : System.Xml.Schema.XmlSchemaSubstitutionGroup
            {
                /*0x48*/ System.Xml.Schema.XmlSchemaChoice choice;

                /*0x1ac347c*/ XmlSchemaSubstitutionGroupV1Compat();
                /*0x1ac3474*/ System.Xml.Schema.XmlSchemaChoice get_Choice();
            }

            class XmlSchemaType : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaDerivationMethod final;
                /*0x5c*/ System.Xml.Schema.XmlSchemaDerivationMethod derivedBy;
                /*0x60*/ System.Xml.Schema.XmlSchemaType baseSchemaType;
                /*0x68*/ System.Xml.Schema.XmlSchemaDatatype datatype;
                /*0x70*/ System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;
                /*0x78*/ System.Xml.Schema.SchemaElementDecl elementDecl;
                /*0x80*/ System.Xml.XmlQualifiedName qname;
                /*0x88*/ System.Xml.Schema.XmlSchemaType redefined;
                /*0x90*/ System.Xml.Schema.XmlSchemaContentType contentType;

                static /*0x1ac3508*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x1ac35f4*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x1ac3658*/ System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x1ac3b48*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                static /*0x1ac3d64*/ bool IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                /*0x1ac2c0c*/ XmlSchemaType();
                /*0x1ac38f0*/ string get_Name();
                /*0x1ac38f8*/ void set_Name(string value);
                /*0x1ac3900*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x1ac3908*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ac26d4*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x1ac3910*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x1ac3918*/ System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType();
                /*0x1ac3920*/ System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy();
                /*0x1ac3928*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x1ac3930*/ bool get_IsMixed();
                /*0x1ac3938*/ void set_IsMixed(bool value);
                /*0x1ac393c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1ac3a10*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x1ac3a94*/ System.Xml.Schema.XmlSchemaContentType get_SchemaContentType();
                /*0x1ac3a9c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x1ac3ac4*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ac3acc*/ void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x1ac3ad4*/ void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1ac3adc*/ void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x1ac3ae4*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x1ac3b08*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x1ac3b30*/ System.Xml.Schema.XmlSchemaType get_Redefined();
                /*0x1ac3b38*/ void set_Redefined(System.Xml.Schema.XmlSchemaType value);
                /*0x1ac3b40*/ void SetContentType(System.Xml.Schema.XmlSchemaContentType value);
                /*0x1ac3e4c*/ string get_NameAttribute();
                /*0x1ac3e54*/ void set_NameAttribute(string value);
            }

            enum XmlSchemaUse
            {
                None = 0,
                Optional = 1,
                Prohibited = 2,
                Required = 3,
            }

            class XmlSchemaValidationException : System.Xml.Schema.XmlSchemaException
            {
                /*0x1ac3e64*/ XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1ac3e74*/ XmlSchemaValidationException();
                /*0x1ac3e80*/ XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x1ac3f74*/ XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x1ac3fa8*/ XmlSchemaValidationException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition);
                /*0x1ac3e6c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XmlValueGetter : System.MulticastDelegate
            {
                /*0x1bd9c84*/ XmlValueGetter(object object, nint method);
                /*0x1bd9ce4*/ object Invoke();
                /*0x1bd9ef8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1bd9f24*/ object EndInvoke(System.IAsyncResult result);
            }

            enum XmlSchemaValidationFlags
            {
                None = 0,
                ProcessInlineSchema = 1,
                ProcessSchemaLocation = 2,
                ReportValidationWarnings = 4,
                ProcessIdentityConstraints = 8,
                AllowXmlAttributes = 16,
            }

            enum ValidatorState
            {
                None = 0,
                Start = 1,
                TopLevelAttribute = 2,
                TopLevelTextOrWS = 3,
                Element = 4,
                Attribute = 5,
                EndOfAttributes = 6,
                Text = 7,
                Whitespace = 8,
                EndElement = 9,
                SkipToEndElement = 10,
                Finish = 11,
            }

            class IdRefNode
            {
                /*0x10*/ string Id;
                /*0x18*/ int LineNo;
                /*0x1c*/ int LinePos;
                /*0x20*/ System.Xml.Schema.IdRefNode Next;

                /*0x14c7e58*/ IdRefNode(System.Xml.Schema.IdRefNode next, string id, int lineNo, int linePos);
            }

            class XmlSchemaValidator
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaDatatype dtQName;
                static /*0x8*/ System.Xml.Schema.XmlSchemaDatatype dtCDATA;
                static /*0x10*/ System.Xml.Schema.XmlSchemaDatatype dtStringArray;
                static /*0x18*/ System.Xml.Schema.XmlSchemaParticle[] EmptyParticleArray;
                static /*0x20*/ System.Xml.Schema.XmlSchemaAttribute[] EmptyAttributeArray;
                static /*0x28*/ bool[,] ValidStates;
                static /*0x30*/ string[] MethodNames;
                /*0x10*/ System.Xml.Schema.XmlSchemaSet schemaSet;
                /*0x18*/ System.Xml.Schema.XmlSchemaValidationFlags validationFlags;
                /*0x1c*/ int startIDConstraint;
                /*0x20*/ bool isRoot;
                /*0x21*/ bool rootHasSchema;
                /*0x22*/ bool attrValid;
                /*0x23*/ bool checkEntity;
                /*0x28*/ System.Xml.Schema.SchemaInfo compiledSchemaInfo;
                /*0x30*/ System.Xml.IDtdInfo dtdSchemaInfo;
                /*0x38*/ System.Collections.Hashtable validatedNamespaces;
                /*0x40*/ System.Xml.HWStack validationStack;
                /*0x48*/ System.Xml.Schema.ValidationState context;
                /*0x50*/ System.Xml.Schema.ValidatorState currentState;
                /*0x58*/ System.Collections.Hashtable attPresence;
                /*0x60*/ System.Xml.Schema.SchemaAttDef wildID;
                /*0x68*/ System.Collections.Hashtable IDs;
                /*0x70*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0x78*/ System.Xml.XmlQualifiedName contextQName;
                /*0x80*/ string NsXs;
                /*0x88*/ string NsXsi;
                /*0x90*/ string NsXmlNs;
                /*0x98*/ string NsXml;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObject partialValidationType;
                /*0xa8*/ System.Text.StringBuilder textValue;
                /*0xb0*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0xb8*/ object validationEventSender;
                /*0xc0*/ System.Xml.XmlNameTable nameTable;
                /*0xc8*/ System.Xml.IXmlLineInfo positionInfo;
                /*0xd0*/ System.Xml.IXmlLineInfo dummyPositionInfo;
                /*0xd8*/ System.Xml.XmlResolver xmlResolver;
                /*0xe0*/ System.Uri sourceUri;
                /*0xe8*/ string sourceUriString;
                /*0xf0*/ System.Xml.IXmlNamespaceResolver nsResolver;
                /*0xf8*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x100*/ string xsiTypeString;
                /*0x108*/ string xsiNilString;
                /*0x110*/ string xsiSchemaLocationString;
                /*0x118*/ string xsiNoNamespaceSchemaLocationString;
                /*0x120*/ System.Xml.XmlCharType xmlCharType;

                static /*0x1acf2d0*/ XmlSchemaValidator();
                static /*0x1acce1c*/ void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x1acb1ec*/ void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x1ac8e98*/ string PrintExpectedElements(System.Collections.ArrayList expected, bool getParticles);
                static /*0x1acef00*/ string PrintNames(System.Collections.ArrayList expected);
                static /*0x1acea64*/ void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder);
                static /*0x1acf088*/ void EnumerateAny(System.Text.StringBuilder builder, string namespaces);
                static /*0x1ac8c88*/ string QNameString(string localName, string ns);
                static /*0x1accb74*/ string BuildElementName(System.Xml.XmlQualifiedName qname);
                static /*0x1ac8d58*/ string BuildElementName(string localName, string ns);
                static /*0x1ace9a4*/ void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x1ac3fcc*/ XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags);
                /*0x1ac41b0*/ void Init();
                /*0x1ac461c*/ void Reset();
                /*0x1ac478c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x1ac4794*/ void set_LineInfoProvider(System.Xml.IXmlLineInfo value);
                /*0x1ac47ac*/ void set_SourceUri(System.Uri value);
                /*0x1ac47ec*/ void set_ValidationEventSender(object value);
                /*0x1ac47f4*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x1ac4870*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x1ac48ec*/ void AddSchema(System.Xml.Schema.XmlSchema schema);
                /*0x1ac50ac*/ void Initialize();
                /*0x1ac5224*/ void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType);
                /*0x1ac5504*/ void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x1ac7010*/ object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x1ac7074*/ object ValidateAttribute(string lName, string ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, string attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x1ac85c8*/ void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x1ac8874*/ void ValidateText(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x1ac88d8*/ void ValidateText(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x1ac92e4*/ void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x1ac9348*/ void ValidateWhitespace(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x1ac953c*/ object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x1ac9a9c*/ void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x1ac9e10*/ void EndValidation();
                /*0x1aca004*/ void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, bool createNodeData);
                /*0x1aca9e4*/ System.Xml.Schema.XmlSchemaSet get_SchemaSet();
                /*0x1aca9ec*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
                /*0x1aca9f4*/ System.Xml.Schema.XmlSchemaContentType get_CurrentContentType();
                /*0x1acaa2c*/ void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo);
                /*0x1acaa3c*/ bool get_StrictlyAssessed();
                /*0x1acaa80*/ bool get_HasSchema();
                /*0x1acaad4*/ string GetConcatenatedValue();
                /*0x1ac9544*/ object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue);
                /*0x1ac6250*/ void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x1ac5b90*/ object ValidateElementContext(System.Xml.XmlQualifiedName elementName, ref bool invalidElementInContext);
                /*0x1acc930*/ System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member);
                /*0x1acaaf4*/ object ValidateAtomicValue(string stringValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x1acadac*/ object ValidateAtomicValue(object parsedValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x1acd8c8*/ string GetTypeName(System.Xml.Schema.SchemaDeclBase decl);
                /*0x1ac8d0c*/ void SaveTextValue(object value);
                /*0x1ac44bc*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x1ac9cf0*/ void Pop();
                /*0x1ac5ff4*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, object particle);
                /*0x1ac65f4*/ System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound);
                /*0x1ac6c48*/ void ThrowDeclNotFoundWarningOrError(bool declFound);
                /*0x1ac6dc4*/ void CheckElementProperties();
                /*0x1ac6e84*/ void ValidateStartElementIdentityConstraints();
                /*0x1ac7c40*/ System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName);
                /*0x1ace198*/ void AddXmlNamespaceSchema();
                /*0x1acb104*/ object CheckMixedValueConstraint(string elementValue);
                /*0x1acc34c*/ void LoadSchema(string uri, string url);
                /*0x1ac46b8*/ void RecompileSchemaSet();
                /*0x1ace40c*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name, bool attrValue);
                /*0x1ac7eb4*/ object CheckAttributeValue(object value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x1acd64c*/ object CheckElementValue(string stringValue);
                /*0x1ac814c*/ void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, object typedValue, bool attrValue);
                /*0x1ace6c0*/ object FindId(string name);
                /*0x1ac9f10*/ void CheckForwardRefs();
                /*0x1ac82e4*/ bool get_HasIdentityConstraints();
                /*0x1acd998*/ bool get_ProcessIdentityConstraints();
                /*0x1ace990*/ bool get_ReportValidationWarnings();
                /*0x1ac477c*/ bool get_ProcessSchemaHints();
                /*0x1ac5878*/ void CheckStateTransition(System.Xml.Schema.ValidatorState toState, string methodName);
                /*0x1ac5b40*/ void ClearPSVI();
                /*0x1ac86a4*/ void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl);
                /*0x1ac6ef0*/ System.Xml.Schema.XmlSchemaElement GetSchemaElement();
                /*0x1aca600*/ string GetDefaultAttributePrefix(string attributeNS);
                /*0x1acd9a4*/ void AddIdentityConstraints();
                /*0x1acddc4*/ void ElementIdentityConstraints();
                /*0x1ac8304*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1acb6e8*/ void EndElementIdentityConstraints(object typedValue, string stringValue, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1ace6dc*/ void ProcessEntity(string name);
                /*0x1acd934*/ void SendValidationEvent(string code);
                /*0x1ac7d0c*/ void SendValidationEvent(string code, string[] args);
                /*0x1ac7aac*/ void SendValidationEvent(string code, string arg);
                /*0x1accbe4*/ void SendValidationEvent(string code, string arg1, string arg2);
                /*0x1ace224*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity);
                /*0x1ac4f00*/ void SendValidationEvent(string code, string[] args, System.Exception innerException);
                /*0x1ace99c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e);
                /*0x1acc878*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x1ac4d40*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x1ace870*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
            }

            enum XmlSchemaValidity
            {
                NotKnown = 0,
                Valid = 1,
                Invalid = 2,
            }

            enum XmlSeverityType
            {
                Error = 0,
                Warning = 1,
            }

            enum XmlTypeCode
            {
                None = 0,
                Item = 1,
                Node = 2,
                Document = 3,
                Element = 4,
                Attribute = 5,
                Namespace = 6,
                ProcessingInstruction = 7,
                Comment = 8,
                Text = 9,
                AnyAtomicType = 10,
                UntypedAtomic = 11,
                String = 12,
                Boolean = 13,
                Decimal = 14,
                Float = 15,
                Double = 16,
                Duration = 17,
                DateTime = 18,
                Time = 19,
                Date = 20,
                GYearMonth = 21,
                GYear = 22,
                GMonthDay = 23,
                GDay = 24,
                GMonth = 25,
                HexBinary = 26,
                Base64Binary = 27,
                AnyUri = 28,
                QName = 29,
                Notation = 30,
                NormalizedString = 31,
                Token = 32,
                Language = 33,
                NmToken = 34,
                Name = 35,
                NCName = 36,
                Id = 37,
                Idref = 38,
                Entity = 39,
                Integer = 40,
                NonPositiveInteger = 41,
                NegativeInteger = 42,
                Long = 43,
                Int = 44,
                Short = 45,
                Byte = 46,
                NonNegativeInteger = 47,
                UnsignedLong = 48,
                UnsignedInt = 49,
                UnsignedShort = 50,
                UnsignedByte = 51,
                PositiveInteger = 52,
                YearMonthDuration = 53,
                DayTimeDuration = 54,
            }

            class XmlValueConverter
            {
                /*0x1bd9c7c*/ XmlValueConverter();
                bool ToBoolean(long value);
                bool ToBoolean(int value);
                bool ToBoolean(double value);
                bool ToBoolean(System.DateTime value);
                bool ToBoolean(string value);
                bool ToBoolean(object value);
                int ToInt32(bool value);
                int ToInt32(long value);
                int ToInt32(double value);
                int ToInt32(System.DateTime value);
                int ToInt32(string value);
                int ToInt32(object value);
                long ToInt64(bool value);
                long ToInt64(int value);
                long ToInt64(double value);
                long ToInt64(System.DateTime value);
                long ToInt64(string value);
                long ToInt64(object value);
                decimal ToDecimal(string value);
                decimal ToDecimal(object value);
                double ToDouble(bool value);
                double ToDouble(int value);
                double ToDouble(long value);
                double ToDouble(System.DateTime value);
                double ToDouble(string value);
                double ToDouble(object value);
                float ToSingle(double value);
                float ToSingle(string value);
                float ToSingle(object value);
                System.DateTime ToDateTime(bool value);
                System.DateTime ToDateTime(int value);
                System.DateTime ToDateTime(long value);
                System.DateTime ToDateTime(double value);
                System.DateTime ToDateTime(System.DateTimeOffset value);
                System.DateTime ToDateTime(string value);
                System.DateTime ToDateTime(object value);
                System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                System.DateTimeOffset ToDateTimeOffset(string value);
                System.DateTimeOffset ToDateTimeOffset(object value);
                string ToString(bool value);
                string ToString(int value);
                string ToString(long value);
                string ToString(decimal value);
                string ToString(float value);
                string ToString(double value);
                string ToString(System.DateTime value);
                string ToString(System.DateTimeOffset value);
                string ToString(object value);
                string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(bool value, System.Type destinationType);
                object ChangeType(int value, System.Type destinationType);
                object ChangeType(long value, System.Type destinationType);
                object ChangeType(decimal value, System.Type destinationType);
                object ChangeType(double value, System.Type destinationType);
                object ChangeType(System.DateTime value, System.Type destinationType);
                object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(object value, System.Type destinationType);
                object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBaseConverter : System.Xml.Schema.XmlValueConverter
            {
                static /*0x0*/ System.Type ICollectionType;
                static /*0x8*/ System.Type IEnumerableType;
                static /*0x10*/ System.Type IListType;
                static /*0x18*/ System.Type ObjectArrayType;
                static /*0x20*/ System.Type StringArrayType;
                static /*0x28*/ System.Type XmlAtomicValueArrayType;
                static /*0x30*/ System.Type DecimalType;
                static /*0x38*/ System.Type Int32Type;
                static /*0x40*/ System.Type Int64Type;
                static /*0x48*/ System.Type StringType;
                static /*0x50*/ System.Type XmlAtomicValueType;
                static /*0x58*/ System.Type ObjectType;
                static /*0x60*/ System.Type ByteType;
                static /*0x68*/ System.Type Int16Type;
                static /*0x70*/ System.Type SByteType;
                static /*0x78*/ System.Type UInt16Type;
                static /*0x80*/ System.Type UInt32Type;
                static /*0x88*/ System.Type UInt64Type;
                static /*0x90*/ System.Type XPathItemType;
                static /*0x98*/ System.Type DoubleType;
                static /*0xa0*/ System.Type SingleType;
                static /*0xa8*/ System.Type DateTimeType;
                static /*0xb0*/ System.Type DateTimeOffsetType;
                static /*0xb8*/ System.Type BooleanType;
                static /*0xc0*/ System.Type ByteArrayType;
                static /*0xc8*/ System.Type XmlQualifiedNameType;
                static /*0xd0*/ System.Type UriType;
                static /*0xd8*/ System.Type TimeSpanType;
                static /*0xe0*/ System.Type XPathNavigatorType;
                /*0x10*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x18*/ System.Xml.Schema.XmlTypeCode typeCode;
                /*0x20*/ System.Type clrTypeDefault;

                static /*0x1d5dae0*/ XmlBaseConverter();
                static /*0x1d5b028*/ bool IsDerivedFrom(System.Type derivedType, System.Type baseType);
                static /*0x1d5aefc*/ string QNameToString(System.Xml.XmlQualifiedName name);
                static /*0x1d5b3d0*/ byte[] StringToBase64Binary(string value);
                static /*0x1d5b4e8*/ System.DateTime StringToDate(string value);
                static /*0x1d5b570*/ System.DateTime StringToDateTime(string value);
                static /*0x1d5b5f8*/ System.TimeSpan StringToDayTimeDuration(string value);
                static /*0x1d5b65c*/ System.TimeSpan StringToDuration(string value);
                static /*0x1d5b6c0*/ System.DateTime StringToGDay(string value);
                static /*0x1d5b748*/ System.DateTime StringToGMonth(string value);
                static /*0x1d5b7d0*/ System.DateTime StringToGMonthDay(string value);
                static /*0x1d5b858*/ System.DateTime StringToGYear(string value);
                static /*0x1d5b8e0*/ System.DateTime StringToGYearMonth(string value);
                static /*0x1d5b968*/ System.DateTimeOffset StringToDateOffset(string value);
                static /*0x1d5b9f0*/ System.DateTimeOffset StringToDateTimeOffset(string value);
                static /*0x1d5ba78*/ System.DateTimeOffset StringToGDayOffset(string value);
                static /*0x1d5bb00*/ System.DateTimeOffset StringToGMonthOffset(string value);
                static /*0x1d5bb88*/ System.DateTimeOffset StringToGMonthDayOffset(string value);
                static /*0x1d5bc10*/ System.DateTimeOffset StringToGYearOffset(string value);
                static /*0x1d5bc98*/ System.DateTimeOffset StringToGYearMonthOffset(string value);
                static /*0x1d5bd20*/ byte[] StringToHexBinary(string value);
                static /*0x1d5bed0*/ System.Xml.XmlQualifiedName StringToQName(string value, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x1d5c1a0*/ System.DateTime StringToTime(string value);
                static /*0x1d5c228*/ System.DateTimeOffset StringToTimeOffset(string value);
                static /*0x1d5c2b0*/ System.TimeSpan StringToYearMonthDuration(string value);
                static /*0x1d5c314*/ string AnyUriToString(System.Uri value);
                static /*0x1d5c32c*/ string Base64BinaryToString(byte[] value);
                static /*0x1d5c390*/ string DateToString(System.DateTime value);
                static /*0x1d5c3d8*/ string DateTimeToString(System.DateTime value);
                static /*0x1d5c420*/ string DayTimeDurationToString(System.TimeSpan value);
                static /*0x1d5c484*/ string DurationToString(System.TimeSpan value);
                static /*0x1d5c4e8*/ string GDayToString(System.DateTime value);
                static /*0x1d5c530*/ string GMonthToString(System.DateTime value);
                static /*0x1d5c578*/ string GMonthDayToString(System.DateTime value);
                static /*0x1d5c5c0*/ string GYearToString(System.DateTime value);
                static /*0x1d5c608*/ string GYearMonthToString(System.DateTime value);
                static /*0x1d5c650*/ string DateOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c69c*/ string DateTimeOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c6e8*/ string GDayOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c734*/ string GMonthOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c780*/ string GMonthDayOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c7cc*/ string GYearOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c818*/ string GYearMonthOffsetToString(System.DateTimeOffset value);
                static /*0x1d5c864*/ string QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x1d5ca94*/ string TimeToString(System.DateTime value);
                static /*0x1d5cadc*/ string TimeOffsetToString(System.DateTimeOffset value);
                static /*0x1d5cb28*/ string YearMonthDurationToString(System.TimeSpan value);
                static /*0x1d5cb8c*/ System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value);
                static /*0x1d5cbb4*/ int DecimalToInt32(decimal value);
                static /*0x1d5ce08*/ long DecimalToInt64(decimal value);
                static /*0x1d5d024*/ ulong DecimalToUInt64(decimal value);
                static /*0x1d5d234*/ byte Int32ToByte(int value);
                static /*0x1d5d39c*/ short Int32ToInt16(int value);
                static /*0x1d5d4d0*/ sbyte Int32ToSByte(int value);
                static /*0x1d5d604*/ ushort Int32ToUInt16(int value);
                static /*0x1d5d734*/ int Int64ToInt32(long value);
                static /*0x1d5d8a0*/ uint Int64ToUInt32(long value);
                static /*0x1d5d9d0*/ System.DateTime UntypedAtomicToDateTime(string value);
                static /*0x1d5da58*/ System.DateTimeOffset UntypedAtomicToDateTimeOffset(string value);
                /*0x1d57b5c*/ XmlBaseConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1d57c4c*/ XmlBaseConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x1d57d50*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic);
                /*0x1d57db0*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault);
                /*0x1d57e00*/ bool ToBoolean(System.DateTime value);
                /*0x1d57efc*/ bool ToBoolean(double value);
                /*0x1d58008*/ bool ToBoolean(int value);
                /*0x1d58104*/ bool ToBoolean(long value);
                /*0x1d58200*/ bool ToBoolean(string value);
                /*0x1d582d0*/ bool ToBoolean(object value);
                /*0x1d583a0*/ System.DateTime ToDateTime(bool value);
                /*0x1d5849c*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x1d585a4*/ System.DateTime ToDateTime(double value);
                /*0x1d586b0*/ System.DateTime ToDateTime(int value);
                /*0x1d587ac*/ System.DateTime ToDateTime(long value);
                /*0x1d588a8*/ System.DateTime ToDateTime(string value);
                /*0x1d58978*/ System.DateTime ToDateTime(object value);
                /*0x1d58a48*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x1d58b48*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x1d58c1c*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x1d58cf0*/ decimal ToDecimal(string value);
                /*0x1d58dc4*/ decimal ToDecimal(object value);
                /*0x1d58e98*/ double ToDouble(bool value);
                /*0x1d58f94*/ double ToDouble(System.DateTime value);
                /*0x1d59090*/ double ToDouble(int value);
                /*0x1d5918c*/ double ToDouble(long value);
                /*0x1d59288*/ double ToDouble(string value);
                /*0x1d59358*/ double ToDouble(object value);
                /*0x1d59428*/ int ToInt32(bool value);
                /*0x1d59524*/ int ToInt32(System.DateTime value);
                /*0x1d59620*/ int ToInt32(double value);
                /*0x1d5972c*/ int ToInt32(long value);
                /*0x1d59828*/ int ToInt32(string value);
                /*0x1d598f8*/ int ToInt32(object value);
                /*0x1d599c8*/ long ToInt64(bool value);
                /*0x1d59ac4*/ long ToInt64(System.DateTime value);
                /*0x1d59bc0*/ long ToInt64(double value);
                /*0x1d59ccc*/ long ToInt64(int value);
                /*0x1d59dc8*/ long ToInt64(string value);
                /*0x1d59e98*/ long ToInt64(object value);
                /*0x1d59f68*/ float ToSingle(double value);
                /*0x1d5a074*/ float ToSingle(string value);
                /*0x1d5a144*/ float ToSingle(object value);
                /*0x1d5a214*/ string ToString(bool value);
                /*0x1d5a2fc*/ string ToString(System.DateTime value);
                /*0x1d5a3e4*/ string ToString(System.DateTimeOffset value);
                /*0x1d5a4d8*/ string ToString(decimal value);
                /*0x1d5a5cc*/ string ToString(double value);
                /*0x1d5a6c4*/ string ToString(int value);
                /*0x1d5a7ac*/ string ToString(long value);
                /*0x1d5a894*/ string ToString(float value);
                /*0x1d5a98c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d5aa4c*/ string ToString(object value);
                /*0x1d5aa60*/ object ChangeType(bool value, System.Type destinationType);
                /*0x1d5aaec*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x1d5ab78*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x1d5ac10*/ object ChangeType(double value, System.Type destinationType);
                /*0x1d5aca4*/ object ChangeType(int value, System.Type destinationType);
                /*0x1d5ad30*/ object ChangeType(long value, System.Type destinationType);
                /*0x1d5adbc*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d5adcc*/ object ChangeType(object value, System.Type destinationType);
                /*0x1d5ade0*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x1d5ade8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1d5adf0*/ string get_XmlTypeName();
                /*0x1d5b020*/ System.Type get_DefaultClrType();
                /*0x1d5b100*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
                /*0x1d5b374*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric10Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x1b55800*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1b5578c*/ XmlNumeric10Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1b5585c*/ decimal ToDecimal(string value);
                /*0x1b5594c*/ decimal ToDecimal(object value);
                /*0x1b56294*/ int ToInt32(long value);
                /*0x1b562f8*/ int ToInt32(string value);
                /*0x1b5642c*/ int ToInt32(object value);
                /*0x1b56890*/ long ToInt64(int value);
                /*0x1b56898*/ long ToInt64(string value);
                /*0x1b569cc*/ long ToInt64(object value);
                /*0x1b56e08*/ string ToString(decimal value);
                /*0x1b56edc*/ string ToString(int value);
                /*0x1b56f40*/ string ToString(long value);
                /*0x1b56fa4*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b57420*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x1b57dbc*/ object ChangeType(int value, System.Type destinationType);
                /*0x1b58238*/ object ChangeType(long value, System.Type destinationType);
                /*0x1b586d0*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b58b54*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b55dc8*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b578c8*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric2Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x1b59cf8*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1b59c84*/ XmlNumeric2Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1b59d54*/ double ToDouble(string value);
                /*0x1b59e4c*/ double ToDouble(object value);
                /*0x1b5a1dc*/ float ToSingle(double value);
                /*0x1b5a1e4*/ float ToSingle(string value);
                /*0x1b5a2dc*/ float ToSingle(object value);
                /*0x1b5a690*/ string ToString(double value);
                /*0x1b5a760*/ string ToString(float value);
                /*0x1b5a804*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b5aba4*/ object ChangeType(double value, System.Type destinationType);
                /*0x1b5af70*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1b5b378*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlDateTimeConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x1d69624*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1d695b4*/ XmlDateTimeConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1d69680*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x1d69700*/ System.DateTime ToDateTime(string value);
                /*0x1d69948*/ System.DateTime ToDateTime(object value);
                /*0x1d69cf4*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x1d69d20*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x1d69f68*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x1d6a328*/ string ToString(System.DateTime value);
                /*0x1d6a524*/ string ToString(System.DateTimeOffset value);
                /*0x1d6a744*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d6aae4*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x1d6aec8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d6b2d0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBooleanConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x1d5e0bc*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1d5e04c*/ XmlBooleanConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1d5e118*/ bool ToBoolean(string value);
                /*0x1d5e39c*/ bool ToBoolean(object value);
                /*0x1d5e6bc*/ string ToString(bool value);
                /*0x1d5e780*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d5ea88*/ object ChangeType(bool value, System.Type destinationType);
                /*0x1d5edf8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d5f18c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlMiscConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x1fe1030*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1fe0fbc*/ XmlMiscConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1fe108c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fe17c0*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fe1eb8*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fe1670*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fe1d38*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlStringConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x2398a44*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x23989d0*/ XmlStringConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x2398aa0*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x2398cd8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x2398fb0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlUntypedConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Untyped;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter UntypedList;
                /*0x30*/ bool allowListToList;

                static /*0x1bd41f0*/ XmlUntypedConverter();
                /*0x1bcd710*/ XmlUntypedConverter();
                /*0x1bcd7c0*/ XmlUntypedConverter(System.Xml.Schema.XmlUntypedConverter atomicConverter, bool allowListToList);
                /*0x1bcd884*/ bool ToBoolean(string value);
                /*0x1bcd934*/ bool ToBoolean(object value);
                /*0x1bcdc80*/ System.DateTime ToDateTime(string value);
                /*0x1bcdd30*/ System.DateTime ToDateTime(object value);
                /*0x1bcdf18*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x1bcdfc8*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x1bce1ac*/ decimal ToDecimal(string value);
                /*0x1bce25c*/ decimal ToDecimal(object value);
                /*0x1bce454*/ double ToDouble(string value);
                /*0x1bce504*/ double ToDouble(object value);
                /*0x1bce700*/ int ToInt32(string value);
                /*0x1bce7b0*/ int ToInt32(object value);
                /*0x1bce9ac*/ long ToInt64(string value);
                /*0x1bcea5c*/ long ToInt64(object value);
                /*0x1bcec58*/ float ToSingle(string value);
                /*0x1bced08*/ float ToSingle(object value);
                /*0x1bcef04*/ string ToString(bool value);
                /*0x1bcef68*/ string ToString(System.DateTime value);
                /*0x1bcefcc*/ string ToString(System.DateTimeOffset value);
                /*0x1bcf040*/ string ToString(decimal value);
                /*0x1bcf0b4*/ string ToString(double value);
                /*0x1bcf120*/ string ToString(int value);
                /*0x1bcf184*/ string ToString(long value);
                /*0x1bcf1e8*/ string ToString(float value);
                /*0x1bcf254*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bd025c*/ object ChangeType(bool value, System.Type destinationType);
                /*0x1bd0620*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x1bd0818*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x1bd0a34*/ object ChangeType(double value, System.Type destinationType);
                /*0x1bd0c48*/ object ChangeType(int value, System.Type destinationType);
                /*0x1bd0e54*/ object ChangeType(long value, System.Type destinationType);
                /*0x1bd1060*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bd1ee0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bcdb30*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bd046c*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bd3874*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1bd3b9c*/ bool SupportsType(System.Type clrType);
            }

            class XmlAnyConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Item;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomic;

                static /*0x1d271fc*/ XmlAnyConverter();
                /*0x1d23218*/ XmlAnyConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x1d2328c*/ bool ToBoolean(object value);
                /*0x1d235b4*/ System.DateTime ToDateTime(object value);
                /*0x1d2378c*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x1d23988*/ decimal ToDecimal(object value);
                /*0x1d23b84*/ double ToDouble(object value);
                /*0x1d23d5c*/ int ToInt32(object value);
                /*0x1d23f34*/ long ToInt64(object value);
                /*0x1d2410c*/ float ToSingle(object value);
                /*0x1d24304*/ object ChangeType(bool value, System.Type destinationType);
                /*0x1d24738*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x1d249e4*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x1d24cd0*/ object ChangeType(double value, System.Type destinationType);
                /*0x1d24f84*/ object ChangeType(int value, System.Type destinationType);
                /*0x1d2522c*/ object ChangeType(long value, System.Type destinationType);
                /*0x1d254d8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d257ac*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d23464*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d245b8*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1d27148*/ System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav);
            }

            class XmlAnyListConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter ItemList;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomicList;

                static /*0x1d27b98*/ XmlAnyListConverter();
                /*0x1d2790c*/ XmlAnyListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x1d27914*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlListConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter atomicConverter;

                static /*0x1fdb04c*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter);
                /*0x1fdaed8*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x1fdaf54*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault);
                /*0x1fdafd8*/ XmlListConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1fdb22c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fdb340*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fdc1ec*/ bool IsListType(System.Type type);
                T[] ToArray<T>(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fdca54*/ System.Collections.IList ToList(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fdc9a0*/ System.Collections.Generic.List<string> StringAsList(string value);
                /*0x1fdc63c*/ string ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1fdc3c0*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
            }

            class XmlUnionConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter[] converters;
                /*0x30*/ bool hasAtomicMember;
                /*0x31*/ bool hasListMember;

                static /*0x1bcd00c*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bccda4*/ XmlUnionConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bcd068*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XsdBuilder : System.Xml.Schema.SchemaBuilder
            {
                static /*0x0*/ System.Xml.Schema.XsdBuilder.State[] SchemaElement;
                static /*0x8*/ System.Xml.Schema.XsdBuilder.State[] SchemaSubelements;
                static /*0x10*/ System.Xml.Schema.XsdBuilder.State[] AttributeSubelements;
                static /*0x18*/ System.Xml.Schema.XsdBuilder.State[] ElementSubelements;
                static /*0x20*/ System.Xml.Schema.XsdBuilder.State[] ComplexTypeSubelements;
                static /*0x28*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentSubelements;
                static /*0x30*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentExtensionSubelements;
                static /*0x38*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentRestrictionSubelements;
                static /*0x40*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentSubelements;
                static /*0x48*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentExtensionSubelements;
                static /*0x50*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentRestrictionSubelements;
                static /*0x58*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeSubelements;
                static /*0x60*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeRestrictionSubelements;
                static /*0x68*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeListSubelements;
                static /*0x70*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeUnionSubelements;
                static /*0x78*/ System.Xml.Schema.XsdBuilder.State[] RedefineSubelements;
                static /*0x80*/ System.Xml.Schema.XsdBuilder.State[] AttributeGroupSubelements;
                static /*0x88*/ System.Xml.Schema.XsdBuilder.State[] GroupSubelements;
                static /*0x90*/ System.Xml.Schema.XsdBuilder.State[] AllSubelements;
                static /*0x98*/ System.Xml.Schema.XsdBuilder.State[] ChoiceSequenceSubelements;
                static /*0xa0*/ System.Xml.Schema.XsdBuilder.State[] IdentityConstraintSubelements;
                static /*0xa8*/ System.Xml.Schema.XsdBuilder.State[] AnnotationSubelements;
                static /*0xb0*/ System.Xml.Schema.XsdBuilder.State[] AnnotatedSubelements;
                static /*0xb8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SchemaAttributes;
                static /*0xc0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeAttributes;
                static /*0xc8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ElementAttributes;
                static /*0xd0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes;
                static /*0xd8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes;
                static /*0xe0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes;
                static /*0xe8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes;
                static /*0xf0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes;
                static /*0xf8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes;
                static /*0x100*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes;
                static /*0x108*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes;
                static /*0x110*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes;
                static /*0x118*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes;
                static /*0x120*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes;
                static /*0x128*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes;
                static /*0x130*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes;
                static /*0x138*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupAttributes;
                static /*0x140*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupRefAttributes;
                static /*0x148*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ParticleAttributes;
                static /*0x150*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributes;
                static /*0x158*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes;
                static /*0x160*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SelectorAttributes;
                static /*0x168*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FieldAttributes;
                static /*0x170*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] NotationAttributes;
                static /*0x178*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IncludeAttributes;
                static /*0x180*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ImportAttributes;
                static /*0x188*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FacetAttributes;
                static /*0x190*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes;
                static /*0x198*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] DocumentationAttributes;
                static /*0x1a0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AppinfoAttributes;
                static /*0x1a8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] RedefineAttributes;
                static /*0x1b0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnnotationAttributes;
                static /*0x1b8*/ System.Xml.Schema.XsdBuilder.XsdEntry[] SchemaEntries;
                static /*0x1c0*/ int[] DerivationMethodValues;
                static /*0x1c8*/ string[] DerivationMethodStrings;
                static /*0x1d0*/ string[] FormStringValues;
                static /*0x1d8*/ string[] UseStringValues;
                static /*0x1e0*/ string[] ProcessContentsStringValues;
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.PositionInfo positionInfo;
                /*0x20*/ System.Xml.Schema.XsdBuilder.XsdEntry currentEntry;
                /*0x28*/ System.Xml.Schema.XsdBuilder.XsdEntry nextEntry;
                /*0x30*/ bool hasChild;
                /*0x38*/ System.Xml.HWStack stateHistory;
                /*0x40*/ System.Collections.Stack containerStack;
                /*0x48*/ System.Xml.XmlNameTable nameTable;
                /*0x50*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x58*/ System.Xml.XmlNamespaceManager namespaceManager;
                /*0x60*/ bool canIncludeImport;
                /*0x68*/ System.Xml.Schema.XmlSchema schema;
                /*0x70*/ System.Xml.Schema.XmlSchemaObject xso;
                /*0x78*/ System.Xml.Schema.XmlSchemaElement element;
                /*0x80*/ System.Xml.Schema.XmlSchemaAny anyElement;
                /*0x88*/ System.Xml.Schema.XmlSchemaAttribute attribute;
                /*0x90*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x98*/ System.Xml.Schema.XmlSchemaComplexType complexType;
                /*0xa0*/ System.Xml.Schema.XmlSchemaSimpleType simpleType;
                /*0xa8*/ System.Xml.Schema.XmlSchemaComplexContent complexContent;
                /*0xb0*/ System.Xml.Schema.XmlSchemaComplexContentExtension complexContentExtension;
                /*0xb8*/ System.Xml.Schema.XmlSchemaComplexContentRestriction complexContentRestriction;
                /*0xc0*/ System.Xml.Schema.XmlSchemaSimpleContent simpleContent;
                /*0xc8*/ System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension;
                /*0xd0*/ System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleContentRestriction;
                /*0xd8*/ System.Xml.Schema.XmlSchemaSimpleTypeUnion simpleTypeUnion;
                /*0xe0*/ System.Xml.Schema.XmlSchemaSimpleTypeList simpleTypeList;
                /*0xe8*/ System.Xml.Schema.XmlSchemaSimpleTypeRestriction simpleTypeRestriction;
                /*0xf0*/ System.Xml.Schema.XmlSchemaGroup group;
                /*0xf8*/ System.Xml.Schema.XmlSchemaGroupRef groupRef;
                /*0x100*/ System.Xml.Schema.XmlSchemaAll all;
                /*0x108*/ System.Xml.Schema.XmlSchemaChoice choice;
                /*0x110*/ System.Xml.Schema.XmlSchemaSequence sequence;
                /*0x118*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x120*/ System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup;
                /*0x128*/ System.Xml.Schema.XmlSchemaAttributeGroupRef attributeGroupRef;
                /*0x130*/ System.Xml.Schema.XmlSchemaNotation notation;
                /*0x138*/ System.Xml.Schema.XmlSchemaIdentityConstraint identityConstraint;
                /*0x140*/ System.Xml.Schema.XmlSchemaXPath xpath;
                /*0x148*/ System.Xml.Schema.XmlSchemaInclude include;
                /*0x150*/ System.Xml.Schema.XmlSchemaImport import;
                /*0x158*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x160*/ System.Xml.Schema.XmlSchemaAppInfo appInfo;
                /*0x168*/ System.Xml.Schema.XmlSchemaDocumentation documentation;
                /*0x170*/ System.Xml.Schema.XmlSchemaFacet facet;
                /*0x178*/ System.Xml.XmlNode[] markup;
                /*0x180*/ System.Xml.Schema.XmlSchemaRedefine redefine;
                /*0x188*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0x190*/ System.Collections.ArrayList unhandledAttributes;
                /*0x198*/ System.Collections.Hashtable namespaces;

                static /*0x1a55c88*/ XsdBuilder();
                static /*0x1a5143c*/ void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51464*/ void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a515f0*/ void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5169c*/ void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a516c0*/ void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a516e4*/ void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a519e8*/ void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51a5c*/ void InitSchema(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51a80*/ void InitInclude(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51b2c*/ void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51b50*/ void InitImport(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51bfc*/ void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51c20*/ void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51c44*/ void InitRedefine(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51cf0*/ void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a51d14*/ void EndRedefine(System.Xml.Schema.XsdBuilder builder);
                static /*0x1a51d30*/ void InitAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52014*/ void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52038*/ void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5205c*/ void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52108*/ void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a521b4*/ void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a523c0*/ void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a523e4*/ void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52460*/ void InitElement(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52554*/ void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a526e8*/ void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5275c*/ void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52780*/ void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5282c*/ void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a528a8*/ void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5291c*/ void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52940*/ void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52a20*/ void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52b00*/ void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52b24*/ void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52ba0*/ void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52c1c*/ void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52c98*/ void InitSimpleType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52f98*/ void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a52fbc*/ void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53030*/ void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a530d8*/ void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a532c0*/ void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53368*/ void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a533e4*/ void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5348c*/ void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53508*/ void InitComplexType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53668*/ void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a536e4*/ void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53758*/ void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a537cc*/ void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53850*/ void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53874*/ void InitComplexContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53960*/ void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a539dc*/ void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53ab0*/ void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53b2c*/ void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53bac*/ void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53c28*/ void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53d14*/ void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53de8*/ void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53e64*/ void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53f38*/ void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a53fb4*/ void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54070*/ void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54094*/ void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54104*/ void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54180*/ void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a543f0*/ void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54414*/ void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a544c0*/ void InitGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5457c*/ void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a545a0*/ void InitGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54924*/ void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54940*/ void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5495c*/ void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a549d8*/ void InitAll(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54a4c*/ void InitChoice(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54ac0*/ void InitSequence(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54b30*/ void InitAny(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54ba4*/ void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54bc8*/ void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54c74*/ void InitNotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54cf8*/ void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54d1c*/ void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54d40*/ void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a54d64*/ void InitFacet(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55078*/ void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a550fc*/ void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55120*/ void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55260*/ void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55284*/ void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a553b0*/ void InitSelector(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55458*/ void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a5547c*/ void InitField(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55530*/ void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55554*/ void InitAnnotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55620*/ void InitAppinfo(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a556c8*/ void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55748*/ void EndAppinfo(System.Xml.Schema.XsdBuilder builder);
                static /*0x1a55770*/ void InitDocumentation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55818*/ void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a55894*/ void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x1a559d8*/ void EndDocumentation(System.Xml.Schema.XsdBuilder builder);
                static /*0x1a55744*/ string ParseUriReference(string s);
                /*0x1a4f8a8*/ XsdBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x1a4fa70*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x1a4ff54*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x1a504f0*/ bool IsContentParsed();
                /*0x1a5050c*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x1a50514*/ void ProcessCData(string value);
                /*0x1a50570*/ void StartChildren();
                /*0x1a50700*/ void EndChildren();
                /*0x1a4fcfc*/ void Push();
                /*0x1a50740*/ void Pop();
                /*0x1a51310*/ System.Xml.Schema.SchemaNames.Token get_CurrentElement();
                /*0x1a5132c*/ System.Xml.Schema.SchemaNames.Token get_ParentElement();
                /*0x1a513a8*/ System.Xml.Schema.XmlSchemaObject get_ParentContainer();
                /*0x1a507f4*/ System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state);
                /*0x1a50928*/ void SetContainer(System.Xml.Schema.XsdBuilder.State state, object container);
                /*0x1a51dd8*/ void AddAttribute(System.Xml.Schema.XmlSchemaObject value);
                /*0x1a54614*/ void AddParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1a4fb84*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x1a4fe38*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x1a52a3c*/ void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x1a5295c*/ void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x1a525d0*/ bool ParseBoolean(string value, string attributeName);
                /*0x1a51510*/ int ParseEnum(string value, string attributeName, string[] values);
                /*0x1a52230*/ System.Xml.XmlQualifiedName ParseQName(string value, string attributeName);
                /*0x1a51758*/ int ParseBlockFinalEnum(string value, string attributeName);
                /*0x1a55a00*/ void SendValidationEvent(string code, string arg0, string arg1, string arg2);
                /*0x1a4fe60*/ void SendValidationEvent(string code, string msg);
                /*0x1a503f8*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x1a55bb0*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x1a532b8*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x1a4fd98*/ void RecordPosition();

                enum State
                {
                    Root = 0,
                    Schema = 1,
                    Annotation = 2,
                    Include = 3,
                    Import = 4,
                    Element = 5,
                    Attribute = 6,
                    AttributeGroup = 7,
                    AttributeGroupRef = 8,
                    AnyAttribute = 9,
                    Group = 10,
                    GroupRef = 11,
                    All = 12,
                    Choice = 13,
                    Sequence = 14,
                    Any = 15,
                    Notation = 16,
                    SimpleType = 17,
                    ComplexType = 18,
                    ComplexContent = 19,
                    ComplexContentRestriction = 20,
                    ComplexContentExtension = 21,
                    SimpleContent = 22,
                    SimpleContentExtension = 23,
                    SimpleContentRestriction = 24,
                    SimpleTypeUnion = 25,
                    SimpleTypeList = 26,
                    SimpleTypeRestriction = 27,
                    Unique = 28,
                    Key = 29,
                    KeyRef = 30,
                    Selector = 31,
                    Field = 32,
                    MinExclusive = 33,
                    MinInclusive = 34,
                    MaxExclusive = 35,
                    MaxInclusive = 36,
                    TotalDigits = 37,
                    FractionDigits = 38,
                    Length = 39,
                    MinLength = 40,
                    MaxLength = 41,
                    Enumeration = 42,
                    Pattern = 43,
                    WhiteSpace = 44,
                    AppInfo = 45,
                    Documentation = 46,
                    Redefine = 47,
                }

                class XsdBuildFunction : System.MulticastDelegate
                {
                    /*0x16cbb54*/ XsdBuildFunction(object object, nint method);
                    /*0x16cbbb4*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                    /*0x16cbf48*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XsdBuilder builder, string value, System.AsyncCallback callback, object object);
                    /*0x16cbf78*/ void EndInvoke(System.IAsyncResult result);
                }

                class XsdInitFunction : System.MulticastDelegate
                {
                    /*0x16cc3f8*/ XsdInitFunction(object object, nint method);
                    /*0x16cc458*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                    /*0x16cc7ec*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XsdBuilder builder, string value, System.AsyncCallback callback, object object);
                    /*0x16cc81c*/ void EndInvoke(System.IAsyncResult result);
                }

                class XsdEndChildFunction : System.MulticastDelegate
                {
                    /*0x16cbf84*/ XsdEndChildFunction(object object, nint method);
                    /*0x16cbfe4*/ void Invoke(System.Xml.Schema.XsdBuilder builder);
                    /*0x16cc35c*/ System.IAsyncResult BeginInvoke(System.Xml.Schema.XsdBuilder builder, System.AsyncCallback callback, object object);
                    /*0x16cc380*/ void EndInvoke(System.IAsyncResult result);
                }

                class XsdAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Attribute;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;

                    /*0x16cbb18*/ XsdAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build);
                }

                class XsdEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Name;
                    /*0x14*/ System.Xml.Schema.XsdBuilder.State CurrentState;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.State[] NextStates;
                    /*0x20*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] Attributes;
                    /*0x28*/ System.Xml.Schema.XsdBuilder.XsdInitFunction InitFunc;
                    /*0x30*/ System.Xml.Schema.XsdBuilder.XsdEndChildFunction EndChildFunc;
                    /*0x38*/ bool ParseContent;

                    /*0x16cc38c*/ XsdEntry(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, bool parseContent);
                }

                class BuilderNamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x50*/ System.Xml.XmlNamespaceManager nsMgr;
                    /*0x58*/ System.Xml.XmlReader reader;

                    /*0x16cba7c*/ BuilderNamespaceManager(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader);
                    /*0x16cbab4*/ string LookupNamespace(string prefix);
                }
            }

            enum XsdDateTimeFlags
            {
                DateTime = 1,
                Time = 2,
                Date = 4,
                GYearMonth = 8,
                GYear = 16,
                GMonthDay = 32,
                GDay = 64,
                GMonth = 128,
                XdrDateTimeNoTz = 256,
                XdrDateTime = 512,
                XdrTimeNoTz = 1024,
                AllXsd = 255,
            }

            struct XsdDateTime
            {
                static /*0x0*/ int Lzyyyy;
                static /*0x4*/ int Lzyyyy_;
                static /*0x8*/ int Lzyyyy_MM;
                static /*0xc*/ int Lzyyyy_MM_;
                static /*0x10*/ int Lzyyyy_MM_dd;
                static /*0x14*/ int Lzyyyy_MM_ddT;
                static /*0x18*/ int LzHH;
                static /*0x1c*/ int LzHH_;
                static /*0x20*/ int LzHH_mm;
                static /*0x24*/ int LzHH_mm_;
                static /*0x28*/ int LzHH_mm_ss;
                static /*0x2c*/ int Lz_;
                static /*0x30*/ int Lz_zz;
                static /*0x34*/ int Lz_zz_;
                static /*0x38*/ int Lz_zz_zz;
                static /*0x3c*/ int Lz__;
                static /*0x40*/ int Lz__mm;
                static /*0x44*/ int Lz__mm_;
                static /*0x48*/ int Lz__mm__;
                static /*0x4c*/ int Lz__mm_dd;
                static /*0x50*/ int Lz___;
                static /*0x54*/ int Lz___dd;
                static /*0x58*/ System.Xml.Schema.XmlTypeCode[] typeCodes;
                /*0x10*/ System.DateTime dt;
                /*0x18*/ uint extra;

                static /*0x1a5e21c*/ XsdDateTime();
                static /*0x1a5cbf0*/ bool TryParse(string text, System.Xml.Schema.XsdDateTimeFlags kinds, ref System.Xml.Schema.XsdDateTime result);
                static /*0x1a5d010*/ System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                static /*0x1a5d488*/ System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                /*0xad07cc*/ XsdDateTime(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0xad07d4*/ XsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0xad0850*/ XsdDateTime(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0xad0858*/ XsdDateTime(System.DateTimeOffset dateTimeOffset);
                /*0xad0864*/ XsdDateTime(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0xad081c*/ void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0xad086c*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode();
                /*0xad0874*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind();
                /*0xad087c*/ int get_Year();
                /*0xad0888*/ int get_Month();
                /*0xad0894*/ int get_Day();
                /*0xad08a0*/ int get_Hour();
                /*0xad08ac*/ int get_Minute();
                /*0xad08b8*/ int get_Second();
                /*0xad08c4*/ int get_Fraction();
                /*0xad08cc*/ int get_ZoneHour();
                /*0xad08d4*/ int get_ZoneMinute();
                /*0xad08dc*/ string ToString();
                /*0xad08e4*/ void PrintDate(System.Text.StringBuilder sb);
                /*0xad08ec*/ void PrintTime(System.Text.StringBuilder sb);
                /*0xad08f4*/ void PrintZone(System.Text.StringBuilder sb);
                /*0xad08fc*/ void IntToCharArray(char[] text, int start, int value, int digits);
                /*0xad0900*/ void ShortToCharArray(char[] text, int start, int value);

                enum DateTimeTypeCode
                {
                    DateTime = 0,
                    Time = 1,
                    Date = 2,
                    GYearMonth = 3,
                    GYear = 4,
                    GMonthDay = 5,
                    GDay = 6,
                    GMonth = 7,
                    XdrDateTime = 8,
                }

                enum XsdDateTimeKind
                {
                    Unspecified = 0,
                    Zulu = 1,
                    LocalWestOfZulu = 2,
                    LocalEastOfZulu = 3,
                }

                struct Parser
                {
                    static /*0x0*/ int[] Power10;
                    /*0x10*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode typeCode;
                    /*0x14*/ int year;
                    /*0x18*/ int month;
                    /*0x1c*/ int day;
                    /*0x20*/ int hour;
                    /*0x24*/ int minute;
                    /*0x28*/ int second;
                    /*0x2c*/ int fraction;
                    /*0x30*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind kind;
                    /*0x34*/ int zoneHour;
                    /*0x38*/ int zoneMinute;
                    /*0x40*/ string text;
                    /*0x48*/ int length;

                    static /*0x16cdc74*/ Parser();
                    static /*0x16cd244*/ bool Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right);
                    /*0xac1df4*/ bool Parse(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                    /*0xac1dfc*/ bool ParseDate(int start);
                    /*0xac1e04*/ bool ParseTimeAndZoneAndWhitespace(int start);
                    /*0xac1e0c*/ bool ParseTimeAndWhitespace(int start);
                    /*0xac1e14*/ bool ParseTime(ref int start);
                    /*0xac1e1c*/ bool ParseZoneAndWhitespace(int start);
                    /*0xac1e24*/ bool Parse4Dig(int start, ref int num);
                    /*0xac1e2c*/ bool Parse2Dig(int start, ref int num);
                    /*0xac1e34*/ bool ParseChar(int start, char ch);
                }
            }

            struct XsdDuration
            {
                /*0x10*/ int years;
                /*0x14*/ int months;
                /*0x18*/ int days;
                /*0x1c*/ int hours;
                /*0x20*/ int minutes;
                /*0x24*/ int seconds;
                /*0x28*/ uint nanoseconds;

                static /*0x1a5fbb0*/ System.Exception TryParse(string s, ref System.Xml.Schema.XsdDuration result);
                static /*0x1a5ea5c*/ System.Exception TryParse(string s, System.Xml.Schema.XsdDuration.DurationType durationType, ref System.Xml.Schema.XsdDuration result);
                static /*0x1a5fbbc*/ string TryParseDigits(string s, ref int offset, bool eatDigits, ref int result, ref int numDigits);
                /*0xad0904*/ XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds);
                /*0xad0918*/ XsdDuration(System.TimeSpan timeSpan);
                /*0xad09dc*/ XsdDuration(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0xad09e4*/ XsdDuration(string s);
                /*0xad09f0*/ XsdDuration(string s, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0xad09f8*/ bool get_IsNegative();
                /*0xad0a04*/ int get_Years();
                /*0xad0a0c*/ int get_Months();
                /*0xad0a14*/ int get_Days();
                /*0xad0a1c*/ int get_Hours();
                /*0xad0a24*/ int get_Minutes();
                /*0xad0a2c*/ int get_Seconds();
                /*0xad0a34*/ int get_Nanoseconds();
                /*0xad0a40*/ System.TimeSpan ToTimeSpan();
                /*0xad0a4c*/ System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0xad0a54*/ System.Exception TryToTimeSpan(ref System.TimeSpan result);
                /*0xad0a64*/ System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, ref System.TimeSpan result);
                /*0xad0a6c*/ string ToString();
                /*0xad0a78*/ string ToString(System.Xml.Schema.XsdDuration.DurationType durationType);

                enum Parts
                {
                    HasNone = 0,
                    HasYears = 1,
                    HasMonths = 2,
                    HasDays = 4,
                    HasHours = 8,
                    HasMinutes = 16,
                    HasSeconds = 32,
                }

                enum DurationType
                {
                    Duration = 0,
                    YearMonthDuration = 1,
                    DayTimeDuration = 2,
                }
            }

            class XsdValidator : System.Xml.Schema.BaseValidator
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaDatatype dtCDATA;
                static /*0x8*/ System.Xml.Schema.XmlSchemaDatatype dtQName;
                static /*0x10*/ System.Xml.Schema.XmlSchemaDatatype dtStringArray;
                /*0x7c*/ int startIDConstraint;
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlNamespaceManager nsManager;
                /*0x98*/ bool bManageNamespaces;
                /*0xa0*/ System.Collections.Hashtable IDs;
                /*0xa8*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xb0*/ System.Xml.Schema.Parser inlineSchemaParser;
                /*0xb8*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0xc0*/ string NsXmlNs;
                /*0xc8*/ string NsXs;
                /*0xd0*/ string NsXsi;
                /*0xd8*/ string XsiType;
                /*0xe0*/ string XsiNil;
                /*0xe8*/ string XsiSchemaLocation;
                /*0xf0*/ string XsiNoNamespaceSchemaLocation;
                /*0xf8*/ string XsdSchema;

                static /*0x16c0fd4*/ XsdValidator();
                /*0x16bbd78*/ XsdValidator(System.Xml.Schema.BaseValidator validator);
                /*0x16bc0dc*/ XsdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x16bbda8*/ void Init();
                /*0x16bc22c*/ void Validate();
                /*0x16bc934*/ void CompleteValidation();
                /*0x16bc300*/ bool get_IsInlineSchemaStarted();
                /*0x16bc310*/ void ProcessInlineSchema();
                /*0x16bc5d0*/ void ValidateElement();
                /*0x16bca48*/ object ValidateChildElement();
                /*0x16bcc98*/ void ProcessElement(object particle);
                /*0x16bcfd4*/ void ProcessXsiAttributes(ref System.Xml.XmlQualifiedName xsiType, ref string xsiNil);
                /*0x16bc73c*/ void ValidateEndElement();
                /*0x16bceec*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(object particle);
                /*0x16bd7c0*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, string xsiNil);
                /*0x16bdc80*/ void ValidateStartElement();
                /*0x16be38c*/ void ValidateEndStartElement();
                /*0x16bff24*/ void LoadSchemaFromLocation(string uri, string url);
                /*0x16be790*/ void LoadSchema(string uri, string url);
                /*0x16bdc00*/ bool get_HasSchema();
                /*0x16c054c*/ bool get_PreserveWhitespace();
                /*0x16c0588*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x16be954*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x16c0790*/ void AddID(string name, object node);
                /*0x16c0824*/ object FindId(string name);
                /*0x16bcc44*/ bool IsXSDRoot(string localName, string ns);
                /*0x16bc10c*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x16bfb08*/ void Pop();
                /*0x16bc938*/ void CheckForwardRefs();
                /*0x16bdc24*/ void ValidateStartElementIdentityConstraints();
                /*0x16bedf8*/ bool get_HasIdentityConstraints();
                /*0x16c0840*/ void AddIdentityConstraints();
                /*0x16c0c6c*/ void ElementIdentityConstraints();
                /*0x16bfc48*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.SchemaAttDef attdef);
                /*0x16bfbc0*/ object UnWrapUnion(object typedValue);
                /*0x16bee08*/ void EndElementIdentityConstraints();
            }
        }

        namespace XmlConfiguration
        {
            class XmlReaderSection
            {
                static /*0x1b5f298*/ bool get_ProhibitDefaultUrlResolver();
                static /*0x1b5f2a0*/ System.Xml.XmlResolver CreateDefaultResolver();
                static /*0x1b5f2f8*/ bool get_CollapseWhiteSpaceIntoEmptyString();
            }
        }

        namespace Xsl
        {
            namespace Runtime
            {
                struct StringConcat
                {
                    /*0x10*/ string s1;
                    /*0x18*/ string s2;
                    /*0x20*/ string s3;
                    /*0x28*/ string s4;
                    /*0x30*/ string delimiter;
                    /*0x38*/ System.Collections.Generic.List<string> strList;
                    /*0x40*/ int idxStr;

                    /*0xad1424*/ void Clear();
                    /*0xad1430*/ int get_Count();
                    /*0xad1438*/ string GetResult();
                    /*0xad1440*/ void ConcatNoDelimiter(string s);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0701435C4E2C38EFE43C51BD22C114AB8B80124D;
    static /*0xc*/ <PrivateImplementationDetails> 0EE6555EB2C89F29655BD23FAB0573D8D684331A;
    static /*0x30*/ <PrivateImplementationDetails> 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1;
    static /*0x74*/ <PrivateImplementationDetails> 161F91CE1721D8F16622810CBB39887D21C47031;
    static /*0x80*/ <PrivateImplementationDetails> 2051D7520B96DCC12F2E4DE851CB9F203D623805;
    static /*0xa0*/ <PrivateImplementationDetails> 221CE291CD044114B4369175B9B91177F5932876;
    static /*0xcc*/ <PrivateImplementationDetails> 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D;
    static /*0xf2*/ <PrivateImplementationDetails> 360487BE4278986419B568EFD887F6145383168A;
    static /*0x11a*/ <PrivateImplementationDetails> 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1;
    static /*0x12e*/ <PrivateImplementationDetails> 485F43E332C2F7530815B17C08DAC169A8F697E0;
    static /*0x14e*/ <PrivateImplementationDetails> 49C5BA13401986EC93E4677F52CBE2248184DFBD;
    static /*0x1be*/ <PrivateImplementationDetails> 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440;
    static /*0x1d6*/ <PrivateImplementationDetails> 553E235E202D57C9F1156E7D232E02BBDC920165;
    static /*0x596*/ <PrivateImplementationDetails> 574B9D4E4C39F6E8004181E5765B627B75EB1AD1;
    static /*0x5ce*/ <PrivateImplementationDetails> 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD;
    static /*0x5da*/ <PrivateImplementationDetails> 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98;
    static /*0x5e0*/ <PrivateImplementationDetails> 68D0F86889D5D656483EEE829BCEECDFEC91D8EA;
    static /*0x878*/ <PrivateImplementationDetails> 6A0D50D692745A6663128CD315B71079584F3E59;
    static /*0xa18*/ <PrivateImplementationDetails> 702F6A3276CBE481D247A77C20B5459FB94D07D2;
    static /*0xa30*/ <PrivateImplementationDetails> 7A32E1A19C182315E4263A65A72066492550D8CD;
    static /*0xa50*/ <PrivateImplementationDetails> 8B4E5E81A88D29642679AFCE41DCA380F9000462;
    static /*0xa60*/ <PrivateImplementationDetails> 977375E4E1ED54F588076ACA36CC17E6C2195CB9;
    static /*0xe20*/ <PrivateImplementationDetails> 99F0664C2AC8464B51252D92FC24F3834C6FB90C;
    static /*0xe2c*/ <PrivateImplementationDetails> 9E31F24F64765FCAA589F589324D17C9FCF6A06D;
    static /*0xe48*/ <PrivateImplementationDetails> 9E374D7263B2452E25DE3D6E617F6A728D98A439;
    static /*0xed8*/ <PrivateImplementationDetails> A933F173482FF50754B4942AF8DFC584EF14A45B;
    static /*0xf1c*/ <PrivateImplementationDetails> AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C;
    static /*0xf34*/ <PrivateImplementationDetails> B368804F0C6DAB083B253A6B106D0783D5C32E90;
    static /*0x10d4*/ <PrivateImplementationDetails> B9F0004E3873FDDCABFDA6174EA18F0859B637B4;
    static /*0x10fc*/ <PrivateImplementationDetails> BAD037B714E1CD1052149B51238A3D4351DD10B5;
    static /*0x1110*/ <PrivateImplementationDetails> C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C;
    static /*0x1120*/ long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81;
    static /*0x1128*/ <PrivateImplementationDetails> DCF398750721AA7A27A6BA56E99350329B06E8B1;
    static /*0x1138*/ long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C;
    static /*0x1140*/ <PrivateImplementationDetails> ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4;
    static /*0x1164*/ <PrivateImplementationDetails> EE3413A2C088FF9432054D6E60A7CB6A498D25F0;
    static /*0x11a4*/ <PrivateImplementationDetails> F64F25EAE9A3D7A356813C4218000185541D7779;
    static /*0x11c8*/ <PrivateImplementationDetails> FB0C58D8B3094F018764CC6E3094B9576DB08069;
    static /*0x1684*/ <PrivateImplementationDetails> FFE3F15642234E7FAD6951D432F1134D5AD15922;

    static /*0x1586898*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=28
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=38
    {
    }

    struct __StaticArrayInitTypeSize=40
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=56
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=68
    {
    }

    struct __StaticArrayInitTypeSize=112
    {
    }

    struct __StaticArrayInitTypeSize=144
    {
    }

    struct __StaticArrayInitTypeSize=416
    {
    }

    struct __StaticArrayInitTypeSize=664
    {
    }

    struct __StaticArrayInitTypeSize=960
    {
    }

    struct __StaticArrayInitTypeSize=1212
    {
    }
}
