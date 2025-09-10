class <Module>
{
}

class SR
{
    static /*0x1526cec*/ string GetString(string name);
    static /*0x1526cf0*/ string Format(string resourceFormat, object p1);
    static /*0x1526d60*/ string Format(string resourceFormat, object p1, object p2);
    static /*0x1526dd8*/ string Format(string resourceFormat, object p1, object p2, object p3);
}

namespace System
{
    namespace Data
    {
        enum AcceptRejectRule
        {
            None = 0,
            Cascade = 1,
        }

        enum AggregateType
        {
            None = 0,
            Sum = 4,
            Mean = 5,
            Min = 6,
            Max = 7,
            First = 8,
            Count = 9,
            Var = 10,
            StDev = 11,
        }

        class InternalDataCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
        {
            static /*0x0*/ System.ComponentModel.CollectionChangeEventArgs s_refreshEventArgs;

            static /*0x1526fc8*/ InternalDataCollectionBase();
            /*0x1526fc0*/ InternalDataCollectionBase();
            /*0x1526e60*/ int get_Count();
            /*0x1526e8c*/ void CopyTo(System.Array ar, int index);
            /*0x1526ed4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1526f00*/ bool get_IsSynchronized();
            /*0x1526f08*/ int NamesEqual(string s1, string s2, bool fCaseSensitive, System.Globalization.CultureInfo locale);
            /*0x1526fb4*/ object get_SyncRoot();
            /*0x1526fb8*/ System.Collections.ArrayList get_List();
        }

        class ColumnTypeConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.Type[] s_types;
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            static /*0x1527a20*/ ColumnTypeConverter();
            /*0x1527048*/ ColumnTypeConverter();
            /*0x1527050*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1527118*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1527628*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x15276f0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x15278f8*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1527a10*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1527a18*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataCommonEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Data.DataCommonEventSource Log;
            static /*0x8*/ long s_nextScopeId;

