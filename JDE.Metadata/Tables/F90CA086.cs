using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA086 - .
/// </summary>
public class F90CA086 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCUAN8.
        /// </summary>
        public const string CRCUAN8 = "CRCUAN8";

        /// <summary>
        /// CRCRAN8.
        /// </summary>
        public const string CRCRAN8 = "CRCRAN8";

        /// <summary>
        /// CRVCRA.
        /// </summary>
        public const string CRVCRA = "CRVCRA";

        /// <summary>
        /// CREDATE.
        /// </summary>
        public const string CREDATE = "CREDATE";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRUDTTM.
        /// </summary>
        public const string CRUDTTM = "CRUDTTM";

        /// <summary>
        /// CRMKEY.
        /// </summary>
        public const string CRMKEY = "CRMKEY";

        /// <summary>
        /// CRENTDBY.
        /// </summary>
        public const string CRENTDBY = "CRENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA086";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCUAN8", "CRCUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CRCRAN8", "CRCRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CRVCRA", "CRVCRA", JdeDataType.Numeric),
        new JdeField("CREDATE", "CREDATE", JdeDataType.Date),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRUDTTM", "CRUDTTM", JdeDataType.Date),
        new JdeField("CRMKEY", "CRMKEY", JdeDataType.String, 30),
        new JdeField("CRENTDBY", "CRENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA086_0", "Primary Key on CRCUAN8, CRCRAN8", new[] { "CRCUAN8", "CRCRAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA086_2", "Index on CRCRAN8, CRCUAN8", new[] { "CRCRAN8", "CRCUAN8" }),
        new JdeIndex("F90CA086_3", "Index on CRVCRA", new[] { "CRVCRA" })
    };
}
