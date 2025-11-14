using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31PUI01 - .
/// </summary>
public class F31PUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEDOCO.
        /// </summary>
        public const string SEDOCO = "SEDOCO";

        /// <summary>
        /// SESTRT.
        /// </summary>
        public const string SESTRT = "SESTRT";

        /// <summary>
        /// SEDRQJ.
        /// </summary>
        public const string SEDRQJ = "SEDRQJ";

        /// <summary>
        /// SELTLV.
        /// </summary>
        public const string SELTLV = "SELTLV";

        /// <summary>
        /// SEDL01.
        /// </summary>
        public const string SEDL01 = "SEDL01";

        /// <summary>
        /// SEDCTO.
        /// </summary>
        public const string SEDCTO = "SEDCTO";

        /// <summary>
        /// SESEQN.
        /// </summary>
        public const string SESEQN = "SESEQN";

        /// <summary>
        /// SEPRJM.
        /// </summary>
        public const string SEPRJM = "SEPRJM";

        /// <summary>
        /// SETSKTP.
        /// </summary>
        public const string SETSKTP = "SETSKTP";

        /// <summary>
        /// SEDS80.
        /// </summary>
        public const string SEDS80 = "SEDS80";

        /// <summary>
        /// SEUNCD.
        /// </summary>
        public const string SEUNCD = "SEUNCD";
    }

    /// <inheritdoc />
    public override string TableName => "F31PUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEDOCO", "SEDOCO", JdeDataType.Numeric),
        new JdeField("SESTRT", "SESTRT", JdeDataType.Numeric),
        new JdeField("SEDRQJ", "SEDRQJ", JdeDataType.Numeric),
        new JdeField("SELTLV", "SELTLV", JdeDataType.Numeric),
        new JdeField("SEDL01", "SEDL01", JdeDataType.String, 60),
        new JdeField("SEDCTO", "SEDCTO", JdeDataType.String, 4),
        new JdeField("SESEQN", "SESEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("SEPRJM", "SEPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("SETSKTP", "SETSKTP", JdeDataType.String, 2),
        new JdeField("SEDS80", "SEDS80", JdeDataType.String, 160),
        new JdeField("SEUNCD", "SEUNCD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31PUI01_0", "Primary Key on SEPRJM, SESEQN", new[] { "SEPRJM", "SESEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
