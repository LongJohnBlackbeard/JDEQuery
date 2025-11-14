using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D110 - .
/// </summary>
public class F80D110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SQSSBID.
        /// </summary>
        public const string SQSSBID = "SQSSBID";

        /// <summary>
        /// SQCO.
        /// </summary>
        public const string SQCO = "SQCO";

        /// <summary>
        /// SQBLISTID.
        /// </summary>
        public const string SQBLISTID = "SQBLISTID";

        /// <summary>
        /// SQPLISTID.
        /// </summary>
        public const string SQPLISTID = "SQPLISTID";

        /// <summary>
        /// SQALISTID.
        /// </summary>
        public const string SQALISTID = "SQALISTID";

        /// <summary>
        /// SQBDOWLD.
        /// </summary>
        public const string SQBDOWLD = "SQBDOWLD";

        /// <summary>
        /// SQDATEFT.
        /// </summary>
        public const string SQDATEFT = "SQDATEFT";

        /// <summary>
        /// SQCDR.
        /// </summary>
        public const string SQCDR = "SQCDR";

        /// <summary>
        /// SQBODO.
        /// </summary>
        public const string SQBODO = "SQBODO";

        /// <summary>
        /// SQODA.
        /// </summary>
        public const string SQODA = "SQODA";

        /// <summary>
        /// SQURCD.
        /// </summary>
        public const string SQURCD = "SQURCD";

        /// <summary>
        /// SQURDT.
        /// </summary>
        public const string SQURDT = "SQURDT";

        /// <summary>
        /// SQURAT.
        /// </summary>
        public const string SQURAT = "SQURAT";

        /// <summary>
        /// SQURAB.
        /// </summary>
        public const string SQURAB = "SQURAB";

        /// <summary>
        /// SQURRF.
        /// </summary>
        public const string SQURRF = "SQURRF";

        /// <summary>
        /// SQUSER.
        /// </summary>
        public const string SQUSER = "SQUSER";

        /// <summary>
        /// SQMKEY.
        /// </summary>
        public const string SQMKEY = "SQMKEY";

        /// <summary>
        /// SQPID.
        /// </summary>
        public const string SQPID = "SQPID";

        /// <summary>
        /// SQUUPMJ.
        /// </summary>
        public const string SQUUPMJ = "SQUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SQSSBID", "SQSSBID", JdeDataType.String, 16, true, true),
        new JdeField("SQCO", "SQCO", JdeDataType.String, 10),
        new JdeField("SQBLISTID", "SQBLISTID", JdeDataType.String, 24),
        new JdeField("SQPLISTID", "SQPLISTID", JdeDataType.String, 24),
        new JdeField("SQALISTID", "SQALISTID", JdeDataType.String, 24),
        new JdeField("SQBDOWLD", "SQBDOWLD", JdeDataType.Numeric),
        new JdeField("SQDATEFT", "SQDATEFT", JdeDataType.Numeric),
        new JdeField("SQCDR", "SQCDR", JdeDataType.Numeric),
        new JdeField("SQBODO", "SQBODO", JdeDataType.Numeric),
        new JdeField("SQODA", "SQODA", JdeDataType.Numeric),
        new JdeField("SQURCD", "SQURCD", JdeDataType.String, 4),
        new JdeField("SQURDT", "SQURDT", JdeDataType.Numeric),
        new JdeField("SQURAT", "SQURAT", JdeDataType.Numeric),
        new JdeField("SQURAB", "SQURAB", JdeDataType.Numeric),
        new JdeField("SQURRF", "SQURRF", JdeDataType.String, 30),
        new JdeField("SQUSER", "SQUSER", JdeDataType.String, 20),
        new JdeField("SQMKEY", "SQMKEY", JdeDataType.String, 30),
        new JdeField("SQPID", "SQPID", JdeDataType.String, 20),
        new JdeField("SQUUPMJ", "SQUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D110_0", "Primary Key on SQSSBID", new[] { "SQSSBID" }, isUnique: true, isPrimaryKey: true)
    };
}
