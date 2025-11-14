using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49141 - .
/// </summary>
public class F49141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWBN01.
        /// </summary>
        public const string PWBN01 = "PWBN01";

        /// <summary>
        /// PWMCUZ.
        /// </summary>
        public const string PWMCUZ = "PWMCUZ";

        /// <summary>
        /// PWDCCD.
        /// </summary>
        public const string PWDCCD = "PWDCCD";

        /// <summary>
        /// PWCTID.
        /// </summary>
        public const string PWCTID = "PWCTID";

        /// <summary>
        /// PWJOBS.
        /// </summary>
        public const string PWJOBS = "PWJOBS";

        /// <summary>
        /// PWSHPN.
        /// </summary>
        public const string PWSHPN = "PWSHPN";

        /// <summary>
        /// PWRSSN.
        /// </summary>
        public const string PWRSSN = "PWRSSN";

        /// <summary>
        /// PWORGN.
        /// </summary>
        public const string PWORGN = "PWORGN";

        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWSHAN.
        /// </summary>
        public const string PWSHAN = "PWSHAN";

        /// <summary>
        /// PWDOC.
        /// </summary>
        public const string PWDOC = "PWDOC";

        /// <summary>
        /// PWDCT.
        /// </summary>
        public const string PWDCT = "PWDCT";

        /// <summary>
        /// PWKCO.
        /// </summary>
        public const string PWKCO = "PWKCO";

        /// <summary>
        /// PWCO.
        /// </summary>
        public const string PWCO = "PWCO";

        /// <summary>
        /// PWEMCU.
        /// </summary>
        public const string PWEMCU = "PWEMCU";

        /// <summary>
        /// PWMCU.
        /// </summary>
        public const string PWMCU = "PWMCU";

        /// <summary>
        /// PWDTDO.
        /// </summary>
        public const string PWDTDO = "PWDTDO";

        /// <summary>
        /// PWDOCZ.
        /// </summary>
        public const string PWDOCZ = "PWDOCZ";

        /// <summary>
        /// PWITM.
        /// </summary>
        public const string PWITM = "PWITM";

        /// <summary>
        /// PWPLT.
        /// </summary>
        public const string PWPLT = "PWPLT";

        /// <summary>
        /// PWCNID.
        /// </summary>
        public const string PWCNID = "PWCNID";

        /// <summary>
        /// PWEQTY.
        /// </summary>
        public const string PWEQTY = "PWEQTY";

        /// <summary>
        /// PWGWEI.
        /// </summary>
        public const string PWGWEI = "PWGWEI";

        /// <summary>
        /// PWWTUM.
        /// </summary>
        public const string PWWTUM = "PWWTUM";

        /// <summary>
        /// PWDOCO.
        /// </summary>
        public const string PWDOCO = "PWDOCO";

        /// <summary>
        /// PWDCTO.
        /// </summary>
        public const string PWDCTO = "PWDCTO";

        /// <summary>
        /// PWKCOO.
        /// </summary>
        public const string PWKCOO = "PWKCOO";

        /// <summary>
        /// PWLNID.
        /// </summary>
        public const string PWLNID = "PWLNID";

        /// <summary>
        /// PWUPCN.
        /// </summary>
        public const string PWUPCN = "PWUPCN";

        /// <summary>
        /// PWUPQT.
        /// </summary>
        public const string PWUPQT = "PWUPQT";

        /// <summary>
        /// PWUPUM.
        /// </summary>
        public const string PWUPUM = "PWUPUM";

        /// <summary>
        /// PWNPCS.
        /// </summary>
        public const string PWNPCS = "PWNPCS";

        /// <summary>
        /// PWOSEQ.
        /// </summary>
        public const string PWOSEQ = "PWOSEQ";

        /// <summary>
        /// PWSEQ.
        /// </summary>
        public const string PWSEQ = "PWSEQ";

        /// <summary>
        /// PWURCD.
        /// </summary>
        public const string PWURCD = "PWURCD";

        /// <summary>
        /// PWURDT.
        /// </summary>
        public const string PWURDT = "PWURDT";

        /// <summary>
        /// PWURAT.
        /// </summary>
        public const string PWURAT = "PWURAT";

        /// <summary>
        /// PWURAB.
        /// </summary>
        public const string PWURAB = "PWURAB";

        /// <summary>
        /// PWURRF.
        /// </summary>
        public const string PWURRF = "PWURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F49141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWBN01", "PWBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("PWMCUZ", "PWMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("PWDCCD", "PWDCCD", JdeDataType.String, 8, true, true),
        new JdeField("PWCTID", "PWCTID", JdeDataType.String, 30),
        new JdeField("PWJOBS", "PWJOBS", JdeDataType.Numeric),
        new JdeField("PWSHPN", "PWSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("PWRSSN", "PWRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("PWORGN", "PWORGN", JdeDataType.Numeric),
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric),
        new JdeField("PWSHAN", "PWSHAN", JdeDataType.Numeric),
        new JdeField("PWDOC", "PWDOC", JdeDataType.Numeric),
        new JdeField("PWDCT", "PWDCT", JdeDataType.String, 4),
        new JdeField("PWKCO", "PWKCO", JdeDataType.String, 10),
        new JdeField("PWCO", "PWCO", JdeDataType.String, 10),
        new JdeField("PWEMCU", "PWEMCU", JdeDataType.String, 24),
        new JdeField("PWMCU", "PWMCU", JdeDataType.String, 24),
        new JdeField("PWDTDO", "PWDTDO", JdeDataType.Numeric),
        new JdeField("PWDOCZ", "PWDOCZ", JdeDataType.Numeric),
        new JdeField("PWITM", "PWITM", JdeDataType.Numeric),
        new JdeField("PWPLT", "PWPLT", JdeDataType.String, 36),
        new JdeField("PWCNID", "PWCNID", JdeDataType.String, 40),
        new JdeField("PWEQTY", "PWEQTY", JdeDataType.String, 10),
        new JdeField("PWGWEI", "PWGWEI", JdeDataType.Numeric),
        new JdeField("PWWTUM", "PWWTUM", JdeDataType.String, 4),
        new JdeField("PWDOCO", "PWDOCO", JdeDataType.Numeric),
        new JdeField("PWDCTO", "PWDCTO", JdeDataType.String, 4),
        new JdeField("PWKCOO", "PWKCOO", JdeDataType.String, 10),
        new JdeField("PWLNID", "PWLNID", JdeDataType.Numeric),
        new JdeField("PWUPCN", "PWUPCN", JdeDataType.String, 26),
        new JdeField("PWUPQT", "PWUPQT", JdeDataType.Numeric),
        new JdeField("PWUPUM", "PWUPUM", JdeDataType.String, 4),
        new JdeField("PWNPCS", "PWNPCS", JdeDataType.Numeric),
        new JdeField("PWOSEQ", "PWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PWSEQ", "PWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PWURCD", "PWURCD", JdeDataType.String, 4),
        new JdeField("PWURDT", "PWURDT", JdeDataType.Numeric),
        new JdeField("PWURAT", "PWURAT", JdeDataType.Numeric),
        new JdeField("PWURAB", "PWURAB", JdeDataType.Numeric),
        new JdeField("PWURRF", "PWURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49141_0", "Primary Key on PWBN01, PWMCUZ, PWDCCD, PWSHPN, PWRSSN, PWOSEQ, PWSEQ", new[] { "PWBN01", "PWMCUZ", "PWDCCD", "PWSHPN", "PWRSSN", "PWOSEQ", "PWSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
