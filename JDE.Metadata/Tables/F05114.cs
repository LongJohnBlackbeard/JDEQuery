using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05114 - .
/// </summary>
public class F05114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTRRTY.
        /// </summary>
        public const string CTRRTY = "CTRRTY";

        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTCMPC.
        /// </summary>
        public const string CTCMPC = "CTCMPC";

        /// <summary>
        /// CTSEQ.
        /// </summary>
        public const string CTSEQ = "CTSEQ";

        /// <summary>
        /// CTLICB.
        /// </summary>
        public const string CTLICB = "CTLICB";

        /// <summary>
        /// CTLICN.
        /// </summary>
        public const string CTLICN = "CTLICN";

        /// <summary>
        /// CTISSD.
        /// </summary>
        public const string CTISSD = "CTISSD";

        /// <summary>
        /// CTEXDE.
        /// </summary>
        public const string CTEXDE = "CTEXDE";

        /// <summary>
        /// CTVRBY.
        /// </summary>
        public const string CTVRBY = "CTVRBY";

        /// <summary>
        /// CTSCRR.
        /// </summary>
        public const string CTSCRR = "CTSCRR";

        /// <summary>
        /// CTVRMT.
        /// </summary>
        public const string CTVRMT = "CTVRMT";

        /// <summary>
        /// CTRENC.
        /// </summary>
        public const string CTRENC = "CTRENC";

        /// <summary>
        /// CTCUCT.
        /// </summary>
        public const string CTCUCT = "CTCUCT";

        /// <summary>
        /// CTSTA.
        /// </summary>
        public const string CTSTA = "CTSTA";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTRRTY", "CTRRTY", JdeDataType.String, 4, true, true),
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCMPC", "CTCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CTSEQ", "CTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTLICB", "CTLICB", JdeDataType.String, 20),
        new JdeField("CTLICN", "CTLICN", JdeDataType.String, 60),
        new JdeField("CTISSD", "CTISSD", JdeDataType.Numeric),
        new JdeField("CTEXDE", "CTEXDE", JdeDataType.Numeric),
        new JdeField("CTVRBY", "CTVRBY", JdeDataType.String, 16),
        new JdeField("CTSCRR", "CTSCRR", JdeDataType.String, 20),
        new JdeField("CTVRMT", "CTVRMT", JdeDataType.String, 20),
        new JdeField("CTRENC", "CTRENC", JdeDataType.String, 20),
        new JdeField("CTCUCT", "CTCUCT", JdeDataType.Numeric),
        new JdeField("CTSTA", "CTSTA", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05114_0", "Primary Key on CTRRTY, CTAN8, CTCMPC, CTSEQ", new[] { "CTRRTY", "CTAN8", "CTCMPC", "CTSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
