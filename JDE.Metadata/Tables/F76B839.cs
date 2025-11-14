using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B839 - .
/// </summary>
public class F76B839 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPJOBS.
        /// </summary>
        public const string JPJOBS = "JPJOBS";

        /// <summary>
        /// JPPQTR.
        /// </summary>
        public const string JPPQTR = "JPPQTR";

        /// <summary>
        /// JPEFTB.
        /// </summary>
        public const string JPEFTB = "JPEFTB";

        /// <summary>
        /// JPEFTE.
        /// </summary>
        public const string JPEFTE = "JPEFTE";

        /// <summary>
        /// JPUSER.
        /// </summary>
        public const string JPUSER = "JPUSER";

        /// <summary>
        /// JPPID.
        /// </summary>
        public const string JPPID = "JPPID";

        /// <summary>
        /// JPJOBN.
        /// </summary>
        public const string JPJOBN = "JPJOBN";

        /// <summary>
        /// JPUPMJ.
        /// </summary>
        public const string JPUPMJ = "JPUPMJ";

        /// <summary>
        /// JPUPMT.
        /// </summary>
        public const string JPUPMT = "JPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B839";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPJOBS", "JPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JPPQTR", "JPPQTR", JdeDataType.String, 2, true, true),
        new JdeField("JPEFTB", "JPEFTB", JdeDataType.Numeric),
        new JdeField("JPEFTE", "JPEFTE", JdeDataType.Numeric),
        new JdeField("JPUSER", "JPUSER", JdeDataType.String, 20),
        new JdeField("JPPID", "JPPID", JdeDataType.String, 20),
        new JdeField("JPJOBN", "JPJOBN", JdeDataType.String, 20),
        new JdeField("JPUPMJ", "JPUPMJ", JdeDataType.Numeric),
        new JdeField("JPUPMT", "JPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B839_0", "Primary Key on JPJOBS, JPPQTR", new[] { "JPJOBS", "JPPQTR" }, isUnique: true, isPrimaryKey: true)
    };
}
