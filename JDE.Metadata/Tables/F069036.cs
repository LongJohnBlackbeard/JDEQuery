using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069036 - .
/// </summary>
public class F069036 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YXPDBA.
        /// </summary>
        public const string YXPDBA = "YXPDBA";

        /// <summary>
        /// YXPPYF.
        /// </summary>
        public const string YXPPYF = "YXPPYF";

        /// <summary>
        /// YXPPYT.
        /// </summary>
        public const string YXPPYT = "YXPPYT";

        /// <summary>
        /// YXUSER.
        /// </summary>
        public const string YXUSER = "YXUSER";

        /// <summary>
        /// YXPID.
        /// </summary>
        public const string YXPID = "YXPID";

        /// <summary>
        /// YXUPMJ.
        /// </summary>
        public const string YXUPMJ = "YXUPMJ";

        /// <summary>
        /// YXXTYP.
        /// </summary>
        public const string YXXTYP = "YXXTYP";
    }

    /// <inheritdoc />
    public override string TableName => "F069036";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YXPDBA", "YXPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YXPPYF", "YXPPYF", JdeDataType.Numeric),
        new JdeField("YXPPYT", "YXPPYT", JdeDataType.Numeric, null, true, true),
        new JdeField("YXUSER", "YXUSER", JdeDataType.String, 20),
        new JdeField("YXPID", "YXPID", JdeDataType.String, 20),
        new JdeField("YXUPMJ", "YXUPMJ", JdeDataType.Numeric),
        new JdeField("YXXTYP", "YXXTYP", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069036_0", "Primary Key on YXXTYP, YXPDBA, YXPPYT", new[] { "YXXTYP", "YXPDBA", "YXPPYT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069036_2", "Index on YXXTYP, YXPPYF", new[] { "YXXTYP", "YXPPYF" })
    };
}
