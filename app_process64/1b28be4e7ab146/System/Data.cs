class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x748c080*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x748c088*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x748c110*/ NullableContextAttribute(byte );
            }
        }
    }
}

class SR
{
    static /*0x748c138*/ string GetString(string name);
    static /*0x748c13c*/ string Format(string resourceFormat, object p1);
    static /*0x748c1ac*/ string Format(string resourceFormat, object p1, object p2);
    static /*0x748c224*/ string Format(string resourceFormat, object p1, object p2, object p3);
}

namespace System
{
    class LocalAppContextSwitches
    {
        static /*0x0*/ int s_allowArbitraryTypeInstantiation;

        static /*0x748c2ac*/ bool get_AllowArbitraryTypeInstantiation();
    }

    class LocalAppContext
    {
        static /*0x0*/ bool s_isDisableCachingInitialized;
        static /*0x1*/ bool s_disableCaching;
        static /*0x8*/ object s_syncObject;

        static /*0x748c32c*/ bool GetCachedSwitchValue(string switchName, ref int switchValue);
        static /*0x748c34c*/ bool GetCachedSwitchValueInternal(string switchName, ref int switchValue);
        static /*0x748c3e0*/ bool get_DisableCaching();

        class <>c
        {
            static /*0x0*/ System.LocalAppContext.<> <>9;
            static /*0x8*/ System.Func<bool> <>9__6_0;

            static /*0x748c4f8*/ <>c();
            /*0x748c560*/ <>c();
            /*0x748c568*/ bool <get_DisableCaching>b__6_0();
        }
    }

    namespace Data
    {
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

