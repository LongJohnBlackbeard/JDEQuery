using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X100W - .
/// </summary>
public class F34X100W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSJOBS.
        /// </summary>
        public const string MSJOBS = "MSJOBS";

        /// <summary>
        /// MS34XMGP.
        /// </summary>
        public const string MS34XMGP = "MS34XMGP";

        /// <summary>
        /// MSMSGT.
        /// </summary>
        public const string MSMSGT = "MSMSGT";

        /// <summary>
        /// MS34XMTD.
        /// </summary>
        public const string MS34XMTD = "MS34XMTD";

        /// <summary>
        /// MS34XMTC.
        /// </summary>
        public const string MS34XMTC = "MS34XMTC";

        /// <summary>
        /// MS34XMTN.
        /// </summary>
        public const string MS34XMTN = "MS34XMTN";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MS34XLATN.
        /// </summary>
        public const string MS34XLATN = "MS34XLATN";
    }

    /// <inheritdoc />
    public override string TableName => "F34X100W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20, true, true),
        new JdeField("MSJOBS", "MSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("MS34XMGP", "MS34XMGP", JdeDataType.Numeric, null, true, true),
        new JdeField("MSMSGT", "MSMSGT", JdeDataType.String, 2),
        new JdeField("MS34XMTD", "MS34XMTD", JdeDataType.String, 60),
        new JdeField("MS34XMTC", "MS34XMTC", JdeDataType.Numeric),
        new JdeField("MS34XMTN", "MS34XMTN", JdeDataType.Numeric),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MS34XLATN", "MS34XLATN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X100W_0", "Primary Key on MSUSER, MSJOBS, MS34XMGP", new[] { "MSUSER", "MSJOBS", "MS34XMGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X100W_2", "Index on MSUSER, MSJOBS, MSUPMJ", new[] { "MSUSER", "MSJOBS", "MSUPMJ" }),
        new JdeIndex("F34X100W_3", "Index on MSUSER, MSJOBS, MSMSGT", new[] { "MSUSER", "MSJOBS", "MSMSGT" })
    };
}
