using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3405 - .
/// </summary>
public class F3405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MUPETY.
        /// </summary>
        public const string MUPETY = "MUPETY";

        /// <summary>
        /// MUENDD.
        /// </summary>
        public const string MUENDD = "MUENDD";

        /// <summary>
        /// MUUPMJ.
        /// </summary>
        public const string MUUPMJ = "MUUPMJ";

        /// <summary>
        /// MUUSER.
        /// </summary>
        public const string MUUSER = "MUUSER";

        /// <summary>
        /// MUJOBN.
        /// </summary>
        public const string MUJOBN = "MUJOBN";

        /// <summary>
        /// MUPID.
        /// </summary>
        public const string MUPID = "MUPID";

        /// <summary>
        /// MUTDAY.
        /// </summary>
        public const string MUTDAY = "MUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MUPETY", "MUPETY", JdeDataType.String, 4),
        new JdeField("MUENDD", "MUENDD", JdeDataType.Numeric, null, true, true),
        new JdeField("MUUPMJ", "MUUPMJ", JdeDataType.Numeric),
        new JdeField("MUUSER", "MUUSER", JdeDataType.String, 20),
        new JdeField("MUJOBN", "MUJOBN", JdeDataType.String, 20),
        new JdeField("MUPID", "MUPID", JdeDataType.String, 20),
        new JdeField("MUTDAY", "MUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3405_0", "Primary Key on MUENDD", new[] { "MUENDD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3405_2", "Unique Index on SYS_NC00008$", new[] { "SYS_NC00008$" }, isUnique: true)
    };
}
