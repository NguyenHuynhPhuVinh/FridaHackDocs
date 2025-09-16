class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7474c50*/ EmbeddedAttribute();
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

                /*0x7474c58*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7474ce0*/ NullableContextAttribute(byte );
            }
        }
    }
}

class SR
{
    static /*0x7474d08*/ string GetString(string name);
    static /*0x7474d0c*/ string Format(string resourceFormat, object p1);
    static /*0x7474d7c*/ string Format(string resourceFormat, object p1, object p2);
    static /*0x7474df4*/ string Format(string resourceFormat, object p1, object p2, object p3);
}

namespace System
{
    class LocalAppContextSwitches
    {
        static /*0x0*/ int s_allowArbitraryTypeInstantiation;

        static /*0x7474e7c*/ bool get_AllowArbitraryTypeInstantiation();
    }

    class LocalAppContext
    {
        static /*0x0*/ bool s_isDisableCachingInitialized;
        static /*0x1*/ bool s_disableCaching;
        static /*0x8*/ object s_syncObject;

        static /*0x7474efc*/ bool GetCachedSwitchValue(string switchName, ref int switchValue);
        static /*0x7474f1c*/ bool GetCachedSwitchValueInternal(string switchName, ref int switchValue);
        static /*0x7474fb0*/ bool get_DisableCaching();

        class <>c
        {
            static /*0x0*/ System.LocalAppContext.<> <>9;
            static /*0x8*/ System.Func<bool> <>9__6_0;

            static /*0x74750c8*/ <>c();
            /*0x7475130*/ <>c();
            /*0x7475138*/ bool <get_DisableCaching>b__6_0();
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

