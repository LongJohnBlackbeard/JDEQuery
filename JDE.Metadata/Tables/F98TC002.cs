using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98TC002 - .
/// </summary>
public class F98TC002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNMCU.
        /// </summary>
        public const string TNMCU = "TNMCU";

        /// <summary>
        /// TNITM.
        /// </summary>
        public const string TNITM = "TNITM";

        /// <summary>
        /// TNTX.
        /// </summary>
        public const string TNTX = "TNTX";

        /// <summary>
        /// TNSRCE.
        /// </summary>
        public const string TNSRCE = "TNSRCE";

        /// <summary>
        /// TNANBY.
        /// </summary>
        public const string TNANBY = "TNANBY";

        /// <summary>
        /// TNSTKT.
        /// </summary>
        public const string TNSTKT = "TNSTKT";

        /// <summary>
        /// TNCMGL.
        /// </summary>
        public const string TNCMGL = "TNCMGL";
    }

    /// <inheritdoc />
    public override string TableName => "F98TC002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNMCU", "TNMCU", JdeDataType.String, 24, true, true),
        new JdeField("TNITM", "TNITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TNTX", "TNTX", JdeDataType.String, 2),
        new JdeField("TNSRCE", "TNSRCE", JdeDataType.String, 2),
        new JdeField("TNANBY", "TNANBY", JdeDataType.Numeric),
        new JdeField("TNSTKT", "TNSTKT", JdeDataType.String, 2),
        new JdeField("TNCMGL", "TNCMGL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98TC002_0", "Primary Key on TNMCU, TNITM", new[] { "TNMCU", "TNITM" }, isUnique: true, isPrimaryKey: true)
    };
}