            static /*0x748db64*/ bool IsAutoIncrementType(System.Type dataType);
            /*0x748c5e0*/ DataColumn();
            /*0x748c930*/ DataColumn(string columnName, System.Type dataType);
            /*0x748c638*/ DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type);
            /*0x748ca4c*/ void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode);
            /*0x748d350*/ bool get_AllowDBNull();
            /*0x748d358*/ void set_AllowDBNull(bool value);
            /*0x748d930*/ bool get_AutoIncrement();
            /*0x748d950*/ void set_AutoIncrement(bool value);
            /*0x748e764*/ object get_AutoIncrementCurrent();
            /*0x748e7b8*/ void set_AutoIncrementCurrent(object value);
            /*0x748e66c*/ System.Data.AutoIncrementValue get_AutoInc();
            /*0x748e7a0*/ long get_AutoIncrementSeed();
            /*0x748e9b0*/ void set_AutoIncrementSeed(long value);
            /*0x748eaa0*/ long get_AutoIncrementStep();
            /*0x748eabc*/ void set_AutoIncrementStep(long value);
            /*0x748ebb4*/ string get_Caption();
            /*0x748ebd0*/ void set_Caption(string value);
            /*0x748ecb0*/ string get_ColumnName();
            /*0x748ecb8*/ void set_ColumnName(string value);
            /*0x748f104*/ string get_EncodedColumnName();
            /*0x748e8bc*/ System.IFormatProvider get_FormatProvider();
            /*0x748ec44*/ System.Globalization.CultureInfo get_Locale();
            /*0x748f184*/ int get_ObjectID();
            /*0x748f18c*/ string get_Prefix();
            /*0x748f194*/ void set_Prefix(string value);
            /*0x748f338*/ string GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x748f45c*/ bool get_Computed();
            /*0x748f46c*/ System.Data.DataExpression get_DataExpression();
            /*0x748f474*/ System.Type get_DataType();
            /*0x748de54*/ void set_DataType(System.Type value);
            /*0x748fbfc*/ System.Data.DataSetDateTime get_DateTimeMode();
            /*0x748fc04*/ void set_DateTimeMode(System.Data.DataSetDateTime value);
            /*0x748f68c*/ object get_DefaultValue();
            /*0x748f7cc*/ void set_DefaultValue(object value);
            /*0x748ff4c*/ bool get_DefaultValueIsNull();
            /*0x748ff54*/ string get_Expression();
            /*0x748cb74*/ void set_Expression(string value);
            /*0x74903e8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x748ddf8*/ bool get_HasData();
            /*0x7490458*/ bool get_ImplementsINullable();
            /*0x7490460*/ bool get_ImplementsIChangeTracking();
            /*0x7490468*/ bool get_ImplementsIRevertibleChangeTracking();
            /*0x7490470*/ bool get_IsValueType();
            /*0x749048c*/ bool get_IsSqlType();
            /*0x7490494*/ void SetMaxLengthSimpleType();
            /*0x7490538*/ int get_MaxLength();
            /*0x7490540*/ void set_MaxLength(int value);
            /*0x7490d3c*/ string get_Namespace();
            /*0x7490d80*/ void set_Namespace(string value);
            /*0x7490f18*/ int get_Ordinal();
            /*0x7490f20*/ void SetOrdinalInternal(int ordinal);
            /*0x7491060*/ bool get_ReadOnly();
            /*0x7490068*/ void set_ReadOnly(bool value);
            /*0x74910a8*/ System.Data.Index get_SortIndex();
            /*0x749118c*/ System.Data.DataTable get_Table();
            /*0x7491194*/ void SetTable(System.Data.DataTable table);
            /*0x7491268*/ System.Data.DataRow GetDataRow(int index);
            /*0x748f400*/ object get_Item(int record);
            /*0x749128c*/ void set_Item(int record, object value);
            /*0x749035c*/ void InitializeRecord(int record);
            /*0x74914e4*/ void SetValue(int record, object value);
            /*0x74915ec*/ void FreeRecord(int record);
            /*0x7491610*/ bool get_Unique();
            /*0x7491618*/ void set_Unique(bool value);
            /*0x7491b0c*/ void InternalUnique(bool value);
            /*0x7491b18*/ string get_XmlDataType();
            /*0x7491b20*/ void set_XmlDataType(string value);
            /*0x7491b28*/ System.Data.SimpleType get_SimpleType();
            /*0x748c9f8*/ void set_SimpleType(System.Data.SimpleType value);
            /*0x7491b30*/ System.Data.MappingType get_ColumnMapping();
            /*0x7491b38*/ void set_ColumnMapping(System.Data.MappingType value);
            /*0x7491e60*/ void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x749091c*/ bool CheckMaxLength();
            /*0x7491f2c*/ void CheckMaxLength(System.Data.DataRow dr);
            /*0x748d4f8*/ void CheckNotAllowNull();
            /*0x7491eb4*/ void CheckNullable(System.Data.DataRow row);
            /*0x7491ac0*/ void CheckUnique();
            /*0x7492100*/ int Compare(int record1, int record2);
            /*0x7492120*/ bool CompareValueTo(int record1, object value, bool checkType);
            /*0x74922ac*/ int CompareValueTo(int record1, object value);
            /*0x74922cc*/ object ConvertValue(object value);
            /*0x74922ec*/ void Copy(int srcRecordNo, int dstRecordNo);
            /*0x749230c*/ System.Data.DataColumn Clone();
            /*0x749293c*/ object GetAggregateValue(int[] records, System.Data.AggregateType kind);
            /*0x7491fa8*/ int GetStringLength(int record);
            /*0x74929f4*/ void Init(int record);
            /*0x7492a80*/ bool get_IsCustomType();
            /*0x7492af4*/ bool IsValueCustomTypeInstance(object value);
            /*0x7492bb4*/ bool get_ImplementsIXMLSerializable();
            /*0x748f4fc*/ bool IsInRelation();
            /*0x7492bbc*/ bool IsMaxLengthViolated();
            /*0x7493164*/ bool IsNotAllowDBNullViolated();
            /*0x74932d4*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x748f090*/ void RaisePropertyChanging(string name);
            /*0x74932fc*/ void InsureStorage();
            /*0x7493398*/ void SetCapacity(int capacity);
            /*0x74933d4*/ void OnSetDataSet();
            /*0x74933d8*/ string ToString();
            /*0x749344c*/ object ConvertXmlToObject(string s);
            /*0x7493488*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x748f420*/ string ConvertObjectToXml(object value);
            /*0x74934cc*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x7493520*/ object GetEmptyColumnStore(int recordCount);
            /*0x7493554*/ void CopyValueIntoStore(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
            /*0x7493570*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            /*0x74935ac*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x74936c8*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x7490224*/ void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression);
        }

        class AutoIncrementValue
        {
            /*0x10*/ bool <Auto>k__BackingField;

            /*0x7493774*/ AutoIncrementValue();
            /*0x7493760*/ bool get_Auto();
            /*0x7493768*/ void set_Auto(bool value);
            /*0x38148bc*/ object get_Current();
            /*0x3816710*/ void set_Current(object value);
            /*0x38146fc*/ long get_Seed();
            /*0x381630c*/ void set_Seed(long value);
            /*0x38146fc*/ long get_Step();
            /*0x381630c*/ void set_Step(long value);
            /*0x38148bc*/ System.Type get_DataType();
            /*0x3816810*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x3816710*/ void SetCurrentAndIncrement(object value);
            /*0x38159dc*/ void MoveAfter();
            /*0x749282c*/ System.Data.AutoIncrementValue Clone();
        }

        class AutoIncrementInt64 : System.Data.AutoIncrementValue
        {
            /*0x18*/ long _current;
            /*0x20*/ long _seed;
            /*0x28*/ long _step;

            /*0x748e928*/ AutoIncrementInt64();
            /*0x749377c*/ object get_Current();
            /*0x74937a4*/ void set_Current(object value);
            /*0x74937f8*/ System.Type get_DataType();
            /*0x7493828*/ long get_Seed();
            /*0x7493830*/ void set_Seed(long value);
            /*0x7493990*/ long get_Step();
            /*0x7493998*/ void set_Step(long value);
            /*0x7493a58*/ void MoveAfter();
            /*0x7493a6c*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x7493ae0*/ void SetCurrentAndIncrement(object value);
            /*0x74938c0*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class AutoIncrementBigInteger : System.Data.AutoIncrementValue
        {
            /*0x18*/ System.Numerics.BigInteger _current;
            /*0x28*/ long _seed;
            /*0x30*/ System.Numerics.BigInteger _step;

            /*0x748e938*/ AutoIncrementBigInteger();
            /*0x7493c18*/ object get_Current();
            /*0x7493c74*/ void set_Current(object value);
            /*0x7493cf4*/ System.Type get_DataType();
            /*0x7493d54*/ long get_Seed();
            /*0x7493d5c*/ void set_Seed(long value);
            /*0x7493f78*/ long get_Step();
            /*0x7493fd8*/ void set_Step(long value);
            /*0x7494184*/ void MoveAfter();
            /*0x7494218*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x7494248*/ void SetCurrentAndIncrement(object value);
            /*0x7493e50*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class DataException : System.SystemException
        {
            /*0x7494324*/ DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x749432c*/ DataException();
            /*0x7494388*/ DataException(string s);
            /*0x74943ac*/ DataException(string s, System.Exception innerException);
        }

        class ConstraintException : System.Data.DataException
        {
            /*0x74943b4*/ ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74943bc*/ ConstraintException();
            /*0x7494418*/ ConstraintException(string s);
        }

        class DeletedRowInaccessibleException : System.Data.DataException
        {
            /*0x749443c*/ DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7494444*/ DeletedRowInaccessibleException();
            /*0x74944a0*/ DeletedRowInaccessibleException(string s);
        }

        class DuplicateNameException : System.Data.DataException
        {
            /*0x74944c4*/ DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74944cc*/ DuplicateNameException();
            /*0x7494528*/ DuplicateNameException(string s);
        }

        class InRowChangingEventException : System.Data.DataException
        {
            /*0x749454c*/ InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7494554*/ InRowChangingEventException();
            /*0x74945b0*/ InRowChangingEventException(string s);
        }

        class InvalidConstraintException : System.Data.DataException
        {
            /*0x74945d4*/ InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74945dc*/ InvalidConstraintException();
            /*0x7494638*/ InvalidConstraintException(string s);
        }

        class NoNullAllowedException : System.Data.DataException
        {
            /*0x749465c*/ NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7494664*/ NoNullAllowedException();
            /*0x74946c0*/ NoNullAllowedException(string s);
        }

        class ReadOnlyException : System.Data.DataException
        {
            /*0x74946e4*/ ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74946ec*/ ReadOnlyException();
            /*0x7494748*/ ReadOnlyException(string s);
        }

        class RowNotInTableException : System.Data.DataException
        {
            /*0x749476c*/ RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7494774*/ RowNotInTableException();
            /*0x74947d0*/ RowNotInTableException(string s);
        }

        class VersionNotFoundException : System.Data.DataException
        {
            /*0x74947f4*/ VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74947fc*/ VersionNotFoundException();
            /*0x7494858*/ VersionNotFoundException(string s);
        }

        class ExceptionBuilder
        {
            static /*0x749487c*/ void TraceException(string trace, System.Exception e);
            static /*0x7494914*/ System.Exception TraceExceptionAsReturnValue(System.Exception e);
            static /*0x7490154*/ System.Exception TraceExceptionForCapture(System.Exception e);
            static /*0x7490398*/ System.Exception TraceExceptionWithoutRethrow(System.Exception e);
            static /*0x7494964*/ System.Exception _Argument(string error);
            static /*0x74949c0*/ System.Exception _Argument(string error, System.Exception innerException);
            static /*0x7494a2c*/ System.Exception _ArgumentNull(string paramName, string msg);
            static /*0x7494a98*/ System.Exception _ArgumentOutOfRange(string paramName, string msg);
            static /*0x7494b04*/ System.Exception _IndexOutOfRange(string error);
            static /*0x7494b60*/ System.Exception _InvalidOperation(string error);
            static /*0x7494bbc*/ System.Exception _InvalidEnumArgumentException(string error);
            static /*0x3910ae8*/ System.Exception _InvalidEnumArgumentException<T>(T value);
            static /*0x7494c18*/ void ThrowDataException(string error, System.Exception innerException);
            static /*0x7494c68*/ System.Exception _Data(string error);
            static /*0x7494cd0*/ System.Exception _Constraint(string error);
            static /*0x7494d38*/ System.Exception _InvalidConstraint(string error);
            static /*0x7494da0*/ System.Exception _DeletedRowInaccessible(string error);
            static /*0x7494e08*/ System.Exception _DuplicateName(string error);
            static /*0x7494e70*/ System.Exception _InRowChangingEvent(string error);
            static /*0x7494ed8*/ System.Exception _NoNullAllowed(string error);
            static /*0x7494f40*/ System.Exception _ReadOnly(string error);
            static /*0x7494fa8*/ System.Exception _RowNotInTable(string error);
            static /*0x7495010*/ System.Exception _VersionNotFound(string error);
            static /*0x748c93c*/ System.Exception ArgumentNull(string paramName);
            static /*0x7495078*/ System.Exception ArgumentOutOfRange(string paramName);
            static /*0x74950cc*/ System.Exception BadObjectPropertyAccess(string error);
            static /*0x7495118*/ System.Exception TypeNotAllowed(System.Type type);
            static /*0x7495184*/ System.Exception CaseInsensitiveNameConflict(string name);
            static /*0x74951d0*/ System.Exception NamespaceNameConflict(string name);
            static /*0x749521c*/ System.Exception InvalidOffsetLength();
            static /*0x749525c*/ System.Exception ColumnNotInTheTable(string column, string table);
            static /*0x74952b8*/ System.Exception ColumnNotInAnyTable();
            static /*0x74952f8*/ System.Exception ColumnOutOfRange(int index);
            static /*0x7495388*/ System.Exception ColumnOutOfRange(string column);
            static /*0x74953d4*/ System.Exception CannotAddColumn1(string column);
            static /*0x7495420*/ System.Exception CannotAddColumn2(string column);
            static /*0x7491dd4*/ System.Exception CannotAddColumn3();
            static /*0x7491e14*/ System.Exception CannotAddColumn4(string column);
            static /*0x749546c*/ System.Exception CannotAddDuplicate(string column);
            static /*0x74954b8*/ System.Exception CannotAddDuplicate2(string table);
            static /*0x7495504*/ System.Exception CannotAddDuplicate3(string table);
            static /*0x7495550*/ System.Exception CannotRemoveColumn();
            static /*0x7495590*/ System.Exception CannotRemovePrimaryKey();
            static /*0x74955d0*/ System.Exception CannotRemoveChildKey(string relation);
            static /*0x749561c*/ System.Exception CannotRemoveConstraint(string constraint, string table);
            static /*0x7495678*/ System.Exception CannotRemoveExpression(string column, string expression);
            static /*0x74956d4*/ System.Exception AddPrimaryKeyConstraint();
            static /*0x7495714*/ System.Exception NoConstraintName();
            static /*0x7495754*/ System.Exception ConstraintViolation(string constraint);
            static /*0x74957a0*/ string KeysToString(object[] keys);
            static /*0x74958b8*/ string UniqueConstraintViolationText(System.Data.DataColumn[] columns, object[] values);
            static /*0x7495a18*/ System.Exception ConstraintViolation(System.Data.DataColumn[] columns, object[] values);
            static /*0x7495a28*/ System.Exception ConstraintOutOfRange(int index);
            static /*0x7495ab8*/ System.Exception DuplicateConstraint(string constraint);
            static /*0x7495b04*/ System.Exception DuplicateConstraintName(string constraint);
            static /*0x7495b50*/ System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk);
            static /*0x7495bd8*/ System.Exception UniqueConstraintViolation();
            static /*0x7495c18*/ System.Exception ConstraintForeignTable();
            static /*0x7495c58*/ System.Exception ConstraintParentValues();
            static /*0x7495c98*/ System.Exception ConstraintAddFailed(System.Data.DataTable table);
            static /*0x7495cec*/ System.Exception ConstraintRemoveFailed();
            static /*0x7495d2c*/ System.Exception FailedCascadeDelete(string constraint);
            static /*0x7495d78*/ System.Exception FailedCascadeUpdate(string constraint);
            static /*0x7495dc4*/ System.Exception FailedClearParentTable(string table, string constraint, string childTable);
            static /*0x7495e28*/ System.Exception ForeignKeyViolation(string constraint, object[] keys);
            static /*0x7495e90*/ System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint);
            static /*0x749311c*/ string MaxLengthViolationText(string columnName);
            static /*0x749328c*/ string NotAllowDBNullViolationText(string columnName);
            static /*0x7495ef8*/ System.Exception CantAddConstraintToMultipleNestedTable(string tableName);
            static /*0x748dae4*/ System.Exception AutoIncrementAndExpression();
            static /*0x748db24*/ System.Exception AutoIncrementAndDefaultValue();
            static /*0x7493a18*/ System.Exception AutoIncrementSeed();
            static /*0x748f47c*/ System.Exception CantChangeDataType();
            static /*0x748f4bc*/ System.Exception NullDataType();
            static /*0x748f050*/ System.Exception ColumnNameRequired();
            static /*0x748fe64*/ System.Exception DefaultValueAndAutoIncrement();
            static /*0x748fac8*/ System.Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x748fea4*/ System.Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x748ffb0*/ System.Exception ExpressionAndUnique();
            static /*0x74901a4*/ System.Exception ExpressionAndReadOnly();
            static /*0x748fff0*/ System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint);
            static /*0x7495f44*/ System.Exception ExpressionInConstraint(System.Data.DataColumn column);
            static /*0x74901e4*/ System.Exception ExpressionCircular();
            static /*0x74920b4*/ System.Exception NonUniqueValues(string column);
            static /*0x749201c*/ System.Exception NullKeyValues(string column);
            static /*0x7492068*/ System.Exception NullValues(string column);
            static /*0x7491068*/ System.Exception ReadOnlyAndExpression();
            static /*0x7495f98*/ System.Exception ReadOnly(string column);
            static /*0x7491a80*/ System.Exception UniqueAndExpression();
            static /*0x749140c*/ System.Exception SetFailed(object value, System.Data.DataColumn column, System.Type type, System.Exception innerException);
            static /*0x7495fe4*/ System.Exception CannotSetToNull(System.Data.DataColumn column);
            static /*0x7491fc8*/ System.Exception LongerThanMaxLength(System.Data.DataColumn column);
            static /*0x7490c98*/ System.Exception CannotSetMaxLength(System.Data.DataColumn column, int value);
            static /*0x7490874*/ System.Exception CannotSetMaxLength2(System.Data.DataColumn column);
            static /*0x748fba0*/ System.Exception CannotSetSimpleContentType(string columnName, System.Type type);
            static /*0x7491d78*/ System.Exception CannotSetSimpleContent(string columnName, System.Type type);
            static /*0x7490ecc*/ System.Exception CannotChangeNamespace(string columnName);
            static /*0x74908c8*/ System.Exception HasToBeStringType(System.Data.DataColumn column);
            static /*0x748de08*/ System.Exception AutoIncrementCannotSetIfHasData(string typeName);
            static /*0x7496038*/ System.Exception INullableUDTwithoutStaticNull(string typeName);
            static /*0x7496084*/ System.Exception IComparableNotImplemented(string typeName);
            static /*0x74960d0*/ System.Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName);
            static /*0x749611c*/ System.Exception InvalidDataColumnMapping(System.Type type);
            static /*0x748fd24*/ System.Exception CannotSetDateTimeModeForNonDateTimeColumns();
            static /*0x748fe1c*/ System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode);
            static /*0x748fd64*/ System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue);
            static /*0x748c990*/ System.Exception ColumnTypeNotSupported();
            static /*0x7496188*/ System.Exception SetFailed(string name);
            static /*0x74961d4*/ System.Exception CanNotUse();
            static /*0x7496214*/ System.Exception SetIListObject();
            static /*0x7496254*/ System.Exception AddNewNotAllowNull();
            static /*0x7496294*/ System.Exception NotOpen();
            static /*0x74962d4*/ System.Exception CreateChildView();
            static /*0x7496314*/ System.Exception CanNotDelete();
            static /*0x7496354*/ System.Exception GetElementIndex(int index);
            static /*0x74963e4*/ System.Exception AddExternalObject();
            static /*0x7496424*/ System.Exception CanNotClear();
            static /*0x7496464*/ System.Exception InsertExternalObject();
            static /*0x74964a4*/ System.Exception RemoveExternalObject();
            static /*0x74964e4*/ System.Exception KeyTableMismatch();
            static /*0x7496524*/ System.Exception KeyNoColumns();
            static /*0x7496564*/ System.Exception KeyTooManyColumns(int cols);
            static /*0x74965f4*/ System.Exception KeyDuplicateColumns(string columnName);
            static /*0x7496640*/ System.Exception RelationDataSetMismatch();
            static /*0x748f64c*/ System.Exception ColumnsTypeMismatch();
            static /*0x7496680*/ System.Exception KeyLengthMismatch();
            static /*0x74966c0*/ System.Exception KeyLengthZero();
            static /*0x7496700*/ System.Exception ForeignRelation();
            static /*0x7496740*/ System.Exception KeyColumnsIdentical();
            static /*0x7496780*/ System.Exception RelationForeignTable(string t1, string t2);
            static /*0x74967dc*/ System.Exception GetParentRowTableMismatch(string t1, string t2);
            static /*0x7496838*/ System.Exception SetParentRowTableMismatch(string t1, string t2);
            static /*0x7496894*/ System.Exception RelationForeignRow();
            static /*0x74968d4*/ System.Exception RelationNestedReadOnly();
            static /*0x7496914*/ System.Exception TableCantBeNestedInTwoTables(string tableName);
            static /*0x7496960*/ System.Exception LoopInNestedRelations(string tableName);
            static /*0x74969ac*/ System.Exception RelationDoesNotExist();
            static /*0x74969ec*/ System.Exception ParentOrChildColumnsDoNotHaveDataSet();
            static /*0x7496a2c*/ System.Exception InValidNestedRelation(string childTableName);
            static /*0x7496a78*/ System.Exception InvalidParentNamespaceinNestedRelation(string childTableName);
            static /*0x7496ac4*/ System.Exception RowNotInTheDataSet();
            static /*0x7496b04*/ System.Exception RowNotInTheTable();
            static /*0x7496b44*/ System.Exception EditInRowChanging();
            static /*0x7496b84*/ System.Exception EndEditInRowChanging();
            static /*0x7496bc4*/ System.Exception BeginEditInRowChanging();
            static /*0x7496c04*/ System.Exception CancelEditInRowChanging();
            static /*0x7496c44*/ System.Exception DeleteInRowDeleting();
            static /*0x7496c84*/ System.Exception ValueArrayLength();
            static /*0x7496cc4*/ System.Exception NoCurrentData();
            static /*0x7496d04*/ System.Exception NoOriginalData();
            static /*0x7496d44*/ System.Exception NoProposedData();
            static /*0x7496d84*/ System.Exception RowRemovedFromTheTable();
            static /*0x7496dc4*/ System.Exception DeletedRowInaccessible();
            static /*0x7496e04*/ System.Exception RowAlreadyDeleted();
            static /*0x7496e44*/ System.Exception RowEmpty();
            static /*0x7496e84*/ System.Exception InvalidRowVersion();
            static /*0x7496ec4*/ System.Exception RowOutOfRange(int index);
            static /*0x7496f54*/ System.Exception RowInsertTwice(int index, string tableName);
            static /*0x7496ff4*/ System.Exception RowInsertMissing(string tableName);
            static /*0x7497040*/ System.Exception RowAlreadyRemoved();
            static /*0x7497080*/ System.Exception MultipleParents();
            static /*0x74970c0*/ System.Exception InvalidRowState(System.Data.DataRowState state);
            static /*0x7497108*/ System.Exception InvalidRowBitPattern();
            static /*0x7497148*/ System.Exception SetDataSetNameToEmpty();
            static /*0x7497188*/ System.Exception SetDataSetNameConflicting(string name);
            static /*0x74971d4*/ System.Exception DataSetUnsupportedSchema(string ns);
            static /*0x7497220*/ System.Exception MergeMissingDefinition(string obj);
            static /*0x749726c*/ System.Exception TablesInDifferentSets();
            static /*0x74972ac*/ System.Exception RelationAlreadyExists();
            static /*0x74972ec*/ System.Exception RowAlreadyInOtherCollection();
            static /*0x749732c*/ System.Exception RowAlreadyInTheCollection();
            static /*0x749736c*/ System.Exception RecordStateRange();
            static /*0x74973ac*/ System.Exception IndexKeyLength(int length, int keyLength);
            static /*0x7497488*/ System.Exception RemovePrimaryKey(System.Data.DataTable table);
            static /*0x7497504*/ System.Exception RelationAlreadyInOtherDataSet();
            static /*0x7497544*/ System.Exception RelationAlreadyInTheDataSet();
            static /*0x7497584*/ System.Exception RelationNotInTheDataSet(string relation);
            static /*0x74975d0*/ System.Exception RelationOutOfRange(object index);
            static /*0x7497654*/ System.Exception DuplicateRelation(string relation);
            static /*0x74976a0*/ System.Exception RelationTableNull();
            static /*0x74976e0*/ System.Exception RelationDataSetNull();
            static /*0x7497720*/ System.Exception RelationTableWasRemoved();
            static /*0x7497760*/ System.Exception ParentTableMismatch();
            static /*0x74977a0*/ System.Exception ChildTableMismatch();
            static /*0x74977e0*/ System.Exception EnforceConstraint();
            static /*0x7497820*/ System.Exception CaseLocaleMismatch();
            static /*0x7497860*/ System.Exception CannotChangeCaseLocale();
            static /*0x7497868*/ System.Exception CannotChangeCaseLocale(System.Exception innerException);
            static /*0x74978b0*/ System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode);
            static /*0x74978f8*/ System.Exception TableForeignPrimaryKey();
            static /*0x7497938*/ System.Exception TableCannotAddToSimpleContent();
            static /*0x7497978*/ System.Exception NoTableName();
            static /*0x74979b8*/ System.Exception MultipleTextOnlyColumns();
            static /*0x74979f8*/ System.Exception InvalidSortString(string sort);
            static /*0x7497a44*/ System.Exception DuplicateTableName(string table);
            static /*0x7497a90*/ System.Exception DuplicateTableName2(string table, string ns);
            static /*0x7497aec*/ System.Exception SelfnestedDatasetConflictingName(string table);
            static /*0x7497b38*/ System.Exception DatasetConflictingName(string table);
            static /*0x7497b84*/ System.Exception TableAlreadyInOtherDataSet();
            static /*0x7497bc4*/ System.Exception TableAlreadyInTheDataSet();
            static /*0x7497c04*/ System.Exception TableOutOfRange(int index);
            static /*0x7497c94*/ System.Exception TableNotInTheDataSet(string table);
            static /*0x7497ce0*/ System.Exception TableInRelation();
            static /*0x7497d20*/ System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint);
            static /*0x7497d98*/ System.Exception CanNotSerializeDataTableHierarchy();
            static /*0x7497dd8*/ System.Exception CanNotRemoteDataTable();
            static /*0x7497e18*/ System.Exception CanNotSetRemotingFormat();
            static /*0x7497e58*/ System.Exception CanNotSerializeDataTableWithEmptyName();
            static /*0x7497e98*/ System.Exception TableNotFound(string tableName);
            static /*0x7497ee4*/ System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type);
            static /*0x7497f9c*/ System.Exception InvalidStorageType(System.TypeCode typecode);
            static /*0x7498030*/ System.Exception RangeArgument(int min, int max);
            static /*0x74980e0*/ System.Exception NullRange();
            static /*0x7498120*/ System.Exception NegativeMinimumCapacity();
            static /*0x7498160*/ System.Exception ProblematicChars(char charValue);
            static /*0x749823c*/ System.Exception StorageSetFailed();
            static /*0x749827c*/ System.Exception SimpleTypeNotSupported();
            static /*0x74982bc*/ System.Exception MissingAttribute(string attribute);
            static /*0x74982dc*/ System.Exception MissingAttribute(string element, string attribute);
            static /*0x7498338*/ System.Exception InvalidAttributeValue(string name, string value);
            static /*0x7498394*/ System.Exception AttributeValues(string name, string value1, string value2);
            static /*0x74983f8*/ System.Exception ElementTypeNotFound(string name);
            static /*0x7498444*/ System.Exception RelationParentNameMissing(string rel);
            static /*0x7498490*/ System.Exception RelationChildNameMissing(string rel);
            static /*0x74984dc*/ System.Exception RelationTableKeyMissing(string rel);
            static /*0x7498528*/ System.Exception RelationChildKeyMissing(string rel);
            static /*0x7498574*/ System.Exception UndefinedDatatype(string name);
            static /*0x74985c0*/ System.Exception DatatypeNotDefined();
            static /*0x7498600*/ System.Exception MismatchKeyLength();
            static /*0x7498640*/ System.Exception InvalidField(string name);
            static /*0x749868c*/ System.Exception InvalidSelector(string name);
            static /*0x74986d8*/ System.Exception CircularComplexType(string name);
            static /*0x7498724*/ System.Exception CannotInstantiateAbstract(string name);
            static /*0x7498770*/ System.Exception InvalidKey(string name);
            static /*0x74987bc*/ System.Exception DiffgramMissingTable(string name);
            static /*0x7498808*/ System.Exception DiffgramMissingSQL();
            static /*0x7498848*/ System.Exception DuplicateConstraintRead(string str);
            static /*0x7498894*/ System.Exception ColumnTypeConflict(string name);
            static /*0x74988e0*/ System.Exception CannotConvert(string name, string type);
            static /*0x749893c*/ System.Exception MissingRefer(string name);
            static /*0x748f2ec*/ System.Exception InvalidPrefix(string name);
            static /*0x74989c0*/ System.Exception CanNotDeserializeObjectType();
            static /*0x7498a00*/ System.Exception IsDataSetAttributeMissingInSchema();
            static /*0x7498a40*/ System.Exception TooManyIsDataSetAtributeInSchema();
            static /*0x7498a80*/ System.Exception NestedCircular(string name);
            static /*0x7498acc*/ System.Exception MultipleParentRows(string tableQName);
            static /*0x7498b18*/ System.Exception PolymorphismNotSupported(string typeName);
            static /*0x7498b64*/ System.Exception DataTableInferenceNotSupported();
            static /*0x7498ba4*/ void ThrowMultipleTargetConverter(System.Exception innerException);
            static /*0x7498c04*/ System.Exception DuplicateDeclaration(string name);
            static /*0x7498c50*/ System.Exception FoundEntity();
            static /*0x7498c90*/ System.Exception MergeFailed(string name);
            static /*0x7498c94*/ System.Exception ConvertFailed(System.Type type1, System.Type type2);
            static /*0x7498d24*/ System.Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr);
            static /*0x7498d80*/ System.Exception InternalRBTreeError(System.Data.RBTreeError internalError);
            static /*0x7498df4*/ System.Exception EnumeratorModified();
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

            static /*0x74a0530*/ void MoveToElement(System.Xml.XmlReader reader);
            static /*0x74a4b48*/ System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x7498e34*/ DataSet();
            /*0x74990d4*/ DataSet(string dataSetName);
            /*0x7499308*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7499310*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema);
            /*0x7499258*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x7499260*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x7499300*/ System.Data.SchemaSerializationMode get_SchemaSerializationMode();
            /*0x7499550*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7499b58*/ void InitializeDerivedDataSet();
            /*0x7499558*/ void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x7499508*/ void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x749a870*/ void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x749ad08*/ void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x7499b5c*/ void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x749aeac*/ void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7499ccc*/ void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x749b178*/ void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x749c388*/ void FailedEnableConstraints();
            /*0x749c53c*/ bool get_CaseSensitive();
            /*0x749c544*/ void set_CaseSensitive(bool value);
            /*0x749cc70*/ bool get_EnforceConstraints();
            /*0x749c3b4*/ void set_EnforceConstraints(bool value);
            /*0x749d428*/ void RestoreEnforceConstraints(bool value);
            /*0x749cc78*/ void EnableConstraints();
            /*0x749d434*/ string get_DataSetName();
            /*0x74990fc*/ void set_DataSetName(string value);
            /*0x749d4b4*/ string get_Namespace();
            /*0x749d4bc*/ void set_Namespace(string value);
            /*0x749d990*/ string get_Prefix();
            /*0x749d998*/ void set_Prefix(string value);
            /*0x749c318*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x749dac0*/ System.Globalization.CultureInfo get_Locale();
            /*0x749dac8*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x749dc68*/ void SetLocaleValue(System.Globalization.CultureInfo value, bool userSet);
            /*0x749e88c*/ bool ShouldSerializeLocale();
            /*0x749e894*/ System.ComponentModel.ISite get_Site();
            /*0x749e89c*/ System.Data.DataRelationCollection get_Relations();
            /*0x749e8a4*/ System.Data.DataTableCollection get_Tables();
            /*0x749e8ac*/ void Clear();
            /*0x749eae0*/ System.Data.DataSet Clone();
            /*0x749a534*/ int EstimatedXmlStringSize();
            /*0x749fb4c*/ string GetRemotingDiffGram(System.Data.DataTable table);
            /*0x749a39c*/ string GetXmlSchemaForRemoting(System.Data.DataTable table);
            /*0x749fc7c*/ void ReadXmlSchema(System.Xml.XmlReader reader);
            /*0x749ba38*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x74a0084*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x74a0138*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x749fddc*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x749fc84*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x74a05a8*/ void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x74a07e4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader);
            /*0x74a07ec*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, bool denyResolving);
            /*0x74a01cc*/ void InferSchema(System.Xml.XmlDocument xdoc, string[] excludedNamespaces, System.Data.XmlReadMode mode);
            /*0x74a2c80*/ bool IsEmpty();
            /*0x74a18f4*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x749c310*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode);
            /*0x74a30f4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x749a654*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode);
            /*0x74a2f70*/ void Merge(System.Data.DataSet dataSet);
            /*0x74a3ea8*/ void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74a4114*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x74a413c*/ void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent);
            /*0x74a4198*/ void RaiseMergeFailed(System.Data.DataTable table, string conflict, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74a423c*/ void OnDataRowCreated(System.Data.DataRow row);
            /*0x749eab8*/ void OnClearFunctionCalled(System.Data.DataTable table);
            /*0x74a4264*/ void OnRemoveTable(System.Data.DataTable table);
            /*0x74a4268*/ void OnRemovedTable(System.Data.DataTable table);
            /*0x74a4294*/ void OnRemoveRelation(System.Data.DataRelation relation);
            /*0x74a4298*/ void OnRemoveRelationHack(System.Data.DataRelation relation);
            /*0x749d43c*/ void RaisePropertyChanging(string name);
            /*0x74a42a8*/ System.Data.DataTable[] TopLevelTables();
            /*0x74a42b0*/ System.Data.DataTable[] TopLevelTables(bool forSchema);
            /*0x74a45a0*/ void Reset();
            /*0x749c870*/ bool ValidateCaseConstraint();
            /*0x749e434*/ bool ValidateLocaleConstraint();
            /*0x74a4860*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x74a4dc4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x74a4f8c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x74a51dc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x74a5210*/ string get_MainTableName();
            /*0x74a5218*/ void set_MainTableName(string value);
            /*0x74a5220*/ int get_ObjectID();
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

            static /*0x748b298*/ System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x7473d88*/ DataTable();
            /*0x74742d4*/ DataTable(string tableName);
            /*0x7474344*/ DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74747c8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74748a0*/ void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x74744dc*/ void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x7474b74*/ void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x7475e74*/ void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x7478c90*/ void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x7479cfc*/ void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x747aa00*/ void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x747ab50*/ void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x7475838*/ void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x7476d14*/ void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x747af54*/ System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, int bitIndex);
            /*0x747aca8*/ void GetRowAndColumnErrors(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x747affc*/ void ConvertToRowError(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x747b2b0*/ bool get_CaseSensitive();
            /*0x747b2b8*/ void set_CaseSensitive(bool value);
            /*0x747b358*/ bool get_AreIndexEventsSuspended();
            /*0x747b368*/ void RestoreIndexEvents(bool forceReset);
            /*0x747b71c*/ void SuspendIndexEvents();
            /*0x747b7c8*/ bool get_IsTypedDataTable();
            /*0x74793ac*/ bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes);
            /*0x747b878*/ bool ShouldSerializeCaseSensitive();
            /*0x747b880*/ bool get_SelfNested();
            /*0x747bc18*/ System.Collections.Generic.List<System.Data.Index> get_LiveIndexes();
            /*0x747bcc0*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x747bcc8*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x747bd28*/ int get_UKColumnPositionForInference();
            /*0x747bd30*/ void set_UKColumnPositionForInference(int value);
            /*0x747bd38*/ System.Data.DataRelationCollection get_ChildRelations();
            /*0x747bdb4*/ System.Data.DataColumnCollection get_Columns();
            /*0x747bdbc*/ System.Globalization.CompareInfo get_CompareInfo();
            /*0x747be0c*/ System.Data.ConstraintCollection get_Constraints();
            /*0x747be14*/ void ResetConstraints();
            /*0x747be30*/ System.Data.DataSet get_DataSet();
            /*0x747be38*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x747befc*/ string get_DisplayExpressionInternal();
            /*0x747bf24*/ bool get_EnforceConstraints();
            /*0x747bf54*/ void set_EnforceConstraints(bool value);
            /*0x747c56c*/ bool get_SuspendEnforceConstraints();
            /*0x747c574*/ void set_SuspendEnforceConstraints(bool value);
            /*0x747bf94*/ void EnableConstraints();
            /*0x7478718*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x747c580*/ System.IFormatProvider get_FormatProvider();
            /*0x747c620*/ System.Globalization.CultureInfo get_Locale();
            /*0x747c628*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x74796d4*/ bool SetLocaleValue(System.Globalization.CultureInfo culture, bool userSet, bool resetIndexes);
            /*0x747cae4*/ bool ShouldSerializeLocale();
            /*0x747caec*/ int get_MinimumCapacity();
            /*0x7479ccc*/ void set_MinimumCapacity(int value);
            /*0x747cb08*/ int get_RecordCapacity();
            /*0x747cb24*/ int get_ElementColumnCount();
            /*0x747cb2c*/ void set_ElementColumnCount(int value);
            /*0x747bb9c*/ System.Data.DataRelationCollection get_ParentRelations();
            /*0x747cb70*/ bool get_MergingData();
            /*0x747cb78*/ void set_MergingData(bool value);
            /*0x747cb84*/ System.Data.DataRelation[] get_NestedParentRelations();
            /*0x747cb8c*/ bool get_SchemaLoading();
            /*0x747cb94*/ void CacheNestedParent();
            /*0x747cbb4*/ System.Data.DataRelation[] FindNestedParentRelations();
            /*0x747d038*/ int get_NestedParentsCount();
            /*0x747d318*/ System.Data.DataColumn[] get_PrimaryKey();
            /*0x747d3cc*/ void set_PrimaryKey(System.Data.DataColumn[] value);
            /*0x747d834*/ System.Data.DataRowCollection get_Rows();
            /*0x747d83c*/ string get_TableName();
            /*0x747d844*/ void set_TableName(string value);
            /*0x747de08*/ string get_EncodedTableName();
            /*0x747de8c*/ string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables);
            /*0x7475df0*/ string get_Namespace();
            /*0x74783d0*/ void set_Namespace(string value);
            /*0x747eea0*/ bool IsNamespaceInherited();
            /*0x747e0d4*/ void CheckCascadingNamespaceConflict(string realNamespace);
            /*0x747e4b0*/ void CheckNamespaceValidityForNestedRelations(string realNamespace);
            /*0x747eeb0*/ void CheckNamespaceValidityForNestedParentRelations(string ns, System.Data.DataTable parentTable);
            /*0x747e8d4*/ void DoRaiseNamespaceChange();
            /*0x747f230*/ string get_Prefix();
            /*0x747f238*/ void set_Prefix(string value);
            /*0x747f394*/ System.Data.DataColumn get_XmlText();
            /*0x747f39c*/ void set_XmlText(System.Data.DataColumn value);
            /*0x747f45c*/ decimal get_MaxOccurs();
            /*0x747f468*/ void set_MaxOccurs(decimal value);
            /*0x747f470*/ decimal get_MinOccurs();
            /*0x747f47c*/ void set_MinOccurs(decimal value);
            /*0x747f484*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues, int record);
            /*0x747f514*/ System.Data.DataRow FindByIndex(System.Data.Index ndx, object[] key);
            /*0x747f5ac*/ System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx);
            /*0x747f62c*/ void SetMergeRecords(System.Data.DataRow row, int newRecord, int oldRecord, System.Data.DataRowAction action);
            /*0x747f9bc*/ System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, bool preserveChanges, System.Data.Index idxSearch);
            /*0x7480398*/ System.Data.DataTable CreateInstance();
            /*0x7480424*/ System.Data.DataTable Clone();
            /*0x748042c*/ System.Data.DataTable Clone(System.Data.DataSet cloneDS);
            /*0x7480620*/ System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable);
            /*0x7480960*/ System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap);
            /*0x74776ac*/ System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, bool skipExpressionColumns);
            /*0x7480de0*/ System.ComponentModel.ISite get_Site();
            /*0x7480de8*/ void AddRow(System.Data.DataRow row, int proposedID);
            /*0x7480df8*/ void InsertRow(System.Data.DataRow row, int proposedID, int pos);
            /*0x7480e04*/ void InsertRow(System.Data.DataRow row, long proposedID, int pos, bool fireEvent);
            /*0x748198c*/ void CheckNotModifying(System.Data.DataRow row);
            /*0x74819bc*/ void Clear();
            /*0x74819c4*/ void Clear(bool clearAll);
            /*0x74823a8*/ void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x7482460*/ void CommitRow(System.Data.DataRow row);
            /*0x7482618*/ int Compare(string s1, string s2);
            /*0x7482620*/ int Compare(string s1, string s2, System.Globalization.CompareInfo comparer);
            /*0x7482784*/ int IndexOf(string s1, string s2);
            /*0x74827c4*/ bool IsSuffix(string s1, string s2);
            /*0x7482804*/ void DeleteRow(System.Data.DataRow row);
            /*0x748285c*/ string FormatSortString(System.Data.IndexField[] indexDesc);
            /*0x7482988*/ void FreeRecord(ref int record);
            /*0x74829a4*/ System.Data.Index GetIndex(string sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x7482d48*/ System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x7482f10*/ System.Collections.Generic.List<System.Data.DataViewListener> GetListeners();
            /*0x747c9e0*/ int GetSpecialHashCode(string name);
            /*0x747feec*/ void InsertRow(System.Data.DataRow row, long proposedID);
            /*0x7483c18*/ int NewRecord();
            /*0x7483d04*/ int NewUninitializedRecord();
            /*0x7483c20*/ int NewRecord(int sourceRecord);
            /*0x747af00*/ System.Data.DataRow NewEmptyRow();
            /*0x7483d20*/ System.Data.DataRow NewUninitializedRow();
            /*0x7483dd8*/ System.Data.DataRow NewRow();
            /*0x7483e90*/ System.Data.DataRow CreateEmptyRow();
            /*0x7483e0c*/ void NewRowCreated(System.Data.DataRow row);
            /*0x7483d4c*/ System.Data.DataRow NewRow(int record);
            /*0x7484268*/ System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder);
            /*0x74842c4*/ System.Type GetRowType();
            /*0x7484324*/ System.Data.DataRow[] NewRowArray(int size);
            /*0x74844d8*/ bool get_NeedColumnChangeEvents();
            /*0x748450c*/ void OnColumnChanging(System.Data.DataColumnChangeEventArgs e);
            /*0x74845dc*/ void OnColumnChanged(System.Data.DataColumnChangeEventArgs e);
            /*0x74846ac*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x748477c*/ void OnRemoveColumnInternal(System.Data.DataColumn column);
            /*0x748478c*/ void OnRemoveColumn(System.Data.DataColumn column);
            /*0x7482574*/ System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x74824d0*/ System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x7484790*/ void OnRowChanged(System.Data.DataRowChangeEventArgs e);
            /*0x7484860*/ void OnRowChanging(System.Data.DataRowChangeEventArgs e);
            /*0x7484930*/ void OnRowDeleting(System.Data.DataRowChangeEventArgs e);
            /*0x7484a00*/ void OnRowDeleted(System.Data.DataRowChangeEventArgs e);
            /*0x7484ad0*/ void OnTableCleared(System.Data.DataTableClearEventArgs e);
            /*0x7484ba0*/ void OnTableClearing(System.Data.DataTableClearEventArgs e);
            /*0x7484c70*/ void OnTableNewRow(System.Data.DataTableNewRowEventArgs e);
            /*0x74829d8*/ System.Data.IndexField[] ParseSortString(string sortString);
            /*0x747dd90*/ void RaisePropertyChanging(string name);
            /*0x7484d40*/ void RecordChanged(int record);
            /*0x7484ebc*/ void RecordChanged(int[] oldIndex, int[] newIndex);
            /*0x74830ac*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x7483240*/ void RecordStateChanged(int record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, int record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2);
            /*0x7485094*/ int[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x7485258*/ int[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74853cc*/ void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, object newValue);
            /*0x7485cac*/ void RemoveRow(System.Data.DataRow row, bool check);
            /*0x7485e4c*/ void Reset();
            /*0x74776a4*/ void ResetIndexes();
            /*0x74860d4*/ void ResetInternalIndexes(System.Data.DataColumn column);
            /*0x74862b4*/ void RollbackRow(System.Data.DataRow row);
            /*0x7483a30*/ System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x7486328*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x7482f18*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, bool fireEvent);
            /*0x747f6e8*/ void SetNewRecord(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged);
            /*0x7481190*/ void SetNewRecordWorker(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, ref System.Exception deferredException);
            /*0x747f740*/ void SetOldRecord(System.Data.DataRow row, int proposedRecord);
            /*0x74864d8*/ void RestoreShadowIndexes();
            /*0x747b6cc*/ void SetShadowIndexes();
            /*0x74864f8*/ void ShadowIndexCopy();
            /*0x748658c*/ string ToString();
            /*0x7486300*/ bool UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x7486600*/ System.Data.DataColumn AddUniqueKey(int position);
            /*0x7486874*/ System.Data.DataColumn AddUniqueKey();
            /*0x748687c*/ System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey);
            /*0x7486928*/ void UpdatePropertyDescriptorCollectionCache();
            /*0x748693c*/ System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes);
            /*0x7478684*/ System.Xml.XmlQualifiedName get_TypeName();
            /*0x7486ba8*/ void set_TypeName(System.Xml.XmlQualifiedName value);
            /*0x7486bb8*/ void Merge(System.Data.DataTable table);
            /*0x7486bc4*/ void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x7486e34*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy);
            /*0x74871f0*/ bool CheckForClosureOnExpressions(System.Data.DataTable dt, bool writeHierarchy);
            /*0x7478788*/ bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x74876ec*/ void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy);
            /*0x7487a2c*/ void RestoreConstraint(bool originalEnforceConstraint);
            /*0x7487a80*/ bool IsEmptyXml(System.Xml.XmlReader reader);
            /*0x7487c50*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x7489624*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x74896b8*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x748ab30*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x7488c20*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x748abe4*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x7489728*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x7487304*/ void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x748ad78*/ void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList);
            /*0x748b4d4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x748b4e4*/ System.Xml.Schema.XmlSchema GetSchema();
            /*0x748b6ac*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x748b858*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x748b88c*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x748b898*/ System.Collections.Hashtable get_RowDiffId();
            /*0x748b90c*/ int get_ObjectID();
            /*0x748b914*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x748ba50*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x748bae0*/ void EvaluateExpressions();
            /*0x7483480*/ void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows);
            /*0x748be58*/ void EvaluateExpressions(System.Data.DataColumn column);
            /*0x7482248*/ void EvaluateDependentExpressions(System.Data.DataColumn column);
            /*0x748553c*/ void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows);

            struct RowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataTable _targetTable;

                /*0x74a5228*/ void Prepare(System.Data.DataTable table);
            }

            struct DSRowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataSet _targetDS;

                /*0x74a1874*/ void Prepare(System.Data.DataSet ds);
            }
        }

        class FunctionNode : System.Data.ExpressionNode
        {
            static /*0x0*/ System.Data.Function[] s_funcs;
            /*0x18*/ string _name;
            /*0x20*/ int _info;
            /*0x24*/ int _argumentCount;
            /*0x28*/ System.Data.ExpressionNode[] _arguments;
            /*0x30*/ System.Data.TypeLimiter _capturedLimiter;

            static /*0x74a8448*/ FunctionNode();
            /*0x74a5254*/ FunctionNode(System.Data.DataTable table, string name);
            /*0x74a53ac*/ void AddArgument(System.Data.ExpressionNode argument);
            /*0x74a5598*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74a5a30*/ object Eval();
            /*0x74a5a44*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74a7cf4*/ object Eval(int[] recordNos);
            /*0x74a7d28*/ bool IsConstant();
            /*0x74a7db8*/ bool IsTableConstant();
            /*0x74a7e34*/ bool HasLocalAggregate();
            /*0x74a7eb0*/ bool HasRemoteAggregate();
            /*0x74a7f2c*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74a7fb4*/ System.Data.ExpressionNode Optimize();
            /*0x74a634c*/ System.Type GetDataType(System.Data.ExpressionNode node);
            /*0x74a65cc*/ object EvalFunction(System.Data.FunctionId id, object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74a8178*/ System.Data.FunctionId get_Aggregate();
            /*0x74a8214*/ bool get_IsAggregate();
            /*0x74a5884*/ void Check();
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

            static /*0x74a90ac*/ Function();
            /*0x74a8e6c*/ Function(string name, System.Data.FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3);
        }

        class TypeLimiter
        {
            [ThreadStatic] static System.Data.TypeLimiter.Scope s_activeScope;
            /*0x10*/ System.Data.TypeLimiter.Scope m_instanceScope;

            static /*0x74a991c*/ bool get_IsTypeLimitingDisabled();
            static /*0x74a9994*/ System.Data.TypeLimiter Capture();
            static /*0x74a9a10*/ void EnsureTypeIsAllowed(System.Type type, System.Data.TypeLimiter capturedLimiter);
            static /*0x74a9c34*/ System.IDisposable EnterRestrictedScope(System.Data.DataSet dataSet);
            static /*0x74aa014*/ System.IDisposable EnterRestrictedScope(System.Data.DataTable dataTable);
            static /*0x74aa0d4*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataTable dataTable);
            static /*0x74a9cf4*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataSet dataSet);
            /*0x74a98ec*/ TypeLimiter(System.Data.TypeLimiter.Scope scope);

            class Scope : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.HashSet<System.Type> s_allowedTypes;
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> m_allowedTypes;
                /*0x18*/ System.Data.TypeLimiter.Scope m_previousScope;

                static /*0x74aa4fc*/ Scope();
                static /*0x74aa344*/ bool IsTypeUnconditionallyAllowed(System.Type type);
                /*0x74a9e90*/ Scope(System.Data.TypeLimiter.Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes);
                /*0x74aa270*/ void Dispose();
                /*0x74a9aa8*/ bool IsAllowedType(System.Type type);

                class <>c
                {
                    static /*0x0*/ System.Data.TypeLimiter.Scope.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__3_0;

                    static /*0x74aad34*/ <>c();
                    /*0x74aad9c*/ <>c();
                    /*0x74aada4*/ bool <.ctor>b__3_0(System.Type type);
                }
            }

            class <>c
            {
                static /*0x0*/ System.Data.TypeLimiter.<> <>9;
                static /*0x8*/ System.Func<System.Data.DataColumn, System.Type> <>9__10_0;
                static /*0x10*/ System.Func<System.Data.DataTable, System.Collections.Generic.IEnumerable<System.Type>> <>9__11_0;

                static /*0x74aadd8*/ <>c();
                /*0x74aae40*/ <>c();
                /*0x74aae48*/ System.Type <GetPreviouslyDeclaredDataTypes>b__10_0(System.Data.DataColumn column);
                /*0x74aae60*/ System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(System.Data.DataTable table);
            }
        }

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

            static /*0x74aafd0*/ InternalDataCollectionBase();
            /*0x74aafc8*/ InternalDataCollectionBase();
            /*0x74aae68*/ int get_Count();
            /*0x74aae94*/ void CopyTo(System.Array ar, int index);
            /*0x74aaedc*/ System.Collections.IEnumerator GetEnumerator();
            /*0x74aaf08*/ bool get_IsSynchronized();
            /*0x74aaf10*/ int NamesEqual(string s1, string s2, bool fCaseSensitive, System.Globalization.CultureInfo locale);
            /*0x74aafbc*/ object get_SyncRoot();
            /*0x74aafc0*/ System.Collections.ArrayList get_List();
        }

        class ColumnTypeConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.Type[] s_types;
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            static /*0x74ab950*/ ColumnTypeConverter();
            /*0x74ab054*/ ColumnTypeConverter();
            /*0x74ab05c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74ab10c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x74ab5b8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x74ab644*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x74ab820*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x74ab940*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x74ab948*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataCommonEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Data.DataCommonEventSource Log;
            static /*0x8*/ long s_nextScopeId;

            static /*0x74ac618*/ DataCommonEventSource();
            /*0x74ac610*/ DataCommonEventSource();
            /*0x74ac52c*/ void Trace(string message);
            /*0x3910ae8*/ void Trace<T0>(string format, T0 arg0);
            /*0x3910ae8*/ void Trace<T0, T1>(string format, T0 arg0, T1 arg1);
            /*0x3910ae8*/ void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2);
            /*0x3910ae8*/ void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            /*0x3910ae8*/ void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x3910ae8*/ void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x74ac53c*/ long EnterScope(string message);
            /*0x3910ae8*/ long EnterScope<T1>(string format, T1 arg1);
            /*0x3910ae8*/ long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2);
            /*0x3910ae8*/ long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
            /*0x3910ae8*/ long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x74ac600*/ void ExitScope(long scopeId);
        }

        class Constraint
        {
            /*0x10*/ string _schemaName;
            /*0x18*/ bool _inCollection;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ string _name;
            /*0x30*/ System.Data.PropertyCollection _extendedProperties;

            /*0x74acd88*/ Constraint();
            /*0x74ac690*/ string get_ConstraintName();
            /*0x74ac698*/ void set_ConstraintName(string value);
            /*0x74acaec*/ string get_SchemaName();
            /*0x74acb24*/ void set_SchemaName(string value);
            /*0x74acb68*/ bool get_InCollection();
            /*0x74acb70*/ void set_InCollection(bool value);
            /*0x38148bc*/ System.Data.DataTable get_Table();
            /*0x74acbb8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x38141c4*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x3813ffc*/ bool CanEnableConstraint();
            /*0x3814a3c*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x3814a74*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignoreNSforTableLookup);
            /*0x74acc28*/ void CheckConstraint();
            /*0x3816710*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraint);
            bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, bool fThrowException);
            /*0x381678c*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x38159dc*/ void CheckState();
            /*0x74acc7c*/ void CheckStateForProperty();
            /*0x74acd74*/ System.Data.DataSet get__DataSet();
            /*0x3813ffc*/ bool IsConstraintViolated();
            /*0x74acd7c*/ string ToString();
        }

        class ConstraintCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;
            /*0x30*/ System.Data.Constraint[] _delayLoadingConstraints;
            /*0x38*/ bool _fLoadForeignKeyConstraintsOnly;

            static /*0x74ae69c*/ bool CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2);
            /*0x74acddc*/ ConstraintCollection(System.Data.DataTable table);
            /*0x74ace94*/ System.Collections.ArrayList get_List();
            /*0x74ace9c*/ System.Data.Constraint get_Item(int index);
            /*0x74acf98*/ System.Data.DataTable get_Table();
            /*0x74acfa0*/ System.Data.Constraint get_Item(string name);
            /*0x74ad1e8*/ void Add(System.Data.Constraint constraint);
            /*0x74ad1f0*/ void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign);
            /*0x74adb74*/ System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey);
            /*0x74ad7d0*/ void AddUniqueConstraint(System.Data.UniqueConstraint constraint);
            /*0x74ad9dc*/ void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint);
            /*0x74ad700*/ bool AutoGenerated(System.Data.Constraint constraint);
            /*0x74adb14*/ void ArrayAdd(System.Data.Constraint constraint);
            /*0x74adc1c*/ void ArrayRemove(System.Data.Constraint constraint);
            /*0x74ad9b8*/ string AssignName();
            /*0x74ada4c*/ void BaseAdd(System.Data.Constraint constraint);
            /*0x74add0c*/ void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength);
            /*0x74adec0*/ void BaseRemove(System.Data.Constraint constraint);
            /*0x74ae16c*/ bool CanRemove(System.Data.Constraint constraint, bool fThrowException);
            /*0x74ae19c*/ void Clear();
            /*0x74ae588*/ bool Contains(string name);
            /*0x74ae5a0*/ bool Contains(string name, bool caseSensitive);
            /*0x74ad5a4*/ System.Data.Constraint FindConstraint(System.Data.Constraint constraint);
            /*0x74ad8ac*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns);
            /*0x74ae724*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column);
            /*0x74ae830*/ System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74ad08c*/ int InternalIndexOf(string constraintName);
            /*0x74adc54*/ string MakeName(int index);
            /*0x74adb4c*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74ac884*/ void RegisterName(string name);
            /*0x74ae960*/ void Remove(System.Data.Constraint constraint);
            /*0x74aca6c*/ void UnregisterName(string name);
        }

        class ConstraintConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x74aeabc*/ ConstraintConverter();
            /*0x74aeac4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74aeb74*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class ConstraintEnumerator
        {
            /*0x10*/ System.Collections.IEnumerator _tables;
            /*0x18*/ System.Collections.IEnumerator _constraints;
            /*0x20*/ System.Data.Constraint _currentObject;

            /*0x74af5b8*/ ConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x74af620*/ bool GetNext();
            /*0x74af94c*/ System.Data.Constraint GetConstraint();
            /*0x74af954*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x74af95c*/ System.Data.Constraint get_CurrentObject();
        }

        class ForeignKeyConstraintEnumerator : System.Data.ConstraintEnumerator
        {
            /*0x74af964*/ ForeignKeyConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x74af968*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x74af9e0*/ System.Data.ForeignKeyConstraint GetForeignKeyConstraint();
        }

        class ChildForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x74afa58*/ ChildForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x74afa84*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class ParentForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x74afb18*/ ParentForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x74afb44*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class DataColumnChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataColumn _column;
            /*0x18*/ System.Data.DataRow <Row>k__BackingField;
            /*0x20*/ object <ProposedValue>k__BackingField;

            /*0x74afbdc*/ DataColumnChangeEventArgs(System.Data.DataRow row);
            /*0x74afc50*/ DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value);
            /*0x74afcf4*/ object get_ProposedValue();
            /*0x74afcfc*/ void set_ProposedValue(object value);
            /*0x74afd04*/ void InitializeColumnChangeEvent(System.Data.DataColumn column, object value);
        }

        class DataColumnChangeEventHandler : System.MulticastDelegate
        {
            /*0x74afd34*/ DataColumnChangeEventHandler(object object, nint method);
            /*0x74afe40*/ void Invoke(object sender, System.Data.DataColumnChangeEventArgs e);
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

            /*0x74afe54*/ DataColumnCollection(System.Data.DataTable table);
            /*0x74affc8*/ System.Collections.ArrayList get_List();
            /*0x74affd0*/ System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking();
            /*0x74affd8*/ int get_ColumnsImplementingIChangeTrackingCount();
            /*0x74affe0*/ int get_ColumnsImplementingIRevertibleChangeTrackingCount();
            /*0x74affe8*/ System.Data.DataColumn get_Item(int index);
            /*0x74b0118*/ System.Data.DataColumn get_Item(string name);
            /*0x74b03b8*/ System.Data.DataColumn get_Item(string name, string ns);
            /*0x74b045c*/ void Add(System.Data.DataColumn column);
            /*0x74b0468*/ void AddAt(int index, System.Data.DataColumn column);
            /*0x74b0b14*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b0bb0*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b0c4c*/ void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b0ce8*/ void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b0a04*/ void ArrayAdd(System.Data.DataColumn column);
            /*0x74b09c4*/ void ArrayAdd(int index, System.Data.DataColumn column);
            /*0x74b0dcc*/ void ArrayRemove(System.Data.DataColumn column);
            /*0x74b1014*/ string AssignName();
            /*0x74b06ec*/ void BaseAdd(System.Data.DataColumn column);
            /*0x74b13dc*/ void BaseGroupSwitch(System.Data.DataColumn[] oldArray, int oldLength, System.Data.DataColumn[] newArray, int newLength);
            /*0x74b15bc*/ void BaseRemove(System.Data.DataColumn column);
            /*0x74b1674*/ bool CanRemove(System.Data.DataColumn column, bool fThrowException);
            /*0x74b0d84*/ void CheckIChangeTracking(System.Data.DataColumn column);
            /*0x74b1ed4*/ void Clear();
            /*0x74b21b4*/ bool Contains(string name);
            /*0x74b2248*/ bool Contains(string name, bool caseSensitive);
            /*0x74b22e4*/ int IndexOf(string columnName);
            /*0x74b0268*/ int IndexOfCaseInsensitive(string name);
            /*0x74b10a8*/ string MakeName(int index);
            /*0x74b0a70*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74b06c4*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74b23e4*/ void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74b1160*/ void RegisterColumnName(string name, System.Data.DataColumn column);
            /*0x74b243c*/ bool CanRegisterName(string name);
            /*0x74b24a0*/ void Remove(System.Data.DataColumn column);
            /*0x74b1320*/ void UnregisterName(string name);
            /*0x74b1df8*/ void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
            /*0x74b0efc*/ void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
        }

        class DataColumnPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataColumn <Column>k__BackingField;

            /*0x74b25ac*/ DataColumnPropertyDescriptor(System.Data.DataColumn dataColumn);
            /*0x74b25ec*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x74b279c*/ System.Data.DataColumn get_Column();
            /*0x74b27a4*/ System.Type get_ComponentType();
            /*0x74b2804*/ bool get_IsReadOnly();
            /*0x74b2820*/ System.Type get_PropertyType();
            /*0x74b283c*/ bool Equals(object other);
            /*0x74b28ac*/ int GetHashCode();
            /*0x74b28cc*/ bool CanResetValue(object component);
            /*0x74b2a14*/ object GetValue(object component);
            /*0x74b2a9c*/ void ResetValue(object component);
            /*0x74b2bec*/ void SetValue(object component, object value);
            /*0x74b2ccc*/ bool ShouldSerializeValue(object component);
        }

        class DataError
        {
            /*0x10*/ string _rowError;
            /*0x18*/ int _count;
            /*0x20*/ System.Data.DataError.ColumnError[] _errorList;

            /*0x74b2cd4*/ DataError();
            /*0x74b2d08*/ DataError(string rowError);
            /*0x74b2d98*/ string get_Text();
            /*0x74b2da0*/ void set_Text(string value);
            /*0x74b2dc0*/ bool get_HasErrors();
            /*0x74b2df4*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x74b3128*/ string GetColumnError(System.Data.DataColumn column);
            /*0x74b2f24*/ void Clear(System.Data.DataColumn column);
            /*0x74b3194*/ void Clear();
            /*0x74b3210*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x74b2d78*/ void SetText(string errorText);
            /*0x74b2fd0*/ int IndexOf(System.Data.DataColumn column);

            struct ColumnError
            {
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ string _error;
            }
        }

        struct DataKey
        {
            /*0x10*/ System.Data.DataColumn[] _columns;

            static /*0x74b35dc*/ bool ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2);
            /*0x74b330c*/ DataKey(System.Data.DataColumn[] columns, bool copyColumns);
            /*0x74b35bc*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x74b35c4*/ bool get_HasValue();
            /*0x74af588*/ System.Data.DataTable get_Table();
            /*0x74b3524*/ void CheckState();
            /*0x74b35d4*/ bool ColumnsEqual(System.Data.DataKey key);
            /*0x74b1d68*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x74b36f4*/ int GetHashCode();
            /*0x74b3758*/ bool Equals(object value);
            /*0x74b37d0*/ bool Equals(System.Data.DataKey value);
            /*0x74b3888*/ string[] GetColumnNames();
            /*0x74b3954*/ System.Data.IndexField[] GetIndexDesc();
            /*0x74b3a40*/ object[] GetKeyValues(int record);
            /*0x74b3b50*/ System.Data.Index GetSortIndex();
            /*0x74b3b58*/ System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates);
            /*0x74b3bb0*/ bool RecordsEqual(int record1, int record2);
            /*0x74b3c34*/ System.Data.DataColumn[] ToArray();
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

            static /*0x74b46cc*/ bool IsKeyNull(object[] values);
            static /*0x74b4790*/ System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version);
            static /*0x74b484c*/ System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            static /*0x74b48e4*/ System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            /*0x74b3d2c*/ DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints);
            /*0x74b4254*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74b425c*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x74b4318*/ DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x74b442c*/ DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x74b4570*/ System.Data.DataColumn[] get_ChildColumns();
            /*0x74b4674*/ System.Data.DataColumn[] get_ChildColumnsReference();
            /*0x74b1dc8*/ System.Data.DataKey get_ChildKey();
            /*0x74b468c*/ System.Data.DataTable get_ChildTable();
            /*0x74b46a4*/ System.Data.DataSet get_DataSet();
            /*0x74b46bc*/ string[] get_ParentColumnNames();
            /*0x74b46c4*/ string[] get_ChildColumnNames();
            /*0x74b4ac0*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x74b4ad8*/ System.Data.DataColumn[] get_ParentColumns();
            /*0x74b4af0*/ System.Data.DataColumn[] get_ParentColumnsReference();
            /*0x74b1de0*/ System.Data.DataKey get_ParentKey();
            /*0x74b4af8*/ System.Data.DataTable get_ParentTable();
            /*0x74b4b10*/ string get_RelationName();
            /*0x74b4b28*/ void CheckNamespaceValidityForNestedRelations(string ns);
            /*0x74b4ecc*/ void CheckNestedRelations();
            /*0x74b52e4*/ bool get_Nested();
            /*0x74b52fc*/ void set_Nested(bool value);
            /*0x74b69c8*/ System.Data.UniqueConstraint get_ParentKeyConstraint();
            /*0x74b69e0*/ void SetParentKeyConstraint(System.Data.UniqueConstraint value);
            /*0x74b69e8*/ System.Data.ForeignKeyConstraint get_ChildKeyConstraint();
            /*0x74b6a00*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x74b6a70*/ bool get_CheckMultipleNested();
            /*0x74b6a78*/ void set_CheckMultipleNested(bool value);
            /*0x74b6a84*/ void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value);
            /*0x74b6a8c*/ void CheckState();
            /*0x74b4588*/ void CheckStateForProperty();
            /*0x74b3f38*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x74b6cbc*/ System.Data.DataRelation Clone(System.Data.DataSet destination);
            /*0x74b7424*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x74b6880*/ void RaisePropertyChanging(string name);
            /*0x74b74f4*/ string ToString();
            /*0x74b63b0*/ void ValidateMultipleNestedRelations();
            /*0x74b7500*/ bool IsAutoGenerated(System.Data.DataColumn col);
            /*0x74b76b8*/ int get_ObjectID();
        }

        class DataRelationCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataRelation _inTransition;
            /*0x18*/ int _defaultNameIndex;
            /*0x20*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x30*/ int _objectID;

            /*0x74b8bec*/ DataRelationCollection();
            /*0x74b76c0*/ int get_ObjectID();
            /*0x3814964*/ System.Data.DataRelation get_Item(int index);
            /*0x3814a3c*/ System.Data.DataRelation get_Item(string name);
            /*0x74b76c8*/ void Add(System.Data.DataRelation relation);
            /*0x74b7980*/ void AddCore(System.Data.DataRelation relation);
            /*0x74b7c28*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b7d30*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74b7e38*/ string AssignName();
            /*0x74b7f14*/ void Clear();
            /*0x74b817c*/ bool Contains(string name);
            /*0x74b8194*/ int InternalIndexOf(string name);
            /*0x38148bc*/ System.Data.DataSet GetDataSet();
            /*0x74b7e5c*/ string MakeName(int index);
            /*0x74b830c*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74b83dc*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74b84ac*/ void RegisterName(string name);
            /*0x74b8668*/ void Remove(System.Data.DataRelation relation);
            /*0x74b8864*/ void RemoveAt(int index);
            /*0x74b88d8*/ void RemoveCore(System.Data.DataRelation relation);
            /*0x74b8ac0*/ void UnregisterName(string name);

            class DataTableRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataTable _table;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ bool _fParentCollection;
                /*0x50*/ System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;

                /*0x74b8c7c*/ DataTableRelationCollection(System.Data.DataTable table, bool fParentCollection);
                /*0x74b8d34*/ System.Collections.ArrayList get_List();
                /*0x74b8d3c*/ void EnsureDataSet();
                /*0x74b8d80*/ System.Data.DataSet GetDataSet();
                /*0x74b8da4*/ System.Data.DataRelation get_Item(int index);
                /*0x74b8ea4*/ System.Data.DataRelation get_Item(string name);
                /*0x74b8f90*/ void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x74b902c*/ void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x74b90c8*/ void AddCache(System.Data.DataRelation relation);
                /*0x74b9110*/ void AddCore(System.Data.DataRelation relation);
                /*0x74b91d0*/ void RemoveCache(System.Data.DataRelation relation);
                /*0x74b92a4*/ void RemoveCore(System.Data.DataRelation relation);
            }

            class DataSetRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataSet _dataSet;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ System.Data.DataRelation[] _delayLoadingRelations;

                /*0x74b9364*/ DataSetRelationCollection(System.Data.DataSet dataSet);
                /*0x74b9408*/ System.Collections.ArrayList get_List();
                /*0x74b9410*/ void Clear();
                /*0x74b9454*/ System.Data.DataSet GetDataSet();
                /*0x74b945c*/ System.Data.DataRelation get_Item(int index);
                /*0x74b955c*/ System.Data.DataRelation get_Item(string name);
                /*0x74b9648*/ void AddCore(System.Data.DataRelation relation);
                /*0x74b9bc4*/ void RemoveCore(System.Data.DataRelation relation);
            }
        }

        class DataRelationPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataRelation <Relation>k__BackingField;

            /*0x74b9e1c*/ DataRelationPropertyDescriptor(System.Data.DataRelation dataRelation);
            /*0x74b9e70*/ System.Data.DataRelation get_Relation();
            /*0x74b9e78*/ System.Type get_ComponentType();
            /*0x74b9ed8*/ bool get_IsReadOnly();
            /*0x74b9ee0*/ System.Type get_PropertyType();
            /*0x74b9f40*/ bool Equals(object other);
            /*0x74b9fb0*/ int GetHashCode();
            /*0x74b9fd0*/ bool CanResetValue(object component);
            /*0x74b9fd8*/ object GetValue(object component);
            /*0x74ba06c*/ void ResetValue(object component);
            /*0x74ba070*/ void SetValue(object component, object value);
            /*0x74ba074*/ bool ShouldSerializeValue(object component);
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

            /*0x74ba07c*/ DataRow(System.Data.DataRowBuilder builder);
            /*0x74ba130*/ System.Data.DataColumn get_LastChangedColumn();
            /*0x74ba14c*/ void set_LastChangedColumn(System.Data.DataColumn value);
            /*0x74ba160*/ bool get_HasPropertyChanged();
            /*0x74ba170*/ int get_RBTreeNodeId();
            /*0x74ba178*/ void set_RBTreeNodeId(int value);
            /*0x74ba228*/ string get_RowError();
            /*0x74ba250*/ void set_RowError(string value);
            /*0x74ba3a4*/ void RowErrorChanged();
            /*0x74ba3f4*/ long get_rowID();
            /*0x74ba3fc*/ void set_rowID(long value);
            /*0x74ba454*/ System.Data.DataRowState get_RowState();
            /*0x74ba678*/ System.Data.DataTable get_Table();
            /*0x74b68ec*/ void CheckForLoops(System.Data.DataRelation rel);
            /*0x74ba680*/ int GetNestedParentCount();
            /*0x74ba748*/ void set_Item(string columnName, object value);
            /*0x74ba63c*/ object get_Item(System.Data.DataColumn column);
            /*0x74ba7dc*/ void set_Item(System.Data.DataColumn column, object value);
            /*0x74bae34*/ object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version);
            /*0x74baed8*/ void set_ItemArray(object[] value);
            /*0x74bb2c0*/ void AcceptChanges();
            /*0x74bb640*/ void BeginEdit();
            /*0x74babb8*/ bool BeginEditInternal();
            /*0x74baccc*/ void CancelEdit();
            /*0x74baadc*/ void CheckColumn(System.Data.DataColumn column);
            /*0x74bb644*/ void CheckInTable();
            /*0x74bb680*/ void Delete();
            /*0x74bad34*/ void EndEdit();
            /*0x74bb6e0*/ void SetColumnError(int columnIndex, string error);
            /*0x74bb744*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x74bb978*/ string GetColumnError(System.Data.DataColumn column);
            /*0x74bba24*/ void ClearErrors();
            /*0x74b1d40*/ void ClearError(System.Data.DataColumn column);
            /*0x74bba4c*/ bool get_HasErrors();
            /*0x74bba90*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x74bbb34*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation);
            /*0x74bbb3c*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74ba774*/ System.Data.DataColumn GetDataColumn(string columnName);
            /*0x74b69c0*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation);
            /*0x74bbc58*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74bbd64*/ System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version);
            /*0x74bbe20*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation);
            /*0x74bbe28*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74bbf44*/ object[] GetColumnValues(System.Data.DataColumn[] columns);
            /*0x74bbf4c*/ object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version);
            /*0x74bbf9c*/ object[] GetKeyValues(System.Data.DataKey key);
            /*0x74b4828*/ object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version);
            /*0x74bbfbc*/ int GetCurrentRecordNo();
            /*0x74bab54*/ int GetDefaultRecord();
            /*0x74bbff8*/ int GetOriginalRecordNo();
            /*0x74bac90*/ int GetProposedRecordNo();
            /*0x74bae78*/ int GetRecordFromVersion(System.Data.DataRowVersion version);
            /*0x74bc034*/ System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState);
            /*0x74bc070*/ System.Data.DataViewRowState GetRecordState(int record);
            /*0x74bc0c8*/ bool HasKeyChanged(System.Data.DataKey key);
            /*0x74bc0d4*/ bool HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x74b4a38*/ bool HasVersion(System.Data.DataRowVersion version);
            /*0x74bc158*/ bool HaveValuesChanged(System.Data.DataColumn[] columns);
            /*0x74bc164*/ bool HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x74bc20c*/ void RejectChanges();
            /*0x74ba430*/ void ResetLastChangedColumn();
            /*0x74bc800*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues);
            /*0x74bc918*/ void SetNestedParentRow(System.Data.DataRow parentRow, bool setNonNested);
            /*0x74bcd0c*/ void SetParentRowToDBNull();
            /*0x74bcff0*/ void SetParentRowToDBNull(System.Data.DataRelation relation);
            /*0x74bd168*/ int CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, int storeIndex);
        }

        class DataRowBuilder
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _record;

            /*0x74bd454*/ DataRowBuilder(System.Data.DataTable table, int record);
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

            /*0x74bd490*/ DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action);
        }

        class DataRowChangeEventHandler : System.MulticastDelegate
        {
            /*0x74bd510*/ DataRowChangeEventHandler(object object, nint method);
            /*0x74bd61c*/ void Invoke(object sender, System.Data.DataRowChangeEventArgs e);
        }

        class DataRowCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataRowCollection.DataRowTree _list;
            /*0x20*/ int _nullInList;

            /*0x74bd630*/ DataRowCollection(System.Data.DataTable table);
            /*0x74bd724*/ int get_Count();
            /*0x74b1ce8*/ System.Data.DataRow get_Item(int index);
            /*0x74bd774*/ void Add(System.Data.DataRow row);
            /*0x74bd794*/ void DiffInsertAt(System.Data.DataRow row, int pos);
            /*0x74bd99c*/ int IndexOf(System.Data.DataRow row);
            /*0x74bda34*/ System.Data.DataRow AddWithColumnEvents(object[] values);
            /*0x74bda94*/ void ArrayAdd(System.Data.DataRow row);
            /*0x74bdafc*/ void ArrayInsert(System.Data.DataRow row, int pos);
            /*0x74bdb74*/ void ArrayClear();
            /*0x74bdbc4*/ void ArrayRemove(System.Data.DataRow row);
            /*0x74bdc58*/ void CopyTo(System.Array ar, int index);
            /*0x74bdcc0*/ void CopyTo(System.Data.DataRow[] array, int index);
            /*0x74bdd28*/ System.Collections.IEnumerator GetEnumerator();

            class DataRowTree : System.Data.RBTree<System.Data.DataRow>
            {
                /*0x74bd6d8*/ DataRowTree();
                /*0x74bdd78*/ int CompareNode(System.Data.DataRow record1, System.Data.DataRow record2);
                /*0x74bdda4*/ int CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2);
            }
        }

        class DataRowCreatedEventHandler : System.MulticastDelegate
        {
            /*0x74bddd0*/ DataRowCreatedEventHandler(object object, nint method);
            /*0x74bdedc*/ void Invoke(object sender, System.Data.DataRow r);
        }

        class DataSetClearEventhandler : System.MulticastDelegate
        {
            /*0x74bdef0*/ DataSetClearEventhandler(object object, nint method);
            /*0x74bdffc*/ void Invoke(object sender, System.Data.DataTable table);
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

            static /*0x74be690*/ DataRowView();
            /*0x74be010*/ DataRowView(System.Data.DataView dataView, System.Data.DataRow row);
            /*0x74be054*/ bool Equals(object other);
            /*0x74be060*/ int GetHashCode();
            /*0x74be080*/ System.Data.DataView get_DataView();
            /*0x74be088*/ System.Data.DataRowVersion get_RowVersionDefault();
            /*0x74be0e0*/ int GetRecord();
            /*0x74be104*/ bool HasRecord();
            /*0x74b29e0*/ object GetColumnValue(System.Data.DataColumn column);
            /*0x74b2b60*/ void SetColumnValue(System.Data.DataColumn column, object value);
            /*0x74be128*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent);
            /*0x74ba064*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation);
            /*0x74be2c4*/ System.Data.DataRow get_Row();
            /*0x74be2cc*/ void EndEdit();
            /*0x74be318*/ bool get_IsNew();
            /*0x74be340*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x74be3dc*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x74be478*/ void RaisePropertyChangedEvent(string propName);
            /*0x74be508*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
            /*0x74be560*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
            /*0x74be568*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
            /*0x74be604*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
            /*0x74be68c*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        enum SerializationFormat
        {
            Xml = 0,
            Binary = 1,
        }

        enum DataSetDateTime
        {
            Local = 1,
            Unspecified = 2,
            UnspecifiedLocal = 3,
            Utc = 4,
        }

        class DataTableClearEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;

            /*0x74be710*/ DataTableClearEventArgs(System.Data.DataTable dataTable);
        }

        class DataTableClearEventHandler : System.MulticastDelegate
        {
            /*0x74be784*/ DataTableClearEventHandler(object object, nint method);
            /*0x74be890*/ void Invoke(object sender, System.Data.DataTableClearEventArgs e);
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

            /*0x74be8a4*/ DataTableCollection(System.Data.DataSet dataSet);
            /*0x74bea0c*/ System.Collections.ArrayList get_List();
            /*0x74bea14*/ int get_ObjectID();
            /*0x74bea1c*/ System.Data.DataTable get_Item(int index);
            /*0x74beb4c*/ System.Data.DataTable get_Item(string name);
            /*0x74b731c*/ System.Data.DataTable get_Item(string name, string tableNamespace);
            /*0x74bef94*/ System.Data.DataTable GetTable(string name, string ns);
            /*0x74bf0b0*/ System.Data.DataTable GetTableSmart(string name, string ns);
            /*0x74bf1ec*/ void Add(System.Data.DataTable table);
            /*0x74bf66c*/ void ArrayAdd(System.Data.DataTable table);
            /*0x74bf760*/ string AssignName();
            /*0x74bf558*/ void BaseAdd(System.Data.DataTable table);
            /*0x74bfad8*/ void BaseGroupSwitch(System.Data.DataTable[] oldArray, int oldLength, System.Data.DataTable[] newArray, int newLength);
            /*0x74bfc50*/ void BaseRemove(System.Data.DataTable table);
            /*0x74bfcc8*/ bool CanRemove(System.Data.DataTable table, bool fThrowException);
            /*0x74c0250*/ void Clear();
            /*0x74bf860*/ bool Contains(string name);
            /*0x74c0528*/ bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive);
            /*0x74c069c*/ bool Contains(string name, bool caseSensitive);
            /*0x74c07c4*/ int IndexOf(System.Data.DataTable table);
            /*0x74c08a8*/ int IndexOf(string tableName);
            /*0x74c08c0*/ int IndexOf(string tableName, string tableNamespace, bool chekforNull);
            /*0x74c0920*/ void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x74bec40*/ int InternalIndexOf(string tableName);
            /*0x74bee08*/ int InternalIndexOf(string tableName, string tableNamespace);
            /*0x74bf7a8*/ string MakeName(int index);
            /*0x74bf690*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74bf488*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74bf878*/ void RegisterName(string name, string tbNamespace);
            /*0x74c0970*/ void Remove(System.Data.DataTable table);
            /*0x74c0144*/ void UnregisterName(string name);
        }

        class DataTableNewRowEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;

            /*0x74c0b6c*/ DataTableNewRowEventArgs(System.Data.DataRow dataRow);
        }

        class DataTableNewRowEventHandler : System.MulticastDelegate
        {
            /*0x74c0be0*/ DataTableNewRowEventHandler(object object, nint method);
            /*0x74c0cec*/ void Invoke(object sender, System.Data.DataTableNewRowEventArgs e);
        }

        class DataTableTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x74c0d00*/ DataTableTypeConverter();
            /*0x74c0da0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
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

            static /*0x74c3e94*/ DataView();
            /*0x74c0da8*/ DataView(System.Data.DataTable table, bool locked);
            /*0x74c12e8*/ bool get_AllowDelete();
            /*0x74c12f0*/ bool get_AllowNew();
            /*0x74c12f8*/ int get_Count();
            /*0x74c1348*/ int get_CountFromIndex();
            /*0x74c1364*/ System.Data.DataViewManager get_DataViewManager();
            /*0x74c136c*/ bool get_IsOpen();
            /*0x74c1374*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x74c137c*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x74c1384*/ string get_Sort();
            /*0x74c13d8*/ System.Comparison<System.Data.DataRow> get_SortComparison();
            /*0x74c13e0*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x74c13e4*/ System.Data.DataTable get_Table();
            /*0x74c13ec*/ object System.Collections.IList.get_Item(int recordIndex);
            /*0x74c1424*/ void System.Collections.IList.set_Item(int recordIndex, object value);
            /*0x74c1408*/ System.Data.DataRowView get_Item(int recordIndex);
            /*0x74c1540*/ System.Data.DataRowView AddNew();
            /*0x74c1824*/ void CheckOpen();
            /*0x74c192c*/ void Close();
            /*0x74c1980*/ void CopyTo(System.Array array, int index);
            /*0x74c1b04*/ void CopyTo(System.Data.DataRowView[] array, int index);
            /*0x74c1cc4*/ void Delete(int index);
            /*0x74c1ce0*/ void Delete(System.Data.DataRow row);
            /*0x74c2060*/ void Dispose(bool disposing);
            /*0x74c1eac*/ void FinishAddNew(bool success);
            /*0x74c2094*/ System.Collections.IEnumerator GetEnumerator();
            /*0x74c2110*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x74c2118*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x74c2120*/ int System.Collections.IList.Add(object value);
            /*0x74c2174*/ void System.Collections.IList.Clear();
            /*0x74c219c*/ bool System.Collections.IList.Contains(object value);
            /*0x74c2228*/ int System.Collections.IList.IndexOf(object value);
            /*0x74c185c*/ int IndexOf(System.Data.DataRowView rowview);
            /*0x74c22a8*/ int IndexOfDataRowView(System.Data.DataRowView rowview);
            /*0x74c2300*/ void System.Collections.IList.Insert(int index, object value);
            /*0x74c2328*/ void System.Collections.IList.Remove(object value);
            /*0x74c2448*/ void System.Collections.IList.RemoveAt(int index);
            /*0x74c2464*/ System.Data.IFilter GetFilter();
            /*0x74c246c*/ int GetRecord(int recordIndex);
            /*0x74c144c*/ System.Data.DataRow GetRow(int index);
            /*0x74c1ad0*/ System.Data.DataRowView GetRowView(int record);
            /*0x74c14e8*/ System.Data.DataRowView GetRowView(System.Data.DataRow dr);
            /*0x74c24f4*/ void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0x74c2584*/ void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e);
            /*0x74c2644*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x74c2afc*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74c2e08*/ void Reset();
            /*0x74c28b4*/ void ResetRowViewCache();
            /*0x74c2e34*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x74c307c*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
            /*0x74c3084*/ void SetIndex2(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, bool fireEvent);
            /*0x74c1964*/ void UpdateIndex();
            /*0x74c3610*/ void UpdateIndex(bool force);
            /*0x74c32e8*/ void UpdateIndex(bool force, bool fireEvent);
            /*0x74c3810*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c3a34*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c3c58*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c3e7c*/ void ColumnCollectionChangedInternal(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c3e8c*/ int get_ObjectID();

            class DataRowReferenceComparer : System.Collections.Generic.IEqualityComparer<System.Data.DataRow>
            {
                static /*0x0*/ System.Data.DataView.DataRowReferenceComparer s_default;

                static /*0x74c3f44*/ DataRowReferenceComparer();
                /*0x74c3f18*/ DataRowReferenceComparer();
                /*0x74c3f20*/ bool Equals(System.Data.DataRow x, System.Data.DataRow y);
                /*0x74c3f2c*/ int GetHashCode(System.Data.DataRow obj);
            }
        }

        class DataViewListener
        {
            /*0x10*/ System.WeakReference _dvWeak;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ System.Data.Index _index;
            /*0x28*/ int _objectID;

            /*0x74c107c*/ DataViewListener(System.Data.DataView dv);
            /*0x74c3fac*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c4078*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c4128*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74c41f4*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x74c42c0*/ void IndexListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74c1100*/ void RegisterMetaDataEvents(System.Data.DataTable table);
            /*0x74c1978*/ void UnregisterMetaDataEvents();
            /*0x74c4590*/ void UnregisterMetaDataEvents(bool updateListeners);
            /*0x74c3728*/ void RegisterListChangedEvent(System.Data.Index index);
            /*0x74c361c*/ void UnregisterListChangedEvent();
            /*0x74c405c*/ void CleanUp(bool updateListeners);
            /*0x74c4370*/ void RegisterListener(System.Data.DataTable table);
        }

        class DataViewManager : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ System.NotSupportedException s_notSupported;
            /*0x20*/ System.Data.DataViewSettingCollection _dataViewSettingsCollection;
            /*0x28*/ int _nViews;

            static /*0x74c4840*/ DataViewManager();
            /*0x74c4838*/ System.Data.DataViewSettingCollection get_DataViewSettings();
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

            /*0x74c48bc*/ DataViewSetting();
            /*0x74c4918*/ bool get_ApplyDefaultSort();
            /*0x74c4920*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x74c4938*/ void SetDataTable(System.Data.DataTable table);
            /*0x74c4950*/ string get_RowFilter();
            /*0x74c4958*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x74c4960*/ string get_Sort();
        }

        class DataViewSettingCollection
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Collections.Hashtable _list;

            /*0x74c4968*/ System.Data.DataViewSetting get_Item(System.Data.DataTable table);
            /*0x74c4a60*/ void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value);
            /*0x74c4b10*/ void Remove(System.Data.DataTable table);
        }

        class DefaultValueTypeConverter : System.ComponentModel.StringConverter
        {
            /*0x74c4b34*/ DefaultValueTypeConverter();
            /*0x74c4b3c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x74c4ccc*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            static /*0x74c5370*/ void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74c4e38*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName);
            /*0x74c4e44*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName, bool local, string relationName);
            /*0x74c4fc4*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74c5574*/ object Eval();
            /*0x74c5588*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74c589c*/ object Eval(int[] records);
            /*0x74c5960*/ bool IsConstant();
            /*0x74c5968*/ bool IsTableConstant();
            /*0x74c5970*/ bool HasLocalAggregate();
            /*0x74c5978*/ bool HasRemoteAggregate();
            /*0x74c5988*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74c5a20*/ System.Data.ExpressionNode Optimize();
        }

        class BinaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _left;
            /*0x28*/ System.Data.ExpressionNode _right;

            static /*0x74cb9e0*/ object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            static /*0x74cd5b0*/ System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code);
            /*0x74c5a24*/ BinaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x74c5a8c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74c5afc*/ object Eval();
            /*0x74c5b10*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74cb1b0*/ object Eval(int[] recordNos);
            /*0x74cb1cc*/ bool IsConstant();
            /*0x74cb214*/ bool IsTableConstant();
            /*0x74cb25c*/ bool HasLocalAggregate();
            /*0x74cb2a4*/ bool HasRemoteAggregate();
            /*0x74cb2ec*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74cb350*/ System.Data.ExpressionNode Optimize();
            /*0x74cb8e4*/ void SetTypeMismatchError(int op, System.Type left, System.Type right);
            /*0x74cba10*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op);
            /*0x74cba18*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op, System.Globalization.CompareInfo comparer);
            /*0x74c5b2c*/ object EvalBinaryOp(int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            /*0x74cd58c*/ System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType);
            /*0x74cd5d4*/ bool IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x74cd6b8*/ bool IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x74cd040*/ System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x74ccc44*/ System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x74cd8f4*/ int SqlResultType(int typeCode);

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

            /*0x74cd954*/ LikeNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x74cd958*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74cde50*/ string AnalyzePattern(string pat);
        }

        class ConstNode : System.Data.ExpressionNode
        {
            /*0x18*/ object _val;

            /*0x74ce180*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant);
            /*0x74cb5e4*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes);
            /*0x74cebec*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74cebf4*/ object Eval();
            /*0x74cebfc*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74cec08*/ object Eval(int[] recordNos);
            /*0x74cec14*/ bool IsConstant();
            /*0x74cec1c*/ bool IsTableConstant();
            /*0x74cec24*/ bool HasLocalAggregate();
            /*0x74cec2c*/ bool HasRemoteAggregate();
            /*0x74cec34*/ System.Data.ExpressionNode Optimize();
            /*0x74ce76c*/ object SmallestDecimal(object constant);
            /*0x74ce188*/ object SmallestNumeric(object constant);
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

            static /*0x74d02c4*/ bool IsUnknown(object value);
            static /*0x74cca00*/ bool ToBoolean(object value);
            /*0x74c3074*/ DataExpression(System.Data.DataTable table, string expression);
            /*0x74cec38*/ DataExpression(System.Data.DataTable table, string expression, System.Type type);
            /*0x74cfe48*/ string get_Expression();
            /*0x74cfe98*/ bool get_HasValue();
            /*0x74cfd10*/ void Bind(System.Data.DataTable table);
            /*0x74c5a04*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74cfea8*/ object Evaluate();
            /*0x74cfeb4*/ object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d0134*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d02a4*/ System.Data.DataColumn[] GetDependency();
            /*0x74d02ac*/ bool IsTableAggregate();
            /*0x74d031c*/ bool HasLocalAggregate();
            /*0x74d0334*/ bool HasRemoteAggregate();
        }

        class ExpressionNode
        {
            /*0x10*/ System.Data.DataTable _table;

            static /*0x74cd818*/ bool IsInteger(System.Data.Common.StorageType type);
            static /*0x74cd434*/ bool IsIntegerSql(System.Data.Common.StorageType type);
            static /*0x74cd668*/ bool IsSigned(System.Data.Common.StorageType type);
            static /*0x74cd744*/ bool IsSignedSql(System.Data.Common.StorageType type);
            static /*0x74cd698*/ bool IsUnsigned(System.Data.Common.StorageType type);
            static /*0x74cd770*/ bool IsUnsignedSql(System.Data.Common.StorageType type);
            static /*0x74cd7f8*/ bool IsNumeric(System.Data.Common.StorageType type);
            static /*0x74cd928*/ bool IsNumericSql(System.Data.Common.StorageType type);
            static /*0x74d036c*/ bool IsFloat(System.Data.Common.StorageType type);
            static /*0x74d037c*/ bool IsFloatSql(System.Data.Common.StorageType type);
            /*0x74c4f44*/ ExpressionNode(System.Data.DataTable table);
            /*0x74cc994*/ System.IFormatProvider get_FormatProvider();
            /*0x74d034c*/ bool get_IsSqlColumn();
            /*0x74d0354*/ System.Data.DataTable get_table();
            /*0x74d035c*/ void BindTable(System.Data.DataTable table);
            /*0x3816810*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x38148bc*/ object Eval();
            /*0x3814b48*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3814a3c*/ object Eval(int[] recordNos);
            /*0x3813ffc*/ bool IsConstant();
            /*0x3813ffc*/ bool IsTableConstant();
            /*0x3813ffc*/ bool HasLocalAggregate();
            /*0x3813ffc*/ bool HasRemoteAggregate();
            /*0x38148bc*/ System.Data.ExpressionNode Optimize();
            /*0x74d0364*/ bool DependsOn(System.Data.DataColumn column);
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

            static /*0x74d1f3c*/ ExpressionParser();
            /*0x74cee20*/ ExpressionParser(System.Data.DataTable table);
            /*0x74ceee4*/ void LoadExpression(string data);
            /*0x74d03a4*/ void StartScan();
            /*0x74cf058*/ System.Data.ExpressionNode Parse();
            /*0x74d0ffc*/ System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate);
            /*0x74d0fc0*/ System.Data.ExpressionNode NodePop();
            /*0x74d0f3c*/ System.Data.ExpressionNode NodePeek();
            /*0x74d0ea4*/ void NodePush(System.Data.ExpressionNode node);
            /*0x74d08a4*/ void BuildExpression(int pri);
            /*0x74d0d5c*/ void CheckToken(System.Data.Tokens token);
            /*0x74d0478*/ System.Data.Tokens Scan();
            /*0x74d1a44*/ void ScanNumeric();
            /*0x74d1da4*/ void ScanName();
            /*0x74d1934*/ void ScanName(char chEnd, char esc, string charsToEscape);
            /*0x74d17c4*/ void ScanDate();
            /*0x74d1b70*/ void ScanBinaryConstant();
            /*0x74d1b88*/ void ScanReserved();
            /*0x74d1864*/ void ScanString(char escape);
            /*0x74d0b4c*/ void ScanToken(System.Data.Tokens token);
            /*0x74d176c*/ void ScanWhite();
            /*0x74d1f28*/ bool IsWhiteSpace(char ch);
            /*0x74d1d68*/ bool IsAlphaNumeric(char ch);
            /*0x74d1b74*/ bool IsDigit(char ch);
            /*0x74d1eac*/ bool IsAlpha(char ch);

            struct ReservedWords
            {
                /*0x10*/ string _word;
                /*0x18*/ System.Data.Tokens _token;
                /*0x1c*/ int _op;

                /*0x74d23b0*/ ReservedWords(string word, System.Data.Tokens token, int op);
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

            /*0x74d043c*/ OperatorInfo(System.Data.Nodes type, int op, int pri);
        }

        class InvalidExpressionException : System.Data.DataException
        {
            /*0x74d23dc*/ InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74d23e4*/ InvalidExpressionException();
            /*0x74d23ec*/ InvalidExpressionException(string s);
        }

        class EvaluateException : System.Data.InvalidExpressionException
        {
            /*0x74d23f4*/ EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74d23fc*/ EvaluateException();
            /*0x74d2404*/ EvaluateException(string s);
        }

        class SyntaxErrorException : System.Data.InvalidExpressionException
        {
            /*0x74d240c*/ SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74d2414*/ SyntaxErrorException();
            /*0x74d241c*/ SyntaxErrorException(string s);
        }

        class ExprException
        {
            static /*0x74d2424*/ System.OverflowException _Overflow(string error);
            static /*0x74d248c*/ System.Data.InvalidExpressionException _Expr(string error);
            static /*0x74d24f4*/ System.Data.SyntaxErrorException _Syntax(string error);
            static /*0x74d255c*/ System.Data.EvaluateException _Eval(string error);
            static /*0x74d25c4*/ System.Data.EvaluateException _Eval(string error, System.Exception innerException);
            static /*0x74d0210*/ System.Exception InvokeArgument();
            static /*0x74d262c*/ System.Exception NYI(string moreinfo);
            static /*0x74d0818*/ System.Exception MissingOperand(System.Data.OperatorInfo before);
            static /*0x74d0afc*/ System.Exception MissingOperator(string token);
            static /*0x74d267c*/ System.Exception TypeMismatch(string expr);
            static /*0x74d26cc*/ System.Exception FunctionArgumentOutOfRange(string arg, string func);
            static /*0x74d161c*/ System.Exception ExpressionTooComplex();
            static /*0x74c5320*/ System.Exception UnboundName(string name);
            static /*0x74d1ed8*/ System.Exception InvalidString(string str);
            static /*0x74c4f74*/ System.Exception UndefinedFunction(string name);
            static /*0x74d0f80*/ System.Exception SyntaxError();
            static /*0x74d2734*/ System.Exception FunctionArgumentCount(string name);
            static /*0x74d0abc*/ System.Exception MissingRightParen();
            static /*0x74d1538*/ System.Exception UnknownToken(string token, int position);
            static /*0x74d165c*/ System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, int position);
            static /*0x74d2784*/ System.Exception DatatypeConvertion(System.Type type1, System.Type type2);
            static /*0x74d00a8*/ System.Exception DatavalueConvertion(object value, System.Type type, System.Exception innerException);
            static /*0x74d2810*/ System.Exception InvalidName(string name);
            static /*0x74d1e5c*/ System.Exception InvalidDate(string date);
            static /*0x74d2860*/ System.Exception NonConstantArgument();
            static /*0x74ce130*/ System.Exception InvalidPattern(string pat);
            static /*0x74cd460*/ System.Exception InWithoutParentheses();
            static /*0x74d28a0*/ System.Exception InWithoutList();
            static /*0x74cb5a4*/ System.Exception InvalidIsSyntax();
            static /*0x74cd520*/ System.Exception Overflow(System.Type type);
            static /*0x74d28e0*/ System.Exception ArgumentType(string function, int arg, System.Type type);
            static /*0x74d29a8*/ System.Exception ArgumentTypeInteger(string function, int arg);
            static /*0x74cb914*/ System.Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2);
            static /*0x74cd828*/ System.Exception AmbiguousBinop(int op, System.Type type1, System.Type type2);
            static /*0x74cd4a0*/ System.Exception UnsupportedOperator(int op);
            static /*0x74d1e0c*/ System.Exception InvalidNameBracketing(string name);
            static /*0x74d1338*/ System.Exception MissingOperandBefore(string op);
            static /*0x74d12a4*/ System.Exception TooManyRightParentheses();
            static /*0x74c52c0*/ System.Exception UnresolvedRelation(string name, string expr);
            static /*0x74d2a4c*/ System.Data.EvaluateException BindFailure(string relationName);
            static /*0x74d15dc*/ System.Exception AggregateArgument();
            static /*0x74c5270*/ System.Exception AggregateUnbound(string expr);
            static /*0x74c585c*/ System.Exception EvalNoContext();
            static /*0x74d2a9c*/ System.Exception ExpressionUnbound(string expr);
            static /*0x74c5910*/ System.Exception ComputeNotAggregate(string expr);
            static /*0x74d0254*/ System.Exception FilterConvertion(string expr);
            static /*0x74d0da0*/ System.Exception LookupArgument();
            static /*0x74d2aec*/ System.Exception InvalidType(string typeName);
            static /*0x74d2b3c*/ System.Exception InvalidHoursArgument();
            static /*0x74d2b7c*/ System.Exception InvalidMinutesArgument();
            static /*0x74d2bbc*/ System.Exception InvalidTimeZoneRange();
            static /*0x74d2bfc*/ System.Exception MismatchKindandTimeSpan();
            static /*0x74cefe4*/ System.Exception UnsupportedDataType(System.Type type);
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

            /*0x74d0de0*/ LookupNode(System.Data.DataTable table, string columnName, string relationName);
            /*0x74d2c3c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74d2ed4*/ object Eval();
            /*0x74d2ef8*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d2ffc*/ object Eval(int[] recordNos);
            /*0x74d302c*/ bool IsConstant();
            /*0x74d3034*/ bool IsTableConstant();
            /*0x74d303c*/ bool HasLocalAggregate();
            /*0x74d3044*/ bool HasRemoteAggregate();
            /*0x74d304c*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74d305c*/ System.Data.ExpressionNode Optimize();
        }

        class NameNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _name;
            /*0x20*/ bool _found;
            /*0x28*/ System.Data.DataColumn _column;

            static /*0x74d0b74*/ string ParseName(char[] text, int start, int pos);
            /*0x74d0e40*/ NameNode(System.Data.DataTable table, char[] text, int start, int pos);
            /*0x74d14f4*/ NameNode(System.Data.DataTable table, string name);
            /*0x74d3060*/ bool get_IsSqlColumn();
            /*0x74d307c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74d32e8*/ object Eval();
            /*0x74d330c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d33a8*/ object Eval(int[] records);
            /*0x74d33d8*/ bool IsConstant();
            /*0x74d33e0*/ bool IsTableConstant();
            /*0x74d3434*/ bool HasLocalAggregate();
            /*0x74d3488*/ bool HasRemoteAggregate();
            /*0x74d34dc*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74d3558*/ System.Data.ExpressionNode Optimize();
        }

        class Operators
        {
            static /*0x0*/ int[] s_priority;
            static /*0x8*/ string[] s_looks;

            static /*0x74d355c*/ Operators();
            static /*0x74cd7d4*/ bool IsArithmetical(int op);
            static /*0x74cd7a8*/ bool IsLogical(int op);
            static /*0x74cd798*/ bool IsRelational(int op);
            static /*0x74d1448*/ int Priority(int op);
            static /*0x74d1388*/ string ToString(int op);
        }

        class UnaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _right;

            /*0x74d12e4*/ UnaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode right);
            /*0x74d3df0*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74d3e38*/ object Eval();
            /*0x74d3e4c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d4678*/ object Eval(int[] recordNos);
            /*0x74d3e8c*/ object EvalUnaryOp(int op, object vl);
            /*0x74d4698*/ bool IsConstant();
            /*0x74d46b8*/ bool IsTableConstant();
            /*0x74d46d8*/ bool HasLocalAggregate();
            /*0x74d46f8*/ bool HasRemoteAggregate();
            /*0x74d4718*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74d473c*/ System.Data.ExpressionNode Optimize();
        }

        class ZeroOpNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;

            /*0x74d4800*/ ZeroOpNode(int op);
            /*0x74d482c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74d4830*/ object Eval();
            /*0x74d48e0*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74d48ec*/ object Eval(int[] recordNos);
            /*0x74d48f8*/ bool IsConstant();
            /*0x74d4900*/ bool IsTableConstant();
            /*0x74d4908*/ bool HasLocalAggregate();
            /*0x74d4910*/ bool HasRemoteAggregate();
            /*0x74d4918*/ System.Data.ExpressionNode Optimize();
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

            /*0x74d491c*/ ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74d495c*/ ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74d4b28*/ ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule);
            /*0x74d4bd0*/ System.Data.DataKey get_ChildKey();
            /*0x74d4bec*/ System.Data.DataColumn[] get_Columns();
            /*0x74d4c0c*/ System.Data.DataTable get_Table();
            /*0x74d4c2c*/ string[] get_ParentColumnNames();
            /*0x74d4c38*/ string[] get_ChildColumnNames();
            /*0x74d4c44*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x74d4d6c*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x74d4d74*/ bool IsKeyNull(object[] values);
            /*0x74d4e38*/ bool IsConstraintViolated();
            /*0x74d5308*/ bool CanEnableConstraint();
            /*0x74d5474*/ void CascadeCommit(System.Data.DataRow row);
            /*0x74d55d4*/ void CascadeDelete(System.Data.DataRow row);
            /*0x74d5b0c*/ void CascadeRollback(System.Data.DataRow row);
            /*0x74d5d00*/ void CascadeUpdate(System.Data.DataRow row);
            /*0x74d6198*/ void CheckCanClearParentTable(System.Data.DataTable table);
            /*0x74d6274*/ void CheckCanRemoveParentRow(System.Data.DataRow row);
            /*0x74d633c*/ void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x74d643c*/ void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action);
            /*0x74d6710*/ void NonVirtualCheckState();
            /*0x74d6964*/ void CheckState();
            /*0x74d6968*/ System.Data.AcceptRejectRule get_AcceptRejectRule();
            /*0x74d6984*/ void set_AcceptRejectRule(System.Data.AcceptRejectRule value);
            /*0x74d69d8*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x74d6a20*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x74d6a30*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x74d7194*/ System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination);
            /*0x74d49a8*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74d77a8*/ System.Data.Rule get_DeleteRule();
            /*0x74d77c4*/ void set_DeleteRule(System.Data.Rule value);
            /*0x74d7818*/ bool Equals(object key);
            /*0x74d7908*/ int GetHashCode();
            /*0x74d7910*/ System.Data.DataColumn[] get_RelatedColumns();
            /*0x74d7178*/ System.Data.DataColumn[] get_RelatedColumnsReference();
            /*0x74d6320*/ System.Data.DataKey get_ParentKey();
            /*0x74d7930*/ System.Data.DataRelation FindParentRelation();
            /*0x74d79f8*/ System.Data.DataTable get_RelatedTable();
            /*0x74d7a18*/ System.Data.Rule get_UpdateRule();
            /*0x74d7a34*/ void set_UpdateRule(System.Data.Rule value);
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

            /*0x74d7a88*/ MergeFailedEventArgs(System.Data.DataTable table, string conflict);
            /*0x74d7b10*/ string get_Conflict();
        }

        class MergeFailedEventHandler : System.MulticastDelegate
        {
            /*0x74d7b18*/ MergeFailedEventHandler(object object, nint method);
            /*0x74d7c24*/ void Invoke(object sender, System.Data.MergeFailedEventArgs e);
        }

        class Merger
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.DataTable _dataTable;
            /*0x20*/ bool _preserveChanges;
            /*0x24*/ System.Data.MissingSchemaAction _missingSchemaAction;
            /*0x28*/ bool _isStandAlonetable;
            /*0x29*/ bool _IgnoreNSforTableLookup;

            /*0x74d7c38*/ Merger(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74d7c8c*/ Merger(System.Data.DataTable dataTable, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74d7ce8*/ void MergeDataSet(System.Data.DataSet source);
            /*0x74d98ec*/ void MergeTable(System.Data.DataTable src);
            /*0x74d9b18*/ void MergeTable(System.Data.DataTable src, System.Data.DataTable dst);
            /*0x74da120*/ System.Data.DataTable MergeSchema(System.Data.DataTable table);
            /*0x74d8ddc*/ void MergeTableData(System.Data.DataTable src);
            /*0x74d8e64*/ void MergeConstraints(System.Data.DataSet source);
            /*0x74da838*/ void MergeConstraints(System.Data.DataTable table);
            /*0x74d8ed4*/ void MergeRelation(System.Data.DataRelation relation);
            /*0x74d9698*/ void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst);
            /*0x74d9fc0*/ System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst);
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
            /*0x74daae4*/ PrimaryKeyTypeConverter();
            /*0x74dab84*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x74dab8c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74dac18*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class PropertyCollection : System.Collections.Hashtable, System.ICloneable
        {
            /*0x74dadbc*/ PropertyCollection();
            /*0x74dadc4*/ PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74dadcc*/ object Clone();
        }

        struct Range
        {
            /*0x10*/ int _min;
            /*0x14*/ int _max;
            /*0x18*/ bool _isNotNull;

            /*0x74db0c8*/ Range(int min, int max);
            /*0x74d5aa8*/ int get_Count();
            /*0x74d55c4*/ bool get_IsNull();
            /*0x74d5ac8*/ int get_Min();
            /*0x74db114*/ void CheckNull();
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
            /*0x3815ed0*/ RBTree(System.Data.TreeAccessMethod accessMethod);
            /*0x3910ae8*/ int CompareNode(K record1, K record2);
            /*0x3910ae8*/ int CompareSateliteTreeNode(K record1, K record2);
            /*0x38159dc*/ void InitTree();
            /*0x3816710*/ void FreePage(System.Data.RBTree.TreePage<K> page);
            /*0x3814964*/ System.Data.RBTree.TreePage<K> AllocPage(int size);
            /*0x3816710*/ void MarkPageFull(System.Data.RBTree.TreePage<K> page);
            /*0x3816710*/ void MarkPageFree(System.Data.RBTree.TreePage<K> page);
            /*0x3815ed0*/ void FreeNode(int nodeId);
            int GetIndexOfPageWithFreeSlot(bool allocatedPage);
            /*0x3814574*/ int get_Count();
            /*0x3813ffc*/ bool get_HasDuplicates();
            /*0x3910ae8*/ int GetNewNode(K key);
            /*0x38145a0*/ int Successor(int x_id);
            /*0x3814200*/ bool Successor(ref int nodeId, ref int mainTreeNodeId);
            /*0x38145a0*/ int Minimum(int x_id);
            int LeftRotate(int root_id, int x_id, int mainTreeNode);
            int RightRotate(int root_id, int x_id, int mainTreeNode);
            /*0x3910ae8*/ int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append);
            /*0x3910ae8*/ void UpdateNodeKey(K currentKey, K newKey);
            /*0x3910ae8*/ K DeleteByIndex(int i);
            /*0x38145a0*/ int RBDelete(int z_id);
            int RBDeleteX(int root_id, int z_id, int mainTreeNodeID);
            int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID);
            /*0x3910ae8*/ int SearchSubTree(int root_id, K key);
            /*0x3910ae8*/ K get_Item(int index);
            /*0x3910ae8*/ System.Data.RBTree.NodePath<K> GetNodeByKey(K key);
            /*0x3910ae8*/ int GetIndexByKey(K key);
            /*0x38145a0*/ int GetIndexByNode(int node);
            /*0x3910ae8*/ int GetIndexByNodePath(System.Data.RBTree.NodePath<K> path);
            /*0x38145a0*/ int ComputeIndexByNode(int nodeId);
            /*0x38145a0*/ int ComputeIndexWithSatelliteByNode(int nodeId);
            /*0x3910ae8*/ System.Data.RBTree.NodePath<K> GetNodeByIndex(int userIndex);
            int ComputeNodeByIndex(int index, ref int satelliteRootId);
            /*0x38145e4*/ int ComputeNodeByIndex(int x_id, int index);
            /*0x3910ae8*/ int Insert(K item);
            /*0x3910ae8*/ int Add(K item);
            /*0x38148bc*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3910ae8*/ int IndexOf(int nodeId, K item);
            /*0x3910ae8*/ int Insert(int position, K item);
            /*0x3910ae8*/ int InsertAt(int position, K item, bool append);
            /*0x3815ed0*/ void RemoveAt(int position);
            /*0x38159dc*/ void Clear();
            /*0x381678c*/ void CopyTo(System.Array array, int index);
            /*0x381678c*/ void CopyTo(K[] array, int index);
            /*0x3815fb8*/ void SetRight(int nodeId, int rightNodeId);
            /*0x3815fb8*/ void SetLeft(int nodeId, int leftNodeId);
            /*0x3815fb8*/ void SetParent(int nodeId, int parentNodeId);
            /*0x3910ae8*/ void SetColor(int nodeId, System.Data.RBTree.NodeColor<K> color);
            /*0x3910ae8*/ void SetKey(int nodeId, K key);
            /*0x3815fb8*/ void SetNext(int nodeId, int nextNodeId);
            /*0x3815fb8*/ void SetSubTreeSize(int nodeId, int size);
            /*0x3815ed0*/ void IncreaseSize(int nodeId);
            /*0x3815ed0*/ void RecomputeSize(int nodeId);
            /*0x3815ed0*/ void DecreaseSize(int nodeId);
            /*0x38145a0*/ int Right(int nodeId);
            /*0x38145a0*/ int Left(int nodeId);
            /*0x38145a0*/ int Parent(int nodeId);
            /*0x3910ae8*/ System.Data.RBTree.NodeColor<K> color(int nodeId);
            /*0x38145a0*/ int Next(int nodeId);
            /*0x38145a0*/ int SubTreeSize(int nodeId);
            /*0x3910ae8*/ K Key(int nodeId);

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

                /*0x3815fb8*/ NodePath(int nodeID, int mainTreeNodeID);
            }

            class TreePage<K>
            {
                /*0x0*/ System.Data.RBTree.Node<K> _slots;
                /*0x0*/ int[] _slotMap;
                /*0x0*/ int _inUseCount;
                /*0x0*/ int _pageId;
                /*0x0*/ int _nextFreeSlotLine;

                /*0x3815ed0*/ TreePage(int size);
                /*0x381467c*/ int AllocSlot(System.Data.RBTree<K> tree);
                /*0x3814574*/ int get_InUseCount();
                /*0x3815ed0*/ void set_InUseCount(int value);
                /*0x3814574*/ int get_PageId();
                /*0x3815ed0*/ void set_PageId(int value);
            }

            struct RBTreeEnumerator<K> : System.Collections.Generic.IEnumerator<K>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ System.Data.RBTree<K> _tree;
                /*0x0*/ int _version;
                /*0x0*/ int _index;
                /*0x0*/ int _mainTreeNodeId;
                /*0x0*/ K _current;

                /*0x3816710*/ RBTreeEnumerator(System.Data.RBTree<K> tree);
                /*0x381678c*/ RBTreeEnumerator(System.Data.RBTree<K> tree, int position);
                /*0x38159dc*/ void Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x3910ae8*/ K get_Current();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
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

            static /*0x74db334*/ int NewCapacity(int capacity);
            /*0x74db14c*/ RecordManager(System.Data.DataTable table);
            /*0x74db224*/ void GrowRecordCapacity();
            /*0x74db410*/ int get_LastFreeRecord();
            /*0x74db418*/ int get_MinimumCapacity();
            /*0x74db420*/ void set_MinimumCapacity(int value);
            /*0x74db464*/ int get_RecordCapacity();
            /*0x74db380*/ void set_RecordCapacity(int value);
            /*0x74db348*/ int NormalizedMinimumCapacity(int capacity);
            /*0x74db46c*/ int NewRecordBase();
            /*0x74db538*/ void FreeRecord(ref int record);
            /*0x74db6f0*/ void Clear(bool clearAll);
            /*0x74db8f4*/ System.Data.DataRow get_Item(int record);
            /*0x74db688*/ void set_Item(int record, System.Data.DataRow value);
            /*0x74db924*/ int ImportRecord(System.Data.DataTable src, int record);
            /*0x74db92c*/ int CopyRecord(System.Data.DataTable src, int record, int copy);
            /*0x74dbc44*/ void SetRowCache(System.Data.DataRow[] newRows);
        }

        class RelatedView : System.Data.DataView, System.Data.IFilter
        {
            /*0xb0*/ System.Nullable<System.Data.DataKey> _parentKey;
            /*0xc0*/ System.Data.DataKey _childKey;
            /*0xc8*/ System.Data.DataRowView _parentRowView;
            /*0xd0*/ object[] _filterValues;

            /*0x74dbc84*/ RelatedView(System.Data.DataColumn[] columns, object[] values);
            /*0x74dbdc0*/ RelatedView(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns);
            /*0x74dbefc*/ object[] GetParentValues();
            /*0x74dbf98*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74dc120*/ System.Data.IFilter GetFilter();
            /*0x74dc124*/ System.Data.DataRowView AddNew();
            /*0x74dc184*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
        }

        class RelationshipConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x74dc1a8*/ RelationshipConverter();
            /*0x74dc1b0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74dc260*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
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

            static /*0x74dce58*/ bool op_Equality(System.Data.IndexField if1, System.Data.IndexField if2);
            /*0x74dce30*/ IndexField(System.Data.DataColumn column, bool isDescending);
            /*0x74dce74*/ bool Equals(object obj);
            /*0x74dcf04*/ int GetHashCode();
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

            static /*0x74dd2e4*/ System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns);
            static /*0x74df718*/ int GetReplaceAction(System.Data.DataViewRowState oldState);
            static /*0x3910ae8*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
            /*0x74dcf64*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74dd28c*/ Index(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74dcf74*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74dd7e0*/ bool Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74dd888*/ bool get_HasRemoteAggregate();
            /*0x74dd890*/ int get_ObjectID();
            /*0x74dd898*/ System.Data.DataViewRowState get_RecordStates();
            /*0x74dd8a0*/ System.Data.IFilter get_RowFilter();
            /*0x74dd918*/ int GetRecord(int recordIndex);
            /*0x74dd970*/ bool get_HasDuplicates();
            /*0x74dd9c0*/ int get_RecordCount();
            /*0x74dd9c8*/ bool AcceptRecord(int record);
            /*0x74dd9f4*/ bool AcceptRecord(int record, System.Data.IFilter filter);
            /*0x74ddb88*/ void ListChangedAdd(System.Data.DataViewListener listener);
            /*0x74ddbe0*/ void ListChangedRemove(System.Data.DataViewListener listener);
            /*0x74ddc38*/ int get_RefCount();
            /*0x74ddc40*/ void AddRef();
            /*0x74dde3c*/ int RemoveRef();
            /*0x74ddff8*/ void ApplyChangeAction(int record, int action, int changeRecord);
            /*0x74de428*/ bool CheckUnique();
            /*0x74de440*/ int CompareRecords(int record1, int record2);
            /*0x74de590*/ int CompareDataRows(int record1, int record2);
            /*0x74de5fc*/ int CompareDuplicateRecords(int record1, int record2);
            /*0x74de748*/ int CompareRecordToKey(int record1, object[] vals);
            /*0x74de818*/ void DeleteRecordFromIndex(int recordIndex);
            /*0x74de3c8*/ void DeleteRecord(int recordIndex);
            /*0x74de820*/ void DeleteRecord(int recordIndex, bool fireEvent);
            /*0x74deaf0*/ System.Data.RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex);
            /*0x74de3d0*/ int GetIndex(int record);
            /*0x74de290*/ int GetIndex(int record, int changeRecord);
            /*0x74d5030*/ object[] GetUniqueKeyValues();
            /*0x74ded7c*/ int FindNodeByKey(object originalKey);
            /*0x74def90*/ int FindNodeByKeys(object[] originalKey);
            /*0x74df1d4*/ int FindNodeByKeyRecord(int record);
            /*0x74df2c8*/ System.Data.Range GetRangeFromNode(int nodeId);
            /*0x74df3f0*/ System.Data.Range FindRecords(object key);
            /*0x74d516c*/ System.Data.Range FindRecords(object[] key);
            /*0x74df414*/ void FireResetEvent();
            /*0x74df6fc*/ int GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x74d5ae0*/ System.Data.DataRow GetRow(int i);
            /*0x74df740*/ System.Data.DataRow[] GetRows(object[] values);
            /*0x74d5190*/ System.Data.DataRow[] GetRows(System.Data.Range range);
            /*0x74dd3dc*/ void InitRecords(System.Data.IFilter filter);
            /*0x74df7d4*/ int InsertRecordToIndex(int record);
            /*0x74de09c*/ int InsertRecord(int record, bool fireEvent);
            /*0x74df824*/ bool IsKeyInIndex(object key);
            /*0x74d5154*/ bool IsKeyInIndex(object[] key);
            /*0x74df83c*/ bool IsKeyRecordInIndex(int record);
            /*0x74df4fc*/ bool get_DoListChanged();
            /*0x74df854*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int newIndex, int oldIndex);
            /*0x74dea60*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int index);
            /*0x74df57c*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74de944*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, int record, bool trackAddRemove);
            /*0x74df8f4*/ void Reset();
            /*0x74df9bc*/ void RecordChanged(int record);
            /*0x74dfaa0*/ void RecordChanged(int oldIndex, int newIndex);
            /*0x74dfbd8*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x74dfcd8*/ void RecordStateChanged(int oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, int newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState);
            /*0x74e003c*/ System.Data.DataTable get_Table();
            /*0x74deb58*/ void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId);

            class IndexTree : System.Data.RBTree<int>
            {
                /*0x40*/ System.Data.Index _index;

                /*0x74df76c*/ IndexTree(System.Data.Index index);
                /*0x74e0044*/ int CompareNode(int record1, int record2);
                /*0x74e005c*/ int CompareSateliteTreeNode(int record1, int record2);
            }

            class <>c
            {
                static /*0x0*/ System.Data.Index.<> <>9;
                static /*0x8*/ System.Data.Listeners.Func<System.Data.DataViewListener, System.Data.DataViewListener, bool> <>9__22_0;
                static /*0x10*/ System.Data.Listeners.Action<System.Data.DataViewListener, System.Data.DataViewListener, System.ComponentModel.ListChangedEventArgs, bool, bool> <>9__85_0;

                static /*0x74e0074*/ <>c();
                /*0x74e00dc*/ <>c();
                /*0x74e00e4*/ bool <.ctor>b__22_0(System.Data.DataViewListener listener);
                /*0x74e00f0*/ void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, bool arg2, bool arg3);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ System.ComponentModel.ListChangedType changedType;

                /*0x74df8ec*/ <>c__DisplayClass86_0();
                /*0x74e010c*/ void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, bool track);
            }
        }

        class Listeners<TElem>
        {
            /*0x0*/ System.Collections.Generic.List<TElem> _listeners;
            /*0x0*/ System.Data.Listeners.Func<TElem, TElem, bool> _filter;
            /*0x0*/ int _objectID;
            /*0x0*/ int _listenerReaderCount;

            /*0x3816044*/ Listeners(int ObjectID, System.Data.Listeners.Func<TElem, TElem, bool> notifyFilter);
            /*0x3813ffc*/ bool get_HasListeners();
            /*0x3910ae8*/ void Add(TElem listener);
            /*0x3910ae8*/ int IndexOfReference(TElem listener);
            /*0x3910ae8*/ void Remove(TElem listener);
            /*0x3910ae8*/ void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem, TElem, T1, T2, T3> action);
            /*0x3815ed0*/ void RemoveNullListeners(int nullIndex);

            class Action`4<TElem, T1, T2, T3, T4> : System.MulticastDelegate
            {
                Action`4(object object, nint method);
                /*0x3910ae8*/ void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            }

            class Func`2<TElem, T1, TResult> : System.MulticastDelegate
            {
                Func`2(object object, nint method);
                /*0x3910ae8*/ TResult Invoke(T1 arg1);
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

            static /*0x74e1608*/ System.Data.SimpleType CreateEnumeratedType(string values);
            static /*0x74e1694*/ System.Data.SimpleType CreateByteArrayType(string encoding);
            static /*0x74e16fc*/ System.Data.SimpleType CreateLimitedStringType(int length);
            static /*0x74e177c*/ System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type);
            /*0x74e013c*/ SimpleType(string baseType);
            /*0x74e0244*/ SimpleType(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x74e0d80*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74e0410*/ void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x74e0ed0*/ bool IsPlainString();
            /*0x74e107c*/ string get_BaseType();
            /*0x74e1084*/ System.Xml.XmlQualifiedName get_XmlBaseType();
            /*0x74e108c*/ string get_Name();
            /*0x74e1094*/ string get_Namespace();
            /*0x74e109c*/ int get_Length();
            /*0x74e10a4*/ int get_MaxLength();
            /*0x74e10ac*/ void set_MaxLength(int value);
            /*0x74e10b4*/ System.Data.SimpleType get_BaseSimpleType();
            /*0x74e10bc*/ string get_SimpleTypeQualifiedName();
            /*0x74e112c*/ string QualifiedName(string name);
            /*0x74e11a8*/ System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, bool inRemoting);
            /*0x74e1850*/ string HasConflictingDefinition(System.Data.SimpleType otherSimpleType);
            /*0x74e1944*/ bool CanHaveMaxLength();
            /*0x74e19a8*/ void ConvertToAnnonymousSimpleType();
        }

        class UniqueConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.DataKey _key;
            /*0x40*/ System.Data.Index _constraintIndex;
            /*0x48*/ bool _bPrimaryKey;
            /*0x50*/ string _constraintName;
            /*0x58*/ string[] _columnNames;

            /*0x74e1a28*/ UniqueConstraint(System.Data.DataColumn column);
            /*0x74e1bdc*/ UniqueConstraint(string name, System.Data.DataColumn[] columns);
            /*0x74e1c10*/ UniqueConstraint(System.Data.DataColumn[] columns);
            /*0x74e1c40*/ UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey);
            /*0x74e1c98*/ UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey);
            /*0x74e1cdc*/ string[] get_ColumnNames();
            /*0x74e1ce8*/ System.Data.Index get_ConstraintIndex();
            /*0x74e1cf0*/ void ConstraintIndexClear();
            /*0x74e1d20*/ void ConstraintIndexInitialize();
            /*0x74e1d78*/ void CheckState();
            /*0x74e1d84*/ void NonVirtualCheckState();
            /*0x74e1d90*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x74e1d94*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x74e1f00*/ bool CanEnableConstraint();
            /*0x74e1f4c*/ bool IsConstraintViolated();
            /*0x74e21ac*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x74e22ac*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x74e22b8*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x74e22c8*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x74e2820*/ System.Data.UniqueConstraint Clone(System.Data.DataTable table);
            /*0x74e2cdc*/ System.Data.DataColumn[] get_Columns();
            /*0x74e22a4*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x74e2ce8*/ bool get_IsPrimaryKey();
            /*0x74e1ae4*/ void Create(string constraintName, System.Data.DataColumn[] columns);
            /*0x74e2d2c*/ bool Equals(object key2);
            /*0x74e2de4*/ int GetHashCode();
            /*0x74e2dec*/ void set_InCollection(bool value);
            /*0x74e2e3c*/ System.Data.DataKey get_Key();
            /*0x74e2e44*/ System.Data.DataTable get_Table();
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

            static /*0x74e5914*/ XDRSchema();
            static /*0x74e42ec*/ System.Data.XDRSchema.NameType FindNameType(string name);
            /*0x74e2e78*/ XDRSchema(System.Data.DataSet ds, bool fInline);
            /*0x74e2ef8*/ void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds);
            /*0x74e338c*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node);
            /*0x74e36b8*/ bool IsTextOnlyContent(System.Xml.XmlElement node);
            /*0x74e3888*/ bool IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x74e31cc*/ System.Data.DataTable HandleTable(System.Xml.XmlElement node);
            /*0x74e43c0*/ System.Type ParseDataType(string dt, string dtValues);
            /*0x74e44fc*/ string GetInstanceName(System.Xml.XmlElement node);
            /*0x74e4674*/ void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table);
            /*0x74e39e8*/ void GetMinMax(System.Xml.XmlElement elNode, ref int minOccurs, ref int maxOccurs);
            /*0x74e4fe4*/ void GetMinMax(System.Xml.XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs);
            /*0x74e572c*/ void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren);
            /*0x74e3c24*/ System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x74e39f8*/ System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x74e6868*/ NameType(string n, System.Type t);
                /*0x74e68ac*/ int CompareTo(object obj);
            }
        }

        class XMLDiffLoader
        {
            /*0x10*/ System.Collections.ArrayList _tables;
            /*0x18*/ System.Data.DataSet _dataSet;
            /*0x20*/ System.Data.DataTable _dataTable;

            /*0x74e8f04*/ XMLDiffLoader();
            /*0x74e68ec*/ void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader);
            /*0x74e7130*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x74e74b4*/ void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader);
            /*0x74e6aa0*/ void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x74e76c4*/ void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync);
            /*0x74e6d90*/ void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x74e79a8*/ void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync);
            /*0x74e8d30*/ System.Data.DataTable GetTable(string tableName, string ns);
            /*0x74e7eb8*/ int ReadOldRowData(System.Data.DataSet ds, ref System.Data.DataTable table, ref int pos, System.Xml.XmlReader row);
            /*0x74e7e58*/ void SkipWhitespaces(System.Xml.XmlReader reader);
        }

        class XMLSchema
        {
            static /*0x74e8f0c*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x74e531c*/ void SetProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x74e3158*/ bool FEqualIdentity(System.Xml.XmlNode node, string name, string ns);
            static /*0x74e8f64*/ bool GetBooleanAttribute(System.Xml.XmlElement element, string attrName, string attrNS, bool defVal);
            static /*0x74e4ebc*/ string GenUniqueColumnName(string proposedName, System.Data.DataTable table);
            /*0x74e2ef0*/ XMLSchema();
        }

        class ConstraintTable
        {
            /*0x10*/ System.Data.DataTable table;
            /*0x18*/ System.Xml.Schema.XmlSchemaIdentityConstraint constraint;

            /*0x74e90b4*/ ConstraintTable(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c);
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

            static /*0x74f8138*/ XSDSchema();
            static /*0x74e1000*/ string QualifiedName(string name);
            static /*0x74e9b3c*/ void SetProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x74ea064*/ void SetExtProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x74e0db8*/ string GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, string ln);
            static /*0x74ea5f4*/ void SetExtProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x74f4740*/ System.Data.AcceptRejectRule TranslateAcceptRejectRule(string strRule);
            static /*0x74f47c4*/ System.Data.Rule TranslateRule(string strRule);
            static /*0x74f7780*/ System.Type XsdtoClr(string xsdTypeName);
            static /*0x74f785c*/ System.Data.XSDSchema.NameType FindNameType(string name);
            static /*0x74f7a94*/ bool IsXsdType(string name);
            /*0x74f8130*/ XSDSchema();
            /*0x74e90f8*/ bool get_FromInference();
            /*0x74e9100*/ void set_FromInference(bool value);
            /*0x74e910c*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema);
            /*0x74e9194*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList);
            /*0x74ea3f4*/ void HandleColumnExpression(object instance, System.Xml.XmlAttribute[] attrs);
            /*0x74ea838*/ void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element);
            /*0x74ea9f4*/ void HandleRelation(System.Xml.XmlElement node, bool fNested);
            /*0x74eb24c*/ bool HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
            /*0x74eb4cc*/ bool IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x74ebef4*/ int DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x74ec28c*/ System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x74ec878*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt);
            /*0x74ec89c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds);
            /*0x74f0284*/ void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, bool fNested);
            /*0x74eba78*/ System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x74f05ac*/ void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isBase);
            /*0x74f1c00*/ void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, bool isBase);
            /*0x74f286c*/ void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, bool isBase);
            /*0x74f2c54*/ void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isNillable);
            /*0x74ec75c*/ System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct);
            /*0x74f42f0*/ System.Data.DataColumn FindField(System.Data.DataTable table, string field);
            /*0x74f446c*/ System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table);
            /*0x74ec134*/ bool GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, bool defVal);
            /*0x74eeaf4*/ string GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, string defVal);
            /*0x74f48b0*/ void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref);
            /*0x74f5188*/ void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode);
            /*0x74f55b8*/ System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x74ea91c*/ string GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x74f6108*/ System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, bool isRef);
            /*0x74f7930*/ System.Type ParseDataType(string dt);
            /*0x74eeb78*/ System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x74f3998*/ void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x74f3240*/ void HandleSimpleContentColumn(string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x74f1efc*/ void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, bool isBase);
            /*0x74f0f74*/ void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, bool isBase);
            /*0x74eef9c*/ void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, bool isNewDataSet);
            /*0x74f7b04*/ void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt);
            /*0x74f5cf8*/ string GetPrefix(string ns);
            /*0x74f7d18*/ string GetNamespaceFromPrefix(string prefix);
            /*0x74f75fc*/ string GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x74f5070*/ string GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x74ebc88*/ bool IsTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x74eee24*/ System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x74f93d0*/ NameType(string n, System.Type t);
                /*0x74f9414*/ int CompareTo(object obj);
            }
        }

        class XmlIgnoreNamespaceReader : System.Xml.XmlNodeReader
        {
            /*0x30*/ System.Collections.Generic.List<string> _namespacesToIgnore;

            /*0x74f9454*/ XmlIgnoreNamespaceReader(System.Xml.XmlDocument xdoc, string[] namespacesToIgnore);
            /*0x74f94f4*/ bool MoveToFirstAttribute();
            /*0x74f9604*/ bool MoveToNextAttribute();
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

            /*0x74f9710*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, bool ignoreSchema);
            /*0x74f97bc*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x74f98c0*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, bool ignoreSchema);
            /*0x74f9984*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x74f9aa0*/ bool get_FromInference();
            /*0x74f9aa8*/ void set_FromInference(bool value);
            /*0x74f9ab4*/ void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x74f9ca8*/ int CountNonNSAttributes(System.Xml.XmlNode node);
            /*0x74f9e28*/ string GetValueForTextOnlyColums(System.Xml.XmlNode n);
            /*0x74fa040*/ string GetInitialTextFromNodes(ref System.Xml.XmlNode n);
            /*0x74fa23c*/ System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row);
            /*0x74f9c10*/ System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e);
            /*0x74fa300*/ bool FColumnElement(System.Xml.XmlElement e);
            /*0x74f9d9c*/ bool FExcludedNamespace(string ns);
            /*0x74fa3e8*/ bool FIgnoreNamespace(System.Xml.XmlNode node);
            /*0x74fa69c*/ bool FIgnoreNamespace(System.Xml.XmlReader node);
            /*0x74f9fec*/ bool IsTextLikeNode(System.Xml.XmlNodeType n);
            /*0x74fa2d0*/ bool IsTextOnly(System.Data.DataColumn c);
            /*0x74fa724*/ void LoadData(System.Xml.XmlDocument xdoc);
            /*0x74fab70*/ void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement);
            /*0x74fb800*/ void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x74fbb40*/ void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, string xmlText);
            /*0x74fbbb0*/ void InitNameTable();
            /*0x74fbeb8*/ void LoadData(System.Xml.XmlReader reader);
            /*0x74fc278*/ void LoadTopMostTable(System.Data.DataTable table);
            /*0x74fced8*/ void LoadTable(System.Data.DataTable table, bool isNested);
            /*0x74fdcc0*/ void LoadColumn(System.Data.DataColumn column, object[] foundColumns);
            /*0x74fccb8*/ bool ProcessXsdSchema();
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

            static /*0x74fbb88*/ bool IsMappedColumn(System.Data.DataColumn c);
            /*0x74faa54*/ XmlToDatasetMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x74fc210*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x74faa20*/ XmlToDatasetMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x74fc244*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x75005e4*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable);
            /*0x75007ec*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table);
            /*0x7500974*/ bool AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x7500c04*/ bool AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x74fe5f8*/ void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x74fec1c*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x74ff76c*/ void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x74ffad8*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x7500e5c*/ System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt);
            /*0x74fa4c8*/ object GetColumnSchema(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x74fdb88*/ object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, bool fIgnoreNamespace);
            /*0x74faa88*/ object GetSchemaForNode(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x74fcbe0*/ System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, bool fIgnoreNamespace);
            /*0x7500aa8*/ void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);

            class XmlNodeIdentety
            {
                /*0x10*/ string LocalName;
                /*0x18*/ string NamespaceURI;

                /*0x75007a8*/ XmlNodeIdentety(string localName, string namespaceURI);
                /*0x750149c*/ int GetHashCode();
                /*0x75014bc*/ bool Equals(object obj);
            }

            class XmlNodeIdHashtable : System.Collections.Hashtable
            {
                /*0x50*/ System.Data.XmlToDatasetMap.XmlNodeIdentety _id;

                /*0x7500dc8*/ XmlNodeIdHashtable(int capacity);
                /*0x75012a8*/ object get_Item(System.Xml.XmlNode node);
                /*0x7501414*/ object get_Item(System.Xml.XmlReader dataReader);
                /*0x7501394*/ object get_Item(System.Data.DataTable table);
                /*0x7501338*/ object get_Item(string name);
            }

            class TableSchemaInfo
            {
                /*0x10*/ System.Data.DataTable TableSchema;
                /*0x18*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;

                /*0x7500704*/ TableSchemaInfo(System.Data.DataTable tableSchema);
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

            static /*0x7501604*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node);
            static /*0x750160c*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type);
            static /*0x75027b0*/ string XmlDataTypeName(System.Type type);
            static /*0x7503e6c*/ bool _PropsNotEmpty(System.Data.PropertyCollection props);
            static /*0x750427c*/ void ValidateColumnMapping(System.Type columnType);
            static /*0x750c83c*/ System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, string name);
            static /*0x750e398*/ string TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule);
            static /*0x750e408*/ string TranslateRule(System.Data.Rule rule);
            static /*0x7505110*/ bool AutoGenerated(System.Data.DataColumn col);
            static /*0x750e858*/ bool AutoGenerated(System.Data.DataRelation rel);
            static /*0x7505660*/ bool AutoGenerated(System.Data.UniqueConstraint unique);
            static /*0x750e93c*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk, bool checkRelation);
            /*0x7501558*/ XmlTreeGen(System.Data.SchemaFormat format);
            /*0x7501d3c*/ void AddXdoProperties(object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x7501eec*/ void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x7503574*/ void GenerateConstraintNames(System.Data.DataTable table, bool fromTable);
            /*0x7503a90*/ void GenerateConstraintNames(System.Collections.ArrayList tables);
            /*0x7503b88*/ void GenerateConstraintNames(System.Data.DataSet ds);
            /*0x7503e94*/ bool HaveExtendedProperties(System.Data.DataSet ds);
            /*0x7504018*/ void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, string targetNamespace);
            /*0x7504304*/ void SetupAutoGenerated(System.Data.DataSet ds);
            /*0x750501c*/ void SetupAutoGenerated(System.Collections.ArrayList dt);
            /*0x75045e4*/ void SetupAutoGenerated(System.Data.DataTable dt);
            /*0x7505734*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x7505ab8*/ void CreateRelations(System.Data.DataTable dt);
            /*0x7505e10*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x75060fc*/ void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, bool writeHierarchy);
            /*0x750952c*/ System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt);
            /*0x7508888*/ System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt);
            /*0x750c3b8*/ void SetPath(System.Xml.XmlWriter xw);
            /*0x750c5f0*/ void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw);
            /*0x750c610*/ void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x750c604*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x750c6d0*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy);
            /*0x750c6dc*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x7508f68*/ System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc);
            /*0x750c930*/ System.Xml.XmlElement GetSchema(string NamespaceURI);
            /*0x750cbc4*/ void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema);
            /*0x750d014*/ void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root);
            /*0x750d604*/ string FindTargetNamespace(System.Data.DataTable table);
            /*0x750d714*/ System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool fWriteOrdinal);
            /*0x7508eb0*/ void AppendChildWithoutRef(System.Xml.XmlElement node, string Namespace, System.Xml.XmlElement el, string refString);
            /*0x750e1d0*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, string strType);
            /*0x7508ea8*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema);
            /*0x750e4c0*/ bool HasMixedColumns(System.Data.DataTable table);
            /*0x7505654*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk);
            /*0x750ea7c*/ bool IsAutoGenerated(object o);
            /*0x75099f8*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool genNested);
            /*0x7503390*/ void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type);
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

            static /*0x750eac0*/ string QualifiedName(string prefix, string name);
            /*0x750eb28*/ NewDiffgramGen(System.Data.DataSet ds);
            /*0x750eed4*/ NewDiffgramGen(System.Data.DataTable dt, bool writeHierarchy);
            /*0x750eff8*/ void CreateTableHierarchy(System.Data.DataTable dt);
            /*0x750ec70*/ void DoAssignments(System.Collections.ArrayList tables);
            /*0x750f37c*/ bool EmptyData();
            /*0x750f470*/ void Save(System.Xml.XmlWriter xmlw);
            /*0x750f478*/ void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table);
            /*0x750f890*/ void GenerateTable(System.Data.DataTable table);
            /*0x750f90c*/ void GenerateTableErrors(System.Data.DataTable table);
            /*0x750fe40*/ void GenerateRow(System.Data.DataRow row);
            /*0x75103d4*/ void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version);
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

            static /*0x7511904*/ bool RowHasErrors(System.Data.DataRow row);
            static /*0x7514644*/ bool PreserveSpace(object value);
            /*0x7510d90*/ XmlDataTreeWriter(System.Data.DataSet ds);
            /*0x75110fc*/ XmlDataTreeWriter(System.Data.DataTable dt, bool writeHierarchy);
            /*0x7511618*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x7511294*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x75119cc*/ void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder);
            /*0x7513a18*/ void Save(System.Xml.XmlWriter xw, bool writeSchema);
            /*0x75142fc*/ System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row);
            /*0x75120fc*/ void XmlDataRowWriter(System.Data.DataRow row, string encodedTableName);
        }

        class DataTextWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter _xmltextWriter;

            static /*0x7512094*/ System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw);
            /*0x75146d8*/ DataTextWriter(System.Xml.XmlWriter w);
            /*0x7514708*/ System.IO.Stream get_BaseStream();
            /*0x751479c*/ void WriteStartDocument();
            /*0x75147bc*/ void WriteStartDocument(bool standalone);
            /*0x75147e0*/ void WriteEndDocument();
            /*0x7514800*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7514820*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7514840*/ void WriteEndElement();
            /*0x7514860*/ void WriteFullEndElement();
            /*0x7514880*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x75148a0*/ void WriteEndAttribute();
            /*0x75148c4*/ void WriteCData(string text);
            /*0x75148e8*/ void WriteComment(string text);
            /*0x751490c*/ void WriteProcessingInstruction(string name, string text);
            /*0x7514930*/ void WriteEntityRef(string name);
            /*0x7514954*/ void WriteCharEntity(char ch);
            /*0x7514978*/ void WriteWhitespace(string ws);
            /*0x751499c*/ void WriteString(string text);
            /*0x75149c0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x75149e4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7514a08*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7514a2c*/ void WriteRaw(string data);
            /*0x7514a50*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7514a74*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7514a98*/ System.Xml.WriteState get_WriteState();
            /*0x7514abc*/ void Close();
            /*0x7514ae0*/ void Flush();
            /*0x7514b04*/ void WriteQualifiedName(string localName, string ns);
            /*0x7514b28*/ string LookupPrefix(string ns);
            /*0x7514b4c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7514b70*/ string get_XmlLang();
        }

        class DataTextReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader _xmlreader;

            static /*0x7514b94*/ System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr);
            /*0x7514bec*/ DataTextReader(System.Xml.XmlReader input);
            /*0x7514c60*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7514c80*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7514ca0*/ string get_Name();
            /*0x7514cc0*/ string get_LocalName();
            /*0x7514ce0*/ string get_NamespaceURI();
            /*0x7514d00*/ string get_Prefix();
            /*0x7514d20*/ string get_Value();
            /*0x7514d40*/ int get_Depth();
            /*0x7514d60*/ string get_BaseURI();
            /*0x7514d84*/ bool get_IsEmptyElement();
            /*0x7514da8*/ bool get_IsDefault();
            /*0x7514dcc*/ char get_QuoteChar();
            /*0x7514df0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7514e14*/ string get_XmlLang();
            /*0x7514e38*/ int get_AttributeCount();
            /*0x7514e5c*/ string GetAttribute(string name);
            /*0x7514e80*/ string GetAttribute(string localName, string namespaceURI);
            /*0x7514ea4*/ string GetAttribute(int i);
            /*0x7514ec8*/ bool MoveToAttribute(string name);
            /*0x7514eec*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x7514f10*/ void MoveToAttribute(int i);
            /*0x7514f34*/ bool MoveToFirstAttribute();
            /*0x7514f58*/ bool MoveToNextAttribute();
            /*0x7514f7c*/ bool MoveToElement();
            /*0x7514fa0*/ bool ReadAttributeValue();
            /*0x7514fc4*/ bool Read();
            /*0x7514fe8*/ bool get_EOF();
            /*0x751500c*/ void Close();
            /*0x7515030*/ System.Xml.ReadState get_ReadState();
            /*0x7515054*/ void Skip();
            /*0x7515078*/ System.Xml.XmlNameTable get_NameTable();
            /*0x751509c*/ string LookupNamespace(string prefix);
            /*0x75150c0*/ bool get_CanResolveEntity();
            /*0x75150e4*/ void ResolveEntity();
            /*0x7515108*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x751512c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7515150*/ bool get_CanReadValueChunk();
            /*0x7515174*/ string ReadString();
        }

        namespace SqlTypes
        {
            class SQLResource
            {
                static /*0x7515198*/ string get_NullString();
                static /*0x75151d8*/ string get_ArithOverflowMessage();
                static /*0x7515218*/ string get_DivideByZeroMessage();
                static /*0x7515258*/ string get_NullValueMessage();
                static /*0x7515298*/ string get_TruncationMessage();
                static /*0x75152d8*/ string get_DateTimeOverflowMessage();
                static /*0x7515318*/ string get_ConcatDiffCollationMessage();
                static /*0x7515358*/ string get_CompareDiffCollationMessage();
                static /*0x7515398*/ string get_ConversionOverflowMessage();
                static /*0x75153d8*/ string get_TimeZoneSpecifiedMessage();
                static /*0x7515418*/ string get_InvalidPrecScaleMessage();
                static /*0x7515458*/ string get_FormatMessage();
                static /*0x7515498*/ string InvalidOpStreamClosed(string method);
                static /*0x75154e4*/ string InvalidOpStreamNonWritable(string method);
                static /*0x7515530*/ string InvalidOpStreamNonReadable(string method);
                static /*0x751557c*/ string InvalidOpStreamNonSeekable(string method);
            }

            interface INullable
            {
                /*0x3813ffc*/ bool get_IsNull();
            }

            struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBinary Null;
                /*0x10*/ byte[] _value;

                static /*0x7516564*/ SqlBinary();
                static /*0x7515744*/ System.Data.SqlTypes.SqlBinary op_Implicit(byte[] x);
                static /*0x751587c*/ System.Data.SqlTypes.EComparison PerformCompareByte(byte[] x, byte[] y);
                static /*0x7515978*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x7515a8c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x7515b8c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x75160c4*/ int HashByteArray(byte[] rgbValue, int length);
                static /*0x75164d8*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x75155c8*/ SqlBinary(bool fNull);
                /*0x75155d4*/ SqlBinary(byte[] value);
                /*0x7515660*/ bool get_IsNull();
                /*0x7515670*/ byte[] get_Value();
                /*0x7515764*/ string ToString();
                /*0x7515c8c*/ int CompareTo(object value);
                /*0x7515d94*/ int CompareTo(System.Data.SqlTypes.SqlBinary value);
                /*0x7515f34*/ bool Equals(object value);
                /*0x751612c*/ int GetHashCode();
                /*0x75161f0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75161f8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x75163ac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBoolean True;
                static /*0x1*/ System.Data.SqlTypes.SqlBoolean False;
                static /*0x2*/ System.Data.SqlTypes.SqlBoolean Null;
                static /*0x3*/ System.Data.SqlTypes.SqlBoolean Zero;
                static /*0x4*/ System.Data.SqlTypes.SqlBoolean One;
                /*0x10*/ byte m_value;

                static /*0x75171a0*/ SqlBoolean();
                static /*0x7516688*/ System.Data.SqlTypes.SqlBoolean op_Implicit(bool x);
                static /*0x7515ed8*/ bool op_True(System.Data.SqlTypes.SqlBoolean x);
                static /*0x7516698*/ System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x7516750*/ System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x7516978*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x7516a28*/ System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x7516a94*/ System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x7517114*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7515a78*/ SqlBoolean(bool value);
                /*0x75165d0*/ SqlBoolean(int value);
                /*0x751663c*/ SqlBoolean(int value, bool fNull);
                /*0x7516658*/ bool get_IsNull();
                /*0x751606c*/ bool get_Value();
                /*0x7516668*/ bool get_IsTrue();
                /*0x7516678*/ bool get_IsFalse();
                /*0x7516808*/ byte get_ByteValue();
                /*0x751689c*/ string ToString();
                /*0x7516b00*/ int CompareTo(object value);
                /*0x7516c08*/ int CompareTo(System.Data.SqlTypes.SqlBoolean value);
                /*0x7516d0c*/ bool Equals(object value);
                /*0x7516e1c*/ int GetHashCode();
                /*0x7516ed0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7516ed8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7516ffc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7518624*/ SqlByte();
                static /*0x75172c4*/ System.Data.SqlTypes.SqlByte op_Implicit(byte x);
                static /*0x7517370*/ System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x751749c*/ System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75175c8*/ System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75176f8*/ System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75177fc*/ System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x75179ac*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7517a74*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7517b3c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7517c04*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7517c70*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7518598*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7517250*/ SqlByte(bool fNull);
                /*0x7517258*/ SqlByte(byte value);
                /*0x7517268*/ bool get_IsNull();
                /*0x7517278*/ byte get_Value();
                /*0x75172d4*/ string ToString();
                /*0x7517cdc*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7517e00*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x7517f20*/ int CompareTo(object value);
                /*0x7518028*/ int CompareTo(System.Data.SqlTypes.SqlByte value);
                /*0x7518170*/ bool Equals(object value);
                /*0x75182ac*/ int GetHashCode();
                /*0x7518340*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7518348*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7518468*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7518f7c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x7519040*/ System.Data.SqlTypes.SqlBytes get_Null();
                /*0x751869c*/ SqlBytes();
                /*0x75186fc*/ SqlBytes(byte[] buffer);
                /*0x7518774*/ SqlBytes(System.Data.SqlTypes.SqlBinary value);
                /*0x7518804*/ bool get_IsNull();
                /*0x7518814*/ byte[] get_Buffer();
                /*0x75189c4*/ long get_Length();
                /*0x7518a34*/ byte[] get_Value();
                /*0x75186d0*/ void SetNull();
                /*0x751884c*/ void CopyStreamToBuffer();
                /*0x751883c*/ bool FStream();
                /*0x7518c1c*/ void SetBuffer(byte[] buffer);
                /*0x7518c7c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7518c84*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x7518e48*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x7519008*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class SqlChars : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ char[] _rgchBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.Data.SqlTypes.SqlStreamChars _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ char[] _rgchWorkBuf;

                static /*0x7519894*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x7519958*/ System.Data.SqlTypes.SqlChars get_Null();
                /*0x7519094*/ SqlChars();
                /*0x75190f4*/ SqlChars(char[] buffer);
                /*0x751916c*/ SqlChars(System.Data.SqlTypes.SqlString value);
                /*0x7519210*/ bool get_IsNull();
                /*0x7519220*/ char[] get_Buffer();
                /*0x75193c4*/ long get_Length();
                /*0x7519434*/ char[] get_Value();
                /*0x75190c8*/ void SetNull();
                /*0x7519248*/ bool FStream();
                /*0x7519258*/ void CopyStreamToBuffer();
                /*0x7519610*/ void SetBuffer(char[] buffer);
                /*0x7519670*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7519678*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x7519794*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x7519920*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x751ae08*/ SqlDateTime();
                static /*0x7519c3c*/ System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value);
                static /*0x7519ce4*/ System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value);
                static /*0x7519d8c*/ System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value);
                static /*0x7519a24*/ System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value);
                static /*0x751a0bc*/ System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value);
                static /*0x751a1e0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x751a2bc*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x751a3a4*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x751a48c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x751a510*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x751ad7c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x75199ac*/ SqlDateTime(bool fNull);
                /*0x75199b8*/ SqlDateTime(System.DateTime value);
                /*0x7519b08*/ SqlDateTime(int dayTicks, int timeTicks);
                /*0x7519c2c*/ bool get_IsNull();
                /*0x7519f88*/ System.DateTime get_Value();
                /*0x751a024*/ int get_DayTicks();
                /*0x751a070*/ int get_TimeTicks();
                /*0x751a0ec*/ string ToString();
                /*0x751a594*/ int CompareTo(object value);
                /*0x751a6a4*/ int CompareTo(System.Data.SqlTypes.SqlDateTime value);
                /*0x751a810*/ bool Equals(object value);
                /*0x751a95c*/ int GetHashCode();
                /*0x751aa18*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x751aa20*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x751ac20*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7521680*/ SqlDecimal();
                static /*0x751c990*/ System.Data.SqlTypes.SqlDecimal Parse(string s);
                static /*0x751d38c*/ System.Data.SqlTypes.SqlDecimal op_Implicit(decimal x);
                static /*0x751d3a4*/ System.Data.SqlTypes.SqlDecimal op_Implicit(long x);
                static /*0x751d40c*/ System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x);
                static /*0x751d52c*/ System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x751e004*/ System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x751e0e4*/ System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x751ea20*/ System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x751f708*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x751f7e4*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x751f91c*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x751fa98*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x751fb80*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x751f68c*/ void ZeroToMaxLen(uint[] rgulData, int cUI4sCur);
                static /*0x751b98c*/ byte BGetPrecUI4(uint value);
                static /*0x751bb90*/ byte BGetPrecUI8(ulong dwlVal);
                static /*0x7520000*/ void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, ref int ciulD);
                static /*0x7520064*/ void MpSet(uint[] rgulD, ref int ciulD, uint iulN);
                static /*0x7520090*/ void MpNormalize(uint[] rgulU, ref int ciulU);
                static /*0x75200e8*/ void MpMul1(uint[] piulD, ref int ciulD, uint iulX);
                static /*0x751c8b0*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
                static /*0x75201e8*/ ulong DWL(uint lo, uint hi);
                static /*0x75201dc*/ uint HI(ulong x);
                static /*0x75201e4*/ uint LO(ulong x);
                static /*0x751ee50*/ void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, ref int ciulQ, uint[] rgulR, ref int ciulR);
                static /*0x751bf34*/ void CheckValidPrecScale(byte bPrec, byte bScale);
                static /*0x7520470*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x752057c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7520688*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7520794*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7520848*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x751c988*/ char ChFromDigit(uint uiDigit);
                static /*0x75215f4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x751b6ec*/ SqlDecimal(bool fNull);
                /*0x751b754*/ SqlDecimal(decimal value);
                /*0x751b8b8*/ SqlDecimal(int value);
                /*0x751bac4*/ SqlDecimal(long value);
                /*0x751bdd4*/ SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive);
                /*0x751b2ac*/ byte CalculatePrecision();
                /*0x751b4d0*/ bool VerifyPrecision(byte precision);
                /*0x751c098*/ bool get_IsNull();
                /*0x751c108*/ decimal get_Value();
                /*0x751c2bc*/ bool get_IsPositive();
                /*0x751c030*/ void SetPositive();
                /*0x751c37c*/ void SetSignBit(bool fPositive);
                /*0x751c400*/ byte get_Scale();
                /*0x751c494*/ int[] get_Data();
                /*0x751c590*/ string ToString();
                /*0x751d240*/ double ToDouble();
                /*0x751c15c*/ decimal ToDecimal();
                /*0x751c010*/ bool FZero();
                /*0x751df9c*/ bool FGt10_38();
                /*0x751fd8c*/ bool FGt10_38(uint[] rglData);
                /*0x751d090*/ void AddULong(uint ulAdd);
                /*0x751ce88*/ void MultByULong(uint uiMultiplier);
                /*0x751fe5c*/ uint DivByULong(uint iDivisor);
                /*0x751db24*/ void AdjustScale(int digits, bool fRound);
                /*0x751de44*/ int LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x75201f4*/ System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x75208fc*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7520a40*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x7520c8c*/ System.Data.SqlTypes.SqlMoney ToSqlMoney();
                /*0x751fe04*/ void StoreFromWorkingArray(uint[] rguiData);
                /*0x751ce10*/ void SetToZero();
                /*0x7520de0*/ int CompareTo(object value);
                /*0x7520f0c*/ int CompareTo(System.Data.SqlTypes.SqlDecimal value);
                /*0x75210d0*/ bool Equals(object value);
                /*0x7521260*/ int GetHashCode();
                /*0x7521370*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7521378*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x75214dc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlDouble Null;
                static /*0x10*/ System.Data.SqlTypes.SqlDouble Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlDouble MinValue;
                static /*0x30*/ System.Data.SqlTypes.SqlDouble MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ double m_value;

                static /*0x75230d0*/ SqlDouble();
                static /*0x7521af4*/ System.Data.SqlTypes.SqlDouble op_Implicit(double x);
                static /*0x7521bb4*/ System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x);
                static /*0x7521c5c*/ System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7521d84*/ System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7521eac*/ System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7521fd4*/ System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7517d34*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7522130*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x75221fc*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x75222c4*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x752238c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x);
                static /*0x7522458*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x752097c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x75225ac*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7522684*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x752275c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7522834*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x75228b8*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7523044*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7521a1c*/ SqlDouble(bool fNull);
                /*0x7521a28*/ SqlDouble(double value);
                /*0x7521a98*/ bool get_IsNull();
                /*0x7521aa8*/ double get_Value();
                /*0x7521b18*/ string ToString();
                /*0x752293c*/ System.Data.SqlTypes.SqlSingle ToSqlSingle();
                /*0x752299c*/ int CompareTo(object value);
                /*0x7522aa8*/ int CompareTo(System.Data.SqlTypes.SqlDouble value);
                /*0x7522c08*/ bool Equals(object value);
                /*0x7522d4c*/ int GetHashCode();
                /*0x7522de0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7522de8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7522f08*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_sizeOfGuid;
                static /*0x8*/ int[] s_rgiGuidOrder;
                static /*0x10*/ System.Data.SqlTypes.SqlGuid Null;
                /*0x10*/ byte[] m_value;

                static /*0x7523e00*/ SqlGuid();
                static /*0x752325c*/ System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x);
                static /*0x752333c*/ System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x7523434*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x7523514*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x75235f4*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x7523d74*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7523160*/ SqlGuid(bool fNull);
                /*0x752316c*/ SqlGuid(System.Guid g);
                /*0x75231a4*/ bool get_IsNull();
                /*0x75231b4*/ System.Guid get_Value();
                /*0x7523290*/ string ToString();
                /*0x75236d4*/ int CompareTo(object value);
                /*0x75237dc*/ int CompareTo(System.Data.SqlTypes.SqlGuid value);
                /*0x7523920*/ bool Equals(object value);
                /*0x7523a58*/ int GetHashCode();
                /*0x7523aec*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7523af4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7523c28*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x752527c*/ SqlInt16();
                static /*0x7523ef8*/ System.Data.SqlTypes.SqlInt16 op_Implicit(short x);
                static /*0x7523fa4*/ System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x);
                static /*0x7524040*/ System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x752414c*/ System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x7524258*/ System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x75243a0*/ System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x75244f8*/ System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x75245c8*/ System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x75246dc*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x75247a0*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x7524864*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x7524928*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x7524994*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x75251f0*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7523edc*/ SqlInt16(bool fNull);
                /*0x7523ee8*/ SqlInt16(short value);
                /*0x751f8c0*/ bool get_IsNull();
                /*0x751f8d0*/ short get_Value();
                /*0x7523f08*/ string ToString();
                /*0x7524a00*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7524a58*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x7524b78*/ int CompareTo(object value);
                /*0x7524c80*/ int CompareTo(System.Data.SqlTypes.SqlInt16 value);
                /*0x7524dc8*/ bool Equals(object value);
                /*0x7524f04*/ int GetHashCode();
                /*0x7524f98*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7524fa0*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x75250c0*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x75267d8*/ SqlInt32();
                static /*0x7525314*/ System.Data.SqlTypes.SqlInt32 op_Implicit(int x);
                static /*0x75253c0*/ System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x);
                static /*0x752545c*/ System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x752559c*/ System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x75256d0*/ System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x7525818*/ System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x752597c*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7525a4c*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x7525b1c*/ System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x7525590*/ bool SameSignInt(int x, int y);
                static /*0x7525c30*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x7525cf8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x7525dc0*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x7525e88*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x7525ef4*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x752674c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x75252f8*/ SqlInt32(bool fNull);
                /*0x7525304*/ SqlInt32(int value);
                /*0x751f9f8*/ bool get_IsNull();
                /*0x751fa08*/ int get_Value();
                /*0x7525324*/ string ToString();
                /*0x7525f60*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7525fb8*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x75260d8*/ int CompareTo(object value);
                /*0x75261e0*/ int CompareTo(System.Data.SqlTypes.SqlInt32 value);
                /*0x7526324*/ bool Equals(object value);
                /*0x7526460*/ int GetHashCode();
                /*0x75264f4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75264fc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x752661c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7527cf4*/ SqlInt64();
                static /*0x7526870*/ System.Data.SqlTypes.SqlInt64 op_Implicit(long x);
                static /*0x7526918*/ System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x);
                static /*0x75269b4*/ System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7526afc*/ System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7526c34*/ System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7526db8*/ System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7526f00*/ System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7517e58*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7524ab0*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x7526010*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x7520ac0*/ System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x7526aec*/ bool SameSignLong(long x, long y);
                static /*0x752704c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x752711c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x75271ec*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x75272bc*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7527340*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7527c68*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7526854*/ SqlInt64(bool fNull);
                /*0x7526860*/ SqlInt64(long value);
                /*0x7517950*/ bool get_IsNull();
                /*0x7517960*/ long get_Value();
                /*0x752687c*/ string ToString();
                /*0x75273c4*/ System.Data.SqlTypes.SqlByte ToSqlByte();
                /*0x7527428*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7527484*/ System.Data.SqlTypes.SqlInt16 ToSqlInt16();
                /*0x75274e8*/ System.Data.SqlTypes.SqlInt32 ToSqlInt32();
                /*0x7527544*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x75275cc*/ int CompareTo(object value);
                /*0x75276d8*/ int CompareTo(System.Data.SqlTypes.SqlInt64 value);
                /*0x7527838*/ bool Equals(object value);
                /*0x752797c*/ int GetHashCode();
                /*0x7527a10*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7527a18*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7527b38*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7529868*/ SqlMoney();
                static /*0x7528104*/ System.Data.SqlTypes.SqlMoney op_Implicit(decimal x);
                static /*0x7528130*/ System.Data.SqlTypes.SqlMoney op_Implicit(long x);
                static /*0x75282b4*/ System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x);
                static /*0x75283ac*/ System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528558*/ System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528700*/ System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x752883c*/ System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528978*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7528a40*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x7528b08*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x7528bd0*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x7520d0c*/ System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x7528c98*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528d68*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528e38*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528f08*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7528f8c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x75297dc*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7527d8c*/ SqlMoney(bool fNull);
                /*0x7527d98*/ SqlMoney(long value, int ignored);
                /*0x7527da8*/ SqlMoney(int value);
                /*0x7527e24*/ SqlMoney(long value);
                /*0x7527f1c*/ SqlMoney(decimal value);
                /*0x751fc74*/ bool get_IsNull();
                /*0x7528074*/ decimal get_Value();
                /*0x751fc84*/ decimal ToDecimal();
                /*0x752251c*/ double ToDouble();
                /*0x752818c*/ string ToString();
                /*0x7529010*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x752906c*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x75290f4*/ int CompareTo(object value);
                /*0x7529200*/ int CompareTo(System.Data.SqlTypes.SqlMoney value);
                /*0x7529360*/ bool Equals(object value);
                /*0x75294a4*/ int GetHashCode();
                /*0x7529514*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x752951c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x752968c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlSingle Null;
                static /*0x8*/ System.Data.SqlTypes.SqlSingle Zero;
                static /*0x10*/ System.Data.SqlTypes.SqlSingle MinValue;
                static /*0x18*/ System.Data.SqlTypes.SqlSingle MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x14*/ float _value;

                static /*0x752b1dc*/ SqlSingle();
                static /*0x7529aa4*/ System.Data.SqlTypes.SqlSingle op_Implicit(float x);
                static /*0x7529b34*/ System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x);
                static /*0x7529bd4*/ System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7529cf0*/ System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7529e0c*/ System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7529f28*/ System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752a07c*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x752a150*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x752a224*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x752a2f0*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x752a3c0*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x752a48c*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x752a558*/ System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x);
                static /*0x752a624*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752a708*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752a7ec*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752a8d0*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752a93c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x752b150*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7529930*/ SqlSingle(bool fNull);
                /*0x752993c*/ SqlSingle(float value);
                /*0x75299b0*/ SqlSingle(double value);
                /*0x7529a14*/ bool get_IsNull();
                /*0x7529a24*/ float get_Value();
                /*0x7529ac0*/ string ToString();
                /*0x752a9a8*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x752aa04*/ int CompareTo(object value);
                /*0x752ab08*/ int CompareTo(System.Data.SqlTypes.SqlSingle value);
                /*0x752ad18*/ bool Equals(object value);
                /*0x752ae58*/ int GetHashCode();
                /*0x752aeec*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x752aef4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x752b014*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x752ca70*/ SqlString();
                static /*0x752b6d4*/ System.Data.SqlTypes.SqlString op_Implicit(string x);
                static /*0x752b754*/ System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x752b8c4*/ int StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x752bedc*/ System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult);
                static /*0x752c048*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x752b358*/ void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x752be38*/ System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x752baf8*/ int CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x752bcc0*/ int CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x752c9e4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x752b26c*/ SqlString(bool fNull);
                /*0x752b2a0*/ SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions);
                /*0x752b404*/ SqlString(string data);
                /*0x752b4c0*/ SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, string data, System.Globalization.CompareInfo cmpInfo);
                /*0x752b5a0*/ bool get_IsNull();
                /*0x752b5b0*/ string get_Value();
                /*0x752b63c*/ void SetCompareInfo();
                /*0x752b6e8*/ string ToString();
                /*0x752c170*/ bool FBinarySort();
                /*0x752c1dc*/ int CompareTo(object value);
                /*0x752c2f4*/ int CompareTo(System.Data.SqlTypes.SqlString value);
                /*0x752c3f4*/ bool Equals(object value);
                /*0x752c5c0*/ int GetHashCode();
                /*0x752c7e0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x752c7e8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x752c8e8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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
                static /*0x752cc48*/ System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x752cb74*/ SqlTypeException();
                /*0x752b89c*/ SqlTypeException(string message);
                /*0x752cbd4*/ SqlTypeException(string message, System.Exception e);
                /*0x752cbf8*/ SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x752cdc8*/ System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x7529a6c*/ SqlNullValueException();
                /*0x752cd40*/ SqlNullValueException(string message);
                /*0x752cd1c*/ SqlNullValueException(string message, System.Exception e);
                /*0x752cd68*/ SqlNullValueException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x752cf80*/ System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x752ce9c*/ SqlTruncateException();
                /*0x752cef8*/ SqlTruncateException(string message);
                /*0x752ced4*/ SqlTruncateException(string message, System.Exception e);
                /*0x752cf20*/ SqlTruncateException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlStreamChars
            {
                /*0x38146fc*/ long get_Length();
                /*0x38146fc*/ long get_Position();
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

                static /*0x752dc38*/ SqlXml();
                static /*0x752d3c8*/ System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, bool closeInput, bool throwTargetInvocationExceptions);
                static /*0x752d77c*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> CreateSqlReaderDelegate();
                static /*0x752d2b0*/ System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo();
                static /*0x752dbac*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x752d054*/ SqlXml();
                /*0x752d0b4*/ System.Xml.XmlReader CreateReader();
                /*0x752d220*/ bool get_IsNull();
                /*0x752d088*/ void SetNull();
                /*0x752d868*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x752d870*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x752da5c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            class SqlXmlStreamWrapper : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ long _lPosition;
                /*0x38*/ bool _isClosed;

                /*0x752d230*/ SqlXmlStreamWrapper(System.IO.Stream stream);
                /*0x752dd30*/ bool get_CanRead();
                /*0x752ddd8*/ bool get_CanSeek();
                /*0x752de10*/ bool get_CanWrite();
                /*0x752de48*/ long get_Length();
                /*0x752df98*/ long get_Position();
                /*0x752dff4*/ void set_Position(long value);
                /*0x752e0c8*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x752e298*/ int Read(byte[] buffer, int offset, int count);
                /*0x752e4d0*/ void Write(byte[] buffer, int offset, int count);
                /*0x752e708*/ int ReadByte();
                /*0x752e820*/ void WriteByte(byte value);
                /*0x752e908*/ void SetLength(long value);
                /*0x752e99c*/ void Flush();
                /*0x752e9b8*/ void Dispose(bool disposing);
                /*0x752df1c*/ void ThrowIfStreamCannotSeek(string method);
                /*0x752e454*/ void ThrowIfStreamCannotRead(string method);
                /*0x752e68c*/ void ThrowIfStreamCannotWrite(string method);
                /*0x752deb4*/ void ThrowIfStreamClosed(string method);
                /*0x752dd68*/ bool IsStreamClosed();
            }
        }

        namespace Common
        {
            class ObjectStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ object s_defaultValue;
                static /*0x8*/ object s_tempAssemblyCacheLock;
                static /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>, System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache;
                static /*0x18*/ System.Xml.Serialization.XmlSerializerFactory s_serializerFactory;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;

                static /*0x7533f2c*/ ObjectStorage();
                static /*0x7533d88*/ void VerifyIDynamicMetaObjectProvider(System.Type type);
                static /*0x7530724*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type);
                static /*0x7532b74*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute);
                /*0x752e9cc*/ ObjectStorage(System.Data.DataColumn column, System.Type type);
                /*0x752edc4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752edf4*/ int Compare(int recordNo1, int recordNo2);
                /*0x752f444*/ int CompareValueTo(int recordNo1, object value);
                /*0x752f61c*/ int CompareTo(object valueNo1, object valueNo2);
                /*0x752efa8*/ int CompareWithFamilies(object valueNo1, object valueNo2);
                /*0x752f8f8*/ void Copy(int recordNo1, int recordNo2);
                /*0x752f970*/ object Get(int recordNo);
                /*0x752f7f4*/ System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType);
                /*0x752f9ac*/ bool IsNull(int record);
                /*0x752f9e4*/ void Set(int recordNo, object value);
                /*0x753012c*/ void SetCapacity(int capacity);
                /*0x75301ec*/ object ConvertXmlToObject(string s);
                /*0x7530798*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x753316c*/ string ConvertObjectToXml(object value);
                /*0x75337e0*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x7533944*/ object GetEmptyStorage(int recordCount);
                /*0x753398c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7533ba0*/ void SetStorage(object store, System.Collections.BitArray nullbits);

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

                    static /*0x75341c0*/ TempAssemblyComparer();
                    /*0x7534000*/ TempAssemblyComparer();
                    /*0x7534008*/ bool Equals(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> y);
                    /*0x7534138*/ int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> obj);
                }
            }

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

                static /*0x75349f8*/ ADP();
                static /*0x7534228*/ void TraceException(string trace, System.Exception e);
                static /*0x75342c0*/ void TraceExceptionAsReturnValue(System.Exception e);
                static /*0x753432c*/ void TraceExceptionWithoutRethrow(System.Exception e);
                static /*0x7534398*/ System.ArgumentException Argument(string error);
                static /*0x752c0e0*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName);
                static /*0x7534428*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName);
                static /*0x7533e9c*/ System.InvalidOperationException InvalidOperation(string error);
                static /*0x75344c0*/ System.NotSupportedException NotSupported(string error);
                static /*0x752d57c*/ bool IsCatchableExceptionType(System.Exception e);
                static /*0x7534550*/ bool IsCatchableOrSecurityExceptionType(System.Exception e);
                static /*0x7534718*/ System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value);
                static /*0x752e22c*/ System.Exception InvalidSeekOrigin(string parameterName);
                static /*0x7534824*/ System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value);
                static /*0x75348c0*/ System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value);
                static /*0x753495c*/ System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value);
                static /*0x752ac54*/ System.Exception WrongType(System.Type got, System.Type expected);
            }

            class BigIntegerStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Numerics.BigInteger[] _values;

                static /*0x7535234*/ System.Numerics.BigInteger ConvertToBigInteger(object value, System.IFormatProvider formatProvider);
                static /*0x7535890*/ object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider);
                /*0x7534d64*/ BigIntegerStorage(System.Data.DataColumn column);
                /*0x7534f2c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7534f5c*/ int Compare(int recordNo1, int recordNo2);
                /*0x75350e4*/ int CompareValueTo(int recordNo, object value);
                /*0x7535eb0*/ object ConvertValue(object value);
                /*0x7535f50*/ void Copy(int recordNo1, int recordNo2);
                /*0x7535ff0*/ object Get(int record);
                /*0x75360e4*/ void Set(int record, object value);
                /*0x7536254*/ void SetCapacity(int capacity);
                /*0x75363a8*/ object ConvertXmlToObject(string s);
                /*0x7536458*/ string ConvertObjectToXml(object value);
                /*0x7536548*/ object GetEmptyStorage(int recordCount);
                /*0x7536590*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75366a4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class BooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ bool[] _values;

                /*0x7536768*/ BooleanStorage(System.Data.DataColumn column);
                /*0x753682c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7536bb0*/ int Compare(int recordNo1, int recordNo2);
                /*0x7536c3c*/ int CompareValueTo(int recordNo, object value);
                /*0x7536d14*/ object ConvertValue(object value);
                /*0x7536e5c*/ void Copy(int recordNo1, int recordNo2);
                /*0x7536eb0*/ object Get(int record);
                /*0x7536f04*/ void Set(int record, object value);
                /*0x753708c*/ void SetCapacity(int capacity);
                /*0x753715c*/ object ConvertXmlToObject(string s);
                /*0x75371e0*/ string ConvertObjectToXml(object value);
                /*0x753726c*/ object GetEmptyStorage(int recordCount);
                /*0x75372b4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75373b4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ byte[] _values;

                /*0x7537478*/ ByteStorage(System.Data.DataColumn column);
                /*0x753753c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7537cd8*/ int Compare(int recordNo1, int recordNo2);
                /*0x7537d48*/ int CompareValueTo(int recordNo, object value);
                /*0x7537e0c*/ object ConvertValue(object value);
                /*0x7537f50*/ void Copy(int recordNo1, int recordNo2);
                /*0x7537fa4*/ object Get(int record);
                /*0x7537ff8*/ void Set(int record, object value);
                /*0x753817c*/ void SetCapacity(int capacity);
                /*0x753824c*/ object ConvertXmlToObject(string s);
                /*0x75382cc*/ string ConvertObjectToXml(object value);
                /*0x7538358*/ object GetEmptyStorage(int recordCount);
                /*0x75383a0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75384a0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class CharStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ char[] _values;

                /*0x7538564*/ CharStorage(System.Data.DataColumn column);
                /*0x7538628*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7538988*/ int Compare(int recordNo1, int recordNo2);
                /*0x7538a10*/ int CompareValueTo(int recordNo, object value);
                /*0x7538ae8*/ object ConvertValue(object value);
                /*0x7538c2c*/ void Copy(int recordNo1, int recordNo2);
                /*0x7538c80*/ object Get(int record);
                /*0x7538cd4*/ void Set(int record, object value);
                /*0x7538eb4*/ void SetCapacity(int capacity);
                /*0x7538f84*/ object ConvertXmlToObject(string s);
                /*0x7539004*/ string ConvertObjectToXml(object value);
                /*0x7539090*/ object GetEmptyStorage(int recordCount);
                /*0x75390d8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75391d8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
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

                static /*0x753aa6c*/ DataStorage();
                static /*0x7539478*/ System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode);
                static /*0x752eb60*/ System.Data.Common.StorageType GetStorageType(System.Type dataType);
                static /*0x753a330*/ System.Type GetTypeStorage(System.Data.Common.StorageType storageType);
                static /*0x7533768*/ bool IsTypeCustomType(System.Type type);
                static /*0x75392a8*/ bool IsTypeCustomType(System.Data.Common.StorageType typeCode);
                static /*0x753a3ac*/ bool IsSqlType(System.Data.Common.StorageType storageType);
                static /*0x753a3b8*/ bool IsSqlType(System.Type dataType);
                static /*0x75392cc*/ bool DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x753a4a8*/ void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, ref bool sqlType, ref bool nullable, ref bool xmlSerializable, ref bool changeTracking, ref bool revertibleChangeTracking);
                static /*0x753a5fc*/ System.Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType);
                static /*0x753a7a8*/ bool ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x753a870*/ bool IsObjectNull(object value);
                static /*0x753a910*/ bool IsObjectSqlNull(object value);
                static /*0x7530e2c*/ System.Type GetType(string value);
                static /*0x753a9fc*/ string GetQualifiedName(System.Type type);
                /*0x7534e98*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, System.Data.Common.StorageType storageType);
                /*0x753929c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, System.Data.Common.StorageType storageType);
                /*0x752ec70*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, System.Data.Common.StorageType storageType);
                /*0x7539308*/ System.Data.DataSetDateTime get_DateTimeMode();
                /*0x752f8dc*/ System.IFormatProvider get_FormatProvider();
                /*0x7536b9c*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x7539324*/ object AggregateCount(int[] recordNos);
                /*0x7535074*/ int CompareBits(int recordNo1, int recordNo2);
                /*0x38145e4*/ int Compare(int recordNo1, int recordNo2);
                int CompareValueTo(int recordNo1, object value);
                /*0x75393d0*/ object ConvertValue(object value);
                /*0x7535fb0*/ void CopyBits(int srcRecordNo, int dstRecordNo);
                /*0x3815fb8*/ void Copy(int recordNo1, int recordNo2);
                /*0x3814964*/ object Get(int recordNo);
                /*0x75360ac*/ object GetBits(int recordNo);
                /*0x75393d8*/ int GetStringLength(int record);
                /*0x753520c*/ bool HasValue(int recordNo);
                /*0x75393e0*/ bool IsNull(int recordNo);
                /*0x3816044*/ void Set(int recordNo, object value);
                /*0x7536234*/ void SetNullBit(int recordNo, bool flag);
                /*0x7536324*/ void SetCapacity(int capacity);
                /*0x3814a3c*/ object ConvertXmlToObject(string s);
                /*0x75393fc*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x3814a3c*/ string ConvertObjectToXml(object value);
                /*0x753943c*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x753a9c4*/ object GetEmptyStorageInternal(int recordCount);
                /*0x753a9d4*/ void CopyValueInternal(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753a9e4*/ void SetStorageInternal(object store, System.Collections.BitArray nullbits);
                /*0x3814964*/ object GetEmptyStorage(int recordCount);
                void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x3816810*/ void SetStorage(object store, System.Collections.BitArray nullbits);
                /*0x753a9f4*/ void SetNullStorage(System.Collections.BitArray nullbits);
            }

            class DateTimeOffsetStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTimeOffset s_defaultValue;
                /*0x50*/ System.DateTimeOffset[] _values;

                static /*0x753c7d4*/ DateTimeOffsetStorage();
                /*0x753a20c*/ DateTimeOffsetStorage(System.Data.DataColumn column);
                /*0x753b8a4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753bd84*/ int Compare(int recordNo1, int recordNo2);
                /*0x753bf28*/ int CompareValueTo(int recordNo, object value);
                /*0x753c0a8*/ object ConvertValue(object value);
                /*0x753c14c*/ void Copy(int recordNo1, int recordNo2);
                /*0x753c1a0*/ object Get(int record);
                /*0x753c2ac*/ void Set(int record, object value);
                /*0x753c3cc*/ void SetCapacity(int capacity);
                /*0x753c49c*/ object ConvertXmlToObject(string s);
                /*0x753c528*/ string ConvertObjectToXml(object value);
                /*0x753c5c4*/ object GetEmptyStorage(int recordCount);
                /*0x753c60c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753c710*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DateTimeStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTime s_defaultValue;
                /*0x50*/ System.DateTime[] _values;

                static /*0x753dc00*/ DateTimeStorage();
                /*0x753a0f0*/ DateTimeStorage(System.Data.DataColumn column);
                /*0x753c858*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753cd18*/ int Compare(int recordNo1, int recordNo2);
                /*0x753ce90*/ int CompareValueTo(int recordNo, object value);
                /*0x753cff4*/ object ConvertValue(object value);
                /*0x753d144*/ void Copy(int recordNo1, int recordNo2);
                /*0x753d198*/ object Get(int record);
                /*0x753d290*/ void Set(int record, object value);
                /*0x753d604*/ void SetCapacity(int capacity);
                /*0x753d6d4*/ object ConvertXmlToObject(string s);
                /*0x753d788*/ string ConvertObjectToXml(object value);
                /*0x753d83c*/ object GetEmptyStorage(int recordCount);
                /*0x753d884*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753d9e4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DecimalStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ decimal s_defaultValue;
                /*0x50*/ decimal[] _values;

                /*0x7539fc0*/ DecimalStorage(System.Data.DataColumn column);
                /*0x753dc78*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753e68c*/ int Compare(int recordNo1, int recordNo2);
                /*0x753e808*/ int CompareValueTo(int recordNo, object value);
                /*0x753e974*/ object ConvertValue(object value);
                /*0x753eaec*/ void Copy(int recordNo1, int recordNo2);
                /*0x753eb40*/ object Get(int record);
                /*0x753ec04*/ void Set(int record, object value);
                /*0x753edac*/ void SetCapacity(int capacity);
                /*0x753ee7c*/ object ConvertXmlToObject(string s);
                /*0x753ef30*/ string ConvertObjectToXml(object value);
                /*0x753efcc*/ object GetEmptyStorage(int recordCount);
                /*0x753f014*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753f118*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ double[] _values;

                /*0x7539efc*/ DoubleStorage(System.Data.DataColumn column);
                /*0x753f1dc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753f900*/ int Compare(int recordNo1, int recordNo2);
                /*0x753f980*/ int CompareValueTo(int recordNo, object value);
                /*0x753fa48*/ object ConvertValue(object value);
                /*0x753fb88*/ void Copy(int recordNo1, int recordNo2);
                /*0x753fbdc*/ object Get(int record);
                /*0x753fc34*/ void Set(int record, object value);
                /*0x753fdb8*/ void SetCapacity(int capacity);
                /*0x753fe88*/ object ConvertXmlToObject(string s);
                /*0x753ff04*/ string ConvertObjectToXml(object value);
                /*0x753ff90*/ object GetEmptyStorage(int recordCount);
                /*0x753ffd8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75400d8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ short[] _values;

                /*0x7539cb0*/ Int16Storage(System.Data.DataColumn column);
                /*0x754019c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75409ac*/ int Compare(int recordNo1, int recordNo2);
                /*0x7540a0c*/ int CompareValueTo(int recordNo, object value);
                /*0x7540abc*/ object ConvertValue(object value);
                /*0x7540c00*/ void Copy(int recordNo1, int recordNo2);
                /*0x7540c54*/ object Get(int record);
                /*0x7540ca8*/ void Set(int record, object value);
                /*0x7540e2c*/ void SetCapacity(int capacity);
                /*0x7540efc*/ object ConvertXmlToObject(string s);
                /*0x7540f7c*/ string ConvertObjectToXml(object value);
                /*0x7541008*/ object GetEmptyStorage(int recordCount);
                /*0x7541050*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754114c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ int[] _values;

                /*0x7539d74*/ Int32Storage(System.Data.DataColumn column);
                /*0x7541210*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7541a24*/ int Compare(int recordNo1, int recordNo2);
                /*0x7541a90*/ int CompareValueTo(int recordNo, object value);
                /*0x7541b40*/ object ConvertValue(object value);
                /*0x7541c84*/ void Copy(int recordNo1, int recordNo2);
                /*0x7541cd8*/ object Get(int record);
                /*0x7541d2c*/ void Set(int record, object value);
                /*0x7541eb0*/ void SetCapacity(int capacity);
                /*0x7541f80*/ object ConvertXmlToObject(string s);
                /*0x7542000*/ string ConvertObjectToXml(object value);
                /*0x754208c*/ object GetEmptyStorage(int recordCount);
                /*0x75420d4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75421d0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ long[] _values;

                /*0x7539e38*/ Int64Storage(System.Data.DataColumn column);
                /*0x7542294*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7542a84*/ int Compare(int recordNo1, int recordNo2);
                /*0x7542af0*/ int CompareValueTo(int recordNo, object value);
                /*0x7542ba0*/ object ConvertValue(object value);
                /*0x7542ce4*/ void Copy(int recordNo1, int recordNo2);
                /*0x7542d38*/ object Get(int record);
                /*0x7542d8c*/ void Set(int record, object value);
                /*0x7542f10*/ void SetCapacity(int capacity);
                /*0x7542fe0*/ object ConvertXmlToObject(string s);
                /*0x7543060*/ string ConvertObjectToXml(object value);
                /*0x75430ec*/ object GetEmptyStorage(int recordCount);
                /*0x7543134*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7543230*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ sbyte[] _values;

                /*0x7539bec*/ SByteStorage(System.Data.DataColumn column);
                /*0x75432f4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7543ab8*/ int Compare(int recordNo1, int recordNo2);
                /*0x7543b70*/ int CompareValueTo(int recordNo, object value);
                /*0x7543c34*/ object ConvertValue(object value);
                /*0x7543d78*/ void Copy(int recordNo1, int recordNo2);
                /*0x7543dcc*/ object Get(int record);
                /*0x7543e54*/ void Set(int record, object value);
                /*0x7543fd8*/ void SetCapacity(int capacity);
                /*0x75440a8*/ object ConvertXmlToObject(string s);
                /*0x7544128*/ string ConvertObjectToXml(object value);
                /*0x75441b4*/ object GetEmptyStorage(int recordCount);
                /*0x75441fc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75442fc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlConvert
            {
                static /*0x75443c0*/ System.Data.SqlTypes.SqlByte ConvertToSqlByte(object value);
                static /*0x7544594*/ System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(object value);
                static /*0x754482c*/ System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(object value);
                static /*0x7544bcc*/ System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(object value);
                static /*0x7545078*/ System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(object value);
                static /*0x7545758*/ System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(object value);
                static /*0x7545da8*/ System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(object value);
                static /*0x754640c*/ System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(object value);
                static /*0x75469d0*/ System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(object value);
                static /*0x7546bbc*/ System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(object value);
                static /*0x7546d7c*/ System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(object value);
                static /*0x7546f5c*/ System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(object value);
                static /*0x7547130*/ System.Data.SqlTypes.SqlString ConvertToSqlString(object value);
                static /*0x7547304*/ System.Data.SqlTypes.SqlChars ConvertToSqlChars(object value);
                static /*0x7547450*/ System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(object value);
                static /*0x754759c*/ System.DateTimeOffset ConvertStringToDateTimeOffset(string value, System.IFormatProvider formatProvider);
                static /*0x7547604*/ object ChangeTypeForDefaultValue(object value, System.Type type, System.IFormatProvider formatProvider);
                static /*0x75477c4*/ object ChangeType2(object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider);
                static /*0x7530f58*/ object ChangeTypeForXML(object value, System.Type type);
            }

            class SqlBinaryStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBinary[] _values;

                /*0x7548cbc*/ SqlBinaryStorage(System.Data.DataColumn column);
                /*0x7548df0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7549024*/ int Compare(int recordNo1, int recordNo2);
                /*0x75490c4*/ int CompareValueTo(int recordNo, object value);
                /*0x7549180*/ object ConvertValue(object value);
                /*0x75491f8*/ void Copy(int recordNo1, int recordNo2);
                /*0x754923c*/ object Get(int record);
                /*0x75492bc*/ bool IsNull(int record);
                /*0x7549338*/ void Set(int record, object value);
                /*0x7549388*/ void SetCapacity(int capacity);
                /*0x7549448*/ object ConvertXmlToObject(string s);
                /*0x7549730*/ string ConvertObjectToXml(object value);
                /*0x75499d0*/ object GetEmptyStorage(int recordCount);
                /*0x7549a18*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7549b20*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlByte[] _values;

                /*0x7549bbc*/ SqlByteStorage(System.Data.DataColumn column);
                /*0x7549ce8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754ab1c*/ int Compare(int recordNo1, int recordNo2);
                /*0x754abbc*/ int CompareValueTo(int recordNo, object value);
                /*0x754ac78*/ object ConvertValue(object value);
                /*0x754acf0*/ void Copy(int recordNo1, int recordNo2);
                /*0x754ad2c*/ object Get(int record);
                /*0x754adac*/ bool IsNull(int record);
                /*0x754ae28*/ void Set(int record, object value);
                /*0x754ae70*/ void SetCapacity(int capacity);
                /*0x754af30*/ object ConvertXmlToObject(string s);
                /*0x754b218*/ string ConvertObjectToXml(object value);
                /*0x754b4b8*/ object GetEmptyStorage(int recordCount);
                /*0x754b500*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754b600*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBytesStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBytes[] _values;

                /*0x754b69c*/ SqlBytesStorage(System.Data.DataColumn column);
                /*0x754b770*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754b964*/ int Compare(int recordNo1, int recordNo2);
                /*0x754b96c*/ int CompareValueTo(int recordNo, object value);
                /*0x754b974*/ void Copy(int recordNo1, int recordNo2);
                /*0x754b9b4*/ object Get(int record);
                /*0x754b9e4*/ bool IsNull(int record);
                /*0x754ba1c*/ void Set(int record, object value);
                /*0x754bb14*/ void SetCapacity(int capacity);
                /*0x754bbd4*/ object ConvertXmlToObject(string s);
                /*0x754bee0*/ string ConvertObjectToXml(object value);
                /*0x754c180*/ object GetEmptyStorage(int recordCount);
                /*0x754c1c8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754c2d0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlCharsStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlChars[] _values;

                /*0x754c36c*/ SqlCharsStorage(System.Data.DataColumn column);
                /*0x754c440*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754c634*/ int Compare(int recordNo1, int recordNo2);
                /*0x754c63c*/ int CompareValueTo(int recordNo, object value);
                /*0x754c644*/ void Copy(int recordNo1, int recordNo2);
                /*0x754c684*/ object Get(int record);
                /*0x754c6b4*/ bool IsNull(int record);
                /*0x754c6ec*/ void Set(int record, object value);
                /*0x754c7e4*/ void SetCapacity(int capacity);
                /*0x754c8a4*/ object ConvertXmlToObject(string s);
                /*0x754cbbc*/ string ConvertObjectToXml(object value);
                /*0x754ce5c*/ object GetEmptyStorage(int recordCount);
                /*0x754cea4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754cfac*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDateTimeStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDateTime[] _values;

                /*0x754d048*/ SqlDateTimeStorage(System.Data.DataColumn column);
                /*0x754d18c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754d794*/ int Compare(int recordNo1, int recordNo2);
                /*0x754d848*/ int CompareValueTo(int recordNo, object value);
                /*0x754d90c*/ object ConvertValue(object value);
                /*0x754d988*/ void Copy(int recordNo1, int recordNo2);
                /*0x754d9e0*/ object Get(int record);
                /*0x754da70*/ bool IsNull(int record);
                /*0x754daf0*/ void Set(int record, object value);
                /*0x754db44*/ void SetCapacity(int capacity);
                /*0x754dc04*/ object ConvertXmlToObject(string s);
                /*0x754def8*/ string ConvertObjectToXml(object value);
                /*0x754e198*/ object GetEmptyStorage(int recordCount);
                /*0x754e1e0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754e2f8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDecimalStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDecimal[] _values;

                /*0x754e394*/ SqlDecimalStorage(System.Data.DataColumn column);
                /*0x754e4d8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754f42c*/ int Compare(int recordNo1, int recordNo2);
                /*0x754f4fc*/ int CompareValueTo(int recordNo, object value);
                /*0x754f5d8*/ object ConvertValue(object value);
                /*0x754f664*/ void Copy(int recordNo1, int recordNo2);
                /*0x754f6cc*/ object Get(int record);
                /*0x754f758*/ bool IsNull(int record);
                /*0x754f7d8*/ void Set(int record, object value);
                /*0x754f85c*/ void SetCapacity(int capacity);
                /*0x754f91c*/ object ConvertXmlToObject(string s);
                /*0x754fc10*/ string ConvertObjectToXml(object value);
                /*0x754feb0*/ object GetEmptyStorage(int recordCount);
                /*0x754fef8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7550028*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDouble[] _values;

                /*0x75500c4*/ SqlDoubleStorage(System.Data.DataColumn column);
                /*0x75501f8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7550efc*/ int Compare(int recordNo1, int recordNo2);
                /*0x7550fa4*/ int CompareValueTo(int recordNo, object value);
                /*0x7551060*/ object ConvertValue(object value);
                /*0x75510d8*/ void Copy(int recordNo1, int recordNo2);
                /*0x7551114*/ object Get(int record);
                /*0x7551198*/ bool IsNull(int record);
                /*0x7551214*/ void Set(int record, object value);
                /*0x7551260*/ void SetCapacity(int capacity);
                /*0x7551320*/ object ConvertXmlToObject(string s);
                /*0x7551608*/ string ConvertObjectToXml(object value);
                /*0x75518a8*/ object GetEmptyStorage(int recordCount);
                /*0x75518f0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75519f8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlGuidStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlGuid[] _values;

                /*0x7551a94*/ SqlGuidStorage(System.Data.DataColumn column);
                /*0x7551bc8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7551dfc*/ int Compare(int recordNo1, int recordNo2);
                /*0x7551e9c*/ int CompareValueTo(int recordNo, object value);
                /*0x7551f58*/ object ConvertValue(object value);
                /*0x7551fd0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7552014*/ object Get(int record);
                /*0x7552094*/ bool IsNull(int record);
                /*0x7552110*/ void Set(int record, object value);
                /*0x7552160*/ void SetCapacity(int capacity);
                /*0x7552220*/ object ConvertXmlToObject(string s);
                /*0x7552508*/ string ConvertObjectToXml(object value);
                /*0x75527a8*/ object GetEmptyStorage(int recordCount);
                /*0x75527f0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75528f8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt16[] _values;

                /*0x7552994*/ SqlInt16Storage(System.Data.DataColumn column);
                /*0x7552ac0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7553904*/ int Compare(int recordNo1, int recordNo2);
                /*0x75539a4*/ int CompareValueTo(int recordNo, object value);
                /*0x7553a60*/ object ConvertValue(object value);
                /*0x7553ad8*/ void Copy(int recordNo1, int recordNo2);
                /*0x7553b14*/ object Get(int record);
                /*0x7553b94*/ bool IsNull(int record);
                /*0x7553c10*/ void Set(int record, object value);
                /*0x7553c58*/ void SetCapacity(int capacity);
                /*0x7553d18*/ object ConvertXmlToObject(string s);
                /*0x7554000*/ string ConvertObjectToXml(object value);
                /*0x75542a0*/ object GetEmptyStorage(int recordCount);
                /*0x75542e8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75543e8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt32[] _values;

                /*0x7554484*/ SqlInt32Storage(System.Data.DataColumn column);
                /*0x75545b8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75553c4*/ int Compare(int recordNo1, int recordNo2);
                /*0x7555464*/ int CompareValueTo(int recordNo, object value);
                /*0x7555520*/ object ConvertValue(object value);
                /*0x7555598*/ void Copy(int recordNo1, int recordNo2);
                /*0x75555d4*/ object Get(int record);
                /*0x7555654*/ bool IsNull(int record);
                /*0x75556d0*/ void Set(int record, object value);
                /*0x7555718*/ void SetCapacity(int capacity);
                /*0x75557d8*/ object ConvertXmlToObject(string s);
                /*0x7555ac0*/ string ConvertObjectToXml(object value);
                /*0x7555d60*/ object GetEmptyStorage(int recordCount);
                /*0x7555da8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7555ea8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt64[] _values;

                /*0x7555f44*/ SqlInt64Storage(System.Data.DataColumn column);
                /*0x7556078*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7556f08*/ int Compare(int recordNo1, int recordNo2);
                /*0x7556fb0*/ int CompareValueTo(int recordNo, object value);
                /*0x755706c*/ object ConvertValue(object value);
                /*0x75570e4*/ void Copy(int recordNo1, int recordNo2);
                /*0x7557120*/ object Get(int record);
                /*0x75571a4*/ bool IsNull(int record);
                /*0x7557220*/ void Set(int record, object value);
                /*0x755726c*/ void SetCapacity(int capacity);
                /*0x755732c*/ object ConvertXmlToObject(string s);
                /*0x7557614*/ string ConvertObjectToXml(object value);
                /*0x75578b4*/ object GetEmptyStorage(int recordCount);
                /*0x75578fc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7557a04*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlMoneyStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlMoney[] _values;

                /*0x7557aa0*/ SqlMoneyStorage(System.Data.DataColumn column);
                /*0x7557bd4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7558ac4*/ int Compare(int recordNo1, int recordNo2);
                /*0x7558b6c*/ int CompareValueTo(int recordNo, object value);
                /*0x7558c28*/ object ConvertValue(object value);
                /*0x7558ca0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7558cdc*/ object Get(int record);
                /*0x7558d60*/ bool IsNull(int record);
                /*0x7558ddc*/ void Set(int record, object value);
                /*0x7558e28*/ void SetCapacity(int capacity);
                /*0x7558ee8*/ object ConvertXmlToObject(string s);
                /*0x75591d0*/ string ConvertObjectToXml(object value);
                /*0x7559470*/ object GetEmptyStorage(int recordCount);
                /*0x75594b8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75595c0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlSingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlSingle[] _values;

                /*0x755965c*/ SqlSingleStorage(System.Data.DataColumn column);
                /*0x7559790*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x755a570*/ int Compare(int recordNo1, int recordNo2);
                /*0x755a610*/ int CompareValueTo(int recordNo, object value);
                /*0x755a6cc*/ object ConvertValue(object value);
                /*0x755a744*/ void Copy(int recordNo1, int recordNo2);
                /*0x755a780*/ object Get(int record);
                /*0x755a800*/ bool IsNull(int record);
                /*0x755a87c*/ void Set(int record, object value);
                /*0x755a8c4*/ void SetCapacity(int capacity);
                /*0x755a984*/ object ConvertXmlToObject(string s);
                /*0x755ac6c*/ string ConvertObjectToXml(object value);
                /*0x755af0c*/ object GetEmptyStorage(int recordCount);
                /*0x755af54*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x755b054*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlStringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlString[] _values;

                /*0x755b0f0*/ SqlStringStorage(System.Data.DataColumn column);
                /*0x755b224*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x755b620*/ int Compare(int recordNo1, int recordNo2);
                /*0x755b690*/ int Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2);
                /*0x755b7cc*/ int CompareValueTo(int recordNo, object value);
                /*0x755b890*/ object ConvertValue(object value);
                /*0x755b910*/ void Copy(int recordNo1, int recordNo2);
                /*0x755b970*/ object Get(int record);
                /*0x755b9f4*/ int GetStringLength(int record);
                /*0x755bac0*/ bool IsNull(int record);
                /*0x755bb40*/ void Set(int record, object value);
                /*0x755bbb8*/ void SetCapacity(int capacity);
                /*0x755bc78*/ object ConvertXmlToObject(string s);
                /*0x755bf64*/ string ConvertObjectToXml(object value);
                /*0x755c204*/ object GetEmptyStorage(int recordCount);
                /*0x755c24c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x755c370*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBoolean[] _values;

                /*0x755c40c*/ SqlBooleanStorage(System.Data.DataColumn column);
                /*0x755c540*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x755c9bc*/ int Compare(int recordNo1, int recordNo2);
                /*0x755ca5c*/ int CompareValueTo(int recordNo, object value);
                /*0x755cb18*/ object ConvertValue(object value);
                /*0x755cb90*/ void Copy(int recordNo1, int recordNo2);
                /*0x755cbcc*/ object Get(int record);
                /*0x755cc4c*/ bool IsNull(int record);
                /*0x755ccc8*/ void Set(int record, object value);
                /*0x755cd10*/ void SetCapacity(int capacity);
                /*0x755cdd0*/ object ConvertXmlToObject(string s);
                /*0x755d0b8*/ string ConvertObjectToXml(object value);
                /*0x755d358*/ object GetEmptyStorage(int recordCount);
                /*0x755d3a0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x755d4a0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ float[] _values;

                /*0x755d53c*/ SingleStorage(System.Data.DataColumn column);
                /*0x755d604*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x755dd3c*/ int Compare(int recordNo1, int recordNo2);
                /*0x755ddc0*/ int CompareValueTo(int recordNo, object value);
                /*0x755de88*/ object ConvertValue(object value);
                /*0x755dfc0*/ void Copy(int recordNo1, int recordNo2);
                /*0x755e018*/ object Get(int record);
                /*0x755e074*/ void Set(int record, object value);
                /*0x755e1ec*/ void SetCapacity(int capacity);
                /*0x755e2c0*/ object ConvertXmlToObject(string s);
                /*0x755e33c*/ string ConvertObjectToXml(object value);
                /*0x755e3c8*/ object GetEmptyStorage(int recordCount);
                /*0x755e410*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x755e510*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlUdtStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, object> s_typeToNull;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;
                /*0x59*/ bool _implementsIComparable;

                static /*0x755fc5c*/ SqlUdtStorage();
                static /*0x755e64c*/ object GetStaticNullForUdtType(System.Type type);
                /*0x755e5d4*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type);
                /*0x755e760*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type, object nullValue);
                /*0x755e8e4*/ bool IsNull(int record);
                /*0x755e9e8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x755ea18*/ int Compare(int recordNo1, int recordNo2);
                /*0x755ea50*/ int CompareValueTo(int recordNo1, object value);
                /*0x755ecdc*/ void Copy(int recordNo1, int recordNo2);
                /*0x755ed64*/ object Get(int recordNo);
                /*0x755ed94*/ void Set(int recordNo, object value);
                /*0x755ef04*/ void SetCapacity(int capacity);
                /*0x755efd8*/ object ConvertXmlToObject(string s);
                /*0x755f324*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x755f5b4*/ string ConvertObjectToXml(object value);
                /*0x755f8e0*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x755fa38*/ object GetEmptyStorage(int recordCount);
                /*0x755fa80*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x755fbc0*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Type type;

                    /*0x755e8dc*/ <>c__DisplayClass6_0();
                    /*0x755fcf4*/ object <GetStaticNullForUdtType>b__0(System.Type t);
                }
            }

            class StringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ string[] _values;

                /*0x755fe1c*/ StringStorage(System.Data.DataColumn column);
                /*0x755fed0*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x756019c*/ int Compare(int recordNo1, int recordNo2);
                /*0x7560214*/ int CompareValueTo(int recordNo, object value);
                /*0x75602a0*/ object ConvertValue(object value);
                /*0x75602d0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7560310*/ object Get(int recordNo);
                /*0x756034c*/ int GetStringLength(int record);
                /*0x756038c*/ bool IsNull(int record);
                /*0x75603c4*/ void Set(int record, object value);
                /*0x7560444*/ void SetCapacity(int capacity);
                /*0x7560504*/ object ConvertXmlToObject(string s);
                /*0x756050c*/ string ConvertObjectToXml(object value);
                /*0x756053c*/ object GetEmptyStorage(int recordCount);
                /*0x7560584*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x756068c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class TimeSpanStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.TimeSpan s_defaultValue;
                /*0x50*/ System.TimeSpan[] _values;

                static /*0x7562000*/ TimeSpanStorage();
                static /*0x7561770*/ System.TimeSpan ConvertToTimeSpan(object value);
                /*0x7560728*/ TimeSpanStorage(System.Data.DataColumn column);
                /*0x7560848*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7561480*/ int Compare(int recordNo1, int recordNo2);
                /*0x75615fc*/ int CompareValueTo(int recordNo, object value);
                /*0x7561924*/ object ConvertValue(object value);
                /*0x75619d0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7561a28*/ object Get(int record);
                /*0x7561b28*/ void Set(int record, object value);
                /*0x7561bfc*/ void SetCapacity(int capacity);
                /*0x7561cd0*/ object ConvertXmlToObject(string s);
                /*0x7561d5c*/ string ConvertObjectToXml(object value);
                /*0x7561df4*/ object GetEmptyStorage(int recordCount);
                /*0x7561e3c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7561f3c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt16Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ushort s_defaultValue;
                /*0x50*/ ushort[] _values;

                /*0x7562078*/ UInt16Storage(System.Data.DataColumn column);
                /*0x7562160*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7562984*/ int Compare(int recordNo1, int recordNo2);
                /*0x7562a40*/ int CompareValueTo(int recordNo, object value);
                /*0x7562b50*/ object ConvertValue(object value);
                /*0x7562c8c*/ void Copy(int recordNo1, int recordNo2);
                /*0x7562ce4*/ object Get(int record);
                /*0x7562da8*/ void Set(int record, object value);
                /*0x7562f40*/ void SetCapacity(int capacity);
                /*0x7563014*/ object ConvertXmlToObject(string s);
                /*0x7563094*/ string ConvertObjectToXml(object value);
                /*0x7563120*/ object GetEmptyStorage(int recordCount);
                /*0x7563168*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7563268*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt32Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ uint s_defaultValue;
                /*0x50*/ uint[] _values;

                /*0x756332c*/ UInt32Storage(System.Data.DataColumn column);
                /*0x7563414*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7563c3c*/ int Compare(int recordNo1, int recordNo2);
                /*0x7563d08*/ int CompareValueTo(int recordNo, object value);
                /*0x7563e18*/ object ConvertValue(object value);
                /*0x7563f54*/ void Copy(int recordNo1, int recordNo2);
                /*0x7563fac*/ object Get(int record);
                /*0x7564070*/ void Set(int record, object value);
                /*0x7564208*/ void SetCapacity(int capacity);
                /*0x75642dc*/ object ConvertXmlToObject(string s);
                /*0x756435c*/ string ConvertObjectToXml(object value);
                /*0x75643e8*/ object GetEmptyStorage(int recordCount);
                /*0x7564430*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7564530*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt64Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ulong s_defaultValue;
                /*0x50*/ ulong[] _values;

                /*0x75645f4*/ UInt64Storage(System.Data.DataColumn column);
                /*0x75646dc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7564f08*/ int Compare(int recordNo1, int recordNo2);
                /*0x7565010*/ int CompareValueTo(int recordNo, object value);
                /*0x7565120*/ object ConvertValue(object value);
                /*0x756525c*/ void Copy(int recordNo1, int recordNo2);
                /*0x75652b4*/ object Get(int record);
                /*0x7565378*/ void Set(int record, object value);
                /*0x7565510*/ void SetCapacity(int capacity);
                /*0x75655e4*/ object ConvertXmlToObject(string s);
                /*0x7565664*/ string ConvertObjectToXml(object value);
                /*0x75656f0*/ object GetEmptyStorage(int recordCount);
                /*0x7565738*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7565838*/ void SetStorage(object store, System.Collections.BitArray nullbits);
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
