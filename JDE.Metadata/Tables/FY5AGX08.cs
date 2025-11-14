using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AGX08 - .
/// </summary>
public class FY5AGX08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIRLS.
        /// </summary>
        public const string DIRLS = "DIRLS";

        /// <summary>
        /// DIY5AGENVN.
        /// </summary>
        public const string DIY5AGENVN = "DIY5AGENVN";

        /// <summary>
        /// DIY5AGGKEY.
        /// </summary>
        public const string DIY5AGGKEY = "DIY5AGGKEY";

        /// <summary>
        /// DIY5AGDSEQ.
        /// </summary>
        public const string DIY5AGDSEQ = "DIY5AGDSEQ";

        /// <summary>
        /// DIY5AGDTSB.
        /// </summary>
        public const string DIY5AGDTSB = "DIY5AGDTSB";

        /// <summary>
        /// DIY5AGTMSB.
        /// </summary>
        public const string DIY5AGTMSB = "DIY5AGTMSB";

        /// <summary>
        /// DIY5AGDTFN.
        /// </summary>
        public const string DIY5AGDTFN = "DIY5AGDTFN";

        /// <summary>
        /// DIY5AGTMFN.
        /// </summary>
        public const string DIY5AGTMFN = "DIY5AGTMFN";

        /// <summary>
        /// DIY5AGUKID.
        /// </summary>
        public const string DIY5AGUKID = "DIY5AGUKID";

        /// <summary>
        /// DIY5AGNNTY.
        /// </summary>
        public const string DIY5AGNNTY = "DIY5AGNNTY";

        /// <summary>
        /// DIY5AGBDT.
        /// </summary>
        public const string DIY5AGBDT = "DIY5AGBDT";

        /// <summary>
        /// DIY5AGPC.
        /// </summary>
        public const string DIY5AGPC = "DIY5AGPC";

        /// <summary>
        /// DIY5AGBFLG.
        /// </summary>
        public const string DIY5AGBFLG = "DIY5AGBFLG";

        /// <summary>
        /// DIY5AGFBDT.
        /// </summary>
        public const string DIY5AGFBDT = "DIY5AGFBDT";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIY5AGGUID.
        /// </summary>
        public const string DIY5AGGUID = "DIY5AGGUID";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AGX08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIRLS", "DIRLS", JdeDataType.String, 20, true, true),
        new JdeField("DIY5AGENVN", "DIY5AGENVN", JdeDataType.String, 20, true, true),
        new JdeField("DIY5AGGKEY", "DIY5AGGKEY", JdeDataType.String, 40, true, true),
        new JdeField("DIY5AGDSEQ", "DIY5AGDSEQ", JdeDataType.Numeric),
        new JdeField("DIY5AGDTSB", "DIY5AGDTSB", JdeDataType.Numeric),
        new JdeField("DIY5AGTMSB", "DIY5AGTMSB", JdeDataType.Numeric),
        new JdeField("DIY5AGDTFN", "DIY5AGDTFN", JdeDataType.Numeric),
        new JdeField("DIY5AGTMFN", "DIY5AGTMFN", JdeDataType.Numeric),
        new JdeField("DIY5AGUKID", "DIY5AGUKID", JdeDataType.Numeric),
        new JdeField("DIY5AGNNTY", "DIY5AGNNTY", JdeDataType.String, 6),
        new JdeField("DIY5AGBDT", "DIY5AGBDT", JdeDataType.Numeric),
        new JdeField("DIY5AGPC", "DIY5AGPC", JdeDataType.Numeric),
        new JdeField("DIY5AGBFLG", "DIY5AGBFLG", JdeDataType.String, 2),
        new JdeField("DIY5AGFBDT", "DIY5AGFBDT", JdeDataType.Numeric),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIY5AGGUID", "DIY5AGGUID", JdeDataType.String, 72)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AGX08_0", "Primary Key on DIRLS, DIY5AGENVN, DIY5AGGKEY", new[] { "DIRLS", "DIY5AGENVN", "DIY5AGGKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
