using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F13907P - .
/// </summary>
public class F13907P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCNUMB.
        /// </summary>
        public const string FCNUMB = "FCNUMB";

        /// <summary>
        /// FCSHNO.
        /// </summary>
        public const string FCSHNO = "FCSHNO";

        /// <summary>
        /// FCSRVT.
        /// </summary>
        public const string FCSRVT = "FCSRVT";

        /// <summary>
        /// FCTHPC.
        /// </summary>
        public const string FCTHPC = "FCTHPC";

        /// <summary>
        /// FCTHD.
        /// </summary>
        public const string FCTHD = "FCTHD";

        /// <summary>
        /// FCSWO.
        /// </summary>
        public const string FCSWO = "FCSWO";

        /// <summary>
        /// FCSRST.
        /// </summary>
        public const string FCSRST = "FCSRST";
    }

    /// <inheritdoc />
    public override string TableName => "F13907P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCNUMB", "FCNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FCSHNO", "FCSHNO", JdeDataType.String, 20, true, true),
        new JdeField("FCSRVT", "FCSRVT", JdeDataType.String, 16, true, true),
        new JdeField("FCTHPC", "FCTHPC", JdeDataType.Numeric),
        new JdeField("FCTHD", "FCTHD", JdeDataType.Numeric),
        new JdeField("FCSWO", "FCSWO", JdeDataType.String, 2),
        new JdeField("FCSRST", "FCSRST", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F13907P_0", "Primary Key on FCNUMB, FCSHNO, FCSRVT", new[] { "FCNUMB", "FCSHNO", "FCSRVT" }, isUnique: true, isPrimaryKey: true)
    };
}
