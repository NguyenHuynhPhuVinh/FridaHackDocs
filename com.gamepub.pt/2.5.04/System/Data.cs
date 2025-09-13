class <Module>
{
}

class SR
{
    static /*0x1ed3d44*/ string GetString(string name);
    static /*0x1ed3be4*/ string Format(string resourceFormat, object p1);
    static /*0x1ed3d48*/ string Format(string resourceFormat, object p1, object p2);
    static /*0x1ed3dcc*/ string Format(string resourceFormat, object p1, object p2, object p3);
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

            static /*0x2100fc8*/ InternalDataCollectionBase();
            /*0x2100fc0*/ InternalDataCollectionBase();
            /*0x2100e48*/ int get_Count();
            /*0x2100e78*/ void CopyTo(System.Array ar, int index);
            /*0x2100ec4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x2100ef4*/ bool get_IsSynchronized();
            /*0x2100efc*/ int NamesEqual(string s1, string s2, bool fCaseSensitive, System.Globalization.CultureInfo locale);
            /*0x2100fb4*/ object get_SyncRoot();
            /*0x2100fb8*/ System.Collections.ArrayList get_List();
        }

        class ColumnTypeConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.Type[] s_types;
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            static /*0x21c5920*/ ColumnTypeConverter();
            /*0x21c4e60*/ ColumnTypeConverter();
            /*0x21c4ec4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x21c4f8c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x21c54ec*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x21c55b4*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x21c57e0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x21c5910*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x21c5918*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataCommonEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Data.DataCommonEventSource Log;
            static /*0x8*/ long s_nextScopeId;

            static /*0x1b23dbc*/ DataCommonEventSource();
            /*0x1b23d58*/ DataCommonEventSource();
            /*0x1b23cfc*/ void Trace(string message);
            void Trace<T0>(string format, T0 arg0);
            void Trace<T0, T1>(string format, T0 arg0, T1 arg1);
            void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2);
            void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x1b23d00*/ long EnterScope(string message);
            long EnterScope<T1>(string format, T1 arg1);
            long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2);
            long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
            long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x1b23d54*/ void ExitScope(long scopeId);
        }

        class Constraint
        {
            /*0x10*/ string _schemaName;
            /*0x18*/ bool _inCollection;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ string _name;
            /*0x30*/ System.Data.PropertyCollection _extendedProperties;

            /*0x21c7754*/ Constraint();
            /*0x21c6ff4*/ string get_ConstraintName();
            /*0x21c6ffc*/ void set_ConstraintName(string value);
            /*0x21c748c*/ string get_SchemaName();
            /*0x21c74d4*/ void set_SchemaName(string value);
            /*0x21c7508*/ bool get_InCollection();
            /*0x21c7510*/ void set_InCollection(bool value);
            System.Data.DataTable get_Table();
            /*0x21c7560*/ System.Data.PropertyCollection get_ExtendedProperties();
            bool ContainsColumn(System.Data.DataColumn column);
            bool CanEnableConstraint();
            System.Data.Constraint Clone(System.Data.DataSet destination);
            System.Data.Constraint Clone(System.Data.DataSet destination, bool ignoreNSforTableLookup);
            /*0x21c75c8*/ void CheckConstraint();
            void CheckCanAddToCollection(System.Data.ConstraintCollection constraint);
            bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, bool fThrowException);
            void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            void CheckState();
            /*0x21c7628*/ void CheckStateForProperty();
            /*0x21c7740*/ System.Data.DataSet get__DataSet();
            bool IsConstraintViolated();
            /*0x21c7748*/ string ToString();
        }

        class ConstraintCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;
            /*0x30*/ System.Data.Constraint[] _delayLoadingConstraints;
            /*0x38*/ bool _fLoadForeignKeyConstraintsOnly;

            static /*0x21c9168*/ bool CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2);
            /*0x21c77bc*/ ConstraintCollection(System.Data.DataTable table);
            /*0x21c7868*/ System.Collections.ArrayList get_List();
            /*0x21c7870*/ System.Data.Constraint get_Item(int index);
            /*0x21c7978*/ System.Data.DataTable get_Table();
            /*0x21c7980*/ System.Data.Constraint get_Item(string name);
            /*0x21c7be8*/ void Add(System.Data.Constraint constraint);
            /*0x21c7bf0*/ void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign);
            /*0x21c85d0*/ System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey);
            /*0x21c8204*/ void AddUniqueConstraint(System.Data.UniqueConstraint constraint);
            /*0x21c842c*/ void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint);
            /*0x21c8130*/ bool AutoGenerated(System.Data.Constraint constraint);
            /*0x21c856c*/ void ArrayAdd(System.Data.Constraint constraint);
            /*0x21c867c*/ void ArrayRemove(System.Data.Constraint constraint);
            /*0x21c83fc*/ string AssignName();
            /*0x21c84a0*/ void BaseAdd(System.Data.Constraint constraint);
            /*0x21c878c*/ void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength);
            /*0x21c8958*/ void BaseRemove(System.Data.Constraint constraint);
            /*0x21c8bfc*/ bool CanRemove(System.Data.Constraint constraint, bool fThrowException);
            /*0x21c8c2c*/ void Clear();
            /*0x21c9024*/ bool Contains(string name);
            /*0x21c9040*/ bool Contains(string name, bool caseSensitive);
            /*0x21c7fa0*/ System.Data.Constraint FindConstraint(System.Data.Constraint constraint);
            /*0x21c82ec*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns);
            /*0x21c91f4*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column);
            /*0x21c930c*/ System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x21c7a78*/ int InternalIndexOf(string constraintName);
            /*0x21c86c0*/ string MakeName(int index);
            /*0x21c85b0*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x21c71e4*/ void RegisterName(string name);
            /*0x21c9448*/ void Remove(System.Data.Constraint constraint);
            /*0x21c7408*/ void UnregisterName(string name);
        }

        class ConstraintConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x21c95ac*/ ConstraintConverter();
            /*0x21c95b4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x21c967c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class ConstraintEnumerator
        {
            /*0x10*/ System.Collections.IEnumerator _tables;
            /*0x18*/ System.Collections.IEnumerator _constraints;
            /*0x20*/ System.Data.Constraint _currentObject;

            /*0x21ca038*/ ConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x21ca090*/ bool GetNext();
            /*0x21ca394*/ System.Data.Constraint GetConstraint();
            /*0x21ca39c*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x21ca3a4*/ System.Data.Constraint get_CurrentObject();
        }

        class ForeignKeyConstraintEnumerator : System.Data.ConstraintEnumerator
        {
            /*0x20f4d94*/ ForeignKeyConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x20f4d9c*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x20f4e18*/ System.Data.ForeignKeyConstraint GetForeignKeyConstraint();
        }

        class ChildForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x21c4d94*/ ChildForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x21c4dc0*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class ParentForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x210c3d4*/ ParentForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x210c400*/ bool IsValidCandidate(System.Data.Constraint constraint);
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

            static /*0x21cb9b8*/ bool IsAutoIncrementType(System.Type dataType);
            /*0x21ca4bc*/ DataColumn();
            /*0x21ca880*/ DataColumn(string columnName, System.Type dataType);
            /*0x21ca550*/ DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type);
            /*0x21ca8d4*/ void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode);
            /*0x21cb210*/ bool get_AllowDBNull();
            /*0x21cb218*/ void set_AllowDBNull(bool value);
            /*0x21cb7cc*/ bool get_AutoIncrement();
            /*0x21cb7ec*/ void set_AutoIncrement(bool value);
            /*0x21cc6a8*/ object get_AutoIncrementCurrent();
            /*0x21cc73c*/ void set_AutoIncrementCurrent(object value);
            /*0x21cc5a0*/ System.Data.AutoIncrementValue get_AutoInc();
            /*0x21cc724*/ long get_AutoIncrementSeed();
            /*0x21cc8c0*/ void set_AutoIncrementSeed(long value);
            /*0x21cc9bc*/ long get_AutoIncrementStep();
            /*0x21cc9d8*/ void set_AutoIncrementStep(long value);
            /*0x21ccadc*/ string get_Caption();
            /*0x21ccaf4*/ void set_Caption(string value);
            /*0x21ccbfc*/ string get_ColumnName();
            /*0x21ccc04*/ void set_ColumnName(string value);
            /*0x21ccfe0*/ string get_EncodedColumnName();
            /*0x21cc848*/ System.IFormatProvider get_FormatProvider();
            /*0x21ccb84*/ System.Globalization.CultureInfo get_Locale();
            /*0x21cd058*/ int get_ObjectID();
            /*0x21cd060*/ string get_Prefix();
            /*0x21cd068*/ void set_Prefix(string value);
            /*0x21cd1ec*/ string GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x21b745c*/ bool get_Computed();
            /*0x21cd320*/ System.Data.DataExpression get_DataExpression();
            /*0x21cd328*/ System.Type get_DataType();
            /*0x21cbcf0*/ void set_DataType(System.Type value);
            /*0x21cd8e4*/ System.Data.DataSetDateTime get_DateTimeMode();
            /*0x21cd8ec*/ void set_DateTimeMode(System.Data.DataSetDateTime value);
            /*0x21cd478*/ object get_DefaultValue();
            /*0x21cd5b0*/ void set_DefaultValue(object value);
            /*0x21cda30*/ bool get_DefaultValueIsNull();
            /*0x21cda38*/ string get_Expression();
            /*0x21ca9fc*/ void set_Expression(string value);
            /*0x21cdd2c*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x21cbce0*/ bool get_HasData();
            /*0x21cdd94*/ bool get_ImplementsINullable();
            /*0x21cdd9c*/ bool get_ImplementsIChangeTracking();
            /*0x21cdda4*/ bool get_ImplementsIRevertibleChangeTracking();
            /*0x21cddac*/ bool get_IsValueType();
            /*0x21cddc8*/ bool get_IsSqlType();
            /*0x21cddd0*/ void SetMaxLengthSimpleType();
            /*0x21cde60*/ int get_MaxLength();
            /*0x21cde68*/ void set_MaxLength(int value);
            /*0x21ce524*/ string get_Namespace();
            /*0x21ce5a0*/ void set_Namespace(string value);
            /*0x21ce6e0*/ int get_Ordinal();
            /*0x21ce6e8*/ void SetOrdinalInternal(int ordinal);
            /*0x21ce820*/ bool get_ReadOnly();
            /*0x21cda98*/ void set_ReadOnly(bool value);
            /*0x21ce828*/ System.Data.Index get_SortIndex();
            /*0x21ce8f8*/ System.Data.DataTable get_Table();
            /*0x21ce900*/ void SetTable(System.Data.DataTable table);
            /*0x21ce9b4*/ System.Data.DataRow GetDataRow(int index);
            /*0x21cd2c0*/ object get_Item(int record);
            /*0x21ce9dc*/ void set_Item(int record, object value);
            /*0x21cdcec*/ void InitializeRecord(int record);
            /*0x21ceb74*/ void SetValue(int record, object value);
            /*0x21cec94*/ void FreeRecord(int record);
            /*0x21cecb8*/ bool get_Unique();
            /*0x21cecc0*/ void set_Unique(bool value);
            /*0x21cf19c*/ void InternalUnique(bool value);
            /*0x21cf1a8*/ string get_XmlDataType();
            /*0x21cf1b0*/ void set_XmlDataType(string value);
            /*0x21cf1b8*/ System.Data.SimpleType get_SimpleType();
            /*0x21ca88c*/ void set_SimpleType(System.Data.SimpleType value);
            /*0x21cf1c0*/ System.Data.MappingType get_ColumnMapping();
            /*0x21cf1c8*/ void set_ColumnMapping(System.Data.MappingType value);
            /*0x21cf41c*/ void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x21ce1dc*/ bool CheckMaxLength();
            /*0x21cf4f4*/ void CheckMaxLength(System.Data.DataRow dr);
            /*0x21cb3b4*/ void CheckNotAllowNull();
            /*0x21cf474*/ void CheckNullable(System.Data.DataRow row);
            /*0x21cf140*/ void CheckUnique();
            /*0x21cf598*/ int Compare(int record1, int record2);
            /*0x21cf5b8*/ bool CompareValueTo(int record1, object value, bool checkType);
            /*0x21cf7b8*/ int CompareValueTo(int record1, object value);
            /*0x21cf7d8*/ object ConvertValue(object value);
            /*0x21cf7f8*/ void Copy(int srcRecordNo, int dstRecordNo);
            /*0x21cf818*/ System.Data.DataColumn Clone();
            /*0x21b729c*/ object GetAggregateValue(int[] records, System.Data.AggregateType kind);
            /*0x21cf578*/ int GetStringLength(int record);
            /*0x21cfcc8*/ void Init(int record);
            /*0x21cfd64*/ bool get_IsCustomType();
            /*0x21cfde4*/ bool IsValueCustomTypeInstance(object value);
            /*0x21cfebc*/ bool get_ImplementsIXMLSerializable();
            /*0x21cd330*/ bool IsInRelation();
            /*0x21cfec4*/ bool IsMaxLengthViolated();
            /*0x21d03dc*/ bool IsNotAllowDBNullViolated();
            /*0x21d0524*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x21ccf68*/ void RaisePropertyChanging(string name);
            /*0x21d0544*/ void InsureStorage();
            /*0x21d05d0*/ void SetCapacity(int capacity);
            /*0x21d0610*/ void OnSetDataSet();
            /*0x21d0614*/ string ToString();
            /*0x21d068c*/ object ConvertXmlToObject(string s);
            /*0x21d06cc*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x21cd2e0*/ string ConvertObjectToXml(object value);
            /*0x21d071c*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x21d0774*/ object GetEmptyColumnStore(int recordCount);
            /*0x21d07ac*/ void CopyValueIntoStore(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
            /*0x21d07c8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            /*0x21d0810*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x21d08d0*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x21cdb9c*/ void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression);
        }

        class AutoIncrementValue
        {
            /*0x10*/ bool <Auto>k__BackingField;

            /*0x21b84bc*/ AutoIncrementValue();
            /*0x21b8a78*/ bool get_Auto();
            /*0x21b8a80*/ void set_Auto(bool value);
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
            /*0x21b8a8c*/ System.Data.AutoIncrementValue Clone();
        }

        class AutoIncrementInt64 : System.Data.AutoIncrementValue
        {
            /*0x18*/ long _current;
            /*0x20*/ long _seed;
            /*0x28*/ long _step;

            /*0x21b8a68*/ AutoIncrementInt64();
            /*0x21b84c4*/ object get_Current();
            /*0x21b8524*/ void set_Current(object value);
            /*0x21b85a8*/ System.Type get_DataType();
            /*0x21b8620*/ long get_Seed();
            /*0x21b8628*/ void set_Seed(long value);
            /*0x21b87b8*/ long get_Step();
            /*0x21b87c0*/ void set_Step(long value);
            /*0x21b8850*/ void MoveAfter();
            /*0x21b8864*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x21b88e4*/ void SetCurrentAndIncrement(object value);
            /*0x21b86cc*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class AutoIncrementBigInteger : System.Data.AutoIncrementValue
        {
            /*0x18*/ System.Numerics.BigInteger _current;
            /*0x28*/ long _seed;
            /*0x30*/ System.Numerics.BigInteger _step;

            /*0x21b8448*/ AutoIncrementBigInteger();
            /*0x21b7470*/ object get_Current();
            /*0x21b74d0*/ void set_Current(object value);
            /*0x21b7554*/ System.Type get_DataType();
            /*0x21b75cc*/ long get_Seed();
            /*0x21b75d4*/ void set_Seed(long value);
            /*0x21b781c*/ long get_Step();
            /*0x21b7888*/ void set_Step(long value);
            /*0x21b7a20*/ void MoveAfter();
            /*0x21b7ab0*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x21b8374*/ void SetCurrentAndIncrement(object value);
            /*0x21b76d0*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class DataColumnChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataColumn _column;
            /*0x18*/ System.Data.DataRow <Row>k__BackingField;
            /*0x20*/ object <ProposedValue>k__BackingField;

            /*0x1b206d0*/ DataColumnChangeEventArgs(System.Data.DataRow row);
            /*0x1b20748*/ DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value);
            /*0x1b207d4*/ object get_ProposedValue();
            /*0x1b207dc*/ void set_ProposedValue(object value);
            /*0x1b207e4*/ void InitializeColumnChangeEvent(System.Data.DataColumn column, object value);
        }

        class DataColumnChangeEventHandler : System.MulticastDelegate
        {
            /*0x1b207f0*/ DataColumnChangeEventHandler(object object, nint method);
            /*0x1b20850*/ void Invoke(object sender, System.Data.DataColumnChangeEventArgs e);
            /*0x1b20be4*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataColumnChangeEventArgs e, System.AsyncCallback callback, object object);
            /*0x1b20c14*/ void EndInvoke(System.IAsyncResult result);
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

            /*0x1b20c20*/ DataColumnCollection(System.Data.DataTable table);
            /*0x1b20da8*/ System.Collections.ArrayList get_List();
            /*0x1b20db0*/ System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking();
            /*0x1b20db8*/ int get_ColumnsImplementingIChangeTrackingCount();
            /*0x1b20dc0*/ int get_ColumnsImplementingIRevertibleChangeTrackingCount();
            /*0x1b20dc8*/ System.Data.DataColumn get_Item(int index);
            /*0x1b20f04*/ System.Data.DataColumn get_Item(string name);
            /*0x1b211c0*/ System.Data.DataColumn get_Item(string name, string ns);
            /*0x1b21270*/ void Add(System.Data.DataColumn column);
            /*0x1b2127c*/ void AddAt(int index, System.Data.DataColumn column);
            /*0x1b21978*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b21a18*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b21ab8*/ void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b21b58*/ void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b2185c*/ void ArrayAdd(System.Data.DataColumn column);
            /*0x1b21818*/ void ArrayAdd(int index, System.Data.DataColumn column);
            /*0x1b21c40*/ void ArrayRemove(System.Data.DataColumn column);
            /*0x1b21e90*/ string AssignName();
            /*0x1b2150c*/ void BaseAdd(System.Data.DataColumn column);
            /*0x1b222a8*/ void BaseGroupSwitch(System.Data.DataColumn[] oldArray, int oldLength, System.Data.DataColumn[] newArray, int newLength);
            /*0x1b224a0*/ void BaseRemove(System.Data.DataColumn column);
            /*0x1b22568*/ bool CanRemove(System.Data.DataColumn column, bool fThrowException);
            /*0x1b21bf8*/ void CheckIChangeTracking(System.Data.DataColumn column);
            /*0x1b22de8*/ void Clear();
            /*0x1b23124*/ bool Contains(string name);
            /*0x1b231bc*/ bool Contains(string name, bool caseSensitive);
            /*0x1b23264*/ int IndexOf(string columnName);
            /*0x1b21058*/ int IndexOfCaseInsensitive(string name);
            /*0x1b21f30*/ string MakeName(int index);
            /*0x1b218cc*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x1b214ec*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x1b23370*/ void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x1b21ffc*/ void RegisterColumnName(string name, System.Data.DataColumn column);
            /*0x1b233c4*/ bool CanRegisterName(string name);
            /*0x1b23434*/ void Remove(System.Data.DataColumn column);
            /*0x1b221e0*/ void UnregisterName(string name);
            /*0x1b22d14*/ void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
            /*0x1b21d80*/ void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
        }

        class DataColumnPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataColumn <Column>k__BackingField;

            /*0x1b2353c*/ DataColumnPropertyDescriptor(System.Data.DataColumn dataColumn);
            /*0x1b23578*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x1b23750*/ System.Data.DataColumn get_Column();
            /*0x1b23758*/ System.Type get_ComponentType();
            /*0x1b237d0*/ bool get_IsReadOnly();
            /*0x1b237ec*/ System.Type get_PropertyType();
            /*0x1b23808*/ bool Equals(object other);
            /*0x1b23884*/ int GetHashCode();
            /*0x1b238a4*/ bool CanResetValue(object component);
            /*0x1b23a0c*/ object GetValue(object component);
            /*0x1b23aa0*/ void ResetValue(object component);
            /*0x1b23c08*/ void SetValue(object component, object value);
            /*0x1b23cf4*/ bool ShouldSerializeValue(object component);
        }

        class DataError
        {
            /*0x10*/ string _rowError;
            /*0x18*/ int _count;
            /*0x20*/ System.Data.DataError.ColumnError[] _errorList;

            /*0x1b23e24*/ DataError();
            /*0x1b23e80*/ DataError(string rowError);
            /*0x1b23f84*/ string get_Text();
            /*0x1b23f8c*/ void set_Text(string value);
            /*0x1b23ff0*/ bool get_HasErrors();
            /*0x1b24024*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x1b24358*/ string GetColumnError(System.Data.DataColumn column);
            /*0x1b24130*/ void Clear(System.Data.DataColumn column);
            /*0x1b24408*/ void Clear();
            /*0x1b244c0*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x1b23f20*/ void SetText(string errorText);
            /*0x1b241fc*/ int IndexOf(System.Data.DataColumn column);

            struct ColumnError
            {
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ string _error;
            }
        }

        class DataException : System.SystemException
        {
            /*0x1b245b4*/ DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b245fc*/ DataException();
            /*0x1b2465c*/ DataException(string s);
            /*0x1b2468c*/ DataException(string s, System.Exception innerException);
        }

        class ConstraintException : System.Data.DataException
        {
            /*0x21ca3ac*/ ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x21ca3f4*/ ConstraintException();
            /*0x21ca454*/ ConstraintException(string s);
        }

        class DeletedRowInaccessibleException : System.Data.DataException
        {
            /*0x2025124*/ DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x202516c*/ DeletedRowInaccessibleException();
            /*0x20251cc*/ DeletedRowInaccessibleException(string s);
        }

        class DuplicateNameException : System.Data.DataException
        {
            /*0x2026478*/ DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x20264c0*/ DuplicateNameException();
            /*0x2026520*/ DuplicateNameException(string s);
        }

        class InRowChangingEventException : System.Data.DataException
        {
            /*0x20f9c24*/ InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x20f9c6c*/ InRowChangingEventException();
            /*0x20f9ccc*/ InRowChangingEventException(string s);
        }

        class InvalidConstraintException : System.Data.DataException
        {
            /*0x2101044*/ InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x210108c*/ InvalidConstraintException();
            /*0x21010ec*/ InvalidConstraintException(string s);
        }

        class NoNullAllowedException : System.Data.DataException
        {
            /*0x2107b0c*/ NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x2107b54*/ NoNullAllowedException();
            /*0x2107bb4*/ NoNullAllowedException(string s);
        }

        class ReadOnlyException : System.Data.DataException
        {
            /*0x210cb60*/ ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x210cba8*/ ReadOnlyException();
            /*0x210cc08*/ ReadOnlyException(string s);
        }

        class RowNotInTableException : System.Data.DataException
        {
            /*0x1ed23f0*/ RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1ed2438*/ RowNotInTableException();
            /*0x1ed2498*/ RowNotInTableException(string s);
        }

        class VersionNotFoundException : System.Data.DataException
        {
            /*0x1db0738*/ VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1db0780*/ VersionNotFoundException();
            /*0x1db07e0*/ VersionNotFoundException(string s);
        }

        class ExceptionBuilder
        {
            static /*0x20265a8*/ void TraceException(string trace, System.Exception e);
            static /*0x2026658*/ System.Exception TraceExceptionAsReturnValue(System.Exception e);
            static /*0x20266ac*/ System.Exception TraceExceptionForCapture(System.Exception e);
            static /*0x201ef24*/ System.Exception TraceExceptionWithoutRethrow(System.Exception e);
            static /*0x2026700*/ System.Exception _Argument(string error);
            static /*0x2026760*/ System.Exception _Argument(string error, System.Exception innerException);
            static /*0x20267d0*/ System.Exception _ArgumentNull(string paramName, string msg);
            static /*0x2026840*/ System.Exception _ArgumentOutOfRange(string paramName, string msg);
            static /*0x20268b0*/ System.Exception _IndexOutOfRange(string error);
            static /*0x2026910*/ System.Exception _InvalidOperation(string error);
            static /*0x2026970*/ System.Exception _InvalidEnumArgumentException(string error);
            static System.Exception _InvalidEnumArgumentException<T>(T value);
            static /*0x20269d0*/ void ThrowDataException(string error, System.Exception innerException);
            static /*0x2026a2c*/ System.Exception _Data(string error);
            static /*0x2026a8c*/ System.Exception _Constraint(string error);
            static /*0x2026aec*/ System.Exception _InvalidConstraint(string error);
            static /*0x2026b4c*/ System.Exception _DeletedRowInaccessible(string error);
            static /*0x2026bb8*/ System.Exception _DuplicateName(string error);
            static /*0x2026c24*/ System.Exception _InRowChangingEvent(string error);
            static /*0x2026c84*/ System.Exception _NoNullAllowed(string error);
            static /*0x2026ce4*/ System.Exception _ReadOnly(string error);
            static /*0x2026d44*/ System.Exception _RowNotInTable(string error);
            static /*0x2026da4*/ System.Exception _VersionNotFound(string error);
            static /*0x2019a38*/ System.Exception ArgumentNull(string paramName);
            static /*0x2026e04*/ System.Exception ArgumentOutOfRange(string paramName);
            static /*0x2026e60*/ System.Exception BadObjectPropertyAccess(string error);
            static /*0x201988c*/ System.Exception CaseInsensitiveNameConflict(string name);
            static /*0x20198e0*/ System.Exception NamespaceNameConflict(string name);
            static /*0x2026eb4*/ System.Exception InvalidOffsetLength();
            static /*0x2026ef8*/ System.Exception ColumnNotInTheTable(string column, string table);
            static /*0x2026f5c*/ System.Exception ColumnNotInAnyTable();
            static /*0x2026fa0*/ System.Exception ColumnOutOfRange(int index);
            static /*0x2027040*/ System.Exception ColumnOutOfRange(string column);
            static /*0x2027094*/ System.Exception CannotAddColumn1(string column);
            static /*0x20270e8*/ System.Exception CannotAddColumn2(string column);
            static /*0x202713c*/ System.Exception CannotAddColumn3();
            static /*0x2027180*/ System.Exception CannotAddColumn4(string column);
            static /*0x20271d4*/ System.Exception CannotAddDuplicate(string column);
            static /*0x2027228*/ System.Exception CannotAddDuplicate2(string table);
            static /*0x202727c*/ System.Exception CannotAddDuplicate3(string table);
            static /*0x20272d0*/ System.Exception CannotRemoveColumn();
            static /*0x2027314*/ System.Exception CannotRemovePrimaryKey();
            static /*0x2027358*/ System.Exception CannotRemoveChildKey(string relation);
            static /*0x20273ac*/ System.Exception CannotRemoveConstraint(string constraint, string table);
            static /*0x2027410*/ System.Exception CannotRemoveExpression(string column, string expression);
            static /*0x2027474*/ System.Exception AddPrimaryKeyConstraint();
            static /*0x20274b8*/ System.Exception NoConstraintName();
            static /*0x20274fc*/ System.Exception ConstraintViolation(string constraint);
            static /*0x2027550*/ string KeysToString(object[] keys);
            static /*0x2027694*/ string UniqueConstraintViolationText(System.Data.DataColumn[] columns, object[] values);
            static /*0x2027820*/ System.Exception ConstraintViolation(System.Data.DataColumn[] columns, object[] values);
            static /*0x2027834*/ System.Exception ConstraintOutOfRange(int index);
            static /*0x20278d4*/ System.Exception DuplicateConstraint(string constraint);
            static /*0x2027928*/ System.Exception DuplicateConstraintName(string constraint);
            static /*0x202797c*/ System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk);
            static /*0x2027a14*/ System.Exception UniqueConstraintViolation();
            static /*0x2027a58*/ System.Exception ConstraintForeignTable();
            static /*0x2027a9c*/ System.Exception ConstraintParentValues();
            static /*0x2027ae0*/ System.Exception ConstraintAddFailed(System.Data.DataTable table);
            static /*0x2027b3c*/ System.Exception ConstraintRemoveFailed();
            static /*0x2027b80*/ System.Exception FailedCascadeDelete(string constraint);
            static /*0x2027bd4*/ System.Exception FailedCascadeUpdate(string constraint);
            static /*0x2027c28*/ System.Exception FailedClearParentTable(string table, string constraint, string childTable);
            static /*0x2027c94*/ System.Exception ForeignKeyViolation(string constraint, object[] keys);
            static /*0x2027d04*/ System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint);
            static /*0x2027d74*/ string MaxLengthViolationText(string columnName);
            static /*0x2027dc4*/ string NotAllowDBNullViolationText(string columnName);
            static /*0x2027e14*/ System.Exception CantAddConstraintToMultipleNestedTable(string tableName);
            static /*0x2027e68*/ System.Exception AutoIncrementAndExpression();
            static /*0x2027eac*/ System.Exception AutoIncrementAndDefaultValue();
            static /*0x2027ef0*/ System.Exception AutoIncrementSeed();
            static /*0x2027f34*/ System.Exception CantChangeDataType();
            static /*0x2027f78*/ System.Exception NullDataType();
            static /*0x2027fbc*/ System.Exception ColumnNameRequired();
            static /*0x2028000*/ System.Exception DefaultValueAndAutoIncrement();
            static /*0x2028044*/ System.Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x2028130*/ System.Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x20281e8*/ System.Exception ExpressionAndUnique();
            static /*0x202822c*/ System.Exception ExpressionAndReadOnly();
            static /*0x2028270*/ System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint);
            static /*0x20282f8*/ System.Exception ExpressionInConstraint(System.Data.DataColumn column);
            static /*0x2028354*/ System.Exception ExpressionCircular();
            static /*0x2028398*/ System.Exception NonUniqueValues(string column);
            static /*0x20283ec*/ System.Exception NullKeyValues(string column);
            static /*0x2028440*/ System.Exception NullValues(string column);
            static /*0x2028494*/ System.Exception ReadOnlyAndExpression();
            static /*0x20284d8*/ System.Exception ReadOnly(string column);
            static /*0x202852c*/ System.Exception UniqueAndExpression();
            static /*0x2028570*/ System.Exception SetFailed(object value, System.Data.DataColumn column, System.Type type, System.Exception innerException);
            static /*0x2028650*/ System.Exception CannotSetToNull(System.Data.DataColumn column);
            static /*0x20286ac*/ System.Exception LongerThanMaxLength(System.Data.DataColumn column);
            static /*0x2028708*/ System.Exception CannotSetMaxLength(System.Data.DataColumn column, int value);
            static /*0x20287c4*/ System.Exception CannotSetMaxLength2(System.Data.DataColumn column);
            static /*0x2028820*/ System.Exception CannotSetSimpleContentType(string columnName, System.Type type);
            static /*0x2028884*/ System.Exception CannotSetSimpleContent(string columnName, System.Type type);
            static /*0x20288e8*/ System.Exception CannotChangeNamespace(string columnName);
            static /*0x202893c*/ System.Exception HasToBeStringType(System.Data.DataColumn column);
            static /*0x2028998*/ System.Exception AutoIncrementCannotSetIfHasData(string typeName);
            static /*0x20289ec*/ System.Exception INullableUDTwithoutStaticNull(string typeName);
            static /*0x2028a40*/ System.Exception IComparableNotImplemented(string typeName);
            static /*0x2028a94*/ System.Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName);
            static /*0x2028ae8*/ System.Exception InvalidDataColumnMapping(System.Type type);
            static /*0x2028b5c*/ System.Exception CannotSetDateTimeModeForNonDateTimeColumns();
            static /*0x2022f88*/ System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode);
            static /*0x2028ba0*/ System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue);
            static /*0x2028c84*/ System.Exception ColumnTypeNotSupported();
            static /*0x2028cf8*/ System.Exception SetFailed(string name);
            static /*0x201f1f0*/ System.Exception CanNotUse();
            static /*0x201d16c*/ System.Exception SetIListObject();
            static /*0x201d5c0*/ System.Exception AddNewNotAllowNull();
            static /*0x201d6d8*/ System.Exception NotOpen();
            static /*0x2028d4c*/ System.Exception CreateChildView();
            static /*0x201de74*/ System.Exception CanNotDelete();
            static /*0x201e54c*/ System.Exception GetElementIndex(int index);
            static /*0x201dfdc*/ System.Exception AddExternalObject();
            static /*0x201e04c*/ System.Exception CanNotClear();
            static /*0x201e23c*/ System.Exception InsertExternalObject();
            static /*0x201e3b0*/ System.Exception RemoveExternalObject();
            static /*0x2028d90*/ System.Exception KeyTableMismatch();
            static /*0x2028dd4*/ System.Exception KeyNoColumns();
            static /*0x2028e18*/ System.Exception KeyTooManyColumns(int cols);
            static /*0x2028eb8*/ System.Exception KeyDuplicateColumns(string columnName);
            static /*0x2028f0c*/ System.Exception RelationDataSetMismatch();
            static /*0x2028f50*/ System.Exception ColumnsTypeMismatch();
            static /*0x2028f94*/ System.Exception KeyLengthMismatch();
            static /*0x2028fd8*/ System.Exception KeyLengthZero();
            static /*0x202901c*/ System.Exception ForeignRelation();
            static /*0x2029060*/ System.Exception KeyColumnsIdentical();
            static /*0x20290a4*/ System.Exception RelationForeignTable(string t1, string t2);
            static /*0x2029108*/ System.Exception GetParentRowTableMismatch(string t1, string t2);
            static /*0x202916c*/ System.Exception SetParentRowTableMismatch(string t1, string t2);
            static /*0x20291d0*/ System.Exception RelationForeignRow();
            static /*0x2029214*/ System.Exception RelationNestedReadOnly();
            static /*0x2029258*/ System.Exception TableCantBeNestedInTwoTables(string tableName);
            static /*0x20292ac*/ System.Exception LoopInNestedRelations(string tableName);
            static /*0x2029300*/ System.Exception RelationDoesNotExist();
            static /*0x2029344*/ System.Exception ParentOrChildColumnsDoNotHaveDataSet();
            static /*0x2029388*/ System.Exception InValidNestedRelation(string childTableName);
            static /*0x20293dc*/ System.Exception InvalidParentNamespaceinNestedRelation(string childTableName);
            static /*0x2029430*/ System.Exception RowNotInTheDataSet();
            static /*0x2029474*/ System.Exception RowNotInTheTable();
            static /*0x20294b8*/ System.Exception EditInRowChanging();
            static /*0x20294fc*/ System.Exception EndEditInRowChanging();
            static /*0x2029540*/ System.Exception BeginEditInRowChanging();
            static /*0x2029584*/ System.Exception CancelEditInRowChanging();
            static /*0x20295c8*/ System.Exception DeleteInRowDeleting();
            static /*0x202960c*/ System.Exception ValueArrayLength();
            static /*0x2029650*/ System.Exception NoCurrentData();
            static /*0x2029694*/ System.Exception NoOriginalData();
            static /*0x20296d8*/ System.Exception NoProposedData();
            static /*0x202971c*/ System.Exception RowRemovedFromTheTable();
            static /*0x2029760*/ System.Exception DeletedRowInaccessible();
            static /*0x20297a4*/ System.Exception RowAlreadyDeleted();
            static /*0x20297e8*/ System.Exception RowEmpty();
            static /*0x202982c*/ System.Exception InvalidRowVersion();
            static /*0x201e4ac*/ System.Exception RowOutOfRange(int index);
            static /*0x2029870*/ System.Exception RowInsertTwice(int index, string tableName);
            static /*0x2029920*/ System.Exception RowInsertMissing(string tableName);
            static /*0x2029974*/ System.Exception RowAlreadyRemoved();
            static /*0x20299b8*/ System.Exception MultipleParents();
            static /*0x20299fc*/ System.Exception InvalidRowState(System.Data.DataRowState state);
            static /*0x2029a48*/ System.Exception InvalidRowBitPattern();
            static /*0x2029a8c*/ System.Exception SetDataSetNameToEmpty();
            static /*0x2029ad0*/ System.Exception SetDataSetNameConflicting(string name);
            static /*0x2029b24*/ System.Exception DataSetUnsupportedSchema(string ns);
            static /*0x2029b78*/ System.Exception MergeMissingDefinition(string obj);
            static /*0x2029bcc*/ System.Exception TablesInDifferentSets();
            static /*0x2029c10*/ System.Exception RelationAlreadyExists();
            static /*0x2029c54*/ System.Exception RowAlreadyInOtherCollection();
            static /*0x2029c98*/ System.Exception RowAlreadyInTheCollection();
            static /*0x2029cdc*/ System.Exception RecordStateRange();
            static /*0x2029d20*/ System.Exception IndexKeyLength(int length, int keyLength);
            static /*0x2029e18*/ System.Exception RemovePrimaryKey(System.Data.DataTable table);
            static /*0x2029e9c*/ System.Exception RelationAlreadyInOtherDataSet();
            static /*0x2029ee0*/ System.Exception RelationAlreadyInTheDataSet();
            static /*0x2029f24*/ System.Exception RelationNotInTheDataSet(string relation);
            static /*0x2029f78*/ System.Exception RelationOutOfRange(object index);
            static /*0x202a00c*/ System.Exception DuplicateRelation(string relation);
            static /*0x202a060*/ System.Exception RelationTableNull();
            static /*0x202a0a4*/ System.Exception RelationDataSetNull();
            static /*0x202a0e8*/ System.Exception RelationTableWasRemoved();
            static /*0x202a12c*/ System.Exception ParentTableMismatch();
            static /*0x202a170*/ System.Exception ChildTableMismatch();
            static /*0x202a1b4*/ System.Exception EnforceConstraint();
            static /*0x202a1f8*/ System.Exception CaseLocaleMismatch();
            static /*0x202a23c*/ System.Exception CannotChangeCaseLocale();
            static /*0x202a244*/ System.Exception CannotChangeCaseLocale(System.Exception innerException);
            static /*0x202a290*/ System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode);
            static /*0x202a2dc*/ System.Exception TableForeignPrimaryKey();
            static /*0x202a320*/ System.Exception TableCannotAddToSimpleContent();
            static /*0x202a364*/ System.Exception NoTableName();
            static /*0x202a3a8*/ System.Exception MultipleTextOnlyColumns();
            static /*0x202a3ec*/ System.Exception InvalidSortString(string sort);
            static /*0x201b8b4*/ System.Exception DuplicateTableName(string table);
            static /*0x202a440*/ System.Exception DuplicateTableName2(string table, string ns);
            static /*0x202a4a4*/ System.Exception SelfnestedDatasetConflictingName(string table);
            static /*0x201a5dc*/ System.Exception DatasetConflictingName(string table);
            static /*0x201a598*/ System.Exception TableAlreadyInOtherDataSet();
            static /*0x201a554*/ System.Exception TableAlreadyInTheDataSet();
            static /*0x2019510*/ System.Exception TableOutOfRange(int index);
            static /*0x201b040*/ System.Exception TableNotInTheDataSet(string table);
            static /*0x201b094*/ System.Exception TableInRelation();
            static /*0x201b0d8*/ System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint);
            static /*0x202a4f8*/ System.Exception CanNotSerializeDataTableHierarchy();
            static /*0x202a53c*/ System.Exception CanNotRemoteDataTable();
            static /*0x202a580*/ System.Exception CanNotSetRemotingFormat();
            static /*0x202a5c4*/ System.Exception CanNotSerializeDataTableWithEmptyName();
            static /*0x202a608*/ System.Exception TableNotFound(string tableName);
            static /*0x2021318*/ System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type);
            static /*0x202a65c*/ System.Exception InvalidStorageType(System.TypeCode typecode);
            static /*0x202a708*/ System.Exception RangeArgument(int min, int max);
            static /*0x202a7cc*/ System.Exception NullRange();
            static /*0x202a810*/ System.Exception NegativeMinimumCapacity();
            static /*0x202a854*/ System.Exception ProblematicChars(char charValue);
            static /*0x202a940*/ System.Exception StorageSetFailed();
            static /*0x202a984*/ System.Exception SimpleTypeNotSupported();
            static /*0x202a9c8*/ System.Exception MissingAttribute(string attribute);
            static /*0x202aa1c*/ System.Exception MissingAttribute(string element, string attribute);
            static /*0x202aa80*/ System.Exception InvalidAttributeValue(string name, string value);
            static /*0x202aae4*/ System.Exception AttributeValues(string name, string value1, string value2);
            static /*0x202ab50*/ System.Exception ElementTypeNotFound(string name);
            static /*0x202aba4*/ System.Exception RelationParentNameMissing(string rel);
            static /*0x202abf8*/ System.Exception RelationChildNameMissing(string rel);
            static /*0x202ac4c*/ System.Exception RelationTableKeyMissing(string rel);
            static /*0x202aca0*/ System.Exception RelationChildKeyMissing(string rel);
            static /*0x202acf4*/ System.Exception UndefinedDatatype(string name);
            static /*0x202ad48*/ System.Exception DatatypeNotDefined();
            static /*0x202ad8c*/ System.Exception MismatchKeyLength();
            static /*0x202add0*/ System.Exception InvalidField(string name);
            static /*0x202ae24*/ System.Exception InvalidSelector(string name);
            static /*0x202ae78*/ System.Exception CircularComplexType(string name);
            static /*0x202aecc*/ System.Exception CannotInstantiateAbstract(string name);
            static /*0x202af20*/ System.Exception InvalidKey(string name);
            static /*0x202af74*/ System.Exception DiffgramMissingTable(string name);
            static /*0x202afc8*/ System.Exception DiffgramMissingSQL();
            static /*0x202b00c*/ System.Exception DuplicateConstraintRead(string str);
            static /*0x202b060*/ System.Exception ColumnTypeConflict(string name);
            static /*0x202b0b4*/ System.Exception CannotConvert(string name, string type);
            static /*0x202b118*/ System.Exception MissingRefer(string name);
            static /*0x202b19c*/ System.Exception InvalidPrefix(string name);
            static /*0x202b1f0*/ System.Exception CanNotDeserializeObjectType();
            static /*0x202b234*/ System.Exception IsDataSetAttributeMissingInSchema();
            static /*0x202b278*/ System.Exception TooManyIsDataSetAtributeInSchema();
            static /*0x202b2bc*/ System.Exception NestedCircular(string name);
            static /*0x202b310*/ System.Exception MultipleParentRows(string tableQName);
            static /*0x202b364*/ System.Exception PolymorphismNotSupported(string typeName);
            static /*0x202b3b8*/ System.Exception DataTableInferenceNotSupported();
            static /*0x202b3fc*/ void ThrowMultipleTargetConverter(System.Exception innerException);
            static /*0x202b45c*/ System.Exception DuplicateDeclaration(string name);
            static /*0x202b4b0*/ System.Exception FoundEntity();
            static /*0x202b4f4*/ System.Exception MergeFailed(string name);
            static /*0x202b4f8*/ System.Exception ConvertFailed(System.Type type1, System.Type type2);
            static /*0x202b598*/ System.Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr);
            static /*0x202b5fc*/ System.Exception InternalRBTreeError(System.Data.RBTreeError internalError);
            static /*0x202b684*/ System.Exception EnumeratorModified();
        }

        struct DataKey
        {
            /*0x10*/ System.Data.DataColumn[] _columns;

            static /*0x1b253c0*/ bool ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2);
            /*0xad1684*/ DataKey(System.Data.DataColumn[] columns, bool copyColumns);
            /*0xad1690*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0xad1698*/ bool get_HasValue();
            /*0xad16a8*/ System.Data.DataTable get_Table();
            /*0xad16b0*/ void CheckState();
            /*0xad16b8*/ bool ColumnsEqual(System.Data.DataKey key);
            /*0xad16c0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0xad16c8*/ int GetHashCode();
            /*0xad16d0*/ bool Equals(object value);
            /*0xad16d8*/ bool Equals(System.Data.DataKey value);
            /*0xad16e0*/ string[] GetColumnNames();
            /*0xad16e8*/ System.Data.IndexField[] GetIndexDesc();
            /*0xad16f0*/ object[] GetKeyValues(int record);
            /*0xad16f8*/ System.Data.Index GetSortIndex();
            /*0xad1704*/ System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates);
            /*0xad170c*/ bool RecordsEqual(int record1, int record2);
            /*0xad1714*/ System.Data.DataColumn[] ToArray();
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

            static /*0x1b2646c*/ bool IsKeyNull(object[] values);
            static /*0x1b2653c*/ System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version);
            static /*0x1b2660c*/ System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            static /*0x1b266ac*/ System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            /*0x1b25b4c*/ DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints);
            /*0x1b26034*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x1b2603c*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x1b26100*/ DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x1b261d4*/ DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x1b262bc*/ System.Data.DataColumn[] get_ChildColumns();
            /*0x1b263f0*/ System.Data.DataColumn[] get_ChildColumnsReference();
            /*0x1b22ccc*/ System.Data.DataKey get_ChildKey();
            /*0x1b26414*/ System.Data.DataTable get_ChildTable();
            /*0x1b26438*/ System.Data.DataSet get_DataSet();
            /*0x1b2645c*/ string[] get_ParentColumnNames();
            /*0x1b26464*/ string[] get_ChildColumnNames();
            /*0x1b26898*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x1b268ac*/ System.Data.DataColumn[] get_ParentColumns();
            /*0x1b268d0*/ System.Data.DataColumn[] get_ParentColumnsReference();
            /*0x1b22cf0*/ System.Data.DataKey get_ParentKey();
            /*0x1b268d8*/ System.Data.DataTable get_ParentTable();
            /*0x1b268fc*/ string get_RelationName();
            /*0x1b26920*/ void CheckNamespaceValidityForNestedRelations(string ns);
            /*0x1b26c90*/ void CheckNestedRelations();
            /*0x1b27034*/ bool get_Nested();
            /*0x1b27058*/ void set_Nested(bool value);
            /*0x1b28604*/ System.Data.UniqueConstraint get_ParentKeyConstraint();
            /*0x1b28628*/ void SetParentKeyConstraint(System.Data.UniqueConstraint value);
            /*0x1b28630*/ System.Data.ForeignKeyConstraint get_ChildKeyConstraint();
            /*0x1b28654*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x1b286bc*/ bool get_CheckMultipleNested();
            /*0x1b286c4*/ void set_CheckMultipleNested(bool value);
            /*0x1b286d0*/ void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value);
            /*0x1b286d8*/ void CheckState();
            /*0x1b262e0*/ void CheckStateForProperty();
            /*0x1b25d58*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x1b2891c*/ System.Data.DataRelation Clone(System.Data.DataSet destination);
            /*0x1b28f44*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x1b284b4*/ void RaisePropertyChanging(string name);
            /*0x1b29024*/ string ToString();
            /*0x1b28024*/ void ValidateMultipleNestedRelations();
            /*0x1b29030*/ bool IsAutoGenerated(System.Data.DataColumn col);
            /*0x1b29218*/ int get_ObjectID();
        }

        class DataRelationCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataRelation _inTransition;
            /*0x18*/ int _defaultNameIndex;
            /*0x20*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x30*/ int _objectID;

            /*0x1b2a6d8*/ DataRelationCollection();
            /*0x1b29220*/ int get_ObjectID();
            System.Data.DataRelation get_Item(int index);
            System.Data.DataRelation get_Item(string name);
            /*0x1b29228*/ void Add(System.Data.DataRelation relation);
            /*0x1b29484*/ void AddCore(System.Data.DataRelation relation);
            /*0x1b29738*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b2982c*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x1b29920*/ string AssignName();
            /*0x1b29a1c*/ void Clear();
            /*0x1b29c54*/ bool Contains(string name);
            /*0x1b29c70*/ int InternalIndexOf(string name);
            System.Data.DataSet GetDataSet();
            /*0x1b29950*/ string MakeName(int index);
            /*0x1b29df4*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x1b29ed4*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x1b29fb4*/ void RegisterName(string name);
            /*0x1b2a18c*/ void Remove(System.Data.DataRelation relation);
            /*0x1b2a32c*/ void RemoveAt(int index);
            /*0x1b2a3ac*/ void RemoveCore(System.Data.DataRelation relation);
            /*0x1b2a5a0*/ void UnregisterName(string name);

            class DataTableRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataTable _table;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ bool _fParentCollection;
                /*0x50*/ System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;

                /*0x2ae4f14*/ DataTableRelationCollection(System.Data.DataTable table, bool fParentCollection);
                /*0x2ae4fc0*/ System.Collections.ArrayList get_List();
                /*0x2ae4fc8*/ void EnsureDataSet();
                /*0x2ae5018*/ System.Data.DataSet GetDataSet();
                /*0x2ae5048*/ System.Data.DataRelation get_Item(int index);
                /*0x2ae514c*/ System.Data.DataRelation get_Item(string name);
                /*0x2ae5248*/ void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x2ae52e8*/ void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x2ae5388*/ void AddCache(System.Data.DataRelation relation);
                /*0x2ae53e0*/ void AddCore(System.Data.DataRelation relation);
                /*0x2ae54a8*/ void RemoveCache(System.Data.DataRelation relation);
                /*0x2ae558c*/ void RemoveCore(System.Data.DataRelation relation);
            }

            class DataSetRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataSet _dataSet;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ System.Data.DataRelation[] _delayLoadingRelations;

                /*0x2ae4430*/ DataSetRelationCollection(System.Data.DataSet dataSet);
                /*0x2ae44d0*/ System.Collections.ArrayList get_List();
                /*0x2ae44d8*/ void Clear();
                /*0x2ae451c*/ System.Data.DataSet GetDataSet();
                /*0x2ae4524*/ System.Data.DataRelation get_Item(int index);
                /*0x2ae4628*/ System.Data.DataRelation get_Item(string name);
                /*0x2ae4724*/ void AddCore(System.Data.DataRelation relation);
                /*0x2ae4cc8*/ void RemoveCore(System.Data.DataRelation relation);
            }
        }

        class DataRelationPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataRelation <Relation>k__BackingField;

            /*0x1b2a76c*/ DataRelationPropertyDescriptor(System.Data.DataRelation dataRelation);
            /*0x1b2a7bc*/ System.Data.DataRelation get_Relation();
            /*0x1b2a7c4*/ System.Type get_ComponentType();
            /*0x1b2a83c*/ bool get_IsReadOnly();
            /*0x1b2a844*/ System.Type get_PropertyType();
            /*0x1b2a8bc*/ bool Equals(object other);
            /*0x1b2a938*/ int GetHashCode();
            /*0x1b2a958*/ bool CanResetValue(object component);
            /*0x1b2a960*/ object GetValue(object component);
            /*0x1b2aa00*/ void ResetValue(object component);
            /*0x1b2aa04*/ void SetValue(object component, object value);
            /*0x1b2aa08*/ bool ShouldSerializeValue(object component);
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

            /*0x1b2aa10*/ DataRow(System.Data.DataRowBuilder builder);
            /*0x1b2aab4*/ System.Data.DataColumn get_LastChangedColumn();
            /*0x1b2aad0*/ void set_LastChangedColumn(System.Data.DataColumn value);
            /*0x1b2aae4*/ bool get_HasPropertyChanged();
            /*0x1b2aaf4*/ int get_RBTreeNodeId();
            /*0x1b2aafc*/ void set_RBTreeNodeId(int value);
            /*0x1b2abb8*/ string get_RowError();
            /*0x1b2ac18*/ void set_RowError(string value);
            /*0x1b2ad84*/ void RowErrorChanged();
            /*0x1b2ade4*/ long get_rowID();
            /*0x1b2adec*/ void set_rowID(long value);
            /*0x1b2ae08*/ System.Data.DataRowState get_RowState();
            /*0x1b2b04c*/ System.Data.DataTable get_Table();
            /*0x1b28524*/ void CheckForLoops(System.Data.DataRelation rel);
            /*0x1b2b054*/ int GetNestedParentCount();
            /*0x1b2b128*/ void set_Item(string columnName, object value);
            /*0x1b2b00c*/ object get_Item(System.Data.DataColumn column);
            /*0x1b2b1c4*/ void set_Item(System.Data.DataColumn column, object value);
            /*0x1b2b83c*/ object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version);
            /*0x1b2b8f4*/ void set_ItemArray(object[] value);
            /*0x1b2bcd0*/ void AcceptChanges();
            /*0x1b2c04c*/ void BeginEdit();
            /*0x1b2b5e0*/ bool BeginEditInternal();
            /*0x1b2b6ec*/ void CancelEdit();
            /*0x1b2b4e8*/ void CheckColumn(System.Data.DataColumn column);
            /*0x1b2c050*/ void CheckInTable();
            /*0x1b2c090*/ void Delete();
            /*0x1b2b754*/ void EndEdit();
            /*0x1b2c100*/ void SetColumnError(int columnIndex, string error);
            /*0x1b2c170*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x1b2c34c*/ string GetColumnError(System.Data.DataColumn column);
            /*0x1b2c3d4*/ void ClearErrors();
            /*0x1b22c2c*/ void ClearError(System.Data.DataColumn column);
            /*0x1b2c40c*/ bool get_HasErrors();
            /*0x1b2c450*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x1b2c52c*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation);
            /*0x1b2c534*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x1b2b158*/ System.Data.DataColumn GetDataColumn(string columnName);
            /*0x1b285fc*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation);
            /*0x1b2c65c*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x1b2c774*/ System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version);
            /*0x1b2c83c*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation);
            /*0x1b2c844*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x1b2c96c*/ object[] GetColumnValues(System.Data.DataColumn[] columns);
            /*0x1b2c974*/ object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version);
            /*0x1b2c9cc*/ object[] GetKeyValues(System.Data.DataKey key);
            /*0x1b265dc*/ object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version);
            /*0x1b2c9f8*/ int GetCurrentRecordNo();
            /*0x1b2b578*/ int GetDefaultRecord();
            /*0x1b2ca38*/ int GetOriginalRecordNo();
            /*0x1b2b6ac*/ int GetProposedRecordNo();
            /*0x1b2b88c*/ int GetRecordFromVersion(System.Data.DataRowVersion version);
            /*0x1b2ca78*/ System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState);
            /*0x1b2cab4*/ System.Data.DataViewRowState GetRecordState(int record);
            /*0x1b2cb10*/ bool HasKeyChanged(System.Data.DataKey key);
            /*0x1b2cb1c*/ bool HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x1b26808*/ bool HasVersion(System.Data.DataRowVersion version);
            /*0x1b2cba4*/ bool HaveValuesChanged(System.Data.DataColumn[] columns);
            /*0x1b2cbb0*/ bool HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x1b2cc6c*/ void RejectChanges();
            /*0x1b2adfc*/ void ResetLastChangedColumn();
            /*0x1b2d284*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues);
            /*0x1b2d3a8*/ void SetNestedParentRow(System.Data.DataRow parentRow, bool setNonNested);
            /*0x1b2d75c*/ void SetParentRowToDBNull();
            /*0x1b2da04*/ void SetParentRowToDBNull(System.Data.DataRelation relation);
            /*0x1b2db90*/ int CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, int storeIndex);
        }

        class DataRowBuilder
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _record;

            /*0x1b2de90*/ DataRowBuilder(System.Data.DataTable table, int record);
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

            /*0x1b2decc*/ DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action);
        }

        class DataRowChangeEventHandler : System.MulticastDelegate
        {
            /*0x1b2df4c*/ DataRowChangeEventHandler(object object, nint method);
            /*0x1b2dfac*/ void Invoke(object sender, System.Data.DataRowChangeEventArgs e);
            /*0x1b2e340*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataRowChangeEventArgs e, System.AsyncCallback callback, object object);
            /*0x1b2e370*/ void EndInvoke(System.IAsyncResult result);
        }

        class DataRowCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataRowCollection.DataRowTree _list;
            /*0x20*/ int _nullInList;

            /*0x1b2e37c*/ DataRowCollection(System.Data.DataTable table);
            /*0x1b2e420*/ int get_Count();
            /*0x1b22bc8*/ System.Data.DataRow get_Item(int index);
            /*0x1b2e474*/ void Add(System.Data.DataRow row);
            /*0x1b2e494*/ void DiffInsertAt(System.Data.DataRow row, int pos);
            /*0x1b2e6b4*/ int IndexOf(System.Data.DataRow row);
            /*0x1b2e75c*/ System.Data.DataRow AddWithColumnEvents(object[] values);
            /*0x1b2e7c8*/ void ArrayAdd(System.Data.DataRow row);
            /*0x1b2e83c*/ void ArrayInsert(System.Data.DataRow row, int pos);
            /*0x1b2e8b8*/ void ArrayClear();
            /*0x1b2e90c*/ void ArrayRemove(System.Data.DataRow row);
            /*0x1b2e9ac*/ void CopyTo(System.Array ar, int index);
            /*0x1b2ea18*/ void CopyTo(System.Data.DataRow[] array, int index);
            /*0x1b2ea84*/ System.Collections.IEnumerator GetEnumerator();

            class DataRowTree : System.Data.RBTree<System.Data.DataRow>
            {
                /*0x2ae5654*/ DataRowTree();
                /*0x2ae56a4*/ int CompareNode(System.Data.DataRow record1, System.Data.DataRow record2);
                /*0x2ae56d8*/ int CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2);
            }
        }

        class DataRowCreatedEventHandler : System.MulticastDelegate
        {
            /*0x1b2ead8*/ DataRowCreatedEventHandler(object object, nint method);
            /*0x1b2eb38*/ void Invoke(object sender, System.Data.DataRow r);
            /*0x1b2eecc*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataRow r, System.AsyncCallback callback, object object);
            /*0x1b2eefc*/ void EndInvoke(System.IAsyncResult result);
        }

        class DataSetClearEventhandler : System.MulticastDelegate
        {
            /*0x1b99f80*/ DataSetClearEventhandler(object object, nint method);
            /*0x1b99fe0*/ void Invoke(object sender, System.Data.DataTable table);
            /*0x1b9a374*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataTable table, System.AsyncCallback callback, object object);
            /*0x1b9a3a4*/ void EndInvoke(System.IAsyncResult result);
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

            static /*0x1b2f5e4*/ DataRowView();
            /*0x1b2ef08*/ DataRowView(System.Data.DataView dataView, System.Data.DataRow row);
            /*0x1b2ef40*/ bool Equals(object other);
            /*0x1b2ef4c*/ int GetHashCode();
            /*0x1b2ef6c*/ System.Data.DataView get_DataView();
            /*0x1b2ef74*/ System.Data.DataRowVersion get_RowVersionDefault();
            /*0x1b2efd0*/ int GetRecord();
            /*0x1b2f000*/ bool HasRecord();
            /*0x1b239d4*/ object GetColumnValue(System.Data.DataColumn column);
            /*0x1b23b70*/ void SetColumnValue(System.Data.DataColumn column, object value);
            /*0x1b2f030*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent);
            /*0x1b2a9f8*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation);
            /*0x1b2f1dc*/ System.Data.DataRow get_Row();
            /*0x1b2f1e4*/ void EndEdit();
            /*0x1b2f23c*/ bool get_IsNew();
            /*0x1b2f264*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x1b2f304*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x1b2f3a4*/ void RaisePropertyChangedEvent(string propName);
            /*0x1b2f434*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
            /*0x1b2f490*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
            /*0x1b2f498*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
            /*0x1b2f540*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
            /*0x1b2f5e0*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
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

            static /*0x1b36ed0*/ void MoveToElement(System.Xml.XmlReader reader);
            static /*0x1b3b41c*/ System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x1b2f65c*/ DataSet();
            /*0x1b2f8c4*/ DataSet(string dataSetName);
            /*0x1b2fb04*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b2fb0c*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema);
            /*0x1b2fa44*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x1b2fa4c*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x1b2fafc*/ System.Data.SchemaSerializationMode get_SchemaSerializationMode();
            /*0x1b2fd74*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b303b0*/ void InitializeDerivedDataSet();
            /*0x1b2fd7c*/ void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x1b2fd20*/ void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x1b310a4*/ void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x1b315ac*/ void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x1b303b4*/ void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b3178c*/ void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b30528*/ void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b31a1c*/ void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b32ba0*/ void FailedEnableConstraints();
            /*0x1b32d44*/ bool get_CaseSensitive();
            /*0x1b32d4c*/ void set_CaseSensitive(bool value);
            /*0x1b3343c*/ bool get_EnforceConstraints();
            /*0x1b32bd8*/ void set_EnforceConstraints(bool value);
            /*0x1b33b94*/ void RestoreEnforceConstraints(bool value);
            /*0x1b33444*/ void EnableConstraints();
            /*0x1b33ba0*/ string get_DataSetName();
            /*0x1b2f8f0*/ void set_DataSetName(string value);
            /*0x1b33c24*/ string get_Namespace();
            /*0x1b33c2c*/ void set_Namespace(string value);
            /*0x1b3409c*/ string get_Prefix();
            /*0x1b340a4*/ void set_Prefix(string value);
            /*0x1b32b38*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x1b341e0*/ System.Globalization.CultureInfo get_Locale();
            /*0x1b341e8*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x1b3436c*/ void SetLocaleValue(System.Globalization.CultureInfo value, bool userSet);
            /*0x1b35334*/ bool ShouldSerializeLocale();
            /*0x1b3533c*/ System.ComponentModel.ISite get_Site();
            /*0x1b35344*/ System.Data.DataRelationCollection get_Relations();
            /*0x1b3534c*/ System.Data.DataTableCollection get_Tables();
            /*0x1b35354*/ void Clear();
            /*0x1b35564*/ System.Data.DataSet Clone();
            /*0x1b30d80*/ int EstimatedXmlStringSize();
            /*0x1b364b4*/ string GetRemotingDiffGram(System.Data.DataTable table);
            /*0x1b30bd4*/ string GetXmlSchemaForRemoting(System.Data.DataTable table);
            /*0x1b365f0*/ void ReadXmlSchema(System.Xml.XmlReader reader);
            /*0x1b32278*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x1b36a10*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x1b36ac8*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x1b36754*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x1b365f8*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x1b36f54*/ void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x1b3717c*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader);
            /*0x1b37184*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, bool denyResolving);
            /*0x1b36b6c*/ void InferSchema(System.Xml.XmlDocument xdoc, string[] excludedNamespaces, System.Data.XmlReadMode mode);
            /*0x1b39528*/ bool IsEmpty();
            /*0x1b38304*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x1b32b30*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode);
            /*0x1b39960*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x1b30ea0*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode);
            /*0x1b397f8*/ void Merge(System.Data.DataSet dataSet);
            /*0x1b3a7bc*/ void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x1b3aa58*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x1b3aa78*/ void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent);
            /*0x1b3aad4*/ void RaiseMergeFailed(System.Data.DataTable table, string conflict, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x1b3ab88*/ void OnDataRowCreated(System.Data.DataRow row);
            /*0x1b35544*/ void OnClearFunctionCalled(System.Data.DataTable table);
            /*0x1b3aba4*/ void OnRemoveTable(System.Data.DataTable table);
            /*0x1b3aba8*/ void OnRemovedTable(System.Data.DataTable table);
            /*0x1b3abd0*/ void OnRemoveRelation(System.Data.DataRelation relation);
            /*0x1b3abd4*/ void OnRemoveRelationHack(System.Data.DataRelation relation);
            /*0x1b33ba8*/ void RaisePropertyChanging(string name);
            /*0x1b3abe4*/ System.Data.DataTable[] TopLevelTables();
            /*0x1b3abec*/ System.Data.DataTable[] TopLevelTables(bool forSchema);
            /*0x1b3ae78*/ void Reset();
            /*0x1b33040*/ bool ValidateCaseConstraint();
            /*0x1b34ee0*/ bool ValidateLocaleConstraint();
            /*0x1b3b120*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x1b3b65c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x1b3b840*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x1b3baac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x1b3bae4*/ string get_MainTableName();
            /*0x1b3baec*/ void set_MainTableName(string value);
            /*0x1b3baf4*/ int get_ObjectID();
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

            static /*0x1bb3e2c*/ System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x1b9ca80*/ DataTable();
            /*0x1b9cfc0*/ DataTable(string tableName);
            /*0x1b9d030*/ DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b9d51c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1b9d608*/ void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x1b9d1e4*/ void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x1b9d8c4*/ void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x1b9eb98*/ void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x1ba1910*/ void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x1ba28bc*/ void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x1ba35b0*/ void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x1ba3720*/ void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x1b9e53c*/ void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x1b9fa28*/ void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x1ba3b94*/ System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, int bitIndex);
            /*0x1ba3898*/ void GetRowAndColumnErrors(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x1ba3c48*/ void ConvertToRowError(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x1ba3f30*/ bool get_CaseSensitive();
            /*0x1ba3f38*/ void set_CaseSensitive(bool value);
            /*0x1ba3fe0*/ bool get_AreIndexEventsSuspended();
            /*0x1ba3ff0*/ void RestoreIndexEvents(bool forceReset);
            /*0x1ba4400*/ void SuspendIndexEvents();
            /*0x1ba44b8*/ bool get_IsTypedDataTable();
            /*0x1ba2064*/ bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes);
            /*0x1ba458c*/ bool ShouldSerializeCaseSensitive();
            /*0x1ba4594*/ bool get_SelfNested();
            /*0x1ba4910*/ System.Collections.Generic.List<System.Data.Index> get_LiveIndexes();
            /*0x1ba49d8*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x1ba49e0*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x1ba4a4c*/ int get_UKColumnPositionForInference();
            /*0x1ba4a54*/ void set_UKColumnPositionForInference(int value);
            /*0x1ba4a5c*/ System.Data.DataRelationCollection get_ChildRelations();
            /*0x1ba4acc*/ System.Data.DataColumnCollection get_Columns();
            /*0x1ba4ad4*/ System.Globalization.CompareInfo get_CompareInfo();
            /*0x1ba4b14*/ System.Data.ConstraintCollection get_Constraints();
            /*0x1ba4b1c*/ void ResetConstraints();
            /*0x1ba4b38*/ System.Data.DataSet get_DataSet();
            /*0x1ba4b40*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x1ba4bf0*/ string get_DisplayExpressionInternal();
            /*0x1ba4c58*/ bool get_EnforceConstraints();
            /*0x1ba4c88*/ void set_EnforceConstraints(bool value);
            /*0x1ba524c*/ bool get_SuspendEnforceConstraints();
            /*0x1ba5254*/ void set_SuspendEnforceConstraints(bool value);
            /*0x1ba4cd8*/ void EnableConstraints();
            /*0x1ba13a8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x1b9a620*/ System.IFormatProvider get_FormatProvider();
            /*0x1ba5260*/ System.Globalization.CultureInfo get_Locale();
            /*0x1ba5268*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x1ba2354*/ bool SetLocaleValue(System.Globalization.CultureInfo culture, bool userSet, bool resetIndexes);
            /*0x1ba5920*/ bool ShouldSerializeLocale();
            /*0x1ba5928*/ int get_MinimumCapacity();
            /*0x1ba2890*/ void set_MinimumCapacity(int value);
            /*0x1ba5944*/ int get_RecordCapacity();
            /*0x1ba5960*/ int get_ElementColumnCount();
            /*0x1ba5968*/ void set_ElementColumnCount(int value);
            /*0x1ba48a0*/ System.Data.DataRelationCollection get_ParentRelations();
            /*0x1ba59b0*/ bool get_MergingData();
            /*0x1ba59b8*/ void set_MergingData(bool value);
            /*0x1ba59c4*/ System.Data.DataRelation[] get_NestedParentRelations();
            /*0x1ba59cc*/ bool get_SchemaLoading();
            /*0x1ba59d4*/ void CacheNestedParent();
            /*0x1ba59f8*/ System.Data.DataRelation[] FindNestedParentRelations();
            /*0x1ba5e08*/ int get_NestedParentsCount();
            /*0x1ba60e4*/ System.Data.DataColumn[] get_PrimaryKey();
            /*0x1ba61d8*/ void set_PrimaryKey(System.Data.DataColumn[] value);
            /*0x1ba661c*/ System.Data.DataRowCollection get_Rows();
            /*0x1ba6624*/ string get_TableName();
            /*0x1ba662c*/ void set_TableName(string value);
            /*0x1ba6bc8*/ string get_EncodedTableName();
            /*0x1ba6c40*/ string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables);
            /*0x1b9eb10*/ string get_Namespace();
            /*0x1ba1074*/ void set_Namespace(string value);
            /*0x1ba7b20*/ bool IsNamespaceInherited();
            /*0x1ba6e4c*/ void CheckCascadingNamespaceConflict(string realNamespace);
            /*0x1ba71f0*/ void CheckNamespaceValidityForNestedRelations(string realNamespace);
            /*0x1ba7b30*/ void CheckNamespaceValidityForNestedParentRelations(string ns, System.Data.DataTable parentTable);
            /*0x1ba75ac*/ void DoRaiseNamespaceChange();
            /*0x1ba7e70*/ string get_Prefix();
            /*0x1ba7e78*/ void set_Prefix(string value);
            /*0x1ba7ffc*/ System.Data.DataColumn get_XmlText();
            /*0x1ba8004*/ void set_XmlText(System.Data.DataColumn value);
            /*0x1ba80b0*/ decimal get_MaxOccurs();
            /*0x1ba80bc*/ void set_MaxOccurs(decimal value);
            /*0x1ba80c4*/ decimal get_MinOccurs();
            /*0x1ba80d0*/ void set_MinOccurs(decimal value);
            /*0x1ba80d8*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues, int record);
            /*0x1ba8174*/ System.Data.DataRow FindByIndex(System.Data.Index ndx, object[] key);
            /*0x1ba8210*/ System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx);
            /*0x1ba828c*/ void SetMergeRecords(System.Data.DataRow row, int newRecord, int oldRecord, System.Data.DataRowAction action);
            /*0x1ba8640*/ System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, bool preserveChanges, System.Data.Index idxSearch);
            /*0x1ba9030*/ System.Data.DataTable CreateInstance();
            /*0x1ba90c0*/ System.Data.DataTable Clone();
            /*0x1ba90c8*/ System.Data.DataTable Clone(System.Data.DataSet cloneDS);
            /*0x1ba92bc*/ System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable);
            /*0x1ba95c8*/ System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap);
            /*0x1ba0404*/ System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, bool skipExpressionColumns);
            /*0x1ba9a0c*/ System.ComponentModel.ISite get_Site();
            /*0x1ba9a14*/ void AddRow(System.Data.DataRow row, int proposedID);
            /*0x1ba9a24*/ void InsertRow(System.Data.DataRow row, int proposedID, int pos);
            /*0x1ba9a30*/ void InsertRow(System.Data.DataRow row, long proposedID, int pos, bool fireEvent);
            /*0x1baa608*/ void CheckNotModifying(System.Data.DataRow row);
            /*0x1baa634*/ void Clear();
            /*0x1baa63c*/ void Clear(bool clearAll);
            /*0x1baaf60*/ void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1bab024*/ void CommitRow(System.Data.DataRow row);
            /*0x1bab200*/ int Compare(string s1, string s2);
            /*0x1bab208*/ int Compare(string s1, string s2, System.Globalization.CompareInfo comparer);
            /*0x1bab370*/ int IndexOf(string s1, string s2);
            /*0x1bab3bc*/ bool IsSuffix(string s1, string s2);
            /*0x1bab408*/ void DeleteRow(System.Data.DataRow row);
            /*0x1bab46c*/ string FormatSortString(System.Data.IndexField[] indexDesc);
            /*0x1bab5b0*/ void FreeRecord(ref int record);
            /*0x1bab5cc*/ System.Data.Index GetIndex(string sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x1bab9b8*/ System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x1babb94*/ System.Collections.Generic.List<System.Data.DataViewListener> GetListeners();
            /*0x1ba5818*/ int GetSpecialHashCode(string name);
            /*0x1ba8b6c*/ void InsertRow(System.Data.DataRow row, long proposedID);
            /*0x1bac8e8*/ int NewRecord();
            /*0x1bac9e0*/ int NewUninitializedRecord();
            /*0x1bac8f0*/ int NewRecord(int sourceRecord);
            /*0x1ba3b30*/ System.Data.DataRow NewEmptyRow();
            /*0x1bac9fc*/ System.Data.DataRow NewUninitializedRow();
            /*0x1bacad0*/ System.Data.DataRow NewRow();
            /*0x1bacb9c*/ System.Data.DataRow CreateEmptyRow();
            /*0x1bacb08*/ void NewRowCreated(System.Data.DataRow row);
            /*0x1baca34*/ System.Data.DataRow NewRow(int record);
            /*0x1bacf48*/ System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder);
            /*0x1bacfa8*/ System.Type GetRowType();
            /*0x1bad020*/ System.Data.DataRow[] NewRowArray(int size);
            /*0x1bad1d4*/ bool get_NeedColumnChangeEvents();
            /*0x1bad214*/ void OnColumnChanging(System.Data.DataColumnChangeEventArgs e);
            /*0x1bad2f4*/ void OnColumnChanged(System.Data.DataColumnChangeEventArgs e);
            /*0x1bad3d4*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x1bad4b4*/ void OnRemoveColumnInternal(System.Data.DataColumn column);
            /*0x1bad4c4*/ void OnRemoveColumn(System.Data.DataColumn column);
            /*0x1bab150*/ System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1bab0a0*/ System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1bad4c8*/ void OnRowChanged(System.Data.DataRowChangeEventArgs e);
            /*0x1bad5a8*/ void OnRowChanging(System.Data.DataRowChangeEventArgs e);
            /*0x1bad688*/ void OnRowDeleting(System.Data.DataRowChangeEventArgs e);
            /*0x1bad768*/ void OnRowDeleted(System.Data.DataRowChangeEventArgs e);
            /*0x1bad848*/ void OnTableCleared(System.Data.DataTableClearEventArgs e);
            /*0x1bad928*/ void OnTableClearing(System.Data.DataTableClearEventArgs e);
            /*0x1bada08*/ void OnTableNewRow(System.Data.DataTableNewRowEventArgs e);
            /*0x1bab60c*/ System.Data.IndexField[] ParseSortString(string sortString);
            /*0x1ba6b4c*/ void RaisePropertyChanging(string name);
            /*0x1badae8*/ void RecordChanged(int record);
            /*0x1badc74*/ void RecordChanged(int[] oldIndex, int[] newIndex);
            /*0x1babd34*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x1babed8*/ void RecordStateChanged(int record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, int record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2);
            /*0x1bade70*/ int[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1bae06c*/ int[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1bae210*/ void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, object newValue);
            /*0x1baeb84*/ void RemoveRow(System.Data.DataRow row, bool check);
            /*0x1baed28*/ void Reset();
            /*0x1ba03fc*/ void ResetIndexes();
            /*0x1baef88*/ void ResetInternalIndexes(System.Data.DataColumn column);
            /*0x1baf180*/ void RollbackRow(System.Data.DataRow row);
            /*0x1bac6ac*/ System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1baf210*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x1babb9c*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, bool fireEvent);
            /*0x1ba834c*/ void SetNewRecord(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged);
            /*0x1ba9db4*/ void SetNewRecordWorker(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, ref System.Exception deferredException);
            /*0x1ba83b0*/ void SetOldRecord(System.Data.DataRow row, int proposedRecord);
            /*0x1ba43e4*/ void RestoreShadowIndexes();
            /*0x1ba43a0*/ void SetShadowIndexes();
            /*0x1baf3e8*/ void ShadowIndexCopy();
            /*0x1baf470*/ string ToString();
            /*0x1baf1d0*/ bool UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1baf4e8*/ System.Data.DataColumn AddUniqueKey(int position);
            /*0x1baf774*/ System.Data.DataColumn AddUniqueKey();
            /*0x1baf77c*/ System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey);
            /*0x1baf82c*/ void UpdatePropertyDescriptorCollectionCache();
            /*0x1baf834*/ System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes);
            /*0x1ba1308*/ System.Xml.XmlQualifiedName get_TypeName();
            /*0x1bafa80*/ void set_TypeName(System.Xml.XmlQualifiedName value);
            /*0x1bafa88*/ void Merge(System.Data.DataTable table);
            /*0x1bafa94*/ void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x1bafd14*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy);
            /*0x1bb00b8*/ bool CheckForClosureOnExpressions(System.Data.DataTable dt, bool writeHierarchy);
            /*0x1ba1410*/ bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x1bb04d8*/ void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy);
            /*0x1bb0804*/ void RestoreConstraint(bool originalEnforceConstraint);
            /*0x1bb0868*/ bool IsEmptyXml(System.Xml.XmlReader reader);
            /*0x1bb0a44*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x1bb22b8*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x1bb235c*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x1bb36fc*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x1bb1904*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x1bb37b4*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x1bb23d0*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x1bb0178*/ void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x1bb3954*/ void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList);
            /*0x1bb4038*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x1bb4048*/ System.Xml.Schema.XmlSchema GetSchema();
            /*0x1bb422c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x1bb4400*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x1bb4438*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x1bb4444*/ System.Collections.Hashtable get_RowDiffId();
            /*0x1bb44ac*/ int get_ObjectID();
            /*0x1bb44b4*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x1bb459c*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x1bb463c*/ void EvaluateExpressions();
            /*0x1bac110*/ void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows);
            /*0x1bb4974*/ void EvaluateExpressions(System.Data.DataColumn column);
            /*0x1baae24*/ void EvaluateDependentExpressions(System.Data.DataColumn column);
            /*0x1bae388*/ void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows);

            struct RowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataTable _targetTable;

                /*0xb22b6c*/ void Prepare(System.Data.DataTable table);
            }

            struct DSRowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataSet _targetDS;

                /*0xb22b28*/ void Prepare(System.Data.DataSet ds);
            }
        }

        class DataTableClearEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;

            /*0x2018dc4*/ DataTableClearEventArgs(System.Data.DataTable dataTable);
        }

        class DataTableClearEventHandler : System.MulticastDelegate
        {
            /*0x2018e3c*/ DataTableClearEventHandler(object object, nint method);
            /*0x2018e9c*/ void Invoke(object sender, System.Data.DataTableClearEventArgs e);
            /*0x2019230*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataTableClearEventArgs e, System.AsyncCallback callback, object object);
            /*0x2019260*/ void EndInvoke(System.IAsyncResult result);
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

            /*0x201926c*/ DataTableCollection(System.Data.DataSet dataSet);
            /*0x20193c8*/ System.Collections.ArrayList get_List();
            /*0x20193d0*/ int get_ObjectID();
            /*0x20193d8*/ System.Data.DataTable get_Item(int index);
            /*0x20195b0*/ System.Data.DataTable get_Item(string name);
            /*0x2019934*/ System.Data.DataTable get_Item(string name, string tableNamespace);
            /*0x2019c34*/ System.Data.DataTable GetTable(string name, string ns);
            /*0x2019d54*/ System.Data.DataTable GetTableSmart(string name, string ns);
            /*0x2019e94*/ void Add(System.Data.DataTable table);
            /*0x201a31c*/ void ArrayAdd(System.Data.DataTable table);
            /*0x201a420*/ string AssignName();
            /*0x201a204*/ void BaseAdd(System.Data.DataTable table);
            /*0x201a8a0*/ void BaseGroupSwitch(System.Data.DataTable[] oldArray, int oldLength, System.Data.DataTable[] newArray, int newLength);
            /*0x201aa28*/ void BaseRemove(System.Data.DataTable table);
            /*0x201aaa4*/ bool CanRemove(System.Data.DataTable table, bool fThrowException);
            /*0x201b160*/ void Clear();
            /*0x201a538*/ bool Contains(string name);
            /*0x201b42c*/ bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive);
            /*0x201b5b4*/ bool Contains(string name, bool caseSensitive);
            /*0x201b6ec*/ int IndexOf(System.Data.DataTable table);
            /*0x201b7dc*/ int IndexOf(string tableName);
            /*0x201b7f8*/ int IndexOf(string tableName, string tableNamespace, bool chekforNull);
            /*0x201b860*/ void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x20196a8*/ int InternalIndexOf(string tableName);
            /*0x2019a94*/ int InternalIndexOf(string tableName, string tableNamespace);
            /*0x201a46c*/ string MakeName(int index);
            /*0x201a340*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x201a124*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x201a630*/ void RegisterName(string name, string tbNamespace);
            /*0x201b908*/ void Remove(System.Data.DataTable table);
            /*0x201af28*/ void UnregisterName(string name);
        }

        class DataTableNewRowEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;

            /*0x201baf8*/ DataTableNewRowEventArgs(System.Data.DataRow dataRow);
        }

        class DataTableNewRowEventHandler : System.MulticastDelegate
        {
            /*0x201bb70*/ DataTableNewRowEventHandler(object object, nint method);
            /*0x201bbd0*/ void Invoke(object sender, System.Data.DataTableNewRowEventArgs e);
            /*0x201bf64*/ System.IAsyncResult BeginInvoke(object sender, System.Data.DataTableNewRowEventArgs e, System.AsyncCallback callback, object object);
            /*0x201bf94*/ void EndInvoke(System.IAsyncResult result);
        }

        class DataTableTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x201bfa0*/ DataTableTypeConverter();
            /*0x201c060*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataView : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IBindingList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
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
            /*0x88*/ System.Data.DataViewRowState _delayedRecordStates;
            /*0x8c*/ bool _fEndInitInProgress;
            /*0x90*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewCache;
            /*0x98*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewBuffer;
            /*0xa0*/ System.Data.DataViewListener _dvListener;
            /*0xa8*/ int _objectID;

            static /*0x201ffe8*/ DataView();
            /*0x201cab8*/ DataView(System.Data.DataTable table, bool locked);
            /*0x201cfe4*/ bool get_AllowDelete();
            /*0x201cfec*/ bool get_AllowNew();
            /*0x201cff4*/ int get_Count();
            /*0x201d048*/ int get_CountFromIndex();
            /*0x201d064*/ System.Data.DataViewManager get_DataViewManager();
            /*0x201d06c*/ bool get_IsOpen();
            /*0x201d074*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x201d07c*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x201d084*/ string get_Sort();
            /*0x201d0dc*/ System.Comparison<System.Data.DataRow> get_SortComparison();
            /*0x201d0e4*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x201d0e8*/ System.Data.DataTable get_Table();
            /*0x201d0f0*/ object System.Collections.IList.get_Item(int recordIndex);
            /*0x201d140*/ void System.Collections.IList.set_Item(int recordIndex, object value);
            /*0x201d118*/ System.Data.DataRowView get_Item(int recordIndex);
            /*0x201d2bc*/ System.Data.DataRowView AddNew();
            /*0x201d588*/ void CheckOpen();
            /*0x201d71c*/ void Close();
            /*0x201d77c*/ void CopyTo(System.Array array, int index);
            /*0x201d918*/ void CopyTo(System.Data.DataRowView[] array, int index);
            /*0x201dad8*/ void Delete(int index);
            /*0x201db00*/ void Delete(System.Data.DataRow row);
            /*0x201deb8*/ void Dispose(bool disposing);
            /*0x201dcc0*/ void FinishAddNew(bool success);
            /*0x201def0*/ System.Collections.IEnumerator GetEnumerator();
            /*0x201df70*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x201df78*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x201df80*/ int System.Collections.IList.Add(object value);
            /*0x201e020*/ void System.Collections.IList.Clear();
            /*0x201e090*/ bool System.Collections.IList.Contains(object value);
            /*0x201e128*/ int System.Collections.IList.IndexOf(object value);
            /*0x201d604*/ int IndexOf(System.Data.DataRowView rowview);
            /*0x201e1b4*/ int IndexOfDataRowView(System.Data.DataRowView rowview);
            /*0x201e210*/ void System.Collections.IList.Insert(int index, object value);
            /*0x201e280*/ void System.Collections.IList.Remove(object value);
            /*0x201e3f4*/ void System.Collections.IList.RemoveAt(int index);
            /*0x201e41c*/ System.Data.IFilter GetFilter();
            /*0x201e424*/ int GetRecord(int recordIndex);
            /*0x201d1b0*/ System.Data.DataRow GetRow(int index);
            /*0x201d8d8*/ System.Data.DataRowView GetRowView(int record);
            /*0x201d258*/ System.Data.DataRowView GetRowView(System.Data.DataRow dr);
            /*0x201e5ec*/ void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0x201e680*/ void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e);
            /*0x201e73c*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x201ebec*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x201ef78*/ void Reset();
            /*0x201e998*/ void ResetRowViewCache();
            /*0x201efa0*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x201f234*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
            /*0x201f23c*/ void SetIndex2(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, bool fireEvent);
            /*0x201d760*/ void UpdateIndex();
            /*0x201f780*/ void UpdateIndex(bool force);
            /*0x201f44c*/ void UpdateIndex(bool force, bool fireEvent);
            /*0x201f97c*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x201fb98*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x201fdb4*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x201ffd0*/ void ColumnCollectionChangedInternal(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x201ffe0*/ int get_ObjectID();

            class DataRowReferenceComparer : System.Collections.Generic.IEqualityComparer<System.Data.DataRow>
            {
                static /*0x0*/ System.Data.DataView.DataRowReferenceComparer s_default;

                static /*0x2ae57c4*/ DataRowReferenceComparer();
                /*0x2ae5798*/ DataRowReferenceComparer();
                /*0x2ae57a0*/ bool Equals(System.Data.DataRow x, System.Data.DataRow y);
                /*0x2ae57ac*/ int GetHashCode(System.Data.DataRow obj);
            }
        }

        class DataViewListener
        {
            /*0x10*/ System.WeakReference _dvWeak;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ System.Data.Index _index;
            /*0x28*/ int _objectID;

            /*0x201cd7c*/ DataViewListener(System.Data.DataView dv);
            /*0x2020064*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x202014c*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x202020c*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x20202dc*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x20203b8*/ void IndexListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x201ce04*/ void RegisterMetaDataEvents(System.Data.DataTable table);
            /*0x201d774*/ void UnregisterMetaDataEvents();
            /*0x2020660*/ void UnregisterMetaDataEvents(bool updateListeners);
            /*0x201f890*/ void RegisterListChangedEvent(System.Data.Index index);
            /*0x201f78c*/ void UnregisterListChangedEvent();
            /*0x2020124*/ void CleanUp(bool updateListeners);
            /*0x2020478*/ void RegisterListener(System.Data.DataTable table);
        }

        class DataViewManager : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ System.NotSupportedException s_notSupported;
            /*0x20*/ System.Data.DataViewSettingCollection _dataViewSettingsCollection;
            /*0x28*/ int _nViews;

            static /*0x2020904*/ DataViewManager();
            /*0x20208fc*/ System.Data.DataViewSettingCollection get_DataViewSettings();
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

            /*0x2020978*/ DataViewSetting();
            /*0x20209e8*/ bool get_ApplyDefaultSort();
            /*0x20209f0*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x2020a04*/ void SetDataTable(System.Data.DataTable table);
            /*0x2020a18*/ string get_RowFilter();
            /*0x2020a20*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x2020a28*/ string get_Sort();
        }

        class DataViewSettingCollection
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Collections.Hashtable _list;

            /*0x2020a30*/ System.Data.DataViewSetting get_Item(System.Data.DataTable table);
            /*0x2020b38*/ void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value);
            /*0x2020bc0*/ void Remove(System.Data.DataTable table);
        }

        class DefaultValueTypeConverter : System.ComponentModel.StringConverter
        {
            /*0x2024da0*/ DefaultValueTypeConverter();
            /*0x2024da8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x2024f70*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            static /*0x21b6e68*/ void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x21b6b20*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName);
            /*0x21b6b2c*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName, bool local, string relationName);
            /*0x21b6c2c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x21b6fe0*/ object Eval();
            /*0x21b6ff4*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x21b7378*/ object Eval(int[] records);
            /*0x21b73fc*/ bool IsConstant();
            /*0x21b7404*/ bool IsTableConstant();
            /*0x21b740c*/ bool HasLocalAggregate();
            /*0x21b7414*/ bool HasRemoteAggregate();
            /*0x21b7424*/ bool DependsOn(System.Data.DataColumn column);
            /*0x21b746c*/ System.Data.ExpressionNode Optimize();
        }

        class BinaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _left;
            /*0x28*/ System.Data.ExpressionNode _right;

            static /*0x21c0508*/ object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            static /*0x21c1bc0*/ System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code);
            /*0x21b9f4c*/ BinaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x21b9f8c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x21b9fec*/ object Eval();
            /*0x21ba000*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x21bfd8c*/ object Eval(int[] recordNos);
            /*0x21bfda8*/ bool IsConstant();
            /*0x21bfe00*/ bool IsTableConstant();
            /*0x21bfe58*/ bool HasLocalAggregate();
            /*0x21bfeb0*/ bool HasRemoteAggregate();
            /*0x21bff08*/ bool DependsOn(System.Data.DataColumn column);
            /*0x21bff70*/ System.Data.ExpressionNode Optimize();
            /*0x21c04cc*/ void SetTypeMismatchError(int op, System.Type left, System.Type right);
            /*0x21c0534*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op);
            /*0x21c053c*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op, System.Globalization.CompareInfo comparer);
            /*0x21ba01c*/ object EvalBinaryOp(int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            /*0x21c1b9c*/ System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType);
            /*0x21c1be4*/ bool IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x21c1c54*/ bool IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x21c17b4*/ System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x21c1430*/ System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x21c1cc4*/ int SqlResultType(int typeCode);

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

            /*0x2101174*/ LikeNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x210117c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x2101734*/ string AnalyzePattern(string pat);
        }

        class ConstNode : System.Data.ExpressionNode
        {
            /*0x18*/ object _val;

            /*0x21c6450*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant);
            /*0x21c01bc*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes);
            /*0x21c6fa8*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x21c6fb0*/ object Eval();
            /*0x21c6fb8*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x21c6fc4*/ object Eval(int[] recordNos);
            /*0x21c6fd0*/ bool IsConstant();
            /*0x21c6fd8*/ bool IsTableConstant();
            /*0x21c6fe0*/ bool HasLocalAggregate();
            /*0x21c6fe8*/ bool HasRemoteAggregate();
            /*0x21c6ff0*/ System.Data.ExpressionNode Optimize();
            /*0x21c6adc*/ object SmallestDecimal(object constant);
            /*0x21c6458*/ object SmallestNumeric(object constant);
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

            static /*0x1b2500c*/ bool IsUnknown(object value);
            static /*0x1b24cfc*/ bool ToBoolean(object value);
            /*0x1b24694*/ DataExpression(System.Data.DataTable table, string expression);
            /*0x1b2469c*/ DataExpression(System.Data.DataTable table, string expression, System.Type type);
            /*0x1b24984*/ string get_Expression();
            /*0x1b249d8*/ bool get_HasValue();
            /*0x1b24890*/ void Bind(System.Data.DataTable table);
            /*0x1b221c4*/ bool DependsOn(System.Data.DataColumn column);
            /*0x1b249e8*/ object Evaluate();
            /*0x1b249f4*/ object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1b24c14*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1b24fec*/ System.Data.DataColumn[] GetDependency();
            /*0x1b24ff4*/ bool IsTableAggregate();
            /*0x1b25070*/ bool HasLocalAggregate();
            /*0x1b25088*/ bool HasRemoteAggregate();
        }

        class ExpressionNode
        {
            /*0x10*/ System.Data.DataTable _table;

            static /*0x202cc5c*/ bool IsInteger(System.Data.Common.StorageType type);
            static /*0x202cc80*/ bool IsIntegerSql(System.Data.Common.StorageType type);
            static /*0x202ccb8*/ bool IsSigned(System.Data.Common.StorageType type);
            static /*0x202cd20*/ bool IsSignedSql(System.Data.Common.StorageType type);
            static /*0x202cd98*/ bool IsUnsigned(System.Data.Common.StorageType type);
            static /*0x202cdc4*/ bool IsUnsignedSql(System.Data.Common.StorageType type);
            static /*0x202ce00*/ bool IsNumeric(System.Data.Common.StorageType type);
            static /*0x202ce20*/ bool IsNumericSql(System.Data.Common.StorageType type);
            static /*0x202cd00*/ bool IsFloat(System.Data.Common.StorageType type);
            static /*0x202cd5c*/ bool IsFloatSql(System.Data.Common.StorageType type);
            /*0x202cb98*/ ExpressionNode(System.Data.DataTable table);
            /*0x202cbc4*/ System.IFormatProvider get_FormatProvider();
            /*0x202cc3c*/ bool get_IsSqlColumn();
            /*0x202cc44*/ System.Data.DataTable get_table();
            /*0x202cc4c*/ void BindTable(System.Data.DataTable table);
            void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            object Eval();
            object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            object Eval(int[] recordNos);
            bool IsConstant();
            bool IsTableConstant();
            bool HasLocalAggregate();
            bool HasRemoteAggregate();
            System.Data.ExpressionNode Optimize();
            /*0x202cc54*/ bool DependsOn(System.Data.DataColumn column);
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

            static /*0x202f0a8*/ ExpressionParser();
            /*0x202cea0*/ ExpressionParser(System.Data.DataTable table);
            /*0x202cf48*/ void LoadExpression(string data);
            /*0x202d028*/ void StartScan();
            /*0x202d0e4*/ System.Data.ExpressionNode Parse();
            /*0x202e644*/ System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate);
            /*0x202e5fc*/ System.Data.ExpressionNode NodePop();
            /*0x202e5ac*/ System.Data.ExpressionNode NodePeek();
            /*0x202e504*/ void NodePush(System.Data.ExpressionNode node);
            /*0x202e254*/ void BuildExpression(int pri);
            /*0x202e4bc*/ void CheckToken(System.Data.Tokens token);
            /*0x202dea4*/ System.Data.Tokens Scan();
            /*0x202ec2c*/ void ScanNumeric();
            /*0x202eff8*/ void ScanName();
            /*0x202eb08*/ void ScanName(char chEnd, char esc, string charsToEscape);
            /*0x202e980*/ void ScanDate();
            /*0x202ed78*/ void ScanBinaryConstant();
            /*0x202ed90*/ void ScanReserved();
            /*0x202ea24*/ void ScanString(char escape);
            /*0x202e490*/ void ScanToken(System.Data.Tokens token);
            /*0x202e920*/ void ScanWhite();
            /*0x202f094*/ bool IsWhiteSpace(char ch);
            /*0x202efc0*/ bool IsAlphaNumeric(char ch);
            /*0x202ed7c*/ bool IsDigit(char ch);
            /*0x202f068*/ bool IsAlpha(char ch);

            struct ReservedWords
            {
                /*0x10*/ string _word;
                /*0x18*/ System.Data.Tokens _token;
                /*0x1c*/ int _op;

                /*0xb22c28*/ ReservedWords(string word, System.Data.Tokens token, int op);
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

            /*0x210b6c0*/ OperatorInfo(System.Data.Nodes type, int op, int pri);
        }

        class InvalidExpressionException : System.Data.DataException
        {
            /*0x210111c*/ InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x2101164*/ InvalidExpressionException();
            /*0x210116c*/ InvalidExpressionException(string s);
        }

        class EvaluateException : System.Data.InvalidExpressionException
        {
            /*0x2026550*/ EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x2026598*/ EvaluateException();
            /*0x20265a0*/ EvaluateException(string s);
        }

        class SyntaxErrorException : System.Data.InvalidExpressionException
        {
            /*0x2129f94*/ SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x2129fdc*/ SyntaxErrorException();
            /*0x2129fe4*/ SyntaxErrorException(string s);
        }

        class ExprException
        {
            static /*0x202b6c8*/ System.OverflowException _Overflow(string error);
            static /*0x202b728*/ System.Data.InvalidExpressionException _Expr(string error);
            static /*0x202b788*/ System.Data.SyntaxErrorException _Syntax(string error);
            static /*0x202b7e8*/ System.Data.EvaluateException _Eval(string error);
            static /*0x202b848*/ System.Data.EvaluateException _Eval(string error, System.Exception innerException);
            static /*0x202b8a8*/ System.Exception InvokeArgument();
            static /*0x202b8ec*/ System.Exception NYI(string moreinfo);
            static /*0x202b940*/ System.Exception MissingOperand(System.Data.OperatorInfo before);
            static /*0x202b9dc*/ System.Exception MissingOperator(string token);
            static /*0x202ba30*/ System.Exception TypeMismatch(string expr);
            static /*0x202ba84*/ System.Exception FunctionArgumentOutOfRange(string arg, string func);
            static /*0x202baec*/ System.Exception ExpressionTooComplex();
            static /*0x202bb30*/ System.Exception UnboundName(string name);
            static /*0x202bb84*/ System.Exception InvalidString(string str);
            static /*0x202bbd8*/ System.Exception UndefinedFunction(string name);
            static /*0x202bc2c*/ System.Exception SyntaxError();
            static /*0x202bc70*/ System.Exception FunctionArgumentCount(string name);
            static /*0x202bcc4*/ System.Exception MissingRightParen();
            static /*0x202bd08*/ System.Exception UnknownToken(string token, int position);
            static /*0x202bdb8*/ System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, int position);
            static /*0x202bef8*/ System.Exception DatatypeConvertion(System.Type type1, System.Type type2);
            static /*0x202bf90*/ System.Exception DatavalueConvertion(object value, System.Type type, System.Exception innerException);
            static /*0x202c028*/ System.Exception InvalidName(string name);
            static /*0x202c07c*/ System.Exception InvalidDate(string date);
            static /*0x202c0d0*/ System.Exception NonConstantArgument();
            static /*0x202c114*/ System.Exception InvalidPattern(string pat);
            static /*0x202c168*/ System.Exception InWithoutParentheses();
            static /*0x202c1ac*/ System.Exception InWithoutList();
            static /*0x202c1f0*/ System.Exception InvalidIsSyntax();
            static /*0x20212a8*/ System.Exception Overflow(System.Type type);
            static /*0x202c234*/ System.Exception ArgumentType(string function, int arg, System.Type type);
            static /*0x202c308*/ System.Exception ArgumentTypeInteger(string function, int arg);
            static /*0x202c3b8*/ System.Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2);
            static /*0x202c494*/ System.Exception AmbiguousBinop(int op, System.Type type1, System.Type type2);
            static /*0x202c570*/ System.Exception UnsupportedOperator(int op);
            static /*0x202c600*/ System.Exception InvalidNameBracketing(string name);
            static /*0x202c654*/ System.Exception MissingOperandBefore(string op);
            static /*0x202c6a8*/ System.Exception TooManyRightParentheses();
            static /*0x202c6ec*/ System.Exception UnresolvedRelation(string name, string expr);
            static /*0x202c750*/ System.Data.EvaluateException BindFailure(string relationName);
            static /*0x202c7a4*/ System.Exception AggregateArgument();
            static /*0x202c7e8*/ System.Exception AggregateUnbound(string expr);
            static /*0x202c83c*/ System.Exception EvalNoContext();
            static /*0x202c880*/ System.Exception ExpressionUnbound(string expr);
            static /*0x202c8d4*/ System.Exception ComputeNotAggregate(string expr);
            static /*0x202c928*/ System.Exception FilterConvertion(string expr);
            static /*0x202c97c*/ System.Exception LookupArgument();
            static /*0x202c9c0*/ System.Exception InvalidType(string typeName);
            static /*0x202ca14*/ System.Exception InvalidHoursArgument();
            static /*0x202ca58*/ System.Exception InvalidMinutesArgument();
            static /*0x202ca9c*/ System.Exception InvalidTimeZoneRange();
            static /*0x202cae0*/ System.Exception MismatchKindandTimeSpan();
            static /*0x202cb24*/ System.Exception UnsupportedDataType(System.Type type);
        }

        class FunctionNode : System.Data.ExpressionNode
        {
            static /*0x0*/ System.Data.Function[] s_funcs;
            /*0x18*/ string _name;
            /*0x20*/ int _info;
            /*0x24*/ int _argumentCount;
            /*0x28*/ System.Data.ExpressionNode[] _arguments;

            static /*0x20f9184*/ FunctionNode();
            /*0x20f5af0*/ FunctionNode(System.Data.DataTable table, string name);
            /*0x20f5c40*/ void AddArgument(System.Data.ExpressionNode argument);
            /*0x20f5e4c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x20f6378*/ object Eval();
            /*0x20f638c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x20f8980*/ object Eval(int[] recordNos);
            /*0x20f89bc*/ bool IsConstant();
            /*0x20f8a58*/ bool IsTableConstant();
            /*0x20f8ae0*/ bool HasLocalAggregate();
            /*0x20f8b68*/ bool HasRemoteAggregate();
            /*0x20f8bf0*/ bool DependsOn(System.Data.DataColumn column);
            /*0x20f8c8c*/ System.Data.ExpressionNode Optimize();
            /*0x20f6e20*/ System.Type GetDataType(System.Data.ExpressionNode node);
            /*0x20f7120*/ object EvalFunction(System.Data.FunctionId id, object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x20f8e5c*/ System.Data.FunctionId get_Aggregate();
            /*0x20f8f0c*/ bool get_IsAggregate();
            /*0x20f6144*/ void Check();
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

            static /*0x20f5098*/ Function();
            /*0x20f4e94*/ Function(string name, System.Data.FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3);
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

            /*0x2101a14*/ LookupNode(System.Data.DataTable table, string columnName, string relationName);
            /*0x2101a4c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x2101c74*/ object Eval();
            /*0x2101ca4*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x2101db8*/ object Eval(int[] recordNos);
            /*0x2101df4*/ bool IsConstant();
            /*0x2101dfc*/ bool IsTableConstant();
            /*0x2101e04*/ bool HasLocalAggregate();
            /*0x2101e0c*/ bool HasRemoteAggregate();
            /*0x2101e14*/ bool DependsOn(System.Data.DataColumn column);
            /*0x2101e24*/ System.Data.ExpressionNode Optimize();
        }

        class NameNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _name;
            /*0x20*/ bool _found;
            /*0x28*/ System.Data.DataColumn _column;

            static /*0x2105058*/ string ParseName(char[] text, int start, int pos);
            /*0x210500c*/ NameNode(System.Data.DataTable table, char[] text, int start, int pos);
            /*0x2105274*/ NameNode(System.Data.DataTable table, string name);
            /*0x21052a0*/ bool get_IsSqlColumn();
            /*0x21052bc*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x21054ec*/ object Eval();
            /*0x210551c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x21055c8*/ object Eval(int[] records);
            /*0x2105604*/ bool IsConstant();
            /*0x210560c*/ bool IsTableConstant();
            /*0x2105664*/ bool HasLocalAggregate();
            /*0x21056bc*/ bool HasRemoteAggregate();
            /*0x2105714*/ bool DependsOn(System.Data.DataColumn column);
            /*0x2105784*/ System.Data.ExpressionNode Optimize();
        }

        class Operators
        {
            static /*0x0*/ int[] s_priority;
            static /*0x8*/ string[] s_looks;

            static /*0x210b920*/ Operators();
            static /*0x210b700*/ bool IsArithmetical(int op);
            static /*0x210b72c*/ bool IsLogical(int op);
            static /*0x210b76c*/ bool IsRelational(int op);
            static /*0x210b77c*/ int Priority(int op);
            static /*0x210b844*/ string ToString(int op);
        }

        class UnaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _right;

            /*0x1dae860*/ UnaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode right);
            /*0x1dae89c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x1dae8c4*/ object Eval();
            /*0x1dae8d8*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1daf14c*/ object Eval(int[] recordNos);
            /*0x1dae91c*/ object EvalUnaryOp(int op, object vl);
            /*0x1daf16c*/ bool IsConstant();
            /*0x1daf18c*/ bool IsTableConstant();
            /*0x1daf1ac*/ bool HasLocalAggregate();
            /*0x1daf1cc*/ bool HasRemoteAggregate();
            /*0x1daf1ec*/ bool DependsOn(System.Data.DataColumn column);
            /*0x1daf210*/ System.Data.ExpressionNode Optimize();
        }

        class ZeroOpNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;

            /*0x2ae42f0*/ ZeroOpNode(int op);
            /*0x2ae4320*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x2ae4324*/ object Eval();
            /*0x2ae43f4*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x2ae4400*/ object Eval(int[] recordNos);
            /*0x2ae440c*/ bool IsConstant();
            /*0x2ae4414*/ bool IsTableConstant();
            /*0x2ae441c*/ bool HasLocalAggregate();
            /*0x2ae4424*/ bool HasRemoteAggregate();
            /*0x2ae442c*/ System.Data.ExpressionNode Optimize();
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

            /*0x202f460*/ ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x202f4ac*/ ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x202f67c*/ ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule);
            /*0x202f6ec*/ System.Data.DataKey get_ChildKey();
            /*0x202f714*/ System.Data.DataColumn[] get_Columns();
            /*0x202f740*/ System.Data.DataTable get_Table();
            /*0x202f76c*/ string[] get_ParentColumnNames();
            /*0x202f778*/ string[] get_ChildColumnNames();
            /*0x202f784*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x202f8a8*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x202f8b0*/ bool IsKeyNull(object[] values);
            /*0x202f980*/ bool IsConstraintViolated();
            /*0x202fb84*/ bool CanEnableConstraint();
            /*0x202fcf4*/ void CascadeCommit(System.Data.DataRow row);
            /*0x202fe70*/ void CascadeDelete(System.Data.DataRow row);
            /*0x2030364*/ void CascadeRollback(System.Data.DataRow row);
            /*0x2030574*/ void CascadeUpdate(System.Data.DataRow row);
            /*0x2030a34*/ void CheckCanClearParentTable(System.Data.DataTable table);
            /*0x2030b18*/ void CheckCanRemoveParentRow(System.Data.DataRow row);
            /*0x2030bf4*/ void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x2030cdc*/ void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action);
            /*0x2030fc4*/ void NonVirtualCheckState();
            /*0x2031220*/ void CheckState();
            /*0x2031224*/ System.Data.AcceptRejectRule get_AcceptRejectRule();
            /*0x203124c*/ void set_AcceptRejectRule(System.Data.AcceptRejectRule value);
            /*0x20312cc*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x2031318*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x2031328*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x2031a30*/ System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination);
            /*0x202f4fc*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x2032004*/ System.Data.Rule get_DeleteRule();
            /*0x203202c*/ void set_DeleteRule(System.Data.Rule value);
            /*0x20320ac*/ bool Equals(object key);
            /*0x20321a0*/ int GetHashCode();
            /*0x20321a8*/ System.Data.DataColumn[] get_RelatedColumns();
            /*0x2031a08*/ System.Data.DataColumn[] get_RelatedColumnsReference();
            /*0x2030bcc*/ System.Data.DataKey get_ParentKey();
            /*0x20321d4*/ System.Data.DataRelation FindParentRelation();
            /*0x20322ac*/ System.Data.DataTable get_RelatedTable();
            /*0x20322d8*/ System.Data.Rule get_UpdateRule();
            /*0x2032300*/ void set_UpdateRule(System.Data.Rule value);
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

            /*0x2101e28*/ MergeFailedEventArgs(System.Data.DataTable table, string conflict);
            /*0x2101ea4*/ string get_Conflict();
        }

        class MergeFailedEventHandler : System.MulticastDelegate
        {
            /*0x2101eac*/ MergeFailedEventHandler(object object, nint method);
            /*0x2101f0c*/ void Invoke(object sender, System.Data.MergeFailedEventArgs e);
            /*0x21022a0*/ System.IAsyncResult BeginInvoke(object sender, System.Data.MergeFailedEventArgs e, System.AsyncCallback callback, object object);
            /*0x21022d0*/ void EndInvoke(System.IAsyncResult result);
        }

        class Merger
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.DataTable _dataTable;
            /*0x20*/ bool _preserveChanges;
            /*0x24*/ System.Data.MissingSchemaAction _missingSchemaAction;
            /*0x28*/ bool _isStandAlonetable;
            /*0x29*/ bool _IgnoreNSforTableLookup;

            /*0x21022dc*/ Merger(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x2102334*/ Merger(System.Data.DataTable dataTable, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x2102394*/ void MergeDataSet(System.Data.DataSet source);
            /*0x2103e08*/ void MergeTable(System.Data.DataTable src);
            /*0x210406c*/ void MergeTable(System.Data.DataTable src, System.Data.DataTable dst);
            /*0x21045fc*/ System.Data.DataTable MergeSchema(System.Data.DataTable table);
            /*0x21032d4*/ void MergeTableData(System.Data.DataTable src);
            /*0x2103350*/ void MergeConstraints(System.Data.DataSet source);
            /*0x2104d24*/ void MergeConstraints(System.Data.DataTable table);
            /*0x21033cc*/ void MergeRelation(System.Data.DataRelation relation);
            /*0x2103b90*/ void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst);
            /*0x21044a4*/ System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst);
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
            /*0x210c4a4*/ PrimaryKeyTypeConverter();
            /*0x210c564*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x210c56c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x210c634*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class PropertyCollection : System.Collections.Hashtable, System.ICloneable
        {
            /*0x210c83c*/ PropertyCollection();
            /*0x210c844*/ PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x210c84c*/ object Clone();
        }

        struct Range
        {
            /*0x10*/ int _min;
            /*0x14*/ int _max;
            /*0x18*/ bool _isNotNull;

            /*0xae12e4*/ Range(int min, int max);
            /*0xae12ec*/ int get_Count();
            /*0xae130c*/ bool get_IsNull();
            /*0xae131c*/ int get_Min();
            /*0xae1344*/ void CheckNull();
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

            static /*0x210ce48*/ int NewCapacity(int capacity);
            /*0x210cc38*/ RecordManager(System.Data.DataTable table);
            /*0x210cd00*/ void GrowRecordCapacity();
            /*0x210cf30*/ int get_LastFreeRecord();
            /*0x210cf38*/ int get_MinimumCapacity();
            /*0x210cf40*/ void set_MinimumCapacity(int value);
            /*0x210cf88*/ int get_RecordCapacity();
            /*0x210ce94*/ void set_RecordCapacity(int value);
            /*0x210ce5c*/ int NormalizedMinimumCapacity(int capacity);
            /*0x210cf90*/ int NewRecordBase();
            /*0x210d044*/ void FreeRecord(ref int record);
            /*0x210d1cc*/ void Clear(bool clearAll);
            /*0x20fa8e0*/ System.Data.DataRow get_Item(int record);
            /*0x210d154*/ void set_Item(int record, System.Data.DataRow value);
            /*0x210d3d0*/ int ImportRecord(System.Data.DataTable src, int record);
            /*0x210d3d8*/ int CopyRecord(System.Data.DataTable src, int record, int copy);
            /*0x210d730*/ void SetRowCache(System.Data.DataRow[] newRows);
        }

        class RelatedView : System.Data.DataView, System.Data.IFilter
        {
            /*0xb0*/ System.Nullable<System.Data.DataKey> _parentKey;
            /*0xc0*/ System.Data.DataKey _childKey;
            /*0xc8*/ System.Data.DataRowView _parentRowView;
            /*0xd0*/ object[] _filterValues;

            /*0x1ed12fc*/ RelatedView(System.Data.DataColumn[] columns, object[] values);
            /*0x1ed1430*/ RelatedView(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns);
            /*0x1ed154c*/ object[] GetParentValues();
            /*0x1ed1600*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1ed178c*/ System.Data.IFilter GetFilter();
            /*0x1ed1790*/ System.Data.DataRowView AddNew();
            /*0x1ed17f4*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
        }

        class RelationshipConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x1ed1824*/ RelationshipConverter();
            /*0x1ed182c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1ed18f4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
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

            static /*0x20fd27c*/ bool op_Equality(System.Data.IndexField if1, System.Data.IndexField if2);
            /*0xae1280*/ IndexField(System.Data.DataColumn column, bool isDescending);
            /*0xae1290*/ bool Equals(object obj);
            /*0xae1298*/ int GetHashCode();
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

            static /*0x20fa064*/ System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns);
            static /*0x20fc734*/ int GetReplaceAction(System.Data.DataViewRowState oldState);
            static int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
            /*0x20f9cfc*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x20fa000*/ Index(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x20f9d0c*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x20fa4ec*/ bool Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x20fa5b4*/ bool get_HasRemoteAggregate();
            /*0x20fa5bc*/ int get_ObjectID();
            /*0x20fa5c4*/ System.Data.DataViewRowState get_RecordStates();
            /*0x20fa5cc*/ System.Data.IFilter get_RowFilter();
            /*0x20fa648*/ int GetRecord(int recordIndex);
            /*0x20fa6ac*/ bool get_HasDuplicates();
            /*0x20fa700*/ int get_RecordCount();
            /*0x20fa708*/ bool AcceptRecord(int record);
            /*0x20fa738*/ bool AcceptRecord(int record, System.Data.IFilter filter);
            /*0x20fa91c*/ void ListChangedAdd(System.Data.DataViewListener listener);
            /*0x20fa980*/ void ListChangedRemove(System.Data.DataViewListener listener);
            /*0x20fa9e4*/ int get_RefCount();
            /*0x20fa9ec*/ void AddRef();
            /*0x20fab98*/ int RemoveRef();
            /*0x20fad54*/ void ApplyChangeAction(int record, int action, int changeRecord);
            /*0x20fb1b4*/ bool CheckUnique();
            /*0x20fb1d0*/ int CompareRecords(int record1, int record2);
            /*0x20fb334*/ int CompareDataRows(int record1, int record2);
            /*0x20fb3d8*/ int CompareDuplicateRecords(int record1, int record2);
            /*0x20fb52c*/ int CompareRecordToKey(int record1, object[] vals);
            /*0x20fb608*/ void DeleteRecordFromIndex(int recordIndex);
            /*0x20fb148*/ void DeleteRecord(int recordIndex);
            /*0x20fb610*/ void DeleteRecord(int recordIndex, bool fireEvent);
            /*0x20fb908*/ System.Data.RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex);
            /*0x20fb150*/ int GetIndex(int record);
            /*0x20faffc*/ int GetIndex(int record, int changeRecord);
            /*0x20fb974*/ object[] GetUniqueKeyValues();
            /*0x20fbcb0*/ int FindNodeByKey(object originalKey);
            /*0x20fbed8*/ int FindNodeByKeys(object[] originalKey);
            /*0x20fc114*/ int FindNodeByKeyRecord(int record);
            /*0x20fc20c*/ System.Data.Range GetRangeFromNode(int nodeId);
            /*0x20fc388*/ System.Data.Range FindRecords(object key);
            /*0x20fc3b8*/ System.Data.Range FindRecords(object[] key);
            /*0x20fc3e8*/ void FireResetEvent();
            /*0x20fc718*/ int GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x20fc75c*/ System.Data.DataRow GetRow(int i);
            /*0x20fc794*/ System.Data.DataRow[] GetRows(object[] values);
            /*0x20fc7cc*/ System.Data.DataRow[] GetRows(System.Data.Range range);
            /*0x20fa144*/ void InitRecords(System.Data.IFilter filter);
            /*0x20fc980*/ int InsertRecordToIndex(int record);
            /*0x20fadfc*/ int InsertRecord(int record, bool fireEvent);
            /*0x20fc9d4*/ bool IsKeyInIndex(object key);
            /*0x20fc9f0*/ bool IsKeyInIndex(object[] key);
            /*0x20fca0c*/ bool IsKeyRecordInIndex(int record);
            /*0x20fc4e4*/ bool get_DoListChanged();
            /*0x20fca28*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int newIndex, int oldIndex);
            /*0x20fb874*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int index);
            /*0x20fc568*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x20fb740*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, int record, bool trackAddRemove);
            /*0x20fcad0*/ void Reset();
            /*0x20fcba4*/ void RecordChanged(int record);
            /*0x20fcc94*/ void RecordChanged(int oldIndex, int newIndex);
            /*0x20fcdd4*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x20fcee8*/ void RecordStateChanged(int oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, int newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState);
            /*0x20fd274*/ System.Data.DataTable get_Table();
            /*0x20fbad0*/ void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId);

            class IndexTree : System.Data.RBTree<int>
            {
                /*0x40*/ System.Data.Index _index;

                /*0x2ae58f8*/ IndexTree(System.Data.Index index);
                /*0x2ae595c*/ int CompareNode(int record1, int record2);
                /*0x2ae5978*/ int CompareSateliteTreeNode(int record1, int record2);
            }

            class <>c
            {
                static /*0x0*/ System.Data.Index.<> <>9;
                static /*0x8*/ System.Data.Listeners.Func<System.Data.DataViewListener, System.Data.DataViewListener, bool> <>9__22_0;
                static /*0x10*/ System.Data.Listeners.Action<System.Data.DataViewListener, System.Data.DataViewListener, System.ComponentModel.ListChangedEventArgs, bool, bool> <>9__85_0;

                static /*0x2ae5830*/ <>c();
                /*0x2ae5890*/ <>c();
                /*0x2ae5898*/ bool <.ctor>b__22_0(System.Data.DataViewListener listener);
                /*0x2ae58a4*/ void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, bool arg2, bool arg3);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ System.ComponentModel.ListChangedType changedType;

                /*0x2ae58c4*/ <>c__DisplayClass86_0();
                /*0x2ae58cc*/ void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, bool track);
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
                System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }

            class Func`2<TElem, T1, TResult> : System.MulticastDelegate
            {
                Func`2(object object, nint method);
                TResult Invoke(T1 arg1);
                System.IAsyncResult BeginInvoke(T1 arg1, System.AsyncCallback callback, object object);
                TResult EndInvoke(System.IAsyncResult result);
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

            static /*0x1ed5030*/ System.Data.SimpleType CreateEnumeratedType(string values);
            static /*0x1ed50ac*/ System.Data.SimpleType CreateByteArrayType(string encoding);
            static /*0x1ed5118*/ System.Data.SimpleType CreateLimitedStringType(int length);
            static /*0x1ed5194*/ System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type);
            /*0x1ed3e60*/ SimpleType(string baseType);
            /*0x1ed3f34*/ SimpleType(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x1ed48f0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1ed40a4*/ void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x1ed4930*/ bool IsPlainString();
            /*0x1ed4a74*/ string get_BaseType();
            /*0x1ed4a7c*/ System.Xml.XmlQualifiedName get_XmlBaseType();
            /*0x1ed4a84*/ string get_Name();
            /*0x1ed4a8c*/ string get_Namespace();
            /*0x1ed4a94*/ int get_Length();
            /*0x1ed4a9c*/ int get_MaxLength();
            /*0x1ed4aa4*/ void set_MaxLength(int value);
            /*0x1ed4aac*/ System.Data.SimpleType get_BaseSimpleType();
            /*0x1ed4ab4*/ string get_SimpleTypeQualifiedName();
            /*0x1ed4b28*/ string QualifiedName(string name);
            /*0x1ed4ba8*/ System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, bool inRemoting);
            /*0x1ed5298*/ string HasConflictingDefinition(System.Data.SimpleType otherSimpleType);
            /*0x1ed53a4*/ bool CanHaveMaxLength();
            /*0x1ed540c*/ void ConvertToAnnonymousSimpleType();
        }

        class UniqueConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.DataKey _key;
            /*0x40*/ System.Data.Index _constraintIndex;
            /*0x48*/ bool _bPrimaryKey;
            /*0x50*/ string _constraintName;
            /*0x58*/ string[] _columnNames;

            /*0x1daf2d4*/ UniqueConstraint(System.Data.DataColumn column);
            /*0x1daf498*/ UniqueConstraint(string name, System.Data.DataColumn[] columns);
            /*0x1daf4d8*/ UniqueConstraint(System.Data.DataColumn[] columns);
            /*0x1daf50c*/ UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey);
            /*0x1daf550*/ UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey);
            /*0x1daf59c*/ string[] get_ColumnNames();
            /*0x1daf5a8*/ System.Data.Index get_ConstraintIndex();
            /*0x1daf5b0*/ void ConstraintIndexClear();
            /*0x1daf5e0*/ void ConstraintIndexInitialize();
            /*0x1daf62c*/ void CheckState();
            /*0x1daf638*/ void NonVirtualCheckState();
            /*0x1daf644*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x1daf648*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x1daf7b8*/ bool CanEnableConstraint();
            /*0x1daf810*/ bool IsConstraintViolated();
            /*0x1dafaa0*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1dafbb0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x1dafbbc*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x1dafbcc*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x1db00ec*/ System.Data.UniqueConstraint Clone(System.Data.DataTable table);
            /*0x1db0578*/ System.Data.DataColumn[] get_Columns();
            /*0x1dafba8*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x1db0584*/ bool get_IsPrimaryKey();
            /*0x1daf390*/ void Create(string constraintName, System.Data.DataColumn[] columns);
            /*0x1db05d4*/ bool Equals(object key2);
            /*0x1db0690*/ int GetHashCode();
            /*0x1db0698*/ void set_InCollection(bool value);
            /*0x1db06ec*/ System.Data.DataKey get_Key();
            /*0x1db06f4*/ System.Data.DataTable get_Table();
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

            static /*0x1db3418*/ XDRSchema();
            static /*0x1db1c40*/ System.Data.XDRSchema.NameType FindNameType(string name);
            /*0x1db0810*/ XDRSchema(System.Data.DataSet ds, bool fInline);
            /*0x1db0894*/ void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds);
            /*0x1db0d10*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node);
            /*0x1db1040*/ bool IsTextOnlyContent(System.Xml.XmlElement node);
            /*0x1db1214*/ bool IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x1db0b2c*/ System.Data.DataTable HandleTable(System.Xml.XmlElement node);
            /*0x1db1d38*/ System.Type ParseDataType(string dt, string dtValues);
            /*0x1db1e88*/ string GetInstanceName(System.Xml.XmlElement node);
            /*0x1db1ffc*/ void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table);
            /*0x1db136c*/ void GetMinMax(System.Xml.XmlElement elNode, ref int minOccurs, ref int maxOccurs);
            /*0x1db2a08*/ void GetMinMax(System.Xml.XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs);
            /*0x1db322c*/ void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren);
            /*0x1db15c4*/ System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x1db137c*/ System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x2ae5be4*/ NameType(string n, System.Type t);
                /*0x2ae5c1c*/ int CompareTo(object obj);
            }
        }

        class XMLDiffLoader
        {
            /*0x10*/ System.Collections.ArrayList _tables;
            /*0x18*/ System.Data.DataSet _dataSet;
            /*0x20*/ System.Data.DataTable _dataTable;

            /*0x1db6c48*/ XMLDiffLoader();
            /*0x1db45f8*/ void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader);
            /*0x1db4e50*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x1db51a0*/ void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader);
            /*0x1db47a0*/ void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x1db539c*/ void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync);
            /*0x1db4a88*/ void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x1db5678*/ void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync);
            /*0x1db6a70*/ System.Data.DataTable GetTable(string tableName, string ns);
            /*0x1db5bb4*/ int ReadOldRowData(System.Data.DataSet ds, ref System.Data.DataTable table, ref int pos, System.Xml.XmlReader row);
            /*0x1db5b48*/ void SkipWhitespaces(System.Xml.XmlReader reader);
        }

        class XMLSchema
        {
            static /*0x1db6c50*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x1db2dac*/ void SetProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x1db0aac*/ bool FEqualIdentity(System.Xml.XmlNode node, string name, string ns);
            static /*0x1db6cb4*/ bool GetBooleanAttribute(System.Xml.XmlElement element, string attrName, string attrNS, bool defVal);
            static /*0x1db28d4*/ string GenUniqueColumnName(string proposedName, System.Data.DataTable table);
            /*0x1db088c*/ XMLSchema();
        }

        class ConstraintTable
        {
            /*0x10*/ System.Data.DataTable table;
            /*0x18*/ System.Xml.Schema.XmlSchemaIdentityConstraint constraint;

            /*0x21ca484*/ ConstraintTable(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c);
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

            static /*0x1dc5a3c*/ XSDSchema();
            static /*0x1db78dc*/ string QualifiedName(string name);
            static /*0x1db795c*/ void SetProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x1db7ee0*/ void SetExtProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x1db77a8*/ string GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, string ln);
            static /*0x1db8494*/ void SetExtProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x1dc2134*/ System.Data.AcceptRejectRule TranslateAcceptRejectRule(string strRule);
            static /*0x1dc21bc*/ System.Data.Rule TranslateRule(string strRule);
            static /*0x1dc50a0*/ System.Type XsdtoClr(string xsdTypeName);
            static /*0x1dc51a0*/ System.Data.XSDSchema.NameType FindNameType(string name);
            static /*0x1dc5414*/ bool IsXsdType(string name);
            /*0x1dc5a34*/ XSDSchema();
            /*0x1db6e10*/ bool get_FromInference();
            /*0x1db6e18*/ void set_FromInference(bool value);
            /*0x1db6e24*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema);
            /*0x1db6eb0*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList);
            /*0x1db828c*/ void HandleColumnExpression(object instance, System.Xml.XmlAttribute[] attrs);
            /*0x1db86ec*/ void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element);
            /*0x1db88c8*/ void HandleRelation(System.Xml.XmlElement node, bool fNested);
            /*0x1db90e8*/ bool HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
            /*0x1db9350*/ bool IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x1db9d50*/ int DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x1dba0b0*/ System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x1dba66c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt);
            /*0x1dba68c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds);
            /*0x1dbdb0c*/ void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, bool fNested);
            /*0x1db98b8*/ System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x1dbde00*/ void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isBase);
            /*0x1dbf520*/ void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, bool isBase);
            /*0x1dc01d8*/ void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, bool isBase);
            /*0x1dc0564*/ void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isNillable);
            /*0x1dba524*/ System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct);
            /*0x1dc1cdc*/ System.Data.DataColumn FindField(System.Data.DataTable table, string field);
            /*0x1dc1ea4*/ System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table);
            /*0x1db9f4c*/ bool GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, bool defVal);
            /*0x1dbc4ac*/ string GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, string defVal);
            /*0x1dc22ac*/ void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref);
            /*0x1dc2b94*/ void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode);
            /*0x1dc2ff4*/ System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x1db87ec*/ string GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x1dc3af8*/ System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, bool isRef);
            /*0x1dc5298*/ System.Type ParseDataType(string dt);
            /*0x1dbc53c*/ System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x1dc1320*/ void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x1dc0b64*/ void HandleSimpleContentColumn(string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x1dbf7cc*/ void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, bool isBase);
            /*0x1dbe780*/ void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, bool isBase);
            /*0x1dbc9ec*/ void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, bool isNewDataSet);
            /*0x1dc5490*/ void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt);
            /*0x1dc36f0*/ string GetPrefix(string ns);
            /*0x1dc5624*/ string GetNamespaceFromPrefix(string prefix);
            /*0x1dc4ec4*/ string GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x1dc2a68*/ string GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x1db9ac8*/ bool IsTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x1dbc860*/ System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x2ae5c98*/ NameType(string n, System.Type t);
                /*0x2ae5cd0*/ int CompareTo(object obj);
            }
        }

        class XmlIgnoreNamespaceReader : System.Xml.XmlNodeReader
        {
            /*0x30*/ System.Collections.Generic.List<string> _namespacesToIgnore;

            /*0x254003c*/ XmlIgnoreNamespaceReader(System.Xml.XmlDocument xdoc, string[] namespacesToIgnore);
            /*0x25400d0*/ bool MoveToFirstAttribute();
            /*0x25401e4*/ bool MoveToNextAttribute();
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

            /*0x2536abc*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, bool ignoreSchema);
            /*0x2536b54*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x2536c24*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, bool ignoreSchema);
            /*0x2536cc8*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x2536da4*/ bool get_FromInference();
            /*0x2536dac*/ void set_FromInference(bool value);
            /*0x2536db8*/ void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x2536fc4*/ int CountNonNSAttributes(System.Xml.XmlNode node);
            /*0x2537158*/ string GetValueForTextOnlyColums(System.Xml.XmlNode n);
            /*0x2537388*/ string GetInitialTextFromNodes(ref System.Xml.XmlNode n);
            /*0x2537568*/ System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row);
            /*0x2536f20*/ System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e);
            /*0x2537630*/ bool FColumnElement(System.Xml.XmlElement e);
            /*0x25370bc*/ bool FExcludedNamespace(string ns);
            /*0x2537724*/ bool FIgnoreNamespace(System.Xml.XmlNode node);
            /*0x25379fc*/ bool FIgnoreNamespace(System.Xml.XmlReader node);
            /*0x253732c*/ bool IsTextLikeNode(System.Xml.XmlNodeType n);
            /*0x2537600*/ bool IsTextOnly(System.Data.DataColumn c);
            /*0x2537a90*/ void LoadData(System.Xml.XmlDocument xdoc);
            /*0x2537efc*/ void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement);
            /*0x2538b10*/ void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x2538e5c*/ void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, string xmlText);
            /*0x2538ed4*/ void InitNameTable();
            /*0x2539134*/ void LoadData(System.Xml.XmlReader reader);
            /*0x25394e4*/ void LoadTopMostTable(System.Data.DataTable table);
            /*0x253a0c0*/ void LoadTable(System.Data.DataTable table, bool isNested);
            /*0x253af44*/ void LoadColumn(System.Data.DataColumn column, object[] foundColumns);
            /*0x2539ea8*/ bool ProcessXsdSchema();
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

            static /*0x2538ea8*/ bool IsMappedColumn(System.Data.DataColumn c);
            /*0x2537dc8*/ XmlToDatasetMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x2539464*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x2537d88*/ XmlToDatasetMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x25394a4*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x2542218*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable);
            /*0x2542344*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table);
            /*0x25424c0*/ bool AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x2542768*/ bool AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x25402fc*/ void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x25408fc*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x2541408*/ void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x254172c*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x2542924*/ System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt);
            /*0x2537814*/ object GetColumnSchema(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x253ae14*/ object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, bool fIgnoreNamespace);
            /*0x2537e08*/ object GetSchemaForNode(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x2539de4*/ System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, bool fIgnoreNamespace);
            /*0x25425fc*/ void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);

            class XmlNodeIdentety
            {
                /*0x10*/ string LocalName;
                /*0x18*/ string NamespaceURI;

                /*0x2ae5e80*/ XmlNodeIdentety(string localName, string namespaceURI);
                /*0x2ae60b8*/ int GetHashCode();
                /*0x2ae60d8*/ bool Equals(object obj);
            }

            class XmlNodeIdHashtable : System.Collections.Hashtable
            {
                /*0x50*/ System.Data.XmlToDatasetMap.XmlNodeIdentety _id;

                /*0x2ae5de8*/ XmlNodeIdHashtable(int capacity);
                /*0x2ae5eb8*/ object get_Item(System.Xml.XmlNode node);
                /*0x2ae5f3c*/ object get_Item(System.Xml.XmlReader dataReader);
                /*0x2ae5fb8*/ object get_Item(System.Data.DataTable table);
                /*0x2ae602c*/ object get_Item(string name);
            }

            class TableSchemaInfo
            {
                /*0x10*/ System.Data.DataTable TableSchema;
                /*0x18*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;

                /*0x2ae5d4c*/ TableSchemaInfo(System.Data.DataTable tableSchema);
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

            static /*0x2542d38*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node);
            static /*0x2542d40*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type);
            static /*0x253f224*/ string XmlDataTypeName(System.Type type);
            static /*0x2544ae4*/ bool _PropsNotEmpty(System.Data.PropertyCollection props);
            static /*0x253f0c8*/ void ValidateColumnMapping(System.Type columnType);
            static /*0x254d4b4*/ System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, string name);
            static /*0x254f234*/ string TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule);
            static /*0x254f2a4*/ string TranslateRule(System.Data.Rule rule);
            static /*0x2545cb0*/ bool AutoGenerated(System.Data.DataColumn col);
            static /*0x254f6d8*/ bool AutoGenerated(System.Data.DataRelation rel);
            static /*0x25461f8*/ bool AutoGenerated(System.Data.UniqueConstraint unique);
            static /*0x254f7c0*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk, bool checkRelation);
            /*0x253ed04*/ XmlTreeGen(System.Data.SchemaFormat format);
            /*0x25434e8*/ void AddXdoProperties(object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x25436ac*/ void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x2544244*/ void GenerateConstraintNames(System.Data.DataTable table, bool fromTable);
            /*0x2544740*/ void GenerateConstraintNames(System.Collections.ArrayList tables);
            /*0x254483c*/ void GenerateConstraintNames(System.Data.DataSet ds);
            /*0x2544b10*/ bool HaveExtendedProperties(System.Data.DataSet ds);
            /*0x2544c98*/ void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, string targetNamespace);
            /*0x2544ef4*/ void SetupAutoGenerated(System.Data.DataSet ds);
            /*0x2545bb8*/ void SetupAutoGenerated(System.Collections.ArrayList dt);
            /*0x2545198*/ void SetupAutoGenerated(System.Data.DataTable dt);
            /*0x25462d8*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x2546628*/ void CreateRelations(System.Data.DataTable dt);
            /*0x2546944*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x2546c68*/ void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, bool writeHierarchy);
            /*0x254a178*/ System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt);
            /*0x2549468*/ System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt);
            /*0x254d0a8*/ void SetPath(System.Xml.XmlWriter xw);
            /*0x253ed9c*/ void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw);
            /*0x254d29c*/ void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x254d290*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x253edb0*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy);
            /*0x254d360*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x2549ba0*/ System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc);
            /*0x254d5ac*/ System.Xml.XmlElement GetSchema(string NamespaceURI);
            /*0x254d854*/ void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema);
            /*0x254dd00*/ void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root);
            /*0x254e3b8*/ string FindTargetNamespace(System.Data.DataTable table);
            /*0x254e4d4*/ System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool fWriteOrdinal);
            /*0x2549ae4*/ void AppendChildWithoutRef(System.Xml.XmlElement node, string Namespace, System.Xml.XmlElement el, string refString);
            /*0x254f060*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, string strType);
            /*0x2549adc*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema);
            /*0x254f35c*/ bool HasMixedColumns(System.Data.DataTable table);
            /*0x25461ec*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk);
            /*0x254f918*/ bool IsAutoGenerated(object o);
            /*0x254a5c8*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool genNested);
            /*0x2544028*/ void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type);
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

            static /*0x2107a94*/ string QualifiedName(string prefix, string name);
            /*0x2105788*/ NewDiffgramGen(System.Data.DataSet ds);
            /*0x2105b14*/ NewDiffgramGen(System.Data.DataTable dt, bool writeHierarchy);
            /*0x2105bfc*/ void CreateTableHierarchy(System.Data.DataTable dt);
            /*0x210589c*/ void DoAssignments(System.Collections.ArrayList tables);
            /*0x2105f4c*/ bool EmptyData();
            /*0x2106044*/ void Save(System.Xml.XmlWriter xmlw);
            /*0x210604c*/ void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table);
            /*0x2106454*/ void GenerateTable(System.Data.DataTable table);
            /*0x21064d4*/ void GenerateTableErrors(System.Data.DataTable table);
            /*0x2106a4c*/ void GenerateRow(System.Data.DataRow row);
            /*0x2107008*/ void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version);
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

            static /*0x253c3d8*/ bool RowHasErrors(System.Data.DataRow row);
            static /*0x253f15c*/ bool PreserveSpace(object value);
            /*0x253b900*/ XmlDataTreeWriter(System.Data.DataSet ds);
            /*0x253bc08*/ XmlDataTreeWriter(System.Data.DataTable dt, bool writeHierarchy);
            /*0x253c0b4*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x253bd64*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x253c4ac*/ void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder);
            /*0x253e454*/ void Save(System.Xml.XmlWriter xw, bool writeSchema);
            /*0x253edbc*/ System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row);
            /*0x253cb10*/ void XmlDataRowWriter(System.Data.DataRow row, string encodedTableName);
        }

        class DataTextWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter _xmltextWriter;

            static /*0x201c608*/ System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw);
            /*0x201c668*/ DataTextWriter(System.Xml.XmlWriter w);
            /*0x201c694*/ System.IO.Stream get_BaseStream();
            /*0x201c72c*/ void WriteStartDocument();
            /*0x201c74c*/ void WriteStartDocument(bool standalone);
            /*0x201c770*/ void WriteEndDocument();
            /*0x201c790*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x201c7b0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x201c7d0*/ void WriteEndElement();
            /*0x201c7f0*/ void WriteFullEndElement();
            /*0x201c810*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x201c830*/ void WriteEndAttribute();
            /*0x201c854*/ void WriteCData(string text);
            /*0x201c878*/ void WriteComment(string text);
            /*0x201c89c*/ void WriteProcessingInstruction(string name, string text);
            /*0x201c8c0*/ void WriteEntityRef(string name);
            /*0x201c8e4*/ void WriteCharEntity(char ch);
            /*0x201c908*/ void WriteWhitespace(string ws);
            /*0x201c92c*/ void WriteString(string text);
            /*0x201c950*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x201c974*/ void WriteChars(char[] buffer, int index, int count);
            /*0x201c998*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x201c9bc*/ void WriteRaw(string data);
            /*0x201c9e0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x201ca04*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x201ca28*/ System.Xml.WriteState get_WriteState();
            /*0x201ca4c*/ void Close();
            /*0x201ca70*/ void Flush();
            /*0x201ca94*/ string LookupPrefix(string ns);
        }

        class DataTextReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader _xmlreader;

            static /*0x201c068*/ System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr);
            /*0x201c0c4*/ DataTextReader(System.Xml.XmlReader input);
            /*0x201c13c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x201c15c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x201c17c*/ string get_Name();
            /*0x201c19c*/ string get_LocalName();
            /*0x201c1bc*/ string get_NamespaceURI();
            /*0x201c1dc*/ string get_Prefix();
            /*0x201c1fc*/ string get_Value();
            /*0x201c21c*/ int get_Depth();
            /*0x201c23c*/ string get_BaseURI();
            /*0x201c260*/ bool get_IsEmptyElement();
            /*0x201c284*/ bool get_IsDefault();
            /*0x201c2a8*/ char get_QuoteChar();
            /*0x201c2cc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x201c2f0*/ string get_XmlLang();
            /*0x201c314*/ int get_AttributeCount();
            /*0x201c338*/ string GetAttribute(string name);
            /*0x201c35c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x201c380*/ string GetAttribute(int i);
            /*0x201c3a4*/ bool MoveToAttribute(string name);
            /*0x201c3c8*/ void MoveToAttribute(int i);
            /*0x201c3ec*/ bool MoveToFirstAttribute();
            /*0x201c410*/ bool MoveToNextAttribute();
            /*0x201c434*/ bool MoveToElement();
            /*0x201c458*/ bool ReadAttributeValue();
            /*0x201c47c*/ bool Read();
            /*0x201c4a0*/ bool get_EOF();
            /*0x201c4c4*/ void Close();
            /*0x201c4e8*/ System.Xml.ReadState get_ReadState();
            /*0x201c50c*/ void Skip();
            /*0x201c530*/ System.Xml.XmlNameTable get_NameTable();
            /*0x201c554*/ string LookupNamespace(string prefix);
            /*0x201c578*/ bool get_CanResolveEntity();
            /*0x201c59c*/ void ResolveEntity();
            /*0x201c5c0*/ bool get_CanReadValueChunk();
            /*0x201c5e4*/ string ReadString();
        }

        namespace SqlTypes
        {
            class SQLResource
            {
                static /*0x1ed3868*/ string get_NullString();
                static /*0x1ed38ac*/ string get_ArithOverflowMessage();
                static /*0x1ed38f0*/ string get_DivideByZeroMessage();
                static /*0x1ed3934*/ string get_NullValueMessage();
                static /*0x1ed3978*/ string get_TruncationMessage();
                static /*0x1ed39bc*/ string get_DateTimeOverflowMessage();
                static /*0x1ed3a00*/ string get_ConcatDiffCollationMessage();
                static /*0x1ed3a44*/ string get_CompareDiffCollationMessage();
                static /*0x1ed3a88*/ string get_ConversionOverflowMessage();
                static /*0x1ed3acc*/ string get_TimeZoneSpecifiedMessage();
                static /*0x1ed3b10*/ string get_InvalidPrecScaleMessage();
                static /*0x1ed3b54*/ string get_FormatMessage();
                static /*0x1ed3b98*/ string InvalidOpStreamClosed(string method);
                static /*0x1ed3c60*/ string InvalidOpStreamNonWritable(string method);
                static /*0x1ed3cac*/ string InvalidOpStreamNonReadable(string method);
                static /*0x1ed3cf8*/ string InvalidOpStreamNonSeekable(string method);
            }

            interface INullable
            {
                bool get_IsNull();
            }

            struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBinary Null;
                /*0x10*/ byte[] _value;

                static /*0x1ed760c*/ SqlBinary();
                static /*0x1ed687c*/ System.Data.SqlTypes.SqlBinary op_Implicit(byte[] x);
                static /*0x1ed69a8*/ System.Data.SqlTypes.EComparison PerformCompareByte(byte[] x, byte[] y);
                static /*0x1ed6ab4*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x1ed6bb8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x1ed6ca8*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x1ed714c*/ int HashByteArray(byte[] rgbValue, int length);
                static /*0x1ed7584*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xade4ec*/ SqlBinary(bool fNull);
                /*0xade4f4*/ SqlBinary(byte[] value);
                /*0xade4fc*/ bool get_IsNull();
                /*0xade50c*/ byte[] get_Value();
                /*0xade514*/ string ToString();
                /*0xade51c*/ int CompareTo(object value);
                /*0xade524*/ int CompareTo(System.Data.SqlTypes.SqlBinary value);
                /*0xade52c*/ bool Equals(object value);
                /*0xade534*/ int GetHashCode();
                /*0xade53c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xade544*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xade54c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBoolean True;
                static /*0x1*/ System.Data.SqlTypes.SqlBoolean False;
                static /*0x2*/ System.Data.SqlTypes.SqlBoolean Null;
                static /*0x3*/ System.Data.SqlTypes.SqlBoolean Zero;
                static /*0x4*/ System.Data.SqlTypes.SqlBoolean One;
                /*0x10*/ byte m_value;

                static /*0x1ed9154*/ SqlBoolean();
                static /*0x1ed876c*/ System.Data.SqlTypes.SqlBoolean op_Implicit(bool x);
                static /*0x1ed7010*/ bool op_True(System.Data.SqlTypes.SqlBoolean x);
                static /*0x1ed877c*/ System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x1ed8870*/ System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x1ed8a24*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x1ed8ac0*/ System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x1ed8b38*/ System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x1ed90cc*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xade554*/ SqlBoolean(bool value);
                /*0xade568*/ SqlBoolean(int value);
                /*0xade57c*/ SqlBoolean(int value, bool fNull);
                /*0xade598*/ bool get_IsNull();
                /*0xade5a8*/ bool get_Value();
                /*0xade5b0*/ bool get_IsTrue();
                /*0xade5c0*/ bool get_IsFalse();
                /*0xade5d0*/ byte get_ByteValue();
                /*0xade5d8*/ string ToString();
                /*0xade5e0*/ int CompareTo(object value);
                /*0xade5e8*/ int CompareTo(System.Data.SqlTypes.SqlBoolean value);
                /*0xade5f4*/ bool Equals(object value);
                /*0xade5fc*/ int GetHashCode();
                /*0xade604*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xade60c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xade614*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x1edb54c*/ SqlByte();
                static /*0x1eda574*/ System.Data.SqlTypes.SqlByte op_Implicit(byte x);
                static /*0x1eda5e0*/ System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1eda6fc*/ System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1eda818*/ System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1eda934*/ System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edaa1c*/ System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x1edab34*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edabd4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edac74*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edad14*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edad8c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x1edb4c4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xade650*/ SqlByte(bool fNull);
                /*0xade658*/ SqlByte(byte value);
                /*0xade668*/ bool get_IsNull();
                /*0xade678*/ byte get_Value();
                /*0xade680*/ string ToString();
                /*0xade688*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xade690*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0xade698*/ int CompareTo(object value);
                /*0xade6a0*/ int CompareTo(System.Data.SqlTypes.SqlByte value);
                /*0xade6ac*/ bool Equals(object value);
                /*0xade6b4*/ int GetHashCode();
                /*0xade6bc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xade6c4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xade6cc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x1eddb0c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x1eddbd4*/ System.Data.SqlTypes.SqlBytes get_Null();
                /*0x1edd2a4*/ SqlBytes();
                /*0x1edd2e4*/ SqlBytes(byte[] buffer);
                /*0x1edd338*/ SqlBytes(System.Data.SqlTypes.SqlBinary value);
                /*0x1edd374*/ bool get_IsNull();
                /*0x1edd384*/ byte[] get_Buffer();
                /*0x1edd514*/ long get_Length();
                /*0x1edd594*/ byte[] get_Value();
                /*0x1edd2d4*/ void SetNull();
                /*0x1edd3c8*/ void CopyStreamToBuffer();
                /*0x1edd3b8*/ bool FStream();
                /*0x1edd77c*/ void SetBuffer(byte[] buffer);
                /*0x1edd7a4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1edd7ac*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x1edd9cc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x1eddb94*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class SqlChars : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ char[] _rgchBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.Data.SqlTypes.SqlStreamChars _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ char[] _rgchWorkBuf;

                static /*0x1edf164*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x1edf22c*/ System.Data.SqlTypes.SqlChars get_Null();
                /*0x1edea08*/ SqlChars();
                /*0x1edea48*/ SqlChars(char[] buffer);
                /*0x1edea9c*/ SqlChars(System.Data.SqlTypes.SqlString value);
                /*0x1edeaf8*/ bool get_IsNull();
                /*0x1edeb08*/ char[] get_Buffer();
                /*0x1edec90*/ long get_Length();
                /*0x1eded10*/ char[] get_Value();
                /*0x1edea38*/ void SetNull();
                /*0x1edeb3c*/ bool FStream();
                /*0x1edeb4c*/ void CopyStreamToBuffer();
                /*0x1edeef0*/ void SetBuffer(char[] buffer);
                /*0x1edef18*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x1edef20*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x1edf054*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x1edf1ec*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x1ee8a04*/ SqlDateTime();
                static /*0x1ee7a1c*/ System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value);
                static /*0x1ee7ad4*/ System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value);
                static /*0x1ee7b6c*/ System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value);
                static /*0x1ee77c8*/ System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value);
                static /*0x1ee30f4*/ System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value);
                static /*0x1ee7ef0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1ee7fa4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1ee8064*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1ee8124*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1ee81b4*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x1ee897c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xade718*/ SqlDateTime(bool fNull);
                /*0xade724*/ SqlDateTime(System.DateTime value);
                /*0xade72c*/ SqlDateTime(int dayTicks, int timeTicks);
                /*0xade734*/ bool get_IsNull();
                /*0xade744*/ System.DateTime get_Value();
                /*0xade74c*/ int get_DayTicks();
                /*0xade754*/ int get_TimeTicks();
                /*0xade75c*/ string ToString();
                /*0xade764*/ int CompareTo(object value);
                /*0xade76c*/ int CompareTo(System.Data.SqlTypes.SqlDateTime value);
                /*0xade778*/ bool Equals(object value);
                /*0xade780*/ int GetHashCode();
                /*0xade788*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xade790*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xade798*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x1eef704*/ SqlDecimal();
                static /*0x1ee6f60*/ System.Data.SqlTypes.SqlDecimal Parse(string s);
                static /*0x1ee1c78*/ System.Data.SqlTypes.SqlDecimal op_Implicit(decimal x);
                static /*0x1ee1d44*/ System.Data.SqlTypes.SqlDecimal op_Implicit(long x);
                static /*0x1eebe24*/ System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x);
                static /*0x1eebf18*/ System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eeca2c*/ System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eecb18*/ System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eed4a0*/ System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1ee1ef8*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x1ee1d90*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x1ee1e44*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x1ee1c90*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x1ee1fac*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x1eee1d0*/ void ZeroToMaxLen(uint[] rgulData, int cUI4sCur);
                static /*0x1eeaa50*/ byte BGetPrecUI4(uint value);
                static /*0x1eead0c*/ byte BGetPrecUI8(ulong dwlVal);
                static /*0x1eee4f0*/ void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, ref int ciulD);
                static /*0x1eee560*/ void MpSet(uint[] rgulD, ref int ciulD, uint iulN);
                static /*0x1eee598*/ void MpNormalize(uint[] rgulU, ref int ciulU);
                static /*0x1eee5f0*/ void MpMul1(uint[] piulD, ref int ciulD, uint iulX);
                static /*0x1eeb7a4*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
                static /*0x1eee704*/ ulong DWL(uint lo, uint hi);
                static /*0x1eee6f8*/ uint HI(ulong x);
                static /*0x1eee700*/ uint LO(ulong x);
                static /*0x1eed8d8*/ void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, ref int ciulQ, uint[] rgulR, ref int ciulR);
                static /*0x1eeb1f4*/ void CheckValidPrecScale(byte bPrec, byte bScale);
                static /*0x1eee900*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eee9c4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eeea88*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eeeb4c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eeec0c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x1eeb8a0*/ char ChFromDigit(uint uiDigit);
                static /*0x1eef67c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xade7b0*/ SqlDecimal(bool fNull);
                /*0xade7bc*/ SqlDecimal(decimal value);
                /*0xade7c4*/ SqlDecimal(int value);
                /*0xade7cc*/ SqlDecimal(long value);
                /*0xade7d4*/ SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive);
                /*0xade7a0*/ byte CalculatePrecision();
                /*0xade7a8*/ bool VerifyPrecision(byte precision);
                /*0xade7e0*/ bool get_IsNull();
                /*0xade7e8*/ decimal get_Value();
                /*0xade7f0*/ bool get_IsPositive();
                /*0xade7f8*/ void SetPositive();
                /*0xade800*/ void SetSignBit(bool fPositive);
                /*0xade80c*/ byte get_Scale();
                /*0xade814*/ int[] get_Data();
                /*0xade81c*/ string ToString();
                /*0xade824*/ double ToDouble();
                /*0xade82c*/ decimal ToDecimal();
                /*0xade834*/ bool FZero();
                /*0xade854*/ bool FGt10_38();
                /*0xade8c8*/ bool FGt10_38(uint[] rglData);
                /*0xade8cc*/ void AddULong(uint ulAdd);
                /*0xade8d4*/ void MultByULong(uint uiMultiplier);
                /*0xade8dc*/ uint DivByULong(uint iDivisor);
                /*0xade8e4*/ void AdjustScale(int digits, bool fRound);
                /*0xade8f0*/ int LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0xade924*/ System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0xade958*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xade960*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0xade968*/ System.Data.SqlTypes.SqlMoney ToSqlMoney();
                /*0xade970*/ void StoreFromWorkingArray(uint[] rguiData);
                /*0xade978*/ void SetToZero();
                /*0xade980*/ int CompareTo(object value);
                /*0xade988*/ int CompareTo(System.Data.SqlTypes.SqlDecimal value);
                /*0xade9bc*/ bool Equals(object value);
                /*0xade9c4*/ int GetHashCode();
                /*0xade9cc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xade9d4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xade9dc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlDouble Null;
                static /*0x10*/ System.Data.SqlTypes.SqlDouble Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlDouble MinValue;
                static /*0x30*/ System.Data.SqlTypes.SqlDouble MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ double m_value;

                static /*0x2110e7c*/ SqlDouble();
                static /*0x210e8f8*/ System.Data.SqlTypes.SqlDouble op_Implicit(double x);
                static /*0x210fd0c*/ System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x);
                static /*0x210e920*/ System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x210ebb8*/ System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x210ea6c*/ System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x210ed04*/ System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x210fdb0*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x210fe5c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x210ff5c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x2110058*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x2110154*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x);
                static /*0x2110250*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x2110374*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x2110418*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x210ee88*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x21104d8*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x2110598*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x2110628*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x2110df4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae1380*/ SqlDouble(bool fNull);
                /*0xae138c*/ SqlDouble(double value);
                /*0xae1394*/ bool get_IsNull();
                /*0xae13a4*/ double get_Value();
                /*0xae13ac*/ string ToString();
                /*0xae13b4*/ System.Data.SqlTypes.SqlSingle ToSqlSingle();
                /*0xae13bc*/ int CompareTo(object value);
                /*0xae13c4*/ int CompareTo(System.Data.SqlTypes.SqlDouble value);
                /*0xae13cc*/ bool Equals(object value);
                /*0xae13d4*/ int GetHashCode();
                /*0xae13dc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae13e4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae13ec*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_sizeOfGuid;
                static /*0x8*/ int[] s_rgiGuidOrder;
                static /*0x10*/ System.Data.SqlTypes.SqlGuid Null;
                /*0x10*/ byte[] m_value;

                static /*0x211348c*/ SqlGuid();
                static /*0x21129fc*/ System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x);
                static /*0x2112a6c*/ System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x2112b80*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x2112c58*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x2112d30*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x2113404*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae14b0*/ SqlGuid(bool fNull);
                /*0xae14b8*/ SqlGuid(System.Guid g);
                /*0xae14f0*/ bool get_IsNull();
                /*0xae1500*/ System.Guid get_Value();
                /*0xae1508*/ string ToString();
                /*0xae1510*/ int CompareTo(object value);
                /*0xae1518*/ int CompareTo(System.Data.SqlTypes.SqlGuid value);
                /*0xae1520*/ bool Equals(object value);
                /*0xae1528*/ int GetHashCode();
                /*0xae1530*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae1538*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae1540*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x21155a8*/ SqlInt16();
                static /*0x21143d8*/ System.Data.SqlTypes.SqlInt16 op_Implicit(short x);
                static /*0x2114408*/ System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x);
                static /*0x211449c*/ System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114598*/ System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114694*/ System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x21147e4*/ System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x211492c*/ System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x21149d4*/ System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x2114ac8*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114b74*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114c20*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114ccc*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2114d44*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x2115520*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae157c*/ SqlInt16(bool fNull);
                /*0xae1588*/ SqlInt16(short value);
                /*0xae1598*/ bool get_IsNull();
                /*0xae15a8*/ short get_Value();
                /*0xae15b0*/ string ToString();
                /*0xae15b8*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xae15c0*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0xae15c8*/ int CompareTo(object value);
                /*0xae15d0*/ int CompareTo(System.Data.SqlTypes.SqlInt16 value);
                /*0xae15dc*/ bool Equals(object value);
                /*0xae15e4*/ int GetHashCode();
                /*0xae15ec*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae15f4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae15fc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x2118714*/ SqlInt32();
                static /*0x21173e4*/ System.Data.SqlTypes.SqlInt32 op_Implicit(int x);
                static /*0x2117414*/ System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x);
                static /*0x21174a8*/ System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x21175f4*/ System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117730*/ System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117880*/ System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x21179e8*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x2117a90*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x2117b38*/ System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x21175e4*/ bool SameSignInt(int x, int y);
                static /*0x2117c2c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117cdc*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117d8c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117e3c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x2117eb4*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x211868c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae1638*/ SqlInt32(bool fNull);
                /*0xae1644*/ SqlInt32(int value);
                /*0xae1654*/ bool get_IsNull();
                /*0xae1664*/ int get_Value();
                /*0xae166c*/ string ToString();
                /*0xae1674*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xae167c*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0xae1684*/ int CompareTo(object value);
                /*0xae168c*/ int CompareTo(System.Data.SqlTypes.SqlInt32 value);
                /*0xae1694*/ bool Equals(object value);
                /*0xae169c*/ int GetHashCode();
                /*0xae16a4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae16ac*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae16b4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x211b54c*/ SqlInt64();
                static /*0x211662c*/ System.Data.SqlTypes.SqlInt64 op_Implicit(long x);
                static /*0x211a2bc*/ System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x);
                static /*0x2116638*/ System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211a364*/ System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211a4a4*/ System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x2116778*/ System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211a628*/ System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211a768*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x2114e84*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x2117ff4*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x211a808*/ System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x211a354*/ bool SameSignLong(long x, long y);
                static /*0x211a9e0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211aa98*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211ab50*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211ac08*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211ac98*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x211b4c4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae16f0*/ SqlInt64(bool fNull);
                /*0xae16fc*/ SqlInt64(long value);
                /*0xae170c*/ bool get_IsNull();
                /*0xae171c*/ long get_Value();
                /*0xae1724*/ string ToString();
                /*0xae172c*/ System.Data.SqlTypes.SqlByte ToSqlByte();
                /*0xae1748*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xae1750*/ System.Data.SqlTypes.SqlInt16 ToSqlInt16();
                /*0xae176c*/ System.Data.SqlTypes.SqlInt32 ToSqlInt32();
                /*0xae1774*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0xae17b4*/ int CompareTo(object value);
                /*0xae17bc*/ int CompareTo(System.Data.SqlTypes.SqlInt64 value);
                /*0xae17c4*/ bool Equals(object value);
                /*0xae17cc*/ int GetHashCode();
                /*0xae17d4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae17dc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae17e4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x211eb2c*/ SqlMoney();
                static /*0x211d570*/ System.Data.SqlTypes.SqlMoney op_Implicit(decimal x);
                static /*0x211d5a0*/ System.Data.SqlTypes.SqlMoney op_Implicit(long x);
                static /*0x211d668*/ System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x);
                static /*0x211d768*/ System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211d904*/ System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211da9c*/ System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211dbbc*/ System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211dcdc*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x211dd84*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x211de24*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x211dec4*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x211df64*/ System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x211e018*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211e0d0*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211e188*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211e240*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211e2d0*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x211eaa4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae1820*/ SqlMoney(bool fNull);
                /*0xae182c*/ SqlMoney(long value, int ignored);
                /*0xae183c*/ SqlMoney(int value);
                /*0xae1844*/ SqlMoney(long value);
                /*0xae184c*/ SqlMoney(decimal value);
                /*0xae1854*/ bool get_IsNull();
                /*0xae1864*/ decimal get_Value();
                /*0xae186c*/ decimal ToDecimal();
                /*0xae1874*/ double ToDouble();
                /*0xae187c*/ string ToString();
                /*0xae1884*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xae188c*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0xae18cc*/ int CompareTo(object value);
                /*0xae18d4*/ int CompareTo(System.Data.SqlTypes.SqlMoney value);
                /*0xae18dc*/ bool Equals(object value);
                /*0xae18e4*/ int GetHashCode();
                /*0xae1900*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae1908*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae1910*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlSingle Null;
                static /*0x8*/ System.Data.SqlTypes.SqlSingle Zero;
                static /*0x10*/ System.Data.SqlTypes.SqlSingle MinValue;
                static /*0x18*/ System.Data.SqlTypes.SqlSingle MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x14*/ float _value;

                static /*0x2121c24*/ SqlSingle();
                static /*0x21208c8*/ System.Data.SqlTypes.SqlSingle op_Implicit(float x);
                static /*0x2120910*/ System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x);
                static /*0x21209ac*/ System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2120ac4*/ System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2120bdc*/ System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2120cf4*/ System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2120e44*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x2120ef0*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x2120f94*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x2121034*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x21210d4*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x2121174*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x2110720*/ System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x);
                static /*0x212121c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x21212d4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x212138c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2121444*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x21214bc*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x2121b9c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae194c*/ SqlSingle(bool fNull);
                /*0xae1958*/ SqlSingle(float value);
                /*0xae1960*/ SqlSingle(double value);
                /*0xae196c*/ bool get_IsNull();
                /*0xae197c*/ float get_Value();
                /*0xae1984*/ string ToString();
                /*0xae198c*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0xae1994*/ int CompareTo(object value);
                /*0xae199c*/ int CompareTo(System.Data.SqlTypes.SqlSingle value);
                /*0xae19a4*/ bool Equals(object value);
                /*0xae19ac*/ int GetHashCode();
                /*0xae19b4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae19bc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae19c4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x2124e9c*/ SqlString();
                static /*0x2123acc*/ System.Data.SqlTypes.SqlString op_Implicit(string x);
                static /*0x2123af8*/ System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x2123c68*/ int StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x21242e0*/ System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult);
                static /*0x2124438*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x21237bc*/ void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x2124204*/ System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x2123eb4*/ int CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x2124088*/ int CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x2124e14*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0xae1a08*/ SqlString(bool fNull);
                /*0xae1a18*/ SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions);
                /*0xae1a20*/ SqlString(string data);
                /*0xae1a28*/ SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, string data, System.Globalization.CompareInfo cmpInfo);
                /*0xae1a30*/ bool get_IsNull();
                /*0xae1a40*/ string get_Value();
                /*0xae1a48*/ void SetCompareInfo();
                /*0xae1a50*/ string ToString();
                /*0xae1a68*/ bool FBinarySort();
                /*0xae1a88*/ int CompareTo(object value);
                /*0xae1a90*/ int CompareTo(System.Data.SqlTypes.SqlString value);
                /*0xae1abc*/ bool Equals(object value);
                /*0xae1ac4*/ int GetHashCode();
                /*0xae1acc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0xae1ad4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0xae1adc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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
                static /*0x212635c*/ System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x212627c*/ SqlTypeException();
                /*0x2123c34*/ SqlTypeException(string message);
                /*0x2120814*/ SqlTypeException(string message, System.Exception e);
                /*0x21262e0*/ SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
            {
                /*0x210fca8*/ SqlNullValueException();
                /*0x21207e4*/ SqlNullValueException(string message, System.Exception e);
            }

            class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
            {
                /*0x2126208*/ SqlTruncateException();
                /*0x212624c*/ SqlTruncateException(string message, System.Exception e);
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

                static /*0x21287ac*/ SqlXml();
                static /*0x21280e0*/ System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, bool closeInput, bool throwTargetInvocationExceptions);
                static /*0x21282e4*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> CreateSqlReaderDelegate();
                static /*0x2127f98*/ System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo();
                static /*0x2128724*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x2127d50*/ SqlXml();
                /*0x2127d98*/ System.Xml.XmlReader CreateReader();
                /*0x2127f0c*/ bool get_IsNull();
                /*0x2127d84*/ void SetNull();
                /*0x21283e4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x21283ec*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x21285c8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            class SqlXmlStreamWrapper : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ long _lPosition;
                /*0x38*/ bool _isClosed;

                /*0x2127f1c*/ SqlXmlStreamWrapper(System.IO.Stream stream);
                /*0x2128894*/ bool get_CanRead();
                /*0x2128958*/ bool get_CanSeek();
                /*0x21289a0*/ bool get_CanWrite();
                /*0x21289e8*/ long get_Length();
                /*0x2128b44*/ long get_Position();
                /*0x2128ba4*/ void set_Position(long value);
                /*0x2128c7c*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x2128e10*/ int Read(byte[] buffer, int offset, int count);
                /*0x212904c*/ void Write(byte[] buffer, int offset, int count);
                /*0x2129288*/ int ReadByte();
                /*0x21293a0*/ void WriteByte(byte value);
                /*0x2129488*/ void Flush();
                /*0x21294a4*/ void Dispose(bool disposing);
                /*0x2128ac4*/ void ThrowIfStreamCannotSeek(string method);
                /*0x2128fcc*/ void ThrowIfStreamCannotRead(string method);
                /*0x2129208*/ void ThrowIfStreamCannotWrite(string method);
                /*0x2128a58*/ void ThrowIfStreamClosed(string method);
                /*0x21288dc*/ bool IsStreamClosed();
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
                static /*0x30*/ bool IsWindowsNT;
                static /*0x31*/ bool IsPlatformNT5;
                static /*0x38*/ string StrEmpty;
                static /*0x40*/ string[] AzureSqlServerEndpoints;
                static /*0x48*/ nint PtrZero;
                static /*0x50*/ int PtrSize;

                static /*0x21b676c*/ ADP();
                static /*0x21b59ac*/ void TraceException(string trace, System.Exception e);
                static /*0x21b5a5c*/ void TraceExceptionAsReturnValue(System.Exception e);
                static /*0x21b5ad4*/ void TraceExceptionWithoutRethrow(System.Exception e);
                static /*0x21b5b4c*/ System.ArgumentException Argument(string error);
                static /*0x21b5be0*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName);
                static /*0x21b5c74*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName);
                static /*0x21b5d18*/ System.InvalidOperationException InvalidOperation(string error);
                static /*0x21b5dac*/ System.NotSupportedException NotSupported(string error);
                static /*0x21b5e40*/ bool IsCatchableExceptionType(System.Exception e);
                static /*0x21b60a8*/ bool IsCatchableOrSecurityExceptionType(System.Exception e);
                static /*0x21b62d0*/ System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value);
                static /*0x21b63f0*/ System.Exception InvalidSeekOrigin(string parameterName);
                static /*0x21b6468*/ System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value);
                static /*0x21b6524*/ System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value);
                static /*0x21b65e0*/ System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value);
                static /*0x21b669c*/ System.Exception WrongType(System.Type got, System.Type expected);
            }

            class BigIntegerStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Numerics.BigInteger[] _values;

                static /*0x21b7adc*/ System.Numerics.BigInteger ConvertToBigInteger(object value, System.IFormatProvider formatProvider);
                static /*0x21b8f2c*/ object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider);
                /*0x21b8ba4*/ BigIntegerStorage(System.Data.DataColumn column);
                /*0x21b8d14*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21b8d4c*/ int Compare(int recordNo1, int recordNo2);
                /*0x21b8e14*/ int CompareValueTo(int recordNo, object value);
                /*0x21b97c8*/ object ConvertValue(object value);
                /*0x21b986c*/ void Copy(int recordNo1, int recordNo2);
                /*0x21b98dc*/ object Get(int record);
                /*0x21b99a0*/ void Set(int record, object value);
                /*0x21b9ae4*/ void SetCapacity(int capacity);
                /*0x21b9bb4*/ object ConvertXmlToObject(string s);
                /*0x21b9c80*/ string ConvertObjectToXml(object value);
                /*0x21b9d60*/ object GetEmptyStorage(int recordCount);
                /*0x21b9dac*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x21b9ec8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class BooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ bool[] _values;

                /*0x21c1cf8*/ BooleanStorage(System.Data.DataColumn column);
                /*0x21c1e04*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21c2208*/ int Compare(int recordNo1, int recordNo2);
                /*0x21c228c*/ int CompareValueTo(int recordNo, object value);
                /*0x21c23a4*/ object ConvertValue(object value);
                /*0x21c2504*/ void Copy(int recordNo1, int recordNo2);
                /*0x21c2570*/ object Get(int record);
                /*0x21c261c*/ void Set(int record, object value);
                /*0x21c27b4*/ void SetCapacity(int capacity);
                /*0x21c2884*/ object ConvertXmlToObject(string s);
                /*0x21c2920*/ string ConvertObjectToXml(object value);
                /*0x21c29c4*/ object GetEmptyStorage(int recordCount);
                /*0x21c2a10*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x21c2b1c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ byte[] _values;

                /*0x21c2ba0*/ ByteStorage(System.Data.DataColumn column);
                /*0x21c2cac*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21c3530*/ int Compare(int recordNo1, int recordNo2);
                /*0x21c35b0*/ int CompareValueTo(int recordNo, object value);
                /*0x21c36c8*/ object ConvertValue(object value);
                /*0x21c3824*/ void Copy(int recordNo1, int recordNo2);
                /*0x21c3890*/ object Get(int record);
                /*0x21c393c*/ void Set(int record, object value);
                /*0x21c3ad0*/ void SetCapacity(int capacity);
                /*0x21c3ba0*/ object ConvertXmlToObject(string s);
                /*0x21c3c38*/ string ConvertObjectToXml(object value);
                /*0x21c3cdc*/ object GetEmptyStorage(int recordCount);
                /*0x21c3d28*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x21c3e34*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class CharStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ char[] _values;

                /*0x21c3eb8*/ CharStorage(System.Data.DataColumn column);
                /*0x21c3fc4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21c43b8*/ int Compare(int recordNo1, int recordNo2);
                /*0x21c4438*/ int CompareValueTo(int recordNo, object value);
                /*0x21c4550*/ object ConvertValue(object value);
                /*0x21c46ac*/ void Copy(int recordNo1, int recordNo2);
                /*0x21c4718*/ object Get(int record);
                /*0x21c47c4*/ void Set(int record, object value);
                /*0x21c49ac*/ void SetCapacity(int capacity);
                /*0x21c4a7c*/ object ConvertXmlToObject(string s);
                /*0x21c4b14*/ string ConvertObjectToXml(object value);
                /*0x21c4bb8*/ object GetEmptyStorage(int recordCount);
                /*0x21c4c04*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x21c4d10*/ void SetStorage(object store, System.Collections.BitArray nullbits);
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

                static /*0x1b9bd24*/ DataStorage();
                static /*0x1b9aa34*/ System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode);
                static /*0x1b9b1f8*/ System.Data.Common.StorageType GetStorageType(System.Type dataType);
                static /*0x1b9b348*/ System.Type GetTypeStorage(System.Data.Common.StorageType storageType);
                static /*0x1b9b3d8*/ bool IsTypeCustomType(System.Type type);
                static /*0x1b9a588*/ bool IsTypeCustomType(System.Data.Common.StorageType typeCode);
                static /*0x1b9b458*/ bool IsSqlType(System.Data.Common.StorageType storageType);
                static /*0x1b9b464*/ bool IsSqlType(System.Type dataType);
                static /*0x1b9a5a8*/ bool DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x1b9b588*/ void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, ref bool sqlType, ref bool nullable, ref bool xmlSerializable, ref bool changeTracking, ref bool revertibleChangeTracking);
                static /*0x1b9b6f0*/ System.Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType);
                static /*0x1b9b8b4*/ bool ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x1b9b9a0*/ bool IsObjectNull(object value);
                static /*0x1b9ba54*/ bool IsObjectSqlNull(object value);
                static /*0x1b9bb4c*/ System.Type GetType(string value);
                static /*0x1b9bca4*/ string GetQualifiedName(System.Type type);
                /*0x1b9a3b0*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, System.Data.Common.StorageType storageType);
                /*0x1b9a57c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, System.Data.Common.StorageType storageType);
                /*0x1b9a450*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, System.Data.Common.StorageType storageType);
                /*0x1b9a5ec*/ System.Data.DataSetDateTime get_DateTimeMode();
                /*0x1b9a608*/ System.IFormatProvider get_FormatProvider();
                /*0x1b9a6bc*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x1b9a6d0*/ object AggregateCount(int[] recordNos);
                /*0x1b9a7a8*/ int CompareBits(int recordNo1, int recordNo2);
                int Compare(int recordNo1, int recordNo2);
                int CompareValueTo(int recordNo1, object value);
                /*0x1b9a814*/ object ConvertValue(object value);
                /*0x1b9a81c*/ void CopyBits(int srcRecordNo, int dstRecordNo);
                void Copy(int recordNo1, int recordNo2);
                object Get(int recordNo);
                /*0x1b9a860*/ object GetBits(int recordNo);
                /*0x1b9a8a4*/ int GetStringLength(int record);
                /*0x1b9a8ac*/ bool HasValue(int recordNo);
                /*0x1b9a8d8*/ bool IsNull(int recordNo);
                void Set(int recordNo, object value);
                /*0x1b9a8f4*/ void SetNullBit(int recordNo, bool flag);
                /*0x1b9a914*/ void SetCapacity(int capacity);
                object ConvertXmlToObject(string s);
                /*0x1b9a9a0*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                string ConvertObjectToXml(object value);
                /*0x1b9a9ec*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x1b9bb14*/ object GetEmptyStorageInternal(int recordCount);
                /*0x1b9bb24*/ void CopyValueInternal(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1b9bb34*/ void SetStorageInternal(object store, System.Collections.BitArray nullbits);
                object GetEmptyStorage(int recordCount);
                void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                void SetStorage(object store, System.Collections.BitArray nullbits);
                /*0x1b9bb44*/ void SetNullStorage(System.Collections.BitArray nullbits);
            }

            class DateTimeOffsetStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTimeOffset s_defaultValue;
                /*0x50*/ System.DateTimeOffset[] _values;

                static /*0x2021ef4*/ DateTimeOffsetStorage();
                /*0x2020be4*/ DateTimeOffsetStorage(System.Data.DataColumn column);
                /*0x2020d2c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x20213e4*/ int Compare(int recordNo1, int recordNo2);
                /*0x20215d0*/ int CompareValueTo(int recordNo, object value);
                /*0x202177c*/ object ConvertValue(object value);
                /*0x202182c*/ void Copy(int recordNo1, int recordNo2);
                /*0x202189c*/ object Get(int record);
                /*0x20219d0*/ void Set(int record, object value);
                /*0x2021af8*/ void SetCapacity(int capacity);
                /*0x2021bc8*/ object ConvertXmlToObject(string s);
                /*0x2021c60*/ string ConvertObjectToXml(object value);
                /*0x2021d08*/ object GetEmptyStorage(int recordCount);
                /*0x2021d54*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2021e70*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DateTimeStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTime s_defaultValue;
                /*0x50*/ System.DateTime[] _values;

                static /*0x2023618*/ DateTimeStorage();
                /*0x2021f78*/ DateTimeStorage(System.Data.DataColumn column);
                /*0x20220c0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2022624*/ int Compare(int recordNo1, int recordNo2);
                /*0x20227d4*/ int CompareValueTo(int recordNo, object value);
                /*0x2022964*/ object ConvertValue(object value);
                /*0x2022ac0*/ void Copy(int recordNo1, int recordNo2);
                /*0x2022b2c*/ object Get(int record);
                /*0x2022c44*/ void Set(int record, object value);
                /*0x2022fd4*/ void SetCapacity(int capacity);
                /*0x20230a4*/ object ConvertXmlToObject(string s);
                /*0x2023178*/ string ConvertObjectToXml(object value);
                /*0x202328c*/ object GetEmptyStorage(int recordCount);
                /*0x20232d8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2023428*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DecimalStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ decimal s_defaultValue;
                /*0x50*/ decimal[] _values;

                /*0x202369c*/ DecimalStorage(System.Data.DataColumn column);
                /*0x20237c8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2024228*/ int Compare(int recordNo1, int recordNo2);
                /*0x20243dc*/ int CompareValueTo(int recordNo, object value);
                /*0x202456c*/ object ConvertValue(object value);
                /*0x20246c8*/ void Copy(int recordNo1, int recordNo2);
                /*0x2024738*/ object Get(int record);
                /*0x20247ec*/ void Set(int record, object value);
                /*0x20249a4*/ void SetCapacity(int capacity);
                /*0x2024a74*/ object ConvertXmlToObject(string s);
                /*0x2024b0c*/ string ConvertObjectToXml(object value);
                /*0x2024bb4*/ object GetEmptyStorage(int recordCount);
                /*0x2024c00*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2024d1c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ double[] _values;

                /*0x20251fc*/ DoubleStorage(System.Data.DataColumn column);
                /*0x2025308*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2025ae8*/ int Compare(int recordNo1, int recordNo2);
                /*0x2025b70*/ int CompareValueTo(int recordNo, object value);
                /*0x2025c8c*/ object ConvertValue(object value);
                /*0x2025de4*/ void Copy(int recordNo1, int recordNo2);
                /*0x2025e50*/ object Get(int record);
                /*0x2025f00*/ void Set(int record, object value);
                /*0x2026094*/ void SetCapacity(int capacity);
                /*0x2026164*/ object ConvertXmlToObject(string s);
                /*0x20261f8*/ string ConvertObjectToXml(object value);
                /*0x202629c*/ object GetEmptyStorage(int recordCount);
                /*0x20262e8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x20263f4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ short[] _values;

                /*0x20fd39c*/ Int16Storage(System.Data.DataColumn column);
                /*0x20fd4a8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x20fddc8*/ int Compare(int recordNo1, int recordNo2);
                /*0x20fde38*/ int CompareValueTo(int recordNo, object value);
                /*0x20fdf44*/ object ConvertValue(object value);
                /*0x20fe0a0*/ void Copy(int recordNo1, int recordNo2);
                /*0x20fe10c*/ object Get(int record);
                /*0x20fe1b8*/ void Set(int record, object value);
                /*0x20fe34c*/ void SetCapacity(int capacity);
                /*0x20fe41c*/ object ConvertXmlToObject(string s);
                /*0x20fe4b4*/ string ConvertObjectToXml(object value);
                /*0x20fe558*/ object GetEmptyStorage(int recordCount);
                /*0x20fe5a4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x20fe6b0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ int[] _values;

                /*0x20fe734*/ Int32Storage(System.Data.DataColumn column);
                /*0x20fe840*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x20ff158*/ int Compare(int recordNo1, int recordNo2);
                /*0x20ff1d4*/ int CompareValueTo(int recordNo, object value);
                /*0x20ff2e0*/ object ConvertValue(object value);
                /*0x20ff43c*/ void Copy(int recordNo1, int recordNo2);
                /*0x20ff4a8*/ object Get(int record);
                /*0x20ff554*/ void Set(int record, object value);
                /*0x20ff6e8*/ void SetCapacity(int capacity);
                /*0x20ff7b8*/ object ConvertXmlToObject(string s);
                /*0x20ff850*/ string ConvertObjectToXml(object value);
                /*0x20ff8f4*/ object GetEmptyStorage(int recordCount);
                /*0x20ff940*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x20ffa4c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ long[] _values;

                /*0x20ffad0*/ Int64Storage(System.Data.DataColumn column);
                /*0x20ffbdc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21004d0*/ int Compare(int recordNo1, int recordNo2);
                /*0x210054c*/ int CompareValueTo(int recordNo, object value);
                /*0x2100658*/ object ConvertValue(object value);
                /*0x21007b4*/ void Copy(int recordNo1, int recordNo2);
                /*0x2100820*/ object Get(int record);
                /*0x21008cc*/ void Set(int record, object value);
                /*0x2100a60*/ void SetCapacity(int capacity);
                /*0x2100b30*/ object ConvertXmlToObject(string s);
                /*0x2100bc8*/ string ConvertObjectToXml(object value);
                /*0x2100c6c*/ object GetEmptyStorage(int recordCount);
                /*0x2100cb8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2100dc4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ObjectStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ object s_defaultValue;
                static /*0x8*/ object s_tempAssemblyCacheLock;
                static /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>, System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache;
                static /*0x18*/ System.Xml.Serialization.XmlSerializerFactory s_serializerFactory;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;

                static /*0x210b60c*/ ObjectStorage();
                static /*0x210b4a4*/ void VerifyIDynamicMetaObjectProvider(System.Type type);
                static /*0x2109aec*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type);
                static /*0x210a2e8*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute);
                /*0x2107be4*/ ObjectStorage(System.Data.DataColumn column, System.Type type);
                /*0x2107db0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2107de8*/ int Compare(int recordNo1, int recordNo2);
                /*0x2108480*/ int CompareValueTo(int recordNo1, object value);
                /*0x2108678*/ int CompareTo(object valueNo1, object valueNo2);
                /*0x2107fbc*/ int CompareWithFamilies(object valueNo1, object valueNo2);
                /*0x2108970*/ void Copy(int recordNo1, int recordNo2);
                /*0x21089f8*/ object Get(int recordNo);
                /*0x2108868*/ System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType);
                /*0x2108a40*/ bool IsNull(int record);
                /*0x2108a84*/ void Set(int recordNo, object value);
                /*0x21094f0*/ void SetCapacity(int capacity);
                /*0x21095b4*/ object ConvertXmlToObject(string s);
                /*0x2109b6c*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x210a8d8*/ string ConvertObjectToXml(object value);
                /*0x210af24*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x210b09c*/ object GetEmptyStorage(int recordCount);
                /*0x210b0e8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x210b2fc*/ void SetStorage(object store, System.Collections.BitArray nullbits);

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

                    static /*0x2ae5b84*/ TempAssemblyComparer();
                    /*0x2ae5994*/ TempAssemblyComparer();
                    /*0x2ae599c*/ bool Equals(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> y);
                    /*0x2ae5af0*/ int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> obj);
                }
            }

            class SByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ sbyte[] _values;

                /*0x1ed24c8*/ SByteStorage(System.Data.DataColumn column);
                /*0x1ed25d4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1ed2e84*/ int Compare(int recordNo1, int recordNo2);
                /*0x1ed2f4c*/ int CompareValueTo(int recordNo, object value);
                /*0x1ed3064*/ object ConvertValue(object value);
                /*0x1ed31c0*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ed322c*/ object Get(int record);
                /*0x1ed32ec*/ void Set(int record, object value);
                /*0x1ed3480*/ void SetCapacity(int capacity);
                /*0x1ed3550*/ object ConvertXmlToObject(string s);
                /*0x1ed35e8*/ string ConvertObjectToXml(object value);
                /*0x1ed368c*/ object GetEmptyStorage(int recordCount);
                /*0x1ed36d8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1ed37e4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlConvert
            {
                static /*0x1edc754*/ System.Data.SqlTypes.SqlByte ConvertToSqlByte(object value);
                static /*0x1ee006c*/ System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(object value);
                static /*0x1ee0370*/ System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(object value);
                static /*0x1ee07b0*/ System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(object value);
                static /*0x1ee0d30*/ System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(object value);
                static /*0x1ee153c*/ System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(object value);
                static /*0x1ee206c*/ System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(object value);
                static /*0x1ee27e8*/ System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(object value);
                static /*0x1ee2ea4*/ System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(object value);
                static /*0x1ed99a8*/ System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(object value);
                static /*0x1ee3128*/ System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(object value);
                static /*0x1ed7bb4*/ System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(object value);
                static /*0x1ee3354*/ System.Data.SqlTypes.SqlString ConvertToSqlString(object value);
                static /*0x1ee358c*/ System.Data.SqlTypes.SqlChars ConvertToSqlChars(object value);
                static /*0x1ee3710*/ System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(object value);
                static /*0x1ee3894*/ System.DateTimeOffset ConvertStringToDateTimeOffset(string value, System.IFormatProvider formatProvider);
                static /*0x1ee3908*/ object ChangeTypeForDefaultValue(object value, System.Type type, System.IFormatProvider formatProvider);
                static /*0x1ee3b04*/ object ChangeType2(object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider);
                static /*0x1ee5118*/ object ChangeTypeForXML(object value, System.Type type);
            }

            class SqlBinaryStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBinary[] _values;

                /*0x1ed7658*/ SqlBinaryStorage(System.Data.DataColumn column);
                /*0x1ed77b4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1ed7a3c*/ int Compare(int recordNo1, int recordNo2);
                /*0x1ed7a88*/ int CompareValueTo(int recordNo, object value);
                /*0x1ed7b3c*/ object ConvertValue(object value);
                /*0x1ed7de8*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ed7e30*/ object Get(int record);
                /*0x1ed7ebc*/ bool IsNull(int record);
                /*0x1ed7f00*/ void Set(int record, object value);
                /*0x1ed7f50*/ void SetCapacity(int capacity);
                /*0x1ed8014*/ object ConvertXmlToObject(string s);
                /*0x1ed82c8*/ string ConvertObjectToXml(object value);
                /*0x1ed8538*/ object GetEmptyStorage(int recordCount);
                /*0x1ed8584*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1ed8690*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlByte[] _values;

                /*0x1edb5d0*/ SqlByteStorage(System.Data.DataColumn column);
                /*0x1edb724*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1edc5dc*/ int Compare(int recordNo1, int recordNo2);
                /*0x1edc628*/ int CompareValueTo(int recordNo, object value);
                /*0x1edc6dc*/ object ConvertValue(object value);
                /*0x1edc980*/ void Copy(int recordNo1, int recordNo2);
                /*0x1edc9c8*/ object Get(int record);
                /*0x1edca54*/ bool IsNull(int record);
                /*0x1edca98*/ void Set(int record, object value);
                /*0x1edcae8*/ void SetCapacity(int capacity);
                /*0x1edcbac*/ object ConvertXmlToObject(string s);
                /*0x1edce60*/ string ConvertObjectToXml(object value);
                /*0x1edd0d0*/ object GetEmptyStorage(int recordCount);
                /*0x1edd11c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1edd228*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBytesStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBytes[] _values;

                /*0x1eddc40*/ SqlBytesStorage(System.Data.DataColumn column);
                /*0x1eddd34*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1eddf8c*/ int Compare(int recordNo1, int recordNo2);
                /*0x1eddf94*/ int CompareValueTo(int recordNo, object value);
                /*0x1eddf9c*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ede024*/ object Get(int record);
                /*0x1ede060*/ bool IsNull(int record);
                /*0x1ede0ac*/ void Set(int record, object value);
                /*0x1ede1f4*/ void SetCapacity(int capacity);
                /*0x1ede2b8*/ object ConvertXmlToObject(string s);
                /*0x1ede58c*/ string ConvertObjectToXml(object value);
                /*0x1ede7fc*/ object GetEmptyStorage(int recordCount);
                /*0x1ede848*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1ede98c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlCharsStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlChars[] _values;

                /*0x1edf298*/ SqlCharsStorage(System.Data.DataColumn column);
                /*0x1edf38c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1edf5e4*/ int Compare(int recordNo1, int recordNo2);
                /*0x1edf5ec*/ int CompareValueTo(int recordNo, object value);
                /*0x1edf5f4*/ void Copy(int recordNo1, int recordNo2);
                /*0x1edf67c*/ object Get(int record);
                /*0x1edf6b8*/ bool IsNull(int record);
                /*0x1edf704*/ void Set(int record, object value);
                /*0x1edf84c*/ void SetCapacity(int capacity);
                /*0x1edf910*/ object ConvertXmlToObject(string s);
                /*0x1edfbf0*/ string ConvertObjectToXml(object value);
                /*0x1edfe60*/ object GetEmptyStorage(int recordCount);
                /*0x1edfeac*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1edfff0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDateTimeStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDateTime[] _values;

                /*0x1ee8f84*/ SqlDateTimeStorage(System.Data.DataColumn column);
                /*0x1ee90f0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1ee9740*/ int Compare(int recordNo1, int recordNo2);
                /*0x1ee97a0*/ int CompareValueTo(int recordNo, object value);
                /*0x1ee985c*/ object ConvertValue(object value);
                /*0x1ee98e0*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ee9944*/ object Get(int record);
                /*0x1ee99e8*/ bool IsNull(int record);
                /*0x1ee9a30*/ void Set(int record, object value);
                /*0x1ee9a8c*/ void SetCapacity(int capacity);
                /*0x1ee9b50*/ object ConvertXmlToObject(string s);
                /*0x1ee9e10*/ string ConvertObjectToXml(object value);
                /*0x1eea080*/ object GetEmptyStorage(int recordCount);
                /*0x1eea0cc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1eea1f8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDecimalStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDecimal[] _values;

                /*0x210d754*/ SqlDecimalStorage(System.Data.DataColumn column);
                /*0x210d8c0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x210ef94*/ int Compare(int recordNo1, int recordNo2);
                /*0x210f018*/ int CompareValueTo(int recordNo, object value);
                /*0x210f0f0*/ object ConvertValue(object value);
                /*0x210f190*/ void Copy(int recordNo1, int recordNo2);
                /*0x210f204*/ object Get(int record);
                /*0x210f2a4*/ bool IsNull(int record);
                /*0x210f2e8*/ void Set(int record, object value);
                /*0x210f378*/ void SetCapacity(int capacity);
                /*0x210f43c*/ object ConvertXmlToObject(string s);
                /*0x210f6fc*/ string ConvertObjectToXml(object value);
                /*0x210f96c*/ object GetEmptyStorage(int recordCount);
                /*0x210f9b8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x210fb00*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDouble[] _values;

                /*0x2110f38*/ SqlDoubleStorage(System.Data.DataColumn column);
                /*0x2111094*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2111e68*/ int Compare(int recordNo1, int recordNo2);
                /*0x2111ebc*/ int CompareValueTo(int recordNo, object value);
                /*0x2111f70*/ object ConvertValue(object value);
                /*0x2111ff4*/ void Copy(int recordNo1, int recordNo2);
                /*0x2112040*/ object Get(int record);
                /*0x21120d8*/ bool IsNull(int record);
                /*0x211211c*/ void Set(int record, object value);
                /*0x2112174*/ void SetCapacity(int capacity);
                /*0x2112238*/ object ConvertXmlToObject(string s);
                /*0x21124ec*/ string ConvertObjectToXml(object value);
                /*0x211275c*/ object GetEmptyStorage(int recordCount);
                /*0x21127a8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x21128c4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlGuidStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlGuid[] _values;

                /*0x2113534*/ SqlGuidStorage(System.Data.DataColumn column);
                /*0x2113690*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2113918*/ int Compare(int recordNo1, int recordNo2);
                /*0x2113964*/ int CompareValueTo(int recordNo, object value);
                /*0x2113a18*/ object ConvertValue(object value);
                /*0x2113a94*/ void Copy(int recordNo1, int recordNo2);
                /*0x2113adc*/ object Get(int record);
                /*0x2113b68*/ bool IsNull(int record);
                /*0x2113bac*/ void Set(int record, object value);
                /*0x2113c00*/ void SetCapacity(int capacity);
                /*0x2113cc4*/ object ConvertXmlToObject(string s);
                /*0x2113f78*/ string ConvertObjectToXml(object value);
                /*0x21141e8*/ object GetEmptyStorage(int recordCount);
                /*0x2114234*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2114340*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt16[] _values;

                /*0x2115630*/ SqlInt16Storage(System.Data.DataColumn column);
                /*0x2115784*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2116924*/ int Compare(int recordNo1, int recordNo2);
                /*0x2116970*/ int CompareValueTo(int recordNo, object value);
                /*0x2116a24*/ object ConvertValue(object value);
                /*0x2116aa0*/ void Copy(int recordNo1, int recordNo2);
                /*0x2116ae8*/ object Get(int record);
                /*0x2116b74*/ bool IsNull(int record);
                /*0x2116bb8*/ void Set(int record, object value);
                /*0x2116c0c*/ void SetCapacity(int capacity);
                /*0x2116cd0*/ object ConvertXmlToObject(string s);
                /*0x2116f84*/ string ConvertObjectToXml(object value);
                /*0x21171f4*/ object GetEmptyStorage(int recordCount);
                /*0x2117240*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x211734c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt32[] _values;

                /*0x21187a0*/ SqlInt32Storage(System.Data.DataColumn column);
                /*0x21188fc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x21197dc*/ int Compare(int recordNo1, int recordNo2);
                /*0x2119828*/ int CompareValueTo(int recordNo, object value);
                /*0x21198dc*/ object ConvertValue(object value);
                /*0x2119958*/ void Copy(int recordNo1, int recordNo2);
                /*0x21199a0*/ object Get(int record);
                /*0x2119a2c*/ bool IsNull(int record);
                /*0x2119a70*/ void Set(int record, object value);
                /*0x2119ac4*/ void SetCapacity(int capacity);
                /*0x2119b88*/ object ConvertXmlToObject(string s);
                /*0x2119e3c*/ string ConvertObjectToXml(object value);
                /*0x211a0ac*/ object GetEmptyStorage(int recordCount);
                /*0x211a0f8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x211a204*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt64[] _values;

                /*0x211b5e4*/ SqlInt64Storage(System.Data.DataColumn column);
                /*0x211b740*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x211c668*/ int Compare(int recordNo1, int recordNo2);
                /*0x211c6bc*/ int CompareValueTo(int recordNo, object value);
                /*0x211c770*/ object ConvertValue(object value);
                /*0x211c7f4*/ void Copy(int recordNo1, int recordNo2);
                /*0x211c840*/ object Get(int record);
                /*0x211c8d8*/ bool IsNull(int record);
                /*0x211c91c*/ void Set(int record, object value);
                /*0x211c974*/ void SetCapacity(int capacity);
                /*0x211ca38*/ object ConvertXmlToObject(string s);
                /*0x211ccec*/ string ConvertObjectToXml(object value);
                /*0x211cf5c*/ object GetEmptyStorage(int recordCount);
                /*0x211cfa8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x211d0c4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlMoneyStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlMoney[] _values;

                /*0x211ec14*/ SqlMoneyStorage(System.Data.DataColumn column);
                /*0x211ed70*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x211fd0c*/ int Compare(int recordNo1, int recordNo2);
                /*0x211fd60*/ int CompareValueTo(int recordNo, object value);
                /*0x211fe14*/ object ConvertValue(object value);
                /*0x211fe98*/ void Copy(int recordNo1, int recordNo2);
                /*0x211fee4*/ object Get(int record);
                /*0x211ff7c*/ bool IsNull(int record);
                /*0x211ffc0*/ void Set(int record, object value);
                /*0x2120018*/ void SetCapacity(int capacity);
                /*0x21200dc*/ object ConvertXmlToObject(string s);
                /*0x2120390*/ string ConvertObjectToXml(object value);
                /*0x2120600*/ object GetEmptyStorage(int recordCount);
                /*0x212064c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2120768*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlSingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlSingle[] _values;

                /*0x2121cb8*/ SqlSingleStorage(System.Data.DataColumn column);
                /*0x2121e14*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2122c70*/ int Compare(int recordNo1, int recordNo2);
                /*0x2122cbc*/ int CompareValueTo(int recordNo, object value);
                /*0x2122d70*/ object ConvertValue(object value);
                /*0x2122dec*/ void Copy(int recordNo1, int recordNo2);
                /*0x2122e34*/ object Get(int record);
                /*0x2122ec0*/ bool IsNull(int record);
                /*0x2122f04*/ void Set(int record, object value);
                /*0x2122f58*/ void SetCapacity(int capacity);
                /*0x212301c*/ object ConvertXmlToObject(string s);
                /*0x21232d0*/ string ConvertObjectToXml(object value);
                /*0x2123540*/ object GetEmptyStorage(int recordCount);
                /*0x212358c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2123698*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlStringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlString[] _values;

                /*0x2124fa4*/ SqlStringStorage(System.Data.DataColumn column);
                /*0x2125100*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x2125598*/ int Compare(int recordNo1, int recordNo2);
                /*0x2125610*/ int Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2);
                /*0x2125694*/ int CompareValueTo(int recordNo, object value);
                /*0x2125764*/ object ConvertValue(object value);
                /*0x21257f4*/ void Copy(int recordNo1, int recordNo2);
                /*0x2125858*/ object Get(int record);
                /*0x21258f0*/ int GetStringLength(int record);
                /*0x2125964*/ bool IsNull(int record);
                /*0x21259ac*/ void Set(int record, object value);
                /*0x2125a24*/ void SetCapacity(int capacity);
                /*0x2125ae8*/ object ConvertXmlToObject(string s);
                /*0x2125da0*/ string ConvertObjectToXml(object value);
                /*0x2126010*/ object GetEmptyStorage(int recordCount);
                /*0x212605c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x212618c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBoolean[] _values;

                /*0x1ed91d8*/ SqlBooleanStorage(System.Data.DataColumn column);
                /*0x1ed9334*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1ed9830*/ int Compare(int recordNo1, int recordNo2);
                /*0x1ed987c*/ int CompareValueTo(int recordNo, object value);
                /*0x1ed9930*/ object ConvertValue(object value);
                /*0x1ed9bd8*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ed9c20*/ object Get(int record);
                /*0x1ed9cac*/ bool IsNull(int record);
                /*0x1ed9cf0*/ void Set(int record, object value);
                /*0x1ed9d40*/ void SetCapacity(int capacity);
                /*0x1ed9e04*/ object ConvertXmlToObject(string s);
                /*0x1eda0b8*/ string ConvertObjectToXml(object value);
                /*0x1eda328*/ object GetEmptyStorage(int recordCount);
                /*0x1eda374*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1eda480*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ float[] _values;

                /*0x1ed548c*/ SingleStorage(System.Data.DataColumn column);
                /*0x1ed5598*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1ed5d98*/ int Compare(int recordNo1, int recordNo2);
                /*0x1ed5e20*/ int CompareValueTo(int recordNo, object value);
                /*0x1ed5f3c*/ object ConvertValue(object value);
                /*0x1ed6094*/ void Copy(int recordNo1, int recordNo2);
                /*0x1ed6100*/ object Get(int record);
                /*0x1ed61b0*/ void Set(int record, object value);
                /*0x1ed6344*/ void SetCapacity(int capacity);
                /*0x1ed6414*/ object ConvertXmlToObject(string s);
                /*0x1ed64a8*/ string ConvertObjectToXml(object value);
                /*0x1ed654c*/ object GetEmptyStorage(int recordCount);
                /*0x1ed6598*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1ed66a4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlUdtStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> s_typeToNull;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;
                /*0x59*/ bool _implementsIComparable;

                static /*0x2127cc8*/ SqlUdtStorage();
                static /*0x21264c8*/ object GetStaticNullForUdtType(System.Type type);
                /*0x2126444*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type);
                /*0x2126778*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type, object nullValue);
                /*0x2126914*/ bool IsNull(int record);
                /*0x2126a34*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x2126a6c*/ int Compare(int recordNo1, int recordNo2);
                /*0x2126ab0*/ int CompareValueTo(int recordNo1, object value);
                /*0x2126d64*/ void Copy(int recordNo1, int recordNo2);
                /*0x2126dfc*/ object Get(int recordNo);
                /*0x2126e38*/ void Set(int recordNo, object value);
                /*0x2126fac*/ void SetCapacity(int capacity);
                /*0x212707c*/ object ConvertXmlToObject(string s);
                /*0x21273a0*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x2127660*/ string ConvertObjectToXml(object value);
                /*0x2127944*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x2127abc*/ object GetEmptyStorage(int recordCount);
                /*0x2127b08*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2127c4c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class StringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ string[] _values;

                /*0x21294b8*/ StringStorage(System.Data.DataColumn column);
                /*0x21295b0*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x21298ac*/ int Compare(int recordNo1, int recordNo2);
                /*0x2129930*/ int CompareValueTo(int recordNo, object value);
                /*0x2129a10*/ object ConvertValue(object value);
                /*0x2129a48*/ void Copy(int recordNo1, int recordNo2);
                /*0x2129ad0*/ object Get(int recordNo);
                /*0x2129b18*/ int GetStringLength(int record);
                /*0x2129b64*/ bool IsNull(int record);
                /*0x2129ba8*/ void Set(int record, object value);
                /*0x2129c58*/ void SetCapacity(int capacity);
                /*0x2129d1c*/ object ConvertXmlToObject(string s);
                /*0x2129d24*/ string ConvertObjectToXml(object value);
                /*0x2129d88*/ object GetEmptyStorage(int recordCount);
                /*0x2129dd4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x2129f18*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class TimeSpanStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.TimeSpan s_defaultValue;
                /*0x50*/ System.TimeSpan[] _values;

                static /*0x212ba84*/ TimeSpanStorage();
                static /*0x212b10c*/ System.TimeSpan ConvertToTimeSpan(object value);
                /*0x2129fec*/ TimeSpanStorage(System.Data.DataColumn column);
                /*0x212a134*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x212add8*/ int Compare(int recordNo1, int recordNo2);
                /*0x212af88*/ int CompareValueTo(int recordNo, object value);
                /*0x212b354*/ object ConvertValue(object value);
                /*0x212b40c*/ void Copy(int recordNo1, int recordNo2);
                /*0x212b478*/ object Get(int record);
                /*0x212b594*/ void Set(int record, object value);
                /*0x212b69c*/ void SetCapacity(int capacity);
                /*0x212b76c*/ object ConvertXmlToObject(string s);
                /*0x212b804*/ string ConvertObjectToXml(object value);
                /*0x212b8a8*/ object GetEmptyStorage(int recordCount);
                /*0x212b8f4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x212ba00*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt16Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ushort s_defaultValue;
                /*0x50*/ ushort[] _values;

                /*0x1daaa74*/ UInt16Storage(System.Data.DataColumn column);
                /*0x1daaba0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1dab4b8*/ int Compare(int recordNo1, int recordNo2);
                /*0x1dab588*/ int CompareValueTo(int recordNo, object value);
                /*0x1dab6b8*/ object ConvertValue(object value);
                /*0x1dab814*/ void Copy(int recordNo1, int recordNo2);
                /*0x1dab880*/ object Get(int record);
                /*0x1dab95c*/ void Set(int record, object value);
                /*0x1dabb10*/ void SetCapacity(int capacity);
                /*0x1dabbe0*/ object ConvertXmlToObject(string s);
                /*0x1dabc78*/ string ConvertObjectToXml(object value);
                /*0x1dabd1c*/ object GetEmptyStorage(int recordCount);
                /*0x1dabd68*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1dabe74*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt32Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ uint s_defaultValue;
                /*0x50*/ uint[] _values;

                /*0x1dabef8*/ UInt32Storage(System.Data.DataColumn column);
                /*0x1dac024*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1dac940*/ int Compare(int recordNo1, int recordNo2);
                /*0x1daca20*/ int CompareValueTo(int recordNo, object value);
                /*0x1dacb50*/ object ConvertValue(object value);
                /*0x1daccac*/ void Copy(int recordNo1, int recordNo2);
                /*0x1dacd18*/ object Get(int record);
                /*0x1dacdf4*/ void Set(int record, object value);
                /*0x1dacfa8*/ void SetCapacity(int capacity);
                /*0x1dad078*/ object ConvertXmlToObject(string s);
                /*0x1dad110*/ string ConvertObjectToXml(object value);
                /*0x1dad1b4*/ object GetEmptyStorage(int recordCount);
                /*0x1dad200*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1dad30c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt64Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ulong s_defaultValue;
                /*0x50*/ ulong[] _values;

                /*0x1dad390*/ UInt64Storage(System.Data.DataColumn column);
                /*0x1dad4bc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x1dadddc*/ int Compare(int recordNo1, int recordNo2);
                /*0x1dadee8*/ int CompareValueTo(int recordNo, object value);
                /*0x1dae018*/ object ConvertValue(object value);
                /*0x1dae174*/ void Copy(int recordNo1, int recordNo2);
                /*0x1dae1e0*/ object Get(int record);
                /*0x1dae2c4*/ void Set(int record, object value);
                /*0x1dae478*/ void SetCapacity(int capacity);
                /*0x1dae548*/ object ConvertXmlToObject(string s);
                /*0x1dae5e0*/ string ConvertObjectToXml(object value);
                /*0x1dae684*/ object GetEmptyStorage(int recordCount);
                /*0x1dae6d0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1dae7dc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0EE6555EB2C89F29655BD23FAB0573D8D684331A;
    static /*0x24*/ <PrivateImplementationDetails> 229F48C8598232AD9236772DD710E64615D0EE51;
    static /*0xbc*/ <PrivateImplementationDetails> 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D;
    static /*0xe2*/ <PrivateImplementationDetails> 547FF12759F2EA9866F3E2095113686A6379ABBF;
    static /*0x17a*/ <PrivateImplementationDetails> 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF;
    static /*0x22a*/ <PrivateImplementationDetails> 624B37B4C211942F3422DFFEAE9F44901E57339C;
    static /*0x2c2*/ <PrivateImplementationDetails> DD3AEFEADB1CD615F3017763F1568179FEE640B0;
    static /*0x2f6*/ <PrivateImplementationDetails> E92B39D8233061927D9ACDE54665E68E7535635A;
    static /*0x32a*/ <PrivateImplementationDetails> FA7899481F1198B5A3F90368A998C285FCE19878;
    static /*0x36a*/ <PrivateImplementationDetails> FF8FD0AC7542FD42A8A7C8D145E120345BA51C56;

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
