using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06053 - .
/// </summary>
public class F06053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWAN8.
        /// </summary>
        public const string YWAN8 = "YWAN8";

        /// <summary>
        /// YWDOCM.
        /// </summary>
        public const string YWDOCM = "YWDOCM";

        /// <summary>
        /// YWCKD.
        /// </summary>
        public const string YWCKD = "YWCKD";

        /// <summary>
        /// YWRXP.
        /// </summary>
        public const string YWRXP = "YWRXP";

        /// <summary>
        /// YWBCB.
        /// </summary>
        public const string YWBCB = "YWBCB";

        /// <summary>
        /// YWAAF.
        /// </summary>
        public const string YWAAF = "YWAAF";

        /// <summary>
        /// YWNPAY.
        /// </summary>
        public const string YWNPAY = "YWNPAY";

        /// <summary>
        /// YWTFCT.
        /// </summary>
        public const string YWTFCT = "YWTFCT";

        /// <summary>
        /// YWDT.
        /// </summary>
        public const string YWDT = "YWDT";

        /// <summary>
        /// YWTRS.
        /// </summary>
        public const string YWTRS = "YWTRS";

        /// <summary>
        /// YWINC.
        /// </summary>
        public const string YWINC = "YWINC";

        /// <summary>
        /// YWCHNG.
        /// </summary>
        public const string YWCHNG = "YWCHNG";

        /// <summary>
        /// YWCKCN.
        /// </summary>
        public const string YWCKCN = "YWCKCN";

        /// <summary>
        /// YWGLBA.
        /// </summary>
        public const string YWGLBA = "YWGLBA";

        /// <summary>
        /// YWPAST.
        /// </summary>
        public const string YWPAST = "YWPAST";

        /// <summary>
        /// YWADV$.
        /// </summary>
        public const string YWADV_ = "YWADV$";

        /// <summary>
        /// YWADV.
        /// </summary>
        public const string YWADV = "YWADV";

        /// <summary>
        /// YWTIPE.
        /// </summary>
        public const string YWTIPE = "YWTIPE";

        /// <summary>
        /// YWDAAF.
        /// </summary>
        public const string YWDAAF = "YWDAAF";

        /// <summary>
        /// YWROEF.
        /// </summary>
        public const string YWROEF = "YWROEF";

        /// <summary>
        /// YWENTF.
        /// </summary>
        public const string YWENTF = "YWENTF";

        /// <summary>
        /// YWEFTB.
        /// </summary>
        public const string YWEFTB = "YWEFTB";

        /// <summary>
        /// YWEFTE.
        /// </summary>
        public const string YWEFTE = "YWEFTE";

        /// <summary>
        /// YWPCKN.
        /// </summary>
        public const string YWPCKN = "YWPCKN";

        /// <summary>
        /// YWICS.
        /// </summary>
        public const string YWICS = "YWICS";

        /// <summary>
        /// YWFUST.
        /// </summary>
        public const string YWFUST = "YWFUST";

        /// <summary>
        /// YWICU.
        /// </summary>
        public const string YWICU = "YWICU";

        /// <summary>
        /// YWCKST.
        /// </summary>
        public const string YWCKST = "YWCKST";

        /// <summary>
        /// YWTHTY.
        /// </summary>
        public const string YWTHTY = "YWTHTY";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWARYN.
        /// </summary>
        public const string YWARYN = "YWARYN";

        /// <summary>
        /// YWADF.
        /// </summary>
        public const string YWADF = "YWADF";

        /// <summary>
        /// YWOVTX.
        /// </summary>
        public const string YWOVTX = "YWOVTX";

        /// <summary>
        /// YWCO.
        /// </summary>
        public const string YWCO = "YWCO";
    }

    /// <inheritdoc />
    public override string TableName => "F06053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWAN8", "YWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YWDOCM", "YWDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("YWCKD", "YWCKD", JdeDataType.Numeric),
        new JdeField("YWRXP", "YWRXP", JdeDataType.Numeric),
        new JdeField("YWBCB", "YWBCB", JdeDataType.Numeric),
        new JdeField("YWAAF", "YWAAF", JdeDataType.String, 2),
        new JdeField("YWNPAY", "YWNPAY", JdeDataType.Numeric),
        new JdeField("YWTFCT", "YWTFCT", JdeDataType.Numeric),
        new JdeField("YWDT", "YWDT", JdeDataType.Numeric),
        new JdeField("YWTRS", "YWTRS", JdeDataType.String, 6),
        new JdeField("YWINC", "YWINC", JdeDataType.String, 2),
        new JdeField("YWCHNG", "YWCHNG", JdeDataType.String, 2),
        new JdeField("YWCKCN", "YWCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YWGLBA", "YWGLBA", JdeDataType.String, 16),
        new JdeField("YWPAST", "YWPAST", JdeDataType.String, 2),
        new JdeField("YWADV$", "YWADV$", JdeDataType.Numeric),
        new JdeField("YWADV", "YWADV", JdeDataType.String, 2),
        new JdeField("YWTIPE", "YWTIPE", JdeDataType.String, 2),
        new JdeField("YWDAAF", "YWDAAF", JdeDataType.String, 2),
        new JdeField("YWROEF", "YWROEF", JdeDataType.String, 2),
        new JdeField("YWENTF", "YWENTF", JdeDataType.String, 2),
        new JdeField("YWEFTB", "YWEFTB", JdeDataType.Numeric),
        new JdeField("YWEFTE", "YWEFTE", JdeDataType.Numeric),
        new JdeField("YWPCKN", "YWPCKN", JdeDataType.Numeric),
        new JdeField("YWICS", "YWICS", JdeDataType.String, 2),
        new JdeField("YWFUST", "YWFUST", JdeDataType.String, 2),
        new JdeField("YWICU", "YWICU", JdeDataType.Numeric),
        new JdeField("YWCKST", "YWCKST", JdeDataType.String, 2),
        new JdeField("YWTHTY", "YWTHTY", JdeDataType.String, 2),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWARYN", "YWARYN", JdeDataType.String, 2),
        new JdeField("YWADF", "YWADF", JdeDataType.String, 2),
        new JdeField("YWOVTX", "YWOVTX", JdeDataType.String, 2),
        new JdeField("YWCO", "YWCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06053_0", "Primary Key on YWAN8, YWCKCN, YWDOCM", new[] { "YWAN8", "YWCKCN", "YWDOCM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06053_2", "Index on YWAN8, YWPCKN, YWCKCN", new[] { "YWAN8", "YWPCKN", "YWCKCN" })
    };
}
