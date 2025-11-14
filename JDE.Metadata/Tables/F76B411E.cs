using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B411E - .
/// </summary>
public class F76B411E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDBRNFK.
        /// </summary>
        public const string SDBRNFK = "SDBRNFK";

        /// <summary>
        /// SDFCO.
        /// </summary>
        public const string SDFCO = "SDFCO";

        /// <summary>
        /// SDN001.
        /// </summary>
        public const string SDN001 = "SDN001";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDBRMD.
        /// </summary>
        public const string SDBRMD = "SDBRMD";

        /// <summary>
        /// SDBSER.
        /// </summary>
        public const string SDBSER = "SDBSER";

        /// <summary>
        /// SDBNNF.
        /// </summary>
        public const string SDBNNF = "SDBNNF";

        /// <summary>
        /// SDBRNFDE.
        /// </summary>
        public const string SDBRNFDE = "SDBRNFDE";

        /// <summary>
        /// SDBSFH.
        /// </summary>
        public const string SDBSFH = "SDBSFH";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDLITM.
        /// </summary>
        public const string SDLITM = "SDLITM";

        /// <summary>
        /// SDBRD60.
        /// </summary>
        public const string SDBRD60 = "SDBRD60";

        /// <summary>
        /// SDBRTN5.
        /// </summary>
        public const string SDBRTN5 = "SDBRTN5";

        /// <summary>
        /// SDBRNO.
        /// </summary>
        public const string SDBRNO = "SDBRNO";

        /// <summary>
        /// SDBCLF.
        /// </summary>
        public const string SDBCLF = "SDBCLF";

        /// <summary>
        /// SDUORG.
        /// </summary>
        public const string SDUORG = "SDUORG";

        /// <summary>
        /// SDUOM.
        /// </summary>
        public const string SDUOM = "SDUOM";

        /// <summary>
        /// SDPRIC.
        /// </summary>
        public const string SDPRIC = "SDPRIC";

        /// <summary>
        /// SDAEXP.
        /// </summary>
        public const string SDAEXP = "SDAEXP";

        /// <summary>
        /// SDBDES.
        /// </summary>
        public const string SDBDES = "SDBDES";

        /// <summary>
        /// SDBRIPI.
        /// </summary>
        public const string SDBRIPI = "SDBRIPI";

        /// <summary>
        /// SDBRXIPI.
        /// </summary>
        public const string SDBRXIPI = "SDBRXIPI";

        /// <summary>
        /// SDBBTP.
        /// </summary>
        public const string SDBBTP = "SDBBTP";

        /// <summary>
        /// SDBIPI.
        /// </summary>
        public const string SDBIPI = "SDBIPI";

        /// <summary>
        /// SDBST2.
        /// </summary>
        public const string SDBST2 = "SDBST2";

        /// <summary>
        /// SDBRICMS.
        /// </summary>
        public const string SDBRICMS = "SDBRICMS";

        /// <summary>
        /// SDBRXICMS.
        /// </summary>
        public const string SDBRXICMS = "SDBRXICMS";

        /// <summary>
        /// SDBBCL.
        /// </summary>
        public const string SDBBCL = "SDBBCL";

        /// <summary>
        /// SDBRAICMS.
        /// </summary>
        public const string SDBRAICMS = "SDBRAICMS";

        /// <summary>
        /// SDBBIS.
        /// </summary>
        public const string SDBBIS = "SDBBIS";

        /// <summary>
        /// SDBVIS.
        /// </summary>
        public const string SDBVIS = "SDBVIS";

        /// <summary>
        /// SDBRMM.
        /// </summary>
        public const string SDBRMM = "SDBRMM";

        /// <summary>
        /// SDRDOR.
        /// </summary>
        public const string SDRDOR = "SDRDOR";

        /// <summary>
        /// SDC1FU.
        /// </summary>
        public const string SDC1FU = "SDC1FU";

        /// <summary>
        /// SDC2FU.
        /// </summary>
        public const string SDC2FU = "SDC2FU";

        /// <summary>
        /// SDD1FU.
        /// </summary>
        public const string SDD1FU = "SDD1FU";

        /// <summary>
        /// SDD2FU.
        /// </summary>
        public const string SDD2FU = "SDD2FU";

        /// <summary>
        /// SDN1FU.
        /// </summary>
        public const string SDN1FU = "SDN1FU";

        /// <summary>
        /// SDN2FU.
        /// </summary>
        public const string SDN2FU = "SDN2FU";

        /// <summary>
        /// SDN3FU.
        /// </summary>
        public const string SDN3FU = "SDN3FU";

        /// <summary>
        /// SDN4FU.
        /// </summary>
        public const string SDN4FU = "SDN4FU";

        /// <summary>
        /// SDN5FU.
        /// </summary>
        public const string SDN5FU = "SDN5FU";

        /// <summary>
        /// SDN6FU.
        /// </summary>
        public const string SDN6FU = "SDN6FU";

        /// <summary>
        /// SDN7FU.
        /// </summary>
        public const string SDN7FU = "SDN7FU";

        /// <summary>
        /// SDS1FU.
        /// </summary>
        public const string SDS1FU = "SDS1FU";

        /// <summary>
        /// SDS2FU.
        /// </summary>
        public const string SDS2FU = "SDS2FU";

        /// <summary>
        /// SDS3FU.
        /// </summary>
        public const string SDS3FU = "SDS3FU";

        /// <summary>
        /// SDS4FU.
        /// </summary>
        public const string SDS4FU = "SDS4FU";

        /// <summary>
        /// SDGENLNG.
        /// </summary>
        public const string SDGENLNG = "SDGENLNG";

        /// <summary>
        /// SDTORG.
        /// </summary>
        public const string SDTORG = "SDTORG";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B411E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDBRNFK", "SDBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("SDFCO", "SDFCO", JdeDataType.String, 10),
        new JdeField("SDN001", "SDN001", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDBRMD", "SDBRMD", JdeDataType.String, 4),
        new JdeField("SDBSER", "SDBSER", JdeDataType.String, 4),
        new JdeField("SDBNNF", "SDBNNF", JdeDataType.Numeric),
        new JdeField("SDBRNFDE", "SDBRNFDE", JdeDataType.Numeric),
        new JdeField("SDBSFH", "SDBSFH", JdeDataType.Numeric),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLITM", "SDLITM", JdeDataType.String, 50),
        new JdeField("SDBRD60", "SDBRD60", JdeDataType.String, 120),
        new JdeField("SDBRTN5", "SDBRTN5", JdeDataType.String, 10),
        new JdeField("SDBRNO", "SDBRNO", JdeDataType.String, 12),
        new JdeField("SDBCLF", "SDBCLF", JdeDataType.String, 20),
        new JdeField("SDUORG", "SDUORG", JdeDataType.Numeric),
        new JdeField("SDUOM", "SDUOM", JdeDataType.String, 4),
        new JdeField("SDPRIC", "SDPRIC", JdeDataType.Numeric),
        new JdeField("SDAEXP", "SDAEXP", JdeDataType.Numeric),
        new JdeField("SDBDES", "SDBDES", JdeDataType.Numeric),
        new JdeField("SDBRIPI", "SDBRIPI", JdeDataType.String, 2),
        new JdeField("SDBRXIPI", "SDBRXIPI", JdeDataType.Numeric),
        new JdeField("SDBBTP", "SDBBTP", JdeDataType.Numeric),
        new JdeField("SDBIPI", "SDBIPI", JdeDataType.Numeric),
        new JdeField("SDBST2", "SDBST2", JdeDataType.String, 6),
        new JdeField("SDBRICMS", "SDBRICMS", JdeDataType.String, 2),
        new JdeField("SDBRXICMS", "SDBRXICMS", JdeDataType.Numeric),
        new JdeField("SDBBCL", "SDBBCL", JdeDataType.Numeric),
        new JdeField("SDBRAICMS", "SDBRAICMS", JdeDataType.Numeric),
        new JdeField("SDBBIS", "SDBBIS", JdeDataType.Numeric),
        new JdeField("SDBVIS", "SDBVIS", JdeDataType.Numeric),
        new JdeField("SDBRMM", "SDBRMM", JdeDataType.String, 2),
        new JdeField("SDRDOR", "SDRDOR", JdeDataType.String, 2),
        new JdeField("SDC1FU", "SDC1FU", JdeDataType.String, 2),
        new JdeField("SDC2FU", "SDC2FU", JdeDataType.String, 2),
        new JdeField("SDD1FU", "SDD1FU", JdeDataType.Numeric),
        new JdeField("SDD2FU", "SDD2FU", JdeDataType.Numeric),
        new JdeField("SDN1FU", "SDN1FU", JdeDataType.Numeric),
        new JdeField("SDN2FU", "SDN2FU", JdeDataType.Numeric),
        new JdeField("SDN3FU", "SDN3FU", JdeDataType.Numeric),
        new JdeField("SDN4FU", "SDN4FU", JdeDataType.Numeric),
        new JdeField("SDN5FU", "SDN5FU", JdeDataType.Numeric),
        new JdeField("SDN6FU", "SDN6FU", JdeDataType.Numeric),
        new JdeField("SDN7FU", "SDN7FU", JdeDataType.Numeric),
        new JdeField("SDS1FU", "SDS1FU", JdeDataType.String, 60),
        new JdeField("SDS2FU", "SDS2FU", JdeDataType.String, 60),
        new JdeField("SDS3FU", "SDS3FU", JdeDataType.String, 6),
        new JdeField("SDS4FU", "SDS4FU", JdeDataType.String, 6),
        new JdeField("SDGENLNG", "SDGENLNG", JdeDataType.Numeric),
        new JdeField("SDTORG", "SDTORG", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B411E_0", "Primary Key on SDBRNFK, SDLNID", new[] { "SDBRNFK", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