            static /*0x7476734*/ bool IsAutoIncrementType(System.Type dataType);
            /*0x74751b0*/ DataColumn();
            /*0x7475500*/ DataColumn(string columnName, System.Type dataType);
            /*0x7475208*/ DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type);
            /*0x747561c*/ void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode);
            /*0x7475f20*/ bool get_AllowDBNull();
            /*0x7475f28*/ void set_AllowDBNull(bool value);
            /*0x7476500*/ bool get_AutoIncrement();
            /*0x7476520*/ void set_AutoIncrement(bool value);
            /*0x7477334*/ object get_AutoIncrementCurrent();
            /*0x7477388*/ void set_AutoIncrementCurrent(object value);
            /*0x747723c*/ System.Data.AutoIncrementValue get_AutoInc();
            /*0x7477370*/ long get_AutoIncrementSeed();
            /*0x7477580*/ void set_AutoIncrementSeed(long value);
            /*0x7477670*/ long get_AutoIncrementStep();
            /*0x747768c*/ void set_AutoIncrementStep(long value);
            /*0x7477784*/ string get_Caption();
            /*0x74777a0*/ void set_Caption(string value);
            /*0x7477880*/ string get_ColumnName();
            /*0x7477888*/ void set_ColumnName(string value);
            /*0x7477cd4*/ string get_EncodedColumnName();
            /*0x747748c*/ System.IFormatProvider get_FormatProvider();
            /*0x7477814*/ System.Globalization.CultureInfo get_Locale();
            /*0x7477d54*/ int get_ObjectID();
            /*0x7477d5c*/ string get_Prefix();
            /*0x7477d64*/ void set_Prefix(string value);
            /*0x7477f08*/ string GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x747802c*/ bool get_Computed();
            /*0x747803c*/ System.Data.DataExpression get_DataExpression();
            /*0x7478044*/ System.Type get_DataType();
            /*0x7476a24*/ void set_DataType(System.Type value);
            /*0x74787cc*/ System.Data.DataSetDateTime get_DateTimeMode();
            /*0x74787d4*/ void set_DateTimeMode(System.Data.DataSetDateTime value);
            /*0x747825c*/ object get_DefaultValue();
            /*0x747839c*/ void set_DefaultValue(object value);
            /*0x7478b1c*/ bool get_DefaultValueIsNull();
            /*0x7478b24*/ string get_Expression();
            /*0x7475744*/ void set_Expression(string value);
            /*0x7478fb8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x74769c8*/ bool get_HasData();
            /*0x7479028*/ bool get_ImplementsINullable();
            /*0x7479030*/ bool get_ImplementsIChangeTracking();
            /*0x7479038*/ bool get_ImplementsIRevertibleChangeTracking();
            /*0x7479040*/ bool get_IsValueType();
            /*0x747905c*/ bool get_IsSqlType();
            /*0x7479064*/ void SetMaxLengthSimpleType();
            /*0x7479108*/ int get_MaxLength();
            /*0x7479110*/ void set_MaxLength(int value);
            /*0x747990c*/ string get_Namespace();
            /*0x7479950*/ void set_Namespace(string value);
            /*0x7479ae8*/ int get_Ordinal();
            /*0x7479af0*/ void SetOrdinalInternal(int ordinal);
            /*0x7479c30*/ bool get_ReadOnly();
            /*0x7478c38*/ void set_ReadOnly(bool value);
            /*0x7479c78*/ System.Data.Index get_SortIndex();
            /*0x7479d5c*/ System.Data.DataTable get_Table();
            /*0x7479d64*/ void SetTable(System.Data.DataTable table);
            /*0x7479e38*/ System.Data.DataRow GetDataRow(int index);
            /*0x7477fd0*/ object get_Item(int record);
            /*0x7479e5c*/ void set_Item(int record, object value);
            /*0x7478f2c*/ void InitializeRecord(int record);
            /*0x747a0b4*/ void SetValue(int record, object value);
            /*0x747a1bc*/ void FreeRecord(int record);
            /*0x747a1e0*/ bool get_Unique();
            /*0x747a1e8*/ void set_Unique(bool value);
            /*0x747a6dc*/ void InternalUnique(bool value);
            /*0x747a6e8*/ string get_XmlDataType();
            /*0x747a6f0*/ void set_XmlDataType(string value);
            /*0x747a6f8*/ System.Data.SimpleType get_SimpleType();
            /*0x74755c8*/ void set_SimpleType(System.Data.SimpleType value);
            /*0x747a700*/ System.Data.MappingType get_ColumnMapping();
            /*0x747a708*/ void set_ColumnMapping(System.Data.MappingType value);
            /*0x747aa30*/ void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x74794ec*/ bool CheckMaxLength();
            /*0x747aafc*/ void CheckMaxLength(System.Data.DataRow dr);
            /*0x74760c8*/ void CheckNotAllowNull();
            /*0x747aa84*/ void CheckNullable(System.Data.DataRow row);
            /*0x747a690*/ void CheckUnique();
            /*0x747acd0*/ int Compare(int record1, int record2);
            /*0x747acf0*/ bool CompareValueTo(int record1, object value, bool checkType);
            /*0x747ae7c*/ int CompareValueTo(int record1, object value);
            /*0x747ae9c*/ object ConvertValue(object value);
            /*0x747aebc*/ void Copy(int srcRecordNo, int dstRecordNo);
            /*0x747aedc*/ System.Data.DataColumn Clone();
            /*0x747b50c*/ object GetAggregateValue(int[] records, System.Data.AggregateType kind);
            /*0x747ab78*/ int GetStringLength(int record);
            /*0x747b5c4*/ void Init(int record);
            /*0x747b650*/ bool get_IsCustomType();
            /*0x747b6c4*/ bool IsValueCustomTypeInstance(object value);
            /*0x747b784*/ bool get_ImplementsIXMLSerializable();
            /*0x74780cc*/ bool IsInRelation();
            /*0x747b78c*/ bool IsMaxLengthViolated();
            /*0x747bd34*/ bool IsNotAllowDBNullViolated();
            /*0x747bea4*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x7477c60*/ void RaisePropertyChanging(string name);
            /*0x747becc*/ void InsureStorage();
            /*0x747bf68*/ void SetCapacity(int capacity);
            /*0x747bfa4*/ void OnSetDataSet();
            /*0x747bfa8*/ string ToString();
            /*0x747c01c*/ object ConvertXmlToObject(string s);
            /*0x747c058*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x7477ff0*/ string ConvertObjectToXml(object value);
            /*0x747c09c*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x747c0f0*/ object GetEmptyColumnStore(int recordCount);
            /*0x747c124*/ void CopyValueIntoStore(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
            /*0x747c140*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            /*0x747c17c*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x747c298*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x7478df4*/ void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression);
        }

        class AutoIncrementValue
        {
            /*0x10*/ bool <Auto>k__BackingField;

            /*0x747c344*/ AutoIncrementValue();
            /*0x747c330*/ bool get_Auto();
            /*0x747c338*/ void set_Auto(bool value);
            /*0x380b9e8*/ object get_Current();
            /*0x380d83c*/ void set_Current(object value);
            /*0x380b828*/ long get_Seed();
            /*0x380d438*/ void set_Seed(long value);
            /*0x380b828*/ long get_Step();
            /*0x380d438*/ void set_Step(long value);
            /*0x380b9e8*/ System.Type get_DataType();
            /*0x380d93c*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x380d83c*/ void SetCurrentAndIncrement(object value);
            /*0x380cb08*/ void MoveAfter();
            /*0x747b3fc*/ System.Data.AutoIncrementValue Clone();
        }

        class AutoIncrementInt64 : System.Data.AutoIncrementValue
        {
            /*0x18*/ long _current;
            /*0x20*/ long _seed;
            /*0x28*/ long _step;

            /*0x74774f8*/ AutoIncrementInt64();
            /*0x747c34c*/ object get_Current();
            /*0x747c374*/ void set_Current(object value);
            /*0x747c3c8*/ System.Type get_DataType();
            /*0x747c3f8*/ long get_Seed();
            /*0x747c400*/ void set_Seed(long value);
            /*0x747c560*/ long get_Step();
            /*0x747c568*/ void set_Step(long value);
            /*0x747c628*/ void MoveAfter();
            /*0x747c63c*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x747c6b0*/ void SetCurrentAndIncrement(object value);
            /*0x747c490*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class AutoIncrementBigInteger : System.Data.AutoIncrementValue
        {
            /*0x18*/ System.Numerics.BigInteger _current;
            /*0x28*/ long _seed;
            /*0x30*/ System.Numerics.BigInteger _step;

            /*0x7477508*/ AutoIncrementBigInteger();
            /*0x747c7e8*/ object get_Current();
            /*0x747c844*/ void set_Current(object value);
            /*0x747c8c4*/ System.Type get_DataType();
            /*0x747c924*/ long get_Seed();
            /*0x747c92c*/ void set_Seed(long value);
            /*0x747cb48*/ long get_Step();
            /*0x747cba8*/ void set_Step(long value);
            /*0x747cd54*/ void MoveAfter();
            /*0x747cde8*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x747ce18*/ void SetCurrentAndIncrement(object value);
            /*0x747ca20*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class DataException : System.SystemException
        {
            /*0x747cef4*/ DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747cefc*/ DataException();
            /*0x747cf58*/ DataException(string s);
            /*0x747cf7c*/ DataException(string s, System.Exception innerException);
        }

        class ConstraintException : System.Data.DataException
        {
            /*0x747cf84*/ ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747cf8c*/ ConstraintException();
            /*0x747cfe8*/ ConstraintException(string s);
        }

        class DeletedRowInaccessibleException : System.Data.DataException
        {
            /*0x747d00c*/ DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d014*/ DeletedRowInaccessibleException();
            /*0x747d070*/ DeletedRowInaccessibleException(string s);
        }

        class DuplicateNameException : System.Data.DataException
        {
            /*0x747d094*/ DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d09c*/ DuplicateNameException();
            /*0x747d0f8*/ DuplicateNameException(string s);
        }

        class InRowChangingEventException : System.Data.DataException
        {
            /*0x747d11c*/ InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d124*/ InRowChangingEventException();
            /*0x747d180*/ InRowChangingEventException(string s);
        }

        class InvalidConstraintException : System.Data.DataException
        {
            /*0x747d1a4*/ InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d1ac*/ InvalidConstraintException();
            /*0x747d208*/ InvalidConstraintException(string s);
        }

        class NoNullAllowedException : System.Data.DataException
        {
            /*0x747d22c*/ NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d234*/ NoNullAllowedException();
            /*0x747d290*/ NoNullAllowedException(string s);
        }

        class ReadOnlyException : System.Data.DataException
        {
            /*0x747d2b4*/ ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d2bc*/ ReadOnlyException();
            /*0x747d318*/ ReadOnlyException(string s);
        }

        class RowNotInTableException : System.Data.DataException
        {
            /*0x747d33c*/ RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d344*/ RowNotInTableException();
            /*0x747d3a0*/ RowNotInTableException(string s);
        }

        class VersionNotFoundException : System.Data.DataException
        {
            /*0x747d3c4*/ VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x747d3cc*/ VersionNotFoundException();
            /*0x747d428*/ VersionNotFoundException(string s);
        }

        class ExceptionBuilder
        {
            static /*0x747d44c*/ void TraceException(string trace, System.Exception e);
            static /*0x747d4e4*/ System.Exception TraceExceptionAsReturnValue(System.Exception e);
            static /*0x7478d24*/ System.Exception TraceExceptionForCapture(System.Exception e);
            static /*0x7478f68*/ System.Exception TraceExceptionWithoutRethrow(System.Exception e);
            static /*0x747d534*/ System.Exception _Argument(string error);
            static /*0x747d590*/ System.Exception _Argument(string error, System.Exception innerException);
            static /*0x747d5fc*/ System.Exception _ArgumentNull(string paramName, string msg);
            static /*0x747d668*/ System.Exception _ArgumentOutOfRange(string paramName, string msg);
            static /*0x747d6d4*/ System.Exception _IndexOutOfRange(string error);
            static /*0x747d730*/ System.Exception _InvalidOperation(string error);
            static /*0x747d78c*/ System.Exception _InvalidEnumArgumentException(string error);
            static /*0x3907c14*/ System.Exception _InvalidEnumArgumentException<T>(T value);
            static /*0x747d7e8*/ void ThrowDataException(string error, System.Exception innerException);
            static /*0x747d838*/ System.Exception _Data(string error);
            static /*0x747d8a0*/ System.Exception _Constraint(string error);
            static /*0x747d908*/ System.Exception _InvalidConstraint(string error);
            static /*0x747d970*/ System.Exception _DeletedRowInaccessible(string error);
            static /*0x747d9d8*/ System.Exception _DuplicateName(string error);
            static /*0x747da40*/ System.Exception _InRowChangingEvent(string error);
            static /*0x747daa8*/ System.Exception _NoNullAllowed(string error);
            static /*0x747db10*/ System.Exception _ReadOnly(string error);
            static /*0x747db78*/ System.Exception _RowNotInTable(string error);
            static /*0x747dbe0*/ System.Exception _VersionNotFound(string error);
            static /*0x747550c*/ System.Exception ArgumentNull(string paramName);
            static /*0x747dc48*/ System.Exception ArgumentOutOfRange(string paramName);
            static /*0x747dc9c*/ System.Exception BadObjectPropertyAccess(string error);
            static /*0x747dce8*/ System.Exception TypeNotAllowed(System.Type type);
            static /*0x747dd54*/ System.Exception CaseInsensitiveNameConflict(string name);
            static /*0x747dda0*/ System.Exception NamespaceNameConflict(string name);
            static /*0x747ddec*/ System.Exception InvalidOffsetLength();
            static /*0x747de2c*/ System.Exception ColumnNotInTheTable(string column, string table);
            static /*0x747de88*/ System.Exception ColumnNotInAnyTable();
            static /*0x747dec8*/ System.Exception ColumnOutOfRange(int index);
            static /*0x747df58*/ System.Exception ColumnOutOfRange(string column);
            static /*0x747dfa4*/ System.Exception CannotAddColumn1(string column);
            static /*0x747dff0*/ System.Exception CannotAddColumn2(string column);
            static /*0x747a9a4*/ System.Exception CannotAddColumn3();
            static /*0x747a9e4*/ System.Exception CannotAddColumn4(string column);
            static /*0x747e03c*/ System.Exception CannotAddDuplicate(string column);
            static /*0x747e088*/ System.Exception CannotAddDuplicate2(string table);
            static /*0x747e0d4*/ System.Exception CannotAddDuplicate3(string table);
            static /*0x747e120*/ System.Exception CannotRemoveColumn();
            static /*0x747e160*/ System.Exception CannotRemovePrimaryKey();
            static /*0x747e1a0*/ System.Exception CannotRemoveChildKey(string relation);
            static /*0x747e1ec*/ System.Exception CannotRemoveConstraint(string constraint, string table);
            static /*0x747e248*/ System.Exception CannotRemoveExpression(string column, string expression);
            static /*0x747e2a4*/ System.Exception AddPrimaryKeyConstraint();
            static /*0x747e2e4*/ System.Exception NoConstraintName();
            static /*0x747e324*/ System.Exception ConstraintViolation(string constraint);
            static /*0x747e370*/ string KeysToString(object[] keys);
            static /*0x747e488*/ string UniqueConstraintViolationText(System.Data.DataColumn[] columns, object[] values);
            static /*0x747e5e8*/ System.Exception ConstraintViolation(System.Data.DataColumn[] columns, object[] values);
            static /*0x747e5f8*/ System.Exception ConstraintOutOfRange(int index);
            static /*0x747e688*/ System.Exception DuplicateConstraint(string constraint);
            static /*0x747e6d4*/ System.Exception DuplicateConstraintName(string constraint);
            static /*0x747e720*/ System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk);
            static /*0x747e7a8*/ System.Exception UniqueConstraintViolation();
            static /*0x747e7e8*/ System.Exception ConstraintForeignTable();
            static /*0x747e828*/ System.Exception ConstraintParentValues();
            static /*0x747e868*/ System.Exception ConstraintAddFailed(System.Data.DataTable table);
            static /*0x747e8bc*/ System.Exception ConstraintRemoveFailed();
            static /*0x747e8fc*/ System.Exception FailedCascadeDelete(string constraint);
            static /*0x747e948*/ System.Exception FailedCascadeUpdate(string constraint);
            static /*0x747e994*/ System.Exception FailedClearParentTable(string table, string constraint, string childTable);
            static /*0x747e9f8*/ System.Exception ForeignKeyViolation(string constraint, object[] keys);
            static /*0x747ea60*/ System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint);
            static /*0x747bcec*/ string MaxLengthViolationText(string columnName);
            static /*0x747be5c*/ string NotAllowDBNullViolationText(string columnName);
            static /*0x747eac8*/ System.Exception CantAddConstraintToMultipleNestedTable(string tableName);
            static /*0x74766b4*/ System.Exception AutoIncrementAndExpression();
            static /*0x74766f4*/ System.Exception AutoIncrementAndDefaultValue();
            static /*0x747c5e8*/ System.Exception AutoIncrementSeed();
            static /*0x747804c*/ System.Exception CantChangeDataType();
            static /*0x747808c*/ System.Exception NullDataType();
            static /*0x7477c20*/ System.Exception ColumnNameRequired();
            static /*0x7478a34*/ System.Exception DefaultValueAndAutoIncrement();
            static /*0x7478698*/ System.Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x7478a74*/ System.Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x7478b80*/ System.Exception ExpressionAndUnique();
            static /*0x7478d74*/ System.Exception ExpressionAndReadOnly();
            static /*0x7478bc0*/ System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint);
            static /*0x747eb14*/ System.Exception ExpressionInConstraint(System.Data.DataColumn column);
            static /*0x7478db4*/ System.Exception ExpressionCircular();
            static /*0x747ac84*/ System.Exception NonUniqueValues(string column);
            static /*0x747abec*/ System.Exception NullKeyValues(string column);
            static /*0x747ac38*/ System.Exception NullValues(string column);
            static /*0x7479c38*/ System.Exception ReadOnlyAndExpression();
            static /*0x747eb68*/ System.Exception ReadOnly(string column);
            static /*0x747a650*/ System.Exception UniqueAndExpression();
            static /*0x7479fdc*/ System.Exception SetFailed(object value, System.Data.DataColumn column, System.Type type, System.Exception innerException);
            static /*0x747ebb4*/ System.Exception CannotSetToNull(System.Data.DataColumn column);
            static /*0x747ab98*/ System.Exception LongerThanMaxLength(System.Data.DataColumn column);
            static /*0x7479868*/ System.Exception CannotSetMaxLength(System.Data.DataColumn column, int value);
            static /*0x7479444*/ System.Exception CannotSetMaxLength2(System.Data.DataColumn column);
            static /*0x7478770*/ System.Exception CannotSetSimpleContentType(string columnName, System.Type type);
            static /*0x747a948*/ System.Exception CannotSetSimpleContent(string columnName, System.Type type);
            static /*0x7479a9c*/ System.Exception CannotChangeNamespace(string columnName);
            static /*0x7479498*/ System.Exception HasToBeStringType(System.Data.DataColumn column);
            static /*0x74769d8*/ System.Exception AutoIncrementCannotSetIfHasData(string typeName);
            static /*0x747ec08*/ System.Exception INullableUDTwithoutStaticNull(string typeName);
            static /*0x747ec54*/ System.Exception IComparableNotImplemented(string typeName);
            static /*0x747eca0*/ System.Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName);
            static /*0x747ecec*/ System.Exception InvalidDataColumnMapping(System.Type type);
            static /*0x74788f4*/ System.Exception CannotSetDateTimeModeForNonDateTimeColumns();
            static /*0x74789ec*/ System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode);
            static /*0x7478934*/ System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue);
            static /*0x7475560*/ System.Exception ColumnTypeNotSupported();
            static /*0x747ed58*/ System.Exception SetFailed(string name);
            static /*0x747eda4*/ System.Exception CanNotUse();
            static /*0x747ede4*/ System.Exception SetIListObject();
            static /*0x747ee24*/ System.Exception AddNewNotAllowNull();
            static /*0x747ee64*/ System.Exception NotOpen();
            static /*0x747eea4*/ System.Exception CreateChildView();
            static /*0x747eee4*/ System.Exception CanNotDelete();
            static /*0x747ef24*/ System.Exception GetElementIndex(int index);
            static /*0x747efb4*/ System.Exception AddExternalObject();
            static /*0x747eff4*/ System.Exception CanNotClear();
            static /*0x747f034*/ System.Exception InsertExternalObject();
            static /*0x747f074*/ System.Exception RemoveExternalObject();
            static /*0x747f0b4*/ System.Exception KeyTableMismatch();
            static /*0x747f0f4*/ System.Exception KeyNoColumns();
            static /*0x747f134*/ System.Exception KeyTooManyColumns(int cols);
            static /*0x747f1c4*/ System.Exception KeyDuplicateColumns(string columnName);
            static /*0x747f210*/ System.Exception RelationDataSetMismatch();
            static /*0x747821c*/ System.Exception ColumnsTypeMismatch();
            static /*0x747f250*/ System.Exception KeyLengthMismatch();
            static /*0x747f290*/ System.Exception KeyLengthZero();
            static /*0x747f2d0*/ System.Exception ForeignRelation();
            static /*0x747f310*/ System.Exception KeyColumnsIdentical();
            static /*0x747f350*/ System.Exception RelationForeignTable(string t1, string t2);
            static /*0x747f3ac*/ System.Exception GetParentRowTableMismatch(string t1, string t2);
            static /*0x747f408*/ System.Exception SetParentRowTableMismatch(string t1, string t2);
            static /*0x747f464*/ System.Exception RelationForeignRow();
            static /*0x747f4a4*/ System.Exception RelationNestedReadOnly();
            static /*0x747f4e4*/ System.Exception TableCantBeNestedInTwoTables(string tableName);
            static /*0x747f530*/ System.Exception LoopInNestedRelations(string tableName);
            static /*0x747f57c*/ System.Exception RelationDoesNotExist();
            static /*0x747f5bc*/ System.Exception ParentOrChildColumnsDoNotHaveDataSet();
            static /*0x747f5fc*/ System.Exception InValidNestedRelation(string childTableName);
            static /*0x747f648*/ System.Exception InvalidParentNamespaceinNestedRelation(string childTableName);
            static /*0x747f694*/ System.Exception RowNotInTheDataSet();
            static /*0x747f6d4*/ System.Exception RowNotInTheTable();
            static /*0x747f714*/ System.Exception EditInRowChanging();
            static /*0x747f754*/ System.Exception EndEditInRowChanging();
            static /*0x747f794*/ System.Exception BeginEditInRowChanging();
            static /*0x747f7d4*/ System.Exception CancelEditInRowChanging();
            static /*0x747f814*/ System.Exception DeleteInRowDeleting();
            static /*0x747f854*/ System.Exception ValueArrayLength();
            static /*0x747f894*/ System.Exception NoCurrentData();
            static /*0x747f8d4*/ System.Exception NoOriginalData();
            static /*0x747f914*/ System.Exception NoProposedData();
            static /*0x747f954*/ System.Exception RowRemovedFromTheTable();
            static /*0x747f994*/ System.Exception DeletedRowInaccessible();
            static /*0x747f9d4*/ System.Exception RowAlreadyDeleted();
            static /*0x747fa14*/ System.Exception RowEmpty();
            static /*0x747fa54*/ System.Exception InvalidRowVersion();
            static /*0x747fa94*/ System.Exception RowOutOfRange(int index);
            static /*0x747fb24*/ System.Exception RowInsertTwice(int index, string tableName);
            static /*0x747fbc4*/ System.Exception RowInsertMissing(string tableName);
            static /*0x747fc10*/ System.Exception RowAlreadyRemoved();
            static /*0x747fc50*/ System.Exception MultipleParents();
            static /*0x747fc90*/ System.Exception InvalidRowState(System.Data.DataRowState state);
            static /*0x747fcd8*/ System.Exception InvalidRowBitPattern();
            static /*0x747fd18*/ System.Exception SetDataSetNameToEmpty();
            static /*0x747fd58*/ System.Exception SetDataSetNameConflicting(string name);
            static /*0x747fda4*/ System.Exception DataSetUnsupportedSchema(string ns);
            static /*0x747fdf0*/ System.Exception MergeMissingDefinition(string obj);
            static /*0x747fe3c*/ System.Exception TablesInDifferentSets();
            static /*0x747fe7c*/ System.Exception RelationAlreadyExists();
            static /*0x747febc*/ System.Exception RowAlreadyInOtherCollection();
            static /*0x747fefc*/ System.Exception RowAlreadyInTheCollection();
            static /*0x747ff3c*/ System.Exception RecordStateRange();
            static /*0x747ff7c*/ System.Exception IndexKeyLength(int length, int keyLength);
            static /*0x7480058*/ System.Exception RemovePrimaryKey(System.Data.DataTable table);
            static /*0x74800d4*/ System.Exception RelationAlreadyInOtherDataSet();
            static /*0x7480114*/ System.Exception RelationAlreadyInTheDataSet();
            static /*0x7480154*/ System.Exception RelationNotInTheDataSet(string relation);
            static /*0x74801a0*/ System.Exception RelationOutOfRange(object index);
            static /*0x7480224*/ System.Exception DuplicateRelation(string relation);
            static /*0x7480270*/ System.Exception RelationTableNull();
            static /*0x74802b0*/ System.Exception RelationDataSetNull();
            static /*0x74802f0*/ System.Exception RelationTableWasRemoved();
            static /*0x7480330*/ System.Exception ParentTableMismatch();
            static /*0x7480370*/ System.Exception ChildTableMismatch();
            static /*0x74803b0*/ System.Exception EnforceConstraint();
            static /*0x74803f0*/ System.Exception CaseLocaleMismatch();
            static /*0x7480430*/ System.Exception CannotChangeCaseLocale();
            static /*0x7480438*/ System.Exception CannotChangeCaseLocale(System.Exception innerException);
            static /*0x7480480*/ System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode);
            static /*0x74804c8*/ System.Exception TableForeignPrimaryKey();
            static /*0x7480508*/ System.Exception TableCannotAddToSimpleContent();
            static /*0x7480548*/ System.Exception NoTableName();
            static /*0x7480588*/ System.Exception MultipleTextOnlyColumns();
            static /*0x74805c8*/ System.Exception InvalidSortString(string sort);
            static /*0x7480614*/ System.Exception DuplicateTableName(string table);
            static /*0x7480660*/ System.Exception DuplicateTableName2(string table, string ns);
            static /*0x74806bc*/ System.Exception SelfnestedDatasetConflictingName(string table);
            static /*0x7480708*/ System.Exception DatasetConflictingName(string table);
            static /*0x7480754*/ System.Exception TableAlreadyInOtherDataSet();
            static /*0x7480794*/ System.Exception TableAlreadyInTheDataSet();
            static /*0x74807d4*/ System.Exception TableOutOfRange(int index);
            static /*0x7480864*/ System.Exception TableNotInTheDataSet(string table);
            static /*0x74808b0*/ System.Exception TableInRelation();
            static /*0x74808f0*/ System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint);
            static /*0x7480968*/ System.Exception CanNotSerializeDataTableHierarchy();
            static /*0x74809a8*/ System.Exception CanNotRemoteDataTable();
            static /*0x74809e8*/ System.Exception CanNotSetRemotingFormat();
            static /*0x7480a28*/ System.Exception CanNotSerializeDataTableWithEmptyName();
            static /*0x7480a68*/ System.Exception TableNotFound(string tableName);
            static /*0x7480ab4*/ System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type);
            static /*0x7480b6c*/ System.Exception InvalidStorageType(System.TypeCode typecode);
            static /*0x7480c00*/ System.Exception RangeArgument(int min, int max);
            static /*0x7480cb0*/ System.Exception NullRange();
            static /*0x7480cf0*/ System.Exception NegativeMinimumCapacity();
            static /*0x7480d30*/ System.Exception ProblematicChars(char charValue);
            static /*0x7480e0c*/ System.Exception StorageSetFailed();
            static /*0x7480e4c*/ System.Exception SimpleTypeNotSupported();
            static /*0x7480e8c*/ System.Exception MissingAttribute(string attribute);
            static /*0x7480eac*/ System.Exception MissingAttribute(string element, string attribute);
            static /*0x7480f08*/ System.Exception InvalidAttributeValue(string name, string value);
            static /*0x7480f64*/ System.Exception AttributeValues(string name, string value1, string value2);
            static /*0x7480fc8*/ System.Exception ElementTypeNotFound(string name);
            static /*0x7481014*/ System.Exception RelationParentNameMissing(string rel);
            static /*0x7481060*/ System.Exception RelationChildNameMissing(string rel);
            static /*0x74810ac*/ System.Exception RelationTableKeyMissing(string rel);
            static /*0x74810f8*/ System.Exception RelationChildKeyMissing(string rel);
            static /*0x7481144*/ System.Exception UndefinedDatatype(string name);
            static /*0x7481190*/ System.Exception DatatypeNotDefined();
            static /*0x74811d0*/ System.Exception MismatchKeyLength();
            static /*0x7481210*/ System.Exception InvalidField(string name);
            static /*0x748125c*/ System.Exception InvalidSelector(string name);
            static /*0x74812a8*/ System.Exception CircularComplexType(string name);
            static /*0x74812f4*/ System.Exception CannotInstantiateAbstract(string name);
            static /*0x7481340*/ System.Exception InvalidKey(string name);
            static /*0x748138c*/ System.Exception DiffgramMissingTable(string name);
            static /*0x74813d8*/ System.Exception DiffgramMissingSQL();
            static /*0x7481418*/ System.Exception DuplicateConstraintRead(string str);
            static /*0x7481464*/ System.Exception ColumnTypeConflict(string name);
            static /*0x74814b0*/ System.Exception CannotConvert(string name, string type);
            static /*0x748150c*/ System.Exception MissingRefer(string name);
            static /*0x7477ebc*/ System.Exception InvalidPrefix(string name);
            static /*0x7481590*/ System.Exception CanNotDeserializeObjectType();
            static /*0x74815d0*/ System.Exception IsDataSetAttributeMissingInSchema();
            static /*0x7481610*/ System.Exception TooManyIsDataSetAtributeInSchema();
            static /*0x7481650*/ System.Exception NestedCircular(string name);
            static /*0x748169c*/ System.Exception MultipleParentRows(string tableQName);
            static /*0x74816e8*/ System.Exception PolymorphismNotSupported(string typeName);
            static /*0x7481734*/ System.Exception DataTableInferenceNotSupported();
            static /*0x7481774*/ void ThrowMultipleTargetConverter(System.Exception innerException);
            static /*0x74817d4*/ System.Exception DuplicateDeclaration(string name);
            static /*0x7481820*/ System.Exception FoundEntity();
            static /*0x7481860*/ System.Exception MergeFailed(string name);
            static /*0x7481864*/ System.Exception ConvertFailed(System.Type type1, System.Type type2);
            static /*0x74818f4*/ System.Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr);
            static /*0x7481950*/ System.Exception InternalRBTreeError(System.Data.RBTreeError internalError);
            static /*0x74819c4*/ System.Exception EnumeratorModified();
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

            static /*0x7489100*/ void MoveToElement(System.Xml.XmlReader reader);
            static /*0x748d718*/ System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x7481a04*/ DataSet();
            /*0x7481ca4*/ DataSet(string dataSetName);
            /*0x7481ed8*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7481ee0*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema);
            /*0x7481e28*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x7481e30*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x7481ed0*/ System.Data.SchemaSerializationMode get_SchemaSerializationMode();
            /*0x7482120*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7482728*/ void InitializeDerivedDataSet();
            /*0x7482128*/ void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x74820d8*/ void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x7483440*/ void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x74838d8*/ void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x748272c*/ void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7483a7c*/ void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x748289c*/ void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7483d48*/ void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7484f58*/ void FailedEnableConstraints();
            /*0x748510c*/ bool get_CaseSensitive();
            /*0x7485114*/ void set_CaseSensitive(bool value);
            /*0x7485840*/ bool get_EnforceConstraints();
            /*0x7484f84*/ void set_EnforceConstraints(bool value);
            /*0x7485ff8*/ void RestoreEnforceConstraints(bool value);
            /*0x7485848*/ void EnableConstraints();
            /*0x7486004*/ string get_DataSetName();
            /*0x7481ccc*/ void set_DataSetName(string value);
            /*0x7486084*/ string get_Namespace();
            /*0x748608c*/ void set_Namespace(string value);
            /*0x7486560*/ string get_Prefix();
            /*0x7486568*/ void set_Prefix(string value);
            /*0x7484ee8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x7486690*/ System.Globalization.CultureInfo get_Locale();
            /*0x7486698*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x7486838*/ void SetLocaleValue(System.Globalization.CultureInfo value, bool userSet);
            /*0x748745c*/ bool ShouldSerializeLocale();
            /*0x7487464*/ System.ComponentModel.ISite get_Site();
            /*0x748746c*/ System.Data.DataRelationCollection get_Relations();
            /*0x7487474*/ System.Data.DataTableCollection get_Tables();
            /*0x748747c*/ void Clear();
            /*0x74876b0*/ System.Data.DataSet Clone();
            /*0x7483104*/ int EstimatedXmlStringSize();
            /*0x748871c*/ string GetRemotingDiffGram(System.Data.DataTable table);
            /*0x7482f6c*/ string GetXmlSchemaForRemoting(System.Data.DataTable table);
            /*0x748884c*/ void ReadXmlSchema(System.Xml.XmlReader reader);
            /*0x7484608*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x7488c54*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x7488d08*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x74889ac*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x7488854*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x7489178*/ void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x74893b4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader);
            /*0x74893bc*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, bool denyResolving);
            /*0x7488d9c*/ void InferSchema(System.Xml.XmlDocument xdoc, string[] excludedNamespaces, System.Data.XmlReadMode mode);
            /*0x748b850*/ bool IsEmpty();
            /*0x748a4c4*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x7484ee0*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode);
            /*0x748bcc4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x7483224*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode);
            /*0x748bb40*/ void Merge(System.Data.DataSet dataSet);
            /*0x748ca78*/ void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x748cce4*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x748cd0c*/ void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent);
            /*0x748cd68*/ void RaiseMergeFailed(System.Data.DataTable table, string conflict, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x748ce0c*/ void OnDataRowCreated(System.Data.DataRow row);
            /*0x7487688*/ void OnClearFunctionCalled(System.Data.DataTable table);
            /*0x748ce34*/ void OnRemoveTable(System.Data.DataTable table);
            /*0x748ce38*/ void OnRemovedTable(System.Data.DataTable table);
            /*0x748ce64*/ void OnRemoveRelation(System.Data.DataRelation relation);
            /*0x748ce68*/ void OnRemoveRelationHack(System.Data.DataRelation relation);
            /*0x748600c*/ void RaisePropertyChanging(string name);
            /*0x748ce78*/ System.Data.DataTable[] TopLevelTables();
            /*0x748ce80*/ System.Data.DataTable[] TopLevelTables(bool forSchema);
            /*0x748d170*/ void Reset();
            /*0x7485440*/ bool ValidateCaseConstraint();
            /*0x7487004*/ bool ValidateLocaleConstraint();
            /*0x748d430*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x748d994*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x748db5c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x748ddac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x748dde0*/ string get_MainTableName();
            /*0x748dde8*/ void set_MainTableName(string value);
            /*0x748ddf0*/ int get_ObjectID();
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

            static /*0x7473e68*/ System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x745c958*/ DataTable();
            /*0x745cea4*/ DataTable(string tableName);
            /*0x745cf14*/ DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x745d398*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x745d470*/ void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x745d0ac*/ void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x745d744*/ void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x745ea44*/ void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x7461860*/ void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x74628cc*/ void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x74635d0*/ void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x7463720*/ void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x745e408*/ void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x745f8e4*/ void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x7463b24*/ System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, int bitIndex);
            /*0x7463878*/ void GetRowAndColumnErrors(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x7463bcc*/ void ConvertToRowError(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x7463e80*/ bool get_CaseSensitive();
            /*0x7463e88*/ void set_CaseSensitive(bool value);
            /*0x7463f28*/ bool get_AreIndexEventsSuspended();
            /*0x7463f38*/ void RestoreIndexEvents(bool forceReset);
            /*0x74642ec*/ void SuspendIndexEvents();
            /*0x7464398*/ bool get_IsTypedDataTable();
            /*0x7461f7c*/ bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes);
            /*0x7464448*/ bool ShouldSerializeCaseSensitive();
            /*0x7464450*/ bool get_SelfNested();
            /*0x74647e8*/ System.Collections.Generic.List<System.Data.Index> get_LiveIndexes();
            /*0x7464890*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x7464898*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x74648f8*/ int get_UKColumnPositionForInference();
            /*0x7464900*/ void set_UKColumnPositionForInference(int value);
            /*0x7464908*/ System.Data.DataRelationCollection get_ChildRelations();
            /*0x7464984*/ System.Data.DataColumnCollection get_Columns();
            /*0x746498c*/ System.Globalization.CompareInfo get_CompareInfo();
            /*0x74649dc*/ System.Data.ConstraintCollection get_Constraints();
            /*0x74649e4*/ void ResetConstraints();
            /*0x7464a00*/ System.Data.DataSet get_DataSet();
            /*0x7464a08*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x7464acc*/ string get_DisplayExpressionInternal();
            /*0x7464af4*/ bool get_EnforceConstraints();
            /*0x7464b24*/ void set_EnforceConstraints(bool value);
            /*0x746513c*/ bool get_SuspendEnforceConstraints();
            /*0x7465144*/ void set_SuspendEnforceConstraints(bool value);
            /*0x7464b64*/ void EnableConstraints();
            /*0x74612e8*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x7465150*/ System.IFormatProvider get_FormatProvider();
            /*0x74651f0*/ System.Globalization.CultureInfo get_Locale();
            /*0x74651f8*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x74622a4*/ bool SetLocaleValue(System.Globalization.CultureInfo culture, bool userSet, bool resetIndexes);
            /*0x74656b4*/ bool ShouldSerializeLocale();
            /*0x74656bc*/ int get_MinimumCapacity();
            /*0x746289c*/ void set_MinimumCapacity(int value);
            /*0x74656d8*/ int get_RecordCapacity();
            /*0x74656f4*/ int get_ElementColumnCount();
            /*0x74656fc*/ void set_ElementColumnCount(int value);
            /*0x746476c*/ System.Data.DataRelationCollection get_ParentRelations();
            /*0x7465740*/ bool get_MergingData();
            /*0x7465748*/ void set_MergingData(bool value);
            /*0x7465754*/ System.Data.DataRelation[] get_NestedParentRelations();
            /*0x746575c*/ bool get_SchemaLoading();
            /*0x7465764*/ void CacheNestedParent();
            /*0x7465784*/ System.Data.DataRelation[] FindNestedParentRelations();
            /*0x7465c08*/ int get_NestedParentsCount();
            /*0x7465ee8*/ System.Data.DataColumn[] get_PrimaryKey();
            /*0x7465f9c*/ void set_PrimaryKey(System.Data.DataColumn[] value);
            /*0x7466404*/ System.Data.DataRowCollection get_Rows();
            /*0x746640c*/ string get_TableName();
            /*0x7466414*/ void set_TableName(string value);
            /*0x74669d8*/ string get_EncodedTableName();
            /*0x7466a5c*/ string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables);
            /*0x745e9c0*/ string get_Namespace();
            /*0x7460fa0*/ void set_Namespace(string value);
            /*0x7467a70*/ bool IsNamespaceInherited();
            /*0x7466ca4*/ void CheckCascadingNamespaceConflict(string realNamespace);
            /*0x7467080*/ void CheckNamespaceValidityForNestedRelations(string realNamespace);
            /*0x7467a80*/ void CheckNamespaceValidityForNestedParentRelations(string ns, System.Data.DataTable parentTable);
            /*0x74674a4*/ void DoRaiseNamespaceChange();
            /*0x7467e00*/ string get_Prefix();
            /*0x7467e08*/ void set_Prefix(string value);
            /*0x7467f64*/ System.Data.DataColumn get_XmlText();
            /*0x7467f6c*/ void set_XmlText(System.Data.DataColumn value);
            /*0x746802c*/ decimal get_MaxOccurs();
            /*0x7468038*/ void set_MaxOccurs(decimal value);
            /*0x7468040*/ decimal get_MinOccurs();
            /*0x746804c*/ void set_MinOccurs(decimal value);
            /*0x7468054*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues, int record);
            /*0x74680e4*/ System.Data.DataRow FindByIndex(System.Data.Index ndx, object[] key);
            /*0x746817c*/ System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx);
            /*0x74681fc*/ void SetMergeRecords(System.Data.DataRow row, int newRecord, int oldRecord, System.Data.DataRowAction action);
            /*0x746858c*/ System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, bool preserveChanges, System.Data.Index idxSearch);
            /*0x7468f68*/ System.Data.DataTable CreateInstance();
            /*0x7468ff4*/ System.Data.DataTable Clone();
            /*0x7468ffc*/ System.Data.DataTable Clone(System.Data.DataSet cloneDS);
            /*0x74691f0*/ System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable);
            /*0x7469530*/ System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap);
            /*0x746027c*/ System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, bool skipExpressionColumns);
            /*0x74699b0*/ System.ComponentModel.ISite get_Site();
            /*0x74699b8*/ void AddRow(System.Data.DataRow row, int proposedID);
            /*0x74699c8*/ void InsertRow(System.Data.DataRow row, int proposedID, int pos);
            /*0x74699d4*/ void InsertRow(System.Data.DataRow row, long proposedID, int pos, bool fireEvent);
            /*0x746a55c*/ void CheckNotModifying(System.Data.DataRow row);
            /*0x746a58c*/ void Clear();
            /*0x746a594*/ void Clear(bool clearAll);
            /*0x746af78*/ void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x746b030*/ void CommitRow(System.Data.DataRow row);
            /*0x746b1e8*/ int Compare(string s1, string s2);
            /*0x746b1f0*/ int Compare(string s1, string s2, System.Globalization.CompareInfo comparer);
            /*0x746b354*/ int IndexOf(string s1, string s2);
            /*0x746b394*/ bool IsSuffix(string s1, string s2);
            /*0x746b3d4*/ void DeleteRow(System.Data.DataRow row);
            /*0x746b42c*/ string FormatSortString(System.Data.IndexField[] indexDesc);
            /*0x746b558*/ void FreeRecord(ref int record);
            /*0x746b574*/ System.Data.Index GetIndex(string sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x746b918*/ System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x746bae0*/ System.Collections.Generic.List<System.Data.DataViewListener> GetListeners();
            /*0x74655b0*/ int GetSpecialHashCode(string name);
            /*0x7468abc*/ void InsertRow(System.Data.DataRow row, long proposedID);
            /*0x746c7e8*/ int NewRecord();
            /*0x746c8d4*/ int NewUninitializedRecord();
            /*0x746c7f0*/ int NewRecord(int sourceRecord);
            /*0x7463ad0*/ System.Data.DataRow NewEmptyRow();
            /*0x746c8f0*/ System.Data.DataRow NewUninitializedRow();
            /*0x746c9a8*/ System.Data.DataRow NewRow();
            /*0x746ca60*/ System.Data.DataRow CreateEmptyRow();
            /*0x746c9dc*/ void NewRowCreated(System.Data.DataRow row);
            /*0x746c91c*/ System.Data.DataRow NewRow(int record);
            /*0x746ce38*/ System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder);
            /*0x746ce94*/ System.Type GetRowType();
            /*0x746cef4*/ System.Data.DataRow[] NewRowArray(int size);
            /*0x746d0a8*/ bool get_NeedColumnChangeEvents();
            /*0x746d0dc*/ void OnColumnChanging(System.Data.DataColumnChangeEventArgs e);
            /*0x746d1ac*/ void OnColumnChanged(System.Data.DataColumnChangeEventArgs e);
            /*0x746d27c*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x746d34c*/ void OnRemoveColumnInternal(System.Data.DataColumn column);
            /*0x746d35c*/ void OnRemoveColumn(System.Data.DataColumn column);
            /*0x746b144*/ System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x746b0a0*/ System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x746d360*/ void OnRowChanged(System.Data.DataRowChangeEventArgs e);
            /*0x746d430*/ void OnRowChanging(System.Data.DataRowChangeEventArgs e);
            /*0x746d500*/ void OnRowDeleting(System.Data.DataRowChangeEventArgs e);
            /*0x746d5d0*/ void OnRowDeleted(System.Data.DataRowChangeEventArgs e);
            /*0x746d6a0*/ void OnTableCleared(System.Data.DataTableClearEventArgs e);
            /*0x746d770*/ void OnTableClearing(System.Data.DataTableClearEventArgs e);
            /*0x746d840*/ void OnTableNewRow(System.Data.DataTableNewRowEventArgs e);
            /*0x746b5a8*/ System.Data.IndexField[] ParseSortString(string sortString);
            /*0x7466960*/ void RaisePropertyChanging(string name);
            /*0x746d910*/ void RecordChanged(int record);
            /*0x746da8c*/ void RecordChanged(int[] oldIndex, int[] newIndex);
            /*0x746bc7c*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x746be10*/ void RecordStateChanged(int record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, int record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2);
            /*0x746dc64*/ int[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x746de28*/ int[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x746df9c*/ void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, object newValue);
            /*0x746e87c*/ void RemoveRow(System.Data.DataRow row, bool check);
            /*0x746ea1c*/ void Reset();
            /*0x7460274*/ void ResetIndexes();
            /*0x746eca4*/ void ResetInternalIndexes(System.Data.DataColumn column);
            /*0x746ee84*/ void RollbackRow(System.Data.DataRow row);
            /*0x746c600*/ System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x746eef8*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x746bae8*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, bool fireEvent);
            /*0x74682b8*/ void SetNewRecord(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged);
            /*0x7469d60*/ void SetNewRecordWorker(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, ref System.Exception deferredException);
            /*0x7468310*/ void SetOldRecord(System.Data.DataRow row, int proposedRecord);
            /*0x746f0a8*/ void RestoreShadowIndexes();
            /*0x746429c*/ void SetShadowIndexes();
            /*0x746f0c8*/ void ShadowIndexCopy();
            /*0x746f15c*/ string ToString();
            /*0x746eed0*/ bool UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x746f1d0*/ System.Data.DataColumn AddUniqueKey(int position);
            /*0x746f444*/ System.Data.DataColumn AddUniqueKey();
            /*0x746f44c*/ System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey);
            /*0x746f4f8*/ void UpdatePropertyDescriptorCollectionCache();
            /*0x746f50c*/ System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes);
            /*0x7461254*/ System.Xml.XmlQualifiedName get_TypeName();
            /*0x746f778*/ void set_TypeName(System.Xml.XmlQualifiedName value);
            /*0x746f788*/ void Merge(System.Data.DataTable table);
            /*0x746f794*/ void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x746fa04*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy);
            /*0x746fdc0*/ bool CheckForClosureOnExpressions(System.Data.DataTable dt, bool writeHierarchy);
            /*0x7461358*/ bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x74702bc*/ void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy);
            /*0x74705fc*/ void RestoreConstraint(bool originalEnforceConstraint);
            /*0x7470650*/ bool IsEmptyXml(System.Xml.XmlReader reader);
            /*0x7470820*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x74721f4*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x7472288*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x7473700*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x74717f0*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x74737b4*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x74722f8*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x746fed4*/ void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x7473948*/ void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList);
            /*0x74740a4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x74740b4*/ System.Xml.Schema.XmlSchema GetSchema();
            /*0x747427c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x7474428*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x747445c*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x7474468*/ System.Collections.Hashtable get_RowDiffId();
            /*0x74744dc*/ int get_ObjectID();
            /*0x74744e4*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x7474620*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x74746b0*/ void EvaluateExpressions();
            /*0x746c050*/ void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows);
            /*0x7474a28*/ void EvaluateExpressions(System.Data.DataColumn column);
            /*0x746ae18*/ void EvaluateDependentExpressions(System.Data.DataColumn column);
            /*0x746e10c*/ void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows);

            struct RowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataTable _targetTable;

                /*0x748ddf8*/ void Prepare(System.Data.DataTable table);
            }

            struct DSRowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataSet _targetDS;

                /*0x748a444*/ void Prepare(System.Data.DataSet ds);
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

            static /*0x7491018*/ FunctionNode();
            /*0x748de24*/ FunctionNode(System.Data.DataTable table, string name);
            /*0x748df7c*/ void AddArgument(System.Data.ExpressionNode argument);
            /*0x748e168*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x748e600*/ object Eval();
            /*0x748e614*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74908c4*/ object Eval(int[] recordNos);
            /*0x74908f8*/ bool IsConstant();
            /*0x7490988*/ bool IsTableConstant();
            /*0x7490a04*/ bool HasLocalAggregate();
            /*0x7490a80*/ bool HasRemoteAggregate();
            /*0x7490afc*/ bool DependsOn(System.Data.DataColumn column);
            /*0x7490b84*/ System.Data.ExpressionNode Optimize();
            /*0x748ef1c*/ System.Type GetDataType(System.Data.ExpressionNode node);
            /*0x748f19c*/ object EvalFunction(System.Data.FunctionId id, object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x7490d48*/ System.Data.FunctionId get_Aggregate();
            /*0x7490de4*/ bool get_IsAggregate();
            /*0x748e454*/ void Check();
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

            static /*0x7491c7c*/ Function();
            /*0x7491a3c*/ Function(string name, System.Data.FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3);
        }

        class TypeLimiter
        {
            [ThreadStatic] static System.Data.TypeLimiter.Scope s_activeScope;
            /*0x10*/ System.Data.TypeLimiter.Scope m_instanceScope;

            static /*0x74924ec*/ bool get_IsTypeLimitingDisabled();
            static /*0x7492564*/ System.Data.TypeLimiter Capture();
            static /*0x74925e0*/ void EnsureTypeIsAllowed(System.Type type, System.Data.TypeLimiter capturedLimiter);
            static /*0x7492804*/ System.IDisposable EnterRestrictedScope(System.Data.DataSet dataSet);
            static /*0x7492be4*/ System.IDisposable EnterRestrictedScope(System.Data.DataTable dataTable);
            static /*0x7492ca4*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataTable dataTable);
            static /*0x74928c4*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataSet dataSet);
            /*0x74924bc*/ TypeLimiter(System.Data.TypeLimiter.Scope scope);

            class Scope : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.HashSet<System.Type> s_allowedTypes;
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> m_allowedTypes;
                /*0x18*/ System.Data.TypeLimiter.Scope m_previousScope;

                static /*0x74930cc*/ Scope();
                static /*0x7492f14*/ bool IsTypeUnconditionallyAllowed(System.Type type);
                /*0x7492a60*/ Scope(System.Data.TypeLimiter.Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes);
                /*0x7492e40*/ void Dispose();
                /*0x7492678*/ bool IsAllowedType(System.Type type);

                class <>c
                {
                    static /*0x0*/ System.Data.TypeLimiter.Scope.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__3_0;

                    static /*0x7493904*/ <>c();
                    /*0x749396c*/ <>c();
                    /*0x7493974*/ bool <.ctor>b__3_0(System.Type type);
                }
            }

            class <>c
            {
                static /*0x0*/ System.Data.TypeLimiter.<> <>9;
                static /*0x8*/ System.Func<System.Data.DataColumn, System.Type> <>9__10_0;
                static /*0x10*/ System.Func<System.Data.DataTable, System.Collections.Generic.IEnumerable<System.Type>> <>9__11_0;

                static /*0x74939a8*/ <>c();
                /*0x7493a10*/ <>c();
                /*0x7493a18*/ System.Type <GetPreviouslyDeclaredDataTypes>b__10_0(System.Data.DataColumn column);
                /*0x7493a30*/ System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(System.Data.DataTable table);
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

            static /*0x7493ba0*/ InternalDataCollectionBase();
            /*0x7493b98*/ InternalDataCollectionBase();
            /*0x7493a38*/ int get_Count();
            /*0x7493a64*/ void CopyTo(System.Array ar, int index);
            /*0x7493aac*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7493ad8*/ bool get_IsSynchronized();
            /*0x7493ae0*/ int NamesEqual(string s1, string s2, bool fCaseSensitive, System.Globalization.CultureInfo locale);
            /*0x7493b8c*/ object get_SyncRoot();
            /*0x7493b90*/ System.Collections.ArrayList get_List();
        }

        class ColumnTypeConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.Type[] s_types;
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            static /*0x7494520*/ ColumnTypeConverter();
            /*0x7493c24*/ ColumnTypeConverter();
            /*0x7493c2c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7493cdc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7494188*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7494214*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x74943f0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7494510*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7494518*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataCommonEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Data.DataCommonEventSource Log;
            static /*0x8*/ long s_nextScopeId;

            static /*0x74951e8*/ DataCommonEventSource();
            /*0x74951e0*/ DataCommonEventSource();
            /*0x74950fc*/ void Trace(string message);
            /*0x3907c14*/ void Trace<T0>(string format, T0 arg0);
            /*0x3907c14*/ void Trace<T0, T1>(string format, T0 arg0, T1 arg1);
            /*0x3907c14*/ void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2);
            /*0x3907c14*/ void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            /*0x3907c14*/ void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x3907c14*/ void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x749510c*/ long EnterScope(string message);
            /*0x3907c14*/ long EnterScope<T1>(string format, T1 arg1);
            /*0x3907c14*/ long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2);
            /*0x3907c14*/ long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
            /*0x3907c14*/ long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x74951d0*/ void ExitScope(long scopeId);
        }

        class Constraint
        {
            /*0x10*/ string _schemaName;
            /*0x18*/ bool _inCollection;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ string _name;
            /*0x30*/ System.Data.PropertyCollection _extendedProperties;

            /*0x7495958*/ Constraint();
            /*0x7495260*/ string get_ConstraintName();
            /*0x7495268*/ void set_ConstraintName(string value);
            /*0x74956bc*/ string get_SchemaName();
            /*0x74956f4*/ void set_SchemaName(string value);
            /*0x7495738*/ bool get_InCollection();
            /*0x7495740*/ void set_InCollection(bool value);
            /*0x380b9e8*/ System.Data.DataTable get_Table();
            /*0x7495788*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x380b2f0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x380b128*/ bool CanEnableConstraint();
            /*0x380bb68*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x380bba0*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignoreNSforTableLookup);
            /*0x74957f8*/ void CheckConstraint();
            /*0x380d83c*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraint);
            bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, bool fThrowException);
            /*0x380d8b8*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x380cb08*/ void CheckState();
            /*0x749584c*/ void CheckStateForProperty();
            /*0x7495944*/ System.Data.DataSet get__DataSet();
            /*0x380b128*/ bool IsConstraintViolated();
            /*0x749594c*/ string ToString();
        }

        class ConstraintCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;
            /*0x30*/ System.Data.Constraint[] _delayLoadingConstraints;
            /*0x38*/ bool _fLoadForeignKeyConstraintsOnly;

            static /*0x749726c*/ bool CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2);
            /*0x74959ac*/ ConstraintCollection(System.Data.DataTable table);
            /*0x7495a64*/ System.Collections.ArrayList get_List();
            /*0x7495a6c*/ System.Data.Constraint get_Item(int index);
            /*0x7495b68*/ System.Data.DataTable get_Table();
            /*0x7495b70*/ System.Data.Constraint get_Item(string name);
            /*0x7495db8*/ void Add(System.Data.Constraint constraint);
            /*0x7495dc0*/ void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign);
            /*0x7496744*/ System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey);
            /*0x74963a0*/ void AddUniqueConstraint(System.Data.UniqueConstraint constraint);
            /*0x74965ac*/ void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint);
            /*0x74962d0*/ bool AutoGenerated(System.Data.Constraint constraint);
            /*0x74966e4*/ void ArrayAdd(System.Data.Constraint constraint);
            /*0x74967ec*/ void ArrayRemove(System.Data.Constraint constraint);
            /*0x7496588*/ string AssignName();
            /*0x749661c*/ void BaseAdd(System.Data.Constraint constraint);
            /*0x74968dc*/ void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength);
            /*0x7496a90*/ void BaseRemove(System.Data.Constraint constraint);
            /*0x7496d3c*/ bool CanRemove(System.Data.Constraint constraint, bool fThrowException);
            /*0x7496d6c*/ void Clear();
            /*0x7497158*/ bool Contains(string name);
            /*0x7497170*/ bool Contains(string name, bool caseSensitive);
            /*0x7496174*/ System.Data.Constraint FindConstraint(System.Data.Constraint constraint);
            /*0x749647c*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns);
            /*0x74972f4*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column);
            /*0x7497400*/ System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x7495c5c*/ int InternalIndexOf(string constraintName);
            /*0x7496824*/ string MakeName(int index);
            /*0x749671c*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x7495454*/ void RegisterName(string name);
            /*0x7497530*/ void Remove(System.Data.Constraint constraint);
            /*0x749563c*/ void UnregisterName(string name);
        }

        class ConstraintConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x749768c*/ ConstraintConverter();
            /*0x7497694*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7497744*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class ConstraintEnumerator
        {
            /*0x10*/ System.Collections.IEnumerator _tables;
            /*0x18*/ System.Collections.IEnumerator _constraints;
            /*0x20*/ System.Data.Constraint _currentObject;

            /*0x7498188*/ ConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x74981f0*/ bool GetNext();
            /*0x749851c*/ System.Data.Constraint GetConstraint();
            /*0x7498524*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x749852c*/ System.Data.Constraint get_CurrentObject();
        }

        class ForeignKeyConstraintEnumerator : System.Data.ConstraintEnumerator
        {
            /*0x7498534*/ ForeignKeyConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x7498538*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x74985b0*/ System.Data.ForeignKeyConstraint GetForeignKeyConstraint();
        }

        class ChildForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x7498628*/ ChildForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x7498654*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class ParentForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x74986e8*/ ParentForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x7498714*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class DataColumnChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataColumn _column;
            /*0x18*/ System.Data.DataRow <Row>k__BackingField;
            /*0x20*/ object <ProposedValue>k__BackingField;

            /*0x74987ac*/ DataColumnChangeEventArgs(System.Data.DataRow row);
            /*0x7498820*/ DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value);
            /*0x74988c4*/ object get_ProposedValue();
            /*0x74988cc*/ void set_ProposedValue(object value);
            /*0x74988d4*/ void InitializeColumnChangeEvent(System.Data.DataColumn column, object value);
        }

        class DataColumnChangeEventHandler : System.MulticastDelegate
        {
            /*0x7498904*/ DataColumnChangeEventHandler(object object, nint method);
            /*0x7498a10*/ void Invoke(object sender, System.Data.DataColumnChangeEventArgs e);
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

            /*0x7498a24*/ DataColumnCollection(System.Data.DataTable table);
            /*0x7498b98*/ System.Collections.ArrayList get_List();
            /*0x7498ba0*/ System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking();
            /*0x7498ba8*/ int get_ColumnsImplementingIChangeTrackingCount();
            /*0x7498bb0*/ int get_ColumnsImplementingIRevertibleChangeTrackingCount();
            /*0x7498bb8*/ System.Data.DataColumn get_Item(int index);
            /*0x7498ce8*/ System.Data.DataColumn get_Item(string name);
            /*0x7498f88*/ System.Data.DataColumn get_Item(string name, string ns);
            /*0x749902c*/ void Add(System.Data.DataColumn column);
            /*0x7499038*/ void AddAt(int index, System.Data.DataColumn column);
            /*0x74996e4*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x7499780*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x749981c*/ void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74998b8*/ void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74995d4*/ void ArrayAdd(System.Data.DataColumn column);
            /*0x7499594*/ void ArrayAdd(int index, System.Data.DataColumn column);
            /*0x749999c*/ void ArrayRemove(System.Data.DataColumn column);
            /*0x7499be4*/ string AssignName();
            /*0x74992bc*/ void BaseAdd(System.Data.DataColumn column);
            /*0x7499fac*/ void BaseGroupSwitch(System.Data.DataColumn[] oldArray, int oldLength, System.Data.DataColumn[] newArray, int newLength);
            /*0x749a18c*/ void BaseRemove(System.Data.DataColumn column);
            /*0x749a244*/ bool CanRemove(System.Data.DataColumn column, bool fThrowException);
            /*0x7499954*/ void CheckIChangeTracking(System.Data.DataColumn column);
            /*0x749aaa4*/ void Clear();
            /*0x749ad84*/ bool Contains(string name);
            /*0x749ae18*/ bool Contains(string name, bool caseSensitive);
            /*0x749aeb4*/ int IndexOf(string columnName);
            /*0x7498e38*/ int IndexOfCaseInsensitive(string name);
            /*0x7499c78*/ string MakeName(int index);
            /*0x7499640*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x7499294*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x749afb4*/ void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x7499d30*/ void RegisterColumnName(string name, System.Data.DataColumn column);
            /*0x749b00c*/ bool CanRegisterName(string name);
            /*0x749b070*/ void Remove(System.Data.DataColumn column);
            /*0x7499ef0*/ void UnregisterName(string name);
            /*0x749a9c8*/ void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
            /*0x7499acc*/ void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
        }

        class DataColumnPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataColumn <Column>k__BackingField;

            /*0x749b17c*/ DataColumnPropertyDescriptor(System.Data.DataColumn dataColumn);
            /*0x749b1bc*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x749b36c*/ System.Data.DataColumn get_Column();
            /*0x749b374*/ System.Type get_ComponentType();
            /*0x749b3d4*/ bool get_IsReadOnly();
            /*0x749b3f0*/ System.Type get_PropertyType();
            /*0x749b40c*/ bool Equals(object other);
            /*0x749b47c*/ int GetHashCode();
            /*0x749b49c*/ bool CanResetValue(object component);
            /*0x749b5e4*/ object GetValue(object component);
            /*0x749b66c*/ void ResetValue(object component);
            /*0x749b7bc*/ void SetValue(object component, object value);
            /*0x749b89c*/ bool ShouldSerializeValue(object component);
        }

        class DataError
        {
            /*0x10*/ string _rowError;
            /*0x18*/ int _count;
            /*0x20*/ System.Data.DataError.ColumnError[] _errorList;

            /*0x749b8a4*/ DataError();
            /*0x749b8d8*/ DataError(string rowError);
            /*0x749b968*/ string get_Text();
            /*0x749b970*/ void set_Text(string value);
            /*0x749b990*/ bool get_HasErrors();
            /*0x749b9c4*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x749bcf8*/ string GetColumnError(System.Data.DataColumn column);
            /*0x749baf4*/ void Clear(System.Data.DataColumn column);
            /*0x749bd64*/ void Clear();
            /*0x749bde0*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x749b948*/ void SetText(string errorText);
            /*0x749bba0*/ int IndexOf(System.Data.DataColumn column);

            struct ColumnError
            {
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ string _error;
            }
        }

        struct DataKey
        {
            /*0x10*/ System.Data.DataColumn[] _columns;

            static /*0x749c1ac*/ bool ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2);
            /*0x749bedc*/ DataKey(System.Data.DataColumn[] columns, bool copyColumns);
            /*0x749c18c*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x749c194*/ bool get_HasValue();
            /*0x7498158*/ System.Data.DataTable get_Table();
            /*0x749c0f4*/ void CheckState();
            /*0x749c1a4*/ bool ColumnsEqual(System.Data.DataKey key);
            /*0x749a938*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x749c2c4*/ int GetHashCode();
            /*0x749c328*/ bool Equals(object value);
            /*0x749c3a0*/ bool Equals(System.Data.DataKey value);
            /*0x749c458*/ string[] GetColumnNames();
            /*0x749c524*/ System.Data.IndexField[] GetIndexDesc();
            /*0x749c610*/ object[] GetKeyValues(int record);
            /*0x749c720*/ System.Data.Index GetSortIndex();
            /*0x749c728*/ System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates);
            /*0x749c780*/ bool RecordsEqual(int record1, int record2);
            /*0x749c804*/ System.Data.DataColumn[] ToArray();
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

            static /*0x749d29c*/ bool IsKeyNull(object[] values);
            static /*0x749d360*/ System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version);
            static /*0x749d41c*/ System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            static /*0x749d4b4*/ System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            /*0x749c8fc*/ DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints);
            /*0x749ce24*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x749ce2c*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x749cee8*/ DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x749cffc*/ DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x749d140*/ System.Data.DataColumn[] get_ChildColumns();
            /*0x749d244*/ System.Data.DataColumn[] get_ChildColumnsReference();
            /*0x749a998*/ System.Data.DataKey get_ChildKey();
            /*0x749d25c*/ System.Data.DataTable get_ChildTable();
            /*0x749d274*/ System.Data.DataSet get_DataSet();
            /*0x749d28c*/ string[] get_ParentColumnNames();
            /*0x749d294*/ string[] get_ChildColumnNames();
            /*0x749d690*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x749d6a8*/ System.Data.DataColumn[] get_ParentColumns();
            /*0x749d6c0*/ System.Data.DataColumn[] get_ParentColumnsReference();
            /*0x749a9b0*/ System.Data.DataKey get_ParentKey();
            /*0x749d6c8*/ System.Data.DataTable get_ParentTable();
            /*0x749d6e0*/ string get_RelationName();
            /*0x749d6f8*/ void CheckNamespaceValidityForNestedRelations(string ns);
            /*0x749da9c*/ void CheckNestedRelations();
            /*0x749deb4*/ bool get_Nested();
            /*0x749decc*/ void set_Nested(bool value);
            /*0x749f598*/ System.Data.UniqueConstraint get_ParentKeyConstraint();
            /*0x749f5b0*/ void SetParentKeyConstraint(System.Data.UniqueConstraint value);
            /*0x749f5b8*/ System.Data.ForeignKeyConstraint get_ChildKeyConstraint();
            /*0x749f5d0*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x749f640*/ bool get_CheckMultipleNested();
            /*0x749f648*/ void set_CheckMultipleNested(bool value);
            /*0x749f654*/ void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value);
            /*0x749f65c*/ void CheckState();
            /*0x749d158*/ void CheckStateForProperty();
            /*0x749cb08*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x749f88c*/ System.Data.DataRelation Clone(System.Data.DataSet destination);
            /*0x749fff4*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x749f450*/ void RaisePropertyChanging(string name);
            /*0x74a00c4*/ string ToString();
            /*0x749ef80*/ void ValidateMultipleNestedRelations();
            /*0x74a00d0*/ bool IsAutoGenerated(System.Data.DataColumn col);
            /*0x74a0288*/ int get_ObjectID();
        }

        class DataRelationCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataRelation _inTransition;
            /*0x18*/ int _defaultNameIndex;
            /*0x20*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x30*/ int _objectID;

            /*0x74a17bc*/ DataRelationCollection();
            /*0x74a0290*/ int get_ObjectID();
            /*0x380ba90*/ System.Data.DataRelation get_Item(int index);
            /*0x380bb68*/ System.Data.DataRelation get_Item(string name);
            /*0x74a0298*/ void Add(System.Data.DataRelation relation);
            /*0x74a0550*/ void AddCore(System.Data.DataRelation relation);
            /*0x74a07f8*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74a0900*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x74a0a08*/ string AssignName();
            /*0x74a0ae4*/ void Clear();
            /*0x74a0d4c*/ bool Contains(string name);
            /*0x74a0d64*/ int InternalIndexOf(string name);
            /*0x380b9e8*/ System.Data.DataSet GetDataSet();
            /*0x74a0a2c*/ string MakeName(int index);
            /*0x74a0edc*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74a0fac*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74a107c*/ void RegisterName(string name);
            /*0x74a1238*/ void Remove(System.Data.DataRelation relation);
            /*0x74a1434*/ void RemoveAt(int index);
            /*0x74a14a8*/ void RemoveCore(System.Data.DataRelation relation);
            /*0x74a1690*/ void UnregisterName(string name);

            class DataTableRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataTable _table;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ bool _fParentCollection;
                /*0x50*/ System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;

                /*0x74a184c*/ DataTableRelationCollection(System.Data.DataTable table, bool fParentCollection);
                /*0x74a1904*/ System.Collections.ArrayList get_List();
                /*0x74a190c*/ void EnsureDataSet();
                /*0x74a1950*/ System.Data.DataSet GetDataSet();
                /*0x74a1974*/ System.Data.DataRelation get_Item(int index);
                /*0x74a1a74*/ System.Data.DataRelation get_Item(string name);
                /*0x74a1b60*/ void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x74a1bfc*/ void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x74a1c98*/ void AddCache(System.Data.DataRelation relation);
                /*0x74a1ce0*/ void AddCore(System.Data.DataRelation relation);
                /*0x74a1da0*/ void RemoveCache(System.Data.DataRelation relation);
                /*0x74a1e74*/ void RemoveCore(System.Data.DataRelation relation);
            }

            class DataSetRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataSet _dataSet;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ System.Data.DataRelation[] _delayLoadingRelations;

                /*0x74a1f34*/ DataSetRelationCollection(System.Data.DataSet dataSet);
                /*0x74a1fd8*/ System.Collections.ArrayList get_List();
                /*0x74a1fe0*/ void Clear();
                /*0x74a2024*/ System.Data.DataSet GetDataSet();
                /*0x74a202c*/ System.Data.DataRelation get_Item(int index);
                /*0x74a212c*/ System.Data.DataRelation get_Item(string name);
                /*0x74a2218*/ void AddCore(System.Data.DataRelation relation);
                /*0x74a2794*/ void RemoveCore(System.Data.DataRelation relation);
            }
        }

        class DataRelationPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataRelation <Relation>k__BackingField;

            /*0x74a29ec*/ DataRelationPropertyDescriptor(System.Data.DataRelation dataRelation);
            /*0x74a2a40*/ System.Data.DataRelation get_Relation();
            /*0x74a2a48*/ System.Type get_ComponentType();
            /*0x74a2aa8*/ bool get_IsReadOnly();
            /*0x74a2ab0*/ System.Type get_PropertyType();
            /*0x74a2b10*/ bool Equals(object other);
            /*0x74a2b80*/ int GetHashCode();
            /*0x74a2ba0*/ bool CanResetValue(object component);
            /*0x74a2ba8*/ object GetValue(object component);
            /*0x74a2c3c*/ void ResetValue(object component);
            /*0x74a2c40*/ void SetValue(object component, object value);
            /*0x74a2c44*/ bool ShouldSerializeValue(object component);
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

            /*0x74a2c4c*/ DataRow(System.Data.DataRowBuilder builder);
            /*0x74a2d00*/ System.Data.DataColumn get_LastChangedColumn();
            /*0x74a2d1c*/ void set_LastChangedColumn(System.Data.DataColumn value);
            /*0x74a2d30*/ bool get_HasPropertyChanged();
            /*0x74a2d40*/ int get_RBTreeNodeId();
            /*0x74a2d48*/ void set_RBTreeNodeId(int value);
            /*0x74a2df8*/ string get_RowError();
            /*0x74a2e20*/ void set_RowError(string value);
            /*0x74a2f74*/ void RowErrorChanged();
            /*0x74a2fc4*/ long get_rowID();
            /*0x74a2fcc*/ void set_rowID(long value);
            /*0x74a3024*/ System.Data.DataRowState get_RowState();
            /*0x74a3248*/ System.Data.DataTable get_Table();
            /*0x749f4bc*/ void CheckForLoops(System.Data.DataRelation rel);
            /*0x74a3250*/ int GetNestedParentCount();
            /*0x74a3318*/ void set_Item(string columnName, object value);
            /*0x74a320c*/ object get_Item(System.Data.DataColumn column);
            /*0x74a33ac*/ void set_Item(System.Data.DataColumn column, object value);
            /*0x74a3a04*/ object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version);
            /*0x74a3aa8*/ void set_ItemArray(object[] value);
            /*0x74a3e90*/ void AcceptChanges();
            /*0x74a4210*/ void BeginEdit();
            /*0x74a3788*/ bool BeginEditInternal();
            /*0x74a389c*/ void CancelEdit();
            /*0x74a36ac*/ void CheckColumn(System.Data.DataColumn column);
            /*0x74a4214*/ void CheckInTable();
            /*0x74a4250*/ void Delete();
            /*0x74a3904*/ void EndEdit();
            /*0x74a42b0*/ void SetColumnError(int columnIndex, string error);
            /*0x74a4314*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x74a4548*/ string GetColumnError(System.Data.DataColumn column);
            /*0x74a45f4*/ void ClearErrors();
            /*0x749a910*/ void ClearError(System.Data.DataColumn column);
            /*0x74a461c*/ bool get_HasErrors();
            /*0x74a4660*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x74a4704*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation);
            /*0x74a470c*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74a3344*/ System.Data.DataColumn GetDataColumn(string columnName);
            /*0x749f590*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation);
            /*0x74a4828*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74a4934*/ System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version);
            /*0x74a49f0*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation);
            /*0x74a49f8*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x74a4b14*/ object[] GetColumnValues(System.Data.DataColumn[] columns);
            /*0x74a4b1c*/ object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version);
            /*0x74a4b6c*/ object[] GetKeyValues(System.Data.DataKey key);
            /*0x749d3f8*/ object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version);
            /*0x74a4b8c*/ int GetCurrentRecordNo();
            /*0x74a3724*/ int GetDefaultRecord();
            /*0x74a4bc8*/ int GetOriginalRecordNo();
            /*0x74a3860*/ int GetProposedRecordNo();
            /*0x74a3a48*/ int GetRecordFromVersion(System.Data.DataRowVersion version);
            /*0x74a4c04*/ System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState);
            /*0x74a4c40*/ System.Data.DataViewRowState GetRecordState(int record);
            /*0x74a4c98*/ bool HasKeyChanged(System.Data.DataKey key);
            /*0x74a4ca4*/ bool HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x749d608*/ bool HasVersion(System.Data.DataRowVersion version);
            /*0x74a4d28*/ bool HaveValuesChanged(System.Data.DataColumn[] columns);
            /*0x74a4d34*/ bool HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x74a4ddc*/ void RejectChanges();
            /*0x74a3000*/ void ResetLastChangedColumn();
            /*0x74a53d0*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues);
            /*0x74a54e8*/ void SetNestedParentRow(System.Data.DataRow parentRow, bool setNonNested);
            /*0x74a58dc*/ void SetParentRowToDBNull();
            /*0x74a5bc0*/ void SetParentRowToDBNull(System.Data.DataRelation relation);
            /*0x74a5d38*/ int CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, int storeIndex);
        }

        class DataRowBuilder
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _record;

            /*0x74a6024*/ DataRowBuilder(System.Data.DataTable table, int record);
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

            /*0x74a6060*/ DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action);
        }

        class DataRowChangeEventHandler : System.MulticastDelegate
        {
            /*0x74a60e0*/ DataRowChangeEventHandler(object object, nint method);
            /*0x74a61ec*/ void Invoke(object sender, System.Data.DataRowChangeEventArgs e);
        }

        class DataRowCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataRowCollection.DataRowTree _list;
            /*0x20*/ int _nullInList;

            /*0x74a6200*/ DataRowCollection(System.Data.DataTable table);
            /*0x74a62f4*/ int get_Count();
            /*0x749a8b8*/ System.Data.DataRow get_Item(int index);
            /*0x74a6344*/ void Add(System.Data.DataRow row);
            /*0x74a6364*/ void DiffInsertAt(System.Data.DataRow row, int pos);
            /*0x74a656c*/ int IndexOf(System.Data.DataRow row);
            /*0x74a6604*/ System.Data.DataRow AddWithColumnEvents(object[] values);
            /*0x74a6664*/ void ArrayAdd(System.Data.DataRow row);
            /*0x74a66cc*/ void ArrayInsert(System.Data.DataRow row, int pos);
            /*0x74a6744*/ void ArrayClear();
            /*0x74a6794*/ void ArrayRemove(System.Data.DataRow row);
            /*0x74a6828*/ void CopyTo(System.Array ar, int index);
            /*0x74a6890*/ void CopyTo(System.Data.DataRow[] array, int index);
            /*0x74a68f8*/ System.Collections.IEnumerator GetEnumerator();

            class DataRowTree : System.Data.RBTree<System.Data.DataRow>
            {
                /*0x74a62a8*/ DataRowTree();
                /*0x74a6948*/ int CompareNode(System.Data.DataRow record1, System.Data.DataRow record2);
                /*0x74a6974*/ int CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2);
            }
        }

        class DataRowCreatedEventHandler : System.MulticastDelegate
        {
            /*0x74a69a0*/ DataRowCreatedEventHandler(object object, nint method);
            /*0x74a6aac*/ void Invoke(object sender, System.Data.DataRow r);
        }

        class DataSetClearEventhandler : System.MulticastDelegate
        {
            /*0x74a6ac0*/ DataSetClearEventhandler(object object, nint method);
            /*0x74a6bcc*/ void Invoke(object sender, System.Data.DataTable table);
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

            static /*0x74a7260*/ DataRowView();
            /*0x74a6be0*/ DataRowView(System.Data.DataView dataView, System.Data.DataRow row);
            /*0x74a6c24*/ bool Equals(object other);
            /*0x74a6c30*/ int GetHashCode();
            /*0x74a6c50*/ System.Data.DataView get_DataView();
            /*0x74a6c58*/ System.Data.DataRowVersion get_RowVersionDefault();
            /*0x74a6cb0*/ int GetRecord();
            /*0x74a6cd4*/ bool HasRecord();
            /*0x749b5b0*/ object GetColumnValue(System.Data.DataColumn column);
            /*0x749b730*/ void SetColumnValue(System.Data.DataColumn column, object value);
            /*0x74a6cf8*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent);
            /*0x74a2c34*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation);
            /*0x74a6e94*/ System.Data.DataRow get_Row();
            /*0x74a6e9c*/ void EndEdit();
            /*0x74a6ee8*/ bool get_IsNew();
            /*0x74a6f10*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x74a6fac*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x74a7048*/ void RaisePropertyChangedEvent(string propName);
            /*0x74a70d8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
            /*0x74a7130*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
            /*0x74a7138*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
            /*0x74a71d4*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
            /*0x74a725c*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
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

            /*0x74a72e0*/ DataTableClearEventArgs(System.Data.DataTable dataTable);
        }

        class DataTableClearEventHandler : System.MulticastDelegate
        {
            /*0x74a7354*/ DataTableClearEventHandler(object object, nint method);
            /*0x74a7460*/ void Invoke(object sender, System.Data.DataTableClearEventArgs e);
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

            /*0x74a7474*/ DataTableCollection(System.Data.DataSet dataSet);
            /*0x74a75dc*/ System.Collections.ArrayList get_List();
            /*0x74a75e4*/ int get_ObjectID();
            /*0x74a75ec*/ System.Data.DataTable get_Item(int index);
            /*0x74a771c*/ System.Data.DataTable get_Item(string name);
            /*0x749feec*/ System.Data.DataTable get_Item(string name, string tableNamespace);
            /*0x74a7b64*/ System.Data.DataTable GetTable(string name, string ns);
            /*0x74a7c80*/ System.Data.DataTable GetTableSmart(string name, string ns);
            /*0x74a7dbc*/ void Add(System.Data.DataTable table);
            /*0x74a823c*/ void ArrayAdd(System.Data.DataTable table);
            /*0x74a8330*/ string AssignName();
            /*0x74a8128*/ void BaseAdd(System.Data.DataTable table);
            /*0x74a86a8*/ void BaseGroupSwitch(System.Data.DataTable[] oldArray, int oldLength, System.Data.DataTable[] newArray, int newLength);
            /*0x74a8820*/ void BaseRemove(System.Data.DataTable table);
            /*0x74a8898*/ bool CanRemove(System.Data.DataTable table, bool fThrowException);
            /*0x74a8e20*/ void Clear();
            /*0x74a8430*/ bool Contains(string name);
            /*0x74a90f8*/ bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive);
            /*0x74a926c*/ bool Contains(string name, bool caseSensitive);
            /*0x74a9394*/ int IndexOf(System.Data.DataTable table);
            /*0x74a9478*/ int IndexOf(string tableName);
            /*0x74a9490*/ int IndexOf(string tableName, string tableNamespace, bool chekforNull);
            /*0x74a94f0*/ void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x74a7810*/ int InternalIndexOf(string tableName);
            /*0x74a79d8*/ int InternalIndexOf(string tableName, string tableNamespace);
            /*0x74a8378*/ string MakeName(int index);
            /*0x74a8260*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74a8058*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x74a8448*/ void RegisterName(string name, string tbNamespace);
            /*0x74a9540*/ void Remove(System.Data.DataTable table);
            /*0x74a8d14*/ void UnregisterName(string name);
        }

        class DataTableNewRowEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;

            /*0x74a973c*/ DataTableNewRowEventArgs(System.Data.DataRow dataRow);
        }

        class DataTableNewRowEventHandler : System.MulticastDelegate
        {
            /*0x74a97b0*/ DataTableNewRowEventHandler(object object, nint method);
            /*0x74a98bc*/ void Invoke(object sender, System.Data.DataTableNewRowEventArgs e);
        }

        class DataTableTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x74a98d0*/ DataTableTypeConverter();
            /*0x74a9970*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
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

            static /*0x74aca64*/ DataView();
            /*0x74a9978*/ DataView(System.Data.DataTable table, bool locked);
            /*0x74a9eb8*/ bool get_AllowDelete();
            /*0x74a9ec0*/ bool get_AllowNew();
            /*0x74a9ec8*/ int get_Count();
            /*0x74a9f18*/ int get_CountFromIndex();
            /*0x74a9f34*/ System.Data.DataViewManager get_DataViewManager();
            /*0x74a9f3c*/ bool get_IsOpen();
            /*0x74a9f44*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x74a9f4c*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x74a9f54*/ string get_Sort();
            /*0x74a9fa8*/ System.Comparison<System.Data.DataRow> get_SortComparison();
            /*0x74a9fb0*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x74a9fb4*/ System.Data.DataTable get_Table();
            /*0x74a9fbc*/ object System.Collections.IList.get_Item(int recordIndex);
            /*0x74a9ff4*/ void System.Collections.IList.set_Item(int recordIndex, object value);
            /*0x74a9fd8*/ System.Data.DataRowView get_Item(int recordIndex);
            /*0x74aa110*/ System.Data.DataRowView AddNew();
            /*0x74aa3f4*/ void CheckOpen();
            /*0x74aa4fc*/ void Close();
            /*0x74aa550*/ void CopyTo(System.Array array, int index);
            /*0x74aa6d4*/ void CopyTo(System.Data.DataRowView[] array, int index);
            /*0x74aa894*/ void Delete(int index);
            /*0x74aa8b0*/ void Delete(System.Data.DataRow row);
            /*0x74aac30*/ void Dispose(bool disposing);
            /*0x74aaa7c*/ void FinishAddNew(bool success);
            /*0x74aac64*/ System.Collections.IEnumerator GetEnumerator();
            /*0x74aace0*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x74aace8*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x74aacf0*/ int System.Collections.IList.Add(object value);
            /*0x74aad44*/ void System.Collections.IList.Clear();
            /*0x74aad6c*/ bool System.Collections.IList.Contains(object value);
            /*0x74aadf8*/ int System.Collections.IList.IndexOf(object value);
            /*0x74aa42c*/ int IndexOf(System.Data.DataRowView rowview);
            /*0x74aae78*/ int IndexOfDataRowView(System.Data.DataRowView rowview);
            /*0x74aaed0*/ void System.Collections.IList.Insert(int index, object value);
            /*0x74aaef8*/ void System.Collections.IList.Remove(object value);
            /*0x74ab018*/ void System.Collections.IList.RemoveAt(int index);
            /*0x74ab034*/ System.Data.IFilter GetFilter();
            /*0x74ab03c*/ int GetRecord(int recordIndex);
            /*0x74aa01c*/ System.Data.DataRow GetRow(int index);
            /*0x74aa6a0*/ System.Data.DataRowView GetRowView(int record);
            /*0x74aa0b8*/ System.Data.DataRowView GetRowView(System.Data.DataRow dr);
            /*0x74ab0c4*/ void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0x74ab154*/ void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e);
            /*0x74ab214*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x74ab6cc*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74ab9d8*/ void Reset();
            /*0x74ab484*/ void ResetRowViewCache();
            /*0x74aba04*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x74abc4c*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
            /*0x74abc54*/ void SetIndex2(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, bool fireEvent);
            /*0x74aa534*/ void UpdateIndex();
            /*0x74ac1e0*/ void UpdateIndex(bool force);
            /*0x74abeb8*/ void UpdateIndex(bool force, bool fireEvent);
            /*0x74ac3e0*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74ac604*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74ac828*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74aca4c*/ void ColumnCollectionChangedInternal(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74aca5c*/ int get_ObjectID();

            class DataRowReferenceComparer : System.Collections.Generic.IEqualityComparer<System.Data.DataRow>
            {
                static /*0x0*/ System.Data.DataView.DataRowReferenceComparer s_default;

                static /*0x74acb14*/ DataRowReferenceComparer();
                /*0x74acae8*/ DataRowReferenceComparer();
                /*0x74acaf0*/ bool Equals(System.Data.DataRow x, System.Data.DataRow y);
                /*0x74acafc*/ int GetHashCode(System.Data.DataRow obj);
            }
        }

        class DataViewListener
        {
            /*0x10*/ System.WeakReference _dvWeak;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ System.Data.Index _index;
            /*0x28*/ int _objectID;

            /*0x74a9c4c*/ DataViewListener(System.Data.DataView dv);
            /*0x74acb7c*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74acc48*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74accf8*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x74acdc4*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x74ace90*/ void IndexListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74a9cd0*/ void RegisterMetaDataEvents(System.Data.DataTable table);
            /*0x74aa548*/ void UnregisterMetaDataEvents();
            /*0x74ad160*/ void UnregisterMetaDataEvents(bool updateListeners);
            /*0x74ac2f8*/ void RegisterListChangedEvent(System.Data.Index index);
            /*0x74ac1ec*/ void UnregisterListChangedEvent();
            /*0x74acc2c*/ void CleanUp(bool updateListeners);
            /*0x74acf40*/ void RegisterListener(System.Data.DataTable table);
        }

        class DataViewManager : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ System.NotSupportedException s_notSupported;
            /*0x20*/ System.Data.DataViewSettingCollection _dataViewSettingsCollection;
            /*0x28*/ int _nViews;

            static /*0x74ad410*/ DataViewManager();
            /*0x74ad408*/ System.Data.DataViewSettingCollection get_DataViewSettings();
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

            /*0x74ad48c*/ DataViewSetting();
            /*0x74ad4e8*/ bool get_ApplyDefaultSort();
            /*0x74ad4f0*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x74ad508*/ void SetDataTable(System.Data.DataTable table);
            /*0x74ad520*/ string get_RowFilter();
            /*0x74ad528*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x74ad530*/ string get_Sort();
        }

        class DataViewSettingCollection
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Collections.Hashtable _list;

            /*0x74ad538*/ System.Data.DataViewSetting get_Item(System.Data.DataTable table);
            /*0x74ad630*/ void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value);
            /*0x74ad6e0*/ void Remove(System.Data.DataTable table);
        }

        class DefaultValueTypeConverter : System.ComponentModel.StringConverter
        {
            /*0x74ad704*/ DefaultValueTypeConverter();
            /*0x74ad70c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x74ad89c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            static /*0x74adf40*/ void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74ada08*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName);
            /*0x74ada14*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName, bool local, string relationName);
            /*0x74adb94*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74ae144*/ object Eval();
            /*0x74ae158*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74ae46c*/ object Eval(int[] records);
            /*0x74ae530*/ bool IsConstant();
            /*0x74ae538*/ bool IsTableConstant();
            /*0x74ae540*/ bool HasLocalAggregate();
            /*0x74ae548*/ bool HasRemoteAggregate();
            /*0x74ae558*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74ae5f0*/ System.Data.ExpressionNode Optimize();
        }

        class BinaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _left;
            /*0x28*/ System.Data.ExpressionNode _right;

            static /*0x74b45b0*/ object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            static /*0x74b6180*/ System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code);
            /*0x74ae5f4*/ BinaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x74ae65c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74ae6cc*/ object Eval();
            /*0x74ae6e0*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74b3d80*/ object Eval(int[] recordNos);
            /*0x74b3d9c*/ bool IsConstant();
            /*0x74b3de4*/ bool IsTableConstant();
            /*0x74b3e2c*/ bool HasLocalAggregate();
            /*0x74b3e74*/ bool HasRemoteAggregate();
            /*0x74b3ebc*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74b3f20*/ System.Data.ExpressionNode Optimize();
            /*0x74b44b4*/ void SetTypeMismatchError(int op, System.Type left, System.Type right);
            /*0x74b45e0*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op);
            /*0x74b45e8*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op, System.Globalization.CompareInfo comparer);
            /*0x74ae6fc*/ object EvalBinaryOp(int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            /*0x74b615c*/ System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType);
            /*0x74b61a4*/ bool IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x74b6288*/ bool IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x74b5c10*/ System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x74b5814*/ System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x74b64c4*/ int SqlResultType(int typeCode);

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

            /*0x74b6524*/ LikeNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x74b6528*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74b6a20*/ string AnalyzePattern(string pat);
        }

        class ConstNode : System.Data.ExpressionNode
        {
            /*0x18*/ object _val;

            /*0x74b6d50*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant);
            /*0x74b41b4*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes);
            /*0x74b77bc*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74b77c4*/ object Eval();
            /*0x74b77cc*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74b77d8*/ object Eval(int[] recordNos);
            /*0x74b77e4*/ bool IsConstant();
            /*0x74b77ec*/ bool IsTableConstant();
            /*0x74b77f4*/ bool HasLocalAggregate();
            /*0x74b77fc*/ bool HasRemoteAggregate();
            /*0x74b7804*/ System.Data.ExpressionNode Optimize();
            /*0x74b733c*/ object SmallestDecimal(object constant);
            /*0x74b6d58*/ object SmallestNumeric(object constant);
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

            static /*0x74b8e94*/ bool IsUnknown(object value);
            static /*0x74b55d0*/ bool ToBoolean(object value);
            /*0x74abc44*/ DataExpression(System.Data.DataTable table, string expression);
            /*0x74b7808*/ DataExpression(System.Data.DataTable table, string expression, System.Type type);
            /*0x74b8a18*/ string get_Expression();
            /*0x74b8a68*/ bool get_HasValue();
            /*0x74b88e0*/ void Bind(System.Data.DataTable table);
            /*0x74ae5d4*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74b8a78*/ object Evaluate();
            /*0x74b8a84*/ object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74b8d04*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74b8e74*/ System.Data.DataColumn[] GetDependency();
            /*0x74b8e7c*/ bool IsTableAggregate();
            /*0x74b8eec*/ bool HasLocalAggregate();
            /*0x74b8f04*/ bool HasRemoteAggregate();
        }

        class ExpressionNode
        {
            /*0x10*/ System.Data.DataTable _table;

            static /*0x74b63e8*/ bool IsInteger(System.Data.Common.StorageType type);
            static /*0x74b6004*/ bool IsIntegerSql(System.Data.Common.StorageType type);
            static /*0x74b6238*/ bool IsSigned(System.Data.Common.StorageType type);
            static /*0x74b6314*/ bool IsSignedSql(System.Data.Common.StorageType type);
            static /*0x74b6268*/ bool IsUnsigned(System.Data.Common.StorageType type);
            static /*0x74b6340*/ bool IsUnsignedSql(System.Data.Common.StorageType type);
            static /*0x74b63c8*/ bool IsNumeric(System.Data.Common.StorageType type);
            static /*0x74b64f8*/ bool IsNumericSql(System.Data.Common.StorageType type);
            static /*0x74b8f3c*/ bool IsFloat(System.Data.Common.StorageType type);
            static /*0x74b8f4c*/ bool IsFloatSql(System.Data.Common.StorageType type);
            /*0x74adb14*/ ExpressionNode(System.Data.DataTable table);
            /*0x74b5564*/ System.IFormatProvider get_FormatProvider();
            /*0x74b8f1c*/ bool get_IsSqlColumn();
            /*0x74b8f24*/ System.Data.DataTable get_table();
            /*0x74b8f2c*/ void BindTable(System.Data.DataTable table);
            /*0x380d93c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x380b9e8*/ object Eval();
            /*0x380bc74*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x380bb68*/ object Eval(int[] recordNos);
            /*0x380b128*/ bool IsConstant();
            /*0x380b128*/ bool IsTableConstant();
            /*0x380b128*/ bool HasLocalAggregate();
            /*0x380b128*/ bool HasRemoteAggregate();
            /*0x380b9e8*/ System.Data.ExpressionNode Optimize();
            /*0x74b8f34*/ bool DependsOn(System.Data.DataColumn column);
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

            static /*0x74bab0c*/ ExpressionParser();
            /*0x74b79f0*/ ExpressionParser(System.Data.DataTable table);
            /*0x74b7ab4*/ void LoadExpression(string data);
            /*0x74b8f74*/ void StartScan();
            /*0x74b7c28*/ System.Data.ExpressionNode Parse();
            /*0x74b9bcc*/ System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate);
            /*0x74b9b90*/ System.Data.ExpressionNode NodePop();
            /*0x74b9b0c*/ System.Data.ExpressionNode NodePeek();
            /*0x74b9a74*/ void NodePush(System.Data.ExpressionNode node);
            /*0x74b9474*/ void BuildExpression(int pri);
            /*0x74b992c*/ void CheckToken(System.Data.Tokens token);
            /*0x74b9048*/ System.Data.Tokens Scan();
            /*0x74ba614*/ void ScanNumeric();
            /*0x74ba974*/ void ScanName();
            /*0x74ba504*/ void ScanName(char chEnd, char esc, string charsToEscape);
            /*0x74ba394*/ void ScanDate();
            /*0x74ba740*/ void ScanBinaryConstant();
            /*0x74ba758*/ void ScanReserved();
            /*0x74ba434*/ void ScanString(char escape);
            /*0x74b971c*/ void ScanToken(System.Data.Tokens token);
            /*0x74ba33c*/ void ScanWhite();
            /*0x74baaf8*/ bool IsWhiteSpace(char ch);
            /*0x74ba938*/ bool IsAlphaNumeric(char ch);
            /*0x74ba744*/ bool IsDigit(char ch);
            /*0x74baa7c*/ bool IsAlpha(char ch);

            struct ReservedWords
            {
                /*0x10*/ string _word;
                /*0x18*/ System.Data.Tokens _token;
                /*0x1c*/ int _op;

                /*0x74baf80*/ ReservedWords(string word, System.Data.Tokens token, int op);
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

            /*0x74b900c*/ OperatorInfo(System.Data.Nodes type, int op, int pri);
        }

        class InvalidExpressionException : System.Data.DataException
        {
            /*0x74bafac*/ InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74bafb4*/ InvalidExpressionException();
            /*0x74bafbc*/ InvalidExpressionException(string s);
        }

        class EvaluateException : System.Data.InvalidExpressionException
        {
            /*0x74bafc4*/ EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74bafcc*/ EvaluateException();
            /*0x74bafd4*/ EvaluateException(string s);
        }

        class SyntaxErrorException : System.Data.InvalidExpressionException
        {
            /*0x74bafdc*/ SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74bafe4*/ SyntaxErrorException();
            /*0x74bafec*/ SyntaxErrorException(string s);
        }

        class ExprException
        {
            static /*0x74baff4*/ System.OverflowException _Overflow(string error);
            static /*0x74bb05c*/ System.Data.InvalidExpressionException _Expr(string error);
            static /*0x74bb0c4*/ System.Data.SyntaxErrorException _Syntax(string error);
            static /*0x74bb12c*/ System.Data.EvaluateException _Eval(string error);
            static /*0x74bb194*/ System.Data.EvaluateException _Eval(string error, System.Exception innerException);
            static /*0x74b8de0*/ System.Exception InvokeArgument();
            static /*0x74bb1fc*/ System.Exception NYI(string moreinfo);
            static /*0x74b93e8*/ System.Exception MissingOperand(System.Data.OperatorInfo before);
            static /*0x74b96cc*/ System.Exception MissingOperator(string token);
            static /*0x74bb24c*/ System.Exception TypeMismatch(string expr);
            static /*0x74bb29c*/ System.Exception FunctionArgumentOutOfRange(string arg, string func);
            static /*0x74ba1ec*/ System.Exception ExpressionTooComplex();
            static /*0x74adef0*/ System.Exception UnboundName(string name);
            static /*0x74baaa8*/ System.Exception InvalidString(string str);
            static /*0x74adb44*/ System.Exception UndefinedFunction(string name);
            static /*0x74b9b50*/ System.Exception SyntaxError();
            static /*0x74bb304*/ System.Exception FunctionArgumentCount(string name);
            static /*0x74b968c*/ System.Exception MissingRightParen();
            static /*0x74ba108*/ System.Exception UnknownToken(string token, int position);
            static /*0x74ba22c*/ System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, int position);
            static /*0x74bb354*/ System.Exception DatatypeConvertion(System.Type type1, System.Type type2);
            static /*0x74b8c78*/ System.Exception DatavalueConvertion(object value, System.Type type, System.Exception innerException);
            static /*0x74bb3e0*/ System.Exception InvalidName(string name);
            static /*0x74baa2c*/ System.Exception InvalidDate(string date);
            static /*0x74bb430*/ System.Exception NonConstantArgument();
            static /*0x74b6d00*/ System.Exception InvalidPattern(string pat);
            static /*0x74b6030*/ System.Exception InWithoutParentheses();
            static /*0x74bb470*/ System.Exception InWithoutList();
            static /*0x74b4174*/ System.Exception InvalidIsSyntax();
            static /*0x74b60f0*/ System.Exception Overflow(System.Type type);
            static /*0x74bb4b0*/ System.Exception ArgumentType(string function, int arg, System.Type type);
            static /*0x74bb578*/ System.Exception ArgumentTypeInteger(string function, int arg);
            static /*0x74b44e4*/ System.Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2);
            static /*0x74b63f8*/ System.Exception AmbiguousBinop(int op, System.Type type1, System.Type type2);
            static /*0x74b6070*/ System.Exception UnsupportedOperator(int op);
            static /*0x74ba9dc*/ System.Exception InvalidNameBracketing(string name);
            static /*0x74b9f08*/ System.Exception MissingOperandBefore(string op);
            static /*0x74b9e74*/ System.Exception TooManyRightParentheses();
            static /*0x74ade90*/ System.Exception UnresolvedRelation(string name, string expr);
            static /*0x74bb61c*/ System.Data.EvaluateException BindFailure(string relationName);
            static /*0x74ba1ac*/ System.Exception AggregateArgument();
            static /*0x74ade40*/ System.Exception AggregateUnbound(string expr);
            static /*0x74ae42c*/ System.Exception EvalNoContext();
            static /*0x74bb66c*/ System.Exception ExpressionUnbound(string expr);
            static /*0x74ae4e0*/ System.Exception ComputeNotAggregate(string expr);
            static /*0x74b8e24*/ System.Exception FilterConvertion(string expr);
            static /*0x74b9970*/ System.Exception LookupArgument();
            static /*0x74bb6bc*/ System.Exception InvalidType(string typeName);
            static /*0x74bb70c*/ System.Exception InvalidHoursArgument();
            static /*0x74bb74c*/ System.Exception InvalidMinutesArgument();
            static /*0x74bb78c*/ System.Exception InvalidTimeZoneRange();
            static /*0x74bb7cc*/ System.Exception MismatchKindandTimeSpan();
            static /*0x74b7bb4*/ System.Exception UnsupportedDataType(System.Type type);
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

            /*0x74b99b0*/ LookupNode(System.Data.DataTable table, string columnName, string relationName);
            /*0x74bb80c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74bbaa4*/ object Eval();
            /*0x74bbac8*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74bbbcc*/ object Eval(int[] recordNos);
            /*0x74bbbfc*/ bool IsConstant();
            /*0x74bbc04*/ bool IsTableConstant();
            /*0x74bbc0c*/ bool HasLocalAggregate();
            /*0x74bbc14*/ bool HasRemoteAggregate();
            /*0x74bbc1c*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74bbc2c*/ System.Data.ExpressionNode Optimize();
        }

        class NameNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _name;
            /*0x20*/ bool _found;
            /*0x28*/ System.Data.DataColumn _column;

            static /*0x74b9744*/ string ParseName(char[] text, int start, int pos);
            /*0x74b9a10*/ NameNode(System.Data.DataTable table, char[] text, int start, int pos);
            /*0x74ba0c4*/ NameNode(System.Data.DataTable table, string name);
            /*0x74bbc30*/ bool get_IsSqlColumn();
            /*0x74bbc4c*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74bbeb8*/ object Eval();
            /*0x74bbedc*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74bbf78*/ object Eval(int[] records);
            /*0x74bbfa8*/ bool IsConstant();
            /*0x74bbfb0*/ bool IsTableConstant();
            /*0x74bc004*/ bool HasLocalAggregate();
            /*0x74bc058*/ bool HasRemoteAggregate();
            /*0x74bc0ac*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74bc128*/ System.Data.ExpressionNode Optimize();
        }

        class Operators
        {
            static /*0x0*/ int[] s_priority;
            static /*0x8*/ string[] s_looks;

            static /*0x74bc12c*/ Operators();
            static /*0x74b63a4*/ bool IsArithmetical(int op);
            static /*0x74b6378*/ bool IsLogical(int op);
            static /*0x74b6368*/ bool IsRelational(int op);
            static /*0x74ba018*/ int Priority(int op);
            static /*0x74b9f58*/ string ToString(int op);
        }

        class UnaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _right;

            /*0x74b9eb4*/ UnaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode right);
            /*0x74bc9c0*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74bca08*/ object Eval();
            /*0x74bca1c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74bd248*/ object Eval(int[] recordNos);
            /*0x74bca5c*/ object EvalUnaryOp(int op, object vl);
            /*0x74bd268*/ bool IsConstant();
            /*0x74bd288*/ bool IsTableConstant();
            /*0x74bd2a8*/ bool HasLocalAggregate();
            /*0x74bd2c8*/ bool HasRemoteAggregate();
            /*0x74bd2e8*/ bool DependsOn(System.Data.DataColumn column);
            /*0x74bd30c*/ System.Data.ExpressionNode Optimize();
        }

        class ZeroOpNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;

            /*0x74bd3d0*/ ZeroOpNode(int op);
            /*0x74bd3fc*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x74bd400*/ object Eval();
            /*0x74bd4b0*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74bd4bc*/ object Eval(int[] recordNos);
            /*0x74bd4c8*/ bool IsConstant();
            /*0x74bd4d0*/ bool IsTableConstant();
            /*0x74bd4d8*/ bool HasLocalAggregate();
            /*0x74bd4e0*/ bool HasRemoteAggregate();
            /*0x74bd4e8*/ System.Data.ExpressionNode Optimize();
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

            /*0x74bd4ec*/ ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74bd52c*/ ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74bd6f8*/ ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule);
            /*0x74bd7a0*/ System.Data.DataKey get_ChildKey();
            /*0x74bd7bc*/ System.Data.DataColumn[] get_Columns();
            /*0x74bd7dc*/ System.Data.DataTable get_Table();
            /*0x74bd7fc*/ string[] get_ParentColumnNames();
            /*0x74bd808*/ string[] get_ChildColumnNames();
            /*0x74bd814*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x74bd93c*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x74bd944*/ bool IsKeyNull(object[] values);
            /*0x74bda08*/ bool IsConstraintViolated();
            /*0x74bded8*/ bool CanEnableConstraint();
            /*0x74be044*/ void CascadeCommit(System.Data.DataRow row);
            /*0x74be1a4*/ void CascadeDelete(System.Data.DataRow row);
            /*0x74be6dc*/ void CascadeRollback(System.Data.DataRow row);
            /*0x74be8d0*/ void CascadeUpdate(System.Data.DataRow row);
            /*0x74bed68*/ void CheckCanClearParentTable(System.Data.DataTable table);
            /*0x74bee44*/ void CheckCanRemoveParentRow(System.Data.DataRow row);
            /*0x74bef0c*/ void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x74bf00c*/ void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action);
            /*0x74bf2e0*/ void NonVirtualCheckState();
            /*0x74bf534*/ void CheckState();
            /*0x74bf538*/ System.Data.AcceptRejectRule get_AcceptRejectRule();
            /*0x74bf554*/ void set_AcceptRejectRule(System.Data.AcceptRejectRule value);
            /*0x74bf5a8*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x74bf5f0*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x74bf600*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x74bfd64*/ System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination);
            /*0x74bd578*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x74c0378*/ System.Data.Rule get_DeleteRule();
            /*0x74c0394*/ void set_DeleteRule(System.Data.Rule value);
            /*0x74c03e8*/ bool Equals(object key);
            /*0x74c04d8*/ int GetHashCode();
            /*0x74c04e0*/ System.Data.DataColumn[] get_RelatedColumns();
            /*0x74bfd48*/ System.Data.DataColumn[] get_RelatedColumnsReference();
            /*0x74beef0*/ System.Data.DataKey get_ParentKey();
            /*0x74c0500*/ System.Data.DataRelation FindParentRelation();
            /*0x74c05c8*/ System.Data.DataTable get_RelatedTable();
            /*0x74c05e8*/ System.Data.Rule get_UpdateRule();
            /*0x74c0604*/ void set_UpdateRule(System.Data.Rule value);
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

            /*0x74c0658*/ MergeFailedEventArgs(System.Data.DataTable table, string conflict);
            /*0x74c06e0*/ string get_Conflict();
        }

        class MergeFailedEventHandler : System.MulticastDelegate
        {
            /*0x74c06e8*/ MergeFailedEventHandler(object object, nint method);
            /*0x74c07f4*/ void Invoke(object sender, System.Data.MergeFailedEventArgs e);
        }

        class Merger
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.DataTable _dataTable;
            /*0x20*/ bool _preserveChanges;
            /*0x24*/ System.Data.MissingSchemaAction _missingSchemaAction;
            /*0x28*/ bool _isStandAlonetable;
            /*0x29*/ bool _IgnoreNSforTableLookup;

            /*0x74c0808*/ Merger(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74c085c*/ Merger(System.Data.DataTable dataTable, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x74c08b8*/ void MergeDataSet(System.Data.DataSet source);
            /*0x74c24bc*/ void MergeTable(System.Data.DataTable src);
            /*0x74c26e8*/ void MergeTable(System.Data.DataTable src, System.Data.DataTable dst);
            /*0x74c2cf0*/ System.Data.DataTable MergeSchema(System.Data.DataTable table);
            /*0x74c19ac*/ void MergeTableData(System.Data.DataTable src);
            /*0x74c1a34*/ void MergeConstraints(System.Data.DataSet source);
            /*0x74c3408*/ void MergeConstraints(System.Data.DataTable table);
            /*0x74c1aa4*/ void MergeRelation(System.Data.DataRelation relation);
            /*0x74c2268*/ void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst);
            /*0x74c2b90*/ System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst);
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
            /*0x74c36b4*/ PrimaryKeyTypeConverter();
            /*0x74c3754*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x74c375c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74c37e8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class PropertyCollection : System.Collections.Hashtable, System.ICloneable
        {
            /*0x74c398c*/ PropertyCollection();
            /*0x74c3994*/ PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74c399c*/ object Clone();
        }

        struct Range
        {
            /*0x10*/ int _min;
            /*0x14*/ int _max;
            /*0x18*/ bool _isNotNull;

            /*0x74c3c98*/ Range(int min, int max);
            /*0x74be678*/ int get_Count();
            /*0x74be194*/ bool get_IsNull();
            /*0x74be698*/ int get_Min();
            /*0x74c3ce4*/ void CheckNull();
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
            /*0x380cffc*/ RBTree(System.Data.TreeAccessMethod accessMethod);
            /*0x3907c14*/ int CompareNode(K record1, K record2);
            /*0x3907c14*/ int CompareSateliteTreeNode(K record1, K record2);
            /*0x380cb08*/ void InitTree();
            /*0x380d83c*/ void FreePage(System.Data.RBTree.TreePage<K> page);
            /*0x380ba90*/ System.Data.RBTree.TreePage<K> AllocPage(int size);
            /*0x380d83c*/ void MarkPageFull(System.Data.RBTree.TreePage<K> page);
            /*0x380d83c*/ void MarkPageFree(System.Data.RBTree.TreePage<K> page);
            /*0x380cffc*/ void FreeNode(int nodeId);
            int GetIndexOfPageWithFreeSlot(bool allocatedPage);
            /*0x380b6a0*/ int get_Count();
            /*0x380b128*/ bool get_HasDuplicates();
            /*0x3907c14*/ int GetNewNode(K key);
            /*0x380b6cc*/ int Successor(int x_id);
            /*0x380b32c*/ bool Successor(ref int nodeId, ref int mainTreeNodeId);
            /*0x380b6cc*/ int Minimum(int x_id);
            int LeftRotate(int root_id, int x_id, int mainTreeNode);
            int RightRotate(int root_id, int x_id, int mainTreeNode);
            /*0x3907c14*/ int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append);
            /*0x3907c14*/ void UpdateNodeKey(K currentKey, K newKey);
            /*0x3907c14*/ K DeleteByIndex(int i);
            /*0x380b6cc*/ int RBDelete(int z_id);
            int RBDeleteX(int root_id, int z_id, int mainTreeNodeID);
            int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID);
            /*0x3907c14*/ int SearchSubTree(int root_id, K key);
            /*0x3907c14*/ K get_Item(int index);
            /*0x3907c14*/ System.Data.RBTree.NodePath<K> GetNodeByKey(K key);
            /*0x3907c14*/ int GetIndexByKey(K key);
            /*0x380b6cc*/ int GetIndexByNode(int node);
            /*0x3907c14*/ int GetIndexByNodePath(System.Data.RBTree.NodePath<K> path);
            /*0x380b6cc*/ int ComputeIndexByNode(int nodeId);
            /*0x380b6cc*/ int ComputeIndexWithSatelliteByNode(int nodeId);
            /*0x3907c14*/ System.Data.RBTree.NodePath<K> GetNodeByIndex(int userIndex);
            int ComputeNodeByIndex(int index, ref int satelliteRootId);
            /*0x380b710*/ int ComputeNodeByIndex(int x_id, int index);
            /*0x3907c14*/ int Insert(K item);
            /*0x3907c14*/ int Add(K item);
            /*0x380b9e8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3907c14*/ int IndexOf(int nodeId, K item);
            /*0x3907c14*/ int Insert(int position, K item);
            /*0x3907c14*/ int InsertAt(int position, K item, bool append);
            /*0x380cffc*/ void RemoveAt(int position);
            /*0x380cb08*/ void Clear();
            /*0x380d8b8*/ void CopyTo(System.Array array, int index);
            /*0x380d8b8*/ void CopyTo(K[] array, int index);
            /*0x380d0e4*/ void SetRight(int nodeId, int rightNodeId);
            /*0x380d0e4*/ void SetLeft(int nodeId, int leftNodeId);
            /*0x380d0e4*/ void SetParent(int nodeId, int parentNodeId);
            /*0x3907c14*/ void SetColor(int nodeId, System.Data.RBTree.NodeColor<K> color);
            /*0x3907c14*/ void SetKey(int nodeId, K key);
            /*0x380d0e4*/ void SetNext(int nodeId, int nextNodeId);
            /*0x380d0e4*/ void SetSubTreeSize(int nodeId, int size);
            /*0x380cffc*/ void IncreaseSize(int nodeId);
            /*0x380cffc*/ void RecomputeSize(int nodeId);
            /*0x380cffc*/ void DecreaseSize(int nodeId);
            /*0x380b6cc*/ int Right(int nodeId);
            /*0x380b6cc*/ int Left(int nodeId);
            /*0x380b6cc*/ int Parent(int nodeId);
            /*0x3907c14*/ System.Data.RBTree.NodeColor<K> color(int nodeId);
            /*0x380b6cc*/ int Next(int nodeId);
            /*0x380b6cc*/ int SubTreeSize(int nodeId);
            /*0x3907c14*/ K Key(int nodeId);

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

                /*0x380d0e4*/ NodePath(int nodeID, int mainTreeNodeID);
            }

            class TreePage<K>
            {
                /*0x0*/ System.Data.RBTree.Node<K> _slots;
                /*0x0*/ int[] _slotMap;
                /*0x0*/ int _inUseCount;
                /*0x0*/ int _pageId;
                /*0x0*/ int _nextFreeSlotLine;

                /*0x380cffc*/ TreePage(int size);
                /*0x380b7a8*/ int AllocSlot(System.Data.RBTree<K> tree);
                /*0x380b6a0*/ int get_InUseCount();
                /*0x380cffc*/ void set_InUseCount(int value);
                /*0x380b6a0*/ int get_PageId();
                /*0x380cffc*/ void set_PageId(int value);
            }

            struct RBTreeEnumerator<K> : System.Collections.Generic.IEnumerator<K>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ System.Data.RBTree<K> _tree;
                /*0x0*/ int _version;
                /*0x0*/ int _index;
                /*0x0*/ int _mainTreeNodeId;
                /*0x0*/ K _current;

                /*0x380d83c*/ RBTreeEnumerator(System.Data.RBTree<K> tree);
                /*0x380d8b8*/ RBTreeEnumerator(System.Data.RBTree<K> tree, int position);
                /*0x380cb08*/ void Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x3907c14*/ K get_Current();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
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

            static /*0x74c3f04*/ int NewCapacity(int capacity);
            /*0x74c3d1c*/ RecordManager(System.Data.DataTable table);
            /*0x74c3df4*/ void GrowRecordCapacity();
            /*0x74c3fe0*/ int get_LastFreeRecord();
            /*0x74c3fe8*/ int get_MinimumCapacity();
            /*0x74c3ff0*/ void set_MinimumCapacity(int value);
            /*0x74c4034*/ int get_RecordCapacity();
            /*0x74c3f50*/ void set_RecordCapacity(int value);
            /*0x74c3f18*/ int NormalizedMinimumCapacity(int capacity);
            /*0x74c403c*/ int NewRecordBase();
            /*0x74c4108*/ void FreeRecord(ref int record);
            /*0x74c42c0*/ void Clear(bool clearAll);
            /*0x74c44c4*/ System.Data.DataRow get_Item(int record);
            /*0x74c4258*/ void set_Item(int record, System.Data.DataRow value);
            /*0x74c44f4*/ int ImportRecord(System.Data.DataTable src, int record);
            /*0x74c44fc*/ int CopyRecord(System.Data.DataTable src, int record, int copy);
            /*0x74c4814*/ void SetRowCache(System.Data.DataRow[] newRows);
        }

        class RelatedView : System.Data.DataView, System.Data.IFilter
        {
            /*0xb0*/ System.Nullable<System.Data.DataKey> _parentKey;
            /*0xc0*/ System.Data.DataKey _childKey;
            /*0xc8*/ System.Data.DataRowView _parentRowView;
            /*0xd0*/ object[] _filterValues;

            /*0x74c4854*/ RelatedView(System.Data.DataColumn[] columns, object[] values);
            /*0x74c4990*/ RelatedView(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns);
            /*0x74c4acc*/ object[] GetParentValues();
            /*0x74c4b68*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x74c4cf0*/ System.Data.IFilter GetFilter();
            /*0x74c4cf4*/ System.Data.DataRowView AddNew();
            /*0x74c4d54*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
        }

        class RelationshipConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x74c4d78*/ RelationshipConverter();
            /*0x74c4d80*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x74c4e30*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
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

            static /*0x74c5a28*/ bool op_Equality(System.Data.IndexField if1, System.Data.IndexField if2);
            /*0x74c5a00*/ IndexField(System.Data.DataColumn column, bool isDescending);
            /*0x74c5a44*/ bool Equals(object obj);
            /*0x74c5ad4*/ int GetHashCode();
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

            static /*0x74c5eb4*/ System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns);
            static /*0x74c82e8*/ int GetReplaceAction(System.Data.DataViewRowState oldState);
            static /*0x3907c14*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
            /*0x74c5b34*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74c5e5c*/ Index(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74c5b44*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74c63b0*/ bool Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x74c6458*/ bool get_HasRemoteAggregate();
            /*0x74c6460*/ int get_ObjectID();
            /*0x74c6468*/ System.Data.DataViewRowState get_RecordStates();
            /*0x74c6470*/ System.Data.IFilter get_RowFilter();
            /*0x74c64e8*/ int GetRecord(int recordIndex);
            /*0x74c6540*/ bool get_HasDuplicates();
            /*0x74c6590*/ int get_RecordCount();
            /*0x74c6598*/ bool AcceptRecord(int record);
            /*0x74c65c4*/ bool AcceptRecord(int record, System.Data.IFilter filter);
            /*0x74c6758*/ void ListChangedAdd(System.Data.DataViewListener listener);
            /*0x74c67b0*/ void ListChangedRemove(System.Data.DataViewListener listener);
            /*0x74c6808*/ int get_RefCount();
            /*0x74c6810*/ void AddRef();
            /*0x74c6a0c*/ int RemoveRef();
            /*0x74c6bc8*/ void ApplyChangeAction(int record, int action, int changeRecord);
            /*0x74c6ff8*/ bool CheckUnique();
            /*0x74c7010*/ int CompareRecords(int record1, int record2);
            /*0x74c7160*/ int CompareDataRows(int record1, int record2);
            /*0x74c71cc*/ int CompareDuplicateRecords(int record1, int record2);
            /*0x74c7318*/ int CompareRecordToKey(int record1, object[] vals);
            /*0x74c73e8*/ void DeleteRecordFromIndex(int recordIndex);
            /*0x74c6f98*/ void DeleteRecord(int recordIndex);
            /*0x74c73f0*/ void DeleteRecord(int recordIndex, bool fireEvent);
            /*0x74c76c0*/ System.Data.RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex);
            /*0x74c6fa0*/ int GetIndex(int record);
            /*0x74c6e60*/ int GetIndex(int record, int changeRecord);
            /*0x74bdc00*/ object[] GetUniqueKeyValues();
            /*0x74c794c*/ int FindNodeByKey(object originalKey);
            /*0x74c7b60*/ int FindNodeByKeys(object[] originalKey);
            /*0x74c7da4*/ int FindNodeByKeyRecord(int record);
            /*0x74c7e98*/ System.Data.Range GetRangeFromNode(int nodeId);
            /*0x74c7fc0*/ System.Data.Range FindRecords(object key);
            /*0x74bdd3c*/ System.Data.Range FindRecords(object[] key);
            /*0x74c7fe4*/ void FireResetEvent();
            /*0x74c82cc*/ int GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x74be6b0*/ System.Data.DataRow GetRow(int i);
            /*0x74c8310*/ System.Data.DataRow[] GetRows(object[] values);
            /*0x74bdd60*/ System.Data.DataRow[] GetRows(System.Data.Range range);
            /*0x74c5fac*/ void InitRecords(System.Data.IFilter filter);
            /*0x74c83a4*/ int InsertRecordToIndex(int record);
            /*0x74c6c6c*/ int InsertRecord(int record, bool fireEvent);
            /*0x74c83f4*/ bool IsKeyInIndex(object key);
            /*0x74bdd24*/ bool IsKeyInIndex(object[] key);
            /*0x74c840c*/ bool IsKeyRecordInIndex(int record);
            /*0x74c80cc*/ bool get_DoListChanged();
            /*0x74c8424*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int newIndex, int oldIndex);
            /*0x74c7630*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int index);
            /*0x74c814c*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x74c7514*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, int record, bool trackAddRemove);
            /*0x74c84c4*/ void Reset();
            /*0x74c858c*/ void RecordChanged(int record);
            /*0x74c8670*/ void RecordChanged(int oldIndex, int newIndex);
            /*0x74c87a8*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x74c88a8*/ void RecordStateChanged(int oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, int newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState);
            /*0x74c8c0c*/ System.Data.DataTable get_Table();
            /*0x74c7728*/ void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId);

            class IndexTree : System.Data.RBTree<int>
            {
                /*0x40*/ System.Data.Index _index;

                /*0x74c833c*/ IndexTree(System.Data.Index index);
                /*0x74c8c14*/ int CompareNode(int record1, int record2);
                /*0x74c8c2c*/ int CompareSateliteTreeNode(int record1, int record2);
            }

            class <>c
            {
                static /*0x0*/ System.Data.Index.<> <>9;
                static /*0x8*/ System.Data.Listeners.Func<System.Data.DataViewListener, System.Data.DataViewListener, bool> <>9__22_0;
                static /*0x10*/ System.Data.Listeners.Action<System.Data.DataViewListener, System.Data.DataViewListener, System.ComponentModel.ListChangedEventArgs, bool, bool> <>9__85_0;

                static /*0x74c8c44*/ <>c();
                /*0x74c8cac*/ <>c();
                /*0x74c8cb4*/ bool <.ctor>b__22_0(System.Data.DataViewListener listener);
                /*0x74c8cc0*/ void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, bool arg2, bool arg3);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ System.ComponentModel.ListChangedType changedType;

                /*0x74c84bc*/ <>c__DisplayClass86_0();
                /*0x74c8cdc*/ void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, bool track);
            }
        }

        class Listeners<TElem>
        {
            /*0x0*/ System.Collections.Generic.List<TElem> _listeners;
            /*0x0*/ System.Data.Listeners.Func<TElem, TElem, bool> _filter;
            /*0x0*/ int _objectID;
            /*0x0*/ int _listenerReaderCount;

            /*0x380d170*/ Listeners(int ObjectID, System.Data.Listeners.Func<TElem, TElem, bool> notifyFilter);
            /*0x380b128*/ bool get_HasListeners();
            /*0x3907c14*/ void Add(TElem listener);
            /*0x3907c14*/ int IndexOfReference(TElem listener);
            /*0x3907c14*/ void Remove(TElem listener);
            /*0x3907c14*/ void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem, TElem, T1, T2, T3> action);
            /*0x380cffc*/ void RemoveNullListeners(int nullIndex);

            class Action`4<TElem, T1, T2, T3, T4> : System.MulticastDelegate
            {
                Action`4(object object, nint method);
                /*0x3907c14*/ void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            }

            class Func`2<TElem, T1, TResult> : System.MulticastDelegate
            {
                Func`2(object object, nint method);
                /*0x3907c14*/ TResult Invoke(T1 arg1);
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

            static /*0x74ca1d8*/ System.Data.SimpleType CreateEnumeratedType(string values);
            static /*0x74ca264*/ System.Data.SimpleType CreateByteArrayType(string encoding);
            static /*0x74ca2cc*/ System.Data.SimpleType CreateLimitedStringType(int length);
            static /*0x74ca34c*/ System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type);
            /*0x74c8d0c*/ SimpleType(string baseType);
            /*0x74c8e14*/ SimpleType(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x74c9950*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x74c8fe0*/ void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x74c9aa0*/ bool IsPlainString();
            /*0x74c9c4c*/ string get_BaseType();
            /*0x74c9c54*/ System.Xml.XmlQualifiedName get_XmlBaseType();
            /*0x74c9c5c*/ string get_Name();
            /*0x74c9c64*/ string get_Namespace();
            /*0x74c9c6c*/ int get_Length();
            /*0x74c9c74*/ int get_MaxLength();
            /*0x74c9c7c*/ void set_MaxLength(int value);
            /*0x74c9c84*/ System.Data.SimpleType get_BaseSimpleType();
            /*0x74c9c8c*/ string get_SimpleTypeQualifiedName();
            /*0x74c9cfc*/ string QualifiedName(string name);
            /*0x74c9d78*/ System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, bool inRemoting);
            /*0x74ca420*/ string HasConflictingDefinition(System.Data.SimpleType otherSimpleType);
            /*0x74ca514*/ bool CanHaveMaxLength();
            /*0x74ca578*/ void ConvertToAnnonymousSimpleType();
        }

        class UniqueConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.DataKey _key;
            /*0x40*/ System.Data.Index _constraintIndex;
            /*0x48*/ bool _bPrimaryKey;
            /*0x50*/ string _constraintName;
            /*0x58*/ string[] _columnNames;

            /*0x74ca5f8*/ UniqueConstraint(System.Data.DataColumn column);
            /*0x74ca7ac*/ UniqueConstraint(string name, System.Data.DataColumn[] columns);
            /*0x74ca7e0*/ UniqueConstraint(System.Data.DataColumn[] columns);
            /*0x74ca810*/ UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey);
            /*0x74ca868*/ UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey);
            /*0x74ca8ac*/ string[] get_ColumnNames();
            /*0x74ca8b8*/ System.Data.Index get_ConstraintIndex();
            /*0x74ca8c0*/ void ConstraintIndexClear();
            /*0x74ca8f0*/ void ConstraintIndexInitialize();
            /*0x74ca948*/ void CheckState();
            /*0x74ca954*/ void NonVirtualCheckState();
            /*0x74ca960*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x74ca964*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x74caad0*/ bool CanEnableConstraint();
            /*0x74cab1c*/ bool IsConstraintViolated();
            /*0x74cad7c*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x74cae7c*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x74cae88*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x74cae98*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x74cb3f0*/ System.Data.UniqueConstraint Clone(System.Data.DataTable table);
            /*0x74cb8ac*/ System.Data.DataColumn[] get_Columns();
            /*0x74cae74*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x74cb8b8*/ bool get_IsPrimaryKey();
            /*0x74ca6b4*/ void Create(string constraintName, System.Data.DataColumn[] columns);
            /*0x74cb8fc*/ bool Equals(object key2);
            /*0x74cb9b4*/ int GetHashCode();
            /*0x74cb9bc*/ void set_InCollection(bool value);
            /*0x74cba0c*/ System.Data.DataKey get_Key();
            /*0x74cba14*/ System.Data.DataTable get_Table();
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

            static /*0x74ce4e4*/ XDRSchema();
            static /*0x74ccebc*/ System.Data.XDRSchema.NameType FindNameType(string name);
            /*0x74cba48*/ XDRSchema(System.Data.DataSet ds, bool fInline);
            /*0x74cbac8*/ void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds);
            /*0x74cbf5c*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node);
            /*0x74cc288*/ bool IsTextOnlyContent(System.Xml.XmlElement node);
            /*0x74cc458*/ bool IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x74cbd9c*/ System.Data.DataTable HandleTable(System.Xml.XmlElement node);
            /*0x74ccf90*/ System.Type ParseDataType(string dt, string dtValues);
            /*0x74cd0cc*/ string GetInstanceName(System.Xml.XmlElement node);
            /*0x74cd244*/ void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table);
            /*0x74cc5b8*/ void GetMinMax(System.Xml.XmlElement elNode, ref int minOccurs, ref int maxOccurs);
            /*0x74cdbb4*/ void GetMinMax(System.Xml.XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs);
            /*0x74ce2fc*/ void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren);
            /*0x74cc7f4*/ System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x74cc5c8*/ System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x74cf438*/ NameType(string n, System.Type t);
                /*0x74cf47c*/ int CompareTo(object obj);
            }
        }

        class XMLDiffLoader
        {
            /*0x10*/ System.Collections.ArrayList _tables;
            /*0x18*/ System.Data.DataSet _dataSet;
            /*0x20*/ System.Data.DataTable _dataTable;

            /*0x74d1ad4*/ XMLDiffLoader();
            /*0x74cf4bc*/ void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader);
            /*0x74cfd00*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x74d0084*/ void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader);
            /*0x74cf670*/ void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x74d0294*/ void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync);
            /*0x74cf960*/ void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x74d0578*/ void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync);
            /*0x74d1900*/ System.Data.DataTable GetTable(string tableName, string ns);
            /*0x74d0a88*/ int ReadOldRowData(System.Data.DataSet ds, ref System.Data.DataTable table, ref int pos, System.Xml.XmlReader row);
            /*0x74d0a28*/ void SkipWhitespaces(System.Xml.XmlReader reader);
        }

        class XMLSchema
        {
            static /*0x74d1adc*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x74cdeec*/ void SetProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x74cbd28*/ bool FEqualIdentity(System.Xml.XmlNode node, string name, string ns);
            static /*0x74d1b34*/ bool GetBooleanAttribute(System.Xml.XmlElement element, string attrName, string attrNS, bool defVal);
            static /*0x74cda8c*/ string GenUniqueColumnName(string proposedName, System.Data.DataTable table);
            /*0x74cbac0*/ XMLSchema();
        }

        class ConstraintTable
        {
            /*0x10*/ System.Data.DataTable table;
            /*0x18*/ System.Xml.Schema.XmlSchemaIdentityConstraint constraint;

            /*0x74d1c84*/ ConstraintTable(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c);
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

            static /*0x74e0d08*/ XSDSchema();
            static /*0x74c9bd0*/ string QualifiedName(string name);
            static /*0x74d270c*/ void SetProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x74d2c34*/ void SetExtProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x74c9988*/ string GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, string ln);
            static /*0x74d31c4*/ void SetExtProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x74dd310*/ System.Data.AcceptRejectRule TranslateAcceptRejectRule(string strRule);
            static /*0x74dd394*/ System.Data.Rule TranslateRule(string strRule);
            static /*0x74e0350*/ System.Type XsdtoClr(string xsdTypeName);
            static /*0x74e042c*/ System.Data.XSDSchema.NameType FindNameType(string name);
            static /*0x74e0664*/ bool IsXsdType(string name);
            /*0x74e0d00*/ XSDSchema();
            /*0x74d1cc8*/ bool get_FromInference();
            /*0x74d1cd0*/ void set_FromInference(bool value);
            /*0x74d1cdc*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema);
            /*0x74d1d64*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList);
            /*0x74d2fc4*/ void HandleColumnExpression(object instance, System.Xml.XmlAttribute[] attrs);
            /*0x74d3408*/ void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element);
            /*0x74d35c4*/ void HandleRelation(System.Xml.XmlElement node, bool fNested);
            /*0x74d3e1c*/ bool HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
            /*0x74d409c*/ bool IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x74d4ac4*/ int DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x74d4e5c*/ System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x74d5448*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt);
            /*0x74d546c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds);
            /*0x74d8e54*/ void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, bool fNested);
            /*0x74d4648*/ System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x74d917c*/ void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isBase);
            /*0x74da7d0*/ void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, bool isBase);
            /*0x74db43c*/ void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, bool isBase);
            /*0x74db824*/ void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isNillable);
            /*0x74d532c*/ System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct);
            /*0x74dcec0*/ System.Data.DataColumn FindField(System.Data.DataTable table, string field);
            /*0x74dd03c*/ System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table);
            /*0x74d4d04*/ bool GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, bool defVal);
            /*0x74d76c4*/ string GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, string defVal);
            /*0x74dd480*/ void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref);
            /*0x74ddd58*/ void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode);
            /*0x74de188*/ System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x74d34ec*/ string GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x74decd8*/ System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, bool isRef);
            /*0x74e0500*/ System.Type ParseDataType(string dt);
            /*0x74d7748*/ System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x74dc568*/ void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x74dbe10*/ void HandleSimpleContentColumn(string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x74daacc*/ void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, bool isBase);
            /*0x74d9b44*/ void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, bool isBase);
            /*0x74d7b6c*/ void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, bool isNewDataSet);
            /*0x74e06d4*/ void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt);
            /*0x74de8c8*/ string GetPrefix(string ns);
            /*0x74e08e8*/ string GetNamespaceFromPrefix(string prefix);
            /*0x74e01cc*/ string GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x74ddc40*/ string GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x74d4858*/ bool IsTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x74d79f4*/ System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x74e1fa0*/ NameType(string n, System.Type t);
                /*0x74e1fe4*/ int CompareTo(object obj);
            }
        }

        class XmlIgnoreNamespaceReader : System.Xml.XmlNodeReader
        {
            /*0x30*/ System.Collections.Generic.List<string> _namespacesToIgnore;

            /*0x74e2024*/ XmlIgnoreNamespaceReader(System.Xml.XmlDocument xdoc, string[] namespacesToIgnore);
            /*0x74e20c4*/ bool MoveToFirstAttribute();
            /*0x74e21d4*/ bool MoveToNextAttribute();
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

            /*0x74e22e0*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, bool ignoreSchema);
            /*0x74e238c*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x74e2490*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, bool ignoreSchema);
            /*0x74e2554*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x74e2670*/ bool get_FromInference();
            /*0x74e2678*/ void set_FromInference(bool value);
            /*0x74e2684*/ void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x74e2878*/ int CountNonNSAttributes(System.Xml.XmlNode node);
            /*0x74e29f8*/ string GetValueForTextOnlyColums(System.Xml.XmlNode n);
            /*0x74e2c10*/ string GetInitialTextFromNodes(ref System.Xml.XmlNode n);
            /*0x74e2e0c*/ System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row);
            /*0x74e27e0*/ System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e);
            /*0x74e2ed0*/ bool FColumnElement(System.Xml.XmlElement e);
            /*0x74e296c*/ bool FExcludedNamespace(string ns);
            /*0x74e2fb8*/ bool FIgnoreNamespace(System.Xml.XmlNode node);
            /*0x74e326c*/ bool FIgnoreNamespace(System.Xml.XmlReader node);
            /*0x74e2bbc*/ bool IsTextLikeNode(System.Xml.XmlNodeType n);
            /*0x74e2ea0*/ bool IsTextOnly(System.Data.DataColumn c);
            /*0x74e32f4*/ void LoadData(System.Xml.XmlDocument xdoc);
            /*0x74e3740*/ void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement);
            /*0x74e43d0*/ void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x74e4710*/ void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, string xmlText);
            /*0x74e4780*/ void InitNameTable();
            /*0x74e4a88*/ void LoadData(System.Xml.XmlReader reader);
            /*0x74e4e48*/ void LoadTopMostTable(System.Data.DataTable table);
            /*0x74e5aa8*/ void LoadTable(System.Data.DataTable table, bool isNested);
            /*0x74e6890*/ void LoadColumn(System.Data.DataColumn column, object[] foundColumns);
            /*0x74e5888*/ bool ProcessXsdSchema();
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

            static /*0x74e4758*/ bool IsMappedColumn(System.Data.DataColumn c);
            /*0x74e3624*/ XmlToDatasetMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x74e4de0*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x74e35f0*/ XmlToDatasetMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x74e4e14*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x74e91b4*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable);
            /*0x74e93bc*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table);
            /*0x74e9544*/ bool AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x74e97d4*/ bool AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x74e71c8*/ void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x74e77ec*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x74e833c*/ void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x74e86a8*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x74e9a2c*/ System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt);
            /*0x74e3098*/ object GetColumnSchema(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x74e6758*/ object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, bool fIgnoreNamespace);
            /*0x74e3658*/ object GetSchemaForNode(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x74e57b0*/ System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, bool fIgnoreNamespace);
            /*0x74e9678*/ void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);

            class XmlNodeIdentety
            {
                /*0x10*/ string LocalName;
                /*0x18*/ string NamespaceURI;

                /*0x74e9378*/ XmlNodeIdentety(string localName, string namespaceURI);
                /*0x74ea06c*/ int GetHashCode();
                /*0x74ea08c*/ bool Equals(object obj);
            }

            class XmlNodeIdHashtable : System.Collections.Hashtable
            {
                /*0x50*/ System.Data.XmlToDatasetMap.XmlNodeIdentety _id;

                /*0x74e9998*/ XmlNodeIdHashtable(int capacity);
                /*0x74e9e78*/ object get_Item(System.Xml.XmlNode node);
                /*0x74e9fe4*/ object get_Item(System.Xml.XmlReader dataReader);
                /*0x74e9f64*/ object get_Item(System.Data.DataTable table);
                /*0x74e9f08*/ object get_Item(string name);
            }

            class TableSchemaInfo
            {
                /*0x10*/ System.Data.DataTable TableSchema;
                /*0x18*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;

                /*0x74e92d4*/ TableSchemaInfo(System.Data.DataTable tableSchema);
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

            static /*0x74ea1d4*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node);
            static /*0x74ea1dc*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type);
            static /*0x74eb380*/ string XmlDataTypeName(System.Type type);
            static /*0x74eca3c*/ bool _PropsNotEmpty(System.Data.PropertyCollection props);
            static /*0x74ece4c*/ void ValidateColumnMapping(System.Type columnType);
            static /*0x74f540c*/ System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, string name);
            static /*0x74f6f68*/ string TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule);
            static /*0x74f6fd8*/ string TranslateRule(System.Data.Rule rule);
            static /*0x74edce0*/ bool AutoGenerated(System.Data.DataColumn col);
            static /*0x74f7428*/ bool AutoGenerated(System.Data.DataRelation rel);
            static /*0x74ee230*/ bool AutoGenerated(System.Data.UniqueConstraint unique);
            static /*0x74f750c*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk, bool checkRelation);
            /*0x74ea128*/ XmlTreeGen(System.Data.SchemaFormat format);
            /*0x74ea90c*/ void AddXdoProperties(object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x74eaabc*/ void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x74ec144*/ void GenerateConstraintNames(System.Data.DataTable table, bool fromTable);
            /*0x74ec660*/ void GenerateConstraintNames(System.Collections.ArrayList tables);
            /*0x74ec758*/ void GenerateConstraintNames(System.Data.DataSet ds);
            /*0x74eca64*/ bool HaveExtendedProperties(System.Data.DataSet ds);
            /*0x74ecbe8*/ void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, string targetNamespace);
            /*0x74eced4*/ void SetupAutoGenerated(System.Data.DataSet ds);
            /*0x74edbec*/ void SetupAutoGenerated(System.Collections.ArrayList dt);
            /*0x74ed1b4*/ void SetupAutoGenerated(System.Data.DataTable dt);
            /*0x74ee304*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x74ee688*/ void CreateRelations(System.Data.DataTable dt);
            /*0x74ee9e0*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x74eeccc*/ void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, bool writeHierarchy);
            /*0x74f20fc*/ System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt);
            /*0x74f1458*/ System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt);
            /*0x74f4f88*/ void SetPath(System.Xml.XmlWriter xw);
            /*0x74f51c0*/ void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw);
            /*0x74f51e0*/ void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x74f51d4*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x74f52a0*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy);
            /*0x74f52ac*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x74f1b38*/ System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc);
            /*0x74f5500*/ System.Xml.XmlElement GetSchema(string NamespaceURI);
            /*0x74f5794*/ void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema);
            /*0x74f5be4*/ void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root);
            /*0x74f61d4*/ string FindTargetNamespace(System.Data.DataTable table);
            /*0x74f62e4*/ System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool fWriteOrdinal);
            /*0x74f1a80*/ void AppendChildWithoutRef(System.Xml.XmlElement node, string Namespace, System.Xml.XmlElement el, string refString);
            /*0x74f6da0*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, string strType);
            /*0x74f1a78*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema);
            /*0x74f7090*/ bool HasMixedColumns(System.Data.DataTable table);
            /*0x74ee224*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk);
            /*0x74f764c*/ bool IsAutoGenerated(object o);
            /*0x74f25c8*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool genNested);
            /*0x74ebf60*/ void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type);
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

            static /*0x74f7690*/ string QualifiedName(string prefix, string name);
            /*0x74f76f8*/ NewDiffgramGen(System.Data.DataSet ds);
            /*0x74f7aa4*/ NewDiffgramGen(System.Data.DataTable dt, bool writeHierarchy);
            /*0x74f7bc8*/ void CreateTableHierarchy(System.Data.DataTable dt);
            /*0x74f7840*/ void DoAssignments(System.Collections.ArrayList tables);
            /*0x74f7f4c*/ bool EmptyData();
            /*0x74f8040*/ void Save(System.Xml.XmlWriter xmlw);
            /*0x74f8048*/ void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table);
            /*0x74f8460*/ void GenerateTable(System.Data.DataTable table);
            /*0x74f84dc*/ void GenerateTableErrors(System.Data.DataTable table);
            /*0x74f8a10*/ void GenerateRow(System.Data.DataRow row);
            /*0x74f8fa4*/ void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version);
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

            static /*0x74fa4d4*/ bool RowHasErrors(System.Data.DataRow row);
            static /*0x74fd214*/ bool PreserveSpace(object value);
            /*0x74f9960*/ XmlDataTreeWriter(System.Data.DataSet ds);
            /*0x74f9ccc*/ XmlDataTreeWriter(System.Data.DataTable dt, bool writeHierarchy);
            /*0x74fa1e8*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x74f9e64*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x74fa59c*/ void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder);
            /*0x74fc5e8*/ void Save(System.Xml.XmlWriter xw, bool writeSchema);
            /*0x74fcecc*/ System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row);
            /*0x74faccc*/ void XmlDataRowWriter(System.Data.DataRow row, string encodedTableName);
        }

        class DataTextWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter _xmltextWriter;

            static /*0x74fac64*/ System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw);
            /*0x74fd2a8*/ DataTextWriter(System.Xml.XmlWriter w);
            /*0x74fd2d8*/ System.IO.Stream get_BaseStream();
            /*0x74fd36c*/ void WriteStartDocument();
            /*0x74fd38c*/ void WriteStartDocument(bool standalone);
            /*0x74fd3b0*/ void WriteEndDocument();
            /*0x74fd3d0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x74fd3f0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x74fd410*/ void WriteEndElement();
            /*0x74fd430*/ void WriteFullEndElement();
            /*0x74fd450*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x74fd470*/ void WriteEndAttribute();
            /*0x74fd494*/ void WriteCData(string text);
            /*0x74fd4b8*/ void WriteComment(string text);
            /*0x74fd4dc*/ void WriteProcessingInstruction(string name, string text);
            /*0x74fd500*/ void WriteEntityRef(string name);
            /*0x74fd524*/ void WriteCharEntity(char ch);
            /*0x74fd548*/ void WriteWhitespace(string ws);
            /*0x74fd56c*/ void WriteString(string text);
            /*0x74fd590*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x74fd5b4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x74fd5d8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x74fd5fc*/ void WriteRaw(string data);
            /*0x74fd620*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x74fd644*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x74fd668*/ System.Xml.WriteState get_WriteState();
            /*0x74fd68c*/ void Close();
            /*0x74fd6b0*/ void Flush();
            /*0x74fd6d4*/ void WriteQualifiedName(string localName, string ns);
            /*0x74fd6f8*/ string LookupPrefix(string ns);
            /*0x74fd71c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x74fd740*/ string get_XmlLang();
        }

        class DataTextReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader _xmlreader;

            static /*0x74fd764*/ System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr);
            /*0x74fd7bc*/ DataTextReader(System.Xml.XmlReader input);
            /*0x74fd830*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x74fd850*/ System.Xml.XmlNodeType get_NodeType();
            /*0x74fd870*/ string get_Name();
            /*0x74fd890*/ string get_LocalName();
            /*0x74fd8b0*/ string get_NamespaceURI();
            /*0x74fd8d0*/ string get_Prefix();
            /*0x74fd8f0*/ string get_Value();
            /*0x74fd910*/ int get_Depth();
            /*0x74fd930*/ string get_BaseURI();
            /*0x74fd954*/ bool get_IsEmptyElement();
            /*0x74fd978*/ bool get_IsDefault();
            /*0x74fd99c*/ char get_QuoteChar();
            /*0x74fd9c0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x74fd9e4*/ string get_XmlLang();
            /*0x74fda08*/ int get_AttributeCount();
            /*0x74fda2c*/ string GetAttribute(string name);
            /*0x74fda50*/ string GetAttribute(string localName, string namespaceURI);
            /*0x74fda74*/ string GetAttribute(int i);
            /*0x74fda98*/ bool MoveToAttribute(string name);
            /*0x74fdabc*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x74fdae0*/ void MoveToAttribute(int i);
            /*0x74fdb04*/ bool MoveToFirstAttribute();
            /*0x74fdb28*/ bool MoveToNextAttribute();
            /*0x74fdb4c*/ bool MoveToElement();
            /*0x74fdb70*/ bool ReadAttributeValue();
            /*0x74fdb94*/ bool Read();
            /*0x74fdbb8*/ bool get_EOF();
            /*0x74fdbdc*/ void Close();
            /*0x74fdc00*/ System.Xml.ReadState get_ReadState();
            /*0x74fdc24*/ void Skip();
            /*0x74fdc48*/ System.Xml.XmlNameTable get_NameTable();
            /*0x74fdc6c*/ string LookupNamespace(string prefix);
            /*0x74fdc90*/ bool get_CanResolveEntity();
            /*0x74fdcb4*/ void ResolveEntity();
            /*0x74fdcd8*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x74fdcfc*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x74fdd20*/ bool get_CanReadValueChunk();
            /*0x74fdd44*/ string ReadString();
        }

        namespace SqlTypes
        {
            class SQLResource
            {
                static /*0x74fdd68*/ string get_NullString();
                static /*0x74fdda8*/ string get_ArithOverflowMessage();
                static /*0x74fdde8*/ string get_DivideByZeroMessage();
                static /*0x74fde28*/ string get_NullValueMessage();
                static /*0x74fde68*/ string get_TruncationMessage();
                static /*0x74fdea8*/ string get_DateTimeOverflowMessage();
                static /*0x74fdee8*/ string get_ConcatDiffCollationMessage();
                static /*0x74fdf28*/ string get_CompareDiffCollationMessage();
                static /*0x74fdf68*/ string get_ConversionOverflowMessage();
                static /*0x74fdfa8*/ string get_TimeZoneSpecifiedMessage();
                static /*0x74fdfe8*/ string get_InvalidPrecScaleMessage();
                static /*0x74fe028*/ string get_FormatMessage();
                static /*0x74fe068*/ string InvalidOpStreamClosed(string method);
                static /*0x74fe0b4*/ string InvalidOpStreamNonWritable(string method);
                static /*0x74fe100*/ string InvalidOpStreamNonReadable(string method);
                static /*0x74fe14c*/ string InvalidOpStreamNonSeekable(string method);
            }

            interface INullable
            {
                /*0x380b128*/ bool get_IsNull();
            }

            struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBinary Null;
                /*0x10*/ byte[] _value;

                static /*0x74ff134*/ SqlBinary();
                static /*0x74fe314*/ System.Data.SqlTypes.SqlBinary op_Implicit(byte[] x);
                static /*0x74fe44c*/ System.Data.SqlTypes.EComparison PerformCompareByte(byte[] x, byte[] y);
                static /*0x74fe548*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x74fe65c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x74fe75c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x74fec94*/ int HashByteArray(byte[] rgbValue, int length);
                static /*0x74ff0a8*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x74fe198*/ SqlBinary(bool fNull);
                /*0x74fe1a4*/ SqlBinary(byte[] value);
                /*0x74fe230*/ bool get_IsNull();
                /*0x74fe240*/ byte[] get_Value();
                /*0x74fe334*/ string ToString();
                /*0x74fe85c*/ int CompareTo(object value);
                /*0x74fe964*/ int CompareTo(System.Data.SqlTypes.SqlBinary value);
                /*0x74feb04*/ bool Equals(object value);
                /*0x74fecfc*/ int GetHashCode();
                /*0x74fedc0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x74fedc8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x74fef7c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBoolean True;
                static /*0x1*/ System.Data.SqlTypes.SqlBoolean False;
                static /*0x2*/ System.Data.SqlTypes.SqlBoolean Null;
                static /*0x3*/ System.Data.SqlTypes.SqlBoolean Zero;
                static /*0x4*/ System.Data.SqlTypes.SqlBoolean One;
                /*0x10*/ byte m_value;

                static /*0x74ffd70*/ SqlBoolean();
                static /*0x74ff258*/ System.Data.SqlTypes.SqlBoolean op_Implicit(bool x);
                static /*0x74feaa8*/ bool op_True(System.Data.SqlTypes.SqlBoolean x);
                static /*0x74ff268*/ System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x74ff320*/ System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x74ff548*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x74ff5f8*/ System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x74ff664*/ System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x74ffce4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x74fe648*/ SqlBoolean(bool value);
                /*0x74ff1a0*/ SqlBoolean(int value);
                /*0x74ff20c*/ SqlBoolean(int value, bool fNull);
                /*0x74ff228*/ bool get_IsNull();
                /*0x74fec3c*/ bool get_Value();
                /*0x74ff238*/ bool get_IsTrue();
                /*0x74ff248*/ bool get_IsFalse();
                /*0x74ff3d8*/ byte get_ByteValue();
                /*0x74ff46c*/ string ToString();
                /*0x74ff6d0*/ int CompareTo(object value);
                /*0x74ff7d8*/ int CompareTo(System.Data.SqlTypes.SqlBoolean value);
                /*0x74ff8dc*/ bool Equals(object value);
                /*0x74ff9ec*/ int GetHashCode();
                /*0x74ffaa0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x74ffaa8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x74ffbcc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x75011f4*/ SqlByte();
                static /*0x74ffe94*/ System.Data.SqlTypes.SqlByte op_Implicit(byte x);
                static /*0x74fff40*/ System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x750006c*/ System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7500198*/ System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75002c8*/ System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75003cc*/ System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x750057c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7500644*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x750070c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x75007d4*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7500840*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x7501168*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x74ffe20*/ SqlByte(bool fNull);
                /*0x74ffe28*/ SqlByte(byte value);
                /*0x74ffe38*/ bool get_IsNull();
                /*0x74ffe48*/ byte get_Value();
                /*0x74ffea4*/ string ToString();
                /*0x75008ac*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x75009d0*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x7500af0*/ int CompareTo(object value);
                /*0x7500bf8*/ int CompareTo(System.Data.SqlTypes.SqlByte value);
                /*0x7500d40*/ bool Equals(object value);
                /*0x7500e7c*/ int GetHashCode();
                /*0x7500f10*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7500f18*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7501038*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7501b4c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x7501c10*/ System.Data.SqlTypes.SqlBytes get_Null();
                /*0x750126c*/ SqlBytes();
                /*0x75012cc*/ SqlBytes(byte[] buffer);
                /*0x7501344*/ SqlBytes(System.Data.SqlTypes.SqlBinary value);
                /*0x75013d4*/ bool get_IsNull();
                /*0x75013e4*/ byte[] get_Buffer();
                /*0x7501594*/ long get_Length();
                /*0x7501604*/ byte[] get_Value();
                /*0x75012a0*/ void SetNull();
                /*0x750141c*/ void CopyStreamToBuffer();
                /*0x750140c*/ bool FStream();
                /*0x75017ec*/ void SetBuffer(byte[] buffer);
                /*0x750184c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7501854*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x7501a18*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x7501bd8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class SqlChars : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ char[] _rgchBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.Data.SqlTypes.SqlStreamChars _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ char[] _rgchWorkBuf;

                static /*0x7502464*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x7502528*/ System.Data.SqlTypes.SqlChars get_Null();
                /*0x7501c64*/ SqlChars();
                /*0x7501cc4*/ SqlChars(char[] buffer);
                /*0x7501d3c*/ SqlChars(System.Data.SqlTypes.SqlString value);
                /*0x7501de0*/ bool get_IsNull();
                /*0x7501df0*/ char[] get_Buffer();
                /*0x7501f94*/ long get_Length();
                /*0x7502004*/ char[] get_Value();
                /*0x7501c98*/ void SetNull();
                /*0x7501e18*/ bool FStream();
                /*0x7501e28*/ void CopyStreamToBuffer();
                /*0x75021e0*/ void SetBuffer(char[] buffer);
                /*0x7502240*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7502248*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x7502364*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x75024f0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x75039d8*/ SqlDateTime();
                static /*0x750280c*/ System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value);
                static /*0x75028b4*/ System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value);
                static /*0x750295c*/ System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value);
                static /*0x75025f4*/ System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value);
                static /*0x7502c8c*/ System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value);
                static /*0x7502db0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x7502e8c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x7502f74*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x750305c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x75030e0*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x750394c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750257c*/ SqlDateTime(bool fNull);
                /*0x7502588*/ SqlDateTime(System.DateTime value);
                /*0x75026d8*/ SqlDateTime(int dayTicks, int timeTicks);
                /*0x75027fc*/ bool get_IsNull();
                /*0x7502b58*/ System.DateTime get_Value();
                /*0x7502bf4*/ int get_DayTicks();
                /*0x7502c40*/ int get_TimeTicks();
                /*0x7502cbc*/ string ToString();
                /*0x7503164*/ int CompareTo(object value);
                /*0x7503274*/ int CompareTo(System.Data.SqlTypes.SqlDateTime value);
                /*0x75033e0*/ bool Equals(object value);
                /*0x750352c*/ int GetHashCode();
                /*0x75035e8*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75035f0*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x75037f0*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x750a250*/ SqlDecimal();
                static /*0x7505560*/ System.Data.SqlTypes.SqlDecimal Parse(string s);
                static /*0x7505f5c*/ System.Data.SqlTypes.SqlDecimal op_Implicit(decimal x);
                static /*0x7505f74*/ System.Data.SqlTypes.SqlDecimal op_Implicit(long x);
                static /*0x7505fdc*/ System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x);
                static /*0x75060fc*/ System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7506bd4*/ System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7506cb4*/ System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x75075f0*/ System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x75082d8*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x75083b4*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x75084ec*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x7508668*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x7508750*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x750825c*/ void ZeroToMaxLen(uint[] rgulData, int cUI4sCur);
                static /*0x750455c*/ byte BGetPrecUI4(uint value);
                static /*0x7504760*/ byte BGetPrecUI8(ulong dwlVal);
                static /*0x7508bd0*/ void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, ref int ciulD);
                static /*0x7508c34*/ void MpSet(uint[] rgulD, ref int ciulD, uint iulN);
                static /*0x7508c60*/ void MpNormalize(uint[] rgulU, ref int ciulU);
                static /*0x7508cb8*/ void MpMul1(uint[] piulD, ref int ciulD, uint iulX);
                static /*0x7505480*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
                static /*0x7508db8*/ ulong DWL(uint lo, uint hi);
                static /*0x7508dac*/ uint HI(ulong x);
                static /*0x7508db4*/ uint LO(ulong x);
                static /*0x7507a20*/ void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, ref int ciulQ, uint[] rgulR, ref int ciulR);
                static /*0x7504b04*/ void CheckValidPrecScale(byte bPrec, byte bScale);
                static /*0x7509040*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x750914c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7509258*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7509364*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7509418*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x7505558*/ char ChFromDigit(uint uiDigit);
                static /*0x750a1c4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x75042bc*/ SqlDecimal(bool fNull);
                /*0x7504324*/ SqlDecimal(decimal value);
                /*0x7504488*/ SqlDecimal(int value);
                /*0x7504694*/ SqlDecimal(long value);
                /*0x75049a4*/ SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive);
                /*0x7503e7c*/ byte CalculatePrecision();
                /*0x75040a0*/ bool VerifyPrecision(byte precision);
                /*0x7504c68*/ bool get_IsNull();
                /*0x7504cd8*/ decimal get_Value();
                /*0x7504e8c*/ bool get_IsPositive();
                /*0x7504c00*/ void SetPositive();
                /*0x7504f4c*/ void SetSignBit(bool fPositive);
                /*0x7504fd0*/ byte get_Scale();
                /*0x7505064*/ int[] get_Data();
                /*0x7505160*/ string ToString();
                /*0x7505e10*/ double ToDouble();
                /*0x7504d2c*/ decimal ToDecimal();
                /*0x7504be0*/ bool FZero();
                /*0x7506b6c*/ bool FGt10_38();
                /*0x750895c*/ bool FGt10_38(uint[] rglData);
                /*0x7505c60*/ void AddULong(uint ulAdd);
                /*0x7505a58*/ void MultByULong(uint uiMultiplier);
                /*0x7508a2c*/ uint DivByULong(uint iDivisor);
                /*0x75066f4*/ void AdjustScale(int digits, bool fRound);
                /*0x7506a14*/ int LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x7508dc4*/ System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x75094cc*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7509610*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x750985c*/ System.Data.SqlTypes.SqlMoney ToSqlMoney();
                /*0x75089d4*/ void StoreFromWorkingArray(uint[] rguiData);
                /*0x75059e0*/ void SetToZero();
                /*0x75099b0*/ int CompareTo(object value);
                /*0x7509adc*/ int CompareTo(System.Data.SqlTypes.SqlDecimal value);
                /*0x7509ca0*/ bool Equals(object value);
                /*0x7509e30*/ int GetHashCode();
                /*0x7509f40*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7509f48*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x750a0ac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlDouble Null;
                static /*0x10*/ System.Data.SqlTypes.SqlDouble Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlDouble MinValue;
                static /*0x30*/ System.Data.SqlTypes.SqlDouble MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ double m_value;

                static /*0x750bca0*/ SqlDouble();
                static /*0x750a6c4*/ System.Data.SqlTypes.SqlDouble op_Implicit(double x);
                static /*0x750a784*/ System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x);
                static /*0x750a82c*/ System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750a954*/ System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750aa7c*/ System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750aba4*/ System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x7500904*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x750ad00*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x750adcc*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x750ae94*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x750af5c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x);
                static /*0x750b028*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x750954c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x750b17c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750b254*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750b32c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750b404*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750b488*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x750bc14*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750a5ec*/ SqlDouble(bool fNull);
                /*0x750a5f8*/ SqlDouble(double value);
                /*0x750a668*/ bool get_IsNull();
                /*0x750a678*/ double get_Value();
                /*0x750a6e8*/ string ToString();
                /*0x750b50c*/ System.Data.SqlTypes.SqlSingle ToSqlSingle();
                /*0x750b56c*/ int CompareTo(object value);
                /*0x750b678*/ int CompareTo(System.Data.SqlTypes.SqlDouble value);
                /*0x750b7d8*/ bool Equals(object value);
                /*0x750b91c*/ int GetHashCode();
                /*0x750b9b0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x750b9b8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x750bad8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_sizeOfGuid;
                static /*0x8*/ int[] s_rgiGuidOrder;
                static /*0x10*/ System.Data.SqlTypes.SqlGuid Null;
                /*0x10*/ byte[] m_value;

                static /*0x750c9d0*/ SqlGuid();
                static /*0x750be2c*/ System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x);
                static /*0x750bf0c*/ System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x750c004*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x750c0e4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x750c1c4*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x750c944*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750bd30*/ SqlGuid(bool fNull);
                /*0x750bd3c*/ SqlGuid(System.Guid g);
                /*0x750bd74*/ bool get_IsNull();
                /*0x750bd84*/ System.Guid get_Value();
                /*0x750be60*/ string ToString();
                /*0x750c2a4*/ int CompareTo(object value);
                /*0x750c3ac*/ int CompareTo(System.Data.SqlTypes.SqlGuid value);
                /*0x750c4f0*/ bool Equals(object value);
                /*0x750c628*/ int GetHashCode();
                /*0x750c6bc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x750c6c4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x750c7f8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x750de4c*/ SqlInt16();
                static /*0x750cac8*/ System.Data.SqlTypes.SqlInt16 op_Implicit(short x);
                static /*0x750cb74*/ System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x);
                static /*0x750cc10*/ System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750cd1c*/ System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750ce28*/ System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750cf70*/ System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750d0c8*/ System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x750d198*/ System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x750d2ac*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750d370*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750d434*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750d4f8*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750d564*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x750ddc0*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750caac*/ SqlInt16(bool fNull);
                /*0x750cab8*/ SqlInt16(short value);
                /*0x7508490*/ bool get_IsNull();
                /*0x75084a0*/ short get_Value();
                /*0x750cad8*/ string ToString();
                /*0x750d5d0*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x750d628*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x750d748*/ int CompareTo(object value);
                /*0x750d850*/ int CompareTo(System.Data.SqlTypes.SqlInt16 value);
                /*0x750d998*/ bool Equals(object value);
                /*0x750dad4*/ int GetHashCode();
                /*0x750db68*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x750db70*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x750dc90*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x750f3a8*/ SqlInt32();
                static /*0x750dee4*/ System.Data.SqlTypes.SqlInt32 op_Implicit(int x);
                static /*0x750df90*/ System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x);
                static /*0x750e02c*/ System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e16c*/ System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e2a0*/ System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e3e8*/ System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e54c*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x750e61c*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x750e6ec*/ System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x750e160*/ bool SameSignInt(int x, int y);
                static /*0x750e800*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e8c8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750e990*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750ea58*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750eac4*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x750f31c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750dec8*/ SqlInt32(bool fNull);
                /*0x750ded4*/ SqlInt32(int value);
                /*0x75085c8*/ bool get_IsNull();
                /*0x75085d8*/ int get_Value();
                /*0x750def4*/ string ToString();
                /*0x750eb30*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x750eb88*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x750eca8*/ int CompareTo(object value);
                /*0x750edb0*/ int CompareTo(System.Data.SqlTypes.SqlInt32 value);
                /*0x750eef4*/ bool Equals(object value);
                /*0x750f030*/ int GetHashCode();
                /*0x750f0c4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x750f0cc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x750f1ec*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x75108c4*/ SqlInt64();
                static /*0x750f440*/ System.Data.SqlTypes.SqlInt64 op_Implicit(long x);
                static /*0x750f4e8*/ System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x);
                static /*0x750f584*/ System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750f6cc*/ System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750f804*/ System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750f988*/ System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750fad0*/ System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7500a28*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x750d680*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x750ebe0*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x7509690*/ System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x750f6bc*/ bool SameSignLong(long x, long y);
                static /*0x750fc1c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750fcec*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750fdbc*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750fe8c*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x750ff10*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x7510838*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x750f424*/ SqlInt64(bool fNull);
                /*0x750f430*/ SqlInt64(long value);
                /*0x7500520*/ bool get_IsNull();
                /*0x7500530*/ long get_Value();
                /*0x750f44c*/ string ToString();
                /*0x750ff94*/ System.Data.SqlTypes.SqlByte ToSqlByte();
                /*0x750fff8*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7510054*/ System.Data.SqlTypes.SqlInt16 ToSqlInt16();
                /*0x75100b8*/ System.Data.SqlTypes.SqlInt32 ToSqlInt32();
                /*0x7510114*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x751019c*/ int CompareTo(object value);
                /*0x75102a8*/ int CompareTo(System.Data.SqlTypes.SqlInt64 value);
                /*0x7510408*/ bool Equals(object value);
                /*0x751054c*/ int GetHashCode();
                /*0x75105e0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75105e8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7510708*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7512438*/ SqlMoney();
                static /*0x7510cd4*/ System.Data.SqlTypes.SqlMoney op_Implicit(decimal x);
                static /*0x7510d00*/ System.Data.SqlTypes.SqlMoney op_Implicit(long x);
                static /*0x7510e84*/ System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x);
                static /*0x7510f7c*/ System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511128*/ System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x75112d0*/ System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x751140c*/ System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511548*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7511610*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x75116d8*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x75117a0*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x75098dc*/ System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x7511868*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511938*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511a08*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511ad8*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x7511b5c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x75123ac*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x751095c*/ SqlMoney(bool fNull);
                /*0x7510968*/ SqlMoney(long value, int ignored);
                /*0x7510978*/ SqlMoney(int value);
                /*0x75109f4*/ SqlMoney(long value);
                /*0x7510aec*/ SqlMoney(decimal value);
                /*0x7508844*/ bool get_IsNull();
                /*0x7510c44*/ decimal get_Value();
                /*0x7508854*/ decimal ToDecimal();
                /*0x750b0ec*/ double ToDouble();
                /*0x7510d5c*/ string ToString();
                /*0x7511be0*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x7511c3c*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x7511cc4*/ int CompareTo(object value);
                /*0x7511dd0*/ int CompareTo(System.Data.SqlTypes.SqlMoney value);
                /*0x7511f30*/ bool Equals(object value);
                /*0x7512074*/ int GetHashCode();
                /*0x75120e4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75120ec*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x751225c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlSingle Null;
                static /*0x8*/ System.Data.SqlTypes.SqlSingle Zero;
                static /*0x10*/ System.Data.SqlTypes.SqlSingle MinValue;
                static /*0x18*/ System.Data.SqlTypes.SqlSingle MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x14*/ float _value;

                static /*0x7513dac*/ SqlSingle();
                static /*0x7512674*/ System.Data.SqlTypes.SqlSingle op_Implicit(float x);
                static /*0x7512704*/ System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x);
                static /*0x75127a4*/ System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x75128c0*/ System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x75129dc*/ System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7512af8*/ System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7512c4c*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x7512d20*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x7512df4*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x7512ec0*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x7512f90*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x751305c*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x7513128*/ System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x);
                static /*0x75131f4*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x75132d8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x75133bc*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x75134a0*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x751350c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x7513d20*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7512500*/ SqlSingle(bool fNull);
                /*0x751250c*/ SqlSingle(float value);
                /*0x7512580*/ SqlSingle(double value);
                /*0x75125e4*/ bool get_IsNull();
                /*0x75125f4*/ float get_Value();
                /*0x7512690*/ string ToString();
                /*0x7513578*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x75135d4*/ int CompareTo(object value);
                /*0x75136d8*/ int CompareTo(System.Data.SqlTypes.SqlSingle value);
                /*0x75138e8*/ bool Equals(object value);
                /*0x7513a28*/ int GetHashCode();
                /*0x7513abc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7513ac4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x7513be4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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

                static /*0x7515640*/ SqlString();
                static /*0x75142a4*/ System.Data.SqlTypes.SqlString op_Implicit(string x);
                static /*0x7514324*/ System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x7514494*/ int StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x7514aac*/ System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult);
                static /*0x7514c18*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x7513f28*/ void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x7514a08*/ System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x75146c8*/ int CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x7514890*/ int CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x75155b4*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7513e3c*/ SqlString(bool fNull);
                /*0x7513e70*/ SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions);
                /*0x7513fd4*/ SqlString(string data);
                /*0x7514090*/ SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, string data, System.Globalization.CompareInfo cmpInfo);
                /*0x7514170*/ bool get_IsNull();
                /*0x7514180*/ string get_Value();
                /*0x751420c*/ void SetCompareInfo();
                /*0x75142b8*/ string ToString();
                /*0x7514d40*/ bool FBinarySort();
                /*0x7514dac*/ int CompareTo(object value);
                /*0x7514ec4*/ int CompareTo(System.Data.SqlTypes.SqlString value);
                /*0x7514fc4*/ bool Equals(object value);
                /*0x7515190*/ int GetHashCode();
                /*0x75153b0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x75153b8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x75154b8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
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
                static /*0x7515818*/ System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x7515744*/ SqlTypeException();
                /*0x751446c*/ SqlTypeException(string message);
                /*0x75157a4*/ SqlTypeException(string message, System.Exception e);
                /*0x75157c8*/ SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x7515998*/ System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x751263c*/ SqlNullValueException();
                /*0x7515910*/ SqlNullValueException(string message);
                /*0x75158ec*/ SqlNullValueException(string message, System.Exception e);
                /*0x7515938*/ SqlNullValueException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x7515b50*/ System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x7515a6c*/ SqlTruncateException();
                /*0x7515ac8*/ SqlTruncateException(string message);
                /*0x7515aa4*/ SqlTruncateException(string message, System.Exception e);
                /*0x7515af0*/ SqlTruncateException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlStreamChars
            {
                /*0x380b828*/ long get_Length();
                /*0x380b828*/ long get_Position();
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

                static /*0x7516808*/ SqlXml();
                static /*0x7515f98*/ System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, bool closeInput, bool throwTargetInvocationExceptions);
                static /*0x751634c*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> CreateSqlReaderDelegate();
                static /*0x7515e80*/ System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo();
                static /*0x751677c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x7515c24*/ SqlXml();
                /*0x7515c84*/ System.Xml.XmlReader CreateReader();
                /*0x7515df0*/ bool get_IsNull();
                /*0x7515c58*/ void SetNull();
                /*0x7516438*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x7516440*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x751662c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            class SqlXmlStreamWrapper : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ long _lPosition;
                /*0x38*/ bool _isClosed;

                /*0x7515e00*/ SqlXmlStreamWrapper(System.IO.Stream stream);
                /*0x7516900*/ bool get_CanRead();
                /*0x75169a8*/ bool get_CanSeek();
                /*0x75169e0*/ bool get_CanWrite();
                /*0x7516a18*/ long get_Length();
                /*0x7516b68*/ long get_Position();
                /*0x7516bc4*/ void set_Position(long value);
                /*0x7516c98*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x7516e68*/ int Read(byte[] buffer, int offset, int count);
                /*0x75170a0*/ void Write(byte[] buffer, int offset, int count);
                /*0x75172d8*/ int ReadByte();
                /*0x75173f0*/ void WriteByte(byte value);
                /*0x75174d8*/ void SetLength(long value);
                /*0x751756c*/ void Flush();
                /*0x7517588*/ void Dispose(bool disposing);
                /*0x7516aec*/ void ThrowIfStreamCannotSeek(string method);
                /*0x7517024*/ void ThrowIfStreamCannotRead(string method);
                /*0x751725c*/ void ThrowIfStreamCannotWrite(string method);
                /*0x7516a84*/ void ThrowIfStreamClosed(string method);
                /*0x7516938*/ bool IsStreamClosed();
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

                static /*0x751cafc*/ ObjectStorage();
                static /*0x751c958*/ void VerifyIDynamicMetaObjectProvider(System.Type type);
                static /*0x75192f4*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type);
                static /*0x751b744*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute);
                /*0x751759c*/ ObjectStorage(System.Data.DataColumn column, System.Type type);
                /*0x7517994*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75179c4*/ int Compare(int recordNo1, int recordNo2);
                /*0x7518014*/ int CompareValueTo(int recordNo1, object value);
                /*0x75181ec*/ int CompareTo(object valueNo1, object valueNo2);
                /*0x7517b78*/ int CompareWithFamilies(object valueNo1, object valueNo2);
                /*0x75184c8*/ void Copy(int recordNo1, int recordNo2);
                /*0x7518540*/ object Get(int recordNo);
                /*0x75183c4*/ System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType);
                /*0x751857c*/ bool IsNull(int record);
                /*0x75185b4*/ void Set(int recordNo, object value);
                /*0x7518cfc*/ void SetCapacity(int capacity);
                /*0x7518dbc*/ object ConvertXmlToObject(string s);
                /*0x7519368*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x751bd3c*/ string ConvertObjectToXml(object value);
                /*0x751c3b0*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x751c514*/ object GetEmptyStorage(int recordCount);
                /*0x751c55c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x751c770*/ void SetStorage(object store, System.Collections.BitArray nullbits);

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

                    static /*0x751cd90*/ TempAssemblyComparer();
                    /*0x751cbd0*/ TempAssemblyComparer();
                    /*0x751cbd8*/ bool Equals(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> y);
                    /*0x751cd08*/ int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> obj);
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

                static /*0x751d5c8*/ ADP();
                static /*0x751cdf8*/ void TraceException(string trace, System.Exception e);
                static /*0x751ce90*/ void TraceExceptionAsReturnValue(System.Exception e);
                static /*0x751cefc*/ void TraceExceptionWithoutRethrow(System.Exception e);
                static /*0x751cf68*/ System.ArgumentException Argument(string error);
                static /*0x7514cb0*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName);
                static /*0x751cff8*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName);
                static /*0x751ca6c*/ System.InvalidOperationException InvalidOperation(string error);
                static /*0x751d090*/ System.NotSupportedException NotSupported(string error);
                static /*0x751614c*/ bool IsCatchableExceptionType(System.Exception e);
                static /*0x751d120*/ bool IsCatchableOrSecurityExceptionType(System.Exception e);
                static /*0x751d2e8*/ System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value);
                static /*0x7516dfc*/ System.Exception InvalidSeekOrigin(string parameterName);
                static /*0x751d3f4*/ System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value);
                static /*0x751d490*/ System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value);
                static /*0x751d52c*/ System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value);
                static /*0x7513824*/ System.Exception WrongType(System.Type got, System.Type expected);
            }

            class BigIntegerStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Numerics.BigInteger[] _values;

                static /*0x751de04*/ System.Numerics.BigInteger ConvertToBigInteger(object value, System.IFormatProvider formatProvider);
                static /*0x751e460*/ object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider);
                /*0x751d934*/ BigIntegerStorage(System.Data.DataColumn column);
                /*0x751dafc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x751db2c*/ int Compare(int recordNo1, int recordNo2);
                /*0x751dcb4*/ int CompareValueTo(int recordNo, object value);
                /*0x751ea80*/ object ConvertValue(object value);
                /*0x751eb20*/ void Copy(int recordNo1, int recordNo2);
                /*0x751ebc0*/ object Get(int record);
                /*0x751ecb4*/ void Set(int record, object value);
                /*0x751ee24*/ void SetCapacity(int capacity);
                /*0x751ef78*/ object ConvertXmlToObject(string s);
                /*0x751f028*/ string ConvertObjectToXml(object value);
                /*0x751f118*/ object GetEmptyStorage(int recordCount);
                /*0x751f160*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x751f274*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class BooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ bool[] _values;

                /*0x751f338*/ BooleanStorage(System.Data.DataColumn column);
                /*0x751f3fc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x751f780*/ int Compare(int recordNo1, int recordNo2);
                /*0x751f80c*/ int CompareValueTo(int recordNo, object value);
                /*0x751f8e4*/ object ConvertValue(object value);
                /*0x751fa2c*/ void Copy(int recordNo1, int recordNo2);
                /*0x751fa80*/ object Get(int record);
                /*0x751fad4*/ void Set(int record, object value);
                /*0x751fc5c*/ void SetCapacity(int capacity);
                /*0x751fd2c*/ object ConvertXmlToObject(string s);
                /*0x751fdb0*/ string ConvertObjectToXml(object value);
                /*0x751fe3c*/ object GetEmptyStorage(int recordCount);
                /*0x751fe84*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x751ff84*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ byte[] _values;

                /*0x7520048*/ ByteStorage(System.Data.DataColumn column);
                /*0x752010c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75208a8*/ int Compare(int recordNo1, int recordNo2);
                /*0x7520918*/ int CompareValueTo(int recordNo, object value);
                /*0x75209dc*/ object ConvertValue(object value);
                /*0x7520b20*/ void Copy(int recordNo1, int recordNo2);
                /*0x7520b74*/ object Get(int record);
                /*0x7520bc8*/ void Set(int record, object value);
                /*0x7520d4c*/ void SetCapacity(int capacity);
                /*0x7520e1c*/ object ConvertXmlToObject(string s);
                /*0x7520e9c*/ string ConvertObjectToXml(object value);
                /*0x7520f28*/ object GetEmptyStorage(int recordCount);
                /*0x7520f70*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7521070*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class CharStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ char[] _values;

                /*0x7521134*/ CharStorage(System.Data.DataColumn column);
                /*0x75211f8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7521558*/ int Compare(int recordNo1, int recordNo2);
                /*0x75215e0*/ int CompareValueTo(int recordNo, object value);
                /*0x75216b8*/ object ConvertValue(object value);
                /*0x75217fc*/ void Copy(int recordNo1, int recordNo2);
                /*0x7521850*/ object Get(int record);
                /*0x75218a4*/ void Set(int record, object value);
                /*0x7521a84*/ void SetCapacity(int capacity);
                /*0x7521b54*/ object ConvertXmlToObject(string s);
                /*0x7521bd4*/ string ConvertObjectToXml(object value);
                /*0x7521c60*/ object GetEmptyStorage(int recordCount);
                /*0x7521ca8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7521da8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
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

                static /*0x752363c*/ DataStorage();
                static /*0x7522048*/ System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode);
                static /*0x7517730*/ System.Data.Common.StorageType GetStorageType(System.Type dataType);
                static /*0x7522f00*/ System.Type GetTypeStorage(System.Data.Common.StorageType storageType);
                static /*0x751c338*/ bool IsTypeCustomType(System.Type type);
                static /*0x7521e78*/ bool IsTypeCustomType(System.Data.Common.StorageType typeCode);
                static /*0x7522f7c*/ bool IsSqlType(System.Data.Common.StorageType storageType);
                static /*0x7522f88*/ bool IsSqlType(System.Type dataType);
                static /*0x7521e9c*/ bool DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x7523078*/ void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, ref bool sqlType, ref bool nullable, ref bool xmlSerializable, ref bool changeTracking, ref bool revertibleChangeTracking);
                static /*0x75231cc*/ System.Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType);
                static /*0x7523378*/ bool ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x7523440*/ bool IsObjectNull(object value);
                static /*0x75234e0*/ bool IsObjectSqlNull(object value);
                static /*0x75199fc*/ System.Type GetType(string value);
                static /*0x75235cc*/ string GetQualifiedName(System.Type type);
                /*0x751da68*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, System.Data.Common.StorageType storageType);
                /*0x7521e6c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, System.Data.Common.StorageType storageType);
                /*0x7517840*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, System.Data.Common.StorageType storageType);
                /*0x7521ed8*/ System.Data.DataSetDateTime get_DateTimeMode();
                /*0x75184ac*/ System.IFormatProvider get_FormatProvider();
                /*0x751f76c*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x7521ef4*/ object AggregateCount(int[] recordNos);
                /*0x751dc44*/ int CompareBits(int recordNo1, int recordNo2);
                /*0x380b710*/ int Compare(int recordNo1, int recordNo2);
                int CompareValueTo(int recordNo1, object value);
                /*0x7521fa0*/ object ConvertValue(object value);
                /*0x751eb80*/ void CopyBits(int srcRecordNo, int dstRecordNo);
                /*0x380d0e4*/ void Copy(int recordNo1, int recordNo2);
                /*0x380ba90*/ object Get(int recordNo);
                /*0x751ec7c*/ object GetBits(int recordNo);
                /*0x7521fa8*/ int GetStringLength(int record);
                /*0x751dddc*/ bool HasValue(int recordNo);
                /*0x7521fb0*/ bool IsNull(int recordNo);
                /*0x380d170*/ void Set(int recordNo, object value);
                /*0x751ee04*/ void SetNullBit(int recordNo, bool flag);
                /*0x751eef4*/ void SetCapacity(int capacity);
                /*0x380bb68*/ object ConvertXmlToObject(string s);
                /*0x7521fcc*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x380bb68*/ string ConvertObjectToXml(object value);
                /*0x752200c*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x7523594*/ object GetEmptyStorageInternal(int recordCount);
                /*0x75235a4*/ void CopyValueInternal(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75235b4*/ void SetStorageInternal(object store, System.Collections.BitArray nullbits);
                /*0x380ba90*/ object GetEmptyStorage(int recordCount);
                void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x380d93c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
                /*0x75235c4*/ void SetNullStorage(System.Collections.BitArray nullbits);
            }

            class DateTimeOffsetStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTimeOffset s_defaultValue;
                /*0x50*/ System.DateTimeOffset[] _values;

                static /*0x75253a4*/ DateTimeOffsetStorage();
                /*0x7522ddc*/ DateTimeOffsetStorage(System.Data.DataColumn column);
                /*0x7524474*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7524954*/ int Compare(int recordNo1, int recordNo2);
                /*0x7524af8*/ int CompareValueTo(int recordNo, object value);
                /*0x7524c78*/ object ConvertValue(object value);
                /*0x7524d1c*/ void Copy(int recordNo1, int recordNo2);
                /*0x7524d70*/ object Get(int record);
                /*0x7524e7c*/ void Set(int record, object value);
                /*0x7524f9c*/ void SetCapacity(int capacity);
                /*0x752506c*/ object ConvertXmlToObject(string s);
                /*0x75250f8*/ string ConvertObjectToXml(object value);
                /*0x7525194*/ object GetEmptyStorage(int recordCount);
                /*0x75251dc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75252e0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DateTimeStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTime s_defaultValue;
                /*0x50*/ System.DateTime[] _values;

                static /*0x75267d0*/ DateTimeStorage();
                /*0x7522cc0*/ DateTimeStorage(System.Data.DataColumn column);
                /*0x7525428*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75258e8*/ int Compare(int recordNo1, int recordNo2);
                /*0x7525a60*/ int CompareValueTo(int recordNo, object value);
                /*0x7525bc4*/ object ConvertValue(object value);
                /*0x7525d14*/ void Copy(int recordNo1, int recordNo2);
                /*0x7525d68*/ object Get(int record);
                /*0x7525e60*/ void Set(int record, object value);
                /*0x75261d4*/ void SetCapacity(int capacity);
                /*0x75262a4*/ object ConvertXmlToObject(string s);
                /*0x7526358*/ string ConvertObjectToXml(object value);
                /*0x752640c*/ object GetEmptyStorage(int recordCount);
                /*0x7526454*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75265b4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DecimalStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ decimal s_defaultValue;
                /*0x50*/ decimal[] _values;

                /*0x7522b90*/ DecimalStorage(System.Data.DataColumn column);
                /*0x7526848*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752725c*/ int Compare(int recordNo1, int recordNo2);
                /*0x75273d8*/ int CompareValueTo(int recordNo, object value);
                /*0x7527544*/ object ConvertValue(object value);
                /*0x75276bc*/ void Copy(int recordNo1, int recordNo2);
                /*0x7527710*/ object Get(int record);
                /*0x75277d4*/ void Set(int record, object value);
                /*0x752797c*/ void SetCapacity(int capacity);
                /*0x7527a4c*/ object ConvertXmlToObject(string s);
                /*0x7527b00*/ string ConvertObjectToXml(object value);
                /*0x7527b9c*/ object GetEmptyStorage(int recordCount);
                /*0x7527be4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7527ce8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ double[] _values;

                /*0x7522acc*/ DoubleStorage(System.Data.DataColumn column);
                /*0x7527dac*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75284d0*/ int Compare(int recordNo1, int recordNo2);
                /*0x7528550*/ int CompareValueTo(int recordNo, object value);
                /*0x7528618*/ object ConvertValue(object value);
                /*0x7528758*/ void Copy(int recordNo1, int recordNo2);
                /*0x75287ac*/ object Get(int record);
                /*0x7528804*/ void Set(int record, object value);
                /*0x7528988*/ void SetCapacity(int capacity);
                /*0x7528a58*/ object ConvertXmlToObject(string s);
                /*0x7528ad4*/ string ConvertObjectToXml(object value);
                /*0x7528b60*/ object GetEmptyStorage(int recordCount);
                /*0x7528ba8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7528ca8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ short[] _values;

                /*0x7522880*/ Int16Storage(System.Data.DataColumn column);
                /*0x7528d6c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752957c*/ int Compare(int recordNo1, int recordNo2);
                /*0x75295dc*/ int CompareValueTo(int recordNo, object value);
                /*0x752968c*/ object ConvertValue(object value);
                /*0x75297d0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7529824*/ object Get(int record);
                /*0x7529878*/ void Set(int record, object value);
                /*0x75299fc*/ void SetCapacity(int capacity);
                /*0x7529acc*/ object ConvertXmlToObject(string s);
                /*0x7529b4c*/ string ConvertObjectToXml(object value);
                /*0x7529bd8*/ object GetEmptyStorage(int recordCount);
                /*0x7529c20*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7529d1c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ int[] _values;

                /*0x7522944*/ Int32Storage(System.Data.DataColumn column);
                /*0x7529de0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752a5f4*/ int Compare(int recordNo1, int recordNo2);
                /*0x752a660*/ int CompareValueTo(int recordNo, object value);
                /*0x752a710*/ object ConvertValue(object value);
                /*0x752a854*/ void Copy(int recordNo1, int recordNo2);
                /*0x752a8a8*/ object Get(int record);
                /*0x752a8fc*/ void Set(int record, object value);
                /*0x752aa80*/ void SetCapacity(int capacity);
                /*0x752ab50*/ object ConvertXmlToObject(string s);
                /*0x752abd0*/ string ConvertObjectToXml(object value);
                /*0x752ac5c*/ object GetEmptyStorage(int recordCount);
                /*0x752aca4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x752ada0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ long[] _values;

                /*0x7522a08*/ Int64Storage(System.Data.DataColumn column);
                /*0x752ae64*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752b654*/ int Compare(int recordNo1, int recordNo2);
                /*0x752b6c0*/ int CompareValueTo(int recordNo, object value);
                /*0x752b770*/ object ConvertValue(object value);
                /*0x752b8b4*/ void Copy(int recordNo1, int recordNo2);
                /*0x752b908*/ object Get(int record);
                /*0x752b95c*/ void Set(int record, object value);
                /*0x752bae0*/ void SetCapacity(int capacity);
                /*0x752bbb0*/ object ConvertXmlToObject(string s);
                /*0x752bc30*/ string ConvertObjectToXml(object value);
                /*0x752bcbc*/ object GetEmptyStorage(int recordCount);
                /*0x752bd04*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x752be00*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ sbyte[] _values;

                /*0x75227bc*/ SByteStorage(System.Data.DataColumn column);
                /*0x752bec4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x752c688*/ int Compare(int recordNo1, int recordNo2);
                /*0x752c740*/ int CompareValueTo(int recordNo, object value);
                /*0x752c804*/ object ConvertValue(object value);
                /*0x752c948*/ void Copy(int recordNo1, int recordNo2);
                /*0x752c99c*/ object Get(int record);
                /*0x752ca24*/ void Set(int record, object value);
                /*0x752cba8*/ void SetCapacity(int capacity);
                /*0x752cc78*/ object ConvertXmlToObject(string s);
                /*0x752ccf8*/ string ConvertObjectToXml(object value);
                /*0x752cd84*/ object GetEmptyStorage(int recordCount);
                /*0x752cdcc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x752cecc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlConvert
            {
                static /*0x752cf90*/ System.Data.SqlTypes.SqlByte ConvertToSqlByte(object value);
                static /*0x752d164*/ System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(object value);
                static /*0x752d3fc*/ System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(object value);
                static /*0x752d79c*/ System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(object value);
                static /*0x752dc48*/ System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(object value);
                static /*0x752e328*/ System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(object value);
                static /*0x752e978*/ System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(object value);
                static /*0x752efdc*/ System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(object value);
                static /*0x752f5a0*/ System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(object value);
                static /*0x752f78c*/ System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(object value);
                static /*0x752f94c*/ System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(object value);
                static /*0x752fb2c*/ System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(object value);
                static /*0x752fd00*/ System.Data.SqlTypes.SqlString ConvertToSqlString(object value);
                static /*0x752fed4*/ System.Data.SqlTypes.SqlChars ConvertToSqlChars(object value);
                static /*0x7530020*/ System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(object value);
                static /*0x753016c*/ System.DateTimeOffset ConvertStringToDateTimeOffset(string value, System.IFormatProvider formatProvider);
                static /*0x75301d4*/ object ChangeTypeForDefaultValue(object value, System.Type type, System.IFormatProvider formatProvider);
                static /*0x7530394*/ object ChangeType2(object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider);
                static /*0x7519b28*/ object ChangeTypeForXML(object value, System.Type type);
            }

            class SqlBinaryStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBinary[] _values;

                /*0x753188c*/ SqlBinaryStorage(System.Data.DataColumn column);
                /*0x75319c0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7531bf4*/ int Compare(int recordNo1, int recordNo2);
                /*0x7531c94*/ int CompareValueTo(int recordNo, object value);
                /*0x7531d50*/ object ConvertValue(object value);
                /*0x7531dc8*/ void Copy(int recordNo1, int recordNo2);
                /*0x7531e0c*/ object Get(int record);
                /*0x7531e8c*/ bool IsNull(int record);
                /*0x7531f08*/ void Set(int record, object value);
                /*0x7531f58*/ void SetCapacity(int capacity);
                /*0x7532018*/ object ConvertXmlToObject(string s);
                /*0x7532300*/ string ConvertObjectToXml(object value);
                /*0x75325a0*/ object GetEmptyStorage(int recordCount);
                /*0x75325e8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75326f0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlByte[] _values;

                /*0x753278c*/ SqlByteStorage(System.Data.DataColumn column);
                /*0x75328b8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75336ec*/ int Compare(int recordNo1, int recordNo2);
                /*0x753378c*/ int CompareValueTo(int recordNo, object value);
                /*0x7533848*/ object ConvertValue(object value);
                /*0x75338c0*/ void Copy(int recordNo1, int recordNo2);
                /*0x75338fc*/ object Get(int record);
                /*0x753397c*/ bool IsNull(int record);
                /*0x75339f8*/ void Set(int record, object value);
                /*0x7533a40*/ void SetCapacity(int capacity);
                /*0x7533b00*/ object ConvertXmlToObject(string s);
                /*0x7533de8*/ string ConvertObjectToXml(object value);
                /*0x7534088*/ object GetEmptyStorage(int recordCount);
                /*0x75340d0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75341d0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBytesStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBytes[] _values;

                /*0x753426c*/ SqlBytesStorage(System.Data.DataColumn column);
                /*0x7534340*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7534534*/ int Compare(int recordNo1, int recordNo2);
                /*0x753453c*/ int CompareValueTo(int recordNo, object value);
                /*0x7534544*/ void Copy(int recordNo1, int recordNo2);
                /*0x7534584*/ object Get(int record);
                /*0x75345b4*/ bool IsNull(int record);
                /*0x75345ec*/ void Set(int record, object value);
                /*0x75346e4*/ void SetCapacity(int capacity);
                /*0x75347a4*/ object ConvertXmlToObject(string s);
                /*0x7534ab0*/ string ConvertObjectToXml(object value);
                /*0x7534d50*/ object GetEmptyStorage(int recordCount);
                /*0x7534d98*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7534ea0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlCharsStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlChars[] _values;

                /*0x7534f3c*/ SqlCharsStorage(System.Data.DataColumn column);
                /*0x7535010*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7535204*/ int Compare(int recordNo1, int recordNo2);
                /*0x753520c*/ int CompareValueTo(int recordNo, object value);
                /*0x7535214*/ void Copy(int recordNo1, int recordNo2);
                /*0x7535254*/ object Get(int record);
                /*0x7535284*/ bool IsNull(int record);
                /*0x75352bc*/ void Set(int record, object value);
                /*0x75353b4*/ void SetCapacity(int capacity);
                /*0x7535474*/ object ConvertXmlToObject(string s);
                /*0x753578c*/ string ConvertObjectToXml(object value);
                /*0x7535a2c*/ object GetEmptyStorage(int recordCount);
                /*0x7535a74*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7535b7c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDateTimeStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDateTime[] _values;

                /*0x7535c18*/ SqlDateTimeStorage(System.Data.DataColumn column);
                /*0x7535d5c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7536364*/ int Compare(int recordNo1, int recordNo2);
                /*0x7536418*/ int CompareValueTo(int recordNo, object value);
                /*0x75364dc*/ object ConvertValue(object value);
                /*0x7536558*/ void Copy(int recordNo1, int recordNo2);
                /*0x75365b0*/ object Get(int record);
                /*0x7536640*/ bool IsNull(int record);
                /*0x75366c0*/ void Set(int record, object value);
                /*0x7536714*/ void SetCapacity(int capacity);
                /*0x75367d4*/ object ConvertXmlToObject(string s);
                /*0x7536ac8*/ string ConvertObjectToXml(object value);
                /*0x7536d68*/ object GetEmptyStorage(int recordCount);
                /*0x7536db0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7536ec8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDecimalStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDecimal[] _values;

                /*0x7536f64*/ SqlDecimalStorage(System.Data.DataColumn column);
                /*0x75370a8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7537ffc*/ int Compare(int recordNo1, int recordNo2);
                /*0x75380cc*/ int CompareValueTo(int recordNo, object value);
                /*0x75381a8*/ object ConvertValue(object value);
                /*0x7538234*/ void Copy(int recordNo1, int recordNo2);
                /*0x753829c*/ object Get(int record);
                /*0x7538328*/ bool IsNull(int record);
                /*0x75383a8*/ void Set(int record, object value);
                /*0x753842c*/ void SetCapacity(int capacity);
                /*0x75384ec*/ object ConvertXmlToObject(string s);
                /*0x75387e0*/ string ConvertObjectToXml(object value);
                /*0x7538a80*/ object GetEmptyStorage(int recordCount);
                /*0x7538ac8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7538bf8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDouble[] _values;

                /*0x7538c94*/ SqlDoubleStorage(System.Data.DataColumn column);
                /*0x7538dc8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7539acc*/ int Compare(int recordNo1, int recordNo2);
                /*0x7539b74*/ int CompareValueTo(int recordNo, object value);
                /*0x7539c30*/ object ConvertValue(object value);
                /*0x7539ca8*/ void Copy(int recordNo1, int recordNo2);
                /*0x7539ce4*/ object Get(int record);
                /*0x7539d68*/ bool IsNull(int record);
                /*0x7539de4*/ void Set(int record, object value);
                /*0x7539e30*/ void SetCapacity(int capacity);
                /*0x7539ef0*/ object ConvertXmlToObject(string s);
                /*0x753a1d8*/ string ConvertObjectToXml(object value);
                /*0x753a478*/ object GetEmptyStorage(int recordCount);
                /*0x753a4c0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753a5c8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlGuidStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlGuid[] _values;

                /*0x753a664*/ SqlGuidStorage(System.Data.DataColumn column);
                /*0x753a798*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753a9cc*/ int Compare(int recordNo1, int recordNo2);
                /*0x753aa6c*/ int CompareValueTo(int recordNo, object value);
                /*0x753ab28*/ object ConvertValue(object value);
                /*0x753aba0*/ void Copy(int recordNo1, int recordNo2);
                /*0x753abe4*/ object Get(int record);
                /*0x753ac64*/ bool IsNull(int record);
                /*0x753ace0*/ void Set(int record, object value);
                /*0x753ad30*/ void SetCapacity(int capacity);
                /*0x753adf0*/ object ConvertXmlToObject(string s);
                /*0x753b0d8*/ string ConvertObjectToXml(object value);
                /*0x753b378*/ object GetEmptyStorage(int recordCount);
                /*0x753b3c0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753b4c8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt16[] _values;

                /*0x753b564*/ SqlInt16Storage(System.Data.DataColumn column);
                /*0x753b690*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753c4d4*/ int Compare(int recordNo1, int recordNo2);
                /*0x753c574*/ int CompareValueTo(int recordNo, object value);
                /*0x753c630*/ object ConvertValue(object value);
                /*0x753c6a8*/ void Copy(int recordNo1, int recordNo2);
                /*0x753c6e4*/ object Get(int record);
                /*0x753c764*/ bool IsNull(int record);
                /*0x753c7e0*/ void Set(int record, object value);
                /*0x753c828*/ void SetCapacity(int capacity);
                /*0x753c8e8*/ object ConvertXmlToObject(string s);
                /*0x753cbd0*/ string ConvertObjectToXml(object value);
                /*0x753ce70*/ object GetEmptyStorage(int recordCount);
                /*0x753ceb8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753cfb8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt32[] _values;

                /*0x753d054*/ SqlInt32Storage(System.Data.DataColumn column);
                /*0x753d188*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753df94*/ int Compare(int recordNo1, int recordNo2);
                /*0x753e034*/ int CompareValueTo(int recordNo, object value);
                /*0x753e0f0*/ object ConvertValue(object value);
                /*0x753e168*/ void Copy(int recordNo1, int recordNo2);
                /*0x753e1a4*/ object Get(int record);
                /*0x753e224*/ bool IsNull(int record);
                /*0x753e2a0*/ void Set(int record, object value);
                /*0x753e2e8*/ void SetCapacity(int capacity);
                /*0x753e3a8*/ object ConvertXmlToObject(string s);
                /*0x753e690*/ string ConvertObjectToXml(object value);
                /*0x753e930*/ object GetEmptyStorage(int recordCount);
                /*0x753e978*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x753ea78*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt64[] _values;

                /*0x753eb14*/ SqlInt64Storage(System.Data.DataColumn column);
                /*0x753ec48*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x753fad8*/ int Compare(int recordNo1, int recordNo2);
                /*0x753fb80*/ int CompareValueTo(int recordNo, object value);
                /*0x753fc3c*/ object ConvertValue(object value);
                /*0x753fcb4*/ void Copy(int recordNo1, int recordNo2);
                /*0x753fcf0*/ object Get(int record);
                /*0x753fd74*/ bool IsNull(int record);
                /*0x753fdf0*/ void Set(int record, object value);
                /*0x753fe3c*/ void SetCapacity(int capacity);
                /*0x753fefc*/ object ConvertXmlToObject(string s);
                /*0x75401e4*/ string ConvertObjectToXml(object value);
                /*0x7540484*/ object GetEmptyStorage(int recordCount);
                /*0x75404cc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75405d4*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlMoneyStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlMoney[] _values;

                /*0x7540670*/ SqlMoneyStorage(System.Data.DataColumn column);
                /*0x75407a4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7541694*/ int Compare(int recordNo1, int recordNo2);
                /*0x754173c*/ int CompareValueTo(int recordNo, object value);
                /*0x75417f8*/ object ConvertValue(object value);
                /*0x7541870*/ void Copy(int recordNo1, int recordNo2);
                /*0x75418ac*/ object Get(int record);
                /*0x7541930*/ bool IsNull(int record);
                /*0x75419ac*/ void Set(int record, object value);
                /*0x75419f8*/ void SetCapacity(int capacity);
                /*0x7541ab8*/ object ConvertXmlToObject(string s);
                /*0x7541da0*/ string ConvertObjectToXml(object value);
                /*0x7542040*/ object GetEmptyStorage(int recordCount);
                /*0x7542088*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7542190*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlSingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlSingle[] _values;

                /*0x754222c*/ SqlSingleStorage(System.Data.DataColumn column);
                /*0x7542360*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x7543140*/ int Compare(int recordNo1, int recordNo2);
                /*0x75431e0*/ int CompareValueTo(int recordNo, object value);
                /*0x754329c*/ object ConvertValue(object value);
                /*0x7543314*/ void Copy(int recordNo1, int recordNo2);
                /*0x7543350*/ object Get(int record);
                /*0x75433d0*/ bool IsNull(int record);
                /*0x754344c*/ void Set(int record, object value);
                /*0x7543494*/ void SetCapacity(int capacity);
                /*0x7543554*/ object ConvertXmlToObject(string s);
                /*0x754383c*/ string ConvertObjectToXml(object value);
                /*0x7543adc*/ object GetEmptyStorage(int recordCount);
                /*0x7543b24*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7543c24*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlStringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlString[] _values;

                /*0x7543cc0*/ SqlStringStorage(System.Data.DataColumn column);
                /*0x7543df4*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x75441f0*/ int Compare(int recordNo1, int recordNo2);
                /*0x7544260*/ int Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2);
                /*0x754439c*/ int CompareValueTo(int recordNo, object value);
                /*0x7544460*/ object ConvertValue(object value);
                /*0x75444e0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7544540*/ object Get(int record);
                /*0x75445c4*/ int GetStringLength(int record);
                /*0x7544690*/ bool IsNull(int record);
                /*0x7544710*/ void Set(int record, object value);
                /*0x7544788*/ void SetCapacity(int capacity);
                /*0x7544848*/ object ConvertXmlToObject(string s);
                /*0x7544b34*/ string ConvertObjectToXml(object value);
                /*0x7544dd4*/ object GetEmptyStorage(int recordCount);
                /*0x7544e1c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7544f40*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBoolean[] _values;

                /*0x7544fdc*/ SqlBooleanStorage(System.Data.DataColumn column);
                /*0x7545110*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754558c*/ int Compare(int recordNo1, int recordNo2);
                /*0x754562c*/ int CompareValueTo(int recordNo, object value);
                /*0x75456e8*/ object ConvertValue(object value);
                /*0x7545760*/ void Copy(int recordNo1, int recordNo2);
                /*0x754579c*/ object Get(int record);
                /*0x754581c*/ bool IsNull(int record);
                /*0x7545898*/ void Set(int record, object value);
                /*0x75458e0*/ void SetCapacity(int capacity);
                /*0x75459a0*/ object ConvertXmlToObject(string s);
                /*0x7545c88*/ string ConvertObjectToXml(object value);
                /*0x7545f28*/ object GetEmptyStorage(int recordCount);
                /*0x7545f70*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7546070*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ float[] _values;

                /*0x754610c*/ SingleStorage(System.Data.DataColumn column);
                /*0x75461d4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754690c*/ int Compare(int recordNo1, int recordNo2);
                /*0x7546990*/ int CompareValueTo(int recordNo, object value);
                /*0x7546a58*/ object ConvertValue(object value);
                /*0x7546b90*/ void Copy(int recordNo1, int recordNo2);
                /*0x7546be8*/ object Get(int record);
                /*0x7546c44*/ void Set(int record, object value);
                /*0x7546dbc*/ void SetCapacity(int capacity);
                /*0x7546e90*/ object ConvertXmlToObject(string s);
                /*0x7546f0c*/ string ConvertObjectToXml(object value);
                /*0x7546f98*/ object GetEmptyStorage(int recordCount);
                /*0x7546fe0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x75470e0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlUdtStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, object> s_typeToNull;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;
                /*0x59*/ bool _implementsIComparable;

                static /*0x754882c*/ SqlUdtStorage();
                static /*0x754721c*/ object GetStaticNullForUdtType(System.Type type);
                /*0x75471a4*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type);
                /*0x7547330*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type, object nullValue);
                /*0x75474b4*/ bool IsNull(int record);
                /*0x75475b8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x75475e8*/ int Compare(int recordNo1, int recordNo2);
                /*0x7547620*/ int CompareValueTo(int recordNo1, object value);
                /*0x75478ac*/ void Copy(int recordNo1, int recordNo2);
                /*0x7547934*/ object Get(int recordNo);
                /*0x7547964*/ void Set(int recordNo, object value);
                /*0x7547ad4*/ void SetCapacity(int capacity);
                /*0x7547ba8*/ object ConvertXmlToObject(string s);
                /*0x7547ef4*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x7548184*/ string ConvertObjectToXml(object value);
                /*0x75484b0*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x7548608*/ object GetEmptyStorage(int recordCount);
                /*0x7548650*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x7548790*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Type type;

                    /*0x75474ac*/ <>c__DisplayClass6_0();
                    /*0x75488c4*/ object <GetStaticNullForUdtType>b__0(System.Type t);
                }
            }

            class StringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ string[] _values;

                /*0x75489ec*/ StringStorage(System.Data.DataColumn column);
                /*0x7548aa0*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x7548d6c*/ int Compare(int recordNo1, int recordNo2);
                /*0x7548de4*/ int CompareValueTo(int recordNo, object value);
                /*0x7548e70*/ object ConvertValue(object value);
                /*0x7548ea0*/ void Copy(int recordNo1, int recordNo2);
                /*0x7548ee0*/ object Get(int recordNo);
                /*0x7548f1c*/ int GetStringLength(int record);
                /*0x7548f5c*/ bool IsNull(int record);
                /*0x7548f94*/ void Set(int record, object value);
                /*0x7549014*/ void SetCapacity(int capacity);
                /*0x75490d4*/ object ConvertXmlToObject(string s);
                /*0x75490dc*/ string ConvertObjectToXml(object value);
                /*0x754910c*/ object GetEmptyStorage(int recordCount);
                /*0x7549154*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754925c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class TimeSpanStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.TimeSpan s_defaultValue;
                /*0x50*/ System.TimeSpan[] _values;

                static /*0x754abd0*/ TimeSpanStorage();
                static /*0x754a340*/ System.TimeSpan ConvertToTimeSpan(object value);
                /*0x75492f8*/ TimeSpanStorage(System.Data.DataColumn column);
                /*0x7549418*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754a050*/ int Compare(int recordNo1, int recordNo2);
                /*0x754a1cc*/ int CompareValueTo(int recordNo, object value);
                /*0x754a4f4*/ object ConvertValue(object value);
                /*0x754a5a0*/ void Copy(int recordNo1, int recordNo2);
                /*0x754a5f8*/ object Get(int record);
                /*0x754a6f8*/ void Set(int record, object value);
                /*0x754a7cc*/ void SetCapacity(int capacity);
                /*0x754a8a0*/ object ConvertXmlToObject(string s);
                /*0x754a92c*/ string ConvertObjectToXml(object value);
                /*0x754a9c4*/ object GetEmptyStorage(int recordCount);
                /*0x754aa0c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754ab0c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt16Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ushort s_defaultValue;
                /*0x50*/ ushort[] _values;

                /*0x754ac48*/ UInt16Storage(System.Data.DataColumn column);
                /*0x754ad30*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754b554*/ int Compare(int recordNo1, int recordNo2);
                /*0x754b610*/ int CompareValueTo(int recordNo, object value);
                /*0x754b720*/ object ConvertValue(object value);
                /*0x754b85c*/ void Copy(int recordNo1, int recordNo2);
                /*0x754b8b4*/ object Get(int record);
                /*0x754b978*/ void Set(int record, object value);
                /*0x754bb10*/ void SetCapacity(int capacity);
                /*0x754bbe4*/ object ConvertXmlToObject(string s);
                /*0x754bc64*/ string ConvertObjectToXml(object value);
                /*0x754bcf0*/ object GetEmptyStorage(int recordCount);
                /*0x754bd38*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754be38*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt32Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ uint s_defaultValue;
                /*0x50*/ uint[] _values;

                /*0x754befc*/ UInt32Storage(System.Data.DataColumn column);
                /*0x754bfe4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754c80c*/ int Compare(int recordNo1, int recordNo2);
                /*0x754c8d8*/ int CompareValueTo(int recordNo, object value);
                /*0x754c9e8*/ object ConvertValue(object value);
                /*0x754cb24*/ void Copy(int recordNo1, int recordNo2);
                /*0x754cb7c*/ object Get(int record);
                /*0x754cc40*/ void Set(int record, object value);
                /*0x754cdd8*/ void SetCapacity(int capacity);
                /*0x754ceac*/ object ConvertXmlToObject(string s);
                /*0x754cf2c*/ string ConvertObjectToXml(object value);
                /*0x754cfb8*/ object GetEmptyStorage(int recordCount);
                /*0x754d000*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754d100*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt64Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ulong s_defaultValue;
                /*0x50*/ ulong[] _values;

                /*0x754d1c4*/ UInt64Storage(System.Data.DataColumn column);
                /*0x754d2ac*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x754dad8*/ int Compare(int recordNo1, int recordNo2);
                /*0x754dbe0*/ int CompareValueTo(int recordNo, object value);
                /*0x754dcf0*/ object ConvertValue(object value);
                /*0x754de2c*/ void Copy(int recordNo1, int recordNo2);
                /*0x754de84*/ object Get(int record);
                /*0x754df48*/ void Set(int record, object value);
                /*0x754e0e0*/ void SetCapacity(int capacity);
                /*0x754e1b4*/ object ConvertXmlToObject(string s);
                /*0x754e234*/ string ConvertObjectToXml(object value);
                /*0x754e2c0*/ object GetEmptyStorage(int recordCount);
                /*0x754e308*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x754e408*/ void SetStorage(object store, System.Collections.BitArray nullbits);
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
