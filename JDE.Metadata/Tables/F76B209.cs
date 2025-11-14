using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B209 - .
/// </summary>
public class F76B209 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTB76MOTY.
        /// </summary>
        public const string CTB76MOTY = "CTB76MOTY";

        /// <summary>
        /// CTB76EMTYF.
        /// </summary>
        public const string CTB76EMTYF = "CTB76EMTYF";

        /// <summary>
        /// CTB76NFSTF.
        /// </summary>
        public const string CTB76NFSTF = "CTB76NFSTF";

        /// <summary>
        /// CTB76EMTYT.
        /// </summary>
        public const string CTB76EMTYT = "CTB76EMTYT";

        /// <summary>
        /// CTB76NFSTT.
        /// </summary>
        public const string CTB76NFSTT = "CTB76NFSTT";

        /// <summary>
        /// CTB76ENAB.
        /// </summary>
        public const string CTB76ENAB = "CTB76ENAB";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B209";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTB76MOTY", "CTB76MOTY", JdeDataType.String, 4, true, true),
        new JdeField("CTB76EMTYF", "CTB76EMTYF", JdeDataType.String, 2, true, true),
        new JdeField("CTB76NFSTF", "CTB76NFSTF", JdeDataType.String, 2, true, true),
        new JdeField("CTB76EMTYT", "CTB76EMTYT", JdeDataType.String, 2, true, true),
        new JdeField("CTB76NFSTT", "CTB76NFSTT", JdeDataType.String, 2, true, true),
        new JdeField("CTB76ENAB", "CTB76ENAB", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B209_0", "Primary Key on CTB76MOTY, CTB76EMTYF, CTB76NFSTF, CTB76EMTYT, CTB76NFSTT", new[] { "CTB76MOTY", "CTB76EMTYF", "CTB76NFSTF", "CTB76EMTYT", "CTB76NFSTT" }, isUnique: true, isPrimaryKey: true)
    };
}
