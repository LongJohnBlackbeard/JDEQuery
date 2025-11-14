using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6008 - .
/// </summary>
public class F76H6008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPH76LECO.
        /// </summary>
        public const string IPH76LECO = "IPH76LECO";

        /// <summary>
        /// IPCFY.
        /// </summary>
        public const string IPCFY = "IPCFY";

        /// <summary>
        /// IPFFP.
        /// </summary>
        public const string IPFFP = "IPFFP";

        /// <summary>
        /// IPITM.
        /// </summary>
        public const string IPITM = "IPITM";

        /// <summary>
        /// IPMCU.
        /// </summary>
        public const string IPMCU = "IPMCU";

        /// <summary>
        /// IPLOCN.
        /// </summary>
        public const string IPLOCN = "IPLOCN";

        /// <summary>
        /// IPLOTN.
        /// </summary>
        public const string IPLOTN = "IPLOTN";

        /// <summary>
        /// IPSOQS.
        /// </summary>
        public const string IPSOQS = "IPSOQS";

        /// <summary>
        /// IPUOM1.
        /// </summary>
        public const string IPUOM1 = "IPUOM1";

        /// <summary>
        /// IPH76IBLO.
        /// </summary>
        public const string IPH76IBLO = "IPH76IBLO";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPUPMT.
        /// </summary>
        public const string IPUPMT = "IPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPH76LECO", "IPH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("IPCFY", "IPCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("IPFFP", "IPFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("IPITM", "IPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IPMCU", "IPMCU", JdeDataType.String, 24, true, true),
        new JdeField("IPLOCN", "IPLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IPLOTN", "IPLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IPSOQS", "IPSOQS", JdeDataType.Numeric),
        new JdeField("IPUOM1", "IPUOM1", JdeDataType.String, 4),
        new JdeField("IPH76IBLO", "IPH76IBLO", JdeDataType.String, 2),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6008_0", "Primary Key on IPH76LECO, IPCFY, IPFFP, IPITM, IPMCU, IPLOCN, IPLOTN", new[] { "IPH76LECO", "IPCFY", "IPFFP", "IPITM", "IPMCU", "IPLOCN", "IPLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
