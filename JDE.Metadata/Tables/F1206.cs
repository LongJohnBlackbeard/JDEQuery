using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1206 - .
/// </summary>
public class F1206 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHNUMB.
        /// </summary>
        public const string FHNUMB = "FHNUMB";

        /// <summary>
        /// FHLNUM.
        /// </summary>
        public const string FHLNUM = "FHLNUM";

        /// <summary>
        /// FHADDS.
        /// </summary>
        public const string FHADDS = "FHADDS";

        /// <summary>
        /// FHLAGY.
        /// </summary>
        public const string FHLAGY = "FHLAGY";

        /// <summary>
        /// FHLIS.
        /// </summary>
        public const string FHLIS = "FHLIS";

        /// <summary>
        /// FHLFE.
        /// </summary>
        public const string FHLFE = "FHLFE";

        /// <summary>
        /// FHLCT.
        /// </summary>
        public const string FHLCT = "FHLCT";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHLRJ.
        /// </summary>
        public const string FHLRJ = "FHLRJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1206";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHNUMB", "FHNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FHLNUM", "FHLNUM", JdeDataType.String, 16, true, true),
        new JdeField("FHADDS", "FHADDS", JdeDataType.String, 6, true, true),
        new JdeField("FHLAGY", "FHLAGY", JdeDataType.Numeric),
        new JdeField("FHLIS", "FHLIS", JdeDataType.Numeric),
        new JdeField("FHLFE", "FHLFE", JdeDataType.Numeric),
        new JdeField("FHLCT", "FHLCT", JdeDataType.Numeric),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHLRJ", "FHLRJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1206_0", "Primary Key on FHNUMB, FHADDS, FHLNUM", new[] { "FHNUMB", "FHADDS", "FHLNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
