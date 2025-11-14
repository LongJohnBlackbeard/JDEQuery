using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B021 - .
/// </summary>
public class F76B021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XIBNOP.
        /// </summary>
        public const string XIBNOP = "XIBNOP";

        /// <summary>
        /// XIBSOP.
        /// </summary>
        public const string XIBSOP = "XIBSOP";

        /// <summary>
        /// XIB76IPIF.
        /// </summary>
        public const string XIB76IPIF = "XIB76IPIF";

        /// <summary>
        /// XIB76TSIPI.
        /// </summary>
        public const string XIB76TSIPI = "XIB76TSIPI";

        /// <summary>
        /// XIUSER.
        /// </summary>
        public const string XIUSER = "XIUSER";

        /// <summary>
        /// XIPID.
        /// </summary>
        public const string XIPID = "XIPID";

        /// <summary>
        /// XIJOBN.
        /// </summary>
        public const string XIJOBN = "XIJOBN";

        /// <summary>
        /// XIUPMJ.
        /// </summary>
        public const string XIUPMJ = "XIUPMJ";

        /// <summary>
        /// XITDAY.
        /// </summary>
        public const string XITDAY = "XITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XIBNOP", "XIBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("XIBSOP", "XIBSOP", JdeDataType.String, 4, true, true),
        new JdeField("XIB76IPIF", "XIB76IPIF", JdeDataType.String, 2),
        new JdeField("XIB76TSIPI", "XIB76TSIPI", JdeDataType.String, 6),
        new JdeField("XIUSER", "XIUSER", JdeDataType.String, 20),
        new JdeField("XIPID", "XIPID", JdeDataType.String, 20),
        new JdeField("XIJOBN", "XIJOBN", JdeDataType.String, 20),
        new JdeField("XIUPMJ", "XIUPMJ", JdeDataType.Numeric),
        new JdeField("XITDAY", "XITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B021_0", "Primary Key on XIBNOP, XIBSOP", new[] { "XIBNOP", "XIBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
