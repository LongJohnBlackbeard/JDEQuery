using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069076 - .
/// </summary>
public class F069076 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YFTBEX.
        /// </summary>
        public const string YFTBEX = "YFTBEX";

        /// <summary>
        /// YFPPYF.
        /// </summary>
        public const string YFPPYF = "YFPPYF";

        /// <summary>
        /// YFPPYT.
        /// </summary>
        public const string YFPPYT = "YFPPYT";

        /// <summary>
        /// YFPPT.
        /// </summary>
        public const string YFPPT = "YFPPT";

        /// <summary>
        /// YFUSER.
        /// </summary>
        public const string YFUSER = "YFUSER";

        /// <summary>
        /// YFPID.
        /// </summary>
        public const string YFPID = "YFPID";

        /// <summary>
        /// YFUPMJ.
        /// </summary>
        public const string YFUPMJ = "YFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F069076";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YFTBEX", "YFTBEX", JdeDataType.String, 6, true, true),
        new JdeField("YFPPYF", "YFPPYF", JdeDataType.Numeric),
        new JdeField("YFPPYT", "YFPPYT", JdeDataType.Numeric, null, true, true),
        new JdeField("YFPPT", "YFPPT", JdeDataType.String, 2),
        new JdeField("YFUSER", "YFUSER", JdeDataType.String, 20),
        new JdeField("YFPID", "YFPID", JdeDataType.String, 20),
        new JdeField("YFUPMJ", "YFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069076_0", "Primary Key on YFTBEX, YFPPYT", new[] { "YFTBEX", "YFPPYT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069076_2", "Index on YFTBEX, YFPPYF", new[] { "YFTBEX", "YFPPYF" })
    };
}
