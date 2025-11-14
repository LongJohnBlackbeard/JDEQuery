using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E20 - .
/// </summary>
public class F43E20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCLNID.
        /// </summary>
        public const string SCLNID = "SCLNID";

        /// <summary>
        /// SCITM.
        /// </summary>
        public const string SCITM = "SCITM";

        /// <summary>
        /// SCITEMDES.
        /// </summary>
        public const string SCITEMDES = "SCITEMDES";

        /// <summary>
        /// SCSCITTY.
        /// </summary>
        public const string SCSCITTY = "SCSCITTY";

        /// <summary>
        /// SCCMDCDE.
        /// </summary>
        public const string SCCMDCDE = "SCCMDCDE";

        /// <summary>
        /// SCCMDSUP.
        /// </summary>
        public const string SCCMDSUP = "SCCMDSUP";

        /// <summary>
        /// SCQTY.
        /// </summary>
        public const string SCQTY = "SCQTY";

        /// <summary>
        /// SCUOM.
        /// </summary>
        public const string SCUOM = "SCUOM";

        /// <summary>
        /// SCPRRC.
        /// </summary>
        public const string SCPRRC = "SCPRRC";

        /// <summary>
        /// SCAEXP.
        /// </summary>
        public const string SCAEXP = "SCAEXP";

        /// <summary>
        /// SCCRDC.
        /// </summary>
        public const string SCCRDC = "SCCRDC";

        /// <summary>
        /// SCFRRC.
        /// </summary>
        public const string SCFRRC = "SCFRRC";

        /// <summary>
        /// SCFEA.
        /// </summary>
        public const string SCFEA = "SCFEA";

        /// <summary>
        /// SCCCD0.
        /// </summary>
        public const string SCCCD0 = "SCCCD0";

        /// <summary>
        /// SCAN8V.
        /// </summary>
        public const string SCAN8V = "SCAN8V";

        /// <summary>
        /// SCUNSPSC.
        /// </summary>
        public const string SCUNSPSC = "SCUNSPSC";

        /// <summary>
        /// SCMOFLAG.
        /// </summary>
        public const string SCMOFLAG = "SCMOFLAG";

        /// <summary>
        /// SCATXA.
        /// </summary>
        public const string SCATXA = "SCATXA";

        /// <summary>
        /// SCSTAM.
        /// </summary>
        public const string SCSTAM = "SCSTAM";

        /// <summary>
        /// SCTAXA.
        /// </summary>
        public const string SCTAXA = "SCTAXA";

        /// <summary>
        /// SCEXR1.
        /// </summary>
        public const string SCEXR1 = "SCEXR1";

        /// <summary>
        /// SCTXR1.
        /// </summary>
        public const string SCTXR1 = "SCTXR1";

        /// <summary>
        /// SCSCAMT.
        /// </summary>
        public const string SCSCAMT = "SCSCAMT";

        /// <summary>
        /// SCSCDESC.
        /// </summary>
        public const string SCSCDESC = "SCSCDESC";

        /// <summary>
        /// SCPRODNM.
        /// </summary>
        public const string SCPRODNM = "SCPRODNM";

        /// <summary>
        /// SCMGFNAME.
        /// </summary>
        public const string SCMGFNAME = "SCMGFNAME";

        /// <summary>
        /// SCMGFID.
        /// </summary>
        public const string SCMGFID = "SCMGFID";

        /// <summary>
        /// SCSUPITMID.
        /// </summary>
        public const string SCSUPITMID = "SCSUPITMID";

        /// <summary>
        /// SCITMAUXID.
        /// </summary>
        public const string SCITMAUXID = "SCITMAUXID";

        /// <summary>
        /// SCITEMURL.
        /// </summary>
        public const string SCITEMURL = "SCITEMURL";

        /// <summary>
        /// SCLNG.
        /// </summary>
        public const string SCLNG = "SCLNG";

        /// <summary>
        /// SCNRCC.
        /// </summary>
        public const string SCNRCC = "SCNRCC";

        /// <summary>
        /// SCCNDJ.
        /// </summary>
        public const string SCCNDJ = "SCCNDJ";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCCOOKIE.
        /// </summary>
        public const string SCCOOKIE = "SCCOOKIE";
    }

    /// <inheritdoc />
    public override string TableName => "F43E20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20, true, true),
        new JdeField("SCLNID", "SCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCITM", "SCITM", JdeDataType.Numeric),
        new JdeField("SCITEMDES", "SCITEMDES", JdeDataType.String, 60),
        new JdeField("SCSCITTY", "SCSCITTY", JdeDataType.String, 2),
        new JdeField("SCCMDCDE", "SCCMDCDE", JdeDataType.String, 30),
        new JdeField("SCCMDSUP", "SCCMDSUP", JdeDataType.String, 60),
        new JdeField("SCQTY", "SCQTY", JdeDataType.Numeric),
        new JdeField("SCUOM", "SCUOM", JdeDataType.String, 4),
        new JdeField("SCPRRC", "SCPRRC", JdeDataType.Numeric),
        new JdeField("SCAEXP", "SCAEXP", JdeDataType.Numeric),
        new JdeField("SCCRDC", "SCCRDC", JdeDataType.String, 6),
        new JdeField("SCFRRC", "SCFRRC", JdeDataType.Numeric),
        new JdeField("SCFEA", "SCFEA", JdeDataType.Numeric),
        new JdeField("SCCCD0", "SCCCD0", JdeDataType.String, 6),
        new JdeField("SCAN8V", "SCAN8V", JdeDataType.Numeric),
        new JdeField("SCUNSPSC", "SCUNSPSC", JdeDataType.String, 16),
        new JdeField("SCMOFLAG", "SCMOFLAG", JdeDataType.String, 2),
        new JdeField("SCATXA", "SCATXA", JdeDataType.Numeric),
        new JdeField("SCSTAM", "SCSTAM", JdeDataType.Numeric),
        new JdeField("SCTAXA", "SCTAXA", JdeDataType.String, 60),
        new JdeField("SCEXR1", "SCEXR1", JdeDataType.String, 4),
        new JdeField("SCTXR1", "SCTXR1", JdeDataType.Numeric),
        new JdeField("SCSCAMT", "SCSCAMT", JdeDataType.Numeric),
        new JdeField("SCSCDESC", "SCSCDESC", JdeDataType.String, 60),
        new JdeField("SCPRODNM", "SCPRODNM", JdeDataType.String, 100),
        new JdeField("SCMGFNAME", "SCMGFNAME", JdeDataType.String, 60),
        new JdeField("SCMGFID", "SCMGFID", JdeDataType.String, 60),
        new JdeField("SCSUPITMID", "SCSUPITMID", JdeDataType.String, 60),
        new JdeField("SCITMAUXID", "SCITMAUXID", JdeDataType.String, 100),
        new JdeField("SCITEMURL", "SCITEMURL", JdeDataType.String),
        new JdeField("SCLNG", "SCLNG", JdeDataType.String, 6),
        new JdeField("SCNRCC", "SCNRCC", JdeDataType.String, 6),
        new JdeField("SCCNDJ", "SCCNDJ", JdeDataType.Numeric),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCCOOKIE", "SCCOOKIE", JdeDataType.String, 400)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E20_0", "Primary Key on SCUSER, SCLNID", new[] { "SCUSER", "SCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