            static /*0x1528628*/ DataCommonEventSource();
            /*0x1528620*/ DataCommonEventSource();
            /*0x152853c*/ void Trace(string message);
            void Trace<T0>(string format, T0 arg0);
            void Trace<T0, T1>(string format, T0 arg0, T1 arg1);
            void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2);
            void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x152854c*/ long EnterScope(string message);
            long EnterScope<T1>(string format, T1 arg1);
            long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2);
            long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
            long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x1528610*/ void ExitScope(long scopeId);
        }

        class Constraint
        {
            /*0x10*/ string _schemaName;
            /*0x18*/ bool _inCollection;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ string _name;
            /*0x30*/ System.Data.PropertyCollection _extendedProperties;

            /*0x1528e4c*/ Constraint();
            /*0x1528698*/ string get_ConstraintName();
            /*0x15286a0*/ void set_ConstraintName(string value);
            /*0x1528b3c*/ string get_SchemaName();
            /*0x1528b74*/ void set_SchemaName(string value);
            /*0x1528ba4*/ bool get_InCollection();
            /*0x1528bac*/ void set_InCollection(bool value);
            System.Data.DataTable get_Table();
            /*0x1528bf0*/ System.Data.PropertyCollection get_ExtendedProperties();
            bool ContainsColumn(System.Data.DataColumn column);
            bool CanEnableConstraint();
            System.Data.Constraint Clone(System.Data.DataSet destination);
            System.Data.Constraint Clone(System.Data.DataSet destination, bool ignoreNSforTableLookup);
            /*0x1528c5c*/ void CheckConstraint();
            void CheckCanAddToCollection(System.Data.ConstraintCollection constraint);
            bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, bool fThrowException);
            void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            void CheckState();
            /*0x1528cf8*/ void CheckStateForProperty();
            /*0x1528e38*/ System.Data.DataSet get__DataSet();
            bool IsConstraintViolated();
            /*0x1528e40*/ string ToString();
        }

        class ConstraintCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;
            /*0x30*/ System.Data.Constraint[] _delayLoadingConstraints;
            /*0x38*/ bool _fLoadForeignKeyConstraintsOnly;

            static /*0x152aa50*/ bool CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2);
            /*0x1528ea8*/ ConstraintCollection(System.Data.DataTable table);
            /*0x1528f50*/ System.Collections.ArrayList get_List();
            /*0x1528f58*/ System.Data.Constraint get_Item(int index);
            /*0x15290e0*/ System.Data.DataTable get_Table();
            /*0x15290e8*/ System.Data.Constraint get_Item(string name);
            /*0x1529378*/ void Add(System.Data.Constraint constraint);
            /*0x1529380*/ void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign);
            /*0x1529e34*/ System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey);
            /*0x1529aac*/ void AddUniqueConstraint(System.Data.UniqueConstraint constraint);
            /*0x1529ca4*/ void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint);
            /*0x1529950*/ bool AutoGenerated(System.Data.Constraint constraint);
            /*0x1529dd4*/ void ArrayAdd(System.Data.Constraint constraint);
            /*0x1529fa0*/ void ArrayRemove(System.Data.Constraint constraint);
            /*0x1529c80*/ string AssignName();
            /*0x1529d10*/ void BaseAdd(System.Data.Constraint constraint);
            /*0x152a090*/ void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength);
            /*0x152a244*/ void BaseRemove(System.Data.Constraint constraint);
            /*0x152a510*/ bool CanRemove(System.Data.Constraint constraint, bool fThrowException);
            /*0x152a540*/ void Clear();
            /*0x152a914*/ bool Contains(string name);
            /*0x152a92c*/ bool Contains(string name, bool caseSensitive);
            /*0x1529780*/ System.Data.Constraint FindConstraint(System.Data.Constraint constraint);
            /*0x1529b74*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns);
            /*0x152aad8*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column);
            /*0x152abe4*/ System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x15291d0*/ int InternalIndexOf(string constraintName);
            /*0x1529fd8*/ string MakeName(int index);
            /*0x1529e0c*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x15288b0*/ void RegisterName(string name);
            /*0x152ad60*/ void Remove(System.Data.Constraint constraint);
            /*0x1528abc*/ void UnregisterName(string name);
        }

        class ConstraintConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x152aebc*/ ConstraintConverter();
            /*0x152aec4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x152af8c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class ConstraintEnumerator
        {
            /*0x10*/ System.Collections.IEnumerator _tables;
            /*0x18*/ System.Collections.IEnumerator _constraints;
            /*0x20*/ System.Data.Constraint _currentObject;

            /*0x152b920*/ ConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x152b974*/ bool GetNext();
            /*0x152bc54*/ System.Data.Constraint GetConstraint();
            /*0x152bc5c*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x152bc64*/ System.Data.Constraint get_CurrentObject();
        }

        class ForeignKeyConstraintEnumerator : System.Data.ConstraintEnumerator
        {
            /*0x152bc6c*/ ForeignKeyConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x152bc70*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x152bce8*/ System.Data.ForeignKeyConstraint GetForeignKeyConstraint();
        }

        class ChildForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x152bd60*/ ChildForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x152bd84*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class ParentForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x152be18*/ ParentForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x152be3c*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class DataColumn : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x20*/ bool _allowNull;
            /*0x28*/ string _caption;
            /*0x30*/ string _columnName;
            /*0x38*/ System.Type _dataType;
            /*0x40*/ System.Data.Common.StorageType _storageType;
            /*0x48*/ object _defaultValue;
            /*0x50*/ System.Data.DataSetDateTime _dateTimeMode;
            /*0x58*/ System.Data.DataExpression _expression;
            /*0x60*/ int _maxLength;
            /*0x64*/ int _ordinal;
            /*0x68*/ bool _readOnly;
            /*0x70*/ System.Data.Index _sortIndex;
            /*0x78*/ System.Data.DataTable _table;
            /*0x80*/ bool _unique;
            /*0x84*/ System.Data.MappingType _columnMapping;
            /*0x88*/ int _hashCode;
            /*0x8c*/ int _errors;
            /*0x90*/ bool _isSqlType;
            /*0x91*/ bool _implementsINullable;
            /*0x92*/ bool _implementsIChangeTracking;
            /*0x93*/ bool _implementsIRevertibleChangeTracking;
            /*0x94*/ bool _implementsIXMLSerializable;
            /*0x95*/ bool _defaultValueIsNull;
            /*0x98*/ System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;
            /*0xa0*/ System.Data.PropertyCollection _extendedProperties;
            /*0xa8*/ System.Data.Common.DataStorage _storage;
            /*0xb0*/ System.Data.AutoIncrementValue _autoInc;
            /*0xb8*/ string _columnUri;
            /*0xc0*/ string _columnPrefix;
            /*0xc8*/ string _encodedColumnName;
            /*0xd0*/ System.Data.SimpleType _simpleType;
            /*0xd8*/ int _objectID;
            /*0xe0*/ string <XmlDataType>k__BackingField;
            /*0xe8*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;

            static /*0x152d3f0*/ bool IsAutoIncrementType(System.Type dataType);
            /*0x152bed4*/ DataColumn();
            /*0x152c260*/ DataColumn(string columnName, System.Type dataType);
            /*0x152bf64*/ DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type);
            /*0x152c310*/ void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode);
            /*0x152cbb8*/ bool get_AllowDBNull();
            /*0x152cbc0*/ void set_AllowDBNull(bool value);
            /*0x152d1a4*/ bool get_AutoIncrement();
            /*0x152d1c4*/ void set_AutoIncrement(bool value);
            /*0x152e034*/ object get_AutoIncrementCurrent();
            /*0x152e0b8*/ void set_AutoIncrementCurrent(object value);
            /*0x152df34*/ System.Data.AutoIncrementValue get_AutoInc();
            /*0x152e0a0*/ long get_AutoIncrementSeed();
            /*0x152e2a0*/ void set_AutoIncrementSeed(long value);
            /*0x152e390*/ long get_AutoIncrementStep();
            /*0x152e3ac*/ void set_AutoIncrementStep(long value);
            /*0x152e4a4*/ string get_Caption();
            /*0x152e4c0*/ void set_Caption(string value);
            /*0x152e5b0*/ string get_ColumnName();
            /*0x152e5b8*/ void set_ColumnName(string value);
            /*0x152eca4*/ string get_EncodedColumnName();
            /*0x152e1bc*/ System.IFormatProvider get_FormatProvider();
            /*0x152e544*/ System.Globalization.CultureInfo get_Locale();
            /*0x152ed10*/ int get_ObjectID();
            /*0x152ed18*/ string get_Prefix();
            /*0x152ed20*/ void set_Prefix(string value);
            /*0x152eec8*/ string GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x152efec*/ bool get_Computed();
            /*0x152effc*/ System.Data.DataExpression get_DataExpression();
            /*0x152f004*/ System.Type get_DataType();
            /*0x152d728*/ void set_DataType(System.Type value);
            /*0x152f758*/ System.Data.DataSetDateTime get_DateTimeMode();
            /*0x152f760*/ void set_DateTimeMode(System.Data.DataSetDateTime value);
            /*0x152f210*/ object get_DefaultValue();
            /*0x152f334*/ void set_DefaultValue(object value);
            /*0x152fab4*/ bool get_DefaultValueIsNull();
            /*0x152fabc*/ string get_Expression();
            /*0x152c418*/ void set_Expression(string value);
            /*0x152ff54*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x152d6cc*/ bool get_HasData();
            /*0x152ffc0*/ bool get_ImplementsINullable();
            /*0x152ffc8*/ bool get_ImplementsIChangeTracking();
            /*0x152ffd0*/ bool get_ImplementsIRevertibleChangeTracking();
            /*0x152ffd8*/ bool get_IsValueType();
            /*0x152fff4*/ bool get_IsSqlType();
            /*0x152fffc*/ void SetMaxLengthSimpleType();
            /*0x1530078*/ int get_MaxLength();
            /*0x1530080*/ void set_MaxLength(int value);
            /*0x15308a8*/ string get_Namespace();
            /*0x1530920*/ void set_Namespace(string value);
            /*0x1530a9c*/ int get_Ordinal();
            /*0x1530aa4*/ void SetOrdinalInternal(int ordinal);
            /*0x1530bd0*/ bool get_ReadOnly();
            /*0x152fbd0*/ void set_ReadOnly(bool value);
            /*0x1530c18*/ System.Data.Index get_SortIndex();
            /*0x1530cdc*/ System.Data.DataTable get_Table();
            /*0x1530ce4*/ void SetTable(System.Data.DataTable table);
            /*0x1530d94*/ System.Data.DataRow GetDataRow(int index);
            /*0x152ef90*/ object get_Item(int record);
            /*0x1530db8*/ void set_Item(int record, object value);
            /*0x152fec8*/ void InitializeRecord(int record);
            /*0x1531010*/ void SetValue(int record, object value);
            /*0x1531118*/ void FreeRecord(int record);
            /*0x153113c*/ bool get_Unique();
            /*0x1531144*/ void set_Unique(bool value);
            /*0x1531638*/ void InternalUnique(bool value);
            /*0x1531644*/ string get_XmlDataType();
            /*0x153164c*/ void set_XmlDataType(string value);
            /*0x1531654*/ System.Data.SimpleType get_SimpleType();
            /*0x152c2d4*/ void set_SimpleType(System.Data.SimpleType value);
            /*0x153165c*/ System.Data.MappingType get_ColumnMapping();
            /*0x1531664*/ void set_ColumnMapping(System.Data.MappingType value);
            /*0x1531964*/ void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1530484*/ bool CheckMaxLength();
            /*0x1531a30*/ void CheckMaxLength(System.Data.DataRow dr);
            /*0x152cd6c*/ void CheckNotAllowNull();
            /*0x15319b8*/ void CheckNullable(System.Data.DataRow row);
            /*0x15315ec*/ void CheckUnique();
            /*0x1531c04*/ int Compare(int record1, int record2);
            /*0x1531c24*/ bool CompareValueTo(int record1, object value, bool checkType);
            /*0x1531e04*/ int CompareValueTo(int record1, object value);
            /*0x1531e24*/ object ConvertValue(object value);
            /*0x1531e44*/ void Copy(int srcRecordNo, int dstRecordNo);
            /*0x1531e64*/ System.Data.DataColumn Clone();
            /*0x153244c*/ object GetAggregateValue(int[] records, System.Data.AggregateType kind);
            /*0x1531aac*/ int GetStringLength(int record);
            /*0x1532510*/ void Init(int record);
            /*0x153259c*/ bool get_IsCustomType();
            /*0x1532610*/ bool IsValueCustomTypeInstance(object value);
            /*0x15326dc*/ bool get_ImplementsIXMLSerializable();
            /*0x152f08c*/ bool IsInRelation();
            /*0x1532770*/ bool IsMaxLengthViolated();
            /*0x1532d0c*/ bool IsNotAllowDBNullViolated();
            /*0x1532e7c*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x152ebd0*/ void RaisePropertyChanging(string name);
            /*0x1532ea4*/ void InsureStorage();
            /*0x1532f1c*/ void SetCapacity(int capacity);
            /*0x1532f58*/ void OnSetDataSet();
            /*0x1532f5c*/ string ToString();
            /*0x1532fd0*/ object ConvertXmlToObject(string s);
            /*0x153300c*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x152efb0*/ string ConvertObjectToXml(object value);
            /*0x1533050*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x15330a4*/ object GetEmptyColumnStore(int recordCount);
            /*0x15330d8*/ void CopyValueIntoStore(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
            /*0x15330f4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            /*0x1533130*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x153322c*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x152fd90*/ void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression);
        }

        class AutoIncrementValue
        {
            /*0x10*/ bool <Auto>k__BackingField;

            /*0x15332d8*/ AutoIncrementValue();
            /*0x15332c4*/ bool get_Auto();
            /*0x15332cc*/ void set_Auto(bool value);
            object get_Current();
            void set_Current(object value);
            long get_Seed();
            void set_Seed(long value);
            long get_Step();
            void set_Step(long value);
            System.Type get_DataType();
            void SetCurrent(object value, System.IFormatProvider formatProvider);
            void SetCurrentAndIncrement(object value);
            void MoveAfter();
            /*0x153232c*/ System.Data.AutoIncrementValue Clone();
        }

        class AutoIncrementInt64 : System.Data.AutoIncrementValue
        {
            /*0x18*/ long _current;
            /*0x20*/ long _seed;
            /*0x28*/ long _step;

            /*0x152e228*/ AutoIncrementInt64();
            /*0x15332e0*/ object get_Current();
            /*0x153333c*/ void set_Current(object value);
            /*0x15333b4*/ System.Type get_DataType();
            /*0x1533420*/ long get_Seed();
            /*0x1533428*/ void set_Seed(long value);
            /*0x1533588*/ long get_Step();
            /*0x1533590*/ void set_Step(long value);
            /*0x1533650*/ void MoveAfter();
            /*0x1533664*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x15336d8*/ void SetCurrentAndIncrement(object value);
            /*0x15334b8*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class AutoIncrementBigInteger : System.Data.AutoIncrementValue
        {
            /*0x18*/ System.Numerics.BigInteger _current;
            /*0x28*/ long _seed;
            /*0x30*/ System.Numerics.BigInteger _step;

            /*0x152e238*/ AutoIncrementBigInteger();
            /*0x1533840*/ object get_Current();
            /*0x153389c*/ void set_Current(object value);
            /*0x1533914*/ System.Type get_DataType();
            /*0x1533980*/ long get_Seed();
            /*0x1533988*/ void set_Seed(long value);
            /*0x1533b90*/ long get_Step();
            /*0x1533bf0*/ void set_Step(long value);
            /*0x1533d58*/ void MoveAfter();
            /*0x1533dd4*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x1533df8*/ void SetCurrentAndIncrement(object value);
            /*0x1533a68*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class DataColumnChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataColumn _column;
            /*0x18*/ System.Data.DataRow <Row>k__BackingField;
            /*0x20*/ object <ProposedValue>k__BackingField;

            /*0x1533eb8*/ DataColumnChangeEventArgs(System.Data.DataRow row);
            /*0x1533f24*/ DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value);
            /*0x1533fa4*/ object get_ProposedValue();
            /*0x1533fac*/ void set_ProposedValue(object value);
            /*0x1533fb4*/ void InitializeColumnChangeEvent(System.Data.DataColumn column, object value);
        }

        class DataColumnChangeEventHandler : System.MulticastDelegate
        {
            /*0x1533fc0*/ DataColumnChangeEventHandler(object object, nint method);
            /*0x15340f0*/ void Invoke(object sender, System.Data.DataColumnChangeEventArgs e);
        }

        class DataColumnCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.Data.DataColumn[] _delayedAddRangeColumns;
            /*0x30*/ System.Collections.Generic.Dictionary<string, System.Data.DataColumn> _columnFromName;
            /*0x38*/ bool _fInClear;
            /*0x40*/ System.Data.DataColumn[] _columnsImplementingIChangeTracking;
            /*0x48*/ int _nColumnsImplementingIChangeTracking;
            /*0x4c*/ int _nColumnsImplementingIRevertibleChangeTracking;
            /*0x50*/ System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
            /*0x58*/ System.ComponentModel.CollectionChangeEventHandler CollectionChanging;
            /*0x60*/ System.ComponentModel.CollectionChangeEventHandler ColumnPropertyChanged;

            /*0x1534104*/ DataColumnCollection(System.Data.DataTable table);
            /*0x1534248*/ System.Collections.ArrayList get_List();
            /*0x1534250*/ System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking();
            /*0x1534258*/ int get_ColumnsImplementingIChangeTrackingCount();
            /*0x1534260*/ int get_ColumnsImplementingIRevertibleChangeTrackingCount();
            /*0x1534268*/ System.Data.DataColumn get_Item(int index);
            /*0x1534424*/ System.Data.DataColumn get_Item(string name);
            /*0x15346c8*/ System.Data.DataColumn get_Item(string name, string ns);
            /*0x1534768*/ void Add(System.Data.DataColumn column);
            /*0x1534774*/ void AddAt(int index, System.Data.DataColumn column);
            /*0x1534dc4*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1534e60*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1534efc*/ void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1534f98*/ void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1534cb8*/ void ArrayAdd(System.Data.DataColumn column);
            /*0x1534c78*/ void ArrayAdd(int index, System.Data.DataColumn column);
            /*0x153507c*/ void ArrayRemove(System.Data.DataColumn column);
            /*0x15352a8*/ string AssignName();
            /*0x15349ec*/ void BaseAdd(System.Data.DataColumn column);
            /*0x153548c*/ void BaseGroupSwitch(System.Data.DataColumn[] oldArray, int oldLength, System.Data.DataColumn[] newArray, int newLength);
            /*0x1535664*/ void BaseRemove(System.Data.DataColumn column);
            /*0x1535720*/ bool CanRemove(System.Data.DataColumn column, bool fThrowException);
            /*0x1535034*/ void CheckIChangeTracking(System.Data.DataColumn column);
            /*0x1535fcc*/ void Clear();
            /*0x15362a0*/ bool Contains(string name);
            /*0x1536334*/ bool Contains(string name, bool caseSensitive);
            /*0x15363d0*/ int IndexOf(string columnName);
            /*0x153456c*/ int IndexOfCaseInsensitive(string name);
            /*0x153533c*/ string MakeName(int index);
            /*0x1534d20*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x15349c4*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x152ec4c*/ void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x152e95c*/ void RegisterColumnName(string name, System.Data.DataColumn column);
            /*0x15365b4*/ bool CanRegisterName(string name);
            /*0x1536618*/ void Remove(System.Data.DataColumn column);
            /*0x152eb14*/ void UnregisterName(string name);
            /*0x1535f00*/ void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
            /*0x15351a4*/ void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
        }

        class DataColumnPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataColumn <Column>k__BackingField;

            /*0x153672c*/ DataColumnPropertyDescriptor(System.Data.DataColumn dataColumn);
            /*0x1536764*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x153692c*/ System.Data.DataColumn get_Column();
            /*0x1536934*/ System.Type get_ComponentType();
            /*0x15369a0*/ bool get_IsReadOnly();
            /*0x15369bc*/ System.Type get_PropertyType();
            /*0x15369d8*/ bool Equals(object other);
            /*0x1536a48*/ int GetHashCode();
            /*0x1536a68*/ bool CanResetValue(object component);
            /*0x1536b80*/ object GetValue(object component);
            /*0x1536c0c*/ void ResetValue(object component);
            /*0x1536cd4*/ void SetValue(object component, object value);
            /*0x1536db8*/ bool ShouldSerializeValue(object component);
        }

        class DataError
        {
            /*0x10*/ string _rowError;
            /*0x18*/ int _count;
            /*0x20*/ System.Data.DataError.ColumnError[] _errorList;

            /*0x1536dc0*/ DataError();
            /*0x1536e18*/ DataError(string rowError);
            /*0x1536f0c*/ string get_Text();
            /*0x1536f14*/ void set_Text(string value);
            /*0x1536f6c*/ bool get_HasErrors();
            /*0x1536fa0*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x1537274*/ string GetColumnError(System.Data.DataColumn column);
            /*0x1537080*/ void Clear(System.Data.DataColumn column);
            /*0x1537310*/ void Clear();
            /*0x15373b8*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x1536eb4*/ void SetText(string errorText);
            /*0x153712c*/ int IndexOf(System.Data.DataColumn column);

            struct ColumnError
            {
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ string _error;
            }
        }

        class DataException : System.SystemException
        {
            /*0x15374a0*/ DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x15374a8*/ DataException();
            /*0x1537504*/ DataException(string s);
            /*0x1537528*/ DataException(string s, System.Exception innerException);
        }

        class ConstraintException : System.Data.DataException
        {
            /*0x1537530*/ ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1537538*/ ConstraintException();
            /*0x1537594*/ ConstraintException(string s);
        }

        class DeletedRowInaccessibleException : System.Data.DataException
        {
            /*0x15375b8*/ DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x15375c0*/ DeletedRowInaccessibleException();
            /*0x153761c*/ DeletedRowInaccessibleException(string s);
        }

        class DuplicateNameException : System.Data.DataException
        {
            /*0x1537640*/ DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1537648*/ DuplicateNameException();
            /*0x15376a4*/ DuplicateNameException(string s);
        }

        class InRowChangingEventException : System.Data.DataException
        {
            /*0x15376c8*/ InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x15376d0*/ InRowChangingEventException();
            /*0x153772c*/ InRowChangingEventException(string s);
        }

        class InvalidConstraintException : System.Data.DataException
        {
            /*0x1537750*/ InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1537758*/ InvalidConstraintException();
            /*0x15377b4*/ InvalidConstraintException(string s);
        }

        class NoNullAllowedException : System.Data.DataException
        {
            /*0x15377d8*/ NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x15377e0*/ NoNullAllowedException();
            /*0x153783c*/ NoNullAllowedException(string s);
        }

        class ReadOnlyException : System.Data.DataException
        {
            /*0x1537860*/ ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1537868*/ ReadOnlyException();
            /*0x15378c4*/ ReadOnlyException(string s);
        }

        class RowNotInTableException : System.Data.DataException
        {
            /*0x15378e8*/ RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x15378f0*/ RowNotInTableException();
            /*0x153794c*/ RowNotInTableException(string s);
        }

        class VersionNotFoundException : System.Data.DataException
        {
            /*0x1537970*/ VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1537978*/ VersionNotFoundException();
            /*0x15379d4*/ VersionNotFoundException(string s);
        }

        class ExceptionBuilder
        {
            static /*0x15379f8*/ void TraceException(string trace, System.Exception e);
            static /*0x1537a90*/ System.Exception TraceExceptionAsReturnValue(System.Exception e);
            static /*0x152fcc0*/ System.Exception TraceExceptionForCapture(System.Exception e);
            static /*0x152ff04*/ System.Exception TraceExceptionWithoutRethrow(System.Exception e);
            static /*0x1537ae0*/ System.Exception _Argument(string error);
            static /*0x1537b44*/ System.Exception _Argument(string error, System.Exception innerException);
            static /*0x1537bb8*/ System.Exception _ArgumentNull(string paramName, string msg);
            static /*0x1537c2c*/ System.Exception _ArgumentOutOfRange(string paramName, string msg);
            static /*0x1537ca0*/ System.Exception _IndexOutOfRange(string error);
            static /*0x1537d04*/ System.Exception _InvalidOperation(string error);
            static /*0x1537d68*/ System.Exception _InvalidEnumArgumentException(string error);
            static System.Exception _InvalidEnumArgumentException<T>(T value);
            static /*0x1537dcc*/ void ThrowDataException(string error, System.Exception innerException);
            static /*0x1537e24*/ System.Exception _Data(string error);
            static /*0x1537e94*/ System.Exception _Constraint(string error);
            static /*0x1537f04*/ System.Exception _InvalidConstraint(string error);
            static /*0x1537f74*/ System.Exception _DeletedRowInaccessible(string error);
            static /*0x1537fe4*/ System.Exception _DuplicateName(string error);
            static /*0x1538054*/ System.Exception _InRowChangingEvent(string error);
            static /*0x15380c4*/ System.Exception _NoNullAllowed(string error);
            static /*0x1538134*/ System.Exception _ReadOnly(string error);
            static /*0x15381a4*/ System.Exception _RowNotInTable(string error);
            static /*0x1538214*/ System.Exception _VersionNotFound(string error);
            static /*0x152972c*/ System.Exception ArgumentNull(string paramName);
            static /*0x1538284*/ System.Exception ArgumentOutOfRange(string paramName);
            static /*0x1528dec*/ System.Exception BadObjectPropertyAccess(string error);
            static /*0x152932c*/ System.Exception CaseInsensitiveNameConflict(string name);
            static /*0x15382d8*/ System.Exception NamespaceNameConflict(string name);
            static /*0x1538324*/ System.Exception InvalidOffsetLength();
            static /*0x1538364*/ System.Exception ColumnNotInTheTable(string column, string table);
            static /*0x15383c0*/ System.Exception ColumnNotInAnyTable();
            static /*0x1534394*/ System.Exception ColumnOutOfRange(int index);
            static /*0x1538400*/ System.Exception ColumnOutOfRange(string column);
            static /*0x15353f4*/ System.Exception CannotAddColumn1(string column);
            static /*0x1535440*/ System.Exception CannotAddColumn2(string column);
            static /*0x15318d8*/ System.Exception CannotAddColumn3();
            static /*0x1531918*/ System.Exception CannotAddColumn4(string column);
            static /*0x15364d0*/ System.Exception CannotAddDuplicate(string column);
            static /*0x1536568*/ System.Exception CannotAddDuplicate2(string table);
            static /*0x153651c*/ System.Exception CannotAddDuplicate3(string table);
            static /*0x1535d7c*/ System.Exception CannotRemoveColumn();
            static /*0x1535dbc*/ System.Exception CannotRemovePrimaryKey();
            static /*0x1535dfc*/ System.Exception CannotRemoveChildKey(string relation);
            static /*0x1535e48*/ System.Exception CannotRemoveConstraint(string constraint, string table);
            static /*0x1535ea4*/ System.Exception CannotRemoveExpression(string column, string expression);
            static /*0x1529a6c*/ System.Exception AddPrimaryKeyConstraint();
            static /*0x1528870*/ System.Exception NoConstraintName();
            static /*0x1528cac*/ System.Exception ConstraintViolation(string constraint);
            static /*0x153844c*/ string KeysToString(object[] keys);
            static /*0x1538574*/ string UniqueConstraintViolationText(System.Data.DataColumn[] columns, object[] values);
            static /*0x15386e0*/ System.Exception ConstraintViolation(System.Data.DataColumn[] columns, object[] values);
            static /*0x1529050*/ System.Exception ConstraintOutOfRange(int index);
            static /*0x1529904*/ System.Exception DuplicateConstraint(string constraint);
            static /*0x152ad14*/ System.Exception DuplicateConstraintName(string constraint);
            static /*0x15386f0*/ System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk);
            static /*0x1529f20*/ System.Exception UniqueConstraintViolation();
            static /*0x1529ee0*/ System.Exception ConstraintForeignTable();
            static /*0x1529f60*/ System.Exception ConstraintParentValues();
            static /*0x1538778*/ System.Exception ConstraintAddFailed(System.Data.DataTable table);
            static /*0x152a4d0*/ System.Exception ConstraintRemoveFailed();
            static /*0x15387cc*/ System.Exception FailedCascadeDelete(string constraint);
            static /*0x1538818*/ System.Exception FailedCascadeUpdate(string constraint);
            static /*0x1538864*/ System.Exception FailedClearParentTable(string table, string constraint, string childTable);
            static /*0x15388c8*/ System.Exception ForeignKeyViolation(string constraint, object[] keys);
            static /*0x1538930*/ System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint);
            static /*0x1532cc4*/ string MaxLengthViolationText(string columnName);
            static /*0x1532e34*/ string NotAllowDBNullViolationText(string columnName);
            static /*0x1529a20*/ System.Exception CantAddConstraintToMultipleNestedTable(string tableName);
            static /*0x152d370*/ System.Exception AutoIncrementAndExpression();
            static /*0x152d3b0*/ System.Exception AutoIncrementAndDefaultValue();
            static /*0x1533610*/ System.Exception AutoIncrementSeed();
            static /*0x152f00c*/ System.Exception CantChangeDataType();
            static /*0x152f04c*/ System.Exception NullDataType();
            static /*0x152e91c*/ System.Exception ColumnNameRequired();
            static /*0x152f9cc*/ System.Exception DefaultValueAndAutoIncrement();
            static /*0x152f624*/ System.Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x152fa0c*/ System.Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x152fb18*/ System.Exception ExpressionAndUnique();
            static /*0x152fd10*/ System.Exception ExpressionAndReadOnly();
            static /*0x152fb58*/ System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint);
            static /*0x1538998*/ System.Exception ExpressionInConstraint(System.Data.DataColumn column);
            static /*0x152fd50*/ System.Exception ExpressionCircular();
            static /*0x1531bb8*/ System.Exception NonUniqueValues(string column);
            static /*0x1531b20*/ System.Exception NullKeyValues(string column);
            static /*0x1531b6c*/ System.Exception NullValues(string column);
            static /*0x1530bd8*/ System.Exception ReadOnlyAndExpression();
            static /*0x15389ec*/ System.Exception ReadOnly(string column);
            static /*0x15315ac*/ System.Exception UniqueAndExpression();
            static /*0x1530f38*/ System.Exception SetFailed(object value, System.Data.DataColumn column, System.Type type, System.Exception innerException);
            static /*0x1538a38*/ System.Exception CannotSetToNull(System.Data.DataColumn column);
            static /*0x1531acc*/ System.Exception LongerThanMaxLength(System.Data.DataColumn column);
            static /*0x1530804*/ System.Exception CannotSetMaxLength(System.Data.DataColumn column, int value);
            static /*0x15303dc*/ System.Exception CannotSetMaxLength2(System.Data.DataColumn column);
            static /*0x152f6fc*/ System.Exception CannotSetSimpleContentType(string columnName, System.Type type);
            static /*0x153187c*/ System.Exception CannotSetSimpleContent(string columnName, System.Type type);
            static /*0x1530a50*/ System.Exception CannotChangeNamespace(string columnName);
            static /*0x1530430*/ System.Exception HasToBeStringType(System.Data.DataColumn column);
            static /*0x152d6dc*/ System.Exception AutoIncrementCannotSetIfHasData(string typeName);
            static /*0x1538a8c*/ System.Exception INullableUDTwithoutStaticNull(string typeName);
            static /*0x1538ad8*/ System.Exception IComparableNotImplemented(string typeName);
            static /*0x1538b24*/ System.Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName);
            static /*0x1538b70*/ System.Exception InvalidDataColumnMapping(System.Type type);
            static /*0x152f88c*/ System.Exception CannotSetDateTimeModeForNonDateTimeColumns();
            static /*0x152f984*/ System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode);
            static /*0x152f8cc*/ System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue);
            static /*0x152c26c*/ System.Exception ColumnTypeNotSupported();
            static /*0x1538bdc*/ System.Exception SetFailed(string name);
            static /*0x1538c28*/ System.Exception CanNotUse();
            static /*0x1538c68*/ System.Exception SetIListObject();
            static /*0x1538ca8*/ System.Exception AddNewNotAllowNull();
            static /*0x1538ce8*/ System.Exception NotOpen();
            static /*0x1538d28*/ System.Exception CreateChildView();
            static /*0x1538d68*/ System.Exception CanNotDelete();
            static /*0x1538da8*/ System.Exception GetElementIndex(int index);
            static /*0x1538e38*/ System.Exception AddExternalObject();
            static /*0x1538e78*/ System.Exception CanNotClear();
            static /*0x1538eb8*/ System.Exception InsertExternalObject();
            static /*0x1538ef8*/ System.Exception RemoveExternalObject();
            static /*0x1538f38*/ System.Exception KeyTableMismatch();
            static /*0x1538f78*/ System.Exception KeyNoColumns();
            static /*0x1538fb8*/ System.Exception KeyTooManyColumns(int cols);
            static /*0x1539048*/ System.Exception KeyDuplicateColumns(string columnName);
            static /*0x1539094*/ System.Exception RelationDataSetMismatch();
            static /*0x152f1d0*/ System.Exception ColumnsTypeMismatch();
            static /*0x15390d4*/ System.Exception KeyLengthMismatch();
            static /*0x1539114*/ System.Exception KeyLengthZero();
            static /*0x1539154*/ System.Exception ForeignRelation();
            static /*0x1539194*/ System.Exception KeyColumnsIdentical();
            static /*0x15391d4*/ System.Exception RelationForeignTable(string t1, string t2);
            static /*0x1539230*/ System.Exception GetParentRowTableMismatch(string t1, string t2);
            static /*0x153928c*/ System.Exception SetParentRowTableMismatch(string t1, string t2);
            static /*0x15392e8*/ System.Exception RelationForeignRow();
            static /*0x1539328*/ System.Exception RelationNestedReadOnly();
            static /*0x1539368*/ System.Exception TableCantBeNestedInTwoTables(string tableName);
            static /*0x15393b4*/ System.Exception LoopInNestedRelations(string tableName);
            static /*0x1539400*/ System.Exception RelationDoesNotExist();
            static /*0x1539440*/ System.Exception ParentOrChildColumnsDoNotHaveDataSet();
            static /*0x1539480*/ System.Exception InValidNestedRelation(string childTableName);
            static /*0x15394cc*/ System.Exception InvalidParentNamespaceinNestedRelation(string childTableName);
            static /*0x1539518*/ System.Exception RowNotInTheDataSet();
            static /*0x1539558*/ System.Exception RowNotInTheTable();
            static /*0x1539598*/ System.Exception EditInRowChanging();
            static /*0x15395d8*/ System.Exception EndEditInRowChanging();
            static /*0x1539618*/ System.Exception BeginEditInRowChanging();
            static /*0x1539658*/ System.Exception CancelEditInRowChanging();
            static /*0x1539698*/ System.Exception DeleteInRowDeleting();
            static /*0x15396d8*/ System.Exception ValueArrayLength();
            static /*0x1539718*/ System.Exception NoCurrentData();
            static /*0x1539758*/ System.Exception NoOriginalData();
            static /*0x1539798*/ System.Exception NoProposedData();
            static /*0x15397d8*/ System.Exception RowRemovedFromTheTable();
            static /*0x1539818*/ System.Exception DeletedRowInaccessible();
            static /*0x1539858*/ System.Exception RowAlreadyDeleted();
            static /*0x1539898*/ System.Exception RowEmpty();
            static /*0x15398d8*/ System.Exception InvalidRowVersion();
            static /*0x1539918*/ System.Exception RowOutOfRange(int index);
            static /*0x15399a8*/ System.Exception RowInsertTwice(int index, string tableName);
            static /*0x1539a48*/ System.Exception RowInsertMissing(string tableName);
            static /*0x1539a94*/ System.Exception RowAlreadyRemoved();
            static /*0x1539ad4*/ System.Exception MultipleParents();
            static /*0x1539b14*/ System.Exception InvalidRowState(System.Data.DataRowState state);
            static /*0x1539b5c*/ System.Exception InvalidRowBitPattern();
            static /*0x1539b9c*/ System.Exception SetDataSetNameToEmpty();
            static /*0x1539bdc*/ System.Exception SetDataSetNameConflicting(string name);
            static /*0x1539c28*/ System.Exception DataSetUnsupportedSchema(string ns);
            static /*0x1539c74*/ System.Exception MergeMissingDefinition(string obj);
            static /*0x1539cc0*/ System.Exception TablesInDifferentSets();
            static /*0x1539d00*/ System.Exception RelationAlreadyExists();
            static /*0x1539d40*/ System.Exception RowAlreadyInOtherCollection();
            static /*0x1539d80*/ System.Exception RowAlreadyInTheCollection();
            static /*0x1539dc0*/ System.Exception RecordStateRange();
            static /*0x1539e00*/ System.Exception IndexKeyLength(int length, int keyLength);
            static /*0x1539edc*/ System.Exception RemovePrimaryKey(System.Data.DataTable table);
            static /*0x1539f58*/ System.Exception RelationAlreadyInOtherDataSet();
            static /*0x1539f98*/ System.Exception RelationAlreadyInTheDataSet();
            static /*0x1539fd8*/ System.Exception RelationNotInTheDataSet(string relation);
            static /*0x153a024*/ System.Exception RelationOutOfRange(object index);
            static /*0x153a0a8*/ System.Exception DuplicateRelation(string relation);
            static /*0x153a0f4*/ System.Exception RelationTableNull();
            static /*0x153a134*/ System.Exception RelationDataSetNull();
            static /*0x153a174*/ System.Exception RelationTableWasRemoved();
            static /*0x153a1b4*/ System.Exception ParentTableMismatch();
            static /*0x153a1f4*/ System.Exception ChildTableMismatch();
            static /*0x153a234*/ System.Exception EnforceConstraint();
            static /*0x153a274*/ System.Exception CaseLocaleMismatch();
            static /*0x153a2b4*/ System.Exception CannotChangeCaseLocale();
            static /*0x153a2bc*/ System.Exception CannotChangeCaseLocale(System.Exception innerException);
            static /*0x153a304*/ System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode);
            static /*0x153a34c*/ System.Exception TableForeignPrimaryKey();
            static /*0x153a38c*/ System.Exception TableCannotAddToSimpleContent();
            static /*0x153a3cc*/ System.Exception NoTableName();
            static /*0x153a40c*/ System.Exception MultipleTextOnlyColumns();
            static /*0x153a44c*/ System.Exception InvalidSortString(string sort);
            static /*0x153a498*/ System.Exception DuplicateTableName(string table);
            static /*0x153a4e4*/ System.Exception DuplicateTableName2(string table, string ns);
            static /*0x153a540*/ System.Exception SelfnestedDatasetConflictingName(string table);
            static /*0x153a58c*/ System.Exception DatasetConflictingName(string table);
            static /*0x153a5d8*/ System.Exception TableAlreadyInOtherDataSet();
            static /*0x153a618*/ System.Exception TableAlreadyInTheDataSet();
            static /*0x153a658*/ System.Exception TableOutOfRange(int index);
            static /*0x153a6e8*/ System.Exception TableNotInTheDataSet(string table);
            static /*0x153a734*/ System.Exception TableInRelation();
            static /*0x153a774*/ System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint);
            static /*0x153a7ec*/ System.Exception CanNotSerializeDataTableHierarchy();
            static /*0x153a82c*/ System.Exception CanNotRemoteDataTable();
            static /*0x153a86c*/ System.Exception CanNotSetRemotingFormat();
            static /*0x153a8ac*/ System.Exception CanNotSerializeDataTableWithEmptyName();
            static /*0x153a8ec*/ System.Exception TableNotFound(string tableName);
            static /*0x153a938*/ System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type);
            static /*0x153a9f0*/ System.Exception InvalidStorageType(System.TypeCode typecode);
            static /*0x153aa84*/ System.Exception RangeArgument(int min, int max);
            static /*0x153ab34*/ System.Exception NullRange();
            static /*0x153ab74*/ System.Exception NegativeMinimumCapacity();
            static /*0x153abb4*/ System.Exception ProblematicChars(char charValue);
            static /*0x153ac90*/ System.Exception StorageSetFailed();
            static /*0x153acd0*/ System.Exception SimpleTypeNotSupported();
            static /*0x153ad10*/ System.Exception MissingAttribute(string attribute);
            static /*0x153ad60*/ System.Exception MissingAttribute(string element, string attribute);
            static /*0x153adbc*/ System.Exception InvalidAttributeValue(string name, string value);
            static /*0x153ae18*/ System.Exception AttributeValues(string name, string value1, string value2);
            static /*0x153ae7c*/ System.Exception ElementTypeNotFound(string name);
            static /*0x153aec8*/ System.Exception RelationParentNameMissing(string rel);
            static /*0x153af14*/ System.Exception RelationChildNameMissing(string rel);
            static /*0x153af60*/ System.Exception RelationTableKeyMissing(string rel);
            static /*0x153afac*/ System.Exception RelationChildKeyMissing(string rel);
            static /*0x153aff8*/ System.Exception UndefinedDatatype(string name);
            static /*0x153b044*/ System.Exception DatatypeNotDefined();
            static /*0x153b084*/ System.Exception MismatchKeyLength();
            static /*0x153b0c4*/ System.Exception InvalidField(string name);
            static /*0x153b110*/ System.Exception InvalidSelector(string name);
            static /*0x153b15c*/ System.Exception CircularComplexType(string name);
            static /*0x153b1a8*/ System.Exception CannotInstantiateAbstract(string name);
            static /*0x153b1f4*/ System.Exception InvalidKey(string name);
            static /*0x153b240*/ System.Exception DiffgramMissingTable(string name);
            static /*0x153b28c*/ System.Exception DiffgramMissingSQL();
            static /*0x153b2cc*/ System.Exception DuplicateConstraintRead(string str);
            static /*0x153b318*/ System.Exception ColumnTypeConflict(string name);
            static /*0x153b364*/ System.Exception CannotConvert(string name, string type);
            static /*0x153b3c0*/ System.Exception MissingRefer(string name);
            static /*0x152ee7c*/ System.Exception InvalidPrefix(string name);
            static /*0x153b444*/ System.Exception CanNotDeserializeObjectType();
            static /*0x153b484*/ System.Exception IsDataSetAttributeMissingInSchema();
            static /*0x153b4c4*/ System.Exception TooManyIsDataSetAtributeInSchema();
            static /*0x153b504*/ System.Exception NestedCircular(string name);
            static /*0x153b550*/ System.Exception MultipleParentRows(string tableQName);
            static /*0x153b59c*/ System.Exception PolymorphismNotSupported(string typeName);
            static /*0x153b5e8*/ System.Exception DataTableInferenceNotSupported();
            static /*0x153b628*/ void ThrowMultipleTargetConverter(System.Exception innerException);
            static /*0x153b688*/ System.Exception DuplicateDeclaration(string name);
            static /*0x153b6d4*/ System.Exception FoundEntity();
            static /*0x153b714*/ System.Exception MergeFailed(string name);
            static /*0x153b718*/ System.Exception ConvertFailed(System.Type type1, System.Type type2);
            static /*0x153b7a8*/ System.Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr);
            static /*0x153b804*/ System.Exception InternalRBTreeError(System.Data.RBTreeError internalError);
            static /*0x153b884*/ System.Exception EnumeratorModified();
        }

        struct DataKey
        {
            /*0x10*/ System.Data.DataColumn[] _columns;

            static /*0x153bb64*/ bool ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2);
            /*0x153b8c4*/ DataKey(System.Data.DataColumn[] columns, bool copyColumns);
            /*0x153bb44*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x153bb4c*/ bool get_HasValue();
            /*0x152b8f0*/ System.Data.DataTable get_Table();
            /*0x153bab4*/ void CheckState();
            /*0x153bb5c*/ bool ColumnsEqual(System.Data.DataKey key);
            /*0x15326fc*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x153bc64*/ int GetHashCode();
            /*0x153bcc8*/ bool Equals(object value);
            /*0x153bd40*/ bool Equals(System.Data.DataKey value);
            /*0x153bdf0*/ string[] GetColumnNames();
            /*0x153bed0*/ System.Data.IndexField[] GetIndexDesc();
            /*0x153bfa8*/ object[] GetKeyValues(int record);
            /*0x153c0ac*/ System.Data.Index GetSortIndex();
            /*0x153c0b4*/ System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates);
            /*0x153c10c*/ bool RecordsEqual(int record1, int record2);
            /*0x153c1a0*/ System.Data.DataColumn[] ToArray();
        }

        class DataRelation
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.PropertyCollection _extendedProperties;
            /*0x20*/ string _relationName;
            /*0x28*/ System.Data.DataKey _childKey;
            /*0x30*/ System.Data.DataKey _parentKey;
            /*0x38*/ System.Data.UniqueConstraint _parentKeyConstraint;
            /*0x40*/ System.Data.ForeignKeyConstraint _childKeyConstraint;
            /*0x48*/ string[] _parentColumnNames;
            /*0x50*/ string[] _childColumnNames;
            /*0x58*/ string _parentTableName;
            /*0x60*/ string _childTableName;
            /*0x68*/ string _parentTableNamespace;
            /*0x70*/ string _childTableNamespace;
            /*0x78*/ bool _nested;
            /*0x79*/ bool _createConstraints;
            /*0x7a*/ bool _checkMultipleNested;
            /*0x7c*/ int _objectID;
            /*0x80*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;

            static /*0x153cb4c*/ bool IsKeyNull(object[] values);
            static /*0x153cc00*/ System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version);
            static /*0x153cc8c*/ System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            static /*0x153cd10*/ System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            /*0x153c278*/ DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints);
            /*0x153c764*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x153c76c*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x153c834*/ DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x153c908*/ DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x153c9f4*/ System.Data.DataColumn[] get_ChildColumns();
            /*0x153caf4*/ System.Data.DataColumn[] get_ChildColumnsReference();
            /*0x15326e4*/ System.Data.DataKey get_ChildKey();
            /*0x153cb0c*/ System.Data.DataTable get_ChildTable();
            /*0x153cb24*/ System.Data.DataSet get_DataSet();
            /*0x153cb3c*/ string[] get_ParentColumnNames();
            /*0x153cb44*/ string[] get_ChildColumnNames();
            /*0x153ce64*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x153ce78*/ System.Data.DataColumn[] get_ParentColumns();
            /*0x153ce90*/ System.Data.DataColumn[] get_ParentColumnsReference();
            /*0x1532758*/ System.Data.DataKey get_ParentKey();
            /*0x153ce98*/ System.Data.DataTable get_ParentTable();
            /*0x153ceb0*/ string get_RelationName();
            /*0x153cec8*/ void CheckNamespaceValidityForNestedRelations(string ns);
            /*0x153d26c*/ void CheckNestedRelations();
            /*0x153d67c*/ bool get_Nested();
            /*0x153d694*/ void set_Nested(bool value);
            /*0x153ec30*/ System.Data.UniqueConstraint get_ParentKeyConstraint();
            /*0x153ec48*/ void SetParentKeyConstraint(System.Data.UniqueConstraint value);
            /*0x153ec50*/ System.Data.ForeignKeyConstraint get_ChildKeyConstraint();
            /*0x153ec68*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x153ecd4*/ bool get_CheckMultipleNested();
            /*0x153ecdc*/ void set_CheckMultipleNested(bool value);
            /*0x153ece8*/ void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value);
            /*0x153ecf0*/ void CheckState();
            /*0x153ca0c*/ void CheckStateForProperty();
            /*0x153c470*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x153ef0c*/ System.Data.DataRelation Clone(System.Data.DataSet destination);
            /*0x153f560*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x153ebbc*/ void RaisePropertyChanging(string name);
            /*0x153f630*/ string ToString();
            /*0x153e700*/ void ValidateMultipleNestedRelations();
            /*0x153f63c*/ bool IsAutoGenerated(System.Data.DataColumn col);
            /*0x153f810*/ int get_ObjectID();
        }

        class DataRelationCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataRelation _inTransition;
            /*0x18*/ int _defaultNameIndex;
            /*0x20*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x30*/ int _objectID;

            /*0xfa2520*/ DataRelationCollection();
            /*0xfa1080*/ int get_ObjectID();
            System.Data.DataRelation get_Item(int index);
            System.Data.DataRelation get_Item(string name);
            /*0xfa1088*/ void Add(System.Data.DataRelation relation);
            /*0xfa1320*/ void AddCore(System.Data.DataRelation relation);
            /*0xfa15d0*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0xfa16c8*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0xfa17c0*/ string AssignName();
            /*0xfa189c*/ void Clear();
            /*0xfa1ad8*/ bool Contains(string name);
            /*0xfa1af0*/ int InternalIndexOf(string name);
            System.Data.DataSet GetDataSet();
            /*0xfa17e4*/ string MakeName(int index);
            /*0xfa1c70*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0xfa1d40*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0xfa1e10*/ void RegisterName(string name);
            /*0xfa1fd4*/ void Remove(System.Data.DataRelation relation);
            /*0xfa2198*/ void RemoveAt(int index);
            /*0xfa220c*/ void RemoveCore(System.Data.DataRelation relation);
            /*0xfa23f4*/ void UnregisterName(string name);

            class DataTableRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataTable _table;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ bool _fParentCollection;
                /*0x50*/ System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;

                /*0xfa25b0*/ DataTableRelationCollection(System.Data.DataTable table, bool fParentCollection);
                /*0xfa265c*/ System.Collections.ArrayList get_List();
                /*0xfa2664*/ void EnsureDataSet();
                /*0xfa26a8*/ System.Data.DataSet GetDataSet();
                /*0xfa26cc*/ System.Data.DataRelation get_Item(int index);
                /*0xfa27cc*/ System.Data.DataRelation get_Item(string name);
                /*0xfa28b8*/ void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0xfa2954*/ void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0xfa29f0*/ void AddCache(System.Data.DataRelation relation);
                /*0xfa2a38*/ void AddCore(System.Data.DataRelation relation);
                /*0xfa2af8*/ void RemoveCache(System.Data.DataRelation relation);
                /*0xfa2bcc*/ void RemoveCore(System.Data.DataRelation relation);
            }

            class DataSetRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataSet _dataSet;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ System.Data.DataRelation[] _delayLoadingRelations;

                /*0xfa2c8c*/ DataSetRelationCollection(System.Data.DataSet dataSet);
                /*0xfa2d24*/ System.Collections.ArrayList get_List();
                /*0xfa2d2c*/ void Clear();
                /*0xfa2d60*/ System.Data.DataSet GetDataSet();
                /*0xfa2d68*/ System.Data.DataRelation get_Item(int index);
                /*0xfa2e68*/ System.Data.DataRelation get_Item(string name);
                /*0xfa2f54*/ void AddCore(System.Data.DataRelation relation);
                /*0xfa34c8*/ void RemoveCore(System.Data.DataRelation relation);
            }
        }

        class DataRelationPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataRelation <Relation>k__BackingField;

            /*0xfa3718*/ DataRelationPropertyDescriptor(System.Data.DataRelation dataRelation);
            /*0xfa3764*/ System.Data.DataRelation get_Relation();
            /*0xfa376c*/ System.Type get_ComponentType();
            /*0xfa37d8*/ bool get_IsReadOnly();
            /*0xfa37e0*/ System.Type get_PropertyType();
            /*0xfa384c*/ bool Equals(object other);
            /*0xfa38bc*/ int GetHashCode();
            /*0xfa38dc*/ bool CanResetValue(object component);
            /*0xfa38e4*/ object GetValue(object component);
            /*0xfa3978*/ void ResetValue(object component);
            /*0xfa397c*/ void SetValue(object component, object value);
            /*0xfa3980*/ bool ShouldSerializeValue(object component);
        }

        class DataRow
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataColumnCollection _columns;
            /*0x20*/ int _oldRecord;
            /*0x24*/ int _newRecord;
            /*0x28*/ int _tempRecord;
            /*0x30*/ long _rowID;
            /*0x38*/ System.Data.DataRowAction _action;
            /*0x3c*/ bool _inChangingEvent;
            /*0x3d*/ bool _inDeletingEvent;
            /*0x3e*/ bool _inCascade;
            /*0x40*/ System.Data.DataColumn _lastChangedColumn;
            /*0x48*/ int _countColumnChange;
            /*0x50*/ System.Data.DataError _error;
            /*0x58*/ int _rbTreeNodeId;
            /*0x5c*/ int _objectID;

            /*0xfa3988*/ DataRow(System.Data.DataRowBuilder builder);
            /*0xfa3a28*/ System.Data.DataColumn get_LastChangedColumn();
            /*0xfa3a44*/ void set_LastChangedColumn(System.Data.DataColumn value);
            /*0xfa3a58*/ bool get_HasPropertyChanged();
            /*0xfa3a68*/ int get_RBTreeNodeId();
            /*0xfa3a70*/ void set_RBTreeNodeId(int value);
            /*0xfa3b20*/ string get_RowError();
            /*0xfa3b7c*/ void set_RowError(string value);
            /*0xfa3cb4*/ void RowErrorChanged();
            /*0xfa3d04*/ long get_rowID();
            /*0xfa3d0c*/ void set_rowID(long value);
            /*0xfa3d28*/ System.Data.DataRowState get_RowState();
            /*0xfa3f4c*/ System.Data.DataTable get_Table();
            /*0xfa3f54*/ void CheckForLoops(System.Data.DataRelation rel);
            /*0xfa4030*/ int GetNestedParentCount();
            /*0xfa40f8*/ void set_Item(string columnName, object value);
            /*0xfa3f10*/ object get_Item(System.Data.DataColumn column);
            /*0xfa4190*/ void set_Item(System.Data.DataColumn column, object value);
            /*0xfa47ac*/ object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version);
            /*0xfa4850*/ void set_ItemArray(object[] value);
            /*0xfa4c10*/ void AcceptChanges();
            /*0xfa4f88*/ void BeginEdit();
            /*0xfa4578*/ bool BeginEditInternal();
            /*0xfa4674*/ void CancelEdit();
            /*0xfa4488*/ void CheckColumn(System.Data.DataColumn column);
            /*0xfa4f8c*/ void CheckInTable();
            /*0xfa4fc8*/ void Delete();
            /*0xfa46d0*/ void EndEdit();
            /*0xfa5028*/ void SetColumnError(int columnIndex, string error);
            /*0xfa5090*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0xfa529c*/ string GetColumnError(System.Data.DataColumn column);
            /*0xfa5320*/ void ClearErrors();
            /*0xfa534c*/ void ClearError(System.Data.DataColumn column);
            /*0xfa5378*/ bool get_HasErrors();
            /*0xfa538c*/ System.Data.DataColumn[] GetColumnsInError();
            /*0xfa5424*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation);
            /*0xfa542c*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0xfa4124*/ System.Data.DataColumn GetDataColumn(string columnName);
            /*0xfa4028*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation);
            /*0xfa5558*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0xfa5674*/ System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version);
            /*0xfa5730*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation);
            /*0xfa5738*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0xfa5864*/ object[] GetColumnValues(System.Data.DataColumn[] columns);
            /*0xfa586c*/ object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version);
            /*0xfa58ec*/ object[] GetKeyValues(System.Data.DataKey key);
            /*0xfa58c4*/ object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version);
            /*0xfa5910*/ int GetCurrentRecordNo();
            /*0xfa4514*/ int GetDefaultRecord();
            /*0xfa594c*/ int GetOriginalRecordNo();
            /*0xfa4638*/ int GetProposedRecordNo();
            /*0xfa47f0*/ int GetRecordFromVersion(System.Data.DataRowVersion version);
            /*0xfa5988*/ System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState);
            /*0xfa59c4*/ System.Data.DataViewRowState GetRecordState(int record);
            /*0xfa5a1c*/ bool HasKeyChanged(System.Data.DataKey key);
            /*0xfa5a28*/ bool HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0xfa5ab0*/ bool HasVersion(System.Data.DataRowVersion version);
            /*0xfa5b3c*/ bool HaveValuesChanged(System.Data.DataColumn[] columns);
            /*0xfa5b48*/ bool HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0xfa5bf4*/ void RejectChanges();
            /*0xfa3d1c*/ void ResetLastChangedColumn();
            /*0xfa61d8*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues);
            /*0xfa62f0*/ void SetNestedParentRow(System.Data.DataRow parentRow, bool setNonNested);
            /*0xfa66f0*/ void SetParentRowToDBNull();
            /*0xfa69d4*/ void SetParentRowToDBNull(System.Data.DataRelation relation);
            /*0xfa6b54*/ int CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, int storeIndex);
        }

        class DataRowBuilder
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _record;

            /*0xfa6e4c*/ DataRowBuilder(System.Data.DataTable table, int record);
        }

        enum DataRowAction
        {
            Nothing = 0,
            Delete = 1,
            Change = 2,
            Rollback = 4,
            Commit = 8,
            Add = 16,
            ChangeOriginal = 32,
            ChangeCurrentAndOriginal = 64,
        }

        class DataRowChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;
            /*0x18*/ System.Data.DataRowAction <Action>k__BackingField;

            /*0xfa6e7c*/ DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action);
        }

        class DataRowChangeEventHandler : System.MulticastDelegate
        {
            /*0xfa6ef0*/ DataRowChangeEventHandler(object object, nint method);
            /*0xfa7020*/ void Invoke(object sender, System.Data.DataRowChangeEventArgs e);
        }

        class DataRowCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataRowCollection.DataRowTree _list;
            /*0x20*/ int _nullInList;

            /*0xfa7034*/ DataRowCollection(System.Data.DataTable table);
            /*0xfa711c*/ int get_Count();
            /*0xfa716c*/ System.Data.DataRow get_Item(int index);
            /*0xfa71c4*/ void Add(System.Data.DataRow row);
            /*0xfa71e4*/ void DiffInsertAt(System.Data.DataRow row, int pos);
            /*0xfa73f4*/ int IndexOf(System.Data.DataRow row);
            /*0xfa748c*/ System.Data.DataRow AddWithColumnEvents(object[] values);
            /*0xfa74ec*/ void ArrayAdd(System.Data.DataRow row);
            /*0xfa7554*/ void ArrayInsert(System.Data.DataRow row, int pos);
            /*0xfa75cc*/ void ArrayClear();
            /*0xfa761c*/ void ArrayRemove(System.Data.DataRow row);
            /*0xfa76b0*/ void CopyTo(System.Array ar, int index);
            /*0xfa7718*/ void CopyTo(System.Data.DataRow[] array, int index);
            /*0xfa7780*/ System.Collections.IEnumerator GetEnumerator();

            class DataRowTree : System.Data.RBTree<System.Data.DataRow>
            {
                /*0xfa70d0*/ DataRowTree();
                /*0xfa77d0*/ int CompareNode(System.Data.DataRow record1, System.Data.DataRow record2);
                /*0xfa77fc*/ int CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2);
            }
        }

        class DataRowCreatedEventHandler : System.MulticastDelegate
        {
            /*0xfa7828*/ DataRowCreatedEventHandler(object object, nint method);
            /*0xfa7958*/ void Invoke(object sender, System.Data.DataRow r);
        }

        class DataSetClearEventhandler : System.MulticastDelegate
        {
            /*0xfa796c*/ DataSetClearEventhandler(object object, nint method);
            /*0xfa7a9c*/ void Invoke(object sender, System.Data.DataTable table);
        }

        enum DataRowState
        {
            Detached = 1,
            Unchanged = 2,
            Added = 4,
            Deleted = 8,
            Modified = 16,
        }

        enum DataRowVersion
        {
            Original = 256,
            Current = 512,
            Proposed = 1024,
            Default = 1536,
        }

        class DataRowView : System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanged
        {
            static /*0x0*/ System.ComponentModel.PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;
            /*0x10*/ System.Data.DataView _dataView;
            /*0x18*/ System.Data.DataRow _row;
            /*0x20*/ bool _delayBeginEdit;
            /*0x28*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            static /*0xfa8568*/ DataRowView();
            /*0xfa7ab0*/ DataRowView(System.Data.DataView dataView, System.Data.DataRow row);
            /*0xfa7adc*/ bool Equals(object other);
            /*0xfa7ae8*/ int GetHashCode();
            /*0xfa7b08*/ System.Data.DataView get_DataView();
            /*0xfa7b10*/ System.Data.DataRowVersion get_RowVersionDefault();
            /*0xfa7b68*/ int GetRecord();
            /*0xfa7b8c*/ bool HasRecord();
            /*0xfa7bb0*/ object GetColumnValue(System.Data.DataColumn column);
            /*0xfa7be4*/ void SetColumnValue(System.Data.DataColumn column, object value);
            /*0xfa7c70*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent);
            /*0xfa3970*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation);
            /*0xfa8048*/ System.Data.DataRow get_Row();
            /*0xfa8050*/ void EndEdit();
            /*0xfa8098*/ bool get_IsNew();
            /*0xfa8258*/ void RaisePropertyChangedEvent(string propName);
            /*0xfa82f0*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
            /*0xfa8350*/ string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
            /*0xfa8358*/ string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
            /*0xfa8360*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
            /*0xfa8368*/ System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
            /*0xfa8370*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
            /*0xfa8378*/ object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType);
            /*0xfa8380*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
            /*0xfa83e0*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes);
            /*0xfa8440*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
            /*0xfa84dc*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
            /*0xfa8564*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        enum SerializationFormat
        {
            Xml = 0,
            Binary = 1,
        }

        class DataSet : System.ComponentModel.MarshalByValueComponent, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ int s_objectTypeCount;
            static /*0x8*/ System.Xml.Schema.XmlSchemaComplexType s_schemaTypeForWSDL;
            /*0x20*/ System.Data.DataViewManager _defaultViewManager;
            /*0x28*/ System.Data.DataTableCollection _tableCollection;
            /*0x30*/ System.Data.DataRelationCollection _relationCollection;
            /*0x38*/ System.Data.PropertyCollection _extendedProperties;
            /*0x40*/ string _dataSetName;
            /*0x48*/ string _datasetPrefix;
            /*0x50*/ string _namespaceURI;
            /*0x58*/ bool _enforceConstraints;
            /*0x59*/ bool _caseSensitive;
            /*0x60*/ System.Globalization.CultureInfo _culture;
            /*0x68*/ bool _cultureUserSet;
            /*0x69*/ bool _fInReadXml;
            /*0x6a*/ bool _fInLoadDiffgram;
            /*0x6b*/ bool _fTopLevelTable;
            /*0x6c*/ bool _fInitInProgress;
            /*0x6d*/ bool _fEnableCascading;
            /*0x6e*/ bool _fIsSchemaLoading;
            /*0x70*/ string _mainTableName;
            /*0x78*/ System.Data.SerializationFormat _remotingFormat;
            /*0x80*/ object _defaultViewManagerLock;
            /*0x88*/ int _objectID;
            /*0x8c*/ bool _useDataSetSchemaOnly;
            /*0x8d*/ bool _udtIsWrapped;
            /*0x90*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;
            /*0x98*/ System.Data.MergeFailedEventHandler MergeFailed;
            /*0xa0*/ System.Data.DataRowCreatedEventHandler DataRowCreated;
            /*0xa8*/ System.Data.DataSetClearEventhandler ClearFunctionCalled;

            static /*0xfb0494*/ void MoveToElement(System.Xml.XmlReader reader);
            static /*0xfb4f54*/ System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0xfa85e4*/ DataSet();
            /*0xfa8974*/ DataSet(string dataSetName);
            /*0xfa8cc0*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfa8cc8*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema);
            /*0xfa8ae0*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0xfa8ae8*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0xfa8cb8*/ System.Data.SchemaSerializationMode get_SchemaSerializationMode();
            /*0xfa8f08*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfa9530*/ void InitializeDerivedDataSet();
            /*0xfa8f10*/ void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0xfa8ec0*/ void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0xfaa230*/ void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0xfaa71c*/ void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0xfa9534*/ void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfaa8f4*/ void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfa96a4*/ void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfaae5c*/ void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xfac10c*/ void FailedEnableConstraints();
            /*0xfac2c8*/ bool get_CaseSensitive();
            /*0xfac2d0*/ void set_CaseSensitive(bool value);
            /*0xfac9f0*/ bool get_EnforceConstraints();
            /*0xfac13c*/ void set_EnforceConstraints(bool value);
            /*0xfad1b0*/ void RestoreEnforceConstraints(bool value);
            /*0xfac9f8*/ void EnableConstraints();
            /*0xfad1bc*/ string get_DataSetName();
            /*0xfa899c*/ void set_DataSetName(string value);
            /*0xfad34c*/ string get_Namespace();
            /*0xfad354*/ void set_Namespace(string value);
            /*0xfad980*/ string get_Prefix();
            /*0xfad988*/ void set_Prefix(string value);
            /*0xfabfbc*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0xfadaa8*/ System.Globalization.CultureInfo get_Locale();
            /*0xfadab0*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0xfadc50*/ void SetLocaleValue(System.Globalization.CultureInfo value, bool userSet);
            /*0xfae840*/ bool ShouldSerializeLocale();
            /*0xfae848*/ System.ComponentModel.ISite get_Site();
            /*0xfae850*/ System.Data.DataRelationCollection get_Relations();
            /*0xfae858*/ System.Data.DataTableCollection get_Tables();
            /*0xfae860*/ void Clear();
            /*0xfaea90*/ System.Data.DataSet Clone();
            /*0xfa9ef4*/ int EstimatedXmlStringSize();
            /*0xfafac0*/ string GetRemotingDiffGram(System.Data.DataTable table);
            /*0xfa9d5c*/ string GetXmlSchemaForRemoting(System.Data.DataTable table);
            /*0xfafbf0*/ void ReadXmlSchema(System.Xml.XmlReader reader);
            /*0xfab6cc*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0xfafff4*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0xfb00a8*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0xfafd50*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0xfafbf8*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0xfb050c*/ void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type, string> multipleTargetConverter);
            /*0xfb0760*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader);
            /*0xfb0768*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, bool denyResolving);
            /*0xfb013c*/ void InferSchema(System.Xml.XmlDocument xdoc, string[] excludedNamespaces, System.Data.XmlReadMode mode);
            /*0xfb2c74*/ bool IsEmpty();
            /*0xfb1910*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0xfabfb4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode);
            /*0xfb30f8*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0xfaa00c*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode);
            /*0xfb2f74*/ void Merge(System.Data.DataSet dataSet);
            /*0xfb3f34*/ void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0xfb419c*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0xfb41c4*/ void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent);
            /*0xfb4224*/ void RaiseMergeFailed(System.Data.DataTable table, string conflict, System.Data.MissingSchemaAction missingSchemaAction);
            /*0xfb42d4*/ void OnDataRowCreated(System.Data.DataRow row);
            /*0xfaea68*/ void OnClearFunctionCalled(System.Data.DataTable table);
            /*0xfb42fc*/ void OnRemoveTable(System.Data.DataTable table);
            /*0xfb4300*/ void OnRemovedTable(System.Data.DataTable table);
            /*0xfb432c*/ void OnRemoveRelation(System.Data.DataRelation relation);
            /*0xfa3708*/ void OnRemoveRelationHack(System.Data.DataRelation relation);
            /*0xfad2cc*/ void RaisePropertyChanging(string name);
            /*0xfb4330*/ System.Data.DataTable[] TopLevelTables();
            /*0xfb4338*/ System.Data.DataTable[] TopLevelTables(bool forSchema);
            /*0xfb4608*/ void Reset();
            /*0xfac5f4*/ bool ValidateCaseConstraint();
            /*0xfae3ec*/ bool ValidateLocaleConstraint();
            /*0xfb4b80*/ System.Data.DataTable FindTable(System.Data.DataTable baseTable, System.ComponentModel.PropertyDescriptor[] props, int propStart);
            /*0xfb4c78*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0xfb51ac*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0xfb5384*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0xfb55d4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0xfb5608*/ string get_MainTableName();
            /*0xfb5610*/ void set_MainTableName(string value);
            /*0xfb5618*/ int get_ObjectID();
        }

        enum DataSetDateTime
        {
            Local = 1,
            Unspecified = 2,
            UnspecifiedLocal = 3,
            Utc = 4,
        }

        class DataTable : System.ComponentModel.MarshalByValueComponent, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ System.Data.DataView _defaultView;
            /*0x30*/ long _nextRowID;
            /*0x38*/ System.Data.DataRowCollection _rowCollection;
            /*0x40*/ System.Data.DataColumnCollection _columnCollection;
            /*0x48*/ System.Data.ConstraintCollection _constraintCollection;
            /*0x50*/ int _elementColumnCount;
            /*0x58*/ System.Data.DataRelationCollection _parentRelationsCollection;
            /*0x60*/ System.Data.DataRelationCollection _childRelationsCollection;
            /*0x68*/ System.Data.RecordManager _recordManager;
            /*0x70*/ System.Collections.Generic.List<System.Data.Index> _indexes;
            /*0x78*/ System.Collections.Generic.List<System.Data.Index> _shadowIndexes;
            /*0x80*/ int _shadowCount;
            /*0x88*/ System.Data.PropertyCollection _extendedProperties;
            /*0x90*/ string _tableName;
            /*0x98*/ string _tableNamespace;
            /*0xa0*/ string _tablePrefix;
            /*0xa8*/ System.Data.DataExpression _displayExpression;
            /*0xb0*/ bool _fNestedInDataset;
            /*0xb8*/ System.Globalization.CultureInfo _culture;
            /*0xc0*/ bool _cultureUserSet;
            /*0xc8*/ System.Globalization.CompareInfo _compareInfo;
            /*0xd0*/ System.Globalization.CompareOptions _compareFlags;
            /*0xd8*/ System.IFormatProvider _formatProvider;
            /*0xe0*/ System.StringComparer _hashCodeProvider;
            /*0xe8*/ bool _caseSensitive;
            /*0xe9*/ bool _caseSensitiveUserSet;
            /*0xf0*/ string _encodedTableName;
            /*0xf8*/ System.Data.DataColumn _xmlText;
            /*0x100*/ System.Data.DataColumn _colUnique;
            /*0x108*/ decimal _minOccurs;
            /*0x118*/ decimal _maxOccurs;
            /*0x128*/ bool _repeatableElement;
            /*0x130*/ object _typeName;
            /*0x138*/ System.Data.UniqueConstraint _primaryKey;
            /*0x140*/ System.Data.IndexField[] _primaryIndex;
            /*0x148*/ System.Data.DataColumn[] _delayedSetPrimaryKey;
            /*0x150*/ System.Data.Index _loadIndex;
            /*0x158*/ System.Data.Index _loadIndexwithOriginalAdded;
            /*0x160*/ System.Data.Index _loadIndexwithCurrentDeleted;
            /*0x168*/ int _suspendIndexEvents;
            /*0x16c*/ bool _inDataLoad;
            /*0x16d*/ bool _schemaLoading;
            /*0x16e*/ bool _enforceConstraints;
            /*0x16f*/ bool _suspendEnforceConstraints;
            /*0x170*/ bool fInitInProgress;
            /*0x171*/ bool _inLoad;
            /*0x172*/ bool _fInLoadDiffgram;
            /*0x173*/ byte _isTypedDataTable;
            /*0x178*/ System.Data.DataRow[] _emptyDataRowArray;
            /*0x180*/ System.ComponentModel.PropertyDescriptorCollection _propertyDescriptorCollectionCache;
            /*0x188*/ System.Data.DataRelation[] _nestedParentRelations;
            /*0x190*/ System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;
            /*0x198*/ bool _mergingData;
            /*0x1a0*/ System.Data.DataRowChangeEventHandler _onRowChangedDelegate;
            /*0x1a8*/ System.Data.DataRowChangeEventHandler _onRowChangingDelegate;
            /*0x1b0*/ System.Data.DataRowChangeEventHandler _onRowDeletingDelegate;
            /*0x1b8*/ System.Data.DataRowChangeEventHandler _onRowDeletedDelegate;
            /*0x1c0*/ System.Data.DataColumnChangeEventHandler _onColumnChangedDelegate;
            /*0x1c8*/ System.Data.DataColumnChangeEventHandler _onColumnChangingDelegate;
            /*0x1d0*/ System.Data.DataTableClearEventHandler _onTableClearingDelegate;
            /*0x1d8*/ System.Data.DataTableClearEventHandler _onTableClearedDelegate;
            /*0x1e0*/ System.Data.DataTableNewRowEventHandler _onTableNewRowDelegate;
            /*0x1e8*/ System.ComponentModel.PropertyChangedEventHandler _onPropertyChangingDelegate;
            /*0x1f0*/ System.Data.DataRowBuilder _rowBuilder;
            /*0x1f8*/ System.Collections.Generic.List<System.Data.DataView> _delayedViews;
            /*0x200*/ System.Collections.Generic.List<System.Data.DataViewListener> _dataViewListeners;
            /*0x208*/ System.Collections.Hashtable _rowDiffId;
            /*0x210*/ System.Threading.ReaderWriterLockSlim _indexesLock;
            /*0x218*/ int _ukColumnPositionForInference;
            /*0x21c*/ System.Data.SerializationFormat _remotingFormat;
            /*0x220*/ int _objectID;

            static /*0x109b4e8*/ System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x1084368*/ DataTable();
            /*0x1084810*/ DataTable(string tableName);
            /*0x1084874*/ DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1084d38*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1084e10*/ void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x1084a0c*/ void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x10850cc*/ void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x10863f0*/ void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x10891c0*/ void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x108a218*/ void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x108aefc*/ void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x108b058*/ void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x1085d98*/ void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x10872c8*/ void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x108b488*/ System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, int bitIndex);
            /*0x108b1bc*/ void GetRowAndColumnErrors(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x108b530*/ void ConvertToRowError(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x108b804*/ bool get_CaseSensitive();
            /*0x108b80c*/ void set_CaseSensitive(bool value);
            /*0x108b8ac*/ bool get_AreIndexEventsSuspended();
            /*0x108b8bc*/ void RestoreIndexEvents(bool forceReset);
            /*0x108bc28*/ void SuspendIndexEvents();
            /*0x108bcd4*/ bool get_IsTypedDataTable();
            /*0x1089900*/ bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes);
            /*0x108bd94*/ bool ShouldSerializeCaseSensitive();
            /*0x108bd9c*/ bool get_SelfNested();
            /*0x108c144*/ System.Collections.Generic.List<System.Data.Index> get_LiveIndexes();
            /*0x108c1ec*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x108c1f4*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x108c254*/ int get_UKColumnPositionForInference();
            /*0x108c25c*/ void set_UKColumnPositionForInference(int value);
            /*0x108c264*/ System.Data.DataRelationCollection get_ChildRelations();
            /*0x108c2d8*/ System.Data.DataColumnCollection get_Columns();
            /*0x108c2e0*/ System.Globalization.CompareInfo get_CompareInfo();
            /*0x108c314*/ System.Data.ConstraintCollection get_Constraints();
            /*0x108c31c*/ void ResetConstraints();
            /*0x108c338*/ System.Data.DataSet get_DataSet();
            /*0x108c340*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x108c3ec*/ string get_DisplayExpressionInternal();
            /*0x108c450*/ bool get_EnforceConstraints();
            /*0x108c480*/ void set_EnforceConstraints(bool value);
            /*0x108caa0*/ bool get_SuspendEnforceConstraints();
            /*0x108caa8*/ void set_SuspendEnforceConstraints(bool value);
            /*0x108c4c0*/ void EnableConstraints();
            /*0x1088c4c*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x108cab4*/ System.IFormatProvider get_FormatProvider();
            /*0x108cb44*/ System.Globalization.CultureInfo get_Locale();
            /*0x108cb4c*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x1089c24*/ bool SetLocaleValue(System.Globalization.CultureInfo culture, bool userSet, bool resetIndexes);
            /*0x108cfe8*/ bool ShouldSerializeLocale();
            /*0x108cff0*/ int get_MinimumCapacity();
            /*0x108a1e8*/ void set_MinimumCapacity(int value);
            /*0x108d00c*/ int get_RecordCapacity();
            /*0x108d028*/ int get_ElementColumnCount();
            /*0x108d030*/ void set_ElementColumnCount(int value);
            /*0x108c0d0*/ System.Data.DataRelationCollection get_ParentRelations();
            /*0x108d074*/ bool get_MergingData();
            /*0x108d07c*/ void set_MergingData(bool value);
            /*0x108d088*/ System.Data.DataRelation[] get_NestedParentRelations();
            /*0x108d090*/ bool get_SchemaLoading();
            /*0x108d098*/ void CacheNestedParent();
            /*0x108d0b0*/ System.Data.DataRelation[] FindNestedParentRelations();
            /*0x108d538*/ int get_NestedParentsCount();
            /*0x108d848*/ System.Data.DataColumn[] get_PrimaryKey();
            /*0x108d8ec*/ void set_PrimaryKey(System.Data.DataColumn[] value);
            /*0x108dcd8*/ System.Data.DataRowCollection get_Rows();
            /*0x108dce0*/ string get_TableName();
            /*0x108dce8*/ void set_TableName(string value);
            /*0x108e270*/ string get_EncodedTableName();
            /*0x108e2dc*/ string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables);
            /*0x1086364*/ string get_Namespace();
            /*0x1088914*/ void set_Namespace(string value);
            /*0x108f308*/ bool IsNamespaceInherited();
            /*0x108e528*/ void CheckCascadingNamespaceConflict(string realNamespace);
            /*0x108e904*/ void CheckNamespaceValidityForNestedRelations(string realNamespace);
            /*0x108f318*/ void CheckNamespaceValidityForNestedParentRelations(string ns, System.Data.DataTable parentTable);
            /*0x108ed2c*/ void DoRaiseNamespaceChange();
            /*0x108f698*/ string get_Prefix();
            /*0x108f6a0*/ void set_Prefix(string value);
            /*0x108f800*/ System.Data.DataColumn get_XmlText();
            /*0x108f808*/ void set_XmlText(System.Data.DataColumn value);
            /*0x108f8b0*/ decimal get_MaxOccurs();
            /*0x108f8bc*/ void set_MaxOccurs(decimal value);
            /*0x108f8c4*/ decimal get_MinOccurs();
            /*0x108f8d0*/ void set_MinOccurs(decimal value);
            /*0x108f8d8*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues, int record);
            /*0x108f968*/ System.Data.DataRow FindByIndex(System.Data.Index ndx, object[] key);
            /*0x108fa00*/ System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx);
            /*0x108fa80*/ void SetMergeRecords(System.Data.DataRow row, int newRecord, int oldRecord, System.Data.DataRowAction action);
            /*0x108fe10*/ System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, bool preserveChanges, System.Data.Index idxSearch);
            /*0x10907ec*/ System.Data.DataTable CreateInstance();
            /*0x1090878*/ System.Data.DataTable Clone();
            /*0x1090880*/ System.Data.DataTable Clone(System.Data.DataSet cloneDS);
            /*0x1090a78*/ System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable);
            /*0x1090db8*/ System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap);
            /*0x1087c80*/ System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, bool skipExpressionColumns);
            /*0x1091238*/ System.ComponentModel.ISite get_Site();
            /*0x1091240*/ void AddRow(System.Data.DataRow row, int proposedID);
            /*0x1091250*/ void InsertRow(System.Data.DataRow row, int proposedID, int pos);
            /*0x109125c*/ void InsertRow(System.Data.DataRow row, long proposedID, int pos, bool fireEvent);
            /*0x1091e08*/ void CheckNotModifying(System.Data.DataRow row);
            /*0x1091e38*/ void Clear();
            /*0x1091e40*/ void Clear(bool clearAll);
            /*0x1092820*/ void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x10928d8*/ void CommitRow(System.Data.DataRow row);
            /*0x1092aa0*/ int Compare(string s1, string s2);
            /*0x1092aa8*/ int Compare(string s1, string s2, System.Globalization.CompareInfo comparer);
            /*0x1092c04*/ int IndexOf(string s1, string s2);
            /*0x1092c44*/ bool IsSuffix(string s1, string s2);
            /*0x1092c84*/ void DeleteRow(System.Data.DataRow row);
            /*0x1092cdc*/ string FormatSortString(System.Data.IndexField[] indexDesc);
            /*0x1092e04*/ void FreeRecord(ref int record);
            /*0x1092e20*/ System.Data.Index GetIndex(string sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x10931b0*/ System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x1093378*/ System.Collections.Generic.List<System.Data.DataViewListener> GetListeners();
            /*0x108cef8*/ int GetSpecialHashCode(string name);
            /*0x1090340*/ void InsertRow(System.Data.DataRow row, long proposedID);
            /*0x109404c*/ int NewRecord();
            /*0x1094138*/ int NewUninitializedRecord();
            /*0x1094054*/ int NewRecord(int sourceRecord);
            /*0x108b434*/ System.Data.DataRow NewEmptyRow();
            /*0x1094154*/ System.Data.DataRow NewUninitializedRow();
            /*0x109420c*/ System.Data.DataRow NewRow();
            /*0x10942cc*/ System.Data.DataRow CreateEmptyRow();
            /*0x1094240*/ void NewRowCreated(System.Data.DataRow row);
            /*0x1094180*/ System.Data.DataRow NewRow(int record);
            /*0x10946a4*/ System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder);
            /*0x1094708*/ System.Type GetRowType();
            /*0x1094774*/ System.Data.DataRow[] NewRowArray(int size);
            /*0x10948f8*/ bool get_NeedColumnChangeEvents();
            /*0x109492c*/ void OnColumnChanging(System.Data.DataColumnChangeEventArgs e);
            /*0x10949fc*/ void OnColumnChanged(System.Data.DataColumnChangeEventArgs e);
            /*0x1094acc*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x1094b9c*/ void OnRemoveColumnInternal(System.Data.DataColumn column);
            /*0x1094bac*/ void OnRemoveColumn(System.Data.DataColumn column);
            /*0x10929f4*/ System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1092948*/ System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1094bb0*/ void OnRowChanged(System.Data.DataRowChangeEventArgs e);
            /*0x1094c80*/ void OnRowChanging(System.Data.DataRowChangeEventArgs e);
            /*0x1094d50*/ void OnRowDeleting(System.Data.DataRowChangeEventArgs e);
            /*0x1094e20*/ void OnRowDeleted(System.Data.DataRowChangeEventArgs e);
            /*0x1094ef0*/ void OnTableCleared(System.Data.DataTableClearEventArgs e);
            /*0x1094fc0*/ void OnTableClearing(System.Data.DataTableClearEventArgs e);
            /*0x1095090*/ void OnTableNewRow(System.Data.DataTableNewRowEventArgs e);
            /*0x1092e54*/ System.Data.IndexField[] ParseSortString(string sortString);
            /*0x108e1f0*/ void RaisePropertyChanging(string name);
            /*0x1095160*/ void RecordChanged(int record);
            /*0x10952d0*/ void RecordChanged(int[] oldIndex, int[] newIndex);
            /*0x1093514*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x109369c*/ void RecordStateChanged(int record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, int record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2);
            /*0x10954a4*/ int[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x109565c*/ int[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x10957d4*/ void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, object newValue);
            /*0x10960b8*/ void RemoveRow(System.Data.DataRow row, bool check);
            /*0x1096258*/ void Reset();
            /*0x1087c78*/ void ResetIndexes();
            /*0x10964d8*/ void ResetInternalIndexes(System.Data.DataColumn column);
            /*0x10966a0*/ void RollbackRow(System.Data.DataRow row);
            /*0x1093e58*/ System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x109672c*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1093380*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, bool fireEvent);
            /*0x108fb3c*/ void SetNewRecord(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged);
            /*0x10915e8*/ void SetNewRecordWorker(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, ref System.Exception deferredException);
            /*0x108fb94*/ void SetOldRecord(System.Data.DataRow row, int proposedRecord);
            /*0x10968e8*/ void RestoreShadowIndexes();
            /*0x108bbf0*/ void SetShadowIndexes();
            /*0x1096904*/ void ShadowIndexCopy();
            /*0x1096988*/ string ToString();
            /*0x10966ec*/ bool UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x10969fc*/ System.Data.DataColumn AddUniqueKey(int position);
            /*0x1096c74*/ System.Data.DataColumn AddUniqueKey();
            /*0x1096c7c*/ System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey);
            /*0x1096d2c*/ void UpdatePropertyDescriptorCollectionCache();
            /*0x1096d34*/ System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes);
            /*0x1088bb8*/ System.Xml.XmlQualifiedName get_TypeName();
            /*0x1096f78*/ void set_TypeName(System.Xml.XmlQualifiedName value);
            /*0x1096f80*/ void Merge(System.Data.DataTable table);
            /*0x1096f8c*/ void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x10971f4*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy);
            /*0x10975ac*/ bool CheckForClosureOnExpressions(System.Data.DataTable dt, bool writeHierarchy);
            /*0x1088cb8*/ bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x1097a9c*/ void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy);
            /*0x1097ddc*/ void RestoreConstraint(bool originalEnforceConstraint);
            /*0x1097e30*/ bool IsEmptyXml(System.Xml.XmlReader reader);
            /*0x1098000*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x1099858*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x10998ec*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x109ad88*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x1098e5c*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x109ae3c*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x109995c*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x10976b4*/ void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x109afcc*/ void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList);
            /*0x109b708*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x109b718*/ System.Xml.Schema.XmlSchema GetSchema();
            /*0x109b8f0*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x109ba9c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x109bad0*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x109badc*/ System.Collections.Hashtable get_RowDiffId();
            /*0x109bb48*/ int get_ObjectID();
            /*0x109bb50*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x109bc6c*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x109bcfc*/ void EvaluateExpressions();
            /*0x10938b8*/ void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows);
            /*0x109c074*/ void EvaluateExpressions(System.Data.DataColumn column);
            /*0x10926c0*/ void EvaluateDependentExpressions(System.Data.DataColumn column);
            /*0x1095944*/ void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows);

            struct RowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataTable _targetTable;

                /*0xfb5620*/ void Prepare(System.Data.DataTable table);
            }

            struct DSRowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataSet _targetDS;

                /*0xfb18a8*/ void Prepare(System.Data.DataSet ds);
            }
        }

        class DataTableClearEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;

            /*0xfb563c*/ DataTableClearEventArgs(System.Data.DataTable dataTable);
        }

        class DataTableClearEventHandler : System.MulticastDelegate
        {
            /*0xfb56a8*/ DataTableClearEventHandler(object object, nint method);
            /*0xfb57d8*/ void Invoke(object sender, System.Data.DataTableClearEventArgs e);
        }

        class DataTableCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.Data.DataTable[] _delayedAddRangeTables;
            /*0x30*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x38*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x40*/ int _objectID;

            /*0xfa8820*/ DataTableCollection(System.Data.DataSet dataSet);
            /*0xfb57ec*/ System.Collections.ArrayList get_List();
            /*0xfb57f4*/ int get_ObjectID();
            /*0xfa8b88*/ System.Data.DataTable get_Item(int index);
            /*0xfb57fc*/ System.Data.DataTable get_Item(string name);
            /*0xfad1c4*/ System.Data.DataTable get_Item(string name, string tableNamespace);
            /*0xfb5c5c*/ System.Data.DataTable GetTable(string name, string ns);
            /*0xfb5d78*/ System.Data.DataTable GetTableSmart(string name, string ns);
            /*0xfaabb0*/ void Add(System.Data.DataTable table);
            /*0xfb60a0*/ void ArrayAdd(System.Data.DataTable table);
            /*0xfb6194*/ string AssignName();
            /*0xfb5f84*/ void BaseAdd(System.Data.DataTable table);
            /*0xfb6514*/ void BaseGroupSwitch(System.Data.DataTable[] oldArray, int oldLength, System.Data.DataTable[] newArray, int newLength);
            /*0xfb668c*/ void BaseRemove(System.Data.DataTable table);
            /*0xfb6700*/ bool CanRemove(System.Data.DataTable table, bool fThrowException);
            /*0xfb48c0*/ void Clear();
            /*0xfb6294*/ bool Contains(string name);
            /*0xfad804*/ bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive);
            /*0xfb6c94*/ bool Contains(string name, bool caseSensitive);
            /*0xfac028*/ int IndexOf(System.Data.DataTable table);
            /*0xfb6dc8*/ int IndexOf(string tableName);
            /*0xfb6de0*/ int IndexOf(string tableName, string tableNamespace, bool chekforNull);
            /*0xfb6e40*/ void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0xfb58f0*/ int InternalIndexOf(string tableName);
            /*0xfb5ac8*/ int InternalIndexOf(string tableName, string tableNamespace);
            /*0xfb61dc*/ string MakeName(int index);
            /*0xfb60c4*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0xfb5eb4*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0xfb62ac*/ void RegisterName(string name, string tbNamespace);
            /*0xfb6e90*/ void Remove(System.Data.DataTable table);
            /*0xfb6b88*/ void UnregisterName(string name);
        }

        class DataTableNewRowEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;

            /*0xfb709c*/ DataTableNewRowEventArgs(System.Data.DataRow dataRow);
        }

        class DataTableNewRowEventHandler : System.MulticastDelegate
        {
            /*0xfb7108*/ DataTableNewRowEventHandler(object object, nint method);
            /*0xfb7238*/ void Invoke(object sender, System.Data.DataTableNewRowEventArgs e);
        }

        class DataTablePropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataTable <Table>k__BackingField;

            /*0xfb724c*/ System.Data.DataTable get_Table();
            /*0xfb7254*/ System.Type get_ComponentType();
            /*0xfb72c0*/ bool get_IsReadOnly();
            /*0xfb72c8*/ System.Type get_PropertyType();
            /*0xfb7334*/ bool CanResetValue(object component);
            /*0xfb733c*/ object GetValue(object component);
            /*0xfb73ac*/ void ResetValue(object component);
            /*0xfb73b0*/ void SetValue(object component, object value);
            /*0xfb73b4*/ bool ShouldSerializeValue(object component);
        }

        class DataTableTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0xfb73bc*/ DataTableTypeConverter();
            /*0xfb7470*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataView : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IBindingList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ITypedList
        {
            static /*0x0*/ System.ComponentModel.ListChangedEventArgs s_resetEventArgs;
            static /*0x8*/ int s_objectTypeCount;
            /*0x20*/ System.Data.DataViewManager _dataViewManager;
            /*0x28*/ System.Data.DataTable _table;
            /*0x30*/ bool _locked;
            /*0x38*/ System.Data.Index _index;
            /*0x40*/ System.Collections.Generic.Dictionary<string, System.Data.Index> _findIndexes;
            /*0x48*/ string _sort;
            /*0x50*/ System.Comparison<System.Data.DataRow> _comparison;
            /*0x58*/ System.Data.IFilter _rowFilter;
            /*0x60*/ System.Data.DataViewRowState _recordStates;
            /*0x64*/ bool _shouldOpen;
            /*0x65*/ bool _open;
            /*0x66*/ bool _allowNew;
            /*0x67*/ bool _allowEdit;
            /*0x68*/ bool _allowDelete;
            /*0x69*/ bool _applyDefaultSort;
            /*0x70*/ System.Data.DataRow _addNewRow;
            /*0x78*/ System.ComponentModel.ListChangedEventArgs _addNewMoved;
            /*0x80*/ System.ComponentModel.ListChangedEventHandler _onListChanged;
            /*0x88*/ string _delayedSort;
            /*0x90*/ System.Data.DataViewRowState _delayedRecordStates;
            /*0x94*/ bool _fInitInProgress;
            /*0x95*/ bool _fEndInitInProgress;
            /*0x98*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewCache;
            /*0xa0*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewBuffer;
            /*0xa8*/ System.Data.DataViewListener _dvListener;
            /*0xb0*/ int _objectID;

            static /*0xfba730*/ DataView();
            /*0xfb7478*/ DataView(System.Data.DataTable table, bool locked);
            /*0xfb7720*/ DataView(System.Data.DataTable table);
            /*0xfb79b8*/ bool get_AllowDelete();
            /*0xfb79c0*/ bool get_AllowEdit();
            /*0xfb79c8*/ bool get_AllowNew();
            /*0xfb79d0*/ int get_Count();
            /*0xfb7a20*/ int get_CountFromIndex();
            /*0xfb7a3c*/ System.Data.DataViewManager get_DataViewManager();
            /*0xfb7a44*/ bool get_IsOpen();
            /*0xfb7a4c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0xfb7a54*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0xfb7a5c*/ string get_Sort();
            /*0xfb7ab0*/ void set_Sort(string value);
            /*0xfb7c6c*/ System.Comparison<System.Data.DataRow> get_SortComparison();
            /*0xfb7c74*/ object System.Collections.ICollection.get_SyncRoot();
            /*0xfb7c78*/ System.Data.DataTable get_Table();
            /*0xfb7c80*/ object System.Collections.IList.get_Item(int recordIndex);
            /*0xfb7cb8*/ void System.Collections.IList.set_Item(int recordIndex, object value);
            /*0xfb7c9c*/ System.Data.DataRowView get_Item(int recordIndex);
            /*0xfb7dd4*/ System.Data.DataRowView AddNew();
            /*0xfb80b8*/ void CheckOpen();
            /*0xfb7c1c*/ void CheckSort(string sort);
            /*0xfb81bc*/ void Close();
            /*0xfb8208*/ void CopyTo(System.Array array, int index);
            /*0xfb8394*/ void CopyTo(System.Data.DataRowView[] array, int index);
            /*0xfb8548*/ void Delete(int index);
            /*0xfb8564*/ void Delete(System.Data.DataRow row);
            /*0xfb8728*/ void Dispose(bool disposing);
            /*0xfa80c0*/ void FinishAddNew(bool success);
            /*0xfb875c*/ System.Collections.IEnumerator GetEnumerator();
            /*0xfb87d8*/ bool System.Collections.IList.get_IsReadOnly();
            /*0xfb87e0*/ bool System.Collections.IList.get_IsFixedSize();
            /*0xfb87e8*/ int System.Collections.IList.Add(object value);
            /*0xfb883c*/ void System.Collections.IList.Clear();
            /*0xfb8864*/ bool System.Collections.IList.Contains(object value);
            /*0xfb88f0*/ int System.Collections.IList.IndexOf(object value);
            /*0xfb80f0*/ int IndexOf(System.Data.DataRowView rowview);
            /*0xfb8970*/ int IndexOfDataRowView(System.Data.DataRowView rowview);
            /*0xfb89e0*/ void System.Collections.IList.Insert(int index, object value);
            /*0xfb8a08*/ void System.Collections.IList.Remove(object value);
            /*0xfb8b28*/ void System.Collections.IList.RemoveAt(int index);
            /*0xfb8b44*/ System.Data.Index GetFindIndex(string column, bool keepIndex);
            /*0xfb8cdc*/ bool System.ComponentModel.IBindingList.get_AllowNew();
            /*0xfb8ce4*/ object System.ComponentModel.IBindingList.AddNew();
            /*0xfb8cf4*/ bool System.ComponentModel.IBindingList.get_AllowEdit();
            /*0xfb8cfc*/ bool System.ComponentModel.IBindingList.get_AllowRemove();
            /*0xfb8d04*/ bool System.ComponentModel.IBindingList.get_SupportsChangeNotification();
            /*0xfb8d0c*/ bool System.ComponentModel.IBindingList.get_SupportsSearching();
            /*0xfb8d14*/ bool System.ComponentModel.IBindingList.get_SupportsSorting();
            /*0xfb8d1c*/ bool System.ComponentModel.IBindingList.get_IsSorted();
            /*0xfb8d40*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty();
            /*0xfb8d44*/ System.ComponentModel.PropertyDescriptor GetSortProperty();
            /*0xfb8dd8*/ System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.get_SortDirection();
            /*0xfb8e10*/ void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property);
            /*0xfb8e48*/ void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
            /*0xfb8f48*/ int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key);
            /*0xfb9200*/ void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property);
            /*0xfb9238*/ void System.ComponentModel.IBindingList.RemoveSort();
            /*0xfb8e64*/ string CreateSortString(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
            /*0xfb92f8*/ string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
            /*0xfb9384*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
            /*0xfb9430*/ System.Data.IFilter GetFilter();
            /*0xfb9438*/ int GetRecord(int recordIndex);
            /*0xfb7ce0*/ System.Data.DataRow GetRow(int index);
            /*0xfb8360*/ System.Data.DataRowView GetRowView(int record);
            /*0xfb7d7c*/ System.Data.DataRowView GetRowView(System.Data.DataRow dr);
            /*0xfb94bc*/ void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0xfb954c*/ void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e);
            /*0xfb95fc*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0xfb9a7c*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0xfb9d94*/ void Reset();
            /*0xfb983c*/ void ResetRowViewCache();
            /*0xfa7e28*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0xfb9dc0*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
            /*0xfb7790*/ void SetIndex2(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, bool fireEvent);
            /*0xfb81f4*/ void UpdateIndex();
            /*0xfba0ec*/ void UpdateIndex(bool force);
            /*0xfb9dc8*/ void UpdateIndex(bool force, bool fireEvent);
            /*0xfba0f8*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xfba300*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xfba508*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xfba718*/ void ColumnCollectionChangedInternal(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xfba728*/ int get_ObjectID();

            class DataRowReferenceComparer : System.Collections.Generic.IEqualityComparer<System.Data.DataRow>
            {
                static /*0x0*/ System.Data.DataView.DataRowReferenceComparer s_default;

                static /*0xffc2d4*/ DataRowReferenceComparer();
                /*0xffc2a8*/ DataRowReferenceComparer();
                /*0xffc2b0*/ bool Equals(System.Data.DataRow x, System.Data.DataRow y);
                /*0xffc2bc*/ int GetHashCode(System.Data.DataRow obj);
            }
        }

        class DataViewListener
        {
            /*0x10*/ System.WeakReference _dvWeak;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ System.Data.Index _index;
            /*0x28*/ int _objectID;

            /*0xffc338*/ DataViewListener(System.Data.DataView dv);
            /*0xffc3b8*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xffc49c*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xffc564*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0xffc62c*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0xffc6fc*/ void IndexListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0xffc7b0*/ void RegisterMetaDataEvents(System.Data.DataTable table);
            /*0xffcbac*/ void UnregisterMetaDataEvents();
            /*0xffcbb4*/ void UnregisterMetaDataEvents(bool updateListeners);
            /*0xffce54*/ void RegisterListChangedEvent(System.Data.Index index);
            /*0xffcf38*/ void UnregisterListChangedEvent();
            /*0xffc480*/ void CleanUp(bool updateListeners);
            /*0xffc98c*/ void RegisterListener(System.Data.DataTable table);
        }

        class DataViewManager : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ System.NotSupportedException s_notSupported;
            /*0x20*/ System.Data.DataViewSettingCollection _dataViewSettingsCollection;
            /*0x28*/ int _nViews;

            static /*0xffd044*/ DataViewManager();
            /*0xffd03c*/ System.Data.DataViewSettingCollection get_DataViewSettings();
        }

        class DataViewManagerListItemTypeDescriptor
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;

            /*0xffd0bc*/ System.Data.DataView GetDataView(System.Data.DataTable table);
        }

        enum DataViewRowState
        {
            None = 0,
            Unchanged = 2,
            Added = 4,
            Deleted = 8,
            ModifiedCurrent = 16,
            ModifiedOriginal = 32,
            OriginalRows = 42,
            CurrentRows = 22,
        }

        class DataViewSetting
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ string _sort;
            /*0x28*/ string _rowFilter;
            /*0x30*/ System.Data.DataViewRowState _rowStateFilter;
            /*0x34*/ bool _applyDefaultSort;

            /*0xffd13c*/ DataViewSetting();
            /*0xffd19c*/ bool get_ApplyDefaultSort();
            /*0xffd1a4*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0xffd1b8*/ void SetDataTable(System.Data.DataTable table);
            /*0xffd1cc*/ string get_RowFilter();
            /*0xffd1d4*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0xffd1dc*/ string get_Sort();
        }

        class DataViewSettingCollection
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Collections.Hashtable _list;

            /*0xffd1e4*/ System.Data.DataViewSetting get_Item(System.Data.DataTable table);
            /*0xffd2e8*/ void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value);
            /*0xffd368*/ void Remove(System.Data.DataTable table);
        }

        class DefaultValueTypeConverter : System.ComponentModel.StringConverter
        {
            /*0xffd38c*/ DefaultValueTypeConverter();
            /*0xffd394*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0xffd544*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        enum Aggregate
        {
            None = -1,
            Sum = 30,
            Avg = 31,
            Min = 32,
            Max = 33,
            Count = 34,
            StDev = 35,
            Var = 37,
        }

        class AggregateNode : System.Data.ExpressionNode
        {
            /*0x18*/ System.Data.AggregateType _type;
            /*0x1c*/ System.Data.Aggregate _aggregate;
            /*0x20*/ bool _local;
            /*0x28*/ string _relationName;
            /*0x30*/ string _columnName;
            /*0x38*/ System.Data.DataTable _childTable;
            /*0x40*/ System.Data.DataColumn _column;
            /*0x48*/ System.Data.DataRelation _relation;

            static /*0xffdbb0*/ void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0xffd6e4*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName);
            /*0xffd6f0*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName, bool local, string relationName);
            /*0xffd840*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0xffdd9c*/ object Eval();
            /*0xffddb0*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0xffe0c4*/ object Eval(int[] records);
            /*0xffe188*/ bool IsConstant();
            /*0xffe190*/ bool IsTableConstant();
            /*0xffe198*/ bool HasLocalAggregate();
            /*0xffe1a0*/ bool HasRemoteAggregate();
            /*0xffe1b0*/ bool DependsOn(System.Data.DataColumn column);
            /*0xffe248*/ System.Data.ExpressionNode Optimize();
        }

        class BinaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _left;
            /*0x28*/ System.Data.ExpressionNode _right;

            static /*0x10043bc*/ object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            static /*0x1005de8*/ System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code);
            /*0xffe24c*/ BinaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0xffe290*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0xffe2e4*/ object Eval();
            /*0xffe2f8*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1003bd0*/ object Eval(int[] recordNos);
            /*0x1003bec*/ bool IsConstant();
            /*0x1003c34*/ bool IsTableConstant();
            /*0x1003c7c*/ bool HasLocalAggregate();
            /*0x1003cc4*/ bool HasRemoteAggregate();
            /*0x1003d0c*/ bool DependsOn(System.Data.DataColumn column);
            /*0x1003d70*/ System.Data.ExpressionNode Optimize();
            /*0x10042bc*/ void SetTypeMismatchError(int op, System.Type left, System.Type right);
            /*0x10043ec*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op);
            /*0x10043f4*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op, System.Globalization.CompareInfo comparer);
            /*0xffe314*/ object EvalBinaryOp(int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            /*0x1005dc4*/ System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType);
            /*0x1005e0c*/ bool IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x1005f1c*/ bool IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x100587c*/ System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x10054a0*/ System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x1006150*/ int SqlResultType(int typeCode);

            enum DataTypePrecedence
            {
                SqlDateTime = 25,
                DateTimeOffset = 24,
                DateTime = 23,
                TimeSpan = 20,
                SqlDouble = 19,
                Double = 18,
                SqlSingle = 17,
                Single = 16,
                SqlDecimal = 15,
                Decimal = 14,
                SqlMoney = 13,
                UInt64 = 12,
                SqlInt64 = 11,
                Int64 = 10,
                UInt32 = 9,
                SqlInt32 = 8,
                Int32 = 7,
                UInt16 = 6,
                SqlInt16 = 5,
                Int16 = 4,
                Byte = 3,
                SqlByte = 2,
                SByte = 1,
                Error = 0,
                SqlBoolean = -1,
                Boolean = -2,
                SqlGuid = -3,
                SqlString = -4,
                String = -5,
                SqlXml = -6,
                SqlChars = -7,
                Char = -8,
                SqlBytes = -9,
                SqlBinary = -10,
            }
        }

        class LikeNode : System.Data.BinaryNode
        {
            /*0x30*/ int _kind;
            /*0x38*/ string _pattern;

            /*0x10061e8*/ LikeNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x100622c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1006748*/ string AnalyzePattern(string pat);
        }

        class ConstNode : System.Data.ExpressionNode
        {
            /*0x18*/ object _val;

            /*0x1006a5c*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant);
            /*0x1003fe8*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes);
            /*0x1007508*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x1007510*/ object Eval();
            /*0x1007518*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1007524*/ object Eval(int[] recordNos);
            /*0x1007530*/ bool IsConstant();
            /*0x1007538*/ bool IsTableConstant();
            /*0x1007540*/ bool HasLocalAggregate();
            /*0x1007548*/ bool HasRemoteAggregate();
            /*0x1007550*/ System.Data.ExpressionNode Optimize();
            /*0x100707c*/ object SmallestDecimal(object constant);
            /*0x1006a64*/ object SmallestNumeric(object constant);
        }

        class DataExpression : System.Data.IFilter
        {
            /*0x10*/ string _originalExpression;
            /*0x18*/ bool _parsed;
            /*0x19*/ bool _bound;
            /*0x20*/ System.Data.ExpressionNode _expr;
            /*0x28*/ System.Data.DataTable _table;
            /*0x30*/ System.Data.Common.StorageType _storageType;
            /*0x38*/ System.Type _dataType;
            /*0x40*/ System.Data.DataColumn[] _dependency;

            static /*0x1008b74*/ bool IsUnknown(object value);
            static /*0x1005230*/ bool ToBoolean(object value);
            /*0x1007554*/ DataExpression(System.Data.DataTable table, string expression);
            /*0x100755c*/ DataExpression(System.Data.DataTable table, string expression, System.Type type);
            /*0x10086fc*/ string get_Expression();
            /*0x100874c*/ bool get_HasValue();
            /*0x100860c*/ void Bind(System.Data.DataTable table);
            /*0xffe22c*/ bool DependsOn(System.Data.DataColumn column);
            /*0x100875c*/ object Evaluate();
            /*0x1008768*/ object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x10089e4*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1008b54*/ System.Data.DataColumn[] GetDependency();
            /*0x1008b5c*/ bool IsTableAggregate();
            /*0x1008bcc*/ bool HasLocalAggregate();
            /*0x1008be4*/ bool HasRemoteAggregate();
        }

        class ExpressionNode
        {
            /*0x10*/ System.Data.DataTable _table;

            static /*0x100605c*/ bool IsInteger(System.Data.Common.StorageType type);
            static /*0x1005c5c*/ bool IsIntegerSql(System.Data.Common.StorageType type);
            static /*0x1005ea8*/ bool IsSigned(System.Data.Common.StorageType type);
            static /*0x1005fc8*/ bool IsSignedSql(System.Data.Common.StorageType type);
            static /*0x1005ef0*/ bool IsUnsigned(System.Data.Common.StorageType type);
            static /*0x1006000*/ bool IsUnsignedSql(System.Data.Common.StorageType type);
            static /*0x100603c*/ bool IsNumeric(System.Data.Common.StorageType type);
            static /*0x1006184*/ bool IsNumericSql(System.Data.Common.StorageType type);
            static /*0x1008c1c*/ bool IsFloat(System.Data.Common.StorageType type);
            static /*0x1008c3c*/ bool IsFloatSql(System.Data.Common.StorageType type);
            /*0xffd7c8*/ ExpressionNode(System.Data.DataTable table);
            /*0x10051c4*/ System.IFormatProvider get_FormatProvider();
            /*0x1008bfc*/ bool get_IsSqlColumn();
            /*0x1008c04*/ System.Data.DataTable get_table();
            /*0x1008c0c*/ void BindTable(System.Data.DataTable table);
            void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            object Eval();
            object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            object Eval(int[] recordNos);
            bool IsConstant();
            bool IsTableConstant();
            bool HasLocalAggregate();
            bool HasRemoteAggregate();
            System.Data.ExpressionNode Optimize();
            /*0x1008c14*/ bool DependsOn(System.Data.DataColumn column);
        }

        enum ValueType
        {
            Unknown = -1,
            Null = 0,
            Bool = 1,
            Numeric = 2,
            Str = 3,
            Float = 4,
            Decimal = 5,
            Object = 6,
            Date = 7,
        }

        enum Nodes
        {
            Noop = 0,
            Unop = 1,
            UnopSpec = 2,
            Binop = 3,
            BinopSpec = 4,
            Zop = 5,
            Call = 6,
            Const = 7,
            Name = 8,
            Paren = 9,
            Conv = 10,
        }

        class ExpressionParser
        {
            static /*0x0*/ System.Data.ExpressionParser.ReservedWords[] s_reservedwords;
            /*0x10*/ char _escape;
            /*0x12*/ char _decimalSeparator;
            /*0x14*/ char _listSeparator;
            /*0x16*/ char _exponentL;
            /*0x18*/ char _exponentU;
            /*0x20*/ char[] _text;
            /*0x28*/ int _pos;
            /*0x2c*/ int _start;
            /*0x30*/ System.Data.Tokens _token;
            /*0x34*/ int _op;
            /*0x38*/ System.Data.OperatorInfo[] _ops;
            /*0x40*/ int _topOperator;
            /*0x44*/ int _topNode;
            /*0x48*/ System.Data.DataTable _table;
            /*0x50*/ System.Data.ExpressionNode[] _nodeStack;
            /*0x58*/ int _prevOperand;
            /*0x60*/ System.Data.ExpressionNode _expression;

            static /*0x100abb0*/ ExpressionParser();
            /*0x10076f0*/ ExpressionParser(System.Data.DataTable table);
            /*0x1007794*/ void LoadExpression(string data);
            /*0x1008c78*/ void StartScan();
            /*0x10078cc*/ System.Data.ExpressionNode Parse();
            /*0x1009ab4*/ System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate);
            /*0x10099dc*/ System.Data.ExpressionNode NodePop();
            /*0x1009958*/ System.Data.ExpressionNode NodePeek();
            /*0x1009798*/ void NodePush(System.Data.ExpressionNode node);
            /*0x10091a4*/ void BuildExpression(int pri);
            /*0x1009688*/ void CheckToken(System.Data.Tokens token);
            /*0x1008d60*/ System.Data.Tokens Scan();
            /*0x100a6b0*/ void ScanNumeric();
            /*0x100aa18*/ void ScanName();
            /*0x100a5a0*/ void ScanName(char chEnd, char esc, string charsToEscape);
            /*0x100a430*/ void ScanDate();
            /*0x100a7e4*/ void ScanBinaryConstant();
            /*0x100a7fc*/ void ScanReserved();
            /*0x100a4d0*/ void ScanString(char escape);
            /*0x100946c*/ void ScanToken(System.Data.Tokens token);
            /*0x100a3d8*/ void ScanWhite();
            /*0x100ab9c*/ bool IsWhiteSpace(char ch);
            /*0x100a9dc*/ bool IsAlphaNumeric(char ch);
            /*0x100a7e8*/ bool IsDigit(char ch);
            /*0x100ab20*/ bool IsAlpha(char ch);

            struct ReservedWords
            {
                /*0x10*/ string _word;
                /*0x18*/ System.Data.Tokens _token;
                /*0x1c*/ int _op;

                /*0x100ae2c*/ ReservedWords(string word, System.Data.Tokens token, int op);
            }
        }

        enum Tokens
        {
            None = 0,
            Name = 1,
            Numeric = 2,
            Decimal = 3,
            Float = 4,
            BinaryConst = 5,
            StringConst = 6,
            Date = 7,
            ListSeparator = 8,
            LeftParen = 9,
            RightParen = 10,
            ZeroOp = 11,
            UnaryOp = 12,
            BinaryOp = 13,
            Child = 14,
            Parent = 15,
            Dot = 16,
            Unknown = 17,
            EOS = 18,
        }

        class OperatorInfo
        {
            /*0x10*/ System.Data.Nodes _type;
            /*0x14*/ int _op;
            /*0x18*/ int _priority;

            /*0x1008d24*/ OperatorInfo(System.Data.Nodes type, int op, int pri);
        }

        class InvalidExpressionException : System.Data.DataException
        {
            /*0x100ae38*/ InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x100ae40*/ InvalidExpressionException();
            /*0x100ae48*/ InvalidExpressionException(string s);
        }

        class EvaluateException : System.Data.InvalidExpressionException
        {
            /*0x100ae50*/ EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x100ae58*/ EvaluateException();
            /*0x100ae60*/ EvaluateException(string s);
        }

        class SyntaxErrorException : System.Data.InvalidExpressionException
        {
            /*0x100ae68*/ SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x100ae70*/ SyntaxErrorException();
            /*0x100ae78*/ SyntaxErrorException(string s);
        }

        class ExprException
        {
            static /*0x100ae80*/ System.OverflowException _Overflow(string error);
            static /*0x100aef0*/ System.Data.InvalidExpressionException _Expr(string error);
            static /*0x100af60*/ System.Data.SyntaxErrorException _Syntax(string error);
            static /*0x100afd0*/ System.Data.EvaluateException _Eval(string error);
            static /*0x100b040*/ System.Data.EvaluateException _Eval(string error, System.Exception innerException);
            static /*0x1008ac0*/ System.Exception InvokeArgument();
            static /*0x100b0b0*/ System.Exception NYI(string moreinfo);
            static /*0x1009114*/ System.Exception MissingOperand(System.Data.OperatorInfo before);
            static /*0x100941c*/ System.Exception MissingOperator(string token);
            static /*0x100b100*/ System.Exception TypeMismatch(string expr);
            static /*0x100b150*/ System.Exception FunctionArgumentOutOfRange(string arg, string func);
            static /*0x100a288*/ System.Exception ExpressionTooComplex();
            static /*0xffdb60*/ System.Exception UnboundName(string name);
            static /*0x100ab4c*/ System.Exception InvalidString(string str);
            static /*0xffd7f0*/ System.Exception UndefinedFunction(string name);
            static /*0x100999c*/ System.Exception SyntaxError();
            static /*0x100b1b8*/ System.Exception FunctionArgumentCount(string name);
            static /*0x10093dc*/ System.Exception MissingRightParen();
            static /*0x100a1a4*/ System.Exception UnknownToken(string token, int position);
            static /*0x100a2c8*/ System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, int position);
            static /*0x100b208*/ System.Exception DatatypeConvertion(System.Type type1, System.Type type2);
            static /*0x1008958*/ System.Exception DatavalueConvertion(object value, System.Type type, System.Exception innerException);
            static /*0x100b294*/ System.Exception InvalidName(string name);
            static /*0x100aad0*/ System.Exception InvalidDate(string date);
            static /*0x100b2e4*/ System.Exception NonConstantArgument();
            static /*0x1006a0c*/ System.Exception InvalidPattern(string pat);
            static /*0x1005c94*/ System.Exception InWithoutParentheses();
            static /*0x100b324*/ System.Exception InWithoutList();
            static /*0x1003fa8*/ System.Exception InvalidIsSyntax();
            static /*0x1005d58*/ System.Exception Overflow(System.Type type);
            static /*0x100b364*/ System.Exception ArgumentType(string function, int arg, System.Type type);
            static /*0x100b42c*/ System.Exception ArgumentTypeInteger(string function, int arg);
            static /*0x10042ec*/ System.Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2);
            static /*0x1006080*/ System.Exception AmbiguousBinop(int op, System.Type type1, System.Type type2);
            static /*0x1005cd4*/ System.Exception UnsupportedOperator(int op);
            static /*0x100aa80*/ System.Exception InvalidNameBracketing(string name);
            static /*0x100a128*/ System.Exception MissingOperandBefore(string op);
            static /*0x1009d6c*/ System.Exception TooManyRightParentheses();
            static /*0xffdb00*/ System.Exception UnresolvedRelation(string name, string expr);
            static /*0x100b4d0*/ System.Data.EvaluateException BindFailure(string relationName);
            static /*0x100a248*/ System.Exception AggregateArgument();
            static /*0xffdab0*/ System.Exception AggregateUnbound(string expr);
            static /*0xffe084*/ System.Exception EvalNoContext();
            static /*0x100b520*/ System.Exception ExpressionUnbound(string expr);
            static /*0xffe138*/ System.Exception ComputeNotAggregate(string expr);
            static /*0x1008b04*/ System.Exception FilterConvertion(string expr);
            static /*0x10096cc*/ System.Exception LookupArgument();
            static /*0x100b570*/ System.Exception InvalidType(string typeName);
            static /*0x100b5c0*/ System.Exception InvalidHoursArgument();
            static /*0x100b600*/ System.Exception InvalidMinutesArgument();
            static /*0x100b640*/ System.Exception InvalidTimeZoneRange();
            static /*0x100b680*/ System.Exception MismatchKindandTimeSpan();
            static /*0x1007858*/ System.Exception UnsupportedDataType(System.Type type);
        }

        class FunctionNode : System.Data.ExpressionNode
        {
            static /*0x0*/ System.Data.Function[] s_funcs;
            /*0x18*/ string _name;
            /*0x20*/ int _info;
            /*0x24*/ int _argumentCount;
            /*0x28*/ System.Data.ExpressionNode[] _arguments;

            static /*0x100e268*/ FunctionNode();
            /*0x100982c*/ FunctionNode(System.Data.DataTable table, string name);
            /*0x1009dac*/ void AddArgument(System.Data.ExpressionNode argument);
            /*0x100b6c0*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x100b998*/ object Eval();
            /*0x100b9ac*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x100dbc8*/ object Eval(int[] recordNos);
            /*0x100dbf8*/ bool IsConstant();
            /*0x100dc88*/ bool IsTableConstant();
            /*0x100dd04*/ bool HasLocalAggregate();
            /*0x100dd80*/ bool HasRemoteAggregate();
            /*0x100ddfc*/ bool DependsOn(System.Data.DataColumn column);
            /*0x100de84*/ System.Data.ExpressionNode Optimize();
            /*0x100c2ec*/ System.Type GetDataType(System.Data.ExpressionNode node);
            /*0x100c56c*/ object EvalFunction(System.Data.FunctionId id, object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1009a18*/ System.Data.FunctionId get_Aggregate();
            /*0x100e034*/ bool get_IsAggregate();
            /*0x1009f88*/ void Check();
        }

        enum FunctionId
        {
            none = -1,
            Ascii = 0,
            Char = 1,
            Charindex = 2,
            Difference = 3,
            Len = 4,
            Lower = 5,
            LTrim = 6,
            Patindex = 7,
            Replicate = 8,
            Reverse = 9,
            Right = 10,
            RTrim = 11,
            Soundex = 12,
            Space = 13,
            Str = 14,
            Stuff = 15,
            Substring = 16,
            Upper = 17,
            IsNull = 18,
            Iif = 19,
            Convert = 20,
            cInt = 21,
            cBool = 22,
            cDate = 23,
            cDbl = 24,
            cStr = 25,
            Abs = 26,
            Acos = 27,
            In = 28,
            Trim = 29,
            Sum = 30,
            Avg = 31,
            Min = 32,
            Max = 33,
            Count = 34,
            StDev = 35,
            Var = 37,
            DateTimeOffset = 38,
        }

        class Function
        {
            static /*0x0*/ string[] s_functionName;
            /*0x10*/ string _name;
            /*0x18*/ System.Data.FunctionId _id;
            /*0x20*/ System.Type _result;
            /*0x28*/ bool _isValidateArguments;
            /*0x29*/ bool _isVariantArgumentList;
            /*0x2c*/ int _argumentCount;
            /*0x30*/ System.Type[] _parameters;

            static /*0x100eecc*/ Function();
            /*0x100ecf4*/ Function(string name, System.Data.FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3);
        }

        interface IFilter
        {
            bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
        }

        class LookupNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _relationName;
            /*0x20*/ string _columnName;
            /*0x28*/ System.Data.DataColumn _column;
            /*0x30*/ System.Data.DataRelation _relation;

            /*0x100970c*/ LookupNode(System.Data.DataTable table, string columnName, string relationName);
            /*0x100f910*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x100fb5c*/ object Eval();
            /*0x100fb80*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x100fc84*/ object Eval(int[] recordNos);
            /*0x100fcb4*/ bool IsConstant();
            /*0x100fcbc*/ bool IsTableConstant();
            /*0x100fcc4*/ bool HasLocalAggregate();
            /*0x100fccc*/ bool HasRemoteAggregate();
            /*0x100fcd4*/ bool DependsOn(System.Data.DataColumn column);
            /*0x100fce4*/ System.Data.ExpressionNode Optimize();
        }

        class NameNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _name;
            /*0x20*/ bool _found;
            /*0x28*/ System.Data.DataColumn _column;

            static /*0x1009494*/ string ParseName(char[] text, int start, int pos);
            /*0x1009748*/ NameNode(System.Data.DataTable table, char[] text, int start, int pos);
            /*0x100a178*/ NameNode(System.Data.DataTable table, string name);
            /*0x100fce8*/ bool get_IsSqlColumn();
            /*0x100fd04*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x100ff30*/ object Eval();
            /*0x100ff54*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x100fff0*/ object Eval(int[] records);
            /*0x1010020*/ bool IsConstant();
            /*0x1010028*/ bool IsTableConstant();
            /*0x101007c*/ bool HasLocalAggregate();
            /*0x10100d0*/ bool HasRemoteAggregate();
            /*0x1010124*/ bool DependsOn(System.Data.DataColumn column);
            /*0x10101a0*/ System.Data.ExpressionNode Optimize();
        }

        class Operators
        {
            static /*0x0*/ int[] s_priority;
            static /*0x8*/ string[] s_looks;

            static /*0x1173d54*/ Operators();
            static /*0x1173b6c*/ bool IsArithmetical(int op);
            static /*0x1173b98*/ bool IsLogical(int op);
            static /*0x1173bd8*/ bool IsRelational(int op);
            static /*0x1173be8*/ int Priority(int op);
            static /*0x1173c94*/ string ToString(int op);
        }

        class UnaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _right;

            /*0x11747fc*/ UnaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode right);
            /*0x117482c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x1174854*/ object Eval();
            /*0x1174868*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1175078*/ object Eval(int[] recordNos);
            /*0x11748a8*/ object EvalUnaryOp(int op, object vl);
            /*0x1175098*/ bool IsConstant();
            /*0x11750b8*/ bool IsTableConstant();
            /*0x11750d8*/ bool HasLocalAggregate();
            /*0x11750f8*/ bool HasRemoteAggregate();
            /*0x1175118*/ bool DependsOn(System.Data.DataColumn column);
            /*0x117513c*/ System.Data.ExpressionNode Optimize();
        }

        class ZeroOpNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;

            /*0x11751f8*/ ZeroOpNode(int op);
            /*0x1175224*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x1175228*/ object Eval();
            /*0x11752dc*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x11752e8*/ object Eval(int[] recordNos);
            /*0x11752f4*/ bool IsConstant();
            /*0x11752fc*/ bool IsTableConstant();
            /*0x1175304*/ bool HasLocalAggregate();
            /*0x117530c*/ bool HasRemoteAggregate();
            /*0x1175314*/ System.Data.ExpressionNode Optimize();
        }

        class ForeignKeyConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.Rule _deleteRule;
            /*0x3c*/ System.Data.Rule _updateRule;
            /*0x40*/ System.Data.AcceptRejectRule _acceptRejectRule;
            /*0x48*/ System.Data.DataKey _childKey;
            /*0x50*/ System.Data.DataKey _parentKey;
            /*0x58*/ string _constraintName;
            /*0x60*/ string[] _parentColumnNames;
            /*0x68*/ string[] _childColumnNames;
            /*0x70*/ string _parentTableName;

            /*0x1175318*/ ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x1175358*/ ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x117551c*/ ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule);
            /*0x1175588*/ System.Data.DataKey get_ChildKey();
            /*0x11755a4*/ System.Data.DataColumn[] get_Columns();
            /*0x11755c4*/ System.Data.DataTable get_Table();
            /*0x11755e4*/ string[] get_ParentColumnNames();
            /*0x11755f0*/ string[] get_ChildColumnNames();
            /*0x11755fc*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x1175724*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x117572c*/ bool IsKeyNull(object[] values);
            /*0x11757e0*/ bool IsConstraintViolated();
            /*0x1175c88*/ bool CanEnableConstraint();
            /*0x1175ddc*/ void CascadeCommit(System.Data.DataRow row);
            /*0x1175f3c*/ void CascadeDelete(System.Data.DataRow row);
            /*0x1176444*/ void CascadeRollback(System.Data.DataRow row);
            /*0x1176638*/ void CascadeUpdate(System.Data.DataRow row);
            /*0x1176a98*/ void CheckCanClearParentTable(System.Data.DataTable table);
            /*0x1176b74*/ void CheckCanRemoveParentRow(System.Data.DataRow row);
            /*0x1176c3c*/ void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1176d3c*/ void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action);
            /*0x1177010*/ void NonVirtualCheckState();
            /*0x117725c*/ void CheckState();
            /*0x1177260*/ System.Data.AcceptRejectRule get_AcceptRejectRule();
            /*0x117727c*/ void set_AcceptRejectRule(System.Data.AcceptRejectRule value);
            /*0x11772d0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x1177318*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x1177328*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x1177a78*/ System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination);
            /*0x11753a4*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x1178080*/ System.Data.Rule get_DeleteRule();
            /*0x117809c*/ void set_DeleteRule(System.Data.Rule value);
            /*0x11780f0*/ bool Equals(object key);
            /*0x11781e0*/ int GetHashCode();
            /*0x11781e8*/ System.Data.DataColumn[] get_RelatedColumns();
            /*0x1177a5c*/ System.Data.DataColumn[] get_RelatedColumnsReference();
            /*0x1176c20*/ System.Data.DataKey get_ParentKey();
            /*0x1178208*/ System.Data.DataRelation FindParentRelation();
            /*0x11782d0*/ System.Data.DataTable get_RelatedTable();
            /*0x11782f0*/ System.Data.Rule get_UpdateRule();
            /*0x117830c*/ void set_UpdateRule(System.Data.Rule value);
        }

        enum MappingType
        {
            Element = 1,
            Attribute = 2,
            SimpleContent = 3,
            Hidden = 4,
        }

        class MergeFailedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;
            /*0x18*/ string <Conflict>k__BackingField;

            /*0x1178360*/ MergeFailedEventArgs(System.Data.DataTable table, string conflict);
            /*0x11783d0*/ string get_Conflict();
        }

        class MergeFailedEventHandler : System.MulticastDelegate
        {
            /*0x11783d8*/ MergeFailedEventHandler(object object, nint method);
            /*0x1178508*/ void Invoke(object sender, System.Data.MergeFailedEventArgs e);
        }

        class Merger
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.DataTable _dataTable;
            /*0x20*/ bool _preserveChanges;
            /*0x24*/ System.Data.MissingSchemaAction _missingSchemaAction;
            /*0x28*/ bool _isStandAlonetable;
            /*0x29*/ bool _IgnoreNSforTableLookup;

            /*0x117851c*/ Merger(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x117856c*/ Merger(System.Data.DataTable dataTable, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x11785c4*/ void MergeDataSet(System.Data.DataSet source);
            /*0x117a174*/ void MergeTable(System.Data.DataTable src);
            /*0x117a3a0*/ void MergeTable(System.Data.DataTable src, System.Data.DataTable dst);
            /*0x117a990*/ System.Data.DataTable MergeSchema(System.Data.DataTable table);
            /*0x117968c*/ void MergeTableData(System.Data.DataTable src);
            /*0x1179714*/ void MergeConstraints(System.Data.DataSet source);
            /*0x117b09c*/ void MergeConstraints(System.Data.DataTable table);
            /*0x1179784*/ void MergeRelation(System.Data.DataRelation relation);
            /*0x1179f20*/ void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst);
            /*0x117a844*/ System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst);
        }

        enum MissingSchemaAction
        {
            Add = 1,
            Ignore = 2,
            Error = 3,
            AddWithKey = 4,
        }

        class PrimaryKeyTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x117b34c*/ PrimaryKeyTypeConverter();
            /*0x117b400*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x117b408*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x117b4d0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class PropertyCollection : System.Collections.Hashtable, System.ICloneable
        {
            /*0x117b684*/ PropertyCollection();
            /*0x117b68c*/ PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x117b694*/ object Clone();
        }

        struct Range
        {
            /*0x10*/ int _min;
            /*0x14*/ int _max;
            /*0x18*/ bool _isNotNull;

            /*0x117b98c*/ Range(int min, int max);
            /*0x11763e0*/ int get_Count();
            /*0x1175f2c*/ bool get_IsNull();
            /*0x1176400*/ int get_Min();
            /*0x117b9d8*/ void CheckNull();
        }

        enum RBTreeError
        {
            InvalidPageSize = 1,
            PagePositionInSlotInUse = 3,
            NoFreeSlots = 4,
            InvalidStateinInsert = 5,
            InvalidNextSizeInDelete = 7,
            InvalidStateinDelete = 8,
            InvalidNodeSizeinDelete = 9,
            InvalidStateinEndDelete = 10,
            CannotRotateInvalidsuccessorNodeinDelete = 11,
            IndexOutOFRangeinGetNodeByIndex = 13,
            RBDeleteFixup = 14,
            UnsupportedAccessMethod1 = 15,
            UnsupportedAccessMethod2 = 16,
            UnsupportedAccessMethodInNonNillRootSubtree = 17,
            AttachedNodeWithZerorbTreeNodeId = 18,
            CompareNodeInDataRowTree = 19,
            CompareSateliteTreeNodeInDataRowTree = 20,
            NestedSatelliteTreeEnumerator = 21,
        }

        enum TreeAccessMethod
        {
            KEY_SEARCH_AND_INDEX = 1,
            INDEX_ONLY = 2,
        }

        class RBTree<K> : System.Collections.IEnumerable
        {
            /*0x0*/ System.Data.RBTree.TreePage<K> _pageTable;
            /*0x0*/ int[] _pageTableMap;
            /*0x0*/ int _inUsePageCount;
            /*0x0*/ int _nextFreePageLine;
            /*0x0*/ int root;
            /*0x0*/ int _version;
            /*0x0*/ int _inUseNodeCount;
            /*0x0*/ int _inUseSatelliteTreeCount;
            /*0x0*/ System.Data.TreeAccessMethod _accessMethod;

            static int GetIntValueFromBitMap(uint bitMap);
            RBTree(System.Data.TreeAccessMethod accessMethod);
            int CompareNode(K record1, K record2);
            int CompareSateliteTreeNode(K record1, K record2);
            void InitTree();
            void FreePage(System.Data.RBTree.TreePage<K> page);
            System.Data.RBTree.TreePage<K> AllocPage(int size);
            void MarkPageFull(System.Data.RBTree.TreePage<K> page);
            void MarkPageFree(System.Data.RBTree.TreePage<K> page);
            void FreeNode(int nodeId);
            int GetIndexOfPageWithFreeSlot(bool allocatedPage);
            int get_Count();
            bool get_HasDuplicates();
            int GetNewNode(K key);
            int Successor(int x_id);
            bool Successor(ref int nodeId, ref int mainTreeNodeId);
            int Minimum(int x_id);
            int LeftRotate(int root_id, int x_id, int mainTreeNode);
            int RightRotate(int root_id, int x_id, int mainTreeNode);
            int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append);
            void UpdateNodeKey(K currentKey, K newKey);
            K DeleteByIndex(int i);
            int RBDelete(int z_id);
            int RBDeleteX(int root_id, int z_id, int mainTreeNodeID);
            int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID);
            int SearchSubTree(int root_id, K key);
            K get_Item(int index);
            System.Data.RBTree.NodePath<K> GetNodeByKey(K key);
            int GetIndexByKey(K key);
            int GetIndexByNode(int node);
            int GetIndexByNodePath(System.Data.RBTree.NodePath<K> path);
            int ComputeIndexByNode(int nodeId);
            int ComputeIndexWithSatelliteByNode(int nodeId);
            System.Data.RBTree.NodePath<K> GetNodeByIndex(int userIndex);
            int ComputeNodeByIndex(int index, ref int satelliteRootId);
            int ComputeNodeByIndex(int x_id, int index);
            int Insert(K item);
            int Add(K item);
            System.Collections.IEnumerator GetEnumerator();
            int IndexOf(int nodeId, K item);
            int Insert(int position, K item);
            int InsertAt(int position, K item, bool append);
            void RemoveAt(int position);
            void Clear();
            void CopyTo(System.Array array, int index);
            void CopyTo(K[] array, int index);
            void SetRight(int nodeId, int rightNodeId);
            void SetLeft(int nodeId, int leftNodeId);
            void SetParent(int nodeId, int parentNodeId);
            void SetColor(int nodeId, System.Data.RBTree.NodeColor<K> color);
            void SetKey(int nodeId, K key);
            void SetNext(int nodeId, int nextNodeId);
            void SetSubTreeSize(int nodeId, int size);
            void IncreaseSize(int nodeId);
            void RecomputeSize(int nodeId);
            void DecreaseSize(int nodeId);
            int Right(int nodeId);
            int Left(int nodeId);
            int Parent(int nodeId);
            System.Data.RBTree.NodeColor<K> color(int nodeId);
            int Next(int nodeId);
            int SubTreeSize(int nodeId);
            K Key(int nodeId);

            enum NodeColor<K>
            {
                red = 0,
                black = 1,
            }

            struct Node<K>
            {
                /*0x0*/ int _selfId;
                /*0x0*/ int _leftId;
                /*0x0*/ int _rightId;
                /*0x0*/ int _parentId;
                /*0x0*/ int _nextId;
                /*0x0*/ int _subTreeSize;
                /*0x0*/ K _keyOfNode;
                /*0x0*/ System.Data.RBTree.NodeColor<K> _nodeColor;
            }

            struct NodePath<K>
            {
                /*0x0*/ int _nodeID;
                /*0x0*/ int _mainTreeNodeID;

                NodePath(int nodeID, int mainTreeNodeID);
            }

            class TreePage<K>
            {
                /*0x0*/ System.Data.RBTree.Node<K> _slots;
                /*0x0*/ int[] _slotMap;
                /*0x0*/ int _inUseCount;
                /*0x0*/ int _pageId;
                /*0x0*/ int _nextFreeSlotLine;

                TreePage(int size);
                int AllocSlot(System.Data.RBTree<K> tree);
                int get_InUseCount();
                void set_InUseCount(int value);
                int get_PageId();
                void set_PageId(int value);
            }

            struct RBTreeEnumerator<K> : System.Collections.Generic.IEnumerator<K>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ System.Data.RBTree<K> _tree;
                /*0x0*/ int _version;
                /*0x0*/ int _index;
                /*0x0*/ int _mainTreeNodeId;
                /*0x0*/ K _current;

                RBTreeEnumerator(System.Data.RBTree<K> tree);
                RBTreeEnumerator(System.Data.RBTree<K> tree, int position);
                void Dispose();
                bool MoveNext();
                K get_Current();
                object System.Collections.IEnumerator.get_Current();
                void System.Collections.IEnumerator.Reset();
            }
        }

        class RecordManager
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _lastFreeRecord;
            /*0x1c*/ int _minimumCapacity;
            /*0x20*/ int _recordCapacity;
            /*0x28*/ System.Collections.Generic.List<int> _freeRecordList;
            /*0x30*/ System.Data.DataRow[] _rows;

            static /*0x117bc18*/ int NewCapacity(int capacity);
            /*0x117ba10*/ RecordManager(System.Data.DataTable table);
            /*0x117badc*/ void GrowRecordCapacity();
            /*0x117bcf4*/ int get_LastFreeRecord();
            /*0x117bcfc*/ int get_MinimumCapacity();
            /*0x117bd04*/ void set_MinimumCapacity(int value);
            /*0x117bd48*/ int get_RecordCapacity();
            /*0x117bc64*/ void set_RecordCapacity(int value);
            /*0x117bc2c*/ int NormalizedMinimumCapacity(int capacity);
            /*0x117bd50*/ int NewRecordBase();
            /*0x117be1c*/ void FreeRecord(ref int record);
            /*0x117bfd4*/ void Clear(bool clearAll);
            /*0x117c1c4*/ System.Data.DataRow get_Item(int record);
            /*0x117bf70*/ void set_Item(int record, System.Data.DataRow value);
            /*0x117c1f4*/ int ImportRecord(System.Data.DataTable src, int record);
            /*0x117c1fc*/ int CopyRecord(System.Data.DataTable src, int record, int copy);
            /*0x117c510*/ void SetRowCache(System.Data.DataRow[] newRows);
        }

        class RelatedView : System.Data.DataView, System.Data.IFilter
        {
            /*0xb8*/ System.Nullable<System.Data.DataKey> _parentKey;
            /*0xc8*/ System.Data.DataKey _childKey;
            /*0xd0*/ System.Data.DataRowView _parentRowView;
            /*0xd8*/ object[] _filterValues;

            /*0x117c534*/ RelatedView(System.Data.DataColumn[] columns, object[] values);
            /*0x117c64c*/ RelatedView(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns);
            /*0x117c754*/ object[] GetParentValues();
            /*0x117c7f0*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x117c968*/ System.Data.IFilter GetFilter();
            /*0x117c96c*/ System.Data.DataRowView AddNew();
            /*0x117c9cc*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
        }

        class RelationshipConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x117c9f0*/ RelationshipConverter();
            /*0x117c9f8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x117cac0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        enum Rule
        {
            None = 0,
            Cascade = 1,
            SetNull = 2,
            SetDefault = 3,
        }

        enum SchemaSerializationMode
        {
            IncludeSchema = 1,
            ExcludeSchema = 2,
        }

        struct IndexField
        {
            /*0x10*/ System.Data.DataColumn Column;
            /*0x18*/ bool IsDescending;

            static /*0x117d578*/ bool op_Equality(System.Data.IndexField if1, System.Data.IndexField if2);
            /*0x117d568*/ IndexField(System.Data.DataColumn column, bool isDescending);
            /*0x117d598*/ bool Equals(object obj);
            /*0x117d620*/ int GetHashCode();
        }

        class Index
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.IndexField[] _indexFields;
            /*0x20*/ System.Comparison<System.Data.DataRow> _comparison;
            /*0x28*/ System.Data.DataViewRowState _recordStates;
            /*0x30*/ System.WeakReference _rowFilter;
            /*0x38*/ System.Data.Index.IndexTree _records;
            /*0x40*/ int _recordCount;
            /*0x44*/ int _refCount;
            /*0x48*/ System.Data.Listeners<System.Data.DataViewListener> _listeners;
            /*0x50*/ bool _suspendEvents;
            /*0x51*/ bool _isSharable;
            /*0x52*/ bool _hasRemoteAggregate;
            /*0x54*/ int _objectID;

            static /*0x117d99c*/ System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns);
            static /*0x117fd54*/ int GetReplaceAction(System.Data.DataViewRowState oldState);
            static int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
            /*0x117d664*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x117d944*/ Index(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x117d674*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x117de40*/ bool Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x117dee8*/ bool get_HasRemoteAggregate();
            /*0x117def0*/ int get_ObjectID();
            /*0x117def8*/ System.Data.DataViewRowState get_RecordStates();
            /*0x117df00*/ System.Data.IFilter get_RowFilter();
            /*0x117df78*/ int GetRecord(int recordIndex);
            /*0x117dfd0*/ bool get_HasDuplicates();
            /*0x117e020*/ int get_RecordCount();
            /*0x117e028*/ bool AcceptRecord(int record);
            /*0x117e054*/ bool AcceptRecord(int record, System.Data.IFilter filter);
            /*0x117e1e8*/ void ListChangedAdd(System.Data.DataViewListener listener);
            /*0x117e240*/ void ListChangedRemove(System.Data.DataViewListener listener);
            /*0x117e298*/ int get_RefCount();
            /*0x117e2a0*/ void AddRef();
            /*0x117e494*/ int RemoveRef();
            /*0x117e650*/ void ApplyChangeAction(int record, int action, int changeRecord);
            /*0x117ea80*/ bool CheckUnique();
            /*0x117ea98*/ int CompareRecords(int record1, int record2);
            /*0x117ebe8*/ int CompareDataRows(int record1, int record2);
            /*0x117ec54*/ int CompareDuplicateRecords(int record1, int record2);
            /*0x117eda0*/ int CompareRecordToKey(int record1, object[] vals);
            /*0x117ee70*/ void DeleteRecordFromIndex(int recordIndex);
            /*0x117ea20*/ void DeleteRecord(int recordIndex);
            /*0x117ee78*/ void DeleteRecord(int recordIndex, bool fireEvent);
            /*0x117f154*/ System.Data.RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex);
            /*0x117ea28*/ int GetIndex(int record);
            /*0x117e8e0*/ int GetIndex(int record, int changeRecord);
            /*0x11759d8*/ object[] GetUniqueKeyValues();
            /*0x117f3d0*/ int FindNodeByKey(object originalKey);
            /*0x117f5e4*/ int FindNodeByKeys(object[] originalKey);
            /*0x117f814*/ int FindNodeByKeyRecord(int record);
            /*0x117f908*/ System.Data.Range GetRangeFromNode(int nodeId);
            /*0x117fa30*/ System.Data.Range FindRecords(object key);
            /*0x1175b04*/ System.Data.Range FindRecords(object[] key);
            /*0x117fa54*/ void FireResetEvent();
            /*0x117fd38*/ int GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x1176418*/ System.Data.DataRow GetRow(int i);
            /*0x117fd7c*/ System.Data.DataRow[] GetRows(object[] values);
            /*0x1175b28*/ System.Data.DataRow[] GetRows(System.Data.Range range);
            /*0x117da60*/ void InitRecords(System.Data.IFilter filter);
            /*0x117fe08*/ int InsertRecordToIndex(int record);
            /*0x117e6f4*/ int InsertRecord(int record, bool fireEvent);
            /*0x117fe58*/ bool IsKeyInIndex(object key);
            /*0x1175aec*/ bool IsKeyInIndex(object[] key);
            /*0x117fe70*/ bool IsKeyRecordInIndex(int record);
            /*0x117fb3c*/ bool get_DoListChanged();
            /*0x117fe88*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int newIndex, int oldIndex);
            /*0x117f0bc*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int index);
            /*0x117fbbc*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x117ef9c*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, int record, bool trackAddRemove);
            /*0x117ff30*/ void Reset();
            /*0x117fff8*/ void RecordChanged(int record);
            /*0x11800dc*/ void RecordChanged(int oldIndex, int newIndex);
            /*0x1180210*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x1180318*/ void RecordStateChanged(int oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, int newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState);
            /*0x1180698*/ System.Data.DataTable get_Table();
            /*0x117f1bc*/ void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId);

            class IndexTree : System.Data.RBTree<int>
            {
                /*0x40*/ System.Data.Index _index;

                /*0x117fda8*/ IndexTree(System.Data.Index index);
                /*0x11806a0*/ int CompareNode(int record1, int record2);
                /*0x11806b8*/ int CompareSateliteTreeNode(int record1, int record2);
            }

            class <>c
            {
                static /*0x0*/ System.Data.Index.<> <>9;
                static /*0x8*/ System.Data.Listeners.Func<System.Data.DataViewListener, System.Data.DataViewListener, bool> <>9__22_0;
                static /*0x10*/ System.Data.Listeners.Action<System.Data.DataViewListener, System.Data.DataViewListener, System.ComponentModel.ListChangedEventArgs, bool, bool> <>9__85_0;

                static /*0x11806d0*/ <>c();
                /*0x1180734*/ <>c();
                /*0x118073c*/ bool <.ctor>b__22_0(System.Data.DataViewListener listener);
                /*0x1180748*/ void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, bool arg2, bool arg3);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ System.ComponentModel.ListChangedType changedType;

                /*0x117ff28*/ <>c__DisplayClass86_0();
                /*0x1180764*/ void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, bool track);
            }
        }

        class Listeners<TElem>
        {
            /*0x0*/ System.Collections.Generic.List<TElem> _listeners;
            /*0x0*/ System.Data.Listeners.Func<TElem, TElem, bool> _filter;
            /*0x0*/ int _objectID;
            /*0x0*/ int _listenerReaderCount;

            Listeners(int ObjectID, System.Data.Listeners.Func<TElem, TElem, bool> notifyFilter);
            bool get_HasListeners();
            void Add(TElem listener);
            int IndexOfReference(TElem listener);
            void Remove(TElem listener);
            void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem, TElem, T1, T2, T3> action);
            void RemoveNullListeners(int nullIndex);

            class Action`4<TElem, T1, T2, T3, T4> : System.MulticastDelegate
            {
                Action`4(object object, nint method);
                void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            }

            class Func`2<TElem, T1, TResult> : System.MulticastDelegate
            {
                Func`2(object object, nint method);
                TResult Invoke(T1 arg1);
            }
        }

        class SimpleType : System.Runtime.Serialization.ISerializable
        {
            /*0x10*/ string _baseType;
            /*0x18*/ System.Data.SimpleType _baseSimpleType;
            /*0x20*/ System.Xml.XmlQualifiedName _xmlBaseType;
            /*0x28*/ string _name;
            /*0x30*/ int _length;
            /*0x34*/ int _minLength;
            /*0x38*/ int _maxLength;
            /*0x40*/ string _pattern;
            /*0x48*/ string _ns;
            /*0x50*/ string _maxExclusive;
            /*0x58*/ string _maxInclusive;
            /*0x60*/ string _minExclusive;
            /*0x68*/ string _minInclusive;
            /*0x70*/ string _enumeration;

            static /*0x11818c8*/ System.Data.SimpleType CreateEnumeratedType(string values);
            static /*0x1181940*/ System.Data.SimpleType CreateByteArrayType(string encoding);
            static /*0x11819b0*/ System.Data.SimpleType CreateLimitedStringType(int length);
            static /*0x1181a28*/ System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type);
            /*0x1180790*/ SimpleType(string baseType);
            /*0x118081c*/ SimpleType(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x11811d0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x118093c*/ void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x1181210*/ bool IsPlainString();
            /*0x1181348*/ string get_BaseType();
            /*0x1181350*/ System.Xml.XmlQualifiedName get_XmlBaseType();
            /*0x1181358*/ string get_Name();
            /*0x1181360*/ string get_Namespace();
            /*0x1181368*/ int get_Length();
            /*0x1181370*/ int get_MaxLength();
            /*0x1181378*/ void set_MaxLength(int value);
            /*0x1181380*/ System.Data.SimpleType get_BaseSimpleType();
            /*0x1181388*/ string get_SimpleTypeQualifiedName();
            /*0x11813f8*/ string QualifiedName(string name);
            /*0x1181474*/ System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, bool inRemoting);
            /*0x1181b18*/ string HasConflictingDefinition(System.Data.SimpleType otherSimpleType);
            /*0x1181c18*/ bool CanHaveMaxLength();
            /*0x1181c7c*/ void ConvertToAnnonymousSimpleType();
        }

        class UniqueConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.DataKey _key;
            /*0x40*/ System.Data.Index _constraintIndex;
            /*0x48*/ bool _bPrimaryKey;
            /*0x50*/ string _constraintName;
            /*0x58*/ string[] _columnNames;

            /*0x1181cf0*/ UniqueConstraint(System.Data.DataColumn column);
            /*0x1181e94*/ UniqueConstraint(string name, System.Data.DataColumn[] columns);
            /*0x1181ec8*/ UniqueConstraint(System.Data.DataColumn[] columns);
            /*0x1181ef8*/ UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey);
            /*0x1181f34*/ UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey);
            /*0x1181f78*/ string[] get_ColumnNames();
            /*0x1181f84*/ System.Data.Index get_ConstraintIndex();
            /*0x1181f8c*/ void ConstraintIndexClear();
            /*0x1181fac*/ void ConstraintIndexInitialize();
            /*0x1181fe4*/ void CheckState();
            /*0x1181ff0*/ void NonVirtualCheckState();
            /*0x1181ffc*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x1182000*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x1182164*/ bool CanEnableConstraint();
            /*0x11821b0*/ bool IsConstraintViolated();
            /*0x1182410*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1182510*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x118251c*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x118252c*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x1182a70*/ System.Data.UniqueConstraint Clone(System.Data.DataTable table);
            /*0x1182f1c*/ System.Data.DataColumn[] get_Columns();
            /*0x1182508*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x1182f28*/ bool get_IsPrimaryKey();
            /*0x1181da0*/ void Create(string constraintName, System.Data.DataColumn[] columns);
            /*0x1182f6c*/ bool Equals(object key2);
            /*0x1183024*/ int GetHashCode();
            /*0x118302c*/ void set_InCollection(bool value);
            /*0x118307c*/ System.Data.DataKey get_Key();
            /*0x1183084*/ System.Data.DataTable get_Table();
        }

        class XDRSchema : System.Data.XMLSchema
        {
            static /*0x0*/ char[] s_colonArray;
            static /*0x8*/ System.Data.XDRSchema.NameType[] s_mapNameTypeXdr;
            static /*0x10*/ System.Data.XDRSchema.NameType s_enumerationNameType;
            /*0x10*/ string _schemaName;
            /*0x18*/ string _schemaUri;
            /*0x20*/ System.Xml.XmlElement _schemaRoot;
            /*0x28*/ System.Data.DataSet _ds;

            static /*0x1185b24*/ XDRSchema();
            static /*0x118449c*/ System.Data.XDRSchema.NameType FindNameType(string name);
            /*0x11830b8*/ XDRSchema(System.Data.DataSet ds, bool fInline);
            /*0x1183130*/ void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds);
            /*0x1183570*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node);
            /*0x1183894*/ bool IsTextOnlyContent(System.Xml.XmlElement node);
            /*0x1183a64*/ bool IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x11833b0*/ System.Data.DataTable HandleTable(System.Xml.XmlElement node);
            /*0x1184570*/ System.Type ParseDataType(string dt, string dtValues);
            /*0x11846ac*/ string GetInstanceName(System.Xml.XmlElement node);
            /*0x1184824*/ void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table);
            /*0x1183ba8*/ void GetMinMax(System.Xml.XmlElement elNode, ref int minOccurs, ref int maxOccurs);
            /*0x11851ac*/ void GetMinMax(System.Xml.XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs);
            /*0x118593c*/ void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren);
            /*0x1183de4*/ System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x1183bb8*/ System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x1186cf0*/ NameType(string n, System.Type t);
                /*0x1186d1c*/ int CompareTo(object obj);
            }
        }

        class XMLDiffLoader
        {
            /*0x10*/ System.Collections.ArrayList _tables;
            /*0x18*/ System.Data.DataSet _dataSet;
            /*0x20*/ System.Data.DataTable _dataTable;

            /*0x11893a4*/ XMLDiffLoader();
            /*0x1186d8c*/ void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader);
            /*0x11875ac*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x1187930*/ void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader);
            /*0x1186f30*/ void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x1187b28*/ void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync);
            /*0x118720c*/ void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x1187df8*/ void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync);
            /*0x11891d8*/ System.Data.DataTable GetTable(string tableName, string ns);
            /*0x1188308*/ int ReadOldRowData(System.Data.DataSet ds, ref System.Data.DataTable table, ref int pos, System.Xml.XmlReader row);
            /*0x11882a8*/ void SkipWhitespaces(System.Xml.XmlReader reader);
        }

        class XMLSchema
        {
            static /*0x11893ac*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x11854f4*/ void SetProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x118333c*/ bool FEqualIdentity(System.Xml.XmlNode node, string name, string ns);
            static /*0x1189404*/ bool GetBooleanAttribute(System.Xml.XmlElement element, string attrName, string attrNS, bool defVal);
            static /*0x1185084*/ string GenUniqueColumnName(string proposedName, System.Data.DataTable table);
            /*0x1183128*/ XMLSchema();
        }

        class ConstraintTable
        {
            /*0x10*/ System.Data.DataTable table;
            /*0x18*/ System.Xml.Schema.XmlSchemaIdentityConstraint constraint;

            /*0x11ce108*/ ConstraintTable(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c);
        }

        class XSDSchema : System.Data.XMLSchema
        {
            static /*0x0*/ System.Data.XSDSchema.NameType[] s_mapNameTypeXsd;
            /*0x10*/ System.Xml.Schema.XmlSchemaSet _schemaSet;
            /*0x18*/ System.Xml.Schema.XmlSchemaElement _dsElement;
            /*0x20*/ System.Data.DataSet _ds;
            /*0x28*/ string _schemaName;
            /*0x30*/ System.Collections.ArrayList _columnExpressions;
            /*0x38*/ System.Collections.Hashtable _constraintNodes;
            /*0x40*/ System.Collections.ArrayList _refTables;
            /*0x48*/ System.Collections.ArrayList _complexTypes;
            /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection _annotations;
            /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection _elements;
            /*0x60*/ System.Collections.Hashtable _attributes;
            /*0x68*/ System.Collections.Hashtable _elementsTable;
            /*0x70*/ System.Collections.Hashtable _attributeGroups;
            /*0x78*/ System.Collections.Hashtable _schemaTypes;
            /*0x80*/ System.Collections.Hashtable _expressions;
            /*0x88*/ System.Collections.Generic.Dictionary<System.Data.DataTable, System.Collections.Generic.List<System.Data.DataTable>> _tableDictionary;
            /*0x90*/ System.Collections.Hashtable _udSimpleTypes;
            /*0x98*/ System.Collections.Hashtable _existingSimpleTypeMap;
            /*0xa0*/ bool _fromInference;

            static /*0x11dd2e8*/ XSDSchema();
            static /*0x11cecb8*/ string QualifiedName(string name);
            static /*0x11ced34*/ void SetProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x11cf288*/ void SetExtProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x11ceba0*/ string GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, string ln);
            static /*0x11cf814*/ void SetExtProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x11d98d4*/ System.Data.AcceptRejectRule TranslateAcceptRejectRule(string strRule);
            static /*0x11d9958*/ System.Data.Rule TranslateRule(string strRule);
            static /*0x11dc928*/ System.Type XsdtoClr(string xsdTypeName);
            static /*0x11dca04*/ System.Data.XSDSchema.NameType FindNameType(string name);
            static /*0x11dcc44*/ bool IsXsdType(string name);
            /*0x11dd2e0*/ XSDSchema();
            /*0x11ce134*/ bool get_FromInference();
            /*0x11ce13c*/ void set_FromInference(bool value);
            /*0x11ce148*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema);
            /*0x11ce1d0*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList);
            /*0x11cf618*/ void HandleColumnExpression(object instance, System.Xml.XmlAttribute[] attrs);
            /*0x11cfa58*/ void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element);
            /*0x11cfc14*/ void HandleRelation(System.Xml.XmlElement node, bool fNested);
            /*0x11d044c*/ bool HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
            /*0x11d06e4*/ bool IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x11d1108*/ int DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x11d14a8*/ System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x11d1a9c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt);
            /*0x11d1ac0*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds);
            /*0x11d52e0*/ void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, bool fNested);
            /*0x11d0c8c*/ System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x11d560c*/ void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isBase);
            /*0x11d6d14*/ void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, bool isBase);
            /*0x11d79ac*/ void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, bool isBase);
            /*0x11d7d90*/ void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isNillable);
            /*0x11d1958*/ System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct);
            /*0x11d948c*/ System.Data.DataColumn FindField(System.Data.DataTable table, string field);
            /*0x11d9608*/ System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table);
            /*0x11d1350*/ bool GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, bool defVal);
            /*0x11d3b04*/ string GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, string defVal);
            /*0x11d9a44*/ void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref);
            /*0x11da308*/ void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode);
            /*0x11da748*/ System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x11cfb3c*/ string GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x11db2a4*/ System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, bool isRef);
            /*0x11dcad8*/ System.Type ParseDataType(string dt);
            /*0x11d3b88*/ System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x11d8b00*/ void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x11d837c*/ void HandleSimpleContentColumn(string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x11d7010*/ void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, bool isBase);
            /*0x11d6000*/ void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, bool isBase);
            /*0x11d4014*/ void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, bool isNewDataSet);
            /*0x11dccb4*/ void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt);
            /*0x11dae80*/ string GetPrefix(string ns);
            /*0x11dceb4*/ string GetNamespaceFromPrefix(string prefix);
            /*0x11dc798*/ string GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x11da1f0*/ string GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x11d0e9c*/ bool IsTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x11d3e9c*/ System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x11de7c4*/ NameType(string n, System.Type t);
                /*0x11de7f0*/ int CompareTo(object obj);
            }
        }

        class XmlIgnoreNamespaceReader : System.Xml.XmlNodeReader
        {
            /*0x30*/ System.Collections.Generic.List<string> _namespacesToIgnore;

            /*0x11de860*/ XmlIgnoreNamespaceReader(System.Xml.XmlDocument xdoc, string[] namespacesToIgnore);
            /*0x11de8f8*/ bool MoveToFirstAttribute();
            /*0x11dea08*/ bool MoveToNextAttribute();
        }

        class XmlDataLoader
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.XmlToDatasetMap _nodeToSchemaMap;
            /*0x20*/ System.Collections.Hashtable _nodeToRowMap;
            /*0x28*/ System.Collections.Stack _childRowsStack;
            /*0x30*/ System.Collections.Hashtable _htableExcludedNS;
            /*0x38*/ bool _fIsXdr;
            /*0x39*/ bool _isDiffgram;
            /*0x40*/ System.Xml.XmlElement _topMostNode;
            /*0x48*/ bool _ignoreSchema;
            /*0x50*/ System.Data.DataTable _dataTable;
            /*0x58*/ bool _isTableLevel;
            /*0x59*/ bool _fromInference;
            /*0x60*/ System.Xml.XmlReader _dataReader;
            /*0x68*/ object _XSD_XMLNS_NS;
            /*0x70*/ object _XDR_SCHEMA;
            /*0x78*/ object _XDRNS;
            /*0x80*/ object _SQL_SYNC;
            /*0x88*/ object _UPDGNS;
            /*0x90*/ object _XSD_SCHEMA;
            /*0x98*/ object _XSDNS;
            /*0xa0*/ object _DFFNS;
            /*0xa8*/ object _MSDNS;
            /*0xb0*/ object _DIFFID;
            /*0xb8*/ object _HASCHANGES;
            /*0xc0*/ object _ROWORDER;

            /*0x11deb14*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, bool ignoreSchema);
            /*0x11debb0*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x11dec88*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, bool ignoreSchema);
            /*0x11ded30*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x11dee14*/ bool get_FromInference();
            /*0x11dee1c*/ void set_FromInference(bool value);
            /*0x11dee28*/ void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x11df01c*/ int CountNonNSAttributes(System.Xml.XmlNode node);
            /*0x11df19c*/ string GetValueForTextOnlyColums(System.Xml.XmlNode n);
            /*0x11df3b8*/ string GetInitialTextFromNodes(ref System.Xml.XmlNode n);
            /*0x11df58c*/ System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row);
            /*0x11def84*/ System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e);
            /*0x11df64c*/ bool FColumnElement(System.Xml.XmlElement e);
            /*0x11df110*/ bool FExcludedNamespace(string ns);
            /*0x11df734*/ bool FIgnoreNamespace(System.Xml.XmlNode node);
            /*0x11df9f8*/ bool FIgnoreNamespace(System.Xml.XmlReader node);
            /*0x11df364*/ bool IsTextLikeNode(System.Xml.XmlNodeType n);
            /*0x11df620*/ bool IsTextOnly(System.Data.DataColumn c);
            /*0x11dfa80*/ void LoadData(System.Xml.XmlDocument xdoc);
            /*0x11dfec4*/ void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement);
            /*0x11e0b44*/ void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x11e0e84*/ void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, string xmlText);
            /*0x11e0ef4*/ void InitNameTable();
            /*0x11e1170*/ void LoadData(System.Xml.XmlReader reader);
            /*0x11e14f0*/ void LoadTopMostTable(System.Data.DataTable table);
            /*0x11e2108*/ void LoadTable(System.Data.DataTable table, bool isNested);
            /*0x11e2f4c*/ void LoadColumn(System.Data.DataColumn column, object[] foundColumns);
            /*0x11e1ef4*/ bool ProcessXsdSchema();
        }

        enum XmlReadMode
        {
            Auto = 0,
            ReadSchema = 1,
            IgnoreSchema = 2,
            InferSchema = 3,
            DiffGram = 4,
            Fragment = 5,
            InferTypedSchema = 6,
        }

        class XmlToDatasetMap
        {
            /*0x10*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap;
            /*0x18*/ System.Data.XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo;

            static /*0x11e0ecc*/ bool IsMappedColumn(System.Data.DataColumn c);
            /*0x11dfda0*/ XmlToDatasetMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x11e1488*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x11dfd6c*/ XmlToDatasetMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x11e14bc*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x11e5850*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable);
            /*0x11e59a8*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table);
            /*0x11e5b24*/ bool AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x11e5dbc*/ bool AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x11e3864*/ void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x11e3e84*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x11e49d0*/ void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x11e4d38*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x11e5f6c*/ System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt);
            /*0x11df814*/ object GetColumnSchema(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x11e2e1c*/ object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, bool fIgnoreNamespace);
            /*0x11dfdd4*/ object GetSchemaForNode(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x11e1e34*/ System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, bool fIgnoreNamespace);
            /*0x11e5c5c*/ void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);

            class XmlNodeIdentety
            {
                /*0x10*/ string LocalName;
                /*0x18*/ string NamespaceURI;

                /*0x11e597c*/ XmlNodeIdentety(string localName, string namespaceURI);
                /*0x11e63b8*/ int GetHashCode();
                /*0x11e63d8*/ bool Equals(object obj);
            }

            class XmlNodeIdHashtable : System.Collections.Hashtable
            {
                /*0x50*/ System.Data.XmlToDatasetMap.XmlNodeIdentety _id;

                /*0x12bcb08*/ XmlNodeIdHashtable(int capacity);
                /*0x12bcba8*/ object get_Item(System.Xml.XmlNode node);
                /*0x12bcc20*/ object get_Item(System.Xml.XmlReader dataReader);
                /*0x12bcc90*/ object get_Item(System.Data.DataTable table);
                /*0x12bccf8*/ object get_Item(string name);
            }

            class TableSchemaInfo
            {
                /*0x10*/ System.Data.DataTable TableSchema;
                /*0x18*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;

                /*0x12bcd6c*/ TableSchemaInfo(System.Data.DataTable tableSchema);
            }
        }

        enum XmlWriteMode
        {
            WriteSchema = 0,
            IgnoreSchema = 1,
            DiffGram = 2,
        }

        enum SchemaFormat
        {
            Public = 1,
            Remoting = 2,
            WebService = 3,
            RemotingSkipSchema = 4,
            WebServiceSkipSchema = 5,
        }

        class XmlTreeGen
        {
            /*0x10*/ System.Collections.ArrayList _constraintNames;
            /*0x18*/ System.Collections.Hashtable _namespaces;
            /*0x20*/ System.Collections.Hashtable _autogenerated;
            /*0x28*/ System.Collections.Hashtable _prefixes;
            /*0x30*/ System.Data.DataSet _ds;
            /*0x38*/ System.Collections.ArrayList _tables;
            /*0x40*/ System.Collections.ArrayList _relations;
            /*0x48*/ System.Xml.XmlDocument _dc;
            /*0x50*/ System.Xml.XmlElement _sRoot;
            /*0x58*/ int _prefixCount;
            /*0x5c*/ System.Data.SchemaFormat _schFormat;
            /*0x60*/ string _filePath;
            /*0x68*/ string _fileName;
            /*0x70*/ string _fileExt;
            /*0x78*/ System.Xml.XmlElement _dsElement;
            /*0x80*/ System.Xml.XmlElement _constraintSeparator;
            /*0x88*/ System.Converter<System.Type, string> _targetConverter;

            static /*0x12bcea0*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node);
            static /*0x12bcea8*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type);
            static /*0x12be0e0*/ string XmlDataTypeName(System.Type type);
            static /*0x12bf8a8*/ bool _PropsNotEmpty(System.Data.PropertyCollection props);
            static /*0x12bfcb8*/ void ValidateColumnMapping(System.Type columnType);
            static /*0x12c81d0*/ System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, string name);
            static /*0x12c9de4*/ string TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule);
            static /*0x12c9e50*/ string TranslateRule(System.Data.Rule rule);
            static /*0x12c0b58*/ bool AutoGenerated(System.Data.DataColumn col);
            static /*0x12ca2ac*/ bool AutoGenerated(System.Data.DataRelation rel);
            static /*0x12c10dc*/ bool AutoGenerated(System.Data.UniqueConstraint unique);
            static /*0x12ca390*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk, bool checkRelation);
            /*0x12bce00*/ XmlTreeGen(System.Data.SchemaFormat format);
            /*0x12bd60c*/ void AddXdoProperties(object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x12bd7bc*/ void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x12befa4*/ void GenerateConstraintNames(System.Data.DataTable table, bool fromTable);
            /*0x12bf4cc*/ void GenerateConstraintNames(System.Collections.ArrayList tables);
            /*0x12bf5c4*/ void GenerateConstraintNames(System.Data.DataSet ds);
            /*0x12bf8d0*/ bool HaveExtendedProperties(System.Data.DataSet ds);
            /*0x12bfa54*/ void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, string targetNamespace);
            /*0x12bfd40*/ void SetupAutoGenerated(System.Data.DataSet ds);
            /*0x12c0a64*/ void SetupAutoGenerated(System.Collections.ArrayList dt);
            /*0x12c0020*/ void SetupAutoGenerated(System.Data.DataTable dt);
            /*0x12c11b0*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x12c1534*/ void CreateRelations(System.Data.DataTable dt);
            /*0x12c188c*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x12c1b60*/ void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, bool writeHierarchy);
            /*0x12c4f1c*/ System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt);
            /*0x12c4280*/ System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt);
            /*0x12c7cf4*/ void SetPath(System.Xml.XmlWriter xw);
            /*0x12c7f90*/ void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw);
            /*0x12c7fb0*/ void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x12c7fa4*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x12c8070*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy);
            /*0x12c807c*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x12c4960*/ System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc);
            /*0x12c82c4*/ System.Xml.XmlElement GetSchema(string NamespaceURI);
            /*0x12c8558*/ void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema);
            /*0x12c89d0*/ void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root);
            /*0x12c8fdc*/ string FindTargetNamespace(System.Data.DataTable table);
            /*0x12c90ec*/ System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool fWriteOrdinal);
            /*0x12c48a8*/ void AppendChildWithoutRef(System.Xml.XmlElement node, string Namespace, System.Xml.XmlElement el, string refString);
            /*0x12c9c1c*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, string strType);
            /*0x12c48a0*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema);
            /*0x12c9f08*/ bool HasMixedColumns(System.Data.DataTable table);
            /*0x12c10d0*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk);
            /*0x12ca4d0*/ bool IsAutoGenerated(object o);
            /*0x12c5360*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool genNested);
            /*0x12bedc4*/ void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type);
        }

        class NewDiffgramGen
        {
            /*0x10*/ System.Xml.XmlDocument _doc;
            /*0x18*/ System.Data.DataSet _ds;
            /*0x20*/ System.Data.DataTable _dt;
            /*0x28*/ System.Xml.XmlWriter _xmlw;
            /*0x30*/ bool _fBefore;
            /*0x31*/ bool _fErrors;
            /*0x38*/ System.Collections.Hashtable _rowsOrder;
            /*0x40*/ System.Collections.ArrayList _tables;
            /*0x48*/ bool _writeHierarchy;

            static /*0x12ca514*/ string QualifiedName(string prefix, string name);
            /*0x12ca57c*/ NewDiffgramGen(System.Data.DataSet ds);
            /*0x12ca8fc*/ NewDiffgramGen(System.Data.DataTable dt, bool writeHierarchy);
            /*0x12ca9e8*/ void CreateTableHierarchy(System.Data.DataTable dt);
            /*0x12ca694*/ void DoAssignments(System.Collections.ArrayList tables);
            /*0x12cad6c*/ bool EmptyData();
            /*0x12cae58*/ void Save(System.Xml.XmlWriter xmlw);
            /*0x12cae60*/ void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table);
            /*0x12cbdec*/ void GenerateTable(System.Data.DataTable table);
            /*0x12cbe68*/ void GenerateTableErrors(System.Data.DataTable table);
            /*0x12cc3a8*/ void GenerateRow(System.Data.DataRow row);
            /*0x12cca04*/ void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version);
        }

        class XmlDataTreeWriter
        {
            /*0x10*/ System.Xml.XmlWriter _xmlw;
            /*0x18*/ System.Data.DataSet _ds;
            /*0x20*/ System.Data.DataTable _dt;
            /*0x28*/ System.Collections.ArrayList _dTables;
            /*0x30*/ System.Data.DataTable[] _topLevelTables;
            /*0x38*/ bool _fFromTable;
            /*0x39*/ bool _isDiffgram;
            /*0x40*/ System.Collections.Hashtable _rowsOrder;
            /*0x48*/ bool _writeHierarchy;

            static /*0x12cc93c*/ bool RowHasErrors(System.Data.DataRow row);
            static /*0x12cd410*/ bool PreserveSpace(object value);
            /*0x12cbaa4*/ XmlDataTreeWriter(System.Data.DataSet ds);
            /*0x12cb2a8*/ XmlDataTreeWriter(System.Data.DataTable dt, bool writeHierarchy);
            /*0x12cd848*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x12cd4c4*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x12cb3fc*/ void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder);
            /*0x12cf420*/ void Save(System.Xml.XmlWriter xw, bool writeSchema);
            /*0x12cfcec*/ System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row);
            /*0x12cdb1c*/ void XmlDataRowWriter(System.Data.DataRow row, string encodedTableName);
        }

        class DataTextWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter _xmltextWriter;

            static /*0x12cb244*/ System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw);
            /*0x12d002c*/ DataTextWriter(System.Xml.XmlWriter w);
            /*0x12c7efc*/ System.IO.Stream get_BaseStream();
            /*0x12d0054*/ void WriteStartDocument();
            /*0x12d0074*/ void WriteStartDocument(bool standalone);
            /*0x12d0098*/ void WriteEndDocument();
            /*0x12d00b8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x12d00d8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x12d00f8*/ void WriteEndElement();
            /*0x12d0118*/ void WriteFullEndElement();
            /*0x12d0138*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x12d0158*/ void WriteEndAttribute();
            /*0x12d017c*/ void WriteCData(string text);
            /*0x12d01a0*/ void WriteComment(string text);
            /*0x12d01c4*/ void WriteProcessingInstruction(string name, string text);
            /*0x12d01e8*/ void WriteEntityRef(string name);
            /*0x12d020c*/ void WriteCharEntity(char ch);
            /*0x12d0230*/ void WriteWhitespace(string ws);
            /*0x12d0254*/ void WriteString(string text);
            /*0x12d0278*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x12d029c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x12d02c0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x12d02e4*/ void WriteRaw(string data);
            /*0x12d0308*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x12d032c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x12d0350*/ System.Xml.WriteState get_WriteState();
            /*0x12d0374*/ void Close();
            /*0x12d0398*/ void Flush();
            /*0x12d03bc*/ string LookupPrefix(string ns);
        }

        class DataTextReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader _xmlreader;

            static /*0x12d03e0*/ System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr);
            /*0x12d0440*/ DataTextReader(System.Xml.XmlReader input);
            /*0x12d04ac*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x12d04cc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x12d04ec*/ string get_Name();
            /*0x12d050c*/ string get_LocalName();
            /*0x12d052c*/ string get_NamespaceURI();
            /*0x12d054c*/ string get_Prefix();
            /*0x12d056c*/ string get_Value();
            /*0x12d058c*/ int get_Depth();
            /*0x12d05ac*/ string get_BaseURI();
            /*0x12d05d0*/ bool get_IsEmptyElement();
            /*0x12d05f4*/ bool get_IsDefault();
            /*0x12d0618*/ char get_QuoteChar();
            /*0x12d063c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x12d0660*/ string get_XmlLang();
            /*0x12d0684*/ int get_AttributeCount();
            /*0x12d06a8*/ string GetAttribute(string name);
            /*0x12d06cc*/ string GetAttribute(string localName, string namespaceURI);
            /*0x12d06f0*/ string GetAttribute(int i);
            /*0x12d0714*/ bool MoveToAttribute(string name);
            /*0x12d0738*/ void MoveToAttribute(int i);
            /*0x12d075c*/ bool MoveToFirstAttribute();
            /*0x12d0780*/ bool MoveToNextAttribute();
            /*0x12d07a4*/ bool MoveToElement();
            /*0x12d07c8*/ bool ReadAttributeValue();
            /*0x12d07ec*/ bool Read();
            /*0x12d0810*/ bool get_EOF();
            /*0x12d0834*/ void Close();
            /*0x12d0858*/ System.Xml.ReadState get_ReadState();
            /*0x12d087c*/ void Skip();
            /*0x12d08a0*/ System.Xml.XmlNameTable get_NameTable();
            /*0x12d08c4*/ string LookupNamespace(string prefix);
            /*0x12d08e8*/ bool get_CanResolveEntity();
            /*0x12d090c*/ void ResolveEntity();
            /*0x12d0930*/ bool get_CanReadValueChunk();
            /*0x12d0954*/ string ReadString();
        }

        namespace SqlTypes
        {
            class SQLResource
            {
                static /*0x12d0978*/ string get_NullString();
                static /*0x12d09b8*/ string get_ArithOverflowMessage();
                static /*0x12d09f8*/ string get_DivideByZeroMessage();
                static /*0x12d0a38*/ string get_NullValueMessage();
                static /*0x12d0a78*/ string get_TruncationMessage();
                static /*0x12d0ab8*/ string get_DateTimeOverflowMessage();
                static /*0x12d0af8*/ string get_ConcatDiffCollationMessage();
                static /*0x12d0b38*/ string get_CompareDiffCollationMessage();
                static /*0x12d0b78*/ string get_ConversionOverflowMessage();
                static /*0x12d0bb8*/ string get_TimeZoneSpecifiedMessage();
                static /*0x12d0bf8*/ string get_InvalidPrecScaleMessage();
                static /*0x12d0c38*/ string get_FormatMessage();
                static /*0x12d0c78*/ string InvalidOpStreamClosed(string method);
                static /*0x12d0cc4*/ string InvalidOpStreamNonWritable(string method);
                static /*0x12d0d10*/ string InvalidOpStreamNonReadable(string method);
                static /*0x12d0d5c*/ string InvalidOpStreamNonSeekable(string method);
            }

            interface INullable
            {
                bool get_IsNull();
            }

            struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBinary Null;
                /*0x10*/ byte[] _value;

                static /*0x12d1adc*/ SqlBinary();
                static /*0x12d0ef0*/ System.Data.SqlTypes.SqlBinary op_Implicit(byte[] x);
                static /*0x12d0ffc*/ System.Data.SqlTypes.EComparison PerformCompareByte(byte[] x, byte[] y);
                static /*0x12d10f0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x12d11d8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x12d12ac*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x12d16ac*/ int HashByteArray(byte[] rgbValue, int length);
                static /*0x12d1a50*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x12d0da8*/ SqlBinary(bool fNull);
                /*0x12d0db0*/ SqlBinary(byte[] value);
                /*0x12d0e28*/ bool get_IsNull();
                /*0x12d0e38*/ byte[] get_Value();
                /*0x12d0f10*/ string ToString();
                /*0x12d1380*/ int CompareTo(object value);
                /*0x12d146c*/ int CompareTo(System.Data.SqlTypes.SqlBinary value);
                /*0x12d1588*/ bool Equals(object value);
                /*0x12d1714*/ int GetHashCode();
                /*0x12d17b8*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x12d17c0*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x12d1954*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBoolean True;
                static /*0x1*/ System.Data.SqlTypes.SqlBoolean False;
                static /*0x2*/ System.Data.SqlTypes.SqlBoolean Null;
                static /*0x3*/ System.Data.SqlTypes.SqlBoolean Zero;
                static /*0x4*/ System.Data.SqlTypes.SqlBoolean One;
                /*0x10*/ byte m_value;

                static /*0x12d2430*/ SqlBoolean();
                static /*0x12d1b84*/ System.Data.SqlTypes.SqlBoolean op_Implicit(bool x);
                static /*0x12d1578*/ bool op_True(System.Data.SqlTypes.SqlBoolean x);
                static /*0x12d1b94*/ System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x12d1c54*/ System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x12d1dd4*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x12d1e5c*/ System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x12d1ec8*/ System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x12d23a4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x12d11c4*/ SqlBoolean(bool value);
                /*0x12d1b24*/ SqlBoolean(int value);
                /*0x12d1b38*/ SqlBoolean(int value, bool fNull);
                /*0x12d1b54*/ bool get_IsNull();
                /*0x12d1644*/ bool get_Value();
                /*0x12d1b64*/ bool get_IsTrue();
                /*0x12d1b74*/ bool get_IsFalse();
                /*0x12d1d14*/ byte get_ByteValue();
                /*0x12d1d6c*/ string ToString();
                /*0x12d1f34*/ int CompareTo(object value);
                /*0x12d2020*/ int CompareTo(System.Data.SqlTypes.SqlBoolean value);
                /*0x12d209c*/ bool Equals(object value);
                /*0x12d2158*/ int GetHashCode();
                /*0x12d2190*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x12d2198*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x12d22bc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlByte : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_iBitNotByteMax;
                static /*0x4*/ System.Data.SqlTypes.SqlByte Null;
                static /*0x6*/ System.Data.SqlTypes.SqlByte Zero;
                static /*0x8*/ System.Data.SqlTypes.SqlByte MinValue;
                static /*0xa*/ System.Data.SqlTypes.SqlByte MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x11*/ byte m_value;

                static /*0x12d3370*/ SqlByte();
                static /*0x12d252c*/ System.Data.SqlTypes.SqlByte op_Implicit(byte x);
                static /*0x12d259c*/ System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d269c*/ System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d279c*/ System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d289c*/ System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d2978*/ System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x12d2a8c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d2b18*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d2ba4*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d2c30*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d2c9c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x12d32e4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x12d24b0*/ SqlByte(bool fNull);
                /*0x12d24b8*/ SqlByte(byte value);
                /*0x12d24c8*/ bool get_IsNull();
                /*0x12d24d8*/ byte get_Value();
                /*0x12d253c*/ string ToString();
                /*0x12d2d08*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x12d2d64*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x12d2dc0*/ int CompareTo(object value);
                /*0x12d2eac*/ int CompareTo(System.Data.SqlTypes.SqlByte value);
                /*0x12d2fc4*/ bool Equals(object value);
                /*0x12d3088*/ int GetHashCode();
                /*0x12d30bc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x12d30c4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x12d31e4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum SqlBytesCharsState
            {
                Null = 0,
                Buffer = 1,
                Stream = 3,
            }

            class SqlBytes : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ byte[] _rgbBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.IO.Stream _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ byte[] _rgbWorkBuf;

                static /*0x126332c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x12633f8*/ System.Data.SqlTypes.SqlBytes get_Null();
                /*0x1262af8*/ SqlBytes();
                /*0x1262b2c*/ SqlBytes(byte[] buffer);
                /*0x1262b7c*/ SqlBytes(System.Data.SqlTypes.SqlBinary value);
                /*0x1262bc4*/ bool get_IsNull();
                /*0x1262bd4*/ byte[] get_Buffer();
                /*0x1262d54*/ long get_Length();
                /*0x1262e00*/ byte[] get_Value();
                /*0x1262b1c*/ void SetNull();
                /*0x1262c0c*/ void CopyStreamToBuffer();
                /*0x1262bfc*/ bool FStream();
                /*0x1263008*/ void SetBuffer(byte[] buffer);
                /*0x1263030*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1263038*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x12631f8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x12633b8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class SqlChars : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ char[] _rgchBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.Data.SqlTypes.SqlStreamChars _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ char[] _rgchWorkBuf;

                static /*0x1263bac*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x1263c78*/ System.Data.SqlTypes.SqlChars get_Null();
                /*0x1263468*/ SqlChars();
                /*0x126349c*/ SqlChars(char[] buffer);
                /*0x12634ec*/ SqlChars(System.Data.SqlTypes.SqlString value);
                /*0x126358c*/ bool get_IsNull();
                /*0x126359c*/ char[] get_Buffer();
                /*0x1263714*/ long get_Length();
                /*0x1263788*/ char[] get_Value();
                /*0x126348c*/ void SetNull();
                /*0x12635c4*/ bool FStream();
                /*0x12635d4*/ void CopyStreamToBuffer();
                /*0x1263960*/ void SetBuffer(char[] buffer);
                /*0x1263988*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1263990*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x1263aac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x1263c38*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            struct SqlDateTime : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ double s_SQLTicksPerMillisecond;
                static /*0x8*/ int SQLTicksPerSecond;
                static /*0xc*/ int SQLTicksPerMinute;
                static /*0x10*/ int SQLTicksPerHour;
                static /*0x14*/ int s_SQLTicksPerDay;
                static /*0x18*/ long s_ticksPerSecond;
                static /*0x20*/ System.DateTime s_SQLBaseDate;
                static /*0x28*/ long s_SQLBaseDateTicks;
                static /*0x30*/ int s_minYear;
                static /*0x34*/ int s_maxYear;
                static /*0x38*/ int s_minDay;
                static /*0x3c*/ int s_maxDay;
                static /*0x40*/ int s_minTime;
                static /*0x44*/ int s_maxTime;
                static /*0x48*/ int s_dayBase;
                static /*0x50*/ int[] s_daysToMonth365;
                static /*0x58*/ int[] s_daysToMonth366;
                static /*0x60*/ System.DateTime s_minDateTime;
                static /*0x68*/ System.DateTime s_maxDateTime;
                static /*0x70*/ System.TimeSpan s_minTimeSpan;
                static /*0x78*/ System.TimeSpan s_maxTimeSpan;
                static /*0x80*/ string s_ISO8601_DateTimeFormat;
                static /*0x88*/ string[] s_dateTimeFormats;
                static /*0x90*/ System.Data.SqlTypes.SqlDateTime MinValue;
                static /*0x9c*/ System.Data.SqlTypes.SqlDateTime MaxValue;
                static /*0xa8*/ System.Data.SqlTypes.SqlDateTime Null;
                /*0x10*/ bool m_fNotNull;
                /*0x14*/ int m_day;
                /*0x18*/ int m_time;

                static /*0x1264fb4*/ SqlDateTime();
                static /*0x1263f70*/ System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value);
                static /*0x1264018*/ System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value);
                static /*0x1264098*/ System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value);
                static /*0x1263d60*/ System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value);
                static /*0x12643cc*/ System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value);
                static /*0x126448c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x126454c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1264618*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x12646e4*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1264768*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1264f28*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x1263ce8*/ SqlDateTime(bool fNull);
                /*0x1263cf4*/ SqlDateTime(System.DateTime value);
                /*0x1263e30*/ SqlDateTime(int dayTicks, int timeTicks);
                /*0x1263f60*/ bool get_IsNull();
                /*0x126428c*/ System.DateTime get_Value();
                /*0x126432c*/ int get_DayTicks();
                /*0x126437c*/ int get_TimeTicks();
                /*0x12643fc*/ string ToString();
                /*0x12647ec*/ int CompareTo(object value);
                /*0x12648d8*/ int CompareTo(System.Data.SqlTypes.SqlDateTime value);
                /*0x1264ae0*/ bool Equals(object value);
                /*0x1264bc0*/ int GetHashCode();
                /*0x1264bf4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1264bfc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x1264ddc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDecimal : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ byte s_NUMERIC_MAX_PRECISION;
                static /*0x1*/ byte MaxPrecision;
                static /*0x2*/ byte MaxScale;
                static /*0x3*/ byte s_bNullMask;
                static /*0x4*/ byte s_bIsNull;
                static /*0x5*/ byte s_bNotNull;
                static /*0x6*/ byte s_bReverseNullMask;
                static /*0x7*/ byte s_bSignMask;
                static /*0x8*/ byte s_bPositive;
                static /*0x9*/ byte s_bNegative;
                static /*0xa*/ byte s_bReverseSignMask;
                static /*0xc*/ uint s_uiZero;
                static /*0x10*/ int s_cNumeMax;
                static /*0x18*/ long s_lInt32Base;
                static /*0x20*/ ulong s_ulInt32Base;
                static /*0x28*/ ulong s_ulInt32BaseForMod;
                static /*0x30*/ ulong s_llMax;
                static /*0x38*/ uint s_ulBase10;
                static /*0x40*/ double s_DUINT_BASE;
                static /*0x48*/ double s_DUINT_BASE2;
                static /*0x50*/ double s_DUINT_BASE3;
                static /*0x58*/ double s_DMAX_NUME;
                static /*0x60*/ uint s_DBL_DIG;
                static /*0x64*/ byte s_cNumeDivScaleMin;
                static /*0x68*/ uint[] s_rgulShiftBase;
                static /*0x70*/ uint[] s_decimalHelpersLo;
                static /*0x78*/ uint[] s_decimalHelpersMid;
                static /*0x80*/ uint[] s_decimalHelpersHi;
                static /*0x88*/ uint[] s_decimalHelpersHiHi;
                static /*0x90*/ byte[] s_rgCLenFromPrec;
                static /*0x98*/ uint s_ulT1;
                static /*0x9c*/ uint s_ulT2;
                static /*0xa0*/ uint s_ulT3;
                static /*0xa4*/ uint s_ulT4;
                static /*0xa8*/ uint s_ulT5;
                static /*0xac*/ uint s_ulT6;
                static /*0xb0*/ uint s_ulT7;
                static /*0xb4*/ uint s_ulT8;
                static /*0xb8*/ uint s_ulT9;
                static /*0xc0*/ ulong s_dwlT10;
                static /*0xc8*/ ulong s_dwlT11;
                static /*0xd0*/ ulong s_dwlT12;
                static /*0xd8*/ ulong s_dwlT13;
                static /*0xe0*/ ulong s_dwlT14;
                static /*0xe8*/ ulong s_dwlT15;
                static /*0xf0*/ ulong s_dwlT16;
                static /*0xf8*/ ulong s_dwlT17;
                static /*0x100*/ ulong s_dwlT18;
                static /*0x108*/ ulong s_dwlT19;
                static /*0x110*/ System.Data.SqlTypes.SqlDecimal Null;
                static /*0x124*/ System.Data.SqlTypes.SqlDecimal MinValue;
                static /*0x138*/ System.Data.SqlTypes.SqlDecimal MaxValue;
                /*0x10*/ byte _bStatus;
                /*0x11*/ byte _bLen;
                /*0x12*/ byte _bPrec;
                /*0x13*/ byte _bScale;
                /*0x14*/ uint _data1;
                /*0x18*/ uint _data2;
                /*0x1c*/ uint _data3;
                /*0x20*/ uint _data4;

                static /*0x126b018*/ SqlDecimal();
                static /*0x1266a18*/ System.Data.SqlTypes.SqlDecimal Parse(string s);
                static /*0x1267380*/ System.Data.SqlTypes.SqlDecimal op_Implicit(decimal x);
                static /*0x1267398*/ System.Data.SqlTypes.SqlDecimal op_Implicit(long x);
                static /*0x1267400*/ System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x);
                static /*0x12674e0*/ System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1267efc*/ System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1267fdc*/ System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x12687e0*/ System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1269480*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x1269520*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x1269628*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x1269730*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x1269838*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x1269404*/ void ZeroToMaxLen(uint[] rgulData, int cUI4sCur);
                static /*0x1265b68*/ byte BGetPrecUI4(uint value);
                static /*0x1265d6c*/ byte BGetPrecUI8(ulong dwlVal);
                static /*0x1269ca0*/ void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, ref int ciulD);
                static /*0x1269d04*/ void MpSet(uint[] rgulD, ref int ciulD, uint iulN);
                static /*0x1269d30*/ void MpNormalize(uint[] rgulU, ref int ciulU);
                static /*0x1269d7c*/ void MpMul1(uint[] piulD, ref int ciulD, uint iulX);
                static /*0x126693c*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
                static /*0x1269e7c*/ ulong DWL(uint lo, uint hi);
                static /*0x1269e70*/ uint HI(ulong x);
                static /*0x1269e78*/ uint LO(ulong x);
                static /*0x1268bd4*/ void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, ref int ciulQ, uint[] rgulR, ref int ciulR);
                static /*0x12660f4*/ void CheckValidPrecScale(byte bPrec, byte bScale);
                static /*0x126a06c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x126a12c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x126a1ec*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x126a2ac*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x126a360*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1266a10*/ char ChFromDigit(uint uiDigit);
                static /*0x126af8c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x12658d4*/ SqlDecimal(bool fNull);
                /*0x126593c*/ SqlDecimal(decimal value);
                /*0x1265a94*/ SqlDecimal(int value);
                /*0x1265ca0*/ SqlDecimal(long value);
                /*0x1265fb0*/ SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive);
                /*0x12654a0*/ byte CalculatePrecision();
                /*0x12656b8*/ bool VerifyPrecision(byte precision);
                /*0x1266260*/ bool get_IsNull();
                /*0x12662d0*/ decimal get_Value();
                /*0x12663f8*/ bool get_IsPositive();
                /*0x12661f8*/ void SetPositive();
                /*0x12664ac*/ void SetSignBit(bool fPositive);
                /*0x1266530*/ byte get_Scale();
                /*0x1266584*/ int[] get_Data();
                /*0x1266660*/ string ToString();
                /*0x1267250*/ double ToDouble();
                /*0x12662d4*/ decimal ToDecimal();
                /*0x12661d8*/ bool FZero();
                /*0x1267e88*/ bool FGt10_38();
                /*0x12699fc*/ bool FGt10_38(uint[] rglData);
                /*0x12670b0*/ void AddULong(uint ulAdd);
                /*0x1266ec4*/ void MultByULong(uint uiMultiplier);
                /*0x1269adc*/ uint DivByULong(uint iDivisor);
                /*0x1267a20*/ void AdjustScale(int digits, bool fRound);
                /*0x1267d30*/ int LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x1269e88*/ System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x126a414*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x126a524*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x126a740*/ System.Data.SqlTypes.SqlMoney ToSqlMoney();
                /*0x1269a84*/ void StoreFromWorkingArray(uint[] rguiData);
                /*0x1266e4c*/ void SetToZero();
                /*0x126a860*/ int CompareTo(object value);
                /*0x126a964*/ int CompareTo(System.Data.SqlTypes.SqlDecimal value);
                /*0x126ab0c*/ bool Equals(object value);
                /*0x126ac38*/ int GetHashCode();
                /*0x126ad48*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x126ad50*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x126aeb4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlDouble Null;
                static /*0x10*/ System.Data.SqlTypes.SqlDouble Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlDouble MinValue;
                static /*0x30*/ System.Data.SqlTypes.SqlDouble MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ double m_value;

                static /*0x126c994*/ SqlDouble();
                static /*0x126b4ac*/ System.Data.SqlTypes.SqlDouble op_Implicit(double x);
                static /*0x126b4f0*/ System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x);
                static /*0x126b580*/ System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126b6d0*/ System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126b820*/ System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126b970*/ System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126bb00*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x126bb98*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x126bc30*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x126bcc0*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x126bd54*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x);
                static /*0x126be44*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x126a494*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x126bf40*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126bff4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126c0a8*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126c15c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126c1e0*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x126c908*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x126b37c*/ SqlDouble(bool fNull);
                /*0x126b388*/ SqlDouble(double value);
                /*0x126b44c*/ bool get_IsNull();
                /*0x126b45c*/ double get_Value();
                /*0x126b4d0*/ string ToString();
                /*0x126c264*/ System.Data.SqlTypes.SqlSingle ToSqlSingle();
                /*0x126c354*/ int CompareTo(object value);
                /*0x126c43c*/ int CompareTo(System.Data.SqlTypes.SqlDouble value);
                /*0x126c574*/ bool Equals(object value);
                /*0x126c650*/ int GetHashCode();
                /*0x126c6d4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x126c6dc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x126c7fc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_sizeOfGuid;
                static /*0x8*/ int[] s_rgiGuidOrder;
                static /*0x10*/ System.Data.SqlTypes.SqlGuid Null;
                /*0x10*/ byte[] m_value;

                static /*0x126d46c*/ SqlGuid();
                static /*0x126caf8*/ System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x);
                static /*0x126cb60*/ System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x126cc58*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x126cd1c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x126cde0*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x126d3e0*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x126ca4c*/ SqlGuid(bool fNull);
                /*0x126ca54*/ SqlGuid(System.Guid g);
                /*0x126ca80*/ bool get_IsNull();
                /*0x126ca90*/ System.Guid get_Value();
                /*0x126cb1c*/ string ToString();
                /*0x126cea4*/ int CompareTo(object value);
                /*0x126cf8c*/ int CompareTo(System.Data.SqlTypes.SqlGuid value);
                /*0x126d0a0*/ bool Equals(object value);
                /*0x126d160*/ int GetHashCode();
                /*0x126d19c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x126d1a4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x126d2c4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt16 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_MASKI2;
                static /*0x4*/ System.Data.SqlTypes.SqlInt16 Null;
                static /*0x8*/ System.Data.SqlTypes.SqlInt16 Zero;
                static /*0xc*/ System.Data.SqlTypes.SqlInt16 MinValue;
                static /*0x10*/ System.Data.SqlTypes.SqlInt16 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x12*/ short m_value;

                static /*0x126e568*/ SqlInt16();
                static /*0x126d52c*/ System.Data.SqlTypes.SqlInt16 op_Implicit(short x);
                static /*0x126d55c*/ System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x);
                static /*0x126d5e8*/ System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126d6d8*/ System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126d7c8*/ System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126d8f4*/ System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126da34*/ System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x126dad0*/ System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x126dbbc*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126dc5c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126dcfc*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126dd9c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126de08*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x126e4dc*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x126d510*/ SqlInt16(bool fNull);
                /*0x126d51c*/ SqlInt16(short value);
                /*0x12695c8*/ bool get_IsNull();
                /*0x12695d8*/ short get_Value();
                /*0x126d53c*/ string ToString();
                /*0x126de74*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x126decc*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x126dfb0*/ int CompareTo(object value);
                /*0x126e098*/ int CompareTo(System.Data.SqlTypes.SqlInt16 value);
                /*0x126e1b8*/ bool Equals(object value);
                /*0x126e280*/ int GetHashCode();
                /*0x126e2b4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x126e2bc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x126e3dc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt32 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ long s_iIntMin;
                static /*0x8*/ long s_lBitNotIntMax;
                static /*0x10*/ System.Data.SqlTypes.SqlInt32 Null;
                static /*0x18*/ System.Data.SqlTypes.SqlInt32 Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlInt32 MinValue;
                static /*0x28*/ System.Data.SqlTypes.SqlInt32 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x14*/ int m_value;

                static /*0x126f758*/ SqlInt32();
                static /*0x126e600*/ System.Data.SqlTypes.SqlInt32 op_Implicit(int x);
                static /*0x126e630*/ System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x);
                static /*0x126e6bc*/ System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126e7e8*/ System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126e908*/ System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126ea34*/ System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126eb88*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x126ec24*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x126ecb8*/ System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x126e7dc*/ bool SameSignInt(int x, int y);
                static /*0x126eda4*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126ee48*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126eeec*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126ef90*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126effc*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x126f6cc*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x126e5e4*/ SqlInt32(bool fNull);
                /*0x126e5f0*/ SqlInt32(int value);
                /*0x12696d0*/ bool get_IsNull();
                /*0x12696e0*/ int get_Value();
                /*0x126e610*/ string ToString();
                /*0x126f068*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x126f0c0*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x126f1a4*/ int CompareTo(object value);
                /*0x126f28c*/ int CompareTo(System.Data.SqlTypes.SqlInt32 value);
                /*0x126f3a8*/ bool Equals(object value);
                /*0x126f470*/ int GetHashCode();
                /*0x126f4a4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x126f4ac*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x126f5cc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt64 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ long s_lLowIntMask;
                static /*0x8*/ long s_lHighIntMask;
                static /*0x10*/ System.Data.SqlTypes.SqlInt64 Null;
                static /*0x20*/ System.Data.SqlTypes.SqlInt64 Zero;
                static /*0x30*/ System.Data.SqlTypes.SqlInt64 MinValue;
                static /*0x40*/ System.Data.SqlTypes.SqlInt64 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ long m_value;

                static /*0x1270a54*/ SqlInt64();
                static /*0x126f7f0*/ System.Data.SqlTypes.SqlInt64 op_Implicit(long x);
                static /*0x126f81c*/ System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x);
                static /*0x126f8a0*/ System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x126f9cc*/ System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x126fae8*/ System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x126fc50*/ System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x126fd88*/ System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x126fec4*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x126df24*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x126f118*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x126a5a4*/ System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x126f9bc*/ bool SameSignLong(long x, long y);
                static /*0x126ff58*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x1270004*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x12700b0*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x127015c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x12701e0*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x12709c8*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x126f7d4*/ SqlInt64(bool fNull);
                /*0x126f7e0*/ SqlInt64(long value);
                /*0x12697d8*/ bool get_IsNull();
                /*0x12697e8*/ long get_Value();
                /*0x126f7fc*/ string ToString();
                /*0x1270264*/ System.Data.SqlTypes.SqlByte ToSqlByte();
                /*0x12702cc*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x1270328*/ System.Data.SqlTypes.SqlInt16 ToSqlInt16();
                /*0x127038c*/ System.Data.SqlTypes.SqlInt32 ToSqlInt32();
                /*0x12703e8*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x1270470*/ int CompareTo(object value);
                /*0x1270558*/ int CompareTo(System.Data.SqlTypes.SqlInt64 value);
                /*0x1270690*/ bool Equals(object value);
                /*0x127076c*/ int GetHashCode();
                /*0x12707a0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x12707a8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x12708c8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlMoney : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_iMoneyScale;
                static /*0x8*/ long s_lTickBase;
                static /*0x10*/ double s_dTickBase;
                static /*0x18*/ long s_minLong;
                static /*0x20*/ long s_maxLong;
                static /*0x28*/ System.Data.SqlTypes.SqlMoney Null;
                static /*0x38*/ System.Data.SqlTypes.SqlMoney Zero;
                static /*0x48*/ System.Data.SqlTypes.SqlMoney MinValue;
                static /*0x58*/ System.Data.SqlTypes.SqlMoney MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x18*/ long _value;

                static /*0x12721a4*/ SqlMoney();
                static /*0x1270e04*/ System.Data.SqlTypes.SqlMoney op_Implicit(decimal x);
                static /*0x1270e30*/ System.Data.SqlTypes.SqlMoney op_Implicit(long x);
                static /*0x1270f30*/ System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x);
                static /*0x1271024*/ System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x12711b8*/ System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271348*/ System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271454*/ System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271560*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x12715f4*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x1271688*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x1271718*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x126a7c0*/ System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x12717ac*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271858*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271904*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x12719b0*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1271a34*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x1272118*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x1270aec*/ SqlMoney(bool fNull);
                /*0x1270af8*/ SqlMoney(long value, int ignored);
                /*0x1270b08*/ SqlMoney(int value);
                /*0x1270b84*/ SqlMoney(long value);
                /*0x1270c88*/ SqlMoney(decimal value);
                /*0x12698ec*/ bool get_IsNull();
                /*0x1270db8*/ decimal get_Value();
                /*0x12698fc*/ decimal ToDecimal();
                /*0x126bed4*/ double ToDouble();
                /*0x1270e8c*/ string ToString();
                /*0x1271ab8*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x1271b14*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x1271b9c*/ int CompareTo(object value);
                /*0x1271c84*/ int CompareTo(System.Data.SqlTypes.SqlMoney value);
                /*0x1271dbc*/ bool Equals(object value);
                /*0x1271e98*/ int GetHashCode();
                /*0x1271eb4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1271ebc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x1272008*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlSingle Null;
                static /*0x8*/ System.Data.SqlTypes.SqlSingle Zero;
                static /*0x10*/ System.Data.SqlTypes.SqlSingle MinValue;
                static /*0x18*/ System.Data.SqlTypes.SqlSingle MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x14*/ float _value;

                static /*0x12735d0*/ SqlSingle();
                static /*0x1272344*/ System.Data.SqlTypes.SqlSingle op_Implicit(float x);
                static /*0x1272380*/ System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x);
                static /*0x1272408*/ System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272550*/ System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272698*/ System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x12727e0*/ System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272968*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x1272a00*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x1272a98*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x1272b28*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x1272bbc*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x1272c50*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x126c2c0*/ System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x);
                static /*0x1272cdc*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272d88*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272e34*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272ee0*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1272f4c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x1273544*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x127226c*/ SqlSingle(bool fNull);
                /*0x1272278*/ SqlSingle(float value);
                /*0x127233c*/ SqlSingle(double value);
                /*0x126bde4*/ bool get_IsNull();
                /*0x126bdf4*/ float get_Value();
                /*0x1272360*/ string ToString();
                /*0x1272fb8*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x1273010*/ int CompareTo(object value);
                /*0x12730f8*/ int CompareTo(System.Data.SqlTypes.SqlSingle value);
                /*0x1273214*/ bool Equals(object value);
                /*0x12732dc*/ int GetHashCode();
                /*0x1273310*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1273318*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x1273438*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum SqlCompareOptions
            {
                None = 0,
                IgnoreCase = 1,
                IgnoreNonSpace = 2,
                IgnoreKanaType = 8,
                IgnoreWidth = 16,
                BinarySort = 32768,
                BinarySort2 = 16384,
            }

            struct SqlString : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlString Null;
                static /*0x20*/ System.Text.UnicodeEncoding s_unicodeEncoding;
                static /*0x28*/ int IgnoreCase;
                static /*0x2c*/ int IgnoreWidth;
                static /*0x30*/ int IgnoreNonSpace;
                static /*0x34*/ int IgnoreKanaType;
                static /*0x38*/ int BinarySort;
                static /*0x3c*/ int BinarySort2;
                static /*0x40*/ System.Data.SqlTypes.SqlCompareOptions s_iDefaultFlag;
                static /*0x44*/ System.Globalization.CompareOptions s_iValidCompareOptionMask;
                static /*0x48*/ System.Data.SqlTypes.SqlCompareOptions s_iValidSqlCompareOptionMask;
                static /*0x4c*/ int s_lcidUSEnglish;
                static /*0x50*/ int s_lcidBinary;
                /*0x10*/ string m_value;
                /*0x18*/ System.Globalization.CompareInfo m_cmpInfo;
                /*0x20*/ int m_lcid;
                /*0x24*/ System.Data.SqlTypes.SqlCompareOptions m_flag;
                /*0x28*/ bool m_fNotNull;

                static /*0x1274b08*/ SqlString();
                static /*0x12739a4*/ System.Data.SqlTypes.SqlString op_Implicit(string x);
                static /*0x12739d0*/ System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x1273b00*/ int StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x127410c*/ System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult);
                static /*0x1274254*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x1273724*/ void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x1274068*/ System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x1273d2c*/ int CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x1273ef0*/ int CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x1274a7c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x1273688*/ SqlString(bool fNull);
                /*0x1273698*/ SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions);
                /*0x12737d4*/ SqlString(string data);
                /*0x1273890*/ SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, string data, System.Globalization.CompareInfo cmpInfo);
                /*0x126352c*/ bool get_IsNull();
                /*0x126353c*/ string get_Value();
                /*0x1273924*/ void SetCompareInfo();
                /*0x12739b8*/ string ToString();
                /*0x127437c*/ bool FBinarySort();
                /*0x127439c*/ int CompareTo(object value);
                /*0x1274498*/ int CompareTo(System.Data.SqlTypes.SqlString value);
                /*0x1274558*/ bool Equals(object value);
                /*0x12746a8*/ int GetHashCode();
                /*0x12748b4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x12748bc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x12749b0*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum EComparison
            {
                LT = 0,
                LE = 1,
                EQ = 2,
                GE = 3,
                GT = 4,
                NE = 5,
            }

            class SqlTypeException : System.SystemException
            {
                static /*0x1274c90*/ System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x1274bbc*/ SqlTypeException();
                /*0x1262fe0*/ SqlTypeException(string message);
                /*0x1274c1c*/ SqlTypeException(string message, System.Exception e);
                /*0x1274c40*/ SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x1274e18*/ System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x1262dc8*/ SqlNullValueException();
                /*0x1274d90*/ SqlNullValueException(string message);
                /*0x1274d6c*/ SqlNullValueException(string message, System.Exception e);
                /*0x1274db8*/ SqlNullValueException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x1274fa0*/ System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x1269c68*/ SqlTruncateException();
                /*0x1274f18*/ SqlTruncateException(string message);
                /*0x1274ef4*/ SqlTruncateException(string message, System.Exception e);
                /*0x1274f40*/ SqlTruncateException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlStreamChars
            {
                long get_Length();
                long get_Position();
                int Read(char[] buffer, int offset, int count);
                long Seek(long offset, System.IO.SeekOrigin origin);
            }

            class SqlXml : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> s_sqlReaderDelegate;
                static /*0x8*/ System.Xml.XmlReaderSettings s_defaultXmlReaderSettings;
                static /*0x10*/ System.Xml.XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;
                static /*0x18*/ System.Reflection.MethodInfo s_createSqlReaderMethodInfo;
                /*0x10*/ System.Reflection.MethodInfo _createSqlReaderMethodInfo;
                /*0x18*/ bool _fNotNull;
                /*0x20*/ System.IO.Stream _stream;
                /*0x28*/ bool _firstCreateReader;

                static /*0x1275c24*/ SqlXml();
                static /*0x12753ac*/ System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, bool closeInput, bool throwTargetInvocationExceptions);
                static /*0x1275774*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> CreateSqlReaderDelegate();
                static /*0x1275288*/ System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo();
                static /*0x1275b98*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x127507c*/ SqlXml();
                /*0x12750b8*/ System.Xml.XmlReader CreateReader();
                /*0x1275208*/ bool get_IsNull();
                /*0x12750a4*/ void SetNull();
                /*0x127586c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1275874*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x1275a48*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            class SqlXmlStreamWrapper : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ long _lPosition;
                /*0x38*/ bool _isClosed;

                /*0x1275218*/ SqlXmlStreamWrapper(System.IO.Stream stream);
                /*0x1275d00*/ bool get_CanRead();
                /*0x1275da8*/ bool get_CanSeek();
                /*0x1275de0*/ bool get_CanWrite();
                /*0x1275e18*/ long get_Length();
                /*0x1275f78*/ long get_Position();
                /*0x1275fd4*/ void set_Position(long value);
                /*0x12760ac*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x1276280*/ int Read(byte[] buffer, int offset, int count);
                /*0x12764c8*/ void Write(byte[] buffer, int offset, int count);
                /*0x1276710*/ int ReadByte();
                /*0x1276824*/ void WriteByte(byte value);
                /*0x1276908*/ void SetLength(long value);
                /*0x127699c*/ void Flush();
                /*0x12769b8*/ void Dispose(bool disposing);
                /*0x1275ef4*/ void ThrowIfStreamCannotSeek(string method);
                /*0x1276444*/ void ThrowIfStreamCannotRead(string method);
                /*0x127668c*/ void ThrowIfStreamCannotWrite(string method);
                /*0x1275e84*/ void ThrowIfStreamClosed(string method);
                /*0x1275d38*/ bool IsStreamClosed();
            }
        }

        namespace Common
        {
            class ADP
            {
                static /*0x0*/ System.Type s_stackOverflowType;
                static /*0x8*/ System.Type s_outOfMemoryType;
                static /*0x10*/ System.Type s_threadAbortType;
                static /*0x18*/ System.Type s_nullReferenceType;
                static /*0x20*/ System.Type s_accessViolationType;
                static /*0x28*/ System.Type s_securityType;
                static /*0x30*/ string StrEmpty;
                static /*0x38*/ string[] AzureSqlServerEndpoints;
                static /*0x40*/ nint PtrZero;
                static /*0x48*/ int PtrSize;

                static /*0x127727c*/ ADP();
                static /*0x12769cc*/ void TraceException(string trace, System.Exception e);
                static /*0x1276a64*/ void TraceExceptionAsReturnValue(System.Exception e);
                static /*0x1276ad0*/ void TraceExceptionWithoutRethrow(System.Exception e);
                static /*0x1276b3c*/ System.ArgumentException Argument(string error);
                static /*0x12742ec*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName);
                static /*0x1276bcc*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName);
                static /*0x1276c6c*/ System.InvalidOperationException InvalidOperation(string error);
                static /*0x1276cfc*/ System.NotSupportedException NotSupported(string error);
                static /*0x1275568*/ bool IsCatchableExceptionType(System.Exception e);
                static /*0x1276d8c*/ bool IsCatchableOrSecurityExceptionType(System.Exception e);
                static /*0x1276f60*/ System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value);
                static /*0x1276214*/ System.Exception InvalidSeekOrigin(string parameterName);
                static /*0x127706c*/ System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value);
                static /*0x127711c*/ System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value);
                static /*0x12771cc*/ System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value);
                static /*0x1264a1c*/ System.Exception WrongType(System.Type got, System.Type expected);
            }

            class BigIntegerStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Numerics.BigInteger[] _values;

                static /*0x1277904*/ System.Numerics.BigInteger ConvertToBigInteger(object value, System.IFormatProvider formatProvider);
                static /*0x1278098*/ object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider);
                /*0x12775d0*/ BigIntegerStorage(System.Data.DataColumn column);
                /*0x1277714*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1277744*/ int Compare(int recordNo1, int recordNo2);
                /*0x12777f8*/ int CompareValueTo(int recordNo, object value);
                /*0x1278820*/ object ConvertValue(object value);
                /*0x12788b8*/ void Copy(int recordNo1, int recordNo2);
                /*0x1278914*/ object Get(int record);
                /*0x12789c4*/ void Set(int record, object value);
                /*0x1278ad0*/ void SetCapacity(int capacity);
                /*0x1278b94*/ object ConvertXmlToObject(string s);
                /*0x1278c44*/ string ConvertObjectToXml(object value);
                /*0x1278d1c*/ object GetEmptyStorage(int recordCount);
                /*0x1278d64*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1278e6c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class BooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ bool[] _values;

                /*0x1278f00*/ BooleanStorage(System.Data.DataColumn column);
                /*0x1278ff8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1279394*/ int Compare(int recordNo1, int recordNo2);
                /*0x127940c*/ int CompareValueTo(int recordNo, object value);
                /*0x1279510*/ object ConvertValue(object value);
                /*0x127965c*/ void Copy(int recordNo1, int recordNo2);
                /*0x12796b4*/ object Get(int record);
                /*0x1279754*/ void Set(int record, object value);
                /*0x12798c4*/ void SetCapacity(int capacity);
                /*0x1279988*/ object ConvertXmlToObject(string s);
                /*0x1279a18*/ string ConvertObjectToXml(object value);
                /*0x1279ab0*/ object GetEmptyStorage(int recordCount);
                /*0x1279af8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1279bf8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ byte[] _values;

                /*0x145ee98*/ ByteStorage(System.Data.DataColumn column);
                /*0x145f020*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x145f7c8*/ int Compare(int recordNo1, int recordNo2);
                /*0x145f8a0*/ int CompareValueTo(int recordNo, object value);
                /*0x145f9a4*/ object ConvertValue(object value);
                /*0x145fb10*/ void Copy(int recordNo1, int recordNo2);
                /*0x145fba4*/ object Get(int record);
                /*0x145fc78*/ void Set(int record, object value);
                /*0x145fe1c*/ void SetCapacity(int capacity);
                /*0x145ff60*/ object ConvertXmlToObject(string s);
                /*0x145ffec*/ string ConvertObjectToXml(object value);
                /*0x1460084*/ object GetEmptyStorage(int recordCount);
                /*0x14600cc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x14601cc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class CharStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ char[] _values;

                /*0x1460260*/ CharStorage(System.Data.DataColumn column);
                /*0x1460354*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14606d8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1460748*/ int CompareValueTo(int recordNo, object value);
                /*0x146084c*/ object ConvertValue(object value);
                /*0x146099c*/ void Copy(int recordNo1, int recordNo2);
                /*0x14609f0*/ object Get(int record);
                /*0x1460a8c*/ void Set(int record, object value);
                /*0x1460c6c*/ void SetCapacity(int capacity);
                /*0x1460d2c*/ object ConvertXmlToObject(string s);
                /*0x1460db8*/ string ConvertObjectToXml(object value);
                /*0x1460e50*/ object GetEmptyStorage(int recordCount);
                /*0x1460e98*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1460f98*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            enum StorageType
            {
                Empty = 0,
                Object = 1,
                DBNull = 2,
                Boolean = 3,
                Char = 4,
                SByte = 5,
                Byte = 6,
                Int16 = 7,
                UInt16 = 8,
                Int32 = 9,
                UInt32 = 10,
                Int64 = 11,
                UInt64 = 12,
                Single = 13,
                Double = 14,
                Decimal = 15,
                DateTime = 16,
                TimeSpan = 17,
                String = 18,
                Guid = 19,
                ByteArray = 20,
                CharArray = 21,
                Type = 22,
                DateTimeOffset = 23,
                BigInteger = 24,
                Uri = 25,
                SqlBinary = 26,
                SqlBoolean = 27,
                SqlByte = 28,
                SqlBytes = 29,
                SqlChars = 30,
                SqlDateTime = 31,
                SqlDecimal = 32,
                SqlDouble = 33,
                SqlGuid = 34,
                SqlInt16 = 35,
                SqlInt32 = 36,
                SqlInt64 = 37,
                SqlMoney = 38,
                SqlSingle = 39,
                SqlString = 40,
            }

            class DataStorage
            {
                static /*0x0*/ System.Type[] s_storageClassType;
                static /*0x8*/ System.Func<System.Type, System.Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces;
                static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Tuple<bool, bool, bool, bool>> s_typeImplementsInterface;
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ System.Data.DataTable _table;
                /*0x20*/ System.Type _dataType;
                /*0x28*/ System.Data.Common.StorageType _storageTypeCode;
                /*0x30*/ System.Collections.BitArray _dbNullBits;
                /*0x38*/ object _defaultValue;
                /*0x40*/ object _nullValue;
                /*0x48*/ bool _isCloneable;
                /*0x49*/ bool _isCustomDefinedType;
                /*0x4a*/ bool _isStringType;
                /*0x4b*/ bool _isValueType;

                static /*0x1463630*/ DataStorage();
                static /*0x1461364*/ System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode);
                static /*0x1462ae4*/ System.Data.Common.StorageType GetStorageType(System.Type dataType);
                static /*0x1462c00*/ System.Type GetTypeStorage(System.Data.Common.StorageType storageType);
                static /*0x1462c7c*/ bool IsTypeCustomType(System.Type type);
                static /*0x1461150*/ bool IsTypeCustomType(System.Data.Common.StorageType typeCode);
                static /*0x1462cf0*/ bool IsSqlType(System.Data.Common.StorageType storageType);
                static /*0x1462cfc*/ bool IsSqlType(System.Type dataType);
                static /*0x1461170*/ bool DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x1462df4*/ void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, ref bool sqlType, ref bool nullable, ref bool xmlSerializable, ref bool changeTracking, ref bool revertibleChangeTracking);
                static /*0x1462f48*/ System.Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType);
                static /*0x14630fc*/ bool ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x14631d0*/ bool IsObjectNull(object value);
                static /*0x1463270*/ bool IsObjectSqlNull(object value);
                static /*0x146335c*/ System.Type GetType(string value);
                static /*0x14635c0*/ string GetQualifiedName(System.Type type);
                /*0x145ef8c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, System.Data.Common.StorageType storageType);
                /*0x1461144*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, System.Data.Common.StorageType storageType);
                /*0x146102c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, System.Data.Common.StorageType storageType);
                /*0x14611ac*/ System.Data.DataSetDateTime get_DateTimeMode();
                /*0x145faf4*/ System.IFormatProvider get_FormatProvider();
                /*0x145f7b4*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x14611c8*/ object AggregateCount(int[] recordNos);
                /*0x145f838*/ int CompareBits(int recordNo1, int recordNo2);
                int Compare(int recordNo1, int recordNo2);
                int CompareValueTo(int recordNo1, object value);
                /*0x1461294*/ object ConvertValue(object value);
                /*0x145fb64*/ void CopyBits(int srcRecordNo, int dstRecordNo);
                void Copy(int recordNo1, int recordNo2);
                object Get(int recordNo);
                /*0x145fc40*/ object GetBits(int recordNo);
                /*0x146129c*/ int GetStringLength(int record);
                /*0x14612a4*/ bool HasValue(int recordNo);
                /*0x14612cc*/ bool IsNull(int recordNo);
                void Set(int recordNo, object value);
                /*0x145fdfc*/ void SetNullBit(int recordNo, bool flag);
                /*0x145fedc*/ void SetCapacity(int capacity);
                object ConvertXmlToObject(string s);
                /*0x14612e8*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                string ConvertObjectToXml(object value);
                /*0x1461328*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x1463324*/ object GetEmptyStorageInternal(int recordCount);
                /*0x1463334*/ void CopyValueInternal(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1463344*/ void SetStorageInternal(object store, System.Collections.BitArray nullbits);
                object GetEmptyStorage(int recordCount);
                void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                void SetStorage(object store, System.Collections.BitArray nullbits);
                /*0x1463354*/ void SetNullStorage(System.Collections.BitArray nullbits);
            }

            class DateTimeOffsetStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTimeOffset s_defaultValue;
                /*0x50*/ System.DateTimeOffset[] _values;

                static /*0x1465258*/ DateTimeOffsetStorage();
                /*0x146242c*/ DateTimeOffsetStorage(System.Data.DataColumn column);
                /*0x146436c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1464844*/ int Compare(int recordNo1, int recordNo2);
                /*0x14649e8*/ int CompareValueTo(int recordNo, object value);
                /*0x1464b68*/ object ConvertValue(object value);
                /*0x1464c0c*/ void Copy(int recordNo1, int recordNo2);
                /*0x1464c64*/ object Get(int record);
                /*0x1464d70*/ void Set(int record, object value);
                /*0x1464e90*/ void SetCapacity(int capacity);
                /*0x1464f50*/ object ConvertXmlToObject(string s);
                /*0x1464fdc*/ string ConvertObjectToXml(object value);
                /*0x1465078*/ object GetEmptyStorage(int recordCount);
                /*0x14650c0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x14651c4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DateTimeStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTime s_defaultValue;
                /*0x50*/ System.DateTime[] _values;

                static /*0x146659c*/ DateTimeStorage();
                /*0x1462304*/ DateTimeStorage(System.Data.DataColumn column);
                /*0x14652dc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1465794*/ int Compare(int recordNo1, int recordNo2);
                /*0x146590c*/ int CompareValueTo(int recordNo, object value);
                /*0x1465a70*/ object ConvertValue(object value);
                /*0x1465bc0*/ void Copy(int recordNo1, int recordNo2);
                /*0x1465c14*/ object Get(int record);
                /*0x1465d0c*/ void Set(int record, object value);
                /*0x1466010*/ void SetCapacity(int capacity);
                /*0x14660d0*/ object ConvertXmlToObject(string s);
                /*0x1466188*/ string ConvertObjectToXml(object value);
                /*0x146623c*/ object GetEmptyStorage(int recordCount);
                /*0x1466284*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x14663bc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DecimalStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ decimal s_defaultValue;
                /*0x50*/ decimal[] _values;

                /*0x14621c8*/ DecimalStorage(System.Data.DataColumn column);
                /*0x1466614*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1466fa4*/ int Compare(int recordNo1, int recordNo2);
                /*0x1467120*/ int CompareValueTo(int recordNo, object value);
                /*0x146728c*/ object ConvertValue(object value);
                /*0x1467404*/ void Copy(int recordNo1, int recordNo2);
                /*0x146745c*/ object Get(int record);
                /*0x1467520*/ void Set(int record, object value);
                /*0x14676c8*/ void SetCapacity(int capacity);
                /*0x1467788*/ object ConvertXmlToObject(string s);
                /*0x146783c*/ string ConvertObjectToXml(object value);
                /*0x14678d8*/ object GetEmptyStorage(int recordCount);
                /*0x1467920*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1467a24*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ double[] _values;

                /*0x14620d4*/ DoubleStorage(System.Data.DataColumn column);
                /*0x1467ab8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14681b8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1468238*/ int CompareValueTo(int recordNo, object value);
                /*0x1468340*/ object ConvertValue(object value);
                /*0x146848c*/ void Copy(int recordNo1, int recordNo2);
                /*0x14684e0*/ object Get(int record);
                /*0x1468580*/ void Set(int record, object value);
                /*0x1468704*/ void SetCapacity(int capacity);
                /*0x14687c4*/ object ConvertXmlToObject(string s);
                /*0x146884c*/ string ConvertObjectToXml(object value);
                /*0x14688e4*/ object GetEmptyStorage(int recordCount);
                /*0x146892c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1468a2c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ short[] _values;

                /*0x1461df8*/ Int16Storage(System.Data.DataColumn column);
                /*0x1468ac0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14692d8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1469338*/ int CompareValueTo(int recordNo, object value);
                /*0x1469428*/ object ConvertValue(object value);
                /*0x1469578*/ void Copy(int recordNo1, int recordNo2);
                /*0x14695cc*/ object Get(int record);
                /*0x1469668*/ void Set(int record, object value);
                /*0x14697ec*/ void SetCapacity(int capacity);
                /*0x14698ac*/ object ConvertXmlToObject(string s);
                /*0x1469938*/ string ConvertObjectToXml(object value);
                /*0x14699d0*/ object GetEmptyStorage(int recordCount);
                /*0x1469a18*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1469b14*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ int[] _values;

                /*0x1461eec*/ Int32Storage(System.Data.DataColumn column);
                /*0x1469ba8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x146a3b0*/ int Compare(int recordNo1, int recordNo2);
                /*0x146a41c*/ int CompareValueTo(int recordNo, object value);
                /*0x146a50c*/ object ConvertValue(object value);
                /*0x146a65c*/ void Copy(int recordNo1, int recordNo2);
                /*0x146a6b0*/ object Get(int record);
                /*0x146a74c*/ void Set(int record, object value);
                /*0x146a8d0*/ void SetCapacity(int capacity);
                /*0x146a990*/ object ConvertXmlToObject(string s);
                /*0x146aa1c*/ string ConvertObjectToXml(object value);
                /*0x146aab4*/ object GetEmptyStorage(int recordCount);
                /*0x146aafc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x146abf8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ long[] _values;

                /*0x1461fe0*/ Int64Storage(System.Data.DataColumn column);
                /*0x146ac8c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x146b468*/ int Compare(int recordNo1, int recordNo2);
                /*0x146b4d4*/ int CompareValueTo(int recordNo, object value);
                /*0x146b5c4*/ object ConvertValue(object value);
                /*0x146b714*/ void Copy(int recordNo1, int recordNo2);
                /*0x146b768*/ object Get(int record);
                /*0x146b804*/ void Set(int record, object value);
                /*0x146b988*/ void SetCapacity(int capacity);
                /*0x146ba48*/ object ConvertXmlToObject(string s);
                /*0x146bad4*/ string ConvertObjectToXml(object value);
                /*0x146bb6c*/ object GetEmptyStorage(int recordCount);
                /*0x146bbb4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x146bcb0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ObjectStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ object s_defaultValue;
                static /*0x8*/ object s_tempAssemblyCacheLock;
                static /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>, System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache;
                static /*0x18*/ System.Xml.Serialization.XmlSerializerFactory s_serializerFactory;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;

                static /*0x1470df8*/ ObjectStorage();
                static /*0x1463494*/ void VerifyIDynamicMetaObjectProvider(System.Type type);
                static /*0x146d8d0*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type);
                static /*0x146fc7c*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute);
                /*0x1461b64*/ ObjectStorage(System.Data.DataColumn column, System.Type type);
                /*0x146bd44*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x146bd74*/ int Compare(int recordNo1, int recordNo2);
                /*0x146c3e0*/ int CompareValueTo(int recordNo1, object value);
                /*0x146c5c4*/ int CompareTo(object valueNo1, object valueNo2);
                /*0x146bf28*/ int CompareWithFamilies(object valueNo1, object valueNo2);
                /*0x146c890*/ void Copy(int recordNo1, int recordNo2);
                /*0x146c904*/ object Get(int recordNo);
                /*0x146c79c*/ System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType);
                /*0x146c940*/ bool IsNull(int record);
                /*0x146c978*/ void Set(int recordNo, object value);
                /*0x146d2c8*/ void SetCapacity(int capacity);
                /*0x146d380*/ object ConvertXmlToObject(string s);
                /*0x146d944*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x147024c*/ string ConvertObjectToXml(object value);
                /*0x14708a0*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x1470a04*/ object GetEmptyStorage(int recordCount);
                /*0x1470a4c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1470c44*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                enum Families
                {
                    DATETIME = 0,
                    NUMBER = 1,
                    STRING = 2,
                    BOOLEAN = 3,
                    ARRAY = 4,
                }

                class TempAssemblyComparer : System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>> s_default;

                    static /*0x147108c*/ TempAssemblyComparer();
                    /*0x1470eb4*/ TempAssemblyComparer();
                    /*0x1470ebc*/ bool Equals(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> y);
                    /*0x1471004*/ int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> obj);
                }
            }

            class SByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ sbyte[] _values;

                /*0x1461d04*/ SByteStorage(System.Data.DataColumn column);
                /*0x14710f0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14718b0*/ int Compare(int recordNo1, int recordNo2);
                /*0x1471968*/ int CompareValueTo(int recordNo, object value);
                /*0x1471a6c*/ object ConvertValue(object value);
                /*0x1471bbc*/ void Copy(int recordNo1, int recordNo2);
                /*0x1471c10*/ object Get(int record);
                /*0x1471cc0*/ void Set(int record, object value);
                /*0x1471e44*/ void SetCapacity(int capacity);
                /*0x1471f04*/ object ConvertXmlToObject(string s);
                /*0x1471f90*/ string ConvertObjectToXml(object value);
                /*0x1472028*/ object GetEmptyStorage(int recordCount);
                /*0x1472070*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1472170*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlConvert
            {
                static /*0x1472204*/ System.Data.SqlTypes.SqlByte ConvertToSqlByte(object value);
                static /*0x14723d0*/ System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(object value);
                static /*0x1472654*/ System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(object value);
                static /*0x14729e8*/ System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(object value);
                static /*0x1472e88*/ System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(object value);
                static /*0x1473548*/ System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(object value);
                static /*0x1473b70*/ System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(object value);
                static /*0x14741c0*/ System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(object value);
                static /*0x147476c*/ System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(object value);
                static /*0x1474944*/ System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(object value);
                static /*0x1474b0c*/ System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(object value);
                static /*0x1474cd8*/ System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(object value);
                static /*0x1474e98*/ System.Data.SqlTypes.SqlString ConvertToSqlString(object value);
                static /*0x1475070*/ System.Data.SqlTypes.SqlChars ConvertToSqlChars(object value);
                static /*0x14751b8*/ System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(object value);
                static /*0x1475300*/ System.DateTimeOffset ConvertStringToDateTimeOffset(string value, System.IFormatProvider formatProvider);
                static /*0x1475368*/ object ChangeTypeForDefaultValue(object value, System.Type type, System.IFormatProvider formatProvider);
                static /*0x1475544*/ object ChangeType2(object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider);
                static /*0x146e014*/ object ChangeTypeForXML(object value, System.Type type);
            }

            class SqlBinaryStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBinary[] _values;

                /*0x146255c*/ SqlBinaryStorage(System.Data.DataColumn column);
                /*0x14768fc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1476b38*/ int Compare(int recordNo1, int recordNo2);
                /*0x1476b7c*/ int CompareValueTo(int recordNo, object value);
                /*0x1476c28*/ object ConvertValue(object value);
                /*0x1476c9c*/ void Copy(int recordNo1, int recordNo2);
                /*0x1476cd8*/ object Get(int record);
                /*0x1476d58*/ bool IsNull(int record);
                /*0x1476d8c*/ void Set(int record, object value);
                /*0x1476dd0*/ void SetCapacity(int capacity);
                /*0x1476e88*/ object ConvertXmlToObject(string s);
                /*0x1477168*/ string ConvertObjectToXml(object value);
                /*0x1477408*/ object GetEmptyStorage(int recordCount);
                /*0x1477450*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1477550*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlByte[] _values;

                /*0x146269c*/ SqlByteStorage(System.Data.DataColumn column);
                /*0x14775e8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1478384*/ int Compare(int recordNo1, int recordNo2);
                /*0x14783c8*/ int CompareValueTo(int recordNo, object value);
                /*0x1478474*/ object ConvertValue(object value);
                /*0x14784e8*/ void Copy(int recordNo1, int recordNo2);
                /*0x1478524*/ object Get(int record);
                /*0x14785a4*/ bool IsNull(int record);
                /*0x14785d8*/ void Set(int record, object value);
                /*0x147861c*/ void SetCapacity(int capacity);
                /*0x14786d4*/ object ConvertXmlToObject(string s);
                /*0x14789b4*/ string ConvertObjectToXml(object value);
                /*0x1478c54*/ object GetEmptyStorage(int recordCount);
                /*0x1478c9c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1478d9c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBytesStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBytes[] _values;

                /*0x14627d4*/ SqlBytesStorage(System.Data.DataColumn column);
                /*0x1478e34*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1479048*/ int Compare(int recordNo1, int recordNo2);
                /*0x1479050*/ int CompareValueTo(int recordNo, object value);
                /*0x1479058*/ void Copy(int recordNo1, int recordNo2);
                /*0x14790cc*/ object Get(int record);
                /*0x14790fc*/ bool IsNull(int record);
                /*0x1479134*/ void Set(int record, object value);
                /*0x147926c*/ void SetCapacity(int capacity);
                /*0x1479324*/ object ConvertXmlToObject(string s);
                /*0x147962c*/ string ConvertObjectToXml(object value);
                /*0x14798cc*/ object GetEmptyStorage(int recordCount);
                /*0x1479914*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1479a4c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlCharsStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlChars[] _values;

                /*0x14628b4*/ SqlCharsStorage(System.Data.DataColumn column);
                /*0x1479ae4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1479cf8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1479d00*/ int CompareValueTo(int recordNo, object value);
                /*0x1479d08*/ void Copy(int recordNo1, int recordNo2);
                /*0x1479d7c*/ object Get(int record);
                /*0x1479dac*/ bool IsNull(int record);
                /*0x1479de4*/ void Set(int record, object value);
                /*0x1479f1c*/ void SetCapacity(int capacity);
                /*0x1479fd4*/ object ConvertXmlToObject(string s);
                /*0x147a2f8*/ string ConvertObjectToXml(object value);
                /*0x147a598*/ object GetEmptyStorage(int recordCount);
                /*0x147a5e0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x147a718*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDateTimeStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDateTime[] _values;

                /*0x1462994*/ SqlDateTimeStorage(System.Data.DataColumn column);
                /*0x147a7b0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x147ad44*/ int Compare(int recordNo1, int recordNo2);
                /*0x147ad9c*/ int CompareValueTo(int recordNo, object value);
                /*0x147ae50*/ object ConvertValue(object value);
                /*0x147aec8*/ void Copy(int recordNo1, int recordNo2);
                /*0x147af20*/ object Get(int record);
                /*0x147afb0*/ bool IsNull(int record);
                /*0x147afe8*/ void Set(int record, object value);
                /*0x147b038*/ void SetCapacity(int capacity);
                /*0x147b0f0*/ object ConvertXmlToObject(string s);
                /*0x147b3f4*/ string ConvertObjectToXml(object value);
                /*0x147b694*/ object GetEmptyStorage(int recordCount);
                /*0x147b6dc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x147b7f4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDecimalStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDecimal[] _values;

                /*0x147ca04*/ SqlDecimalStorage(System.Data.DataColumn column);
                /*0x147cb54*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x147da30*/ int Compare(int recordNo1, int recordNo2);
                /*0x147daa8*/ int CompareValueTo(int recordNo, object value);
                /*0x147db74*/ object ConvertValue(object value);
                /*0x147dc00*/ void Copy(int recordNo1, int recordNo2);
                /*0x147dc68*/ object Get(int record);
                /*0x147dcf4*/ bool IsNull(int record);
                /*0x147dd2c*/ void Set(int record, object value);
                /*0x147ddb0*/ void SetCapacity(int capacity);
                /*0x147de68*/ object ConvertXmlToObject(string s);
                /*0x147e16c*/ string ConvertObjectToXml(object value);
                /*0x147e408*/ object GetEmptyStorage(int recordCount);
                /*0x147e450*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x147e580*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDouble[] _values;

                /*0x147e618*/ SqlDoubleStorage(System.Data.DataColumn column);
                /*0x147e758*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x147f3d4*/ int Compare(int recordNo1, int recordNo2);
                /*0x147f420*/ int CompareValueTo(int recordNo, object value);
                /*0x147f4cc*/ object ConvertValue(object value);
                /*0x147f544*/ void Copy(int recordNo1, int recordNo2);
                /*0x147f584*/ object Get(int record);
                /*0x147f608*/ bool IsNull(int record);
                /*0x147f63c*/ void Set(int record, object value);
                /*0x147f688*/ void SetCapacity(int capacity);
                /*0x147f740*/ object ConvertXmlToObject(string s);
                /*0x147fa30*/ string ConvertObjectToXml(object value);
                /*0x147fccc*/ object GetEmptyStorage(int recordCount);
                /*0x147fd14*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x147fe1c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlGuidStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlGuid[] _values;

                /*0x147feb4*/ SqlGuidStorage(System.Data.DataColumn column);
                /*0x147fff4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1480230*/ int Compare(int recordNo1, int recordNo2);
                /*0x1480274*/ int CompareValueTo(int recordNo, object value);
                /*0x1480320*/ object ConvertValue(object value);
                /*0x1480398*/ void Copy(int recordNo1, int recordNo2);
                /*0x14803d4*/ object Get(int record);
                /*0x1480454*/ bool IsNull(int record);
                /*0x1480488*/ void Set(int record, object value);
                /*0x14804d0*/ void SetCapacity(int capacity);
                /*0x1480588*/ object ConvertXmlToObject(string s);
                /*0x1480868*/ string ConvertObjectToXml(object value);
                /*0x1480b04*/ object GetEmptyStorage(int recordCount);
                /*0x1480b4c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1480c4c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt16[] _values;

                /*0x1480ce4*/ SqlInt16Storage(System.Data.DataColumn column);
                /*0x1480e1c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1481bc8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1481c0c*/ int CompareValueTo(int recordNo, object value);
                /*0x1481cb8*/ object ConvertValue(object value);
                /*0x1481d30*/ void Copy(int recordNo1, int recordNo2);
                /*0x1481d6c*/ object Get(int record);
                /*0x1481dec*/ bool IsNull(int record);
                /*0x1481e20*/ void Set(int record, object value);
                /*0x1481e68*/ void SetCapacity(int capacity);
                /*0x1481f20*/ object ConvertXmlToObject(string s);
                /*0x1482200*/ string ConvertObjectToXml(object value);
                /*0x148249c*/ object GetEmptyStorage(int recordCount);
                /*0x14824e4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x14825e4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt32[] _values;

                /*0x148267c*/ SqlInt32Storage(System.Data.DataColumn column);
                /*0x14827bc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1483538*/ int Compare(int recordNo1, int recordNo2);
                /*0x148357c*/ int CompareValueTo(int recordNo, object value);
                /*0x1483628*/ object ConvertValue(object value);
                /*0x14836a0*/ void Copy(int recordNo1, int recordNo2);
                /*0x14836dc*/ object Get(int record);
                /*0x148375c*/ bool IsNull(int record);
                /*0x1483790*/ void Set(int record, object value);
                /*0x14837d8*/ void SetCapacity(int capacity);
                /*0x1483890*/ object ConvertXmlToObject(string s);
                /*0x1483b70*/ string ConvertObjectToXml(object value);
                /*0x1483e0c*/ object GetEmptyStorage(int recordCount);
                /*0x1483e54*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1483f54*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt64[] _values;

                /*0x1483fec*/ SqlInt64Storage(System.Data.DataColumn column);
                /*0x148412c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1484f28*/ int Compare(int recordNo1, int recordNo2);
                /*0x1484f74*/ int CompareValueTo(int recordNo, object value);
                /*0x1485020*/ object ConvertValue(object value);
                /*0x1485098*/ void Copy(int recordNo1, int recordNo2);
                /*0x14850d8*/ object Get(int record);
                /*0x148515c*/ bool IsNull(int record);
                /*0x1485190*/ void Set(int record, object value);
                /*0x14851dc*/ void SetCapacity(int capacity);
                /*0x1485294*/ object ConvertXmlToObject(string s);
                /*0x1485584*/ string ConvertObjectToXml(object value);
                /*0x1485820*/ object GetEmptyStorage(int recordCount);
                /*0x1485868*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1485970*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlMoneyStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlMoney[] _values;

                /*0x1485a08*/ SqlMoneyStorage(System.Data.DataColumn column);
                /*0x1485b48*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14869ac*/ int Compare(int recordNo1, int recordNo2);
                /*0x14869f8*/ int CompareValueTo(int recordNo, object value);
                /*0x1486aa4*/ object ConvertValue(object value);
                /*0x1486b1c*/ void Copy(int recordNo1, int recordNo2);
                /*0x1486b5c*/ object Get(int record);
                /*0x1486be0*/ bool IsNull(int record);
                /*0x1486c14*/ void Set(int record, object value);
                /*0x1486c60*/ void SetCapacity(int capacity);
                /*0x1486d18*/ object ConvertXmlToObject(string s);
                /*0x1487008*/ string ConvertObjectToXml(object value);
                /*0x14872a4*/ object GetEmptyStorage(int recordCount);
                /*0x14872ec*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x14873f4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlSingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlSingle[] _values;

                /*0x148748c*/ SqlSingleStorage(System.Data.DataColumn column);
                /*0x14875cc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x14882f4*/ int Compare(int recordNo1, int recordNo2);
                /*0x1488338*/ int CompareValueTo(int recordNo, object value);
                /*0x14883e4*/ object ConvertValue(object value);
                /*0x148845c*/ void Copy(int recordNo1, int recordNo2);
                /*0x1488498*/ object Get(int record);
                /*0x1488518*/ bool IsNull(int record);
                /*0x148854c*/ void Set(int record, object value);
                /*0x1488594*/ void SetCapacity(int capacity);
                /*0x148864c*/ object ConvertXmlToObject(string s);
                /*0x148892c*/ string ConvertObjectToXml(object value);
                /*0x1488bc8*/ object GetEmptyStorage(int recordCount);
                /*0x1488c10*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1488d10*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlStringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlString[] _values;

                /*0x1488da8*/ SqlStringStorage(System.Data.DataColumn column);
                /*0x1488ee8*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x1489304*/ int Compare(int recordNo1, int recordNo2);
                /*0x1489374*/ int Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2);
                /*0x148942c*/ int CompareValueTo(int recordNo, object value);
                /*0x14894f0*/ object ConvertValue(object value);
                /*0x1489570*/ void Copy(int recordNo1, int recordNo2);
                /*0x14895c8*/ object Get(int record);
                /*0x148964c*/ int GetStringLength(int record);
                /*0x14896c0*/ bool IsNull(int record);
                /*0x14896f8*/ void Set(int record, object value);
                /*0x1489764*/ void SetCapacity(int capacity);
                /*0x148981c*/ object ConvertXmlToObject(string s);
                /*0x1489b10*/ string ConvertObjectToXml(object value);
                /*0x1489dac*/ object GetEmptyStorage(int recordCount);
                /*0x1489df4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1489f0c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBoolean[] _values;

                /*0x1489fa4*/ SqlBooleanStorage(System.Data.DataColumn column);
                /*0x148a0e4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x148a570*/ int Compare(int recordNo1, int recordNo2);
                /*0x148a5b4*/ int CompareValueTo(int recordNo, object value);
                /*0x148a660*/ object ConvertValue(object value);
                /*0x148a6d8*/ void Copy(int recordNo1, int recordNo2);
                /*0x148a714*/ object Get(int record);
                /*0x148a794*/ bool IsNull(int record);
                /*0x148a7c8*/ void Set(int record, object value);
                /*0x148a810*/ void SetCapacity(int capacity);
                /*0x148a8c8*/ object ConvertXmlToObject(string s);
                /*0x148aba8*/ string ConvertObjectToXml(object value);
                /*0x148ae44*/ object GetEmptyStorage(int recordCount);
                /*0x148ae8c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x148af8c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ float[] _values;

                /*0x148b024*/ SingleStorage(System.Data.DataColumn column);
                /*0x148b11c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x148b83c*/ int Compare(int recordNo1, int recordNo2);
                /*0x148b8c0*/ int CompareValueTo(int recordNo, object value);
                /*0x148b9c8*/ object ConvertValue(object value);
                /*0x148bb0c*/ void Copy(int recordNo1, int recordNo2);
                /*0x148bb64*/ object Get(int record);
                /*0x148bc08*/ void Set(int record, object value);
                /*0x148bd74*/ void SetCapacity(int capacity);
                /*0x148be38*/ object ConvertXmlToObject(string s);
                /*0x148bec0*/ string ConvertObjectToXml(object value);
                /*0x148bf58*/ object GetEmptyStorage(int recordCount);
                /*0x148bfa0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x148c0a0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlUdtStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, object> s_typeToNull;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;
                /*0x59*/ bool _implementsIComparable;

                static /*0x148d794*/ SqlUdtStorage();
                static /*0x148c1ac*/ object GetStaticNullForUdtType(System.Type type);
                /*0x148c134*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type);
                /*0x148c2b8*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type, object nullValue);
                /*0x148c448*/ bool IsNull(int record);
                /*0x148c54c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x148c57c*/ int Compare(int recordNo1, int recordNo2);
                /*0x148c5b4*/ int CompareValueTo(int recordNo1, object value);
                /*0x148c840*/ void Copy(int recordNo1, int recordNo2);
                /*0x148c8c4*/ object Get(int recordNo);
                /*0x148c8f4*/ void Set(int recordNo, object value);
                /*0x148ca54*/ void SetCapacity(int capacity);
                /*0x148cb18*/ object ConvertXmlToObject(string s);
                /*0x148ce60*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x148d0fc*/ string ConvertObjectToXml(object value);
                /*0x148d424*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x148d57c*/ object GetEmptyStorage(int recordCount);
                /*0x148d5c4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x148d6fc*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Type type;

                    /*0x148c440*/ <>c__DisplayClass6_0();
                    /*0x148d820*/ object <GetStaticNullForUdtType>b__0(System.Type t);
                }
            }

            class StringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ string[] _values;

                /*0x148d948*/ StringStorage(System.Data.DataColumn column);
                /*0x148da2c*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x148dd14*/ int Compare(int recordNo1, int recordNo2);
                /*0x148dd8c*/ int CompareValueTo(int recordNo, object value);
                /*0x148de60*/ object ConvertValue(object value);
                /*0x148de90*/ void Copy(int recordNo1, int recordNo2);
                /*0x148df04*/ object Get(int recordNo);
                /*0x148df40*/ int GetStringLength(int record);
                /*0x148df80*/ bool IsNull(int record);
                /*0x148dfb8*/ void Set(int record, object value);
                /*0x148e054*/ void SetCapacity(int capacity);
                /*0x148e10c*/ object ConvertXmlToObject(string s);
                /*0x148e114*/ string ConvertObjectToXml(object value);
                /*0x148e174*/ object GetEmptyStorage(int recordCount);
                /*0x148e1bc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x148e2f4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class TimeSpanStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.TimeSpan s_defaultValue;
                /*0x50*/ System.TimeSpan[] _values;

                static /*0x148fbc0*/ TimeSpanStorage();
                static /*0x148f2fc*/ System.TimeSpan ConvertToTimeSpan(object value);
                /*0x148e38c*/ TimeSpanStorage(System.Data.DataColumn column);
                /*0x148e4b8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x148f020*/ int Compare(int recordNo1, int recordNo2);
                /*0x148f19c*/ int CompareValueTo(int recordNo, object value);
                /*0x148f524*/ object ConvertValue(object value);
                /*0x148f5d0*/ void Copy(int recordNo1, int recordNo2);
                /*0x148f628*/ object Get(int record);
                /*0x148f728*/ void Set(int record, object value);
                /*0x148f7fc*/ void SetCapacity(int capacity);
                /*0x148f8c0*/ object ConvertXmlToObject(string s);
                /*0x148f94c*/ string ConvertObjectToXml(object value);
                /*0x148f9e4*/ object GetEmptyStorage(int recordCount);
                /*0x148fa2c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x148fb2c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt16Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ushort s_defaultValue;
                /*0x50*/ ushort[] _values;

                /*0x148fc38*/ UInt16Storage(System.Data.DataColumn column);
                /*0x148fd50*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1490570*/ int Compare(int recordNo1, int recordNo2);
                /*0x149062c*/ int CompareValueTo(int recordNo, object value);
                /*0x1490748*/ object ConvertValue(object value);
                /*0x1490890*/ void Copy(int recordNo1, int recordNo2);
                /*0x14908e8*/ object Get(int record);
                /*0x14909b8*/ void Set(int record, object value);
                /*0x1490b40*/ void SetCapacity(int capacity);
                /*0x1490c04*/ object ConvertXmlToObject(string s);
                /*0x1490c90*/ string ConvertObjectToXml(object value);
                /*0x1490d28*/ object GetEmptyStorage(int recordCount);
                /*0x1490d70*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1490e70*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt32Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ uint s_defaultValue;
                /*0x50*/ uint[] _values;

                /*0x1490f04*/ UInt32Storage(System.Data.DataColumn column);
                /*0x149101c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1491840*/ int Compare(int recordNo1, int recordNo2);
                /*0x149190c*/ int CompareValueTo(int recordNo, object value);
                /*0x1491a28*/ object ConvertValue(object value);
                /*0x1491b70*/ void Copy(int recordNo1, int recordNo2);
                /*0x1491bc8*/ object Get(int record);
                /*0x1491c98*/ void Set(int record, object value);
                /*0x1491e20*/ void SetCapacity(int capacity);
                /*0x1491ee4*/ object ConvertXmlToObject(string s);
                /*0x1491f70*/ string ConvertObjectToXml(object value);
                /*0x1492008*/ object GetEmptyStorage(int recordCount);
                /*0x1492050*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1492150*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt64Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ulong s_defaultValue;
                /*0x50*/ ulong[] _values;

                /*0x14921e4*/ UInt64Storage(System.Data.DataColumn column);
                /*0x14922fc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1492b18*/ int Compare(int recordNo1, int recordNo2);
                /*0x1492c20*/ int CompareValueTo(int recordNo, object value);
                /*0x1492d3c*/ object ConvertValue(object value);
                /*0x1492e84*/ void Copy(int recordNo1, int recordNo2);
                /*0x1492edc*/ object Get(int record);
                /*0x1492fac*/ void Set(int record, object value);
                /*0x1493134*/ void SetCapacity(int capacity);
                /*0x14931f8*/ object ConvertXmlToObject(string s);
                /*0x1493284*/ string ConvertObjectToXml(object value);
                /*0x149331c*/ object GetEmptyStorage(int recordCount);
                /*0x1493364*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1493464*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E;
    static /*0x98*/ <PrivateImplementationDetails> 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D;
    static /*0xbe*/ <PrivateImplementationDetails> 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA;
    static /*0xf2*/ <PrivateImplementationDetails> 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD;
    static /*0x116*/ <PrivateImplementationDetails> BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226;
    static /*0x1ae*/ <PrivateImplementationDetails> C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E;
    static /*0x246*/ <PrivateImplementationDetails> D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939;
    static /*0x2de*/ <PrivateImplementationDetails> E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6;
    static /*0x38e*/ <PrivateImplementationDetails> F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591;
    static /*0x3ce*/ <PrivateImplementationDetails> FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=38
    {
    }

    struct __StaticArrayInitTypeSize=52
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=152
    {
    }

    struct __StaticArrayInitTypeSize=176
    {
    }
}
