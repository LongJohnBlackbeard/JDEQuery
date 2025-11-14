using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08464 - .
/// </summary>
public class F08464 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPWZSTP.
        /// </summary>
        public const string VPWZSTP = "VPWZSTP";

        /// <summary>
        /// VPDATAI.
        /// </summary>
        public const string VPDATAI = "VPDATAI";

        /// <summary>
        /// VPRECAPP.
        /// </summary>
        public const string VPRECAPP = "VPRECAPP";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPMKEY.
        /// </summary>
        public const string VPMKEY = "VPMKEY";

        /// <summary>
        /// VPUPMJ.
        /// </summary>
        public const string VPUPMJ = "VPUPMJ";

        /// <summary>
        /// VPUPMT.
        /// </summary>
        public const string VPUPMT = "VPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08464";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPWZSTP", "VPWZSTP", JdeDataType.String, 20, true, true),
        new JdeField("VPDATAI", "VPDATAI", JdeDataType.String, 20, true, true),
        new JdeField("VPRECAPP", "VPRECAPP", JdeDataType.String, 2, true, true),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPMKEY", "VPMKEY", JdeDataType.String, 30),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPUPMT", "VPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08464_0", "Primary Key on VPWZSTP, VPDATAI, VPRECAPP", new[] { "VPWZSTP", "VPDATAI", "VPRECAPP" }, isUnique: true, isPrimaryKey: true)
    };
}
