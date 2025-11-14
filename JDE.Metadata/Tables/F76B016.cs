using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B016 - .
/// </summary>
public class F76B016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDB76IDOC.
        /// </summary>
        public const string IDB76IDOC = "IDB76IDOC";

        /// <summary>
        /// IDB76IDCT.
        /// </summary>
        public const string IDB76IDCT = "IDB76IDCT";

        /// <summary>
        /// IDB76IREJ.
        /// </summary>
        public const string IDB76IREJ = "IDB76IREJ";

        /// <summary>
        /// IDB76IPLD.
        /// </summary>
        public const string IDB76IPLD = "IDB76IPLD";

        /// <summary>
        /// IDB76ISCC.
        /// </summary>
        public const string IDB76ISCC = "IDB76ISCC";

        /// <summary>
        /// IDB76ICCJ.
        /// </summary>
        public const string IDB76ICCJ = "IDB76ICCJ";

        /// <summary>
        /// IDB76IEXC.
        /// </summary>
        public const string IDB76IEXC = "IDB76IEXC";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDJOBN.
        /// </summary>
        public const string IDJOBN = "IDJOBN";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDUPMT.
        /// </summary>
        public const string IDUPMT = "IDUPMT";

        /// <summary>
        /// IDB76MOD.
        /// </summary>
        public const string IDB76MOD = "IDB76MOD";

        /// <summary>
        /// IDB76AFRM.
        /// </summary>
        public const string IDB76AFRM = "IDB76AFRM";

        /// <summary>
        /// IDB76IPM.
        /// </summary>
        public const string IDB76IPM = "IDB76IPM";

        /// <summary>
        /// IDB76AUTH.
        /// </summary>
        public const string IDB76AUTH = "IDB76AUTH";

        /// <summary>
        /// IDCRCD.
        /// </summary>
        public const string IDCRCD = "IDCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F76B016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDB76IDOC", "IDB76IDOC", JdeDataType.String, 20, true, true),
        new JdeField("IDB76IDCT", "IDB76IDCT", JdeDataType.String, 6, true, true),
        new JdeField("IDB76IREJ", "IDB76IREJ", JdeDataType.Numeric),
        new JdeField("IDB76IPLD", "IDB76IPLD", JdeDataType.String, 6),
        new JdeField("IDB76ISCC", "IDB76ISCC", JdeDataType.String, 6),
        new JdeField("IDB76ICCJ", "IDB76ICCJ", JdeDataType.Numeric),
        new JdeField("IDB76IEXC", "IDB76IEXC", JdeDataType.String, 6),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDJOBN", "IDJOBN", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDUPMT", "IDUPMT", JdeDataType.Numeric),
        new JdeField("IDB76MOD", "IDB76MOD", JdeDataType.String, 4),
        new JdeField("IDB76AFRM", "IDB76AFRM", JdeDataType.Numeric),
        new JdeField("IDB76IPM", "IDB76IPM", JdeDataType.String, 2),
        new JdeField("IDB76AUTH", "IDB76AUTH", JdeDataType.Numeric),
        new JdeField("IDCRCD", "IDCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B016_0", "Primary Key on IDB76IDOC, IDB76IDCT", new[] { "IDB76IDOC", "IDB76IDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
