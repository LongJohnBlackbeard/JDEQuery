using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74YUI03 - .
/// </summary>
public class F74YUI03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFSFXE.
        /// </summary>
        public const string WFSFXE = "WFSFXE";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFPYE.
        /// </summary>
        public const string WFPYE = "WFPYE";

        /// <summary>
        /// WFDIVJ.
        /// </summary>
        public const string WFDIVJ = "WFDIVJ";

        /// <summary>
        /// WFDSVJ.
        /// </summary>
        public const string WFDSVJ = "WFDSVJ";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

        /// <summary>
        /// WFTRDJ.
        /// </summary>
        public const string WFTRDJ = "WFTRDJ";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFAAP.
        /// </summary>
        public const string WFAAP = "WFAAP";

        /// <summary>
        /// WFADSC.
        /// </summary>
        public const string WFADSC = "WFADSC";

        /// <summary>
        /// WFADSA.
        /// </summary>
        public const string WFADSA = "WFADSA";

        /// <summary>
        /// WFATXA.
        /// </summary>
        public const string WFATXA = "WFATXA";

        /// <summary>
        /// WFATXN.
        /// </summary>
        public const string WFATXN = "WFATXN";

        /// <summary>
        /// WFSTAM.
        /// </summary>
        public const string WFSTAM = "WFSTAM";

        /// <summary>
        /// WFTXA1.
        /// </summary>
        public const string WFTXA1 = "WFTXA1";

        /// <summary>
        /// WFEXR1.
        /// </summary>
        public const string WFEXR1 = "WFEXR1";

        /// <summary>
        /// WFAEXP.
        /// </summary>
        public const string WFAEXP = "WFAEXP";

        /// <summary>
        /// WFTXR1.
        /// </summary>
        public const string WFTXR1 = "WFTXR1";

        /// <summary>
        /// WFCRRM.
        /// </summary>
        public const string WFCRRM = "WFCRRM";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFCRR.
        /// </summary>
        public const string WFCRR = "WFCRR";

        /// <summary>
        /// WFACR.
        /// </summary>
        public const string WFACR = "WFACR";

        /// <summary>
        /// WFFAP.
        /// </summary>
        public const string WFFAP = "WFFAP";

        /// <summary>
        /// WFCDS.
        /// </summary>
        public const string WFCDS = "WFCDS";

        /// <summary>
        /// WFCDSA.
        /// </summary>
        public const string WFCDSA = "WFCDSA";

        /// <summary>
        /// WFCTXA.
        /// </summary>
        public const string WFCTXA = "WFCTXA";

        /// <summary>
        /// WFCTXN.
        /// </summary>
        public const string WFCTXN = "WFCTXN";

        /// <summary>
        /// WFCTAM.
        /// </summary>
        public const string WFCTAM = "WFCTAM";

        /// <summary>
        /// WFBCRC.
        /// </summary>
        public const string WFBCRC = "WFBCRC";

        /// <summary>
        /// WFPKCO.
        /// </summary>
        public const string WFPKCO = "WFPKCO";

        /// <summary>
        /// WFPO.
        /// </summary>
        public const string WFPO = "WFPO";

        /// <summary>
        /// WFPDCT.
        /// </summary>
        public const string WFPDCT = "WFPDCT";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFRMK.
        /// </summary>
        public const string WFRMK = "WFRMK";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74YUI03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6, true, true),
        new JdeField("WFSFXE", "WFSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFPYE", "WFPYE", JdeDataType.Numeric),
        new JdeField("WFDIVJ", "WFDIVJ", JdeDataType.Numeric),
        new JdeField("WFDSVJ", "WFDSVJ", JdeDataType.Numeric),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFTRDJ", "WFTRDJ", JdeDataType.Numeric),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFAAP", "WFAAP", JdeDataType.Numeric),
        new JdeField("WFADSC", "WFADSC", JdeDataType.Numeric),
        new JdeField("WFADSA", "WFADSA", JdeDataType.Numeric),
        new JdeField("WFATXA", "WFATXA", JdeDataType.Numeric),
        new JdeField("WFATXN", "WFATXN", JdeDataType.Numeric),
        new JdeField("WFSTAM", "WFSTAM", JdeDataType.Numeric),
        new JdeField("WFTXA1", "WFTXA1", JdeDataType.String, 20),
        new JdeField("WFEXR1", "WFEXR1", JdeDataType.String, 4),
        new JdeField("WFAEXP", "WFAEXP", JdeDataType.Numeric),
        new JdeField("WFTXR1", "WFTXR1", JdeDataType.Numeric),
        new JdeField("WFCRRM", "WFCRRM", JdeDataType.String, 2),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFCRR", "WFCRR", JdeDataType.Numeric),
        new JdeField("WFACR", "WFACR", JdeDataType.Numeric),
        new JdeField("WFFAP", "WFFAP", JdeDataType.Numeric),
        new JdeField("WFCDS", "WFCDS", JdeDataType.Numeric),
        new JdeField("WFCDSA", "WFCDSA", JdeDataType.Numeric),
        new JdeField("WFCTXA", "WFCTXA", JdeDataType.Numeric),
        new JdeField("WFCTXN", "WFCTXN", JdeDataType.Numeric),
        new JdeField("WFCTAM", "WFCTAM", JdeDataType.Numeric),
        new JdeField("WFBCRC", "WFBCRC", JdeDataType.String, 6),
        new JdeField("WFPKCO", "WFPKCO", JdeDataType.String, 10),
        new JdeField("WFPO", "WFPO", JdeDataType.String, 16),
        new JdeField("WFPDCT", "WFPDCT", JdeDataType.String, 4),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric),
        new JdeField("WFRMK", "WFRMK", JdeDataType.String, 60),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74YUI03_0", "Primary Key on WFDOC, WFDCT, WFKCO, WFSFX, WFSFXE, WFJOBS", new[] { "WFDOC", "WFDCT", "WFKCO", "WFSFX", "WFSFXE", "WFJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
