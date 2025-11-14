using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07991 - .
/// </summary>
public class F07991 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YXSSN.
        /// </summary>
        public const string YXSSN = "YXSSN";

        /// <summary>
        /// YXDOCM.
        /// </summary>
        public const string YXDOCM = "YXDOCM";

        /// <summary>
        /// YXUKID.
        /// </summary>
        public const string YXUKID = "YXUKID";

        /// <summary>
        /// YXPDBA.
        /// </summary>
        public const string YXPDBA = "YXPDBA";

        /// <summary>
        /// YXGPA.
        /// </summary>
        public const string YXGPA = "YXGPA";

        /// <summary>
        /// YXPSTF.
        /// </summary>
        public const string YXPSTF = "YXPSTF";

        /// <summary>
        /// YXUPMJ.
        /// </summary>
        public const string YXUPMJ = "YXUPMJ";

        /// <summary>
        /// YXUPMT.
        /// </summary>
        public const string YXUPMT = "YXUPMT";

        /// <summary>
        /// YXPID.
        /// </summary>
        public const string YXPID = "YXPID";

        /// <summary>
        /// YXJOBN.
        /// </summary>
        public const string YXJOBN = "YXJOBN";

        /// <summary>
        /// YXUSER.
        /// </summary>
        public const string YXUSER = "YXUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07991";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YXSSN", "YXSSN", JdeDataType.String, 40, true, true),
        new JdeField("YXDOCM", "YXDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("YXUKID", "YXUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("YXPDBA", "YXPDBA", JdeDataType.Numeric),
        new JdeField("YXGPA", "YXGPA", JdeDataType.Numeric),
        new JdeField("YXPSTF", "YXPSTF", JdeDataType.String, 2),
        new JdeField("YXUPMJ", "YXUPMJ", JdeDataType.Numeric),
        new JdeField("YXUPMT", "YXUPMT", JdeDataType.Numeric),
        new JdeField("YXPID", "YXPID", JdeDataType.String, 20),
        new JdeField("YXJOBN", "YXJOBN", JdeDataType.String, 20),
        new JdeField("YXUSER", "YXUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07991_0", "Primary Key on YXSSN, YXDOCM, YXUKID", new[] { "YXSSN", "YXDOCM", "YXUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
