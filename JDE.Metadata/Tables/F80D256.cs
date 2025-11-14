using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D256 - .
/// </summary>
public class F80D256 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPPRDJ.
        /// </summary>
        public const string VPPRDJ = "VPPRDJ";

        /// <summary>
        /// VPMCU.
        /// </summary>
        public const string VPMCU = "VPMCU";

        /// <summary>
        /// VPAVPL.
        /// </summary>
        public const string VPAVPL = "VPAVPL";

        /// <summary>
        /// VPCVPL.
        /// </summary>
        public const string VPCVPL = "VPCVPL";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPMKEY.
        /// </summary>
        public const string VPMKEY = "VPMKEY";

        /// <summary>
        /// VPUTIME.
        /// </summary>
        public const string VPUTIME = "VPUTIME";

        /// <summary>
        /// VPURCD.
        /// </summary>
        public const string VPURCD = "VPURCD";

        /// <summary>
        /// VPURDT.
        /// </summary>
        public const string VPURDT = "VPURDT";

        /// <summary>
        /// VPURAT.
        /// </summary>
        public const string VPURAT = "VPURAT";

        /// <summary>
        /// VPURAB.
        /// </summary>
        public const string VPURAB = "VPURAB";

        /// <summary>
        /// VPURRF.
        /// </summary>
        public const string VPURRF = "VPURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D256";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPPRDJ", "VPPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VPMCU", "VPMCU", JdeDataType.String, 24, true, true),
        new JdeField("VPAVPL", "VPAVPL", JdeDataType.Numeric),
        new JdeField("VPCVPL", "VPCVPL", JdeDataType.Numeric),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPMKEY", "VPMKEY", JdeDataType.String, 30),
        new JdeField("VPUTIME", "VPUTIME", JdeDataType.Date),
        new JdeField("VPURCD", "VPURCD", JdeDataType.String, 4),
        new JdeField("VPURDT", "VPURDT", JdeDataType.Numeric),
        new JdeField("VPURAT", "VPURAT", JdeDataType.Numeric),
        new JdeField("VPURAB", "VPURAB", JdeDataType.Numeric),
        new JdeField("VPURRF", "VPURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D256_0", "Primary Key on VPPRDJ, VPMCU", new[] { "VPPRDJ", "VPMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
