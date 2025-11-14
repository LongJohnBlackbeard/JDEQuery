using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L4008 - .
/// </summary>
public class F74L4008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKTXA1.
        /// </summary>
        public const string TKTXA1 = "TKTXA1";

        /// <summary>
        /// TKEFDJ.
        /// </summary>
        public const string TKEFDJ = "TKEFDJ";

        /// <summary>
        /// TKITM.
        /// </summary>
        public const string TKITM = "TKITM";

        /// <summary>
        /// TKL74TT.
        /// </summary>
        public const string TKL74TT = "TKL74TT";

        /// <summary>
        /// TKL74TR.
        /// </summary>
        public const string TKL74TR = "TKL74TR";

        /// <summary>
        /// TKL74STAM.
        /// </summary>
        public const string TKL74STAM = "TKL74STAM";

        /// <summary>
        /// TKL74TC.
        /// </summary>
        public const string TKL74TC = "TKL74TC";

        /// <summary>
        /// TKL74TE.
        /// </summary>
        public const string TKL74TE = "TKL74TE";

        /// <summary>
        /// TKL74TER.
        /// </summary>
        public const string TKL74TER = "TKL74TER";

        /// <summary>
        /// TKTORG.
        /// </summary>
        public const string TKTORG = "TKTORG";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74L4008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKTXA1", "TKTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TKEFDJ", "TKEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TKITM", "TKITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TKL74TT", "TKL74TT", JdeDataType.String, 6),
        new JdeField("TKL74TR", "TKL74TR", JdeDataType.String, 10),
        new JdeField("TKL74STAM", "TKL74STAM", JdeDataType.Numeric),
        new JdeField("TKL74TC", "TKL74TC", JdeDataType.String, 6),
        new JdeField("TKL74TE", "TKL74TE", JdeDataType.String, 2),
        new JdeField("TKL74TER", "TKL74TER", JdeDataType.String, 4),
        new JdeField("TKTORG", "TKTORG", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L4008_0", "Primary Key on TKTXA1, TKEFDJ, TKITM", new[] { "TKTXA1", "TKEFDJ", "TKITM" }, isUnique: true, isPrimaryKey: true)
    };
}
